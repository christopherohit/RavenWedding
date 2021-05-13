using Telerik.QuickStart.WinControls;
using Telerik.Examples.WinControls.Properties;
using System;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Scheduler.Dialogs;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.PageView.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        private List<IRemindObject> openedAlerts = new List<IRemindObject>();
        public Form1()
        {
            InitializeComponent();

            this.radPageViewPage1.Image = Resources.OutlookViewNotes;
            this.radPageViewPage2.Image = Resources.OutlookViewTasks;
            this.radPageViewPage3.Image = Resources.OutlookViewContacts;
            this.radPageViewPage4.Image = Resources.OutlookViewCalendar;
            this.radPageViewPage6.Image = Resources.OutlookViewMail;

            ApplySchedulerSettings();

            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;

            //this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void ApplySchedulerSettings()
        {
            this.radScheduler1.ActiveView.StartDate = DateTime.Now.Date;

            FillAppointments();

            this.radSchedulerReminder1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerReminder1.AlarmFormShowing += new EventHandler<RadAlarmFormShowingEventArgs>(radSchedulerReminder1_AlarmFormShowing);
            this.radSchedulerReminder1.RemindObjectShown += new EventHandler<RadShowRemindObjectArgs>(radSchedulerReminder1_RemindObjectShown);
            this.radSchedulerReminder1.StartReminderInterval = this.radScheduler1.ActiveView.StartDate;
            this.radSchedulerReminder1.EndReminderInterval = DateHelper.GetEndOfDay(this.radScheduler1.ActiveView.StartDate);
            this.radSchedulerReminder1.StartReminder();           
        }

        void radSchedulerReminder1_RemindObjectShown(object sender, RadShowRemindObjectArgs e)
        {
            if (this.openedAlerts.Contains(e.RemindObject))
            {
                return;
            }
            Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);

            RadButtonElement radButtonElement = new RadButtonElement();
            radButtonElement.Click += new EventHandler(radButtonElement_Click);
            radButtonElement.Tag = e.RemindObject;
            radButtonElement.Image = global::Telerik.Examples.WinControls.Properties.Resources.EditTask16;

            this.openedAlerts.Add(e.RemindObject);
            
            radDesktopAlert.ButtonItems.Add(radButtonElement);
            radDesktopAlert.ThemeName = this.radScheduler1.ThemeName == "" ? this.GetExampleDefaultTheme() : this.radScheduler1.ThemeName;
            radDesktopAlert.FixedSize = new System.Drawing.Size(329, 120);
            radDesktopAlert.ContentImage = global::Telerik.Examples.WinControls.Properties.Resources.Reminder48;
            radDesktopAlert.ContentText = "<html><I>" + ((Appointment)e.RemindObject).Description + "</I></html>";
            radDesktopAlert.CaptionText = e.RemindObject.Subject;
            radDesktopAlert.Show();
            radDesktopAlert.Closed -= new RadPopupClosedEventHandler(radDesktopAlert_AlertClosed);
            radDesktopAlert.Closed += new RadPopupClosedEventHandler(radDesktopAlert_AlertClosed);
        }

        void radDesktopAlert_AlertClosed(object sender, RadPopupClosedEventArgs args)
        {
            Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert = sender as Telerik.WinControls.UI.RadDesktopAlert;
            this.openedAlerts.Remove((IRemindObject)radDesktopAlert.ButtonItems[0].Tag);
        }

        void radButtonElement_Click(object sender, EventArgs e)
        {
            RadButtonElement radButtonElement = sender as RadButtonElement;
            EditAppointmentDialog editAppointmentDialog = new EditAppointmentDialog((IEvent)radButtonElement.Tag, this.radScheduler1);
            editAppointmentDialog.ShowDialog(this);
        }

        void radSchedulerReminder1_AlarmFormShowing(object sender, RadAlarmFormShowingEventArgs e)
        {
            e.AlarmForm = null;
        }

        private void FillAppointments()
        {
            DateTime dtStart = DateTime.Now.Date.AddHours(9);
            DateTime dtEnd = DateTime.Now.Date.AddHours(12);

            Appointment appointment = new Appointment(dtStart, dtEnd.AddHours(8),
                "ASP.NET AJAX Or Silverlight Is The Future Of Web Development",
                "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build");
            appointment.BackgroundId = (int)AppointmentBackground.Anniversary;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            appointment.Reminder = TimeSpan.FromMinutes(15);
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart.AddHours(2), dtEnd.AddHours(3),
                "Silverlight Made Easy",
                "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            appointment.Reminder = TimeSpan.FromMinutes(15);
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart, dtEnd.AddHours(4),
                "SQL 2008",
                "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            appointment.Reminder = TimeSpan.FromMinutes(15);
            this.radScheduler1.Appointments.Add(appointment);
        }

        protected override void WireEvents()
        {
        }
    }
}
