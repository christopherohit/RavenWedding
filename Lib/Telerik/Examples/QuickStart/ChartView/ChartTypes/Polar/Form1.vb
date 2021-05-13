Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Polar
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private [set] As DataSet
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			 Me.set = New DataSet()

			Dim cardioid As New DataTable("Cardioid")
			cardioid.Columns.Add("Value", GetType(Double))
			cardioid.Columns.Add("Angle", GetType(Double))

			Dim shotgunFront As New DataTable("ShotgunFront")
			shotgunFront.Columns.Add("Value", GetType(Double))
			shotgunFront.Columns.Add("Angle", GetType(Double))

			Dim shotgunSide As New DataTable("ShotgunSide")
			shotgunSide.Columns.Add("Value", GetType(Double))
			shotgunSide.Columns.Add("Angle", GetType(Double))

			[set].Tables.Add(cardioid)
			[set].Tables.Add(shotgunFront)
			[set].Tables.Add(shotgunSide)

			Dim count As Integer = 720
			Dim angleStep As Double = 2 * Math.PI / count

			For i As Integer = 0 To count - 1
				Dim factor As Double = If(i > 0.25 * count AndAlso i < 0.75 * count, 0.7, 1)
				Dim angle As Double = i * angleStep

				cardioid.Rows.Add(0.5 + 0.5 * (Math.Cos(angle)), angle * 180 / Math.PI)
				shotgunFront.Rows.Add(factor * Math.Pow(Math.Abs(Math.Cos(angle)), 8), angle * 180 / Math.PI)
				shotgunSide.Rows.Add(0.48 * Math.Pow(Math.Abs(Math.Sin(angle)), 20), angle * 180 / Math.PI)
			Next i

			Me.BindChartToLineSeries()
			Me.radChartView1.DataSource = Me.set

			Dim area As PolarArea = TryCast(Me.radChartView1.Area, PolarArea)
			area.StartAngle = 90
			area.ShowGrid = True
		End Sub

		Private Sub BindChartToLineSeries()
			Me.radChartView1.Area.Series.Clear()

			Dim cardioidSeries As New PolarLineSeries("Value", "Angle")
			cardioidSeries.DataMember = "Cardioid"
			cardioidSeries.BorderWidth = 2
			Me.radChartView1.Series.Add(cardioidSeries)
			cardioidSeries.BorderColor = Color.FromArgb(200, 142, 196, 65)
			cardioidSeries.PointSize = SizeF.Empty

			Dim shotgunFrontSeries As New PolarLineSeries("Value", "Angle")
			shotgunFrontSeries.DataMember = "ShotgunFront"
			shotgunFrontSeries.BorderWidth = 2
			Me.radChartView1.Series.Add(shotgunFrontSeries)
			shotgunFrontSeries.BorderColor = Color.FromArgb(200, 27, 157, 222)
			shotgunFrontSeries.PointSize = SizeF.Empty

			Dim shotgunSideSeries As New PolarLineSeries("Value", "Angle")
			shotgunSideSeries.DataMember = "ShotgunSide"
			shotgunSideSeries.BorderWidth = 2
			shotgunSideSeries.PointSize = SizeF.Empty
			Me.radChartView1.Series.Add(shotgunSideSeries)
			shotgunSideSeries.BorderColor = Color.FromArgb(200, 27, 157, 222)
			shotgunSideSeries.PointSize = SizeF.Empty

			cardioidSeries.PolarAxis.Minimum = 0R
			cardioidSeries.PolarAxis.Maximum = 1R
			cardioidSeries.PolarAxis.MajorStep = 0.2R
			cardioidSeries.PolarAxis.TickLength = 0
			cardioidSeries.PolarAxis.MajorTickOffset = 1
			cardioidSeries.PolarAxis.LastLabelVisibility = AxisLastLabelVisibility.Hidden
			cardioidSeries.PolarAxis.LabelFormatProvider = New AxisLabelFormat()
			cardioidSeries.RadialAxis.LabelFormat = "{0}°"
			cardioidSeries.RadialAxis.TickLength = 0
		End Sub

		Private Sub BindChartToAreaSeries()
			Me.radChartView1.Area.Series.Clear()

			Dim cardioidSeries As New PolarAreaSeries("Value", "Angle")
			cardioidSeries.DataMember = "Cardioid"
			Me.radChartView1.Series.Add(cardioidSeries)
			cardioidSeries.BackColor = Color.FromArgb(200, 142, 196, 65)
			cardioidSeries.BorderColor = Color.FromArgb(142, 196, 65)
			cardioidSeries.PointSize = SizeF.Empty

			Dim shotgunFrontSeries As New PolarAreaSeries("Value", "Angle")
			shotgunFrontSeries.DataMember = "ShotgunFront"
			Me.radChartView1.Series.Add(shotgunFrontSeries)
			shotgunFrontSeries.BackColor = Color.FromArgb(200, 27, 157, 222)
			shotgunFrontSeries.BorderColor = Color.FromArgb(27, 157, 222)
			shotgunFrontSeries.PointSize = SizeF.Empty

			Dim shotgunSideSeries As New PolarAreaSeries("Value", "Angle")
			shotgunSideSeries.DataMember = "ShotgunSide"
			Me.radChartView1.Series.Add(shotgunSideSeries)
			shotgunSideSeries.BackColor = Color.FromArgb(200, 27, 157, 222)
			shotgunSideSeries.BorderColor = Color.FromArgb(27, 157, 222)
			shotgunSideSeries.PointSize = SizeF.Empty
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Select Case e.Position
				Case 0
					Me.BindChartToLineSeries()
				Case 1
					Me.BindChartToAreaSeries()
			End Select
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
		End Sub
	End Class
End Namespace
