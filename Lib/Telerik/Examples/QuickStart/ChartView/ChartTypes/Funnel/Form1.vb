Imports Telerik.Charting
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Funnel
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm

		Private funnelSeries As FunnelSeries

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.funnelSeries = New FunnelSeries()

			Me.PopulateFunnelSeries()

			Me.radChartView1.Series.Clear()
			Me.radChartView1.Series.Add(Me.funnelSeries)
			Me.radChartView1.ShowLegend = True
			Me.radChartView1.View.Palette = KnownPalette.Metro
		End Sub

		Private Sub PopulateFunnelSeries()
			Me.funnelSeries.ShowLabels = True

			Me.funnelSeries.DataPoints.Add(New FunnelDataPoint(5442, "Visited the website"))
			Me.funnelSeries.DataPoints.Add(New FunnelDataPoint(1519, "Watched the demos"))
			Me.funnelSeries.DataPoints.Add(New FunnelDataPoint(1131, "Downloaded a trial"))
			Me.funnelSeries.DataPoints.Add(New FunnelDataPoint(811, "Purchased a license"))
			Me.funnelSeries.DataPoints.Add(New FunnelDataPoint(704, "Renewed a license"))

		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler Me.radSpinEditorNeckRatio.ValueChanged, AddressOf radSpinEditorNeckRatio_ValueChanged
			AddHandler Me.radSpinEditorSegmentSpacing.ValueChanged, AddressOf radSpinEditorSegmentSpacing_ValueChanged
			AddHandler Me.radCheckBoxDynamicSlope.ToggleStateChanged, AddressOf radCheckBoxDynamicSlope_ToggleStateChanged
			AddHandler Me.radCheckBoxDynamicHeight.ToggleStateChanged, AddressOf radCheckBoxDynamicHeight_ToggleStateChanged
		End Sub

		Private Sub radCheckBoxDynamicHeight_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.funnelSeries.DynamicHeight = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radSpinEditorNeckRatio.Enabled = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
		End Sub

		Private Sub radCheckBoxDynamicSlope_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.funnelSeries.DynamicSlope = args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
		End Sub

		Private Sub radSpinEditorSegmentSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.funnelSeries.SegmentSpacing = CInt(Fix(Me.radSpinEditorSegmentSpacing.Value))
		End Sub

		Private Sub radSpinEditorNeckRatio_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.funnelSeries.NeckRatio = CSng(Me.radSpinEditorNeckRatio.Value)
		End Sub
	End Class
End Namespace
