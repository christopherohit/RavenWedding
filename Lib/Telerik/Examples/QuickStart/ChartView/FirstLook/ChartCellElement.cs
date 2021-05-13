using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using Telerik.Charting;
using System.Drawing;

namespace Telerik.Examples.WinControls.ChartView.FirstLook
{
    public class ChartCellElement : GridDataCellElement
    {
        RadChartElement chart;
        static Random r = new Random();
        static LineSeries lineSeries;

        public ChartCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
            this.Padding = new Padding(0);
            chart.View.Margin = new System.Windows.Forms.Padding(3);
            chart.View.MinSize = new SizeF(10, 10);
            chart.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            chart = new RadChartElement();
            this.Children.Add(chart);

            lineSeries = new LineSeries();
            lineSeries.BorderColor = Color.FromArgb(68, 68, 68);
            lineSeries.PointSize = new SizeF();

            for (int i = 0; i < 12; i++)
            {
                lineSeries.DataPoints.Add(new CategoricalDataPoint(r.Next(50)));
            }
            chart.View.Series.Add(lineSeries);

            chart.View.Axes[0].IsVisible = false;
            chart.View.Axes[1].IsVisible = false;
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data != null && (data.Name == "Snacks" || data.Name == "Beverages") && context is GridDataRowElement;
        }
    }
}
