Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.CustomElements
	Public Class MyAppointmentElement
		Inherits AppointmentElement
		Private icon As LightVisualElement

		Public Sub New(ByVal scheduler As RadScheduler, ByVal view As SchedulerView, ByVal appointment As IEvent)
			MyBase.New(scheduler, view, appointment)
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(AppointmentElement)
			End Get
		End Property

		Protected Overrides Sub InitializeAppointment()
			MyBase.InitializeAppointment()

			Me.BackColor = ColorTranslator.FromHtml("#FFFCD9")
			Me.GradientStyle = Telerik.WinControls.GradientStyles.Solid

			Me.BorderColor = ColorTranslator.FromHtml("#C4C7B6")
			Me.BorderWidth = 3
		End Sub

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			Me.icon = New LightVisualElement()

			Me.icon.ShouldHandleMouseInput = False
			Me.icon.NotifyParentOnMouseInput = True
			Me.icon.Alignment = ContentAlignment.BottomRight
			Me.icon.StretchHorizontally = False
			Me.icon.StretchVertically = False

			Me.Children.Add(icon)
		End Sub

		Public Overrides Sub Synchronize()
			MyBase.Synchronize()
			Dim apointment As Appointment = TryCast(Me.Appointment, Appointment)
			Dim timeToAppoinmet As TimeSpan = Me.Appointment.Start - Date.Now
			If apointment.Reminder IsNot Nothing Then
				If apointment.MasterEvent IsNot Nothing Then
					icon.Margin = New Padding(0, 0, 10, -4)
				Else
					icon.Margin = New Padding(0)
				End If
				icon.Image = Image.FromFile("..\Resources\reminder-icon.png")
				Me.icon.ToolTipText = String.Format("Time to apportionment {0} hours and {1} minutes.", timeToAppoinmet.Hours, timeToAppoinmet.Minutes)
			Else
				icon.Image = Nothing
			End If
		End Sub
	End Class
End Namespace