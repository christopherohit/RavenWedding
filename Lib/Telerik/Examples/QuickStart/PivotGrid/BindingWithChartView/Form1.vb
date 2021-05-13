Imports System.IO
Imports Telerik.Charting
Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.Aggregates
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PivotGrid.BindingWithChartView
    Partial Public Class Form1
        Inherits ExamplesForm
        Private orders As New List(Of Order2)()
        Private provider As LocalDataSourceProvider

        Public Sub New()
            Me.InitializeComponent()

            Me.WireEvents()

        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Me.LoadData()
            Me.SetupAxes()
            Me.SetupPivot()
            Me.LoadSettings()
        End Sub

        Private Sub LoadSettings()
            Me.radChartView1.ChartElement.LegendPosition = LegendPosition.Right
            Me.radChartView1.ChartElement.LegendElement.Alignment = ContentAlignment.TopCenter

            Me.checkBoxDelayUpdates.Checked = Me.radPivotGrid1.ChartDataProvider.DelayUpdate
            Me.checkBoxSelectionOnly.Checked = Me.radPivotGrid1.ChartDataProvider.SelectionOnly
            Me.checkBoxColumnSubTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeColumnSubTotals
            Me.checkBoxRowSubTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeRowSubTotals
            Me.checkBoxColumnGrandTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals
            Me.checkBoxRowGrandTotals.Checked = Me.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals

            If Me.radPivotGrid1.ChartDataProvider.SeriesAxis = PivotAxis.Rows Then
                Me.radioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            Else
                Me.radioColumns.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If

            If Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Bar Then
                Me.radioBarSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            ElseIf Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Line Then
                Me.radioLineSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            ElseIf Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Area Then
                Me.radioAreaSeries.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If
        End Sub

        Private Sub LoadData()
            Dim stream As Stream = System.Reflection.Assembly.GetAssembly(Me.GetType()).GetManifestResourceStream("PivotData.txt")

            Using streamReader As New StreamReader(stream)
                Do While streamReader.Peek() <> -1
                    Dim items() As String = streamReader.ReadLine().Split(ControlChars.Tab)
                    Dim o As New Order2() With {.Date = Date.Parse(items(0), System.Globalization.CultureInfo.InvariantCulture), .Product = items(1), .Quantity = Integer.Parse(items(2), System.Globalization.CultureInfo.InvariantCulture), .Net = Double.Parse(items(3), System.Globalization.CultureInfo.InvariantCulture), .Promotion = items(4), .Advertisement = items(5)}
                    Me.orders.Add(o)
                Loop
            End Using
        End Sub

        Private Sub SetupPivot()
            Me.provider = New LocalDataSourceProvider() With {.ItemsSource = Me.orders}

            Me.provider.RowGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Product", .GroupComparer = New GroupNameComparer()})

            Me.provider.ColumnGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "Date", .Step = DateTimeStep.Month})
            Me.provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Promotion", .GroupComparer = New GroupNameComparer()})

            Me.provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Quantity", .CustomName = "Avg. Quantity", .AggregateFunction = AggregateFunctions.Average})

            AddHandler radPivotGrid1.PivotGridElement.UpdateCompleted, AddressOf pivotGridElement_DataUpdated
            Me.radPivotGrid1.DataProvider = Me.provider
            Me.radChartView1.DataSource = Me.radPivotGrid1
        End Sub

        Private Sub pivotGridElement_DataUpdated(ByVal sender As Object, ByVal e As EventArgs)
            Me.Invoke(New MethodInvoker(Sub()
                                            If Me.radPivotGrid1.PivotGridElement.ColumnRootGroup.Children.Count = 0 Then
                                                Return
                                            End If

                                            Dim firstNode As PivotGroupNode = Me.radPivotGrid1.PivotGridElement.ColumnRootGroup.Children(0)
                                            Me.radPivotGrid1.PivotGridElement.SelectColumn(firstNode)
                                            RemoveHandler Me.radPivotGrid1.PivotGridElement.UpdateCompleted, AddressOf pivotGridElement_DataUpdated
                                        End Sub))
        End Sub

        Private Sub SetupAxes()
            Dim verticalAxis As New LinearAxis()
            verticalAxis.AxisType = AxisType.Second

            Dim horizontalAxis As New CategoricalAxis()
            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine

            Me.radChartView1.Area.Axes.Add(horizontalAxis)
            Me.radChartView1.Area.Axes.Add(verticalAxis)
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler checkBoxDelayUpdates.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler checkBoxSelectionOnly.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler checkBoxColumnSubTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler checkBoxRowSubTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler checkBoxColumnGrandTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            AddHandler checkBoxRowGrandTotals.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged

            AddHandler radioRows.ToggleStateChanged, AddressOf radioRows_ToggleStateChanged
            AddHandler radioColumns.ToggleStateChanged, AddressOf radioRows_ToggleStateChanged

            AddHandler radioBarSeries.ToggleStateChanged, AddressOf radioSeries_ToggleStateChanged
            AddHandler radioLineSeries.ToggleStateChanged, AddressOf radioSeries_ToggleStateChanged
            AddHandler radioAreaSeries.ToggleStateChanged, AddressOf radioSeries_ToggleStateChanged

            AddHandler radPivotGrid1.ChartDataProvider.UpdateCompleted, AddressOf ChartDataProvider_UpdateCompleted
        End Sub

        Private Sub UpdateAxesPlotMode()
            Dim axis As CategoricalAxis = TryCast(Me.radChartView1.Axes(0), CategoricalAxis)
            If axis IsNot Nothing Then
                If Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Bar Then
                    axis.PlotMode = Charting.AxisPlotMode.BetweenTicks
                Else
                    axis.PlotMode = Charting.AxisPlotMode.OnTicksPadded
                End If
            End If
        End Sub

        Private Sub UpdateSeriesCombineMode()
            If Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType <> GeneratedSeriesType.Bar Then
                For Each series As CartesianSeries In Me.radChartView1.Series
                    series.CombineMode = ChartSeriesCombineMode.Stack
                Next series
            End If
        End Sub

        Private Sub radioSeries_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If Me.radioBarSeries.IsChecked Then
                Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Bar
            ElseIf Me.radioAreaSeries.IsChecked Then
                Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Area

            ElseIf Me.radioLineSeries.IsChecked Then
                Me.radPivotGrid1.ChartDataProvider.GeneratedSeriesType = GeneratedSeriesType.Line
            End If

            UpdateAxesPlotMode()
        End Sub

        Private Sub ChartDataProvider_UpdateCompleted(ByVal sender As Object, ByVal e As EventArgs)
            UpdateSeriesCombineMode()
        End Sub

        Private Sub radioRows_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radPivotGrid1.ChartDataProvider.SeriesAxis = If(Me.radioRows.IsChecked, PivotAxis.Rows, PivotAxis.Columns)
        End Sub

        Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If sender Is Me.checkBoxDelayUpdates Then
                Me.radPivotGrid1.ChartDataProvider.DelayUpdate = Me.checkBoxDelayUpdates.Checked
            ElseIf sender Is Me.checkBoxSelectionOnly Then
                Me.radPivotGrid1.ChartDataProvider.SelectionOnly = Me.checkBoxSelectionOnly.Checked
            ElseIf sender Is Me.checkBoxColumnSubTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeColumnSubTotals = Me.checkBoxColumnSubTotals.Checked
            ElseIf sender Is Me.checkBoxRowSubTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeRowSubTotals = Me.checkBoxRowSubTotals.Checked
            ElseIf sender Is Me.checkBoxColumnGrandTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeColumnGrandTotals = Me.checkBoxColumnGrandTotals.Checked
            ElseIf sender Is Me.checkBoxRowGrandTotals Then
                Me.radPivotGrid1.ChartDataProvider.IncludeRowGrandTotals = Me.checkBoxRowGrandTotals.Checked
            End If
        End Sub
    End Class
End Namespace
