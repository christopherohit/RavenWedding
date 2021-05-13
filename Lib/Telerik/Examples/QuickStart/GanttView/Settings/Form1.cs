using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.Settings
{
    public partial class Form1 : ExamplesForm
    {
        private int id = 999;

        public Form1()
        {
            InitializeComponent();

            DataSet telerikWeddingPlanerData = new DataSet();

            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "Telerik.Examples.WinControls.Resources.TelerikWeddingPlanner.xml";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                telerikWeddingPlanerData.ReadXml(stream);
            }

            this.radGanttView1.GanttViewElement.Columns.Add(new GanttViewTextViewColumn("Title"));
            GanttViewTextViewColumn startColumn = new GanttViewTextViewColumn("Start");
            startColumn.DataType = typeof(DateTime);
            startColumn.FormatString = "{0:HH:mm dd.MM.yyyy}";
            this.radGanttView1.GanttViewElement.Columns.Add(startColumn);
            GanttViewTextViewColumn endColumn = new GanttViewTextViewColumn("Finish");
            endColumn.DataType = typeof(DateTime);
            endColumn.FormatString = "{0:HH:mm dd.MM.yyyy}";
            this.radGanttView1.GanttViewElement.Columns.Add(endColumn);

            this.radGanttView1.GanttViewElement.Columns[0].Width = 300;
            this.radGanttView1.GanttViewElement.Columns[1].Width = 100;
            this.radGanttView1.GanttViewElement.Columns[2].Width = 100;

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
            this.radGanttView1.GanttViewElement.DataSource = telerikWeddingPlanerData;

            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = new DateTime(2006, 08, 21);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = new DateTime(2007, 04, 02);
            this.radDateTimePickerElementStart.Value = new DateTime(2006, 08, 21);
            this.radDateTimePickerElementEnd.Value = new DateTime(2007, 04, 02);
        }

        protected override void WireEvents()
        {
            this.radGanttView1.ItemChildIdNeeded += radGanttView1_ItemChildIdNeeded;
            this.radButtonElementAddTask.Click += radButtonElementAddTask_Click;
            this.radButtonElementDeleteTask.Click += radButtonElementDeleteTask_Click;
            this.radButtonElementAddMilestone.Click += radButtonElementAddMilestone_Click;
            this.radButtonElementProgress25.Click += radButtonElementProgress25_Click;
            this.radButtonElementProgress50.Click += radButtonElementProgress50_Click;
            this.radButtonElementProgress100.Click += radButtonElementProgress100_Click;
            this.radButtonElementWeek.Click += radButtonElementWeek_Click;
            this.radButtonElementMonth.Click += radButtonElementMonth_Click;
            this.radButtonElementYear.Click += radButtonElementYear_Click;
            this.radDateTimePickerElementStart.ValueChanged += radDateTimePickerElementStart_ValueChanged;
            this.radDateTimePickerElementEnd.ValueChanged += radDateTimePickerElementEnd_ValueChanged;
            this.radButtonElementPrevious.Click += radButtonElementPrevious_Click;
            this.radButtonElementNext.Click += radButtonElementNext_Click;
            this.radTrackBarElementZoom.ValueChanged += radTrackBarElementZoom_ValueChanged;
        }

        private void radGanttView1_ItemChildIdNeeded(object sender, GanttViewItemChildIdNeededEventArgs e)
        {
            e.ChildId = (id++).ToString();
        }

        private void radButtonElementAddTask_Click(object sender, EventArgs e)
        {
            if (this.radGanttView1.GanttViewElement.SelectedItem != null)
            {
                GanttViewDataItem newItem = new GanttViewDataItem();
                newItem.Start = this.radGanttView1.GanttViewElement.SelectedItem.Start;
                newItem.End = this.radGanttView1.GanttViewElement.SelectedItem.End;
                newItem.Title = "<new child>";

                this.radGanttView1.GanttViewElement.SelectedItem.Items.Insert(0, newItem);
            }
        }

        private void radButtonElementDeleteTask_Click(object sender, EventArgs e)
        {
            if (this.radGanttView1.SelectedItem == null)
            {
                return;
            }

            if (this.radGanttView1.GanttViewElement.SelectedItem.Parent == null)
            {
                this.radGanttView1.GanttViewElement.Items.Remove(this.radGanttView1.GanttViewElement.SelectedItem);
            }
            else
            {
                this.radGanttView1.GanttViewElement.SelectedItem.Parent.Items.Remove(this.radGanttView1.GanttViewElement.SelectedItem);
            }
        }

        private void radButtonElementAddMilestone_Click(object sender, EventArgs e)
        {
            if (this.radGanttView1.GanttViewElement.SelectedItem != null)
            {
                GanttViewDataItem newItem = new GanttViewDataItem();
                newItem.Start = this.radGanttView1.GanttViewElement.SelectedItem.Start;
                newItem.End = newItem.Start;
                newItem.Title = "<new milestone>";

                this.radGanttView1.GanttViewElement.SelectedItem.Items.Insert(0, newItem);
            }
        }

        private void radButtonElementProgress25_Click(object sender, EventArgs e)
        {
            if (this.radGanttView1.GanttViewElement.SelectedItem != null)
            {
                this.radGanttView1.GanttViewElement.SelectedItem.Progress = 25m;
            }
        }

        private void radButtonElementProgress50_Click(object sender, EventArgs e)
        {
            if (this.radGanttView1.GanttViewElement.SelectedItem != null)
            {
                this.radGanttView1.GanttViewElement.SelectedItem.Progress = 50m;
            }
        }

        private void radButtonElementProgress100_Click(object sender, EventArgs e)
        {
            if (this.radGanttView1.GanttViewElement.SelectedItem != null)
            {
                this.radGanttView1.GanttViewElement.SelectedItem.Progress = 100m;
            }
        }

        private void radButtonElementWeek_Click(object sender, EventArgs e)
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Week;
        }

        private void radButtonElementMonth_Click(object sender, EventArgs e)
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Month;
        }

        private void radButtonElementYear_Click(object sender, EventArgs e)
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Year;
        }

        private void radDateTimePickerElementStart_ValueChanged(object sender, EventArgs e)
        {
            if (this.radDateTimePickerElementStart.Value.HasValue)
            {
                this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = this.radDateTimePickerElementStart.Value.Value;
            }
        }

        private void radDateTimePickerElementEnd_ValueChanged(object sender, EventArgs e)
        {
            if (this.radDateTimePickerElementEnd.Value.HasValue)
            {
                this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = this.radDateTimePickerElementEnd.Value.Value;
            }
        }

        private void radButtonElementPrevious_Click(object sender, EventArgs e)
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.HorizontalScrollBarElement.PerformLargeDecrement(1);
        }

        private void radButtonElementNext_Click(object sender, EventArgs e)
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.HorizontalScrollBarElement.PerformLargeIncrement(1);
        }

        private void radTrackBarElementZoom_ValueChanged(object sender, EventArgs e)
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = new TimeSpan(0, (int)this.radTrackBarElementZoom.Value, 0);
        }
    }
}
