using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Customize.FormatValues
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetPreferences()
        {
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.EnableGrouping = false;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.SelectedControl = this.radGridView1;
        }

        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetPreferences();

            this.order_DetailsTableAdapter1.Fill(this.nwindDataSet1.Order_Details);
        }

        private void radButtonAdd_Click(object sender, EventArgs e)
        {
			((GridViewDataColumn)this.radGridView1.Columns["UnitPrice"]).FormatString = radTextBox1.Text;
			((GridViewDataColumn)this.radGridView1.Columns["Discount"]).FormatString = radTextBox1.Text;
            ((GridViewDataColumn)this.radGridView1.Columns["OrderID"]).FormatString = radTextBox1.Text;
        }

        private void checkBoxFormatting_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            GridViewDataColumn discount = (GridViewDataColumn)this.radGridView1.Columns["Discount"];
            GridViewDataColumn orderId = (GridViewDataColumn)this.radGridView1.Columns["OrderID"];
            GridViewDataColumn unitPrice = (GridViewDataColumn)this.radGridView1.Columns["UnitPrice"];

            if (this.radCheckPercent.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                discount.FormatString = "{0:0.00%;0.00%;none}";
            }
            else
            {
                discount.FormatString = "";
            }

            if (this.radCheckID.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                orderId.FormatString = "#{0}";
            }
            else
            {
                orderId.FormatString = "";
            }

            if (this.radCheckPrice.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                unitPrice.FormatString = "${0}";
            }
            else
            {
                unitPrice.FormatString = "";
            }
        }
        #endregion

        protected override void WireEvents()
        {
            this.radButtonAdd.Click += new System.EventHandler(this.radButtonAdd_Click);
            this.radCheckPrice.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.checkBoxFormatting_ToggleStateChanged);
            this.radCheckID.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.checkBoxFormatting_ToggleStateChanged);
            this.radCheckPercent.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.checkBoxFormatting_ToggleStateChanged);
        }
    }
}
