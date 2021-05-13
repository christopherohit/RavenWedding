Imports System.Linq
Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.DrillDown
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm

		Private year As Integer
		Private month As Integer
		Private smartLabelsController As New SmartLabelsController()

		Public Sub New()
			InitializeComponent()
			InitializeDropDownList()

			Dim barSerias As New BarSeries()

			barSerias.ValueMember = "Value"
			barSerias.CategoryMember = "Date"
			barSerias.DataSource = DrillDownViewModel.ParseDataByYear()

			radChartView1.Views.AddNew()
			radChartView1.Views.AddNew()
			radChartView1.Title = "Revenue by Years"
			Me.radChartView1.ChartElement.ShowTitle = True
			radChartView1.ChartElement.TitlePosition = TitlePosition.Top
			Dim controller As New DrillDownController()
			Me.radChartView1.Controllers.Add(controller)
			AddHandler radChartView1.Drill, AddressOf radChartView1_Drill
			Me.radChartView1.ShowDrillNavigation = True
			FillColors(Me.radChartView1.View, KnownPalette.Warm)

			Dim horizontalAxis As New DateTimeContinuousAxis()
			horizontalAxis.MajorStepUnit = Charting.TimeInterval.Year
			horizontalAxis.MajorStep = 1
			horizontalAxis.LabelFormat = "{0:yyyy}"
			horizontalAxis.Title = "Year"

			Dim verticalAxis As New LinearAxis()
			verticalAxis.AxisType = AxisType.Second
			verticalAxis.Title = "USD"
			barSerias.HorizontalAxis = verticalAxis

			barSerias.VerticalAxis = horizontalAxis


			radChartView1.Series.Add(barSerias)
			AddHandler radChartView1.LabelFormatting, AddressOf radChartView1_LabelFormatting
			Me.radChartView1.ShowTrackBall = False

			'smartLabelsController.Strategy = new FalpLabelStrategy();


			Me.radChartView1.Controllers.Add(smartLabelsController)
			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True

			Me.FillBarSeries(barSerias)
		End Sub

		Private Sub radChartView1_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
			e.LabelElement.BackColor = Color.White
			e.LabelElement.BorderColor = Color.Black
			e.LabelElement.ForeColor = Color.Black
		End Sub

		Private Sub InitializeDropDownList()
			Me.radDropDownList1.Items.Add("Breadcrumb")
			Me.radDropDownList1.Items.Add("Home Buttom")
			Me.radDropDownList1.SelectedIndex = 0
			Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.radDropDownList1.SelectedIndex = 0 Then
				Me.radChartView1.ChartElement.DrillNavigationMode = DrillNavigationMode.Breadcrumb
			Else
				Me.radChartView1.ChartElement.DrillNavigationMode = DrillNavigationMode.HomeBackButtons
			End If
		End Sub

		Private Sub radChartView1_Drill(ByVal sender As Object, ByVal e As DrillEventArgs)
			Dim series As CartesianSeries = New BarSeries()
			series.ValueMember = "Value"
			series.CategoryMember = "Date"

			Dim horizontalAxis As New DateTimeCategoricalAxis()
			Dim area As CartesianArea = e.View.GetArea(Of CartesianArea)()
			area.ShowGrid = True

			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalStripes = True
			grid.DrawVerticalStripes = True

			Me.radChartView1.ShowTrackBall = False
			Select Case e.Level
				Case 0
					series.DataSource = DrillDownViewModel.ParseDataByYear()
					radChartView1.Title = "Revenue by Years"
					grid.DrawVerticalStripes = False
					Me.FillBarSeries(series)
				Case 1
					If e.SelectedPoint IsNot Nothing Then
						year = (CType(e.SelectedPoint.DataItem, DrillDownDataInfo)).Date.Year
					End If

					series.DataSource = DrillDownViewModel.ParseDataByMonth(year)
					radChartView1.Title = "Revenue by Months"
					horizontalAxis.LabelFormat = "{0:MMMM}"
					horizontalAxis.Title = "Months"
					grid.DrawVerticalStripes = False
					Me.FillBarSeries(series)
				Case 2
					If e.SelectedPoint IsNot Nothing Then
						month = (CType(e.SelectedPoint.DataItem, DrillDownDataInfo)).Date.Month
					End If

					series = New LineSeries()
					series.ValueMember = "Value"
					series.CategoryMember = "Date"
					series.DataSource = DrillDownViewModel.ParseDataByDay(year, month)
					series.ShowLabels = True
					series.DrawLinesToLabels = True
					series.SyncLinesToLabelsColor = False
					series.LinesToLabelsColor = Color.Black

					radChartView1.Title = "Revenue by Days"
					horizontalAxis.LabelFormat = "{0:dd}"
					horizontalAxis.Title = "Days"
					Me.radChartView1.ShowTrackBall = True
					grid.DrawVerticalStripes = True
					series.ForeColor = Color.Black
					Me.SetTrackBall()
			End Select

			e.View.Axes.Clear()
			series.HorizontalAxis = horizontalAxis
			e.View.Series.Clear()
			e.View.Series.Add(series)

			Me.FillColors(e.View, KnownPalette.Warm)
		End Sub

		Private Sub FillColors(ByVal view As Telerik.WinControls.UI.ChartView, ByVal pallete As ChartPalette)
			view.Palette = Nothing
			view.Palette = pallete
		End Sub

		Private Sub SetTrackBall()
			Dim trackBallElement As New ChartTrackballController()
			'trackBallElement.Element.TextAlignment = ContentAlignment.MiddleCenter; 
			'trackBallElement.Element.BorderColor = Color.Black;
			trackBallElement.Element.ForeColor = Color.Black
			'trackBallElement.Element.BackColor = Color.White; 
			trackBallElement.Element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
			'trackBallElement.Element.GradientStyle = Telerik.WinControls.GradientStyles.Solid; 
			trackBallElement.Element.Padding = New Padding(3, 0, 3, 3)
			trackBallElement.PointFormatString = "{0}:{1} USD"
			AddHandler trackBallElement.TextNeeded, AddressOf trackBallElement_TextNeeded
			Me.radChartView1.Controllers.Add(trackBallElement)
		End Sub

		Private Sub trackBallElement_TextNeeded(ByVal sender As Object, ByVal e As TextNeededEventArgs)
			e.Text = "<html><color=black>" & e.Points(0).DataPoint.Label.ToString() & vbLf & "USD"
		End Sub

		Private Sub FillBarSeries(ByVal series As CartesianSeries)
			Dim dictionary As New SortedDictionary(Of Double, DataPointElement)()
			For i As Integer = 0 To series.Children.Count - 1
				Dim childElement As DataPointElement = CType(series.Children(i), DataPointElement)
				Dim volume As Double = CDbl(childElement.DataPoint.Label)
				dictionary.Add(volume, childElement)
			Next i

			Dim j As Integer = 0
			For Each childElement As DataPointElement In dictionary.Values
				childElement.BackColor = KnownPalette.Warm.GetEntry(series.Family, j).Fill
				childElement.BorderColor = KnownPalette.Warm.GetEntry(series.Family, j).Stroke
				j += 1
				If j > 7 Then
					j = 7
				End If
			Next childElement
		End Sub

		Protected Overrides Sub WireEvents()
		End Sub
	End Class
End Namespace
