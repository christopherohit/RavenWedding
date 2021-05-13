using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.Events
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
            for (int i = 0; i < summaries.Length; i++)
            {
                appointment = new Appointment(start[i], end[i], summaries[i],
                    descriptions[i], locations[i]);
                appointment.BackgroundId = (int)backgrounds[i];
                this.radSchedulerDemo.Appointments.Add(appointment);
            }

            appointment = new Appointment(baseDate.AddHours(11.0), baseDate.AddHours(12.0), "Wash the car", "", "Garage");
            appointment.RecurrenceRule = new DailyRecurrenceRule(baseDate.AddHours(11.0), 2);
            this.radSchedulerDemo.Appointments.Add(appointment);
            this.radSchedulerDemo.Appointments.EndUpdate();

            this.radSchedulerDemo.Resources.Add(new Resource(1, "Dell Laptop"));
            this.radSchedulerDemo.Resources.Add(new Resource(2, "Lenovo Laptop"));
            this.radSchedulerDemo.Resources.Add(new Resource(3, "Toshiba Laptop"));
            (this.radSchedulerDemo.ActiveView as SchedulerDayView).DayCount = 1;
            this.radTxtEventList.ReadOnly = true;
        }

        private void radScheduler1_AppointmentMouseDown(object sender, SchedulerAppointmentMouseEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentMouseDown\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentMouseUp(object sender, SchedulerAppointmentMouseEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentMouseUp\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentEditDialogShowing\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentSelected(object sender, SchedulerAppointmentSelectedEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentSelected\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_AppointmentSelecting(object sender, SchedulerAppointmentCancelEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentSelecting\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_CellClick(object sender, SchedulerCellEventArgs e)
        {
            this.radTxtEventList.Text += "CellClick\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_ActiveViewChanging(object sender, SchedulerViewChangingEventArgs e)
        {
            this.radTxtEventList.Text += "ActiveViewChanging\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            this.radTxtEventList.Text += "ActiveViewChanged\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        private void radSchedulerDemo_RecurrenceEditDialogShowing(object sender, RecurrenceEditDialogShowingEventArgs e)
        {
            this.radTxtEventList.Text += "RecurrenceEditDialogShowing\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }
        void radScheduler1_AppointmentDropping(object sender, AppointmentMovingEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentDropping\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_AppointmentDropped(object sender, AppointmentMovedEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentDropped\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_AppointmentMoving(object sender, AppointmentMovingEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentMoving\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_CellSelectionChanging(object sender, SchedulerCellSelectingEventArgs e)
        {
            this.radTxtEventList.Text += "CellSelectionChanging\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_CellSelectionChanged(object sender, EventArgs e)
        {
            this.radTxtEventList.Text += "CellSelectionChanged\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_AppointmentMoved(object sender, Telerik.WinControls.UI.AppointmentMovedEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentMoved\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_AppointmentResizeStart(object sender, Telerik.WinControls.UI.SchedulerAppointmentCancelEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentResizeStart\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_AppointmentResizeEnd(object sender, Telerik.WinControls.UI.SchedulerAppointmentEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentResizeEnd\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }

        void radScheduler1_AppointmentResized(object sender, Telerik.WinControls.UI.AppointmentResizedEventArgs e)
        {
            this.radTxtEventList.Text += "AppointmentResized\r\n";
            this.radTxtEventList.SelectionStart = this.radTxtEventList.TextLength;
            this.radTxtEventList.ScrollToCaret();
        }
        protected override void WireEvents()
        {
            this.radSchedulerDemo.ActiveViewChanged += this.radScheduler1_ActiveViewChanged;
            this.radSchedulerDemo.AppointmentSelected +=this.radScheduler1_AppointmentSelected;
            this.radSchedulerDemo.RecurrenceEditDialogShowing += this.radSchedulerDemo_RecurrenceEditDialogShowing;
            this.radSchedulerDemo.CellClick += this.radScheduler1_CellClick;
            this.radSchedulerDemo.AppointmentMouseDown +=this.radScheduler1_AppointmentMouseDown;
            this.radSchedulerDemo.ActiveViewChanging += radScheduler1_ActiveViewChanging;
            this.radSchedulerDemo.AppointmentEditDialogShowing +=this.radScheduler1_AppointmentEditDialogShowing;
            this.radSchedulerDemo.AppointmentMouseUp += this.radScheduler1_AppointmentMouseUp;
            this.radSchedulerDemo.AppointmentSelecting += radScheduler1_AppointmentSelecting;

            this.radSchedulerDemo.AppointmentResized += this.radScheduler1_AppointmentResized;
            this.radSchedulerDemo.AppointmentResizeEnd += this.radScheduler1_AppointmentResizeEnd;
            this.radSchedulerDemo.AppointmentResizeStart += this.radScheduler1_AppointmentResizeStart;
            
            this.radSchedulerDemo.AppointmentMoving += this.radScheduler1_AppointmentMoving;
            this.radSchedulerDemo.AppointmentMoved += this.radScheduler1_AppointmentMoved;
            this.radSchedulerDemo.AppointmentDropped += this.radScheduler1_AppointmentDropped;
            this.radSchedulerDemo.AppointmentDropping += this.radScheduler1_AppointmentDropping;
           
            this.radSchedulerDemo.CellSelectionChanged += this.radScheduler1_CellSelectionChanged;
            this.radSchedulerDemo.CellSelectionChanging += this.radScheduler1_CellSelectionChanging;
        }
    }
}