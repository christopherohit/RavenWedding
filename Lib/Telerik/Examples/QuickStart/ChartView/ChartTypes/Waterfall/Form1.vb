Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Waterfall
	''' <summary>
	''' RadChartView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radChartView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim series As New WaterfallSeries("Value", "Summary", "Total", "Category")
			series.ShowLabels = True
			series.DataSource = DataModel.GetData()

			Me.radChartView1.Series.Add(series)
		End Sub
	End Class
End Namespace

