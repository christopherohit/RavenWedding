Namespace Telerik.Examples.WinControls.ChartView.Appearance
	Public Class LineAreaSeriesData
'INSTANT VB NOTE: The variable month was renamed since Visual Basic does not allow class members with the same name:
		Private month_Renamed As String
'INSTANT VB NOTE: The variable profit was renamed since Visual Basic does not allow class members with the same name:
		Private profit_Renamed As Double

		Public Sub New(ByVal profit As Double, ByVal month As String)
			Me.profit_Renamed = profit
			Me.month_Renamed = month
		End Sub

		Public ReadOnly Property Month() As String
			Get
				Return Me.month_Renamed
			End Get
		End Property

		Public ReadOnly Property Profit() As Double
			Get
				Return Me.profit_Renamed
			End Get
		End Property
	End Class
End Namespace
