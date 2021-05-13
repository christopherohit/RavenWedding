Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Sparkline.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm
        Implements ICustomThemeExamplesForm

        Private viewModel As ExampleViewModel

        Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True
            AddHandler Me.doubleBufferedTableLayoutPanel1.CellPaint, AddressOf Me.DoubleBufferedTableLayoutPanel1_CellPaint
        End Sub

        Private Sub AttachChildViewModels()
            Me.sparklineUserControl1.Owner = Me.viewModel.Callees(0)
            Me.sparklineUserControl1.CallType = CallType.Duration
            Me.sparklineUserControl2.Owner = Me.viewModel.Callees(0)
            Me.sparklineUserControl2.CallType = CallType.HoldTime
            Me.sparklineUserControl3.Owner = Me.viewModel.Callees(0)
            Me.sparklineUserControl3.CallType = CallType.ResolvedIssues
            Me.sparklineUserControl4.Owner = Me.viewModel.Callees(1)
            Me.sparklineUserControl4.CallType = CallType.Duration
            Me.sparklineUserControl5.Owner = Me.viewModel.Callees(1)
            Me.sparklineUserControl5.CallType = CallType.HoldTime
            Me.sparklineUserControl6.Owner = Me.viewModel.Callees(1)
            Me.sparklineUserControl6.CallType = CallType.ResolvedIssues
            Me.sparklineUserControl7.Owner = Me.viewModel.Callees(2)
            Me.sparklineUserControl7.CallType = CallType.Duration
            Me.sparklineUserControl8.Owner = Me.viewModel.Callees(2)
            Me.sparklineUserControl8.CallType = CallType.HoldTime
            Me.sparklineUserControl9.Owner = Me.viewModel.Callees(2)
            Me.sparklineUserControl9.CallType = CallType.ResolvedIssues
        End Sub

        Private Sub DoubleBufferedTableLayoutPanel1_CellPaint(ByVal sender As Object, ByVal e As TableLayoutCellPaintEventArgs)
            If e.Row > 0 AndAlso e.Row < Me.doubleBufferedTableLayoutPanel1.RowCount - 1 Then
                Dim rectangle As Rectangle = e.CellBounds

                If e.Column = Me.doubleBufferedTableLayoutPanel1.ColumnCount - 1 Then
                    rectangle.Width -= 1
                End If

                e.Graphics.DrawRectangle(Pens.LightGray, rectangle)
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.viewModel = New ExampleViewModel()
            Me.AttachChildViewModels()
            Me.BindChartView()
            Me.radLabel6.Text = Me.viewModel.Callees(0).Name
            Me.radLabel7.Text = Me.viewModel.Callees(1).Name
            Me.radLabel8.Text = Me.viewModel.Callees(2).Name
            Me.radChartView1.Title = "Overall Performance for the past 24 hours"
            Me.radChartView1.ShowTitle = True
            Me.radChartView1.View.Margin = New Padding(0, 10, 0, 0)
            Me.radChartView1.BackColor = Color.White
            Me.radChartView1.ForeColor = Color.Black
            Me.UpdateChartTitle()
            Me.radChartView1.ShowLegend = True
            Me.radChartView1.ChartElement.LegendElement.PositionOffset = New SizeF(0, -100)
            Me.radChartView1.ChartElement.LegendOffset = New Point(660, 50)
        End Sub

        Private Sub BindChartView()
            Dim lineSeries As LineSeries = New LineSeries("Active Calls")
            lineSeries.DataSource = Me.viewModel.Calls
            lineSeries.CategoryMember = "TimeInverval"
            lineSeries.ValueMember = "DurationMinutes"
            lineSeries.LegendTitle = "Calls on Hold"
            lineSeries.LegendTitle = "Active Calls"
            lineSeries.BorderColor = Color.FromArgb(142, 196, 65)
            Me.radChartView1.Series.Add(lineSeries)
            Dim lineSeries2 As LineSeries = New LineSeries("Calls on Hold")
            lineSeries2.DataSource = Me.viewModel.Calls
            lineSeries2.CategoryMember = "TimeInverval"
            lineSeries2.ValueMember = "HoldTimeMinutes"
            lineSeries2.LegendTitle = "Calls on Hold"
            lineSeries2.BorderColor = Color.FromArgb(27, 157, 222)
            Me.radChartView1.Series.Add(lineSeries2)
            Dim lineSeries3 As LineSeries = New LineSeries("Abondenments")
            lineSeries3.DataSource = Me.viewModel.Calls
            lineSeries3.CategoryMember = "TimeInverval"
            lineSeries3.ValueMember = "Abandonments"
            lineSeries3.LegendTitle = "Abandonments"
            lineSeries3.BorderColor = Color.FromArgb(245, 151, 0)
            Me.radChartView1.Series.Add(lineSeries3)
            Dim verticalAxis As NumericalAxis = TryCast(Me.radChartView1.Axes(1), NumericalAxis)

            If verticalAxis IsNot Nothing Then
                verticalAxis.Maximum = 100
                verticalAxis.DesiredTickCount = 6
            End If

            Dim horizontalAxis As CategoricalAxis = TryCast(Me.radChartView1.Axes(0), CategoricalAxis)

            If horizontalAxis IsNot Nothing Then
                horizontalAxis.PlotMode = AxisPlotMode.OnTicksPadded
                horizontalAxis.LabelInterval = 2
                horizontalAxis.LabelFormat = "{0:HH:mm}h"
            End If

            Me.radChartView1.Area.View.Palette = KnownPalette.Fluent
        End Sub

        Private Sub UpdateChartTitle()
            Dim titleElement As ChartTitleElement = Me.radChartView1.ChartElement.FindDescendant(Of ChartTitleElement)()

            If titleElement IsNot Nothing Then
                titleElement.Font = Me.radLabel1.Font
                titleElement.Margin = New Padding(0, 10, 0, 0)
            End If
        End Sub
    End Class
End Namespace
