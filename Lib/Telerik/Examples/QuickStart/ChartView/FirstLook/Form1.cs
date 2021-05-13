using System;
using System.Collections.Generic;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using Telerik.Charting;
using System.Data;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;

namespace Telerik.Examples.WinControls.ChartView.FirstLook
{
    /// <summary>
    /// RadChartView example
    /// </summary>
    public partial class Form1 : ExamplesForm , ICustomThemeExamplesForm
    {
        OrderViewModel model;

        public Form1()
        {
            InitializeComponent();
            radChartView1.View.Margin = new Padding(5);
            radChartView2.View.Margin = new Padding(5);
            radChartView3.View.Margin = new Padding(5);
             
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            model = new OrderViewModel();

            InitializeBarSeries();
            InitializePieSeries();
            InitializeLineSeries();
            InitalizeGrid();
        }

        private void InitalizeGrid()
        {
            this.radGridView1.CreateCell += new GridViewCreateCellEventHandler(radGridView1_CreateCell);
            this.radGridView1.TableElement.RowHeight = 40;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.AutoExpandGroups = true;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.AllowColumnReorder = false;
            this.radGridView1.EnableSorting = false;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.ShowRowHeaderColumn = false;
            this.radGridView1.TableElement.BackColor = Color.Transparent;
            this.radGridView1.TableElement.Padding = new Padding(10);
            this.radGridView1.GridViewElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            this.radGridView1.GridViewElement.BorderGradientStyle = GradientStyles.Solid;
            this.radGridView1.GridViewElement.BorderColor = Color.Transparent;

            GridViewTextBoxColumn textBoxColumn = new GridViewTextBoxColumn();
            textBoxColumn.Name = "Name";
            textBoxColumn.HeaderText = "Name";
            textBoxColumn.FieldName = "Name";
            textBoxColumn.Width = 110;
            textBoxColumn.TextAlignment = ContentAlignment.BottomRight;
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn);

            GridViewTextBoxColumn textBoxColumn2 = new GridViewTextBoxColumn();
            textBoxColumn2.Name = "Snacks";
            textBoxColumn2.HeaderText = "Snacks";
            textBoxColumn2.FieldName = "Snacks";
            textBoxColumn2.Width = 150;
            textBoxColumn2.TextAlignment = ContentAlignment.BottomRight;
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn2);

            GridViewTextBoxColumn textBoxColumn3 = new GridViewTextBoxColumn();
            textBoxColumn3.Name = "Beverages";
            textBoxColumn3.HeaderText = "Beverages";
            textBoxColumn3.FieldName = "Beverages";
            textBoxColumn3.Width = 150;
            textBoxColumn3.TextAlignment = ContentAlignment.BottomRight;
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn3);

            this.radGridView1.Rows.Add("Europe", null, null);
            this.radGridView1.Rows.Add("North America", null, null);
            this.radGridView1.Rows.Add("Asia", null, null);
            this.radGridView1.Rows.Add("Other", null, null);
        }

        void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridDataCellElement) && (e.Column.Name == "Snacks" || e.Column.Name == "Beverages"))
            {
                e.CellType = typeof(ChartCellElement);
            }
        }

        private void InitializeLineSeries()
        {
            LineSeries lineSeries1 = new LineSeries();
            lineSeries1.Name = "Snacks";
            lineSeries1.LegendTitle = "Snacks";
            lineSeries1.PointSize = new SizeF(0, 0);
            lineSeries1.BorderWidth = 2;
            lineSeries1.DataSource = model.LineStackData;
            lineSeries1.ValueMember = "Value";
            lineSeries1.CategoryMember = "Month";
            this.radChartView3.Series.Add(lineSeries1);

            LineSeries lineSeries2 = new LineSeries();
            lineSeries2.Name = "Beverages";
            lineSeries2.LegendTitle = "Beverages";
            lineSeries2.PointSize = new SizeF(0, 0);
            lineSeries2.BorderWidth = 2;
            lineSeries2.ValueMember = "Value";
            lineSeries2.CategoryMember = "Month";
            lineSeries2.DataSource = model.LineBeverageData;
            this.radChartView3.Series.Add(lineSeries2);

            this.radChartView3.ShowLegend = true;
        }

        private void InitializePieSeries()
        {
            PieSeries pieSeries = new PieSeries();
            pieSeries.ValueMember = "Value";
            pieSeries.LegendTitleMember = "Name";
            pieSeries.DataSource = model.Regions;
            pieSeries.ShowLabels = true;
            
            this.radChartView2.Series.Add(pieSeries);
            this.radChartView2.ShowLegend = true;
        }
  
        private void InitializeBarSeries()
        {
            BarSeries barSeries = new BarSeries();
            barSeries.Name = "Snacks";
            barSeries.LegendTitle = "Snacks";
            barSeries.ValueMember = "Value";
            barSeries.CategoryMember = "Month";
            barSeries.DataSource = model.BarSnackData;
            this.radChartView1.Series.Add(barSeries);

            BarSeries barSeries2 = new BarSeries();
            barSeries2.Name = "Beverages";
            barSeries2.LegendTitle = "Beverages";
            barSeries2.DataSource = model.BarBeverageData;
            barSeries2.ValueMember = "Value";
            barSeries2.CategoryMember = "Month";
            this.radChartView1.Series.Add(barSeries2);
            
            for (int i = 0; i < this.radChartView1.Series.Count; i++)
            {
                this.radChartView1.GetSeries<BarSeries>(i).CombineMode = ChartSeriesCombineMode.Stack;
            }

            this.radChartView1.ShowLegend = true;
        }
    }
}
