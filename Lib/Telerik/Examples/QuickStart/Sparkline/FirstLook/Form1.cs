using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.Examples.WinControls.Editors;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Sparkline.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm, ICustomThemeExamplesForm
    {
        private ExampleViewModel viewModel;

        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;
            this.doubleBufferedTableLayoutPanel1.CellPaint += this.DoubleBufferedTableLayoutPanel1_CellPaint;
        }

        private void AttachChildViewModels()
        {
            this.sparklineUserControl1.Owner = this.viewModel.Callees[0];
            this.sparklineUserControl1.CallType = CallType.Duration;
            this.sparklineUserControl2.Owner = this.viewModel.Callees[0];
            this.sparklineUserControl2.CallType = CallType.HoldTime;
            this.sparklineUserControl3.Owner = this.viewModel.Callees[0];
            this.sparklineUserControl3.CallType = CallType.ResolvedIssues;

            this.sparklineUserControl4.Owner = this.viewModel.Callees[1];
            this.sparklineUserControl4.CallType = CallType.Duration;
            this.sparklineUserControl5.Owner = this.viewModel.Callees[1];
            this.sparklineUserControl5.CallType = CallType.HoldTime;
            this.sparklineUserControl6.Owner = this.viewModel.Callees[1];
            this.sparklineUserControl6.CallType = CallType.ResolvedIssues;

            this.sparklineUserControl7.Owner = this.viewModel.Callees[2];
            this.sparklineUserControl7.CallType = CallType.Duration;
            this.sparklineUserControl8.Owner = this.viewModel.Callees[2];
            this.sparklineUserControl8.CallType = CallType.HoldTime;
            this.sparklineUserControl9.Owner = this.viewModel.Callees[2];
            this.sparklineUserControl9.CallType = CallType.ResolvedIssues;
        }

        private void DoubleBufferedTableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row > 0 && e.Row < this.doubleBufferedTableLayoutPanel1.RowCount - 1)
            {
                Rectangle rectangle = e.CellBounds;
                if (e.Column == this.doubleBufferedTableLayoutPanel1.ColumnCount - 1)
                {
                    rectangle.Width -= 1;
                }

                e.Graphics.DrawRectangle(Pens.LightGray, rectangle);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.viewModel = new ExampleViewModel();
            this.AttachChildViewModels();
            this.BindChartView();

            this.radLabel6.Text = this.viewModel.Callees[0].Name;
            this.radLabel7.Text = this.viewModel.Callees[1].Name;
            this.radLabel8.Text = this.viewModel.Callees[2].Name;

            this.radChartView1.Title = "Overall Performance for the past 24 hours";
            this.radChartView1.ShowTitle = true;
            this.radChartView1.View.Margin = new Padding(0, 10, 0, 0);
            this.radChartView1.BackColor = Color.White;
            this.radChartView1.ForeColor = Color.Black;

            this.UpdateChartTitle();
            this.radChartView1.ShowLegend = true;
            this.radChartView1.ChartElement.LegendElement.PositionOffset = new SizeF(0, -100);
            this.radChartView1.ChartElement.LegendOffset = new Point(660, 50);
        }

        private void BindChartView()
        {
            LineSeries lineSeries = new LineSeries("Active Calls");
            lineSeries.DataSource = this.viewModel.Calls;
            lineSeries.CategoryMember = "TimeInverval";
            lineSeries.ValueMember = "DurationMinutes";
            lineSeries.LegendTitle = "Calls on Hold";
            lineSeries.LegendTitle = "Active Calls";
            lineSeries.BorderColor = Color.FromArgb(142, 196, 65);
            this.radChartView1.Series.Add(lineSeries);

            LineSeries lineSeries2 = new LineSeries("Calls on Hold");
            lineSeries2.DataSource = this.viewModel.Calls;
            lineSeries2.CategoryMember = "TimeInverval";
            lineSeries2.ValueMember = "HoldTimeMinutes";
            lineSeries2.LegendTitle = "Calls on Hold";
            lineSeries2.BorderColor = Color.FromArgb(27, 157, 222);
            this.radChartView1.Series.Add(lineSeries2);

            LineSeries lineSeries3 = new LineSeries("Abondenments");
            lineSeries3.DataSource = this.viewModel.Calls;
            lineSeries3.CategoryMember = "TimeInverval";
            lineSeries3.ValueMember = "Abandonments";
            lineSeries3.LegendTitle = "Abandonments";
            lineSeries3.BorderColor = Color.FromArgb(245, 151, 0);
            this.radChartView1.Series.Add(lineSeries3);

            NumericalAxis verticalAxis = this.radChartView1.Axes[1] as NumericalAxis;
            if (verticalAxis != null)
            {
                verticalAxis.Maximum = 100;
                verticalAxis.DesiredTickCount = 6;
            }

            CategoricalAxis horizontalAxis = this.radChartView1.Axes[0] as CategoricalAxis;
            if (horizontalAxis != null)
            {
                horizontalAxis.PlotMode = AxisPlotMode.OnTicksPadded;
                horizontalAxis.LabelInterval = 2;
                horizontalAxis.LabelFormat = "{0:HH:mm}h";
            }

            this.radChartView1.Area.View.Palette = KnownPalette.Fluent;
        }

        private void UpdateChartTitle()
        {
            ChartTitleElement titleElement = this.radChartView1.ChartElement.FindDescendant<ChartTitleElement>();
            if (titleElement != null)
            {
                titleElement.Font = this.radLabel1.Font;
                titleElement.Margin = new Padding(0, 10, 0, 0);
            }
        }
    }
}
