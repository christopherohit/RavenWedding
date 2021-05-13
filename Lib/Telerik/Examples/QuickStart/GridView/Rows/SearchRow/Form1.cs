using System;
using System.Windows.Forms;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Rows.SearchRow
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            NorthwindDataSet nwindDataSet = new NorthwindDataSet();
            CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();
            BindingSource customersBindingSource = new BindingSource();
            customersTableAdapter.Fill(nwindDataSet.Customers);
            customersBindingSource.DataSource = nwindDataSet.Customers;
            radGridView1.DataSource = customersBindingSource;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.Columns["Region"].IsVisible = false;
            this.radGridView1.Columns["Phone"].IsVisible = false;
            this.radGridView1.Columns["Fax"].IsVisible = false;
        }

        private void radCheckBoxShowClearButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterView.TableSearchRow.ShowClearButton = this.radCheckBoxShowClearButton.IsChecked;
        }

        private void radCheckBoxShowCloseButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterView.TableSearchRow.ShowCloseButton = this.radCheckBoxShowCloseButton.IsChecked;
        }

        private void radCheckBoxCloseOnEscape_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterView.TableSearchRow.CloseOnEscape = this.radCheckBoxCloseOnEscape.IsChecked;
        }

        private void radCheckBoxDeferredSearch_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterView.TableSearchRow.DeferredSearch = this.radCheckBoxDeferredSearch.IsChecked;
        }
    }
}
