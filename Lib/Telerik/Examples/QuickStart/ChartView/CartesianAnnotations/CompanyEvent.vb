Imports System.Linq
Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
	Public Class CompanyEvent
'INSTANT VB NOTE: The variable eventDescription was renamed since Visual Basic does not allow class members with the same name:
		Private eventDescription_Renamed As String
'INSTANT VB NOTE: The variable timeOfEvent was renamed since Visual Basic does not allow class members with the same name:
		Private timeOfEvent_Renamed As Date
'INSTANT VB NOTE: The variable offset was renamed since Visual Basic does not allow class members with the same name:
		Private offset_Renamed As SizeF

		Public Sub New(ByVal timeOfEvent As Date, ByVal eventDescription As String, ByVal offset As SizeF)
			Me.timeOfEvent_Renamed = timeOfEvent
			Me.eventDescription_Renamed = eventDescription
			Me.offset_Renamed = offset
		End Sub

		Public Property EventDescription() As String
			Get
				Return eventDescription_Renamed
			End Get
			Set(ByVal value As String)
				eventDescription_Renamed = value
			End Set
		End Property

		Public Property TimeOfEvent() As Date
			Get
				Return timeOfEvent_Renamed
			End Get
			Set(ByVal value As Date)
				timeOfEvent_Renamed = value
			End Set
		End Property

		Public Property Offset() As SizeF
			Get
				Return offset_Renamed
			End Get
			Set(ByVal value As SizeF)
				offset_Renamed = value
			End Set
		End Property
	End Class
End Namespace
