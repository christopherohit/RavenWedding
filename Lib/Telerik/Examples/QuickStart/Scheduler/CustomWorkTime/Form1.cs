using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Scheduler.CustomWorkTime
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radSchedulerNavigator1.AgendaViewButtonVisible = false;
            this.radDropDownList1.DataSource = Enum.GetValues(typeof(DayOfWeek));
            this.radDropDownList2.DataSource = Enum.GetValues(typeof(DayOfWeek));
            this.radDropDownList1.SelectedValue = DayOfWeek.Monday;
            this.radDropDownList2.SelectedValue = DayOfWeek.Friday;

            this.radScheduler1.ActiveView.StartDate = DateTime.Now.Date;

            SetDateTimePickersDefaultValues();
            FillAppointments();

            this.radSchedulerNavigator1.TimelineViewButtonVisible = false;
            this.radSchedulerNavigator1.MonthViewButtonVisible = false;

            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;

            WorkTimeExceptionRule exceptionRule = new WorkTimeExceptionRule();
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                exceptionRule.ExceptionStartDate = DateTime.Now.Date;
                exceptionRule.ExceptionEndDate = DateTime.Now.Date.AddHours(24);
                exceptionRule.StartTime = new TimeSpan(10,0,0);
                exceptionRule.EndTime = new TimeSpan(12,0,0);
                view.WorkTimeExceptions.Add(exceptionRule);
            }

            UpdateRuler();
            UpdateWorkTime();
            LoadSettings();
        }

        private void LoadSettings()
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            this.radSpinEditor1.Value = dayView.RulerStartScale;
            this.radSpinEditor2.Value = dayView.RulerStartScaleMinutes;
            this.radSpinEditor3.Value = dayView.RulerEndScaleMinutes;
            this.radSpinEditor4.Value = dayView.RulerEndScale;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ScrollToWorkTime();
        }

        private void ScrollToWorkTime()
        {
            SchedulerDayViewElement dayViewElement = (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement);
            TimeSpan time = new TimeSpan(this.radDateTimePicker1.Value.Hour - 1, this.radDateTimePicker1.Value.Minute, 0);
            dayViewElement.DataAreaElement.Table.ScrollToTime(time);
        }

        private void FillAppointments()
        {
            this.radScheduler1.Appointments.BeginUpdate();

            DateTime dtStart = DateTime.Now.Date.AddDays(2).AddHours(10);
            DateTime dtEnd = DateTime.Now.Date.AddDays(2).AddHours(12);

            Appointment appointment = new Appointment(dtStart, dtEnd,
                "ASP.NET AJAX Or Silverlight Is The Future Of Web Development",
                "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build");
            appointment.BackgroundId = (int)AppointmentBackground.Anniversary;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart.AddHours(2), dtEnd.AddHours(3),
                "Silverlight Made Easy",
                "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler1.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(-1);
            dtEnd = dtEnd.AddDays(-1);

            appointment = new Appointment(dtStart.AddHours(4), dtEnd.AddHours(4),
                "SQL 2008",
                "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.");
            appointment.BackgroundId = (int)AppointmentBackground.Important;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler1.Appointments.Add(appointment);

            this.radScheduler1.Appointments.EndUpdate();
        }

        void DateTimePickerElement_ValueChanging1(object sender, ValueChangingEventArgs e)
        {
            if ((DateTime)e.NewValue >= this.radDateTimePicker2.Value)
            {
                e.Cancel = true;
            }
        }

        void DateTimePickerElement_ValueChanging2(object sender, ValueChangingEventArgs e)
        {
            if ((DateTime)e.NewValue <= this.radDateTimePicker1.Value)
            {
                e.Cancel = true;
            }
        }

        private void SetDateTimePickersDefaultValues()
        {
            DateTime dtStart = new DateTime(
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                9, 0, 0);

            this.radDateTimePicker1.Value = dtStart;

            DateTime dtEnd = new DateTime(
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                14, 0, 0);

            this.radDateTimePicker2.Value = dtEnd;
        }

        private void radDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateWorkTime();
        }

        private void UpdateRuler()
        {
            RulerPrimitive ruler = (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement).DataAreaElement.Ruler;
            ruler.FormatStrings = new RulerFormatStrings("hh", "mm", "", "mm");
        }

        private void UpdateWorkTime()
        {
            TimeInterval timeInterval = new TimeInterval(this.radDateTimePicker1.Value.TimeOfDay, this.radDateTimePicker2.Value.TimeOfDay);
            ((SchedulerDayViewBase)this.radScheduler1.ActiveView).WorkTime = timeInterval;
        }

        private void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView.ViewType == e.OldView.ViewType)
            {
                return;
            }

            switch ( this.radScheduler1.ActiveViewType )
            {
                case SchedulerViewType.Day:
                    this.radScheduler1.GetDayView().DayCount = 3;
                    this.radGroupBox1.Enabled = true;
                    UpdateWorkTime();
                    ScrollToWorkTime();
                    UpdateRuler();
                    break;
                case SchedulerViewType.Week:
                case SchedulerViewType.WorkWeek:
                    this.radGroupBox1.Enabled = true;
                    UpdateWorkTime();
                    ScrollToWorkTime();
                    UpdateRuler();
                    break;
                default:
                    this.radGroupBox1.Enabled = false;
                    break;
            }

            LoadSettings();
        }

        protected override void WireEvents()
        {
            this.radDateTimePicker1.ValueChanging += DateTimePickerElement_ValueChanging1;
            this.radDateTimePicker2.ValueChanging += DateTimePickerElement_ValueChanging2;
            this.radDateTimePicker2.ValueChanged += this.radDateTimePicker_ValueChanged;
            this.radDateTimePicker1.ValueChanged += this.radDateTimePicker_ValueChanged;
            this.radScheduler1.ActiveViewChanged += this.radScheduler1_ActiveViewChanged;
            this.radDropDownList1.SelectedIndexChanged += radDropDownList1_SelectedIndexChanged;
            this.radDropDownList2.SelectedIndexChanged += radDropDownList2_SelectedIndexChanged;
        }

        private void radDropDownList2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                view.WorkWeekEnd = (DayOfWeek)this.radDropDownList2.Items[e.Position].Value;
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                view.WorkWeekStart = (DayOfWeek)this.radDropDownList1.Items[e.Position].Value;
            }
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                view.RulerStartScale = (int)this.radSpinEditor1.Value;
            }
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                view.RulerStartScaleMinutes = (int)this.radSpinEditor2.Value;
            }
        }
        
        private void radSpinEditor3_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                view.RulerEndScaleMinutes = (int)this.radSpinEditor3.Value;
            }
        }

        private void radSpinEditor4_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                view.RulerEndScale = (int)this.radSpinEditor4.Value;
                if (view.RulerEndScale == 24 || (int)this.radSpinEditor4.Value == 24)
                {
                    this.radSpinEditor3.Value = 0;
                    this.radSpinEditor3.Enabled = false;
                }
                else
                {
                    this.radSpinEditor3.Enabled = true;
                }
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                RadForm workTimeExceptionsForm = new RadForm();
                workTimeExceptionsForm.Size = new System.Drawing.Size(1000, 200);
            
                RadGridView grid = new RadGridView();
                workTimeExceptionsForm.Controls.Add(grid); 
                string themeName = this.radScheduler1.ThemeName == "" ? this.GetExampleDefaultTheme() : this.radScheduler1.ThemeName;
                ThemeResolutionService.ApplyThemeToControlTree(workTimeExceptionsForm, themeName);
                grid.Dock = System.Windows.Forms.DockStyle.Fill;
                grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                grid.BindingContext = new System.Windows.Forms.BindingContext();
                grid.DataSource = view.WorkTimeExceptions;
                grid.Columns["ResourceId"].IsVisible = false;
                grid.Columns["ExceptionStartDate"].FormatString = "{0:D}";
                grid.Columns["ExceptionEndDate"].FormatString = "{0:D}";
                grid.Columns["StartTime"].DataTypeConverter = new MyTypeConverter();
                grid.Columns["EndTime"].DataTypeConverter = new MyTypeConverter();
                grid.EditorRequired += grid_EditorRequired;
                grid.DefaultValuesNeeded += grid_DefaultValuesNeeded;
                workTimeExceptionsForm.Show();
            }
        }

        private void grid_DefaultValuesNeeded(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells["StartTime"].Value = new TimeSpan(0,0,0);
            e.Row.Cells["EndTime"].Value = new TimeSpan(23,0,0);
        }

        void grid_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            GridViewEditManager editMgr = sender as GridViewEditManager;
            if (editMgr.GridViewElement.CurrentColumn.Name == "StartTime" || editMgr.GridViewElement.CurrentColumn.Name == "EndTime")
            {
                GridTimePickerEditor editor = new GridTimePickerEditor();
                RadTimePickerElement editorElement = (editor.EditorElement as RadTimePickerElement);
                editorElement.Culture = new System.Globalization.CultureInfo("en-GB");
                editorElement.PopupMinSize = new System.Drawing.Size(0, 320);
                e.Editor = editor;
            }
        }
    }
}