using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.RightToLeft
{
    public partial class Form1 : ExamplesForm
    {
        private readonly string selectCommand = "SELECT CustomerID, CompanyName, ContactName, Country, City FROM Customers";
        private string[] columnNames = new string[] { "Customer Id", "Company Name", "Contact Name", "Country", "City" };
        List<Customer> data = new List<Customer>();

        public Form1()
        {
            InitializeComponent();

            this.radVirtualGrid1.ColumnCount = columnNames.Length;
            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.AllowDelete = false;
            this.radVirtualGrid1.AllowEdit = false;
            this.radVirtualGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill;

            SelectData();
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radToggleButtonUseRTL.ToggleStateChanged += radToggleButtonUseRTL_ToggleStateChanged;
        }

        void radToggleButtonUseRTL_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.radVirtualGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
            else
            {
                this.radVirtualGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            }
        }

        #region VirtualGrid events

        private void radVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = columnNames[e.ColumnIndex];
            }

            if (e.RowIndex < 0)
            {
                e.FieldName = columnNames[e.ColumnIndex].Replace(" ", "");
            }

            if (e.RowIndex >= 0 && e.RowIndex < data.Count)
            {
                e.Value = data[e.RowIndex][e.ColumnIndex];
            }
        }

        private void radVirtualGrid1_SortChanged(object sender, VirtualGridEventArgs e)
        {
            SelectData();
        }

        private void radVirtualGrid1_FilterChanged(object sender, VirtualGridEventArgs e)
        {
            SelectData();
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
           e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
        }

        #endregion

        #region OleDb CRUD

        private void SelectData()
        {
            string sortExpression = this.radVirtualGrid1.SortDescriptors.Expression;
            string filterExpression = this.radVirtualGrid1.FilterDescriptors.Expression;

            if (!string.IsNullOrEmpty(sortExpression))
            {
                sortExpression = "ORDER BY " + sortExpression;
            }

            if (!string.IsNullOrEmpty(filterExpression))
            {
                filterExpression = "WHERE " + filterExpression;
            }

            string commandString = String.Format("{0} {1} {2}", selectCommand, filterExpression, sortExpression);

            using (OleDbCommand command = new OleDbCommand(commandString))
            {
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                IDataReader reader = command.ExecuteReader();
                data.Clear();

                while (reader.Read())
                {
                    Customer customer = new Customer(
                        Convert.ToString(reader[0]),
                        Convert.ToString(reader[1]),
                        Convert.ToString(reader[2]),
                        Convert.ToString(reader[3]),
                        Convert.ToString(reader[4]));
                    data.Add(customer);
                }

                command.Connection.Close();
            }

            this.radVirtualGrid1.RowCount = data.Count;
        }

        #endregion
    }
}
