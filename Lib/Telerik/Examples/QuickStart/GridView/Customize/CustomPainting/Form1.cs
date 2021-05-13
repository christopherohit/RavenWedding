using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using System.Drawing.Drawing2D;

namespace Telerik.Examples.WinControls.GridView.Customize.CustomPainting
{
    public partial class Form1 : ExamplesForm
    {
        Random r = new Random();

        Color[] fills = new Color[] 
        {
          Color.FromArgb(153, 255, 0),  
          Color.FromArgb(255, 204, 204),  
          Color.FromArgb(0, 255, 255)
        };

        Color[] borders = new Color[]
        {
          Color.Green,  
          Color.Red,  
          Color.Blue
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void AddRow(DataTable table, int rowID, string task, string project)
        {
            int start = r.Next(4) + 6;
            int end = start + r.Next(8);
            if (end > 14)
            {
                end = 14;
            }
            table.Rows.Add(rowID, task, project, start, end, r.Next(3));
        }

        private GridDataCellElement GetCell(GridRowElement rowElement, int index)
        {
            foreach (GridCellElement cell in rowElement.VisualCells)
            {
                if (cell.ColumnInfo != null && cell.ColumnInfo.Index == index)
                {
                    return cell as GridDataCellElement;
                }
            }
            return null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Task", typeof(string));
            table.Columns.Add("Project", typeof(string));
            table.Columns.Add("StartCell", typeof(int));
            table.Columns.Add("EndCell", typeof(int));
            table.Columns.Add("Color", typeof(int));

            AddRow(table, 1, "Task 1", "Project 1");
            AddRow(table, 2, "Task 2", "Project 1");
            AddRow(table, 3, "Task 3", "Project 1");
            AddRow(table, 4, "Task 4", "Project 1");
            AddRow(table, 5, "Task 5", "Project 1");

            AddRow(table, 6, "Task 1", "Project 2");
            AddRow(table, 7, "Task 2", "Project 2");
            AddRow(table, 8, "Task 3", "Project 2");

            this.radGridView1.EnableCustomDrawing = true;

            this.radGridView1.ReadOnly = true;
            this.radGridView1.AutoExpandGroups = true;
            this.radGridView1.DataSource = table;
            this.radGridView1.GroupDescriptors.Add(new Telerik.WinControls.Data.GroupDescriptor("Project"));

            string[] months = new string[] { "Jan", "Feb", "Mar" };

            for (int i = 0; i<months.Length; i++)
            {
                for (int j = 1; j<=4; j++)
                {
                    GridViewTextBoxColumn column = new GridViewTextBoxColumn(months[i] + "Week" + j);
                    column.HeaderText = "Week " + j.ToString();
                    this.radGridView1.Columns.Add(column);
                }
            }

            ColumnGroupsViewDefinition def = new ColumnGroupsViewDefinition();
            def.ColumnGroups.Add(new GridViewColumnGroup("Event"));
            def.ColumnGroups[0].ShowHeader = false;
            def.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            def.ColumnGroups[0].Rows[0].ColumnNames.Add(this.radGridView1.Columns[0].Name);
            def.ColumnGroups[0].Rows[0].ColumnNames.Add(this.radGridView1.Columns[1].Name);

            for (int i = 0; i < months.Length; i++)
            {
                def.ColumnGroups.Add(new GridViewColumnGroup(months[i] + "'11"));
                def.ColumnGroups[1 + i].Rows.Add(new GridViewColumnGroupRow());
                for (int j = 1; j <= 4; j++)
                {
                    def.ColumnGroups[1 + i].Rows[0].ColumnNames.Add(months[i] + "Week" + j);
                }
            }
            
            this.radGridView1.ViewDefinition = def;
        }
        
        private void radGridView1_CreateRowInfo(object sender, GridViewCreateRowInfoEventArgs e)
        {
            e.RowInfo.Height = 28;
        }

        private void radGridView1_RowPaint(object sender, GridViewRowPaintEventArgs e)
        {
            if (e.Row is GridDataRowElement)
            {
                GridDataRowElement rowElement = (GridDataRowElement)e.Row;
                int startIndex = (int)e.Row.RowInfo.Cells["StartCell"].Value;
                int endIndex = (int)e.Row.RowInfo.Cells["EndCell"].Value;
                GridDataCellElement startCell = GetCell(e.Row, startIndex);
                GridDataCellElement endCell = GetCell(e.Row, endIndex);
                
                if (startCell != null || endCell != null)
                {
                    int left = startCell == null ? rowElement.ScrollableColumns.BoundingRectangle.Left - 10 : startCell.ControlBoundingRectangle.Left;
                    int right = endCell == null ? rowElement.ScrollableColumns.BoundingRectangle.Right + 10 : endCell.ControlBoundingRectangle.Right;

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    Region clipRegion = e.Graphics.Clip;

                    e.Graphics.SetClip(rowElement.ScrollableColumns.BoundingRectangle);

                    int randomColor = (int)e.Row.RowInfo.Cells["Color"].Value;

                    using (RoundRectShape shape = new RoundRectShape(5))
                    using (GraphicsPath path = shape.CreatePath(new RectangleF(left + 5, 5, (right - left) - 10, e.Row.Size.Height - 10)))
                    using (Brush brush = new SolidBrush(fills[randomColor]))
                    using (Pen pen = new Pen(borders[randomColor], 2))
                    {
                        e.Graphics.FillPath(brush, path);
                        e.Graphics.DrawPath(pen, path);
                    }

                    e.Graphics.Clip = clipRegion;
                }
            }
        }

        protected override void WireEvents()
        {
            this.radGridView1.CreateRowInfo += new GridViewCreateRowInfoEventHandler(radGridView1_CreateRowInfo);
            this.radGridView1.RowPaint += new GridViewRowPaintEventHandler(radGridView1_RowPaint);
        }
    }
}
