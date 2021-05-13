Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private enableFormatting As Boolean
		Private formattingFont As New Font("Segoe UI", 8f)

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			enableFormatting = True

			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True

			Dim grid As CartesianGrid = area.GetGrid(Of CartesianGrid)()
			grid.DrawHorizontalStripes = True
			grid.ForeColor = Color.FromArgb(200, 200, 200)
			grid.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			grid.DrawVerticalStripes = False
			grid.DrawHorizontalFills = False
			grid.DrawVerticalFills = False

			Dim horizontalAxis As New DateTimeCategoricalAxis()
			horizontalAxis.LabelFormat = "{0:MMM - dd}"
			horizontalAxis.LabelFitMode = AxisLabelFitMode.Rotate
			horizontalAxis.LabelRotationAngle = 315
			area.Axes.Add(horizontalAxis)

			Dim verticalAxis As New LinearAxis()
			verticalAxis.Minimum = 58
			verticalAxis.Maximum = 70
			verticalAxis.AxisType = Telerik.Charting.AxisType.Second
			area.Axes.Add(verticalAxis)

			InitializeOhlcSeries()
			SetupOhlcLabels()

		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				enableFormatting = True
			Else
				enableFormatting = False
			End If
			Me.radChartView1.Invalidate()
			Me.radChartView1.View.Refresh()
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Series(0).ShowLabels = True
			Else
				Me.radChartView1.Series(0).ShowLabels = False
			End If
		End Sub

		Private Sub radChartView1_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
			Dim label As OhlcLabelElement = TryCast(e.LabelElement, OhlcLabelElement)

			If enableFormatting Then
				label.Font = formattingFont

				Dim isFalling As Boolean = (CType(e.LabelElement.DataPoint, OhlcDataPoint)).IsFalling
				If label.PositionOffset <> PointF.Empty Then
					If isFalling Then
						label.ForeColor = Color.FromArgb(210, 0, 0)

					Else
						label.ForeColor = Color.FromArgb(102, 102, 102)
					End If
				Else
					If isFalling Then
						label.ForeColor = Color.Black
					Else
						label.ForeColor = Color.FromArgb(0, 150, 0)
					End If
				End If
			Else
				label.ResetValue(UIChartElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local)
				label.ResetValue(UIChartElement.FontProperty, Telerik.WinControls.ValueResetFlags.Local)
			End If
		End Sub

		Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs)
			UpdateLabelPostion()
		End Sub

		Private Sub SetupOhlcLabels()
			If Me.radChartView1.Series.Count > 0 Then
				For Each point As TwoLabelOhlcPointElement In Me.radChartView1.Series(0).Children
					Dim upperLabel As OhlcLabelElement = TryCast(point.Children(0), OhlcLabelElement)
					If upperLabel IsNot Nothing Then
						upperLabel.Text = (TryCast(point.DataPoint, OhlcDataPoint)).Open.ToString()
					End If

					Dim lowerLabel As OhlcLabelElement = TryCast(point.Children(1), OhlcLabelElement)
					If lowerLabel IsNot Nothing Then
						lowerLabel.Text = (TryCast(point.DataPoint, OhlcDataPoint)).Close.ToString()
					End If
				Next point
			End If
		End Sub

		Private Sub UpdateLabelPostion()
			If Me.radChartView1.Series.Count > 0 Then
				For Each point As TwoLabelOhlcPointElement In radChartView1.Series(0).Children
					Dim lowerLabel As OhlcLabelElement = TryCast(point.Children(1), OhlcLabelElement)
					If lowerLabel IsNot Nothing Then
						lowerLabel.PositionOffset = New PointF(0, CSng(point.DataPoint.LayoutSlot.Height + lowerLabel.GetLayoutSlot().Height + 5))
					End If
				Next point
			End If
		End Sub

		Private Sub InitializeOhlcSeries()
			Dim series As New TwoLabelOhlcSeries()

			series.DataPoints.Add(New OhlcDataPoint(64.96, 64.96, 63.34, 63.54, New Date(11, 7, 5)))
			series.DataPoints.Add(New OhlcDataPoint(63.47, 64.54, 63.1, 63.52, New Date(11, 7, 6)))
			series.DataPoints.Add(New OhlcDataPoint(63.43, 64.95, 63.43, 63.84, New Date(11, 7, 7)))
			series.DataPoints.Add(New OhlcDataPoint(64.17, 64.17, 62.47, 62.99, New Date(11, 7, 8)))
			series.DataPoints.Add(New OhlcDataPoint(63.29, 63.34, 61.57, 61.7, New Date(11, 7, 11)))
			series.DataPoints.Add(New OhlcDataPoint(61.63, 62.36, 59.56, 59.63, New Date(11, 7, 12)))
			series.DataPoints.Add(New OhlcDataPoint(60.22, 63.91, 60.17, 63.54, New Date(11, 7, 13)))
			series.DataPoints.Add(New OhlcDataPoint(63.62, 64.75, 62.9, 64.02, New Date(11, 7, 14)))
			series.DataPoints.Add(New OhlcDataPoint(64.04, 66.36, 63.76, 66.12, New Date(11, 7, 15)))
			series.DataPoints.Add(New OhlcDataPoint(65.91, 67.12, 64.36, 64.84, New Date(11, 7, 18)))
			series.DataPoints.Add(New OhlcDataPoint(64.84, 67.11, 64.42, 67.11, New Date(11, 7, 19)))
			series.DataPoints.Add(New OhlcDataPoint(66.85, 68.12, 66.62, 66.99, New Date(11, 7, 20)))
			series.DataPoints.Add(New OhlcDataPoint(66.5, 67, 66.18, 66.68, New Date(11, 7, 21)))
			series.DataPoints.Add(New OhlcDataPoint(66.2, 66.85, 65.11, 65.74, New Date(11, 7, 22)))
			series.DataPoints.Add(New OhlcDataPoint(65.85, 66.25, 64.63, 64.76, New Date(11, 7, 25)))
			series.DataPoints.Add(New OhlcDataPoint(64.95, 66.95, 64.45, 66.77, New Date(11, 7, 26)))
			series.DataPoints.Add(New OhlcDataPoint(66.82, 68.02, 65.21, 65.21, New Date(11, 7, 27)))
			series.DataPoints.Add(New OhlcDataPoint(65.27, 66.3, 63.68, 63.88, New Date(11, 7, 28)))
			series.DataPoints.Add(New OhlcDataPoint(64, 65.98, 63.86, 65.8, New Date(11, 7, 29)))

			series.ShowLabels = True
			series.VerticalAxis = Me.radChartView1.Axes.Get(Of LinearAxis)(1)
			series.HorizontalAxis = Me.radChartView1.Axes.Get(Of CategoricalAxis)(0)
			Me.radChartView1.Series.Add(series)
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radChartView1.LabelFormatting, AddressOf radChartView1_LabelFormatting
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radCheckBox2.ToggleStateChanged, AddressOf radCheckBox2_ToggleStateChanged
			AddHandler Resize, AddressOf Form1_Resize
		End Sub
	End Class
End Namespace
