using System;
using System.Collections.Generic;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using Telerik.Charting;
using System.Drawing;

namespace Telerik.Examples.WinControls.ChartView.Appearance
{
    /// <summary>
    /// RadChartView example
    /// </summary>
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        int[] barSeriesValues = new int[] {270, 330, 390, 280, 350, 250, 410, 310};
        double[] radarSeriesValues = new double[] { 3.9, 3.9, 2, 4, 3.5, 3, 3.5, 4.1, 1.5, 5, 2.5, 2.5, 2, 4.5, 2, 3.5, 1, 2.5, 4.5, 3, 4.2, 2.8, 3.2, 2 };

        public Form1()
        {
            InitializeComponent();
        }
       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            InitializePaletteListControl();

            InitializeBarChart();
            InitializePieChart();
            InitializeRadarChart();
            InitializeLineChart();
            InitializeAreaChart();

            this.radListControl1.SelectedValue = KnownPalette.Metro;
        }

        void radListControl1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.radChartView1.View.Palette = this.radListControl1.SelectedValue as ChartPalette;
            this.radChartView2.View.Palette = this.radListControl1.SelectedValue as ChartPalette;
            this.radChartView3.View.Palette = this.radListControl1.SelectedValue as ChartPalette;
            this.radChartView4.View.Palette = this.radListControl1.SelectedValue as ChartPalette;
            this.radChartView5.View.Palette = this.radListControl1.SelectedValue as ChartPalette;
        }

        private void InitializePaletteListControl()
        {
            List<PaletteObject> palettes = new List<PaletteObject>();
            palettes.Add(new PaletteObject(KnownPalette.ArcticPaletteName, KnownPalette.Arctic));
            palettes.Add(new PaletteObject(KnownPalette.AutumnPaletteName, KnownPalette.Autumn));
            palettes.Add(new PaletteObject(KnownPalette.ColdPaletteName, KnownPalette.Cold));
            palettes.Add(new PaletteObject(KnownPalette.FlowerPaletteName, KnownPalette.Flower));
            palettes.Add(new PaletteObject(KnownPalette.ForestPaletteName, KnownPalette.Forest));
            palettes.Add(new PaletteObject(KnownPalette.GrayscalePaletteName, KnownPalette.Grayscale));
            palettes.Add(new PaletteObject(KnownPalette.GroundPaletteName, KnownPalette.Ground));
            palettes.Add(new PaletteObject(KnownPalette.LilacPaletteName, KnownPalette.Lilac));
            palettes.Add(new PaletteObject(KnownPalette.MetroPaletteName, KnownPalette.Metro));
            palettes.Add(new PaletteObject(KnownPalette.NaturalPaletteName, KnownPalette.Natural));
            palettes.Add(new PaletteObject(KnownPalette.PastelPaletteName, KnownPalette.Pastel));
            palettes.Add(new PaletteObject(KnownPalette.RainbowPaletteName, KnownPalette.Rainbow));
            palettes.Add(new PaletteObject(KnownPalette.SpringPaletteName, KnownPalette.Spring));
            palettes.Add(new PaletteObject(KnownPalette.SummerPaletteName, KnownPalette.Summer));
            palettes.Add(new PaletteObject(KnownPalette.WarmPaletteName, KnownPalette.Warm));
            palettes.Add(new PaletteObject(KnownPalette.Windows8PaletteName, KnownPalette.Windows8));
            palettes.Add(new PaletteObject(KnownPalette.SunPaletteName, KnownPalette.Sun));
            palettes.Add(new PaletteObject(KnownPalette.FluentPaletteName, KnownPalette.Fluent));
            palettes.Add(new PaletteObject(KnownPalette.MaterialPaletteName, KnownPalette.Material));

            this.radListControl1.DisplayMember = "Name";
            this.radListControl1.ValueMember = "Palette";
            this.radListControl1.DataSource = palettes;
        }

        private void InitializeAreaChart()
        {
           AreaSeries areaSeries;
            AreaSeriesDataModel model = new AreaSeriesDataModel();
            for (int i = 0; i < 8; i++)
            {
                areaSeries = new AreaSeries();
               
                areaSeries.Spline = true;
                areaSeries.CategoryMember = "Month";
                areaSeries.ValueMember = "Profit";
                areaSeries.DataSource = model.GetData(i);
                areaSeries.PointSize = new SizeF(0, 0);
                this.radChartView5.Series.Add(areaSeries);

            }
            
            this.radChartView5.View.Margin = new Padding(0, 0, 30, 0);
        }

        private void InitializeLineChart()
        {
            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;

            LineSeries lineSeries;
            LineSeriesDataModel model = new LineSeriesDataModel();
            for (int i = 0; i < 8; i++)
            {
                lineSeries = new LineSeries();
                
                lineSeries.CategoryMember = "Month";
                lineSeries.ValueMember = "Profit";
                lineSeries.DataSource = model.GetData(i);
                float pointSize = i < 2 ? 3 : 0;
                lineSeries.PointSize = new SizeF(pointSize, pointSize);
                this.radChartView4.Series.Add(lineSeries);
            }

            this.radChartView4.View.Margin = new Padding(0, 0, 30, 0);
        }

        private void InitializeRadarChart()
        {
            this.radChartView3.AreaType = ChartAreaType.Polar;
            this.radChartView3.Axes.Add(new PolarAxis());

            PolarArea area = this.radChartView3.Area as PolarArea;
            PolarAxis polarAxis = area.Axes.Get<PolarAxis>()[0];
            polarAxis.Minimum = 0d;
            polarAxis.Maximum = 5d;
            polarAxis.TickLength = 5;
            area.ShowGrid = true;
            PolarGrid grid = (PolarGrid)area.Grid;
            grid.DrawPolarFills = false;
            grid.DrawRadialFills = false;
            grid.BackColor = Color.LightGray;
            grid.BackColor2 = Color.LightGray;

            int valuesPerSeries = 8;
            List<RadarSeries> radarSeries = new List<RadarSeries>();
            RadarLineSeries radarLineSeries1 = new RadarLineSeries();
            radarLineSeries1.PolarAxis = polarAxis;

            RadarLineSeries radarLineSeries2 = new RadarLineSeries();
            radarLineSeries2.PolarAxis = polarAxis;

            RadarAreaSeries radarAreaSeries1 = new RadarAreaSeries();
            radarAreaSeries1.PolarAxis = polarAxis;

            radarSeries.Add(radarLineSeries1);
            radarSeries.Add(radarLineSeries2);
            radarSeries.Add(radarAreaSeries1);

            for(int i = 0; i < radarSeriesValues.Length; i++)
            {
                int seriesNumber = i / valuesPerSeries;
                radarSeries[seriesNumber].DataPoints.Add(new CategoricalDataPoint(radarSeriesValues[i]));
            }

            radarLineSeries1.PointSize = new SizeF(1f, 1f);
            radarLineSeries2.PointSize = new SizeF(1f, 1f);
            radarAreaSeries1.PointSize = new SizeF(1f, 1f);

            this.radChartView3.Series.Add(radarAreaSeries1);
            this.radChartView3.Series.Add(radarLineSeries2);
            this.radChartView3.Series.Add(radarLineSeries1);

            this.radChartView3.View.Margin = new Padding(20);
        }

        private void InitializePieChart()
        {
            PieDataPoint point;
            PieSeries pieSeries = new PieSeries();

            for (int i = 0; i < 6; i++)
            {
                point = new PieDataPoint();
                point.Value = 60;
                pieSeries.DataPoints.Add(point);
            }
            
            this.radChartView2.Series.Add(pieSeries);
        }
  
        private void InitializeBarChart()
        {
            CategoricalDataPoint point;
            BarSeries barSeries;
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            CartesianGrid grid = area.GetGrid<CartesianGrid>();

            grid.ForeColor = Color.FromArgb(235, 235, 235);
            grid.DrawVerticalStripes = false;
            grid.DrawHorizontalStripes = true;
            grid.DrawHorizontalFills = false;
            grid.DrawVerticalFills = false;
            area.ShowGrid = true;

            for (int i = 0; i < barSeriesValues.Length; i++)
            {
                barSeries = new BarSeries();
                point = new CategoricalDataPoint(barSeriesValues[i], "May 2012");
                barSeries.DataPoints.Add(point);
                area.Series.Add(barSeries);
            }
           
            this.radChartView1.View.Margin = new Padding(0, 0, 30, 0);
        }

        void radListControl1_ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            PaletteListDataItem listDataItem = (PaletteListDataItem)args.NewItem;
            PaletteObject dataObject = (PaletteObject)listDataItem.DataBoundItem;

            listDataItem.Palette = dataObject.Palette;
        }

        void radListControl1_ItemDataBinding(object sender, ListItemDataBindingEventArgs args)
        {
            args.NewItem = new PaletteListDataItem();
        }

        void radListControl1_CreatingVisualListItem(object sender, CreatingVisualListItemEventArgs args)
        {
            args.VisualItem = new PaletteListVisualItem();
        }

        protected override void WireEvents()
        {
            this.radListControl1.SelectedValueChanged += new System.EventHandler(this.radListControl1_SelectedValueChanged);
            this.radListControl1.ItemDataBinding += new Telerik.WinControls.UI.ListItemDataBindingEventHandler(this.radListControl1_ItemDataBinding);
            this.radListControl1.ItemDataBound += new Telerik.WinControls.UI.ListItemDataBoundEventHandler(this.radListControl1_ItemDataBound);
            this.radListControl1.CreatingVisualListItem += new Telerik.WinControls.UI.CreatingVisualListItemEventHandler(this.radListControl1_CreatingVisualListItem);
        }
    }
}
