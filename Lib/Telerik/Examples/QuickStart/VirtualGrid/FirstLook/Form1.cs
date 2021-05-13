using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        private readonly string selectCommand = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, PostalCode FROM Customers";
        private string[] columnNames = new string[] { "Company Name", "Contact Name", "Contact Title", "Address", "Postal Code" };
        List<Customer> data = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
            this.radVirtualGrid1.ColumnCount = columnNames.Length;
            SelectData();
        }

        #region VirtualGrid events

        private void radVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
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

        private void radVirtualGrid1_CellValuePushed(object sender, VirtualGridCellValuePushedEventArgs e)
        {
            this.UpdateCellValue(data[e.RowIndex].CustomerId, columnNames[e.ColumnIndex].Replace(" ", ""), Convert.ToString(e.Value));
        }

        private void radVirtualGrid1_UserAddedRow(object sender, VirtualGridNewRowEventArgs e)
        {
            List<object> newValues = new List<object>();

            for (int i = 0; i < columnNames.Length; i++)
            {
                if (e.NewValues.ContainsKey(i))
                {
                    newValues.Add(e.NewValues[i]);
                }
                else
                {
                    newValues.Add(DBNull.Value);
                }
            }

            this.AddDataRow(newValues);
        }

        private void radVirtualGrid1_UserDeletingRow(object sender, VirtualGridRowsEventArgs e)
        {
            foreach (int rowIndex in e.RowIndices)
            {
                this.DeleteDataRow(data[rowIndex].CustomerId);
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
                        Convert.ToString(reader[4]),
                        Convert.ToString(reader[5]));
                    data.Add(customer);
                }

                command.Connection.Close();
            }

            this.radVirtualGrid1.RowCount = data.Count;
        }

        private void DeleteDataRow(string id)
        {
            using (OleDbCommand command = new OleDbCommand("DELETE FROM Customers where CustomerID = ?"))
            {
                command.Parameters.Add(new OleDbParameter("@customerId", id));
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }

            SelectData();
        }

        private void AddDataRow(List<object> newValues)
        {
            using (OleDbCommand command = new OleDbCommand(
@"INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, PostalCode) 
values (?, ?, ?, ?, ?, ?)"))
            {
                command.Parameters.Add(new OleDbParameter("@param1", GenerateID()));
                command.Parameters.Add(new OleDbParameter("@param2", Convert.ToString(newValues[0])));
                command.Parameters.Add(new OleDbParameter("@param3", Convert.ToString(newValues[1])));
                command.Parameters.Add(new OleDbParameter("@param4", Convert.ToString(newValues[2])));
                command.Parameters.Add(new OleDbParameter("@param5", Convert.ToString(newValues[3])));
                command.Parameters.Add(new OleDbParameter("@param6", Convert.ToString(newValues[4])));
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            int currentColumn = this.radVirtualGrid1.VirtualGridElement.CurrentCell.ColumnIndex;

            SelectData();

            this.radVirtualGrid1.VirtualGridElement.InputBehavior.SelectCell
                (data.Count - 1, currentColumn, false, false, this.radVirtualGrid1.VirtualGridElement.MasterViewInfo);
        }

        private void UpdateCellValue(string id, string columnName, string value)
        {
            using (OleDbCommand command = new OleDbCommand(
                @"UPDATE Customers SET " + columnName + " = ? WHERE CustomerID = ?"))
            {
                command.Parameters.Add(new OleDbParameter("@columnValue", value));
                command.Parameters.Add(new OleDbParameter("@customerId", id));
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            SelectData();
        }

        private string GenerateID()
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                sb.Append((char)('A' + rand.Next(26)));
            }

            return sb.ToString();
        }

        #endregion
    }
}
