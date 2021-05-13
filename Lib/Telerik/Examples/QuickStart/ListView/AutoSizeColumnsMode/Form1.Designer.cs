namespace Telerik.Examples.WinControls.ListView.AutoSizeColumnsMode
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "File Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Total Size");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Type");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Free Space");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("Files Stored on This Computer");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup2 = new Telerik.WinControls.UI.ListViewDataItemGroup("Hard Disk Drives");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup3 = new Telerik.WinControls.UI.ListViewDataItemGroup("Devices with Removable Storage");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("Shared Documents", new string[] {
            "Shared Documents",
            "",
            "File Folder"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("Administrator\'s Documents", new string[] {
            "Administrator\'s Documents",
            "",
            "File Folder"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("3.5 Floppy (A:)", new string[] {
            "3.5 Floppy (A:)",
            "1.44 MB",
            "Floppy Drive",
            "203 KB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (C:)", new string[] {
            "Local Disk (C:)",
            "160.4 GB",
            "Local Disk",
            "31.02 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem5 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (D:)", new string[] {
            "Local Disk (D:)",
            "136.2 GB",
            "Local Disk",
            "57.52 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem6 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (E:)", new string[] {
            "Local Disk (E:)",
            "40.00 GB",
            "Local Disk",
            "13.37 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem7 = new Telerik.WinControls.UI.ListViewDataItem("Local Disk (F:)", new string[] {
            "Local Disk (F:)",
            "0.99 TB",
            "Local Disk",
            "357.37 GB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem8 = new Telerik.WinControls.UI.ListViewDataItem("DVD/CD-RW Drive (G:)", new string[] {
            "DVD/CD-RW (G:)",
            "4.7 GB",
            "DVD Drive",
            "0 KB"});
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem9 = new Telerik.WinControls.UI.ListViewDataItem("CD-RW Drive (H:)", new string[] {
            "CD-RW (G:)",
            "",
            "CD Drive"});
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.radGroupBox5 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabelMyComputer = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox5)).BeginInit();
            this.radGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMyComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radListView1);
            this.radPanelDemoHolder.Controls.Add(this.radLabelMyComputer);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(28, 5);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(561, 372);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1032, 1);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox5);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(200, 803);
            this.settingsPanel.Size = new System.Drawing.Size(200, 803);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(113, 118);
            // 
            // radListView1
            // 
            this.radListView1.AutoSizeColumnsMode = Telerik.WinControls.UI.ListViewAutoSizeColumnsMode.Fill;
            listViewDetailColumn1.HeaderText = "File Name";
            listViewDetailColumn1.MinWidth = 150F;
            listViewDetailColumn1.Width = 283.9235F;
            listViewDetailColumn2.HeaderText = "Total Size";
            listViewDetailColumn2.Width = 79.29031F;
            listViewDetailColumn3.HeaderText = "Type";
            listViewDetailColumn3.Width = 91.81257F;
            listViewDetailColumn4.HeaderText = "Free Space";
            listViewDetailColumn4.Width = 106.9736F;
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.EnableCustomGrouping = true;
            this.radListView1.EnableSorting = true;
            listViewDataItemGroup1.Text = "Files Stored on This Computer";
            listViewDataItemGroup2.Text = "Hard Disk Drives";
            listViewDataItemGroup3.Text = "Devices with Removable Storage";
            this.radListView1.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1,
            listViewDataItemGroup2,
            listViewDataItemGroup3});
            listViewDataItem1.Group = listViewDataItemGroup1;
            listViewDataItem1.Image = global::Telerik.Examples.WinControls.Properties.Resources.folder_xp;
            listViewDataItem1.Text = "Shared Documents";
            listViewDataItem2.Group = listViewDataItemGroup1;
            listViewDataItem2.Image = global::Telerik.Examples.WinControls.Properties.Resources.folder_xp;
            listViewDataItem2.Text = "Administrator\'s Documents";
            listViewDataItem3.Group = listViewDataItemGroup3;
            listViewDataItem3.Image = global::Telerik.Examples.WinControls.Properties.Resources.floppy_drive;
            listViewDataItem3.Text = "3.5 Floppy (A:)";
            listViewDataItem4.Group = listViewDataItemGroup2;
            listViewDataItem4.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem4.Text = "Local Disk (C:)";
            listViewDataItem5.Group = listViewDataItemGroup2;
            listViewDataItem5.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem5.Text = "Local Disk (D:)";
            listViewDataItem6.Group = listViewDataItemGroup2;
            listViewDataItem6.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem6.Text = "Local Disk (E:)";
            listViewDataItem7.Group = listViewDataItemGroup2;
            listViewDataItem7.Image = global::Telerik.Examples.WinControls.Properties.Resources.hard_drive;
            listViewDataItem7.Text = "Local Disk (F:)";
            listViewDataItem8.Group = listViewDataItemGroup3;
            listViewDataItem8.Image = global::Telerik.Examples.WinControls.Properties.Resources.cd_drive;
            listViewDataItem8.Text = "DVD/CD-RW Drive (G:)";
            listViewDataItem9.Group = listViewDataItemGroup3;
            listViewDataItem9.Image = global::Telerik.Examples.WinControls.Properties.Resources.cd_drive;
            listViewDataItem9.Text = "CD-RW Drive (H:)";
            this.radListView1.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1,
            listViewDataItem2,
            listViewDataItem3,
            listViewDataItem4,
            listViewDataItem5,
            listViewDataItem6,
            listViewDataItem7,
            listViewDataItem8,
            listViewDataItem9});
            this.radListView1.ItemSize = new System.Drawing.Size(200, 34);
            this.radListView1.ItemSpacing = -1;
            this.radListView1.KeyboardSearchEnabled = true;
            this.radListView1.Location = new System.Drawing.Point(0, 30);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(561, 342);
            this.radListView1.TabIndex = 1;
            this.radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.radListView1.CellFormatting += new Telerik.WinControls.UI.ListViewCellFormattingEventHandler(this.RadListView1_CellFormatting);
            // 
            // radGroupBox5
            // 
            this.radGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox5.Controls.Add(this.radRadioButton2);
            this.radGroupBox5.Controls.Add(this.radRadioButton1);
            this.radGroupBox5.HeaderText = "AutoSize Columns Mode";
            this.radGroupBox5.Location = new System.Drawing.Point(4, 7);
            this.radGroupBox5.Name = "radGroupBox5";
            this.radGroupBox5.Size = new System.Drawing.Size(193, 82);
            this.radGroupBox5.TabIndex = 18;
            this.radGroupBox5.Text = "AutoSize Columns Mode";
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(9, 53);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(48, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.TabStop = false;
            this.radRadioButton2.Text = "None";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButton1.Location = new System.Drawing.Point(9, 27);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(34, 18);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.Text = "Fill";
            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RadRadioButton1_ToggleStateChanged);
            // 
            // radLabelMyComputer
            // 
            this.radLabelMyComputer.AutoSize = false;
            this.radLabelMyComputer.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabelMyComputer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabelMyComputer.ForeColor = System.Drawing.Color.Gray;
            this.radLabelMyComputer.Location = new System.Drawing.Point(0, 0);
            this.radLabelMyComputer.Name = "radLabelMyComputer";
            this.radLabelMyComputer.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.radLabelMyComputer.Size = new System.Drawing.Size(561, 30);
            this.radLabelMyComputer.TabIndex = 2;
            this.radLabelMyComputer.Text = "My Computer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1454, 788);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox5)).EndInit();
            this.radGroupBox5.ResumeLayout(false);
            this.radGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMyComputer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox5;
        private Telerik.WinControls.UI.RadLabel radLabelMyComputer;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
    }
}