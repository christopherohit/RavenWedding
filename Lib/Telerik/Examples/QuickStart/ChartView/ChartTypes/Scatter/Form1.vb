Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Tests
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
	''' <summary>
	''' RadChartView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private customShape As CustomShape
		Private shapedForm As New ShapedForm()

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1

			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True
			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalStripes = True
			grid.DrawVerticalStripes = True

			InitializeChartAxes()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim model As New ViewModel()
			Me.radChartView1.DataSource = model.GetData()
			Dim axes() As LinearAxis = Me.radChartView1.Axes.Get(Of LinearAxis)()

			Me.ChangeSeries("Scatter point")

			Me.Initialize()
		End Sub

		Private Sub Initialize()
			Me.radDropDownListSeriesType.Items.Add("Scatter point")
			Me.radDropDownListSeriesType.Items.Add("Scatter line")
			Me.radDropDownListSeriesType.Items.Add("Scatter area")
			Me.radDropDownListSeriesType.SelectedIndex = 0

			Me.customShape = New CustomShape()
			Me.customShape.CreateClosedShape(CreateInitialShape(5, 100, 60))

			Dim item As New RadListDataItem("CustomShape")
			item.Value = GetType(CustomShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("RoundRectShape")
			item.Value = GetType(RoundRectShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("EllipseShape")
			item.Value = GetType(EllipseShape)
			Me.radDropDownListShapes.Items.Add(item)
			item = New RadListDataItem("DonutShape")
			item.Value = GetType(DonutShape)
			Me.radDropDownListShapes.Items.Add(item)

			AddHandler radDropDownListShapes.SelectedIndexChanged, AddressOf radDropDownListShapes_SelectedIndexChanged
			Me.radDropDownListShapes.SelectedIndex = 2

			Me.radSpinEditorPointRadius.Value = 6D

			Me.radChartView1.ShowTitle = True
			Me.radChartView1.Title = "Mean hourly earnings in the UK public and private sector (aged 16-64)"
			Me.radChartView1.ChartElement.TitleElement.Font = New Font("Segoe UI", 20f)
		End Sub

		Private Sub InitializeChartAxes()
			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()

			Dim horizontalAxis As New LinearAxis()
			horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
			horizontalAxis.Title = "Employee Age"
			horizontalAxis.Minimum = 16
			horizontalAxis.Maximum = 64
			horizontalAxis.MajorStep = 4
			area.Axes.Add(horizontalAxis)

			Dim verticalAxis As New LinearAxis()
			verticalAxis.AxisType = AxisType.Second
			verticalAxis.Title = "Earnings (GPB/hour)"
			verticalAxis.Minimum = 2
			verticalAxis.Maximum = 20
			area.Axes.Add(verticalAxis)
		End Sub

		Private Function CreateInitialShape(ByVal vertices As Integer, ByVal radius1 As Double, ByVal radius2 As Double) As List(Of PointF)
			Dim pts As New List(Of PointF)()

			If radius1 = 0 Then
				Return Nothing
			End If

			If radius2 = 0 Then
				Return Nothing
			End If

			For i As Integer = 0 To vertices - 1
				Dim angle1 As Double = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices)
				Dim angle2 As Double = ((4.0 * i - vertices + 2) * Math.PI) / (2.0f * vertices)
				pts.Add(New PointF(CSng(Math.Cos(angle1) * radius1), CSng(Math.Sin(angle1) * radius1)))
				pts.Add(New PointF(CSng(Math.Cos(angle2) * radius2), CSng(Math.Sin(angle2) * radius2)))
			Next i

			Return pts
		End Function

		Private Sub ChangeSeries(ByVal seriesType As String)
			Me.radChartView1.Series.Clear()

			Dim seriesPublic As ScatterSeries
			Dim seriesPrivate As ScatterSeries
			Me.radCheckBoxSpline.Enabled = False

			If seriesType = "Scatter line" Then
				seriesPublic = New ScatterLineSeries() With {.Spline = Me.radCheckBoxSpline.IsChecked}
				seriesPrivate = New ScatterLineSeries() With {.Spline = Me.radCheckBoxSpline.IsChecked}
				Me.radCheckBoxSpline.Enabled = True
				Me.radSpinEditorPointRadius.Value = 0D

				seriesPublic.BorderColor = Color.FromArgb(27, 157, 222)
				seriesPrivate.BorderColor = Color.FromArgb(142, 196, 65)
			ElseIf seriesType = "Scatter area" Then
				seriesPublic = New ScatterAreaSeries() With {.Spline = Me.radCheckBoxSpline.IsChecked}
				seriesPrivate = New ScatterAreaSeries() With {.Spline = Me.radCheckBoxSpline.IsChecked}
				Me.radCheckBoxSpline.Enabled = True
				Me.radSpinEditorPointRadius.Value = 0D

				seriesPublic.BorderColor = Color.FromArgb(27, 157, 222)
				seriesPublic.BackColor = Color.FromArgb(100, 27, 157, 222)
				seriesPrivate.BorderColor = Color.FromArgb(142, 196, 65)
				seriesPrivate.BackColor = Color.FromArgb(100, 142, 196, 65)
			Else
				seriesPublic = New ScatterSeries()
				seriesPrivate = New ScatterSeries()
				Me.radSpinEditorPointRadius.Value = 6D

				seriesPublic.BackColor = Color.FromArgb(27, 157, 222)
				seriesPrivate.BackColor = Color.FromArgb(142, 196, 65)
			End If

			Dim axes() As LinearAxis = Me.radChartView1.Axes.Get(Of LinearAxis)()

			seriesPublic.DataMember = "public"
			seriesPrivate.DataMember = "private"

			seriesPrivate.XValueMember = "Age"
			seriesPublic.XValueMember = seriesPrivate.XValueMember
			seriesPrivate.YValueMember = "Wage"
			seriesPublic.YValueMember = seriesPrivate.YValueMember
			seriesPrivate.HorizontalAxis = axes(0)
			seriesPublic.HorizontalAxis = seriesPrivate.HorizontalAxis
			seriesPrivate.VerticalAxis = axes(1)
			seriesPublic.VerticalAxis = seriesPrivate.VerticalAxis

			Me.radChartView1.Series.Add(seriesPublic)
			Me.radChartView1.Series.Add(seriesPrivate)

			ApplySelectedShape()
			ApplySelectedPointSize()
		End Sub

		Private Sub ApplyShapeToPoints(ByVal shape As ElementShape)
			For Each series As ScatterSeries In Me.radChartView1.Series
				For Each point As ScatterPointElement In series.Children
					point.Shape = shape
				Next point
			Next series
		End Sub

		Private Sub ApplySelectedShape()
			Select Case Me.radDropDownListShapes.SelectedIndex
				Case 0
					Me.ApplyShapeToPoints(Me.customShape)
					Me.radButtonEditShape.Enabled = True
				Case 1
					Me.ApplyShapeToPoints(New RoundRectShape(2))
					Me.radButtonEditShape.Enabled = False
				Case 2
					Me.ApplyShapeToPoints(New EllipseShape())
					Me.radButtonEditShape.Enabled = False
				Case 3
					Me.ApplyShapeToPoints(New DonutShape())
					Me.radButtonEditShape.Enabled = False
				Case 4
					Me.ApplyShapeToPoints(New TabOffice12Shape())
					Me.radButtonEditShape.Enabled = False
				Case 5
					Me.ApplyShapeToPoints(New TabVsShape())
					Me.radButtonEditShape.Enabled = False
			End Select
		End Sub

		Private Sub ApplySelectedPointSize()
			For Each series As ScatterSeries In Me.radChartView1.Series
				series.PointSize = New SizeF(CSng(Me.radSpinEditorPointRadius.Value), CSng(Me.radSpinEditorPointRadius.Value))
			Next series
		End Sub

		Private Sub radButtonEditShape_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radDropDownListShapes.SelectedIndex = 0 Then
				Dim editor As New CustomShapeEditorForm()
				Me.customShape = editor.EditShape(Me.customShape)
				Me.ApplyShapeToPoints(Me.customShape)
			End If
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			ApplySelectedPointSize()
		End Sub

		Private Sub radDropDownListShapes_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			ApplySelectedShape()
		End Sub

		Private Sub radDropDownListSeriesType_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Me.ChangeSeries(Me.radDropDownListSeriesType.Text)
		End Sub

		Private Sub radCheckBoxSpline_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			For Each series As ScatterLineSeries In Me.radChartView1.Series
				series.Spline = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Next series
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radButtonEditShape.Click, AddressOf radButtonEditShape_Click
			AddHandler radSpinEditorPointRadius.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler Me.radDropDownListSeriesType.SelectedIndexChanged, AddressOf radDropDownListSeriesType_SelectedIndexChanged
			AddHandler Me.radCheckBoxSpline.ToggleStateChanged, AddressOf radCheckBoxSpline_ToggleStateChanged
		End Sub
	End Class
End Namespace

