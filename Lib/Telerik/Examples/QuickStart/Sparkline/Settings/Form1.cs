using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Sparkline;

namespace Telerik.Examples.WinControls.Sparkline.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private static Random rand = new Random();

        private bool suspendCheckAll;

        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;

            this.AddLineData();
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.tableLayoutPanel1.CellPaint += TableLayoutPanel1_CellPaint;
        }

        protected override void UnwireEvents()
        {
            base.UnwireEvents();

            this.tableLayoutPanel1.CellPaint -= TableLayoutPanel1_CellPaint;
        }

        private void TableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray);
            pen.Width = 2;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (e.Row < this.tableLayoutPanel1.RowCount - 1)
            {
                if (e.Column < this.tableLayoutPanel1.ColumnCount - 1)
                {
                    e.Graphics.DrawLine(pen, new Point(e.CellBounds.X, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Bottom));
                    e.Graphics.DrawLine(pen, new Point(e.CellBounds.Right, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Y));
                }
                else
                {
                    e.Graphics.DrawLine(pen, new Point(e.CellBounds.X, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Bottom));
                }
            }
            else
            {
                if (e.Column < this.tableLayoutPanel1.ColumnCount - 1)
                {
                    e.Graphics.DrawLine(pen, new Point(e.CellBounds.Right, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Y));
                }
            }
        }

        private void AddLineData()
        {
            SparkLineSeries lineSeries = new SparkLineSeries();

            this.radSparkline1.Series = lineSeries;

            lineSeries = new SparkLineSeries();
            this.radSparkline2.Series = lineSeries;

            lineSeries = new SparkLineSeries();
            this.radSparkline3.Series = lineSeries;

            lineSeries = new SparkLineSeries();
            this.radSparkline4.Series = lineSeries;

            for (int i = 0; i < 12; i++)
            {
                this.radSparkline1.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline2.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline3.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline4.Series.DataPoints.Add(rand.Next(-100, 100));
            }

            SparkAreaSeries areaSeries = new SparkAreaSeries();
            this.radSparkline5.Series = areaSeries;

            areaSeries = new SparkAreaSeries();
            this.radSparkline6.Series = areaSeries;

            areaSeries = new SparkAreaSeries();
            this.radSparkline7.Series = areaSeries;

            areaSeries = new SparkAreaSeries();
            this.radSparkline8.Series = areaSeries;

            for (int i = 0; i < 12; i++)
            {
                this.radSparkline5.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline6.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline7.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline8.Series.DataPoints.Add(rand.Next(-100, 100));
            }

            SparkScatterSeries scatterSeries = new SparkScatterSeries();
            this.radSparkline9.Series = scatterSeries;

            scatterSeries = new SparkScatterSeries();
            this.radSparkline10.Series = scatterSeries;

            scatterSeries = new SparkScatterSeries();
            this.radSparkline11.Series = scatterSeries;

            scatterSeries = new SparkScatterSeries();
            this.radSparkline12.Series = scatterSeries;

            for (int i = 0; i < 12; i++)
            {
                this.radSparkline9.Series.DataPoints.Add(i, rand.Next(-100, 100));
                this.radSparkline10.Series.DataPoints.Add(i, rand.Next(-100, 100));
                this.radSparkline11.Series.DataPoints.Add(i, rand.Next(-100, 100));
                this.radSparkline12.Series.DataPoints.Add(i, rand.Next(-100, 100));
            }

            SparkBarSeries barSeries = new SparkBarSeries();
            this.radSparkline13.Series = barSeries;

            barSeries = new SparkBarSeries();
            this.radSparkline14.Series = barSeries;

            barSeries = new SparkBarSeries();
            this.radSparkline15.Series = barSeries;

            barSeries = new SparkBarSeries();
            this.radSparkline16.Series = barSeries;

            for (int i = 0; i < 12; i++)
            {
                this.radSparkline13.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline14.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline15.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline16.Series.DataPoints.Add(rand.Next(-100, 100));
            }

            SparkWinLossSeries winLossSeries = new SparkWinLossSeries();
            this.radSparkline17.Series = winLossSeries;

            winLossSeries = new SparkWinLossSeries();
            this.radSparkline18.Series = winLossSeries;

            winLossSeries = new SparkWinLossSeries();
            this.radSparkline19.Series = winLossSeries;

            winLossSeries = new SparkWinLossSeries();
            this.radSparkline20.Series = winLossSeries;

            for (int i = 0; i < 12; i++)
            {
                this.radSparkline17.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline18.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline19.Series.DataPoints.Add(rand.Next(-100, 100));
                this.radSparkline20.Series.DataPoints.Add(rand.Next(-100, 100));
            }
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.ShowHighPointIndicator = this.radCheckBoxHighPoint.Checked;
            }

            this.UpdateCheckAll();
        }

        private void radCheckBox2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.ShowLowPointIndicator = this.radCheckLowPoint.Checked;
            }

            this.UpdateCheckAll();
        }

        private void radCheckBox3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {

            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.ShowNegativePointIndicators = this.radCheckBoxNegativePoints.Checked;
            }

            this.UpdateCheckAll();
        }

        private void radCheckBox4_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.ShowFirstPointIndicator = this.radCheckBoxFirstPoint.Checked;
            }

            this.UpdateCheckAll();
        }

        private void radCheckBox5_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.ShowLastPointIndicator = this.radCheckBoxLastPoint.Checked;
            }

            this.UpdateCheckAll();
        }

        //markers
        private void radCheckBox6_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                SparkLineSeries lineSeries = sparkline.Series as SparkLineSeries;
                if (lineSeries != null)
                {
                    lineSeries.ShowMarkers = this.radCheckBoxMarkers.Checked;
                }
            }

            this.UpdateCheckAll();
        }

        //normal range
        private void radCheckBox7_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                if (sparkline.Series is SparkLineSeries || sparkline.Series is SparkScatterSeries)
                {
                    if (this.radCheckBoxRange.Checked)
                    {
                        CartesianSparkPlotBandAnnotation range = new CartesianSparkPlotBandAnnotation();
                        range.DrawMode = AnnotationDrawMode.BelowSeries;
                        range.Axis = sparkline.Series.Axes[1] as SparkCartesianAxis;
                        range.From = -30;
                        range.To = 30;
                        range.BackColor = Color.FromArgb(100, Color.LightGray);
                        sparkline.SparklineElement.View.Annotations.Add(range);
                    }
                    else
                    {
                        sparkline.SparklineElement.View.Annotations.Clear();
                    }                  
                }
            }

            this.UpdateCheckAll();
        }

        //axis
        private void radCheckBox8_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                SparkLineSeries lineSeries = sparkline.Series as SparkLineSeries;
                if (sparkline.Series is SparkLineSeries || sparkline.Series is SparkScatterSeries)
                {
                    sparkline.ShowAxis = this.radCheckBoxAxis.Checked;
                }
            }

            this.UpdateCheckAll();
        }

        //show tooltip
        private void radCheckBoxTooltip_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.ShowToolTip = this.radCheckBoxTooltip.Checked;
            }

            this.UpdateCheckAll();
        }

        //show all
        private void radCheckBox9_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.suspendCheckAll)
            {
                return;
            }

            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                this.suspendCheckAll = true;
                this.radCheckBoxHighPoint.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckLowPoint.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckBoxNegativePoints.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckBoxFirstPoint.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckBoxLastPoint.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckBoxMarkers.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckBoxRange.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckBoxAxis.Checked = this.radCheckBoxShowAll.Checked;
                this.radCheckBoxTooltip.Checked = this.radCheckBoxShowAll.Checked;
                this.suspendCheckAll = false;
            }
        }

        private void UpdateCheckAll()
        {
            if (this.suspendCheckAll)
            {
                return;
            }

            bool shouldCheck = true;
            foreach (Control control in this.radGroupBox1.Controls)
            {
                RadCheckBox checkBox = control as RadCheckBox;
                if (checkBox == null || checkBox == this.radCheckBoxShowAll)
                {
                    continue;
                }

                if (!checkBox.Checked)
                {
                    shouldCheck = false;
                    break;
                }
            }

            this.suspendCheckAll = true;
            this.radCheckBoxShowAll.Checked = shouldCheck;
            this.suspendCheckAll = false;
        }

        private void radColorBoxMarkers_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckBoxMarkers.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.MarkerBackColor = this.radColorBoxMarkers.Value;
            }
        }

        private void radColorBoxAreaAndLine_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null && sparkline.Series is SparkLineSeries)
                {
                    continue;
                }

                sparkline.Series.BackColor = this.radColorBoxAreaAndLine.Value;
                sparkline.Series.BorderColor = this.radColorBoxAreaAndLine.Value;
            }
        }

        private void radColorBoxNegativePoints_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckBoxNegativePoints.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                this.radCheckBoxNegativePoints.Checked = true;
                sparkline.Series.NegativePointBackColor = this.radColorBoxNegativePoints.Value;
            }
        }

        private void radColorBoxHighPoint_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckBoxHighPoint.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.HighPointBackColor = this.radColorBoxHighPoint.Value;
            }
        }

        private void radColorBoxLowPoint_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckLowPoint.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.LowPointBackColor = this.radColorBoxLowPoint.Value;
            }
        }

        private void radColorBoxFirstPoint_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckBoxFirstPoint.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.FirstPointBackColor = this.radColorBoxFirstPoint.Value;
            }
        }

        private void radColorBoxLastPoint_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckBoxLastPoint.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Series.LastPointBackColor = this.radColorBoxLastPoint.Value;
            }
        }

        private void radColorBoxAxisStroke_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckBoxAxis.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                sparkline.Axes[0].BorderColor = this.radColorBoxAxisStroke.Value;
            }
        }

        private void radColorBoxRangeColor_ValueChanged(object sender, EventArgs e)
        {
            this.radCheckBoxRange.Checked = true;
            foreach (Control control in this.tableLayoutPanel1.Controls)
            {
                RadSparkline sparkline = control as RadSparkline;
                if (sparkline == null)
                {
                    continue;
                }

                if (sparkline.Annotations.Count > 0)
                {
                    sparkline.Annotations[0].BackColor = this.radColorBoxRangeColor.Value;
                    //sparkline.Annotations[0].Invalidate();
                }
            }
        }
    }
}
