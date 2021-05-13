using System;
using System.Collections.Generic;
using System.Drawing;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bezier
{
    /// <summary>
    /// RadChartView example
    /// </summary>
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radChartView1;        
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BezierSeries bezier = new BezierSeries();
            BezierDataPoint point = new BezierDataPoint(20, 40, 0, 0, 100, 140);
            bezier.DataPoints.Add(point);
            point = new BezierDataPoint(20, 100, 100, 0, 0, 0);
            bezier.DataPoints.Add(point);

            this.radChartView1.Series.Add(bezier);

            bezier = new BezierSeries();
            point = new BezierDataPoint(20, 150, 0, 0, 20, 250);
            bezier.DataPoints.Add(point);
            point = new BezierDataPoint(80, 150, 80, 250, 0, 0);
            bezier.DataPoints.Add(point);

            this.radChartView1.Series.Add(bezier);

            bezier = new BezierSeries();
            point = new BezierDataPoint(120, 80, 0, 0, 180, 10);
            bezier.DataPoints.Add(point);
            point = new BezierDataPoint(200, 80, 190, 10, 0, 0);
            bezier.DataPoints.Add(point);

            this.radChartView1.Series.Add(bezier);

            bezier = new BezierSeries();
            point = new BezierDataPoint(160, 120, 0, 0, 120, 180);
            bezier.DataPoints.Add(point);
            point = new BezierDataPoint(160, 180, 120, 120, 200, 240);
            bezier.DataPoints.Add(point);
            point = new BezierDataPoint(160, 240, 200, 180, 0, 0);
            bezier.DataPoints.Add(point);

            this.radChartView1.Series.Add(bezier);
        }
	}
}

