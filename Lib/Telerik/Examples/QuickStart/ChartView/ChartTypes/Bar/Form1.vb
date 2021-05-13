Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
	''' <summary>
	''' RadTreeView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1

            Dim themeName As String = If(String.IsNullOrEmpty(Me.CurrentThemeName), "Fluent", Me.CurrentThemeName)
            Dim theme As Theme = theme.ReadCSSText("" & ControlChars.CrLf & "                                            theme" & ControlChars.CrLf & "                                            {" & ControlChars.CrLf & "                                               name: " & themeName & ";" & ControlChars.CrLf & "                                               elementType: Telerik.WinControls.UI.RadChartElement; " & ControlChars.CrLf & "                                               controlType: Telerik.WinControls.UI.RadChartView; " & ControlChars.CrLf & "                                            }" & ControlChars.CrLf & ControlChars.CrLf & "                                            Bar" & ControlChars.CrLf & "                                            {    " & ControlChars.CrLf & "                                                HeightAspectRatio" & ControlChars.CrLf & "                                                {" & ControlChars.CrLf & "                                                    Value: 0.9;" & ControlChars.CrLf & "                                                    EndValue: 1;" & ControlChars.CrLf & "                                                    MaxValue: 1;" & ControlChars.CrLf & "                                                    Frames: 30;" & ControlChars.CrLf & "                                                    Interval: 20;" & ControlChars.CrLf & "                                                    EasingType: InOutCubic;" & ControlChars.CrLf & "                                                    RandomDelay: 200;" & ControlChars.CrLf & "                                                    RemoveAfterApply: true; " & ControlChars.CrLf & "                                                }" & ControlChars.CrLf & "                                            }" & ControlChars.CrLf & "                                            ")
            ThemeRepository.Add(theme, False)
        End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim area As CartesianArea = Me.radChartView1.GetArea(Of CartesianArea)()
			area.ShowGrid = True

			Me.radDropDownList1.SelectedIndex = 0

			Dim verticalAcix As New LinearAxis()
			verticalAcix.AxisType = AxisType.Second
			Dim horizontalAxis As New CategoricalAxis()
			Dim model As New PerformanceModel()

            For i As Integer = 0 To 3
                Dim barSeries As New BarSeries("Performance", "RepresentativeName")
                barSeries.Name = "Q" & (i + 1)
                barSeries.HorizontalAxis = horizontalAxis
                barSeries.VerticalAxis = verticalAcix
                barSeries.DataSource = model.GetData(i)
                Me.radChartView1.Series.Add(barSeries)
                For Each pointElement As DataPointElement In barSeries.Children
                    pointElement.BorderWidth = 0
                Next pointElement
            Next i
        End Sub

		Private Sub showLabelsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			For i As Integer = 0 To Me.radChartView1.Series.Count - 1
				Dim barSeries As BarSeries = Me.radChartView1.GetSeries(Of BarSeries)(i)
				barSeries.ShowLabels = Not barSeries.ShowLabels
			Next i
		End Sub

		Private Sub orientationCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Dim grid As CartesianGrid = Me.radChartView1.GetArea(Of CartesianArea)().GetGrid(Of CartesianGrid)()

			If Me.orientationCheckBox.IsChecked Then
				Me.radChartView1.GetArea(Of CartesianArea)().Orientation = Orientation.Horizontal
				grid.DrawVerticalStripes = True
				grid.DrawHorizontalStripes = False
			Else
				Me.radChartView1.GetArea(Of CartesianArea)().Orientation = Orientation.Vertical
				grid.DrawVerticalStripes = False
				grid.DrawHorizontalStripes = True
			End If
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.radChartView1.Series.Count = 0 Then
				Return
			End If

			Dim combineMode As ChartSeriesCombineMode = ChartSeriesCombineMode.None
			If radDropDownList1.SelectedIndex = 0 Then
				combineMode = ChartSeriesCombineMode.Cluster
			ElseIf radDropDownList1.SelectedIndex = 1 Then
				combineMode = ChartSeriesCombineMode.Stack
			ElseIf radDropDownList1.SelectedIndex = 2 Then
				combineMode = ChartSeriesCombineMode.Stack100
			End If

			For i As Integer = 0 To Me.radChartView1.Series.Count - 1
				Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = combineMode
			Next i
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler showLabelsCheckBox.ToggleStateChanged, AddressOf showLabelsCheckBox_ToggleStateChanged
			AddHandler orientationCheckBox.ToggleStateChanged, AddressOf orientationCheckBox_ToggleStateChanged
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf radDropDownList1_SelectedIndexChanged
		End Sub
	End Class
End Namespace

