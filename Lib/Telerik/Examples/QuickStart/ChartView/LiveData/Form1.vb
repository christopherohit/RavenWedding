Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.LiveData
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private model As New LiveDataModel()
        Private font1 As New Font("Segoe UI", 12.0F, FontStyle.Regular)

        Public Sub New()
			InitializeComponent()
			InitializeChart1(GetType(FastLineSeries))
			InitializeChart2()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			model.StartTimer()
			AddHandler model.PropertyChanged, AddressOf model_PropertyChanged
		End Sub

		Private Sub InitializeChart1(ByVal seriesType As Type)
			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.ForeColor = Color.FromArgb(235, 235, 235)
			grid.DrawVerticalStripes = False
			grid.DrawHorizontalStripes = True
			grid.DrawHorizontalFills = False
			grid.DrawVerticalFills = False
			area.ShowGrid = True

			Dim lineSeries As LineSeries

			If seriesType Is GetType(FastLineSeries) Then
				lineSeries = New FastLineSeries()
				lineSeries.BorderColor = Color.Blue
				exampleCustomShapeControl4.Element.BackColor = Color.Blue
			Else
				lineSeries = New LineSeries()
				lineSeries.BorderColor = Color.FromArgb(142, 196, 65)
				exampleCustomShapeControl4.Element.BackColor = Color.FromArgb(142, 196, 65)
			End If

			lineSeries.PointSize = New SizeF(0, 0)
			lineSeries.CategoryMember = "Category"
			lineSeries.ValueMember = "Value"
			lineSeries.DataSource = model.Data
			lineSeries.BorderWidth = 2

			Me.radChartView1.Series.Add(lineSeries)

			Me.radChartView1.ChartElement.TitlePosition = TitlePosition.Top
			Me.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft
			Me.radChartView1.ChartElement.TitleElement.Margin = New Padding(10, 10, 0, 0)
            Me.radChartView1.ChartElement.TitleElement.Font = font1
            Me.radChartView1.View.Margin = New Padding(10, 0, 35, 0)

			Dim axeY As LinearAxis = radChartView1.Axes.Get(Of LinearAxis)(1)
			axeY.Minimum = 500
			axeY.Maximum = 2000
			axeY.MajorStep = 500

			Dim axeX As CategoricalAxis = radChartView1.Axes.Get(Of CategoricalAxis)(0)
			axeX.ClipLabels = False
			axeX.LabelInterval = 50
			axeX.LabelFormat = "{0:HH:mm:ss.f}"
		End Sub

		Private Sub InitializeChart2()
			Dim area As CartesianArea = Me.radChartView2.GetArea(Of CartesianArea)()
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.ForeColor = Color.FromArgb(235, 235, 235)
			grid.DrawVerticalStripes = False
			grid.DrawHorizontalStripes = True
			grid.DrawHorizontalFills = False
			grid.DrawVerticalFills = False
			area.ShowGrid = True

			Dim trackball As New ChartTrackballController()
			trackball.IsFixedSize = True
			trackball.FixedSize = New Size(150, 30)
			AddHandler trackball.TextNeeded, AddressOf trackball_TextNeeded
			Me.radChartView2.Controllers.Add(trackball)

			Dim areaSeries As New AreaSeries()
			areaSeries.Spline = False
			areaSeries.CategoryMember = "Category"
			areaSeries.ValueMember = "Value"
			areaSeries.DataSource = model.Data2
			areaSeries.PointSize = New SizeF(0, 0)
			areaSeries.BorderColor = Color.FromArgb(142, 196, 65)
			areaSeries.BackColor = Color.FromArgb(150, Color.FromArgb(142, 196, 65))

			Me.radChartView2.Series.Add(areaSeries)

			Me.radChartView2.ChartElement.TitlePosition = TitlePosition.Top
			Me.radChartView2.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleLeft
			Me.radChartView2.ChartElement.TitleElement.Margin = New Padding(10, 10, 0, 0)
            Me.radChartView2.ChartElement.TitleElement.Font = font1
            Me.radChartView2.View.Margin = New Padding(10, 0, 0, 10)

			Dim axeY As LinearAxis = radChartView2.Axes.Get(Of LinearAxis)(1)
			axeY.Minimum = 3000
			axeY.Maximum = 4200

			Dim axeX As CategoricalAxis = radChartView2.Axes.Get(Of CategoricalAxis)(0)
			axeX.LabelInterval = 2
			axeX.LabelFormat = "{0:HH}"
			axeX.LastLabelVisibility = Charting.AxisLastLabelVisibility.Visible

		End Sub

		Private Sub trackball_TextNeeded(ByVal sender As Object, ByVal e As TextNeededEventArgs)
			Dim dataItem As ChartBusinessObject = TryCast(e.Points(0).DataPoint.DataItem, ChartBusinessObject)
			If dataItem Is Nothing Then
				Return
			End If

			Dim textBuilder As New StringBuilder()
			textBuilder.Append("<html><color=255,0,0,0>")
			textBuilder.Append(String.Format("Online users at {0:HH}h:<b>{1}</b>", dataItem.Category, dataItem.Value))
			textBuilder.Append("</html>")
			e.Text = textBuilder.ToString()
			e.Element.BorderBoxStyle = BorderBoxStyle.FourBorders
			e.Element.Location = New Point(e.Element.Location.X, 0)
		End Sub

		Private Sub model_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			Me.exampleCustomShapeControl1.LeftText = model.MessagesPerSecond
			Me.exampleCustomShapeControl2.LeftText = model.MessagesPerMinute
			Me.exampleCustomShapeControl4.LeftText = model.FPS
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.Disposed, AddressOf Form1_Disposed
		End Sub

		Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			model.StopTimer()
			RemoveHandler model.PropertyChanged, AddressOf model_PropertyChanged
		End Sub

		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButton1.ToggleStateChanged
			radChartView1.Series.Clear()
			InitializeChart1(GetType(LineSeries))
		End Sub

		Private Sub radRadioButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radRadioButton2.ToggleStateChanged
			radChartView1.Series.Clear()
			InitializeChart1(GetType(FastLineSeries))
		End Sub
	End Class
End Namespace
