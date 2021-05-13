using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RangeSelector.MSFTStocks
{
    public partial class Form1 : ExamplesForm
    {
        private List<int> listOfDates = new List<int>();

        public Form1()
        {
            InitializeComponent();

            SetupCharts();

            //Setup range selector
            radRangeSelector1.AssociatedControl = radChartView1;
            radRangeSelector1.RangeSelectorElement.EnableFastScrolling = true;
            radRangeSelector1.SelectionChanged += radRangeSelector1_SelectionChanged;
            ((RangeSelectorViewElement)radRangeSelector1.RangeSelectorElement.AssociatedElement).LabelInitializing += new LabelInitializingEventHandler(RangeSelectorViewElement_LabelInitializing);

            this.radChartView1.View.Margin = new Padding(10, 0, 0, 0);
            this.radChartView2.View.Margin = new Padding(0, 0, 0, 15);
            this.radChartView1.BackColor = Color.White;
            this.radChartView2.BackColor = Color.White;
        }
      

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Hide the bar series from the selector
            RangeSelectorViewElement rangeChart = ((RangeSelectorViewElement)radRangeSelector1.RangeSelectorElement.AssociatedElement);
            rangeChart.View.Series[0].IsVisible = false;
            rangeChart.View.Series[1].Palette = KnownPalette.Sun.GlobalEntries[0];

            UpdateBarChartView();
        }

        private void SetupCharts()
        {
            DataTable data = GetDataTableFromCsv("..\\RangeSelector\\MSFTStocks\\ExampleData.csv", true);

            //Setup OHLC series. This is the series displayed in the upper chart.
            CandlestickSeries ohlcSeries = new CandlestickSeries();
            ohlcSeries.CloseValueMember = "Close";
            ohlcSeries.HighValueMember = "High";
            ohlcSeries.LowValueMember = "Low";
            ohlcSeries.OpenValueMember = "Open";
            ohlcSeries.CategoryMember = "Date";
            ohlcSeries.DataSource = data;
            radChartView1.Series.Add(ohlcSeries);
            ((CategoricalAxis)ohlcSeries.HorizontalAxis).MajorTickInterval = 20;
            ((CategoricalAxis)ohlcSeries.HorizontalAxis).LabelFormat = "{0:MMM yy}";

            //Setup a line series and add it to the upper chart. Make it invisible. It will be used by the range selector. 
            LineSeries lineSeries = new LineSeries();
            lineSeries.ValueMember = "Close";
            lineSeries.CategoryMember = "Date";
            lineSeries.DataSource = data;
            lineSeries.BorderWidth = 0;
            radChartView1.Series.Add(lineSeries);

            //Setup upper chart
            radChartView1.View.Palette = KnownPalette.Sun;
            radChartView1.ShowTitle = true;
            radChartView1.Title = "Microsoft Corporation (MSFT)-NasdaqGS";

            ChartTrackballController controller = new ChartTrackballController();
            radChartView1.Controllers.Add(controller);
            controller.TextNeeded += controller_TextNeeded;

            //Setup bar series for the second chart
            BarSeries barSeries = new BarSeries();
            barSeries.DataSource = data;
            barSeries.ValueMember = "Volume";
            barSeries.CategoryMember = "Date";
            radChartView2.Series.Add(barSeries);
            barSeries.HorizontalAxis.IsVisible = false;
            barSeries.VerticalAxis.LabelFormatProvider = new StringLimiterFormatProvider();
            barSeries.VerticalAxis.LabelFormat = "{0}M";

            //Setup the bottom chart
            radChartView2.View.Palette = KnownPalette.Metro;
            radChartView2.ShowTitle = true;
            radChartView2.Title = "Volume";
            radChartView2.View.Margin = new System.Windows.Forms.Padding(4, 0, 40, 5); //make its axes equal to the upper one

            ChartTrackballController controller2 = new ChartTrackballController();
            radChartView2.Controllers.Add(controller2);
            controller2.TextNeeded += controller_TextNeeded;
        }
        
        void radRangeSelector1_SelectionChanged(object sender, EventArgs e)
        {
            //when the selection in the range selector is changed, update the bottom chart
            UpdateBarChartView();
        }

        void RangeSelectorViewElement_LabelInitializing(object sender, LabelInitializingEventArgs e)
        {
            //Show just year labels
            DateTime date = DateTime.Parse(e.LabelElement.Text);
            if (!listOfDates.Contains(date.Year))
            {
                listOfDates.Add(date.Year);
                e.LabelElement.Text = string.Format("{0:yyyy}", date);
                e.LabelElement.AngleTransform = 45;
            }
            else
            {
                e.Cancel = true;
            }
        }

        void controller_TextNeeded(object sender, TextNeededEventArgs e)
        {
            string pattern = @"\d\d\d,\d\d\d,\d\d\d,\d+";
            string replacement = "black";
            Regex rgx = new Regex(pattern);
            e.Text = rgx.Replace(e.Text, replacement);
        }

        private void UpdateBarChartView()
        {
            double zoomFactor = 100d / (this.radRangeSelector1.EndRange - this.radRangeSelector1.StartRange);

            if (zoomFactor < 1d)
            {
                zoomFactor = 1d;
            }

            if (zoomFactor > 100d)
            {
                zoomFactor = 100d;
            }

            SizeF areaSize = ((RangeSelectorViewElement)this.radRangeSelector1.RangeSelectorElement.AssociatedElement).AreaSize;

            double pan = (((areaSize.Width - 1) * zoomFactor) / 100) * this.radRangeSelector1.StartRange;

            radChartView2.View.Zoom(zoomFactor, 1);
            radChartView2.View.Pan(-pan, 0);
        }


        static DataTable GetDataTableFromCsv(string path, bool isFirstRowHeader)
        {
            string header = isFirstRowHeader ? "Yes" : "No";

            string pathOnly = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);

            string sql = @"SELECT * FROM [" + fileName + "]";

            using (OleDbConnection connection = new OleDbConnection(
                      @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                      ";Extended Properties=\"Text;HDR=" + header + "\""))
            using (OleDbCommand command = new OleDbCommand(sql, connection))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataTable.Locale = CultureInfo.CurrentCulture;
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
