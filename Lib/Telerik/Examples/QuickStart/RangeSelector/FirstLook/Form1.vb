Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RangeSelector.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			TryCast(Me.radRangeSlider1.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement).ScalesPosition = ViewPosition.BottomRight

			Me.radChartView1.View.Margin = New Padding(0)
			Me.radChartView1.BackColor = Color.White
		End Sub
	End Class
End Namespace
