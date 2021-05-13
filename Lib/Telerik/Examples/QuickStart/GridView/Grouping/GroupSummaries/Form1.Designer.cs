using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.WinControls.UI;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.GridView.Grouping.GroupSummaries
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGridViewDemo = new Telerik.WinControls.UI.RadGridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSetGridView = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.radComboFunction = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboPosition = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem3 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBox3 = new Telerik.WinControls.UI.RadDropDownList();
            this.radComboBoxItem6 = new Telerik.WinControls.UI.RadListDataItem();
            this.radComboBoxItem5 = new Telerik.WinControls.UI.RadListDataItem();
            this.radButtonAddSummary = new Telerik.WinControls.UI.RadButton();
            this.radComboColumn = new Telerik.WinControls.UI.RadDropDownList();
            this.ordersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.radLblTip = new Telerik.WinControls.UI.RadLabel();
            this.radLblFuncName = new Telerik.WinControls.UI.RadLabel();
            this.radLblColumn = new Telerik.WinControls.UI.RadLabel();
            this.radLblPosition = new Telerik.WinControls.UI.RadLabel();
            this.radLblIn = new Telerik.WinControls.UI.RadLabel();
            this.radGroupOptions = new Telerik.WinControls.UI.RadGroupBox();
            this.radCheckBoxPinRow = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSetGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFuncName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupOptions)).BeginInit();
            this.radGroupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxPinRow)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupOptions);
            this.settingsPanel.Controls.Add(this.radLblTip);
            this.settingsPanel.Location = new System.Drawing.Point(751, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 723);
            this.settingsPanel.Controls.SetChildIndex(this.radLblTip, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupOptions, 0);
            // 
            // radGridViewDemo
            // 
            this.radGridViewDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewDemo.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridViewDemo.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridViewDemo.MasterTemplate.Caption = "Products";
            gridViewTextBoxColumn1.FieldName = "CustomerID";
            gridViewTextBoxColumn1.FormatString = "{0: ddd, MM/dd}";
            gridViewTextBoxColumn1.HeaderText = "Customer ID";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CustomerID";
            gridViewTextBoxColumn1.Width = 117;
            gridViewDateTimeColumn1.DataType = typeof(System.DateTime);
            gridViewDateTimeColumn1.FieldName = "OrderDate";
            gridViewDateTimeColumn1.HeaderText = "Order Date";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "OrderDate";
            gridViewDateTimeColumn1.Width = 117;
            gridViewDateTimeColumn2.DataType = typeof(System.DateTime);
            gridViewDateTimeColumn2.FieldName = "ShippedDate";
            gridViewDateTimeColumn2.HeaderText = "Shipped Date";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "ShippedDate";
            gridViewDateTimeColumn2.Width = 117;
            gridViewDecimalColumn1.DataType = typeof(decimal);
            gridViewDecimalColumn1.FieldName = "Freight";
            gridViewDecimalColumn1.HeaderText = "Freight";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Freight";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewDecimalColumn1.Width = 117;
            gridViewTextBoxColumn2.FieldName = "ShipName";
            gridViewTextBoxColumn2.HeaderText = "Ship Name";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ShipName";
            gridViewTextBoxColumn2.Width = 117;
            gridViewTextBoxColumn3.FieldName = "ShipAddress";
            gridViewTextBoxColumn3.HeaderText = "Ship Address";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ShipAddress";
            gridViewTextBoxColumn3.Width = 117;
            gridViewTextBoxColumn4.FieldName = "ShipCity";
            gridViewTextBoxColumn4.HeaderText = "Ship City";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ShipCity";
            gridViewTextBoxColumn4.Width = 117;
            gridViewTextBoxColumn5.FieldName = "ShipCountry";
            gridViewTextBoxColumn5.HeaderText = "Ship Country";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "ShipCountry";
            gridViewTextBoxColumn5.Width = 119;
            this.radGridViewDemo.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.radGridViewDemo.MasterTemplate.DataSource = this.ordersBindingSource;
            this.radGridViewDemo.Name = "radGridViewDemo";
            this.radGridViewDemo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridViewDemo.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridViewDemo.Size = new System.Drawing.Size(952, 725);
            this.radGridViewDemo.TabIndex = 5;
            this.radGridViewDemo.TabStop = false;
            this.radGridViewDemo.Text = "radGridView1";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.nwindDataSetGridView;
            // 
            // nwindDataSetGridView
            // 
            this.nwindDataSetGridView.DataSetName = "NwindDataSetGridView";
            this.nwindDataSetGridView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radComboFunction
            // 
            this.radComboFunction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radComboFunction.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboFunction.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboFunction.Location = new System.Drawing.Point(21, 60);
            this.radComboFunction.Name = "radComboFunction";
            // 
            // 
            // 
            this.radComboFunction.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboFunction.Size = new System.Drawing.Size(138, 20);
            this.radComboFunction.TabIndex = 0;
            this.radComboFunction.TabStop = false;
            // 
            // radComboBoxItem1
            // 
            this.radComboBoxItem1.Text = "Group Header Row";
            // 
            // radComboPosition
            // 
            this.radComboPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radComboPosition.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboPosition.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboPosition.Items.AddRange(new List<RadListDataItem>( new RadListDataItem[] {
            this.radComboBoxItem2,
            this.radComboBoxItem3,
            this.radComboBoxItem4}));
            this.radComboPosition.Location = new System.Drawing.Point(21, 201);
            this.radComboPosition.Name = "radComboPosition";
            // 
            // 
            // 
            this.radComboPosition.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboPosition.Size = new System.Drawing.Size(138, 20);
            this.radComboPosition.TabIndex = 2;
            this.radComboPosition.TabStop = false;
         
            // 
            // radComboBoxItem2
            // 
            this.radComboBoxItem2.Text = "Group Header Row";
            // 
            // radComboBoxItem3
            // 
            this.radComboBoxItem3.Text = "Top Summary Rows";
            // 
            // radComboBoxItem4
            // 
            this.radComboBoxItem4.Text = "Bottom Summary Rows";
            // 
            // radComboBox3
            // 
            this.radComboBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radComboBox3.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboBox3.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBox3.Items.AddRange(new List<RadListDataItem>( new RadListDataItem[] {
            this.radComboBoxItem6,
            this.radComboBoxItem5}));
            this.radComboBox3.Location = new System.Drawing.Point(21, 265);
            this.radComboBox3.Name = "radComboBox3";
            // 
            // 
            // 
            this.radComboBox3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBox3.Size = new System.Drawing.Size(138, 20);
            this.radComboBox3.TabIndex = 3;
            this.radComboBox3.TabStop = false;
            // 
            // radComboBoxItem6
            // 
            this.radComboBoxItem6.Text = "Row 1";
            // 
            // radComboBoxItem5
            // 
            this.radComboBoxItem5.Text = "New Row";
            // 
            // radButtonAddSummary
            // 
            this.radButtonAddSummary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radButtonAddSummary.Location = new System.Drawing.Point(21, 306);
            this.radButtonAddSummary.Name = "radButtonAddSummary";
            this.radButtonAddSummary.Size = new System.Drawing.Size(138, 21);
            this.radButtonAddSummary.TabIndex = 4;
            this.radButtonAddSummary.Text = "Add";
       
            // 
            // radComboColumn
            // 
            this.radComboColumn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radComboColumn.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
            this.radComboColumn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboColumn.Location = new System.Drawing.Point(21, 124);
            this.radComboColumn.Name = "radComboColumn";
            // 
            // 
            // 
            this.radComboColumn.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboColumn.Size = new System.Drawing.Size(138, 20);
            this.radComboColumn.TabIndex = 1;
            this.radComboColumn.TabStop = false;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // radLblTip
            // 
            this.radLblTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLblTip.AutoSize = false;
            this.radLblTip.Location = new System.Drawing.Point(10, 386);
            this.radLblTip.MaximumSize = new System.Drawing.Size(175, 0);
            this.radLblTip.Name = "radLblTip";
            this.radLblTip.Size = new System.Drawing.Size(180, 106);
            this.radLblTip.TabIndex = 9;
            this.radLblTip.Text = "The grid is initially grouped by Customer ID and the sum of each customer\'s order" +
                "s\' freight is calculated.\r\n\r\nYou can use the controls below in order to apply cu" +
                "stom group summaries.";
            // 
            // radLblFuncName
            // 
            this.radLblFuncName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLblFuncName.Location = new System.Drawing.Point(21, 31);
            this.radLblFuncName.Name = "radLblFuncName";
            this.radLblFuncName.Size = new System.Drawing.Size(94, 18);
            this.radLblFuncName.TabIndex = 10;
            this.radLblFuncName.Text = "1. Select function:";
            // 
            // radLblColumn
            // 
            this.radLblColumn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLblColumn.Location = new System.Drawing.Point(21, 95);
            this.radLblColumn.Name = "radLblColumn";
            this.radLblColumn.Size = new System.Drawing.Size(90, 18);
            this.radLblColumn.TabIndex = 10;
            this.radLblColumn.Text = "2. Select column:";
            // 
            // radLblPosition
            // 
            this.radLblPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLblPosition.Location = new System.Drawing.Point(21, 159);
            this.radLblPosition.Name = "radLblPosition";
            this.radLblPosition.Size = new System.Drawing.Size(132, 33);
            this.radLblPosition.TabIndex = 10;
            this.radLblPosition.Text = "3. Select location for the\r\nsummary:";
            // 
            // radLblIn
            // 
            this.radLblIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLblIn.Location = new System.Drawing.Point(21, 236);
            this.radLblIn.Name = "radLblIn";
            this.radLblIn.Size = new System.Drawing.Size(102, 18);
            this.radLblIn.TabIndex = 10;
            this.radLblIn.Text = "4. Add summary in:";
            // 
            // radGroupOptions
            // 
            this.radGroupOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupOptions.Controls.Add(this.radCheckBoxPinRow);
            this.radGroupOptions.Controls.Add(this.radLblFuncName);
            this.radGroupOptions.Controls.Add(this.radLblIn);
            this.radGroupOptions.Controls.Add(this.radComboBox3);
            this.radGroupOptions.Controls.Add(this.radLblPosition);
            this.radGroupOptions.Controls.Add(this.radComboColumn);
            this.radGroupOptions.Controls.Add(this.radLblColumn);
            this.radGroupOptions.Controls.Add(this.radComboPosition);
            this.radGroupOptions.Controls.Add(this.radButtonAddSummary);
            this.radGroupOptions.Controls.Add(this.radComboFunction);
            this.radGroupOptions.FooterImageIndex = -1;
            this.radGroupOptions.FooterImageKey = "";
            this.radGroupOptions.HeaderImageIndex = -1;
            this.radGroupOptions.HeaderImageKey = "";
            this.radGroupOptions.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupOptions.HeaderText = "Options";
            this.radGroupOptions.Location = new System.Drawing.Point(10, 6);
            this.radGroupOptions.Name = "radGroupOptions";
            this.radGroupOptions.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupOptions.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupOptions.Size = new System.Drawing.Size(180, 374);
            this.radGroupOptions.TabIndex = 0;
            this.radGroupOptions.Text = "Options";
            // 
            // radCheckBoxPinRow
            // 
            this.radCheckBoxPinRow.Location = new System.Drawing.Point(21, 343);
            this.radCheckBoxPinRow.Name = "radCheckBoxPinRow";
            this.radCheckBoxPinRow.Size = new System.Drawing.Size(80, 18);
            this.radCheckBoxPinRow.TabIndex = 11;
            this.radCheckBoxPinRow.Text = "Show Totals";
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridViewDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(952, 725);
            this.Controls.SetChildIndex(this.radGridViewDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSetGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAddSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblFuncName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupOptions)).EndInit();
            this.radGroupOptions.ResumeLayout(false);
            this.radGroupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxPinRow)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridViewDemo;
        private NorthwindDataSet nwindDataSetGridView;
        private Telerik.WinControls.UI.RadDropDownList radComboFunction;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem1;
        private Telerik.WinControls.UI.RadDropDownList radComboPosition;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem2;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem3;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem4;
        private Telerik.WinControls.UI.RadDropDownList radComboBox3;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem5;
        private Telerik.WinControls.UI.RadListDataItem radComboBoxItem6;
        private Telerik.WinControls.UI.RadButton radButtonAddSummary;
        private Telerik.WinControls.UI.RadDropDownList radComboColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrdersTableAdapter ordersTableAdapter;
        private Telerik.WinControls.UI.RadLabel radLblTip;
        private Telerik.WinControls.UI.RadLabel radLblFuncName;
        private Telerik.WinControls.UI.RadLabel radLblColumn;
        private Telerik.WinControls.UI.RadLabel radLblPosition;
        private Telerik.WinControls.UI.RadLabel radLblIn;
        private Telerik.WinControls.UI.RadGroupBox radGroupOptions;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxPinRow;
	}
}
