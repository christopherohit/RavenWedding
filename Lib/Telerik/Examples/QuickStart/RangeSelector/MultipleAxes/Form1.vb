Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.RangeSelector.MultipleAxes
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			SetupChartAndSelectors()
			SetupEvents()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			TryCast(Me.radRangeSelector1.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement).View.Palette = KnownPalette.Metro
			TryCast(Me.radRangeSelector2.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement).View.Series(0).Palette = KnownPalette.Metro.GlobalEntries(2)
			TryCast(Me.radRangeSelector2.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement).View.Series(1).Palette = KnownPalette.Metro.GlobalEntries(3)
		End Sub

		Private Sub SetupChartAndSelectors()
			Me.radChartView1.View.Margin = New Padding(0, 0, 10, 0)

			Dim horizontalAxis1 As New CategoricalAxis()
			horizontalAxis1.Title = "axe1"
			horizontalAxis1.TitleElement.Padding = New Padding(0, -10, 0, 0)
			horizontalAxis1.TitleElement.IsVisible = False
			horizontalAxis1.AxisType = AxisType.First
			Dim horizontalAxis2 As New CategoricalAxis()
			horizontalAxis2.AxisType = AxisType.First
			horizontalAxis2.VerticalLocation = AxisVerticalLocation.Top
			horizontalAxis2.Title = "axe2"
			horizontalAxis2.TitleElement.Padding = New Padding(0, -10, 0, 0)
			horizontalAxis2.TitleElement.IsVisible = False
			Dim horizontalAxis3 As New CategoricalAxis()
			horizontalAxis3.AxisType = AxisType.First
			Dim verticalAxis1 As New LinearAxis()
			horizontalAxis3.Title = "axe3"
			horizontalAxis3.TitleElement.Padding = New Padding(0, -10, 0, 0)
			horizontalAxis3.TitleElement.IsVisible = False
			verticalAxis1.AxisType = AxisType.Second

			Dim series1 As New LineSeries()
			series1.Name = "series1"
			series1.HorizontalAxis = horizontalAxis1
			series1.VerticalAxis = verticalAxis1

			Dim series2 As New LineSeries()
			series2.Name = "series2"
			series2.HorizontalAxis = horizontalAxis1
			series2.VerticalAxis = verticalAxis1

			Dim series3 As New LineSeries()
			series3.Name = "series3"
			series3.HorizontalAxis = horizontalAxis2
			series3.VerticalAxis = verticalAxis1

			Dim series4 As New LineSeries()
			series4.Name = "series4"
			series4.HorizontalAxis = horizontalAxis3
			series4.VerticalAxis = verticalAxis1

			series1.DataPoints.Add(New CategoricalDataPoint(3.5, "Jan"))
			series1.DataPoints.Add(New CategoricalDataPoint(2.8, "Feb"))
			series1.DataPoints.Add(New CategoricalDataPoint(3.4, "Mar"))

			series1.DataPoints.Add(New CategoricalDataPoint(3.2, "Apr"))
			series1.DataPoints.Add(New CategoricalDataPoint(3.4, "May"))
			series1.DataPoints.Add(New CategoricalDataPoint(2.9, "Jun"))

			series1.DataPoints.Add(New CategoricalDataPoint(3.7, "Jul"))
			series1.DataPoints.Add(New CategoricalDataPoint(3.1, "Aug"))
			series1.DataPoints.Add(New CategoricalDataPoint(2.9, "Sep"))

			series1.DataPoints.Add(New CategoricalDataPoint(3.3, "Oct"))
			series1.DataPoints.Add(New CategoricalDataPoint(3.1, "Nov"))
			series1.DataPoints.Add(New CategoricalDataPoint(3.6, "Dec"))


			series2.DataPoints.Add(New CategoricalDataPoint(4.5, "Jan"))
			series2.DataPoints.Add(New CategoricalDataPoint(1.8, "Feb"))
			series2.DataPoints.Add(New CategoricalDataPoint(3.0, "Mar"))

			series2.DataPoints.Add(New CategoricalDataPoint(3.8, "Apr"))
			series2.DataPoints.Add(New CategoricalDataPoint(2.4, "May"))
			series2.DataPoints.Add(New CategoricalDataPoint(4.9, "Jun"))

			series2.DataPoints.Add(New CategoricalDataPoint(4.1, "Jul"))
			series2.DataPoints.Add(New CategoricalDataPoint(2.1, "Aug"))
			series2.DataPoints.Add(New CategoricalDataPoint(3.9, "Sep"))

			series2.DataPoints.Add(New CategoricalDataPoint(5.3, "Oct"))
			series2.DataPoints.Add(New CategoricalDataPoint(3.5, "Nov"))
			series2.DataPoints.Add(New CategoricalDataPoint(4.6, "Dec"))


			series3.DataPoints.Add(New CategoricalDataPoint(4.8, "1999"))
			series3.DataPoints.Add(New CategoricalDataPoint(5.2, "2000"))
			series3.DataPoints.Add(New CategoricalDataPoint(6, "2001"))
			series3.DataPoints.Add(New CategoricalDataPoint(5.8, "2002"))
			series3.DataPoints.Add(New CategoricalDataPoint(5.4, "2003"))
			series3.DataPoints.Add(New CategoricalDataPoint(5.6, "2004"))
			series3.DataPoints.Add(New CategoricalDataPoint(5, "2005"))
			series3.DataPoints.Add(New CategoricalDataPoint(4.7, "2006"))
			series3.DataPoints.Add(New CategoricalDataPoint(4.6, "2007"))
			series3.DataPoints.Add(New CategoricalDataPoint(4.2, "2008"))
			series3.DataPoints.Add(New CategoricalDataPoint(5.3, "2009"))
			series3.DataPoints.Add(New CategoricalDataPoint(4.9, "2010"))
			series3.DataPoints.Add(New CategoricalDataPoint(4.1, "2011"))
			series3.DataPoints.Add(New CategoricalDataPoint(7.9, "2012"))
			series3.DataPoints.Add(New CategoricalDataPoint(3.5, "2013"))

			series4.DataPoints.Add(New CategoricalDataPoint(6.23, "Q1"))
			series4.DataPoints.Add(New CategoricalDataPoint(7.5, "Q2"))
			series4.DataPoints.Add(New CategoricalDataPoint(5.8, "Q3"))
			series4.DataPoints.Add(New CategoricalDataPoint(6.95, "Q4"))

			Me.radChartView1.Series.Add(series1)
			Me.radChartView1.Series.Add(series2)
			Me.radChartView1.Series.Add(series3)
			Me.radChartView1.Series.Add(series4)

			Me.radChartView1.View.Palette = KnownPalette.Metro

			Me.radRangeSelector1.AssociatedControl = Me.radChartView1
			Me.radRangeSelector2.AssociatedControl = Me.radChartView1
			Me.radChartView1.BackColor = Color.White

		End Sub

		Private Sub SetupEvents()
			AddHandler radRangeSelector1.ScaleInitializing, AddressOf radRangeSelector1_ScaleInitializing
			AddHandler radRangeSelector2.ScaleInitializing, AddressOf radRangeSelector2_ScaleInitializing

			Dim rangeSelectorChart1 As RangeSelectorViewElement = TryCast(Me.radRangeSelector1.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement)
			If rangeSelectorChart1 IsNot Nothing Then
				AddHandler rangeSelectorChart1.SeriesInitializing, AddressOf rangeSelectorChart1_SeriesInitializing
			End If

			Dim rangeSelectorChart2 As RangeSelectorViewElement = TryCast(Me.radRangeSelector2.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement)
			If rangeSelectorChart2 IsNot Nothing Then
				AddHandler rangeSelectorChart2.SeriesInitializing, AddressOf rangeSelectorChart2_SeriesInitializing
			End If

			AddHandler radRangeSelector1.ThumbLeftValueChanged, AddressOf radRangeSelector1_ThumbLeftValueChanged
			AddHandler radRangeSelector1.ThumbRightValueChanged, AddressOf radRangeSelector1_ThumbRightValueChanged
			AddHandler radRangeSelector2.ThumbLeftValueChanged, AddressOf radRangeSelector2_ThumbLeftValueChanged
			AddHandler radRangeSelector2.ThumbRightValueChanged, AddressOf radRangeSelector2_ThumbRightValueChanged
		End Sub

		#Region "Event Handlers"

		Private Sub radRangeSelector1_ScaleInitializing(ByVal sender As Object, ByVal e As ScaleInitializingEventArgs)
			Dim scaleElement As RangeSelectorChartScaleContainerElement = TryCast(e.ScaleElement, RangeSelectorChartScaleContainerElement)
			If scaleElement Is Nothing Then
				Return
			End If
			If Not(scaleElement.Title = "axe1") Then
				e.Cancel = True
			End If
		End Sub

		Private Sub rangeSelectorChart1_SeriesInitializing(ByVal sender As Object, ByVal e As SeriesInitializingEventArgs)
			If e.Series.Name = "series1" OrElse e.Series.Name = "series2" Then
				e.SeriesType = GetType(BarSeries)
			Else
				e.Cancel = True
			End If
		End Sub

		Private Sub radRangeSelector2_ScaleInitializing(ByVal sender As Object, ByVal e As ScaleInitializingEventArgs)
			Dim scaleElement As RangeSelectorChartScaleContainerElement = TryCast(e.ScaleElement, RangeSelectorChartScaleContainerElement)
			If scaleElement Is Nothing Then
				Return
			End If

			If scaleElement.Title = "axe2" Then
				For Each item As RangeSelectorChartScaleLabelElement In e.ScaleElement.Children
					item.ForeColor = Color.FromArgb(255, 166, 105, 64)
				Next item
			ElseIf scaleElement.Title = "axe3" Then
				e.ScaleElement.ScalePostion = ViewPosition.TopLeft
				For Each item As RangeSelectorChartScaleLabelElement In e.ScaleElement.Children
					item.ForeColor = Color.FromArgb(255, 142, 196, 65)
				Next item
			Else
				e.Cancel = True
			End If
		End Sub

		Private Sub rangeSelectorChart2_SeriesInitializing(ByVal sender As Object, ByVal e As SeriesInitializingEventArgs)
			If e.Series.Name = "series3" OrElse e.Series.Name = "series4" Then
				e.SeriesType = GetType(AreaSeries)
			Else
				e.Cancel = True
			End If
		End Sub


		Private Sub radRangeSelector1_ThumbLeftValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRangeSelector2.StartRange = Me.radRangeSelector1.StartRange
		End Sub

		Private Sub radRangeSelector1_ThumbRightValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRangeSelector2.EndRange = Me.radRangeSelector1.EndRange
		End Sub

		Private Sub radRangeSelector2_ThumbLeftValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRangeSelector1.StartRange = Me.radRangeSelector2.StartRange
		End Sub

		Private Sub radRangeSelector2_ThumbRightValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radRangeSelector1.EndRange = Me.radRangeSelector2.EndRange
		End Sub

		#End Region
	End Class
End Namespace
