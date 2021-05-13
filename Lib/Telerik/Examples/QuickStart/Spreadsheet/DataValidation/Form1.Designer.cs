namespace Telerik.Examples.WinControls.Spreadsheet.DataValidation
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
            Telerik.Windows.Documents.Spreadsheet.Model.Workbook workbook1 = new Telerik.Windows.Documents.Spreadsheet.Model.Workbook();
            this.clearInvalidDataCirclesRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.circleInvalidDataRadioButton = new Telerik.WinControls.UI.RadRadioButton();
            this.radSpreadsheet1 = new Telerik.WinControls.UI.RadSpreadsheet();
            this.radSpreadsheetRibbonBar1 = new Telerik.WinControls.UI.RadSpreadsheetRibbonBar();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearInvalidDataCirclesRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleInvalidDataRadioButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheetRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(0, 221);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(230, 156);
            this.settingsPanel.Size = new System.Drawing.Size(230, 156);
            // 
            // clearInvalidDataCirclesRadioButton
            // 
            this.clearInvalidDataCirclesRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearInvalidDataCirclesRadioButton.AutoSize = false;
            this.clearInvalidDataCirclesRadioButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearInvalidDataCirclesRadioButton.Location = new System.Drawing.Point(5, 63);
            this.clearInvalidDataCirclesRadioButton.Name = "clearInvalidDataCirclesRadioButton";
            this.clearInvalidDataCirclesRadioButton.Size = new System.Drawing.Size(200, 36);
            this.clearInvalidDataCirclesRadioButton.TabIndex = 4;
            this.clearInvalidDataCirclesRadioButton.Tag = "NotAutoSized";
            this.clearInvalidDataCirclesRadioButton.Text = "Clear invalid data circles";
            this.clearInvalidDataCirclesRadioButton.TextWrap = true;
            this.clearInvalidDataCirclesRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.clearInvalidDataCirclesRadioButton.Click += new System.EventHandler(this.ClearInvalidDataCirclesRadioButton_Click);
            // 
            // circleInvalidDataRadioButton
            // 
            this.circleInvalidDataRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circleInvalidDataRadioButton.AutoSize = false;
            this.circleInvalidDataRadioButton.Location = new System.Drawing.Point(5, 21);
            this.circleInvalidDataRadioButton.Name = "circleInvalidDataRadioButton";
            this.circleInvalidDataRadioButton.Size = new System.Drawing.Size(200, 36);
            this.circleInvalidDataRadioButton.TabIndex = 3;
            this.circleInvalidDataRadioButton.Tag = "NotAutoSized";
            this.circleInvalidDataRadioButton.Text = "Circle invalid data";
            this.circleInvalidDataRadioButton.TextWrap = true;
            this.circleInvalidDataRadioButton.Click += new System.EventHandler(this.CircleInvalidDataRadioButton_Click);
            // 
            // radSpreadsheet1
            // 
            this.radSpreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSpreadsheet1.Location = new System.Drawing.Point(0, 168);
            this.radSpreadsheet1.Name = "radSpreadsheet1";
            this.radSpreadsheet1.Size = new System.Drawing.Size(1473, 618);
            this.radSpreadsheet1.TabIndex = 2;
            workbook1.ActiveTabIndex = -1;
            workbook1.Name = "Book1";
            workbook1.WorkbookContentChangedInterval = System.TimeSpan.Parse("00:00:00.0300000");
            this.radSpreadsheet1.Workbook = workbook1;
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
            this.radSpreadsheetRibbonBar1.Text = "Data Validation";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.circleInvalidDataRadioButton);
            this.radGroupBox1.Controls.Add(this.clearInvalidDataCirclesRadioButton);
            this.radGroupBox1.HeaderText = "Data Validation Options";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 32);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 108);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Data Validation Options";
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
            ((System.ComponentModel.ISupportInitialize)(this.clearInvalidDataCirclesRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleInvalidDataRadioButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpreadsheetRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRadioButton clearInvalidDataCirclesRadioButton;
        private Telerik.WinControls.UI.RadRadioButton circleInvalidDataRadioButton;
        private Telerik.WinControls.UI.RadSpreadsheet radSpreadsheet1;
        private Telerik.WinControls.UI.RadSpreadsheetRibbonBar radSpreadsheetRibbonBar1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}