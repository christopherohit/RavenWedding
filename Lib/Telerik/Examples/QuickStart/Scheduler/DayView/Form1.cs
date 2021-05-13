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

namespace Telerik.Examples.WinControls.Scheduler.DayView
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radSchedulerNavigator1.TimelineViewButtonVisible = false;
            this.radSchedulerNavigator1.MonthViewButtonVisible = false;
            this.radSchedulerNavigator1.AgendaViewButtonVisible = false;
            this.radSchedulerNavigator1.ShowWeekendCheckBox.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            this.dropDownRangeFactor.DataSource = Enum.GetValues(typeof(ScaleRange));
            this.dropDownWorkWeekStart.DataSource = Enum.GetValues(typeof(DayOfWeek));
            this.dropDownWorkWeekEnd.DataSource = Enum.GetValues(typeof(DayOfWeek));

            this.radScheduler1.ViewElement.AppointmentMargin = Padding.Empty;

            this.LoadSettings();
            this.FillAppointments();

            this.radScheduler1.ActiveViewChanged += radScheduler1_ActiveViewChanged;
            this.radScheduler1.CellSelectionChanged += radScheduler1_CellSelectionChanged;
            this.radScheduler1.SelectionBehavior.SelectCell(this.radScheduler1.ViewElement.GetCellAtPosition(1, 0));
        }

        private void LoadSettings()
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            SchedulerWeekView weekView = this.radScheduler1.ActiveView as SchedulerWeekView;
            SchedulerDayViewElement dayViewElement = this.radScheduler1.ViewElement as SchedulerDayViewElement;

            this.timePickerRulerStart.Value = DateTime.Today.Add(TimeSpan.FromHours(dayView.RulerStartScale))
                .Add(TimeSpan.FromMilliseconds(dayView.RulerStartScaleMinutes));

            this.timePickerRulerEnd.Value = dayView.RulerEndScale == 24 ? DateTime.Today.AddHours(23).AddMinutes(59) : 
                DateTime.Today.Add(TimeSpan.FromHours(dayView.RulerEndScale)).Add(TimeSpan.FromMilliseconds(dayView.RulerEndScaleMinutes));

            this.spinEditorScaleSize.Value = dayView.RulerScaleSize;
            this.dropDownRangeFactor.SelectedValue = dayView.RangeFactor;
            this.spinEditorRulerWidth.Value = dayView.RulerWidth;
            this.spinEditorPointerWidth.Value = (decimal)dayViewElement.DataAreaElement.Ruler.CurrentTimePointerWidth;

            ////

            this.timePickerWorkTimeStart.Value = DateTime.Today.Add(dayView.WorkTime.Start);
            this.timePickerWorkTimeEnd.Value = DateTime.Today.Add(dayView.WorkTime.End);
            this.dropDownWorkWeekStart.SelectedValue = dayView.WorkWeekStart;
            this.dropDownWorkWeekEnd.SelectedValue = dayView.WorkWeekEnd;

            ////

            this.checkBoxShowWeekend.Checked = weekView != null ? weekView.ShowWeekend : false;
            this.checkBoxShowRuler.Checked = dayView.ShowRuler;
            this.checkBoxShowHeader.Checked = dayView.ShowHeader;
            this.checkBoxShowAllDayArea.Checked = dayView.ShowAllDayArea;
            this.checkBoxExactTimeRendering.Checked = this.radScheduler1.EnableExactTimeRendering;
            this.spinEditorAllDayHeight.Value = dayViewElement.AllDayHeaderHeight;
            this.spinEditorAllDayMaxHeight.Minimum = this.spinEditorAllDayHeight.Value;
            this.spinEditorAllDayMaxHeight.Value = dayViewElement.AllDayHeaderElement.MaxHeaderHeight;
            this.spinEditorAppointmentSpacing.Value = dayViewElement.AppointmentMargin.All;

            this.spinEditorAllDayHeight.Enabled = dayView.ShowAllDayArea;
            this.spinEditorAllDayMaxHeight.Enabled = dayView.ShowAllDayArea;
            this.spinEditorRulerWidth.Enabled = dayView.ShowRuler;
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

        protected override void WireEvents()
        {
            base.WireEvents();

            this.timePickerRulerStart.ValueChanged += timePickerRulerStart_ValueChanged;
            this.timePickerRulerEnd.ValueChanged += timePickerRulerEnd_ValueChanged;
            this.spinEditorScaleSize.ValueChanged += spinEditorScaleSize_ValueChanged;

            this.dropDownRangeFactor.SelectedValueChanged += dropDownRangeFactor_SelectedValueChanged;
            this.spinEditorRulerWidth.ValueChanged += spinEditorRulerWidth_ValueChanged;
            this.spinEditorPointerWidth.ValueChanged += spinEditorPointerWidth_ValueChanged;

            ////

            this.timePickerWorkTimeStart.ValueChanged += timePickerWorkTimeStart_ValueChanged;
            this.timePickerWorkTimeEnd.ValueChanged += timePickerWorkTimeEnd_ValueChanged;

            this.dropDownWorkWeekStart.SelectedValueChanged += dropDownWorkWeekStart_SelectedValueChanged;
            this.dropDownWorkWeekEnd.SelectedValueChanged += dropDownWorkWeekEnd_SelectedValueChanged;

            ////

            this.checkBoxShowWeekend.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxShowRuler.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxShowHeader.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxShowAllDayArea.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxExactTimeRendering.ToggleStateChanged += checkBox_ToggleStateChanged;

            this.spinEditorAllDayHeight.ValueChanged += spinEditorCommon_ValueChanged;
            this.spinEditorAllDayMaxHeight.ValueChanged += spinEditorCommon_ValueChanged;
            this.spinEditorAppointmentSpacing.ValueChanged += spinEditorCommon_ValueChanged;
        }

        void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            SchedulerDayViewElement dayViewElement = this.radScheduler1.ViewElement as SchedulerDayViewElement;
            dayViewElement.DataAreaElement.Ruler.CurrentTimePointerWidth = (int)this.spinEditorPointerWidth.Value;
            dayViewElement.AllDayHeaderHeight = (int)this.spinEditorAllDayHeight.Value;
            dayViewElement.AllDayHeaderElement.MaxHeaderHeight = (int)this.spinEditorAllDayMaxHeight.Value;
            dayViewElement.AppointmentMargin = new Padding((int)this.spinEditorAppointmentSpacing.Value);
            SchedulerWeekView weekView = this.radScheduler1.ActiveView as SchedulerWeekView;
            if (weekView != null)
            {
                weekView.ShowWeekend = this.checkBoxShowWeekend.Checked;
            }

            this.suspendTrackBar = true;
            this.radTrackBar1.Value = 1;
            this.suspendTrackBar = false;

            this.LoadSettings();
        }

        void spinEditorCommon_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewElement dayViewElement = this.radScheduler1.ViewElement as SchedulerDayViewElement;

            if (sender == this.spinEditorAllDayHeight)
            {
                this.spinEditorAllDayMaxHeight.Minimum = this.spinEditorAllDayHeight.Value;
            }

            dayViewElement.AllDayHeaderHeight = (int)this.spinEditorAllDayHeight.Value;
            dayViewElement.AllDayHeaderElement.MaxHeaderHeight = (int)this.spinEditorAllDayMaxHeight.Value; 
            dayViewElement.AppointmentMargin = new Padding((int)this.spinEditorAppointmentSpacing.Value);  
        }

        void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            SchedulerWeekView weekView = this.radScheduler1.ActiveView as SchedulerWeekView;
            if (weekView != null)
            {
                weekView.ShowWeekend = this.checkBoxShowWeekend.Checked;
            }

            dayView.ShowRuler = this.checkBoxShowRuler.Checked;
            dayView.ShowHeader = this.checkBoxShowHeader.Checked;
            dayView.ShowAllDayArea = this.checkBoxShowAllDayArea.Checked;
            this.radScheduler1.EnableExactTimeRendering = this.checkBoxExactTimeRendering.Checked;

            this.spinEditorAllDayHeight.Enabled = dayView.ShowAllDayArea;
            this.spinEditorAllDayMaxHeight.Enabled = dayView.ShowAllDayArea;
            this.spinEditorRulerWidth.Enabled = dayView.ShowRuler;
        }

        void dropDownWorkWeekEnd_SelectedValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.WorkWeekEnd = this.dropDownWorkWeekEnd.SelectedValue is DayOfWeek ? (DayOfWeek)this.dropDownWorkWeekEnd.SelectedValue : DayOfWeek.Friday;
        }

        void dropDownWorkWeekStart_SelectedValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.WorkWeekStart = this.dropDownWorkWeekStart.SelectedValue is DayOfWeek ? (DayOfWeek)this.dropDownWorkWeekStart.SelectedValue : DayOfWeek.Monday;
        }

        void timePickerWorkTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.WorkTime.End = timePickerWorkTimeEnd.Value.Value.TimeOfDay;
        }

        void timePickerWorkTimeStart_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.WorkTime.Start = timePickerWorkTimeStart.Value.Value.TimeOfDay;
        }

        void spinEditorPointerWidth_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewElement dayViewElement = this.radScheduler1.ViewElement as SchedulerDayViewElement;
            dayViewElement.DataAreaElement.Ruler.CurrentTimePointerWidth = (int)this.spinEditorPointerWidth.Value;
        }

        void spinEditorRulerWidth_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.RulerWidth = (int)this.spinEditorRulerWidth.Value;
        }

        void dropDownRangeFactor_SelectedValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.RangeFactor = this.dropDownRangeFactor.SelectedValue is ScaleRange ? (ScaleRange)this.dropDownRangeFactor.SelectedValue : ScaleRange.Hour;
        }

        void spinEditorScaleSize_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.RulerScaleSize = (int)this.spinEditorScaleSize.Value;
        }

        void timePickerRulerStart_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            dayView.RulerStartScale = timePickerRulerStart.Value.Value.Hour;
            dayView.RulerStartScaleMinutes = timePickerRulerStart.Value.Value.Minute;
        }

        void timePickerRulerEnd_ValueChanged(object sender, EventArgs e)
        {
            SchedulerDayViewBase dayView = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (timePickerRulerEnd.Value.Value.Hour == 23 && timePickerRulerEnd.Value.Value.Minute == 59)
            {
                dayView.RulerEndScaleMinutes = 0;
                dayView.RulerEndScale = 24;
            }
            else
            {
                dayView.RulerEndScale = timePickerRulerEnd.Value.Value.Hour;
                dayView.RulerEndScaleMinutes = timePickerRulerEnd.Value.Value.Minute;
            }
        }

        bool suspendTrackBar = false;
        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            int column = this.radScheduler1.SelectionBehavior.CurrentCell.Column;
            if (column >= 0 && !suspendTrackBar)
            {
                ((SchedulerDayViewElement)this.radScheduler1.ViewElement).SetColumnWidth(column, this.radTrackBar1.Value);
            }
        }

        void radScheduler1_CellSelectionChanged(object sender, EventArgs e)
        {
            suspendTrackBar = true;
            int column = this.radScheduler1.SelectionBehavior.CurrentCell.Column;
            if (column >= 0)
            {
                this.radTrackBar1.Value = ((SchedulerDayViewElement)this.radScheduler1.ViewElement).GetColumnWidth(column);
            }

            suspendTrackBar = false;
        }

    }
}
