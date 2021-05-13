using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
{
    public partial class Form1 : ExamplesForm
    {
        private RadVirtualGridLocalizationProvider oldProvider; 
        private readonly string selectCommand = "SELECT ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products";
        private string[] columnNames = new string[] { "Product Name", "Unit Quantity", "Unit Price", "In Stock", "Ordered Units" };
        List<Product> data = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            this.radVirtualGrid1.ColumnCount = columnNames.Length;
            this.radVirtualGrid1.AllowDelete = false;
            this.radVirtualGrid1.AllowEdit = false;
            this.radVirtualGrid1.AllowSorting = false;
            this.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill;

            this.oldProvider = RadVirtualGridLocalizationProvider.CurrentProvider; 
            RadVirtualGridLocalizationProvider.CurrentProvider = new MyGermanRadVirtualGridLocalizationProvider(); 

            SelectData();
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radRadioButtonGerman.ToggleStateChanged += radRadioButtonGerman_ToggleStateChanged;
            this.Disposed += Form1_Disposed;
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            RadVirtualGridLocalizationProvider.CurrentProvider = this.oldProvider;
        }
        
        private void radRadioButtonGerman_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                RadVirtualGridLocalizationProvider.CurrentProvider = new MyGermanRadVirtualGridLocalizationProvider(); 
            }
            else
            {
                RadVirtualGridLocalizationProvider.CurrentProvider = this.oldProvider; 
            }

            this.radVirtualGrid1.VirtualGridElement.TableElement.SynchronizeRows();
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

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
           e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
        }

        #endregion

        #region OleDb CRUD

        private void radVirtualGrid1_FilterChanged(object sender, Telerik.WinControls.UI.VirtualGridEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void radVirtualGrid1_SortChanged(object sender, Telerik.WinControls.UI.VirtualGridEventArgs e)
        {
            throw new System.NotImplementedException();
        }

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
                    Product customer = new Product(
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
