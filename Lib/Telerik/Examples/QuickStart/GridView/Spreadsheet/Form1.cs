using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Spreadsheet
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        #region Constants

        private const int alphabetLength = 26;
        private const int rowsCount = 1000;
        private const int columnsCount = 1000;
        private const int rowBeginIndex = 2;
        private const int clientColumnIndex = 1;
        private const int feeColumnIndex = clientColumnIndex + 1;
        private const int comissionColumnIndex = feeColumnIndex + 1;
        private const int totalColumnIndex = comissionColumnIndex + 1;

        #endregion

        #region Fields

        private bool updatingCombos = false;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.radRibbonBarButtonGroup2.ShowBorder = false;
            this.radRibbonBarButtonGroup3.ShowBorder = false;
            this.radRibbonBarButtonGroup9.ShowBorder = false;
            this.radRibbonBarButtonGroup13.ShowBorder = false;
            this.radRibbonBarButtonGroup14.ShowBorder = false;
            this.radButtonElementCut.ShowBorder = false;
            this.radButtonElementCopy.ShowBorder = false;
            this.radButtonElementFormat.ShowBorder = false;

            this.SetGridProperties();

            this.gridView.CellFormatting += new CellFormattingEventHandler(gridView_CellFormatting);
            this.gridView.ViewCellFormatting += new CellFormattingEventHandler(gridView_ViewCellFormatting);
            this.gridView.CreateCell += new GridViewCreateCellEventHandler(GridView_CreateCell);

            this.gridView.CurrentCellChanged += new CurrentCellChangedEventHandler(gridView_CurrentCellChanged);
            this.gridView.ValueChanged += new EventHandler(gridView_ValueChanged);

            this.gridView.RowsChanged += new GridViewCollectionChangedEventHandler(gridView_RowsChanged);

            this.SelectedControl = this.gridView;
            this.radDropDownListElementFont.SelectedItem = this.radDropDownListElementFont.Items[0];
            this.radDropDownListElementFontSize.SelectedItem = this.radDropDownListElementFontSize.Items[0];

            this.radButtonElementBold.Click += new EventHandler(radButtonElementBold_Click);
            this.radButtonElementItalic.Click += new EventHandler(radButtonElementItalic_Click);
            this.radButtonElementUnderline.Click += new EventHandler(radButtonElementUnderline_Click);
            this.radButtonElementColor.Click += new EventHandler(radButtonElementColor_Click);
            this.radButtonElementFontColor.Click += new EventHandler(radButtonElementFontColor_Click);


            this.radDropDownListElementFont.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListElementFont_SelectedIndexChanged);
            this.radDropDownListElementFontSize.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListElementFontSize_SelectedIndexChanged);
            this.radButtonElementIncrease.Click += new EventHandler(radButtonElementIncrease_Click);
            this.radButtonElementDecrease.Click += new EventHandler(radButtonElementDecrease_Click);

            this.radTextBoxCellContent.TextChanged += new EventHandler(radTextBoxCellContent_TextChanged);
        }

        #endregion

        #region Event Handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            for (int i = 0; i < this.gridView.Columns.Count; i++)
            {
                GridViewDataColumn dataColumn = this.gridView.Columns[i] as GridViewDataColumn;

                if (dataColumn != null)
                {
                    dataColumn.HeaderText = this.GetColumnName(i);
                    dataColumn.Width = 100;
                }
            }

            this.gridView.TableElement.RowHeight = 26;
            this.gridView.TableElement.TableHeaderHeight = 32;

            this.FillGridWithData();
            this.SetInitialStyles();
        }

        private void gridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            int columnIndex = e.CellElement.ColumnIndex;
            int rowIndex = e.CellElement.RowIndex;
            GridCellElement cell = e.CellElement;
            if (rowIndex == rowBeginIndex - 1)
            {
                if (columnIndex == totalColumnIndex || columnIndex == comissionColumnIndex ||
                    columnIndex == feeColumnIndex || columnIndex == clientColumnIndex)
                {
                    if (cell.IsSelected)
                    {
                        cell.BackColor = Color.FromArgb(162, 207, 223);
                    }
                }
            }
            else if (rowIndex > rowBeginIndex - 1 && rowIndex < rowBeginIndex + 8)
            {
                if (columnIndex == totalColumnIndex || columnIndex == comissionColumnIndex ||
                    columnIndex == feeColumnIndex || columnIndex == clientColumnIndex)
                {
                    if (cell.IsSelected)
                    {
                        cell.BackColor = Color.FromArgb(228, 227, 216);
                    }
                }
            }

            if (IsNumber(e.CellElement.Value))
            {
                e.CellElement.Alignment = ContentAlignment.TopRight;
            }
            else
            {
                e.CellElement.Alignment = ContentAlignment.TopLeft;
            }
        }

        private void gridView_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is SpreadsheetGridRowHeaderCellElement)
            {
                StyleSelectedCell(e.CellElement as SpreadsheetGridRowHeaderCellElement);
            }
            else if (e.CellElement is GridHeaderCellElement)
            {
                StyleSelectedCell(e.CellElement as GridHeaderCellElement);
            }
        }

        private void StyleSelectedCell(SpreadsheetGridRowHeaderCellElement cell)
        {
            bool selected = false;
            bool current = false;
            foreach (GridViewCellInfo selectedCell in this.gridView.SelectedCells)
            {
                if (cell.RowInfo.Index == selectedCell.RowInfo.Index)
                {
                    if (cell.RowInfo == this.gridView.CurrentRow)
                    {
                        current = true;
                    }
                    else
                    {
                        selected = true;
                    }
                    break;
                }
            }
            if (current)
            {
                cell.NumberOfColors = 2;
                cell.BackColor = Color.FromArgb(255, 226, 160);
                cell.BackColor2 = Color.FromArgb(255, 205, 102);
                cell.BorderColor = Color.FromArgb(255, 190, 106);
                cell.BorderInnerColor = Color.FromArgb(255, 245, 162);
            }
            else if (selected)
            {
                cell.NumberOfColors = 1;
                cell.BackColor = Color.FromArgb(255, 231, 174);
                cell.BorderColor = Color.FromArgb(209, 225, 245);
                cell.BorderInnerColor = Color.White;
            }
            else
            {
                cell.NumberOfColors = 4;
                cell.BackColor = Color.FromArgb(231, 240, 252);
                cell.BackColor2 = Color.FromArgb(218, 233, 251);
                cell.BorderColor = Color.FromArgb(209, 225, 245);
                cell.BorderInnerColor = Color.White;
            }
        }

        private void StyleSelectedCell(GridHeaderCellElement cell)
        {
            bool selected = false;
            bool current = false;
            foreach (GridViewCellInfo selectedCell in this.gridView.SelectedCells)
            {
                if (cell.ColumnInfo.Index == selectedCell.ColumnInfo.Index)
                {
                    if (cell.ColumnInfo == this.gridView.CurrentColumn)
                    {
                        current = true;
                    }
                    else
                    {
                        selected = true;
                    }
                    break;
                }
            }
            if (current)
            {
                cell.DrawFill = true;
                cell.NumberOfColors = 2;
                cell.BackColor = Color.FromArgb(255, 226, 160);
                cell.BackColor2 = Color.FromArgb(255, 205, 102);
                cell.BorderColor = Color.FromArgb(255, 190, 106);
                cell.BorderInnerColor = Color.FromArgb(255, 245, 162);
            }
            else if (selected)
            {
                cell.DrawFill = true;
                cell.NumberOfColors = 1;
                cell.BackColor = Color.FromArgb(255, 231, 174);
                cell.BorderColor = Color.FromArgb(209, 225, 245);
                cell.BorderInnerColor = Color.White;
            }
            else
            {
                cell.ResetValue(LightVisualElement.NumberOfColorsProperty, ValueResetFlags.Local);
                cell.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                cell.ResetValue(LightVisualElement.BackColor2Property, ValueResetFlags.Local);
                cell.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                cell.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local);
                cell.ResetValue(LightVisualElement.BorderInnerColorProperty, ValueResetFlags.Local);
            }
        }

        private bool IsNumber(object cellValue)
        {
            if (cellValue == null)
                return false;

            string val = cellValue.ToString();
            if (String.IsNullOrEmpty(val))
                return false;
            foreach (char item in val)
            {
                if (!Char.IsDigit(item) && item != '$' && item != '.' && item != ',')
                {
                    return false;
                }
            }

            return true;
        }

        private void GridView_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.CellType == typeof(GridRowHeaderCellElement) && e.Row is GridDataRowElement)
            {
                e.CellType = typeof(SpreadsheetGridRowHeaderCellElement);
            }
        }


        private void radButtonElementBold_Click(object sender, EventArgs e)
        {
            foreach (GridViewCellInfo cell in gridView.SelectedCells)
            {
                GridViewCellStyle style = cell.Style;
                if (style != null)
                {
                    if (style.Font != null)
                    {
                        if (!style.Font.Bold)
                            style.Font = GetFont(FontStyle.Bold);
                        else
                            style.Font = GetFont(FontStyle.Regular);
                    }
                    else
                        style.Font = GetFont(FontStyle.Bold);
                }
            }
        }

        private void radButtonElementItalic_Click(object sender, EventArgs e)
        {
            foreach (GridViewCellInfo cell in gridView.SelectedCells)
            {
                GridViewCellStyle style = cell.Style;
                if (style != null)
                {
                    if (style.Font != null)
                    {
                        if (!style.Font.Italic)
                            style.Font = GetFont(FontStyle.Italic);
                        else
                            style.Font = GetFont(FontStyle.Regular);
                    }
                    else
                        style.Font = GetFont(FontStyle.Italic);
                }
            }
        }

        private void radButtonElementUnderline_Click(object sender, EventArgs e)
        {
            foreach (GridViewCellInfo cell in gridView.SelectedCells)
            {
                GridViewCellStyle style = cell.Style;
                if (style != null)
                {
                    if (style.Font != null)
                    {
                        if (!style.Font.Underline)
                            style.Font = GetFont(FontStyle.Underline);
                        else
                            style.Font = GetFont(FontStyle.Regular);
                    }
                    else
                        style.Font = GetFont(FontStyle.Underline);
                }
            }
        }

        private void radButtonElementColor_Click(object sender, EventArgs e)
        {
            RadColorDialog radColorDialog = new RadColorDialog();
            ((RadForm)radColorDialog.ColorDialogForm).ThemeName = this.CurrentThemeName;

            if (radColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = radColorDialog.SelectedColor;

                foreach (GridViewCellInfo cell in gridView.SelectedCells)
                {
                    GridViewCellStyle style = cell.Style;
                    if (style != null)
                    {
                        style.CustomizeFill = true;
                        style.GradientStyle = GradientStyles.Solid;
                        style.BackColor = color;
                    }
                }
            }
        }

        private void radButtonElementFontColor_Click(object sender, EventArgs e)
        {
            RadColorDialog radColorDialog = new RadColorDialog();
            ((RadForm)radColorDialog.ColorDialogForm).ThemeName = this.CurrentThemeName;

            if (radColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = radColorDialog.SelectedColor;

                foreach (GridViewCellInfo cell in gridView.SelectedCells)
                {
                    GridViewCellStyle style = cell.Style;
                    if (style != null)
                    {
                        style.ForeColor = color;
                    }
                }
            }
        }


        private void radDropDownListElementFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingCombos)
                return;

            foreach (GridViewCellInfo cell in gridView.SelectedCells)
            {
                GridViewCellStyle style = cell.Style;
                if (style != null)
                {
                    SetStyle(style);
                }
            }
        }

        private void radDropDownListElementFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingCombos)
                return;

            foreach (GridViewCellInfo cell in gridView.SelectedCells)
            {
                GridViewCellStyle style = cell.Style;
                if (style != null)
                {
                    SetStyle(style);
                }
            }
        }

        private void radButtonElementIncrease_Click(object sender, EventArgs e)
        {
            if (radDropDownListElementFontSize.SelectedItem == null)
                return;

            if (radDropDownListElementFontSize.SelectedIndex < radDropDownListElementFontSize.Items.Count - 1)
            {
                radDropDownListElementFontSize.SelectedIndex++;
                radDropDownListElementFontSize_SelectedIndexChanged(null, null);
            }
        }

        private void radButtonElementDecrease_Click(object sender, EventArgs e)
        {
            if (radDropDownListElementFontSize.SelectedItem == null)
                return;

            if (radDropDownListElementFontSize.SelectedIndex > 0)
            {
                radDropDownListElementFontSize.SelectedIndex--;
                radDropDownListElementFontSize_SelectedIndexChanged(null, null);
            }
        }


        private void gridView_CurrentCellChanged(object sender, CurrentCellChangedEventArgs e)
        {
            if (e.NewCell != null)
            {
                string columnName = e.NewCell.ColumnInfo.HeaderText;
                string rowNumber = (e.NewCell.RowInfo.Index + 1).ToString();
                this.radTextBoxCellNumber.Text = columnName + rowNumber;

                if (e.NewCell.Value != null)
                    this.radTextBoxCellContent.Text = e.NewCell.Value.ToString();
                else
                    this.radTextBoxCellContent.Text = String.Empty;

                GridViewCellStyle style = e.NewCell.Style;
                if (style != null)
                    UpdateCombos(style);
            }
        }

        private void gridView_ValueChanged(object sender, EventArgs e)
        {
            RadTextBoxEditor editor = sender as RadTextBoxEditor;
            if (editor != null)
            {
                if (editor.Value != null)
                    this.radTextBoxCellContent.Text = editor.Value.ToString();
                else
                    this.radTextBoxCellContent.Text = String.Empty;
            }
        }

        private void gridView_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            this.gridView.MasterTemplate.Refresh(this.gridView.Columns[0]);
        }

        private void radTextBoxCellContent_TextChanged(object sender, EventArgs e)
        {
            GridDataCellElement cell = gridView.CurrentCell;
            if (cell != null)
            {
                cell.Value = this.radTextBoxCellContent.Text;
            }
        }

        #endregion

        #region Methods

        private void SetGridProperties()
        {
            this.gridView.TableElement.RowHeaderColumnWidth = 42;

            this.gridView.TableElement.CurrentRowHeaderImage = null;
            this.gridView.AllowAddNewRow = false;
            this.gridView.EnableGrouping = false;
            this.gridView.EnableSorting = false;
            this.gridView.EnableFiltering = false;

            this.gridView.ShowRowHeaderColumn = true;
            this.gridView.EnableHotTracking = false;

            this.gridView.RowCount = rowsCount;
            this.gridView.ColumnCount = columnsCount;

            this.gridView.SelectionMode = GridViewSelectionMode.CellSelect;
            this.gridView.MultiSelect = true;

            this.gridView.CurrentRow = this.gridView.Rows[0];
        }

        private void FillGridWithData()
        {
            this.InitializeHeaderRow(this.gridView.Rows[rowBeginIndex - 1]);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex], "John", 500, 50);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex + 1], "Jim", 550, 55);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex + 2], "Paul", 750, 75);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex + 3], "Michael", 2500, 125);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex + 4], "Tony", 1500, 82);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex + 5], "Peter", 200, 15);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex + 6], "Robert", 110, 5);
            this.InitializeRow(this.gridView.Rows[rowBeginIndex + 7], "Bill", 710, 35);
        }

        private void SetStyle(GridViewCellStyle style)
        {
            if (style.Font != null)
            {
                if (style.Font.Bold)
                    style.Font = GetFont(FontStyle.Bold);
                else if (style.Font.Italic)
                    style.Font = GetFont(FontStyle.Italic);
                else if (style.Font.Underline)
                    style.Font = GetFont(FontStyle.Underline);
                else
                    style.Font = GetFont(FontStyle.Regular);
            }
            else
                style.Font = GetFont(FontStyle.Regular);
        }

        private Font GetFont(FontStyle fontStyle)
        {
            int fontSize = 8;
            string fontFamily = this.BaseFont.FontFamily.Name;

            if (radDropDownListElementFontSize.SelectedItem != null)
            {
                fontSize = Convert.ToInt16((radDropDownListElementFontSize.SelectedItem as RadListDataItem).Text);
            }
            if (radDropDownListElementFont.SelectedItem != null)
            {
                fontFamily = this.radDropDownListElementFont.SelectedText;
            }

            Font font = new Font(fontFamily, fontSize, fontStyle);
            return font;
        }

        private void UpdateCombos(GridViewCellStyle style)
        {
            if (style.Font == null)
                return;

            updatingCombos = true;
            string fontFamilyName = "Calibri";

            if (style.Font.FontFamily != null)
            { }
            fontFamilyName = style.Font.FontFamily.Name;
            foreach (RadListDataItem item in radDropDownListElementFont.Items)
            {
                if (item.Text == fontFamilyName)
                {
                    radDropDownListElementFont.SelectedItem = item;
                    break;
                }
            }

            float fontSize = style.Font.Size;
            foreach (RadListDataItem item in radDropDownListElementFontSize.Items)
            {
                if (float.Parse(item.Text) == fontSize)
                {
                    radDropDownListElementFontSize.SelectedItem = item;
                    break;
                }
            }

            updatingCombos = false;
        }


        private void SetInitialStyles()
        {
            GridViewRowInfo headerRow = gridView.Rows[rowBeginIndex - 1];
            StyleHeaderCell(headerRow.Cells[gridView.Columns[totalColumnIndex].Name]);
            StyleHeaderCell(headerRow.Cells[gridView.Columns[comissionColumnIndex].Name]);
            StyleHeaderCell(headerRow.Cells[gridView.Columns[feeColumnIndex].Name]);
            StyleHeaderCell(headerRow.Cells[gridView.Columns[clientColumnIndex].Name]);

            for (int i = rowBeginIndex; i < rowBeginIndex + 8; i++)
            {
                GridViewRowInfo row = gridView.Rows[i];
                StyleCell(row.Cells[gridView.Columns[totalColumnIndex].Name]);
                StyleCell(row.Cells[gridView.Columns[comissionColumnIndex].Name]);
                StyleCell(row.Cells[gridView.Columns[feeColumnIndex].Name]);
                StyleCell(row.Cells[gridView.Columns[clientColumnIndex].Name]);
            }
        }

        private Font font = null;

        private Font BaseFont
        {
            get
            {
                if (this.font != null)
                {
                    return this.font;
                }

                try
                {
                    this.font = new Font(new FontFamily("Calibri"), 8.0F, FontStyle.Bold);
                }
                catch (System.ArgumentException)
                {
                    this.font = Control.DefaultFont;
                }

                return this.font;
            }
            set
            {
                this.font = value;
            }
        }

        private void StyleHeaderCell(GridViewCellInfo cell)
        {
            cell.Style.Font = this.BaseFont;
            cell.Style.CustomizeFill = true;
            cell.Style.GradientStyle = GradientStyles.Solid;
            cell.Style.BackColor = Color.FromArgb(162, 215, 255);
        }

        private void StyleCell(GridViewCellInfo cell)
        {
            cell.Style.Font = this.BaseFont;
            cell.Style.CustomizeFill = true;
            cell.Style.GradientStyle = GradientStyles.Solid;
            cell.Style.BackColor = Color.FromArgb(228, 236, 247);
        }


        private void InitializeHeaderRow(GridViewRowInfo row)
        {
            row.Cells[clientColumnIndex].Value = "Client";
            row.Cells[feeColumnIndex].Value = "Fee";
            row.Cells[comissionColumnIndex].Value = "Comission";
            row.Cells[totalColumnIndex].Value = "Total";
        }

        private void InitializeRow(GridViewRowInfo row, string client, decimal fee, decimal comission)
        {
            row.Cells[clientColumnIndex].Value = client;
            row.Cells[feeColumnIndex].Value = String.Format("{0:C}", fee);
            row.Cells[comissionColumnIndex].Value = String.Format("{0:C}", comission);
            row.Cells[totalColumnIndex].Value = String.Format("{0:C}", fee + comission);
        }

        private String GetColumnName(int columnIndex)
        {
            StringBuilder result = new StringBuilder();
            int cycle = columnIndex + 1;

            while (cycle > 0)
            {
                int letterIndex = cycle % alphabetLength;
                if (letterIndex == 0)
                {
                    letterIndex = alphabetLength;
                    cycle--;
                }
                result.Insert(0, (char)('A' + letterIndex - 1));
                cycle /= alphabetLength;
            }
            return result.ToString();
        }

        #endregion

        protected override void WireEvents()
        {
        }
    }
}
