Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Imports System.Drawing.Drawing2D
Imports HotelApp.Data

Namespace HotelApp
	Partial Public Class UserControlCurrentStatus
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			Me.reportsRangeSelectorPanel.BackColor = Color.White
			Me.reportsRangeSelectorPanel.RootElement.EnableElementShadow = False

			Me.trendsRangeSelector.RangeSelectorElement.Margin = New Padding(120, 0, 40, 40)
			Me.trendsRangeSelector.ShowButtons = False
			AddHandler Me.trendsRangeSelector.SelectionChanged, AddressOf trendsRangeSelector_SelectionChanged
			AddHandler Me.trendsRangeSelector.ScaleInitializing, AddressOf trendsRangeSelector_ScaleInitializing

			Me.occupiedPerDayChartView.ShowTitle = True
			Me.occupiedPerDayChartView.Title = "OCCUPIED PER DAY"
			Me.occupiedPerDayChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium
			Me.occupiedPerDayChartView.ChartElement.TitleElement.CustomFontSize = 10f
			Me.occupiedPerDayChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter
			Dim area As CartesianArea = Me.occupiedPerDayChartView.GetArea(Of CartesianArea)()
			area.ShowGrid = True
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalFills = False
			grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.occupiedPerDayChartView.Area.View.Palette = KnownPalette.Rainbow
			Me.trendsChartView.Area.View.Palette = KnownPalette.Rainbow

			Me.trendsChartView.ShowTitle = True
			Me.trendsChartView.Title = "TRENDS"
			Me.trendsChartView.ChartElement.TitleElement.CustomFont = Utils.MainFontMedium
			Me.trendsChartView.ChartElement.TitleElement.CustomFontSize = 10f
			Me.trendsChartView.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter

			Me.trendsRangeSelector.AssociatedControl = Me.trendsChartView
		End Sub

		Private Sub trendsRangeSelector_ScaleInitializing(ByVal sender As Object, ByVal e As ScaleInitializingEventArgs)
			Dim dt As Date
			For Each label As RangeSelectorChartScaleLabelElement In e.ScaleElement.Children
				If Date.TryParse(label.Text, dt) Then
					label.Text = dt.ToString("dd/MM/yyyy")
				End If
			Next label
		End Sub

		Private Sub trendsRangeSelector_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.trendsChartView.Series.Count > 0 Then
				Me.trendsChartView.ChartElement.InvalidateMeasure(True)
				Me.trendsChartView.ChartElement.UpdateLayout()
				Dim ls As LineSeries = TryCast(Me.trendsChartView.Series(0), LineSeries)
				RemoveBorderFromAxis(TryCast(ls.VerticalAxis, LinearAxis), TryCast(ls.HorizontalAxis, CategoricalAxis))
			End If
		End Sub

		Public Sub Initialize(ByVal reportsInterval As String, ByVal bookings As BindingList(Of Booking), ByVal rooms As BindingList(Of Room), ByVal date_Renamed As Date)
			Me.occupiedPerDayChartView.Series.Clear()
			Me.occupiedPerDayChartView.Axes.Clear()
			Me.occupiedPerDayChartView.Annotations.Clear()
			Me.trendsChartView.Series.Clear()
			Me.trendsChartView.Axes.Clear()
			Me.trendsRangeSelector.AssociatedControl = Nothing

			Select Case reportsInterval
				Case "Days"
					LoadChart(bookings, date_Renamed, 3)
				Case "Weekly"
					LoadChart(bookings, date_Renamed, 7)
				Case "Monthly"
					LoadChart(bookings, date_Renamed, 30)
			End Select

			Me.trendsRangeSelector.AssociatedControl = Me.trendsChartView
			Me.trendsRangeSelector.StartRange = 0
			Me.trendsRangeSelector.EndRange = 100
		End Sub

		Private Sub LoadChart(ByVal bookings As BindingList(Of Booking), ByVal date_Renamed As Date, ByVal days As Integer)
			RemoveHandler Me.occupiedPerDayChartView.LabelFormatting, AddressOf occupiedPerDayChartView_LabelFormatting
			AddHandler Me.occupiedPerDayChartView.LabelFormatting, AddressOf occupiedPerDayChartView_LabelFormatting
			Dim barSeries_Renamed As New BarSeries()
			Dim lineSeries_Renamed As New LineSeries()
			barSeries_Renamed.ShowLabels = True
			Dim verticalMaxValue As Integer = 0

			Dim occupiedPerDay As Integer = 0
			For i As Integer = 0 To days - 1
				occupiedPerDay = GetOccupiedRooms(bookings, date_Renamed.AddDays(i))
				barSeries_Renamed.DataPoints.Add(New CategoricalDataPoint(occupiedPerDay, date_Renamed.AddDays(i)))
				lineSeries_Renamed.DataPoints.Add(New CategoricalDataPoint(occupiedPerDay, date_Renamed.AddDays(i)))
				If occupiedPerDay > verticalMaxValue Then
					verticalMaxValue = occupiedPerDay
				End If
			Next i
			Me.occupiedPerDayChartView.Series.Add(barSeries_Renamed)
			Me.trendsChartView.Series.Add(lineSeries_Renamed)

			Dim verticalAxis As LinearAxis = TryCast(barSeries_Renamed.VerticalAxis, LinearAxis)
			verticalAxis.BorderColor = Color.FromArgb(209, 209, 209)
			verticalAxis.CustomFont = Utils.MainFontMedium
			verticalAxis.CustomFontSize = 10f
			verticalAxis.Minimum = 0
			verticalAxis.Maximum = Math.Max(verticalMaxValue, 5)
			verticalAxis.MajorStep = 1

			Dim trendsVerticalAxis As LinearAxis = TryCast(lineSeries_Renamed.VerticalAxis, LinearAxis)
			trendsVerticalAxis.BorderColor = Color.FromArgb(209, 209, 209)
			trendsVerticalAxis.CustomFont = Utils.MainFontMedium
			trendsVerticalAxis.CustomFontSize = 10f
			trendsVerticalAxis.Minimum = 0
			trendsVerticalAxis.Maximum = Math.Max(verticalMaxValue, 5)
			trendsVerticalAxis.MajorStep = verticalMaxValue \ 2

			Dim horizontalAxis As CategoricalAxis = TryCast(barSeries_Renamed.HorizontalAxis, CategoricalAxis)
			If days <= 7 Then
				horizontalAxis.MajorTickInterval = 1
			ElseIf days > 7 Then
				horizontalAxis.MajorTickInterval = 5
			End If
			horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
			horizontalAxis.GapLength = 0.58
			horizontalAxis.CustomFont = Utils.MainFontMedium
			horizontalAxis.CustomFontSize = 10f
			horizontalAxis.LabelFormat = "{0:dd/MM/yyyy}"
			horizontalAxis.BorderColor = Color.FromArgb(209, 209, 209)

			Dim trendsHorizontalAxis As CategoricalAxis = TryCast(lineSeries_Renamed.HorizontalAxis, CategoricalAxis)
			If days <= 7 Then
				trendsHorizontalAxis.MajorTickInterval = 1
			ElseIf days > 7 Then
				trendsHorizontalAxis.MajorTickInterval = 5
			End If
			trendsHorizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
			trendsHorizontalAxis.ClipLabels = True
			trendsHorizontalAxis.CustomFont = Utils.MainFontMedium
			trendsHorizontalAxis.CustomFontSize = 10f
			trendsHorizontalAxis.PlotMode = AxisPlotMode.BetweenTicks
			trendsHorizontalAxis.LabelFormat = "{0:dd/MM/yyyy}"
			trendsHorizontalAxis.BorderColor = Color.FromArgb(209, 209, 209)

			Me.occupiedPerDayChartView.ChartElement.View.Margin = New Padding(60, 20, 40, 20)
			Me.trendsChartView.ChartElement.View.Margin = New Padding(100, 20, 40, 10)

			If verticalMaxValue > 0 Then
				Dim annotation1 As New CartesianGridLineAnnotation()
				annotation1.Axis = verticalAxis
				annotation1.Value = verticalMaxValue
				annotation1.BorderColor = Color.FromArgb(255, 145, 0)
				annotation1.BorderDashStyle = DashStyle.Solid
				annotation1.BorderWidth = 2
				Me.occupiedPerDayChartView.Annotations.Add(annotation1)
			End If
			Me.occupiedPerDayChartView.ChartElement.InvalidateMeasure(True)
			Me.occupiedPerDayChartView.ChartElement.UpdateLayout()
			RemoveBorderFromAxis(verticalAxis, horizontalAxis)

			Me.trendsChartView.ChartElement.InvalidateMeasure(True)
			Me.trendsChartView.ChartElement.UpdateLayout()
			RemoveBorderFromAxis(trendsVerticalAxis, trendsHorizontalAxis)
		End Sub

		Private Sub RemoveBorderFromAxis(ByVal verticalAxis As LinearAxis, ByVal horizontalAxis As CategoricalAxis)
			For Each el As UIChartElement In verticalAxis.Children
				Dim label As AxisLabelElement = TryCast(el, AxisLabelElement)
				If label IsNot Nothing Then
					label.BorderWidth = 0
				End If
			Next el
			For Each el As UIChartElement In horizontalAxis.Children
				Dim label As AxisLabelElement = TryCast(el, AxisLabelElement)
				If label IsNot Nothing Then
					label.BorderWidth = 0
				End If
			Next el
		End Sub

		Private Sub occupiedPerDayChartView_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
			e.LabelElement.BackColor = Color.Transparent
			e.LabelElement.BorderColor = Color.Transparent
		End Sub

		Private Function GetOccupiedRooms(ByVal bookings As BindingList(Of Booking), ByVal date_Renamed As Date) As Integer
			Dim occupiedRooms As Integer = 0
			For Each b As Booking In bookings
				If b.From <= date_Renamed AndAlso b.To >= date_Renamed AndAlso (b.Status = BookingStatus.Actual OrElse b.Status = BookingStatus.Reservation) Then
					occupiedRooms += 1
				End If
			Next b

			Return occupiedRooms
		End Function
	End Class
End Namespace