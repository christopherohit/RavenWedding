using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.Xls;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Utilities;

namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadGeneration
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private Products products = new Products();        
        private IEnumerable<string> exportFormats;

        private static readonly int IndexColumnName = 0;
        private static readonly int IndexColumnQuantity = 1;
        private static readonly int IndexColumnUnitPrice = 2;
        private static readonly int IndexColumnSubTotal = 3;

        private static readonly ThemableColor InvoiceBackground = new ThemableColor(System.Windows.Media.Color.FromArgb(255, 44, 62, 80));
        private static readonly ThemableColor InvoiceHeaderForeground = new ThemableColor(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
        private static readonly string EnUSCultureAccountFormatString = "_($* #,##0.00_);_($* (#,##0.00);_($* \"-\"??_);_(@_)";

        public Form1()
        {
            InitializeComponent();

            WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsxFormatProvider());
            WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsFormatProvider());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.exportFormatDropDownList.DataSource = ExportFormats;
            this.exportFormatDropDownList.SelectedIndex = 0;
            this.radGridView1.AutoGenerateColumns = false;
            this.radGridView1.AllowEditRow = false;
            this.radGridView1.AllowDeleteRow = false;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.ShowRowHeaderColumn = false;
            this.radGridView1.DataSource = this.products.GetData(20);
            this.radGridView1.BestFitColumns();
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.CurrentRow = null;
            this.radGridView1.SelectionChanging += SelectionChanging;
            
            this.CalculateTotal();
        }

        void SelectionChanging(object sender, GridViewSelectionCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void CalculateTotal()
        {
            decimal sum = 0;
            foreach (var row in this.radGridView1.Rows)
            {
                sum += decimal.Parse(row.Cells[3].Value.ToString());
            }

            this.totalSumLabel.Text = string.Format("{0:C}", sum);
        }

        public IEnumerable<string> ExportFormats
        {
            get
            {
                if (this.exportFormats == null)
                {
                    this.exportFormats = new string[] { "Xlsx", "Xls", "Csv", "Txt" };
                }

                return this.exportFormats;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Workbook workbook = this.CreateWorkbook(this.radGridView1);
            SaveDocument(workbook, this.exportFormatDropDownList.Text);
        }


        private Workbook CreateWorkbook(RadGridView gridView)
        {
            Workbook workbook = new Workbook();
            workbook.Sheets.Add(SheetType.Worksheet);

            Worksheet worksheet = workbook.ActiveWorksheet;

            this.PrepareInvoiceDocument(worksheet, gridView.RowCount);

            int currentRow = IndexColumnName + 1;
            foreach (var product in gridView.Rows)
            {
                worksheet.Cells[currentRow, IndexColumnName].SetValue(product.Cells[IndexColumnName].Value.ToString());
                worksheet.Cells[currentRow, IndexColumnQuantity].SetValue(product.Cells[IndexColumnQuantity].Value.ToString());
                worksheet.Cells[currentRow, IndexColumnUnitPrice].SetValue(product.Cells[IndexColumnUnitPrice].Value.ToString());
                worksheet.Cells[currentRow, IndexColumnSubTotal].SetValue(product.Cells[IndexColumnSubTotal].Value.ToString());

                currentRow++;
            }

            return workbook;
        }

        private void PrepareInvoiceDocument(Worksheet worksheet, int itemsCount)
        {
            int lastItemIndexRow = IndexColumnName + itemsCount;

            CellIndex firstUsedCellIndex = new CellIndex(0, 0);
            CellIndex lastUsedCellIndex = new CellIndex(lastItemIndexRow + 1, IndexColumnSubTotal);
            CellBorder border = new CellBorder(CellBorderStyle.DashDot, InvoiceBackground);
            worksheet.Cells[firstUsedCellIndex, lastUsedCellIndex].SetBorders(new CellBorders(border, border, border, border, null, null, null, null));

            worksheet.Cells[firstUsedCellIndex].SetValue("INVOICE");
            worksheet.Cells[firstUsedCellIndex].SetFontSize(20);

            worksheet.Columns[0].SetWidth(new ColumnWidth(300, true));
            worksheet.Columns[IndexColumnUnitPrice].SetWidth(new ColumnWidth(120, true));
            worksheet.Columns[IndexColumnSubTotal].SetWidth(new ColumnWidth(120, true));

            worksheet.Cells[IndexColumnName, 0].SetValue("Item");
            worksheet.Cells[IndexColumnName, IndexColumnQuantity].SetValue("QTY");
            worksheet.Cells[IndexColumnName, IndexColumnUnitPrice].SetValue("Unit Price");
            worksheet.Cells[IndexColumnName, IndexColumnSubTotal].SetValue("SubTotal");

            worksheet.Cells[IndexColumnName, 0, IndexColumnName, IndexColumnSubTotal].SetFill
                (new GradientFill(GradientType.Horizontal, InvoiceBackground, InvoiceBackground));
            worksheet.Cells[IndexColumnName, 0, IndexColumnName, IndexColumnSubTotal].SetForeColor(InvoiceHeaderForeground);
            worksheet.Cells[IndexColumnName, IndexColumnUnitPrice, lastItemIndexRow, IndexColumnSubTotal].SetFormat(
                new CellValueFormat(EnUSCultureAccountFormatString));

            worksheet.Cells[lastItemIndexRow + 1, 2].SetValue("TOTAL: ");
            worksheet.Cells[lastItemIndexRow + 1, 3].SetFormat(new CellValueFormat(EnUSCultureAccountFormatString));

            string subTotalColumnCellRange = NameConverter.ConvertCellRangeToName(
                new CellIndex(IndexColumnName + 1, IndexColumnSubTotal),
                new CellIndex(lastItemIndexRow, IndexColumnSubTotal));

            worksheet.Cells[lastItemIndexRow + 1, IndexColumnSubTotal].SetValue(string.Format("=SUM({0})", subTotalColumnCellRange));

            worksheet.Cells[lastItemIndexRow + 1, IndexColumnUnitPrice, lastItemIndexRow + 1, IndexColumnSubTotal].SetFontSize(20);
        }

        public static void SaveDocument(Workbook workbook, string selectedFormat)
        {
            IWorkbookFormatProvider formatProvider = GetFormatProvider(selectedFormat);

            if (formatProvider == null)
            {
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = String.Format("{0} files|*{1}|All files (*.*)|*.*", selectedFormat,
                formatProvider.SupportedExtensions.First());
            dialog.FileName = "SpreadDocumentsGeneration";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = dialog.OpenFile())
                    {
                        formatProvider.Export(workbook, stream);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private static IWorkbookFormatProvider GetFormatProvider(string extension)
        {
            IWorkbookFormatProvider formatProvider;
            switch (extension)
            {
                case "Xls":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("XlsFormatProvider");
                    break;
                case "Xlsx":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider");
                    break;
                case "Csv":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("CsvFormatProvider");
                    (formatProvider as CsvFormatProvider).Settings.HasHeaderRow = true;
                    break;
                case "Txt":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider");
                    break;
                default:
                    formatProvider = null;
                    break;
            }

            return formatProvider;
        }

    }
}
