using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GanttView.AutomaticTimeline
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupGanttViews();
            this.SetupTrackbar();
        }

        private void SetupGanttViews()
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = new DateTime(1990, 1, 1);
            this.radGanttView2.GanttViewElement.GraphicalViewElement.TimelineStart = new DateTime(1990, 1, 1);

            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = new DateTime(2011, 1, 1);
            this.radGanttView2.GanttViewElement.GraphicalViewElement.TimelineEnd = new DateTime(2011, 1, 1);

            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.YearHalves;
            this.radGanttView2.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.YearHalves;

            this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = new TimeSpan(5, 0, 0, 0);
            this.radGanttView2.GanttViewElement.GraphicalViewElement.OnePixelTime = new TimeSpan(5, 0, 0, 0);

            this.radGanttView1.GanttViewElement.GraphicalViewElement.AutomaticTimelineTimeRange = false;
            this.radGanttView2.GanttViewElement.GraphicalViewElement.AutomaticTimelineTimeRange = true;
        }

        private void SetupTrackbar()
        {
            this.radTrackBarZoom.LargeTickFrequency = 200;
            this.radTrackBarZoom.SmallTickFrequency = 20;
            this.radTrackBarZoom.Minimum = 0;
            this.radTrackBarZoom.Maximum = 1100;
            this.radTrackBarZoom.Value = 1100;

            this.radTrackBarZoom.ValueChanged += new System.EventHandler(this.radTrackBarZoom_ValueChanged);
        }

        private void radTrackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            double value = 51 + 0.005d * Math.Pow(this.radTrackBarZoom.Value, 2d);
            Console.WriteLine(string.Format("{0} - {1}", this.radTrackBarZoom.Value, value));

            TimeSpan time = new TimeSpan(0, (int)value, 0);
            this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = time;
            this.radGanttView2.GanttViewElement.GraphicalViewElement.OnePixelTime = time;
        }
    }
}
