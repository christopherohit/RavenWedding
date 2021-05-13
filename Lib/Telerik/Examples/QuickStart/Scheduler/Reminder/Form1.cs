using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Scheduler.Dialogs;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Scheduler.Reminder
{
    public partial class Form1 : ExamplesForm
    {
        private CustomAlarmForm customAlarmForm;

        public Form1()
        {
            InitializeComponent();

            FillAppointments();

            this.radSchedulerReminder1.ItemOpened += new EventHandler<RadOpenItemArgs>(radReminder1_ItemOpened);
            this.customAlarmForm = new CustomAlarmForm();

            this.radScheduler1.ThemeNameChanged += new ThemeNameChangedEventHandler(radScheduler1_ThemeNameChanged);

            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
        }

        void radScheduler1_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            this.radSchedulerReminder1.ThemeName = this.radScheduler1.ThemeName;
        }

        private void FillAppointments()
        {
            this.radScheduler1.Appointments.BeginUpdate();

            DateTime dtStart = DateTime.Now.AddMinutes(-13);
            DateTime dtEnd = dtStart.AddHours(1);

            Appointment appointment = new Appointment(dtStart, dtEnd,
                "ASP.NET AJAX Or Silverlight Is The Future Of Web Development",
                "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build");
            appointment.BackgroundId = (int)AppointmentBackground.MustAttend;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            appointment.Reminder = System.TimeSpan.Parse("00:15:00");
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddMinutes(1);
            dtEnd = dtStart.AddHours(1);

            appointment = new Appointment(dtStart.AddHours(2), dtEnd.AddHours(3),
                "Silverlight Made Easy",
                "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.");
            appointment.BackgroundId = (int)AppointmentBackground.PhoneCall;
            appointment.StatusId = (int)AppointmentStatus.Free;
            appointment.Reminder = System.TimeSpan.Parse("00:15:00");
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddMinutes(1);
            dtEnd = dtStart.AddHours(1);

            appointment = new Appointment(dtStart.AddHours(-2), dtEnd.AddHours(4),
                "SQL 2008",
                "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            appointment.Reminder = System.TimeSpan.Parse("00:15:00");
            this.radScheduler1.Appointments.Add(appointment);

            this.radScheduler1.Appointments.EndUpdate();
        }

        void radReminder1_ItemOpened(object sender, RadOpenItemArgs e)
        {
            EditAppointmentDialog editAppointmentDialog = new EditAppointmentDialog((IEvent)e.RemindObject, this.radScheduler1);
            ThemeResolutionService.ApplyThemeToControlTree(editAppointmentDialog, this.radScheduler1.ThemeName);
            editAppointmentDialog.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radSchedulerReminder1.TimeInterval = (int)this.radSpinEditor1.Value * 1000;

            this.radLabel1.Enabled = !this.radLabel1.Enabled;
            this.radSpinEditor1.Enabled = !this.radSpinEditor1.Enabled;
            this.radGroupBox1.Enabled = !this.radGroupBox1.Enabled;

            if (this.radSpinEditor1.Enabled)
            {
                this.radButton1.Text = "Start";
                this.radSchedulerReminder1.StopReminder();
            }
            else
            {
                this.radButton1.Text = "Stop";
                this.radSchedulerReminder1.StartReminder();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radButton1_Click(null, null);
        }

        private void radRadioButtonCustom_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radSchedulerReminder1.AlarmFormShowing += new EventHandler<RadAlarmFormShowingEventArgs>(radSchedulerReminder1_ShowingAlarmForm);
            }
            else
            {
                this.radSchedulerReminder1.AlarmFormShowing -= new EventHandler<RadAlarmFormShowingEventArgs>(radSchedulerReminder1_ShowingAlarmForm);
            }
        }

        void radSchedulerReminder1_ShowingAlarmForm(object sender, RadAlarmFormShowingEventArgs e)
        {
            e.AlarmForm = this.customAlarmForm;
        }

        private void radRadioButtonDefault_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radSchedulerReminder1.ResetToDefaultAlarmForm();
            }
        }

        protected override void WireEvents()
        {
            this.radRadioButtonCustom.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonCustom_ToggleStateChanged);
            this.radRadioButtonDefault.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonDefault_ToggleStateChanged);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
        }
    }
}
