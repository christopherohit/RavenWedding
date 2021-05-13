Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.RangeSelector.MSFTStocks
	Partial Public Class Form1
		Inherits ExamplesForm
		Private listOfDates As New List(Of Integer)()

		Public Sub New()
			InitializeComponent()

			SetupCharts()

			'Setup range selector
			radRangeSelector1.AssociatedControl = radChartView1
			radRangeSelector1.RangeSelectorElement.EnableFastScrolling = True
			AddHandler radRangeSelector1.SelectionChanged, AddressOf radRangeSelector1_SelectionChanged
			AddHandler (CType(radRangeSelector1.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement)).LabelInitializing, AddressOf RangeSelectorViewElement_LabelInitializing

			Me.radChartView1.View.Margin = New Padding(10, 0, 0, 0)
			Me.radChartView2.View.Margin = New Padding(0, 0, 0, 15)
			Me.radChartView1.BackColor = Color.White
			Me.radChartView2.BackColor = Color.White
		End Sub


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			'Hide the bar series from the selector
			Dim rangeChart As RangeSelectorViewElement = (CType(radRangeSelector1.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement))
			rangeChart.View.Series(0).IsVisible = False
			rangeChart.View.Series(1).Palette = KnownPalette.Sun.GlobalEntries(0)

			UpdateBarChartView()
		End Sub

		Private Sub SetupCharts()
			Dim data As DataTable = GetDataTableFromCsv("..\RangeSelector\MSFTStocks\ExampleData.csv", True)

			'Setup OHLC series. This is the series displayed in the upper chart.
			Dim ohlcSeries As New CandlestickSeries()
			ohlcSeries.CloseValueMember = "Close"
			ohlcSeries.HighValueMember = "High"
			ohlcSeries.LowValueMember = "Low"
			ohlcSeries.OpenValueMember = "Open"
			ohlcSeries.CategoryMember = "Date"
			ohlcSeries.DataSource = data
			radChartView1.Series.Add(ohlcSeries)
			CType(ohlcSeries.HorizontalAxis, CategoricalAxis).MajorTickInterval = 20
			CType(ohlcSeries.HorizontalAxis, CategoricalAxis).LabelFormat = "{0:MMM yy}"

			'Setup a line series and add it to the upper chart. Make it invisible. It will be used by the range selector. 
			Dim lineSeries As New LineSeries()
			lineSeries.ValueMember = "Close"
			lineSeries.CategoryMember = "Date"
			lineSeries.DataSource = data
			lineSeries.BorderWidth = 0
			radChartView1.Series.Add(lineSeries)

			'Setup upper chart
			radChartView1.View.Palette = KnownPalette.Sun
			radChartView1.ShowTitle = True
			radChartView1.Title = "Microsoft Corporation (MSFT)-NasdaqGS"

			Dim controller As New ChartTrackballController()
			radChartView1.Controllers.Add(controller)
			AddHandler controller.TextNeeded, AddressOf controller_TextNeeded

			'Setup bar series for the second chart
			Dim barSeries As New BarSeries()
			barSeries.DataSource = data
			barSeries.ValueMember = "Volume"
			barSeries.CategoryMember = "Date"
			radChartView2.Series.Add(barSeries)
			barSeries.HorizontalAxis.IsVisible = False
			barSeries.VerticalAxis.LabelFormatProvider = New StringLimiterFormatProvider()
			barSeries.VerticalAxis.LabelFormat = "{0}M"

			'Setup the bottom chart
			radChartView2.View.Palette = KnownPalette.Metro
			radChartView2.ShowTitle = True
			radChartView2.Title = "Volume"
			radChartView2.View.Margin = New Padding(4, 0, 40, 5) 'make its axes equal to the upper one

			Dim controller2 As New ChartTrackballController()
			radChartView2.Controllers.Add(controller2)
			AddHandler controller2.TextNeeded, AddressOf controller_TextNeeded
		End Sub

		Private Sub radRangeSelector1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			'when the selection in the range selector is changed, update the bottom chart
			UpdateBarChartView()
		End Sub

		Private Sub RangeSelectorViewElement_LabelInitializing(ByVal sender As Object, ByVal e As LabelInitializingEventArgs)
			'Show just year labels
			Dim [date] As Date = Date.Parse(e.LabelElement.Text)
			If Not listOfDates.Contains([date].Year) Then
				listOfDates.Add([date].Year)
				e.LabelElement.Text = String.Format("{0:yyyy}", [date])
				e.LabelElement.AngleTransform = 45
			Else
				e.Cancel = True
			End If
		End Sub

		Private Sub controller_TextNeeded(ByVal sender As Object, ByVal e As TextNeededEventArgs)
			Dim pattern As String = "\d\d\d,\d\d\d,\d\d\d,\d+"
			Dim replacement As String = "black"
			Dim rgx As New Regex(pattern)
			e.Text = rgx.Replace(e.Text, replacement)
		End Sub

		Private Sub UpdateBarChartView()
			Dim zoomFactor As Double = 100R / (Me.radRangeSelector1.EndRange - Me.radRangeSelector1.StartRange)

			If zoomFactor < 1R Then
				zoomFactor = 1R
			End If

			If zoomFactor > 100R Then
				zoomFactor = 100R
			End If

			Dim areaSize As SizeF = (CType(Me.radRangeSelector1.RangeSelectorElement.AssociatedElement, RangeSelectorViewElement)).AreaSize

			Dim pan As Double = (((areaSize.Width - 1) * zoomFactor) / 100) * Me.radRangeSelector1.StartRange

			radChartView2.View.Zoom(zoomFactor, 1)
			radChartView2.View.Pan(-pan, 0)
		End Sub


		Private Shared Function GetDataTableFromCsv(ByVal path As String, ByVal isFirstRowHeader As Boolean) As DataTable
			Dim header As String = If(isFirstRowHeader, "Yes", "No")

            Dim pathOnly As String = System.IO.Path.GetDirectoryName(path)
            Dim fileName As String = System.IO.Path.GetFileName(path)

            Dim sql As String = "SELECT * FROM [" & fileName & "]"

			Using connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pathOnly & ";Extended Properties=""Text;HDR=" & header & """")
			Using command As New OleDbCommand(sql, connection)
			Using adapter As New OleDbDataAdapter(command)
				Dim dataTable As New DataTable()
				dataTable.Locale = CultureInfo.CurrentCulture
				adapter.Fill(dataTable)
				Return dataTable
			End Using
			End Using
			End Using
		End Function
	End Class
End Namespace
