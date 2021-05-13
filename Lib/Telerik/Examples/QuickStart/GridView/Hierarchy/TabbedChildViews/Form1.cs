using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.Charting.Styles;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Hierarchy.TabbedChildViews
{
    public partial class Form1 : ExamplesForm
    {
        #pragma warning disable 618
        RadChart chart = new RadChart();

        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radGridView1;
        }

        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.BeginUpdate();

            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

            PrepareChartControl();
            LoadDetailsTable();
            LoadPerformanceTable();

            this.radGridView1.UseScrollbarsInHierarchy = true;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.AutoExpandGroups = true;
            this.radGridView1.GroupDescriptors.Add("City", ListSortDirection.Ascending);

            this.radGridView1.EndUpdate();

            this.radGridView1.Rows[0].IsExpanded = true;
        }

        void radGridView1_ChildViewExpanded(object sender, ChildViewExpandedEventArgs e)
        {
            e.ChildRow.ChildViewInfos[0].ChildRows[0].Height = 152;
            e.ChildRow.ChildViewInfos[2].ChildRows[0].Height = 152;
            e.ChildRow.Height = 224;
        }

        void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridViewDataColumn column = e.CellElement.ColumnInfo as GridViewDataColumn;
            if (column != null && column.OwnerTemplate.Caption == "Details")
            {
                if (column.FieldName == "FirstName")
                {
                    e.CellElement.Text = "<html><b>Name:</b> " + e.CellElement.RowInfo.Cells["LastName"].Value + ", " +
                        e.CellElement.RowInfo.Cells["FirstName"].Value;
                }
                if (column.FieldName == "BirthDate")
                {
                    e.CellElement.Text = string.Format("<html><b>Birth Date:</b> {0:d}", e.CellElement.RowInfo.Cells["BirthDate"].Value);
                }
                if (column.FieldName == "Title")
                {
                    e.CellElement.Text = "<html><b>Title:</b> " + e.CellElement.RowInfo.Cells["Title"].Value;
                }
                if (column.FieldName == "Address")
                {
                    e.CellElement.Text = "<html><b>Address:</b> " + e.CellElement.RowInfo.Cells["Address"].Value;
                }
                if (e.CellElement is GridImageCellElement)
                {
                    ((GridImageCellElement)e.CellElement).ImageLayout = ImageLayout.Zoom;
                }
            }
            if (column != null && column.OwnerTemplate.Caption == "Performance")
            {
                if (e.CellElement.RowInfo.Tag == null)
                {
                    chart.Series.Clear();
                    chart.Series.Add(GetRowData((GridViewRowInfo)e.CellElement.RowInfo));
                    e.CellElement.RowInfo.Tag = chart.GetBitmap();
                }
                e.CellElement.Image = e.CellElement.RowInfo.Tag as Image;
                e.CellElement.DrawBorder = false;
                e.CellElement.DrawFill = false;                
                e.CellElement.Text = "";
                e.CellElement.Padding = new Padding(10, 0, 0, 0);
            }
        }

        void radGridView1_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridDetailViewCellElement))
            {
                e.CellElement = new CustomDetailViewCellElement(e.Column, e.Row);
            }
        }

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.ChildViewTabsPosition = Telerik.WinControls.UI.TabPositions.Top;
        }

        private void radRadioButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.ChildViewTabsPosition = TabPositions.Bottom;
        }

        private void radRadioButton3_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.ChildViewTabsPosition = TabPositions.Left;
        }

        private void radRadioButton4_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.ChildViewTabsPosition = TabPositions.Right;
        }

        private void radRadioButton5_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.TableElement.PageViewMode = PageViewMode.Strip;
        }

        private void radRadioButton6_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.TableElement.PageViewMode = PageViewMode.Stack;
        }

        private void radRadioButton7_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.TableElement.PageViewMode = PageViewMode.Outlook;
        }

        private void radRadioButton8_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.TableElement.PageViewMode = PageViewMode.ExplorerBar;
        }

        #endregion

        void PrepareChartControl()
        {
            chart.Size = new Size(600, 150);
            chart.Chart.ChartTitle.Visible = false;
            chart.Legend.Visible = false;
            chart.Appearance.Border.Visible = false;
            chart.Appearance.FillStyle.MainColor = Color.White;
            chart.AutoLayout = true;
            chart.ChartTitle.Visible = false;
            chart.ChartTitle.TextBlock.Text = "";
            chart.PlotArea.Appearance.Border.Visible = false;
            chart.PlotArea.Appearance.FillStyle.FillType = FillType.Solid;
            chart.PlotArea.Appearance.FillStyle.MainColor = Color.Transparent;
            chart.PlotArea.Appearance.FillStyle.SecondColor = Color.Transparent;
            chart.PlotArea.YAxis.Appearance.CustomFormat = "C0";
            chart.PlotArea.YAxis.LabelStep = 2;
            chart.PlotArea.XAxis.Appearance.ValueFormat = ChartValueFormat.ShortDate;
            chart.PlotArea.XAxis.Appearance.CustomFormat = "dd/MM";
        }

        void LoadDetailsTable()
        {
            DataTable table = new DataTable("Details");
            table.Columns.Add("EmployeeID", typeof(int));
            table.Columns.Add("Photo", typeof(byte[]));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("BirthDate", typeof(DateTime));
            table.Columns.Add("Country", typeof(string));
            foreach (DataRow row in this.northwindDataSet.Employees.Rows)
            {
                table.Rows.Add(row["EmployeeID"], row["Photo"], row["FirstName"],
                    row["LastName"], row["Title"], row["Address"], row["City"], row["BirthDate"], row["Country"]);
            }

            GridViewTemplate template = new GridViewTemplate();
            template.Caption = "Details";
            template.DataSource = table;
            template.AllowRowResize = false;
            template.ShowColumnHeaders = false;
            template.Columns["Photo"].Width = 125;
            template.Columns["City"].Width = 70;
            template.Columns["Country"].Width = 70;
            template.Columns["FirstName"].DisableHTMLRendering = false;
            template.Columns["Title"].DisableHTMLRendering = false;
            template.Columns["BirthDate"].DisableHTMLRendering = false;
            template.Columns["Address"].Width = 200;
            template.Columns["Address"].DisableHTMLRendering = false;
            this.radGridView1.Templates.Insert(0, template);


            GridViewRelation relation = new GridViewRelation(this.radGridView1.MasterTemplate);
            relation.ChildTemplate = template;
            relation.ParentColumnNames.Add("EmployeeID");
            relation.ChildColumnNames.Add("EmployeeID");
            this.radGridView1.Relations.Add(relation);

            HtmlViewDefinition viewDef = new HtmlViewDefinition();
            viewDef.RowTemplate.Rows.Add(new RowDefinition());
            viewDef.RowTemplate.Rows.Add(new RowDefinition());
            viewDef.RowTemplate.Rows.Add(new RowDefinition());
            viewDef.RowTemplate.Rows[0].Cells.Add(new CellDefinition("Photo", 0, 1, 3));
            viewDef.RowTemplate.Rows[0].Cells.Add(new CellDefinition("FirstName", 0, 1, 1));
            viewDef.RowTemplate.Rows[0].Cells.Add(new CellDefinition("BirthDate", 0, 2, 1));
            viewDef.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Title", 0, 3, 1));
            viewDef.RowTemplate.Rows[2].Cells.Add(new CellDefinition("Address", 0, 1, 1));
            viewDef.RowTemplate.Rows[2].Cells.Add(new CellDefinition("City", 0, 1, 1));
            viewDef.RowTemplate.Rows[2].Cells.Add(new CellDefinition("Country", 0, 1, 1));
            template.ViewDefinition = viewDef;            
        }

        void LoadPerformanceTable()
        {
            Random r = new Random();
            DataTable chartTable = new DataTable();
            chartTable.Columns.Add("EmployeeID", typeof(int));
            for (int i = 0; i < 12; i++)
            {
                chartTable.Columns.Add("Month" + (i+1), typeof(int));                
            }
            foreach (DataRow row in this.northwindDataSet.Employees.Rows)
            {
                DataRow dataRow = chartTable.NewRow();
                dataRow["EmployeeID"] = row["EmployeeID"];
                for (int i = 0; i < 12; i++)
                {
                    dataRow[i + 1] = r.Next(1000) * 10;
                }
                chartTable.Rows.Add(dataRow);
            }
            GridViewTemplate template2 = new GridViewTemplate();
            template2.Caption = "Performance";
            template2.DataSource = chartTable;
            template2.AllowRowResize = false;
            template2.ShowColumnHeaders = false;
            template2.ShowRowHeaderColumn = false;
            template2.Columns[0].Width = 600;
            for (int i = 1; i < template2.Columns.Count; i++)
            {
                template2.Columns[i].IsVisible = false;
            }
            this.radGridView1.Templates.Add(template2);

            GridViewRelation relation2 = new GridViewRelation(this.radGridView1.MasterTemplate);
            relation2.ChildTemplate = template2;
            relation2.ParentColumnNames.Add("EmployeeID");
            relation2.ChildColumnNames.Add("EmployeeID");
            this.radGridView1.Relations.Add(relation2);
        }

        Telerik.Charting.ChartSeries GetRowData(GridViewRowInfo row)
        {
            Telerik.Charting.ChartSeries series = new Telerik.Charting.ChartSeries();
            series.Type = ChartSeriesType.Bar;
            series.Name = "Sales";
            series.Appearance.LabelAppearance.Visible = false;
            for (int i = 0; i < 12; ++i)
            {
                series.Items.Add(new ChartSeriesItem((int)row.Cells[i+1].Value));
            }
            return series;
        }

        protected override void WireEvents()
        {
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.ChildViewExpanded += new Telerik.WinControls.UI.ChildViewExpandedEventHandler(this.radGridView1_ChildViewExpanded);
            this.radGridView1.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(radGridView1_CreateCell);
            this.radRadioButton4.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton4_ToggleStateChanged);
            this.radRadioButton3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton3_ToggleStateChanged);
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radRadioButton5.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton5_ToggleStateChanged);
            this.radRadioButton6.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton6_ToggleStateChanged);
            this.radRadioButton7.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton7_ToggleStateChanged);
            this.radRadioButton8.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton8_ToggleStateChanged);
        }
    }
}
