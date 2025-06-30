namespace PersonalExpenseAndTaskManager
{
    partial class SettingsForm
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
            labelTheme = new Label();
            panelLight = new Panel();
            panelDark = new Panel();
            labelLight = new Label();
            labelDark = new Label();
            checkBoxLight = new CheckBox();
            checkBoxDark = new CheckBox();
            buttonDone = new Button();
            SuspendLayout();
            // 
            // labelTheme
            // 
            labelTheme.Anchor = AnchorStyles.None;
            labelTheme.AutoSize = true;
            labelTheme.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            labelTheme.Location = new Point(12, 9);
            labelTheme.Name = "labelTheme";
            labelTheme.Size = new Size(75, 25);
            labelTheme.TabIndex = 0;
            labelTheme.Text = "Theme:";
            // 
            // panelLight
            // 
            panelLight.Anchor = AnchorStyles.None;
            panelLight.BackColor = SystemColors.ButtonHighlight;
            panelLight.Location = new Point(121, 80);
            panelLight.Name = "panelLight";
            panelLight.Size = new Size(101, 70);
            panelLight.TabIndex = 1;
            // 
            // panelDark
            // 
            panelDark.Anchor = AnchorStyles.None;
            panelDark.BackColor = SystemColors.ActiveCaptionText;
            panelDark.Location = new Point(335, 80);
            panelDark.Name = "panelDark";
            panelDark.Size = new Size(101, 70);
            panelDark.TabIndex = 2;
            // 
            // labelLight
            // 
            labelLight.Anchor = AnchorStyles.None;
            labelLight.AutoSize = true;
            labelLight.Location = new Point(155, 62);
            labelLight.Name = "labelLight";
            labelLight.Size = new Size(34, 15);
            labelLight.TabIndex = 3;
            labelLight.Text = "Light";
            // 
            // labelDark
            // 
            labelDark.Anchor = AnchorStyles.None;
            labelDark.AutoSize = true;
            labelDark.Location = new Point(369, 62);
            labelDark.Name = "labelDark";
            labelDark.Size = new Size(31, 15);
            labelDark.TabIndex = 4;
            labelDark.Text = "Dark";
            // 
            // checkBoxLight
            // 
            checkBoxLight.Anchor = AnchorStyles.None;
            checkBoxLight.AutoSize = true;
            checkBoxLight.Checked = true;
            checkBoxLight.CheckState = CheckState.Checked;
            checkBoxLight.Cursor = Cursors.Hand;
            checkBoxLight.Location = new Point(100, 106);
            checkBoxLight.Name = "checkBoxLight";
            checkBoxLight.Size = new Size(15, 14);
            checkBoxLight.TabIndex = 5;
            checkBoxLight.UseVisualStyleBackColor = true;
            checkBoxLight.CheckedChanged += checkBoxLight_CheckedChanged;
            // 
            // checkBoxDark
            // 
            checkBoxDark.Anchor = AnchorStyles.None;
            checkBoxDark.AutoSize = true;
            checkBoxDark.Cursor = Cursors.Hand;
            checkBoxDark.Location = new Point(314, 106);
            checkBoxDark.Name = "checkBoxDark";
            checkBoxDark.Size = new Size(15, 14);
            checkBoxDark.TabIndex = 6;
            checkBoxDark.UseVisualStyleBackColor = true;
            checkBoxDark.CheckedChanged += checkBoxDark_CheckedChanged;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.None;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Location = new Point(234, 188);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 7;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // SettingsForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(545, 214);
            ControlBox = false;
            Controls.Add(buttonDone);
            Controls.Add(checkBoxDark);
            Controls.Add(checkBoxLight);
            Controls.Add(labelDark);
            Controls.Add(labelLight);
            Controls.Add(panelDark);
            Controls.Add(panelLight);
            Controls.Add(labelTheme);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTheme;
        private Panel panelLight;
        private Panel panelDark;
        private Label labelLight;
        private Label labelDark;
        private CheckBox checkBoxLight;
        private CheckBox checkBoxDark;
        private Button buttonDone;
    }
}