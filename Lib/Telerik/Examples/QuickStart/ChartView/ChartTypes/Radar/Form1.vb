Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Radar
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim hotel1DataList As New RadarLineSeries(New SizeF(6f, 6f))
			Dim hotel2DataList As New RadarLineSeries(New SizeF(6f, 6f))
			Dim hotel3DataList As New RadarLineSeries(New SizeF(6f, 6f))

			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(3.1R, "Price"))
			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(3.5R, "Accommodation"))
			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(3.8R, "Cleanness"))
			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(4.5R, "Bar/Cafe"))
			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(3.5R, "Restaurant"))
			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(3.6R, "Spa center"))
			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(3.0R, "Kids facilities"))
			hotel1DataList.DataPoints.Add(New CategoricalDataPoint(3.3R, "Overall"))

			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(3.8R, "Price"))
			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(4.5R, "Accommodation"))
			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(4.3R, "Cleanness"))
			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(3.8R, "Bar/Cafe"))
			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(4.7R, "Restaurant"))
			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(3.9R, "Spa center"))
			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(3.8R, "Kids facilities"))
			hotel2DataList.DataPoints.Add(New CategoricalDataPoint(4.0R, "Overall"))

			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(4.6R, "Price"))
			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(4.3R, "Accommodation"))
			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(4.7R, "Cleanness"))
			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(3.5R, "Bar/Cafe"))
			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(3.9R, "Restaurant"))
			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(3.2R, "Spa center"))
			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(4.0R, "Kids facilities"))
			hotel3DataList.DataPoints.Add(New CategoricalDataPoint(4.8R, "Overall"))

			Me.radChartView1.Series.Add(hotel1DataList)
			Me.radChartView1.Series.Add(hotel2DataList)
			Me.radChartView1.Series.Add(hotel3DataList)

			hotel1DataList.BorderWidth = 2f
			hotel2DataList.BorderWidth = 2f
			hotel3DataList.BorderWidth = 2f

			hotel1DataList.PolarAxis.Minimum = 0R
			hotel1DataList.PolarAxis.Maximum = 5R
			hotel1DataList.PolarAxis.TickLength = 5
			hotel1DataList.RadialAxis.TickLength = 0

			Dim area As PolarArea = TryCast(Me.radChartView1.Area, PolarArea)
			area.ShowGrid = True
		End Sub

		Private Sub radSpinEditorLineWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			For Each series As RadarLineSeries In Me.radChartView1.Series
				series.BorderWidth = CSng(Me.radSpinEditorLineWidth.Value)
			Next series
		End Sub

		Private Sub radSpinEditorPointRadius_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			For Each series As RadarLineSeries In Me.radChartView1.Series
				series.PointSize = New SizeF(CSng(Me.radSpinEditorPointRadius.Value), CSng(Me.radSpinEditorPointRadius.Value))
			Next series
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radSpinEditorPointRadius.ValueChanged, AddressOf radSpinEditorPointRadius_ValueChanged
			AddHandler radSpinEditorLineWidth.ValueChanged, AddressOf radSpinEditorLineWidth_ValueChanged
		End Sub
	End Class
End Namespace
