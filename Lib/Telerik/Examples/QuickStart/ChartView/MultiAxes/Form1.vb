Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.MultiAxes
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private rnd As New Random()

		Public Sub New()
			InitializeComponent()

			Me.SetChartViewData()
			Me.SetupChartView()

			Me.radChartView1.ShowLegend = True
			Me.radChartView1.LegendTitle = "Telemetry"
			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Title = "Prototype car best lap telemetry"
			Me.radChartView1.ChartElement.TitlePosition = TitlePosition.Top
			Me.radChartView1.ChartElement.TitleElement.Padding = New Padding(Me.radChartView1.View.Margin.Left, 10, 0, 0)

			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalStripes = True
		End Sub

		Private Sub SetupChartView()
			Dim horizontalAxis As New DateTimeContinuousAxis()
			horizontalAxis.LabelFormat = "{0:m:ss:ff}"
			horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
			horizontalAxis.PlotMode = AxisPlotMode.OnTicks
			horizontalAxis.Title = "Time"
			horizontalAxis.MaximumTicks = 15

			Dim throttlePedal As New LineSeries()
			throttlePedal.LegendTitle = "Throttle pedal"
			throttlePedal.ValueMember = "ThrottlePedal"
			throttlePedal.CategoryMember = "Time"
			Dim throttleAxis As New LinearAxis()
			throttleAxis.HorizontalLocation = AxisHorizontalLocation.Right
			throttleAxis.AxisType = AxisType.Second
			throttleAxis.Title = "Throttle, %"
			throttleAxis.Minimum = -250
			throttleAxis.Maximum = 100
			throttlePedal.VerticalAxis = throttleAxis
			throttlePedal.HorizontalAxis = horizontalAxis

			Dim brakePedal As New LineSeries()
			brakePedal.LegendTitle = "Brake pedal"
			brakePedal.ValueMember = "BrakePedal"
			brakePedal.CategoryMember = "Time"
			Dim brakeAxis As New LinearAxis()
			brakeAxis.HorizontalLocation = AxisHorizontalLocation.Right
			brakeAxis.AxisType = AxisType.Second
			brakeAxis.Title = "Brake, %"
			brakeAxis.Minimum = -250
			brakeAxis.Maximum = 100
			brakePedal.VerticalAxis = brakeAxis
			brakePedal.HorizontalAxis = horizontalAxis

			Dim engineRpm As New LineSeries()
			engineRpm.LegendTitle = "Engine RPM"
			engineRpm.ValueMember = "EngineRpm"
			engineRpm.CategoryMember = "Time"
			Dim engineRpmAxis As New LinearAxis()
			engineRpmAxis.AxisType = AxisType.Second
			engineRpmAxis.Title = "Engine RPM"
			engineRpmAxis.Minimum = 2000
			engineRpmAxis.Maximum = 10000
			engineRpm.VerticalAxis = engineRpmAxis
			engineRpm.HorizontalAxis = horizontalAxis

			Dim gear As New BarSeries()
			gear.LegendTitle = "Gear"
			gear.ValueMember = "Gear"
			gear.CategoryMember = "Time"
			Dim gearAxis As New LinearAxis()
			gearAxis.AxisType = AxisType.Second
			gearAxis.Title = "Gear"
			gearAxis.Maximum = 30
			gearAxis.DesiredTickCount = 40
			gear.VerticalAxis = gearAxis
			gear.HorizontalAxis = horizontalAxis

			Dim speed As New LineSeries()
			speed.LegendTitle = "Speed"
			speed.ValueMember = "Speed"
			speed.CategoryMember = "Time"
			Dim speedAxis As New LinearAxis()
			speedAxis.AxisType = AxisType.Second
			speedAxis.Title = "Speed, km/h"
			speedAxis.Minimum = 0
			speedAxis.Maximum = 500
			speed.VerticalAxis = speedAxis
			speed.HorizontalAxis = horizontalAxis

			Me.radChartView1.Series.Add(gear)
			Me.radChartView1.Series.Add(brakePedal)
			Me.radChartView1.Series.Add(throttlePedal)
			Me.radChartView1.Series.Add(speed)
			Me.radChartView1.Series.Add(engineRpm)

			throttleAxis.LabelOffset = 5
			brakeAxis.LabelOffset = 5
			gearAxis.LabelOffset = 1

			For i As Integer = 0 To gearAxis.Children.Count - 1
				Dim gearLabel As AxisLabelElement = TryCast(gearAxis.Children(i), AxisLabelElement)

				If gearLabel IsNot Nothing AndAlso Integer.Parse(gearLabel.Text) > 6 Then
					gearLabel.IsVisible = False
				End If
			Next i
		End Sub

		Private Sub SetChartViewData()
			Dim table As New DataTable()

			table.Columns.Add("Time", GetType(Date))
			table.Columns.Add("ThrottlePedal", GetType(Double))
			table.Columns.Add("BrakePedal", GetType(Double))
			table.Columns.Add("EngineRpm", GetType(Double))
			table.Columns.Add("Gear", GetType(Double))
			table.Columns.Add("Speed", GetType(Double))

			Dim separator() As Char = { ControlChars.Cr, ControlChars.Lf }
			Dim fileContents As String = My.Resources.Telemetry
			Dim lines() As String = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries)

			Dim secondsCounter As Integer = 0

			For Each line As String In lines
				If String.IsNullOrEmpty(line) Then
					Continue For
				End If

				Dim data() As String = line.Split(","c)

                Dim time As DateTime = New DateTime(2012, 2, 4, 0, 0, 0).AddMilliseconds(500 * System.Math.Max(System.Threading.Interlocked.Increment(secondsCounter), secondsCounter - 1))
                Dim throttle As Double = Double.Parse(data(0), CultureInfo.InvariantCulture)
				Dim brake As Double = Double.Parse(data(1), CultureInfo.InvariantCulture)
				Dim engineRpm As Double = Double.Parse(data(2), CultureInfo.InvariantCulture)
				Dim gear As Double = Double.Parse(data(3), CultureInfo.InvariantCulture)
				Dim speed As Double = Double.Parse(data(4), CultureInfo.InvariantCulture)

				table.Rows.Add(time, throttle, brake, engineRpm, gear, speed)
			Next line

			Me.radChartView1.DataSource = table
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
