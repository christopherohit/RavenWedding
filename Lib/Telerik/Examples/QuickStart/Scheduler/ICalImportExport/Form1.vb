Imports Telerik.QuickStart.WinControls
Imports System.IO
Imports Telerik.WinControls.UI.Scheduler.ICalendar
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.ICalImportExport
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			AddHandler radButton1.Click, AddressOf radButton1_Click
			AddHandler radButton2.Click, AddressOf radButton2_Click
			Me.radScheduler1.GetDayView().DayCount = 3
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.AddExtension = True
			openFileDialog.DefaultExt = ".ics"
			openFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*"
			openFileDialog.Multiselect = False

			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Using fileStream As FileStream = File.OpenRead(openFileDialog.FileName)
					Me.radScheduler1.Import(fileStream, New SchedulerICalendarImporter())
				End Using
			End If
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.AddExtension = True
			saveFileDialog.DefaultExt = ".xml"
			saveFileDialog.Filter = "iCal files (*.ics)|*.ics|All files (*.*)|*.*"

			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Using fileStream As FileStream = File.Create(saveFileDialog.FileName)
					Me.radScheduler1.Export(fileStream, New SchedulerICalendarExporter())
				End Using
			End If
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.radScheduler1.ActiveView.StartDate = Date.Now.Date

			FillAppointments()
		End Sub

		Private Sub FillAppointments()
			Me.radScheduler1.Appointments.BeginUpdate()

			Dim dtStart As Date = Date.Now.Date.AddDays(2).AddHours(10)
			Dim dtEnd As Date = Date.Now.Date.AddDays(2).AddHours(12)

			Dim appointment As New Appointment(dtStart.AddHours(-1), dtEnd.AddHours(8), "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
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

			appointment = New Appointment(dtStart, dtEnd.AddHours(4), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.NeedsPreparation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
