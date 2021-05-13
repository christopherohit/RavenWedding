Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.Appearance
	''' <summary>
	''' RadChartView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private barSeriesValues() As Integer = {270, 330, 390, 280, 350, 250, 410, 310}
		Private radarSeriesValues() As Double = { 3.9, 3.9, 2, 4, 3.5, 3, 3.5, 4.1, 1.5, 5, 2.5, 2.5, 2, 4.5, 2, 3.5, 1, 2.5, 4.5, 3, 4.2, 2.8, 3.2, 2 }

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			InitializePaletteListControl()

			InitializeBarChart()
			InitializePieChart()
			InitializeRadarChart()
			InitializeLineChart()
			InitializeAreaChart()

			Me.radListControl1.SelectedValue = KnownPalette.Metro
		End Sub

		Private Sub radListControl1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radChartView1.View.Palette = TryCast(Me.radListControl1.SelectedValue, ChartPalette)
			Me.radChartView2.View.Palette = TryCast(Me.radListControl1.SelectedValue, ChartPalette)
			Me.radChartView3.View.Palette = TryCast(Me.radListControl1.SelectedValue, ChartPalette)
			Me.radChartView4.View.Palette = TryCast(Me.radListControl1.SelectedValue, ChartPalette)
			Me.radChartView5.View.Palette = TryCast(Me.radListControl1.SelectedValue, ChartPalette)
		End Sub

		Private Sub InitializePaletteListControl()
			Dim palettes As New List(Of PaletteObject)()
			palettes.Add(New PaletteObject(KnownPalette.ArcticPaletteName, KnownPalette.Arctic))
			palettes.Add(New PaletteObject(KnownPalette.AutumnPaletteName, KnownPalette.Autumn))
			palettes.Add(New PaletteObject(KnownPalette.ColdPaletteName, KnownPalette.Cold))
			palettes.Add(New PaletteObject(KnownPalette.FlowerPaletteName, KnownPalette.Flower))
			palettes.Add(New PaletteObject(KnownPalette.ForestPaletteName, KnownPalette.Forest))
			palettes.Add(New PaletteObject(KnownPalette.GrayscalePaletteName, KnownPalette.Grayscale))
			palettes.Add(New PaletteObject(KnownPalette.GroundPaletteName, KnownPalette.Ground))
			palettes.Add(New PaletteObject(KnownPalette.LilacPaletteName, KnownPalette.Lilac))
			palettes.Add(New PaletteObject(KnownPalette.MetroPaletteName, KnownPalette.Metro))
			palettes.Add(New PaletteObject(KnownPalette.NaturalPaletteName, KnownPalette.Natural))
			palettes.Add(New PaletteObject(KnownPalette.PastelPaletteName, KnownPalette.Pastel))
			palettes.Add(New PaletteObject(KnownPalette.RainbowPaletteName, KnownPalette.Rainbow))
			palettes.Add(New PaletteObject(KnownPalette.SpringPaletteName, KnownPalette.Spring))
			palettes.Add(New PaletteObject(KnownPalette.SummerPaletteName, KnownPalette.Summer))
			palettes.Add(New PaletteObject(KnownPalette.WarmPaletteName, KnownPalette.Warm))
			palettes.Add(New PaletteObject(KnownPalette.Windows8PaletteName, KnownPalette.Windows8))
			palettes.Add(New PaletteObject(KnownPalette.SunPaletteName, KnownPalette.Sun))
			palettes.Add(New PaletteObject(KnownPalette.FluentPaletteName, KnownPalette.Fluent))
			palettes.Add(New PaletteObject(KnownPalette.MaterialPaletteName, KnownPalette.Material))

			Me.radListControl1.DisplayMember = "Name"
			Me.radListControl1.ValueMember = "Palette"
			Me.radListControl1.DataSource = palettes
		End Sub

		Private Sub InitializeAreaChart()
		   Dim areaSeries As AreaSeries
			Dim model As New AreaSeriesDataModel()
			For i As Integer = 0 To 7
				areaSeries = New AreaSeries()

				areaSeries.Spline = True
				areaSeries.CategoryMember = "Month"
				areaSeries.ValueMember = "Profit"
				areaSeries.DataSource = model.GetData(i)
				areaSeries.PointSize = New SizeF(0, 0)
				Me.radChartView5.Series.Add(areaSeries)

			Next i

			Me.radChartView5.View.Margin = New Padding(0, 0, 30, 0)
		End Sub

		Private Sub InitializeLineChart()
			Dim verticalAxis As New LinearAxis()
			verticalAxis.AxisType = AxisType.Second

			Dim lineSeries As LineSeries
			Dim model As New LineSeriesDataModel()
			For i As Integer = 0 To 7
				lineSeries = New LineSeries()

				lineSeries.CategoryMember = "Month"
				lineSeries.ValueMember = "Profit"
				lineSeries.DataSource = model.GetData(i)
				Dim pointSize As Single = If(i < 2, 3, 0)
				lineSeries.PointSize = New SizeF(pointSize, pointSize)
				Me.radChartView4.Series.Add(lineSeries)
			Next i

			Me.radChartView4.View.Margin = New Padding(0, 0, 30, 0)
		End Sub

		Private Sub InitializeRadarChart()
			Me.radChartView3.AreaType = ChartAreaType.Polar
			Me.radChartView3.Axes.Add(New PolarAxis())

			Dim area As PolarArea = TryCast(Me.radChartView3.Area, PolarArea)
			Dim polarAxis As PolarAxis = area.Axes.Get(Of PolarAxis)()(0)
			polarAxis.Minimum = 0R
			polarAxis.Maximum = 5R
			polarAxis.TickLength = 5
			area.ShowGrid = True
			Dim grid As PolarGrid = CType(area.Grid, PolarGrid)
			grid.DrawPolarFills = False
			grid.DrawRadialFills = False
			grid.BackColor = Color.LightGray
			grid.BackColor2 = Color.LightGray

			Dim valuesPerSeries As Integer = 8
			Dim radarSeries As New List(Of RadarSeries)()
			Dim radarLineSeries1 As New RadarLineSeries()
			radarLineSeries1.PolarAxis = polarAxis

			Dim radarLineSeries2 As New RadarLineSeries()
			radarLineSeries2.PolarAxis = polarAxis

			Dim radarAreaSeries1 As New RadarAreaSeries()
			radarAreaSeries1.PolarAxis = polarAxis

			radarSeries.Add(radarLineSeries1)
			radarSeries.Add(radarLineSeries2)
			radarSeries.Add(radarAreaSeries1)

			For i As Integer = 0 To radarSeriesValues.Length - 1
				Dim seriesNumber As Integer = i \ valuesPerSeries
				radarSeries(seriesNumber).DataPoints.Add(New CategoricalDataPoint(radarSeriesValues(i)))
			Next i

			radarLineSeries1.PointSize = New SizeF(1f, 1f)
			radarLineSeries2.PointSize = New SizeF(1f, 1f)
			radarAreaSeries1.PointSize = New SizeF(1f, 1f)

			Me.radChartView3.Series.Add(radarAreaSeries1)
			Me.radChartView3.Series.Add(radarLineSeries2)
			Me.radChartView3.Series.Add(radarLineSeries1)

			Me.radChartView3.View.Margin = New Padding(20)
		End Sub

		Private Sub InitializePieChart()
			Dim point As PieDataPoint
			Dim pieSeries As New PieSeries()

			For i As Integer = 0 To 5
				point = New PieDataPoint()
				point.Value = 60
				pieSeries.DataPoints.Add(point)
			Next i

			Me.radChartView2.Series.Add(pieSeries)
		End Sub

		Private Sub InitializeBarChart()
			Dim point As CategoricalDataPoint
			Dim barSeries As BarSeries
			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()

			grid.ForeColor = Color.FromArgb(235, 235, 235)
			grid.DrawVerticalStripes = False
			grid.DrawHorizontalStripes = True
			grid.DrawHorizontalFills = False
			grid.DrawVerticalFills = False
			area.ShowGrid = True

			For i As Integer = 0 To barSeriesValues.Length - 1
				barSeries = New BarSeries()
				point = New CategoricalDataPoint(barSeriesValues(i), "May 2012")
				barSeries.DataPoints.Add(point)
				area.Series.Add(barSeries)
			Next i

			Me.radChartView1.View.Margin = New Padding(0, 0, 30, 0)
		End Sub

		Private Sub radListControl1_ItemDataBound(ByVal sender As Object, ByVal args As ListItemDataBoundEventArgs)
			Dim listDataItem As PaletteListDataItem = CType(args.NewItem, PaletteListDataItem)
			Dim dataObject As PaletteObject = CType(listDataItem.DataBoundItem, PaletteObject)

			listDataItem.Palette = dataObject.Palette
		End Sub

		Private Sub radListControl1_ItemDataBinding(ByVal sender As Object, ByVal args As ListItemDataBindingEventArgs)
			args.NewItem = New PaletteListDataItem()
		End Sub

		Private Sub radListControl1_CreatingVisualListItem(ByVal sender As Object, ByVal args As CreatingVisualListItemEventArgs)
			args.VisualItem = New PaletteListVisualItem()
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radListControl1.SelectedValueChanged, AddressOf radListControl1_SelectedValueChanged
			AddHandler radListControl1.ItemDataBinding, AddressOf radListControl1_ItemDataBinding
			AddHandler radListControl1.ItemDataBound, AddressOf radListControl1_ItemDataBound
			AddHandler radListControl1.CreatingVisualListItem, AddressOf radListControl1_CreatingVisualListItem
		End Sub
	End Class
End Namespace
