using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Charting;

namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        bool enableFormatting;
        Font formattingFont = new Font("Segoe UI", 8f);

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            enableFormatting = true;

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;

            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.ForeColor = Color.FromArgb(200, 200, 200);
            grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            grid.DrawVerticalStripes = false;
            grid.DrawHorizontalFills = false;
            grid.DrawVerticalFills = false;

            DateTimeCategoricalAxis horizontalAxis = new DateTimeCategoricalAxis();
            horizontalAxis.LabelFormat = "{0:MMM - dd}";
            horizontalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
            horizontalAxis.LabelRotationAngle = 315;
            area.Axes.Add(horizontalAxis);

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.Minimum = 58;
            verticalAxis.Maximum = 70;
            verticalAxis.AxisType = Telerik.Charting.AxisType.Second;
            area.Axes.Add(verticalAxis);

            InitializeOhlcSeries();
            SetupOhlcLabels();
           
        }

        void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                enableFormatting = true;
            }
            else
            {
                enableFormatting = false;
            }
            this.radChartView1.Invalidate();
            this.radChartView1.View.Refresh();
        }

        void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Series[0].ShowLabels = true;
            }
            else
            {
                this.radChartView1.Series[0].ShowLabels = false;
            }
        }

        void radChartView1_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            OhlcLabelElement label = e.LabelElement as OhlcLabelElement;

            if (enableFormatting)
            {
                label.Font = formattingFont;

                bool isFalling = ((OhlcDataPoint)e.LabelElement.DataPoint).IsFalling;
                if (label.PositionOffset != PointF.Empty)
                {
                    if (isFalling)
                    {
                        label.ForeColor = Color.FromArgb(210, 0, 0);
                    }
                    
                    else
                    {
                        label.ForeColor = Color.FromArgb(102, 102, 102);
                    }
                }
                else
                {
                    if (isFalling)
                    {
                        label.ForeColor = Color.Black;
                    }
                    else
                    {
                        label.ForeColor = Color.FromArgb(0, 150, 0);
                    }
                }
            }
            else
            {
                label.ResetValue(UIChartElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                label.ResetValue(UIChartElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            UpdateLabelPostion();
        }

        private void SetupOhlcLabels()
        {
            if (this.radChartView1.Series.Count > 0)
            {
                foreach (TwoLabelOhlcPointElement point in this.radChartView1.Series[0].Children)
                {
                    OhlcLabelElement upperLabel = point.Children[0] as OhlcLabelElement;
                    if (upperLabel != null)
                    {
                        upperLabel.Text = (point.DataPoint as OhlcDataPoint).Open.ToString();
                    }

                    OhlcLabelElement lowerLabel = point.Children[1] as OhlcLabelElement;
                    if (lowerLabel != null)
                    {
                        lowerLabel.Text = (point.DataPoint as OhlcDataPoint).Close.ToString();
                    }
                }
            }
        }

        private void UpdateLabelPostion()
        {
            if (this.radChartView1.Series.Count > 0)
            {
                foreach (TwoLabelOhlcPointElement point in radChartView1.Series[0].Children)
                {
                    OhlcLabelElement lowerLabel = point.Children[1] as OhlcLabelElement;
                    if (lowerLabel != null)
                    {
                        lowerLabel.PositionOffset = new PointF(0, (float)(point.DataPoint.LayoutSlot.Height + lowerLabel.GetLayoutSlot().Height + 5));
                    }
                }
            }
        }

        private void InitializeOhlcSeries()
        {
            TwoLabelOhlcSeries series = new TwoLabelOhlcSeries();

            series.DataPoints.Add(new OhlcDataPoint(64.96, 64.96, 63.34, 63.54, new DateTime(11, 7, 5)));
            series.DataPoints.Add(new OhlcDataPoint(63.47, 64.54, 63.1, 63.52, new DateTime(11, 7, 6)));
            series.DataPoints.Add(new OhlcDataPoint(63.43, 64.95, 63.43, 63.84, new DateTime(11, 7, 7)));
            series.DataPoints.Add(new OhlcDataPoint(64.17, 64.17, 62.47, 62.99, new DateTime(11, 7, 8)));
            series.DataPoints.Add(new OhlcDataPoint(63.29, 63.34, 61.57, 61.7, new DateTime(11, 7, 11)));
            series.DataPoints.Add(new OhlcDataPoint(61.63, 62.36, 59.56, 59.63, new DateTime(11, 7, 12)));
            series.DataPoints.Add(new OhlcDataPoint(60.22, 63.91, 60.17, 63.54, new DateTime(11, 7, 13)));
            series.DataPoints.Add(new OhlcDataPoint(63.62, 64.75, 62.9, 64.02, new DateTime(11, 7, 14)));
            series.DataPoints.Add(new OhlcDataPoint(64.04, 66.36, 63.76, 66.12, new DateTime(11, 7, 15)));
            series.DataPoints.Add(new OhlcDataPoint(65.91, 67.12, 64.36, 64.84, new DateTime(11, 7, 18)));
            series.DataPoints.Add(new OhlcDataPoint(64.84, 67.11, 64.42, 67.11, new DateTime(11, 7, 19)));
            series.DataPoints.Add(new OhlcDataPoint(66.85, 68.12, 66.62, 66.99, new DateTime(11, 7, 20)));
            series.DataPoints.Add(new OhlcDataPoint(66.5, 67, 66.18, 66.68, new DateTime(11, 7, 21)));
            series.DataPoints.Add(new OhlcDataPoint(66.2, 66.85, 65.11, 65.74, new DateTime(11, 7, 22)));
            series.DataPoints.Add(new OhlcDataPoint(65.85, 66.25, 64.63, 64.76, new DateTime(11, 7, 25)));
            series.DataPoints.Add(new OhlcDataPoint(64.95, 66.95, 64.45, 66.77, new DateTime(11, 7, 26)));
            series.DataPoints.Add(new OhlcDataPoint(66.82, 68.02, 65.21, 65.21, new DateTime(11, 7, 27)));
            series.DataPoints.Add(new OhlcDataPoint(65.27, 66.3, 63.68, 63.88, new DateTime(11, 7, 28)));
            series.DataPoints.Add(new OhlcDataPoint(64, 65.98, 63.86, 65.8, new DateTime(11, 7, 29)));

            series.ShowLabels = true;
            series.VerticalAxis = this.radChartView1.Axes.Get<LinearAxis>(1);
            series.HorizontalAxis = this.radChartView1.Axes.Get<CategoricalAxis>(0);
            this.radChartView1.Series.Add(series);
        }

        protected override void WireEvents()
        {
            this.radChartView1.LabelFormatting += new ChartViewLabelFormattingEventHandler(radChartView1_LabelFormatting);
            this.radCheckBox1.ToggleStateChanged += new StateChangedEventHandler(radCheckBox1_ToggleStateChanged);
            this.radCheckBox2.ToggleStateChanged += new StateChangedEventHandler(radCheckBox2_ToggleStateChanged);
            this.Resize += new System.EventHandler(Form1_Resize);
        }
    }
}
