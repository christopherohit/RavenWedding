using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Charting;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.RangeSelector.MultipleAxes
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            SetupChartAndSelectors();
            SetupEvents();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            (this.radRangeSelector1.RangeSelectorElement.AssociatedElement as RangeSelectorViewElement).View.Palette = KnownPalette.Metro;
            (this.radRangeSelector2.RangeSelectorElement.AssociatedElement as RangeSelectorViewElement).View.Series[0].Palette = KnownPalette.Metro.GlobalEntries[2];
            (this.radRangeSelector2.RangeSelectorElement.AssociatedElement as RangeSelectorViewElement).View.Series[1].Palette = KnownPalette.Metro.GlobalEntries[3];
        }

        private void SetupChartAndSelectors()
        {
            this.radChartView1.View.Margin = new Padding(0, 0, 10, 0);

            CategoricalAxis horizontalAxis1 = new CategoricalAxis();
            horizontalAxis1.Title = "axe1";
            horizontalAxis1.TitleElement.Padding = new System.Windows.Forms.Padding(0, -10, 0, 0);
            horizontalAxis1.TitleElement.IsVisible = false;
            horizontalAxis1.AxisType = AxisType.First;
            CategoricalAxis horizontalAxis2 = new CategoricalAxis();
            horizontalAxis2.AxisType = AxisType.First;
            horizontalAxis2.VerticalLocation = AxisVerticalLocation.Top;
            horizontalAxis2.Title = "axe2";
            horizontalAxis2.TitleElement.Padding = new System.Windows.Forms.Padding(0, -10, 0, 0);
            horizontalAxis2.TitleElement.IsVisible = false;
            CategoricalAxis horizontalAxis3 = new CategoricalAxis();
            horizontalAxis3.AxisType = AxisType.First;
            LinearAxis verticalAxis1 = new LinearAxis();
            horizontalAxis3.Title = "axe3";
            horizontalAxis3.TitleElement.Padding = new System.Windows.Forms.Padding(0, -10, 0, 0);
            horizontalAxis3.TitleElement.IsVisible = false;
            verticalAxis1.AxisType = AxisType.Second;

            LineSeries series1 = new LineSeries();
            series1.Name = "series1";
            series1.HorizontalAxis = horizontalAxis1;
            series1.VerticalAxis = verticalAxis1;

            LineSeries series2 = new LineSeries();
            series2.Name = "series2";
            series2.HorizontalAxis = horizontalAxis1;
            series2.VerticalAxis = verticalAxis1;

            LineSeries series3 = new LineSeries();
            series3.Name = "series3";
            series3.HorizontalAxis = horizontalAxis2;
            series3.VerticalAxis = verticalAxis1;

            LineSeries series4 = new LineSeries();
            series4.Name = "series4";
            series4.HorizontalAxis = horizontalAxis3;
            series4.VerticalAxis = verticalAxis1;

            series1.DataPoints.Add(new CategoricalDataPoint(3.5, "Jan"));
            series1.DataPoints.Add(new CategoricalDataPoint(2.8, "Feb"));
            series1.DataPoints.Add(new CategoricalDataPoint(3.4, "Mar"));

            series1.DataPoints.Add(new CategoricalDataPoint(3.2, "Apr"));
            series1.DataPoints.Add(new CategoricalDataPoint(3.4, "May"));
            series1.DataPoints.Add(new CategoricalDataPoint(2.9, "Jun"));

            series1.DataPoints.Add(new CategoricalDataPoint(3.7, "Jul"));
            series1.DataPoints.Add(new CategoricalDataPoint(3.1, "Aug"));
            series1.DataPoints.Add(new CategoricalDataPoint(2.9, "Sep"));

            series1.DataPoints.Add(new CategoricalDataPoint(3.3, "Oct"));
            series1.DataPoints.Add(new CategoricalDataPoint(3.1, "Nov"));
            series1.DataPoints.Add(new CategoricalDataPoint(3.6, "Dec"));


            series2.DataPoints.Add(new CategoricalDataPoint(4.5, "Jan"));
            series2.DataPoints.Add(new CategoricalDataPoint(1.8, "Feb"));
            series2.DataPoints.Add(new CategoricalDataPoint(3.0, "Mar"));

            series2.DataPoints.Add(new CategoricalDataPoint(3.8, "Apr"));
            series2.DataPoints.Add(new CategoricalDataPoint(2.4, "May"));
            series2.DataPoints.Add(new CategoricalDataPoint(4.9, "Jun"));

            series2.DataPoints.Add(new CategoricalDataPoint(4.1, "Jul"));
            series2.DataPoints.Add(new CategoricalDataPoint(2.1, "Aug"));
            series2.DataPoints.Add(new CategoricalDataPoint(3.9, "Sep"));

            series2.DataPoints.Add(new CategoricalDataPoint(5.3, "Oct"));
            series2.DataPoints.Add(new CategoricalDataPoint(3.5, "Nov"));
            series2.DataPoints.Add(new CategoricalDataPoint(4.6, "Dec"));


            series3.DataPoints.Add(new CategoricalDataPoint(4.8, "1999"));
            series3.DataPoints.Add(new CategoricalDataPoint(5.2, "2000"));
            series3.DataPoints.Add(new CategoricalDataPoint(6, "2001"));
            series3.DataPoints.Add(new CategoricalDataPoint(5.8, "2002"));
            series3.DataPoints.Add(new CategoricalDataPoint(5.4, "2003"));
            series3.DataPoints.Add(new CategoricalDataPoint(5.6, "2004"));
            series3.DataPoints.Add(new CategoricalDataPoint(5, "2005"));
            series3.DataPoints.Add(new CategoricalDataPoint(4.7, "2006"));
            series3.DataPoints.Add(new CategoricalDataPoint(4.6, "2007"));
            series3.DataPoints.Add(new CategoricalDataPoint(4.2, "2008"));
            series3.DataPoints.Add(new CategoricalDataPoint(5.3, "2009"));
            series3.DataPoints.Add(new CategoricalDataPoint(4.9, "2010"));
            series3.DataPoints.Add(new CategoricalDataPoint(4.1, "2011"));
            series3.DataPoints.Add(new CategoricalDataPoint(7.9, "2012"));
            series3.DataPoints.Add(new CategoricalDataPoint(3.5, "2013"));

            series4.DataPoints.Add(new CategoricalDataPoint(6.23, "Q1"));
            series4.DataPoints.Add(new CategoricalDataPoint(7.5, "Q2"));
            series4.DataPoints.Add(new CategoricalDataPoint(5.8, "Q3"));
            series4.DataPoints.Add(new CategoricalDataPoint(6.95, "Q4"));

            this.radChartView1.Series.Add(series1);
            this.radChartView1.Series.Add(series2);
            this.radChartView1.Series.Add(series3);
            this.radChartView1.Series.Add(series4);

            this.radChartView1.View.Palette = KnownPalette.Metro;

            this.radRangeSelector1.AssociatedControl = this.radChartView1;
            this.radRangeSelector2.AssociatedControl = this.radChartView1;
            this.radChartView1.BackColor = Color.White;

        }

        private void SetupEvents()
        {
            this.radRangeSelector1.ScaleInitializing += new ScaleInitializingEventHandler(radRangeSelector1_ScaleInitializing);
            this.radRangeSelector2.ScaleInitializing += new ScaleInitializingEventHandler(radRangeSelector2_ScaleInitializing);

            RangeSelectorViewElement rangeSelectorChart1 = this.radRangeSelector1.RangeSelectorElement.AssociatedElement as RangeSelectorViewElement;
            if (rangeSelectorChart1 != null)
            {
                rangeSelectorChart1.SeriesInitializing += new SeriesInitializingEventHandler(rangeSelectorChart1_SeriesInitializing);
            }

            RangeSelectorViewElement rangeSelectorChart2 = this.radRangeSelector2.RangeSelectorElement.AssociatedElement as RangeSelectorViewElement;
            if (rangeSelectorChart2 != null)
            {
                rangeSelectorChart2.SeriesInitializing += new SeriesInitializingEventHandler(rangeSelectorChart2_SeriesInitializing);
            }

            this.radRangeSelector1.ThumbLeftValueChanged += new EventHandler(radRangeSelector1_ThumbLeftValueChanged);
            this.radRangeSelector1.ThumbRightValueChanged += new EventHandler(radRangeSelector1_ThumbRightValueChanged);
            this.radRangeSelector2.ThumbLeftValueChanged += new EventHandler(radRangeSelector2_ThumbLeftValueChanged);
            this.radRangeSelector2.ThumbRightValueChanged += new EventHandler(radRangeSelector2_ThumbRightValueChanged);
        }

        #region Event Handlers

        void radRangeSelector1_ScaleInitializing(object sender, ScaleInitializingEventArgs e)
        {
            RangeSelectorChartScaleContainerElement scaleElement = e.ScaleElement as RangeSelectorChartScaleContainerElement;
            if (scaleElement == null)
            {
                return;
            }
            if (!(scaleElement.Title == "axe1"))
            {
                e.Cancel = true;
            }
        }

        void rangeSelectorChart1_SeriesInitializing(object sender, SeriesInitializingEventArgs e)
        {
            if (e.Series.Name == "series1" || e.Series.Name == "series2")
            {
                e.SeriesType = typeof(BarSeries);
            }
            else
            {
                e.Cancel = true;
            }
        }

        void radRangeSelector2_ScaleInitializing(object sender, ScaleInitializingEventArgs e)
        {
            RangeSelectorChartScaleContainerElement scaleElement = e.ScaleElement as RangeSelectorChartScaleContainerElement;
            if (scaleElement == null)
            {
                return;
            }

            if (scaleElement.Title == "axe2")
            {
                foreach (RangeSelectorChartScaleLabelElement item in e.ScaleElement.Children)
                {
                    item.ForeColor = Color.FromArgb(255, 166, 105, 64);
                }
            }
            else if (scaleElement.Title == "axe3")
            {
                e.ScaleElement.ScalePostion = ViewPosition.TopLeft;
                foreach (RangeSelectorChartScaleLabelElement item in e.ScaleElement.Children)
                {
                    item.ForeColor = Color.FromArgb(255, 142, 196, 65);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        void rangeSelectorChart2_SeriesInitializing(object sender, SeriesInitializingEventArgs e)
        {
            if (e.Series.Name == "series3" || e.Series.Name == "series4")
            {
                e.SeriesType = typeof(AreaSeries);
            }
            else
            {
                e.Cancel = true;
            }
        }


        void radRangeSelector1_ThumbLeftValueChanged(object sender, EventArgs e)
        {
            this.radRangeSelector2.StartRange = this.radRangeSelector1.StartRange;
        }

        void radRangeSelector1_ThumbRightValueChanged(object sender, EventArgs e)
        {
            this.radRangeSelector2.EndRange = this.radRangeSelector1.EndRange;
        }

        void radRangeSelector2_ThumbLeftValueChanged(object sender, EventArgs e)
        {
            this.radRangeSelector1.StartRange = this.radRangeSelector2.StartRange;
        }

        void radRangeSelector2_ThumbRightValueChanged(object sender, EventArgs e)
        {
            this.radRangeSelector1.EndRange = this.radRangeSelector2.EndRange;
        }

        #endregion
    }
}
