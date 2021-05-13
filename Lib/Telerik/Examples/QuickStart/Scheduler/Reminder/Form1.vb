Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Scheduler.Dialogs
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Scheduler.Reminder
	Partial Public Class Form1
		Inherits ExamplesForm
		Private customAlarmForm As CustomAlarmForm

		Public Sub New()
			InitializeComponent()

			FillAppointments()

			AddHandler radSchedulerReminder1.ItemOpened, AddressOf radReminder1_ItemOpened
			Me.customAlarmForm = New CustomAlarmForm()

			AddHandler radScheduler1.ThemeNameChanged, AddressOf radScheduler1_ThemeNameChanged

			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
		End Sub

		Private Sub radScheduler1_ThemeNameChanged(ByVal source As Object, ByVal args As ThemeNameChangedEventArgs)
			Me.radSchedulerReminder1.ThemeName = Me.radScheduler1.ThemeName
		End Sub

		Private Sub FillAppointments()
			Me.radScheduler1.Appointments.BeginUpdate()

			Dim dtStart As Date = Date.Now.AddMinutes(-13)
			Dim dtEnd As Date = dtStart.AddHours(1)

			Dim appointment As New Appointment(dtStart, dtEnd, "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.MustAttend))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			appointment.Reminder = TimeSpan.Parse("00:15:00")
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddMinutes(1)
			dtEnd = dtStart.AddHours(1)

			appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.PhoneCall))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			appointment.Reminder = TimeSpan.Parse("00:15:00")
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddMinutes(1)
			dtEnd = dtStart.AddHours(1)

			appointment = New Appointment(dtStart.AddHours(-2), dtEnd.AddHours(4), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.NeedsPreparation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			appointment.Reminder = TimeSpan.Parse("00:15:00")
			Me.radScheduler1.Appointments.Add(appointment)

			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Private Sub radReminder1_ItemOpened(ByVal sender As Object, ByVal e As RadOpenItemArgs)
			Dim editAppointmentDialog As New EditAppointmentDialog(CType(e.RemindObject, IEvent), Me.radScheduler1)
			ThemeResolutionService.ApplyThemeToControlTree(editAppointmentDialog, Me.radScheduler1.ThemeName)
			editAppointmentDialog.ShowDialog()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radSchedulerReminder1.TimeInterval = CInt(Fix(Me.radSpinEditor1.Value)) * 1000

			Me.radLabel1.Enabled = Not Me.radLabel1.Enabled
			Me.radSpinEditor1.Enabled = Not Me.radSpinEditor1.Enabled
			Me.radGroupBox1.Enabled = Not Me.radGroupBox1.Enabled

			If Me.radSpinEditor1.Enabled Then
				Me.radButton1.Text = "Start"
				Me.radSchedulerReminder1.StopReminder()
			Else
				Me.radButton1.Text = "Stop"
				Me.radSchedulerReminder1.StartReminder()
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radButton1_Click(Nothing, Nothing)
		End Sub

		Private Sub radRadioButtonCustom_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				AddHandler radSchedulerReminder1.AlarmFormShowing, AddressOf radSchedulerReminder1_ShowingAlarmForm
			Else
				RemoveHandler radSchedulerReminder1.AlarmFormShowing, AddressOf radSchedulerReminder1_ShowingAlarmForm
			End If
		End Sub

		Private Sub radSchedulerReminder1_ShowingAlarmForm(ByVal sender As Object, ByVal e As RadAlarmFormShowingEventArgs)
			e.AlarmForm = Me.customAlarmForm
		End Sub

		Private Sub radRadioButtonDefault_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radSchedulerReminder1.ResetToDefaultAlarmForm()
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radRadioButtonCustom.ToggleStateChanged, AddressOf radRadioButtonCustom_ToggleStateChanged
			AddHandler radRadioButtonDefault.ToggleStateChanged, AddressOf radRadioButtonDefault_ToggleStateChanged
			AddHandler radButton1.Click, AddressOf radButton1_Click
		End Sub
	End Class
End Namespace
