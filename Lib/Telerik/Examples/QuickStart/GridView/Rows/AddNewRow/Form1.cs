using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;

namespace Telerik.Examples.WinControls.GridView.Rows.AddNewRow
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private ProductsTableAdapter productAdapter = new ProductsTableAdapter();
        private BindingSource productSource = new BindingSource();
        private int ProductID = 100000;

        #endregion

        public Form1()
        {
            InitializeComponent();

			this.SelectedControl = this.radGridView1;
            this.radGridView1.EnableHotTracking = true;
        }

        private void FillGrid()
        {
            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);
            this.productAdapter.Fill(this.nwindRadGridView.Products);

            this.productSource.DataSource = this.nwindRadGridView.Products;
            this.radGridView1.DataSource = productSource;
        }

        private void SetPreferences()
        {
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.MasterTemplate.AllowAddNewRow = true;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Columns["ProductID"].IsVisible = false;
            this.radGridView1.Columns["SupplierID"].IsVisible = false;
            this.radGridView1.Columns["CategoryID"].IsVisible = false;
            this.radGridView1.Columns["UnitsOnOrder"].IsVisible = false;
            this.radGridView1.Columns["ReorderLevel"].IsVisible = false;

            this.radGridView1.Columns["ProductName"].HeaderText = "Product Name";
            this.radGridView1.Columns["UnitsInStock"].HeaderText = "In Stock";
            this.radGridView1.Columns["UnitPrice"].HeaderText = "Price";
            this.radGridView1.Columns["UnitPrice"].FormatString = "${0:###,###0.00}";
            this.radGridView1.Columns["QuantityPerUnit"].HeaderText = "Quantity Per Unit";
            this.radGridView1.Columns["QuantityPerUnit"].TextAlignment = ContentAlignment.MiddleCenter;

            this.radGridView1.DefaultValuesNeeded += new GridViewRowEventHandler(radGridView1_DefaultValuesNeeded);
        }

        void radGridView1_DefaultValuesNeeded(object sender, GridViewRowEventArgs e)
        {
            //ProductID cannot be null and has to be unique as there are constrains in the data base.
            //Therefore its value has to be set in DefaultValuesNeeded event handler:
            e.Row.Cells["ProductID"].Value = ProductID++;    
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FillGrid();
            SetPreferences();
        }

        protected override void WireEvents()
        {
        }
    }
}
