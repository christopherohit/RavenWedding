Namespace Telerik.Examples.WinControls.ChartView.Printing
	Public Class LineAreaSeriesData
'INSTANT VB NOTE: The variable month was renamed since Visual Basic does not allow class members with the same name:
		Private month_Renamed As String
'INSTANT VB NOTE: The variable expense was renamed since Visual Basic does not allow class members with the same name:
		Private expense_Renamed As Double

		Public Sub New(ByVal expense As Double, ByVal month As String)
			Me.expense_Renamed = expense
			Me.month_Renamed = month
		End Sub

		Public ReadOnly Property Month() As String
			Get
				Return Me.month_Renamed
			End Get
		End Property

		Public ReadOnly Property Expense() As Double
			Get
				Return Me.expense_Renamed
			End Get
		End Property
	End Class
End Namespace
