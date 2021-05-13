using System;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Radar
{
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

            RadarLineSeries hotel1DataList = new RadarLineSeries(new SizeF(6f, 6f));
            RadarLineSeries hotel2DataList = new RadarLineSeries(new SizeF(6f, 6f));
            RadarLineSeries hotel3DataList = new RadarLineSeries(new SizeF(6f, 6f));

            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(3.1d, "Price"));
            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(3.5d, "Accommodation"));
            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(3.8d, "Cleanness"));
            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(4.5d, "Bar/Cafe"));
            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(3.5d, "Restaurant"));
            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(3.6d, "Spa center"));
            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(3.0d, "Kids facilities"));
            hotel1DataList.DataPoints.Add(new CategoricalDataPoint(3.3d, "Overall"));

            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(3.8d, "Price"));
            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(4.5d, "Accommodation"));
            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(4.3d, "Cleanness"));
            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(3.8d, "Bar/Cafe"));
            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(4.7d, "Restaurant"));
            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(3.9d, "Spa center"));
            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(3.8d, "Kids facilities"));
            hotel2DataList.DataPoints.Add(new CategoricalDataPoint(4.0d, "Overall"));

            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(4.6d, "Price"));
            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(4.3d, "Accommodation"));
            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(4.7d, "Cleanness"));
            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(3.5d, "Bar/Cafe"));
            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(3.9d, "Restaurant"));
            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(3.2d, "Spa center"));
            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(4.0d, "Kids facilities"));
            hotel3DataList.DataPoints.Add(new CategoricalDataPoint(4.8d, "Overall"));

            this.radChartView1.Series.Add(hotel1DataList);
            this.radChartView1.Series.Add(hotel2DataList);
            this.radChartView1.Series.Add(hotel3DataList);

            hotel1DataList.BorderWidth = 2f;
            hotel2DataList.BorderWidth = 2f;
            hotel3DataList.BorderWidth = 2f;

            hotel1DataList.PolarAxis.Minimum = 0d;
            hotel1DataList.PolarAxis.Maximum = 5d;
            hotel1DataList.PolarAxis.TickLength = 5;
            hotel1DataList.RadialAxis.TickLength = 0; 

            PolarArea area = this.radChartView1.Area as PolarArea;
            area.ShowGrid = true;
        }

        private void radSpinEditorLineWidth_ValueChanged(object sender, EventArgs e)
        {
            foreach (RadarLineSeries series in this.radChartView1.Series)
            {
                series.BorderWidth = (float)this.radSpinEditorLineWidth.Value;
            }
        }

        private void radSpinEditorPointRadius_ValueChanged(object sender, EventArgs e)
        {
            foreach (RadarLineSeries series in this.radChartView1.Series)
            {
                series.PointSize = new SizeF((float)this.radSpinEditorPointRadius.Value, (float)this.radSpinEditorPointRadius.Value);
            }
        }

        protected override void WireEvents()
        {
            this.radSpinEditorPointRadius.ValueChanged += new System.EventHandler(this.radSpinEditorPointRadius_ValueChanged);
            this.radSpinEditorLineWidth.ValueChanged += new System.EventHandler(this.radSpinEditorLineWidth_ValueChanged);
        }
    }
}
