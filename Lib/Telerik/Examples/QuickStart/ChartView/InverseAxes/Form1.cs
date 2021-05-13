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

namespace Telerik.Examples.WinControls.ChartView.InverseAxes
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private Color dryHoleColor = Color.FromArgb(142, 196, 65);
        private Color naturalGasColor = Color.FromArgb(27, 157, 222);
        private Color crudeOilColor = Color.FromArgb(245, 151, 0);

        public Form1()
        {
            InitializeComponent();

            this.radCheckBoxDryHoles.ButtonElement.TextElement.ForeColor = dryHoleColor;
            this.radCheckBoxDryHoles.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.radCheckBoxNaturalGas.ButtonElement.TextElement.ForeColor = naturalGasColor;
            this.radCheckBoxNaturalGas.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.radCheckBoxCrudeOil.ButtonElement.TextElement.ForeColor = crudeOilColor;
            this.radCheckBoxCrudeOil.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            SetupMainChart();
            SetupAggregatesChart();
            SetupDepthsChart();
        }

        private void SetupMainChart()
        {
            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            verticalAxis.LabelFormat = "{0}m";
            verticalAxis.IsInverse = true;

            DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.LabelFormat = "{0:yyyy}";
            horizontalAxis.VerticalLocation = AxisVerticalLocation.Top;
            horizontalAxis.MajorStep = 2;
            horizontalAxis.MajorStepUnit = Charting.TimeInterval.Year;

            AreaSeries dryHoles = new AreaSeries();
            dryHoles.BackColor = Color.FromArgb(100, dryHoleColor);
            dryHoles.BorderColor = dryHoleColor;
            dryHoles.DataMember = "DryHoles";
            dryHoles.ValueMember = "Depth";
            dryHoles.CategoryMember = "Time";
            dryHoles.VerticalAxis = verticalAxis;
            dryHoles.HorizontalAxis = horizontalAxis;

            AreaSeries naturalGas = new AreaSeries();
            naturalGas.BackColor = Color.FromArgb(100, naturalGasColor);
            naturalGas.BorderColor = naturalGasColor;
            naturalGas.DataMember = "NaturalGas";
            naturalGas.ValueMember = "Depth";
            naturalGas.CategoryMember = "Time";
            naturalGas.VerticalAxis = verticalAxis;
            naturalGas.HorizontalAxis = horizontalAxis;

            AreaSeries crudeOil = new AreaSeries();
            crudeOil.BackColor = Color.FromArgb(100, crudeOilColor);
            crudeOil.BorderColor = crudeOilColor;
            crudeOil.DataMember = "CrudeOil";
            crudeOil.ValueMember = "Depth";
            crudeOil.CategoryMember = "Time";
            crudeOil.VerticalAxis = verticalAxis;
            crudeOil.HorizontalAxis = horizontalAxis;

            this.radChartViewWellsDepth.Series.Add(dryHoles);
            this.radChartViewWellsDepth.Series.Add(naturalGas);
            this.radChartViewWellsDepth.Series.Add(crudeOil);

            DataModel model = new DataModel();
            this.radChartViewWellsDepth.DataSource = model.GetRawData();

            naturalGas.IsVisible = false;
            crudeOil.IsVisible = false;
        }

        private void SetupAggregatesChart()
        {
            DataModel model = new DataModel();

            BarSeries max = new BarSeries();
            max.ValueMember = "MaximumDepth";
            max.CategoryMember = "Name";
            max.ShowLabels = true;
            max.LabelMode = BarLabelModes.Top;
            max.LabelFormat = "{0:F0}";

            BarSeries avg = new BarSeries();
            avg.ValueMember = "AverageDepth";
            avg.CategoryMember = "Name";
            avg.ShowLabels = true;
            avg.LabelMode = BarLabelModes.Top;
            avg.LabelFormat = "{0:F0}";

            this.radChartViewAvgVsMaxDepth.Series.AddRange(max, avg);
            this.radChartViewAvgVsMaxDepth.DataSource = model.GetAggregatedData();
            this.radChartViewAvgVsMaxDepth.GetArea<CartesianArea>().Orientation = Orientation.Horizontal;
            avg.HorizontalAxis.IsVisible = false;

            avg.Children[0].BackColor = avg.Children[0].BorderColor = dryHoleColor;
            avg.Children[1].BackColor = avg.Children[1].BorderColor = naturalGasColor;
            avg.Children[2].BackColor = avg.Children[2].BorderColor = crudeOilColor;

            foreach (UIChartElement element in avg.Children)
            {
                element.Children[0].BackColor = element.Children[0].BorderColor = Color.Transparent;
            }
        }

        private void SetupDepthsChart()
        {
            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            verticalAxis.LabelFormat = "{0}m";
            verticalAxis.IsInverse = true;
            verticalAxis.MajorStep = 3000;

            DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
            horizontalAxis.LabelFormat = "{0:yyyy}";
            horizontalAxis.VerticalLocation = AxisVerticalLocation.Top;
            horizontalAxis.MajorStep = 10;
            horizontalAxis.MajorStepUnit = Charting.TimeInterval.Year;
            
            LineSeries dryHoles = new LineSeries();
            dryHoles.BorderColor = dryHoleColor;
            dryHoles.DataMember = "DryHoles";
            dryHoles.ValueMember = "Depth";
            dryHoles.CategoryMember = "Time";
            dryHoles.VerticalAxis = verticalAxis;
            dryHoles.HorizontalAxis = horizontalAxis;

            LineSeries naturalGas = new LineSeries();
            naturalGas.BorderColor = naturalGasColor;
            naturalGas.DataMember = "NaturalGas";
            naturalGas.ValueMember = "Depth";
            naturalGas.CategoryMember = "Time";
            naturalGas.VerticalAxis = verticalAxis;
            naturalGas.HorizontalAxis = horizontalAxis;

            LineSeries crudeOil = new LineSeries();
            crudeOil.BorderColor = crudeOilColor;
            crudeOil.DataMember = "CrudeOil";
            crudeOil.ValueMember = "Depth";
            crudeOil.CategoryMember = "Time";
            crudeOil.VerticalAxis = verticalAxis;
            crudeOil.HorizontalAxis = horizontalAxis;

            this.radChartViewDepthVsResource.Series.Add(dryHoles);
            this.radChartViewDepthVsResource.Series.Add(naturalGas);
            this.radChartViewDepthVsResource.Series.Add(crudeOil);

            DataModel model = new DataModel();
            this.radChartViewDepthVsResource.DataSource = model.GetRawData();
        }

        protected override void WireEvents()
        {
            this.radCheckBoxDryHoles.ToggleStateChanged += radCheckBoxDryHoles_ToggleStateChanged;
            this.radCheckBoxNaturalGas.ToggleStateChanged += radCheckBoxNaturalGas_ToggleStateChanged;
            this.radCheckBoxCrudeOil.ToggleStateChanged += radCheckBoxCrudeOil_ToggleStateChanged;
        }

        private void radCheckBoxDryHoles_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radChartViewWellsDepth.Series[0].IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBoxNaturalGas_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radChartViewWellsDepth.Series[1].IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBoxCrudeOil_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radChartViewWellsDepth.Series[2].IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }
    }
}
