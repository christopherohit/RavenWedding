using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Data;

namespace Telerik.Examples.WinControls.GridView.Hierarchy.LoadOnDemandHierarchy
{
	public partial class Form1 : ExamplesForm
	{
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.productModelTableAdapter.Fill(this.adventureLT2008DataSet.ProductModel);
            this.productTableAdapter.Fill(this.adventureLT2008DataSet.Product);

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Templates[0].AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Templates[0].AllowAddNewRow = false;

            this.radGridView1.Templates[0].HierarchyDataProvider = new GridViewEventDataProvider(this.radGridView1.Templates[0]);
            this.radGridView1.RowSourceNeeded += new GridViewRowSourceNeededEventHandler(radGridView1_RowSourceNeeded);
        }

        void radGridView1_RowSourceNeeded(object sender, GridViewRowSourceNeededEventArgs e)
        {
            DataRowView rowView = e.ParentRow.DataBoundItem as DataRowView;
            DataRow [] rows = rowView.Row.GetChildRows("ProductModel_Product");

            foreach (DataRow dataRow in rows)
            {
                GridViewRowInfo row = e.Template.Rows.NewRow();
                row.Cells["Name"].Value = dataRow["Name"];
                row.Cells["ProductNumber"].Value = dataRow["ProductNumber"];
                row.Cells["Color"].Value = dataRow["Color"];
                row.Cells["ListPrice"].Value = dataRow["ListPrice"];
                row.Cells["Size"].Value = dataRow["Size"];
                row.Cells["Weight"].Value = dataRow["Weight"];
                row.Cells["DiscontinuedDate"].Value = dataRow["DiscontinuedDate"];

                e.SourceCollection.Add(row);
            }
        }

        protected override void WireEvents()
        {
        }
    }
}
