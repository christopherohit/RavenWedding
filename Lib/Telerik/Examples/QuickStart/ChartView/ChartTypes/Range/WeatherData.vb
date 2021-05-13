Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Range
	Public Class WeatherData
'INSTANT VB NOTE: The variable time was renamed since Visual Basic does not allow class members with the same name:
		Private time_Renamed As Date
'INSTANT VB NOTE: The variable low was renamed since Visual Basic does not allow class members with the same name:
		Private low_Renamed As Double
'INSTANT VB NOTE: The variable high was renamed since Visual Basic does not allow class members with the same name:
		Private high_Renamed As Double

		Public Sub New(ByVal time As Date, ByVal low As Double, ByVal high As Double)
			Me.time_Renamed = time
			Me.low_Renamed = low
			Me.high_Renamed = high
		End Sub

		Public ReadOnly Property Time() As Date
			Get
				Return time_Renamed
			End Get
		End Property

		Public ReadOnly Property Low() As Double
			Get
				Return low_Renamed
			End Get
		End Property

		Public ReadOnly Property High() As Double
			Get
				Return high_Renamed
			End Get
		End Property
	End Class
End Namespace
