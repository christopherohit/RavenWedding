Imports Telerik.WinControls.UI.Map

Namespace Telerik.Examples.WinControls.Map.FirstLook
	Public Class TripCity
'INSTANT VB NOTE: The variable location was renamed since Visual Basic does not allow class members with the same name:
		Private location_Renamed As PointG
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable tripStop was renamed since Visual Basic does not allow class members with the same name:
		Private tripStop_Renamed As Integer
'INSTANT VB NOTE: The variable isFlight was renamed since Visual Basic does not allow class members with the same name:
		Private isFlight_Renamed As Boolean

		Public Sub New(ByVal name As String, ByVal location As PointG, ByVal tripStop As Integer, ByVal isFlight As Boolean)
			Me.name_Renamed = name
			Me.location_Renamed = location
			Me.tripStop_Renamed = tripStop
			Me.isFlight_Renamed = isFlight
		End Sub

		Public Property Location() As PointG
			Get
				Return location_Renamed
			End Get
			Set(ByVal value As PointG)
				Me.location_Renamed = value
			End Set
		End Property

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				Me.name_Renamed = value
			End Set
		End Property

		Public Property TripStop() As Integer
			Get
				Return tripStop_Renamed
			End Get
			Set(ByVal value As Integer)
				Me.tripStop_Renamed = value
			End Set
		End Property

		Public Property IsFlight() As Boolean
			Get
				Return isFlight_Renamed
			End Get
			Set(ByVal value As Boolean)
				Me.isFlight_Renamed = value
			End Set
		End Property
	End Class
End Namespace
