Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.DayView
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radSchedulerNavigator1.TimelineViewButtonVisible = False
			Me.radSchedulerNavigator1.MonthViewButtonVisible = False
			Me.radSchedulerNavigator1.AgendaViewButtonVisible = False
			Me.radSchedulerNavigator1.ShowWeekendCheckBox.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			Me.dropDownRangeFactor.DataSource = System.Enum.GetValues(GetType(ScaleRange))
			Me.dropDownWorkWeekStart.DataSource = System.Enum.GetValues(GetType(DayOfWeek))
			Me.dropDownWorkWeekEnd.DataSource = System.Enum.GetValues(GetType(DayOfWeek))

			Me.radScheduler1.ViewElement.AppointmentMargin = Padding.Empty

			Me.LoadSettings()
			Me.FillAppointments()

			AddHandler Me.radScheduler1.ActiveViewChanged, AddressOf radScheduler1_ActiveViewChanged
			AddHandler Me.radScheduler1.CellSelectionChanged, AddressOf radScheduler1_CellSelectionChanged
			Me.radScheduler1.SelectionBehavior.SelectCell(Me.radScheduler1.ViewElement.GetCellAtPosition(1, 0))
		End Sub

		Private Sub LoadSettings()
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			Dim weekView As SchedulerWeekView = TryCast(Me.radScheduler1.ActiveView, SchedulerWeekView)
			Dim dayViewElement As SchedulerDayViewElement = TryCast(Me.radScheduler1.ViewElement, SchedulerDayViewElement)

			Me.timePickerRulerStart.Value = Date.Today.Add(TimeSpan.FromHours(dayView.RulerStartScale)).Add(TimeSpan.FromMilliseconds(dayView.RulerStartScaleMinutes))

			Me.timePickerRulerEnd.Value = If(dayView.RulerEndScale = 24, Date.Today.AddHours(23).AddMinutes(59), Date.Today.Add(TimeSpan.FromHours(dayView.RulerEndScale)).Add(TimeSpan.FromMilliseconds(dayView.RulerEndScaleMinutes)))

			Me.spinEditorScaleSize.Value = dayView.RulerScaleSize
			Me.dropDownRangeFactor.SelectedValue = dayView.RangeFactor
			Me.spinEditorRulerWidth.Value = dayView.RulerWidth
			Me.spinEditorPointerWidth.Value = CDec(dayViewElement.DataAreaElement.Ruler.CurrentTimePointerWidth)

			'//

			Me.timePickerWorkTimeStart.Value = Date.Today.Add(dayView.WorkTime.Start)
			Me.timePickerWorkTimeEnd.Value = Date.Today.Add(dayView.WorkTime.End)
			Me.dropDownWorkWeekStart.SelectedValue = dayView.WorkWeekStart
			Me.dropDownWorkWeekEnd.SelectedValue = dayView.WorkWeekEnd

			'//

			Me.checkBoxShowWeekend.Checked = If(weekView IsNot Nothing, weekView.ShowWeekend, False)
			Me.checkBoxShowRuler.Checked = dayView.ShowRuler
			Me.checkBoxShowHeader.Checked = dayView.ShowHeader
			Me.checkBoxShowAllDayArea.Checked = dayView.ShowAllDayArea
			Me.checkBoxExactTimeRendering.Checked = Me.radScheduler1.EnableExactTimeRendering
			Me.spinEditorAllDayHeight.Value = dayViewElement.AllDayHeaderHeight
			Me.spinEditorAllDayMaxHeight.Minimum = Me.spinEditorAllDayHeight.Value
			Me.spinEditorAllDayMaxHeight.Value = dayViewElement.AllDayHeaderElement.MaxHeaderHeight
			Me.spinEditorAppointmentSpacing.Value = dayViewElement.AppointmentMargin.All

			Me.spinEditorAllDayHeight.Enabled = dayView.ShowAllDayArea
			Me.spinEditorAllDayMaxHeight.Enabled = dayView.ShowAllDayArea
			Me.spinEditorRulerWidth.Enabled = dayView.ShowRuler
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

			AddHandler Me.timePickerRulerStart.ValueChanged, AddressOf timePickerRulerStart_ValueChanged
			AddHandler Me.timePickerRulerEnd.ValueChanged, AddressOf timePickerRulerEnd_ValueChanged
			AddHandler Me.spinEditorScaleSize.ValueChanged, AddressOf spinEditorScaleSize_ValueChanged

			AddHandler Me.dropDownRangeFactor.SelectedValueChanged, AddressOf dropDownRangeFactor_SelectedValueChanged
			AddHandler Me.spinEditorRulerWidth.ValueChanged, AddressOf spinEditorRulerWidth_ValueChanged
			AddHandler Me.spinEditorPointerWidth.ValueChanged, AddressOf spinEditorPointerWidth_ValueChanged

			'//

			AddHandler Me.timePickerWorkTimeStart.ValueChanged, AddressOf timePickerWorkTimeStart_ValueChanged
			AddHandler Me.timePickerWorkTimeEnd.ValueChanged, AddressOf timePickerWorkTimeEnd_ValueChanged

			AddHandler Me.dropDownWorkWeekStart.SelectedValueChanged, AddressOf dropDownWorkWeekStart_SelectedValueChanged
			AddHandler Me.dropDownWorkWeekEnd.SelectedValueChanged, AddressOf dropDownWorkWeekEnd_SelectedValueChanged

			'//

			AddHandler Me.checkBoxShowWeekend.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxShowRuler.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxShowHeader.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxShowAllDayArea.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
			AddHandler Me.checkBoxExactTimeRendering.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged

			AddHandler Me.spinEditorAllDayHeight.ValueChanged, AddressOf spinEditorCommon_ValueChanged
			AddHandler Me.spinEditorAllDayMaxHeight.ValueChanged, AddressOf spinEditorCommon_ValueChanged
			AddHandler Me.spinEditorAppointmentSpacing.ValueChanged, AddressOf spinEditorCommon_ValueChanged
		End Sub

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			Dim dayViewElement As SchedulerDayViewElement = TryCast(Me.radScheduler1.ViewElement, SchedulerDayViewElement)
			dayViewElement.DataAreaElement.Ruler.CurrentTimePointerWidth = CInt(Fix(Me.spinEditorPointerWidth.Value))
			dayViewElement.AllDayHeaderHeight = CInt(Fix(Me.spinEditorAllDayHeight.Value))
			dayViewElement.AllDayHeaderElement.MaxHeaderHeight = CInt(Fix(Me.spinEditorAllDayMaxHeight.Value))
			dayViewElement.AppointmentMargin = New Padding(CInt(Fix(Me.spinEditorAppointmentSpacing.Value)))
			Dim weekView As SchedulerWeekView = TryCast(Me.radScheduler1.ActiveView, SchedulerWeekView)
			If weekView IsNot Nothing Then
				weekView.ShowWeekend = Me.checkBoxShowWeekend.Checked
			End If

			Me.suspendTrackBar = True
			Me.radTrackBar1.Value = 1
			Me.suspendTrackBar = False

			Me.LoadSettings()
		End Sub

		Private Sub spinEditorCommon_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayViewElement As SchedulerDayViewElement = TryCast(Me.radScheduler1.ViewElement, SchedulerDayViewElement)

			If sender Is Me.spinEditorAllDayHeight Then
				Me.spinEditorAllDayMaxHeight.Minimum = Me.spinEditorAllDayHeight.Value
			End If

			dayViewElement.AllDayHeaderHeight = CInt(Fix(Me.spinEditorAllDayHeight.Value))
			dayViewElement.AllDayHeaderElement.MaxHeaderHeight = CInt(Fix(Me.spinEditorAllDayMaxHeight.Value))
			dayViewElement.AppointmentMargin = New Padding(CInt(Fix(Me.spinEditorAppointmentSpacing.Value)))
		End Sub

		Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			Dim weekView As SchedulerWeekView = TryCast(Me.radScheduler1.ActiveView, SchedulerWeekView)
			If weekView IsNot Nothing Then
				weekView.ShowWeekend = Me.checkBoxShowWeekend.Checked
			End If

			dayView.ShowRuler = Me.checkBoxShowRuler.Checked
			dayView.ShowHeader = Me.checkBoxShowHeader.Checked
			dayView.ShowAllDayArea = Me.checkBoxShowAllDayArea.Checked
			Me.radScheduler1.EnableExactTimeRendering = Me.checkBoxExactTimeRendering.Checked

			Me.spinEditorAllDayHeight.Enabled = dayView.ShowAllDayArea
			Me.spinEditorAllDayMaxHeight.Enabled = dayView.ShowAllDayArea
			Me.spinEditorRulerWidth.Enabled = dayView.ShowRuler
		End Sub

		Private Sub dropDownWorkWeekEnd_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.WorkWeekEnd = If(TypeOf Me.dropDownWorkWeekEnd.SelectedValue Is DayOfWeek, CType(Me.dropDownWorkWeekEnd.SelectedValue, DayOfWeek), DayOfWeek.Friday)
		End Sub

		Private Sub dropDownWorkWeekStart_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.WorkWeekStart = If(TypeOf Me.dropDownWorkWeekStart.SelectedValue Is DayOfWeek, CType(Me.dropDownWorkWeekStart.SelectedValue, DayOfWeek), DayOfWeek.Monday)
		End Sub

		Private Sub timePickerWorkTimeEnd_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.WorkTime.End = timePickerWorkTimeEnd.Value.Value.TimeOfDay
		End Sub

		Private Sub timePickerWorkTimeStart_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.WorkTime.Start = timePickerWorkTimeStart.Value.Value.TimeOfDay
		End Sub

		Private Sub spinEditorPointerWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayViewElement As SchedulerDayViewElement = TryCast(Me.radScheduler1.ViewElement, SchedulerDayViewElement)
			dayViewElement.DataAreaElement.Ruler.CurrentTimePointerWidth = CInt(Fix(Me.spinEditorPointerWidth.Value))
		End Sub

		Private Sub spinEditorRulerWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.RulerWidth = CInt(Fix(Me.spinEditorRulerWidth.Value))
		End Sub

		Private Sub dropDownRangeFactor_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.RangeFactor = If(TypeOf Me.dropDownRangeFactor.SelectedValue Is ScaleRange, CType(Me.dropDownRangeFactor.SelectedValue, ScaleRange), ScaleRange.Hour)
		End Sub

		Private Sub spinEditorScaleSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.RulerScaleSize = CInt(Fix(Me.spinEditorScaleSize.Value))
		End Sub

		Private Sub timePickerRulerStart_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			dayView.RulerStartScale = timePickerRulerStart.Value.Value.Hour
			dayView.RulerStartScaleMinutes = timePickerRulerStart.Value.Value.Minute
		End Sub

		Private Sub timePickerRulerEnd_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If timePickerRulerEnd.Value.Value.Hour = 23 AndAlso timePickerRulerEnd.Value.Value.Minute = 59 Then
				dayView.RulerEndScaleMinutes = 0
				dayView.RulerEndScale = 24
			Else
				dayView.RulerEndScale = timePickerRulerEnd.Value.Value.Hour
				dayView.RulerEndScaleMinutes = timePickerRulerEnd.Value.Value.Minute
			End If
		End Sub

		Private suspendTrackBar As Boolean = False
		Private Sub radTrackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTrackBar1.ValueChanged
			Dim column As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Column
			If column >= 0 AndAlso (Not suspendTrackBar) Then
				CType(Me.radScheduler1.ViewElement, SchedulerDayViewElement).SetColumnWidth(column, Me.radTrackBar1.Value)
			End If
		End Sub

		Private Sub radScheduler1_CellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			suspendTrackBar = True
			Dim column As Integer = Me.radScheduler1.SelectionBehavior.CurrentCell.Column
			If column >= 0 Then
				Me.radTrackBar1.Value = (CType(Me.radScheduler1.ViewElement, SchedulerDayViewElement)).GetColumnWidth(column)
			End If

			suspendTrackBar = False
		End Sub

	End Class
End Namespace
