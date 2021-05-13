using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PivotGrid.UnderlyingData
{
    public partial class UnderlyingDataForm : Telerik.WinControls.UI.RadForm
    {
        public UnderlyingDataForm()
        {
            InitializeComponent();

            GridViewSummaryItem summaryItemQuantity = new GridViewSummaryItem();
            summaryItemQuantity.Name = "Quantity";
            summaryItemQuantity.Aggregate = GridAggregateFunction.Sum;
            GridViewSummaryItem summaryItemNet = new GridViewSummaryItem();
            summaryItemNet.Name = "Net";
            summaryItemNet.Aggregate = GridAggregateFunction.Sum;

            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItemQuantity);
            summaryRowItem.Add(summaryItemNet);
            this.radGridView1.SummaryRowsTop.Add(summaryRowItem);
        }

        internal void DisplayUnderlyingData(IEnumerable underlyingData, IWin32Window owner)
        {
            this.radGridView1.DataSource = underlyingData;
            this.ShowDialog(owner);
        }
    }
}
