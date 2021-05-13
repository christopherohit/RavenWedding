Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.StockSeries
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private viewModel As CandlestickViewModel
		Private movingAverageIndicators As List(Of String), financialIndicators As List(Of String)
		Private chartTypes As List(Of String)

		Public Sub New()
			InitializeComponent()
			InitializeData()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radDropDownList1.DataSource = chartTypes
			Me.radDropDownList2.DataSource = movingAverageIndicators
			Me.radDropDownList3.DataSource = financialIndicators

			SetCartesianGrid(Me.radChartView1)
			SetCartesianGrid(Me.radChartView2)
			SetTrackBall()

		End Sub

		Private Sub InitializeData()
			viewModel = New CandlestickViewModel()

			chartTypes = New List(Of String)() From {"OHLC", "HLC", "Candlestick"}

			movingAverageIndicators = New List(Of String)() From {"MA (5)", "Exponential MA (5)", "Modified MA (5)", "Modified Exponential MA (5)", "Weighted MA (5)", "Adaptive MA Kaufman (10,4,2)", "Bollinger Bands (5,2)"}

			financialIndicators = New List(Of String)() From {"Average True Range (5)", "Commodity Channel Index (5)", "MACD (12, 9, 6)", "Momentum (5)", "Oscillator (8, 4)", "RAVI (8, 4)", "Rate Of Change (8)", "Relative Momentum Index (8)", "Relative Strength Index (8)", "Stochastic Fast (14, 3)", "Stochastic Slow (14, 3, 3)", "TRIX (8)", "True Range", "Ultimate Oscillator (6, 9, 12)"}
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			UpdateStockSeries()
		End Sub

		Private Sub radDropDownList2_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			UpdateStockSeries()
		End Sub

		Private Sub UpdateStockSeries()
			Dim horizontalAxis As DateTimeCategoricalAxis = TryCast(Me.radChartView2.Axes(0), DateTimeCategoricalAxis)
			Dim verticalAxis As LinearAxis = TryCast(Me.radChartView2.Axes(1), LinearAxis)

			Me.radChartView2.Series.Clear()

			If Me.radDropDownList1.SelectedItem IsNot Nothing Then
				Dim seriesType As String = Me.radDropDownList1.SelectedItem.Text

				If seriesType = "Candlestick" OrElse seriesType = "OHLC" Then
					Dim series As OhlcSeries = If(seriesType = "Candlestick", New CandlestickSeries(), New OhlcSeries())

					series.BorderColor = Color.FromArgb(102, 102, 102)
					series.BackColor = Color.FromArgb(102, 102, 102)
					series.HorizontalAxis = horizontalAxis
					series.VerticalAxis = verticalAxis
					series.OpenValueMember = "Open"
					series.HighValueMember = "High"
					series.LowValueMember = "Low"
					series.CloseValueMember = "Close"
					series.CategoryMember = "Date"
					series.DataSource = viewModel.Data

					Me.radChartView2.Series.Add(series)

					If Not(TypeOf series Is CandlestickSeries) Then
						For Each point As OhlcPointElement In series.Children
							If point.IsFalling Then
								point.BorderColor = Color.FromArgb(175, 175, 175)
							End If
						Next point
					End If
				Else
					Dim series As New HlcSeries()

					series.BorderColor = Color.FromArgb(102, 102, 102)
					series.BackColor = Color.FromArgb(102, 102, 102)
					series.HorizontalAxis = horizontalAxis
					series.VerticalAxis = verticalAxis
					series.HighValueMember = "High"
					series.LowValueMember = "Low"
					series.CloseValueMember = "Close"
					series.CategoryMember = "Date"
					series.DataSource = viewModel.Data

					Me.radChartView2.Series.Add(series)
				End If
			End If

			If Me.radDropDownList2.SelectedItem IsNot Nothing Then
				Dim indicator As IndicatorBase = CreateMAIndicator(Me.radDropDownList2.SelectedItem.Text)
				indicator.BorderColor = Color.Red
				indicator.PointSize = SizeF.Empty

				Dim parentIndicator As IParentIndicator = TryCast(indicator, IParentIndicator)
				If parentIndicator IsNot Nothing Then
					parentIndicator.ChildIndicator.BorderColor = Color.Black
				End If

				Me.radChartView2.Series.Add(indicator)
			End If
		End Sub

		Private Sub radDropDownList3_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radChartView1.View.Margin = New Padding(15, 10, 10, 10)
			UpdateFinancialIndicator(Me.radDropDownList3.SelectedItem.Text)
		End Sub

		Private Sub UpdateFinancialIndicator(ByVal indicatorType As String)
			Dim horizontalAxis As DateTimeCategoricalAxis = TryCast(Me.radChartView1.Axes(0), DateTimeCategoricalAxis)
			Dim verticalAxis As LinearAxis = TryCast(Me.radChartView1.Axes(1), LinearAxis)

			Me.radChartView1.Series.Clear()

			Dim indicator As IndicatorBase = CreateFinancialIndicator(indicatorType)
			indicator.HorizontalAxis = horizontalAxis
			indicator.VerticalAxis = verticalAxis
			indicator.PointSize = SizeF.Empty
			indicator.BorderColor = Color.Black

			Dim parentIndicator As IParentIndicator = TryCast(indicator, IParentIndicator)
			If parentIndicator IsNot Nothing Then
				parentIndicator.ChildIndicator.BorderColor = Color.Red
			End If

			Me.radChartView1.Series.Add(indicator)
		End Sub

		Private Sub SetCartesianGrid(ByVal chart As RadChartView)
			Dim area As CartesianArea = chart.GetArea(Of CartesianArea)()
			area.ShowGrid = True

			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalFills = False
			grid.DrawVerticalFills = False
			grid.DrawHorizontalStripes = True
			grid.DrawVerticalStripes = True
			grid.ForeColor = Color.LightGray
			grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
		End Sub

		Private Sub SetTrackBall()
			Dim trackBallElement As New ChartTrackballController()

			trackBallElement.Element.TextAlignment = ContentAlignment.MiddleLeft
			trackBallElement.Element.BorderColor = Color.Black
			trackBallElement.Element.BackColor = Color.White
			trackBallElement.Element.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
			trackBallElement.Element.GradientStyle = Telerik.WinControls.GradientStyles.Solid
			trackBallElement.Element.Padding = New Padding(3, 0, 3, 3)

			Me.radChartView2.Controllers.Add(trackBallElement)
		End Sub


		Private Sub ConfigureAxis(ByVal min As Double, ByVal max As Double, ByVal majorStep As Double)
			Dim axis As LinearAxis = TryCast(Me.radChartView1.Axes(1), LinearAxis)
			If axis Is Nothing Then
				Return
			End If

			axis.Minimum = min
			axis.Maximum = max
			axis.MajorStep = majorStep
		End Sub

		Private Function CreateMAIndicator(ByVal indicatorType As String) As IndicatorBase
			Dim indicator As IndicatorBase

			If indicatorType.StartsWith("MA (") Then
				indicator = New MovingAverageIndicator()
				indicator.Name = "MA"
			ElseIf indicatorType.StartsWith("Exponential MA") Then
				indicator = New ExponentialMovingAverageIndicator()
				indicator.Name = "EMA"
			ElseIf indicatorType.StartsWith("Modified MA") Then
				indicator = New ModifiedMovingAverageIndicator()
				indicator.Name = "MMA"
			ElseIf indicatorType.StartsWith("Modified Exponential MA") Then
				indicator = New ModifiedExponentialMovingAverageIndicator()
				indicator.Name = "MEMA"
			ElseIf indicatorType.StartsWith("Weighted MA") Then
				indicator = New WeightedMovingAverageIndicator()
				indicator.Name = "WMA"
			ElseIf indicatorType.StartsWith("Adaptive MA") Then
				indicator = New AdaptiveMovingAverageKaufmanIndicator()
				indicator.Name = "KAMA"
				CType(indicator, AdaptiveMovingAverageKaufmanIndicator).SlowPeriod = 10
				CType(indicator, AdaptiveMovingAverageKaufmanIndicator).FastPeriod = 4
			Else
				indicator = New BollingerBandsIndicator()
				indicator.Name = "BOLL"
				CType(indicator, BollingerBandsIndicator).StandardDeviations = 2
			End If

			CType(indicator, ValuePeriodIndicatorBase).Period = 5
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			Return indicator
		End Function

		Private Function CreateFinancialIndicator(ByVal indicatorType As String) As IndicatorBase
			If indicatorType.StartsWith("Average True Range") Then
				Return CreateAverageTrueRangeIndicator()
			ElseIf indicatorType.StartsWith("Commodity Channel Index") Then
				Return CreateCommodityChannelIndexIndicator()
			ElseIf indicatorType.StartsWith("MACD") Then
				Return CreateMACDIndicator()
			ElseIf indicatorType.StartsWith("Momentum") Then
				Return CreateMomentumIndicator()
			ElseIf indicatorType.StartsWith("Oscillator") Then
				Return CreateOscillatorIndicator()
			ElseIf indicatorType.StartsWith("RAVI") Then
				Return CreateRaviIndicator()
			ElseIf indicatorType.StartsWith("Rate Of Change") Then
				Return CreateRateOfChangeIndicator()
			ElseIf indicatorType.StartsWith("Relative Momentum Index") Then
				Return CreateRelativeMomentumIndexIndicator()
			ElseIf indicatorType.StartsWith("Relative Strength Index") Then
				Return CreateRelativeStrengthIndexIndicator()
			ElseIf indicatorType.StartsWith("Stochastic Fast") Then
				Return CreateStochasticFastIndicator()
			ElseIf indicatorType.StartsWith("Stochastic Slow") Then
				Return CreateStochasticSlowIndicator()
			ElseIf indicatorType.StartsWith("True Range") Then
				Return CreateTrueRangeIndicator()
			ElseIf indicatorType.StartsWith("TRIX") Then
				Return CreateTrixIndicator()
			End If
			Return CreateUltimateOscillatorIndicator()
		End Function

		Private Function CreateAverageTrueRangeIndicator() As AverageTrueRangeIndicator
			Dim indicator As New AverageTrueRangeIndicator()
			indicator.Period = 5
			indicator.CategoryMember = "Date"
			indicator.HighValueMember = "High"
			indicator.LowValueMember = "Low"
			indicator.CloseValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(0, 5, 1)

			Return indicator
		End Function

		Private Function CreateCommodityChannelIndexIndicator() As CommodityChannelIndexIndicator
			Dim indicator As New CommodityChannelIndexIndicator()
			indicator.Period = 5
			indicator.CategoryMember = "Date"
			indicator.HighValueMember = "High"
			indicator.LowValueMember = "Low"
			indicator.CloseValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(-200, 200, 100)

			Return indicator
		End Function


		Private Function CreateMACDIndicator() As IndicatorBase
			Dim indicator As New MacdIndicator()
			indicator.ShortPeriod = 9
			indicator.LongPeriod = 12
			indicator.SignalPeriod = 6
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(-2, 2, 1)

			Return indicator
		End Function

		Private Function CreateMomentumIndicator() As MomentumIndicator
			Dim indicator As New MomentumIndicator()
			indicator.Period = 8
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(80, 120, 10)

			Return indicator
		End Function

		Private Function CreateOscillatorIndicator() As OscillatorIndicator
			Dim indicator As New OscillatorIndicator()
			indicator.ShortPeriod = 4
			indicator.LongPeriod = 8
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(-5, 5, 5)

			Return indicator
		End Function

		Private Function CreateRaviIndicator() As RaviIndicator
			Dim indicator As New RaviIndicator()
			indicator.ShortPeriod = 4
			indicator.LongPeriod = 8
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(-5, 5, 5)

			Return indicator
		End Function

		Private Function CreateRateOfChangeIndicator() As RateOfChangeIndicator
			Dim indicator As New RateOfChangeIndicator()
			indicator.Period = 8
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(-20, 20, 10)

			Return indicator
		End Function

		Private Function CreateRelativeMomentumIndexIndicator() As RelativeMomentumIndexIndicator
			Dim indicator As New RelativeMomentumIndexIndicator()
			indicator.Period = 8
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(0, 100, 20)

			Return indicator
		End Function

		Private Function CreateRelativeStrengthIndexIndicator() As RelativeStrengthIndexIndicator
			Dim indicator As New RelativeStrengthIndexIndicator()
			indicator.Period = 8
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(0, 100, 20)

			Return indicator
		End Function

		Private Function CreateStochasticFastIndicator() As StochasticFastIndicator
			Dim indicator As New StochasticFastIndicator()
			indicator.MainPeriod = 14
			indicator.SignalPeriod = 3
			indicator.CategoryMember = "Date"
			indicator.HighValueMember = "High"
			indicator.LowValueMember = "Low"
			indicator.CloseValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(0, 100, 20)

			Return indicator
		End Function

		Private Function CreateStochasticSlowIndicator() As StochasticSlowIndicator
			Dim indicator As New StochasticSlowIndicator()
			indicator.MainPeriod = 14
			indicator.SignalPeriod = 3
			indicator.SlowingPeriod = 3
			indicator.CategoryMember = "Date"
			indicator.HighValueMember = "High"
			indicator.LowValueMember = "Low"
			indicator.CloseValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(0, 100, 20)

			Return indicator
		End Function

		Private Function CreateTrixIndicator() As TrixIndicator
			Dim indicator As New TrixIndicator()
			indicator.Period = 8
			indicator.CategoryMember = "Date"
			indicator.ValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(-1, 1, 0.5)

			Return indicator
		End Function

		Private Function CreateTrueRangeIndicator() As TrueRangeIndicator
			Dim indicator As New TrueRangeIndicator()
			indicator.CategoryMember = "Date"
			indicator.HighValueMember = "High"
			indicator.LowValueMember = "Low"
			indicator.CloseValueMember = "Close"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(0, 6, 1)

			Return indicator
		End Function

		Private Function CreateUltimateOscillatorIndicator() As UltimateOscillatorIndicator
			Dim indicator As New UltimateOscillatorIndicator()
			indicator.Period = 6
			indicator.Period2 = 9
			indicator.Period3 = 12
			indicator.CategoryMember = "Date"
			indicator.CloseValueMember = "Close"
			indicator.HighValueMember = "High"
			indicator.LowValueMember = "Low"
			indicator.DataSource = viewModel.Data

			ConfigureAxis(0, 100, 20)

			Return indicator
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			AddHandler radDropDownList2.SelectedIndexChanged, AddressOf radDropDownList2_SelectedIndexChanged
			AddHandler radDropDownList3.SelectedIndexChanged, AddressOf radDropDownList3_SelectedIndexChanged
		End Sub
	End Class
End Namespace
