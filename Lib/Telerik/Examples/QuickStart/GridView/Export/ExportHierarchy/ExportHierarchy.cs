using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Telerik.Data;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;


namespace Telerik.Examples.WinControls.GridView.Export.ExportHierarchy
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            saveFileDialog.Filter = "Excel (*.xls)|*.xls";

            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.AutoGenerateHierarchy = true;
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.ShowFilteringRow = false;
            this.radGridView1.ShowHeaderCellButtons = true;
            this.radGridView1.AutoExpandGroups = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.TableElement.BeginUpdate();
            //TODO
            //this.ordersTableAdapter.FillByTOP20(this.nwindDataSet.Orders);
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
            this.order_detailsTableAdapter.Fill(this.nwindDataSet.Order_Details);

            this.radGridView1.Columns["ShipName"].IsVisible = false;
            this.radGridView1.Columns["ShipAddress"].IsVisible = false;
            this.radGridView1.Columns["ShipPostalCode"].IsVisible = false;
            this.radGridView1.Columns["RequiredDate"].IsVisible = false;
            this.radGridView1.Columns["ShippedDate"].IsVisible = false;

            this.radGridView1.Columns["OrderDate"].FormatString = "{0:d}";
            this.radGridView1.Columns["OrderDate"].ExcelExportType = DisplayFormatType.ShortDate;

            this.radGridView1.MasterTemplate.Templates[0].Columns["UnitPrice"].FormatString = "{0:c}";

            this.AddSummaries();
            this.radGridView1.TableElement.EndUpdate();

            this.radRadioButtonExcel.IsChecked = true;
            this.radComboBoxSummaries.SelectedIndex = 0;
        }

        void radRadioButtonExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioButtonCsv.IsChecked)
            {
                this.radCheckBoxExportVisual.Enabled = false;
                saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
            }
            else
            {
                this.radCheckBoxExportVisual.Enabled = true;

                if (this.radRadioButtonExcel.IsChecked)
                {
                    saveFileDialog.Filter = "Excel (*.xls)|*.xls";
                }
                else if (this.radRadioButtonHtml.IsChecked)
                {
                    saveFileDialog.Filter = "Html File (*.htm)|*.htm";
                }
                else if (this.radRadioButtonPdf.IsChecked)
                {
                    saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
                }
            }
        }

        private void radButtonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (saveFileDialog.FileName.Equals(String.Empty))
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show("Please enter a file name.");
                return;
            }

            string fileName = this.saveFileDialog.FileName;
            bool openExportFile = false;

            if (this.radRadioButtonExcel.IsChecked)
            {
                RunExportToExcelML(fileName, ref openExportFile);
            }
            else if (this.radRadioButtonCsv.IsChecked)
            {
                RunExportToCSV(fileName, ref openExportFile);
            }
            else if (this.radRadioButtonHtml.IsChecked)
            {
                RunExportToHTML(fileName, ref openExportFile);
            }
            else if (this.radRadioButtonPdf.IsChecked)
            {
                RunExportToPDF(fileName, ref openExportFile);
            }

            if (openExportFile)
            {
                try
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                catch (Exception ex)
                {
                    string message = String.Format("The file cannot be opened on your system.\nError message: {0}", ex.Message);
                    RadMessageBox.Show(message, "Open File", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }

        private void AddSummaries()
        {
            //master template
            GridViewSummaryRowItem item1 = new GridViewSummaryRowItem();
            GridViewSummaryRowItem item2 = new GridViewSummaryRowItem();

            item1.Add(new GridViewSummaryItem("OrderID", "Count: {0}", GridAggregateFunction.Count));
            item2.Add(new GridViewSummaryItem("Freight", "Max: {0}", GridAggregateFunction.Max));

            this.radGridView1.MasterTemplate.SummaryRowsTop.Add(item1);
            this.radGridView1.MasterTemplate.SummaryRowsBottom.Add(item2);

            //child template
            GridViewSummaryRowItem item3 = new GridViewSummaryRowItem();
            GridViewSummaryRowItem item4 = new GridViewSummaryRowItem();

            item3.Add(new GridViewSummaryItem("UnitPrice", "Avg: {0:c}", GridAggregateFunction.Avg));
            item4.Add(new GridViewSummaryItem("Quantity", "Sum: {0}", GridAggregateFunction.Sum));

            this.radGridView1.MasterTemplate.Templates[0].SummaryRowsTop.Add(item3);
            this.radGridView1.MasterTemplate.Templates[0].SummaryRowsBottom.Add(item4);
        }

        private void radComboBoxSummaries_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radButtonExport.Focus();
        }

        private void RunExportToExcelML(string fileName, ref bool openExportFile)
        {
            ExportToExcelML excelExporter = new ExportToExcelML(this.radGridView1);

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    excelExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    excelExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            excelExporter.ExportVisualSettings = this.radCheckBoxExportVisual.IsChecked;
            excelExporter.ExportHierarchy = this.radCheckBoxExportHierarchy.IsChecked;
            excelExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                excelExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to Excel", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void RunExportToCSV(string fileName, ref bool openExportFile)
        {
            ExportToCSV csvExporter = new ExportToCSV(this.radGridView1);
            csvExporter.CSVCellFormatting += csvExporter_CSVCellFormatting;

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    csvExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    csvExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            csvExporter.ExportHierarchy = this.radCheckBoxExportHierarchy.IsChecked;
            csvExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                csvExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to CSV", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void csvExporter_CSVCellFormatting(object sender, Telerik.WinControls.UI.Export.CSV.CSVCellFormattingEventArgs e)
        {
            if (e.GridCellInfo.ColumnInfo is GridViewDateTimeColumn)
            {
                e.CSVCellElement.Value = this.FormatDate(e.CSVCellElement.Value);
            }
        }

        private void RunExportToHTML(string fileName, ref bool openExportFile)
        {
            ExportToHTML htmlExporter = new ExportToHTML(this.radGridView1);
            htmlExporter.HTMLCellFormatting += htmlExporter_HTMLCellFormatting;

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    htmlExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            htmlExporter.ExportVisualSettings = this.radCheckBoxExportVisual.IsChecked;
            htmlExporter.ExportHierarchy = this.radCheckBoxExportHierarchy.IsChecked;
            htmlExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                htmlExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to HTML", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }
            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void htmlExporter_HTMLCellFormatting(object sender, Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventArgs e)
        {
            if (e.GridCellInfo.ColumnInfo is GridViewDateTimeColumn)
            {
                e.HTMLCellElement.Value = this.FormatDate(e.HTMLCellElement.Value);
            }
        }

        private void RunExportToPDF(string fileName, ref bool openExportFile)
        {
            ExportToPDF pdfExporter = new ExportToPDF(this.radGridView1);
            pdfExporter.PdfExportSettings.Title = "My PDF Title";
            pdfExporter.PdfExportSettings.PageWidth = 297;
            pdfExporter.PdfExportSettings.PageHeight = 210;
            pdfExporter.FitToPageWidth = true;
            pdfExporter.HTMLCellFormatting += pdfExporter_HTMLCellFormatting;

            switch (this.radComboBoxSummaries.SelectedIndex)
            {
                case 0:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportAll;
                    break;
                case 1:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyTop;
                    break;
                case 2:
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom;
                    break;
                case 3:
                    pdfExporter.SummariesExportOption = SummariesOption.DoNotExport;
                    break;
            }

            //set export settings
            pdfExporter.ExportVisualSettings = this.radCheckBoxExportVisual.IsChecked;
            pdfExporter.ExportHierarchy = this.radCheckBoxExportHierarchy.IsChecked;
            pdfExporter.HiddenColumnOption = HiddenOption.DoNotExport;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                pdfExporter.RunExport(fileName);

                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                DialogResult dr = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?",
                    "Export to PDF", MessageBoxButtons.YesNo, RadMessageIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    openExportFile = true;
                }

            }
            catch (IOException ex)
            {
                RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
                RadMessageBox.Show(this, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void pdfExporter_HTMLCellFormatting(object sender, Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventArgs e)
        {
            if (e.GridCellInfo.ColumnInfo is GridViewDateTimeColumn)
            {
                e.HTMLCellElement.Value = this.FormatDate(e.HTMLCellElement.Value);
            }
        }

        private string FormatDate(object value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.ToString("d MMM yyyy");
            }

            return value.ToString();
        }

        protected override void WireEvents()
        {
            this.radComboBoxSummaries.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBoxSummaries_SelectedIndexChanged);
            this.radRadioButtonExcel.ToggleStateChanged += new StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
            this.radRadioButtonCsv.ToggleStateChanged += new StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
            this.radRadioButtonHtml.ToggleStateChanged += new StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
            this.radRadioButtonPdf.ToggleStateChanged += new StateChangedEventHandler(radRadioButtonExport_ToggleStateChanged);
            this.radButtonExport.Click += new System.EventHandler(this.radButtonExport_Click);
        }
    }
}