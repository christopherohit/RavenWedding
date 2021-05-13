using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Documents.SpreadsheetStreaming;

namespace ExportWithDpl.SpreadsheetStreamingExport
{
    public class ExampleViewModel : INotifyPropertyChanged
    {
        private static readonly int ColumnsCount = 8;
        private static readonly int HeaderRowHeight = 22;
        private static readonly int RowHeight = 18;
        private static readonly string[] ColumnHeaders = { "ID", "DATE", "TIME", "CLIENT", "COMPANY", "SHIPPING", "DISCOUNT", "STATUS" };
        private static readonly double[] ColumnWidths = { 9.43, 12.29, 10.71, 15.43, 21.71, 14.29, 13.57, 11.29 };

        
        private int exportedCellsCount;
        private double exportTime;
        private int rowsCount;
        private SpreadDocumentFormat selectedDocumentFormat;
        private int totalCellsCount;
        private DateTime exportStarted;
        private bool canExport;
        private long memory;

        public long Memory
        {
            get { return memory; }
            set
            {
                if (this.memory != value)
                {
                    this.memory = value;
                    this.OnPropertyChanged("Memory");
                }
            }
        }

        public SpreadDocumentFormat SelectedDocumentFormat
        {
            get
            {
                return this.selectedDocumentFormat;
            }
            set
            {
                if (this.selectedDocumentFormat != value)
                {
                    this.selectedDocumentFormat = value;
                    this.OnPropertyChanged("SelectedDocumentFormat");
                }
            }
        }

        public IEnumerable<SpreadDocumentFormat> ExportFormats
        {
            get
            {
                return Enum.GetValues(typeof(SpreadDocumentFormat)).Cast<SpreadDocumentFormat>();
            }
        }

        public int RowsCount
        {
            get
            {
                return this.rowsCount;
            }
            set
            {
                if (this.rowsCount != value)
                {
                    this.rowsCount = value;
                    this.OnPropertyChanged("RowsCount");
                }
            }
        }

        public int ExportedCellsCount
        {
            get
            {
                return this.exportedCellsCount;
            }
            set
            {
                if (this.exportedCellsCount != value)
                {
                    this.exportedCellsCount = value;
                    this.OnPropertyChanged("ExportedCellsCount");
                }
            }
        }

        public int TotalCellsCount
        {
            get
            {
                return this.totalCellsCount;
            }
            set
            {
                if (this.totalCellsCount != value)
                {
                    this.totalCellsCount = value;
                    this.OnPropertyChanged("TotalCellsCount");
                }
            }
        }

        public double ExportTime
        {
            get
            {
                return this.exportTime;
            }
            set
            {
                if (this.exportTime != value)
                {
                    this.exportTime = value;
                    this.OnPropertyChanged("ExportTime");
                }
            }
        }

        public bool CanExport
        {
            get
            {
                return this.canExport;
            }
            set
            {
                if (this.canExport != value)
                {
                    this.canExport = value;
                    this.OnPropertyChanged("CanExport");
                }
            }
        }

        public ExampleViewModel()
        {   
            this.RowsCount = 5000;
            this.CanExport = true;
        }

        public void Export()
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = String.Format("{0} files|*.{1}|All files (*.*)|*.*",
                this.SelectedDocumentFormat.ToString().ToLower(),
                this.SelectedDocumentFormat.ToString().ToLower());
            dialog.FileName = "SpreadStreamProcessing";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.ExportedCellsCount = 0;
                this.TotalCellsCount = (this.RowsCount + 3) * ColumnsCount;
                Stream stream = dialog.OpenFile();
                this.CanExport = false;
                using (stream)
                {
                    this.GenerateDocument(stream, this.RowsCount);
                }

