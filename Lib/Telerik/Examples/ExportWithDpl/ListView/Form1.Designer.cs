namespace ExportWithDpl.ListView
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.settingsPanel = new Telerik.WinControls.UI.RadPanel();
            this.listViewShowGroupsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.groupChildItemsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.exportImagesCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.exportVisualSettingsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.customizeVisualSettingsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.collapsedOptionDoNotExportRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.collapsedOptionExportAsHiddenRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.collapsedOptionExportAlwaysRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.exportFormatTxtRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.exportFormatCsvRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.exportFormatPdfRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.exportFormatXlsxRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.exportButton = new Telerik.WinControls.UI.RadButton();
            this.listViewTypeDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowGroupsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChildItemsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportImagesCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportVisualSettingsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizeVisualSettingsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapsedOptionDoNotExportRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapsedOptionExportAsHiddenRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapsedOptionExportAlwaysRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatTxtRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatCsvRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatPdfRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatXlsxRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTypeDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListView1
            // 
            this.radListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            listViewDetailColumn1.HeaderText = "File Name";
            listViewDetailColumn1.Width = 180F;
            listViewDetailColumn2.HeaderText = "Total Size";
            listViewDetailColumn2.Width = 150F;
            listViewDetailColumn3.HeaderText = "Type";
            listViewDetailColumn3.Width = 180F;
            listViewDetailColumn4.HeaderText = "Free Space";
            listViewDetailColumn4.Width = 150F;
            this.radListView1.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListView1.EnableCustomGrouping = true;
            listViewDataItemGroup1.Text = "Files Stored on This Computer";
            listViewDataItemGroup2.Text = "Hard Disk Drives";
            listViewDataItemGroup3.Text = "Devices with Removable Storage";
            this.radListView1.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1,
            listViewDataItemGroup2,
            listViewDataItemGroup3});
            listViewDataItem1.Group = listViewDataItemGroup1;
            listViewDataItem1.Image = global::ExportWithDpl.Properties.Resources.folder_xp;
            listViewDataItem1.Text = "Shared Documents";
            listViewDataItem2.Group = listViewDataItemGroup1;
            listViewDataItem2.Image = global::ExportWithDpl.Properties.Resources.folder_xp;
            listViewDataItem2.Text = "Administrator\'s Documents";
            listViewDataItem3.Group = listViewDataItemGroup3;
            listViewDataItem3.Image = global::ExportWithDpl.Properties.Resources.floppy_drive;
            listViewDataItem3.Text = "3.5 Floppy (A:)";
            listViewDataItem4.Group = listViewDataItemGroup2;
            listViewDataItem4.Image = global::ExportWithDpl.Properties.Resources.hard_drive;
            listViewDataItem4.Text = "Local Disk (C:)";
            listViewDataItem5.Group = listViewDataItemGroup2;
            listViewDataItem5.Image = global::ExportWithDpl.Properties.Resources.hard_drive;
            listViewDataItem5.Text = "Local Disk (D:)";
            listViewDataItem6.Group = listViewDataItemGroup2;
            listViewDataItem6.Image = global::ExportWithDpl.Properties.Resources.hard_drive;
            listViewDataItem6.Text = "Local Disk (E:)";
            listViewDataItem7.Group = listViewDataItemGroup2;
            listViewDataItem7.Image = global::ExportWithDpl.Properties.Resources.hard_drive;
            listViewDataItem7.Text = "Local Disk (F:)";
            listViewDataItem8.Group = listViewDataItemGroup3;
            listViewDataItem8.Image = global::ExportWithDpl.Properties.Resources.cd_drive;
            listViewDataItem8.Text = "DVD/CD-RW Drive (G:)";
            listViewDataItem9.Group = listViewDataItemGroup3;
            listViewDataItem9.Image = global::ExportWithDpl.Properties.Resources.cd_drive;
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
            this.radListView1.ItemSize = new System.Drawing.Size(200, 32);
            this.radListView1.Location = new System.Drawing.Point(0, 0);
            this.radListView1.Name = "radListView1";
            this.radListView1.ShowGroups = true;
            this.radListView1.Size = new System.Drawing.Size(688, 555);
            this.radListView1.TabIndex = 0;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.listViewShowGroupsCheckBox);
            this.settingsPanel.Controls.Add(this.groupChildItemsCheckBox);
            this.settingsPanel.Controls.Add(this.exportImagesCheckBox);
            this.settingsPanel.Controls.Add(this.exportVisualSettingsCheckBox);
            this.settingsPanel.Controls.Add(this.customizeVisualSettingsCheckBox);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.exportButton);
            this.settingsPanel.Controls.Add(this.listViewTypeDropDownList);
            this.settingsPanel.Controls.Add(this.radLabel1);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(718, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(292, 555);
            this.settingsPanel.TabIndex = 1;
            // 
            // listViewShowGroupsCheckBox
            // 
            this.listViewShowGroupsCheckBox.Location = new System.Drawing.Point(6, 99);
            this.listViewShowGroupsCheckBox.Name = "listViewShowGroupsCheckBox";
            this.listViewShowGroupsCheckBox.Size = new System.Drawing.Size(86, 18);
            this.listViewShowGroupsCheckBox.TabIndex = 8;
            this.listViewShowGroupsCheckBox.Text = "Show groups";
            // 
            // groupChildItemsCheckBox
            // 
            this.groupChildItemsCheckBox.Location = new System.Drawing.Point(6, 235);
            this.groupChildItemsCheckBox.Name = "groupChildItemsCheckBox";
            this.groupChildItemsCheckBox.Size = new System.Drawing.Size(149, 18);
            this.groupChildItemsCheckBox.TabIndex = 7;
            this.groupChildItemsCheckBox.Text = "ExportChildItemsGrouped";
            // 
            // exportImagesCheckBox
            // 
            this.exportImagesCheckBox.Location = new System.Drawing.Point(6, 206);
            this.exportImagesCheckBox.Name = "exportImagesCheckBox";
            this.exportImagesCheckBox.Size = new System.Drawing.Size(88, 18);
            this.exportImagesCheckBox.TabIndex = 6;
            this.exportImagesCheckBox.Text = "ExportImages";
            // 
            // exportVisualSettingsCheckBox
            // 
            this.exportVisualSettingsCheckBox.Location = new System.Drawing.Point(6, 174);
            this.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox";
            this.exportVisualSettingsCheckBox.Size = new System.Drawing.Size(122, 18);
            this.exportVisualSettingsCheckBox.TabIndex = 6;
            this.exportVisualSettingsCheckBox.Text = "ExportVisualSettings";
            // 
            // customizeVisualSettingsCheckBox
            // 
            this.customizeVisualSettingsCheckBox.AutoSize = false;
            this.customizeVisualSettingsCheckBox.Location = new System.Drawing.Point(6, 128);
            this.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox";
            this.customizeVisualSettingsCheckBox.Size = new System.Drawing.Size(193, 35);
            this.customizeVisualSettingsCheckBox.TabIndex = 5;
            this.customizeVisualSettingsCheckBox.Text = "Customize visual settings when exporting";
            this.customizeVisualSettingsCheckBox.TextWrap = true;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.collapsedOptionDoNotExportRadioButton);
            this.radGroupBox2.Controls.Add(this.collapsedOptionExportAsHiddenRadioButton);
            this.radGroupBox2.Controls.Add(this.collapsedOptionExportAlwaysRadioButton);
            this.radGroupBox2.HeaderText = "Collapsed item option";
            this.radGroupBox2.Location = new System.Drawing.Point(6, 361);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(193, 100);
            this.radGroupBox2.TabIndex = 4;
            this.radGroupBox2.Text = "Collapsed item option";
            // 
            // collapsedOptionDoNotExportRadioButton
            // 
            this.collapsedOptionDoNotExportRadioButton.Location = new System.Drawing.Point(6, 46);
            this.collapsedOptionDoNotExportRadioButton.Name = "collapsedOptionDoNotExportRadioButton";
            this.collapsedOptionDoNotExportRadioButton.Size = new System.Drawing.Size(86, 18);
            this.collapsedOptionDoNotExportRadioButton.TabIndex = 1;
            this.collapsedOptionDoNotExportRadioButton.Text = "DoNotExport";
            // 
            // collapsedOptionExportAsHiddenRadioButton
            // 
            this.collapsedOptionExportAsHiddenRadioButton.Location = new System.Drawing.Point(6, 70);
            this.collapsedOptionExportAsHiddenRadioButton.Name = "collapsedOptionExportAsHiddenRadioButton";
            this.collapsedOptionExportAsHiddenRadioButton.Size = new System.Drawing.Size(101, 18);
            this.collapsedOptionExportAsHiddenRadioButton.TabIndex = 1;
            this.collapsedOptionExportAsHiddenRadioButton.Text = "ExportAsHidden";
            // 
            // collapsedOptionExportAlwaysRadioButton
            // 
            this.collapsedOptionExportAlwaysRadioButton.Location = new System.Drawing.Point(6, 22);
            this.collapsedOptionExportAlwaysRadioButton.Name = "collapsedOptionExportAlwaysRadioButton";
            this.collapsedOptionExportAlwaysRadioButton.Size = new System.Drawing.Size(86, 18);
            this.collapsedOptionExportAlwaysRadioButton.TabIndex = 0;
            this.collapsedOptionExportAlwaysRadioButton.Text = "ExportAlways";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.exportFormatTxtRadioButton);
            this.radGroupBox1.Controls.Add(this.exportFormatCsvRadioButton);
            this.radGroupBox1.Controls.Add(this.exportFormatPdfRadioButton);
            this.radGroupBox1.Controls.Add(this.exportFormatXlsxRadioButton);
            this.radGroupBox1.HeaderText = "Export format";
            this.radGroupBox1.Location = new System.Drawing.Point(6, 267);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(193, 77);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Export format";
            // 
            // exportFormatTxtRadioButton
            // 
            this.exportFormatTxtRadioButton.Location = new System.Drawing.Point(82, 46);
            this.exportFormatTxtRadioButton.Name = "exportFormatTxtRadioButton";
            this.exportFormatTxtRadioButton.Size = new System.Drawing.Size(39, 18);
            this.exportFormatTxtRadioButton.TabIndex = 1;
            this.exportFormatTxtRadioButton.Text = "TXT";
            // 
            // exportFormatCsvRadioButton
            // 
            this.exportFormatCsvRadioButton.Location = new System.Drawing.Point(6, 46);
            this.exportFormatCsvRadioButton.Name = "exportFormatCsvRadioButton";
            this.exportFormatCsvRadioButton.Size = new System.Drawing.Size(40, 18);
            this.exportFormatCsvRadioButton.TabIndex = 1;
            this.exportFormatCsvRadioButton.Text = "CSV";
            // 
            // exportFormatPdfRadioButton
            // 
            this.exportFormatPdfRadioButton.Location = new System.Drawing.Point(82, 22);
            this.exportFormatPdfRadioButton.Name = "exportFormatPdfRadioButton";
            this.exportFormatPdfRadioButton.Size = new System.Drawing.Size(40, 18);
            this.exportFormatPdfRadioButton.TabIndex = 1;
            this.exportFormatPdfRadioButton.Text = "PDF";
            // 
            // exportFormatXlsxRadioButton
            // 
            this.exportFormatXlsxRadioButton.Location = new System.Drawing.Point(6, 22);
            this.exportFormatXlsxRadioButton.Name = "exportFormatXlsxRadioButton";
            this.exportFormatXlsxRadioButton.Size = new System.Drawing.Size(45, 18);
            this.exportFormatXlsxRadioButton.TabIndex = 0;
            this.exportFormatXlsxRadioButton.Text = "XLSX";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(6, 11);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(274, 24);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            // 
            // listViewTypeDropDownList
            // 
            this.listViewTypeDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Selected = true;
            radListDataItem1.Text = "List View";
            radListDataItem2.Text = "Icon View";
            radListDataItem3.Text = "Detail View";
            this.listViewTypeDropDownList.Items.Add(radListDataItem1);
            this.listViewTypeDropDownList.Items.Add(radListDataItem2);
            this.listViewTypeDropDownList.Items.Add(radListDataItem3);
            this.listViewTypeDropDownList.Location = new System.Drawing.Point(100, 43);
            this.listViewTypeDropDownList.Name = "listViewTypeDropDownList";
            this.listViewTypeDropDownList.Size = new System.Drawing.Size(180, 24);
            this.listViewTypeDropDownList.TabIndex = 0;
            this.listViewTypeDropDownList.Text = "List View";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(10, 51);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(76, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "ListViewType: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1010, 555);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.radListView1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Export with Document Processing Libraries";
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewShowGroupsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChildItemsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportImagesCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportVisualSettingsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizeVisualSettingsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collapsedOptionDoNotExportRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapsedOptionExportAsHiddenRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapsedOptionExportAlwaysRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatTxtRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatCsvRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatPdfRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportFormatXlsxRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTypeDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadPanel settingsPanel;
        private Telerik.WinControls.UI.RadDropDownList listViewTypeDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton exportButton;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton exportFormatTxtRadioButton;
        private Telerik.WinControls.UI.RadRadioButton exportFormatCsvRadioButton;
        private Telerik.WinControls.UI.RadRadioButton exportFormatPdfRadioButton;
        private Telerik.WinControls.UI.RadRadioButton exportFormatXlsxRadioButton;
        private Telerik.WinControls.UI.RadCheckBox groupChildItemsCheckBox;
        private Telerik.WinControls.UI.RadCheckBox exportImagesCheckBox;
        private Telerik.WinControls.UI.RadCheckBox exportVisualSettingsCheckBox;
        private Telerik.WinControls.UI.RadCheckBox customizeVisualSettingsCheckBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton collapsedOptionDoNotExportRadioButton;
        private Telerik.WinControls.UI.RadRadioButton collapsedOptionExportAsHiddenRadioButton;
        private Telerik.WinControls.UI.RadRadioButton collapsedOptionExportAlwaysRadioButton;
        private Telerik.WinControls.UI.RadCheckBox listViewShowGroupsCheckBox;
    }
}