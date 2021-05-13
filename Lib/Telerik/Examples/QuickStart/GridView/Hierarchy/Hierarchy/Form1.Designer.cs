namespace Telerik.Examples.WinControls.GridView.Hierarchy.Hierarchy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSpy = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.nwindDataSet = new Telerik.Examples.WinControls.DataSources.NorthwindDataSet();
            this.ordersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.customersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.suppliersTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.SuppliersTableAdapter();
            this.productsTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.order_DetailsTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.employeesTableAdapter = new Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.radGroupHierarchyOptions = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioHierarchyFromDataSet = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioManuallyUnbound = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupHierarchyOptions)).BeginInit();
            this.radGroupHierarchyOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioHierarchyFromDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioManuallyUnbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBox2);
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Controls.Add(this.radGroupHierarchyOptions);
            this.settingsPanel.Controls.Add(this.btnSpy);
            this.settingsPanel.Location = new System.Drawing.Point(938, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 768);
            this.settingsPanel.Controls.SetChildIndex(this.btnSpy, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupHierarchyOptions, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox2, 0);
            // 
            // btnSpy
            // 
            this.btnSpy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpy.Image = ((System.Drawing.Image)(resources.GetObject("btnSpy.Image")));
            this.btnSpy.Location = new System.Drawing.Point(10, 7);
            this.btnSpy.Name = "btnSpy";
            this.btnSpy.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            // 
            // 
            // 
            this.btnSpy.RootElement.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSpy.Size = new System.Drawing.Size(180, 24);
            this.btnSpy.TabIndex = 0;
            this.btnSpy.Text = "RadControl Spy ";
            this.btnSpy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1139, 770);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "NwindRadGridView";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter
            // 
            this.order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // radGroupHierarchyOptions
            // 
            this.radGroupHierarchyOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupHierarchyOptions.Controls.Add(this.radRadioHierarchyFromDataSet);
            this.radGroupHierarchyOptions.Controls.Add(this.radRadioManuallyUnbound);
            this.radGroupHierarchyOptions.Controls.Add(this.radRadioButton2);
            this.radGroupHierarchyOptions.FooterImageIndex = -1;
            this.radGroupHierarchyOptions.FooterImageKey = "";
            this.radGroupHierarchyOptions.HeaderImageIndex = -1;
            this.radGroupHierarchyOptions.HeaderImageKey = "";
            this.radGroupHierarchyOptions.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupHierarchyOptions.HeaderText = " Scenarios ";
            this.radGroupHierarchyOptions.Location = new System.Drawing.Point(10, 6);
            this.radGroupHierarchyOptions.Name = "radGroupHierarchyOptions";
            this.radGroupHierarchyOptions.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupHierarchyOptions.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupHierarchyOptions.Size = new System.Drawing.Size(180, 141);
            this.radGroupHierarchyOptions.TabIndex = 0;
            this.radGroupHierarchyOptions.Text = " Scenarios ";
            // 
            // radRadioHierarchyFromDataSet
            // 
            this.radRadioHierarchyFromDataSet.Location = new System.Drawing.Point(15, 94);
            this.radRadioHierarchyFromDataSet.Name = "radRadioHierarchyFromDataSet";
            this.radRadioHierarchyFromDataSet.Size = new System.Drawing.Size(133, 29);
            this.radRadioHierarchyFromDataSet.TabIndex = 0;
            this.radRadioHierarchyFromDataSet.Text = "Auto-Generated from\r\nDataSet";
       
            // 
            // radRadioManuallyUnbound
            // 
            this.radRadioManuallyUnbound.Location = new System.Drawing.Point(15, 24);
            this.radRadioManuallyUnbound.Name = "radRadioManuallyUnbound";
            this.radRadioManuallyUnbound.Size = new System.Drawing.Size(128, 29);
            this.radRadioManuallyUnbound.TabIndex = 0;
            this.radRadioManuallyUnbound.Text = "Manually Generated\r\nfor Unbound Mode";
        
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Location = new System.Drawing.Point(15, 59);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(128, 29);
            this.radRadioButton2.TabIndex = 0;
            this.radRadioButton2.Text = "Manually Generated\r\nfor Bound Mode";
          
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 153);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(126, 18);
            this.radCheckBox1.TabIndex = 1;
            this.radCheckBox1.Text = "Use nested scrollbars";
         
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox2.Location = new System.Drawing.Point(10, 177);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(145, 18);
            this.radCheckBox2.TabIndex = 2;
            this.radCheckBox2.Text = "Show child view captions";
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1139, 770);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupHierarchyOptions)).EndInit();
            this.radGroupHierarchyOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadioHierarchyFromDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioManuallyUnbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
		private Telerik.Examples.WinControls.DataSources.NorthwindDataSet nwindDataSet;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
        private Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupHierarchyOptions;
        private Telerik.WinControls.UI.RadRadioButton radRadioManuallyUnbound;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioHierarchyFromDataSet;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadButton btnSpy;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        
	}
}
