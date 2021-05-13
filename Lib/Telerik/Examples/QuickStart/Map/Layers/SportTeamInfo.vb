Imports System.Text
Imports Telerik.WinControls.UI.Map

Namespace Telerik.Examples.WinControls.Map.Layers
	Public Class SportTeamInfo
'INSTANT VB NOTE: The variable location was renamed since Visual Basic does not allow class members with the same name:
		Private location_Renamed As PointG
'INSTANT VB NOTE: The variable city was renamed since Visual Basic does not allow class members with the same name:
		Private city_Renamed As String
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable arena was renamed since Visual Basic does not allow class members with the same name:
		Private arena_Renamed As String

		Public Sub New(ByVal location As PointG, ByVal city As String, ByVal name As String, ByVal arena As String)
			Me.location_Renamed = location
			Me.city_Renamed = city
			Me.name_Renamed = name
			Me.arena_Renamed = arena
		End Sub

		Public Property Location() As PointG
			Get
				Return location_Renamed
			End Get
			Set(ByVal value As PointG)
				location_Renamed = value
			End Set
		End Property

		Public Property City() As String
			Get
				Return city_Renamed
			End Get
			Set(ByVal value As String)
				city_Renamed = value
			End Set
		End Property

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property

		Public Property Arena() As String
			Get
				Return arena_Renamed
			End Get
			Set(ByVal value As String)
				arena_Renamed = value
			End Set
		End Property
	End Class
End Namespace
