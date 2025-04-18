namespace PersonalExpenseAndTaskManager
{
    partial class AddExpenseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxAmount = new TextBox();
            comboBoxInOut = new ComboBox();
            labelAmount = new Label();
            labelInOut = new Label();
            dateTimePicker = new DateTimePicker();
            labelDate = new Label();
            groupBoxTransactionData = new GroupBox();
            groupBoxOptionalData = new GroupBox();
            labelIntermediate = new Label();
            textBoxIntermediate = new TextBox();
            labelDescription = new Label();
            richTextBoxDescription = new RichTextBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            buttonDone = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBoxTransactionData.SuspendLayout();
            groupBoxOptionalData.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(66, 58);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(98, 27);
            textBoxAmount.TabIndex = 0;
            textBoxAmount.TextChanged += textBoxAmount_TextChanged;
            // 
            // comboBoxInOut
            // 
            comboBoxInOut.Cursor = Cursors.Hand;
            comboBoxInOut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInOut.FormattingEnabled = true;
            comboBoxInOut.Items.AddRange(new object[] { "Income", "Expense" });
            comboBoxInOut.Location = new Point(231, 57);
            comboBoxInOut.Name = "comboBoxInOut";
            comboBoxInOut.Size = new Size(115, 28);
            comboBoxInOut.TabIndex = 1;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAmount.Location = new Point(80, 35);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(64, 20);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "Amount";
            // 
            // labelInOut
            // 
            labelInOut.AutoSize = true;
            labelInOut.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInOut.Location = new Point(270, 35);
            labelInOut.Name = "labelInOut";
            labelInOut.Size = new Size(30, 20);
            labelInOut.TabIndex = 3;
            labelInOut.Text = "I/O";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Cursor = Cursors.Hand;
            dateTimePicker.Location = new Point(91, 158);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(213, 27);
            dateTimePicker.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(175, 135);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 5;
            labelDate.Text = "Date";
            // 
            // groupBoxTransactionData
            // 
            groupBoxTransactionData.Controls.Add(dateTimePicker);
            groupBoxTransactionData.Controls.Add(labelDate);
            groupBoxTransactionData.Controls.Add(textBoxAmount);
            groupBoxTransactionData.Controls.Add(comboBoxInOut);
            groupBoxTransactionData.Controls.Add(labelInOut);
            groupBoxTransactionData.Controls.Add(labelAmount);
            groupBoxTransactionData.Location = new Point(22, 12);
            groupBoxTransactionData.Name = "groupBoxTransactionData";
            groupBoxTransactionData.Size = new Size(421, 258);
            groupBoxTransactionData.TabIndex = 6;
            groupBoxTransactionData.TabStop = false;
            groupBoxTransactionData.Text = "Transaction Data";
            // 
            // groupBoxOptionalData
            // 
            groupBoxOptionalData.Controls.Add(labelIntermediate);
            groupBoxOptionalData.Controls.Add(textBoxIntermediate);
            groupBoxOptionalData.Controls.Add(labelDescription);
            groupBoxOptionalData.Controls.Add(richTextBoxDescription);
            groupBoxOptionalData.Controls.Add(labelCategory);
            groupBoxOptionalData.Controls.Add(comboBoxCategory);
            groupBoxOptionalData.Location = new Point(22, 306);
            groupBoxOptionalData.Name = "groupBoxOptionalData";
            groupBoxOptionalData.Size = new Size(421, 276);
            groupBoxOptionalData.TabIndex = 7;
            groupBoxOptionalData.TabStop = false;
            groupBoxOptionalData.Text = "Optional Data";
            // 
            // labelIntermediate
            // 
            labelIntermediate.AutoSize = true;
            labelIntermediate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIntermediate.Location = new Point(155, 202);
            labelIntermediate.Name = "labelIntermediate";
            labelIntermediate.Size = new Size(96, 20);
            labelIntermediate.TabIndex = 12;
            labelIntermediate.Text = "Intermediate";
            // 
            // textBoxIntermediate
            // 
            textBoxIntermediate.Location = new Point(141, 225);
            textBoxIntermediate.Name = "textBoxIntermediate";
            textBoxIntermediate.Size = new Size(122, 27);
            textBoxIntermediate.TabIndex = 11;
            textBoxIntermediate.TextChanged += textBoxIntermediate_TextChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(108, 90);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(87, 20);
            labelDescription.TabIndex = 10;
            labelDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(108, 113);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(192, 84);
            richTextBoxDescription.TabIndex = 9;
            richTextBoxDescription.Text = "";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(167, 23);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(72, 20);
            labelCategory.TabIndex = 8;
            labelCategory.Text = "Category";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Cursor = Cursors.Hand;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "purchase", "sale", "estimate", "debt", "bill", "tax" });
            comboBoxCategory.Location = new Point(146, 46);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(115, 28);
            comboBoxCategory.TabIndex = 6;
            // 
            // buttonDone
            // 
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(185, 588);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 26);
            buttonDone.TabIndex = 8;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // AddExpenseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 622);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOptionalData);
            Controls.Add(groupBoxTransactionData);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(484, 665);
            MinimizeBox = false;
            MinimumSize = new Size(484, 665);
            Name = "AddExpenseForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Insertion";
            groupBoxTransactionData.ResumeLayout(false);
            groupBoxTransactionData.PerformLayout();
            groupBoxOptionalData.ResumeLayout(false);
            groupBoxOptionalData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxAmount;
        private ComboBox comboBoxInOut;
        private Label labelAmount;
        private Label labelInOut;
        private DateTimePicker dateTimePicker;
        private Label labelDate;
        private GroupBox groupBoxTransactionData;
        private GroupBox groupBoxOptionalData;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private RichTextBox richTextBoxDescription;
        private Label labelDescription;
        private TextBox textBoxIntermediate;
        private Label labelIntermediate;
        private Button buttonDone;
        private System.Windows.Forms.Timer timer1;
    }
}