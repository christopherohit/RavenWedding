Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx
Imports Telerik.Windows.Documents.Spreadsheet.Model
Imports Telerik.Windows.Documents.Spreadsheet.Model.Filtering
Imports Telerik.Windows.Documents.Spreadsheet.Model.Sorting

Namespace Telerik.Examples.WinControls.Spreadsheet.SortingAndFiltering
    Partial Public Class Form1
        Inherits ExamplesForm
        Private Const SampleDocumentPath As String = "..\Spreadsheet\SampleData\OrdersLog.xlsx"

        Private Shared ReadOnly filterRange As New CellRange(2, 0, 48, 7)
        Private Shared ReadOnly sortRange As New CellRange(3, 0, 48, 7)

        Private workbook As Workbook

        Public Sub New()
            Me.StartWaiting()
            InitializeComponent()
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items(3).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items(4)
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.SystemButtons.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.ShouldHandleMouseInput = False
            Me.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.CanManageOwnerForm = False

            Dim bytes As Byte() = File.ReadAllBytes(SampleDocumentPath)
            Me.workbook = TryCast(WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider"), XlsxFormatProvider).Import(bytes)
            Me.workbook.ActiveWorksheet.Filter.FilterRange = filterRange
            Me.workbook.Protect(String.Empty)

            Me.radSpreadsheet1.SpreadsheetElement.Workbook = Me.workbook
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Me.StopWaiting()
            Me.radSpreadsheet1.SpreadsheetElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        End Sub

        Private Sub FilterByMonthSortByCompanyRadioButton_Click(sender As Object, e As EventArgs)
            Me.ApplyFilterByMonthAndSortByCompany()
        End Sub

        Private Sub FilterByCompanySortByFillRadioButton_Click(sender As Object, e As EventArgs)
            Me.ApplyFilterByCompanySortByFill()
        End Sub

        Private Sub TopFilterAndCustomSortRadioButton_Click(sender As Object, e As EventArgs)
            Me.ApplyTopFilterAndCustomSort()
        End Sub

        Private Sub RemoveFilterAndSortRadioButton_Click(sender As Object, e As EventArgs)
            Me.RemoveFiltersAndSortConditions()
        End Sub

        Private Sub ApplyFilterByMonthAndSortByCompany()
            Me.workbook.History.BeginUndoGroup()

            Dim valuesCollectionFilter As New ValuesCollectionFilter(1, Nothing, New DateGroupItem() {New DateGroupItem(2014, 6)})
            Me.ApplyFilter(valuesCollectionFilter)

            Dim conditions As ISortCondition() = New ISortCondition() {New ValuesSortCondition(4, SortOrder.Ascending)}
            Me.SetSortState(conditions)

            Me.workbook.History.EndUndoGroup()
        End Sub

        Private Sub ApplyFilterByCompanySortByFill()
            Me.workbook.History.BeginUndoGroup()

            Dim valuesCollectionFilter As New ValuesCollectionFilter(4, New String() {"Plan Smart"}, New DateGroupItem(-1) {})
            Me.ApplyFilter(valuesCollectionFilter)

            Dim conditions As ISortCondition() = Me.GetSortingConditions()
            Me.SetSortState(conditions)

            Me.workbook.History.EndUndoGroup()
        End Sub

        Private Function GetSortingConditions() As ISortCondition()
            Dim definitionsWorksheet As Worksheet = Me.workbook.Worksheets("Definitions")

            Return New ISortCondition() {New FillColorSortCondition(7, definitionsWorksheet.Cells(1, 0, 1, 0).GetFill().Value, SortOrder.Ascending), New FillColorSortCondition(7, definitionsWorksheet.Cells(2, 0, 2, 0).GetFill().Value, SortOrder.Ascending), New FillColorSortCondition(7, definitionsWorksheet.Cells(3, 0, 3, 0).GetFill().Value, SortOrder.Ascending), New FillColorSortCondition(7, definitionsWorksheet.Cells(4, 0, 4, 0).GetFill().Value, SortOrder.Ascending)}
        End Function

        Private Sub ApplyTopFilterAndCustomSort()
            Me.workbook.History.BeginUndoGroup()

            Dim topFilter As New TopFilter(6, TopFilterType.TopPercent, 20)
            Me.ApplyFilter(topFilter)

            Dim customValuesSortCondition As New CustomValuesSortCondition(5, New String() {"express", "1 day", "2 days", "regular"}, SortOrder.Ascending)
            Me.SetSortState(customValuesSortCondition)

            Me.workbook.History.EndUndoGroup()
        End Sub

        Private Sub RemoveFiltersAndSortConditions()
            Me.workbook.History.BeginUndoGroup()

            Dim worksheet As Worksheet = Me.workbook.ActiveWorksheet

            worksheet.Filter.ClearFilters()
            worksheet.SortState.Clear()

            Me.workbook.History.EndUndoGroup()
        End Sub

        Private Sub ApplyFilter(filter As IFilter)
            Me.workbook.ActiveWorksheet = Me.workbook.Worksheets(0)
            Dim autoFilter As AutoFilter = Me.workbook.ActiveWorksheet.Filter
            autoFilter.ClearFilters()
            autoFilter.FilterRange = filterRange
            autoFilter.SetFilter(filter)
        End Sub

        Private Sub SetSortState(ParamArray conditions As ISortCondition())
            Me.workbook.ActiveWorksheet = Me.workbook.Worksheets(0)
            Dim sortState As SortState = Me.workbook.ActiveWorksheet.SortState
            sortState.[Set](sortRange, conditions)
        End Sub
    End Class
End Namespace