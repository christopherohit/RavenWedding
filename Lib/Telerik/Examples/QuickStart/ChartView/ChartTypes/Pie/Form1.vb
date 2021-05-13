Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Pie
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private pieSeries As PieSeries

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radChartView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radLabel4.Visible = False
			Me.radSpinDonutRadius.Visible = False

			Me.radChartView1.Controllers.Add(New ChartSelectionController())
			AddHandler radChartView1.SelectedPointChanged, AddressOf selectionController_SelectedPointChanged

			BindSelectionModeCombo()
			AddHandler radDropDownList1.SelectedValueChanged, AddressOf radDropDownList1_SelectedValueChanged
			Me.radDropDownList1.SelectedValue = ChartSelectionMode.SingleDataPoint

			Me.pieSeries = New PieSeries()
			Me.PopulatePieSeries()
			Me.radChartView1.Series.Clear()
			Me.radChartView1.Series.Add(Me.pieSeries)

            Dim themeName As String = If(String.IsNullOrEmpty(Me.CurrentThemeName), "Fluent", Me.CurrentThemeName)
            Dim theme As Theme = theme.ReadCSSText("" & ControlChars.CrLf & "                                        theme" & ControlChars.CrLf & "                                        {" & ControlChars.CrLf & "                                           name: " & themeName & ";" & ControlChars.CrLf & "                                           elementType: Telerik.WinControls.UI.RadChartElement; " & ControlChars.CrLf & "                                           controlType: Telerik.WinControls.UI.RadChartView; " & ControlChars.CrLf & "                                        }" & ControlChars.CrLf & ControlChars.CrLf & "                                        PieSegment" & ControlChars.CrLf & "                                        {    " & ControlChars.CrLf & "                                            RadiusAspectRatio" & ControlChars.CrLf & "                                            {" & ControlChars.CrLf & "                                                Value: 0.5;" & ControlChars.CrLf & "                                                EndValue: 1;" & ControlChars.CrLf & "                                                MaxValue: 1;" & ControlChars.CrLf & "                                                Frames: 20;" & ControlChars.CrLf & "                                                Interval: 10;" & ControlChars.CrLf & "                                                EasingType: OutCircular;" & ControlChars.CrLf & "                                                RandomDelay: 100;" & ControlChars.CrLf & "                                                RemoveAfterApply: true; " & ControlChars.CrLf & "                                            }" & ControlChars.CrLf & "                                        }" & ControlChars.CrLf & "                                        ")
            ThemeRepository.Add(theme, False)
        End Sub

		Private Sub radDropDownList1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radChartView1.SelectionMode = CType(Me.radDropDownList1.SelectedValue, ChartSelectionMode)
		End Sub

		Private Sub selectionController_SelectedPointChanged(ByVal sender As Object, ByVal args As ChartViewSelectedPointChangedEventArgs)
			Me.UpdadateOffsetFromCenter(TryCast(args.OldSelectedPoint, PieDataPoint))
			Me.UpdadateOffsetFromCenter(TryCast(args.NewSelectedPoint, PieDataPoint))
		End Sub

		Private Sub UpdadateOffsetFromCenter(ByVal point As PieDataPoint)
			If point IsNot Nothing Then
				point.OffsetFromCenter = If(point.IsSelected, 0.1, 0)
			End If
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim range As AngleRange = Me.pieSeries.Range
			range.StartAngle = Decimal.ToDouble(Me.radSpinEditor1.Value)
			Me.pieSeries.Range = range
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim range As AngleRange = Me.pieSeries.Range
			range.SweepAngle = Decimal.ToDouble(Me.radSpinEditor2.Value)
			Me.pieSeries.Range = range
		End Sub

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.pieSeries.ShowLabels = If(args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, True, False)
		End Sub

		Private Sub PopulatePieSeries()
			Me.pieSeries.ShowLabels = True
			Me.pieSeries.LabelFormat = "{0:P2}"
			Me.pieSeries.RadiusFactor = 0.9f
			Me.pieSeries.Range = New AngleRange(270, 360)

			Me.pieSeries.DataPoints.Add(New PieDataPoint(40, "Apple"))
			Me.pieSeries.DataPoints.Add(New PieDataPoint(45, "Microsoft"))
			Me.pieSeries.DataPoints.Add(New PieDataPoint(40, "Google"))
			Me.pieSeries.DataPoints.Add(New PieDataPoint(25, "Android"))
			Me.pieSeries.DataPoints.Add(New PieDataPoint(15, "HTC"))
			Me.pieSeries.DataPoints.Add(New PieDataPoint(15, "Samsung"))
			Me.pieSeries.DataPoints.Add(New PieDataPoint(15, "Bada"))
			Me.pieSeries.DataPoints.Add(New PieDataPoint(30, "Others"))

		End Sub

		Private Sub BindSelectionModeCombo()
			Dim selectionModeBindingSource As New BindingSource()
			selectionModeBindingSource.Add(ChartSelectionMode.None)
			selectionModeBindingSource.Add(ChartSelectionMode.SingleDataPoint)
			selectionModeBindingSource.Add(ChartSelectionMode.MultipleDataPoints)

			Me.radDropDownList1.DataSource = selectionModeBindingSource
		End Sub

		Private Sub radRadioButton1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Series.Clear()
				Me.pieSeries = New PieSeries()
				Me.PopulatePieSeries()
				Me.radChartView1.Series.Add(pieSeries)
				Me.radLabel4.Visible = False
				Me.radSpinDonutRadius.Visible = False
				Me.pieSeries.ShowLabels = Me.radCheckBox1.Checked
			End If
		End Sub

		Private Sub radRadioButton2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radChartView1.Series.Clear()
				Me.pieSeries = New DonutSeries()
				Me.PopulatePieSeries()
				Me.radChartView1.Series.Add(pieSeries)
				Me.radLabel4.Visible = True
				Me.radSpinDonutRadius.Value = CInt(Fix((CType(pieSeries, DonutSeries)).InnerRadiusFactor * 100))
				Me.radSpinDonutRadius.Visible = True
				Me.pieSeries.ShowLabels = Me.radCheckBox1.Checked
			End If
		End Sub

		Private Sub radSpinDonutRadius_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			CType(Me.pieSeries, DonutSeries).InnerRadiusFactor = CSng(Me.radSpinDonutRadius.Value) / 100
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler radSpinEditor2.ValueChanged, AddressOf radSpinEditor2_ValueChanged
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_ToggleStateChanged
			AddHandler radRadioButton2.ToggleStateChanged, AddressOf radRadioButton2_ToggleStateChanged
			AddHandler radRadioButton1.ToggleStateChanged, AddressOf radRadioButton1_ToggleStateChanged
			AddHandler radSpinDonutRadius.ValueChanged, AddressOf radSpinDonutRadius_ValueChanged
		End Sub
	End Class
End Namespace
