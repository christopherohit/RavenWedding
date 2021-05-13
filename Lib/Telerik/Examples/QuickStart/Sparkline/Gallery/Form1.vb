Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Sparkline

Namespace Telerik.Examples.WinControls.Sparkline.Gallery
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private Shared rand As Random = New Random()

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            Me.UpdateGridViewSettings(Me.gridLineSpark)
            Me.UpdateGridViewSettings(Me.gridAreaSpark)
            Me.UpdateGridViewSettings(Me.gridBarSpark)
            Me.UpdateGridViewSettings(Me.gridWinLossSpark)
            Me.AddGridColumns(Me.gridLineSpark, SparkSeriesType.Line)
            Me.AddGridColumns(Me.gridAreaSpark, SparkSeriesType.Area)
            Me.AddGridColumns(Me.gridBarSpark, SparkSeriesType.Bar)
            Me.AddGridColumns(Me.gridWinLossSpark, SparkSeriesType.WinLoss)
            Me.AddLineData()
            Me.AddAreaData()
            Me.AddBarData()
            Me.AddWinLossData()
            Me.gridLineSpark.CurrentRow = Nothing
            Me.gridAreaSpark.CurrentRow = Nothing
            Me.gridBarSpark.CurrentRow = Nothing
            Me.gridWinLossSpark.CurrentRow = Nothing
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.AdjustGridColumnWidths(Me.gridLineSpark)
            Me.AdjustGridColumnWidths(Me.gridAreaSpark)
            Me.AdjustGridColumnWidths(Me.gridBarSpark)
            Me.AdjustGridColumnWidths(Me.gridWinLossSpark)
        End Sub

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()

            AddHandler Me.gridLineSpark.TableElement.HScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridLineSpark.TableElement.VScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridAreaSpark.TableElement.HScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridAreaSpark.TableElement.VScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridBarSpark.TableElement.HScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridBarSpark.TableElement.VScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridWinLossSpark.TableElement.HScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridWinLossSpark.TableElement.VScrollBar.RadPropertyChanging, AddressOf ScrollBar_RadPropertyChanging
            AddHandler Me.gridLineSpark.CellFormatting, AddressOf Grid_CellFormatting
            AddHandler Me.gridAreaSpark.CellFormatting, AddressOf Grid_CellFormatting
            AddHandler Me.gridBarSpark.CellFormatting, AddressOf Grid_CellFormatting
            AddHandler Me.gridWinLossSpark.CellFormatting, AddressOf Grid_CellFormatting
        End Sub

        Private Sub Grid_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
            Dim cellElement As GridSparklineCellElement = TryCast(e.CellElement, GridSparklineCellElement)

            If cellElement Is Nothing Then
                Return
            End If

            If cellElement.GridControl Is Me.gridLineSpark AndAlso e.Column.Name = "Range" Then
                Dim annotation1 As CartesianSparkPlotBandAnnotation = New CartesianSparkPlotBandAnnotation()
                annotation1.DrawMode = AnnotationDrawMode.BelowSeries
                annotation1.Axis = TryCast(cellElement.SparklineElement.Series.Axes(1), SparkCartesianAxis)
                annotation1.From = -40
                annotation1.[To] = 40
                annotation1.BackColor = Color.FromArgb(100, Color.Gray)
                cellElement.SparklineElement.View.Annotations.Add(annotation1)
            End If

            If e.Column.Name = "Axis" Then
                cellElement.SparklineElement.View.ShowAxis = True
            End If
        End Sub

        Private Sub ScrollBar_RadPropertyChanging(ByVal sender As Object, ByVal args As Telerik.WinControls.RadPropertyChangingEventArgs)
            If args.[Property] Is LightVisualElement.VisibilityProperty Then
                args.Cancel = True
            End If
        End Sub

        Private Sub AdjustGridColumnWidths(ByVal grid As RadGridView)
            Dim currentWidth As Integer = grid.TableElement.GroupIndent
            Dim startColumnWidth As Integer = 80
            Dim remainingWidth As Integer = grid.TableElement.Bounds.Width - grid.TableElement.GroupIndent - 240
            Dim desiredColumnWidth As Double = remainingWidth / CDbl((grid.Columns.Count - 3))

            For i As Integer = 0 To grid.Columns.Count - 1
                Dim col As GridViewColumn = grid.Columns(i)

                If i < 3 Then
                    col.Width = startColumnWidth
                ElseIf i < grid.Columns.Count - 1 Then
                    col.Width = CInt(Math.Floor(desiredColumnWidth))
                Else
                    col.Width = grid.TableElement.Bounds.Width - currentWidth
                End If

                currentWidth += col.Width
            Next
        End Sub

        Private Sub AddWinLossData()
            Dim row As GridViewRowInfo = Me.gridWinLossSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/USD"
            row.Cells("High").Value = 0.4311
            row.Cells("Low").Value = -0.3524
            Dim values As Double() = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Win/Loss").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
            row.Cells("Axis").Value = values
            row = Me.gridWinLossSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/GBP"
            row.Cells("High").Value = 0.4321
            row.Cells("Low").Value = -0.4701
            values = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Win/Loss").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
            row.Cells("Axis").Value = values
        End Sub

        Private Sub AddBarData()
            Dim row As GridViewRowInfo = Me.gridBarSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/USD"
            row.Cells("High").Value = 0.4311
            row.Cells("Low").Value = -0.3524
            Dim values As Double() = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Bars").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
            row.Cells("Axis").Value = values
            row = Me.gridBarSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/GBP"
            row.Cells("High").Value = 0.4321
            row.Cells("Low").Value = -0.4701
            values = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Bars").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
            row.Cells("Axis").Value = values
        End Sub

        Private Sub AddAreaData()
            Dim row As GridViewRowInfo = Me.gridAreaSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/USD"
            row.Cells("High").Value = 0.4311
            row.Cells("Low").Value = -0.3524
            Dim values As Double() = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Area").Value = values
            row.Cells("Area + Markers").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
            row.Cells("Axis").Value = values
            row = Me.gridAreaSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/GBP"
            row.Cells("High").Value = 0.4321
            row.Cells("Low").Value = -0.4701
            values = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Area").Value = values
            row.Cells("Area + Markers").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
            row.Cells("Axis").Value = values
        End Sub

        Private Sub AddLineData()
            Dim row As GridViewRowInfo = Me.gridLineSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/USD"
            row.Cells("High").Value = 0.4311
            row.Cells("Low").Value = -0.3524
            Dim values As Double() = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Line").Value = values
            row.Cells("Line + Markers").Value = values
            row.Cells("Range").Value = values
            row.Cells("Scatter").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
            row = Me.gridLineSpark.Rows.AddNew()
            row.Cells("Currency").Value = "EUR/GBP"
            row.Cells("High").Value = 0.4321
            row.Cells("Low").Value = -0.4701
            values = New Double(11) {}

            For i As Integer = 0 To values.Length - 1
                values(i) = rand.[Next](-100, 100)
            Next

            row.Cells("Line").Value = values
            row.Cells("Line + Markers").Value = values
            row.Cells("Range").Value = values
            row.Cells("Scatter").Value = values
            row.Cells("End Points").Value = values
            row.Cells("High/Low").Value = values
        End Sub

        Private Sub AddGridColumns(ByVal grid As RadGridView, ByVal sparkType As SparkSeriesType)
            Dim currencyColumn As GridViewTextBoxColumn = New GridViewTextBoxColumn("Currency")
            currencyColumn.Width = 80
            currencyColumn.HeaderText = "Currency"
            grid.Columns.Add(currencyColumn)
            Dim highValueColumn As GridViewDecimalColumn = New GridViewDecimalColumn("High")
            highValueColumn.Width = 80
            highValueColumn.DecimalPlaces = 4
            highValueColumn.HeaderText = "High"
            grid.Columns.Add(highValueColumn)
            Dim lowValueColumn As GridViewDecimalColumn = New GridViewDecimalColumn("Low")
            lowValueColumn.Width = 80
            lowValueColumn.DecimalPlaces = 4
            lowValueColumn.HeaderText = "Low"
            grid.Columns.Add(lowValueColumn)
            Dim sparklineColumn As GridViewSparklineColumn = New GridViewSparklineColumn()

            Select Case sparkType
                Case SparkSeriesType.Line
                    sparklineColumn = New GridViewSparklineColumn("Line")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Line"
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("Line + Markers")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Line + Markers"
                    sparklineColumn.ShowMarkers = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("Range")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Range"
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("Scatter")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Scatter"
                    sparklineColumn.SeriesType = SparkSeriesType.Scatter
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("End Points")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "End Points"
                    sparklineColumn.ShowFirstPointIndicator = True
                    sparklineColumn.ShowLastPointIndicator = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("High/Low")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "High/Low"
                    sparklineColumn.ShowHighPointIndicator = True
                    sparklineColumn.ShowLowPointIndicator = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                Case SparkSeriesType.Area
                    sparklineColumn = New GridViewSparklineColumn("Area")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Area"
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("Area + Markers")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Area + Markers"
                    sparklineColumn.ShowMarkers = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("End Points")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "End Points"
                    sparklineColumn.ShowFirstPointIndicator = True
                    sparklineColumn.ShowLastPointIndicator = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("High/Low")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "High/Low"
                    sparklineColumn.ShowHighPointIndicator = True
                    sparklineColumn.ShowLowPointIndicator = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("Axis")
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Axis"
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                Case SparkSeriesType.Bar, SparkSeriesType.WinLoss
                    sparklineColumn = New GridViewSparklineColumn()
                    sparklineColumn.HeaderText = If(sparkType = SparkSeriesType.Bar, "Bars", "Win/Loss")
                    sparklineColumn.FieldName = sparklineColumn.HeaderText
                    sparklineColumn.ShowNegativePointIndicators = True
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("End Points")
                    sparklineColumn.ShowNegativePointIndicators = True
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "End Points"
                    sparklineColumn.ShowFirstPointIndicator = True
                    sparklineColumn.ShowLastPointIndicator = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("High/Low")
                    sparklineColumn.ShowNegativePointIndicators = True
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "High/Low"
                    sparklineColumn.ShowHighPointIndicator = True
                    sparklineColumn.ShowLowPointIndicator = True
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                    sparklineColumn = New GridViewSparklineColumn("Axis")
                    sparklineColumn.ShowNegativePointIndicators = True
                    sparklineColumn.ShowTooltip = True
                    sparklineColumn.HeaderText = "Axis"
                    sparklineColumn.SeriesType = sparkType
                    grid.Columns.Add(sparklineColumn)
                Case Else
            End Select
        End Sub

        Private Sub UpdateGridViewSettings(ByVal grid As RadGridView)
            grid.EnableFiltering = True
            grid.ShowHeaderCellButtons = True
            grid.ShowFilteringRow = False
            grid.ShowGroupPanel = False
            grid.AllowAddNewRow = False
            grid.TableElement.TableHeaderHeight = 28
            grid.TableElement.RowHeight = 40
            grid.[ReadOnly] = True
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()
            Me.AdjustGridColumnWidths(Me.gridLineSpark)
            Me.AdjustGridColumnWidths(Me.gridAreaSpark)
            Me.AdjustGridColumnWidths(Me.gridBarSpark)
            Me.AdjustGridColumnWidths(Me.gridWinLossSpark)
        End Sub
    End Class
End Namespace
