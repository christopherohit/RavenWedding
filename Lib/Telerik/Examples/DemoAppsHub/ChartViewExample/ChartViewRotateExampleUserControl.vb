Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace DemoAppsHub.ChartViewExample
	Public Partial Class ChartViewRotateExampleUserControl
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			Dim barSeries As BarSeries = New BarSeries("Performance", "RepresentativeName")
			barSeries.LegendTitle = "Q1"
			barSeries.Name = "Q1"
			barSeries.DataPoints.Add(New CategoricalDataPoint(177, "Harley"))
			barSeries.DataPoints.Add(New CategoricalDataPoint(128, "White"))
			barSeries.DataPoints.Add(New CategoricalDataPoint(143, "Smith"))
			barSeries.DataPoints.Add(New CategoricalDataPoint(111, "Jones"))
			barSeries.DataPoints.Add(New CategoricalDataPoint(118, "Marshall"))
			Me.radChartView1.Series.Add(barSeries)

			Dim barSeries2 As BarSeries = New BarSeries("Performance", "RepresentativeName")
			barSeries2.LegendTitle = "Q2"
			barSeries2.Name = "Q2"
			barSeries2.DataPoints.Add(New CategoricalDataPoint(153, "Harley"))
			barSeries2.DataPoints.Add(New CategoricalDataPoint(141, "White"))
			barSeries2.DataPoints.Add(New CategoricalDataPoint(130, "Smith"))
			barSeries2.DataPoints.Add(New CategoricalDataPoint(88, "Jones"))
			barSeries2.DataPoints.Add(New CategoricalDataPoint(109, "Marshall"))
			Me.radChartView1.Series.Add(barSeries2)

			Dim barSeries3 As BarSeries = New BarSeries("Performance", "RepresentativeName")
			barSeries3.LegendTitle = "Q3"
			barSeries3.Name = "Q3"
			barSeries3.DataPoints.Add(New CategoricalDataPoint(10, "Harley"))
			barSeries3.DataPoints.Add(New CategoricalDataPoint(55, "White"))
			barSeries3.DataPoints.Add(New CategoricalDataPoint(121, "Smith"))
			barSeries3.DataPoints.Add(New CategoricalDataPoint(86, "Jones"))
			barSeries3.DataPoints.Add(New CategoricalDataPoint(99, "Marshall"))
			Me.radChartView1.Series.Add(barSeries3)

			Me.radChartView1.ShowLegend = True
			Me.radChartView1.LegendTitle = "Performance"

			Me.radChartView1.ShowPanZoom = True
		End Sub
	End Class
End Namespace
