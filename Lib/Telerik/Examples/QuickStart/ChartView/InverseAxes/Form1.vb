Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.InverseAxes
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private dryHoleColor As Color = Color.FromArgb(142, 196, 65)
		Private naturalGasColor As Color = Color.FromArgb(27, 157, 222)
		Private crudeOilColor As Color = Color.FromArgb(245, 151, 0)

		Public Sub New()
			InitializeComponent()

			Me.radCheckBoxDryHoles.ButtonElement.TextElement.ForeColor = dryHoleColor
			Me.radCheckBoxDryHoles.Font = New Font("Segoe UI", 10, FontStyle.Bold)
			Me.radCheckBoxNaturalGas.ButtonElement.TextElement.ForeColor = naturalGasColor
			Me.radCheckBoxNaturalGas.Font = New Font("Segoe UI", 10, FontStyle.Bold)
			Me.radCheckBoxCrudeOil.ButtonElement.TextElement.ForeColor = crudeOilColor
			Me.radCheckBoxCrudeOil.Font = New Font("Segoe UI", 10, FontStyle.Bold)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			SetupMainChart()
			SetupAggregatesChart()
			SetupDepthsChart()
		End Sub

		Private Sub SetupMainChart()
			Dim verticalAxis As New LinearAxis()
			verticalAxis.AxisType = AxisType.Second
			verticalAxis.LabelFormat = "{0}m"
			verticalAxis.IsInverse = True

			Dim horizontalAxis As New DateTimeContinuousAxis()
			horizontalAxis.LabelFormat = "{0:yyyy}"
			horizontalAxis.VerticalLocation = AxisVerticalLocation.Top
			horizontalAxis.MajorStep = 2
			horizontalAxis.MajorStepUnit = Charting.TimeInterval.Year

			Dim dryHoles As New AreaSeries()
			dryHoles.BackColor = Color.FromArgb(100, dryHoleColor)
			dryHoles.BorderColor = dryHoleColor
			dryHoles.DataMember = "DryHoles"
			dryHoles.ValueMember = "Depth"
			dryHoles.CategoryMember = "Time"
			dryHoles.VerticalAxis = verticalAxis
			dryHoles.HorizontalAxis = horizontalAxis

			Dim naturalGas As New AreaSeries()
			naturalGas.BackColor = Color.FromArgb(100, naturalGasColor)
			naturalGas.BorderColor = naturalGasColor
			naturalGas.DataMember = "NaturalGas"
			naturalGas.ValueMember = "Depth"
			naturalGas.CategoryMember = "Time"
			naturalGas.VerticalAxis = verticalAxis
			naturalGas.HorizontalAxis = horizontalAxis

			Dim crudeOil As New AreaSeries()
			crudeOil.BackColor = Color.FromArgb(100, crudeOilColor)
			crudeOil.BorderColor = crudeOilColor
			crudeOil.DataMember = "CrudeOil"
			crudeOil.ValueMember = "Depth"
			crudeOil.CategoryMember = "Time"
			crudeOil.VerticalAxis = verticalAxis
			crudeOil.HorizontalAxis = horizontalAxis

			Me.radChartViewWellsDepth.Series.Add(dryHoles)
			Me.radChartViewWellsDepth.Series.Add(naturalGas)
			Me.radChartViewWellsDepth.Series.Add(crudeOil)

			Dim model As New DataModel()
			Me.radChartViewWellsDepth.DataSource = model.GetRawData()

			naturalGas.IsVisible = False
			crudeOil.IsVisible = False
		End Sub

		Private Sub SetupAggregatesChart()
			Dim model As New DataModel()

			Dim max As New BarSeries()
			max.ValueMember = "MaximumDepth"
			max.CategoryMember = "Name"
			max.ShowLabels = True
			max.LabelMode = BarLabelModes.Top
			max.LabelFormat = "{0:F0}"

			Dim avg As New BarSeries()
			avg.ValueMember = "AverageDepth"
			avg.CategoryMember = "Name"
			avg.ShowLabels = True
			avg.LabelMode = BarLabelModes.Top
			avg.LabelFormat = "{0:F0}"

			Me.radChartViewAvgVsMaxDepth.Series.AddRange(max, avg)
			Me.radChartViewAvgVsMaxDepth.DataSource = model.GetAggregatedData()
			Me.radChartViewAvgVsMaxDepth.GetArea(Of CartesianArea)().Orientation = Orientation.Horizontal
			avg.HorizontalAxis.IsVisible = False

			avg.Children(0).BorderColor = dryHoleColor
			avg.Children(0).BackColor = avg.Children(0).BorderColor
			avg.Children(1).BorderColor = naturalGasColor
			avg.Children(1).BackColor = avg.Children(1).BorderColor
			avg.Children(2).BorderColor = crudeOilColor
			avg.Children(2).BackColor = avg.Children(2).BorderColor

			For Each element As UIChartElement In avg.Children
				element.Children(0).BorderColor = Color.Transparent
				element.Children(0).BackColor = element.Children(0).BorderColor
			Next element
		End Sub

		Private Sub SetupDepthsChart()
			Dim verticalAxis As New LinearAxis()
			verticalAxis.AxisType = AxisType.Second
			verticalAxis.LabelFormat = "{0}m"
			verticalAxis.IsInverse = True
			verticalAxis.MajorStep = 3000

			Dim horizontalAxis As New DateTimeContinuousAxis()
			horizontalAxis.LabelFormat = "{0:yyyy}"
			horizontalAxis.VerticalLocation = AxisVerticalLocation.Top
			horizontalAxis.MajorStep = 10
			horizontalAxis.MajorStepUnit = Charting.TimeInterval.Year

			Dim dryHoles As New LineSeries()
			dryHoles.BorderColor = dryHoleColor
			dryHoles.DataMember = "DryHoles"
			dryHoles.ValueMember = "Depth"
			dryHoles.CategoryMember = "Time"
			dryHoles.VerticalAxis = verticalAxis
			dryHoles.HorizontalAxis = horizontalAxis

			Dim naturalGas As New LineSeries()
			naturalGas.BorderColor = naturalGasColor
			naturalGas.DataMember = "NaturalGas"
			naturalGas.ValueMember = "Depth"
			naturalGas.CategoryMember = "Time"
			naturalGas.VerticalAxis = verticalAxis
			naturalGas.HorizontalAxis = horizontalAxis

			Dim crudeOil As New LineSeries()
			crudeOil.BorderColor = crudeOilColor
			crudeOil.DataMember = "CrudeOil"
			crudeOil.ValueMember = "Depth"
			crudeOil.CategoryMember = "Time"
			crudeOil.VerticalAxis = verticalAxis
			crudeOil.HorizontalAxis = horizontalAxis

			Me.radChartViewDepthVsResource.Series.Add(dryHoles)
			Me.radChartViewDepthVsResource.Series.Add(naturalGas)
			Me.radChartViewDepthVsResource.Series.Add(crudeOil)

			Dim model As New DataModel()
			Me.radChartViewDepthVsResource.DataSource = model.GetRawData()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.radCheckBoxDryHoles.ToggleStateChanged, AddressOf radCheckBoxDryHoles_ToggleStateChanged
			AddHandler Me.radCheckBoxNaturalGas.ToggleStateChanged, AddressOf radCheckBoxNaturalGas_ToggleStateChanged
			AddHandler Me.radCheckBoxCrudeOil.ToggleStateChanged, AddressOf radCheckBoxCrudeOil_ToggleStateChanged
		End Sub

		Private Sub radCheckBoxDryHoles_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radChartViewWellsDepth.Series(0).IsVisible = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxNaturalGas_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radChartViewWellsDepth.Series(1).IsVisible = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxCrudeOil_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radChartViewWellsDepth.Series(2).IsVisible = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub
	End Class
End Namespace
