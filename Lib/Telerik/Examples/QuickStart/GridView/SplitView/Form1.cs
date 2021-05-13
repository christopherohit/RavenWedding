using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Layouts;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.SplitView
{
    public partial class Form1 : ExamplesForm
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            this.gridView.DataSource = this.northwindDataSet.Order_Details;

            foreach (GridViewDataColumn dataColumn in this.gridView.Columns)
            {
                dataColumn.Width = 100;
            }

            this.gridView.SynchronizeCurrentRowInSplitMode = false;
            this.radRadioButtonVertical.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.gridView.Columns["UnitPrice"].FormatString = "{0:C}";
            this.gridView.Columns["Discount"].FormatString = "{0:0%;0:0%;-}";
        }

        private void radRadioButtonNone_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.gridView.SplitMode = RadGridViewSplitMode.None;
        }

        private void radRadioButtonVertical_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.gridView.SplitMode = RadGridViewSplitMode.Vertical;
        }

        private void radRadioButtonHorizontal_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.gridView.SplitMode = RadGridViewSplitMode.Horizontal;
        }

        #endregion

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.gridView.SynchronizeCurrentRowInSplitMode = true;
            }
            else
            {
                this.gridView.SynchronizeCurrentRowInSplitMode = false;
            }
        }

        protected override void WireEvents()
        {
            this.radRadioButtonNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonNone_ToggleStateChanged);
            this.radRadioButtonVertical.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonVertical_ToggleStateChanged);
            this.radRadioButtonHorizontal.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonHorizontal_ToggleStateChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
        }
    }
}
