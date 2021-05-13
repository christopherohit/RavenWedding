namespace Telerik.Examples.WinControls.Forms.TaskDialog.FirstLook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonInstallation = new Telerik.WinControls.UI.RadButton();
            this.MainTableLayoutPanel = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radPanelGameDifficulty = new Telerik.WinControls.UI.RadPanel();
            this.GameTableLayoutPanel = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.buttonDiffuculty = new Telerik.WinControls.UI.RadButton();
            this.radLabelGameImage = new Telerik.WinControls.UI.RadLabel();
            this.radLabelGameDescription = new Telerik.WinControls.UI.RadLabel();
            this.radPanelWarning = new Telerik.WinControls.UI.RadPanel();
            this.WarningTableLayoutPanel = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.buttonWarning = new Telerik.WinControls.UI.RadButton();
            this.radLabelWarningImage = new Telerik.WinControls.UI.RadLabel();
            this.radLabelWarningDescription = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabelGameDifficultySample = new Telerik.WinControls.UI.RadLabel();
            this.radLabelWarningSample = new Telerik.WinControls.UI.RadLabel();
            this.radPanelInstallation = new Telerik.WinControls.UI.RadPanel();
            this.InstallationTableLayoutPanel = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radLabelInstallationImage = new Telerik.WinControls.UI.RadLabel();
            this.radLabelInstallationDescription = new Telerik.WinControls.UI.RadLabel();
            this.radLabelInstallationSample = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInstallation)).BeginInit();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelGameDifficulty)).BeginInit();
            this.radPanelGameDifficulty.SuspendLayout();
            this.GameTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDiffuculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGameDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelWarning)).BeginInit();
            this.radPanelWarning.SuspendLayout();
            this.WarningTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelWarningImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelWarningDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGameDifficultySample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelWarningSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelInstallation)).BeginInit();
            this.radPanelInstallation.SuspendLayout();
            this.InstallationTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInstallationImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInstallationDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInstallationSample)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.MainTableLayoutPanel);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(136, 116);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(730, 538);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1063, 47);
            // 
            // buttonInstallation
            // 
            this.buttonInstallation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInstallation.Location = new System.Drawing.Point(135, 45);
            this.buttonInstallation.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.buttonInstallation.Name = "buttonInstallation";
            this.buttonInstallation.Size = new System.Drawing.Size(235, 36);
            this.buttonInstallation.TabIndex = 1;
            this.buttonInstallation.Text = "Open Installation Sample";
            this.buttonInstallation.Click += new System.EventHandler(this.ButtonInstallation_Click);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.radPanelGameDifficulty, 0, 5);
            this.MainTableLayoutPanel.Controls.Add(this.radPanelWarning, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.radLabelGameDifficultySample, 0, 4);
            this.MainTableLayoutPanel.Controls.Add(this.radLabelWarningSample, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.radPanelInstallation, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.radLabelInstallationSample, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 6;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(730, 538);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // radPanelGameDifficulty
            // 
            this.radPanelGameDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanelGameDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.radPanelGameDifficulty.Controls.Add(this.GameTableLayoutPanel);
            this.radPanelGameDifficulty.Location = new System.Drawing.Point(8, 412);
            this.radPanelGameDifficulty.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.radPanelGameDifficulty.Name = "radPanelGameDifficulty";
            // 
            // 
            // 
            this.radPanelGameDifficulty.RootElement.EnableElementShadow = false;
            this.radPanelGameDifficulty.Size = new System.Drawing.Size(714, 126);
            this.radPanelGameDifficulty.TabIndex = 5;
            // 
            // GameTableLayoutPanel
            // 
            this.GameTableLayoutPanel.ColumnCount = 3;
            this.GameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.GameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.GameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GameTableLayoutPanel.Controls.Add(this.buttonDiffuculty, 1, 1);
            this.GameTableLayoutPanel.Controls.Add(this.radLabelGameImage, 0, 0);
            this.GameTableLayoutPanel.Controls.Add(this.radLabelGameDescription, 1, 0);
            this.GameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.GameTableLayoutPanel.Name = "GameTableLayoutPanel";
            this.GameTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.GameTableLayoutPanel.RowCount = 3;
            this.GameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.GameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameTableLayoutPanel.Size = new System.Drawing.Size(714, 126);
            this.GameTableLayoutPanel.TabIndex = 1;
            // 
            // buttonDiffuculty
            // 
            this.buttonDiffuculty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiffuculty.Location = new System.Drawing.Point(135, 45);
            this.buttonDiffuculty.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.buttonDiffuculty.Name = "buttonDiffuculty";
            this.buttonDiffuculty.Size = new System.Drawing.Size(235, 36);
            this.buttonDiffuculty.TabIndex = 1;
            this.buttonDiffuculty.Text = "Open Game Difficulty Sample";
            this.buttonDiffuculty.Click += new System.EventHandler(this.ButtonDifficulty_Click);
            // 
            // radLabelGameImage
            // 
            this.radLabelGameImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelGameImage.AutoSize = false;
            this.radLabelGameImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.radLabelGameImage.Image = ((System.Drawing.Image)(resources.GetObject("radLabelGameImage.Image")));
            this.radLabelGameImage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabelGameImage.Location = new System.Drawing.Point(16, 13);
            this.radLabelGameImage.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.radLabelGameImage.Name = "radLabelGameImage";
            this.GameTableLayoutPanel.SetRowSpan(this.radLabelGameImage, 3);
            this.radLabelGameImage.Size = new System.Drawing.Size(100, 100);
            this.radLabelGameImage.TabIndex = 2;
            // 
            // radLabelGameDescription
            // 
            this.radLabelGameDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelGameDescription.AutoSize = false;
            this.GameTableLayoutPanel.SetColumnSpan(this.radLabelGameDescription, 2);
            this.radLabelGameDescription.Location = new System.Drawing.Point(130, 13);
            this.radLabelGameDescription.Name = "radLabelGameDescription";
            this.radLabelGameDescription.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.radLabelGameDescription.Size = new System.Drawing.Size(576, 26);
            this.radLabelGameDescription.TabIndex = 3;
            this.radLabelGameDescription.Text = "At the start of a new game, you have to choose the level of difficulty you want t" +
    "o play!";
            // 
            // radPanelWarning
            // 
            this.radPanelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanelWarning.BackColor = System.Drawing.Color.Transparent;
            this.radPanelWarning.Controls.Add(this.WarningTableLayoutPanel);
            this.radPanelWarning.Location = new System.Drawing.Point(8, 226);
            this.radPanelWarning.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.radPanelWarning.Name = "radPanelWarning";
            // 
            // 
            // 
            this.radPanelWarning.RootElement.EnableElementShadow = false;
            this.radPanelWarning.Size = new System.Drawing.Size(714, 126);
            this.radPanelWarning.TabIndex = 4;
            // 
            // WarningTableLayoutPanel
            // 
            this.WarningTableLayoutPanel.ColumnCount = 3;
            this.WarningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.WarningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.WarningTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WarningTableLayoutPanel.Controls.Add(this.buttonWarning, 1, 1);
            this.WarningTableLayoutPanel.Controls.Add(this.radLabelWarningImage, 0, 0);
            this.WarningTableLayoutPanel.Controls.Add(this.radLabelWarningDescription, 1, 0);
            this.WarningTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarningTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.WarningTableLayoutPanel.Name = "WarningTableLayoutPanel";
            this.WarningTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.WarningTableLayoutPanel.RowCount = 3;
            this.WarningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WarningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.WarningTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WarningTableLayoutPanel.Size = new System.Drawing.Size(714, 126);
            this.WarningTableLayoutPanel.TabIndex = 1;
            // 
            // buttonWarning
            // 
            this.buttonWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWarning.Location = new System.Drawing.Point(135, 45);
            this.buttonWarning.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Size = new System.Drawing.Size(235, 36);
            this.buttonWarning.TabIndex = 1;
            this.buttonWarning.Text = "Open Warning Sample";
            this.buttonWarning.Click += new System.EventHandler(this.ButtonWarning_Click);
            // 
            // radLabelWarningImage
            // 
            this.radLabelWarningImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelWarningImage.AutoSize = false;
            this.radLabelWarningImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.radLabelWarningImage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabelWarningImage.Location = new System.Drawing.Point(16, 13);
            this.radLabelWarningImage.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.radLabelWarningImage.Name = "radLabelWarningImage";
            this.WarningTableLayoutPanel.SetRowSpan(this.radLabelWarningImage, 3);
            this.radLabelWarningImage.Size = new System.Drawing.Size(100, 100);
            this.radLabelWarningImage.TabIndex = 2;
            // 
            // radLabelWarningDescription
            // 
            this.radLabelWarningDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelWarningDescription.AutoSize = false;
            this.radLabelWarningDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WarningTableLayoutPanel.SetColumnSpan(this.radLabelWarningDescription, 2);
            this.radLabelWarningDescription.Location = new System.Drawing.Point(130, 13);
            this.radLabelWarningDescription.Name = "radLabelWarningDescription";
            this.radLabelWarningDescription.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.radLabelWarningDescription.ReadOnly = true;
            this.radLabelWarningDescription.Size = new System.Drawing.Size(576, 26);
            this.radLabelWarningDescription.TabIndex = 3;
            this.radLabelWarningDescription.Text = " Enable protect mode.";
            this.radLabelWarningDescription.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabelGameDifficultySample
            // 
            this.radLabelGameDifficultySample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelGameDifficultySample.AutoSize = false;
            this.radLabelGameDifficultySample.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabelGameDifficultySample.Location = new System.Drawing.Point(3, 355);
            this.radLabelGameDifficultySample.Name = "radLabelGameDifficultySample";
            this.radLabelGameDifficultySample.Size = new System.Drawing.Size(724, 54);
            this.radLabelGameDifficultySample.TabIndex = 3;
            this.radLabelGameDifficultySample.Text = "Game Difficulty Sample";
            this.radLabelGameDifficultySample.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // radLabelWarningSample
            // 
            this.radLabelWarningSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelWarningSample.AutoSize = false;
            this.radLabelWarningSample.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabelWarningSample.Location = new System.Drawing.Point(3, 169);
            this.radLabelWarningSample.Name = "radLabelWarningSample";
            this.radLabelWarningSample.Size = new System.Drawing.Size(724, 54);
            this.radLabelWarningSample.TabIndex = 2;
            this.radLabelWarningSample.Text = "Warning Sample";
            this.radLabelWarningSample.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // radPanelInstallation
            // 
            this.radPanelInstallation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPanelInstallation.BackColor = System.Drawing.Color.Transparent;
            this.radPanelInstallation.Controls.Add(this.InstallationTableLayoutPanel);
            this.radPanelInstallation.Location = new System.Drawing.Point(8, 40);
            this.radPanelInstallation.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.radPanelInstallation.Name = "radPanelInstallation";
            // 
            // 
            // 
            this.radPanelInstallation.RootElement.EnableElementShadow = false;
            this.radPanelInstallation.Size = new System.Drawing.Size(714, 126);
            this.radPanelInstallation.TabIndex = 0;
            // 
            // InstallationTableLayoutPanel
            // 
            this.InstallationTableLayoutPanel.ColumnCount = 3;
            this.InstallationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.InstallationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.InstallationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InstallationTableLayoutPanel.Controls.Add(this.buttonInstallation, 1, 1);
            this.InstallationTableLayoutPanel.Controls.Add(this.radLabelInstallationImage, 0, 0);
            this.InstallationTableLayoutPanel.Controls.Add(this.radLabelInstallationDescription, 1, 0);
            this.InstallationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstallationTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.InstallationTableLayoutPanel.Name = "InstallationTableLayoutPanel";
            this.InstallationTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.InstallationTableLayoutPanel.RowCount = 3;
            this.InstallationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InstallationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.InstallationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InstallationTableLayoutPanel.Size = new System.Drawing.Size(714, 126);
            this.InstallationTableLayoutPanel.TabIndex = 0;
            // 
            // radLabelInstallationImage
            // 
            this.radLabelInstallationImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelInstallationImage.AutoSize = false;
            this.radLabelInstallationImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.radLabelInstallationImage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabelInstallationImage.Location = new System.Drawing.Point(16, 13);
            this.radLabelInstallationImage.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.radLabelInstallationImage.Name = "radLabelInstallationImage";
            this.InstallationTableLayoutPanel.SetRowSpan(this.radLabelInstallationImage, 3);
            this.radLabelInstallationImage.Size = new System.Drawing.Size(100, 100);
            this.radLabelInstallationImage.TabIndex = 2;
            // 
            // radLabelInstallationDescription
            // 
            this.radLabelInstallationDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelInstallationDescription.AutoSize = false;
            this.InstallationTableLayoutPanel.SetColumnSpan(this.radLabelInstallationDescription, 2);
            this.radLabelInstallationDescription.Location = new System.Drawing.Point(130, 13);
            this.radLabelInstallationDescription.Name = "radLabelInstallationDescription";
            this.radLabelInstallationDescription.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.radLabelInstallationDescription.Size = new System.Drawing.Size(576, 26);
            this.radLabelInstallationDescription.TabIndex = 3;
            this.radLabelInstallationDescription.Text = "Installation Warning!";
            // 
            // radLabelInstallationSample
            // 
            this.radLabelInstallationSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabelInstallationSample.AutoSize = false;
            this.radLabelInstallationSample.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.radLabelInstallationSample.Location = new System.Drawing.Point(3, 3);
            this.radLabelInstallationSample.Name = "radLabelInstallationSample";
            this.radLabelInstallationSample.Size = new System.Drawing.Size(724, 34);
            this.radLabelInstallationSample.TabIndex = 1;
            this.radLabelInstallationSample.Text = "Installation Sample";
            this.radLabelInstallationSample.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1454, 788);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonInstallation)).EndInit();
            this.MainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelGameDifficulty)).EndInit();
            this.radPanelGameDifficulty.ResumeLayout(false);
            this.GameTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonDiffuculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGameDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelWarning)).EndInit();
            this.radPanelWarning.ResumeLayout(false);
            this.WarningTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelWarningImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelWarningDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelGameDifficultySample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelWarningSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelInstallation)).EndInit();
            this.radPanelInstallation.ResumeLayout(false);
            this.InstallationTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInstallationImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInstallationDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInstallationSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton buttonInstallation;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel MainTableLayoutPanel;
        private Telerik.WinControls.UI.RadLabel radLabelGameDifficultySample;
        private Telerik.WinControls.UI.RadLabel radLabelWarningSample;
        private Telerik.WinControls.UI.RadPanel radPanelInstallation;
        private Telerik.WinControls.UI.RadLabel radLabelInstallationSample;
        private Telerik.WinControls.UI.RadPanel radPanelGameDifficulty;
        private Telerik.WinControls.UI.RadPanel radPanelWarning;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel InstallationTableLayoutPanel;
        private Telerik.WinControls.UI.RadLabel radLabelInstallationImage;
        private Telerik.WinControls.UI.RadLabel radLabelInstallationDescription;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel GameTableLayoutPanel;
        private Telerik.WinControls.UI.RadButton buttonDiffuculty;
        private Telerik.WinControls.UI.RadLabel radLabelGameImage;
        private Telerik.WinControls.UI.RadLabel radLabelGameDescription;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel WarningTableLayoutPanel;
        private Telerik.WinControls.UI.RadButton buttonWarning;
        private Telerik.WinControls.UI.RadLabel radLabelWarningImage;
        private Telerik.WinControls.UI.RadCheckBox radLabelWarningDescription;
    }
}