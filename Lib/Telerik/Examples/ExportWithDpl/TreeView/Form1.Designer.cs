namespace ExportWithDpl.TreeView
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
            this.allowAlternatingRowColorCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.groupChildNodesCheckBox = new Telerik.WinControls.UI.RadCheckBox();
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
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allowAlternatingRowColorCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChildNodesCheckBox)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.tableLayoutPanel1);
            this.settingsPanel.Controls.Add(this.radGroupBox2);
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.exportButton);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(552, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(239, 756);
            this.settingsPanel.TabIndex = 0;
            // 
            // allowAlternatingRowColorCheckBox
            // 
            this.allowAlternatingRowColorCheckBox.Location = new System.Drawing.Point(3, 3);
            this.allowAlternatingRowColorCheckBox.Name = "allowAlternatingRowColorCheckBox";
            this.allowAlternatingRowColorCheckBox.Size = new System.Drawing.Size(155, 18);
            this.allowAlternatingRowColorCheckBox.TabIndex = 18;
            this.allowAlternatingRowColorCheckBox.Text = "Allow alternating row color";
            // 
            // groupChildNodesCheckBox
            // 
            this.groupChildNodesCheckBox.Location = new System.Drawing.Point(3, 175);
            this.groupChildNodesCheckBox.Name = "groupChildNodesCheckBox";
            this.groupChildNodesCheckBox.Size = new System.Drawing.Size(154, 18);
            this.groupChildNodesCheckBox.TabIndex = 17;
            this.groupChildNodesCheckBox.Text = "ExportChildNodesGrouped";
            // 
            // exportImagesCheckBox
            // 
            this.exportImagesCheckBox.Location = new System.Drawing.Point(3, 132);
            this.exportImagesCheckBox.Name = "exportImagesCheckBox";
            this.exportImagesCheckBox.Size = new System.Drawing.Size(88, 18);
            this.exportImagesCheckBox.TabIndex = 15;
            this.exportImagesCheckBox.Text = "ExportImages";
            // 
            // exportVisualSettingsCheckBox
            // 
            this.exportVisualSettingsCheckBox.Location = new System.Drawing.Point(3, 89);
            this.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox";
            this.exportVisualSettingsCheckBox.Size = new System.Drawing.Size(122, 18);
            this.exportVisualSettingsCheckBox.TabIndex = 16;
            this.exportVisualSettingsCheckBox.Text = "ExportVisualSettings";
            // 
            // customizeVisualSettingsCheckBox
            // 
            this.customizeVisualSettingsCheckBox.AutoSize = false;
            this.customizeVisualSettingsCheckBox.Location = new System.Drawing.Point(3, 46);
            this.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox";
            this.customizeVisualSettingsCheckBox.Size = new System.Drawing.Size(192, 35);
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
            this.radGroupBox2.HeaderText = "Collapsed node option";
            this.radGroupBox2.Location = new System.Drawing.Point(6, 391);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(218, 132);
            this.radGroupBox2.TabIndex = 13;
            this.radGroupBox2.Text = "Collapsed node option";
            // 
            // collapsedOptionDoNotExportRadioButton
            // 
            this.collapsedOptionDoNotExportRadioButton.Location = new System.Drawing.Point(6, 57);
            this.collapsedOptionDoNotExportRadioButton.Name = "collapsedOptionDoNotExportRadioButton";
            this.collapsedOptionDoNotExportRadioButton.Size = new System.Drawing.Size(86, 18);
            this.collapsedOptionDoNotExportRadioButton.TabIndex = 1;
            this.collapsedOptionDoNotExportRadioButton.Text = "DoNotExport";
            // 
            // collapsedOptionExportAsHiddenRadioButton
            // 
            this.collapsedOptionExportAsHiddenRadioButton.Location = new System.Drawing.Point(5, 92);
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
            this.radGroupBox1.Location = new System.Drawing.Point(9, 282);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(215, 100);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.Text = "Export format";
            // 
            // exportFormatTxtRadioButton
            // 
            this.exportFormatTxtRadioButton.Location = new System.Drawing.Point(82, 63);
            this.exportFormatTxtRadioButton.Name = "exportFormatTxtRadioButton";
            this.exportFormatTxtRadioButton.Size = new System.Drawing.Size(39, 18);
            this.exportFormatTxtRadioButton.TabIndex = 1;
            this.exportFormatTxtRadioButton.Text = "TXT";
            // 
            // exportFormatCsvRadioButton
            // 
            this.exportFormatCsvRadioButton.Location = new System.Drawing.Point(6, 63);
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
            this.exportButton.Location = new System.Drawing.Point(6, 12);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(221, 24);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Export";
            // 
            // radTreeView1
            // 
            this.radTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.Size = new System.Drawing.Size(546, 756);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.allowAlternatingRowColorCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupChildNodesCheckBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.customizeVisualSettingsCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportImagesCheckBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.exportVisualSettingsCheckBox, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 218);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(791, 756);
            this.Controls.Add(this.radTreeView1);
            this.Controls.Add(this.settingsPanel);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Export with Document Processing Libraries";
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allowAlternatingRowColorCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupChildNodesCheckBox)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel settingsPanel;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadCheckBox groupChildNodesCheckBox;
        private Telerik.WinControls.UI.RadCheckBox exportImagesCheckBox;
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
        private Telerik.WinControls.UI.RadCheckBox allowAlternatingRowColorCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}