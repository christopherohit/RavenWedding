using System;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.CustomCell
{
    public partial class Form1 : ExamplesForm
    {
        NorthwindDataSet set = new NorthwindDataSet();
        private string[] columns;
        private string[] fields;

        public Form1()
        {
            InitializeComponent();

            ProductsTableAdapter products = new ProductsTableAdapter();
            products.Fill(set.Products);

            this.columns = new string[] { "Product Name", "Units in stock", "Units on order", "Discontinued" };
            this.fields = new string[] { "ProductName", "UnitsInStock", "UnitsOnOrder", "Discontinued" };

            this.radVirtualGrid1.ColumnCount = this.columns.Length;
            this.radVirtualGrid1.RowCount = set.Products.Rows.Count;

            this.radVirtualGrid1.TableElement.ColumnWidth = 150;
            this.radVirtualGrid1.TableElement.SetColumnWidth(0, 500);

            this.radVirtualGrid1.CellValueNeeded += radVirtualGrid1_CellValueNeeded;
            this.radVirtualGrid1.CellValuePushed += radVirtualGrid1_CellValuePushed;
            this.radVirtualGrid1.CellFormatting += radVirtualGrid1_CellFormatting;
            this.radVirtualGrid1.EditorRequired += radVirtualGrid1_EditorRequired;
            this.radVirtualGrid1.CreateCellElement += radVirtualGrid1_CreateCellElement;

            this.radVirtualGrid1.MasterViewInfo.RegisterCustomColumn(3);
        }

        private void radVirtualGrid1_EditorRequired(object sender, VirtualGridEditorRequiredEventArgs e)
        {
            string columnName = this.columns[e.ColumnIndex];

            switch (columnName)
            {
                case "ProductName":
                    e.Editor = new VirtualGridTextBoxEditor();
                    break;
                case "UnitsInStock":
                case "UnitsOnOrder":
                    e.Editor = new VirtualGridSpinEditor();
                    break;
                case "Discontinued":
                    e.Cancel = true;
                    break;
            }
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.RowIndex < 0 || e.CellElement.ColumnIndex < 0)
            {
                return;
            }

            string columnName = this.fields[e.CellElement.ColumnIndex];

            switch (columnName)
            {
                case "ProductName":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    break;
                case "UnitsInStock":
                case "UnitsOnOrder":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    break;
            }
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columns[e.ColumnIndex];
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            e.FieldName = this.fields[e.ColumnIndex];
            e.Value = this.set.Products.Rows[e.RowIndex][e.FieldName];
        }

        private void radVirtualGrid1_CellValuePushed(object sender, VirtualGridCellValuePushedEventArgs e)
        {
            try
            {
                this.set.Products.Rows[e.RowIndex][this.fields[e.ColumnIndex]] = e.Value;
            }
            catch (Exception)
            {
                //Indicate error
            }
        }

        private void radVirtualGrid1_CreateCellElement(object sender, VirtualGridCreateCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                e.CellElement = new MyVirtualGridCheckBoxCellElement();
            }
        }
    }
}
