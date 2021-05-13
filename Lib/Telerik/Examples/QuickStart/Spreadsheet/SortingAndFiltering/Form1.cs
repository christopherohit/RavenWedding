using System;
using System.IO;
using Telerik.QuickStart.WinControls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Filtering;
using Telerik.Windows.Documents.Spreadsheet.Model.Sorting;

namespace Telerik.Examples.WinControls.Spreadsheet.SortingAndFiltering
{
    public partial class Form1 : ExamplesForm
    {
        private const string SampleDocumentPath = @"..\Spreadsheet\SampleData\OrdersLog.xlsx";

        private static readonly CellRange filterRange = new CellRange(2, 0, 48, 7);
        private static readonly CellRange sortRange = new CellRange(3, 0, 48, 7);

        private Workbook workbook;

        public Form1()
        {
            this.StartWaiting();
            InitializeComponent();
            this.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items[3].Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = this.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items[4];
            this.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.SystemButtons.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.ShouldHandleMouseInput = false;
            this.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.CanManageOwnerForm = false;

            byte[] bytes = File.ReadAllBytes(SampleDocumentPath);
            this.workbook = (WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider") as XlsxFormatProvider).Import(bytes);
            this.workbook.ActiveWorksheet.Filter.FilterRange = filterRange;
            this.workbook.Protect(string.Empty);

            this.radSpreadsheet1.SpreadsheetElement.Workbook = this.workbook;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.StopWaiting();
            this.radSpreadsheet1.SpreadsheetElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
        }

        private void FilterByMonthSortByCompanyRadioButton_Click(object sender, EventArgs e)
        {
            this.ApplyFilterByMonthAndSortByCompany();
        }

        private void FilterByCompanySortByFillRadioButton_Click(object sender, EventArgs e)
        {
            this.ApplyFilterByCompanySortByFill();
        }

        private void TopFilterAndCustomSortRadioButton_Click(object sender, EventArgs e)
        {
            this.ApplyTopFilterAndCustomSort();
        }

        private void RemoveFilterAndSortRadioButton_Click(object sender, EventArgs e)
        {
            this.RemoveFiltersAndSortConditions();
        }

        private void ApplyFilterByMonthAndSortByCompany()
        {
            this.workbook.History.BeginUndoGroup();

            ValuesCollectionFilter valuesCollectionFilter = new ValuesCollectionFilter(1, null, new DateGroupItem[] { new DateGroupItem(2014, 6) });
            this.ApplyFilter(valuesCollectionFilter);

            ISortCondition[] conditions = new ISortCondition[] { new ValuesSortCondition(4, SortOrder.Ascending) };
            this.SetSortState(conditions);

            this.workbook.History.EndUndoGroup();
        }

        private void ApplyFilterByCompanySortByFill()
        {
            this.workbook.History.BeginUndoGroup();

            ValuesCollectionFilter valuesCollectionFilter = new ValuesCollectionFilter(4, new string[] { "Plan Smart" }, null);
            this.ApplyFilter(valuesCollectionFilter);

            ISortCondition[] conditions = this.GetSortingConditions();
            this.SetSortState(conditions);

            this.workbook.History.EndUndoGroup();
        }

        private ISortCondition[] GetSortingConditions()
        {
            Worksheet definitionsWorksheet = this.workbook.Worksheets["Definitions"];

            return new ISortCondition[] 
            {
                new FillColorSortCondition(7, definitionsWorksheet.Cells[1, 0, 1, 0].GetFill().Value, SortOrder.Ascending),
                new FillColorSortCondition(7, definitionsWorksheet.Cells[2, 0, 2, 0].GetFill().Value, SortOrder.Ascending),
                new FillColorSortCondition(7, definitionsWorksheet.Cells[3, 0, 3, 0].GetFill().Value, SortOrder.Ascending),
                new FillColorSortCondition(7, definitionsWorksheet.Cells[4, 0, 4, 0].GetFill().Value, SortOrder.Ascending)
            };
        }

        private void ApplyTopFilterAndCustomSort()
        {
            this.workbook.History.BeginUndoGroup();

            TopFilter topFilter = new TopFilter(6, TopFilterType.TopPercent, 20);
            this.ApplyFilter(topFilter);

            CustomValuesSortCondition customValuesSortCondition = new CustomValuesSortCondition(5, new string[] { "express", "1 day", "2 days", "regular" }, SortOrder.Ascending);
            this.SetSortState(customValuesSortCondition);

            this.workbook.History.EndUndoGroup();
        }

        private void RemoveFiltersAndSortConditions()
        {
            this.workbook.History.BeginUndoGroup();

            Worksheet worksheet = this.workbook.ActiveWorksheet;

            worksheet.Filter.ClearFilters();
            worksheet.SortState.Clear();

            this.workbook.History.EndUndoGroup();
        }

        private void ApplyFilter(IFilter filter)
        {
            this.workbook.ActiveWorksheet = this.workbook.Worksheets[0];
            AutoFilter autoFilter = this.workbook.ActiveWorksheet.Filter;
            autoFilter.ClearFilters();
            autoFilter.FilterRange = filterRange;
            autoFilter.SetFilter(filter);
        }

        private void SetSortState(params ISortCondition[] conditions)
        {
            this.workbook.ActiveWorksheet = this.workbook.Worksheets[0];
            SortState sortState = this.workbook.ActiveWorksheet.SortState;
            sortState.Set(sortRange, conditions);
        }
    }
}
