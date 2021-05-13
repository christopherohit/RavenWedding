namespace ExportWithDpl.PropertyGrid
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
            this.settingsPanel = new Telerik.WinControls.UI.RadPanel();
            this.exportDescriptionsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.groupChildItemsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
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
            this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportDescriptionsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChildItemsCheckBox)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.exportDescriptionsCheckBox);
            this.settingsPanel.Controls.Add(this.groupChildItemsCheckBox);
            this.settingsPanel.Controls.Add(this.exportVisualSettingsCheckBox);
            this.settingsPanel.Controls.Add(this.customizeVisualSettingsCheckBox);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.exportButton);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(381, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(211, 570);
            this.settingsPanel.TabIndex = 1;
            // 
            // exportDescriptionsCheckBox
            // 
            this.exportDescriptionsCheckBox.Location = new System.Drawing.Point(5, 175);
            this.exportDescriptionsCheckBox.Name = "exportDescriptionsCheckBox";
            this.exportDescriptionsCheckBox.Size = new System.Drawing.Size(114, 18);
            this.exportDescriptionsCheckBox.TabIndex = 18;
            this.exportDescriptionsCheckBox.Text = "ExportDescriptions";
            // 
            // groupChildItemsCheckBox
            // 
            this.groupChildItemsCheckBox.Location = new System.Drawing.Point(5, 142);
            this.groupChildItemsCheckBox.Name = "groupChildItemsCheckBox";
            this.groupChildItemsCheckBox.Size = new System.Drawing.Size(149, 18);
            this.groupChildItemsCheckBox.TabIndex = 17;
            this.groupChildItemsCheckBox.Text = "ExportChildItemsGrouped";
            // 
            // exportVisualSettingsCheckBox
            // 
            this.exportVisualSettingsCheckBox.Location = new System.Drawing.Point(5, 110);
            this.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox";
            this.exportVisualSettingsCheckBox.Size = new System.Drawing.Size(122, 18);
            this.exportVisualSettingsCheckBox.TabIndex = 16;
            this.exportVisualSettingsCheckBox.Text = "ExportVisualSettings";
            // 
            // customizeVisualSettingsCheckBox
            // 
            this.customizeVisualSettingsCheckBox.AutoSize = false;
            this.customizeVisualSettingsCheckBox.Location = new System.Drawing.Point(5, 51);
            this.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox";
            this.customizeVisualSettingsCheckBox.Size = new System.Drawing.Size(193, 50);
            this.customizeVisualSettingsCheckBox.TabIndex = 14;
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
            this.radGroupBox2.Location = new System.Drawing.Point(6, 296);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(192, 105);
            this.radGroupBox2.TabIndex = 13;
            this.radGroupBox2.Text = "Collapsed item option";
            // 
            // collapsedOptionDoNotExportRadioButton
            // 
            this.collapsedOptionDoNotExportRadioButton.Location = new System.Drawing.Point(6, 48);
            this.collapsedOptionDoNotExportRadioButton.Name = "collapsedOptionDoNotExportRadioButton";
            this.collapsedOptionDoNotExportRadioButton.Size = new System.Drawing.Size(86, 18);
            this.collapsedOptionDoNotExportRadioButton.TabIndex = 1;
            this.collapsedOptionDoNotExportRadioButton.Text = "DoNotExport";
            // 
            // collapsedOptionExportAsHiddenRadioButton
            // 
            this.collapsedOptionExportAsHiddenRadioButton.Location = new System.Drawing.Point(6, 74);
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
            this.radGroupBox1.Location = new System.Drawing.Point(6, 207);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(192, 77);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.Text = "Export format";
            // 
            // exportFormatTxtRadioButton
            // 
            this.exportFormatTxtRadioButton.Location = new System.Drawing.Point(82, 48);
            this.exportFormatTxtRadioButton.Name = "exportFormatTxtRadioButton";
            this.exportFormatTxtRadioButton.Size = new System.Drawing.Size(39, 18);
            this.exportFormatTxtRadioButton.TabIndex = 1;
            this.exportFormatTxtRadioButton.Text = "TXT";
            // 
            // exportFormatCsvRadioButton
            // 
            this.exportFormatCsvRadioButton.Location = new System.Drawing.Point(6, 48);
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
            this.exportButton.Size = new System.Drawing.Size(192, 24);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Export";
            // 
            // radPropertyGrid1
            // 
            this.radPropertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radPropertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPropertyGrid1.Name = "radPropertyGrid1";
            this.radPropertyGrid1.SelectedObject = this.exportButton;
            this.radPropertyGrid1.Size = new System.Drawing.Size(381, 570);
            this.radPropertyGrid1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.radPropertyGrid1.TabIndex = 2;
            this.radPropertyGrid1.ToolbarVisible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 570);
            this.Controls.Add(this.radPropertyGrid1);
            this.Controls.Add(this.settingsPanel);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Export with Document Processing Libraries";
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportDescriptionsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChildItemsCheckBox)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel settingsPanel;
        private Telerik.WinControls.UI.RadCheckBox groupChildItemsCheckBox;
        private Telerik.WinControls.UI.RadCheckBox exportVisualSettingsCheckBox;
        private Telerik.WinControls.UI.RadCheckBox customizeVisualSettingsCheckBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton collapsedOptionDoNotExportRadioButton;
        private Telerik.WinControls.UI.RadRadioButton collapsedOptionExportAsHiddenRadioButton;
        private Telerik.WinControls.UI.RadRadioButton collapsedOptionExportAlwaysRadioButton;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton exportFormatTxtRadioButton;
        private Telerik.WinControls.UI.RadRadioButton exportFormatCsvRadioButton;
        private Telerik.WinControls.UI.RadRadioButton exportFormatPdfRadioButton;
        private Telerik.WinControls.UI.RadRadioButton exportFormatXlsxRadioButton;
        private Telerik.WinControls.UI.RadButton exportButton;
        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private Telerik.WinControls.UI.RadCheckBox exportDescriptionsCheckBox;
    }
}