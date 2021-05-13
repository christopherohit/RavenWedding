Imports Telerik.QuickStart.WinControls
Imports My
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Scheduler.Dialogs

Namespace Telerik.Examples.WinControls.PageView.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Private openedAlerts As New List(Of IRemindObject)()
		Public Sub New()
			InitializeComponent()

			Me.radPageViewPage1.Image = Resources.OutlookViewNotes
			Me.radPageViewPage2.Image = Resources.OutlookViewTasks
			Me.radPageViewPage3.Image = Resources.OutlookViewContacts
			Me.radPageViewPage4.Image = Resources.OutlookViewCalendar
			Me.radPageViewPage6.Image = Resources.OutlookViewMail

			ApplySchedulerSettings()

			Me.radSchedulerNavigator1.AssociatedScheduler = Me.radScheduler1

			'this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			'this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		End Sub

		Private Sub ApplySchedulerSettings()
			Me.radScheduler1.ActiveView.StartDate = Date.Now.Date

			FillAppointments()

			Me.radSchedulerReminder1.AssociatedScheduler = Me.radScheduler1
			AddHandler radSchedulerReminder1.AlarmFormShowing, AddressOf radSchedulerReminder1_AlarmFormShowing
			AddHandler radSchedulerReminder1.RemindObjectShown, AddressOf radSchedulerReminder1_RemindObjectShown
			Me.radSchedulerReminder1.StartReminderInterval = Me.radScheduler1.ActiveView.StartDate
			Me.radSchedulerReminder1.EndReminderInterval = DateHelper.GetEndOfDay(Me.radScheduler1.ActiveView.StartDate)
			Me.radSchedulerReminder1.StartReminder()
		End Sub

		Private Sub radSchedulerReminder1_RemindObjectShown(ByVal sender As Object, ByVal e As RadShowRemindObjectArgs)
			If Me.openedAlerts.Contains(e.RemindObject) Then
				Return
			End If
			Dim radDesktopAlert As New Telerik.WinControls.UI.RadDesktopAlert(Me.components)

			Dim radButtonElement As New RadButtonElement()
			AddHandler radButtonElement.Click, AddressOf radButtonElement_Click
			radButtonElement.Tag = e.RemindObject
			radButtonElement.Image = My.Resources.EditTask16

			Me.openedAlerts.Add(e.RemindObject)

			radDesktopAlert.ButtonItems.Add(radButtonElement)
			radDesktopAlert.ThemeName = If(Me.radScheduler1.ThemeName = "", Me.GetExampleDefaultTheme(), Me.radScheduler1.ThemeName)
			radDesktopAlert.FixedSize = New Size(329, 120)
			radDesktopAlert.ContentImage = My.Resources.Reminder48
			radDesktopAlert.ContentText = "<html><I>" & (CType(e.RemindObject, Appointment)).Description & "</I></html>"
			radDesktopAlert.CaptionText = e.RemindObject.Subject
			radDesktopAlert.Show()
			RemoveHandler radDesktopAlert.Closed, AddressOf radDesktopAlert_AlertClosed
			AddHandler radDesktopAlert.Closed, AddressOf radDesktopAlert_AlertClosed
		End Sub

		Private Sub radDesktopAlert_AlertClosed(ByVal sender As Object, ByVal args As RadPopupClosedEventArgs)
			Dim radDesktopAlert As Telerik.WinControls.UI.RadDesktopAlert = TryCast(sender, Telerik.WinControls.UI.RadDesktopAlert)
			Me.openedAlerts.Remove(CType(radDesktopAlert.ButtonItems(0).Tag, IRemindObject))
		End Sub

		Private Sub radButtonElement_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim radButtonElement As RadButtonElement = TryCast(sender, RadButtonElement)
			Dim editAppointmentDialog As New EditAppointmentDialog(CType(radButtonElement.Tag, IEvent), Me.radScheduler1)
			editAppointmentDialog.ShowDialog(Me)
		End Sub

		Private Sub radSchedulerReminder1_AlarmFormShowing(ByVal sender As Object, ByVal e As RadAlarmFormShowingEventArgs)
			e.AlarmForm = Nothing
		End Sub

		Private Sub FillAppointments()
			Dim dtStart As Date = Date.Now.Date.AddHours(9)
			Dim dtEnd As Date = Date.Now.Date.AddHours(12)

			Dim appointment As New Appointment(dtStart, dtEnd.AddHours(8), "ASP.NET AJAX Or Silverlight Is The Future Of Web Development", "Understanding the future is critical for web developers. Decisions you make today need to be aware of what's coming if you're going to be successful on web. In this session, we'll examine ASP.NET AJAX and Silverlight to gain a deep understanding of how these technologies can help us solve the problems of a rich, ajaxified Internet. From the rich client-side library in ASP.NETAJAX that changes the way you write JavaScript to the power of .NET in the browser with Silverlight, understanding how to leverage these technologies is key for future ASP.NET applications. We'll also examine the future of web browsers and seek to understand how they will affect the applications we build")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Anniversary))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			appointment.Reminder = TimeSpan.FromMinutes(15)
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(1)
			dtEnd = dtEnd.AddDays(1)

			appointment = New Appointment(dtStart.AddHours(2), dtEnd.AddHours(3), "Silverlight Made Easy", "This session will introduce people to Silverlight with coding in C# and VB.NET to build high quality, robust and elegant web sites.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Business))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			appointment.Reminder = TimeSpan.FromMinutes(15)
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(1)
			dtEnd = dtEnd.AddDays(1)

			appointment = New Appointment(dtStart, dtEnd.AddHours(4), "SQL 2008", "SQL Server 2008 introduces support for Microsoft PowerShell. PowerShell is a powerful scripting shell that lets administrators and developers automate server administration and application deployment. It is more powerful than simple T-SQL and provides great features to SQL Server administrator. This session will cover the basics of the SQL Server providers in PowerShell.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.NeedsPreparation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			appointment.Reminder = TimeSpan.FromMinutes(15)
			Me.radScheduler1.Appointments.Add(appointment)
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
