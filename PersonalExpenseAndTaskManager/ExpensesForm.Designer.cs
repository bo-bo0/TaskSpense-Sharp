﻿namespace PersonalExpenseAndTaskManager
{
    partial class ExpensesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panelScreen = new Panel();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            tabControl = new TabControl();
            tabPageExpenses = new TabPage();
            PanelCenter = new FlowLayoutPanel();
            buttonExit = new Button();
            buttonSettings = new Button();
            panelPlus = new Panel();
            labelPlus = new Label();
            buttonGraphics = new Button();
            buttonTasks = new Button();
            panelGrid = new Panel();
            comboBoxFilterCategory = new ComboBox();
            pictureBoxResetCategory = new PictureBox();
            labelNoFilterResult = new Label();
            dataGridExpenses = new DataGridView();
            buttonScreen = new PictureBox();
            panelRed = new Panel();
            tabPageTasks = new TabPage();
            flowLayoutPanelNotifications = new FlowLayoutPanel();
            pictureBoxBell = new PictureBox();
            panelGrid2 = new Panel();
            labelNoSortResult = new Label();
            pictureBoxResetSort = new PictureBox();
            comboBoxSort = new ComboBox();
            dataGridViewTasks = new DataGridView();
            buttonScreen2 = new PictureBox();
            PanelCenter2 = new FlowLayoutPanel();
            buttonExit2 = new Button();
            buttonSettings2 = new Button();
            panel1 = new Panel();
            labelPlus2 = new Label();
            buttonGraphics2 = new Button();
            buttonExpenses = new Button();
            panelRed2 = new Panel();
            tabPageGraphics = new TabPage();
            buttonScreen3 = new PictureBox();
            panelRedGraphics = new Panel();
            buttonSettings3 = new Button();
            buttonGraphicsInGraphics = new Button();
            buttonExOrTas = new Button();
            buttonExit3 = new Button();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            timerNotifyCheck = new System.Windows.Forms.Timer(components);
            tabControl.SuspendLayout();
            tabPageExpenses.SuspendLayout();
            PanelCenter.SuspendLayout();
            panelPlus.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResetCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridExpenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonScreen).BeginInit();
            tabPageTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBell).BeginInit();
            panelGrid2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResetSort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonScreen2).BeginInit();
            PanelCenter2.SuspendLayout();
            panel1.SuspendLayout();
            tabPageGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonScreen3).BeginInit();
            panelRedGraphics.SuspendLayout();
            SuspendLayout();
            // 
            // panelScreen
            // 
            panelScreen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelScreen.AutoSize = true;
            panelScreen.Location = new Point(1236, 647);
            panelScreen.Name = "panelScreen";
            panelScreen.Size = new Size(82, 79);
            panelScreen.TabIndex = 7;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabPageExpenses);
            tabControl.Controls.Add(tabPageTasks);
            tabControl.Controls.Add(tabPageGraphics);
            tabControl.ItemSize = new Size(0, 1);
            tabControl.Location = new Point(-9, -8);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1328, 734);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 10;
            // 
            // tabPageExpenses
            // 
            tabPageExpenses.BackColor = Color.Chocolate;
            tabPageExpenses.Controls.Add(PanelCenter);
            tabPageExpenses.Controls.Add(panelGrid);
            tabPageExpenses.Controls.Add(buttonScreen);
            tabPageExpenses.Controls.Add(panelRed);
            tabPageExpenses.Location = new Point(4, 5);
            tabPageExpenses.Name = "tabPageExpenses";
            tabPageExpenses.Padding = new Padding(3);
            tabPageExpenses.Size = new Size(1320, 725);
            tabPageExpenses.TabIndex = 0;
            tabPageExpenses.Text = "tabPageExpenses";
            tabPageExpenses.Paint += tabPageExpenses_Paint;
            // 
            // PanelCenter
            // 
            PanelCenter.Anchor = AnchorStyles.Top;
            PanelCenter.BackColor = Color.Firebrick;
            PanelCenter.Controls.Add(buttonExit);
            PanelCenter.Controls.Add(buttonSettings);
            PanelCenter.Controls.Add(panelPlus);
            PanelCenter.Controls.Add(buttonGraphics);
            PanelCenter.Controls.Add(buttonTasks);
            PanelCenter.Location = new Point(-11, 7);
            PanelCenter.Margin = new Padding(10);
            PanelCenter.Name = "PanelCenter";
            PanelCenter.Padding = new Padding(128, 0, 0, 0);
            PanelCenter.Size = new Size(1155, 87);
            PanelCenter.TabIndex = 5;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top;
            buttonExit.AutoSize = true;
            buttonExit.BackColor = Color.FromArgb(255, 192, 128);
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(168, 0);
            buttonExit.Margin = new Padding(40, 0, 0, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(170, 86);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            buttonExit.MouseEnter += buttonGeneric_Hover;
            buttonExit.MouseLeave += buttonGeneric_Leave;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Top;
            buttonSettings.AutoSize = true;
            buttonSettings.BackColor = Color.FromArgb(255, 192, 128);
            buttonSettings.Cursor = Cursors.Hand;
            buttonSettings.Font = new Font("Britannic Bold", 30F);
            buttonSettings.Location = new Point(378, 0);
            buttonSettings.Margin = new Padding(40, 0, 0, 0);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(177, 86);
            buttonSettings.TabIndex = 1;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            buttonSettings.MouseEnter += buttonGeneric_Hover;
            buttonSettings.MouseLeave += buttonGeneric_Leave;
            // 
            // panelPlus
            // 
            panelPlus.Controls.Add(labelPlus);
            panelPlus.Location = new Point(558, 3);
            panelPlus.Name = "panelPlus";
            panelPlus.Size = new Size(105, 81);
            panelPlus.TabIndex = 10;
            // 
            // labelPlus
            // 
            labelPlus.AutoSize = true;
            labelPlus.BackColor = Color.Transparent;
            labelPlus.Cursor = Cursors.Hand;
            labelPlus.Font = new Font("Segoe UI", 90F, FontStyle.Bold);
            labelPlus.ForeColor = Color.Gold;
            labelPlus.Location = new Point(2, -51);
            labelPlus.Margin = new Padding(30, 0, 3, 0);
            labelPlus.Name = "labelPlus";
            labelPlus.Size = new Size(152, 159);
            labelPlus.TabIndex = 1;
            labelPlus.Text = "+";
            labelPlus.Click += labelPlus_Click;
            // 
            // buttonGraphics
            // 
            buttonGraphics.Anchor = AnchorStyles.Top;
            buttonGraphics.AutoSize = true;
            buttonGraphics.BackColor = Color.FromArgb(255, 192, 128);
            buttonGraphics.Cursor = Cursors.Hand;
            buttonGraphics.Font = new Font("Britannic Bold", 30F);
            buttonGraphics.Location = new Point(706, 0);
            buttonGraphics.Margin = new Padding(40, 0, 0, 0);
            buttonGraphics.Name = "buttonGraphics";
            buttonGraphics.Size = new Size(188, 86);
            buttonGraphics.TabIndex = 3;
            buttonGraphics.Text = "Graphics";
            buttonGraphics.UseVisualStyleBackColor = false;
            buttonGraphics.Click += buttonGraphics_Click;
            buttonGraphics.MouseEnter += buttonGeneric_Hover;
            buttonGraphics.MouseLeave += buttonGeneric_Leave;
            // 
            // buttonTasks
            // 
            buttonTasks.Anchor = AnchorStyles.Top;
            buttonTasks.AutoSize = true;
            buttonTasks.BackColor = Color.FromArgb(255, 192, 128);
            buttonTasks.Cursor = Cursors.Hand;
            buttonTasks.Font = new Font("Britannic Bold", 30F);
            buttonTasks.Location = new Point(934, 0);
            buttonTasks.Margin = new Padding(40, 0, 0, 0);
            buttonTasks.Name = "buttonTasks";
            buttonTasks.Size = new Size(167, 86);
            buttonTasks.TabIndex = 4;
            buttonTasks.Text = "Tasks";
            buttonTasks.UseVisualStyleBackColor = false;
            buttonTasks.Click += buttonTasks_Click;
            buttonTasks.MouseEnter += buttonGeneric_Hover;
            buttonTasks.MouseLeave += buttonGeneric_Leave;
            // 
            // panelGrid
            // 
            panelGrid.Anchor = AnchorStyles.Top;
            panelGrid.AutoSize = true;
            panelGrid.BackColor = Color.Transparent;
            panelGrid.Controls.Add(comboBoxFilterCategory);
            panelGrid.Controls.Add(pictureBoxResetCategory);
            panelGrid.Controls.Add(labelNoFilterResult);
            panelGrid.Controls.Add(dataGridExpenses);
            panelGrid.Location = new Point(224, 150);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(940, 523);
            panelGrid.TabIndex = 9;
            // 
            // comboBoxFilterCategory
            // 
            comboBoxFilterCategory.Cursor = Cursors.Hand;
            comboBoxFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterCategory.ForeColor = SystemColors.WindowText;
            comboBoxFilterCategory.FormattingEnabled = true;
            comboBoxFilterCategory.Items.AddRange(new object[] { "purchase", "sale", "estimate", "debt", "bill", "tax" });
            comboBoxFilterCategory.Location = new Point(324, 3);
            comboBoxFilterCategory.Name = "comboBoxFilterCategory";
            comboBoxFilterCategory.Size = new Size(143, 23);
            comboBoxFilterCategory.TabIndex = 10;
            comboBoxFilterCategory.SelectedIndexChanged += comboBoxFilterCategory_SelectedIndexChanged;
            // 
            // pictureBoxResetCategory
            // 
            pictureBoxResetCategory.Cursor = Cursors.Hand;
            pictureBoxResetCategory.Image = (Image)resources.GetObject("pictureBoxResetCategory.Image");
            pictureBoxResetCategory.Location = new Point(374, 32);
            pictureBoxResetCategory.Name = "pictureBoxResetCategory";
            pictureBoxResetCategory.Size = new Size(42, 43);
            pictureBoxResetCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResetCategory.TabIndex = 11;
            pictureBoxResetCategory.TabStop = false;
            pictureBoxResetCategory.Click += pictureBoxResetCategory_Click;
            // 
            // labelNoFilterResult
            // 
            labelNoFilterResult.AutoSize = true;
            labelNoFilterResult.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNoFilterResult.Location = new Point(317, 127);
            labelNoFilterResult.Name = "labelNoFilterResult";
            labelNoFilterResult.Size = new Size(160, 28);
            labelNoFilterResult.TabIndex = 10;
            labelNoFilterResult.Text = "No results found";
            labelNoFilterResult.Visible = false;
            // 
            // dataGridExpenses
            // 
            dataGridExpenses.AllowUserToAddRows = false;
            dataGridExpenses.AllowUserToDeleteRows = false;
            dataGridExpenses.AllowUserToResizeColumns = false;
            dataGridExpenses.AllowUserToResizeRows = false;
            dataGridExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridExpenses.BackgroundColor = Color.Chocolate;
            dataGridExpenses.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Info;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridExpenses.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridExpenses.GridColor = Color.Black;
            dataGridExpenses.Location = new Point(46, 91);
            dataGridExpenses.Name = "dataGridExpenses";
            dataGridExpenses.ReadOnly = true;
            dataGridExpenses.RowHeadersWidth = 25;
            dataGridExpenses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.Cornsilk;
            dataGridExpenses.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridExpenses.ShowCellErrors = false;
            dataGridExpenses.ShowCellToolTips = false;
            dataGridExpenses.ShowEditingIcon = false;
            dataGridExpenses.ShowRowErrors = false;
            dataGridExpenses.Size = new Size(783, 428);
            dataGridExpenses.TabIndex = 8;
            dataGridExpenses.CellDoubleClick += dataGridExpenses_CellDoubleClick;
            // 
            // buttonScreen
            // 
            buttonScreen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonScreen.Cursor = Cursors.Hand;
            buttonScreen.Image = (Image)resources.GetObject("buttonScreen.Image");
            buttonScreen.Location = new Point(1250, 654);
            buttonScreen.Margin = new Padding(30, 10, 10, 10);
            buttonScreen.Name = "buttonScreen";
            buttonScreen.Size = new Size(65, 66);
            buttonScreen.TabIndex = 6;
            buttonScreen.TabStop = false;
            buttonScreen.Click += buttonScreen_Click;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Firebrick;
            panelRed.Location = new Point(5, 3);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(1711, 94);
            panelRed.TabIndex = 10;
            // 
            // tabPageTasks
            // 
            tabPageTasks.BackColor = Color.LightSalmon;
            tabPageTasks.Controls.Add(flowLayoutPanelNotifications);
            tabPageTasks.Controls.Add(pictureBoxBell);
            tabPageTasks.Controls.Add(panelGrid2);
            tabPageTasks.Controls.Add(buttonScreen2);
            tabPageTasks.Controls.Add(PanelCenter2);
            tabPageTasks.Controls.Add(panelRed2);
            tabPageTasks.Location = new Point(4, 5);
            tabPageTasks.Name = "tabPageTasks";
            tabPageTasks.Size = new Size(1320, 725);
            tabPageTasks.TabIndex = 1;
            tabPageTasks.Text = "tabPageTasks";
            // 
            // flowLayoutPanelNotifications
            // 
            flowLayoutPanelNotifications.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanelNotifications.AutoScroll = true;
            flowLayoutPanelNotifications.BackColor = Color.White;
            flowLayoutPanelNotifications.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelNotifications.Font = new Font("Segoe UI", 13F);
            flowLayoutPanelNotifications.Location = new Point(3, 515);
            flowLayoutPanelNotifications.Name = "flowLayoutPanelNotifications";
            flowLayoutPanelNotifications.Size = new Size(200, 115);
            flowLayoutPanelNotifications.TabIndex = 16;
            flowLayoutPanelNotifications.Visible = false;
            // 
            // pictureBoxBell
            // 
            pictureBoxBell.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxBell.Cursor = Cursors.Hand;
            pictureBoxBell.Image = (Image)resources.GetObject("pictureBoxBell.Image");
            pictureBoxBell.Location = new Point(12, 646);
            pictureBoxBell.Name = "pictureBoxBell";
            pictureBoxBell.Size = new Size(54, 64);
            pictureBoxBell.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBell.TabIndex = 15;
            pictureBoxBell.TabStop = false;
            pictureBoxBell.Click += pictureBoxBell_Click;
            // 
            // panelGrid2
            // 
            panelGrid2.Anchor = AnchorStyles.Top;
            panelGrid2.AutoSize = true;
            panelGrid2.BackColor = Color.Transparent;
            panelGrid2.Controls.Add(labelNoSortResult);
            panelGrid2.Controls.Add(pictureBoxResetSort);
            panelGrid2.Controls.Add(comboBoxSort);
            panelGrid2.Controls.Add(dataGridViewTasks);
            panelGrid2.Location = new Point(273, 150);
            panelGrid2.Name = "panelGrid2";
            panelGrid2.Size = new Size(940, 523);
            panelGrid2.TabIndex = 14;
            // 
            // labelNoSortResult
            // 
            labelNoSortResult.AutoSize = true;
            labelNoSortResult.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNoSortResult.Location = new Point(268, 127);
            labelNoSortResult.Name = "labelNoSortResult";
            labelNoSortResult.Size = new Size(160, 28);
            labelNoSortResult.TabIndex = 17;
            labelNoSortResult.Text = "No results found";
            labelNoSortResult.Visible = false;
            // 
            // pictureBoxResetSort
            // 
            pictureBoxResetSort.Cursor = Cursors.Hand;
            pictureBoxResetSort.Image = (Image)resources.GetObject("pictureBoxResetSort.Image");
            pictureBoxResetSort.Location = new Point(325, 32);
            pictureBoxResetSort.Name = "pictureBoxResetSort";
            pictureBoxResetSort.Size = new Size(42, 43);
            pictureBoxResetSort.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResetSort.TabIndex = 16;
            pictureBoxResetSort.TabStop = false;
            pictureBoxResetSort.Click += pictureBoxResetSort_Click;
            // 
            // comboBoxSort
            // 
            comboBoxSort.Cursor = Cursors.Hand;
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.ForeColor = SystemColors.WindowText;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "deadline", "priority" });
            comboBoxSort.Location = new Point(275, 3);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(143, 23);
            comboBoxSort.TabIndex = 15;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.AllowUserToDeleteRows = false;
            dataGridViewTasks.AllowUserToResizeColumns = false;
            dataGridViewTasks.AllowUserToResizeRows = false;
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewTasks.BackgroundColor = Color.LightSalmon;
            dataGridViewTasks.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Info;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewTasks.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTasks.GridColor = Color.Black;
            dataGridViewTasks.Location = new Point(58, 91);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 25;
            dataGridViewTasks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = Color.Cornsilk;
            dataGridViewTasks.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.ShowCellErrors = false;
            dataGridViewTasks.ShowCellToolTips = false;
            dataGridViewTasks.ShowEditingIcon = false;
            dataGridViewTasks.ShowRowErrors = false;
            dataGridViewTasks.Size = new Size(610, 428);
            dataGridViewTasks.TabIndex = 8;
            dataGridViewTasks.CellDoubleClick += dataGridViewTasks_CellContentDoubleClick;
            dataGridViewTasks.CellMouseClick += dataGridViewTasks_CellMouseClick;
            // 
            // buttonScreen2
            // 
            buttonScreen2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonScreen2.Cursor = Cursors.Hand;
            buttonScreen2.Image = (Image)resources.GetObject("buttonScreen2.Image");
            buttonScreen2.Location = new Point(1250, 654);
            buttonScreen2.Margin = new Padding(30, 10, 10, 10);
            buttonScreen2.Name = "buttonScreen2";
            buttonScreen2.Size = new Size(65, 66);
            buttonScreen2.TabIndex = 13;
            buttonScreen2.TabStop = false;
            buttonScreen2.Click += buttonScreen_Click;
            // 
            // PanelCenter2
            // 
            PanelCenter2.Anchor = AnchorStyles.Top;
            PanelCenter2.BackColor = Color.Firebrick;
            PanelCenter2.Controls.Add(buttonExit2);
            PanelCenter2.Controls.Add(buttonSettings2);
            PanelCenter2.Controls.Add(panel1);
            PanelCenter2.Controls.Add(buttonGraphics2);
            PanelCenter2.Controls.Add(buttonExpenses);
            PanelCenter2.Location = new Point(-11, 7);
            PanelCenter2.Margin = new Padding(10);
            PanelCenter2.Name = "PanelCenter2";
            PanelCenter2.Padding = new Padding(128, 0, 0, 0);
            PanelCenter2.Size = new Size(1155, 87);
            PanelCenter2.TabIndex = 11;
            // 
            // buttonExit2
            // 
            buttonExit2.Anchor = AnchorStyles.Top;
            buttonExit2.AutoSize = true;
            buttonExit2.BackColor = Color.FromArgb(255, 192, 128);
            buttonExit2.Cursor = Cursors.Hand;
            buttonExit2.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit2.Location = new Point(168, 0);
            buttonExit2.Margin = new Padding(40, 0, 0, 0);
            buttonExit2.Name = "buttonExit2";
            buttonExit2.Size = new Size(170, 86);
            buttonExit2.TabIndex = 0;
            buttonExit2.Text = "Exit";
            buttonExit2.UseVisualStyleBackColor = false;
            buttonExit2.Click += buttonExit_Click;
            buttonExit2.MouseEnter += buttonGeneric_Hover;
            buttonExit2.MouseLeave += buttonGeneric_Leave;
            // 
            // buttonSettings2
            // 
            buttonSettings2.Anchor = AnchorStyles.Top;
            buttonSettings2.AutoSize = true;
            buttonSettings2.BackColor = Color.FromArgb(255, 192, 128);
            buttonSettings2.Cursor = Cursors.Hand;
            buttonSettings2.Font = new Font("Britannic Bold", 30F);
            buttonSettings2.Location = new Point(378, 0);
            buttonSettings2.Margin = new Padding(40, 0, 0, 0);
            buttonSettings2.Name = "buttonSettings2";
            buttonSettings2.Size = new Size(177, 86);
            buttonSettings2.TabIndex = 1;
            buttonSettings2.Text = "Settings";
            buttonSettings2.UseVisualStyleBackColor = false;
            buttonSettings2.Click += buttonSettings_Click;
            buttonSettings2.MouseEnter += buttonGeneric_Hover;
            buttonSettings2.MouseLeave += buttonGeneric_Leave;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelPlus2);
            panel1.Location = new Point(558, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 81);
            panel1.TabIndex = 10;
            // 
            // labelPlus2
            // 
            labelPlus2.AutoSize = true;
            labelPlus2.BackColor = Color.Transparent;
            labelPlus2.Cursor = Cursors.Hand;
            labelPlus2.Font = new Font("Segoe UI", 90F, FontStyle.Bold);
            labelPlus2.ForeColor = Color.Gold;
            labelPlus2.Location = new Point(2, -51);
            labelPlus2.Margin = new Padding(30, 0, 3, 0);
            labelPlus2.Name = "labelPlus2";
            labelPlus2.Size = new Size(152, 159);
            labelPlus2.TabIndex = 1;
            labelPlus2.Text = "+";
            labelPlus2.Click += labelPlus2_Click;
            // 
            // buttonGraphics2
            // 
            buttonGraphics2.Anchor = AnchorStyles.Top;
            buttonGraphics2.AutoSize = true;
            buttonGraphics2.BackColor = Color.FromArgb(255, 192, 128);
            buttonGraphics2.Cursor = Cursors.Hand;
            buttonGraphics2.Font = new Font("Britannic Bold", 30F);
            buttonGraphics2.Location = new Point(706, 0);
            buttonGraphics2.Margin = new Padding(40, 0, 0, 0);
            buttonGraphics2.Name = "buttonGraphics2";
            buttonGraphics2.Size = new Size(188, 86);
            buttonGraphics2.TabIndex = 3;
            buttonGraphics2.Text = "Graphics";
            buttonGraphics2.UseVisualStyleBackColor = false;
            buttonGraphics2.Click += buttonGraphics_Click;
            buttonGraphics2.MouseEnter += buttonGeneric_Hover;
            buttonGraphics2.MouseLeave += buttonGeneric_Leave;
            // 
            // buttonExpenses
            // 
            buttonExpenses.Anchor = AnchorStyles.Top;
            buttonExpenses.AutoSize = true;
            buttonExpenses.BackColor = Color.FromArgb(255, 192, 128);
            buttonExpenses.Cursor = Cursors.Hand;
            buttonExpenses.Font = new Font("Britannic Bold", 30F);
            buttonExpenses.Location = new Point(934, 0);
            buttonExpenses.Margin = new Padding(40, 0, 0, 0);
            buttonExpenses.Name = "buttonExpenses";
            buttonExpenses.Size = new Size(192, 86);
            buttonExpenses.TabIndex = 4;
            buttonExpenses.Text = "Expenses";
            buttonExpenses.UseVisualStyleBackColor = false;
            buttonExpenses.Click += buttonExpenses_Click;
            buttonExpenses.MouseEnter += buttonGeneric_Hover;
            buttonExpenses.MouseLeave += buttonGeneric_Leave;
            // 
            // panelRed2
            // 
            panelRed2.BackColor = Color.Firebrick;
            panelRed2.Location = new Point(-4, 4);
            panelRed2.Name = "panelRed2";
            panelRed2.Size = new Size(1732, 94);
            panelRed2.TabIndex = 12;
            // 
            // tabPageGraphics
            // 
            tabPageGraphics.Controls.Add(buttonScreen3);
            tabPageGraphics.Controls.Add(panelRedGraphics);
            tabPageGraphics.Controls.Add(cartesianChart1);
            tabPageGraphics.Location = new Point(4, 5);
            tabPageGraphics.Name = "tabPageGraphics";
            tabPageGraphics.Size = new Size(1320, 725);
            tabPageGraphics.TabIndex = 2;
            tabPageGraphics.Text = "tabPageGraphics";
            tabPageGraphics.UseVisualStyleBackColor = true;
            tabPageGraphics.Click += buttonScreen_Click;
            // 
            // buttonScreen3
            // 
            buttonScreen3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonScreen3.Cursor = Cursors.Hand;
            buttonScreen3.Image = (Image)resources.GetObject("buttonScreen3.Image");
            buttonScreen3.Location = new Point(1250, 654);
            buttonScreen3.Margin = new Padding(30, 10, 10, 10);
            buttonScreen3.Name = "buttonScreen3";
            buttonScreen3.Size = new Size(65, 66);
            buttonScreen3.TabIndex = 7;
            buttonScreen3.TabStop = false;
            buttonScreen3.Click += buttonScreen_Click;
            // 
            // panelRedGraphics
            // 
            panelRedGraphics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRedGraphics.BackColor = Color.Brown;
            panelRedGraphics.Controls.Add(buttonSettings3);
            panelRedGraphics.Controls.Add(buttonGraphicsInGraphics);
            panelRedGraphics.Controls.Add(buttonExOrTas);
            panelRedGraphics.Controls.Add(buttonExit3);
            panelRedGraphics.Location = new Point(3, 3);
            panelRedGraphics.Name = "panelRedGraphics";
            panelRedGraphics.Size = new Size(1314, 95);
            panelRedGraphics.TabIndex = 5;
            // 
            // buttonSettings3
            // 
            buttonSettings3.Anchor = AnchorStyles.Top;
            buttonSettings3.AutoSize = true;
            buttonSettings3.BackColor = Color.FromArgb(255, 192, 128);
            buttonSettings3.Cursor = Cursors.Hand;
            buttonSettings3.Font = new Font("Britannic Bold", 30F);
            buttonSettings3.Location = new Point(364, 4);
            buttonSettings3.Margin = new Padding(40, 0, 0, 0);
            buttonSettings3.Name = "buttonSettings3";
            buttonSettings3.Size = new Size(177, 86);
            buttonSettings3.TabIndex = 1;
            buttonSettings3.Text = "Settings";
            buttonSettings3.UseVisualStyleBackColor = false;
            buttonSettings3.Click += buttonSettings_Click;
            buttonSettings3.MouseEnter += buttonGeneric_Hover;
            buttonSettings3.MouseLeave += buttonGeneric_Leave;
            // 
            // buttonGraphicsInGraphics
            // 
            buttonGraphicsInGraphics.Anchor = AnchorStyles.Top;
            buttonGraphicsInGraphics.AutoSize = true;
            buttonGraphicsInGraphics.BackColor = Color.FromArgb(255, 192, 128);
            buttonGraphicsInGraphics.Cursor = Cursors.Hand;
            buttonGraphicsInGraphics.Font = new Font("Britannic Bold", 30F);
            buttonGraphicsInGraphics.Location = new Point(692, 4);
            buttonGraphicsInGraphics.Margin = new Padding(40, 0, 0, 0);
            buttonGraphicsInGraphics.Name = "buttonGraphicsInGraphics";
            buttonGraphicsInGraphics.Size = new Size(188, 86);
            buttonGraphicsInGraphics.TabIndex = 3;
            buttonGraphicsInGraphics.Text = "Graphics";
            buttonGraphicsInGraphics.UseVisualStyleBackColor = false;
            buttonGraphicsInGraphics.Click += buttonGraphicsInGraphics_Click;
            buttonGraphicsInGraphics.MouseEnter += buttonGeneric_Hover;
            buttonGraphicsInGraphics.MouseLeave += buttonGeneric_Leave;
            // 
            // buttonExOrTas
            // 
            buttonExOrTas.Anchor = AnchorStyles.Top;
            buttonExOrTas.AutoSize = true;
            buttonExOrTas.BackColor = Color.FromArgb(255, 192, 128);
            buttonExOrTas.Cursor = Cursors.Hand;
            buttonExOrTas.Font = new Font("Britannic Bold", 30F);
            buttonExOrTas.Location = new Point(920, 4);
            buttonExOrTas.Margin = new Padding(40, 0, 0, 0);
            buttonExOrTas.Name = "buttonExOrTas";
            buttonExOrTas.Size = new Size(167, 86);
            buttonExOrTas.TabIndex = 4;
            buttonExOrTas.Text = "Tasks";
            buttonExOrTas.UseVisualStyleBackColor = false;
            buttonExOrTas.Click += buttonExOrTas_Click;
            buttonExOrTas.MouseEnter += buttonGeneric_Hover;
            buttonExOrTas.MouseLeave += buttonGeneric_Leave;
            // 
            // buttonExit3
            // 
            buttonExit3.Anchor = AnchorStyles.Top;
            buttonExit3.AutoSize = true;
            buttonExit3.BackColor = Color.FromArgb(255, 192, 128);
            buttonExit3.Cursor = Cursors.Hand;
            buttonExit3.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit3.Location = new Point(154, 4);
            buttonExit3.Margin = new Padding(40, 0, 0, 0);
            buttonExit3.Name = "buttonExit3";
            buttonExit3.Size = new Size(170, 86);
            buttonExit3.TabIndex = 0;
            buttonExit3.Text = "Exit";
            buttonExit3.UseVisualStyleBackColor = false;
            buttonExit3.Click += buttonExit_Click;
            buttonExit3.MouseEnter += buttonGeneric_Hover;
            buttonExit3.MouseLeave += buttonGeneric_Leave;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.None;
            cartesianChart1.Location = new Point(311, 182);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(654, 437);
            cartesianChart1.TabIndex = 0;
            // 
            // timerNotifyCheck
            // 
            timerNotifyCheck.Enabled = true;
            timerNotifyCheck.Interval = 1000;
            timerNotifyCheck.Tick += timerNotifyCheck_Tick;
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1311, 717);
            Controls.Add(tabControl);
            Controls.Add(panelScreen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExpensesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskSpense Sharp";
            Load += ExpensesForm_Load;
            KeyDown += ExpensesForm_KeyDown;
            Resize += ExpensesForm_Resize;
            tabControl.ResumeLayout(false);
            tabPageExpenses.ResumeLayout(false);
            tabPageExpenses.PerformLayout();
            PanelCenter.ResumeLayout(false);
            PanelCenter.PerformLayout();
            panelPlus.ResumeLayout(false);
            panelPlus.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResetCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridExpenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonScreen).EndInit();
            tabPageTasks.ResumeLayout(false);
            tabPageTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBell).EndInit();
            panelGrid2.ResumeLayout(false);
            panelGrid2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResetSort).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonScreen2).EndInit();
            PanelCenter2.ResumeLayout(false);
            PanelCenter2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageGraphics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonScreen3).EndInit();
            panelRedGraphics.ResumeLayout(false);
            panelRedGraphics.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel panelScreen;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private TabControl tabControl;
        private TabPage tabPageExpenses;
        private PictureBox buttonScreen;
        private TabPage tabPageTasks;
        private Panel panelRed;
        private FlowLayoutPanel PanelCenter;
        private Button buttonExit;
        private Button buttonSettings;
        private Panel panelPlus;
        private Label labelPlus;
        private Button buttonGraphics;
        private Button buttonTasks;
        private FlowLayoutPanel PanelCenter2;
        private Button buttonExit2;
        private Button buttonSettings2;
        private Panel panel1;
        private Label labelPlus2;
        private Button buttonGraphics2;
        private Button buttonExpenses;
        private Panel panelRed2;
        private PictureBox buttonScreen2;
        private Panel panelGrid2;
        public DataGridView dataGridViewTasks;
        private ComboBox comboBoxSort;
        private PictureBox pictureBoxResetSort;
        private Label labelNoSortResult;
        private TabPage tabPageGraphics;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Button buttonExit3;
        private Button buttonSettings3;
        private Button buttonGraphicsInGraphics;
        private Button buttonExOrTas;
        private Panel panelRedGraphics;
        private PictureBox buttonScreen3;
        private Panel panelGrid;
        private ComboBox comboBoxFilterCategory;
        private PictureBox pictureBoxResetCategory;
        private Label labelNoFilterResult;
        public DataGridView dataGridExpenses;
        private System.Windows.Forms.Timer timerNotifyCheck;
        public FlowLayoutPanel flowLayoutPanelNotifications;
        public PictureBox pictureBoxBell;
    }
}
