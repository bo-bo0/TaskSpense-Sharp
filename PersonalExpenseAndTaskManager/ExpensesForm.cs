using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO.Packaging;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

namespace PersonalExpenseAndTaskManager
{
    public partial class ExpensesForm : Form
    {
        public static List<Expense> expenses = [];
        public static List<Task> tasks = [];

        public static string? appFolder = null;
        public static string? expensesFile = null;
        public static string? tasksFile = null;
        public static string localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //string contatining the path to the local folder of the user (%localappdata%)
        public ExpensesForm()
        {
            InitializeComponent();
            this.KeyPreview = true; // activate key preview to capture key events

            //initialize floder
            appFolder = Path.Combine(localPath, "TaskSpense Sharp");
            Directory.CreateDirectory(appFolder); // make sure the folder exists


            //create save files if not exist
            expensesFile = Path.Combine(appFolder, "Expenses.json");
            if (!File.Exists(expensesFile))
                File.WriteAllText(expensesFile, null);

            tasksFile = Path.Combine(appFolder, "Tasks.json");
            if (!File.Exists(tasksFile))
                File.WriteAllText(tasksFile, null);

                //initialize tab control (only a not working test for now)
                var tabExpenses = new UserControl();
            tabPageExpenses.Controls.Add(tabExpenses);

            var tabTasks = new UserControl();
            tabPageExpenses.Controls.Add(tabTasks);


            tabControl.SelectedIndex = 0;
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; //set fullscreen

            if (expensesFile != null) { FileActions.readJsonContent(expensesFile, expenses, dataGridExpenses); }
            if (tasksFile != null) { FileActions.readJsonContent(tasksFile, tasks, dataGridViewTasks); }

            //theme file
            if (appFolder != null)
            {
                var file_theme = Path.Combine(appFolder, "Theme.json");

                if (!File.Exists(file_theme))
                { Global.LightTheme = true; }

                else
                {
                    string? value = File.ReadAllText(file_theme);

                    if (value != null && !TextActions.spacesString(value))
                    {
                        var flag = value.Substring(15);

                        if (flag == "True" || flag == "False")
                        {
                            Global.LightTheme = Convert.ToBoolean(flag);
                            if (ActiveForm != null) { Global.UpdateTheme(ActiveForm); }
                        }
                    }
                }
            }
        }

        private void ExpensesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                WindowState = Graphics.screenSet(WindowState);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to exit?", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
                Close();
        }

        private void ExpensesForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                var fs = new MemoryStream(Properties.Resources.fulls);

