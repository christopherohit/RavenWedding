using System;
using System.Collections.Generic;
using System.IO; 
using System.Windows.Forms;
using Telerik.Pivot.Core;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.Pivot.Core.Aggregates;

namespace Telerik.Examples.WinControls.PivotGrid.LayoutTypes
{
    public partial class Form1 : ExamplesForm
    {
        private RadPivotGrid radPivotGrid1;
 

        public Form1()
        {
            this.radPivotGrid1 = new RadPivotGrid();
            this.radPivotGrid1.Dock = DockStyle.Fill;
            this.Controls.Add(this.radPivotGrid1);

            this.InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radPivotGrid1.PivotGridElement.ColumnGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "OrderDate", Step = DateTimeStep.Year, GroupComparer = new GroupNameComparer() });

            this.radPivotGrid1.PivotGridElement.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "ShipCountry", GroupComparer = new GrandTotalComparer(), SortOrder = Pivot.Core.SortOrder.Descending });
            this.radPivotGrid1.PivotGridElement.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "FirstName", GroupComparer = new GrandTotalComparer(), SortOrder = Pivot.Core.SortOrder.Ascending });
            
            this.radPivotGrid1.PivotGridElement.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Quantity", AggregateFunction = AggregateFunctions.Sum });
            this.radPivotGrid1.PivotGridElement.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "UnitPrice", AggregateFunction = AggregateFunctions.Max});

            NorthwindDataSet dataset = new DataSources.NorthwindDataSet();

            OrdersViewTableAdapter adapter = new OrdersViewTableAdapter();

            adapter.Fill(dataset.OrdersView);
            this.radPivotGrid1.AggregatesPosition = PivotAxis.Columns;
            this.radPivotGrid1.PivotGridElement.DataSource = dataset.OrdersView;
        }

         
        private void radioTabularHeader_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                if (sender == this.radioTabularColumnHeader)
                {
                    this.radPivotGrid1.PivotGridElement.ColumnHeadersLayout = PivotLayout.Tabular;
                }
                else
                {
                    this.radPivotGrid1.PivotGridElement.RowHeadersLayout = PivotLayout.Tabular;
                }
            }
        }

        private void radioCompactHeader_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                if (sender == this.radioCompactColumnHeader)
                {
                    this.radPivotGrid1.PivotGridElement.ColumnHeadersLayout = PivotLayout.Compact;
                }
                else
                {
                    this.radPivotGrid1.PivotGridElement.RowHeadersLayout = PivotLayout.Compact;
                }
            }
        }

        protected override void WireEvents()
        {
            this.radioCompactColumnHeader.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioCompactHeader_ToggleStateChanged);
            this.radioTabularColumnHeader.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioTabularHeader_ToggleStateChanged);
            this.radioCompactRowHeader.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioCompactHeader_ToggleStateChanged);
            this.radioTabularRowHeader.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioTabularHeader_ToggleStateChanged);
        }
    }
}
