Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.SmartLabels
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private data As New DataModel()
		Private smartLabelsController As SmartLabelsController

		Public Sub New()
			InitializeComponent()

			Me.doubleBufferedTableLayoutPanel2.BackColor = Color.White

			AddHandler Me.radChartView1.LabelFormatting, AddressOf radChartView_LabelFormatting
			AddHandler Me.radChartView2.LabelFormatting, AddressOf radChartView_LabelFormatting

			Me.InitializePie()

			Me.radChartView1.View.Margin = New Padding(20)
			Me.radChartView1.Title = "Smart Labels OFF"
			Me.radChartView2.Title = "Smart Labels ON"
			Me.radChartView1.ShowTitle = True
			Me.radChartView2.ShowTitle = True
			Me.radChartView1.ChartElement.TitlePosition = TitlePosition.Top
			Me.radChartView2.ChartElement.TitlePosition = TitlePosition.Top
			Me.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter
			Me.radChartView2.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter

			Me.smartLabelsController = New SmartLabelsController()
			Me.radChartView2.Controllers.Add(Me.smartLabelsController)

			AddHandler Me.radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
			Dim chartTypes As New List(Of String)()

			chartTypes.Add("Pie")
			chartTypes.Add("Line")
			chartTypes.Add("Bar")
			chartTypes.Add("Scatter")

			Me.radDropDownList1.DataSource = chartTypes
		End Sub

		Private Sub InitializeLine()
			Me.radChartView1.AreaType = ChartAreaType.Cartesian
			Me.radChartView2.AreaType = ChartAreaType.Cartesian

			Dim line As New LineSeries()
			line.ShowLabels = True
			line.LegendTitle = "Desktop Internet users"
			line.DrawLinesToLabels = Me.radCheckBox1.Checked
			line.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			Dim smartLine As New LineSeries()
			smartLine.ShowLabels = True
			smartLine.LegendTitle = "Desktop Internet users"
			smartLine.DrawLinesToLabels = Me.radCheckBox1.Checked
			smartLine.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			For Each dataItem As KeyValuePair(Of Double, Object) In Me.data.GetLineOneData()
				Dim point As New CategoricalDataPoint(dataItem.Key, dataItem.Value)
				point.Label = point.Value
				line.DataPoints.Add(point)

				point = New CategoricalDataPoint(dataItem.Key, dataItem.Value)
				point.Label = point.Value
				smartLine.DataPoints.Add(point)
			Next dataItem

			Dim line2 As New LineSeries()
			line2.ShowLabels = True
			line2.LegendTitle = "Desktop Internet users"
			line2.DrawLinesToLabels = Me.radCheckBox1.Checked
			line2.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			Dim smartLine2 As New LineSeries()
			smartLine2.ShowLabels = True
			smartLine2.LegendTitle = "Desktop Internet users"
			smartLine2.DrawLinesToLabels = Me.radCheckBox1.Checked
			smartLine2.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			For Each dataItem As KeyValuePair(Of Double, Object) In Me.data.GetLineTwoData()
				Dim point As New CategoricalDataPoint(dataItem.Key, dataItem.Value)
				point.Label = point.Value
				line2.DataPoints.Add(point)

				point = New CategoricalDataPoint(dataItem.Key, dataItem.Value)
				point.Label = point.Value
				smartLine2.DataPoints.Add(point)
			Next dataItem

			Me.radChartView1.Series.Add(line)
			Me.radChartView1.Series.Add(line2)

			Me.radChartView2.Series.Add(smartLine)
			Me.radChartView2.Series.Add(smartLine2)
		End Sub

		Private Sub InitializePie()
			Me.radChartView1.AreaType = ChartAreaType.Pie
			Me.radChartView2.AreaType = ChartAreaType.Pie

			Dim pie As New PieSeries()
			pie.LabelMode = PieLabelModes.Horizontal
			pie.ShowLabels = True
			pie.DrawLinesToLabels = Me.radCheckBox1.Checked
			pie.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			Dim smartPie As New PieSeries()
			smartPie.LabelMode = PieLabelModes.Horizontal
			smartPie.ShowLabels = True
			smartPie.DrawLinesToLabels = Me.radCheckBox1.Checked
			smartPie.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			For Each dataItem As KeyValuePair(Of Double, Object) In Me.data.GetPieData()
				Dim point As New PieDataPoint(dataItem.Key, dataItem.Value.ToString())
				point.Label = dataItem.Value.ToString()
				pie.DataPoints.Add(point)

				point = New PieDataPoint(dataItem.Key, dataItem.Value.ToString())
				point.Label = dataItem.Value.ToString()
				smartPie.DataPoints.Add(point)
			Next dataItem

			Me.radChartView1.Series.Add(pie)
			Me.radChartView2.Series.Add(smartPie)

			Me.radCheckBox1.Checked = True
		End Sub

		Private Sub InitializeScatter()
			Me.radChartView1.AreaType = ChartAreaType.Cartesian
			Me.radChartView2.AreaType = ChartAreaType.Cartesian

			Me.radChartView1.ShowGrid = True
			Me.radChartView2.ShowGrid = True

			Dim scatter As New ScatterSeries()
			scatter.LegendTitle = "Area/Price ratio New York"
			scatter.ShowLabels = True
			scatter.DrawLinesToLabels = Me.radCheckBox1.Checked
			scatter.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			Dim scatter2 As New ScatterSeries()
			scatter2.LegendTitle = "Area/Price ratio Los Angeles"
			scatter2.ShowLabels = True
			scatter2.DrawLinesToLabels = Me.radCheckBox1.Checked
			scatter2.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			Dim smartScatter As New ScatterSeries()
			smartScatter.LegendTitle = "Area/Price ratio New York"
			smartScatter.ShowLabels = True
			smartScatter.DrawLinesToLabels = Me.radCheckBox1.Checked
			smartScatter.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			Dim smartScatter2 As New ScatterSeries()
			smartScatter2.LegendTitle = "Area/Price ratio Los Angeles"
			smartScatter2.ShowLabels = True
			smartScatter2.DrawLinesToLabels = Me.radCheckBox1.Checked
			smartScatter2.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

			Dim points As List(Of KeyValuePair(Of Double,Double)) = Me.data.GetScatterData()

			For i As Integer = 0 To points.Count \ 2 - 1
				Dim point As New ScatterDataPoint(points(i).Key, points(i).Value)
				point.Label = String.Format("{0:F2}", point.XValue / point.YValue)
				scatter.DataPoints.Add(point)

				point = New ScatterDataPoint(points(i).Key, points(i).Value)
				point.Label = String.Format("{0:F2}", point.XValue / point.YValue)
				smartScatter.DataPoints.Add(point)
			Next i

			For i As Integer = points.Count \ 2 To points.Count - 1
				Dim point As New ScatterDataPoint(points(i).Key, points(i).Value)
				point.Label = String.Format("{0:F2}", point.XValue / point.YValue)
				scatter2.DataPoints.Add(point)

				point = New ScatterDataPoint(points(i).Key, points(i).Value)
				point.Label = String.Format("{0:F2}", point.XValue / point.YValue)
				smartScatter2.DataPoints.Add(point)
			Next i

			Me.radChartView1.Series.Add(scatter)
			Me.radChartView1.Series.Add(scatter2)
			Me.radChartView2.Series.Add(smartScatter)
			Me.radChartView2.Series.Add(smartScatter2)

			CType(scatter.VerticalAxis, LinearAxis).Maximum = 110
			CType(scatter.VerticalAxis, LinearAxis).DesiredTickCount = 12
			CType(scatter.VerticalAxis, LinearAxis).Title = "Price(USD/per sq.ft.)"
			CType(scatter.HorizontalAxis, LinearAxis).Maximum = 110
			CType(scatter.HorizontalAxis, LinearAxis).DesiredTickCount = 12
			CType(scatter.HorizontalAxis, LinearAxis).Title = "Property area (sq.ft.)"

			CType(smartScatter.VerticalAxis, LinearAxis).Maximum = 110
			CType(smartScatter.VerticalAxis, LinearAxis).DesiredTickCount = 12
			CType(smartScatter.VerticalAxis, LinearAxis).Title = "Price(USD/per sq.ft.)"
			CType(smartScatter.HorizontalAxis, LinearAxis).Maximum = 110
			CType(smartScatter.HorizontalAxis, LinearAxis).DesiredTickCount = 12
			CType(smartScatter.HorizontalAxis, LinearAxis).Title = "Property area (sq.ft.)"
		End Sub

		Private Sub InitializeBar()
			Me.radChartView1.AreaType = ChartAreaType.Cartesian
			Me.radChartView2.AreaType = ChartAreaType.Cartesian

			Me.radChartView1.ShowGrid = True
			Me.radChartView2.ShowGrid = True

			For Each dataItem As KeyValuePair(Of Double, Object) In Me.data.GetBarData()
				Dim bar As New BarSeries()
				bar.ShowLabels = True
				bar.LegendTitle = dataItem.Value.ToString()
				bar.DrawLinesToLabels = Me.radCheckBox1.Checked
				bar.SyncLinesToLabelsColor = Me.radCheckBox3.Checked

				Dim smartBar As New BarSeries()
				smartBar.ShowLabels = True
				smartBar.LegendTitle = dataItem.Value.ToString()
				smartBar.DrawLinesToLabels = Me.radCheckBox1.Checked

				Dim point As New CategoricalDataPoint(dataItem.Key, dataItem.Value)
				point.Label = String.Format("{0:P2} - {1}", point.Value / 100, point.Category)
				bar.DataPoints.Add(point)

				point = New CategoricalDataPoint(dataItem.Key, dataItem.Value)
				point.Label = String.Format("{0:P2} - {1}", point.Value / 100, point.Category)
				smartBar.DataPoints.Add(point)

				Me.radChartView1.Series.Add(bar)
				Me.radChartView2.Series.Add(smartBar)
			Next dataItem

			Me.radChartView1.Axes(0).LabelFitMode = AxisLabelFitMode.MultiLine
			Me.radChartView2.Axes(0).LabelFitMode = AxisLabelFitMode.MultiLine
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.radChartView1.AreaType = ChartAreaType.Polar
			Me.radChartView2.AreaType = ChartAreaType.Polar

			Me.radChartView1.View.Margin = New Padding(40)
			Me.radChartView2.View.Margin = New Padding(40)

			Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Right
			Me.radChartView2.ChartElement.LegendPosition = LegendPosition.Right
			Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical
			Me.radChartView2.ChartElement.LegendElement.StackElement.Orientation = Orientation.Vertical

			Dim strategy As SmartLabelsStrategyBase = Nothing
			Me.smartLabelsController.Strategy = Nothing

			If Me.radDropDownList1.SelectedItem.Text = "Pie" Then
				Me.radChartView1.View.Margin = New Padding(60, 0, 50, 0)
				Me.radChartView2.View.Margin = New Padding(60, 0, 50, 0)

				Me.InitializePie()
				strategy = New PieTwoLabelColumnsStrategy()
			ElseIf Me.radDropDownList1.SelectedItem.Text = "Line" Then
				Me.InitializeLine()
				strategy = New VerticalAdjusmentLabelsStrategy()

				Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Top
				Me.radChartView2.ChartElement.LegendPosition = LegendPosition.Top
				Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
				Me.radChartView2.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
			ElseIf Me.radDropDownList1.SelectedItem.Text = "Bar" Then
				Me.InitializeBar()
				strategy = New VerticalAdjusmentLabelsStrategy()
			ElseIf Me.radDropDownList1.SelectedItem.Text = "Scatter" Then
				Me.InitializeScatter()
				strategy = New EightPositionsLabelsStrategy()

				Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Top
				Me.radChartView2.ChartElement.LegendPosition = LegendPosition.Top
				Me.radChartView1.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
				Me.radChartView2.ChartElement.LegendElement.StackElement.Orientation = Orientation.Horizontal
			End If

			Me.smartLabelsController.Strategy = strategy
			Me.radSpinEditor1.Value = 0D
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim enabled As Boolean = args.ToggleState = ToggleState.On

			For i As Integer = 0 To Me.radChartView1.Series.Count - 1
				Me.radChartView1.Series(i).DrawLinesToLabels = enabled
				Me.radChartView2.Series(i).DrawLinesToLabels = enabled
			Next i

			Me.radChartView1.View.PerformRefresh(Me.radChartView1.View, False)
			Me.radChartView2.View.PerformRefresh(Me.radChartView1.View, False)
		End Sub

		Private Sub radChartView_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
			If Me.radCheckBox2.Checked Then
				If Me.radCheckBox4.Checked Then
					e.LabelElement.BorderColor = (CType(e.LabelElement.Parent, DataPointElement)).BackColor
				Else
					e.LabelElement.BorderColor = Color.Black
				End If

				e.LabelElement.BackColor = Color.White
			Else
				e.LabelElement.ResetValue(LabelElement.BorderColorProperty, Telerik.WinControls.ValueResetFlags.Local)
				e.LabelElement.ResetValue(LabelElement.BorderWidthProperty, Telerik.WinControls.ValueResetFlags.Local)
				e.LabelElement.ResetValue(LabelElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local)
			End If
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radChartView1.View.PerformRefresh(Me.radChartView1.View, False)
			Me.radChartView2.View.PerformRefresh(Me.radChartView1.View, False)
		End Sub

		Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim enabled As Boolean = args.ToggleState = ToggleState.On

			For i As Integer = 0 To Me.radChartView1.Series.Count - 1
				Me.radChartView1.Series(i).SyncLinesToLabelsColor = enabled
				Me.radChartView2.Series(i).SyncLinesToLabelsColor = enabled
			Next i

			Me.radChartView1.View.PerformRefresh(Me.radChartView1.View, False)
			Me.radChartView2.View.PerformRefresh(Me.radChartView1.View, False)
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			For Each controller As ChartViewController In Me.radChartView2.Controllers
				Dim control As SmartLabelsController = TryCast(controller, SmartLabelsController)

				If control IsNot Nothing Then
					control.Strategy.DistanceToLabel = CInt(Fix(Me.radSpinEditor1.Value))
					Me.radChartView2.View.PerformRefresh(Me.radChartView2.View, False)
				End If
			Next controller
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radCheckBox2.ToggleStateChanged, AddressOf radCheckBox2_ToggleStateChanged
			AddHandler radCheckBox3.ToggleStateChanged, AddressOf radCheckBox3_ToggleStateChanged
			AddHandler radCheckBox4.ToggleStateChanged, AddressOf radCheckBox2_ToggleStateChanged
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
		End Sub
	End Class
End Namespace
