using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.CustomTimeline
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            DateTime start = new DateTime(1897, 1, 1);
            DateTime end = DateTime.Now.AddYears(1);

            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineBehavior = new ExampleGanttViewTimelineBehavior();
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Custom;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = new TimeSpan(168, 0, 0);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = start;
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = end;

            this.radGanttView1.GanttViewElement.ChildMember = "Title";
            this.radGanttView1.GanttViewElement.TitleMember = "Title";
            this.radGanttView1.GanttViewElement.StartMember = "Start";
            this.radGanttView1.GanttViewElement.EndMember = "End";

            WarsData data = new WarsData();
            this.radGanttView1.GanttViewElement.DataSource = data.Wars;
        }
    }
}
