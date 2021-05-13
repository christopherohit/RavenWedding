Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	Public Class ChartCellElement
		Inherits GridDataCellElement
		Private chart As RadChartElement
		Private Shared r As New Random()
		Private Shared lineSeries As LineSeries

		Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(column, row)
			Me.Padding = New Padding(0)
			chart.View.Margin = New Padding(3)
			chart.View.MinSize = New SizeF(10, 10)
			chart.GradientStyle = Telerik.WinControls.GradientStyles.Solid
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridDataCellElement)
			End Get
		End Property

		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()

			chart = New RadChartElement()
			Me.Children.Add(chart)

			lineSeries = New LineSeries()
			lineSeries.BorderColor = Color.FromArgb(68, 68, 68)
			lineSeries.PointSize = New SizeF()

			For i As Integer = 0 To 11
				lineSeries.DataPoints.Add(New CategoricalDataPoint(r.Next(50)))
			Next i
			chart.View.Series.Add(lineSeries)

			chart.View.Axes(0).IsVisible = False
			chart.View.Axes(1).IsVisible = False
		End Sub

		Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
			Return data IsNot Nothing AndAlso (data.Name = "Snacks" OrElse data.Name = "Beverages") AndAlso TypeOf context Is GridDataRowElement
		End Function
	End Class
End Namespace
