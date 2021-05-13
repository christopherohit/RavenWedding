using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.Charting;

namespace DemoAppsHub.ChartViewExample
{
    public partial class ChartViewRotateExampleUserControl : UserControl
    {
        public ChartViewRotateExampleUserControl()
        {
            InitializeComponent();

            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.LegendTitle = "Q1";
            barSeries.Name = "Q1";
            barSeries.DataPoints.Add(new CategoricalDataPoint(177, "Harley"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(128, "White"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(143, "Smith"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(111, "Jones"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(118, "Marshall"));
            this.radChartView1.Series.Add(barSeries);

            BarSeries barSeries2 = new BarSeries("Performance", "RepresentativeName");
            barSeries2.LegendTitle = "Q2";
            barSeries2.Name = "Q2";
            barSeries2.DataPoints.Add(new CategoricalDataPoint(153, "Harley"));
            barSeries2.DataPoints.Add(new CategoricalDataPoint(141, "White"));
            barSeries2.DataPoints.Add(new CategoricalDataPoint(130, "Smith"));
            barSeries2.DataPoints.Add(new CategoricalDataPoint(88, "Jones"));
            barSeries2.DataPoints.Add(new CategoricalDataPoint(109, "Marshall"));
            this.radChartView1.Series.Add(barSeries2);

            BarSeries barSeries3 = new BarSeries("Performance", "RepresentativeName");
            barSeries3.LegendTitle = "Q3";
            barSeries3.Name = "Q3";
            barSeries3.DataPoints.Add(new CategoricalDataPoint(10, "Harley"));
            barSeries3.DataPoints.Add(new CategoricalDataPoint(55, "White"));
            barSeries3.DataPoints.Add(new CategoricalDataPoint(121, "Smith"));
            barSeries3.DataPoints.Add(new CategoricalDataPoint(86, "Jones"));
            barSeries3.DataPoints.Add(new CategoricalDataPoint(99, "Marshall"));
            this.radChartView1.Series.Add(barSeries3);

            this.radChartView1.ShowLegend = true;
            this.radChartView1.LegendTitle = "Performance";

            this.radChartView1.ShowPanZoom = true;
        }
    }
}
