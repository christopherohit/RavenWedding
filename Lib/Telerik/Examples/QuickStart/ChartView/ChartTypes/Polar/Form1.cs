using System;
using System.Drawing;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Data;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Polar
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        DataSet set;
        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radChartView1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

             this.set = new DataSet();

            DataTable cardioid = new DataTable("Cardioid");
            cardioid.Columns.Add("Value", typeof(double));
            cardioid.Columns.Add("Angle", typeof(double));

            DataTable shotgunFront = new DataTable("ShotgunFront");
            shotgunFront.Columns.Add("Value", typeof(double));
            shotgunFront.Columns.Add("Angle", typeof(double));

            DataTable shotgunSide = new DataTable("ShotgunSide");
            shotgunSide.Columns.Add("Value", typeof(double));
            shotgunSide.Columns.Add("Angle", typeof(double));

            set.Tables.Add(cardioid);
            set.Tables.Add(shotgunFront);
            set.Tables.Add(shotgunSide);

            int count = 720;
            double angleStep = 2 * Math.PI / count;

            for (int i = 0; i < count; i++)
            {
                double factor = i > 0.25 * count && i < 0.75 * count ? 0.7 : 1;
                double angle = i * angleStep;

                cardioid.Rows.Add(0.5 + 0.5 * (Math.Cos(angle)), angle * 180 / Math.PI);
                shotgunFront.Rows.Add(factor * Math.Pow(Math.Abs(Math.Cos(angle)), 8), angle * 180 / Math.PI);
                shotgunSide.Rows.Add(0.48 * Math.Pow(Math.Abs(Math.Sin(angle)), 20), angle * 180 / Math.PI);
            }

            this.BindChartToLineSeries();
            this.radChartView1.DataSource = this.set;

            PolarArea area = this.radChartView1.Area as PolarArea;
            area.StartAngle = 90;
            area.ShowGrid = true;          
        }

        private void BindChartToLineSeries()
        {
            this.radChartView1.Area.Series.Clear();

            PolarLineSeries cardioidSeries = new PolarLineSeries("Value", "Angle");
            cardioidSeries.DataMember = "Cardioid";
            cardioidSeries.BorderWidth = 2;
            this.radChartView1.Series.Add(cardioidSeries);
            cardioidSeries.BorderColor = Color.FromArgb(200, 142, 196, 65);
            cardioidSeries.PointSize = SizeF.Empty;

            PolarLineSeries shotgunFrontSeries = new PolarLineSeries("Value", "Angle");
            shotgunFrontSeries.DataMember = "ShotgunFront";
            shotgunFrontSeries.BorderWidth = 2;
            this.radChartView1.Series.Add(shotgunFrontSeries);
            shotgunFrontSeries.BorderColor = Color.FromArgb(200, 27, 157, 222);
            shotgunFrontSeries.PointSize = SizeF.Empty;

            PolarLineSeries shotgunSideSeries = new PolarLineSeries("Value", "Angle");
            shotgunSideSeries.DataMember = "ShotgunSide";
            shotgunSideSeries.BorderWidth = 2;
            shotgunSideSeries.PointSize = SizeF.Empty;
            this.radChartView1.Series.Add(shotgunSideSeries);
            shotgunSideSeries.BorderColor = Color.FromArgb(200, 27, 157, 222);
            shotgunSideSeries.PointSize = SizeF.Empty;

            cardioidSeries.PolarAxis.Minimum = 0d;
            cardioidSeries.PolarAxis.Maximum = 1d;
            cardioidSeries.PolarAxis.MajorStep = 0.2d;
            cardioidSeries.PolarAxis.TickLength = 0;
            cardioidSeries.PolarAxis.MajorTickOffset = 1;
            cardioidSeries.PolarAxis.LastLabelVisibility = AxisLastLabelVisibility.Hidden;
            cardioidSeries.PolarAxis.LabelFormatProvider = new AxisLabelFormat();
            cardioidSeries.RadialAxis.LabelFormat = "{0}°";
            cardioidSeries.RadialAxis.TickLength = 0;
        }

        private void BindChartToAreaSeries()
        {
            this.radChartView1.Area.Series.Clear();

            PolarAreaSeries cardioidSeries = new PolarAreaSeries("Value", "Angle");
            cardioidSeries.DataMember = "Cardioid";
            this.radChartView1.Series.Add(cardioidSeries);
            cardioidSeries.BackColor = Color.FromArgb(200, 142, 196, 65);
            cardioidSeries.BorderColor = Color.FromArgb(142, 196, 65);
            cardioidSeries.PointSize = SizeF.Empty;

            PolarAreaSeries shotgunFrontSeries = new PolarAreaSeries("Value", "Angle");
            shotgunFrontSeries.DataMember = "ShotgunFront";
            this.radChartView1.Series.Add(shotgunFrontSeries);
            shotgunFrontSeries.BackColor = Color.FromArgb(200, 27, 157, 222);
            shotgunFrontSeries.BorderColor = Color.FromArgb(27, 157, 222);
            shotgunFrontSeries.PointSize = SizeF.Empty;

            PolarAreaSeries shotgunSideSeries = new PolarAreaSeries("Value", "Angle");
            shotgunSideSeries.DataMember = "ShotgunSide";
            this.radChartView1.Series.Add(shotgunSideSeries);
            shotgunSideSeries.BackColor = Color.FromArgb(200, 27, 157, 222);
            shotgunSideSeries.BorderColor = Color.FromArgb(27, 157, 222);
            shotgunSideSeries.PointSize = SizeF.Empty;
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (e.Position)
            {
                case 0:
                    this.BindChartToLineSeries();
                    break;
                case 1:
                    this.BindChartToAreaSeries();
                    break;
            }
        }

        protected override void WireEvents()
        {
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
        }
    }
}
