using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;


namespace Telerik.Examples.WinControls.GridView.Columns.ColumnRowOperations
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			this.SelectedControl = this.radGridView1;
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.TableElement.CellSpacing = -1;
            this.radGridView1.TableElement.EnableHotTracking = false;
            this.radGridView1.TableElement.TableHeaderHeight = 35;
            this.radGridView1.TableElement.GroupHeaderHeight = 40;
            this.radGridView1.TableElement.RowHeight = 30;
        }

       
        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.TableElement.BeginUpdate();

            //populate and bind the datasource
            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);

            this.radGridView1.DataSource = customersBindingSource;

            this.radGridView1.Columns.Remove(this.radGridView1.Columns["CustomerID"]);
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["Region"]);
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["Fax"]);
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["CompanyName"]);
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["PostalCode"]);

            this.radGridView1.Columns["ContactName"].HeaderText = "Contact Name";
            this.radGridView1.Columns["ContactName"].MinWidth = 80;

            this.radGridView1.Columns["ContactTitle"].HeaderText = "Contact Title";

            this.radGridView1.Columns["Address"].MinWidth = 100;

            this.radGridView1.Columns["City"].MinWidth = 60;

            this.radGridView1.Columns["Country"].MinWidth = 70;

            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.TableElement.EndUpdate(true);

            chkColResize.ToggleState = this.radGridView1.MasterTemplate.AllowColumnResize ? ToggleState.On : ToggleState.Off;
            chkRowResize.ToggleState = this.radGridView1.MasterTemplate.AllowRowResize ? ToggleState.On : ToggleState.Off;
            chkColReorder.ToggleState = this.radGridView1.MasterTemplate.AllowColumnReorder ? ToggleState.On : ToggleState.Off;
            chkColChooser.ToggleState = this.radGridView1.MasterTemplate.AllowColumnChooser ? ToggleState.On : ToggleState.Off;
            chkContextMenu.ToggleState = this.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu ? ToggleState.On : ToggleState.Off;
            chkFiltering.ToggleState = this.radGridView1.MasterTemplate.EnableFiltering ? ToggleState.On : ToggleState.Off;
            chkColAutosize.ToggleState = this.radGridView1.MasterTemplate.AllowAutoSizeColumns ? ToggleState.On : ToggleState.Off;
        }

        private void chkColResize_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
			this.radGridView1.MasterTemplate.AllowColumnResize = chkColResize.ToggleState == ToggleState.On;
		}

		private void chkRowResize_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.MasterTemplate.AllowRowResize = chkRowResize.ToggleState == ToggleState.On;
		}

		private void chkColReorder_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.MasterTemplate.AllowColumnReorder = chkColReorder.ToggleState == ToggleState.On;
		}

		private void chkColChooser_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.MasterTemplate.AllowColumnChooser = chkColChooser.ToggleState == ToggleState.On;
		}

		private void chkContextMenu_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = chkContextMenu.ToggleState == ToggleState.On;
		}

		private void chkFiltering_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.MasterTemplate.EnableFiltering = chkFiltering.ToggleState == ToggleState.On;
            this.radGridView1.MasterTemplate.ShowFilteringRow = chkFiltering.ToggleState == ToggleState.On;
		}

		private void chkColAutosize_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
            this.radGridView1.MasterTemplate.AllowAutoSizeColumns = chkColAutosize.ToggleState == ToggleState.On;
		}

        #endregion

        protected override void WireEvents()
        {
            this.chkColAutosize.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkColAutosize_ToggleStateChanged);
            this.chkColResize.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkColResize_ToggleStateChanged);
            this.chkContextMenu.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkContextMenu_ToggleStateChanged);
            this.chkColReorder.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkColReorder_ToggleStateChanged);
            this.chkColChooser.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkColChooser_ToggleStateChanged);
            this.chkRowResize.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkRowResize_ToggleStateChanged);
            this.chkFiltering.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.chkFiltering_ToggleStateChanged);
        }
    }
}
