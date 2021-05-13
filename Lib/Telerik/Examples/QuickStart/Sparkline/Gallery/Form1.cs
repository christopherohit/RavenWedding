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

namespace Telerik.Examples.WinControls.Sparkline.Gallery
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;

            this.UpdateGridViewSettings(this.gridLineSpark);
            this.UpdateGridViewSettings(this.gridAreaSpark);
            this.UpdateGridViewSettings(this.gridBarSpark);
            this.UpdateGridViewSettings(this.gridWinLossSpark);

            this.AddGridColumns(this.gridLineSpark, SparkSeriesType.Line);
            this.AddGridColumns(this.gridAreaSpark, SparkSeriesType.Area);
            this.AddGridColumns(this.gridBarSpark, SparkSeriesType.Bar);
            this.AddGridColumns(this.gridWinLossSpark, SparkSeriesType.WinLoss);

            this.AddLineData();
            this.AddAreaData();
            this.AddBarData();
            this.AddWinLossData();

            this.gridLineSpark.CurrentRow = null;
            this.gridAreaSpark.CurrentRow = null;
            this.gridBarSpark.CurrentRow = null;
            this.gridWinLossSpark.CurrentRow = null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.AdjustGridColumnWidths(this.gridLineSpark);
            this.AdjustGridColumnWidths(this.gridAreaSpark);
            this.AdjustGridColumnWidths(this.gridBarSpark);
            this.AdjustGridColumnWidths(this.gridWinLossSpark);
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.gridLineSpark.TableElement.HScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;
            this.gridLineSpark.TableElement.VScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;

            this.gridAreaSpark.TableElement.HScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;
            this.gridAreaSpark.TableElement.VScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;

            this.gridBarSpark.TableElement.HScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;
            this.gridBarSpark.TableElement.VScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;

            this.gridWinLossSpark.TableElement.HScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;
            this.gridWinLossSpark.TableElement.VScrollBar.RadPropertyChanging += ScrollBar_RadPropertyChanging;

            this.gridLineSpark.CellFormatting += Grid_CellFormatting;
            this.gridAreaSpark.CellFormatting += Grid_CellFormatting;
            this.gridBarSpark.CellFormatting += Grid_CellFormatting;
            this.gridWinLossSpark.CellFormatting += Grid_CellFormatting;
        }

        private void Grid_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridSparklineCellElement cellElement = e.CellElement as GridSparklineCellElement;
            if (cellElement == null)
            {
                return;
            }

            if (cellElement.GridControl == this.gridLineSpark && e.Column.Name == "Range")
            {
                CartesianSparkPlotBandAnnotation annotation1 = new CartesianSparkPlotBandAnnotation();
                annotation1.DrawMode = AnnotationDrawMode.BelowSeries;
                annotation1.Axis = cellElement.SparklineElement.Series.Axes[1] as SparkCartesianAxis;
                annotation1.From = -40;
                annotation1.To = 40;
                annotation1.BackColor = Color.FromArgb(100, Color.Gray);
                cellElement.SparklineElement.View.Annotations.Add(annotation1);
            }

            if  (e.Column.Name == "Axis")
            {
                cellElement.SparklineElement.View.ShowAxis = true;
            }
        }

        private void ScrollBar_RadPropertyChanging(object sender, Telerik.WinControls.RadPropertyChangingEventArgs args)
        {
            if (args.Property == LightVisualElement.VisibilityProperty)
            {
                args.Cancel = true;
            }
        }

        private void AdjustGridColumnWidths(RadGridView grid)
        {
            int currentWidth = grid.TableElement.GroupIndent;
            int startColumnWidth = 80;
            int remainingWidth = grid.TableElement.Bounds.Width - grid.TableElement.GroupIndent - 240;
            double desiredColumnWidth = remainingWidth / (double)(grid.Columns.Count - 3);
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                GridViewColumn col = grid.Columns[i];
                if (i < 3)
                {
                    col.Width = startColumnWidth;
                     
                }
                else if (i < grid.Columns.Count -1)
                {
                    col.Width = (int)Math.Floor(desiredColumnWidth);
                }
                else
                {
                    col.Width = grid.TableElement.Bounds.Width - currentWidth;
                }

                currentWidth += col.Width;
            }
        }

        private void AddWinLossData()
        {
            GridViewRowInfo row = this.gridWinLossSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/USD";
            row.Cells["High"].Value = 0.4311;
            row.Cells["Low"].Value = -0.3524;

            double[] values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Win/Loss"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;
            row.Cells["Axis"].Value = values;

            row = this.gridWinLossSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/GBP";
            row.Cells["High"].Value = 0.4321;
            row.Cells["Low"].Value = -0.4701;

            values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Win/Loss"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;
            row.Cells["Axis"].Value = values;
        }

        private void AddBarData()
        {
            GridViewRowInfo row = this.gridBarSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/USD";
            row.Cells["High"].Value = 0.4311;
            row.Cells["Low"].Value = -0.3524;

            double[] values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Bars"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;
            row.Cells["Axis"].Value = values;

            row = this.gridBarSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/GBP";
            row.Cells["High"].Value = 0.4321;
            row.Cells["Low"].Value = -0.4701;

            values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Bars"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;
            row.Cells["Axis"].Value = values;
        }

        private void AddAreaData()
        {
            GridViewRowInfo row = this.gridAreaSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/USD";
            row.Cells["High"].Value = 0.4311;
            row.Cells["Low"].Value = -0.3524;

            double[] values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Area"].Value = values;
            row.Cells["Area + Markers"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;
            row.Cells["Axis"].Value = values;

            row = this.gridAreaSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/GBP";
            row.Cells["High"].Value = 0.4321;
            row.Cells["Low"].Value = -0.4701;

            values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Area"].Value = values;
            row.Cells["Area + Markers"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;
            row.Cells["Axis"].Value = values;
        }

        private void AddLineData()
        {
            GridViewRowInfo row = this.gridLineSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/USD";
            row.Cells["High"].Value = 0.4311;
            row.Cells["Low"].Value = -0.3524;

            double[] values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Line"].Value = values;
            row.Cells["Line + Markers"].Value = values;
            row.Cells["Range"].Value = values;
            row.Cells["Scatter"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;

            row = this.gridLineSpark.Rows.AddNew();
            row.Cells["Currency"].Value = "EUR/GBP";
            row.Cells["High"].Value = 0.4321;
            row.Cells["Low"].Value = -0.4701;

            values = new double[12];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(-100, 100);
            }

            row.Cells["Line"].Value = values;
            row.Cells["Line + Markers"].Value = values;
            row.Cells["Range"].Value = values;
            row.Cells["Scatter"].Value = values;
            row.Cells["End Points"].Value = values;
            row.Cells["High/Low"].Value = values;
        }

        private void AddGridColumns(RadGridView grid, SparkSeriesType sparkType)
        {
            GridViewTextBoxColumn currencyColumn = new GridViewTextBoxColumn("Currency");
            currencyColumn.Width = 80;
            currencyColumn.HeaderText = "Currency";
            grid.Columns.Add(currencyColumn);

            GridViewDecimalColumn highValueColumn = new GridViewDecimalColumn("High");
            highValueColumn.Width = 80;
            highValueColumn.DecimalPlaces = 4;
            highValueColumn.HeaderText = "High";
            grid.Columns.Add(highValueColumn);

            GridViewDecimalColumn lowValueColumn = new GridViewDecimalColumn("Low");
            lowValueColumn.Width = 80;
            lowValueColumn.DecimalPlaces = 4;
            lowValueColumn.HeaderText = "Low";
            grid.Columns.Add(lowValueColumn);

            GridViewSparklineColumn sparklineColumn = new GridViewSparklineColumn();
            switch (sparkType)
            {
                case SparkSeriesType.Line:
                    sparklineColumn = new GridViewSparklineColumn("Line");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Line";
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("Line + Markers");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Line + Markers";
                    sparklineColumn.ShowMarkers = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("Range");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Range";
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("Scatter");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Scatter";
                    sparklineColumn.SeriesType = SparkSeriesType.Scatter;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("End Points");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "End Points";
                    sparklineColumn.ShowFirstPointIndicator = true;
                    sparklineColumn.ShowLastPointIndicator = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("High/Low");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "High/Low";
                    sparklineColumn.ShowHighPointIndicator = true;
                    sparklineColumn.ShowLowPointIndicator = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    break;
                case SparkSeriesType.Area:
                    sparklineColumn = new GridViewSparklineColumn("Area");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Area";
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("Area + Markers");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Area + Markers";
                    sparklineColumn.ShowMarkers = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("End Points");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "End Points";
                    sparklineColumn.ShowFirstPointIndicator = true;
                    sparklineColumn.ShowLastPointIndicator = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("High/Low");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "High/Low";
                    sparklineColumn.ShowHighPointIndicator = true;
                    sparklineColumn.ShowLowPointIndicator = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("Axis");
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Axis";
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    break;
                case SparkSeriesType.Bar:
                case SparkSeriesType.WinLoss:
                    sparklineColumn = new GridViewSparklineColumn();
                    sparklineColumn.HeaderText = sparkType == SparkSeriesType.Bar ? "Bars" : "Win/Loss";
                    sparklineColumn.FieldName = sparklineColumn.HeaderText;
                    sparklineColumn.ShowNegativePointIndicators = true;
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("End Points");
                    sparklineColumn.ShowNegativePointIndicators = true;
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "End Points";
                    sparklineColumn.ShowFirstPointIndicator = true;
                    sparklineColumn.ShowLastPointIndicator = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("High/Low");
                    sparklineColumn.ShowNegativePointIndicators = true;
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "High/Low";
                    sparklineColumn.ShowHighPointIndicator = true;
                    sparklineColumn.ShowLowPointIndicator = true;
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    sparklineColumn = new GridViewSparklineColumn("Axis");
                    sparklineColumn.ShowNegativePointIndicators = true;
                    sparklineColumn.ShowTooltip = true;
                    sparklineColumn.HeaderText = "Axis";
                    sparklineColumn.SeriesType = sparkType;
                    grid.Columns.Add(sparklineColumn);

                    break;
                default:
                    break;
            }
        }

        private void UpdateGridViewSettings(RadGridView grid)
        {
            grid.EnableFiltering = true;
            grid.ShowHeaderCellButtons = true;
            grid.ShowFilteringRow = false;
            grid.ShowGroupPanel = false;
            grid.AllowAddNewRow = false;
            grid.TableElement.TableHeaderHeight = 28;
            grid.TableElement.RowHeight = 40;
            grid.ReadOnly = true;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            this.AdjustGridColumnWidths(this.gridLineSpark);
            this.AdjustGridColumnWidths(this.gridAreaSpark);
            this.AdjustGridColumnWidths(this.gridBarSpark);
            this.AdjustGridColumnWidths(this.gridWinLossSpark);
        }
    }
}
