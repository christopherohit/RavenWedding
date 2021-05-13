using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.Scheduler.TimeZones
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

            this.radScheduler1.ActiveView.StartDate = DateTime.Today;

            FillAppointments();

            this.radScheduler1.ActiveViewChanged += new EventHandler<SchedulerViewChangedEventArgs>(radScheduler1_ActiveViewChanged);

            this.InitializeTimeZones();

            this.radScheduler1.GetDayView().RulerWidth = 55;

            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
        }

        private void InitializeTimeZones()
        {
            List<SchedulerTimeZone> listOfTimeZones = SchedulerTimeZone.GetSchedulerTimeZones();

            foreach (SchedulerTimeZone timezone in listOfTimeZones)
            {
                timezone.Label = timezone.Label.Replace("(", string.Empty);
                timezone.Label = timezone.Label.Replace(")", string.Empty);
            }
            
            this.radDropDownList2.DataSource = new List<SchedulerTimeZone>(listOfTimeZones);
        }

        void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView.ViewType != e.OldView.ViewType)
            {
                SchedulerDayViewBase view = e.NewView as SchedulerDayViewBase;
                if (view != null)
                {
                    UpdateControls(true);
                    view.RulerWidth = 55;
                }
                else
                {
                    UpdateControls(false);
                }

                e.NewView.DefaultTimeZone = e.OldView.DefaultTimeZone;
            }
        }

        private void UpdateControls(bool isDayView)
        {
            this.radButton2.Visible = isDayView;
            this.radLabel2.Visible = isDayView;
            this.radDropDownList2.Visible = isDayView;
        }

        private void FillAppointments()
        {
            this.radScheduler1.Appointments.BeginUpdate();

            DateTime dtStart = DateTime.Today.AddDays(2).AddHours(10);
            DateTime dtEnd = DateTime.Today.AddDays(2).AddHours(12);

            Appointment appointment = new Appointment(dtStart, dtEnd,
                "ASP.NET AJAX Or Silverlight Is The Future Of Web Development",
                "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build");
            appointment.BackgroundId = (int)AppointmentBackground.MustAttend;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart.AddHours(2), dtEnd.AddHours(3),
                "Silverlight Made Easy",
                "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.");
            appointment.BackgroundId = (int)AppointmentBackground.PhoneCall;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart.AddHours(-2), dtEnd.AddHours(4),
                "SQL 2008",
                "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            this.radScheduler1.Appointments.EndUpdate();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                SchedulerTimeZone schedulerTimeZone = this.radDropDownList2.SelectedValue as SchedulerTimeZone;
                if (!view.TimeZones.Contains(schedulerTimeZone))
                {
                    view.TimeZones.Add(schedulerTimeZone);
                }
            }
        }

        protected override void WireEvents()
        {
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
        }
    }
}
