Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Charting
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts

Namespace Telerik.Examples.WinControls.ChartView.FirstLook
	''' <summary>
	''' RadChartView example
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Implements ICustomThemeExamplesForm
		Private model As OrderViewModel

		Public Sub New()
			InitializeComponent()
			radChartView1.View.Margin = New Padding(5)
			radChartView2.View.Margin = New Padding(5)
			radChartView3.View.Margin = New Padding(5)

		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			model = New OrderViewModel()

			InitializeBarSeries()
			InitializePieSeries()
			InitializeLineSeries()
			InitalizeGrid()
		End Sub

		Private Sub InitalizeGrid()
			AddHandler radGridView1.CreateCell, AddressOf radGridView1_CreateCell
			Me.radGridView1.TableElement.RowHeight = 40
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.AutoExpandGroups = True
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.AllowColumnReorder = False
			Me.radGridView1.EnableSorting = False
			Me.radGridView1.ShowGroupPanel = False
			Me.radGridView1.ShowRowHeaderColumn = False
			Me.radGridView1.TableElement.BackColor = Color.Transparent
			Me.radGridView1.TableElement.Padding = New Padding(10)
			Me.radGridView1.GridViewElement.BorderBoxStyle = BorderBoxStyle.SingleBorder
			Me.radGridView1.GridViewElement.BorderGradientStyle = GradientStyles.Solid
			Me.radGridView1.GridViewElement.BorderColor = Color.Transparent

			Dim textBoxColumn As New GridViewTextBoxColumn()
			textBoxColumn.Name = "Name"
			textBoxColumn.HeaderText = "Name"
			textBoxColumn.FieldName = "Name"
			textBoxColumn.Width = 110
			textBoxColumn.TextAlignment = ContentAlignment.BottomRight
			radGridView1.MasterTemplate.Columns.Add(textBoxColumn)

			Dim textBoxColumn2 As New GridViewTextBoxColumn()
			textBoxColumn2.Name = "Snacks"
			textBoxColumn2.HeaderText = "Snacks"
			textBoxColumn2.FieldName = "Snacks"
			textBoxColumn2.Width = 150
			textBoxColumn2.TextAlignment = ContentAlignment.BottomRight
			radGridView1.MasterTemplate.Columns.Add(textBoxColumn2)

			Dim textBoxColumn3 As New GridViewTextBoxColumn()
			textBoxColumn3.Name = "Beverages"
			textBoxColumn3.HeaderText = "Beverages"
			textBoxColumn3.FieldName = "Beverages"
			textBoxColumn3.Width = 150
			textBoxColumn3.TextAlignment = ContentAlignment.BottomRight
			radGridView1.MasterTemplate.Columns.Add(textBoxColumn3)

			Me.radGridView1.Rows.Add("Europe", Nothing, Nothing)
			Me.radGridView1.Rows.Add("North America", Nothing, Nothing)
			Me.radGridView1.Rows.Add("Asia", Nothing, Nothing)
			Me.radGridView1.Rows.Add("Other", Nothing, Nothing)
		End Sub

		Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If e.CellType Is GetType(GridDataCellElement) AndAlso (e.Column.Name = "Snacks" OrElse e.Column.Name = "Beverages") Then
				e.CellType = GetType(ChartCellElement)
			End If
		End Sub

		Private Sub InitializeLineSeries()
			Dim lineSeries1 As New LineSeries()
			lineSeries1.Name = "Snacks"
			lineSeries1.LegendTitle = "Snacks"
			lineSeries1.PointSize = New SizeF(0, 0)
			lineSeries1.BorderWidth = 2
			lineSeries1.DataSource = model.LineStackData
			lineSeries1.ValueMember = "Value"
			lineSeries1.CategoryMember = "Month"
			Me.radChartView3.Series.Add(lineSeries1)

			Dim lineSeries2 As New LineSeries()
			lineSeries2.Name = "Beverages"
			lineSeries2.LegendTitle = "Beverages"
			lineSeries2.PointSize = New SizeF(0, 0)
			lineSeries2.BorderWidth = 2
			lineSeries2.ValueMember = "Value"
			lineSeries2.CategoryMember = "Month"
			lineSeries2.DataSource = model.LineBeverageData
			Me.radChartView3.Series.Add(lineSeries2)

			Me.radChartView3.ShowLegend = True
		End Sub

		Private Sub InitializePieSeries()
			Dim pieSeries As New PieSeries()
			pieSeries.ValueMember = "Value"
			pieSeries.LegendTitleMember = "Name"
			pieSeries.DataSource = model.Regions
			pieSeries.ShowLabels = True

			Me.radChartView2.Series.Add(pieSeries)
			Me.radChartView2.ShowLegend = True
		End Sub

		Private Sub InitializeBarSeries()
			Dim barSeries As New BarSeries()
			barSeries.Name = "Snacks"
			barSeries.LegendTitle = "Snacks"
			barSeries.ValueMember = "Value"
			barSeries.CategoryMember = "Month"
			barSeries.DataSource = model.BarSnackData
			Me.radChartView1.Series.Add(barSeries)

			Dim barSeries2 As New BarSeries()
			barSeries2.Name = "Beverages"
			barSeries2.LegendTitle = "Beverages"
			barSeries2.DataSource = model.BarBeverageData
			barSeries2.ValueMember = "Value"
			barSeries2.CategoryMember = "Month"
			Me.radChartView1.Series.Add(barSeries2)

			For i As Integer = 0 To Me.radChartView1.Series.Count - 1
				Me.radChartView1.GetSeries(Of BarSeries)(i).CombineMode = ChartSeriesCombineMode.Stack
			Next i

			Me.radChartView1.ShowLegend = True
		End Sub
	End Class
End Namespace
