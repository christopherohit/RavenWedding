using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.SmartLabels
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private DataModel data = new DataModel();
        private SmartLabelsController smartLabelsController;

        public Form1()
        {
            InitializeComponent();

            this.doubleBufferedTableLayoutPanel2.BackColor = Color.White;

            this.radChartView1.LabelFormatting += radChartView_LabelFormatting;
            this.radChartView2.LabelFormatting += radChartView_LabelFormatting;

            this.InitializePie();

            this.radChartView1.View.Margin = new Padding(20);
            this.radChartView1.Title = "Smart Labels OFF";
            this.radChartView2.Title = "Smart Labels ON";
            this.radChartView1.ShowTitle = true;
            this.radChartView2.ShowTitle = true;
            this.radChartView1.ChartElement.TitlePosition = TitlePosition.Top;
            this.radChartView2.ChartElement.TitlePosition = TitlePosition.Top;
            this.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;
            this.radChartView2.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;

            this.smartLabelsController = new SmartLabelsController();
            this.radChartView2.Controllers.Add(this.smartLabelsController);

            this.radDropDownList1.SelectedIndexChanged += radDropDownList1_SelectedIndexChanged;
            List<string> chartTypes = new List<string>();

            chartTypes.Add("Pie");
            chartTypes.Add("Line");
            chartTypes.Add("Bar");
            chartTypes.Add("Scatter");

            this.radDropDownList1.DataSource = chartTypes;
        }

        private void InitializeLine()
        {
            this.radChartView1.AreaType = ChartAreaType.Cartesian;
            this.radChartView2.AreaType = ChartAreaType.Cartesian;

            LineSeries line = new LineSeries();
            line.ShowLabels = true;
            line.LegendTitle = "Desktop Internet users";
            line.DrawLinesToLabels = this.radCheckBox1.Checked;
            line.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            LineSeries smartLine = new LineSeries();
            smartLine.ShowLabels = true;
            smartLine.LegendTitle = "Desktop Internet users";
            smartLine.DrawLinesToLabels = this.radCheckBox1.Checked;
            smartLine.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            foreach (KeyValuePair<double, object> dataItem in this.data.GetLineOneData())
            {
                CategoricalDataPoint point = new CategoricalDataPoint(dataItem.Key, dataItem.Value);
                point.Label = point.Value;
                line.DataPoints.Add(point);

                point = new CategoricalDataPoint(dataItem.Key, dataItem.Value);
                point.Label = point.Value;
                smartLine.DataPoints.Add(point);
            }

            LineSeries line2 = new LineSeries();
            line2.ShowLabels = true;
            line2.LegendTitle = "Desktop Internet users";
            line2.DrawLinesToLabels = this.radCheckBox1.Checked;
            line2.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            LineSeries smartLine2 = new LineSeries();
            smartLine2.ShowLabels = true;
            smartLine2.LegendTitle = "Desktop Internet users";
            smartLine2.DrawLinesToLabels = this.radCheckBox1.Checked;
            smartLine2.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            foreach (KeyValuePair<double, object> dataItem in this.data.GetLineTwoData())
            {
                CategoricalDataPoint point = new CategoricalDataPoint(dataItem.Key, dataItem.Value);
                point.Label = point.Value;
                line2.DataPoints.Add(point);

                point = new CategoricalDataPoint(dataItem.Key, dataItem.Value);
                point.Label = point.Value;
                smartLine2.DataPoints.Add(point);
            }
            
            this.radChartView1.Series.Add(line);
            this.radChartView1.Series.Add(line2);

            this.radChartView2.Series.Add(smartLine);
            this.radChartView2.Series.Add(smartLine2);
        }

        private void InitializePie()
        {
            this.radChartView1.AreaType = ChartAreaType.Pie;
            this.radChartView2.AreaType = ChartAreaType.Pie;

            PieSeries pie = new PieSeries();
            pie.LabelMode = PieLabelModes.Horizontal;
            pie.ShowLabels = true;
            pie.DrawLinesToLabels = this.radCheckBox1.Checked;
            pie.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            PieSeries smartPie = new PieSeries();
            smartPie.LabelMode = PieLabelModes.Horizontal;
            smartPie.ShowLabels = true;
            smartPie.DrawLinesToLabels = this.radCheckBox1.Checked;
            smartPie.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            foreach (KeyValuePair<double, object> dataItem in this.data.GetPieData())
            {
                PieDataPoint point = new PieDataPoint(dataItem.Key, dataItem.Value.ToString());
                point.Label = dataItem.Value.ToString();
                pie.DataPoints.Add(point);

                point = new PieDataPoint(dataItem.Key, dataItem.Value.ToString());
                point.Label = dataItem.Value.ToString();
                smartPie.DataPoints.Add(point);
            }

            this.radChartView1.Series.Add(pie);
            this.radChartView2.Series.Add(smartPie);

            this.radCheckBox1.Checked = true;
        }

        private void InitializeScatter()
        {
            this.radChartView1.AreaType = ChartAreaType.Cartesian;
            this.radChartView2.AreaType = ChartAreaType.Cartesian;

            this.radChartView1.ShowGrid = true;
            this.radChartView2.ShowGrid = true;

            ScatterSeries scatter = new ScatterSeries();
            scatter.LegendTitle = "Area/Price ratio New York";
            scatter.ShowLabels = true;
            scatter.DrawLinesToLabels = this.radCheckBox1.Checked;
            scatter.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            ScatterSeries scatter2 = new ScatterSeries();
            scatter2.LegendTitle = "Area/Price ratio Los Angeles";
            scatter2.ShowLabels = true;
            scatter2.DrawLinesToLabels = this.radCheckBox1.Checked;
            scatter2.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            ScatterSeries smartScatter = new ScatterSeries();
            smartScatter.LegendTitle = "Area/Price ratio New York";
            smartScatter.ShowLabels = true;
            smartScatter.DrawLinesToLabels = this.radCheckBox1.Checked;
            smartScatter.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            ScatterSeries smartScatter2 = new ScatterSeries();
            smartScatter2.LegendTitle = "Area/Price ratio Los Angeles";
            smartScatter2.ShowLabels = true;
            smartScatter2.DrawLinesToLabels = this.radCheckBox1.Checked;
            smartScatter2.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

            List<KeyValuePair<double,double>> points = this.data.GetScatterData();

            for (int i = 0; i < points.Count / 2; i++)
            {
                ScatterDataPoint point = new ScatterDataPoint(points[i].Key, points[i].Value);
                point.Label = string.Format("{0:F2}", point.XValue / point.YValue);
                scatter.DataPoints.Add(point);

                point = new ScatterDataPoint(points[i].Key, points[i].Value);
                point.Label = string.Format("{0:F2}", point.XValue / point.YValue);
                smartScatter.DataPoints.Add(point);
            }

            for (int i = points.Count / 2; i < points.Count; i++)
            {
                ScatterDataPoint point = new ScatterDataPoint(points[i].Key, points[i].Value);
                point.Label = string.Format("{0:F2}", point.XValue / point.YValue);
                scatter2.DataPoints.Add(point);

                point = new ScatterDataPoint(points[i].Key, points[i].Value);
                point.Label = string.Format("{0:F2}", point.XValue / point.YValue);
                smartScatter2.DataPoints.Add(point);
            }

            this.radChartView1.Series.Add(scatter);
            this.radChartView1.Series.Add(scatter2);
            this.radChartView2.Series.Add(smartScatter);
            this.radChartView2.Series.Add(smartScatter2);

            ((LinearAxis)scatter.VerticalAxis).Maximum = 110;
            ((LinearAxis)scatter.VerticalAxis).DesiredTickCount = 12;
            ((LinearAxis)scatter.VerticalAxis).Title = "Price(USD/per sq.ft.)";
            ((LinearAxis)scatter.HorizontalAxis).Maximum = 110;
            ((LinearAxis)scatter.HorizontalAxis).DesiredTickCount = 12;
            ((LinearAxis)scatter.HorizontalAxis).Title = "Property area (sq.ft.)";

            ((LinearAxis)smartScatter.VerticalAxis).Maximum = 110;
            ((LinearAxis)smartScatter.VerticalAxis).DesiredTickCount = 12;
            ((LinearAxis)smartScatter.VerticalAxis).Title = "Price(USD/per sq.ft.)";
            ((LinearAxis)smartScatter.HorizontalAxis).Maximum = 110;
            ((LinearAxis)smartScatter.HorizontalAxis).DesiredTickCount = 12;
            ((LinearAxis)smartScatter.HorizontalAxis).Title = "Property area (sq.ft.)";
        }

        private void InitializeBar()
        {
            this.radChartView1.AreaType = ChartAreaType.Cartesian;
            this.radChartView2.AreaType = ChartAreaType.Cartesian;

            this.radChartView1.ShowGrid = true;
            this.radChartView2.ShowGrid = true;

            foreach (KeyValuePair<double, object> dataItem in this.data.GetBarData())
            {
                BarSeries bar = new BarSeries();
                bar.ShowLabels = true;
                bar.LegendTitle = dataItem.Value.ToString();
                bar.DrawLinesToLabels = this.radCheckBox1.Checked;
                bar.SyncLinesToLabelsColor = this.radCheckBox3.Checked;

                BarSeries smartBar = new BarSeries();
                smartBar.ShowLabels = true;
                smartBar.LegendTitle = dataItem.Value.ToString();
                smartBar.DrawLinesToLabels = this.radCheckBox1.Checked;

                CategoricalDataPoint point = new CategoricalDataPoint(dataItem.Key, dataItem.Value);
                point.Label = string.Format("{0:P2} - {1}", point.Value / 100, point.Category);
                bar.DataPoints.Add(point);

                point = new CategoricalDataPoint(dataItem.Key, dataItem.Value);
                point.Label = string.Format("{0:P2} - {1}", point.Value / 100, point.Category);
                smartBar.DataPoints.Add(point);

                this.radChartView1.Series.Add(bar);
                this.radChartView2.Series.Add(smartBar);
            }

            this.radChartView1.Axes[0].LabelFitMode = AxisLabelFitMode.MultiLine;
            this.radChartView2.Axes[0].LabelFitMode = AxisLabelFitMode.MultiLine;
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radChartView1.AreaType = ChartAreaType.Polar;
            this.radChartView2.AreaType = ChartAreaType.Polar;

            this.radChartView1.View.Margin = new Padding(40);
            this.radChartView2.View.Margin = new Padding(40);

            this.radChartView1.ChartElement.LegendPosition = LegendPosition.Right;
            this.radChartView2.ChartElement.LegendPosition = LegendPosition.Right;
            this.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical;
            this.radChartView2.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical;

            SmartLabelsStrategyBase strategy = null;
            this.smartLabelsController.Strategy = null;

            if (this.radDropDownList1.SelectedItem.Text == "Pie")
            {
                this.radChartView1.View.Margin = new Padding(60, 0, 50, 0);
                this.radChartView2.View.Margin = new Padding(60, 0, 50, 0);

                this.InitializePie();
                strategy = new PieTwoLabelColumnsStrategy();
            }
            else if(this.radDropDownList1.SelectedItem.Text == "Line")
            {
                this.InitializeLine();
                strategy = new VerticalAdjusmentLabelsStrategy();

                this.radChartView1.ChartElement.LegendPosition = LegendPosition.Top;
                this.radChartView2.ChartElement.LegendPosition = LegendPosition.Top;
                this.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal;
                this.radChartView2.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal;
            }
            else if (this.radDropDownList1.SelectedItem.Text == "Bar")
            {
                this.InitializeBar();
                strategy = new VerticalAdjusmentLabelsStrategy();
            }
            else if (this.radDropDownList1.SelectedItem.Text == "Scatter")
            {
                this.InitializeScatter();
                strategy = new EightPositionsLabelsStrategy();

                this.radChartView1.ChartElement.LegendPosition = LegendPosition.Top;
                this.radChartView2.ChartElement.LegendPosition = LegendPosition.Top;
                this.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal;
                this.radChartView2.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal;
            }

            this.smartLabelsController.Strategy = strategy;
            this.radSpinEditor1.Value = 0m;
        }
        
        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            bool enabled = args.ToggleState == ToggleState.On;

            for (int i = 0; i < this.radChartView1.Series.Count; i++)
            {
                this.radChartView1.Series[i].DrawLinesToLabels = enabled;
                this.radChartView2.Series[i].DrawLinesToLabels = enabled;
            }

            this.radChartView1.View.PerformRefresh(this.radChartView1.View, false);
            this.radChartView2.View.PerformRefresh(this.radChartView1.View, false);
        }

        private void radChartView_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            if (this.radCheckBox2.Checked)
            {
                if (this.radCheckBox4.Checked)
                {
                    e.LabelElement.BorderColor = ((DataPointElement)e.LabelElement.Parent).BackColor;
                }
                else
                {
                    e.LabelElement.BorderColor = Color.Black;
                }

                e.LabelElement.BackColor = Color.White;
            }
            else
            {
                e.LabelElement.ResetValue(LabelElement.BorderColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                e.LabelElement.ResetValue(LabelElement.BorderWidthProperty, Telerik.WinControls.ValueResetFlags.Local);
                e.LabelElement.ResetValue(LabelElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radChartView1.View.PerformRefresh(this.radChartView1.View, false);
            this.radChartView2.View.PerformRefresh(this.radChartView1.View, false);
        }

        private void radCheckBox3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            bool enabled = args.ToggleState == ToggleState.On;

            for (int i = 0; i < this.radChartView1.Series.Count; i++)
            {
                this.radChartView1.Series[i].SyncLinesToLabelsColor = enabled;
                this.radChartView2.Series[i].SyncLinesToLabelsColor = enabled;
            }

            this.radChartView1.View.PerformRefresh(this.radChartView1.View, false);
            this.radChartView2.View.PerformRefresh(this.radChartView1.View, false);
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            foreach (ChartViewController controller in this.radChartView2.Controllers)
            {
                SmartLabelsController control = controller as SmartLabelsController;

                if (control != null)
                {
                    control.Strategy.DistanceToLabel = (int)this.radSpinEditor1.Value;
                    this.radChartView2.View.PerformRefresh(this.radChartView2.View, false);
                }
            }
        }

        protected override void WireEvents()
        {
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox2_ToggleStateChanged);
            this.radCheckBox3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox3_ToggleStateChanged);
            this.radCheckBox4.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox2_ToggleStateChanged);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
        }
    }
}
