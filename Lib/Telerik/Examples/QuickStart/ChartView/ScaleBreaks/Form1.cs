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

namespace Telerik.Examples.WinControls.ChartView.ScaleBreaks
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        List<AxisScaleBreak> scaleBreaks = new List<AxisScaleBreak>();

        public Form1()
        {
            InitializeComponent();

            this.radDropDownListStyle.Items.Add(new RadListDataItem("Straight", ScaleBreakStyle.Straight));
            this.radDropDownListStyle.Items.Add(new RadListDataItem("Waved", ScaleBreakStyle.Waved));
            this.radDropDownListStyle.Items.Add(new RadListDataItem("Ragged", ScaleBreakStyle.Ragged));
            this.radDropDownListStyle.SelectedIndex = 0;

            this.radSpinEditorSize.Value = 5;

            this.radColorBoxBackColor.Value = Color.White;

            this.radColorBoxBorderColor.Value = Color.Gray;

            scaleBreaks.Add(new AxisScaleBreak("Break1", 3000, 4000));
            scaleBreaks.Add(new AxisScaleBreak("Break2", 1200, 2600));
            scaleBreaks.Add(new AxisScaleBreak("Break3", 40, 800));

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;

            BarSeries northAmerica = new BarSeries();
            northAmerica.LegendTitle = "North America";
            northAmerica.ShowLabels = true;
            northAmerica.DataPoints.Add(new CategoricalDataPoint(4274.6, 2012));
            northAmerica.DataPoints.Add(new CategoricalDataPoint(4806.9, 2011));
            northAmerica.DataPoints.Add(new CategoricalDataPoint(4935.5, 2010));
            northAmerica.DataPoints.Add(new CategoricalDataPoint(4975.4, 2009));

            BarSeries africa = new BarSeries();
            africa.LegendTitle = "Africa";
            africa.ShowLabels = true;
            africa.DataPoints.Add(new CategoricalDataPoint(2886.0, 2009));
            africa.DataPoints.Add(new CategoricalDataPoint(2785.8, 2010));
            africa.DataPoints.Add(new CategoricalDataPoint(2801.9, 2011));
            africa.DataPoints.Add(new CategoricalDataPoint(2817.7, 2012));

            BarSeries asia = new BarSeries();
            asia.LegendTitle = "Asia";
            asia.ShowLabels = true;
            asia.DataPoints.Add(new CategoricalDataPoint(20.4, 2009));
            asia.DataPoints.Add(new CategoricalDataPoint(19.6, 2010));
            asia.DataPoints.Add(new CategoricalDataPoint(21.9, 2011));
            asia.DataPoints.Add(new CategoricalDataPoint(24.0, 2012));

            BarSeries europe = new BarSeries();
            europe.LegendTitle = "Europe";
            europe.ShowLabels = true;
            europe.DataPoints.Add(new CategoricalDataPoint(1033.9, 2009));
            europe.DataPoints.Add(new CategoricalDataPoint(1095.9, 2010));
            europe.DataPoints.Add(new CategoricalDataPoint(1098.2, 2011));
            europe.DataPoints.Add(new CategoricalDataPoint(1040.5, 2012));

            this.radChartView1.Series.Add(northAmerica);
            this.radChartView1.Series.Add(africa);
            this.radChartView1.Series.Add(asia);
            this.radChartView1.Series.Add(europe);

            this.radChartView1.ShowLegend = true;

            foreach (AxisScaleBreak scaleBreak in this.scaleBreaks)
            {
                europe.VerticalAxis.ScaleBreaks.Add(scaleBreak);
            }

            europe.VerticalAxis.Title = "Million units";
            europe.HorizontalAxis.Title = "Year";
        }

        protected override void WireEvents()
        {
            this.radSpinEditorSize.ValueChanged += radSpinEditorSize_ValueChanged;
            this.radButtonScaleBreaks.Click += radButtonScaleBreaks_Click;
            this.radColorBoxBackColor.ValueChanged += radColorBoxBackColor_ValueChanged;
            this.radColorBoxBorderColor.ValueChanged += radColorBoxBorderColor_ValueChanged;
            this.radDropDownListStyle.SelectedIndexChanged += radDropDownListStyle_SelectedIndexChanged;
        }

        private void radColorBoxBackColor_ValueChanged(object sender, EventArgs e)
        {
            CartesianAxis axis = this.radChartView1.Axes[1] as CartesianAxis;
            axis.ScaleBreakBackColor = this.radColorBoxBackColor.Value;
        }

        private void radColorBoxBorderColor_ValueChanged(object sender, EventArgs e)
        {
            CartesianAxis axis = this.radChartView1.Axes[1] as CartesianAxis;
            axis.ScaleBreakBorderColor = this.radColorBoxBorderColor.Value;
        }

        private void radSpinEditorSize_ValueChanged(object sender, EventArgs e)
        {
            CartesianAxis axis = this.radChartView1.Axes[1] as CartesianAxis;
            axis.ScaleBreakSize = (double)this.radSpinEditorSize.Value;
        }

        private void radDropDownListStyle_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            CartesianAxis axis = this.radChartView1.Axes[1] as CartesianAxis;
            axis.ScaleBreakStyle = (ScaleBreakStyle)this.radDropDownListStyle.SelectedItem.Value;
        }

        private void radButtonScaleBreaks_Click(object sender, EventArgs e)
        {
            CartesianAxis axis = this.radChartView1.Axes[1] as CartesianAxis;

            if (axis.HasScaleBreaks)
            {
                axis.ScaleBreaks.Clear();

                this.radButtonScaleBreaks.Text = "Add Scale Breaks";
            }
            else
            {
                foreach (AxisScaleBreak scaleBreak in this.scaleBreaks)
                {
                    axis.ScaleBreaks.Add(scaleBreak);
                }

                this.radButtonScaleBreaks.Text = "Remove Scale Breaks";
            }
        }
    }
}
