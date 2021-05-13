Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.ScaleBreaks
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private scaleBreaks As New List(Of AxisScaleBreak)()

		Public Sub New()
			InitializeComponent()

			Me.radDropDownListStyle.Items.Add(New RadListDataItem("Straight", ScaleBreakStyle.Straight))
			Me.radDropDownListStyle.Items.Add(New RadListDataItem("Waved", ScaleBreakStyle.Waved))
			Me.radDropDownListStyle.Items.Add(New RadListDataItem("Ragged", ScaleBreakStyle.Ragged))
			Me.radDropDownListStyle.SelectedIndex = 0

			Me.radSpinEditorSize.Value = 5

			Me.radColorBoxBackColor.Value = Color.White

			Me.radColorBoxBorderColor.Value = Color.Gray

			scaleBreaks.Add(New AxisScaleBreak("Break1", 3000, 4000))
			scaleBreaks.Add(New AxisScaleBreak("Break2", 1200, 2600))
			scaleBreaks.Add(New AxisScaleBreak("Break3", 40, 800))

			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True

			Dim northAmerica As New BarSeries()
			northAmerica.LegendTitle = "North America"
			northAmerica.ShowLabels = True
			northAmerica.DataPoints.Add(New CategoricalDataPoint(4274.6, 2012))
			northAmerica.DataPoints.Add(New CategoricalDataPoint(4806.9, 2011))
			northAmerica.DataPoints.Add(New CategoricalDataPoint(4935.5, 2010))
			northAmerica.DataPoints.Add(New CategoricalDataPoint(4975.4, 2009))

			Dim africa As New BarSeries()
			africa.LegendTitle = "Africa"
			africa.ShowLabels = True
			africa.DataPoints.Add(New CategoricalDataPoint(2886.0, 2009))
			africa.DataPoints.Add(New CategoricalDataPoint(2785.8, 2010))
			africa.DataPoints.Add(New CategoricalDataPoint(2801.9, 2011))
			africa.DataPoints.Add(New CategoricalDataPoint(2817.7, 2012))

			Dim asia As New BarSeries()
			asia.LegendTitle = "Asia"
			asia.ShowLabels = True
			asia.DataPoints.Add(New CategoricalDataPoint(20.4, 2009))
			asia.DataPoints.Add(New CategoricalDataPoint(19.6, 2010))
			asia.DataPoints.Add(New CategoricalDataPoint(21.9, 2011))
			asia.DataPoints.Add(New CategoricalDataPoint(24.0, 2012))

			Dim europe As New BarSeries()
			europe.LegendTitle = "Europe"
			europe.ShowLabels = True
			europe.DataPoints.Add(New CategoricalDataPoint(1033.9, 2009))
			europe.DataPoints.Add(New CategoricalDataPoint(1095.9, 2010))
			europe.DataPoints.Add(New CategoricalDataPoint(1098.2, 2011))
			europe.DataPoints.Add(New CategoricalDataPoint(1040.5, 2012))

			Me.radChartView1.Series.Add(northAmerica)
			Me.radChartView1.Series.Add(africa)
			Me.radChartView1.Series.Add(asia)
			Me.radChartView1.Series.Add(europe)

			Me.radChartView1.ShowLegend = True

			For Each scaleBreak As AxisScaleBreak In Me.scaleBreaks
				europe.VerticalAxis.ScaleBreaks.Add(scaleBreak)
			Next scaleBreak

			europe.VerticalAxis.Title = "Million units"
			europe.HorizontalAxis.Title = "Year"
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.radSpinEditorSize.ValueChanged, AddressOf radSpinEditorSize_ValueChanged
			AddHandler Me.radButtonScaleBreaks.Click, AddressOf radButtonScaleBreaks_Click
			AddHandler Me.radColorBoxBackColor.ValueChanged, AddressOf radColorBoxBackColor_ValueChanged
			AddHandler Me.radColorBoxBorderColor.ValueChanged, AddressOf radColorBoxBorderColor_ValueChanged
			AddHandler Me.radDropDownListStyle.SelectedIndexChanged, AddressOf radDropDownListStyle_SelectedIndexChanged
		End Sub

		Private Sub radColorBoxBackColor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim axis As CartesianAxis = TryCast(Me.radChartView1.Axes(1), CartesianAxis)
			axis.ScaleBreakBackColor = Me.radColorBoxBackColor.Value
		End Sub

		Private Sub radColorBoxBorderColor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim axis As CartesianAxis = TryCast(Me.radChartView1.Axes(1), CartesianAxis)
			axis.ScaleBreakBorderColor = Me.radColorBoxBorderColor.Value
		End Sub

		Private Sub radSpinEditorSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim axis As CartesianAxis = TryCast(Me.radChartView1.Axes(1), CartesianAxis)
			axis.ScaleBreakSize = CDbl(Me.radSpinEditorSize.Value)
		End Sub

		Private Sub radDropDownListStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim axis As CartesianAxis = TryCast(Me.radChartView1.Axes(1), CartesianAxis)
			axis.ScaleBreakStyle = CType(Me.radDropDownListStyle.SelectedItem.Value, ScaleBreakStyle)
		End Sub

		Private Sub radButtonScaleBreaks_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim axis As CartesianAxis = TryCast(Me.radChartView1.Axes(1), CartesianAxis)

			If axis.HasScaleBreaks Then
				axis.ScaleBreaks.Clear()

				Me.radButtonScaleBreaks.Text = "Add Scale Breaks"
			Else
				For Each scaleBreak As AxisScaleBreak In Me.scaleBreaks
					axis.ScaleBreaks.Add(scaleBreak)
				Next scaleBreak

				Me.radButtonScaleBreaks.Text = "Remove Scale Breaks"
			End If
		End Sub
	End Class
End Namespace
