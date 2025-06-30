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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            checkBoxLight.Checked = Global.LightTheme;
            checkBoxDark.Checked = !Global.LightTheme;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Global.LightTheme = checkBoxLight.Checked;
            var currForm = Application.OpenForms.OfType<ExpensesForm>().FirstOrDefault();

            if (currForm != null) { Global.UpdateTheme(currForm); }

            Close();
        }

        private void checkBoxLight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLight.Checked) { checkBoxDark.Checked = false; }

            else { checkBoxDark.Checked = true; }
        }

        private void checkBoxDark_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDark.Checked) { checkBoxLight.Checked = false; }

            else { checkBoxLight.Checked = true; }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var form = sender as Form;

            if (form != null) { form.FormBorderStyle = FormBorderStyle.FixedDialog; }
        }
    }
}
