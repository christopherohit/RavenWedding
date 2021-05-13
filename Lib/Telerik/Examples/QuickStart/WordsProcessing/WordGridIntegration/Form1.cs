using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Common.FormatProviders;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.FormatProviders.Txt;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace Telerik.Examples.WinControls.WordsProcessing.WordGridIntegration
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private const int WidthOfIndentColumns = 20;

        private static readonly Color DefaultHeaderRowColor = Color.FromArgb(255, 127, 127, 127);
        private static readonly Color DefaultGroupHeaderRowColor = Color.FromArgb(255, 216, 216, 216);
        private static readonly Color DefaultDataRowColor = Color.FromArgb(255, 251, 247, 255);

        private List<Product> products;
        private Color headerRowColor;
        private Color dataRowColor;
        private Color groupHeaderRowColor;
        private string[] exportFormats;
        private string selectedExportFormat;
        private bool repeatHeaderRowOnEveryPage = true;

        public Form1()
        {
            InitializeComponent();
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
            set
            {
                if (this.products != value)
                {
                    this.products = value;
                }
            }
        }


        public Color HeaderRowColor
        {
            get
            {
                return this.headerRowColor;
            }
            set
            {
                if (this.headerRowColor != value)
                {
                    this.headerRowColor = value;
                }
            }
        }

        public Color DataRowColor
        {
            get
            {
                return this.dataRowColor;
            }
            set
            {
                if (this.dataRowColor != value)
                {
                    this.dataRowColor = value;
                }
            }
        }

        public Color GroupHeaderRowColor
        {
            get
            {
                return this.groupHeaderRowColor;
            }
            set
            {
                if (this.groupHeaderRowColor != value)
                {
                    this.groupHeaderRowColor = value;
                }
            }
        }

        public IEnumerable<string> ExportFormats
        {
            get
            {
                if (exportFormats == null)
                {
                    exportFormats = new string[] { "Docx", "Rtf", "Txt" };
                }

                return exportFormats;
            }
        }

        public string SelectedExportFormat
        {
            get
            {
                return selectedExportFormat;
            }
            set
            {
                if (!object.Equals(selectedExportFormat, value))
                {
                    selectedExportFormat = value;
                }
            }
        }

        public bool RepeatHeaderRowOnEveryPage
        {
            get
            {
                return this.repeatHeaderRowOnEveryPage;
            }
            set
            {
                if (this.repeatHeaderRowOnEveryPage != value)
                {
                    this.repeatHeaderRowOnEveryPage = value;                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Products = new Products().GetData(100).ToList();

            this.SelectedExportFormat = this.ExportFormats.First();

            this.HeaderRowColor = DefaultHeaderRowColor;
            this.DataRowColor = DefaultDataRowColor;
            this.GroupHeaderRowColor = DefaultGroupHeaderRowColor;

            this.radGridView1.DataSource = this.Products;
            this.radGridView1.BestFitColumns();
            this.radGridView1.Columns["UnitPrice"].FormatString = "{0:C}";
            this.radGridView1.Columns["Date"].DataType = typeof(DateTime);
            this.radGridView1.Columns["Date"].FormatString = "{0:d}";
            this.radGridView1.Columns.Remove(this.radGridView1.Columns["SubTotal"]);
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.AutoExpandGroups = true;
            GroupDescriptor descriptor = new GroupDescriptor();
            descriptor.GroupNames.Add("UnitPrice", ListSortDirection.Ascending);
            this.radGridView1.GroupDescriptors.Add(descriptor);


            headerRowColorBox.Value = DefaultHeaderRowColor;
            groupHeaderColorBox.Value = DefaultGroupHeaderRowColor;
            dataRowColorBox.Value = DefaultDataRowColor;
            this.exportFormatDropDownList.DataSource = ExportFormats;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            RadFlowDocument document = this.CreateDocument(radGridView1);
            
            string selectedFromat = this.SelectedExportFormat;
            SaveDocument(document, selectedFromat);
        }
        public static void SaveDocument(RadFlowDocument document, string selectedFromat)
        {
            IFormatProvider<RadFlowDocument> formatProvider = null;
            switch (selectedFromat)
            {
                case "Docx":
                    formatProvider = new DocxFormatProvider();
                    break;
                case "Rtf":
                    formatProvider = new RtfFormatProvider();
                    break;
                case "Txt":
                    formatProvider = new TxtFormatProvider();
                    break;
            }
            if (formatProvider == null)
            {
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = String.Format("{0} files|*{1}|All files (*.*)|*.*",
                selectedFromat,
                formatProvider.SupportedExtensions.First());
            dialog.FilterIndex = 1;
            dialog.FileName = "WordGridIntegration";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = dialog.OpenFile())
                {
                    formatProvider.Export(document, stream);
                }
            }
        }
        private RadFlowDocument CreateDocument(RadGridView grid)
        {
            RadFlowDocument document = new RadFlowDocument();
            Table table = document.Sections.AddSection().Blocks.AddTable();
            document.StyleRepository.AddBuiltInStyle(BuiltInStyleNames.TableGridStyleId);
            table.StyleId = BuiltInStyleNames.TableGridStyleId;

            IList<GridViewColumn> columns = (from c in grid.Columns.OfType<GridViewColumn>()
                                             orderby c.Index// where c.IsVisible
                                             select c).ToList();
            int indentColumns = grid.GroupDescriptors.Count;
            int rowIndex = 0;

            if (grid.ShowColumnHeaders)
            {
                TableRow headerRow = table.Rows.AddTableRow();
                headerRow.RepeatOnEveryPage = this.RepeatHeaderRowOnEveryPage;
                ThemableColor headerBackground = this.ConvertColor(this.headerRowColorBox.Value);

                if (grid.GroupDescriptors.Count > 0)
                {
                    this.AddIndentCell(headerRow, indentColumns, headerBackground);
                }

                for (int i = 0; i < columns.Count; i++)
                {
                    TableCell cell = headerRow.Cells.AddTableCell();
                    cell.Shading.BackgroundColor = headerBackground;
                    cell.PreferredWidth = new TableWidthUnit(columns[i].Width);
                    Run headerRun = cell.Blocks.AddParagraph().Inlines.AddRun(columns[i].Name);
                    headerRun.FontWeight = System.Windows.FontWeights.Bold;
                }
            }

            if (grid.Groups.Count > 0)
            {
                foreach (DataGroup group in grid.Groups)
                {
                    rowIndex = this.AddGroupRow(table, rowIndex, group.Level, group, columns);
                    this.AddDataRows(table, rowIndex, group.Level + 1, group, columns);
                }
            }
            else
            {
                this.AddDataRows(table, rowIndex, 0, grid.Rows, columns);
            }

            document.Sections.First().Blocks.AddParagraph();
            return document;
        }

        private void AddDataRows(Table table, int startRowIndex, int indentColumnsstartColumnIndex, IEnumerable<Telerik.WinControls.UI.GridViewRowInfo> rows, IList<GridViewColumn> columns)
        {
            ThemableColor background = ConvertColor(this.dataRowColorBox.Value);
            foreach (var row in rows)
            {
                TableRow tableRows = table.Rows.AddTableRow();
                if (indentColumnsstartColumnIndex > 0)
                {
                    this.AddIndentCell(tableRows, indentColumnsstartColumnIndex, background);
                }

                for (int columnIndex = 0; columnIndex < columns.Count; columnIndex++)
                {
                    TableCell cell = tableRows.Cells.AddTableCell();
                    this.AddCellValue(cell, row.Cells[columnIndex].Value);
                    cell.Shading.BackgroundColor = background;
                    cell.PreferredWidth = new TableWidthUnit(columns[columnIndex].Width);
                }
            }

            
        }

        private int AddGroupRow(Table table, int rowIndex, int numberOfIndentCells, DataGroup group, IList<GridViewColumn> columns)
        {
            int level = this.GetGroupLevel(group);
            TableRow row = table.Rows.AddTableRow();
            if (level > 0)
            {
                this.AddIndentCell(row, level,  ConvertColor(this.dataRowColorBox.Value));
            }
            TableCell cell = row.Cells.AddTableCell();
            cell.Shading.BackgroundColor = ConvertColor(this.groupHeaderColorBox.Value);
            cell.ColumnSpan = columns.Count + (radGridView1.GroupDescriptors.Count > 0 ? 1 : 0) - (level > 0 ? 1 : 0);
            this.AddCellValue(cell, group.GroupRow.HeaderText);           
            return rowIndex;
        }

        private void AddCellValue(TableCell cell, object value)
        {
            string stringValue = value != null ? value.ToString() : string.Empty;
            cell.Blocks.AddParagraph().Inlines.AddRun(stringValue);
        }

        private void AddIndentCell(TableRow row, int indentColumns, ThemableColor background)
        {
            TableCell indentCell = row.Cells.AddTableCell();
            indentCell.PreferredWidth = new TableWidthUnit(indentColumns * WidthOfIndentColumns);
            indentCell.Shading.BackgroundColor = background;
            indentCell.Blocks.AddParagraph();
        }

        private int GetGroupLevel(DataGroup group)
        {
            return group.Level;
        }

        private ThemableColor ConvertColor(Color color)
        {
            return ThemableColor.FromArgb(color.A,
                                           color.R,
                                           color.G,
                                           color.B);
        }

        private void radCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.RepeatHeaderRowOnEveryPage = this.radCheckBox1.Checked;
        }

        private void exportFormatDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.SelectedExportFormat = exportFormatDropDownList.Items[e.Position].Text;
        }
    }
}
