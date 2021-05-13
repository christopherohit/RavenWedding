using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.NavigatorSteps
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radScheduler1.ActiveView.StartDate = DateTime.Today;

            FillAppointments();

            FillNavigationStepTypesCombo();

            this.radComboBox1.SelectedIndex = 0;

            this.radGroupBox1.Enabled = false;

            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;

            this.radScheduler1.ActiveViewChanged += new EventHandler<SchedulerViewChangedEventArgs>(radScheduler1_ActiveViewChanged);

        }

        void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView.ViewType != e.OldView.ViewType && e.NewView.ViewType == SchedulerViewType.Month)
            {
                this.radScheduler1.GetMonthView().WeekCount = 5;
            }

            UpdateControlsAndValues();

            this.radSpinEditor1.Value = this.radSchedulerNavigator1.NavigationStep;
        }

        private void FillNavigationStepTypesCombo()
        {
            this.radComboBox1.Items.Add(new RadListDataItem("Day", NavigationStepTypes.Day));
            this.radComboBox1.Items.Add(new RadListDataItem("Week", NavigationStepTypes.Week));
            this.radComboBox1.Items.Add(new RadListDataItem("Month", NavigationStepTypes.Month));
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

        private void radComboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            UpdateControlsAndValues();
        }

        private void UpdateControlsAndValues()
        {
            RadListDataItem selectedItem = this.radComboBox1.SelectedItem as RadListDataItem;
            if (selectedItem != null)
            {
                NavigationStepTypes stepType = (NavigationStepTypes)selectedItem.Value;
                this.radSchedulerNavigator1.NavigationStepType = stepType;

                if (this.radScheduler1.ActiveViewType != SchedulerViewType.Day &&
                    this.radScheduler1.ActiveViewType != SchedulerViewType.Timeline && 
                    stepType == NavigationStepTypes.Day)
                {
                    this.radSpinEditor1.Minimum = 7;
                }
                else
                {
                    this.radSpinEditor1.Minimum = 1;
                }
            }
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            this.radSchedulerNavigator1.NavigationStep = (int)this.radSpinEditor1.Value;
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radSchedulerNavigator1.AutomaticNavigation = this.radCheckBox1.Checked;
            this.radGroupBox1.Enabled = !this.radCheckBox1.Checked;
        }

        protected override void WireEvents()
        {
            this.radComboBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox1_SelectedIndexChanged);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
        }
    }
}
