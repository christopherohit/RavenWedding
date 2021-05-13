namespace ExportWithDpl.PivotGrid
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
            this.radPivotGrid1 = new Telerik.WinControls.UI.RadPivotGrid();
            this.settingsPanel = new Telerik.WinControls.UI.RadPanel();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPageSpreadExport = new Telerik.WinControls.UI.RadPageViewPage();
            this.exportFlatDataCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.customizeVisualSettingsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.exportButton = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.pdfRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.csvRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.xlsxRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.exportVisualSettingsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radPageViewPagePdfExport = new Telerik.WinControls.UI.RadPageViewPage();
            this.radCheckBoxShowHeaderAndFooter = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxFitToPageWidth = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxExportFlatDataPdfExport = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxCustomizeVisualSettingsPdfExport = new Telerik.WinControls.UI.RadCheckBox();
            this.radButtonPdfExport = new Telerik.WinControls.UI.RadButton();
            this.radCheckBoxExportVisualSettingsPdfExport = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPageSpreadExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportFlatDataCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizeVisualSettingsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csvRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlsxRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportVisualSettingsCheckBox)).BeginInit();
            this.radPageViewPagePdfExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowHeaderAndFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFitToPageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportFlatDataPdfExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCustomizeVisualSettingsPdfExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPdfExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportVisualSettingsPdfExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPivotGrid1
            // 
            this.radPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.radPivotGrid1.Name = "radPivotGrid1";
            this.radPivotGrid1.Size = new System.Drawing.Size(715, 748);
            this.radPivotGrid1.TabIndex = 5;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(1010, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(16, 748);
            this.settingsPanel.TabIndex = 4;
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Visible = false;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPageSpreadExport);
            this.radPageView1.Controls.Add(this.radPageViewPagePdfExport);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPageView1.Location = new System.Drawing.Point(715, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPagePdfExport;
            this.radPageView1.Size = new System.Drawing.Size(295, 748);
            this.radPageView1.TabIndex = 2;
            this.radPageView1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = false;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).ToolTipText = "Scroll Strip Left";
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).ToolTipText = "Scroll Strip Right";
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).ToolTipText = "Close Selected Page";
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radPageViewPageSpreadExport
            // 
            this.radPageViewPageSpreadExport.Controls.Add(this.exportFlatDataCheckBox);
            this.radPageViewPageSpreadExport.Controls.Add(this.customizeVisualSettingsCheckBox);
            this.radPageViewPageSpreadExport.Controls.Add(this.exportButton);
            this.radPageViewPageSpreadExport.Controls.Add(this.radGroupBox1);
            this.radPageViewPageSpreadExport.Controls.Add(this.exportVisualSettingsCheckBox);
            this.radPageViewPageSpreadExport.ItemSize = new System.Drawing.SizeF(83F, 28F);
            this.radPageViewPageSpreadExport.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPageSpreadExport.Name = "radPageViewPageSpreadExport";
            this.radPageViewPageSpreadExport.Size = new System.Drawing.Size(274, 700);
            this.radPageViewPageSpreadExport.Text = "SpreadExport";
            // 
            // exportFlatDataCheckBox
            // 
            this.exportFlatDataCheckBox.Location = new System.Drawing.Point(6, 139);
            this.exportFlatDataCheckBox.Name = "exportFlatDataCheckBox";
            this.exportFlatDataCheckBox.Size = new System.Drawing.Size(93, 18);
            this.exportFlatDataCheckBox.TabIndex = 8;
            this.exportFlatDataCheckBox.Text = "ExportFlatData";
            this.exportFlatDataCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.exportFlatDataCheckBox_ToggleStateChanged);
            // 
            // customizeVisualSettingsCheckBox
            // 
            this.customizeVisualSettingsCheckBox.AutoSize = false;
            this.customizeVisualSettingsCheckBox.Location = new System.Drawing.Point(6, 55);
            this.customizeVisualSettingsCheckBox.Name = "customizeVisualSettingsCheckBox";
            this.customizeVisualSettingsCheckBox.Size = new System.Drawing.Size(168, 38);
            this.customizeVisualSettingsCheckBox.TabIndex = 7;
            this.customizeVisualSettingsCheckBox.Text = "Customize visual settings when exporting";
            this.customizeVisualSettingsCheckBox.TextWrap = true;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.customizeVisualSettingsCheckBox.GetChildAt(0))).Text = "Customize visual settings when exporting";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportButton.Location = new System.Drawing.Point(55, 11);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(165, 23);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Export";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.txtRadioButton);
            this.radGroupBox1.Controls.Add(this.pdfRadioButton);
            this.radGroupBox1.Controls.Add(this.csvRadioButton);
            this.radGroupBox1.Controls.Add(this.xlsxRadioButton);
            this.radGroupBox1.HeaderText = "Export format";
            this.radGroupBox1.Location = new System.Drawing.Point(55, 179);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(165, 119);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Export format";
            // 
            // txtRadioButton
            // 
            this.txtRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRadioButton.Location = new System.Drawing.Point(14, 94);
            this.txtRadioButton.Name = "txtRadioButton";
            this.txtRadioButton.Size = new System.Drawing.Size(39, 18);
            this.txtRadioButton.TabIndex = 2;
            this.txtRadioButton.TabStop = false;
            this.txtRadioButton.Text = "TXT";
            // 
            // pdfRadioButton
            // 
            this.pdfRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pdfRadioButton.Location = new System.Drawing.Point(14, 70);
            this.pdfRadioButton.Name = "pdfRadioButton";
            this.pdfRadioButton.Size = new System.Drawing.Size(40, 18);
            this.pdfRadioButton.TabIndex = 1;
            this.pdfRadioButton.TabStop = false;
            this.pdfRadioButton.Text = "PDF";
            // 
            // csvRadioButton
            // 
            this.csvRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.csvRadioButton.Location = new System.Drawing.Point(14, 46);
            this.csvRadioButton.Name = "csvRadioButton";
            this.csvRadioButton.Size = new System.Drawing.Size(40, 18);
            this.csvRadioButton.TabIndex = 1;
            this.csvRadioButton.TabStop = false;
            this.csvRadioButton.Text = "CSV";
            // 
            // xlsxRadioButton
            // 
            this.xlsxRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xlsxRadioButton.Location = new System.Drawing.Point(14, 22);
            this.xlsxRadioButton.Name = "xlsxRadioButton";
            this.xlsxRadioButton.Size = new System.Drawing.Size(45, 18);
            this.xlsxRadioButton.TabIndex = 0;
            this.xlsxRadioButton.TabStop = false;
            this.xlsxRadioButton.Text = "XLSX";
            // 
            // exportVisualSettingsCheckBox
            // 
            this.exportVisualSettingsCheckBox.Location = new System.Drawing.Point(6, 105);
            this.exportVisualSettingsCheckBox.Name = "exportVisualSettingsCheckBox";
            this.exportVisualSettingsCheckBox.Size = new System.Drawing.Size(122, 18);
            this.exportVisualSettingsCheckBox.TabIndex = 6;
            this.exportVisualSettingsCheckBox.Text = "ExportVisualSettings";
            this.exportVisualSettingsCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.exportVisualSettingsCheckBox_ToggleStateChanged);
            // 
            // radPageViewPagePdfExport
            // 
            this.radPageViewPagePdfExport.Controls.Add(this.radCheckBoxShowHeaderAndFooter);
            this.radPageViewPagePdfExport.Controls.Add(this.radCheckBoxFitToPageWidth);
            this.radPageViewPagePdfExport.Controls.Add(this.radCheckBoxExportFlatDataPdfExport);
            this.radPageViewPagePdfExport.Controls.Add(this.radCheckBoxCustomizeVisualSettingsPdfExport);
            this.radPageViewPagePdfExport.Controls.Add(this.radButtonPdfExport);
            this.radPageViewPagePdfExport.Controls.Add(this.radCheckBoxExportVisualSettingsPdfExport);
            this.radPageViewPagePdfExport.ItemSize = new System.Drawing.SizeF(65F, 28F);
            this.radPageViewPagePdfExport.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPagePdfExport.Name = "radPageViewPagePdfExport";
            this.radPageViewPagePdfExport.Size = new System.Drawing.Size(274, 700);
            this.radPageViewPagePdfExport.Text = "PdfExport";
            // 
            // radCheckBoxShowHeaderAndFooter
            // 
            this.radCheckBoxShowHeaderAndFooter.Location = new System.Drawing.Point(6, 192);
            this.radCheckBoxShowHeaderAndFooter.Name = "radCheckBoxShowHeaderAndFooter";
            this.radCheckBoxShowHeaderAndFooter.Size = new System.Drawing.Size(137, 18);
            this.radCheckBoxShowHeaderAndFooter.TabIndex = 18;
            this.radCheckBoxShowHeaderAndFooter.Text = "ShowHeaderAndFooter";
            this.radCheckBoxShowHeaderAndFooter.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowHeaderAndFooter_ToggleStateChanged);
            // 
            // radCheckBoxFitToPageWidth
            // 
            this.radCheckBoxFitToPageWidth.Location = new System.Drawing.Point(6, 162);
            this.radCheckBoxFitToPageWidth.Name = "radCheckBoxFitToPageWidth";
            this.radCheckBoxFitToPageWidth.Size = new System.Drawing.Size(100, 18);
            this.radCheckBoxFitToPageWidth.TabIndex = 17;
            this.radCheckBoxFitToPageWidth.Text = "FitToPageWidth";
            // 
            // radCheckBoxExportFlatDataPdfExport
            // 
            this.radCheckBoxExportFlatDataPdfExport.Location = new System.Drawing.Point(6, 129);
            this.radCheckBoxExportFlatDataPdfExport.Name = "radCheckBoxExportFlatDataPdfExport";
            this.radCheckBoxExportFlatDataPdfExport.Size = new System.Drawing.Size(93, 18);
            this.radCheckBoxExportFlatDataPdfExport.TabIndex = 16;
            this.radCheckBoxExportFlatDataPdfExport.Text = "ExportFlatData";
            this.radCheckBoxExportFlatDataPdfExport.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxExportFlatDataPdfExport_ToggleStateChanged);
            // 
            // radCheckBoxCustomizeVisualSettingsPdfExport
            // 
            this.radCheckBoxCustomizeVisualSettingsPdfExport.AutoSize = false;
            this.radCheckBoxCustomizeVisualSettingsPdfExport.Location = new System.Drawing.Point(6, 51);
            this.radCheckBoxCustomizeVisualSettingsPdfExport.Name = "radCheckBoxCustomizeVisualSettingsPdfExport";
            this.radCheckBoxCustomizeVisualSettingsPdfExport.Size = new System.Drawing.Size(168, 38);
            this.radCheckBoxCustomizeVisualSettingsPdfExport.TabIndex = 15;
            this.radCheckBoxCustomizeVisualSettingsPdfExport.Text = "Customize visual settings when exporting";
            this.radCheckBoxCustomizeVisualSettingsPdfExport.TextWrap = true;
            ((Telerik.WinControls.UI.RadCheckBoxElement)(this.radCheckBoxCustomizeVisualSettingsPdfExport.GetChildAt(0))).Text = "Customize visual settings when exporting";
            // 
            // radButtonPdfExport
            // 
            this.radButtonPdfExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonPdfExport.Location = new System.Drawing.Point(55, 11);
            this.radButtonPdfExport.Name = "radButtonPdfExport";
            this.radButtonPdfExport.Size = new System.Drawing.Size(165, 23);
            this.radButtonPdfExport.TabIndex = 8;
            this.radButtonPdfExport.Text = "Export";
            this.radButtonPdfExport.Click += new System.EventHandler(this.radButtonPdfExport_Click);
            // 
            // radCheckBoxExportVisualSettingsPdfExport
            // 
            this.radCheckBoxExportVisualSettingsPdfExport.Location = new System.Drawing.Point(6, 96);
            this.radCheckBoxExportVisualSettingsPdfExport.Name = "radCheckBoxExportVisualSettingsPdfExport";
            this.radCheckBoxExportVisualSettingsPdfExport.Size = new System.Drawing.Size(122, 18);
            this.radCheckBoxExportVisualSettingsPdfExport.TabIndex = 14;
            this.radCheckBoxExportVisualSettingsPdfExport.Text = "ExportVisualSettings";
            this.radCheckBoxExportVisualSettingsPdfExport.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxExportVisualSettingsPdfExport_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1026, 748);
            this.Controls.Add(this.radPivotGrid1);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.settingsPanel);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Export with Document Processing Libraries";
            ((System.ComponentModel.ISupportInitialize)(this.radPivotGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPageSpreadExport.ResumeLayout(false);
            this.radPageViewPageSpreadExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exportFlatDataCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customizeVisualSettingsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csvRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlsxRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportVisualSettingsCheckBox)).EndInit();
            this.radPageViewPagePdfExport.ResumeLayout(false);
            this.radPageViewPagePdfExport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxShowHeaderAndFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxFitToPageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportFlatDataPdfExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxCustomizeVisualSettingsPdfExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPdfExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportVisualSettingsPdfExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPivotGrid radPivotGrid1;
        private Telerik.WinControls.UI.RadPanel settingsPanel;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageSpreadExport;
        private Telerik.WinControls.UI.RadCheckBox customizeVisualSettingsCheckBox;
        private Telerik.WinControls.UI.RadButton exportButton;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton txtRadioButton;
        private Telerik.WinControls.UI.RadRadioButton pdfRadioButton;
        private Telerik.WinControls.UI.RadRadioButton csvRadioButton;
        private Telerik.WinControls.UI.RadRadioButton xlsxRadioButton;
        private Telerik.WinControls.UI.RadCheckBox exportVisualSettingsCheckBox;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPagePdfExport;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxCustomizeVisualSettingsPdfExport;
        private Telerik.WinControls.UI.RadButton radButtonPdfExport;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxExportVisualSettingsPdfExport;
        private Telerik.WinControls.UI.RadCheckBox exportFlatDataCheckBox;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxExportFlatDataPdfExport;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxFitToPageWidth;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxShowHeaderAndFooter;
    }
}