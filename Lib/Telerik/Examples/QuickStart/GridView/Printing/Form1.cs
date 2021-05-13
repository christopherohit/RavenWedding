using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Collections.Generic;
using System.Drawing;
using System.Data;

namespace Telerik.Examples.WinControls.GridView.Printing
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        class ViewDefinitionInfo
        {
            public List<string> Columns;
            public IGridViewDefinition ViewDefinition;

            public int RowHeight = 30;
            public int HeaderHeight = 30;

        }

        ViewDefinitionInfo tableViewInfo;
        ViewDefinitionInfo htmlViewInfo;
        ViewDefinitionInfo columnGroupViewInfo;
        ViewDefinitionInfo currentViewInfo;

        Font italicFont = new Font("Segoe UI", 9f, FontStyle.Italic);

        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();

            this.radGridView1.EnableFiltering = true;
            this.radGridView1.ShowFilteringRow = false;
            this.radGridView1.ShowHeaderCellButtons = true;
            this.radGridView1.ShowGroupedColumns = true;
            this.radGridView1.AutoExpandGroups = true;
            this.radGridView1.EnableAlternatingRowColor = true;
            this.radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            this.radGridView1.PrintCellFormatting += new PrintCellFormattingEventHandler(radGridView1_PrintCellFormatting);
            this.WireEvents();
        }

        private void InitializeGrid()
        {
            this.radGridView1.Columns["FirstName"].Width = (int)(80F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["LastName"].Width = (int)(80F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["Title"].Width = (int)(120F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["Photo"].Width = 80;
            this.radGridView1.Columns["Photo"].ImageLayout = ImageLayout.Stretch;
            this.radGridView1.Columns["City"].Width = (int)(70F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["Country"].Width = (int)(70F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["Address"].Width = (int)(200F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["Notes"].Width = (int)(260F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["Notes"].WrapText = true;
            this.radGridView1.Columns["BirthDate"].FormatString = "{0:d}";
            this.radGridView1.Columns["BirthDate"].Width = (int)(120F * radGridView1.RootElement.DpiScaleFactor.Height);
            this.radGridView1.Columns["HireDate"].FormatString = "{0:d}";
            ((GridViewTextBoxColumn)this.radGridView1.Columns["Notes"]).Multiline = true;

            tableViewInfo = new ViewDefinitionInfo();
            tableViewInfo.ViewDefinition = (TableViewDefinition)this.radGridView1.ViewDefinition;
            tableViewInfo.Columns = new List<string>() { "FirstName", "LastName", "Title", "Country", "HomePhone", "Address", "Check", "Combo" };

            // column groups view
            ColumnGroupsViewDefinition cgv = new ColumnGroupsViewDefinition();
            columnGroupViewInfo = new ViewDefinitionInfo();
            columnGroupViewInfo.ViewDefinition = cgv;
            columnGroupViewInfo.Columns = new List<string>() { "Photo", "FirstName", "LastName", "Title", "Address", "City", "Country", "HomePhone", "Notes" };
            columnGroupViewInfo.RowHeight = (int)(90F * radGridView1.RootElement.DpiScaleFactor.Height);
            columnGroupViewInfo.HeaderHeight = (int)(80F * radGridView1.RootElement.DpiScaleFactor.Height);

            cgv.ColumnGroups.Add(new GridViewColumnGroup());
            cgv.ColumnGroups.Add(new GridViewColumnGroup("General"));
            cgv.ColumnGroups.Add(new GridViewColumnGroup("Details"));
            cgv.ColumnGroups.Add(new GridViewColumnGroup("Notes"));

            cgv.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow() { MinHeight = 30 });
            cgv.ColumnGroups[1].Rows.Add(new GridViewColumnGroupRow() { MinHeight = 30 });
            cgv.ColumnGroups[1].Rows.Add(new GridViewColumnGroupRow() { MinHeight = 30 });
            cgv.ColumnGroups[2].Rows.Add(new GridViewColumnGroupRow() { MinHeight = 30 });
            cgv.ColumnGroups[2].Rows.Add(new GridViewColumnGroupRow() { MinHeight = 30 });
            
            cgv.ColumnGroups[0].Rows[0].ColumnNames.Add("Photo");
            cgv.ColumnGroups[0].ShowHeader = false;

            cgv.ColumnGroups[1].Rows[0].ColumnNames.Add("Title");
            cgv.ColumnGroups[1].Rows[1].ColumnNames.Add("FirstName");
            cgv.ColumnGroups[1].Rows[1].ColumnNames.Add("LastName");

            cgv.ColumnGroups[2].Rows[0].ColumnNames.Add("City");
            cgv.ColumnGroups[2].Rows[0].ColumnNames.Add("Country");
            cgv.ColumnGroups[2].Rows[0].ColumnNames.Add("HomePhone");
            cgv.ColumnGroups[2].Rows[1].ColumnNames.Add("Address");

            cgv.ColumnGroups[3].Rows.Add(new GridViewColumnGroupRow());
            cgv.ColumnGroups[3].Rows[0].ColumnNames.Add("Notes");
            cgv.ColumnGroups[3].ShowHeader = false;

            // html view
            htmlViewInfo = new ViewDefinitionInfo();
            htmlViewInfo.ViewDefinition = new HtmlViewDefinition();
            htmlViewInfo.Columns = new List<string>() { "Photo", "Title", "FirstName", "LastName", "City", "Country", "Address", "Phone", "BirthDate", "HireDate", "HomePhone" };

            HtmlViewDefinition htmlView = new HtmlViewDefinition();
            htmlView.RowTemplate.Rows.Add(new RowDefinition());
            htmlView.RowTemplate.Rows.Add(new RowDefinition());
            htmlView.RowTemplate.Rows.Add(new RowDefinition());
            htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("Photo", 0, 1, 3));
            htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("FirstName", 0, 1, 1));
            htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("LastName", 0, 2, 1));
            htmlView.RowTemplate.Rows[0].Cells.Add(new CellDefinition("BirthDate", 0, 1, 1));
            htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Title", 0, 3, 1));
            htmlView.RowTemplate.Rows[1].Cells.Add(new CellDefinition("HireDate", 0, 1, 1));
            htmlView.RowTemplate.Rows[2].Cells.Add(new CellDefinition("Address", 0, 1, 1));
            htmlView.RowTemplate.Rows[2].Cells.Add(new CellDefinition("City", 0, 1, 1));
            htmlView.RowTemplate.Rows[2].Cells.Add(new CellDefinition("Country", 0, 1, 1));
            htmlView.RowTemplate.Rows[2].Cells.Add(new CellDefinition("HomePhone", 0, 1, 1));
            htmlView.RowTemplate.Rows[0].Height = 23;
            htmlView.RowTemplate.Rows[1].Height = 23;
            htmlView.RowTemplate.Rows[2].Height = 32;

            htmlViewInfo.RowHeight = (int)(100F * radGridView1.RootElement.DpiScaleFactor.Height);
            htmlViewInfo.HeaderHeight = -1;
            htmlViewInfo.ViewDefinition = htmlView;
        }

        private void InitializePrintDocument()
        {
            this.radPrintDocument1.LeftFooter = "Page [Page #] of [Total Pages]";
            this.radPrintDocument1.LeftHeader = "[Time Printed]";
            this.radPrintDocument1.MiddleFooter = "***";
            this.radPrintDocument1.MiddleHeader = "Company employees info";
            this.radPrintDocument1.RightFooter = "Printed by: [User Name]";
            this.radPrintDocument1.RightHeader = "[Date Printed]";
        }

        private void SetView(ViewDefinitionInfo info)
        {
            currentViewInfo = info;

            this.radGridView1.FilterDescriptors.Clear();

            this.radGridView1.BeginUpdate();

            foreach (GridViewColumn col in this.radGridView1.Columns)
            {
                col.IsVisible = info.Columns.Contains(col.Name);
            }

            GridTraverser traverser = new GridTraverser(this.radGridView1.MasterView);
            while (traverser.MoveNext())
            {
                if (traverser.Current is GridViewDataRowInfo)
                {
                    traverser.Current.Height = info.RowHeight;
                }
            }

            this.radGridView1.MasterView.TableHeaderRow.Height = info.HeaderHeight;

            this.radGridView1.EndUpdate(false);

            this.radGridView1.ViewDefinition = info.ViewDefinition;
            this.radGridView1.PrintStyle.FitWidthMode = PrintFitWidthMode.NoFitCentered;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
            {
                if (this.radRadioButtonHtml.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    htmlViewInfo.RowHeight = (int)(130F * radGridView1.RootElement.DpiScaleFactor.Height);
                    radGridView1.Columns["Photo"].Width += 20;
                    SetView(htmlViewInfo);
                }
            }
        }

        #endregion

        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            this.radGridView1.GroupDescriptors.Add(new Telerik.WinControls.Data.GroupDescriptor("Title Desc"));

            InitializeGrid();
            InitializePrintDocument();

            SetView(columnGroupViewInfo);
        }

        private void radRadioTable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioButtonColumnGroups.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetView(columnGroupViewInfo);
            }
            else if (this.radRadioButtonHtml.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                SetView(htmlViewInfo);
            }
            else
            {
                SetView(tableViewInfo);
            }
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridDataCellElement cell = e.CellElement as GridDataCellElement;
            if (cell != null)
            {
                if (cell.ColumnInfo.Name == "Notes")
                {
                    cell.Font = italicFont;
                    cell.Padding = new Padding(4);
                }
                else
                {
                    cell.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local);
                }
            }
        }

        private void radGridView1_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            if (e.Column != null && e.Column.Name == "Notes" && e.Row is GridViewDataRowInfo)
            {
                e.PrintCell.Font = this.italicFont;
            }
        }

        private void radButtonPrint_Click(object sender, EventArgs e)
        {
            this.radGridView1.Print(true, this.radPrintDocument1);
        }

        private void radButtonPrintPreview_Click(object sender, EventArgs e)
        {
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.ThemeName = this.radGridView1.ThemeName;
            dialog.Document = this.radPrintDocument1;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();
        }

        private void radButtonPrintSettings_Click(object sender, EventArgs e)
        {
            GridViewPrintSettingsDialog dialog = new GridViewPrintSettingsDialog();
            dialog.ThemeName = this.radGridView1.ThemeName;
            dialog.ShowPreviewButton = false;
            dialog.PrintDocument = this.radPrintDocument1;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                radButtonPrintPreview_Click(sender, e);
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.radRadioButtonTable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioTable_ToggleStateChanged);
            this.radRadioButtonHtml.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioTable_ToggleStateChanged);
            this.radRadioButtonColumnGroups.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioTable_ToggleStateChanged);
            this.radButtonPrint.Click += new System.EventHandler(this.radButtonPrint_Click);
            this.radButtonPrintPreview.Click += new System.EventHandler(this.radButtonPrintPreview_Click);
            this.radButtonPrintSettings.Click += new System.EventHandler(this.radButtonPrintSettings_Click);
        }
    }
}