                buttonScreen.Image = Image.FromStream(fs);
                buttonScreen2.Image = Image.FromStream(fs);
                buttonScreen3.Image = Image.FromStream(fs);
            }
            else
            {
                var ws = new MemoryStream(Properties.Resources.wins);

                buttonScreen.Image = Image.FromStream(ws);
                buttonScreen2.Image = Image.FromStream(ws);
                buttonScreen3.Image = Image.FromStream(ws);
            }

            panelRed.Size = new Size(Width, panelRed.Height); //resize panel red
            panelRed2.Size = new Size(Width, panelRed.Height); //resize panel red2
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            WindowState = Graphics.screenSet(WindowState);
        }

        private void buttonGeneric_Hover(object sender, EventArgs e)
        {
            Button? curr = sender as Button;

            if (curr != null) { curr.BackColor = Color.FromArgb(204, 153, 102); }
        }

        private void buttonGeneric_Leave(object sender, EventArgs e)
        {
            Button? curr = sender as Button;

            if (curr != null) { curr.BackColor = Color.FromArgb(255, 192, 128); }
        }

        private void labelPlus_Click(object sender, EventArgs e)
        {
            AddExpenseForm addForm = new AddExpenseForm();
            addForm.ShowDialog();

            comboBoxFilterCategory_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void dataGridExpenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var result = MessageBox.Show("Are you sure you want to delete this element?", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Global.AlreadyCartesian = false;

                dataGridExpenses.DataSource = null;

                if (TextActions.spacesString(comboBoxFilterCategory.Text))
                {
                    expenses.RemoveAt(e.RowIndex);
                    if (expenses.Count > 0) { dataGridExpenses.DataSource = expenses; }
                }
                else
                {
                    //correctly remove item from list if filters are applied
                    var currIndex = e.RowIndex;
                    int i = 0;
                    Expense? finalItem = null;
                    foreach (var item in expenses)
                    {
                        if (item.Category == comboBoxFilterCategory.Text)
                        {

                            if (e.RowIndex == i)
                            {

                                finalItem = item;
                                break;

                            }

                            i++;
                        }

                    }

                    if (finalItem != null) { expenses.Remove(finalItem); }

                    if (expenses.Count > 0) { comboBoxFilterCategory_SelectedIndexChanged(this, EventArgs.Empty); }
                }

                //update file
                if (expensesFile != null)
                {
                    File.WriteAllText(expensesFile, null);
                    var reverseExpenses = expenses.Reverse<Expense>().ToList();

                    foreach (var item in reverseExpenses)
                        FileActions.addJsonContent(item, expensesFile, expenses);
                }
            }

        }

        private void pictureBoxResetCategory_Click(object sender, EventArgs e)
        {
            comboBoxFilterCategory.Text = null;
            dataGridExpenses.DataSource = null;
            labelNoFilterResult.Visible = false;
            if (expenses.Count > 0) { dataGridExpenses.DataSource = expenses; }
        }

        private void comboBoxFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredExpenses = new List<Expense>();
            if (!TextActions.spacesString(comboBoxFilterCategory.Text))
            {
                labelNoFilterResult.Visible = false;

                foreach (var item in expenses)
                {
                    if (item.Category == comboBoxFilterCategory.Text)
                        filteredExpenses.Add(item);
                }
                if (filteredExpenses.Count != 0)
                {
                    dataGridExpenses.DataSource = null;
                    dataGridExpenses.DataSource = filteredExpenses;
                }
                else
                {
                    dataGridExpenses.DataSource = null;
                    labelNoFilterResult.Visible = true;
                }
            }
        }

        private void tabPageExpenses_Paint(object sender, PaintEventArgs e)
        {
            /* base.OnPaint(e);

             using (SolidBrush redBrush = new SolidBrush(Color.Firebrick))
             {
                 e.Graphics.FillRectangle(redBrush, 0, 0, tabPageExpenses.Width, 94);
             }*/
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
            Global.CurrentPage = "Tasks";
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            Global.CurrentPage = "Expenses";
        }

        private void labelPlus2_Click(object sender, EventArgs e)
        {
            var addTask = new AddTaskForm();
            addTask.ShowDialog();
        }

        private void pictureBoxResetSort_Click(object sender, EventArgs e)
        {
            labelNoSortResult.Visible = false;
            comboBoxSort.Text = null;
            if (tasks.Count > 0) { dataGridViewTasks.DataSource = tasks; return; }

            dataGridViewTasks.DataSource = null;
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sortedTasks = new List<Task>(tasks);

            dataGridViewTasks.DataSource = null;

            if (!TextActions.spacesString(comboBoxSort.Text)) { labelNoSortResult.Visible = true; }

            if (comboBoxSort.Text == "priority") { Sort.InsertionSortPriority(sortedTasks, dataGridViewTasks, labelNoSortResult, tasks); }

            if (comboBoxSort.Text == "deadline" && tasks.Count > 1) { Sort.InsertionSortDeadline(sortedTasks, dataGridViewTasks, labelNoSortResult, tasks); }

            else if (tasks.Count == 1)
            {

                if (!TextActions.spacesString(tasks[0].Deadline ?? " ")) { dataGridViewTasks.DataSource = tasks; labelNoSortResult.Visible = false; }
            }
        }

        private void dataGridViewTasks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            var result = MessageBox.Show("Are you sure you want to delete this element?", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (TextActions.spacesString(comboBoxSort.Text))
                {
                    tasks.RemoveAt(e.RowIndex);
                    dataGridViewTasks.DataSource = null;
                    if (tasks.Count() > 0) { dataGridViewTasks.DataSource = tasks; }
                }

                else //correctly remove item if elements are sorted
                {
                    var phList = new List<Task>(tasks);

                    if (comboBoxSort.Text == "priority")
                        Sort.InsertionSortPriority(phList, dataGridViewTasks, labelNoSortResult, tasks);

                    else //if == "deadline" 
                        Sort.InsertionSortDeadline(phList, dataGridViewTasks, labelNoSortResult, tasks);

                    foreach (var item in tasks)
                    {
                        if (item == phList[e.RowIndex])
                        {
                            tasks.Remove(item);
                            dataGridViewTasks.DataSource = null;
                            if (tasks.Count() > 0) { dataGridViewTasks.DataSource = tasks; }

                            break;
                        }
                    }
                }

                //update file
                if (tasksFile != null)
                {
                    File.WriteAllText(tasksFile, null);
                    var reverseTasks = tasks.Reverse<Task>().ToList();

                    foreach (var item in reverseTasks)
                        FileActions.addJsonContent(item, tasksFile, tasks);
                }
            }
        }

        private void dataGridViewTasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dataGridViewTasks.Visible = false;
                Global.FullDescriptionFlag = true;

                //description area
                string? current_description = $"{dataGridViewTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}";
                var DescriptionShower = new RichTextBox();
                DescriptionShower.Text = current_description;
                DescriptionShower.Location = new Point(223, 130);
                DescriptionShower.Size = new Size(240, 200);
                DescriptionShower.ReadOnly = true;
                DescriptionShower.Font = new Font("Arial", 12);
                panelGrid2.Controls.Add(DescriptionShower);

                //back button
                var BackButton = new Button();
                BackButton.Size = new Size(120, 40);
                BackButton.Location = new Point(223, 100);
                BackButton.Text = "Back";
                BackButton.Font = new Font("Arial", 10);
                BackButton.Cursor = Cursors.Hand;
                BackButton.Name = "BackButton";
                BackButton.Click += BackButton_Click;
                panelGrid2.Controls.Add(BackButton);
            }
        }

        private void BackButton_Click(object? sender, EventArgs e)
        {
            var button = sender as Button;

            if (button == null) { return; }

            if (button.Name == "BackButton")
            {

                panelGrid2.Controls.Remove(button);
                panelGrid2.Controls.Remove(panelGrid2.Controls.OfType<RichTextBox>().FirstOrDefault());

                dataGridViewTasks.Visible = true;
                Global.FullDescriptionFlag = false;
            }
        }

        private void buttonGraphics_Click(object sender, EventArgs e)
        {
            if (!Global.AlreadyCartesian)
            {
                var expensesValues = new List<double>();

                foreach (var item in expenses)
                    expensesValues.Add(Convert.ToDouble(item.Amount, CultureInfo.InvariantCulture));

                expensesValues.Reverse();

                var lineSeries = new LineSeries<double>
                {
                    Values = expensesValues,
                    Fill = null
                };

                cartesianChart1.Series = new ISeries[] { lineSeries };

                cartesianChart1.Update();

                Global.AlreadyCartesian = true;
            }
            buttonExOrTas.Text = Global.CurrentPage;

            tabControl.SelectedIndex = 2;
        }

        private void buttonGraphicsInGraphics_Click(object sender, EventArgs e)
        {
            var expensesValues = new List<double>();

            foreach (var item in expenses)
                expensesValues.Add(Convert.ToDouble(item.Amount));

            expensesValues.Reverse();

            var lineSeries = new LineSeries<double>
            {
                Values = expensesValues,
                Fill = null
            };

            cartesianChart1.Series = new ISeries[] { lineSeries };

            cartesianChart1.Update();
        }

        private void buttonExOrTas_Click(object sender, EventArgs e)
        {
            if (Global.CurrentPage == "Expenses") { tabControl.SelectedIndex = 0; }
            else if (Global.CurrentPage == "Tasks") { tabControl.SelectedIndex = 1; }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.ShowDialog();
        }
    }
    public abstract class Sort
    {
        public static void InsertionSortPriority(List<Task> sortedTasks, DataGridView dataGridViewTasks, Label labelNoSortResult, List<Task> tasks)
        {
            bool flag = false;

            //insertion sort
            int item = 0;
            for (int j = 1; j < sortedTasks.Count(); j++)
            {
                item = j;

                for (int i = j - 1; i >= 0; i--)
                {
                    //empty priority fix

                    if (sortedTasks[i].Priority == null) { sortedTasks[i].Priority = 0; }

                    if (sortedTasks[item].Priority == null) { sortedTasks[item].Priority = 0; }

                    if (sortedTasks[i].Priority < sortedTasks[item].Priority)
                    {
                        var ph = sortedTasks[item];
                        sortedTasks[item] = sortedTasks[i];
                        sortedTasks[i] = ph;
                        item--;

                        flag = true;
                    }
                }
            }

            /////

            //0 removal
            foreach (var item0 in sortedTasks)
                if (item0.Priority == 0) { item0.Priority = null; }

            if (flag) { dataGridViewTasks.DataSource = sortedTasks; labelNoSortResult.Visible = false; }
        }

        public static void InsertionSortDeadline(List<Task> sortedTasks, DataGridView dataGridViewTasks, Label labelNoSortResult, List<Task> tasks)
        {
            bool flag = false;

            //insertion sort
            int item = 0;
            for (int j = 1; j < sortedTasks.Count(); j++)
            {
                item = j;

                for (int i = j - 1; i >= 0; i--)
                {
                    //empty deadline fix
                    if (TextActions.spacesString(sortedTasks[i].Deadline ?? " ")) { sortedTasks[i].Deadline = Convert.ToString(DateTime.MaxValue); }
                    if (TextActions.spacesString(sortedTasks[item].Deadline ?? " ")) { sortedTasks[item].Deadline = Convert.ToString(DateTime.MaxValue); }

                    TimeSpan ts1 = Convert.ToDateTime(sortedTasks[i].Deadline) - DateTime.MinValue;
                    TimeSpan ts2 = Convert.ToDateTime(sortedTasks[item].Deadline) - DateTime.MinValue;

                    if (ts1 > ts2)
                    {
                        var ph = sortedTasks[item];
                        sortedTasks[item] = sortedTasks[i];
                        sortedTasks[i] = ph;
                        item--;

                        flag = true;
                    }
                }
            }

            //max date removal
            foreach (var dateMax in sortedTasks)
            {
                if (dateMax.Deadline == Convert.ToString(DateTime.MaxValue))
                    dateMax.Deadline = null;

            }

            if (flag) { dataGridViewTasks.DataSource = sortedTasks; }

            else { dataGridViewTasks.DataSource = tasks; }

            labelNoSortResult.Visible = false;
        }
    }
    public abstract class Global 
    {
        //global variables
        public static bool FullDescriptionFlag = false;
        public static bool AlreadyCartesian = false;
        public static string CurrentPage = "Expenses"; //Graphics page excluded
        public static bool LightTheme = true;
        public static string? themeFile = null;

        //global methods
        public static T? FindControlRecursive<T>(Control parent) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T tControl)
                    return tControl;
                var found = FindControlRecursive<T>(control);
                if (found != null)
                    return found;
            }
            return null;
        }
        public static void UpdateTheme(Form form)
        {
            var TC = form.Controls.OfType<TabControl>().FirstOrDefault();

            if (TC != null) 
            {

                if (LightTheme)
                {
                    TC.TabPages[0].BackColor = Color.Chocolate; //form background
                    //datagrid background
                    var dataGridView = FindControlRecursive<DataGridView>(TC.TabPages[0]);
                    if (dataGridView != null) { dataGridView.BackgroundColor = Color.Chocolate; }

                    TC.TabPages[1].BackColor = Color.LightSalmon; //form background
                    //datagrid background
                    dataGridView = FindControlRecursive<DataGridView>(TC.TabPages[1]);
                    if (dataGridView != null) { dataGridView.BackgroundColor = Color.LightSalmon; }

                    TC.TabPages[2].BackColor = Color.White; //form background
                }
                else
                {
                    TC.TabPages[0].BackColor = Color.Brown; //form background
                    //datagrid background
                    var dataGridView = FindControlRecursive<DataGridView>(TC.TabPages[0]);
                    if (dataGridView != null) { dataGridView.BackgroundColor = Color.Brown; }

                    TC.TabPages[1].BackColor = Color.Gray; //form background
                    //datagrid background
                    dataGridView = FindControlRecursive<DataGridView>(TC.TabPages[1]);
                    if (dataGridView != null) { dataGridView.BackgroundColor = Color.Gray; }

                    TC.TabPages[2].BackColor = Color.Black; //form background
                }
                if (ExpensesForm.appFolder != null)
                    { themeFile = Path.Combine(ExpensesForm.appFolder, "Theme.json"); }

                if (themeFile != null)
                    { File.WriteAllText(themeFile, $"\"light_theme\": {LightTheme}"); }
            }
        }
    }
}
