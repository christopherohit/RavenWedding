using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.CustomPainting
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGanttView();
        }

        public void InitializeGanttView()
        {
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Id"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("ParentId"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Title"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Start"));
            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("End"));

            this.radGanttView1.GanttViewElement.Columns[0].Visible = false;
            this.radGanttView1.GanttViewElement.Columns[1].Visible = false;
            this.radGanttView1.GanttViewElement.Columns[2].Width = 350;
            this.radGanttView1.GanttViewElement.Columns[3].Width = 120;
            this.radGanttView1.GanttViewElement.Columns[4].Width = 120;

            this.radGanttView1.GanttViewElement.TaskDataMember = "Tasks";
            this.radGanttView1.GanttViewElement.ChildMember = "Id";
            this.radGanttView1.GanttViewElement.ParentMember = "ParentId";
            this.radGanttView1.GanttViewElement.TitleMember = "Title";
            this.radGanttView1.GanttViewElement.StartMember = "Start";
            this.radGanttView1.GanttViewElement.EndMember = "End";
            this.radGanttView1.GanttViewElement.ProgressMember = "Progress";
            this.radGanttView1.GanttViewElement.LinkDataMember = "Links";
            this.radGanttView1.GanttViewElement.LinkStartMember = "StartId";
            this.radGanttView1.GanttViewElement.LinkEndMember = "EndId";
            this.radGanttView1.GanttViewElement.LinkTypeMember = "LinkType";

            this.radGanttView1.DataSource = this.GetData();
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = new DateTime(2013, 1, 2);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = new DateTime(2013, 1, 30);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month;

            this.radGanttView1.EnableCustomPainting = true;            
        }

        private DataSet GetData()
        {
            DataSet set = new DataSet();
            DataTable tasks = new DataTable("Tasks");            

            tasks.Columns.Add("Id", typeof(int));
            tasks.Columns.Add("ParentId", typeof(int));
            tasks.Columns.Add("Title", typeof(string));
            tasks.Columns.Add("Start", typeof(DateTime));
            tasks.Columns.Add("End", typeof(DateTime));
            tasks.Columns.Add("Deadline", typeof(DateTime));

            tasks.Rows.Add(1, 0, "Scope", new DateTime(2013, 1, 3, 8, 0, 0), new DateTime(2013, 1, 6, 0, 0, 0), DBNull.Value);
            tasks.Rows.Add(2, 1, "Determine project scope", new DateTime(2013, 1, 3, 8, 0, 0), new DateTime(2013, 1, 5, 23, 0, 0), new DateTime(2013, 1, 4, 12, 0, 0));
            tasks.Rows.Add(3, 1, "Secure project sponsorship", new DateTime(2013, 1, 3, 16, 0, 0), new DateTime(2013, 1, 4, 15, 0, 0), new DateTime(2013, 1, 6, 10, 0, 0));
            tasks.Rows.Add(4, 1, "Define preliminary resources", new DateTime(2013, 1, 4, 13, 0, 0), new DateTime(2013, 1, 5, 12, 0, 0), new DateTime(2013, 1, 6, 16, 0, 0));
            tasks.Rows.Add(5, 1, "Secure core resources", new DateTime(2013, 1, 5, 13, 0, 0), new DateTime(2013, 1, 6, 0, 0, 0), new DateTime(2013, 1, 8, 0, 0, 0));
            tasks.Rows.Add(6, 1, "Scope complete", new DateTime(2013, 1, 6, 0, 0, 0), new DateTime(2013, 1, 6, 0, 0, 0), DBNull.Value);
            tasks.Rows.Add(7, 0, "Analysis/Software Requirements", new DateTime(2013, 1, 6, 13, 0, 0), new DateTime(2013, 1, 28, 16, 0, 0), DBNull.Value);
            tasks.Rows.Add(8, 7, "Conduct needed analysis", new DateTime(2013, 1, 6, 13, 0, 0), new DateTime(2013, 1, 12, 0, 0, 0), new DateTime(2013, 1, 14, 10, 0, 0));
            tasks.Rows.Add(9, 7, "Draft preliminary software specifications", new DateTime(2013, 1, 13, 13, 0, 0), new DateTime(2013, 1, 18, 0, 0, 0), new DateTime(2013, 1, 16, 0, 0, 0));
            tasks.Rows.Add(10, 7, "Develop preliminary budget", new DateTime(2013, 1, 18, 13, 0, 0), new DateTime(2013, 1, 20, 0, 0, 0), new DateTime(2013, 1, 21, 0, 0, 0));
            tasks.Rows.Add(11, 7, "Review software specifications/budget with team", new DateTime(2013, 1, 21, 5, 0, 0), new DateTime(2013, 1, 21, 17, 0, 0), new DateTime(2013, 1, 21, 23, 0, 0));
            tasks.Rows.Add(12, 7, "Incorporate feedback on software specifications", new DateTime(2013, 1, 21, 12, 0, 0), new DateTime(2013, 1, 21, 23, 0, 0), new DateTime(2013, 1, 22, 12, 0, 0));
            tasks.Rows.Add(13, 7, "Develop delivery time", new DateTime(2013, 1, 24, 6, 0, 0), new DateTime(2013, 1, 24, 16, 0, 0), new DateTime(2013, 1, 24, 20, 0, 0));
            tasks.Rows.Add(14, 7, "Obtain approval to proceed (concept, timeline, budget)", new DateTime(2013, 1, 25, 5, 0, 0), new DateTime(2013, 1, 25, 15, 0, 0), new DateTime(2013, 1, 25, 17, 0, 0));
            tasks.Rows.Add(15, 7, "Secure required resources", new DateTime(2013, 1, 24, 13, 0, 0), new DateTime(2013, 1, 28, 16, 0, 0), new DateTime(2013, 1, 28, 20, 0, 0));
            tasks.Rows.Add(16, 7, "Analysis complete", new DateTime(2013, 1, 26, 0, 0, 0), new DateTime(2013, 1, 26, 0, 0, 0), DBNull.Value);

            DataTable links = new DataTable("Links");

            links.Columns.Add("StartId", typeof(int));
            links.Columns.Add("EndId", typeof(int));
            links.Columns.Add("LinkType", typeof(int));

            links.Rows.Add(2, 3, 1);
            links.Rows.Add(3, 4, 1);
            links.Rows.Add(4, 5, 1);
            links.Rows.Add(5, 6, 1);
            links.Rows.Add(8, 9, 1);
            links.Rows.Add(9, 10, 1);
            links.Rows.Add(10, 11, 1);
            links.Rows.Add(11, 12, 1);
            links.Rows.Add(12, 13, 1);
            links.Rows.Add(13, 14, 1);
            links.Rows.Add(14, 15, 1);
            links.Rows.Add(15, 16, 1);

            set.Tables.Add(tasks);
            set.Tables.Add(links);

            return set;
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radGanttView1.ItemPaint += radGanttView1_ItemPaint;
        }

        private void radGanttView1_ItemPaint(object sender, GanttViewItemPaintEventArgs e)
        {
            GanttViewDataItem item = e.Element.Data;
            DataRowView row = item.DataBoundItem as DataRowView;

            object deadlineValue = row["Deadline"];

            if (deadlineValue.Equals(DBNull.Value))
            {
                return;
            }

            DateTime deadline = (DateTime)deadlineValue;
            bool overdue = deadline < item.End;

            RectangleF deadlineRect = e.Element.GraphicalViewElement.GetDrawRectangle(item, deadline);
            RectangleF overdueFlagRect = e.Element.GraphicalViewElement.GetDrawRectangle(item, item.End.AddHours(2));

            SmoothingMode mode = e.Graphics.SmoothingMode;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.DrawOverdueFlag(e.Graphics, overdueFlagRect, overdue);
            this.DrawDeadline(e.Graphics, deadlineRect);
            e.Graphics.SmoothingMode = mode;
        }

        private void DrawDeadline(Graphics graphics, RectangleF rect)
        {            
            RectangleF topBallRect = new RectangleF(rect.X - 2, rect.Y + 1, 4f, 4f);
            RectangleF bottomBallRect = new RectangleF(rect.X - 2, rect.Bottom - 2, 4f, 4f);

            graphics.DrawLine(Pens.Red, new PointF(rect.X, rect.Y + 2), new PointF(rect.X, rect.Bottom));
            graphics.FillEllipse(Brushes.Red, topBallRect);
            graphics.FillEllipse(Brushes.Red, bottomBallRect);
        }

        private void DrawOverdueFlag(Graphics graphics, RectangleF rect, bool overdue)
        {
            PointF[] points = new PointF[7];
            points[0] = new PointF(rect.X, rect.Y + 2);
            points[1] = new PointF(rect.X + 20, rect.Y + 2);
            points[2] = new PointF(rect.X + 15, rect.Y + 2 + rect.Height / 4f);
            points[3] = new PointF(rect.X + 20, rect.Y + 2 + rect.Height / 2f);
            points[4] = new PointF(rect.X + 2, rect.Y + 2 + rect.Height / 2f);
            points[5] = new PointF(rect.X + 2, rect.Bottom);
            points[6] = new PointF(rect.X, rect.Bottom);


            GraphicsPath flagPath = new GraphicsPath();
            flagPath.AddClosedCurve(points, 0f);

            if (overdue)
            {
                graphics.FillPath(Brushes.Red, flagPath);
            }
            else
            {
                graphics.FillPath(Brushes.Green, flagPath);
            }
        }
    }
}
