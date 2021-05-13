Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.MonthView
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.dropDownWorkWeekStart.DataSource = System.Enum.GetValues(GetType(DayOfWeek))
			Me.dropDownWorkWeekEnd.DataSource = System.Enum.GetValues(GetType(DayOfWeek))

			Me.LoadSettings()
			Me.FillAppointments()
			Me.SetToolTips()

			Me.radScheduler1.SelectionBehavior.SelectCell(Me.radScheduler1.ViewElement.GetCellAtPosition(0, 0))
			AddHandler Me.radScheduler1.ActiveViewChanged, AddressOf radScheduler1_ActiveViewChanged
			AddHandler Me.radScheduler1.ActiveViewChanging, AddressOf radScheduler1_ActiveViewChanging
			AddHandler Me.radScheduler1.ActiveView.PropertyChanged, AddressOf ActiveView_PropertyChanged
		End Sub

		Private Sub SetToolTips()
			AddHandler Me.checkBoxVerticalScroll.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to display the vertical scrollbar in MonthView"

			AddHandler Me.checkBoxShowWeeksHeader.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to display the week headers which stay on the left side of each row"

			AddHandler Me.checkBoxEnableWeeksHeader.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to allow the user to navigate to WeekView by clicking on the week headers"

			AddHandler Me.checkBoxAppointmentsScrolling.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to allow displaying scrollbars at the end of each row when there are overflown cells in it"

			AddHandler Me.checkBoxCellsOverflow.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to allow displaying a button at the bottom of the overflown cells which can be used to navigate to DayView"

			AddHandler Me.checkBoxShowFullMonth.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to force the MonthView to always display exactly one month and navigate to the beginning of the previous/next month"

			AddHandler Me.checkBoxShowWeekend.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Uncheck to display only the days from the working week"

			AddHandler Me.checkBoxExactTimeRendering.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to make RadScheduler render the appointments exactly according to their start and end times"

			AddHandler Me.checkBoxAutoSizeAppointments.ToolTipTextNeeded, Sub(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) e.ToolTipText = "Check to make RadScheduler render the appointments with automatic height so that they can fit their content"
		End Sub

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			If Me.radScheduler1.ActiveViewType <> SchedulerViewType.Month Then
				Me.radGroupBox1.Visible = False
				Me.radGroupBox2.Visible = False
				Me.radGroupBox3.Visible = False
				Me.buttonBackToMonthView.Visible = True
			Else
				Me.radGroupBox1.Visible = True
				Me.radGroupBox2.Visible = True
				Me.radGroupBox3.Visible = True
				Me.buttonBackToMonthView.Visible = False
				LoadSettings()
				Me.radScheduler1.SelectionBehavior.SelectCell(Me.radScheduler1.ViewElement.GetCellAtPosition(0, 0))
			End If
		End Sub

		Private Sub radScheduler1_ActiveViewChanging(ByVal sender As Object, ByVal e As SchedulerViewChangingEventArgs)
			RemoveHandler e.OldView.PropertyChanged, AddressOf ActiveView_PropertyChanged
			AddHandler e.NewView.PropertyChanged, AddressOf ActiveView_PropertyChanged
		End Sub

		Private Sub ActiveView_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			If e.PropertyName = "WeekCount" Then
				Me.spinEditorWeekCount.Value = Me.radScheduler1.GetMonthView().WeekCount
			End If
		End Sub

		Private Sub LoadSettings()
			Dim monthView As SchedulerMonthView = TryCast(Me.radScheduler1.ActiveView, SchedulerMonthView)

			Me.checkBoxVerticalScroll.Checked = monthView.ShowVerticalNavigator
			Me.checkBoxShowWeeksHeader.Checked = monthView.ShowWeeksHeader
			Me.checkBoxEnableWeeksHeader.Checked = monthView.EnableWeeksHeader
			Me.checkBoxAppointmentsScrolling.Checked = monthView.EnableAppointmentsScrolling
			Me.checkBoxCellsOverflow.Checked = monthView.EnableCellOverflowButton

			Me.dropDownWorkWeekStart.SelectedValue = monthView.WorkWeekStart
			Me.dropDownWorkWeekEnd.SelectedValue = monthView.WorkWeekEnd
			Me.spinEditorWeekCount.Value = monthView.WeekCount
			Me.checkBoxShowFullMonth.Checked = monthView.ShowFullMonth
			Me.checkBoxShowWeekend.Checked = monthView.ShowWeekend

			Me.checkBoxExactTimeRendering.Checked = Me.radScheduler1.EnableExactTimeRendering
			Me.checkBoxAutoSizeAppointments.Checked = Me.radScheduler1.AutoSizeAppointments
			Me.spinEditorAppointmentSpacing.Value = Me.radScheduler1.ViewElement.AppointmentMargin.Vertical
			Me.trackBarRowSize.Value = 1
			Me.trackBarColumnSize.Value = 1
		End Sub

		Private Sub FillAppointments()
			Me.radScheduler1.Appointments.BeginUpdate()

			Dim dtStart As Date = Date.Today.AddDays(2).AddHours(10)
			Dim dtEnd As Date = Date.Today.AddDays(2).AddHours(12)

			Dim appointment As New Appointment(dtStart, dtEnd, "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.MustAttend))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.PhoneCall))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(-2), dtEnd.AddHours(4), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.NeedsPreparation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.checkBoxVerticalScroll.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxShowWeeksHeader.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxEnableWeeksHeader.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxAppointmentsScrolling.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxCellsOverflow.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged

			AddHandler Me.dropDownWorkWeekStart.SelectedValueChanged, AddressOf dropDownWorkWeek_SelectedValueChanged
			AddHandler Me.dropDownWorkWeekEnd.SelectedValueChanged, AddressOf dropDownWorkWeek_SelectedValueChanged
			AddHandler Me.spinEditorWeekCount.ValueChanged, AddressOf spinEditorWeekCount_ValueChanged
			AddHandler Me.checkBoxShowFullMonth.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxShowWeekend.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged

			AddHandler Me.checkBoxExactTimeRendering.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxAutoSizeAppointments.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.spinEditorAppointmentSpacing.ValueChanged, AddressOf spinEditorAppointmentSpacing_ValueChanged

			AddHandler Me.trackBarRowSize.ValueChanged, AddressOf trackBar_ValueChanged
			AddHandler Me.trackBarColumnSize.ValueChanged, AddressOf trackBar_ValueChanged
			AddHandler Me.radScheduler1.CellSelectionChanged, AddressOf radScheduler1_CellSelectionChanged
		End Sub

		Private Sub spinEditorAppointmentSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radScheduler1.ViewElement.AppointmentMargin = New Padding(CInt(Fix(Me.spinEditorAppointmentSpacing.Value)))
		End Sub

		Private Sub spinEditorWeekCount_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim monthView As SchedulerMonthView = TryCast(Me.radScheduler1.ActiveView, SchedulerMonthView)
			monthView.WeekCount = CInt(Fix(Me.spinEditorWeekCount.Value))
		End Sub

		Private Sub dropDownWorkWeek_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim monthView As SchedulerMonthView = TryCast(Me.radScheduler1.ActiveView, SchedulerMonthView)
			monthView.WorkWeekStart = If(TypeOf Me.dropDownWorkWeekStart.SelectedValue Is DayOfWeek, CType(Me.dropDownWorkWeekStart.SelectedValue, DayOfWeek), DayOfWeek.Monday)
			monthView.WorkWeekEnd = If(TypeOf Me.dropDownWorkWeekEnd.SelectedValue Is DayOfWeek, CType(Me.dropDownWorkWeekEnd.SelectedValue, DayOfWeek), DayOfWeek.Friday)
		End Sub

		Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim monthView As SchedulerMonthView = TryCast(Me.radScheduler1.ActiveView, SchedulerMonthView)

			monthView.ShowVerticalNavigator = Me.checkBoxVerticalScroll.Checked
			monthView.ShowWeeksHeader = Me.checkBoxShowWeeksHeader.Checked
			monthView.EnableWeeksHeader = Me.checkBoxEnableWeeksHeader.Checked
			monthView.EnableAppointmentsScrolling = Me.checkBoxAppointmentsScrolling.Checked
			monthView.EnableCellOverflowButton = Me.checkBoxCellsOverflow.Checked

			monthView.ShowFullMonth = Me.checkBoxShowFullMonth.Checked
			monthView.ShowWeekend = Me.checkBoxShowWeekend.Checked

			Me.radScheduler1.EnableExactTimeRendering = Me.checkBoxExactTimeRendering.Checked
			Me.radScheduler1.AutoSizeAppointments = Me.checkBoxAutoSizeAppointments.Checked
		End Sub

		Private Sub radScheduler1_CellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radScheduler1.ActiveViewType <> SchedulerViewType.Month Then
				Return
			End If

			suspendTrackbars = True
			Dim row As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Row
			Dim column As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Column

			If row >= 0 Then
				Me.trackBarRowSize.Value = (CType(Me.radScheduler1.ViewElement, SchedulerMonthViewElement)).GetRowHeight(row)
			End If
			If column >= 0 Then
				Me.trackBarColumnSize.Value = (CType(Me.radScheduler1.ViewElement, SchedulerMonthViewElement)).GetColumnWidth(column)
			End If

			suspendTrackbars = False
		End Sub

		Private suspendTrackbars As Boolean = False
		Private Sub trackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If suspendTrackbars Then
				Return
			End If
			Dim row As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Row
			Dim column As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Column

			If sender Is Me.trackBarRowSize AndAlso row >= 0 Then
				CType(Me.radScheduler1.ViewElement, SchedulerMonthViewElement).SetRowHeight(row, Me.trackBarRowSize.Value)
			ElseIf sender Is Me.trackBarColumnSize AndAlso column >= 0 Then
				CType(Me.radScheduler1.ViewElement, SchedulerMonthViewElement).SetColumnWidth(column, Me.trackBarColumnSize.Value)
			End If
		End Sub

		Private Sub buttonBackToMonthView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonBackToMonthView.Click
			Me.radScheduler1.ActiveViewType = SchedulerViewType.Month
		End Sub

	End Class
End Namespace
