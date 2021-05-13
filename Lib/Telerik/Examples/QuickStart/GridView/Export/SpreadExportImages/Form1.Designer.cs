namespace Telerik.Examples.WinControls.GridView.Export.SpreadExportImages
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
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureDataSet = new Telerik.Examples.WinControls.DataSources.FurnitureDataSet();
            this.productsTableAdapter = new Telerik.Examples.WinControls.DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter();
            this.exportButton = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.imageAlignmentDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.imageLayoutDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlignmentDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLayoutDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.Add(this.exportButton);
            this.settingsPanel.Location = new System.Drawing.Point(1046, 187);
            this.settingsPanel.Size = new System.Drawing.Size(230, 226);
            this.settingsPanel.Controls.SetChildIndex(this.exportButton, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowCellContextMenu = false;
            this.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AllowEditRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewImageColumn1.DataType = typeof(byte[]);
            gridViewImageColumn1.FieldName = "Photo";
            gridViewImageColumn1.HeaderText = "Photo";
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.IsAutoGenerated = true;
            gridViewImageColumn1.Name = "Photo";
            gridViewImageColumn1.Width = 408;
            gridViewTextBoxColumn1.FieldName = "ProductName";
            gridViewTextBoxColumn1.HeaderText = "Product";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ProductName";
            gridViewTextBoxColumn1.Width = 238;
            gridViewTextBoxColumn2.FieldName = "Manufacturer";
            gridViewTextBoxColumn2.HeaderText = "Manufacturer";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Manufacturer";
            gridViewTextBoxColumn2.Width = 241;
            gridViewTextBoxColumn3.FieldName = "Dimensions";
            gridViewTextBoxColumn3.FormatString = "{0} inches";
            gridViewTextBoxColumn3.HeaderText = "Dimensions";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Dimensions";
            gridViewTextBoxColumn3.Width = 207;
            gridViewDecimalColumn1.FieldName = "Price";
            gridViewDecimalColumn1.FormatString = "{0:C}";
            gridViewDecimalColumn1.HeaderText = "Price";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Price";
            gridViewDecimalColumn1.Width = 207;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "Quantity";
            gridViewDecimalColumn2.HeaderText = "Quantity";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Quantity";
            gridViewDecimalColumn2.Width = 150;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "ID";
            gridViewDecimalColumn3.HeaderText = "ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "ID";
            gridViewDecimalColumn3.Width = 121;
            gridViewTextBoxColumn4.FieldName = "Front";
            gridViewTextBoxColumn4.HeaderText = "Front";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Front";
            gridViewTextBoxColumn4.Width = 207;
            gridViewTextBoxColumn5.FieldName = "Back";
            gridViewTextBoxColumn5.HeaderText = "Back";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Back";
            gridViewTextBoxColumn5.Width = 145;
            gridViewTextBoxColumn6.FieldName = "SalesRepresentative";
            gridViewTextBoxColumn6.HeaderText = "SalesRepresentative";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "SalesRepresentative";
            gridViewTextBoxColumn6.Width = 132;
            gridViewTextBoxColumn7.FieldName = "Lining";
            gridViewTextBoxColumn7.HeaderText = "Lining";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Lining";
            gridViewTextBoxColumn7.Width = 161;
            gridViewCheckBoxColumn1.FieldName = "Condition";
            gridViewCheckBoxColumn1.HeaderText = "Condition";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "Condition";
            gridViewCheckBoxColumn1.Width = 200;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewImageColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCheckBoxColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.productsBindingSource;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.EnableSorting = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1467, 907);
            this.radGridView1.TabIndex = 2;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.furnitureDataSet;
            // 
            // furnitureDataSet
            // 
            this.furnitureDataSet.DataSetName = "FurnitureDataSet";
            this.furnitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exportButton.Location = new System.Drawing.Point(10, 33);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(210, 24);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.imageAlignmentDropDownList);
            this.radGroupBox1.Controls.Add(this.imageLayoutDropDownList);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Image column export settings:";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 64);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 141);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Image column export settings:";
            // 
            // imageAlignmentDropDownList
            // 
            this.imageAlignmentDropDownList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageAlignmentDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.imageAlignmentDropDownList.Location = new System.Drawing.Point(5, 107);
            this.imageAlignmentDropDownList.Name = "imageAlignmentDropDownList";
            this.imageAlignmentDropDownList.Size = new System.Drawing.Size(200, 20);
            this.imageAlignmentDropDownList.TabIndex = 3;
            this.imageAlignmentDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.imageAlignmentDropDownList_SelectedIndexChanged);
            // 
            // imageLayoutDropDownList
            // 
            this.imageLayoutDropDownList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageLayoutDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.imageLayoutDropDownList.Location = new System.Drawing.Point(5, 47);
            this.imageLayoutDropDownList.Name = "imageLayoutDropDownList";
            this.imageLayoutDropDownList.Size = new System.Drawing.Size(200, 20);
            this.imageLayoutDropDownList.TabIndex = 2;
            this.imageLayoutDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.imageLayoutDropDownList_SelectedIndexChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(5, 83);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(91, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Image Alignment";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(5, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(73, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Image Layout";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1477, 917);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.radGridView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlignmentDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLayoutDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DataSources.FurnitureDataSet furnitureDataSet;
        private DataSources.FurnitureDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton exportButton;
        private Telerik.WinControls.UI.RadDropDownList imageAlignmentDropDownList;
        private Telerik.WinControls.UI.RadDropDownList imageLayoutDropDownList;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}