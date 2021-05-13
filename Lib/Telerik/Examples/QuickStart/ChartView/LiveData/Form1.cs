using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.LiveData
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        LiveDataModel model = new LiveDataModel();
        Font font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);

        public Form1()
        {
            InitializeComponent();
            InitializeChart1(typeof(FastLineSeries));
            InitializeChart2();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            model.StartTimer();
            model.PropertyChanged += new PropertyChangedEventHandler(model_PropertyChanged);
        }

        private void InitializeChart1(Type seriesType)
        {
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.ForeColor = Color.FromArgb(235, 235, 235);
            grid.DrawVerticalStripes = false;
            grid.DrawHorizontalStripes = true;
            grid.DrawHorizontalFills = false;
            grid.DrawVerticalFills = false;
            area.ShowGrid = true;

            LineSeries lineSeries;

            if (seriesType == typeof(FastLineSeries))
            {
                lineSeries = new FastLineSeries();
                lineSeries.BorderColor = Color.Blue;
                exampleCustomShapeControl4.Element.BackColor = Color.Blue;
            }
            else
            {
                lineSeries = new LineSeries();
                lineSeries.BorderColor = Color.FromArgb(142, 196, 65);
                exampleCustomShapeControl4.Element.BackColor = Color.FromArgb(142, 196, 65);
            }

            lineSeries.PointSize = new SizeF(0, 0);
            lineSeries.CategoryMember = "Category";
            lineSeries.ValueMember = "Value";
            lineSeries.DataSource = model.Data;
            lineSeries.BorderWidth = 2;

            this.radChartView1.Series.Add(lineSeries);

            this.radChartView1.ChartElement.TitlePosition = TitlePosition.Top;
            this.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.radChartView1.ChartElement.TitleElement.Margin = new Padding(10, 10, 0, 0);
            this.radChartView1.ChartElement.TitleElement.Font = font;
            this.radChartView1.View.Margin = new Padding(10, 0, 35, 0);

            LinearAxis axeY = radChartView1.Axes.Get<LinearAxis>(1);
            axeY.Minimum = 500;
            axeY.Maximum = 2000;
            axeY.MajorStep = 500;

            CategoricalAxis axeX = radChartView1.Axes.Get<CategoricalAxis>(0);
            axeX.ClipLabels = false;
            axeX.LabelInterval = 50;
            axeX.LabelFormat = "{0:HH:mm:ss.f}";
        }

        private void InitializeChart2()
        {
            CartesianArea area = this.radChartView2.GetArea<CartesianArea>();
            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.ForeColor = Color.FromArgb(235, 235, 235);
            grid.DrawVerticalStripes = false;
            grid.DrawHorizontalStripes = true;
            grid.DrawHorizontalFills = false;
            grid.DrawVerticalFills = false;
            area.ShowGrid = true;

            ChartTrackballController trackball = new ChartTrackballController();
            trackball.IsFixedSize = true;
            trackball.FixedSize = new System.Drawing.Size(150, 30);
            trackball.TextNeeded += new TextNeededEventHandler(trackball_TextNeeded);
            this.radChartView2.Controllers.Add(trackball);

            AreaSeries areaSeries = new AreaSeries();
            areaSeries.Spline = false;
            areaSeries.CategoryMember = "Category";
            areaSeries.ValueMember = "Value";
            areaSeries.DataSource = model.Data2;
            areaSeries.PointSize = new SizeF(0, 0);
            areaSeries.BorderColor = Color.FromArgb(142, 196, 65);
            areaSeries.BackColor = Color.FromArgb(150, Color.FromArgb(142, 196, 65));

            this.radChartView2.Series.Add(areaSeries);

            this.radChartView2.ChartElement.TitlePosition = TitlePosition.Top;
            this.radChartView2.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.radChartView2.ChartElement.TitleElement.Margin = new Padding(10, 10, 0, 0);
            this.radChartView2.ChartElement.TitleElement.Font = font;
            this.radChartView2.View.Margin = new Padding(10, 0, 0, 10);

            LinearAxis axeY = radChartView2.Axes.Get<LinearAxis>(1);
            axeY.Minimum = 3000;
            axeY.Maximum = 4200;

            CategoricalAxis axeX = radChartView2.Axes.Get<CategoricalAxis>(0);
            axeX.LabelInterval = 2;
            axeX.LabelFormat = "{0:HH}";
            axeX.LastLabelVisibility = Charting.AxisLastLabelVisibility.Visible;

        }

        private void trackball_TextNeeded(object sender, TextNeededEventArgs e)
        {
            ChartBusinessObject dataItem = e.Points[0].DataPoint.DataItem as ChartBusinessObject;
            if (dataItem == null)
            {
                return;
            }

            StringBuilder textBuilder = new StringBuilder();
            textBuilder.Append("<html><color=255,0,0,0>");
            textBuilder.Append(String.Format("Online users at {0:HH}h:<b>{1}</b>", dataItem.Category, dataItem.Value));
            textBuilder.Append("</html>");
            e.Text = textBuilder.ToString();
            e.Element.BorderBoxStyle = BorderBoxStyle.FourBorders;
            e.Element.Location = new Point(e.Element.Location.X, 0);
        }

        private void model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.exampleCustomShapeControl1.LeftText = model.MessagesPerSecond;
            this.exampleCustomShapeControl2.LeftText = model.MessagesPerMinute;
            this.exampleCustomShapeControl4.LeftText = model.FPS;
        }

        protected override void WireEvents()
        {
            this.Disposed += Form1_Disposed;
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            model.StopTimer();
            model.PropertyChanged -= model_PropertyChanged;
        }

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radChartView1.Series.Clear();
            InitializeChart1(typeof(LineSeries));
        }

        private void radRadioButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            radChartView1.Series.Clear();
            InitializeChart1(typeof(FastLineSeries));
        }
    }
}
