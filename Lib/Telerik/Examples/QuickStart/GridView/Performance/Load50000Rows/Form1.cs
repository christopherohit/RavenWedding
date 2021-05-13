using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Performance.Load50000Rows
{
    /// <summary>
    /// This example shows the capability of the RadGridView control to handle
    /// 50 000 rows of data.
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        private Random randomGenerator = new Random();
        private const int ROWS_COUNT = 50000;
        private string[] randomStrings;

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            InitializeData();

            this.radGridViewDemo.MasterView.TableHeaderRow.IsVisible = false;
            this.radGridViewDemo.MasterTemplate.EnableGrouping = false;
        }

        #endregion

        #region Binding

        private void InitializeData()
        {
            this.randomStrings = new string[20];

            for (int i = 0; i < this.randomStrings.Length; i++)
            {
                this.randomStrings[i] = "String " + (i + 1);
            }

            DataColumn integerColumn = new DataColumn("RowIndex", typeof(int));
            DataColumn stringColumn = new DataColumn("StringColumn", typeof(string));
            DataColumn decimalColumn = new DataColumn("DecimalColumn", typeof(decimal));
            DataColumn boolColumn = new DataColumn("BooleanColumn", typeof(bool));

            dataTable.Columns.Add(integerColumn);
            dataTable.Columns.Add(stringColumn);
            dataTable.Columns.Add(decimalColumn);
            dataTable.Columns.Add(boolColumn);

            dataTable.BeginLoadData();
            for (int i = 0; i < ROWS_COUNT; i++)
            {
                DataRow row = dataTable.NewRow();

                row["RowIndex"] = i;
                row["StringColumn"] = this.randomStrings[randomGenerator.Next(0, this.randomStrings.Length - 1)];
                row["DecimalColumn"] = (decimal)(Math.PI / (float)(i + 1));
                row["BooleanColumn"] = (randomGenerator.Next() % 2) == 0;

                dataTable.Rows.Add(row);
            }
            dataTable.EndLoadData();
        }

        #endregion

        #region Event handling

        private void radBtnBind_Click(object sender, EventArgs e)
        {
            this.radGridViewDemo.Controls.Remove(this.radBtnBind);

            this.radGridViewDemo.EnableFiltering = true;
            this.radGridViewDemo.EnableSorting = true;
            this.radGridViewDemo.EnableGrouping = true;
            this.radGridViewDemo.MasterView.TableHeaderRow.IsVisible = true;

            this.radGridViewDemo.MasterTemplate.BeginUpdate();
            this.radGridViewDemo.DataSource = this.dataTable;
            (this.radGridViewDemo.MasterTemplate.Columns["DecimalColumn"] as GridViewDecimalColumn).FormatString = "{0:F6}";
            this.radGridViewDemo.MasterTemplate.EndUpdate();
        }

        #endregion

        protected override void WireEvents()
        {
            this.radBtnBind.Click += new System.EventHandler(this.radBtnBind_Click);
        }
    }
}
