
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Documents.SpreadsheetStreaming

Namespace ExportWithDpl.SpreadsheetStreamingExport
    Public Class ExampleViewModel
        Implements INotifyPropertyChanged
        Private Shared ReadOnly ColumnsCount As Integer = 8
        Private Shared ReadOnly HeaderRowHeight As Integer = 22
        Private Shared ReadOnly RowHeight As Integer = 18
        Private Shared ReadOnly ColumnHeaders As String() = {"ID", "DATE", "TIME", "CLIENT", "COMPANY", "SHIPPING", _
            "DISCOUNT", "STATUS"}
        Private Shared ReadOnly ColumnWidths As Double() = {9.43, 12.29, 10.71, 15.43, 21.71, 14.29, _
            13.57, 11.29}


        Private m_exportedCellsCount As Integer
        Private m_exportTime As Double
        Private m_rowsCount As Integer
        Private m_selectedDocumentFormat As SpreadDocumentFormat
        Private m_totalCellsCount As Integer
        Private exportStarted As DateTime
        Private m_canExport As Boolean

        Public Property SelectedDocumentFormat() As SpreadDocumentFormat
            Get
                Return Me.m_selectedDocumentFormat
            End Get
            Set
                If Me.m_selectedDocumentFormat <> Value Then
                    Me.m_selectedDocumentFormat = Value
                    Me.OnPropertyChanged("SelectedDocumentFormat")
                End If
            End Set
        End Property

        Public ReadOnly Property ExportFormats() As IEnumerable(Of SpreadDocumentFormat)
            Get
                Return [Enum].GetValues(GetType(SpreadDocumentFormat)).Cast(Of SpreadDocumentFormat)()
            End Get
        End Property

        Public Property RowsCount() As Integer
            Get
                Return Me.m_rowsCount
            End Get
            Set
                If Me.m_rowsCount <> Value Then
                    Me.m_rowsCount = Value
                    Me.OnPropertyChanged("RowsCount")
                End If
            End Set
        End Property

        Public Property ExportedCellsCount() As Integer
            Get
                Return Me.m_exportedCellsCount
            End Get
            Set
                If Me.m_exportedCellsCount <> Value Then
                    Me.m_exportedCellsCount = Value
                    Me.OnPropertyChanged("ExportedCellsCount")
                End If
            End Set
        End Property

        Public Property TotalCellsCount() As Integer
            Get
                Return Me.m_totalCellsCount
            End Get
            Set
                If Me.m_totalCellsCount <> Value Then
                    Me.m_totalCellsCount = Value
                    Me.OnPropertyChanged("TotalCellsCount")
                End If
            End Set
        End Property

        Public Property ExportTime() As Double
            Get
                Return Me.m_exportTime
            End Get
            Set
                If Me.m_exportTime <> Value Then
                    Me.m_exportTime = Value
                    Me.OnPropertyChanged("ExportTime")
                End If
            End Set
        End Property

        Public Property CanExport() As Boolean
            Get
                Return Me.m_canExport
            End Get
            Set
                If Me.m_canExport <> Value Then
                    Me.m_canExport = Value
                    Me.OnPropertyChanged("CanExport")
                End If
            End Set
        End Property

        Public Sub New()
            Me.RowsCount = 5000
            Me.CanExport = True
        End Sub

        Public Sub Export()
            Dim dialog As New SaveFileDialog()

            dialog.Filter = [String].Format("{0} files|*.{1}|All files (*.*)|*.*", Me.SelectedDocumentFormat.ToString().ToLower(), Me.SelectedDocumentFormat.ToString().ToLower())
            dialog.FileName = "SpreadStreamProcessing"
            If dialog.ShowDialog() = DialogResult.OK Then
                Me.ExportedCellsCount = 0
                Me.TotalCellsCount = (Me.RowsCount + 3) * ColumnsCount
                Dim stream As Stream = dialog.OpenFile()
                Me.CanExport = False
                Using stream
                    Me.GenerateDocument(stream, Me.RowsCount)
                End Using

                Me.CanExport = True
            End If
        End Sub

        Private Sub GenerateDocument(documentStream As Stream, rowsCount As Integer)
            Me.ExportedCellsCount = 0
            Me.exportStarted = DateTime.Now

            Using workbookExporter As IWorkbookExporter = SpreadExporter.CreateWorkbookExporter(Me.SelectedDocumentFormat, documentStream)
                Using worksheetExporter As IWorksheetExporter = workbookExporter.CreateWorksheetExporter("Orders Log")
                    For i As Integer = 0 To ColumnWidths.Length - 1
                        Using columnExporter As IColumnExporter = worksheetExporter.CreateColumnExporter()
                            columnExporter.SetWidthInCharacters(ColumnWidths(i))
                        End Using
                    Next

                    Me.ExportHeaderRows(worksheetExporter)

                    For rowIndex As Integer = 0 To rowsCount - 1
                        Using rowExporter As IRowExporter = worksheetExporter.CreateRowExporter()
                            rowExporter.SetHeightInPoints(RowHeight)

                            Dim row As DocumentRow = DocumentHelper.GenerateDocumentRow(rowsCount, rowIndex)

                            Dim normalFormat As New SpreadCellFormat()
                            normalFormat.FontSize = 10
                            normalFormat.VerticalAlignment = SpreadVerticalAlignment.Center
                            normalFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center

                            Me.ExportIdColumn(rowExporter, row, normalFormat)
                            Me.ExportDateColumn(rowExporter, row)
                            Me.ExportTimeColumn(rowExporter, row)
                            Me.ExportClientColumn(rowExporter, row, normalFormat)
                            Me.ExportCompanyColumn(rowExporter, row, normalFormat)
                            Me.ExportShippingColumn(rowExporter, row)
                            Me.ExportDiscountColumn(rowExporter, row)
                            Me.ExportStatusColumn(rowExporter, row)
                        End Using
                    Next

                    worksheetExporter.MergeCells(0, 0, 0, 7)
                    worksheetExporter.MergeCells(1, 0, 1, 5)
                    worksheetExporter.MergeCells(1, 6, 1, 7)
                End Using
            End Using
        End Sub

        Private Sub ExportIdColumn(rowExporter As IRowExporter, row As DocumentRow, normalFormat As SpreadCellFormat)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Me.UpdateProgess()
                cellExporter.SetValue(row.Id)
                cellExporter.SetFormat(normalFormat)
            End Using
        End Sub

        Private Sub ExportDateColumn(rowExporter As IRowExporter, row As DocumentRow)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Dim dateFormat As New SpreadCellFormat()
                dateFormat.FontSize = 10
                dateFormat.VerticalAlignment = SpreadVerticalAlignment.Center
                dateFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center
                dateFormat.NumberFormat = "m/d/yyyy"

                Me.UpdateProgess()
                cellExporter.SetValue(row.[Date])
                cellExporter.SetFormat(dateFormat)
            End Using
        End Sub

        Private Sub ExportTimeColumn(rowExporter As IRowExporter, row As DocumentRow)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Dim timeFormat As New SpreadCellFormat()
                timeFormat.FontSize = 10
                timeFormat.VerticalAlignment = SpreadVerticalAlignment.Center
                timeFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center
                timeFormat.NumberFormat = "h:mm;@"

                Me.UpdateProgess()
                cellExporter.SetValue(row.Time)
                cellExporter.SetFormat(timeFormat)
            End Using
        End Sub

        Private Sub ExportClientColumn(rowExporter As IRowExporter, row As DocumentRow, normalFormat As SpreadCellFormat)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Me.UpdateProgess()
                cellExporter.SetValue(row.Client)
                cellExporter.SetFormat(normalFormat)
            End Using
        End Sub

        Private Sub ExportCompanyColumn(rowExporter As IRowExporter, row As DocumentRow, normalFormat As SpreadCellFormat)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Me.UpdateProgess()
                cellExporter.SetValue(row.Company)
                cellExporter.SetFormat(normalFormat)
            End Using
        End Sub

        Private Sub ExportShippingColumn(rowExporter As IRowExporter, row As DocumentRow)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Dim expressFormat As New SpreadCellFormat()
                expressFormat.FontSize = 10
                expressFormat.VerticalAlignment = SpreadVerticalAlignment.Center
                expressFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center

                If row.Shipping = Shipping.Express Then
                    expressFormat.IsBold = True
                    expressFormat.ForeColor = New SpreadThemableColor(New SpreadColor(192, 0, 0))
                End If

                Dim shipping__1 As String = String.Empty
                Select Case row.Shipping
                    Case Shipping.Express
                        shipping__1 = "express"
                        Exit Select
                    Case Shipping.OneDay
                        shipping__1 = "1 day"
                        Exit Select
                    Case Shipping.TwoDays
                        shipping__1 = "2 days"
                        Exit Select
                    Case Shipping.Regular
                        shipping__1 = "regular"
                        Exit Select
                End Select

                Me.UpdateProgess()
                cellExporter.SetValue(shipping__1)
                cellExporter.SetFormat(expressFormat)
            End Using
        End Sub

        Private Sub ExportDiscountColumn(rowExporter As IRowExporter, row As DocumentRow)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Dim percentFormat As New SpreadCellFormat()
                percentFormat.FontSize = 10
                percentFormat.VerticalAlignment = SpreadVerticalAlignment.Center
                percentFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center
                percentFormat.NumberFormat = "0%"

                Me.UpdateProgess()
                cellExporter.SetValue(row.Discount)
                cellExporter.SetFormat(percentFormat)
            End Using
        End Sub

        Private Sub ExportStatusColumn(rowExporter As IRowExporter, row As DocumentRow)
            Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                Dim color As SpreadColor = Nothing
                Select Case row.Shipping
                    Case Shipping.Express
                        color = New SpreadColor(242, 116, 33)
                        Exit Select
                    Case Shipping.OneDay
                        color = New SpreadColor(255, 192, 0)
                        Exit Select
                    Case Shipping.TwoDays
                        color = New SpreadColor(142, 188, 0)
                        Exit Select
                    Case Shipping.Regular
                        color = New SpreadColor(27, 157, 222)
                        Exit Select
                End Select

                Dim statusFormat As New SpreadCellFormat()
                statusFormat.Fill = SpreadPatternFill.CreateSolidFill(color)
                Dim border As New SpreadBorder(SpreadBorderStyle.Thin, New SpreadThemableColor(New SpreadColor(255, 255, 255)))
                statusFormat.LeftBorder = border
                statusFormat.TopBorder = border
                statusFormat.RightBorder = border
                statusFormat.BottomBorder = border

                Me.UpdateProgess()
                cellExporter.SetFormat(statusFormat)
            End Using
        End Sub

        Private Sub ExportHeaderRows(worksheetExporter As IWorksheetExporter)
            Using rowExporter As IRowExporter = worksheetExporter.CreateRowExporter()
                rowExporter.SetHeightInPoints(HeaderRowHeight)

                Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                    Dim format As New SpreadCellFormat()
                    format.FontFamily = New SpreadThemableFontFamily("Segoe UI")
                    format.FontSize = 16
                    format.Fill = SpreadPatternFill.CreateSolidFill(New SpreadColor(51, 153, 51))
                    format.ForeColor = New SpreadThemableColor(New SpreadColor(255, 255, 255))
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Left
                    format.VerticalAlignment = SpreadVerticalAlignment.Center

                    cellExporter.SetFormat(format)
                    cellExporter.SetValue("ORDERS LOG")
                End Using
            End Using

            Using rowExporter As IRowExporter = worksheetExporter.CreateRowExporter()
                rowExporter.SetHeightInPoints(HeaderRowHeight)

                Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                    Dim format As New SpreadCellFormat()
                    format.FontFamily = New SpreadThemableFontFamily("Segoe UI")
                    format.FontSize = 14
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Left
                    format.VerticalAlignment = SpreadVerticalAlignment.Center

                    cellExporter.SetFormat(format)
                    cellExporter.SetValue("REPORT")
                End Using

                rowExporter.SkipCells(5)

                Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                    Dim format As New SpreadCellFormat()
                    format.FontFamily = New SpreadThemableFontFamily("Segoe UI")
                    format.FontSize = 14
                    format.NumberFormat = "[$-409]mmm-yy;@"
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Center
                    format.VerticalAlignment = SpreadVerticalAlignment.Center

                    cellExporter.SetFormat(format)
                    cellExporter.SetFormula("=TODAY()")
                End Using
            End Using

            Using rowExporter As IRowExporter = worksheetExporter.CreateRowExporter()
                rowExporter.SetHeightInPoints(HeaderRowHeight)

                Dim format As New SpreadCellFormat()
                format.IsBold = True
                format.Fill = SpreadPatternFill.CreateSolidFill(New SpreadColor(142, 196, 65))
                format.ForeColor = New SpreadThemableColor(New SpreadColor(255, 255, 255))
                format.HorizontalAlignment = SpreadHorizontalAlignment.Center
                format.VerticalAlignment = SpreadVerticalAlignment.Center

                For i As Integer = 0 To ColumnHeaders.Length - 1
                    Using cellExporter As ICellExporter = rowExporter.CreateCellExporter()
                        cellExporter.SetFormat(format)
                        cellExporter.SetValue(ColumnHeaders(i))
                    End Using
                Next
            End Using
        End Sub

        Private Sub UpdateProgess()
            Me.ExportedCellsCount += 1
            Me.ExportTime = (DateTime.Now - Me.exportStarted).TotalMilliseconds / 1000
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            Dim handler As PropertyChangedEventHandler = Me.PropertyChangedEvent

            If Not handler Is Nothing Then
                handler(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
