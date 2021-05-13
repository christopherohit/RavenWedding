Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting

Namespace Telerik.Examples.WinControls.ChartView.RadarAnnotations
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private color60S As Color = Color.FromArgb(235, 122, 42)
		Private color30S As Color = Color.FromArgb(156, 214, 15)
		Private color60N As Color = Color.FromArgb(37, 160, 219)
		Private color30N As Color = Color.FromArgb(212, 223, 50)

		Private series60S As RadarLineSeries
		Private series30S As RadarLineSeries
		Private series60N As RadarLineSeries
		Private series30N As RadarLineSeries

		Private northwardEquinoxAnnotation As RadialAxisGridLineAnnotation
		Private northernSolsticeAnnotation As RadialAxisGridLineAnnotation
		Private southwardEquinoxAnnotation As RadialAxisGridLineAnnotation
		Private southernSolsticeAnnotation As RadialAxisGridLineAnnotation

		Private springAnnotation As RadialAxisPlotBandAnnotation
		Private summerAnnotation As RadialAxisPlotBandAnnotation
		Private autunmAnnotation As RadialAxisPlotBandAnnotation
		Private winterAnnotation As RadialAxisPlotBandAnnotation

		Private workHoursAnnotation As PolarAxisPlotBandAnnotation

		Public Sub New()
			InitializeComponent()

			Me.radCheckBox60S.ButtonElement.TextElement.ForeColor = color60S
			Me.radCheckBox30S.ButtonElement.TextElement.ForeColor = color30S
			Me.radCheckBox60N.ButtonElement.TextElement.ForeColor = color60N
			Me.radCheckBox30N.ButtonElement.TextElement.ForeColor = color30N

			Me.radCheckBox60S.Font = New Font("Segoe UI", 10, FontStyle.Bold)
			Me.radCheckBox30S.Font = New Font("Segoe UI", 10, FontStyle.Bold)
			Me.radCheckBox60N.Font = New Font("Segoe UI", 10, FontStyle.Bold)
			Me.radCheckBox30N.Font = New Font("Segoe UI", 10, FontStyle.Bold)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.SetupSeries()

			Me.northwardEquinoxAnnotation = New RadialAxisGridLineAnnotation("March")
			Me.northernSolsticeAnnotation = New RadialAxisGridLineAnnotation("June")
			Me.southwardEquinoxAnnotation = New RadialAxisGridLineAnnotation("September")
			Me.southernSolsticeAnnotation = New RadialAxisGridLineAnnotation("December")

			Me.springAnnotation = New RadialAxisPlotBandAnnotation("June", "March")
			Me.summerAnnotation = New RadialAxisPlotBandAnnotation("September", "June")
			Me.autunmAnnotation = New RadialAxisPlotBandAnnotation("December", "September")
			Me.winterAnnotation = New RadialAxisPlotBandAnnotation("March", "December")

			Me.workHoursAnnotation = New PolarAxisPlotBandAnnotation(8, 17)
			Me.workHoursAnnotation.BackColor = Color.FromArgb(80, 255, 160, 25)
		End Sub

		Private Sub SetupSeries()
			Me.series60S = New RadarLineSeries()
			Me.series60S.ValueMember = "60S"
			Me.series60S.CategoryMember = "Month"
			Me.series60S.PointSize = New SizeF(7, 7)
			Me.series60S.BorderColor = color60S
			Me.series60S.BackColor = Me.series60S.BorderColor

			Me.series30S = New RadarLineSeries()
			Me.series30S.ValueMember = "30S"
			Me.series30S.CategoryMember = "Month"
			Me.series30S.PointSize = New SizeF(7, 7)
			Me.series30S.BorderColor = color30S
			Me.series30S.BackColor = Me.series30S.BorderColor

			Me.series60N = New RadarLineSeries()
			Me.series60N.ValueMember = "60N"
			Me.series60N.CategoryMember = "Month"
			Me.series60N.PointSize = New SizeF(7, 7)
			Me.series60N.BorderColor = color60N
			Me.series60N.BackColor = Me.series60N.BorderColor

			Me.series30N = New RadarLineSeries()
			Me.series30N.ValueMember = "30N"
			Me.series30N.CategoryMember = "Month"
			Me.series30N.PointSize = New SizeF(7, 7)
			Me.series30N.BorderColor = color30N
			Me.series30N.BackColor = Me.series30N.BorderColor

			Me.radChartView1.Series.Add(Me.series60S)
			Me.radChartView1.Series.Add(Me.series30S)
			Me.radChartView1.Series.Add(Me.series60N)
			Me.radChartView1.Series.Add(Me.series30N)
			Me.radChartView1.DataSource = Me.GetData()

			Dim area As PolarArea = Me.radChartView1.GetArea(Of PolarArea)()
			Dim radialAxis As RadialAxis = TryCast(area.Axes(1), RadialAxis)
			Dim polarAxis As PolarAxis = TryCast(area.Axes(0), PolarAxis)

			area.StartAngle = 270
			radialAxis.SweepDirection = SweepDirection.Clockwise
			polarAxis.Minimum = 0
			polarAxis.Maximum = 24
			polarAxis.MajorStep = 6
			polarAxis.LabelFormat = "{0}h"
		End Sub

		Private Function GetData() As DataTable
			Dim table As New DataTable()

			table.Columns.Add("Month", GetType(String))
			table.Columns.Add("60S", GetType(Double))
			table.Columns.Add("30S", GetType(Double))
			table.Columns.Add("60N", GetType(Double))
			table.Columns.Add("30N", GetType(Double))

			table.Rows.Add("January", 18.34, 13.9, 10.1, 5.66)
			table.Rows.Add("February", 16.49, 13.42, 10.58, 7.51)
			table.Rows.Add("March", 14.04, 12.67, 11.33, 9.96)
			table.Rows.Add("April", 11.16, 11.72, 12.28, 12.84)
			table.Rows.Add("May", 8.43, 10.85, 13.15, 15.57)
			table.Rows.Add("June", 6.12, 10.21, 13.79, 17.88)
			table.Rows.Add("July", 5.62, 10.09, 13.91, 18.38)
			table.Rows.Add("August", 7.38, 10.54, 13.46, 16.62)
			table.Rows.Add("September", 10.09, 11.37, 12.63, 13.91)
			table.Rows.Add("October", 12.87, 12.29, 11.71, 11.13)
			table.Rows.Add("November", 15.69, 13.19, 10.81, 8.31)
			table.Rows.Add("December", 17.9, 13.79, 10.21, 6.1)

			Return table
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler Me.radCheckBox60S.ToggleStateChanged, AddressOf radCheckBox60S_ToggleStateChanged
			AddHandler Me.radCheckBox30S.ToggleStateChanged, AddressOf radCheckBox30S_ToggleStateChanged
			AddHandler Me.radCheckBox60N.ToggleStateChanged, AddressOf radCheckBox60N_ToggleStateChanged
			AddHandler Me.radCheckBox30N.ToggleStateChanged, AddressOf radCheckBox30N_ToggleStateChanged

			AddHandler Me.radCheckBoxSpring.ToggleStateChanged, AddressOf radCheckBoxSpring_ToggleStateChanged
			AddHandler Me.radCheckBoxSummer.ToggleStateChanged, AddressOf radCheckBoxSummer_ToggleStateChanged
			AddHandler Me.radCheckBoxAutumn.ToggleStateChanged, AddressOf radCheckBoxAutumn_ToggleStateChanged
			AddHandler Me.radCheckBoxWinter.ToggleStateChanged, AddressOf radCheckBoxWinter_ToggleStateChanged

			AddHandler Me.radCheckBoxSouthernSolstice.ToggleStateChanged, AddressOf radCheckBoxSouthernSolstice_ToggleStateChanged
			AddHandler Me.radCheckBoxSouthwardEquinox.ToggleStateChanged, AddressOf radCheckBoxSouthwardEquinox_ToggleStateChanged
			AddHandler Me.radCheckBoxNorthwardEquinox.ToggleStateChanged, AddressOf radCheckBoxNorthwardEquinox_ToggleStateChanged
			AddHandler Me.radCheckBoxNorthernSolstice.ToggleStateChanged, AddressOf radCheckBoxNorthernSolstice_ToggleStateChanged

			AddHandler Me.radCheckBoxWorkHours.ToggleStateChanged, AddressOf radCheckBoxWorkHours_ToggleStateChanged
		End Sub

		Private Sub radCheckBox60S_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.series60S.IsVisible = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBox30S_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.series30S.IsVisible = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBox60N_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.series60N.IsVisible = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBox30N_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.series30N.IsVisible = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radCheckBoxSpring_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.springAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.springAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxSummer_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.summerAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.summerAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxAutumn_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.autunmAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.autunmAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxWinter_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.winterAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.winterAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxSouthernSolstice_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.southernSolsticeAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.southernSolsticeAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxSouthwardEquinox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.southwardEquinoxAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.southwardEquinoxAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxNorthernSolstice_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.northernSolsticeAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.northernSolsticeAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxNorthwardEquinox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.northwardEquinoxAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.northwardEquinoxAnnotation)
			End If
		End Sub

		Private Sub radCheckBoxWorkHours_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Area.Annotations.Add(Me.workHoursAnnotation)
			Else
				Me.radChartView1.Area.Annotations.Remove(Me.workHoursAnnotation)
			End If
		End Sub
	End Class
End Namespace
