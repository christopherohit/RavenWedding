using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ExportWithDpl.GridView
{
    public partial class Form1 : RadForm
    {
        private GridViewSpreadExport spreadExporter;
        private GridViewPdfExport pdfExporter;
                
        public Form1()
        {
            InitializeComponent();
            this.WireEvents();

            if (Program.themeName != "") //set the example theme to the same theme QSF uses
            {
                this.ThemeName = Program.themeName;
            }
            else
            {
                this.ThemeName = "TelerikMetro"; //set default theme
            }

            ApplyThemeRecursively(this.Controls);
        }

        void ApplyThemeRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                RadControl radControl = control as RadControl;
                if (radControl != null )
                {                    
                    radControl.ThemeName = this.ThemeName;                    
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            this.order_DetailsTableAdapter.Fill(this.nwindDataSet.Order_Details);

            this.SetupExample();

            this.spreadExporter = new GridViewSpreadExport(this.radGridView1);
            this.spreadExporter.CellFormatting += spreadExporter_CellFormatting;

            this.pdfExporter = new GridViewPdfExport(this.radGridView1);
            this.pdfExporter.CellFormatting += pdfExporter_CellFormatting;

            this.SetupInitialSettings();
        }

        private void SetupInitialSettings()
        {
            this.exportVisualSettingsCheckBox.ToggleState = ToggleState.On;
            this.exportHierarchyCheckBox.ToggleState = ToggleState.On;
            this.xlsxRadioButton.ToggleState = ToggleState.On;
            this.hiddenColumnDoNotExportRadioButton.ToggleState = ToggleState.On;
            this.hiddenRowDoNotExportRadioButton.ToggleState = ToggleState.On;
            this.summariesExportAllRadioButton.ToggleState = ToggleState.On;
            this.pagingCurrentPageOnlyRadioButton.ToggleState = ToggleState.On;
            this.hideColumnsCheckBox.ToggleState = ToggleState.On;

            this.radCheckBoxExportVisualSettingsPdfExport.ToggleState = ToggleState.On;
            this.radCheckBoxExportHierarchyPdfExport.ToggleState = ToggleState.On;
            this.radRadioButtonHiddenColumnDoNotExportPdfExport.ToggleState = ToggleState.On;
            this.radRadioButtonHiddenRowDoNotExportPdfExport.ToggleState = ToggleState.On;
            this.radRadioButtonSummariesExportAllPdfExport.ToggleState = ToggleState.On;
            this.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.ToggleState = ToggleState.On;
            this.radCheckBoxHideSomeColumnsPdfExport.ToggleState = ToggleState.On;
        }

        private void SetupExample()
        {
            this.radGridView1.DataMember = "Customers";
            this.radGridView1.AutoGenerateHierarchy = true;
            this.radGridView1.DataSource = nwindDataSet;
            this.SetupMasterForAutoGenerateHierarchy();

            this.radGridView1.GroupDescriptors.Add(new GroupDescriptor(new SortDescriptor("City", ListSortDirection.Ascending)));
            this.radGridView1.Groups[0].Expand();

            this.radGridView1.Groups[0].GetItems()[0].IsExpanded = true;
            this.radGridView1.Groups[0].GetItems()[0].ChildRows[0].IsExpanded = true;
        }

        private void SetupMasterForAutoGenerateHierarchy()
        {
            this.radGridView1.MasterTemplate.Columns["CompanyName"].HeaderText = "Company Name";
            this.radGridView1.MasterTemplate.Columns["ContactName"].HeaderText = "Contact Name";

            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            GridViewTemplate template = this.radGridView1.MasterTemplate.Templates[0];
            template.Columns["OrderID"].HeaderText = "Order ID";
            template.Columns["ShipAddress"].HeaderText = "Ship Address";
            template.Columns["OrderDate"].HeaderText = "Order Date";
            template.Columns["OrderDate"].TextAlignment = ContentAlignment.MiddleRight;
            template.Columns["OrderDate"].FormatString = "{0: ddd, MM/dd}";
            template.Columns["OrderDate"].ExcelExportFormatString = "ddd, MM/dd";
            template.Columns["OrderDate"].ExcelExportType = DisplayFormatType.Custom;
            template.Columns["CustomerID"].IsVisible = false;
            template.Columns["EmployeeID"].IsVisible = false;
            template.Columns["RequiredDate"].IsVisible = false;
            template.Columns["ShippedDate"].IsVisible = false;
            template.Columns["ShipVia"].IsVisible = false;
            template.Columns["ShipName"].IsVisible = false;
            template.Columns["ShipCity"].IsVisible = false;
            template.Columns["ShipRegion"].IsVisible = false;
            template.Columns["ShipPostalCode"].IsVisible = false;
            template.Columns["ShipCity"].IsVisible = false;
            template.Columns["ShipName"].IsVisible = false;
            template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.MasterTemplate.Templates[0].Templates.RemoveAt(0);
        }

        private void WireEvents()
        {
            this.Load += Form1_Load;

            // Spread Export
            this.hideColumnsCheckBox.ToggleStateChanged += hideColumnsCheckBox_ToggleStateChanged;
            this.hideFirstRowCheckBox.ToggleStateChanged += hideFirstRowCheckBox_ToggleStateChanged;
            this.showSummaryCheckBox.ToggleStateChanged += showSummaryCheckBox_ToggleStateChanged;
            this.enablePagingCheckBox.ToggleStateChanged += enablePagingCheckBox_ToggleStateChanged;
            this.createHtmlViewDefinitionCheckBox.ToggleStateChanged += createHtmlViewDefinitionCheckBox_ToggleStateChanged;
            this.spreadExportButton.Click += spreadExportButton_Click;
            this.exportVisualSettingsCheckBox.ToggleStateChanged += exportVisualSettingsCheckBox_ToggleStateChanged;
            this.exportHierarchyCheckBox.ToggleStateChanged += exportHierarchyCheckBox_ToggleStateChanged;
            this.exportChildRowsGroupedCheckBox.ToggleStateChanged += exportChildRowsGroupedCheckBox_ToggleStateChanged;
            this.hiddenColumnExportAlwaysRadioButton.ToggleStateChanged += hiddenColumnRadioButton_ToggleStateChanged;
            this.hiddenColumnDoNotExportRadioButton.ToggleStateChanged += hiddenColumnRadioButton_ToggleStateChanged;
            this.hiddenColumnExportAsHiddenRadioButton.ToggleStateChanged += hiddenColumnRadioButton_ToggleStateChanged;
            this.hiddenRowExportAlwaysRadioButton.ToggleStateChanged += hiddenRowRadioButton_ToggleStateChanged;
            this.hiddenRowDoNotExportRadioButton.ToggleStateChanged += hiddenRowRadioButton_ToggleStateChanged;
            this.hiddenRowExportAsHiddenRadioButton.ToggleStateChanged += hiddenRowRadioButton_ToggleStateChanged;
            this.summariesExportAllRadioButton.ToggleStateChanged += summariesRadioButton_ToggleStateChanged;
            this.summariesExportOnlyTopRadioButton.ToggleStateChanged += summariesRadioButton_ToggleStateChanged;
            this.summariesExportOnlyBottomRadioButton.ToggleStateChanged += summariesRadioButton_ToggleStateChanged;
            this.summariesDoNotExportRadioButton.ToggleStateChanged += summariesRadioButton_ToggleStateChanged;
            this.pagingCurrentPageOnlyRadioButton.ToggleStateChanged += pagingRadioButton_ToggleStateChanged;
            this.pagingAllPagesRadioButton.ToggleStateChanged += pagingRadioButton_ToggleStateChanged;
            this.pinSomeRowsAndColumnsCheckBox.ToggleStateChanged += pinSomeRowsAndColumnsCheckBox_ToggleStateChanged;
            this.freezeHeaderRowCheckBox.ToggleStateChanged += freezeHeaderRowCheckBox_ToggleStateChanged;
            this.freezePinnedRowsCheckBox.ToggleStateChanged += freezePinnedRowsCheckBox_ToggleStateChanged;
            this.freezePinnedColumnsCheckBox.ToggleStateChanged += freezePinnedColumnsCheckBox_ToggleStateChanged;
            this.exportViewDefinitionCheckBox.ToggleStateChanged += exportViewDefinitionCheckBox_ToggleStateChanged;

            // PDF Export
            this.radCheckBoxHideSomeColumnsPdfExport.ToggleStateChanged += hideColumnsCheckBox_ToggleStateChanged;
            this.radCheckBoxHideFirstRowPdfExport.ToggleStateChanged += hideFirstRowCheckBox_ToggleStateChanged;
            this.radCheckBoxShowSummaryPdfExport.ToggleStateChanged += showSummaryCheckBox_ToggleStateChanged;
            this.radCheckBoxEnablePagingPdfExport.ToggleStateChanged += enablePagingCheckBox_ToggleStateChanged;
            this.radCheckBoxCreateViewDefinitionPdfExport.ToggleStateChanged += createHtmlViewDefinitionCheckBox_ToggleStateChanged;
            this.radButtonPdfExport.Click += radButtonPdfExport_Click;
            this.radCheckBoxExportVisualSettingsPdfExport.ToggleStateChanged += radCheckBoxExportVisualSettingsPdfExport_ToggleStateChanged;
            this.radCheckBoxExportHierarchyPdfExport.ToggleStateChanged += radCheckBoxExportHierarchyPdfExport_ToggleStateChanged;
            this.radRadioButtonHiddenColumnExportAlwaysPdfExport.ToggleStateChanged += radRadioButtonHiddenColumnPdfExport_ToggleStateChanged;
            this.radRadioButtonHiddenColumnDoNotExportPdfExport.ToggleStateChanged += radRadioButtonHiddenColumnPdfExport_ToggleStateChanged;
            this.radRadioButtonHiddenColumnExportAsHiddenPdfExport.ToggleStateChanged += radRadioButtonHiddenColumnPdfExport_ToggleStateChanged;
            this.radRadioButtonHiddenRowExportAlwaysPdfExport.ToggleStateChanged += radRadioButtonHiddenRowPdfExport_ToggleStateChanged;
            this.radRadioButtonHiddenRowDoNotExportPdfExport.ToggleStateChanged += radRadioButtonHiddenRowPdfExport_ToggleStateChanged;
            this.radRadioButtonHiddenRowExportAsHiddenPdfExport.ToggleStateChanged += radRadioButtonHiddenRowPdfExport_ToggleStateChanged;
            this.radRadioButtonSummariesExportAllPdfExport.ToggleStateChanged += radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged;
            this.radRadioButtonSummariesExportOnlyTopPdfExport.ToggleStateChanged += radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged;
            this.radRadioButtonSummariesExportOnlyBottomPdfExport.ToggleStateChanged += radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged;
            this.radRadioButtonSummariesDoNotExportPdfExport.ToggleStateChanged += radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged;
            this.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.ToggleStateChanged += radRadioButtonPagingOptionPdfExport_ToggleStateChanged;
            this.radRadioButtonPagingOptionAllPAgesPdfExport.ToggleStateChanged += radRadioButtonPagingOptionPdfExport_ToggleStateChanged;
            this.radCheckBoxExportViewDefinitionPdfExport.ToggleStateChanged += radCheckBoxExportViewDefinitionPdfExport_ToggleStateChanged;
        }

        #region Event handlers

        private void hideColumnsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.MasterTemplate.Columns["CustomerID"].IsVisible = args.ToggleState == ToggleState.Off;
            this.radGridView1.MasterTemplate.Columns["ContactTitle"].IsVisible = args.ToggleState == ToggleState.Off;
            this.radGridView1.MasterTemplate.Columns["Region"].IsVisible = args.ToggleState == ToggleState.Off;
            this.radGridView1.MasterTemplate.Columns["PostalCode"].IsVisible = args.ToggleState == ToggleState.Off;
            this.radGridView1.MasterTemplate.Columns["Country"].IsVisible = args.ToggleState == ToggleState.Off;
            this.radGridView1.MasterTemplate.Columns["Fax"].IsVisible = args.ToggleState == ToggleState.Off;

            if (this.hideColumnsCheckBox.ToggleState != args.ToggleState)
            {
                this.hideColumnsCheckBox.ToggleState = args.ToggleState;
            }

            if (this.radCheckBoxHideSomeColumnsPdfExport.ToggleState != args.ToggleState)
            {
                this.radCheckBoxHideSomeColumnsPdfExport.ToggleState = args.ToggleState;
            }
        }

        private void hideFirstRowCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.ChildRows[0].IsVisible = args.ToggleState == ToggleState.Off;
            if (this.hideFirstRowCheckBox.ToggleState != args.ToggleState)
            {
                this.hideFirstRowCheckBox.ToggleState = args.ToggleState;
            }

            if (this.radCheckBoxHideFirstRowPdfExport.ToggleState != args.ToggleState)
            {
                this.radCheckBoxHideFirstRowPdfExport.ToggleState = args.ToggleState;
            }
        }

        private void showSummaryCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                GridViewSummaryItem summaryItem = new GridViewSummaryItem();
                summaryItem.Name = "CompanyName";
                summaryItem.Aggregate = GridAggregateFunction.Count;

                GridViewSummaryRowItem summaryRowTopItem = new GridViewSummaryRowItem();
                summaryRowTopItem.Add(summaryItem);
                this.radGridView1.SummaryRowsTop.Add(summaryRowTopItem);

                GridViewSummaryRowItem summaryRowBottomItem = new GridViewSummaryRowItem();
                summaryRowBottomItem.Add(summaryItem);
                this.radGridView1.SummaryRowsBottom.Add(summaryRowBottomItem);
            }
            else
            {
                this.radGridView1.SummaryRowsBottom.Clear();
                this.radGridView1.SummaryRowsTop.Clear();
            }

            if (this.showSummaryCheckBox.ToggleState != args.ToggleState)
            {
                this.showSummaryCheckBox.ToggleStateChanged -= showSummaryCheckBox_ToggleStateChanged;
                this.showSummaryCheckBox.ToggleState = args.ToggleState;
                this.showSummaryCheckBox.ToggleStateChanged += showSummaryCheckBox_ToggleStateChanged;
            }

            if (this.radCheckBoxShowSummaryPdfExport.ToggleState != args.ToggleState)
            {
                this.radCheckBoxShowSummaryPdfExport.ToggleStateChanged -= showSummaryCheckBox_ToggleStateChanged;
                this.radCheckBoxShowSummaryPdfExport.ToggleState = args.ToggleState;
                this.radCheckBoxShowSummaryPdfExport.ToggleStateChanged += showSummaryCheckBox_ToggleStateChanged;
            }
        }

        private void enablePagingCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radGridView1.EnablePaging = args.ToggleState == ToggleState.On;
            if (this.enablePagingCheckBox.ToggleState != args.ToggleState)
            {
                this.enablePagingCheckBox.ToggleState = args.ToggleState;
            }

            if (this.radCheckBoxEnablePagingPdfExport.ToggleState != args.ToggleState)
            {
                this.radCheckBoxEnablePagingPdfExport.ToggleState = args.ToggleState;
            }
        }

        private void createHtmlViewDefinitionCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                HtmlViewDefinition view = new HtmlViewDefinition();
                view.RowTemplate.Rows.Add(new RowDefinition());
                view.RowTemplate.Rows.Add(new RowDefinition());
                view.RowTemplate.Rows.Add(new RowDefinition());
                view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("PostalCode", 0, 1, 1));
                view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("CompanyName", 0, 1, 3));
                view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("ContactTitle", 0, 1, 1));
                view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("Address", 0, 1, 1));
                view.RowTemplate.Rows[0].Cells.Add(new CellDefinition("CustomerID", 0, 1, 1));
                view.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Country", 0, 1, 2));
                view.RowTemplate.Rows[1].Cells.Add(new CellDefinition("City", 0, 2, 1));
                view.RowTemplate.Rows[1].Cells.Add(new CellDefinition("Phone", 0, 1, 1));
                view.RowTemplate.Rows[2].Cells.Add(new CellDefinition("Fax", 0, 2, 1));
                view.RowTemplate.Rows[2].Cells.Add(new CellDefinition("ContactName", 0, 1, 1));
                this.radGridView1.ViewDefinition = view;

                this.radGridView1.GroupDescriptors.Clear();
                this.exportViewDefinitionCheckBox.ToggleState = ToggleState.On;
                this.radCheckBoxExportViewDefinitionPdfExport.ToggleState = ToggleState.On;
                this.exportHierarchyCheckBox.ToggleState = ToggleState.Off;
                this.radCheckBoxExportHierarchyPdfExport.ToggleState = ToggleState.Off;
                this.hideColumnsCheckBox.ToggleState = ToggleState.Off;
                this.radCheckBoxHideSomeColumnsPdfExport.ToggleState = ToggleState.Off;
            }
            else
            {
                this.radGridView1.ViewDefinition = new TableViewDefinition();
                this.exportViewDefinitionCheckBox.ToggleState = ToggleState.Off;
                this.radCheckBoxExportViewDefinitionPdfExport.ToggleState = ToggleState.Off;
            }
        }

        #region SpreadExport

        private void spreadExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "exportedFile";
            if (xlsxRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Xlsx;
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            }
            else if (csvRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Csv;
                dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            }
            else if (pdfRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Pdf;
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            }
            else if (txtRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Txt;
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SpreadExportRenderer renderer = new SpreadExportRenderer();
                renderer.WorkbookCreated += renderer_WorkbookCreated;
                this.spreadExporter.RunExport(dialog.FileName, renderer);
            }
        }

        private void renderer_WorkbookCreated(object sender, WorkbookCreatedEventArgs e)
        {
            Worksheet worksheet = e.Workbook.ActiveWorksheet;
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
        }

        private void spreadExporter_CellFormatting(object sender, Telerik.WinControls.Export.CellFormattingEventArgs e)
        {
            if (this.customizeVisualSettingsCheckBox.ToggleState != ToggleState.On)
            {
                return;
            }

            if (e.GridRowInfoType == typeof(GridViewTableHeaderRowInfo))
            {
                e.CellStyleInfo.Underline = true;

                if (e.GridCellInfo.RowInfo.HierarchyLevel == 0)
                {
                    e.CellStyleInfo.BackColor = Color.DeepSkyBlue;
                }
                else if (e.GridCellInfo.RowInfo.HierarchyLevel == 1)
                {
                    e.CellStyleInfo.BackColor = Color.LightSkyBlue;
                }
            }

            if (e.GridRowInfoType == typeof(GridViewHierarchyRowInfo))
            {
                if (e.GridCellInfo.RowInfo.HierarchyLevel == 0)
                {
                    e.CellStyleInfo.IsItalic = true;
                    e.CellStyleInfo.FontSize = 12;
                    e.CellStyleInfo.BackColor = Color.GreenYellow;
                }
                else if (e.GridCellInfo.RowInfo.HierarchyLevel == 1)
                {
                    e.CellStyleInfo.ForeColor = Color.DarkGreen;
                    e.CellStyleInfo.BackColor = Color.LightGreen;
                }
            }
        }

        private void exportVisualSettingsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.ExportVisualSettings = args.ToggleState == ToggleState.On;
        }

        private void exportHierarchyCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.ExportHierarchy = args.ToggleState == ToggleState.On;
        }

        private void exportChildRowsGroupedCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.ExportChildRowsGrouped = args.ToggleState == ToggleState.On;
        }

        private void hiddenColumnRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.hiddenColumnExportAlwaysRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.HiddenColumnOption = HiddenOption.ExportAlways;
            }
            else if (this.hiddenColumnDoNotExportRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.HiddenColumnOption = HiddenOption.DoNotExport;
            }
            else if (this.hiddenColumnExportAsHiddenRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.HiddenColumnOption = HiddenOption.ExportAsHidden;
            }
        }

        private void hiddenRowRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.hiddenRowExportAlwaysRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.HiddenRowOption = HiddenOption.ExportAlways;
            }
            else if (this.hiddenRowDoNotExportRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.HiddenRowOption = HiddenOption.DoNotExport;
            }
            else if (this.hiddenRowExportAsHiddenRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.HiddenRowOption = HiddenOption.ExportAsHidden;
            }
        }

        private void summariesRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.summariesExportAllRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.SummariesExportOption = SummariesOption.ExportAll;
            }
            else if (this.summariesExportOnlyTopRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
            }
            else if (this.summariesExportOnlyBottomRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
            }
            else if (this.summariesDoNotExportRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.SummariesExportOption = SummariesOption.DoNotExport;
            }
        }

        private void pagingRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.pagingCurrentPageOnlyRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.PagingExportOption = PagingExportOption.CurrentPageOnly;
            }
            else if (this.pagingAllPagesRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.PagingExportOption = PagingExportOption.AllPages;
            }
        }

        private void pinSomeRowsAndColumnsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.radGridView1.GroupDescriptors.Clear();
                this.radGridView1.Rows[0].IsPinned = true;
                this.radGridView1.Columns["CompanyName"].IsPinned = true;
                this.exportHierarchyCheckBox.ToggleState = ToggleState.Off;
            }
            else
            {
                this.radGridView1.Rows[0].IsPinned = false;
                this.radGridView1.Columns["CompanyName"].IsPinned = false;
            }
        }

        private void freezeHeaderRowCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.FreezeHeaderRow = args.ToggleState == ToggleState.On;
        }

        private void freezePinnedRowsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.FreezePinnedRows = args.ToggleState == ToggleState.On;
        }

        private void freezePinnedColumnsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.FreezePinnedColumns = args.ToggleState == ToggleState.On;
        }

        private void exportViewDefinitionCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.ExportViewDefinition = args.ToggleState == ToggleState.On;
        }

        #endregion

        #region PDF Export

        private void radButtonPdfExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "exportedFile";
            dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pdfExporter.RunExport(dialog.FileName, new PdfExportRenderer());
            }
        }

        private void pdfExporter_CellFormatting(object sender, PdfExportCellFormattingEventArgs e)
        {
            if (this.radCheckBoxCustomizeVisualSettingsPdfExport.ToggleState != ToggleState.On)
            {
                return;
            }

            if (e.Row is GridViewTableHeaderRowInfo)
            {
                if (e.Row.HierarchyLevel == 0)
                {
                    e.CellElement.BackColor = Color.DeepSkyBlue;
                }
                else if (e.Row.HierarchyLevel == 1)
                {
                    e.CellElement.BackColor = Color.LightSkyBlue;
                }
            }

            if (e.Row is GridViewHierarchyRowInfo)
            {
                if (e.Row.HierarchyLevel == 0)
                {
                    e.CellElement.Font = new Font("Segoe UI", 12);
                    e.CellElement.BackColor = Color.GreenYellow;
                }
                else if (e.Row.HierarchyLevel == 1)
                {
                    e.CellElement.ForeColor = Color.DarkGreen;
                    e.CellElement.BackColor = Color.LightGreen;
                }
            }
        }

        private void radCheckBoxExportVisualSettingsPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.pdfExporter.ExportVisualSettings = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxExportHierarchyPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.pdfExporter.ExportHierarchy = args.ToggleState == ToggleState.On;
        }

        private void radRadioButtonHiddenColumnPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioButtonHiddenColumnExportAlwaysPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.HiddenColumnOption = HiddenOption.ExportAlways;
            }
            else if (this.radRadioButtonHiddenColumnDoNotExportPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.HiddenColumnOption = HiddenOption.DoNotExport;
            }
            else if (this.radRadioButtonHiddenColumnExportAsHiddenPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.HiddenColumnOption = HiddenOption.ExportAsHidden;
            }
        }

        private void radRadioButtonHiddenRowPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioButtonHiddenRowExportAlwaysPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.HiddenRowOption = HiddenOption.ExportAlways;
            }
            else if (this.radRadioButtonHiddenRowDoNotExportPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.HiddenRowOption = HiddenOption.DoNotExport;
            }
            else if (this.radRadioButtonHiddenRowExportAsHiddenPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.HiddenRowOption = HiddenOption.ExportAsHidden;
            }
        }

        private void radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioButtonSummariesExportAllPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.SummariesExportOption = SummariesOption.ExportAll;
            }
            else if (this.radRadioButtonSummariesExportOnlyTopPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
            }
            else if (this.radRadioButtonSummariesExportOnlyBottomPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
            }
            else if (this.radRadioButtonSummariesDoNotExportPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.SummariesExportOption = SummariesOption.DoNotExport;
            }
        }

        private void radRadioButtonPagingOptionPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.PagingExportOption = PagingExportOption.CurrentPageOnly;
            }
            else if (this.radRadioButtonPagingOptionAllPAgesPdfExport.ToggleState == ToggleState.On)
            {
                this.pdfExporter.PagingExportOption = PagingExportOption.AllPages;
            }
        }

        private void radCheckBoxExportViewDefinitionPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.pdfExporter.ExportViewDefinition = args.ToggleState == ToggleState.On;
        }

        #endregion

        #endregion
    }
}