                this.CanExport = true;
            }
        }

        private void GenerateDocument(Stream documentStream, int rowsCount)
        {
            this.ExportedCellsCount = 0;
            this.exportStarted = DateTime.Now;

            using (IWorkbookExporter workbookExporter = SpreadExporter.CreateWorkbookExporter(this.SelectedDocumentFormat, documentStream))
            {
                using (IWorksheetExporter worksheetExporter = workbookExporter.CreateWorksheetExporter("Orders Log"))
                {
                    for (int i = 0; i < ColumnWidths.Length; i++)
                    {
                        using (IColumnExporter columnExporter = worksheetExporter.CreateColumnExporter())
                        {
                            columnExporter.SetWidthInCharacters(ColumnWidths[i]);
                        }
                    }

                    this.ExportHeaderRows(worksheetExporter);

                    for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
                    {
                        using (IRowExporter rowExporter = worksheetExporter.CreateRowExporter())
                        {
                            rowExporter.SetHeightInPoints(RowHeight);

                            DocumentRow row = DocumentHelper.GenerateDocumentRow(rowsCount, rowIndex);

                            SpreadCellFormat normalFormat = new SpreadCellFormat();
                            normalFormat.FontSize = 10;
                            normalFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                            normalFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;

                            this.ExportIdColumn(rowExporter, row, normalFormat);
                            this.ExportDateColumn(rowExporter, row);
                            this.ExportTimeColumn(rowExporter, row);
                            this.ExportClientColumn(rowExporter, row, normalFormat);
                            this.ExportCompanyColumn(rowExporter, row, normalFormat);
                            this.ExportShippingColumn(rowExporter, row);
                            this.ExportDiscountColumn(rowExporter, row);
                            this.ExportStatusColumn(rowExporter, row);


                            if (rowIndex % (this.RowsCount / 100) == 0 || rowIndex == this.RowsCount - 1)
                            {
                                this.ExportTime = (DateTime.Now - this.exportStarted).TotalMilliseconds / 1000;
                                this.ExportedCellsCount = ColumnsCount * (rowIndex + 1);
                                this.Memory = GC.GetTotalMemory(false) / 1024 / 1024;
                                Application.DoEvents();
                            }
                        }
                    }

                    worksheetExporter.MergeCells(0, 0, 0, 7);
                    worksheetExporter.MergeCells(1, 0, 1, 5);
                    worksheetExporter.MergeCells(1, 6, 1, 7);
                }
            }
        }

        private void ExportIdColumn(IRowExporter rowExporter, DocumentRow row, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                cellExporter.SetValue(row.Id);
                cellExporter.SetFormat(normalFormat);
            }
        }

        private void ExportDateColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat dateFormat = new SpreadCellFormat();
                dateFormat.FontSize = 10;
                dateFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                dateFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                dateFormat.NumberFormat = "m/d/yyyy";

                cellExporter.SetValue(row.Date);
                cellExporter.SetFormat(dateFormat);
            }
        }

        private void ExportTimeColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat timeFormat = new SpreadCellFormat();
                timeFormat.FontSize = 10;
                timeFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                timeFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                timeFormat.NumberFormat = "h:mm;@";

                cellExporter.SetValue(row.Time);
                cellExporter.SetFormat(timeFormat);
            }
        }

        private void ExportClientColumn(IRowExporter rowExporter, DocumentRow row, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                cellExporter.SetValue(row.Client);
                cellExporter.SetFormat(normalFormat);
            }
        }

        private void ExportCompanyColumn(IRowExporter rowExporter, DocumentRow row, SpreadCellFormat normalFormat)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                cellExporter.SetValue(row.Company);
                cellExporter.SetFormat(normalFormat);
            }
        }

        private void ExportShippingColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat expressFormat = new SpreadCellFormat();
                expressFormat.FontSize = 10;
                expressFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                expressFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;

                if (row.Shipping == Shipping.Express)
                {
                    expressFormat.IsBold = true;
                    expressFormat.ForeColor = new SpreadThemableColor(new SpreadColor(192, 0, 0));
                }

                string shipping = string.Empty;
                switch (row.Shipping)
                {
                    case Shipping.Express:
                        shipping = "express";
                        break;
                    case Shipping.OneDay:
                        shipping = "1 day";
                        break;
                    case Shipping.TwoDays:
                        shipping = "2 days";
                        break;
                    case Shipping.Regular:
                        shipping = "regular";
                        break;
                }

                cellExporter.SetValue(shipping);
                cellExporter.SetFormat(expressFormat);
            }
        }

        private void ExportDiscountColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadCellFormat percentFormat = new SpreadCellFormat();
                percentFormat.FontSize = 10;
                percentFormat.VerticalAlignment = SpreadVerticalAlignment.Center;
                percentFormat.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                percentFormat.NumberFormat = "0%";

                cellExporter.SetValue(row.Discount);
                cellExporter.SetFormat(percentFormat);
            }
        }

        private void ExportStatusColumn(IRowExporter rowExporter, DocumentRow row)
        {
            using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
            {
                SpreadColor color = null;
                switch (row.Shipping)
                {
                    case Shipping.Express:
                        color = new SpreadColor(242, 116, 33);
                        break;
                    case Shipping.OneDay:
                        color = new SpreadColor(255, 192, 0);
                        break;
                    case Shipping.TwoDays:
                        color = new SpreadColor(142, 188, 0);
                        break;
                    case Shipping.Regular:
                        color = new SpreadColor(27, 157, 222);
                        break;
                }

                SpreadCellFormat statusFormat = new SpreadCellFormat();
                statusFormat.Fill = SpreadPatternFill.CreateSolidFill(color);
                SpreadBorder border = new SpreadBorder(SpreadBorderStyle.Thin, new SpreadThemableColor(new SpreadColor(255, 255, 255)));
                statusFormat.LeftBorder = border;
                statusFormat.TopBorder = border;
                statusFormat.RightBorder = border;
                statusFormat.BottomBorder = border;

                cellExporter.SetFormat(statusFormat);
            }
        }

        private void ExportHeaderRows(IWorksheetExporter worksheetExporter)
        {
            using (IRowExporter rowExporter = worksheetExporter.CreateRowExporter())
            {
                rowExporter.SetHeightInPoints(HeaderRowHeight);

                using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                {
                    SpreadCellFormat format = new SpreadCellFormat();
                    format.FontFamily = new SpreadThemableFontFamily("Segoe UI");
                    format.FontSize = 16;
                    format.Fill = SpreadPatternFill.CreateSolidFill(new SpreadColor(51, 153, 51));
                    format.ForeColor = new SpreadThemableColor(new SpreadColor(255, 255, 255));
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Left;
                    format.VerticalAlignment = SpreadVerticalAlignment.Center;

                    cellExporter.SetFormat(format);
                    cellExporter.SetValue("ORDERS LOG");
                }
            }

            using (IRowExporter rowExporter = worksheetExporter.CreateRowExporter())
            {
                rowExporter.SetHeightInPoints(HeaderRowHeight);

                using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                {
                    SpreadCellFormat format = new SpreadCellFormat();
                    format.FontFamily = new SpreadThemableFontFamily("Segoe UI");
                    format.FontSize = 14;
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Left;
                    format.VerticalAlignment = SpreadVerticalAlignment.Center;

                    cellExporter.SetFormat(format);
                    cellExporter.SetValue("REPORT");
                }

                rowExporter.SkipCells(5);

                using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                {
                    SpreadCellFormat format = new SpreadCellFormat();
                    format.FontFamily = new SpreadThemableFontFamily("Segoe UI");
                    format.FontSize = 14;
                    format.NumberFormat = "[$-409]mmm-yy;@";
                    format.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                    format.VerticalAlignment = SpreadVerticalAlignment.Center;

                    cellExporter.SetFormat(format);
                    cellExporter.SetFormula("=TODAY()");
                }
            }

            using (IRowExporter rowExporter = worksheetExporter.CreateRowExporter())
            {
                rowExporter.SetHeightInPoints(HeaderRowHeight);

                SpreadCellFormat format = new SpreadCellFormat();
                format.IsBold = true;
                format.Fill = SpreadPatternFill.CreateSolidFill(new SpreadColor(142, 196, 65));
                format.ForeColor = new SpreadThemableColor(new SpreadColor(255, 255, 255));
                format.HorizontalAlignment = SpreadHorizontalAlignment.Center;
                format.VerticalAlignment = SpreadVerticalAlignment.Center;

                for (int i = 0; i < ColumnHeaders.Length; i++)
                {
                    using (ICellExporter cellExporter = rowExporter.CreateCellExporter())
                    {
                        cellExporter.SetFormat(format);
                        cellExporter.SetValue(ColumnHeaders[i]);
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
