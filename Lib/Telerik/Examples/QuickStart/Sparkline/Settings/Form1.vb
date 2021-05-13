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

Namespace Telerik.Examples.WinControls.Sparkline.Settings
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private Shared rand As Random = New Random()
        Private suspendCheckAll As Boolean

        Public Sub New()
            InitializeComponent()

            Me.CenterPanel = True
            Me.AddLineData()
        End Sub

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()

            AddHandler Me.radCheckBoxTooltip.ToggleStateChanged, AddressOf Me.radCheckBoxTooltip_ToggleStateChanged
            AddHandler Me.radColorBoxRangeColor.ValueChanged, AddressOf Me.radColorBoxRangeColor_ValueChanged
            AddHandler Me.radColorBoxLowPoint.ValueChanged, AddressOf Me.radColorBoxLowPoint_ValueChanged
            AddHandler Me.radColorBoxFirstPoint.ValueChanged, AddressOf Me.radColorBoxFirstPoint_ValueChanged
            AddHandler Me.radColorBoxLastPoint.ValueChanged, AddressOf Me.radColorBoxLastPoint_ValueChanged
            AddHandler Me.radColorBoxAxisStroke.ValueChanged, AddressOf Me.radColorBoxAxisStroke_ValueChanged
            AddHandler Me.radColorBoxMarkers.ValueChanged, AddressOf Me.radColorBoxMarkers_ValueChanged
            AddHandler Me.radColorBoxHighPoint.ValueChanged, AddressOf Me.radColorBoxHighPoint_ValueChanged
            AddHandler Me.radColorBoxNegativePoints.ValueChanged, AddressOf Me.radColorBoxNegativePoints_ValueChanged
            AddHandler Me.radCheckBoxShowAll.ToggleStateChanged, AddressOf Me.radCheckBox9_ToggleStateChanged
            AddHandler Me.radCheckBoxMarkers.ToggleStateChanged, AddressOf Me.radCheckBox6_ToggleStateChanged
            AddHandler Me.radCheckBoxRange.ToggleStateChanged, AddressOf Me.radCheckBox7_ToggleStateChanged
            AddHandler Me.radCheckBoxAxis.ToggleStateChanged, AddressOf Me.radCheckBox8_ToggleStateChanged
            AddHandler Me.radCheckBoxLastPoint.ToggleStateChanged, AddressOf Me.radCheckBox5_ToggleStateChanged
            AddHandler Me.radCheckBoxFirstPoint.ToggleStateChanged, AddressOf Me.radCheckBox4_ToggleStateChanged
            AddHandler Me.radCheckBoxNegativePoints.ToggleStateChanged, AddressOf Me.radCheckBox3_ToggleStateChanged
            AddHandler Me.radCheckLowPoint.ToggleStateChanged, AddressOf Me.radCheckBox2_ToggleStateChanged
            AddHandler Me.radColorBoxAreaAndLine.ValueChanged, AddressOf Me.radColorBoxAreaAndLine_ValueChanged
            AddHandler Me.radCheckBoxHighPoint.ToggleStateChanged, AddressOf Me.radCheckBox1_ToggleStateChanged

            AddHandler Me.tableLayoutPanel1.CellPaint, AddressOf TableLayoutPanel1_CellPaint
        End Sub

        Protected Overrides Sub UnwireEvents()
            MyBase.UnwireEvents()

            RemoveHandler Me.radCheckBoxTooltip.ToggleStateChanged, AddressOf Me.radCheckBoxTooltip_ToggleStateChanged
            RemoveHandler Me.radColorBoxRangeColor.ValueChanged, AddressOf Me.radColorBoxRangeColor_ValueChanged
            RemoveHandler Me.radColorBoxLowPoint.ValueChanged, AddressOf Me.radColorBoxLowPoint_ValueChanged
            RemoveHandler Me.radColorBoxFirstPoint.ValueChanged, AddressOf Me.radColorBoxFirstPoint_ValueChanged
            RemoveHandler Me.radColorBoxLastPoint.ValueChanged, AddressOf Me.radColorBoxLastPoint_ValueChanged
            RemoveHandler Me.radColorBoxAxisStroke.ValueChanged, AddressOf Me.radColorBoxAxisStroke_ValueChanged
            RemoveHandler Me.radColorBoxMarkers.ValueChanged, AddressOf Me.radColorBoxMarkers_ValueChanged
            RemoveHandler Me.radColorBoxHighPoint.ValueChanged, AddressOf Me.radColorBoxHighPoint_ValueChanged
            RemoveHandler Me.radColorBoxNegativePoints.ValueChanged, AddressOf Me.radColorBoxNegativePoints_ValueChanged
            RemoveHandler Me.radCheckBoxShowAll.ToggleStateChanged, AddressOf Me.radCheckBox9_ToggleStateChanged
            RemoveHandler Me.radCheckBoxMarkers.ToggleStateChanged, AddressOf Me.radCheckBox6_ToggleStateChanged
            RemoveHandler Me.radCheckBoxRange.ToggleStateChanged, AddressOf Me.radCheckBox7_ToggleStateChanged
            RemoveHandler Me.radCheckBoxAxis.ToggleStateChanged, AddressOf Me.radCheckBox8_ToggleStateChanged
            RemoveHandler Me.radCheckBoxLastPoint.ToggleStateChanged, AddressOf Me.radCheckBox5_ToggleStateChanged
            RemoveHandler Me.radCheckBoxFirstPoint.ToggleStateChanged, AddressOf Me.radCheckBox4_ToggleStateChanged
            RemoveHandler Me.radCheckBoxNegativePoints.ToggleStateChanged, AddressOf Me.radCheckBox3_ToggleStateChanged
            RemoveHandler Me.radCheckLowPoint.ToggleStateChanged, AddressOf Me.radCheckBox2_ToggleStateChanged
            RemoveHandler Me.radColorBoxAreaAndLine.ValueChanged, AddressOf Me.radColorBoxAreaAndLine_ValueChanged
            RemoveHandler Me.radCheckBoxHighPoint.ToggleStateChanged, AddressOf Me.radCheckBox1_ToggleStateChanged


            RemoveHandler Me.tableLayoutPanel1.CellPaint, AddressOf TableLayoutPanel1_CellPaint
        End Sub

        Private Sub TableLayoutPanel1_CellPaint(ByVal sender As Object, ByVal e As TableLayoutCellPaintEventArgs)
            Dim pen As Pen = New Pen(Color.LightGray)
            pen.Width = 2
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash

            If e.Row < Me.tableLayoutPanel1.RowCount - 1 Then

                If e.Column < Me.tableLayoutPanel1.ColumnCount - 1 Then
                    e.Graphics.DrawLine(pen, New Point(e.CellBounds.X, e.CellBounds.Bottom), New Point(e.CellBounds.Right, e.CellBounds.Bottom))
                    e.Graphics.DrawLine(pen, New Point(e.CellBounds.Right, e.CellBounds.Bottom), New Point(e.CellBounds.Right, e.CellBounds.Y))
                Else
                    e.Graphics.DrawLine(pen, New Point(e.CellBounds.X, e.CellBounds.Bottom), New Point(e.CellBounds.Right, e.CellBounds.Bottom))
                End If
            Else

                If e.Column < Me.tableLayoutPanel1.ColumnCount - 1 Then
                    e.Graphics.DrawLine(pen, New Point(e.CellBounds.Right, e.CellBounds.Bottom), New Point(e.CellBounds.Right, e.CellBounds.Y))
                End If
            End If
        End Sub

        Private Sub AddLineData()
            Dim lineSeries As SparkLineSeries = New SparkLineSeries()
            Me.radSparkline1.Series = lineSeries
            lineSeries = New SparkLineSeries()
            Me.radSparkline2.Series = lineSeries
            lineSeries = New SparkLineSeries()
            Me.radSparkline3.Series = lineSeries
            lineSeries = New SparkLineSeries()
            Me.radSparkline4.Series = lineSeries

            For i As Integer = 0 To 12 - 1
                Me.radSparkline1.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline2.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline3.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline4.Series.DataPoints.Add(rand.[Next](-100, 100))
            Next

            Dim areaSeries As SparkAreaSeries = New SparkAreaSeries()
            Me.radSparkline5.Series = areaSeries
            areaSeries = New SparkAreaSeries()
            Me.radSparkline6.Series = areaSeries
            areaSeries = New SparkAreaSeries()
            Me.radSparkline7.Series = areaSeries
            areaSeries = New SparkAreaSeries()
            Me.radSparkline8.Series = areaSeries

            For i As Integer = 0 To 12 - 1
                Me.radSparkline5.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline6.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline7.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline8.Series.DataPoints.Add(rand.[Next](-100, 100))
            Next

            Dim scatterSeries As SparkScatterSeries = New SparkScatterSeries()
            Me.radSparkline9.Series = scatterSeries
            scatterSeries = New SparkScatterSeries()
            Me.radSparkline10.Series = scatterSeries
            scatterSeries = New SparkScatterSeries()
            Me.radSparkline11.Series = scatterSeries
            scatterSeries = New SparkScatterSeries()
            Me.radSparkline12.Series = scatterSeries

            For i As Integer = 0 To 12 - 1
                Me.radSparkline9.Series.DataPoints.Add(i, rand.[Next](-100, 100))
                Me.radSparkline10.Series.DataPoints.Add(i, rand.[Next](-100, 100))
                Me.radSparkline11.Series.DataPoints.Add(i, rand.[Next](-100, 100))
                Me.radSparkline12.Series.DataPoints.Add(i, rand.[Next](-100, 100))
            Next

            Dim barSeries As SparkBarSeries = New SparkBarSeries()
            Me.radSparkline13.Series = barSeries
            barSeries = New SparkBarSeries()
            Me.radSparkline14.Series = barSeries
            barSeries = New SparkBarSeries()
            Me.radSparkline15.Series = barSeries
            barSeries = New SparkBarSeries()
            Me.radSparkline16.Series = barSeries

            For i As Integer = 0 To 12 - 1
                Me.radSparkline13.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline14.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline15.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline16.Series.DataPoints.Add(rand.[Next](-100, 100))
            Next

            Dim winLossSeries As SparkWinLossSeries = New SparkWinLossSeries()
            Me.radSparkline17.Series = winLossSeries
            winLossSeries = New SparkWinLossSeries()
            Me.radSparkline18.Series = winLossSeries
            winLossSeries = New SparkWinLossSeries()
            Me.radSparkline19.Series = winLossSeries
            winLossSeries = New SparkWinLossSeries()
            Me.radSparkline20.Series = winLossSeries

            For i As Integer = 0 To 12 - 1
                Me.radSparkline17.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline18.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline19.Series.DataPoints.Add(rand.[Next](-100, 100))
                Me.radSparkline20.Series.DataPoints.Add(rand.[Next](-100, 100))
            Next
        End Sub

        Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.ShowHighPointIndicator = Me.radCheckBoxHighPoint.Checked
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.ShowLowPointIndicator = Me.radCheckLowPoint.Checked
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.ShowNegativePointIndicators = Me.radCheckBoxNegativePoints.Checked
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox4_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.ShowFirstPointIndicator = Me.radCheckBoxFirstPoint.Checked
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox5_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.ShowLastPointIndicator = Me.radCheckBoxLastPoint.Checked
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox6_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                Dim lineSeries As SparkLineSeries = TryCast(sparkline.Series, SparkLineSeries)

                If lineSeries IsNot Nothing Then
                    lineSeries.ShowMarkers = Me.radCheckBoxMarkers.Checked
                End If
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox7_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                If TypeOf sparkline.Series Is SparkLineSeries OrElse TypeOf sparkline.Series Is SparkScatterSeries Then

                    If Me.radCheckBoxRange.Checked Then
                        Dim range As CartesianSparkPlotBandAnnotation = New CartesianSparkPlotBandAnnotation()
                        range.DrawMode = AnnotationDrawMode.BelowSeries
                        range.Axis = TryCast(sparkline.Series.Axes(1), SparkCartesianAxis)
                        range.From = -30
                        range.[To] = 30
                        range.BackColor = Color.FromArgb(100, Color.LightGray)
                        sparkline.SparklineElement.View.Annotations.Add(range)
                    Else
                        sparkline.SparklineElement.View.Annotations.Clear()
                    End If
                End If
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox8_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                Dim lineSeries As SparkLineSeries = TryCast(sparkline.Series, SparkLineSeries)

                If TypeOf sparkline.Series Is SparkLineSeries OrElse TypeOf sparkline.Series Is SparkScatterSeries Then
                    sparkline.ShowAxis = Me.radCheckBoxAxis.Checked
                End If
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBoxTooltip_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.ShowToolTip = Me.radCheckBoxTooltip.Checked
            Next

            Me.UpdateCheckAll()
        End Sub

        Private Sub radCheckBox9_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If Me.suspendCheckAll Then
                Return
            End If

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                Me.suspendCheckAll = True
                Me.radCheckBoxHighPoint.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckLowPoint.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckBoxNegativePoints.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckBoxFirstPoint.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckBoxLastPoint.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckBoxMarkers.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckBoxRange.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckBoxAxis.Checked = Me.radCheckBoxShowAll.Checked
                Me.radCheckBoxTooltip.Checked = Me.radCheckBoxShowAll.Checked
                Me.suspendCheckAll = False
            Next
        End Sub

        Private Sub UpdateCheckAll()
            If Me.suspendCheckAll Then
                Return
            End If

            Dim shouldCheck As Boolean = True

            For Each control As Control In Me.radGroupBox1.Controls
                Dim checkBox As RadCheckBox = TryCast(control, RadCheckBox)

                If checkBox Is Nothing OrElse checkBox Is Me.radCheckBoxShowAll Then
                    Continue For
                End If

                If Not checkBox.Checked Then
                    shouldCheck = False
                    Exit For
                End If
            Next

            Me.suspendCheckAll = True
            Me.radCheckBoxShowAll.Checked = shouldCheck
            Me.suspendCheckAll = False
        End Sub

        Private Sub radColorBoxMarkers_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxMarkers.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.MarkerBackColor = Me.radColorBoxMarkers.Value
            Next
        End Sub

        Private Sub radColorBoxAreaAndLine_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing AndAlso TypeOf sparkline.Series Is SparkLineSeries Then
                    Continue For
                End If

                sparkline.Series.BackColor = Me.radColorBoxAreaAndLine.Value
                sparkline.Series.BorderColor = Me.radColorBoxAreaAndLine.Value
            Next
        End Sub

        Private Sub radColorBoxNegativePoints_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxNegativePoints.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                Me.radCheckBoxNegativePoints.Checked = True
                sparkline.Series.NegativePointBackColor = Me.radColorBoxNegativePoints.Value
            Next
        End Sub

        Private Sub radColorBoxHighPoint_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxHighPoint.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.HighPointBackColor = Me.radColorBoxHighPoint.Value
            Next
        End Sub

        Private Sub radColorBoxLowPoint_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckLowPoint.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.LowPointBackColor = Me.radColorBoxLowPoint.Value
            Next
        End Sub

        Private Sub radColorBoxFirstPoint_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxFirstPoint.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.FirstPointBackColor = Me.radColorBoxFirstPoint.Value
            Next
        End Sub

        Private Sub radColorBoxLastPoint_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxLastPoint.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Series.LastPointBackColor = Me.radColorBoxLastPoint.Value
            Next
        End Sub

        Private Sub radColorBoxAxisStroke_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxAxis.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                sparkline.Axes(0).BorderColor = Me.radColorBoxAxisStroke.Value
            Next
        End Sub

        Private Sub radColorBoxRangeColor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxRange.Checked = True

            For Each control As Control In Me.tableLayoutPanel1.Controls
                Dim sparkline As RadSparkline = TryCast(control, RadSparkline)

                If sparkline Is Nothing Then
                    Continue For
                End If

                If sparkline.Annotations.Count > 0 Then
                    sparkline.Annotations(0).BackColor = Me.radColorBoxRangeColor.Value
                End If
            Next
        End Sub
    End Class
End Namespace
