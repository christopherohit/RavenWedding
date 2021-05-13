Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
	Public Class TwoLabelOhlcSeries
		Inherits OhlcSeries
		Protected Overrides Function CreatePointElement(ByVal point As DataPoint) As DataPointElement
			Return New TwoLabelOhlcPointElement(point)
		End Function
	End Class

	Public Class TwoLabelOhlcPointElement
		Inherits OhlcPointElement
'INSTANT VB NOTE: The variable secondLabel was renamed since Visual Basic does not allow class members with the same name:
		Private secondLabel_Renamed As LabelElement

		Public Sub New(ByVal point As DataPoint)
			MyBase.New(point)
			secondLabel_Renamed = CreateLabelElement(Me)
			Me.Children.Add(secondLabel_Renamed)
		End Sub

		Public ReadOnly Property SecondLabel() As LabelElement
			Get
				Return Me.secondLabel_Renamed
			End Get
		End Property

		Public Overrides Function GetThemeEffectiveType() As Type
			Return GetType(OhlcPointElement)
		End Function
	End Class
End Namespace
