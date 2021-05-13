Namespace Telerik.Examples.WinControls.Scheduler.DataBinding
	Partial Public Class CustomAppointmentEditForm
		Inherits Telerik.WinControls.UI.Scheduler.Dialogs.EditAppointmentDialog
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub LoadSettingsFromEvent(ByVal ev As Telerik.WinControls.UI.IEvent)
			MyBase.LoadSettingsFromEvent(ev)

			Dim appointmentWithEmail As AppointmentWithEmail = TryCast(ev, AppointmentWithEmail)
			If appointmentWithEmail IsNot Nothing Then
				Me.txtEmail.Text = appointmentWithEmail.Email
			End If
		End Sub

		Protected Overrides Sub ApplySettingsToEvent(ByVal ev As Telerik.WinControls.UI.IEvent)
			Dim appointmentWithEmail As AppointmentWithEmail = TryCast(ev, AppointmentWithEmail)
			If appointmentWithEmail IsNot Nothing Then
				appointmentWithEmail.Email = Me.txtEmail.Text
			End If
			MyBase.ApplySettingsToEvent(ev)
		End Sub

		Protected Overrides Function CreateNewEvent() As Telerik.WinControls.UI.IEvent
			Return New AppointmentWithEmail()
		End Function
	End Class
End Namespace
