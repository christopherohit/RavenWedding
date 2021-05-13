using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.MultiAxes
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            this.SetChartViewData();
            this.SetupChartView();

            this.radChartView1.ShowLegend = true;
            this.radChartView1.LegendTitle = "Telemetry";
            this.radChartView1.ShowTitle = true;
            this.radChartView1.Title = "Prototype car best lap telemetry";
            this.radChartView1.ChartElement.TitlePosition = TitlePosition.Top;
            this.radChartView1.ChartElement.TitleElement.Padding = new System.Windows.Forms.Padding(this.radChartView1.View.Margin.Left, 10, 0, 0);

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
        }

        private void SetupChartView()
        {
            DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.LabelFormat = "{0:m:ss:ff}";
            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;
            horizontalAxis.PlotMode = AxisPlotMode.OnTicks;
            horizontalAxis.Title = "Time";
            horizontalAxis.MaximumTicks = 15;

            LineSeries throttlePedal = new LineSeries();
            throttlePedal.LegendTitle = "Throttle pedal";
            throttlePedal.ValueMember = "ThrottlePedal";
            throttlePedal.CategoryMember = "Time";
            LinearAxis throttleAxis = new LinearAxis();
            throttleAxis.HorizontalLocation = AxisHorizontalLocation.Right;
            throttleAxis.AxisType = AxisType.Second;
            throttleAxis.Title = "Throttle, %";
            throttleAxis.Minimum = -250;
            throttleAxis.Maximum = 100;
            throttlePedal.VerticalAxis = throttleAxis;
            throttlePedal.HorizontalAxis = horizontalAxis;

            LineSeries brakePedal = new LineSeries();
            brakePedal.LegendTitle = "Brake pedal";
            brakePedal.ValueMember = "BrakePedal";
            brakePedal.CategoryMember = "Time";
            LinearAxis brakeAxis = new LinearAxis();
            brakeAxis.HorizontalLocation = AxisHorizontalLocation.Right;
            brakeAxis.AxisType = AxisType.Second;
            brakeAxis.Title = "Brake, %";
            brakeAxis.Minimum = -250;
            brakeAxis.Maximum = 100;
            brakePedal.VerticalAxis = brakeAxis;
            brakePedal.HorizontalAxis = horizontalAxis;

            LineSeries engineRpm = new LineSeries();
            engineRpm.LegendTitle = "Engine RPM";
            engineRpm.ValueMember = "EngineRpm";
            engineRpm.CategoryMember = "Time";
            LinearAxis engineRpmAxis = new LinearAxis();
            engineRpmAxis.AxisType = AxisType.Second;
            engineRpmAxis.Title = "Engine RPM";
            engineRpmAxis.Minimum = 2000;
            engineRpmAxis.Maximum = 10000;
            engineRpm.VerticalAxis = engineRpmAxis;
            engineRpm.HorizontalAxis = horizontalAxis;

            BarSeries gear = new BarSeries();
            gear.LegendTitle = "Gear";
            gear.ValueMember = "Gear";
            gear.CategoryMember = "Time";
            LinearAxis gearAxis = new LinearAxis();
            gearAxis.AxisType = AxisType.Second;
            gearAxis.Title = "Gear";
            gearAxis.Maximum = 30;
            gearAxis.DesiredTickCount = 40;
            gear.VerticalAxis = gearAxis;
            gear.HorizontalAxis = horizontalAxis;

            LineSeries speed = new LineSeries();
            speed.LegendTitle = "Speed";
            speed.ValueMember = "Speed";
            speed.CategoryMember = "Time";
            LinearAxis speedAxis = new LinearAxis();
            speedAxis.AxisType = AxisType.Second;
            speedAxis.Title = "Speed, km/h";
            speedAxis.Minimum = 0;
            speedAxis.Maximum = 500;
            speed.VerticalAxis = speedAxis;
            speed.HorizontalAxis = horizontalAxis;

            this.radChartView1.Series.Add(gear);
            this.radChartView1.Series.Add(brakePedal);
            this.radChartView1.Series.Add(throttlePedal);
            this.radChartView1.Series.Add(speed);
            this.radChartView1.Series.Add(engineRpm);
            
            throttleAxis.LabelOffset = 5;
            brakeAxis.LabelOffset = 5;
            gearAxis.LabelOffset = 1;

            for (int i = 0; i < gearAxis.Children.Count; i++)
            {
                AxisLabelElement gearLabel = gearAxis.Children[i] as AxisLabelElement;

                if (gearLabel != null && int.Parse(gearLabel.Text) > 6)
                {
                    gearLabel.IsVisible = false;
                }
            }
        }
  
        private void SetChartViewData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Time", typeof(DateTime));
            table.Columns.Add("ThrottlePedal", typeof(double));
            table.Columns.Add("BrakePedal", typeof(double));
            table.Columns.Add("EngineRpm", typeof(double));
            table.Columns.Add("Gear", typeof(double));
            table.Columns.Add("Speed", typeof(double));

            char[] separator = { '\r', '\n' };
            string fileContents = Properties.Resources.Telemetry;
            string[] lines = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            int secondsCounter = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');

                DateTime time = new DateTime(2012, 02, 04, 0, 0, 0).AddMilliseconds(500 * secondsCounter++);
                double throttle = double.Parse(data[0], CultureInfo.InvariantCulture);
                double brake = double.Parse(data[1], CultureInfo.InvariantCulture);
                double engineRpm = double.Parse(data[2], CultureInfo.InvariantCulture);
                double gear = double.Parse(data[3], CultureInfo.InvariantCulture);
                double speed = double.Parse(data[4], CultureInfo.InvariantCulture);

                table.Rows.Add(time, throttle, brake, engineRpm, gear, speed);
            }

            this.radChartView1.DataSource = table;
        }

        protected override void WireEvents()
        {
        }
    }
}
