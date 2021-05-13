using System.Drawing;
namespace Telerik.Examples.WinControls.GridView.Columns.GridViews
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditor2 = new Telerik.WinControls.UI.RadSpinEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.radGroupViewOpts = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupSpacing = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioGCView = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioHTML = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioTable = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupViewOpts)).BeginInit();
            this.radGroupViewOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSpacing)).BeginInit();
            this.radGroupSpacing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioGCView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioHTML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTable)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupViewOpts);
            this.settingsPanel.Location = new System.Drawing.Point(727, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 525);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupViewOpts, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            gridViewTextBoxColumn1.FieldName = "CustomerID";
            gridViewTextBoxColumn1.HeaderText = "ID ";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CustomerID";
            gridViewTextBoxColumn1.Width = 190;
            gridViewTextBoxColumn2.FieldName = "CompanyName";
            gridViewTextBoxColumn2.HeaderText = "CompanyName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "CompanyName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "ContactName";
            gridViewTextBoxColumn3.HeaderText = "ContactName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ContactName";
            gridViewTextBoxColumn3.Width = 130;
            gridViewTextBoxColumn4.FieldName = "ContactTitle";
            gridViewTextBoxColumn4.HeaderText = "ContactTitle";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ContactTitle";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "Address";
            gridViewTextBoxColumn5.HeaderText = "Address";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Address";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.FieldName = "City";
            gridViewTextBoxColumn6.HeaderText = "City";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "City";
            gridViewTextBoxColumn6.Width = 200;
            gridViewTextBoxColumn7.FieldName = "Region";
            gridViewTextBoxColumn7.HeaderText = "Region";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Region";
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.FieldName = "PostalCode";
            gridViewTextBoxColumn8.HeaderText = "PostalCode";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "PostalCode";
            gridViewTextBoxColumn9.FieldName = "Country";
            gridViewTextBoxColumn9.HeaderText = "Country";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "Country";
            gridViewTextBoxColumn9.Width = 150;
            gridViewTextBoxColumn10.FieldName = "Phone";
            gridViewTextBoxColumn10.HeaderText = "Phone";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "Phone";
            gridViewTextBoxColumn10.Width = 100;
            gridViewTextBoxColumn11.FieldName = "Fax";
            gridViewTextBoxColumn11.HeaderText = "Fax";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "Fax";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.radGridView1.MasterTemplate.DataSource = this.customersBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1009, 519);
            this.radGridView1.TabIndex = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Location = new System.Drawing.Point(81, 36);
            this.radSpinEditor1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radSpinEditor1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditor1.Name = "radSpinEditor1";
            // 
            // 
            // 
            this.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor1.Size = new System.Drawing.Size(55, 20);
            this.radSpinEditor1.TabIndex = 2;
            this.radSpinEditor1.TabStop = false;
            this.radSpinEditor1.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
   
            // 
            // radSpinEditor2
            // 
            this.radSpinEditor2.Location = new System.Drawing.Point(81, 62);
            this.radSpinEditor2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radSpinEditor2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.radSpinEditor2.Name = "radSpinEditor2";
            // 
            // 
            // 
            this.radSpinEditor2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor2.Size = new System.Drawing.Size(55, 20);
            this.radSpinEditor2.TabIndex = 3;
            this.radSpinEditor2.TabStop = false;
            this.radSpinEditor2.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
       
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cell Spacing:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Row Spacing:";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupViewOpts
            // 
            this.radGroupViewOpts.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupViewOpts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupViewOpts.Controls.Add(this.radGroupSpacing);
            this.radGroupViewOpts.Controls.Add(this.radRadioGCView);
            this.radGroupViewOpts.Controls.Add(this.radRadioHTML);
            this.radGroupViewOpts.Controls.Add(this.radRadioTable);
            this.radGroupViewOpts.FooterText = "";
            this.radGroupViewOpts.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupViewOpts.HeaderText = "View Options";
            this.radGroupViewOpts.Location = new System.Drawing.Point(10, 6);
            this.radGroupViewOpts.Name = "radGroupViewOpts";
            // 
            // 
            // 
            this.radGroupViewOpts.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupViewOpts.Size = new System.Drawing.Size(180, 196);
            this.radGroupViewOpts.TabIndex = 0;
            this.radGroupViewOpts.Text = "View Options";
            // 
            // radGroupSpacing
            // 
            this.radGroupSpacing.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupSpacing.Controls.Add(this.label1);
            this.radGroupSpacing.Controls.Add(this.radSpinEditor1);
            this.radGroupSpacing.Controls.Add(this.radSpinEditor2);
            this.radGroupSpacing.Controls.Add(this.label2);
            this.radGroupSpacing.FooterText = "";
            this.radGroupSpacing.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupSpacing.HeaderText = "Spacing Options";
            this.radGroupSpacing.Location = new System.Drawing.Point(9, 87);
            this.radGroupSpacing.Name = "radGroupSpacing";
            // 
            // 
            // 
            this.radGroupSpacing.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupSpacing.Size = new System.Drawing.Size(143, 98);
            this.radGroupSpacing.TabIndex = 8;
            this.radGroupSpacing.Text = "Spacing Options";
            // 
            // radRadioGCView
            // 
            this.radRadioGCView.Location = new System.Drawing.Point(12, 66);
            this.radRadioGCView.Name = "radRadioGCView";
            this.radRadioGCView.Size = new System.Drawing.Size(125, 18);
            this.radRadioGCView.TabIndex = 7;
            this.radRadioGCView.Text = "Column Groups View";
            // 
            // radRadioHTML
            // 
            this.radRadioHTML.Location = new System.Drawing.Point(12, 45);
            this.radRadioHTML.Name = "radRadioHTML";
            this.radRadioHTML.Size = new System.Drawing.Size(77, 18);
            this.radRadioHTML.TabIndex = 7;
            this.radRadioHTML.Text = "HTML View";
            // 
            // radRadioTable
            // 
            this.radRadioTable.Location = new System.Drawing.Point(12, 24);
            this.radRadioTable.Name = "radRadioTable";
            this.radRadioTable.Size = new System.Drawing.Size(74, 18);
            this.radRadioTable.TabIndex = 7;
            this.radRadioTable.Text = "Table View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1029, 519);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupViewOpts)).EndInit();
            this.radGroupViewOpts.ResumeLayout(false);
            this.radGroupViewOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSpacing)).EndInit();
            this.radGroupSpacing.ResumeLayout(false);
            this.radGroupSpacing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioGCView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioHTML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSet northwindDataSet;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupViewOpts;
        private Telerik.WinControls.UI.RadRadioButton radRadioGCView;
        private Telerik.WinControls.UI.RadRadioButton radRadioHTML;
        private Telerik.WinControls.UI.RadRadioButton radRadioTable;
        private Telerik.WinControls.UI.RadGroupBox radGroupSpacing;
    }
}
