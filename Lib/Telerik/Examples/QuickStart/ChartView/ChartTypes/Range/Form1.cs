using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Range
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
		public Form1()
		{
			InitializeComponent();

            this.radDropDownListChartType.SelectedIndex = 1;

			this.SelectedControl = this.radChartView1;
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.LabelFormat = "{0}°C";
            verticalAxis.AxisType = AxisType.Second;

            DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.LabelFormat = "{0:MMM}";

            WeatherModel model = new WeatherModel();

            RangeBarSeries barSeries = new RangeBarSeries("High", "Low", "Time");
            barSeries.Name = "Temperature";
            barSeries.HorizontalAxis = horizontalAxis;
            barSeries.VerticalAxis = verticalAxis;

            this.radChartView1.Series.Add(barSeries);

            this.radChartView1.DataSource = model.GetTemperatureData();

            CartesianGridLineAnnotation line2011 = new CartesianGridLineAnnotation(horizontalAxis, new DateTime(2011, 1, 1));
            line2011.Label = "2011";
            line2011.DrawMode = AnnotationDrawMode.BelowSeries;
            CartesianGridLineAnnotation line2012 = new CartesianGridLineAnnotation(horizontalAxis, new DateTime(2012, 1, 1));
            line2012.Label = "2012";
            line2012.DrawMode = AnnotationDrawMode.BelowSeries;

            this.radChartView1.Area.Annotations.Add(line2011);
            this.radChartView1.Area.Annotations.Add(line2012);
            this.radChartView1.View.Palette = KnownPalette.Metro;
        }

        private void radDropDownListChartType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radCheckBoxSpline.Enabled = e.Position == 0;

            this.radChartView1.Series.Clear();

            if (e.Position == 0)
            {
                RangeSeries rangeSeries = new RangeSeries("High", "Low", "Time");
                rangeSeries.Name = "Temperature";
                rangeSeries.Spline = this.radCheckBoxSpline.IsChecked;

                this.radChartView1.Series.Add(rangeSeries);
            }
            else
            {
                RangeBarSeries barSeries = new RangeBarSeries("High", "Low", "Time");
                barSeries.Name = "Temperature";

                this.radChartView1.Series.Add(barSeries);
            }
        }

        private void showLabelsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            for (int i = 0; i < this.radChartView1.Series.Count; i++)
            {
                RangeSeriesBase rangeSeries = this.radChartView1.GetSeries<RangeSeriesBase>(i);
                rangeSeries.ShowLabels = !rangeSeries.ShowLabels;
            }
        }

        private void orientationCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            CartesianGrid grid = this.radChartView1.GetArea<CartesianArea>().GetGrid<CartesianGrid>();

            if (this.orientationCheckBox.IsChecked)
            {
                this.radChartView1.GetArea<CartesianArea>().Orientation = Orientation.Horizontal;
                grid.DrawVerticalStripes = true;
                grid.DrawHorizontalStripes = false;
            }
            else
            {
                this.radChartView1.GetArea<CartesianArea>().Orientation = Orientation.Vertical;
                grid.DrawVerticalStripes = false;
                grid.DrawHorizontalStripes = true;
            }
        }

        private void radCheckBoxSpline_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            RangeSeries range = this.radChartView1.Series[0] as RangeSeries;

            if (range != null)
            {
                range.Spline = !range.Spline;
            }
        }
        
        protected override void WireEvents()
        {
            this.radDropDownListChartType.SelectedIndexChanged += radDropDownListChartType_SelectedIndexChanged;
            this.orientationCheckBox.ToggleStateChanged += this.orientationCheckBox_ToggleStateChanged;
            this.radCheckBoxSpline.ToggleStateChanged += this.radCheckBoxSpline_ToggleStateChanged;
        }
	}
}

