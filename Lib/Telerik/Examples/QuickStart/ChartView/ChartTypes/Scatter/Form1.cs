using System;
using System.Collections.Generic;
using System.Drawing;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Tests;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
{
    /// <summary>
    /// RadChartView example
    /// </summary>
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private CustomShape customShape;
        private ShapedForm shapedForm = new ShapedForm();

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radChartView1;

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;

            InitializeChartAxes();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ViewModel model = new ViewModel();
            this.radChartView1.DataSource = model.GetData();
            LinearAxis[] axes = this.radChartView1.Axes.Get<LinearAxis>();

            this.ChangeSeries("Scatter point");

            this.Initialize();
        }

        private void Initialize()
        {
            this.radDropDownListSeriesType.Items.Add("Scatter point");
            this.radDropDownListSeriesType.Items.Add("Scatter line");
            this.radDropDownListSeriesType.Items.Add("Scatter area");
            this.radDropDownListSeriesType.SelectedIndex = 0;

            this.customShape = new CustomShape();
            this.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60));

            RadListDataItem item = new RadListDataItem("CustomShape");
            item.Value = typeof(CustomShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("RoundRectShape");
            item.Value = typeof(RoundRectShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("EllipseShape");
            item.Value = typeof(EllipseShape);
            this.radDropDownListShapes.Items.Add(item);
            item = new RadListDataItem("DonutShape");
            item.Value = typeof(DonutShape);
            this.radDropDownListShapes.Items.Add(item);

            this.radDropDownListShapes.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListShapes_SelectedIndexChanged);
            this.radDropDownListShapes.SelectedIndex = 2;

            this.radSpinEditorPointRadius.Value = 6m;

            this.radChartView1.ShowTitle = true;
            this.radChartView1.Title = "Mean hourly earnings in the UK public and private sector (aged 16-64)";
            this.radChartView1.ChartElement.TitleElement.Font = new Font("Segoe UI", 20f);
        }

        private void InitializeChartAxes()
        {
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();

            LinearAxis horizontalAxis = new LinearAxis();
            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;
            horizontalAxis.Title = "Employee Age";
            horizontalAxis.Minimum = 16;
            horizontalAxis.Maximum = 64;
            horizontalAxis.MajorStep = 4;
            area.Axes.Add(horizontalAxis);

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            verticalAxis.Title = "Earnings (GPB/hour)";
            verticalAxis.Minimum = 2;
            verticalAxis.Maximum = 20;
            area.Axes.Add(verticalAxis);
        }

        private List<PointF> CreateInitialShape(int vertices, double radius1, double radius2)
        {
            List<PointF> pts = new List<PointF>();

            if (radius1 == 0) return null;

            if (radius2 == 0) return null;

            for (int i = 0; i < vertices; i++)
            {
                double angle1 = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices);
                double angle2 = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices);
                pts.Add(new PointF((float)(Math.Cos(angle1) * radius1), (float)(Math.Sin(angle1) * radius1)));
                pts.Add(new PointF((float)(Math.Cos(angle2) * radius2), (float)(Math.Sin(angle2) * radius2)));
            }

            return pts;
        }

        private void ChangeSeries(string seriesType)
        {
            this.radChartView1.Series.Clear();

            ScatterSeries seriesPublic;
            ScatterSeries seriesPrivate;
            this.radCheckBoxSpline.Enabled = false;

            if (seriesType == "Scatter line")
            {
                seriesPublic = new ScatterLineSeries() { Spline = this.radCheckBoxSpline.IsChecked };
                seriesPrivate = new ScatterLineSeries() { Spline = this.radCheckBoxSpline.IsChecked };
                this.radCheckBoxSpline.Enabled = true;
                this.radSpinEditorPointRadius.Value = 0m;

                seriesPublic.BorderColor = Color.FromArgb(27, 157, 222);
                seriesPrivate.BorderColor = Color.FromArgb(142, 196, 65);
            }
            else if (seriesType == "Scatter area")
            {
                seriesPublic = new ScatterAreaSeries() { Spline = this.radCheckBoxSpline.IsChecked };
                seriesPrivate = new ScatterAreaSeries() { Spline = this.radCheckBoxSpline.IsChecked };
                this.radCheckBoxSpline.Enabled = true;
                this.radSpinEditorPointRadius.Value = 0m;

                seriesPublic.BorderColor = Color.FromArgb(27, 157, 222);
                seriesPublic.BackColor = Color.FromArgb(100, 27, 157, 222);
                seriesPrivate.BorderColor = Color.FromArgb(142, 196, 65);
                seriesPrivate.BackColor = Color.FromArgb(100, 142, 196, 65);
            }
            else
            {
                seriesPublic = new ScatterSeries();
                seriesPrivate = new ScatterSeries();
                this.radSpinEditorPointRadius.Value = 6m;

                seriesPublic.BackColor = Color.FromArgb(27, 157, 222);
                seriesPrivate.BackColor = Color.FromArgb(142, 196, 65);
            }

            LinearAxis[] axes = this.radChartView1.Axes.Get<LinearAxis>();

            seriesPublic.DataMember = "public";
            seriesPrivate.DataMember = "private";

            seriesPublic.XValueMember = seriesPrivate.XValueMember = "Age";
            seriesPublic.YValueMember = seriesPrivate.YValueMember = "Wage";
            seriesPublic.HorizontalAxis = seriesPrivate.HorizontalAxis = axes[0];
            seriesPublic.VerticalAxis = seriesPrivate.VerticalAxis = axes[1];
            
            this.radChartView1.Series.Add(seriesPublic);
            this.radChartView1.Series.Add(seriesPrivate);

            ApplySelectedShape();
            ApplySelectedPointSize();
        }

        private void ApplyShapeToPoints(ElementShape shape)
        {
            foreach (ScatterSeries series in this.radChartView1.Series)
            {
                foreach (ScatterPointElement point in series.Children)
                {
                    point.Shape = shape;
                }
            }
        }

        private void ApplySelectedShape()
        {
            switch (this.radDropDownListShapes.SelectedIndex)
            {
                case 0:
                    this.ApplyShapeToPoints(this.customShape);
                    this.radButtonEditShape.Enabled = true;
                    break;
                case 1:
                    this.ApplyShapeToPoints(new RoundRectShape(2));
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 2:
                    this.ApplyShapeToPoints(new EllipseShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 3:
                    this.ApplyShapeToPoints(new DonutShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 4:
                    this.ApplyShapeToPoints(new TabOffice12Shape());
                    this.radButtonEditShape.Enabled = false;
                    break;
                case 5:
                    this.ApplyShapeToPoints(new TabVsShape());
                    this.radButtonEditShape.Enabled = false;
                    break;
            }
        }

        private void ApplySelectedPointSize()
        {
            foreach (ScatterSeries series in this.radChartView1.Series)
            {
                series.PointSize = new SizeF((float)this.radSpinEditorPointRadius.Value, (float)this.radSpinEditorPointRadius.Value);
            }
        }

        private void radButtonEditShape_Click(object sender, EventArgs e)
        {
            if (this.radDropDownListShapes.SelectedIndex == 0)
            {
                CustomShapeEditorForm editor = new CustomShapeEditorForm();
                this.customShape = editor.EditShape(this.customShape);
                this.ApplyShapeToPoints(this.customShape);
            }
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            ApplySelectedPointSize();
        }

        private void radDropDownListShapes_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ApplySelectedShape();
        }

        private void radDropDownListSeriesType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.ChangeSeries(this.radDropDownListSeriesType.Text);
        }

        private void radCheckBoxSpline_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (ScatterLineSeries series in this.radChartView1.Series)
            {
                series.Spline = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
            }
        }

        protected override void WireEvents()
        {
            this.radButtonEditShape.Click += new System.EventHandler(this.radButtonEditShape_Click);
            this.radSpinEditorPointRadius.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            this.radDropDownListSeriesType.SelectedIndexChanged += radDropDownListSeriesType_SelectedIndexChanged;
            this.radCheckBoxSpline.ToggleStateChanged += radCheckBoxSpline_ToggleStateChanged;
        }
    }
}

