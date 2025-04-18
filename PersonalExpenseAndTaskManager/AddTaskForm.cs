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