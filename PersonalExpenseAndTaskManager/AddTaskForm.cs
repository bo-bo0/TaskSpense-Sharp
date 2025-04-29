using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseAndTaskManager
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void checkBoxActivedeadline_CheckedChanged(object sender, EventArgs e)
        {
            var senderCheckBox = (CheckBox)sender;

            dateTimePickerDeadline.Enabled = (senderCheckBox.Checked) ? true : false;

        }

        private void checkBoxActivePriority_CheckedChanged(object sender, EventArgs e)
        {
            var senderCheckBox = (CheckBox)sender;

            trackBarPriority.Enabled = (senderCheckBox.Checked) ? true : false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TextActions.spacesString(textBoxTitle.Text) || TextActions.spacesString(richTextBoxDescription2.Text))
                buttonDone2.Enabled = false;

            else
                buttonDone2.Enabled = true;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            TextActions.inputBlock(textBoxTitle, 16);
        }

        private void buttonDone2_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you want to upload this data?", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                var newTask = new Task(textBoxTitle.Text, richTextBoxDescription2.Text, (checkBoxActivedeadline.Checked) ? Convert.ToString(dateTimePickerDeadline.Value) : null, (checkBoxActivePriority.Checked) ? trackBarPriority.Value : null);

                ExpensesForm.tasks.Insert(0, newTask);

                var currMainForm = Application.OpenForms.OfType<ExpensesForm>().FirstOrDefault();

                if (currMainForm != null)
                {
                    currMainForm.dataGridViewTasks.DataSource = null;
                    currMainForm.dataGridViewTasks.DataSource = ExpensesForm.tasks;
                }

                if (ExpensesForm.tasksFile != null) { FileActions.addJsonContent(newTask, ExpensesForm.tasksFile, ExpensesForm.tasks); }

                AddTaskForm.ActiveForm?.Close();
            }
        }
    }
    public class TrackBarNoFocus : TrackBar
    {
        private const int WM_SETFOCUS = 0x0007;
        private const int WM_KILLFOCUS = 0x0008;

        protected override void WndProc(ref Message m)
        {
            // ignore focus
            if (m.Msg != WM_SETFOCUS && m.Msg != WM_KILLFOCUS)
            {
                base.WndProc(ref m);
            }
        }

        protected override bool ShowFocusCues => false;
    }
}