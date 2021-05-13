using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadGridIntegration
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private const int WidthOfIndentColumns = 20;

        private static readonly Color DefaultHeaderRowColor =  Color.FromArgb(255, 127, 127, 127);
        private static readonly Color DefaultGroupHeaderRowColor =  Color.FromArgb(255, 216, 216, 216);
        private static readonly Color DefaultDataRowColor = Color.FromArgb(255, 251, 247, 255);

        private List<Product> products;
        private Color headerRowColor;
        private Color dataRowColor;
        private Color groupHeaderRowColor;
        private string[] exportFormats;
        private string selectedExportFormat;

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

        public string[] ExportFormats
        {
            get
            {
                if (exportFormats == null)
                {
                    exportFormats = new string[] { "Xlsx", "Xls", "Csv", "Txt" };
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Products = new Products().GetData(100).ToList();

            this.SelectedExportFormat = this.ExportFormats[0];

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
            this.exportFormatDropDownList.SelectedIndex = 0;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Workbook workbook = CreateWorkbook(this.radGridView1);
            FileHelper.SaveDocument(workbook, this.SelectedExportFormat);
        }

        private Workbook CreateWorkbook(RadGridView grid)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();
            workbook.History.IsEnabled = false;

            IList<GridViewColumn> columns = (from c in grid.Columns.OfType<GridViewColumn>()
                                             orderby c.Index// where c.IsVisible
                                             select c).ToList();

            int rowIndex = 0;
            if (grid.ShowColumnHeaders)
            {
                this.AddHeaderRow(worksheet, grid.GroupDescriptors.Count, columns);
                rowIndex = 1;
            }

            if (grid.Groups.Count > 0)
            {
                foreach (DataGroup group in grid.Groups)
                {
                    rowIndex = this.AddGroupRow(worksheet, rowIndex, group.Level, group, columns);
                    rowIndex += this.AddDataRows(worksheet, rowIndex, group.Level+1 , group, columns);
                }
            }
            else
            {
                this.AddDataRows(worksheet, rowIndex, 0, grid.Rows, columns);
            }

            this.SetWidthOfColumns(worksheet, grid.GroupDescriptors.Count, columns);
            return workbook;
        }

        private void SetWidthOfColumns(Worksheet worksheet, int numberOfIndentColumns, IList<GridViewColumn> columns)
        {
            for (int i = 0; i < numberOfIndentColumns; i++)
            {
                worksheet.Columns[i].SetWidth(new ColumnWidth(WidthOfIndentColumns, false));
            }

            for (int i = 0; i < columns.Count; i++)
            {
                worksheet.Columns[numberOfIndentColumns + i].SetWidth(new ColumnWidth(columns[i].Width, false));
            }
        }

        private void AddHeaderRow(Worksheet worksheet, int numberOfGroupDescriptors, IList<GridViewColumn> columns)
        {
            int headerColumnStartIndex = numberOfGroupDescriptors;

            for (int i = 0; i < columns.Count; i++)
            {
                worksheet.Cells[0, headerColumnStartIndex + i].SetValue(columns[i].HeaderText);
            }

            var fill = new PatternFill(PatternType.Solid, ThemableColor.FromArgb(this.headerRowColorBox.Value.A, this.headerRowColorBox.Value.R, this.headerRowColorBox.Value.G, this.headerRowColorBox.Value.B), ThemableColor.FromArgb(0, 255, 255, 255));
            worksheet.Cells[0, 0, 0, numberOfGroupDescriptors + columns.Count - 1].SetFill(fill);
        }

        private int AddDataRows(Worksheet worksheet, int startRowIndex, int startColumnIndex, IEnumerable<Telerik.WinControls.UI.GridViewRowInfo> rows, IList<GridViewColumn> columns)
        {
            int rowIndex = 0;
            int headerColumn = (this.radGridView1.ShowColumnHeaders) ? 1 : 0;
            foreach (var row in rows)
            {
                if (row is GridViewHierarchyRowInfo)
                {
                    AddDataRows(worksheet, startRowIndex, startColumnIndex, (this.radGridView1.Rows[rowIndex] as GridViewHierarchyRowInfo).ChildRows, columns);
                }

                for (int columnIndex = 0; columnIndex < columns.Count; columnIndex++)
                {
                    object value = row.Cells[columnIndex].Value;

                    int currentRowIndex = startRowIndex + rowIndex;
                    int curentColumnIndex = startColumnIndex + columnIndex;
                    worksheet.Cells[currentRowIndex, curentColumnIndex].SetValue(value.ToString());
                }

                ++rowIndex;
            }

            var fill = new PatternFill(PatternType.Solid, ThemableColor.FromArgb(this.dataRowColorBox.Value.A, this.dataRowColorBox.Value.R, this.dataRowColorBox.Value.G, this.dataRowColorBox.Value.B), ThemableColor.FromArgb(0,255,255,255));
            worksheet.Cells[startRowIndex, 0, startRowIndex + rowIndex - headerColumn, startColumnIndex + columns.Count - 1].SetFill(fill);
            return rowIndex;
        }

        private int AddGroupRow(Worksheet worksheet, int rowIndex, int numberOfIndentCells, DataGroup group, IList<GridViewColumn> columns)
        {
            int startColumnIndex = this.GetGroupLevel(group);

            CellSelection groupHeaderRow = worksheet.Cells[rowIndex, startColumnIndex, rowIndex, numberOfIndentCells + columns.Count ];
            groupHeaderRow.Merge();

            IFill fill = new PatternFill(PatternType.Solid, ThemableColor.FromArgb(this.groupHeaderColorBox.Value.A, this.groupHeaderColorBox.Value.R, this.groupHeaderColorBox.Value.G, this.groupHeaderColorBox.Value.B), ThemableColor.FromArgb(0, 255, 255, 255));
            groupHeaderRow.SetFill(fill);

            string cellValue = group.GroupRow.HeaderText;
            groupHeaderRow.SetValue(cellValue);
            groupHeaderRow.SetHorizontalAlignment(Telerik.Windows.Documents.Spreadsheet.Model.RadHorizontalAlignment.Left);

            rowIndex++;
            startColumnIndex++;

            return rowIndex;
        }

        private int GetGroupLevel(DataGroup group)
        {            
            return group.Level;
        }

        private void exportFormatDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.SelectedExportFormat = exportFormatDropDownList.Items[e.Position].Text;
        }
    }
}
