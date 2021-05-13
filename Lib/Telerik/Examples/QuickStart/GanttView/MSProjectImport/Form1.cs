using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.MSProjectImport
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGanttView();
            InitializeSources();
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
            this.radGanttView1.GanttViewElement.Columns[2].Width = 250;
            this.radGanttView1.GanttViewElement.Columns[3].Width = 115;
            this.radGanttView1.GanttViewElement.Columns[4].Width = 115;

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
        }

        public void InitializeSources()
        {
            this.radListControlSources.Items.Add(new RadListDataItem("HomeMovePlan.xml", Properties.Resources.HomeMovePlan));
            this.radListControlSources.Items.Add(new RadListDataItem("NursingSchedule.xml", Properties.Resources.NursingSchedule));
            this.radListControlSources.Items.Add(new RadListDataItem("MarketSchedule.xml", Properties.Resources.MarketSchedule));
            this.radListControlSources.Items.Add(new RadListDataItem("WeddingPlanner.xml", Properties.Resources.WeddingPlanner));
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radListControlSources.SelectedIndexChanged += radListControlSources_SelectedIndexChanged;
            this.radListControlSources.SelectedIndex = 0;
        }

        private void radListControlSources_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            MsProjectImporter importer = new MsProjectImporter();
            StringReader reader = new StringReader(this.radListControlSources.Items[e.Position].Value.ToString());
            DataSet dataSet = importer.GetData(reader);

            DateTime minDate = DateTime.MaxValue;
            DateTime maxDate = DateTime.MinValue;

            foreach (DataRow row in dataSet.Tables["Tasks"].Rows)
            {
                if ((DateTime)row["Start"] < minDate)
                {
                    minDate = (DateTime)row["Start"];
                }

                if ((DateTime)row["End"] > maxDate)
                {
                    maxDate = (DateTime)row["End"];
                }
            }

            TimeSpan span = this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = minDate;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = maxDate;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = span;

            this.radGanttView1.DataSource = dataSet;
        }
    }
}
