using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.ChartView.DrillDown
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {

        int year;
        int month;
        private SmartLabelsController smartLabelsController = new SmartLabelsController();

        public Form1()
        {
            InitializeComponent();
            InitializeDropDownList();

            BarSeries barSerias = new BarSeries();

            barSerias.ValueMember = "Value";
            barSerias.CategoryMember = "Date";
            barSerias.DataSource = DrillDownViewModel.ParseDataByYear();

            radChartView1.Views.AddNew();
            radChartView1.Views.AddNew();
            radChartView1.Title = "Revenue by Years";
            this.radChartView1.ChartElement.ShowTitle = true;
            radChartView1.ChartElement.TitlePosition = TitlePosition.Top;
            DrillDownController controller = new DrillDownController();
            this.radChartView1.Controllers.Add(controller);
            this.radChartView1.Drill += new DrillEventHandler(radChartView1_Drill);
            this.radChartView1.ShowDrillNavigation = true;
            FillColors(this.radChartView1.View, KnownPalette.Warm);

            DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.MajorStepUnit = Charting.TimeInterval.Year;
            horizontalAxis.MajorStep = 1;
            horizontalAxis.LabelFormat = "{0:yyyy}";
            horizontalAxis.Title = "Year";

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            verticalAxis.Title = "USD";
            barSerias.HorizontalAxis = verticalAxis;

            barSerias.VerticalAxis = horizontalAxis;


            radChartView1.Series.Add(barSerias);
            this.radChartView1.LabelFormatting += new ChartViewLabelFormattingEventHandler(radChartView1_LabelFormatting);
            this.radChartView1.ShowTrackBall = false;

            //smartLabelsController.Strategy = new FalpLabelStrategy();


            this.radChartView1.Controllers.Add(smartLabelsController);
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;

            this.FillBarSeries(barSerias);
        }

        void radChartView1_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            e.LabelElement.BackColor = Color.White;
            e.LabelElement.BorderColor = Color.Black;
            e.LabelElement.ForeColor = Color.Black;
        }

        private void InitializeDropDownList()
        {
            this.radDropDownList1.Items.Add("Breadcrumb");
            this.radDropDownList1.Items.Add("Home Buttom");
            this.radDropDownList1.SelectedIndex = 0;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList1_SelectedIndexChanged);
        }

        void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.radDropDownList1.SelectedIndex == 0)
            {
                this.radChartView1.ChartElement.DrillNavigationMode = DrillNavigationMode.Breadcrumb;
            }
            else
            {
                this.radChartView1.ChartElement.DrillNavigationMode = DrillNavigationMode.HomeBackButtons;
            }
        }

        void radChartView1_Drill(object sender, DrillEventArgs e)
        {
            CartesianSeries series = new BarSeries();
            series.ValueMember = "Value";
            series.CategoryMember = "Date";

            DateTimeCategoricalAxis horizontalAxis = new DateTimeCategoricalAxis();
            CartesianArea area = e.View.GetArea<CartesianArea>();
            area.ShowGrid = true;

            CartesianGrid grid = area.GetGrid<CartesianGrid>();
            grid.DrawHorizontalStripes = true;
            grid.DrawVerticalStripes = true;

            this.radChartView1.ShowTrackBall = false;
            switch (e.Level)
            {
                case 0:
                    series.DataSource = DrillDownViewModel.ParseDataByYear();
                    radChartView1.Title = "Revenue by Years";
                    grid.DrawVerticalStripes = false;
                    this.FillBarSeries(series);
                    break;
                case 1:
                    if (e.SelectedPoint != null)
                    {
                        year = ((DrillDownDataInfo)e.SelectedPoint.DataItem).Date.Year;
                    }

                    series.DataSource = DrillDownViewModel.ParseDataByMonth(year);
                    radChartView1.Title = "Revenue by Months";
                    horizontalAxis.LabelFormat = "{0:MMMM}";
                    horizontalAxis.Title = "Months";
                    grid.DrawVerticalStripes = false;
                    this.FillBarSeries(series);
                    break;
                case 2:
                    if (e.SelectedPoint != null)
                    {
                        month = ((DrillDownDataInfo)e.SelectedPoint.DataItem).Date.Month;
                    }

                    series = new LineSeries();
                    series.ValueMember = "Value";
                    series.CategoryMember = "Date";
                    series.DataSource = DrillDownViewModel.ParseDataByDay(year, month);
                    series.ShowLabels = true;
                    series.DrawLinesToLabels = true;
                    series.SyncLinesToLabelsColor = false;
                    series.LinesToLabelsColor = Color.Black;

                    radChartView1.Title = "Revenue by Days";
                    horizontalAxis.LabelFormat = "{0:dd}";
                    horizontalAxis.Title = "Days";
                    this.radChartView1.ShowTrackBall = true;
                    grid.DrawVerticalStripes = true;
                    series.ForeColor = Color.Black;
                    this.SetTrackBall();
                    break;
            }

            e.View.Axes.Clear();
            series.HorizontalAxis = horizontalAxis;
            e.View.Series.Clear();
            e.View.Series.Add(series);

            this.FillColors(e.View, KnownPalette.Warm);
        }

        private void FillColors(Telerik.WinControls.UI.ChartView view, ChartPalette pallete)
        {
            view.Palette = null;
            view.Palette = pallete;
        }

        private void SetTrackBall()
        {
            ChartTrackballController trackBallElement = new ChartTrackballController();
            //trackBallElement.Element.TextAlignment = ContentAlignment.MiddleCenter; 
            //trackBallElement.Element.BorderColor = Color.Black;
            trackBallElement.Element.ForeColor = Color.Black;
            //trackBallElement.Element.BackColor = Color.White; 
            trackBallElement.Element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            //trackBallElement.Element.GradientStyle = Telerik.WinControls.GradientStyles.Solid; 
            trackBallElement.Element.Padding = new Padding(3, 0, 3, 3);
            trackBallElement.PointFormatString = "{0}:{1} USD";
            trackBallElement.TextNeeded += new TextNeededEventHandler(trackBallElement_TextNeeded);
            this.radChartView1.Controllers.Add(trackBallElement);
        }

        void trackBallElement_TextNeeded(object sender, TextNeededEventArgs e)
        {
            e.Text = "<html><color=black>" + e.Points[0].DataPoint.Label.ToString() + "\nUSD";
        }

        private void FillBarSeries(CartesianSeries series)
        {
            SortedDictionary<double, DataPointElement> dictionary = new SortedDictionary<double, DataPointElement>();
            for (int i = 0; i < series.Children.Count; i++)
            {
                DataPointElement childElement = (DataPointElement)series.Children[i];
                double volume = (double)childElement.DataPoint.Label;
                dictionary.Add(volume, childElement);
            }

            int j = 0;
            foreach (DataPointElement childElement in dictionary.Values)
            {
                childElement.BackColor = KnownPalette.Warm.GetEntry(series.Family, j).Fill;
                childElement.BorderColor = KnownPalette.Warm.GetEntry(series.Family, j).Stroke;
                if (++j > 7)
                {
                    j = 7;
                }
            }
        }

        protected override void WireEvents()
        {
        }
    }
}
