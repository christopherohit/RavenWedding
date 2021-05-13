namespace Telerik.Examples.WinControls.Spreadsheet.SortingAndFiltering
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
            Telerik.Windows.Documents.Spreadsheet.Model.Workbook workbook2 = new Telerik.Windows.Documents.Spreadsheet.Model.Workbook();
            this.radSpreadsheet1 = new Telerik.WinControls.UI.RadSpreadsheet();
            this.radSpreadsheetRibbonBar1 = new Telerik.WinControls.UI.RadSpreadsheetRibbonBar();
            this.filterByMonthSortByCompanyRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.filterByCompanySortByFillRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.topFilterAndCustomSortRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.removeFilterAndSortRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheetRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterByMonthSortByCompanyRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterByCompanySortByFillRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topFilterAndCustomSortRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeFilterAndSortRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 54);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 241);
            this.settingsPanel.Size = new System.Drawing.Size(230, 241);
            // 
            // radSpreadsheet1
            // 
            this.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSpreadsheet1.Location = new System.Drawing.Point(0, 168);
            this.radSpreadsheet1.Name = "radSpreadsheet1";
            this.radSpreadsheet1.Size = new System.Drawing.Size(1473, 618);
            this.radSpreadsheet1.TabIndex = 2;
            workbook2.ActiveTabIndex = -1;
            workbook2.Name = "Book1";
            workbook2.WorkbookContentChangedInterval = System.TimeSpan.Parse("00:00:00.0300000");
            this.radSpreadsheet1.Workbook = workbook2;
            // 
            // radSpreadsheetRibbonBar1
            // 
            this.radSpreadsheetRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;
            this.radSpreadsheetRibbonBar1.AssociatedSpreadsheet = this.radSpreadsheet1;
            // 
            // 
            // 
            this.radSpreadsheetRibbonBar1.ExitButton.Text = "Exit";
            this.radSpreadsheetRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radSpreadsheetRibbonBar1.Name = "radSpreadsheetRibbonBar1";
            // 
            // 
            // 
            this.radSpreadsheetRibbonBar1.OptionsButton.Text = "Options";
            this.radSpreadsheetRibbonBar1.Size = new System.Drawing.Size(1473, 168);
            this.radSpreadsheetRibbonBar1.TabIndex = 0;
            this.radSpreadsheetRibbonBar1.Text = "Sorting and Filtering";
            // 
            // filterByMonthSortByCompanyRadioButton
            // 
            this.filterByMonthSortByCompanyRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterByMonthSortByCompanyRadioButton.AutoSize = false;
            this.filterByMonthSortByCompanyRadioButton.Location = new System.Drawing.Point(6, 21);
            this.filterByMonthSortByCompanyRadioButton.Name = "filterByMonthSortByCompanyRadioButton";
            this.filterByMonthSortByCompanyRadioButton.Size = new System.Drawing.Size(199, 36);
            this.filterByMonthSortByCompanyRadioButton.TabIndex = 1;
            this.filterByMonthSortByCompanyRadioButton.TabStop = false;
            this.filterByMonthSortByCompanyRadioButton.Tag = "NotAutoSized";
            this.filterByMonthSortByCompanyRadioButton.Text = "Filter by June and Sort by company";
            this.filterByMonthSortByCompanyRadioButton.TextWrap = true;
            this.filterByMonthSortByCompanyRadioButton.Click += new System.EventHandler(this.FilterByMonthSortByCompanyRadioButton_Click);
            // 
            // filterByCompanySortByFillRadioButton
            // 
            this.filterByCompanySortByFillRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterByCompanySortByFillRadioButton.AutoSize = false;
            this.filterByCompanySortByFillRadioButton.Location = new System.Drawing.Point(6, 63);
            this.filterByCompanySortByFillRadioButton.Name = "filterByCompanySortByFillRadioButton";
            this.filterByCompanySortByFillRadioButton.Size = new System.Drawing.Size(199, 36);
            this.filterByCompanySortByFillRadioButton.TabIndex = 2;
            this.filterByCompanySortByFillRadioButton.TabStop = false;
            this.filterByCompanySortByFillRadioButton.Tag = "NotAutoSized";
            this.filterByCompanySortByFillRadioButton.Text = "Filter by \"Plan Smart\" Company and Sort by status";
            this.filterByCompanySortByFillRadioButton.TextWrap = true;
            this.filterByCompanySortByFillRadioButton.Click += new System.EventHandler(this.FilterByCompanySortByFillRadioButton_Click);
            // 
            // topFilterAndCustomSortRadioButton
            // 
            this.topFilterAndCustomSortRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topFilterAndCustomSortRadioButton.AutoSize = false;
            this.topFilterAndCustomSortRadioButton.Location = new System.Drawing.Point(6, 105);
            this.topFilterAndCustomSortRadioButton.Name = "topFilterAndCustomSortRadioButton";
            this.topFilterAndCustomSortRadioButton.Size = new System.Drawing.Size(199, 36);
            this.topFilterAndCustomSortRadioButton.TabIndex = 4;
            this.topFilterAndCustomSortRadioButton.TabStop = false;
            this.topFilterAndCustomSortRadioButton.Tag = "NotAutoSized";
            this.topFilterAndCustomSortRadioButton.Text = "Filter Top 20 Percent of Discounts and Sort by shipping type";
            this.topFilterAndCustomSortRadioButton.TextWrap = true;
            this.topFilterAndCustomSortRadioButton.Click += new System.EventHandler(this.TopFilterAndCustomSortRadioButton_Click);
            // 
            // removeFilterAndSortRadioButton
            // 
            this.removeFilterAndSortRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeFilterAndSortRadioButton.AutoSize = false;
            this.removeFilterAndSortRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeFilterAndSortRadioButton.Location = new System.Drawing.Point(6, 147);
            this.removeFilterAndSortRadioButton.Name = "removeFilterAndSortRadioButton";
            this.removeFilterAndSortRadioButton.Size = new System.Drawing.Size(199, 36);
            this.removeFilterAndSortRadioButton.TabIndex = 3;
            this.removeFilterAndSortRadioButton.Tag = "NotAutoSized";
            this.removeFilterAndSortRadioButton.Text = "No filters and sort conditions";
            this.removeFilterAndSortRadioButton.TextWrap = true;
            this.removeFilterAndSortRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.removeFilterAndSortRadioButton.Click += new System.EventHandler(this.RemoveFilterAndSortRadioButton_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.filterByMonthSortByCompanyRadioButton);
            this.radGroupBox1.Controls.Add(this.topFilterAndCustomSortRadioButton);
            this.radGroupBox1.Controls.Add(this.removeFilterAndSortRadioButton);
            this.radGroupBox1.Controls.Add(this.filterByCompanySortByFillRadioButton);
            this.radGroupBox1.HeaderText = "Sort and Filter Options";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 192);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Sort and Filter Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radSpreadsheet1);
            this.Controls.Add(this.radSpreadsheetRibbonBar1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1483, 796);
            this.Controls.SetChildIndex(this.radSpreadsheetRibbonBar1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radSpreadsheet1, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheetRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterByMonthSortByCompanyRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterByCompanySortByFillRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topFilterAndCustomSortRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeFilterAndSortRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSpreadsheet radSpreadsheet1;
        private Telerik.WinControls.UI.RadSpreadsheetRibbonBar radSpreadsheetRibbonBar1;
        private Telerik.WinControls.UI.RadRadioButton topFilterAndCustomSortRadioButton;
        private Telerik.WinControls.UI.RadRadioButton filterByCompanySortByFillRadioButton;
        private Telerik.WinControls.UI.RadRadioButton removeFilterAndSortRadioButton;
        private Telerik.WinControls.UI.RadRadioButton filterByMonthSortByCompanyRadioButton;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}