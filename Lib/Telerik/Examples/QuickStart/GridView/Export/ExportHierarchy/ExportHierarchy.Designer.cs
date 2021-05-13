using Telerik.WinControls.UI;
using System.Collections.Generic;
namespace Telerik.Examples.WinControls.GridView.Export.ExportHierarchy
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.nwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.ordersTableAdapter = new DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.order_detailsTableAdapter = new DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();

            this.radComboBoxSummaries = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.radRadioButtonExcel = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonCsv = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonHtml = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButtonPdf = new Telerik.WinControls.UI.RadRadioButton();
            this.radCheckBoxExportVisual = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBoxExportHierarchy = new Telerik.WinControls.UI.RadCheckBox();
            this.radButtonExport = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHtml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportVisual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportHierarchy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupSettings);
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1125, 1);
            this.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Size = new System.Drawing.Size(200, 747);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupSettings, 0);
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "NwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // ordersTableAdapter
            //
            this.ordersTableAdapter.ClearBeforeFill = true;
            //
            // orders_detailsTableAdapter
            //
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // radComboBoxSummaries
            // 
            this.radComboBoxSummaries.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBoxSummaries.Items.AddRange(new List<RadListDataItem>(new RadListDataItem[] {
            this.radComboBoxItem3,
            this.radComboBoxItem4,
            this.radComboBoxItem5,
            this.radComboBoxItem6}));
            this.radComboBoxSummaries.Location = new System.Drawing.Point(9, 180);
            this.radComboBoxSummaries.Name = "radComboBoxSummaries";
            this.radComboBoxSummaries.NullText = "How to export summaries";
            this.radComboBoxSummaries.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxSummaries.Size = new System.Drawing.Size(143, 20);
            this.radComboBoxSummaries.TabIndex = 5;
            this.radComboBoxSummaries.TabStop = false;
          
            // 
            // radComboBoxItem3
            // 
            this.radComboBoxItem3.Text = "All Summaries";
            // 
            // radComboBoxItem4
            //
            this.radComboBoxItem4.Text = "OnlyTop Summaries";
            // 
            // radComboBoxItem5
            // 
            this.radComboBoxItem5.Text = "Only Bottom Summaries";
            // 
            // radComboBoxItem6
            // 
            this.radComboBoxItem6.Text = "Do not export summaries";
            // 
            // radRadioButtonExcel
            // 
            this.radRadioButtonExcel.Location = new System.Drawing.Point(9, 20);
            this.radRadioButtonExcel.Name = "radRadioButtonExcel";
            this.radRadioButtonExcel.Size = new System.Drawing.Size(128, 29);
            this.radRadioButtonExcel.TabIndex = 0;
            this.radRadioButtonExcel.Text = "Export to ExcelML";
     
            // 
            // radRadioButtonCsv
            // 
            this.radRadioButtonCsv.Location = new System.Drawing.Point(9, 42);
            this.radRadioButtonCsv.Name = "radRadioButtonCsv";
            this.radRadioButtonCsv.Size = new System.Drawing.Size(128, 29);
            this.radRadioButtonCsv.TabIndex = 0;
            this.radRadioButtonCsv.Text = "Export to CSV";
          
            // 
            // radRadioButtonHtml
            // 
            this.radRadioButtonHtml.Location = new System.Drawing.Point(9, 64);
            this.radRadioButtonHtml.Name = "radRadioButtonHtml";
            this.radRadioButtonHtml.Size = new System.Drawing.Size(128, 29);
            this.radRadioButtonHtml.TabIndex = 0;
            this.radRadioButtonHtml.Text = "Export to HTML";
          
            // 
            // radRadioButtonPdf
            // 
            this.radRadioButtonPdf.Location = new System.Drawing.Point(9, 86);
            this.radRadioButtonPdf.Name = "radRadioButtonPdf";
            this.radRadioButtonPdf.Size = new System.Drawing.Size(128, 29);
            this.radRadioButtonPdf.TabIndex = 0;
            this.radRadioButtonPdf.Text = "Export to PDF";
       
            // 
            // radCheckBoxExportHierarchy
            // 
            this.radCheckBoxExportHierarchy.Location = new System.Drawing.Point(9, 130);
            this.radCheckBoxExportHierarchy.Name = "radCheckBoxExportHierarchy";
            this.radCheckBoxExportHierarchy.Size = new System.Drawing.Size(125, 18);
            this.radCheckBoxExportHierarchy.TabIndex = 2;
            this.radCheckBoxExportHierarchy.Text = "Export Hierarchy";
            this.radCheckBoxExportHierarchy.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBoxExportVisual
            // 
            this.radCheckBoxExportVisual.Enabled = false;
            this.radCheckBoxExportVisual.Location = new System.Drawing.Point(9, 152);
            this.radCheckBoxExportVisual.Name = "radCheckBoxExportVisual";
            this.radCheckBoxExportVisual.Size = new System.Drawing.Size(125, 18);
            this.radCheckBoxExportVisual.TabIndex = 2;
            this.radCheckBoxExportVisual.Text = "Export Visual Settings";
            this.radCheckBoxExportVisual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radButtonExport
            // 
            this.radButtonExport.Location = new System.Drawing.Point(10, 230);
            this.radButtonExport.Name = "radButtonExport";
            this.radButtonExport.Size = new System.Drawing.Size(144, 30);
            this.radButtonExport.TabIndex = 1;
            this.radButtonExport.Text = "Run Export";

            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.MasterTemplate.DataSource = this.nwindDataSet;
            this.radGridView1.MasterTemplate.DataMember = "Orders";
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(1326, 749);
            this.radGridView1.TabIndex = 7;
            this.radGridView1.Text = "radGridView1";
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSettings.Controls.Add(this.radButtonExport);
            this.radGroupSettings.Controls.Add(this.radRadioButtonExcel);
            this.radGroupSettings.Controls.Add(this.radRadioButtonCsv);
            this.radGroupSettings.Controls.Add(this.radRadioButtonHtml);
            this.radGroupSettings.Controls.Add(this.radRadioButtonPdf);
            this.radGroupSettings.Controls.Add(this.radComboBoxSummaries);
            this.radGroupSettings.Controls.Add(this.radCheckBoxExportHierarchy);
            this.radGroupSettings.Controls.Add(this.radCheckBoxExportVisual);
            this.radGroupSettings.FooterImageIndex = -1;
            this.radGroupSettings.FooterImageKey = "";
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.HeaderImageIndex = -1;
            this.radGroupSettings.HeaderImageKey = "";
            this.radGroupSettings.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupSettings.HeaderText = "Export Settings";
            this.radGroupSettings.Location = new System.Drawing.Point(10, 6);
            this.radGroupSettings.Name = "radGroupSettings";
            this.radGroupSettings.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupSettings.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupSettings.Size = new System.Drawing.Size(180, 300);
            this.radGroupSettings.TabIndex = 8;
            this.radGroupSettings.Text = "Export Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1326, 749);

            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonCsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonHtml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButtonPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportVisual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxExportHierarchy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            this.radGroupSettings.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private RadGridView radGridView1;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindDataSet;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_detailsTableAdapter;        
        private RadCheckBox radCheckBoxExportVisual;
        private RadCheckBox radCheckBoxExportHierarchy;
        private RadButton radButtonExport;
        private RadDropDownList radComboBoxSummaries;
        private RadListDataItem radComboBoxItem3;
        private RadListDataItem radComboBoxItem4;
        private RadListDataItem radComboBoxItem5;
        private RadListDataItem radComboBoxItem6;
        private RadGroupBox radGroupSettings;

        private RadRadioButton radRadioButtonExcel;
        private RadRadioButton radRadioButtonHtml;
        private RadRadioButton radRadioButtonCsv;
        private RadRadioButton radRadioButtonPdf;
    }
}

