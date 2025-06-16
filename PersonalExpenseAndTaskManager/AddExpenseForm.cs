using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseAndTaskManager
{
    public partial class AddExpenseForm : Form
    {
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            TextActions.inputBlock(textBoxAmount, 11);

            int i = 0;
            bool hasCommaOrDot = false;
            int afterCounter = 0;

            foreach (var character in textBoxAmount.Text)
            {

                if (!char.IsDigit(character) && character != '.' && character != ',')
                {
                    textBoxAmount.Text = $"{textBoxAmount.Text.Substring(0, i)}{textBoxAmount.Text.Substring(i + 1, textBoxAmount.Text.Length - (i + 1))}";
                    textBoxAmount.SelectionStart = i;

                    break;
                }

                if (i > 0 && (textBoxAmount.Text[i] == '.' || textBoxAmount.Text[i] == ','))
                {
                    if ((textBoxAmount.Text[i - 1] == '.' || textBoxAmount.Text[i - 1] == ',') || hasCommaOrDot)
                    {
                        textBoxAmount.Text = $"{textBoxAmount.Text.Substring(0, i)}";
                        textBoxAmount.SelectionStart = i;
                    }

                    hasCommaOrDot = true;
                }

                else if (textBoxAmount.Text[i] == '.' || textBoxAmount.Text[i] == ',')
                    textBoxAmount.Text = null;

                if (hasCommaOrDot) { afterCounter++; }

                if(afterCounter > 3)
                {
                    textBoxAmount.Text = $"{textBoxAmount.Text.Substring(0, i)}";
                    textBoxAmount.SelectionStart = i;
                }
                
                i++;
            }

        }

        private void textBoxIntermediate_TextChanged(object sender, EventArgs e)
        {
            TextActions.inputBlock(textBoxIntermediate, 14);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to upload this data?", "Confirm Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (AddExpenseForm.ActiveForm != null)
                {
                    foreach (var item in textBoxAmount.Text) 
                    {
                        if (item == '.') { textBoxAmount.Text = textBoxAmount.Text.Replace('.', ','); break; }
                    }

                    var newExpense = new Expense((comboBoxInOut.Text == "Income") ? $"+{textBoxAmount.Text}" : $"-{textBoxAmount.Text}", Convert.ToString(dateTimePicker.Value), comboBoxCategory.Text, richTextBoxDescription.Text, textBoxIntermediate.Text);
                    ExpensesForm.expenses.Insert(0,newExpense);
                    
                    if(ExpensesForm.expensesFile != null) FileActions.addJsonContent(newExpense, ExpensesForm.expensesFile, ExpensesForm.expenses);

                    var currMainForm = Application.OpenForms.OfType<ExpensesForm>().FirstOrDefault();

                    if (currMainForm != null)
                    {
                        currMainForm.dataGridExpenses.DataSource = null;
                        currMainForm.dataGridExpenses.DataSource = ExpensesForm.expenses;
                    }

                    Global.AlreadyCartesian = false;

                    AddExpenseForm.ActiveForm.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TextActions.spacesString(textBoxAmount.Text) || TextActions.spacesString(comboBoxInOut.Text))
                buttonDone.Enabled = false;
            else
                buttonDone.Enabled = true;
        }

    }

}
