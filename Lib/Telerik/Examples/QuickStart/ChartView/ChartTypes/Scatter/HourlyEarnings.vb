Imports System.Text

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
	Public Class HourlyEarnings
'INSTANT VB NOTE: The variable sector was renamed since Visual Basic does not allow class members with the same name:
		Private sector_Renamed As String
'INSTANT VB NOTE: The variable wage was renamed since Visual Basic does not allow class members with the same name:
		Private wage_Renamed As Double
'INSTANT VB NOTE: The variable age was renamed since Visual Basic does not allow class members with the same name:
		Private age_Renamed As Integer

		Public Sub New(ByVal sector As String, ByVal wage As Double, ByVal age As Integer)
			Me.sector_Renamed = sector
			Me.wage_Renamed = wage
			Me.age_Renamed = age
		End Sub

		Public ReadOnly Property Sector() As String
			Get
				Return Me.sector_Renamed
			End Get
		End Property

		Public ReadOnly Property Wage() As Double
			Get
				Return Me.wage_Renamed
			End Get
		End Property

		Public ReadOnly Property Age() As Integer
			Get
				Return Me.age_Renamed
			End Get
		End Property
	End Class
End Namespace
