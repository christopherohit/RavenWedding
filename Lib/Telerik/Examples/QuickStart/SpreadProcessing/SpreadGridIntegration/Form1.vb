Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Spreadsheet.Model
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadGridIntegration
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private Const WidthOfIndentColumns As Integer = 20
        Private Shared ReadOnly DefaultHeaderRowColor As Color = Color.FromArgb(255, 127, 127, 127)
        Private Shared ReadOnly DefaultGroupHeaderRowColor As Color = Color.FromArgb(255, 216, 216, 216)
        Private Shared ReadOnly DefaultDataRowColor As Color = Color.FromArgb(255, 251, 247, 255)

        Private m_products As List(Of Product)
        Private m_headerRowColor As Color
        Private m_dataRowColor As Color
        Private m_groupHeaderRowColor As Color
        Private m_exportFormats As String()
        Private m_selectedExportFormat As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property Products() As List(Of Product)
            Get
                Return Me.m_products
            End Get
            Set(value As List(Of Product))
                If Not Me.m_products Is value Then
                    Me.m_products = value
                End If
            End Set
        End Property

        Public Property HeaderRowColor() As Color
            Get
                Return Me.m_headerRowColor
            End Get
            Set(value As Color)
                If Me.m_headerRowColor <> value Then
                    Me.m_headerRowColor = value
                End If
            End Set
        End Property

        Public Property DataRowColor() As Color
            Get
                Return Me.m_dataRowColor
            End Get
            Set(value As Color)
                If Me.m_dataRowColor <> value Then
                    Me.m_dataRowColor = value
                End If
            End Set
        End Property

        Public Property GroupHeaderRowColor() As Color
            Get
                Return Me.m_groupHeaderRowColor
            End Get
            Set(value As Color)
                If Me.m_groupHeaderRowColor <> value Then
                    Me.m_groupHeaderRowColor = value
                End If
            End Set
        End Property

        Public ReadOnly Property ExportFormats() As String()
            Get
                If m_exportFormats Is Nothing Then
                    m_exportFormats = New String() {"Xlsx", "Csv", "Txt"}
                End If

                Return m_exportFormats
            End Get
        End Property

        Public Property SelectedExportFormat() As String
            Get
                Return m_selectedExportFormat
            End Get
            Set(value As String)
                If Not Object.Equals(m_selectedExportFormat, value) Then
                    m_selectedExportFormat = value
                End If
            End Set
        End Property

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.Products = New Products().GetData(100).ToList()
            Me.SelectedExportFormat = Me.ExportFormats(0)
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
            Me.exportFormatDropDownList.DataSource = ExportFormats
            Me.exportFormatDropDownList.SelectedIndex = 0
        End Sub

        Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim workbook As Workbook = CreateWorkbook(Me.radGridView1)
            FileHelper.SaveDocument(workbook, Me.SelectedExportFormat)
        End Sub

        Private Function CreateWorkbook(ByVal grid As RadGridView) As Workbook
            Dim workbook As Workbook = New Workbook()
            Dim worksheet As Worksheet = workbook.Worksheets.Add()
            workbook.History.IsEnabled = False
            Dim columns As IList(Of GridViewColumn) = (From c In grid.Columns.OfType(Of GridViewColumn)() Order By c.Index Select c).ToList()
            Dim rowIndex As Integer = 0

            If grid.ShowColumnHeaders Then
                Me.AddHeaderRow(worksheet, grid.GroupDescriptors.Count, columns)
                rowIndex = 1
            End If

            If grid.Groups.Count > 0 Then

                For Each group As DataGroup In grid.Groups
                    rowIndex = Me.AddGroupRow(worksheet, rowIndex, group.Level, group, columns)
                    rowIndex += Me.AddDataRows(worksheet, rowIndex, group.Level + 1, group, columns)
                Next
            Else
                Me.AddDataRows(worksheet, rowIndex, 0, grid.Rows, columns)
            End If

            Me.SetWidthOfColumns(worksheet, grid.GroupDescriptors.Count, columns)
            Return workbook
        End Function

        Private Sub SetWidthOfColumns(ByVal worksheet As Worksheet, ByVal numberOfIndentColumns As Integer, ByVal columns As IList(Of GridViewColumn))
            For i As Integer = 0 To numberOfIndentColumns - 1
                worksheet.Columns(i).SetWidth(New ColumnWidth(WidthOfIndentColumns, False))
            Next

            For i As Integer = 0 To columns.Count - 1
                worksheet.Columns(numberOfIndentColumns + i).SetWidth(New ColumnWidth(columns(i).Width, False))
            Next
        End Sub

        Private Sub AddHeaderRow(ByVal worksheet As Worksheet, ByVal numberOfGroupDescriptors As Integer, ByVal columns As IList(Of GridViewColumn))
            Dim headerColumnStartIndex As Integer = numberOfGroupDescriptors

            For i As Integer = 0 To columns.Count - 1
                worksheet.Cells(0, headerColumnStartIndex + i).SetValue(columns(i).HeaderText)
            Next

            Dim fill As PatternFill = New PatternFill(PatternType.Solid, ThemableColor.FromArgb(Me.headerRowColorBox.Value.A, Me.headerRowColorBox.Value.R, Me.headerRowColorBox.Value.G, Me.headerRowColorBox.Value.B), ThemableColor.FromArgb(0, 255, 255, 255))
            worksheet.Cells(0, 0, 0, numberOfGroupDescriptors + columns.Count - 1).SetFill(fill)
        End Sub

        Private Function AddDataRows(ByVal worksheet As Worksheet, ByVal startRowIndex As Integer, ByVal startColumnIndex As Integer, ByVal rows As IEnumerable(Of Telerik.WinControls.UI.GridViewRowInfo), ByVal columns As IList(Of GridViewColumn)) As Integer
            Dim rowIndex As Integer = 0
            Dim headerColumn As Integer = If((Me.radGridView1.ShowColumnHeaders), 1, 0)
            For Each row As GridViewRowInfo In rows
                If TypeOf row Is GridViewHierarchyRowInfo Then
                    AddDataRows(worksheet, startRowIndex, startColumnIndex, TryCast(Me.radGridView1.Rows(rowIndex), GridViewHierarchyRowInfo).ChildRows, columns)
                End If

                For columnIndex As Integer = 0 To columns.Count - 1
                    Dim value As Object = row.Cells(columnIndex).Value

                    Dim currentRowIndex As Integer = startRowIndex + rowIndex
                    Dim curentColumnIndex As Integer = startColumnIndex + columnIndex
                    worksheet.Cells(currentRowIndex, curentColumnIndex).SetValue(value.ToString())
                Next

                rowIndex += 1
            Next row

            Dim fill As PatternFill = New PatternFill(PatternType.Solid, ThemableColor.FromArgb(Me.dataRowColorBox.Value.A, Me.dataRowColorBox.Value.R, Me.dataRowColorBox.Value.G, Me.dataRowColorBox.Value.B), ThemableColor.FromArgb(0, 255, 255, 255))
            worksheet.Cells(startRowIndex, 0, startRowIndex + rowIndex - headerColumn, startColumnIndex + columns.Count - 1).SetFill(fill)
            Return rowIndex
        End Function

        Private Function AddGroupRow(ByVal worksheet As Worksheet, ByVal rowIndex As Integer, ByVal numberOfIndentCells As Integer, ByVal group As DataGroup, ByVal columns As IList(Of GridViewColumn)) As Integer
            Dim startColumnIndex As Integer = Me.GetGroupLevel(group)
            Dim groupHeaderRow As CellSelection = worksheet.Cells(rowIndex, startColumnIndex, rowIndex, numberOfIndentCells + columns.Count)
            groupHeaderRow.Merge()
            Dim fill As IFill = New PatternFill(PatternType.Solid, ThemableColor.FromArgb(Me.groupHeaderColorBox.Value.A, Me.groupHeaderColorBox.Value.R, Me.groupHeaderColorBox.Value.G, Me.groupHeaderColorBox.Value.B), ThemableColor.FromArgb(0, 255, 255, 255))
            groupHeaderRow.SetFill(fill)
            Dim cellValue As String = group.GroupRow.HeaderText
            groupHeaderRow.SetValue(cellValue)
            groupHeaderRow.SetHorizontalAlignment(Telerik.Windows.Documents.Spreadsheet.Model.RadHorizontalAlignment.Left)
            rowIndex += 1
            startColumnIndex += 1
            Return rowIndex
        End Function

        Private Function GetGroupLevel(ByVal group As DataGroup) As Integer
            Return group.Level
        End Function

        Private Sub exportFormatDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.SelectedExportFormat = exportFormatDropDownList.Items(e.Position).Text
        End Sub
    End Class
End Namespace
