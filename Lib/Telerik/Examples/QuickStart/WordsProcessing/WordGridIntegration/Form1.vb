Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Common.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders.Docx
Imports Telerik.Windows.Documents.Flow.FormatProviders.Rtf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Txt
Imports Telerik.Windows.Documents.Flow.Model
Imports Telerik.Windows.Documents.Flow.Model.Styles
Imports Telerik.Windows.Documents.Spreadsheet.Model
Imports System.IO

Namespace Telerik.Examples.WinControls.WordsProcessing.WordGridIntegration
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private Const WidthOfIndentColumns As Integer = 20
        Private Shared ReadOnly DefaultHeaderRowColor As Color = Color.FromArgb(255, 127, 127, 127)
        Private Shared ReadOnly DefaultGroupHeaderRowColor As Color = Color.FromArgb(255, 216, 216, 216)
        Private Shared ReadOnly DefaultDataRowColor As Color = Color.FromArgb(255, 251, 247, 255)
        Private products_Renamed As List(Of Product)
        Private headerRowColor_Renamed As Color
        Private dataRowColor_Renamed As Color
        Private groupHeaderRowColor_Renamed As Color
        Private exportFormats_Renamed As String()
        Private selectedExportFormat_Renamed As String
        Private repeatHeaderRowOnEveryPage_Renamed As Boolean = True

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property Products As List(Of Product)
            Get
                Return Me.products_Renamed
            End Get
            Set(ByVal value As List(Of Product))

                If Me.products_Renamed IsNot value Then
                    Me.products_Renamed = value
                End If
            End Set
        End Property

        Public Property HeaderRowColor As Color
            Get
                Return Me.headerRowColor_Renamed
            End Get
            Set(ByVal value As Color)

                If Me.headerRowColor_Renamed <> value Then
                    Me.headerRowColor_Renamed = value
                End If
            End Set
        End Property

        Public Property DataRowColor As Color
            Get
                Return Me.dataRowColor_Renamed
            End Get
            Set(ByVal value As Color)

                If Me.dataRowColor_Renamed <> value Then
                    Me.dataRowColor_Renamed = value
                End If
            End Set
        End Property

        Public Property GroupHeaderRowColor As Color
            Get
                Return Me.groupHeaderRowColor_Renamed
            End Get
            Set(ByVal value As Color)

                If Me.groupHeaderRowColor_Renamed <> value Then
                    Me.groupHeaderRowColor_Renamed = value
                End If
            End Set
        End Property

        Public ReadOnly Property ExportFormats As IEnumerable(Of String)
            Get

                If exportFormats_Renamed Is Nothing Then
                    exportFormats_Renamed = New String() {"Docx", "Rtf", "Txt"}
                End If

                Return exportFormats_Renamed
            End Get
        End Property

        Public Property SelectedExportFormat As String
            Get
                Return selectedExportFormat_Renamed
            End Get
            Set(ByVal value As String)

                If Not Object.Equals(selectedExportFormat_Renamed, value) Then
                    selectedExportFormat_Renamed = value
                End If
            End Set
        End Property

        Public Property RepeatHeaderRowOnEveryPage As Boolean
            Get
                Return Me.repeatHeaderRowOnEveryPage_Renamed
            End Get
            Set(ByVal value As Boolean)

                If Me.repeatHeaderRowOnEveryPage_Renamed <> value Then
                    Me.repeatHeaderRowOnEveryPage_Renamed = value
                End If
            End Set
        End Property

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.Products = New Products().GetData(100).ToList()
            Me.SelectedExportFormat = Me.ExportFormats.First()
            Me.HeaderRowColor = DefaultHeaderRowColor
            Me.DataRowColor = DefaultDataRowColor
            Me.GroupHeaderRowColor = DefaultGroupHeaderRowColor
            Me.radGridView1.DataSource = Me.Products
            Me.radGridView1.BestFitColumns()
            Me.radGridView1.Columns("UnitPrice").FormatString = "{0:C}"
            Me.radGridView1.Columns("Date").DataType = GetType(DateTime)
            Me.radGridView1.Columns("Date").FormatString = "{0:d}"
            Me.radGridView1.Columns.Remove(Me.radGridView1.Columns("SubTotal"))
            Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.AutoExpandGroups = True
            Dim descriptor As GroupDescriptor = New GroupDescriptor()
            descriptor.GroupNames.Add("UnitPrice", ListSortDirection.Ascending)
            Me.radGridView1.GroupDescriptors.Add(descriptor)
            headerRowColorBox.Value = DefaultHeaderRowColor
            groupHeaderColorBox.Value = DefaultGroupHeaderRowColor
            dataRowColorBox.Value = DefaultDataRowColor
            Me.exportFormatDropDownList.DataSource = Me.ExportFormats
        End Sub

        Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim document As RadFlowDocument = Me.CreateDocument(radGridView1)
            Dim selectedFromat As String = Me.SelectedExportFormat
            SaveDocument(document, selectedFromat)
        End Sub

        Public Shared Sub SaveDocument(ByVal document As RadFlowDocument, ByVal selectedFromat As String)
            Dim formatProvider As IFormatProvider(Of RadFlowDocument) = Nothing

            Select Case selectedFromat
                Case "Docx"
                    formatProvider = New DocxFormatProvider()
                Case "Rtf"
                    formatProvider = New RtfFormatProvider()
                Case "Txt"
                    formatProvider = New TxtFormatProvider()
            End Select

            If formatProvider Is Nothing Then
                Return
            End If

            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = String.Format("{0} files|*{1}|All files (*.*)|*.*", selectedFromat, formatProvider.SupportedExtensions.First())
            dialog.FilterIndex = 1
            dialog.FileName = "WordGridIntegration"

            If dialog.ShowDialog() = DialogResult.OK Then

                Using stream As Stream = dialog.OpenFile()
                    formatProvider.Export(document, stream)
                End Using
            End If
        End Sub

        Private Function CreateDocument(ByVal grid As RadGridView) As RadFlowDocument
            Dim document As RadFlowDocument = New RadFlowDocument()
            Dim table As Table = document.Sections.AddSection().Blocks.AddTable()
            document.StyleRepository.AddBuiltInStyle(BuiltInStyleNames.TableGridStyleId)
            table.StyleId = BuiltInStyleNames.TableGridStyleId
            Dim columns As IList(Of GridViewColumn) = (From c In grid.Columns.OfType(Of GridViewColumn)() Order By c.Index Select c).ToList()
            Dim indentColumns As Integer = grid.GroupDescriptors.Count
            Dim rowIndex As Integer = 0

            If grid.ShowColumnHeaders Then
                Dim headerRow As TableRow = table.Rows.AddTableRow()
                headerRow.RepeatOnEveryPage = Me.RepeatHeaderRowOnEveryPage
                Dim headerBackground As ThemableColor = Me.ConvertColor(Me.headerRowColorBox.Value)

                If grid.GroupDescriptors.Count > 0 Then
                    Me.AddIndentCell(headerRow, indentColumns, headerBackground)
                End If

                For i As Integer = 0 To columns.Count - 1
                    Dim cell As TableCell = headerRow.Cells.AddTableCell()
                    cell.Shading.BackgroundColor = headerBackground
                    cell.PreferredWidth = New TableWidthUnit(columns(i).Width)
                    Dim headerRun As Run = cell.Blocks.AddParagraph().Inlines.AddRun(columns(i).Name)
                    headerRun.FontWeight = System.Windows.FontWeights.Bold
                Next
            End If

            If grid.Groups.Count > 0 Then

                For Each group As DataGroup In grid.Groups
                    rowIndex = Me.AddGroupRow(table, rowIndex, group.Level, group, columns)
                    Me.AddDataRows(table, rowIndex, group.Level + 1, group, columns)
                Next
            Else
                Me.AddDataRows(table, rowIndex, 0, grid.Rows, columns)
            End If

            document.Sections.First().Blocks.AddParagraph()
            Return document
        End Function

        Private Sub AddDataRows(ByVal table As Table, ByVal startRowIndex As Integer, ByVal indentColumnsstartColumnIndex As Integer, ByVal rows As IEnumerable(Of Telerik.WinControls.UI.GridViewRowInfo), ByVal columns As IList(Of GridViewColumn))
            Dim background As ThemableColor = ConvertColor(Me.dataRowColorBox.Value)

            For Each row As GridViewRowInfo In rows
                Dim tableRows As TableRow = table.Rows.AddTableRow()

                If indentColumnsstartColumnIndex > 0 Then
                    Me.AddIndentCell(tableRows, indentColumnsstartColumnIndex, background)
                End If

                For columnIndex As Integer = 0 To columns.Count - 1
                    Dim cell As TableCell = tableRows.Cells.AddTableCell()
                    Me.AddCellValue(cell, row.Cells(columnIndex).Value)
                    cell.Shading.BackgroundColor = background
                    cell.PreferredWidth = New TableWidthUnit(columns(columnIndex).Width)
                Next
            Next
        End Sub

        Private Function AddGroupRow(ByVal table As Table, ByVal rowIndex As Integer, ByVal numberOfIndentCells As Integer, ByVal group As DataGroup, ByVal columns As IList(Of GridViewColumn)) As Integer
            Dim level As Integer = Me.GetGroupLevel(group)
            Dim row As TableRow = table.Rows.AddTableRow()

            If level > 0 Then
                Me.AddIndentCell(row, level, ConvertColor(Me.dataRowColorBox.Value))
            End If

            Dim cell As TableCell = row.Cells.AddTableCell()
            cell.Shading.BackgroundColor = ConvertColor(Me.groupHeaderColorBox.Value)
            cell.ColumnSpan = columns.Count + (If(radGridView1.GroupDescriptors.Count > 0, 1, 0)) - (If(level > 0, 1, 0))
            Me.AddCellValue(cell, group.GroupRow.HeaderText)
            Return rowIndex
        End Function

        Private Sub AddCellValue(ByVal cell As TableCell, ByVal value As Object)
            Dim stringValue As String = If(value IsNot Nothing, value.ToString(), String.Empty)
            cell.Blocks.AddParagraph().Inlines.AddRun(stringValue)
        End Sub

        Private Sub AddIndentCell(ByVal row As TableRow, ByVal indentColumns As Integer, ByVal background As ThemableColor)
            Dim indentCell As TableCell = row.Cells.AddTableCell()
            indentCell.PreferredWidth = New TableWidthUnit(indentColumns * WidthOfIndentColumns)
            indentCell.Shading.BackgroundColor = background
            indentCell.Blocks.AddParagraph()
        End Sub

        Private Function GetGroupLevel(ByVal group As DataGroup) As Integer
            Return group.Level
        End Function

        Private Function ConvertColor(ByVal color As Color) As ThemableColor
            Return ThemableColor.FromArgb(color.A, color.R, color.G, color.B)
        End Function

        Private Sub radCheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.RepeatHeaderRowOnEveryPage = Me.radCheckBox1.Checked
        End Sub

        Private Sub exportFormatDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.SelectedExportFormat = exportFormatDropDownList.Items(e.Position).Text
        End Sub
    End Class
End Namespace
