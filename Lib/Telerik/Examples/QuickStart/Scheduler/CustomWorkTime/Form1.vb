Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.CustomWorkTime
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.radSchedulerNavigator1.AgendaViewButtonVisible = False
			Me.radDropDownList1.DataSource = System.Enum.GetValues(GetType(DayOfWeek))
			Me.radDropDownList2.DataSource = System.Enum.GetValues(GetType(DayOfWeek))
			Me.radDropDownList1.SelectedValue = DayOfWeek.Monday
			Me.radDropDownList2.SelectedValue = DayOfWeek.Friday

			Me.radScheduler1.ActiveView.StartDate = Date.Now.Date

			SetDateTimePickersDefaultValues()
			FillAppointments()

			Me.radSchedulerNavigator1.TimelineViewButtonVisible = False
			Me.radSchedulerNavigator1.MonthViewButtonVisible = False

			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1

			Dim exceptionRule As New WorkTimeExceptionRule()
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				exceptionRule.ExceptionStartDate = Date.Now.Date
				exceptionRule.ExceptionEndDate = Date.Now.Date.AddHours(24)
				exceptionRule.StartTime = New TimeSpan(10,0,0)
				exceptionRule.EndTime = New TimeSpan(12,0,0)
				view.WorkTimeExceptions.Add(exceptionRule)
			End If

			UpdateRuler()
			UpdateWorkTime()
			LoadSettings()
		End Sub

		Private Sub LoadSettings()
			Dim dayView As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			Me.radSpinEditor1.Value = dayView.RulerStartScale
			Me.radSpinEditor2.Value = dayView.RulerStartScaleMinutes
			Me.radSpinEditor3.Value = dayView.RulerEndScaleMinutes
			Me.radSpinEditor4.Value = dayView.RulerEndScale
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			ScrollToWorkTime()
		End Sub

		Private Sub ScrollToWorkTime()
			Dim dayViewElement As SchedulerDayViewElement = (TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewElement))
			Dim time As New TimeSpan(Me.radDateTimePicker1.Value.Hour - 1, Me.radDateTimePicker1.Value.Minute, 0)
			dayViewElement.DataAreaElement.Table.ScrollToTime(time)
		End Sub

		Private Sub FillAppointments()
			Me.radScheduler1.Appointments.BeginUpdate()

			Dim dtStart As Date = Date.Now.Date.AddDays(2).AddHours(10)
			Dim dtEnd As Date = Date.Now.Date.AddDays(2).AddHours(12)

			Dim appointment As New Appointment(dtStart, dtEnd, "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Anniversary))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Business))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(-1)
			dtEnd = dtEnd.AddDays(-1)

			appointment = New Appointment(dtStart.AddHours(4), dtEnd.AddHours(4), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Important))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Private Sub DateTimePickerElement_ValueChanging1(ByVal sender As Object, ByVal e As ValueChangingEventArgs)
			If CDate(e.NewValue) >= Me.radDateTimePicker2.Value Then
				e.Cancel = True
			End If
		End Sub

		Private Sub DateTimePickerElement_ValueChanging2(ByVal sender As Object, ByVal e As ValueChangingEventArgs)
			If CDate(e.NewValue) <= Me.radDateTimePicker1.Value Then
				e.Cancel = True
			End If
		End Sub

		Private Sub SetDateTimePickersDefaultValues()
			Dim dtStart As New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 9, 0, 0)

			Me.radDateTimePicker1.Value = dtStart

			Dim dtEnd As New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day, 14, 0, 0)

			Me.radDateTimePicker2.Value = dtEnd
		End Sub

		Private Sub radDateTimePicker_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateWorkTime()
		End Sub

		Private Sub UpdateRuler()
			Dim ruler As RulerPrimitive = (TryCast(Me.radScheduler1.SchedulerElement.ViewElement, SchedulerDayViewElement)).DataAreaElement.Ruler
			ruler.FormatStrings = New RulerFormatStrings("hh", "mm", "", "mm")
		End Sub

		Private Sub UpdateWorkTime()
			Dim timeInterval As New TimeInterval(Me.radDateTimePicker1.Value.TimeOfDay, Me.radDateTimePicker2.Value.TimeOfDay)
			CType(Me.radScheduler1.ActiveView, SchedulerDayViewBase).WorkTime = timeInterval
		End Sub

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			If e.NewView.ViewType = e.OldView.ViewType Then
				Return
			End If

			Select Case Me.radScheduler1.ActiveViewType
				Case SchedulerViewType.Day
					Me.radScheduler1.GetDayView().DayCount = 3
					Me.radGroupBox1.Enabled = True
					UpdateWorkTime()
					ScrollToWorkTime()
					UpdateRuler()
				Case SchedulerViewType.Week, SchedulerViewType.WorkWeek
					Me.radGroupBox1.Enabled = True
					UpdateWorkTime()
					ScrollToWorkTime()
					UpdateRuler()
				Case Else
					Me.radGroupBox1.Enabled = False
			End Select

			LoadSettings()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.radDateTimePicker1.ValueChanging, AddressOf DateTimePickerElement_ValueChanging1
			AddHandler Me.radDateTimePicker2.ValueChanging, AddressOf DateTimePickerElement_ValueChanging2
			AddHandler Me.radDateTimePicker2.ValueChanged, AddressOf radDateTimePicker_ValueChanged
			AddHandler Me.radDateTimePicker1.ValueChanged, AddressOf radDateTimePicker_ValueChanged
			AddHandler Me.radScheduler1.ActiveViewChanged, AddressOf radScheduler1_ActiveViewChanged
			AddHandler Me.radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler Me.radDropDownList2.SelectedIndexChanged, AddressOf radDropDownList2_SelectedIndexChanged
		End Sub

		Private Sub radDropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				view.WorkWeekEnd = CType(Me.radDropDownList2.Items(e.Position).Value, DayOfWeek)
			End If
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				view.WorkWeekStart = CType(Me.radDropDownList1.Items(e.Position).Value, DayOfWeek)
			End If
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor1.ValueChanged
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				view.RulerStartScale = CInt(Fix(Me.radSpinEditor1.Value))
			End If
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor2.ValueChanged
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				view.RulerStartScaleMinutes = CInt(Fix(Me.radSpinEditor2.Value))
			End If
		End Sub

		Private Sub radSpinEditor3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor3.ValueChanged
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				view.RulerEndScaleMinutes = CInt(Fix(Me.radSpinEditor3.Value))
			End If
		End Sub

		Private Sub radSpinEditor4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radSpinEditor4.ValueChanged
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				view.RulerEndScale = CInt(Fix(Me.radSpinEditor4.Value))
				If view.RulerEndScale = 24 OrElse CInt(Fix(Me.radSpinEditor4.Value)) = 24 Then
					Me.radSpinEditor3.Value = 0
					Me.radSpinEditor3.Enabled = False
				Else
					Me.radSpinEditor3.Enabled = True
				End If
			End If
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				Dim workTimeExceptionsForm As New RadForm()
				workTimeExceptionsForm.Size = New Size(1000, 200)

				Dim grid As New RadGridView()
				workTimeExceptionsForm.Controls.Add(grid)
				Dim themeName As String = If(Me.radScheduler1.ThemeName = "", Me.GetExampleDefaultTheme(), Me.radScheduler1.ThemeName)
				ThemeResolutionService.ApplyThemeToControlTree(workTimeExceptionsForm, themeName)
				grid.Dock = DockStyle.Fill
				grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
				grid.BindingContext = New BindingContext()
				grid.DataSource = view.WorkTimeExceptions
				grid.Columns("ResourceId").IsVisible = False
				grid.Columns("ExceptionStartDate").FormatString = "{0:D}"
				grid.Columns("ExceptionEndDate").FormatString = "{0:D}"
				grid.Columns("StartTime").DataTypeConverter = New MyTypeConverter()
				grid.Columns("EndTime").DataTypeConverter = New MyTypeConverter()
				AddHandler grid.EditorRequired, AddressOf grid_EditorRequired
				AddHandler grid.DefaultValuesNeeded, AddressOf grid_DefaultValuesNeeded
				workTimeExceptionsForm.Show()
			End If
		End Sub

		Private Sub grid_DefaultValuesNeeded(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
			e.Row.Cells("StartTime").Value = New TimeSpan(0,0,0)
			e.Row.Cells("EndTime").Value = New TimeSpan(23,0,0)
		End Sub

		Private Sub grid_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
			Dim editMgr As GridViewEditManager = TryCast(sender, GridViewEditManager)
			If editMgr.GridViewElement.CurrentColumn.Name = "StartTime" OrElse editMgr.GridViewElement.CurrentColumn.Name = "EndTime" Then
				Dim editor As New GridTimePickerEditor()
				Dim editorElement As RadTimePickerElement = (TryCast(editor.EditorElement, RadTimePickerElement))
				editorElement.Culture = New System.Globalization.CultureInfo("en-GB")
				editorElement.PopupMinSize = New Size(0, 320)
				e.Editor = editor
			End If
		End Sub
	End Class
End Namespace