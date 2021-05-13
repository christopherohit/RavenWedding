using Telerik.WinControls.UI;
using System.Collections.Generic;
namespace Telerik.Examples.WinControls.GridView.Export.ExportMethods
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindRadGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.customersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBoxSheet = new Telerik.WinControls.UI.RadTextBox();
            this.radComboBoxSummaries = new Telerik.WinControls.UI.RadDropDownList();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radCheckBoxExportVisual = new Telerik.WinControls.UI.RadCheckBox();
            this.radButtonExport = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLblProgress = new Telerik.WinControls.UI.RadLabel();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radListBox1 = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupSettings);
            this.settingsPanel.Location = new System.Drawing.Point(1125, 1);
            this.settingsPanel.Size = new System.Drawing.Size(230, 747);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.radGroupSettings, 0);
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(10, 323);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.radProgressBar1.SeparatorWidth = 4;
            this.radProgressBar1.Size = new System.Drawing.Size(190, 17);
            this.radProgressBar1.StepWidth = 13;
            this.radProgressBar1.TabIndex = 5;
            this.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radProgressBar1.Visible = false;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindRadGridView;
            // 
            // nwindRadGridView
            // 
            this.nwindRadGridView.DataSetName = "NwindRadGridView";
            this.nwindRadGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(9, 254);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 18);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "Sheet name:";
            // 
            // radTextBoxSheet
            // 
            this.radTextBoxSheet.Location = new System.Drawing.Point(10, 275);
            this.radTextBoxSheet.Name = "radTextBoxSheet";
            this.radTextBoxSheet.Size = new System.Drawing.Size(190, 20);
            this.radTextBoxSheet.TabIndex = 6;
            this.radTextBoxSheet.TabStop = false;
            // 
            // radComboBoxSummaries
            // 
            this.radComboBoxSummaries.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem5.Text = "All Summaries";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "OnlyTop Summaries";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "Only Bottom Summaries";
            radListDataItem7.TextWrap = true;
            radListDataItem8.Text = "Do not export summaries";
            radListDataItem8.TextWrap = true;
            this.radComboBoxSummaries.Items.Add(radListDataItem5);
            this.radComboBoxSummaries.Items.Add(radListDataItem6);
            this.radComboBoxSummaries.Items.Add(radListDataItem7);
            this.radComboBoxSummaries.Items.Add(radListDataItem8);
            this.radComboBoxSummaries.Location = new System.Drawing.Point(10, 227);
            this.radComboBoxSummaries.Name = "radComboBoxSummaries";
            this.radComboBoxSummaries.NullText = "How to export summaries";
            // 
            // 
            // 
            this.radComboBoxSummaries.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxSummaries.Size = new System.Drawing.Size(190, 20);
            this.radComboBoxSummaries.TabIndex = 5;
           
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Enabled = false;
            this.radRadioButton2.Location = new System.Drawing.Point(9, 191);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(128, 33);
            this.radRadioButton2.TabIndex = 4;
            this.radRadioButton2.Text = "Max rows supported\r\nby prior versions";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Enabled = false;
            this.radRadioButton1.Location = new System.Drawing.Point(9, 155);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(128, 33);
            this.radRadioButton1.TabIndex = 3;
            this.radRadioButton1.TabStop = true;
            this.radRadioButton1.Text = "Max rows supported\r\nby Excel 2007";
            this.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBoxExportVisual
            // 
            this.radCheckBoxExportVisual.Enabled = false;
            this.radCheckBoxExportVisual.Location = new System.Drawing.Point(9, 131);
            this.radCheckBoxExportVisual.Name = "radCheckBoxExportVisual";
            this.radCheckBoxExportVisual.Size = new System.Drawing.Size(125, 18);
            this.radCheckBoxExportVisual.TabIndex = 2;
            this.radCheckBoxExportVisual.Text = "Export visual settings";
            this.radCheckBoxExportVisual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radButtonExport
            // 
            this.radButtonExport.Location = new System.Drawing.Point(10, 355);
            this.radButtonExport.Name = "radButtonExport";
            this.radButtonExport.Size = new System.Drawing.Size(190, 27);
            this.radButtonExport.TabIndex = 1;
            this.radButtonExport.Text = "Run Export";
          
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "CompanyName";
            gridViewTextBoxColumn1.HeaderText = "Company Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CompanyName";
            gridViewTextBoxColumn1.Width = 192;
            gridViewTextBoxColumn2.FieldName = "ContactName";
            gridViewTextBoxColumn2.HeaderText = "Contact Name";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ContactName";
            gridViewTextBoxColumn2.Width = 192;
            gridViewTextBoxColumn3.FieldName = "ContactTitle";
            gridViewTextBoxColumn3.HeaderText = "Contact Title";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ContactTitle";
            gridViewTextBoxColumn3.Width = 192;
            gridViewTextBoxColumn4.FieldName = "Address";
            gridViewTextBoxColumn4.HeaderText = "Address";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Address";
            gridViewTextBoxColumn4.Width = 192;
            gridViewTextBoxColumn5.FieldName = "City";
            gridViewTextBoxColumn5.HeaderText = "City";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "City";
            gridViewTextBoxColumn5.Width = 192;
            gridViewTextBoxColumn6.FieldName = "Country";
            gridViewTextBoxColumn6.HeaderText = "Country";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Country";
            gridViewTextBoxColumn6.Width = 192;
            gridViewTextBoxColumn7.FieldName = "Phone";
            gridViewTextBoxColumn7.HeaderText = "Phone";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Phone";
            gridViewTextBoxColumn7.Width = 197;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView1.MasterTemplate.DataSource = this.customersBindingSource;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(1364, 519);
            this.radGridView1.TabIndex = 7;
            this.radGridView1.Text = "radGridView1";
            // 
            // radLblProgress
            // 
            this.radLblProgress.Location = new System.Drawing.Point(9, 302);
            this.radLblProgress.Name = "radLblProgress";
            this.radLblProgress.Size = new System.Drawing.Size(52, 18);
            this.radLblProgress.TabIndex = 7;
            this.radLblProgress.Text = "Progress:";
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSettings.Controls.Add(this.radListBox1);
            this.radGroupSettings.Controls.Add(this.radTextBoxSheet);
            this.radGroupSettings.Controls.Add(this.radLabel1);
            this.radGroupSettings.Controls.Add(this.radButtonExport);
            this.radGroupSettings.Controls.Add(this.radRadioButton1);
            this.radGroupSettings.Controls.Add(this.radRadioButton2);
            this.radGroupSettings.Controls.Add(this.radProgressBar1);
            this.radGroupSettings.Controls.Add(this.radComboBoxSummaries);
            this.radGroupSettings.Controls.Add(this.radLblProgress);
            this.radGroupSettings.Controls.Add(this.radCheckBoxExportVisual);
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.HeaderText = "Export Settings";
            this.radGroupSettings.Location = new System.Drawing.Point(10, 6);
            this.radGroupSettings.Name = "radGroupSettings";
            this.radGroupSettings.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupSettings.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupSettings.Size = new System.Drawing.Size(210, 424);
            this.radGroupSettings.TabIndex = 8;
            this.radGroupSettings.Text = "Export Settings";
            // 
            // radListBox1
            // 
            radListDataItem1.Text = "Export to Excel";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Export to CSV";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Export to HTML";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Export to PDF";
            radListDataItem4.TextWrap = true;
            this.radListBox1.Items.Add(radListDataItem1);
            this.radListBox1.Items.Add(radListDataItem2);
            this.radListBox1.Items.Add(radListDataItem3);
            this.radListBox1.Items.Add(radListDataItem4);
            this.radListBox1.Location = new System.Drawing.Point(10, 23);
            this.radListBox1.Name = "radListBox1";
            this.radListBox1.Size = new System.Drawing.Size(190, 102);
            this.radListBox1.TabIndex = 8;
            this.radListBox1.Text = "Export to Excel";
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1364, 519);

            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindRadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            this.radGroupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private RadProgressBar radProgressBar1;
		private RadGridView radGridView1;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindRadGridView;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private RadRadioButton radRadioButton2;
        private RadRadioButton radRadioButton1;
        private RadCheckBox radCheckBoxExportVisual;
        private RadButton radButtonExport;
        private RadTextBox radTextBoxSheet;
        private RadDropDownList radComboBoxSummaries;
        private RadLabel radLabel1;
        private RadLabel radLblProgress;
        private RadGroupBox radGroupSettings;
        private RadListControl radListBox1;
    }
}

