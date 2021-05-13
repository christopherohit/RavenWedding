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

namespace Telerik.Examples.WinControls.ChartView.RadarAnnotations
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private Color color60S = Color.FromArgb(235, 122, 42);
        private Color color30S = Color.FromArgb(156, 214, 15);
        private Color color60N = Color.FromArgb(37, 160, 219);
        private Color color30N = Color.FromArgb(212, 223, 50);

        private RadarLineSeries series60S;
        private RadarLineSeries series30S;
        private RadarLineSeries series60N;
        private RadarLineSeries series30N;

        private RadialAxisGridLineAnnotation northwardEquinoxAnnotation;
        private RadialAxisGridLineAnnotation northernSolsticeAnnotation;
        private RadialAxisGridLineAnnotation southwardEquinoxAnnotation;
        private RadialAxisGridLineAnnotation southernSolsticeAnnotation;

        private RadialAxisPlotBandAnnotation springAnnotation;
        private RadialAxisPlotBandAnnotation summerAnnotation;
        private RadialAxisPlotBandAnnotation autunmAnnotation;
        private RadialAxisPlotBandAnnotation winterAnnotation;

        private PolarAxisPlotBandAnnotation workHoursAnnotation;

        public Form1()
        {
            InitializeComponent();

            this.radCheckBox60S.ButtonElement.TextElement.ForeColor = color60S;
            this.radCheckBox30S.ButtonElement.TextElement.ForeColor = color30S;
            this.radCheckBox60N.ButtonElement.TextElement.ForeColor = color60N;
            this.radCheckBox30N.ButtonElement.TextElement.ForeColor = color30N;

            this.radCheckBox60S.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.radCheckBox30S.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.radCheckBox60N.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.radCheckBox30N.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.SetupSeries();

            this.northwardEquinoxAnnotation = new RadialAxisGridLineAnnotation("March");
            this.northernSolsticeAnnotation = new RadialAxisGridLineAnnotation("June");
            this.southwardEquinoxAnnotation = new RadialAxisGridLineAnnotation("September");
            this.southernSolsticeAnnotation = new RadialAxisGridLineAnnotation("December");

            this.springAnnotation = new RadialAxisPlotBandAnnotation("June", "March");
            this.summerAnnotation = new RadialAxisPlotBandAnnotation("September", "June");
            this.autunmAnnotation = new RadialAxisPlotBandAnnotation("December", "September");
            this.winterAnnotation = new RadialAxisPlotBandAnnotation("March", "December");

            this.workHoursAnnotation = new PolarAxisPlotBandAnnotation(8, 17);
            this.workHoursAnnotation.BackColor = Color.FromArgb(80, 255, 160, 25);
        }

        private void SetupSeries()
        {
            this.series60S = new RadarLineSeries();
            this.series60S.ValueMember = "60S";
            this.series60S.CategoryMember = "Month";
            this.series60S.PointSize = new SizeF(7, 7);
            this.series60S.BackColor = this.series60S.BorderColor = color60S;

            this.series30S = new RadarLineSeries();
            this.series30S.ValueMember = "30S";
            this.series30S.CategoryMember = "Month";
            this.series30S.PointSize = new SizeF(7, 7);
            this.series30S.BackColor = this.series30S.BorderColor = color30S;

            this.series60N = new RadarLineSeries();
            this.series60N.ValueMember = "60N";
            this.series60N.CategoryMember = "Month";
            this.series60N.PointSize = new SizeF(7, 7);
            this.series60N.BackColor = this.series60N.BorderColor = color60N;

            this.series30N = new RadarLineSeries();
            this.series30N.ValueMember = "30N";
            this.series30N.CategoryMember = "Month";
            this.series30N.PointSize = new SizeF(7, 7);
            this.series30N.BackColor = this.series30N.BorderColor = color30N;

            this.radChartView1.Series.Add(this.series60S);
            this.radChartView1.Series.Add(this.series30S);
            this.radChartView1.Series.Add(this.series60N);
            this.radChartView1.Series.Add(this.series30N);
            this.radChartView1.DataSource = this.GetData();

            PolarArea area = this.radChartView1.GetArea<PolarArea>();
            RadialAxis radialAxis = area.Axes[1] as RadialAxis;
            PolarAxis polarAxis = area.Axes[0] as PolarAxis;

            area.StartAngle = 270;
            radialAxis.SweepDirection = SweepDirection.Clockwise;
            polarAxis.Minimum = 0;
            polarAxis.Maximum = 24;
            polarAxis.MajorStep = 6;
            polarAxis.LabelFormat = "{0}h";
        }

        private DataTable GetData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Month", typeof(string));
            table.Columns.Add("60S", typeof(double));
            table.Columns.Add("30S", typeof(double));
            table.Columns.Add("60N", typeof(double));
            table.Columns.Add("30N", typeof(double));

            table.Rows.Add("January", 18.34, 13.9, 10.1, 5.66);
            table.Rows.Add("February", 16.49, 13.42, 10.58, 7.51);
            table.Rows.Add("March", 14.04, 12.67, 11.33, 9.96);
            table.Rows.Add("April", 11.16, 11.72, 12.28, 12.84);
            table.Rows.Add("May", 8.43, 10.85, 13.15, 15.57);
            table.Rows.Add("June", 6.12, 10.21, 13.79, 17.88);
            table.Rows.Add("July", 5.62, 10.09, 13.91, 18.38);
            table.Rows.Add("August", 7.38, 10.54, 13.46, 16.62);
            table.Rows.Add("September", 10.09, 11.37, 12.63, 13.91);
            table.Rows.Add("October", 12.87, 12.29, 11.71, 11.13);
            table.Rows.Add("November", 15.69, 13.19, 10.81, 8.31);
            table.Rows.Add("December", 17.9, 13.79, 10.21, 6.1);

            return table;
        }

        protected override void WireEvents()
        {
            this.radCheckBox60S.ToggleStateChanged += radCheckBox60S_ToggleStateChanged;
            this.radCheckBox30S.ToggleStateChanged += radCheckBox30S_ToggleStateChanged;
            this.radCheckBox60N.ToggleStateChanged += radCheckBox60N_ToggleStateChanged;
            this.radCheckBox30N.ToggleStateChanged += radCheckBox30N_ToggleStateChanged;

            this.radCheckBoxSpring.ToggleStateChanged += radCheckBoxSpring_ToggleStateChanged;
            this.radCheckBoxSummer.ToggleStateChanged += radCheckBoxSummer_ToggleStateChanged;
            this.radCheckBoxAutumn.ToggleStateChanged += radCheckBoxAutumn_ToggleStateChanged;
            this.radCheckBoxWinter.ToggleStateChanged += radCheckBoxWinter_ToggleStateChanged;

            this.radCheckBoxSouthernSolstice.ToggleStateChanged += radCheckBoxSouthernSolstice_ToggleStateChanged;
            this.radCheckBoxSouthwardEquinox.ToggleStateChanged += radCheckBoxSouthwardEquinox_ToggleStateChanged;
            this.radCheckBoxNorthwardEquinox.ToggleStateChanged += radCheckBoxNorthwardEquinox_ToggleStateChanged;
            this.radCheckBoxNorthernSolstice.ToggleStateChanged += radCheckBoxNorthernSolstice_ToggleStateChanged;

            this.radCheckBoxWorkHours.ToggleStateChanged += radCheckBoxWorkHours_ToggleStateChanged;
        }

        private void radCheckBox60S_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.series60S.IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBox30S_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.series30S.IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBox60N_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.series60N.IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBox30N_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.series30N.IsVisible = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBoxSpring_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.springAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.springAnnotation);
            }
        }

        private void radCheckBoxSummer_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.summerAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.summerAnnotation);
            }
        }

        private void radCheckBoxAutumn_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.autunmAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.autunmAnnotation);
            }
        }

        private void radCheckBoxWinter_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.winterAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.winterAnnotation);
            }
        }

        private void radCheckBoxSouthernSolstice_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.southernSolsticeAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.southernSolsticeAnnotation);
            }
        }

        private void radCheckBoxSouthwardEquinox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.southwardEquinoxAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.southwardEquinoxAnnotation);
            }
        }

        private void radCheckBoxNorthernSolstice_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.northernSolsticeAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.northernSolsticeAnnotation);
            }
        }

        private void radCheckBoxNorthwardEquinox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.northwardEquinoxAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.northwardEquinoxAnnotation);
            }
        }

        private void radCheckBoxWorkHours_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Area.Annotations.Add(this.workHoursAnnotation);
            }
            else
            {
                this.radChartView1.Area.Annotations.Remove(this.workHoursAnnotation);
            }
        }
    }
}
