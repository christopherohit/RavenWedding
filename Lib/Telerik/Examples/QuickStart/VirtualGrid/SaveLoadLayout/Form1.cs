using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.SaveLoadLayout
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
            this.radVirtualGrid1.AllowRowResize = true;
            this.radVirtualGrid1.AllowColumnResize = true;

            SelectData();

            this.radVirtualGrid1.TableElement.SetRowPinPosition(2, PinnedRowPosition.Top);
            this.radVirtualGrid1.TableElement.SetRowPinPosition(12, PinnedRowPosition.Top);
            this.radVirtualGrid1.TableElement.SetRowPinPosition(22, PinnedRowPosition.Top);

            this.radVirtualGrid1.TableElement.SetRowPinPosition(1, PinnedRowPosition.Bottom);
            this.radVirtualGrid1.TableElement.SetRowPinPosition(11, PinnedRowPosition.Bottom);
            this.radVirtualGrid1.TableElement.SetRowPinPosition(21, PinnedRowPosition.Bottom);

            this.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill;
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radButtonSaveLayout.Click += radButtonSaveLayout_Click;
            this.radButtonLoadLayout.Click += radButtonLoadLayout_Click;
        }

        private void radButtonSaveLayout_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Select a xml file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radVirtualGrid1.SaveLayout(dialog.FileName);
            }
        }

        private void radButtonLoadLayout_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dialog.Title = "Select a xml file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radVirtualGrid1.LoadLayout(dialog.FileName);
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
