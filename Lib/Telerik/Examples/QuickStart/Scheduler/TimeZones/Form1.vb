Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.TimeZones
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radScheduler1.ActiveView.StartDate = Date.Today

			FillAppointments()

			AddHandler radScheduler1.ActiveViewChanged, AddressOf radScheduler1_ActiveViewChanged

			Me.InitializeTimeZones()

			Me.radScheduler1.GetDayView().RulerWidth = 55

			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1
		End Sub

		Private Sub InitializeTimeZones()
			Dim listOfTimeZones As List(Of SchedulerTimeZone) = SchedulerTimeZone.GetSchedulerTimeZones()

			For Each timezone As SchedulerTimeZone In listOfTimeZones
				timezone.Label = timezone.Label.Replace("(", String.Empty)
				timezone.Label = timezone.Label.Replace(")", String.Empty)
			Next timezone

			Me.radDropDownList2.DataSource = New List(Of SchedulerTimeZone)(listOfTimeZones)
		End Sub

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As SchedulerViewChangedEventArgs)
			If e.NewView.ViewType <> e.OldView.ViewType Then
				Dim view As SchedulerDayViewBase = TryCast(e.NewView, SchedulerDayViewBase)
				If view IsNot Nothing Then
					UpdateControls(True)
					view.RulerWidth = 55
				Else
					UpdateControls(False)
				End If

				e.NewView.DefaultTimeZone = e.OldView.DefaultTimeZone
			End If
		End Sub

		Private Sub UpdateControls(ByVal isDayView As Boolean)
			Me.radButton2.Visible = isDayView
			Me.radLabel2.Visible = isDayView
			Me.radDropDownList2.Visible = isDayView
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

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim view As SchedulerDayViewBase = TryCast(Me.radScheduler1.ActiveView, SchedulerDayViewBase)
			If view IsNot Nothing Then
				Dim schedulerTimeZone As SchedulerTimeZone = TryCast(Me.radDropDownList2.SelectedValue, SchedulerTimeZone)
				If Not view.TimeZones.Contains(schedulerTimeZone) Then
					view.TimeZones.Add(schedulerTimeZone)
				End If
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButton2.Click, AddressOf radButton2_Click
		End Sub
	End Class
End Namespace
