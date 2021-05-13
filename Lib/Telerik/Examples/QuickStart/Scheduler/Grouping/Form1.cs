using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.Grouping
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DateTime baseDate = DateTime.Today;
            DateTime[] start = new DateTime[] { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0) };
            DateTime[] end = new DateTime[] { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0) };
            string[] summaries = new string[] { "Mr. Brown", "Mr. White", "Mrs. Green" };
            string[] descriptions = new string[] { "", "", "" };
            string[] locations = new string[] { "City", "Out of town", "Service Center" };
            AppointmentBackground[] backgrounds = new AppointmentBackground[] { AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal };

            this.radSchedulerDemo.Appointments.BeginUpdate();
            Appointment appointment = null;
          
            appointment = new Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "Wash the car", "", "Garage");
            appointment.RecurrenceRule = new DailyRecurrenceRule(baseDate.AddHours(11.0), 2);
            this.radSchedulerDemo.Appointments.Add(appointment);
            this.radSchedulerDemo.Appointments.EndUpdate();
                 
            Color[] colors = new Color[]
            {
                Color.LightBlue, Color.LightGreen, Color.LightYellow,
                Color.Red, Color.Orange, Color.Pink, Color.Purple, Color.Peru, Color.PowderBlue
            };

            string[] names = new string[]
            {
                "Alan Smith", "Anne Dodsworth",
                "Boyan Mastoni", "Richard Duncan", "Maria Shnaider"
            };

            for (int i = 0; i < names.Length; i++)
            {
                Resource resource = new Resource();
                resource.Id = new EventId(i);
                resource.Name = names[i];
                resource.Color = colors[i];
 
                resource.Image = this.imageList1.Images[i];
                this.radSchedulerDemo.Resources.Add(resource);
            }

            this.radSchedulerDemo.GetDayView().ResourcesPerView = 2;
            this.radSchedulerDemo.GroupType = GroupType.Resource;
            SchedulerDayViewGroupedByResourceElement headerElement = this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
            headerElement.ResourceHeaderHeight = 135;

            for (int i = 0; i < summaries.Length; i++)
            {
                appointment = new Appointment(start[i], end[i], summaries[i],
                    descriptions[i], locations[i]);
                appointment.ResourceId = this.radSchedulerDemo.Resources[0].Id;
                appointment.BackgroundId = (int)backgrounds[i];
                this.radSchedulerDemo.Appointments.Add(appointment);
            }

            SchedulerDayViewGroupedByResourceElement dayView = this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
            dayView.ScrollToWorkHours();

            this.radSchedulerDemo.ActiveViewChanged += new EventHandler<SchedulerViewChangedEventArgs>(radSchedulerDemo_ActiveViewChanged);
            this.radSchedulerDemo.PropertyChanged += new PropertyChangedEventHandler(radSchedulerDemo_PropertyChanged);
            this.radSchedulerDemo.MouseDown += new MouseEventHandler(radSchedulerDemo_MouseDown);

            this.radSchedulerDemo.SchedulerElement.SetResourceHeaderAngleTransform(SchedulerViewType.Timeline, 0);

            this.radSchedulerNavigator1.AssociatedScheduler = this.radSchedulerDemo;
            this.radSchedulerDemo.SelectionBehavior.SelectDateRange(DateTime.Now.Date.AddHours(7), DateTime.Now.Date.AddHours(8), this.radSchedulerDemo.Resources[0].Id);
        }

        void radSchedulerDemo_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.isSwitchedMonthToWeek)
            {
                InvalidateScheduler();
                this.isSwitchedMonthToWeek = false;
            }
        }

        void radSchedulerDemo_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            InvalidateScheduler();
        }

        void radSchedulerDemo_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.OldView.ViewType != e.NewView.ViewType)
            {
                switch (e.NewView.ViewType)
                {
                    case SchedulerViewType.Month:
                        this.radSchedulerDemo.GetMonthView().WeekCount = 5;
                        break;
                    case SchedulerViewType.Day:
                        this.radSchedulerDemo.GetDayView().DayCount = 1;
                        break;
                }
            }

            if (e.OldView.ViewType == SchedulerViewType.Month && e.NewView.ViewType == SchedulerViewType.Week)
            {
                this.isSwitchedMonthToWeek = true;
            }

            InvalidateScheduler();
        }

        private bool isSwitchedMonthToWeek = false;

        private void InvalidateScheduler()
        {
            SchedulerDayViewGroupedByResourceElement dayView = this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
            SchedulerMonthViewGroupedByResourceElement monthView = this.radSchedulerDemo.SchedulerElement.ViewElement as SchedulerMonthViewGroupedByResourceElement;
            TimelineGroupingByResourcesElement timelineElement = this.radSchedulerDemo.SchedulerElement.ViewElement as TimelineGroupingByResourcesElement;

            if (dayView == null && monthView == null && timelineElement == null)
                return;

            int headerHeight = 135;

            if (dayView != null)
            {
                dayView.ResourceHeaderHeight = headerHeight;
                dayView.InvalidateMeasure(true);
            }
            else if (monthView != null)
            {
                monthView.ResourceHeaderHeight = headerHeight;
            }
            else if (timelineElement != null)
            {
                timelineElement.ResourceHeaderWidth = headerHeight;
            }
          
            this.radSchedulerDemo.PerformLayout();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radSchedulerDemo.GetDayView().DayCount = 1;
            this.radSchedulerDemo.GetDayView().StartDate = this.radSchedulerDemo.GetDayView().StartDate.AddDays(1);
        }

        protected override void WireEvents()
        {
        }

        bool suspendTrackBar = false;

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (radSchedulerDemo.SelectionBehavior.CurrentCellElement != null)
            {
                SchedulerViewGroupedByResourceElementBase viewGroupedByResource = radSchedulerDemo.ViewElement as SchedulerViewGroupedByResourceElementBase;
                int resourceId = GetResourceIndex(viewGroupedByResource);
            
                if (resourceId >= 0 && !suspendTrackBar)
                {
                    viewGroupedByResource.SetResourceSize(resourceId, this.radTrackBar1.Value);
                }
            }
        }
  
        private int GetResourceIndex(SchedulerViewGroupedByResourceElementBase viewGroupedByResource)
        {
            IResource cellResource = radSchedulerDemo.SelectionBehavior.CurrentCellElement.View.GetResource();         
            int cellResourceIndex = radSchedulerDemo.Resources.IndexOf(cellResource);

            int resourceId = cellResourceIndex - viewGroupedByResource.ResourceStartIndex;
            return resourceId;
        }
        
        private void radSchedulerDemo_CellSelectionChanged(object sender, EventArgs e)
        {
            suspendTrackBar = true;
            SchedulerViewGroupedByResourceElementBase viewGroupedByResource = radSchedulerDemo.ViewElement as SchedulerViewGroupedByResourceElementBase;
            int resourceId = GetResourceIndex(viewGroupedByResource);
            this.radTrackBar1.Value = viewGroupedByResource.GetResourceSize(resourceId); 
            suspendTrackBar = false;
        }

        private void radTrackBar1_ToolTipTextNeeded(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Resize current resource";
        }
    }
}