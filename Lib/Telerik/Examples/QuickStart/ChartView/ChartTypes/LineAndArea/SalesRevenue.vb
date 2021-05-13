Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.LineAndArea
	Public Class SalesRevenue
'INSTANT VB NOTE: The variable month was renamed since Visual Basic does not allow class members with the same name:
		Private month_Renamed As String
'INSTANT VB NOTE: The variable revenue was renamed since Visual Basic does not allow class members with the same name:
		Private revenue_Renamed As Double

		Public Sub New(ByVal month As String, ByVal revenue As Double)
			Me.month_Renamed = month
			Me.revenue_Renamed = revenue
		End Sub

		Public ReadOnly Property Month() As String
			Get
				Return Me.month_Renamed
			End Get
		End Property

		Public ReadOnly Property Revenue() As Double
			Get
				Return Me.revenue_Renamed
			End Get
		End Property
	End Class
End Namespace
