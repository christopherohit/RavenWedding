using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters;
using Telerik.Examples.WinControls.DataSources;
using Telerik.Pivot.Core.Aggregates;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PivotGrid.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        private RadPivotGrid radPivotGrid1;

        public Form1()
        {
            this.radPivotGrid1 = new RadPivotGrid();
            this.radPivotGrid1.Dock = DockStyle.Fill;
            this.radPivotGrid1.PivotGridElement.ShowFilterArea = true;
            this.radPivotGrid1.PivotGridElement.FilterAreaHeight = 45;
            this.Controls.Add(this.radPivotGrid1);

            InitializeComponent();

            this.FillWithData();
        }
        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
            {
                this.radPivotGrid1.PivotGridElement.FilterAreaHeight = 72;
            }
            else
            {
                this.radPivotGrid1.PivotGridElement.FilterAreaHeight = 42;
            }
        }
        private void FillWithData()
        {
            this.radPivotGrid1.RowGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "OrderDate", Step = DateTimeStep.Year, GroupComparer = new GroupNameComparer() });
            this.radPivotGrid1.RowGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "OrderDate", Step = DateTimeStep.Quarter, GroupComparer = new GroupNameComparer() });
            this.radPivotGrid1.RowGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "OrderDate", Step = DateTimeStep.Month, GroupComparer = new GroupNameComparer() });

            this.radPivotGrid1.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "FirstName", GroupComparer = new GrandTotalComparer() });

            this.radPivotGrid1.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Quantity", AggregateFunction = AggregateFunctions.Sum });
            this.radPivotGrid1.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Discount", AggregateFunction = AggregateFunctions.Average });

            this.radPivotGrid1.FilterDescriptions.Add(new PropertyFilterDescription() { PropertyName = "ShipCountry", CustomName = "Country" });

            NorthwindDataSet dataset = new DataSources.NorthwindDataSet();
            OrdersViewTableAdapter adapter = new OrdersViewTableAdapter();
            adapter.Fill(dataset.OrdersView);

            this.radPivotGrid1.AggregatesPosition = PivotAxis.Columns;
            this.radPivotGrid1.DataSource = dataset.OrdersView;
            this.radPivotGrid1.ErrorString = "Error";
            this.radPivotGrid1.EmptyValueString = "No Data";
        }
    }
}
