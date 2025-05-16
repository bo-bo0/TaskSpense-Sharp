using System;
using System.Diagnostics.Eventing.Reader;
using System.IO.Packaging;
using System.Reflection.Metadata.Ecma335;
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
        //string contatin the path to the local folder of the user (%localappdata%)

        public ExpensesForm()
        {
            InitializeComponent();
            this.KeyPreview = true; //per attivare gli eventi da tastiera

            //initialize floder
            appFolder = Path.Combine(localPath, "TaskSpense Sharp");
            Directory.CreateDirectory(appFolder); // Assicura che la cartella esista


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

            /*if (expensesFile != null)
            {
                string json;
                using (var r = new StreamReader(expensesFile)) { json = r.ReadToEnd(); }

                if (json == "") return; //se il file è vuoto non fa nulla
                try
                {
                    expenses = JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
                    dataGridExpenses.DataSource = expenses;
                }
                catch
                {

                    var answer = MessageBox.Show("It was not possible to read the save files. Press Ok to create new data or Cancel to close the application.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (answer == DialogResult.Cancel)
                        Close();
                    else
                    {
                        dataGridExpenses.DataSource = null;
                        File.WriteAllText(expensesFile, null); //reset file
                    }

                } 
            }*/
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
            }
            else
            {
                var ws = new MemoryStream(Properties.Resources.wins);

                buttonScreen.Image = Image.FromStream(ws);
                buttonScreen2.Image = Image.FromStream(ws);
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
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
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
}
