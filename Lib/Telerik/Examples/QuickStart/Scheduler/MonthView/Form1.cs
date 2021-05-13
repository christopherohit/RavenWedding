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

namespace Telerik.Examples.WinControls.Scheduler.MonthView
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            
            this.dropDownWorkWeekStart.DataSource = Enum.GetValues(typeof(DayOfWeek));
            this.dropDownWorkWeekEnd.DataSource = Enum.GetValues(typeof(DayOfWeek));

            this.LoadSettings();
            this.FillAppointments();
            this.SetToolTips();

            this.radScheduler1.SelectionBehavior.SelectCell(this.radScheduler1.ViewElement.GetCellAtPosition(0, 0));
            this.radScheduler1.ActiveViewChanged += radScheduler1_ActiveViewChanged;
            this.radScheduler1.ActiveViewChanging += radScheduler1_ActiveViewChanging;
            this.radScheduler1.ActiveView.PropertyChanged += ActiveView_PropertyChanged;
        }

        private void SetToolTips()
        {
            this.checkBoxVerticalScroll.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to display the vertical scrollbar in MonthView"; };

            this.checkBoxShowWeeksHeader.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to display the week headers which stay on the left side of each row"; };

            this.checkBoxEnableWeeksHeader.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to allow the user to navigate to WeekView by clicking on the week headers"; };

            this.checkBoxAppointmentsScrolling.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to allow displaying scrollbars at the end of each row when there are overflown cells in it"; };

            this.checkBoxCellsOverflow.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to allow displaying a button at the bottom of the overflown cells which can be used to navigate to DayView"; };

            this.checkBoxShowFullMonth.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to force the MonthView to always display exactly one month and navigate to the beginning of the previous/next month"; };

            this.checkBoxShowWeekend.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Uncheck to display only the days from the working week"; };

            this.checkBoxExactTimeRendering.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to make RadScheduler render the appointments exactly according to their start and end times"; };

            this.checkBoxAutoSizeAppointments.ToolTipTextNeeded += delegate(object sender, Telerik.WinControls.ToolTipTextNeededEventArgs e) 
            { e.ToolTipText = "Check to make RadScheduler render the appointments with automatic height so that they can fit their content"; };
        }

        void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (this.radScheduler1.ActiveViewType != SchedulerViewType.Month)
            {
                this.radGroupBox1.Visible = false;
                this.radGroupBox2.Visible = false;
                this.radGroupBox3.Visible = false;
                this.buttonBackToMonthView.Visible = true;
            }
            else
            {
                this.radGroupBox1.Visible = true;
                this.radGroupBox2.Visible = true;
                this.radGroupBox3.Visible = true;
                this.buttonBackToMonthView.Visible = false;
                LoadSettings();
                this.radScheduler1.SelectionBehavior.SelectCell(this.radScheduler1.ViewElement.GetCellAtPosition(0, 0));
            }
        }

        void radScheduler1_ActiveViewChanging(object sender, SchedulerViewChangingEventArgs e)
        {
            e.OldView.PropertyChanged -= ActiveView_PropertyChanged;
            e.NewView.PropertyChanged += ActiveView_PropertyChanged;
        }

        void ActiveView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "WeekCount")
            {
                this.spinEditorWeekCount.Value = this.radScheduler1.GetMonthView().WeekCount;
            }
        }

        private void LoadSettings()
        {
            SchedulerMonthView monthView = this.radScheduler1.ActiveView as SchedulerMonthView;

            this.checkBoxVerticalScroll.Checked = monthView.ShowVerticalNavigator;
            this.checkBoxShowWeeksHeader.Checked = monthView.ShowWeeksHeader;
            this.checkBoxEnableWeeksHeader.Checked = monthView.EnableWeeksHeader;
            this.checkBoxAppointmentsScrolling.Checked = monthView.EnableAppointmentsScrolling;
            this.checkBoxCellsOverflow.Checked = monthView.EnableCellOverflowButton;

            this.dropDownWorkWeekStart.SelectedValue = monthView.WorkWeekStart;
            this.dropDownWorkWeekEnd.SelectedValue = monthView.WorkWeekEnd;
            this.spinEditorWeekCount.Value = monthView.WeekCount;
            this.checkBoxShowFullMonth.Checked = monthView.ShowFullMonth;
            this.checkBoxShowWeekend.Checked = monthView.ShowWeekend;

            this.checkBoxExactTimeRendering.Checked = this.radScheduler1.EnableExactTimeRendering;
            this.checkBoxAutoSizeAppointments.Checked = this.radScheduler1.AutoSizeAppointments;
            this.spinEditorAppointmentSpacing.Value = this.radScheduler1.ViewElement.AppointmentMargin.Vertical;
            this.trackBarRowSize.Value = 1;
            this.trackBarColumnSize.Value = 1;
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

            this.checkBoxVerticalScroll.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxShowWeeksHeader.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxEnableWeeksHeader.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxAppointmentsScrolling.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxCellsOverflow.ToggleStateChanged += checkBox_ToggleStateChanged;

            this.dropDownWorkWeekStart.SelectedValueChanged += dropDownWorkWeek_SelectedValueChanged;
            this.dropDownWorkWeekEnd.SelectedValueChanged += dropDownWorkWeek_SelectedValueChanged;
            this.spinEditorWeekCount.ValueChanged += spinEditorWeekCount_ValueChanged;
            this.checkBoxShowFullMonth.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxShowWeekend.ToggleStateChanged += checkBox_ToggleStateChanged;

            this.checkBoxExactTimeRendering.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.checkBoxAutoSizeAppointments.ToggleStateChanged += checkBox_ToggleStateChanged;
            this.spinEditorAppointmentSpacing.ValueChanged += spinEditorAppointmentSpacing_ValueChanged;

            this.trackBarRowSize.ValueChanged += trackBar_ValueChanged;
            this.trackBarColumnSize.ValueChanged += trackBar_ValueChanged;
            this.radScheduler1.CellSelectionChanged += radScheduler1_CellSelectionChanged;
        }

        void spinEditorAppointmentSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radScheduler1.ViewElement.AppointmentMargin = new Padding((int)this.spinEditorAppointmentSpacing.Value);
        }

        void spinEditorWeekCount_ValueChanged(object sender, EventArgs e)
        {
            SchedulerMonthView monthView = this.radScheduler1.ActiveView as SchedulerMonthView;
            monthView.WeekCount = (int)this.spinEditorWeekCount.Value;
        }

        void dropDownWorkWeek_SelectedValueChanged(object sender, EventArgs e)
        {
            SchedulerMonthView monthView = this.radScheduler1.ActiveView as SchedulerMonthView;
            monthView.WorkWeekStart = this.dropDownWorkWeekStart.SelectedValue is DayOfWeek ? (DayOfWeek)this.dropDownWorkWeekStart.SelectedValue : DayOfWeek.Monday;
            monthView.WorkWeekEnd = this.dropDownWorkWeekEnd.SelectedValue is DayOfWeek ? (DayOfWeek)this.dropDownWorkWeekEnd.SelectedValue : DayOfWeek.Friday;
        }

        void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            SchedulerMonthView monthView = this.radScheduler1.ActiveView as SchedulerMonthView;

            monthView.ShowVerticalNavigator = this.checkBoxVerticalScroll.Checked;
            monthView.ShowWeeksHeader = this.checkBoxShowWeeksHeader.Checked;
            monthView.EnableWeeksHeader = this.checkBoxEnableWeeksHeader.Checked;
            monthView.EnableAppointmentsScrolling = this.checkBoxAppointmentsScrolling.Checked;
            monthView.EnableCellOverflowButton = this.checkBoxCellsOverflow.Checked;

            monthView.ShowFullMonth = this.checkBoxShowFullMonth.Checked;
            monthView.ShowWeekend = this.checkBoxShowWeekend.Checked;

            this.radScheduler1.EnableExactTimeRendering = this.checkBoxExactTimeRendering.Checked;
            this.radScheduler1.AutoSizeAppointments = this.checkBoxAutoSizeAppointments.Checked;
        }

        void radScheduler1_CellSelectionChanged(object sender, EventArgs e)
        {
            if (this.radScheduler1.ActiveViewType != SchedulerViewType.Month)
            {
                return;
            }

            suspendTrackbars = true;
            int row = this.radScheduler1.SelectionBehavior.CurrentCell.Row;
            int column = this.radScheduler1.SelectionBehavior.CurrentCell.Column;

            if (row >= 0)
            {
                this.trackBarRowSize.Value = ((SchedulerMonthViewElement)this.radScheduler1.ViewElement).GetRowHeight(row);
            }
            if (column >= 0)
            {
                this.trackBarColumnSize.Value = ((SchedulerMonthViewElement)this.radScheduler1.ViewElement).GetColumnWidth(column);
            }

            suspendTrackbars = false;
        }

        bool suspendTrackbars = false;
        void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (suspendTrackbars)
            {
                return;
            }
            int row = this.radScheduler1.SelectionBehavior.CurrentCell.Row;
            int column = this.radScheduler1.SelectionBehavior.CurrentCell.Column;

            if (sender == this.trackBarRowSize && row >= 0)
            {
                ((SchedulerMonthViewElement)this.radScheduler1.ViewElement).SetRowHeight(row, this.trackBarRowSize.Value);
            }
            else if (sender == this.trackBarColumnSize && column >= 0)
            {
                ((SchedulerMonthViewElement)this.radScheduler1.ViewElement).SetColumnWidth(column, this.trackBarColumnSize.Value);
            }
        }

        private void buttonBackToMonthView_Click(object sender, EventArgs e)
        {
            this.radScheduler1.ActiveViewType = SchedulerViewType.Month;
        }

    }
}
