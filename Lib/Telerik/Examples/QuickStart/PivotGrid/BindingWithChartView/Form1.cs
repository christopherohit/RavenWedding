using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.Aggregates;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PivotGrid.BindingWithChartView
{
    public partial class Form1 : ExamplesForm
    {
        List<Order2> orders = new List<Order2>();
        LocalDataSourceProvider provider;

        public Form1()
        {
            this.InitializeComponent();

            this.WireEvents();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadData();
            this.SetupAxes();
            this.SetupPivot();
            this.LoadSettings();
        }

        private void LoadSettings()
        {
            this.radChartView1.ChartElement.LegendPosition = LegendPosition.Right;
            this.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter;

            this.checkBoxDelayUpdates.Checked = this.radPivotGrid1.ChartDataProvider.DelayUpdate;
            this.checkBoxSelectionOnly.Checked = this.radPivotGrid1.ChartDataProvider.SelectionOnly;
            this.checkBoxColumnSubTotals.Checked = this.radPivotGrid1.ChartDataProvider.IncludeColumnSubTotals;
            this.checkBoxRowSubTotals.Checked = this.radPivotGrid1.ChartDataProvider.IncludeRowSubTotals;
            this.checkBoxColumnGrandTotals.Checked = this.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals;
            this.checkBoxRowGrandTotals.Checked = this.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals;

            if (this.radPivotGrid1.ChartDataProvider.SeriesAxis == PivotAxis.Rows)
            {
                this.radioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            }
            else
            {
                this.radioColumns.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            }

            if (this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType == GeneratedSeriesType.Bar)
            {
                this.radioBarSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            }
            else if (this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType == GeneratedSeriesType.Line)
            {
                this.radioLineSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            }
            else if (this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType == GeneratedSeriesType.Area)
            {
                this.radioAreaSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            }
        }

        private void LoadData()
        {
            Stream stream = System.Reflection.Assembly.GetAssembly(this.GetType()).GetManifestResourceStream("Telerik.Examples.WinControls.PivotGrid.Settings.PivotData.txt");

            using (StreamReader streamReader = new StreamReader(stream))
            {
                while (streamReader.Peek() != -1)
                {
                    string[] items = streamReader.ReadLine().Split('\t');
                    Order2 o = new Order2()
                    {
                        Date = DateTime.Parse(items[0], System.Globalization.CultureInfo.InvariantCulture),
                        Product = items[1],
                        Quantity = int.Parse(items[2], System.Globalization.CultureInfo.InvariantCulture),
                        Net = double.Parse(items[3], System.Globalization.CultureInfo.InvariantCulture),
                        Promotion = items[4],
                        Advertisement = items[5]
                    };
                    this.orders.Add(o);
                }
            }
        }

        private void SetupPivot()
        {
            this.provider = new LocalDataSourceProvider() { ItemsSource = this.orders };

            this.provider.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Product", GroupComparer = new GroupNameComparer() });

            this.provider.ColumnGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "Date", Step = DateTimeStep.Month });
            this.provider.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Promotion", GroupComparer = new GroupNameComparer() });

            this.provider.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Quantity", CustomName = "Avg. Quantity", AggregateFunction = AggregateFunctions.Average });

            this.radPivotGrid1.PivotGridElement.UpdateCompleted += new EventHandler(pivotGridElement_DataUpdated);
            this.radPivotGrid1.DataProvider = this.provider;
            this.radChartView1.DataSource = this.radPivotGrid1;
        }

        void pivotGridElement_DataUpdated(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                if (this.radPivotGrid1.PivotGridElement.ColumnRootGroup.Children.Count == 0)
                {
                    return;
                }

                PivotGroupNode firstNode = this.radPivotGrid1.PivotGridElement.ColumnRootGroup.Children[0];
                this.radPivotGrid1.PivotGridElement.SelectColumn(firstNode);
                this.radPivotGrid1.PivotGridElement.UpdateCompleted -= pivotGridElement_DataUpdated;
            }));
        }

        private void SetupAxes()
        {
            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;

            CategoricalAxis horizontalAxis = new CategoricalAxis();
            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;

            this.radChartView1.Area.Axes.Add(horizontalAxis);
            this.radChartView1.Area.Axes.Add(verticalAxis);
        }

        protected override void WireEvents()
        {
            this.checkBoxDelayUpdates.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
            this.checkBoxSelectionOnly.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
            this.checkBoxColumnSubTotals.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
            this.checkBoxRowSubTotals.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
            this.checkBoxColumnGrandTotals.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);
            this.checkBoxRowGrandTotals.ToggleStateChanged += new StateChangedEventHandler(checkBox_ToggleStateChanged);

            this.radioRows.ToggleStateChanged += new StateChangedEventHandler(radioRows_ToggleStateChanged);
            this.radioColumns.ToggleStateChanged += new StateChangedEventHandler(radioRows_ToggleStateChanged);

            this.radioBarSeries.ToggleStateChanged += new StateChangedEventHandler(radioSeries_ToggleStateChanged);
            this.radioLineSeries.ToggleStateChanged += new StateChangedEventHandler(radioSeries_ToggleStateChanged);
            this.radioAreaSeries.ToggleStateChanged += new StateChangedEventHandler(radioSeries_ToggleStateChanged);

            this.radPivotGrid1.ChartDataProvider.UpdateCompleted += new EventHandler(ChartDataProvider_UpdateCompleted);
        }

        void UpdateAxesPlotMode()
        {
            CategoricalAxis axis = this.radChartView1.Axes[0] as CategoricalAxis;
            if (axis != null)
            {
                if (this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType == GeneratedSeriesType.Bar)
                {
                    axis.PlotMode = Charting.AxisPlotMode.BetweenTicks;
                }
                else
                {
                    axis.PlotMode = Charting.AxisPlotMode.OnTicksPadded;
                }
            }
        }

        void UpdateSeriesCombineMode()
        {
            if (this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType != GeneratedSeriesType.Bar)
            {
                foreach (CartesianSeries series in this.radChartView1.Series)
                {
                    series.CombineMode = ChartSeriesCombineMode.Stack;
                }
            }
        }

        void radioSeries_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radioBarSeries.IsChecked)
            {
                this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Bar;
            }
            else if (this.radioAreaSeries.IsChecked)
            {
                this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Area;

            }
            else if (this.radioLineSeries.IsChecked)
            {
                this.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Line;
            }

            UpdateAxesPlotMode();
        }

        void ChartDataProvider_UpdateCompleted(object sender, EventArgs e)
        {
            UpdateSeriesCombineMode();
        }

        void radioRows_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radPivotGrid1.ChartDataProvider.SeriesAxis = this.radioRows.IsChecked ? PivotAxis.Rows : PivotAxis.Columns;
        }

        void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (sender == this.checkBoxDelayUpdates)
            {
                this.radPivotGrid1.ChartDataProvider.DelayUpdate = this.checkBoxDelayUpdates.Checked;
            }
            else if (sender == this.checkBoxSelectionOnly)
            {
                this.radPivotGrid1.ChartDataProvider.SelectionOnly = this.checkBoxSelectionOnly.Checked;
            }
            else if (sender == this.checkBoxColumnSubTotals)
            {
                this.radPivotGrid1.ChartDataProvider.IncludeColumnSubTotals = this.checkBoxColumnSubTotals.Checked;
            }
            else if (sender == this.checkBoxRowSubTotals)
            {
                this.radPivotGrid1.ChartDataProvider.IncludeRowSubTotals = this.checkBoxRowSubTotals.Checked;
            }
            else if (sender == this.checkBoxColumnGrandTotals)
            {
                this.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals = this.checkBoxColumnGrandTotals.Checked;
            }
            else if (sender == this.checkBoxRowGrandTotals)
            {
                this.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals = this.checkBoxRowGrandTotals.Checked;
            }
        }
    }
}
