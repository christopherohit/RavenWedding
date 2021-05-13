using System;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Data;
using Telerik.WinControls.UI;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.Paging
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radGridView1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.PopulateRadGridView();
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radSpinEditorPageSize.ValueChanged += radSpinEditorPageSize_ValueChanged;
            this.radDropDownListPagingGroupingPriority.SelectedIndexChanged += radDropDownListPagingGroupingPriority_SelectedIndexChanged;
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

        private void PopulateRadGridView()
        {
            NorthwindDataSet set = new NorthwindDataSet();
            OrdersTableAdapter adapter = new OrdersTableAdapter();
            adapter.Fill(set.Orders);

            radGridView1.DataSource = set.Orders;

            this.radGridView1.Columns["EmployeeID"].IsVisible = false;
            this.radGridView1.Columns["RequiredDate"].IsVisible = false;
            this.radGridView1.Columns["ShipVia"].IsVisible = false;
            this.radGridView1.Columns["ShipRegion"].IsVisible = false;
            ((GridViewDateTimeColumn)this.radGridView1.Columns["OrderDate"]).FormatString = "{0:dd MMMM yyyy}";
            ((GridViewDateTimeColumn)this.radGridView1.Columns["ShippedDate"]).FormatString = "{0:dd MMMM yyyy}";

            this.radGridView1.BestFitColumns(BestFitColumnMode.AllCells);
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.AutoExpandGroups = true;
            this.radGridView1.SortDescriptors.Add("ShipCountry", System.ComponentModel.ListSortDirection.Ascending);
            this.radGridView1.GroupDescriptors.Add("ShipCountry", System.ComponentModel.ListSortDirection.Ascending);
            this.radGridView1.MasterTemplate.DataView.PagingBeforeGrouping = true;
        }

        private void radSpinEditorPageSize_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.PageSize = (int)this.radSpinEditorPageSize.Value;
        }

        private void radDropDownListPagingGroupingPriority_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radGridView1.MasterTemplate.DataView.PagingBeforeGrouping = e.Position == 0;
        }

        private void radSpinEditorPageButtons_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.NumericButtonsCount = (int)this.radSpinEditorPageButtons.Value;
        }

        private void radCheckBoxButtonsStrip_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowButtonsStripElement = this.radCheckBoxButtonsStrip.Checked;
        }

        private void radCheckBoxTextBoxStrip_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowTextBoxStripElement = this.radCheckBoxTextBoxStrip.Checked;
        }

        private void radCheckBoxFirstButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowFirstButton = this.radCheckBoxFirstButton.Checked;
        }

        private void radCheckBoxPreviousButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowPreviousButton = this.radCheckBoxPreviousButton.Checked;
        }

        private void radCheckBoxFastBackButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowFastBackButton = this.radCheckBoxFastBackButton.Checked;
        }

        private void radCheckBoxNumericalButtons_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowNumericalButtons = this.radCheckBoxNumericalButtons.Checked;
        }

        private void radCheckBoxFastForwardButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowFastForwardButton = this.radCheckBoxFastForwardButton.Checked;
        }

        private void radCheckBoxNextButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowNextButton = this.radCheckBoxNextButton.Checked;
        }

        private void radCheckBoxLastButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.GridViewElement.PagingPanelElement.ShowLastButton = this.radCheckBoxLastButton.Checked;
        }
    }
}
