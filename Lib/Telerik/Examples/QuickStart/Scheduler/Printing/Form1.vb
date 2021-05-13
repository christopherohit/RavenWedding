Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.Printing
	Partial Public Class Form1
		Inherits ExamplesForm
		Private suspendRadioButtons As Boolean = False

		Public Sub New()
			InitializeComponent()
			FillAppointments()
			Me.radScheduler1.ActiveViewType = SchedulerViewType.Week
		End Sub

		Private Sub buttonPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radScheduler1.Print(True, Me.radPrintDocument1)
		End Sub

		Private Sub buttonPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New RadPrintPreviewDialog()
			dialog.ThemeName = Me.radScheduler1.ThemeName
			dialog.Document = Me.radPrintDocument1
			dialog.ShowDialog()

			Me.UpdateSelectedStyle()
		End Sub

		Private Sub buttonSettings_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New SchedulerPrintSettingsDialog()
			dialog.ThemeName = Me.radScheduler1.ThemeName
			dialog.PrintDocument = Me.radPrintDocument1

			If dialog.ShowDialog() = DialogResult.OK Then
				buttonPreview_Click(sender, e)
			Else
				Me.UpdateSelectedStyle()
			End If
		End Sub

		Private Sub radScheduler1_ActiveViewChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.SchedulerViewChangedEventArgs)
			Select Case Me.radScheduler1.ActiveViewType
				Case SchedulerViewType.Day
					radioDaily.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
				Case SchedulerViewType.Week
					radioWeekly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
				Case SchedulerViewType.Month
					radioMonthly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
				Case SchedulerViewType.Timeline
					radioDetails.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
				Case SchedulerViewType.Agenda
					radioAgenda.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			End Select
		End Sub

		Private Sub radio_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState <> Telerik.WinControls.Enumerations.ToggleState.On OrElse suspendRadioButtons Then
				Return
			End If

			If sender Is Me.radioDaily Then
				Me.radScheduler1.ActiveViewType = SchedulerViewType.Day
				Me.radScheduler1.PrintStyle = New SchedulerDailyPrintStyle(Me.radScheduler1.ActiveView.StartDate, Date.Now)
			ElseIf sender Is Me.radioWeekly Then
				Me.radScheduler1.ActiveViewType = SchedulerViewType.Week
				Dim startDate As Date = DateHelper.GetStartOfWeek(Me.radScheduler1.ActiveView.EndDate, Me.radScheduler1.DateTimeFormat, DayOfWeek.Monday)
				Dim endDate As Date = DateHelper.GetEndOfWeek(startDate, Me.radScheduler1.DateTimeFormat, DayOfWeek.Monday).AddDays(-1)
				Me.radScheduler1.PrintStyle = New SchedulerWeeklyPrintStyle(startDate, endDate)
			ElseIf sender Is Me.radioWeeklyCalendar Then
				Me.radScheduler1.ActiveViewType = SchedulerViewType.Week
				Dim startDate As Date = DateHelper.GetStartOfWeek(Me.radScheduler1.ActiveView.EndDate, Me.radScheduler1.DateTimeFormat, DayOfWeek.Monday)
				Dim endDate As Date = DateHelper.GetEndOfWeek(startDate, Me.radScheduler1.DateTimeFormat, DayOfWeek.Monday).AddDays(-1)
				Me.radScheduler1.PrintStyle = New SchedulerWeeklyCalendarPrintStyle(startDate, endDate)
			ElseIf sender Is Me.radioMonthly Then
				Me.radScheduler1.ActiveViewType = SchedulerViewType.Month
				Me.radScheduler1.PrintStyle = New SchedulerMonthlyPrintStyle(Me.radScheduler1.ActiveView.StartDate, Me.radScheduler1.ActiveView.EndDate)
			ElseIf sender Is Me.radioDetails Then
				Me.radScheduler1.ActiveViewType = SchedulerViewType.Timeline
				Me.radScheduler1.PrintStyle = New SchedulerDetailsPrintStyle(Me.radScheduler1.ActiveView.StartDate, Me.radScheduler1.ActiveView.EndDate)
			ElseIf sender Is Me.radioAgenda Then
				Me.radScheduler1.ActiveViewType = SchedulerViewType.Agenda
				Dim startDate As Date = DateHelper.GetStartOfWeek(Me.radScheduler1.ActiveView.EndDate, Me.radScheduler1.DateTimeFormat, DayOfWeek.Monday)
				Dim endDate As Date = DateHelper.GetEndOfWeek(startDate, Me.radScheduler1.DateTimeFormat, DayOfWeek.Monday).AddDays(-1)
				Me.radScheduler1.PrintStyle = New SchedulerAgendaPrintStyle(startDate, endDate)
			End If
		End Sub

		Private Sub UpdateSelectedStyle()
			suspendRadioButtons = True

			If TypeOf Me.radScheduler1.PrintStyle Is SchedulerDailyPrintStyle Then
				Me.radioDaily.IsChecked = True
			ElseIf TypeOf Me.radScheduler1.PrintStyle Is SchedulerWeeklyPrintStyle Then
				Me.radioWeekly.IsChecked = True
			ElseIf TypeOf Me.radScheduler1.PrintStyle Is SchedulerWeeklyCalendarPrintStyle Then
				Me.radioWeeklyCalendar.IsChecked = True
			ElseIf TypeOf Me.radScheduler1.PrintStyle Is SchedulerMonthlyPrintStyle Then
				Me.radioMonthly.IsChecked = True
			ElseIf TypeOf Me.radScheduler1.PrintStyle Is SchedulerDetailsPrintStyle Then
				Me.radioDetails.IsChecked = True
			End If

			suspendRadioButtons = False
		End Sub

		Private Sub FillAppointments()
			Me.radSchedulerNavigator1.SchedulerNavigatorElement.TimeZonesDropDown.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			Me.radScheduler1.Appointments.BeginUpdate()

			Dim dtStart As Date = DateHelper.GetStartOfWeek(Date.Today, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat).AddHours(10)
			Dim dtEnd As Date = DateHelper.GetStartOfWeek(Date.Today, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat).AddHours(12)

			Dim appointment As New Appointment(dtStart, dtEnd, "Building Windows 8 applications with the Metro look", "In this session, I will show you how to build a Windows 8 Metro Style Application in XAML and C#.During the process, I will highlight the similarities with other XAML platforms like Silverlight for the Windows Phone, and even how to share code between the two, as well as how to take advantage of the new features in WinRT such as contracts/charms and the new intrinsic GridView controls with semantic zoom.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Anniversary))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			Me.radScheduler1.Appointments.Add(appointment)

			appointment = New Appointment(dtStart.AddDays(4).AddHours(2), dtEnd.AddDays(4).AddHours(2), "Silverlight 5 for LOB development", "Most Silverlight 5 sessions give you an overview of the most magical features in the platform. However, not everyone is busy building 3D-enabled applications or media-intensive applications. Most Silverlight developers build LOB applications. For this group, this session is exactly what you need.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Business))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			Me.radScheduler1.Appointments.Add(appointment)

			appointment = New Appointment(dtStart.AddHours(4), dtEnd.AddHours(4), "Building Applications with HTML 5 and Javascript – a new perspective: Windows 8", "HTML 5 is out there for some time (though still a draft) and a lot of web applications are being built using this standard and technologies like Javascript. But how about building apps for the OS system Windows 8 using HTML 5 and Javascript?")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Important))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(1)
			dtEnd = dtEnd.AddDays(1)

			appointment = New Appointment(dtStart, dtEnd.AddDays(3), "What’s New In Windows Phone", "An overview of the features new in Windows Phone 7.5 (code name Mango) along with details on some of the most important new features, starting with Fast Application Switching, greater access to the calendar and contacts, a local database, a greatly enhanced motion API and much more.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.MustAttend))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			Me.radScheduler1.Appointments.Add(appointment)

			appointment = New Appointment(dtStart.AddHours(1), dtEnd.AddHours(1), "Windows Phone 7 Application - from start to market", "A crash course in Windows Phone application development with Visual Studio and Expression Blend, with an emphasis on declarative Xaml programming. This presentation will start with foundational information and take you through advanced topics such as tasks and data binding, as well as preparing your program for the marketplace.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.NeedsPreparation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Busy))
			Me.radScheduler1.Appointments.Add(appointment)

			appointment = New Appointment(dtStart.AddDays(4).AddHours(2), dtEnd.AddDays(4).AddHours(3), "How Do You Test SharePoint 2010 Applications?", "There are many types of testing you can perform on a developed web application – from unit, to functional, to smoke, to load testing – and more!  Different tools are required for different types of testing, and properly testing SharePoint 2010 can present unique challenges.  Using Visual Studio 2010 Ultimate and several commercial testing tools, I will demonstrate several key testing types in action as applied to a SharePoint 2010 application.  When performing a stress test, I will take you through the interpretation of the results and guide you on how and what to test in your application.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.PhoneCall))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Busy))
			Me.radScheduler1.Appointments.Add(appointment)

			appointment = New Appointment(dtStart.AddHours(4), dtEnd.AddHours(5), "Common Design Patterns", "Design Patterns provide common templates for solving the same family of problems in a similar way. They also provide a higher-level language for software developers to use to describe approaches they might choose when designing a component of an application. In this session, you'll learn about several of the most common, and useful, design patterns used by Microsoft developers today.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Personal))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			Dim tempDateTime As Date = dtEnd.AddHours(7)
			appointment = New Appointment(dtStart.AddHours(6), tempDateTime.AddDays(1), "Moving your XAML applications to Metro", "By now you know what Metro is, what the Windows Runtime (WinRT) is, and that C# and VB.NET can access the WinRT via an interop layer. The big question: What's involved in moving my Silverlight (or WPF) application over to Metro? In this session Carl Franklin goes through the pain points and gives you a real idea of what it will take to port your application.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Business))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Free))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(1)
			dtEnd = dtEnd.AddDays(1)

			appointment = New Appointment(dtStart.AddHours(1), dtEnd.AddHours(4), "Windows Azure – Under the hood", "As a happy Windows Azure user you’ve probably been wondering about the internals of Windows Azure. How is provisioning of services happening, how do all components scale seemingly infinite? What happens if my role instance goes down? Come join me and balance on the thin line between software architecture and system architecture that forms the base of one of the most complete cloud platforms out there: Windows Azure.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Vacation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Unavailable))
			Me.radScheduler1.Appointments.Add(appointment)

			appointment = New Appointment(dtStart.AddDays(1).AddHours(5), dtEnd.AddDays(1).AddHours(7), "Taking Care of a Cloud Environment: Windows Azure", "No, this session is not about greener IT. It does cover the environment your application will live in once deployed to Windows Azure: learn about the virtual machine you’ve deployed to and how it interacts with the datacenter. Learn about how you can get use the RoleEnvironment class and diagnostics provided by Windows Azure. Communication between roles, logging and diagnostics are just some of the possibilities of what you can do if you know about how the Windows Azure environment works. And who knows, maybe we can even auto-scale our application...")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.Personal))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Tentative))
			Me.radScheduler1.Appointments.Add(appointment)

			appointment = New Appointment(dtStart.AddHours(8), dtEnd.AddHours(10), "Pragmatic ASP.NET Tips, Tricks, And Tools", "Every experienced ASP.NET developer has picked up a few cool tricks or useful tools that they put to use on every new project after they've learned them. This session draws upon the experience of many successful ASP.NET developers and distills this knowledge into a collection of tips and tricks you can start using in your work today. Some of the topics covered in this session include error handling, tracing, caching, base page classes, site layout and architecture, and data access best practices. You'll learn about highly reusable Http Modules and Handlers and a few code routines you may want to add to your personal library. Stick around for part 2 if you’re interested in learning about a wide variety of (usually free) tools available to aid ASP.NET developers. This session is appropriate for anyone who is working with ASP.NET today, and especially for those who are new to ASP.NET.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.MustAttend))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Busy))
			Me.radScheduler1.Appointments.Add(appointment)

			dtStart = dtStart.AddDays(1)
			dtEnd = dtEnd.AddDays(1)

			appointment = New Appointment(dtStart, dtEnd, "Fun With Programming", "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.")
			appointment.BackgroundId = CInt(Fix(AppointmentBackground.NeedsPreparation))
			appointment.StatusId = CInt(Fix(AppointmentStatus.Busy))
			Me.radScheduler1.Appointments.Add(appointment)

			Me.radScheduler1.Appointments.EndUpdate()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radScheduler1.ActiveViewChanged, AddressOf radScheduler1_ActiveViewChanged
			AddHandler radioDetails.ToggleStateChanged, AddressOf radio_ToggleStateChanged
			AddHandler radioMonthly.ToggleStateChanged, AddressOf radio_ToggleStateChanged
			AddHandler radioWeekly.ToggleStateChanged, AddressOf radio_ToggleStateChanged
			AddHandler radioWeeklyCalendar.ToggleStateChanged, AddressOf radio_ToggleStateChanged
			AddHandler radioDaily.ToggleStateChanged, AddressOf radio_ToggleStateChanged
			AddHandler buttonPrint.Click, AddressOf buttonPrint_Click
			AddHandler buttonPreview.Click, AddressOf buttonPreview_Click
			AddHandler buttonSettings.Click, AddressOf buttonSettings_Click
		End Sub
	End Class
End Namespace
