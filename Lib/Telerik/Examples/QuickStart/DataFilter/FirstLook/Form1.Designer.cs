namespace Telerik.Examples.WinControls.DataFilter.FirstLook
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.northwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.radDataFilter1 = new Telerik.WinControls.UI.RadDataFilter();
            this.dataFilterDescriptorItem1 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem2 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem3 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem4 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem5 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem6 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem7 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem8 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem9 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem10 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem11 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem12 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem13 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem14 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.dataFilterDescriptorItem15 = new Telerik.WinControls.UI.DataFilterDescriptorItem();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radScrollablePanel1 = new Telerik.WinControls.UI.RadScrollablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).BeginInit();
            this.radScrollablePanel1.PanelContainer.SuspendLayout();
            this.radScrollablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(819, 68);
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.northwindDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // radDataFilter1
            // 
            this.radDataFilter1.DataSource = this.ordersBindingSource;
            this.radDataFilter1.Descriptors.AddRange(new Telerik.WinControls.RadItem[] {
            this.dataFilterDescriptorItem1,
            this.dataFilterDescriptorItem2,
            this.dataFilterDescriptorItem3,
            this.dataFilterDescriptorItem4,
            this.dataFilterDescriptorItem5,
            this.dataFilterDescriptorItem6,
            this.dataFilterDescriptorItem7,
            this.dataFilterDescriptorItem8,
            this.dataFilterDescriptorItem9,
            this.dataFilterDescriptorItem10,
            this.dataFilterDescriptorItem11,
            this.dataFilterDescriptorItem12,
            this.dataFilterDescriptorItem13,
            this.dataFilterDescriptorItem14,
            this.dataFilterDescriptorItem15});
            this.radDataFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDataFilter1.Expression = "([OrderDate] < \'11/1/1996 2:14:18 PM\' OR [OrderDate] > \'10/1/1996 2:13:49 PM\') AN" +
    "D [ShipCity] = \'Seattle\' AND [ShipCountry] = \'USA\'";
            this.radDataFilter1.Location = new System.Drawing.Point(0, 0);
            this.radDataFilter1.Name = "radDataFilter1";
            this.radDataFilter1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radDataFilter1.Size = new System.Drawing.Size(597, 905);
            this.radDataFilter1.TabIndex = 2;
            this.radDataFilter1.Text = "radDataFilter1";
            // 
            // dataFilterDescriptorItem1
            // 
            this.dataFilterDescriptorItem1.DescriptorName = "OrderID";
            this.dataFilterDescriptorItem1.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem1.IsAutoGenerated = true;
            this.dataFilterDescriptorItem1.Name = "dataFilterDescriptorItem1";
            // 
            // dataFilterDescriptorItem2
            // 
            this.dataFilterDescriptorItem2.DescriptorName = "CustomerID";
            this.dataFilterDescriptorItem2.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem2.IsAutoGenerated = true;
            this.dataFilterDescriptorItem2.Name = "dataFilterDescriptorItem2";
            // 
            // dataFilterDescriptorItem3
            // 
            this.dataFilterDescriptorItem3.DescriptorName = "EmployeeID";
            this.dataFilterDescriptorItem3.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem3.IsAutoGenerated = true;
            this.dataFilterDescriptorItem3.Name = "dataFilterDescriptorItem3";
            // 
            // dataFilterDescriptorItem4
            // 
            this.dataFilterDescriptorItem4.DescriptorName = "OrderDate";
            this.dataFilterDescriptorItem4.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem4.IsAutoGenerated = true;
            this.dataFilterDescriptorItem4.Name = "dataFilterDescriptorItem4";
            // 
            // dataFilterDescriptorItem5
            // 
            this.dataFilterDescriptorItem5.DescriptorName = "RequiredDate";
            this.dataFilterDescriptorItem5.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem5.IsAutoGenerated = true;
            this.dataFilterDescriptorItem5.Name = "dataFilterDescriptorItem5";
            // 
            // dataFilterDescriptorItem6
            // 
            this.dataFilterDescriptorItem6.DescriptorName = "ShippedDate";
            this.dataFilterDescriptorItem6.DescriptorType = typeof(System.DateTime);
            this.dataFilterDescriptorItem6.IsAutoGenerated = true;
            this.dataFilterDescriptorItem6.Name = "dataFilterDescriptorItem6";
            // 
            // dataFilterDescriptorItem7
            // 
            this.dataFilterDescriptorItem7.DescriptorName = "ShipVia";
            this.dataFilterDescriptorItem7.DescriptorType = typeof(int);
            this.dataFilterDescriptorItem7.IsAutoGenerated = true;
            this.dataFilterDescriptorItem7.Name = "dataFilterDescriptorItem7";
            // 
            // dataFilterDescriptorItem8
            // 
            this.dataFilterDescriptorItem8.DescriptorName = "Freight";
            this.dataFilterDescriptorItem8.DescriptorType = typeof(decimal);
            this.dataFilterDescriptorItem8.IsAutoGenerated = true;
            this.dataFilterDescriptorItem8.Name = "dataFilterDescriptorItem8";
            // 
            // dataFilterDescriptorItem9
            // 
            this.dataFilterDescriptorItem9.DescriptorName = "ShipName";
            this.dataFilterDescriptorItem9.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem9.IsAutoGenerated = true;
            this.dataFilterDescriptorItem9.Name = "dataFilterDescriptorItem9";
            // 
            // dataFilterDescriptorItem10
            // 
            this.dataFilterDescriptorItem10.DescriptorName = "ShipAddress";
            this.dataFilterDescriptorItem10.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem10.IsAutoGenerated = true;
            this.dataFilterDescriptorItem10.Name = "dataFilterDescriptorItem10";
            // 
            // dataFilterDescriptorItem11
            // 
            this.dataFilterDescriptorItem11.DescriptorName = "ShipCity";
            this.dataFilterDescriptorItem11.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem11.IsAutoGenerated = true;
            this.dataFilterDescriptorItem11.Name = "dataFilterDescriptorItem11";
            // 
            // dataFilterDescriptorItem12
            // 
            this.dataFilterDescriptorItem12.DescriptorName = "ShipRegion";
            this.dataFilterDescriptorItem12.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem12.IsAutoGenerated = true;
            this.dataFilterDescriptorItem12.Name = "dataFilterDescriptorItem12";
            // 
            // dataFilterDescriptorItem13
            // 
            this.dataFilterDescriptorItem13.DescriptorName = "ShipPostalCode";
            this.dataFilterDescriptorItem13.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem13.IsAutoGenerated = true;
            this.dataFilterDescriptorItem13.Name = "dataFilterDescriptorItem13";
            // 
            // dataFilterDescriptorItem14
            // 
            this.dataFilterDescriptorItem14.DescriptorName = "ShipCountry";
            this.dataFilterDescriptorItem14.DescriptorType = typeof(string);
            this.dataFilterDescriptorItem14.IsAutoGenerated = true;
            this.dataFilterDescriptorItem14.Name = "dataFilterDescriptorItem14";
            // 
            // dataFilterDescriptorItem15
            // 
            this.dataFilterDescriptorItem15.DescriptorName = "OrdersOrder Details";
            this.dataFilterDescriptorItem15.DescriptorType = typeof(System.ComponentModel.IBindingList);
            this.dataFilterDescriptorItem15.IsAutoGenerated = true;
            this.dataFilterDescriptorItem15.Name = "dataFilterDescriptorItem15";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "OrderID";
            gridViewDecimalColumn1.HeaderText = "OrderID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "OrderID";
            gridViewDecimalColumn1.Width = 98;
            gridViewTextBoxColumn1.FieldName = "CustomerID";
            gridViewTextBoxColumn1.HeaderText = "CustomerID";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CustomerID";
            gridViewTextBoxColumn1.Width = 98;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "EmployeeID";
            gridViewDecimalColumn2.HeaderText = "EmployeeID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "EmployeeID";
            gridViewDecimalColumn2.Width = 68;
            gridViewDateTimeColumn1.CustomFormat = "";
            gridViewDateTimeColumn1.FieldName = "OrderDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:MM/dd/yyyy}";
            gridViewDateTimeColumn1.HeaderText = "OrderDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "OrderDate";
            gridViewDateTimeColumn1.Width = 98;
            gridViewDateTimeColumn2.CustomFormat = "";
            gridViewDateTimeColumn2.FieldName = "RequiredDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn2.FormatString = "{0:MM/dd/yyyy}";
            gridViewDateTimeColumn2.HeaderText = "RequiredDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "RequiredDate";
            gridViewDateTimeColumn2.Width = 98;
            gridViewDateTimeColumn3.CustomFormat = "";
            gridViewDateTimeColumn3.FieldName = "ShippedDate";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn3.FormatString = "{0:MM/dd/yyyy}";
            gridViewDateTimeColumn3.HeaderText = "ShippedDate";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "ShippedDate";
            gridViewDateTimeColumn3.Width = 98;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "ShipVia";
            gridViewDecimalColumn3.HeaderText = "ShipVia";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "ShipVia";
            gridViewDecimalColumn3.Width = 74;
            gridViewDecimalColumn4.FieldName = "Freight";
            gridViewDecimalColumn4.HeaderText = "Freight";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Freight";
            gridViewDecimalColumn4.Width = 98;
            gridViewTextBoxColumn2.FieldName = "ShipName";
            gridViewTextBoxColumn2.HeaderText = "ShipName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "ShipName";
            gridViewTextBoxColumn2.Width = 96;
            gridViewTextBoxColumn3.FieldName = "ShipAddress";
            gridViewTextBoxColumn3.HeaderText = "ShipAddress";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ShipAddress";
            gridViewTextBoxColumn3.Width = 74;
            gridViewTextBoxColumn4.FieldName = "ShipCity";
            gridViewTextBoxColumn4.HeaderText = "ShipCity";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ShipCity";
            gridViewTextBoxColumn4.Width = 98;
            gridViewTextBoxColumn5.FieldName = "ShipRegion";
            gridViewTextBoxColumn5.HeaderText = "ShipRegion";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "ShipRegion";
            gridViewTextBoxColumn5.Width = 98;
            gridViewTextBoxColumn6.FieldName = "ShipPostalCode";
            gridViewTextBoxColumn6.HeaderText = "ShipPostalCode";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "ShipPostalCode";
            gridViewTextBoxColumn6.Width = 74;
            gridViewTextBoxColumn7.FieldName = "ShipCountry";
            gridViewTextBoxColumn7.HeaderText = "ShipCountry";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "ShipCountry";
            gridViewTextBoxColumn7.Width = 92;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn2,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDateTimeColumn3,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.radGridView1.MasterTemplate.DataSource = this.ordersBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(889, 905);
            this.radGridView1.TabIndex = 3;
            this.radGridView1.Text = "radGridView1";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Size = new System.Drawing.Size(1490, 905);
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radDataFilter1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(400, 200);
            this.splitPanel1.Size = new System.Drawing.Size(597, 905);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.09811828F, 0F);
            this.splitPanel1.SizeInfo.MinimumSize = new System.Drawing.Size(400, 200);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-141, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radGridView1);
            this.splitPanel2.Location = new System.Drawing.Point(601, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(400, 200);
            this.splitPanel2.Size = new System.Drawing.Size(889, 905);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.09811831F, 0F);
            this.splitPanel2.SizeInfo.MinimumSize = new System.Drawing.Size(400, 200);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(141, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // radScrollablePanel1
            // 
            this.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScrollablePanel1.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel1.Name = "radScrollablePanel1";
            // 
            // radScrollablePanel1.PanelContainer
            // 
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radSplitContainer1);
            this.radScrollablePanel1.PanelContainer.MinimumSize = new System.Drawing.Size(800, 200);
            this.radScrollablePanel1.PanelContainer.Size = new System.Drawing.Size(1490, 905);
            this.radScrollablePanel1.Size = new System.Drawing.Size(1492, 907);
            this.radScrollablePanel1.TabIndex = 2;
            this.radScrollablePanel1.Text = "radScrollablePanel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radScrollablePanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1502, 917);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.radScrollablePanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDataFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.radScrollablePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).EndInit();
            this.radScrollablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSources.NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Telerik.WinControls.UI.RadDataFilter radDataFilter1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem1;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem2;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem3;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem4;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem5;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem6;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem7;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem8;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem9;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem10;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem11;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem12;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem13;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem14;
        private Telerik.WinControls.UI.DataFilterDescriptorItem dataFilterDescriptorItem15;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel1;
    }
}