using System;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Paging
{
    public partial class Form1 : ExamplesForm
    {
        private NorthwindDataSet set = new NorthwindDataSet();
        private string[] visibleColumns;
        private string[] columnHeaderss;

        public Form1()
        {
            InitializeComponent();

            this.radVirtualGrid1.TableElement.ColumnWidth = 170;

            OrdersTableAdapter adapter = new OrdersTableAdapter();
            adapter.Fill(set.Orders);
            this.visibleColumns = new string[] { "OrderDate", "RequiredDate", "ShippedDate", "Freight", "ShipName", "ShipCity", "ShipCountry" };
            this.columnHeaderss = new string[] { "Order Date", "Required Date", "Shipped Date", "Freight", "Ship Name", "City", "Country" };
            
            this.radVirtualGrid1.ColumnCount = this.visibleColumns.Length;
            this.radVirtualGrid1.RowCount = set.Orders.Rows.Count;
            this.radVirtualGrid1.AllowFiltering = false;
            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.EnablePaging = true;
            this.radVirtualGrid1.PageSize = 30;

            this.radVirtualGrid1.CellFormatting += radVirtualGrid1_CellFormatting;
            this.radVirtualGrid1.CellValueNeeded += this.radVirtualGrid1_CellValueNeeded;
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.RowIndex < 0 || e.CellElement.ColumnIndex < 0)
            {
                return;
            }

            string columnName = this.visibleColumns[e.CellElement.ColumnIndex];

            switch (columnName)
            {
                case "OrderDate":
                case "ShippedDate":
                case "RequiredDate":
                    if (e.CellElement.Value != null && e.CellElement.Value != DBNull.Value)
                    {
                        e.CellElement.Text = ((DateTime)e.CellElement.Value).ToLongDateString();
                    }

                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    break;
                case "Freight":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    break;
                case "ShipName":
                case "ShipCity":
                case "ShipCountry":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    break;
            }
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columnHeaderss[e.ColumnIndex];
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.RowIndex < this.radVirtualGrid1.RowCount)
            {
                e.Value = this.set.Orders.Rows[e.RowIndex][this.visibleColumns[e.ColumnIndex]];
            }
        }

        #region Settings event handlers

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radSpinEditorPageSize.ValueChanged += radSpinEditorPageSize_ValueChanged;
            this.radSpinEditorPageButtons.ValueChanged += radSpinEditorPageButtons_ValueChanged;

            this.radCheckBoxButtonsStrip.ToggleStateChanged += radCheckBoxButtonsStrip_ToggleStateChanged;
            this.radCheckBoxTextBoxStrip.ToggleStateChanged += radCheckBoxTextBoxStrip_ToggleStateChanged;
            this.radCheckBoxFirstButton.ToggleStateChanged += this.radCheckBoxFirstButton_ToggleStateChanged;
            this.radCheckBoxPreviousButton.ToggleStateChanged += this.radCheckBoxPreviousButton_ToggleStateChanged;
            this.radCheckBoxFastBackButton.ToggleStateChanged += this.radCheckBoxFastBackButton_ToggleStateChanged;
            this.radCheckBoxNumericalButtons.ToggleStateChanged += this.radCheckBoxNumericalButtons_ToggleStateChanged;
            this.radCheckBoxFastForwardButton.ToggleStateChanged += this.radCheckBoxFastForwardButton_ToggleStateChanged;
            this.radCheckBoxNextButton.ToggleStateChanged += this.radCheckBoxNextButton_ToggleStateChanged;
            this.radCheckBoxLastButton.ToggleStateChanged += this.radCheckBoxLastButton_ToggleStateChanged;
            this.radCheckBoxButtonsStrip.ToggleStateChanged += this.radCheckBoxFirstButton_ToggleStateChanged;
            this.radCheckBoxTextBoxStrip.ToggleStateChanged += this.radCheckBoxPreviousButton_ToggleStateChanged;         
        }

        private void radSpinEditorPageSize_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.PageSize = (int)this.radSpinEditorPageSize.Value;
        }

        private void radSpinEditorPageButtons_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.NumericButtonsCount = (int)this.radSpinEditorPageButtons.Value;
        }

        private void radCheckBoxButtonsStrip_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowButtonsStripElement = this.radCheckBoxButtonsStrip.Checked;
        }

        private void radCheckBoxTextBoxStrip_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowTextBoxStripElement = this.radCheckBoxTextBoxStrip.Checked;
        }

        private void radCheckBoxFirstButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowFirstButton = this.radCheckBoxFirstButton.Checked;
        }

        private void radCheckBoxPreviousButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowPreviousButton = this.radCheckBoxPreviousButton.Checked;
        }

        private void radCheckBoxFastBackButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowFastBackButton = this.radCheckBoxFastBackButton.Checked;
        }

        private void radCheckBoxNumericalButtons_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowNumericalButtons = this.radCheckBoxNumericalButtons.Checked;
        }

        private void radCheckBoxFastForwardButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowFastForwardButton = this.radCheckBoxFastForwardButton.Checked;
        }

        private void radCheckBoxNextButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowNextButton = this.radCheckBoxNextButton.Checked;
        }

        private void radCheckBoxLastButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowLastButton = this.radCheckBoxLastButton.Checked;
        }

        #endregion
    }
}
