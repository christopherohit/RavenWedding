using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Xml;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.FirstLook
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
            GanttViewTextViewColumn startColumn = new GanttViewTextViewColumn("Start");
            startColumn.DataType = typeof(DateTime);
            startColumn.FormatString = "{0:HH:mm dd.MM.yyyy}";
            this.radGanttView1.GanttViewElement.Columns.Add(startColumn);
            GanttViewTextViewColumn endColumn = new GanttViewTextViewColumn("Finish");
            endColumn.DataType = typeof(DateTime);
            endColumn.FormatString = "{0:HH:mm dd.MM.yyyy}";
            this.radGanttView1.GanttViewElement.Columns.Add(endColumn);

            this.radGanttView1.GanttViewElement.Columns[0].Visible = false;
            this.radGanttView1.GanttViewElement.Columns[1].Visible = false;
            this.radGanttView1.GanttViewElement.Columns[2].Width = 350;
            this.radGanttView1.GanttViewElement.Columns[3].Width = 100;
            this.radGanttView1.GanttViewElement.Columns[4].Width = 100;

            this.radGanttView1.GanttViewElement.TaskDataMember = "Tasks";
            this.radGanttView1.GanttViewElement.ChildMember = "Id";
            this.radGanttView1.GanttViewElement.ParentMember = "ParentId";
            this.radGanttView1.GanttViewElement.TitleMember = "Title";
            this.radGanttView1.GanttViewElement.StartMember = "Start";
            this.radGanttView1.GanttViewElement.EndMember = "Finish";
            this.radGanttView1.GanttViewElement.ProgressMember = "Progress";
            this.radGanttView1.GanttViewElement.LinkDataMember = "Links";
            this.radGanttView1.GanttViewElement.LinkStartMember = "StartId";
            this.radGanttView1.GanttViewElement.LinkEndMember = "EndId";
            this.radGanttView1.GanttViewElement.LinkTypeMember = "LinkType";

            DataSet telerikWeddingPlanner = new DataSet();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            string resourceName = "Telerik.Examples.WinControls.Resources.TelerikWeddingPlanner.xml";

            using (Stream resourceStream = executingAssembly.GetManifestResourceStream(resourceName))
            {
                telerikWeddingPlanner.ReadXml(resourceStream);
            }

            this.radGanttView1.DataSource = telerikWeddingPlanner;

            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = new DateTime(2006, 8, 21);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = new DateTime(2007, 4, 3);
        }
    }
}
