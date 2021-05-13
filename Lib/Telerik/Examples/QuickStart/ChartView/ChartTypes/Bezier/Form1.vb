Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Tests
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bezier
	''' <summary>
	''' RadChartView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim bezier As New BezierSeries()
			Dim point As New BezierDataPoint(20, 40, 0, 0, 100, 140)
			bezier.DataPoints.Add(point)
			point = New BezierDataPoint(20, 100, 100, 0, 0, 0)
			bezier.DataPoints.Add(point)

			Me.radChartView1.Series.Add(bezier)

			bezier = New BezierSeries()
			point = New BezierDataPoint(20, 150, 0, 0, 20, 250)
			bezier.DataPoints.Add(point)
			point = New BezierDataPoint(80, 150, 80, 250, 0, 0)
			bezier.DataPoints.Add(point)

			Me.radChartView1.Series.Add(bezier)

			bezier = New BezierSeries()
			point = New BezierDataPoint(120, 80, 0, 0, 180, 10)
			bezier.DataPoints.Add(point)
			point = New BezierDataPoint(200, 80, 190, 10, 0, 0)
			bezier.DataPoints.Add(point)

			Me.radChartView1.Series.Add(bezier)

			bezier = New BezierSeries()
			point = New BezierDataPoint(160, 120, 0, 0, 120, 180)
			bezier.DataPoints.Add(point)
			point = New BezierDataPoint(160, 180, 120, 120, 200, 240)
			bezier.DataPoints.Add(point)
			point = New BezierDataPoint(160, 240, 200, 180, 0, 0)
			bezier.DataPoints.Add(point)

			Me.radChartView1.Series.Add(bezier)
		End Sub
	End Class
End Namespace

