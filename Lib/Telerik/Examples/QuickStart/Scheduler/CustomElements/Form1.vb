Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.CustomElements
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radScheduler1.ElementProvider = New MyElementProvider(radScheduler1)
			radScheduler1.GetDayView().StartDate = Date.Now.AddDays(-1)
			radScheduler1.GetDayView().AutoScrollToWorkTime = True
			radScheduler1.Appointments.Add(New Appointment(Date.Now.AddHours(-5).AddDays(-1), Date.Now.AddHours(-3).AddDays(-1), "WinForms Q2 release" & vbLf, "", ""))
			radScheduler1.Appointments.Add(New Appointment(Date.Now.AddHours(-4).AddDays(0), Date.Now.AddHours(-2).AddDays(0), "DevCraft official release" & vbLf, "", ""))
			radScheduler1.Appointments.Add(New Appointment(Date.Now.AddDays(1), Date.Now.AddDays(1).AddHours(2), "DevCraft keynote" & vbLf, "", "Boston"))
			For Each item As Appointment In radScheduler1.Appointments
				 Dim reminder As TimeSpan = TimeSpan.FromMinutes(15)

				 item.Reminder = reminder
			Next item
		End Sub
	End Class
End Namespace