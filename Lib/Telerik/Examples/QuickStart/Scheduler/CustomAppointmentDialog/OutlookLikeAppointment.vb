Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Scheduler.CustomAppointmentDialog
	Public Class OutlookLikeAppointment
		Inherits Appointment
		Public Sub New()
			MyBase.New()
		End Sub

'INSTANT VB NOTE: The variable email was renamed since Visual Basic does not allow class members with the same name:
		Private email_Renamed As String = String.Empty
		Public Property Email() As String
			Get
				Return Me.email_Renamed
			End Get
			Set(ByVal value As String)
				If Me.email_Renamed <> value Then
					Me.email_Renamed = value
					Me.OnPropertyChanged("Email")
				End If
			End Set
		End Property

		Protected Overrides Function CreateOccurrenceInstance() As [Event]
			Dim occurrence As New OutlookLikeAppointment()
			occurrence.email_Renamed = Me.email_Renamed
			Return occurrence
		End Function
	End Class
End Namespace
