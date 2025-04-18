namespace PersonalExpenseAndTaskManager
{
    partial class AddTaskForm
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
            textBoxTitle = new TextBox();
            richTextBoxDescription2 = new RichTextBox();
            dateTimePickerDeadline = new DateTimePicker();
            trackBarPriority = new TrackBarNoFocus();
            labelTitle = new Label();
            labelDescription2 = new Label();
            labelDeadline = new Label();
            labelPriority = new Label();
            groupBoxTaskData = new GroupBox();
            groupBoxOptionalData2 = new GroupBox();
            checkBoxActivePriority = new CheckBox();
            checkBoxActivedeadline = new CheckBox();
            panelPriority = new Panel();
            buttonDone2 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBarPriority).BeginInit();
            groupBoxTaskData.SuspendLayout();
            groupBoxOptionalData2.SuspendLayout();
            panelPriority.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(157, 44);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(138, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // richTextBoxDescription2
            // 
            richTextBoxDescription2.Location = new Point(148, 146);
            richTextBoxDescription2.Name = "richTextBoxDescription2";
            richTextBoxDescription2.Size = new Size(152, 72);
            richTextBoxDescription2.TabIndex = 1;
            richTextBoxDescription2.Text = "";
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Cursor = Cursors.Hand;
            dateTimePickerDeadline.Enabled = false;
            dateTimePickerDeadline.Location = new Point(106, 84);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(225, 27);
            dateTimePickerDeadline.TabIndex = 2;
            // 
            // trackBarPriority
            // 
            trackBarPriority.Cursor = Cursors.Hand;
            trackBarPriority.Enabled = false;
            trackBarPriority.Location = new Point(20, 8);
            trackBarPriority.Maximum = 5;
            trackBarPriority.Minimum = 1;
            trackBarPriority.Name = "trackBarPriority";
            trackBarPriority.Size = new Size(104, 45);
            trackBarPriority.TabIndex = 3;
            trackBarPriority.Value = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(209, 24);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Title";
            // 
            // labelDescription2
            // 
            labelDescription2.AutoSize = true;
            labelDescription2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescription2.Location = new Point(183, 123);
            labelDescription2.Name = "labelDescription2";
            labelDescription2.Size = new Size(87, 20);
            labelDescription2.TabIndex = 5;
            labelDescription2.Text = "Description";
            // 
            // labelDeadline
            // 
            labelDeadline.AutoSize = true;
            labelDeadline.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDeadline.Location = new Point(181, 57);
            labelDeadline.Name = "labelDeadline";
            labelDeadline.Size = new Size(70, 20);
            labelDeadline.TabIndex = 6;
            labelDeadline.Text = "Deadline";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPriority.Location = new Point(185, 164);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(60, 20);
            labelPriority.TabIndex = 7;
            labelPriority.Text = "Priority";
            // 
            // groupBoxTaskData
            // 
            groupBoxTaskData.Controls.Add(textBoxTitle);
            groupBoxTaskData.Controls.Add(richTextBoxDescription2);
            groupBoxTaskData.Controls.Add(labelTitle);
            groupBoxTaskData.Controls.Add(labelDescription2);
            groupBoxTaskData.Location = new Point(12, 5);
            groupBoxTaskData.Name = "groupBoxTaskData";
            groupBoxTaskData.Size = new Size(444, 281);
            groupBoxTaskData.TabIndex = 8;
            groupBoxTaskData.TabStop = false;
            groupBoxTaskData.Text = "Task Data";
            // 
            // groupBoxOptionalData2
            // 
            groupBoxOptionalData2.Controls.Add(checkBoxActivePriority);
            groupBoxOptionalData2.Controls.Add(checkBoxActivedeadline);
            groupBoxOptionalData2.Controls.Add(panelPriority);
            groupBoxOptionalData2.Controls.Add(dateTimePickerDeadline);
            groupBoxOptionalData2.Controls.Add(labelPriority);
            groupBoxOptionalData2.Controls.Add(labelDeadline);
            groupBoxOptionalData2.Location = new Point(12, 292);
            groupBoxOptionalData2.Name = "groupBoxOptionalData2";
            groupBoxOptionalData2.Size = new Size(444, 290);
            groupBoxOptionalData2.TabIndex = 9;
            groupBoxOptionalData2.TabStop = false;
            groupBoxOptionalData2.Text = "Optional Data";
            // 
            // checkBoxActivePriority
            // 
            checkBoxActivePriority.AutoSize = true;
            checkBoxActivePriority.Location = new Point(123, 214);
            checkBoxActivePriority.Name = "checkBoxActivePriority";
            checkBoxActivePriority.Size = new Size(15, 14);
            checkBoxActivePriority.TabIndex = 10;
            checkBoxActivePriority.UseVisualStyleBackColor = true;
            checkBoxActivePriority.CheckedChanged += checkBoxActivePriority_CheckedChanged;
            // 
            // checkBoxActivedeadline
            // 
            checkBoxActivedeadline.AutoSize = true;
            checkBoxActivedeadline.Location = new Point(86, 91);
            checkBoxActivedeadline.Name = "checkBoxActivedeadline";
            checkBoxActivedeadline.Size = new Size(15, 14);
            checkBoxActivedeadline.TabIndex = 9;
            checkBoxActivedeadline.UseVisualStyleBackColor = true;
            checkBoxActivedeadline.CheckedChanged += checkBoxActivedeadline_CheckedChanged;
            // 
            // panelPriority
            // 
            panelPriority.Anchor = AnchorStyles.None;
            panelPriority.BorderStyle = BorderStyle.Fixed3D;
            panelPriority.Controls.Add(trackBarPriority);
            panelPriority.Location = new Point(142, 191);
            panelPriority.Name = "panelPriority";
            panelPriority.Size = new Size(146, 58);
            panelPriority.TabIndex = 8;
            // 
            // buttonDone2
            // 
            buttonDone2.Enabled = false;
            buttonDone2.Location = new Point(186, 591);
            buttonDone2.Name = "buttonDone2";
            buttonDone2.Size = new Size(75, 25);
            buttonDone2.TabIndex = 10;
            buttonDone2.Text = "Done";
            buttonDone2.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 626);
            Controls.Add(buttonDone2);
            Controls.Add(groupBoxOptionalData2);
            Controls.Add(groupBoxTaskData);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTaskForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Insertion";
            ((System.ComponentModel.ISupportInitialize)trackBarPriority).EndInit();
            groupBoxTaskData.ResumeLayout(false);
            groupBoxTaskData.PerformLayout();
            groupBoxOptionalData2.ResumeLayout(false);
            groupBoxOptionalData2.PerformLayout();
            panelPriority.ResumeLayout(false);
            panelPriority.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTitle;
        private RichTextBox richTextBoxDescription2;
        private DateTimePicker dateTimePickerDeadline;
        private TrackBarNoFocus trackBarPriority;
        private Label labelTitle;
        private Label labelDescription2;
        private Label labelDeadline;
        private Label labelPriority;
        private GroupBox groupBoxTaskData;
        private GroupBox groupBoxOptionalData2;
        private Panel panelPriority;
        private Button buttonDone2;
        private CheckBox checkBoxActivedeadline;
        private CheckBox checkBoxActivePriority;
        private System.Windows.Forms.Timer timer2;
    }
}