Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
	Public Class PerformanceData
		Private quarter As String
		Private name As String
'INSTANT VB NOTE: The variable performance was renamed since Visual Basic does not allow class members with the same name:
		Private performance_Renamed As Double

		Public Sub New(ByVal name As String, ByVal quarter As String, ByVal performance As Double)
			Me.name = name
			Me.quarter = quarter
			Me.performance_Renamed = performance
		End Sub

		Public ReadOnly Property QuarterName() As String
			Get
				Return Me.quarter
			End Get
		End Property

		Public ReadOnly Property RepresentativeName() As String
			Get
				Return Me.name
			End Get
		End Property

		Public ReadOnly Property Performance() As Double
			Get
				Return Me.performance_Renamed
			End Get
		End Property
	End Class
End Namespace
