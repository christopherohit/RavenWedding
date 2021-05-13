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
    public partial class ChartViewZoomScrollExampleUserControl : UserControl
    {
        public ChartViewZoomScrollExampleUserControl()
        {
            InitializeComponent();

            this.radChartView1.View.Margin = new System.Windows.Forms.Padding(0);

            AreaSeries series = new AreaSeries();
            series.PointSize = new SizeF();
            series.LegendTitle = "Newspapers";
            series.DataPoints.Add(new CategoricalDataPoint(15, "Jan 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(10, "Feb 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(15, "Mar 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(15, "Apr 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(13, "May 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(15, "Jun 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(10, "Jul 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(20, "Aug 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(16, "Sep 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(10, "Oct 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(7, "Nov 2012"));
            series.DataPoints.Add(new CategoricalDataPoint(15, "Dec 2012"));

            series.DataPoints.Add(new CategoricalDataPoint(11, "Jan 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(10, "Feb 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(15, "Mar 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(20, "Apr 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(19, "May 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(15, "Jun 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(10, "Jul 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(12, "Aug 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(14, "Sep 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(10, "Oct 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(15, "Nov 2013"));
            series.DataPoints.Add(new CategoricalDataPoint(20, "Dec 2013"));

            this.radChartView1.Series.Add(series);

            AreaSeries series2 = new AreaSeries();
            series2.PointSize = new SizeF();
            series2.LegendTitle = "Magazines";
            series2.DataPoints.Add(new CategoricalDataPoint(15, "Jan 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(20, "Feb 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(21, "Mar 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(28, "Apr 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(25, "May 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(25, "Jun 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(20, "Jul 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(15, "Aug 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(17, "Sep 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(25, "Oct 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(19, "Nov 2012"));
            series2.DataPoints.Add(new CategoricalDataPoint(22, "Dec 2012"));

            series2.DataPoints.Add(new CategoricalDataPoint(15, "Jan 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(20, "Feb 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(5, "Mar 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(21, "Apr 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(25, "May 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(15, "Jun 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(20, "Jul 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(15, "Aug 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(33, "Sep 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(25, "Oct 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(19, "Nov 2013"));
            series2.DataPoints.Add(new CategoricalDataPoint(18, "Dec 2013"));
            this.radChartView1.Series.Add(series2);

            this.radChartView1.Axes[0].LabelFitMode = AxisLabelFitMode.Rotate;
            this.radChartView1.Axes[0].LabelRotationAngle = 45;

            this.radChartView1.ShowLegend = true;
            this.radChartView1.LegendTitle = "Sold copies (x 1K)";

            this.radChartView1.ShowPanZoom = true;
        }
    }
}
