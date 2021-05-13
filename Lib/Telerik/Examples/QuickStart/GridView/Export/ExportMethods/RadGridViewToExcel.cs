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


namespace Telerik.Examples.WinControls.GridView.Export.ExportMethods
{
    public partial class Form1 : ExamplesForm
    {
        // Fields
        private bool exportVisualSettings;
	
		public Form1()
        {
            InitializeComponent();
            
            this.radGridView1.EnableHotTracking = true;
            this.radGridView1.EnableAlternatingRowColor = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.TableElement.BeginUpdate();
            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;

            this.AddSummaries();
            this.radGridView1.TableElement.EndUpdate();

            SetConditions();

            this.radListBox1.SelectedIndex = 0;
            this.radComboBoxSummaries.SelectedIndex = 0;

            this.radGridView1.Columns[0].Width = 300;
        }  

        //Update the progress bar with the export progress
        private void exportProgress(object sender, ProgressEventArgs e)
        {
            // Call InvokeRequired to check if thread needs marshalling, to access properly the UI thread.
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(
                    delegate{
                        if (e.ProgressValue <= 100)
                        {
                            radProgressBar1.Value1 = e.ProgressValue;
                        }
                        else
                        {
                            radProgressBar1.Value1 = 100;
                        }
                }));
            }
            else
            {
                if (e.ProgressValue <= 100)
                {
                    radProgressBar1.Value1 = e.ProgressValue;
                }
                else
                {
                    radProgressBar1.Value1 = 100;
                }
                
            }
        }

        // when the worker finishes the export, we can do some post processing
        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.radButtonExport.Enabled = true;
			this.radProgressBar1.Value1 = 0;

            RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
            RadMessageBox.Show("The data in the grid was exported successfully.", "Export to Excel");
        }

        private void radListBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            saveFileDialog.Filter = "Excel (*.xls)|*.xls";

            switch (this.radListBox1.SelectedIndex)
            {             
                case 0: //export to excelML
                    this.radCheckBoxExportVisual.Enabled = true;
                    this.radRadioButton1.Enabled = true;
                    this.radRadioButton2.Enabled = true;
                    this.radTextBoxSheet.Enabled = true;
                    this.radComboBoxSummaries.Enabled = true;
                    this.radLabel1.Visible = true;
                    this.radLabel1.Text = "Sheet:";
                    this.radTextBoxSheet.Text = String.Empty;
                    this.radTextBoxSheet.Visible = true;

                    this.radProgressBar1.Visible = false;
                    this.radLblProgress.Visible = false;
                    break;
                case 1: //export to CSV
                    saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
                    this.radCheckBoxExportVisual.Enabled = false;
                    this.radRadioButton1.Enabled = false;
                    this.radRadioButton2.Enabled = false;
                    this.radTextBoxSheet.Enabled = false;
                    this.radComboBoxSummaries.Enabled = true;
                    this.radLabel1.Visible = false;
                    this.radTextBoxSheet.Visible = false;

                    this.radProgressBar1.Visible = false;
                    this.radLblProgress.Visible = false;
                    break;
                case 2: //export to HTML
                    saveFileDialog.Filter = "Html File (*.htm)|*.htm";
                    this.radCheckBoxExportVisual.Enabled = true;
                    this.radRadioButton1.Enabled = false;
                    this.radRadioButton2.Enabled = false;
                    this.radTextBoxSheet.Enabled = true;
                    this.radComboBoxSummaries.Enabled = true;
                    this.radLabel1.Visible = true;
                    this.radLabel1.Text = "HtmlTable Caption:";
                    this.radTextBoxSheet.Text = String.Empty;
                    this.radTextBoxSheet.Visible = true;

                    this.radProgressBar1.Visible = false;
                    this.radLblProgress.Visible = false;
                    break;
                case 3: //export to PDF
                    saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
                    this.radCheckBoxExportVisual.Enabled = true;
                    this.radRadioButton1.Enabled = false;
                    this.radRadioButton2.Enabled = false;
                    this.radTextBoxSheet.Enabled = true;
                    this.radComboBoxSummaries.Enabled = true;
                    this.radLabel1.Visible = true;
                    this.radLabel1.Text = "PdfTable Caption:";
                    this.radTextBoxSheet.Text = String.Empty;
                    this.radTextBoxSheet.Visible = true;

                    this.radProgressBar1.Visible = false;
                    this.radLblProgress.Visible = false;
                    break;
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

            if (this.radCheckBoxExportVisual.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.exportVisualSettings = true;
            }
            else
            {
                this.exportVisualSettings = false;
            }

            switch (this.radListBox1.SelectedIndex)
            {
                case 0: //export to excelML
                    RunExportToExcelML(fileName, ref openExportFile);
                    break;

                case 1: //export to CSV
                    RunExportToCSV(fileName, ref openExportFile);
                    break;

                case 2: //export to HTML
                    RunExportToHTML(fileName, ref openExportFile);
                    break;

                case 3: //export to PDF
                    RunExportToPDF(fileName, ref openExportFile);
                    break;
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

        private void SetConditions()
        {
            //add a couple of sample formatting objects
            ConditionalFormattingObject c1 = new ConditionalFormattingObject("Red", ConditionTypes.Equal, "London", "", true);
            c1.RowBackColor = Color.FromArgb(255, 153, 0);
            c1.RowForeColor = Color.Black;
            radGridView1.Columns["City"].ConditionalFormattingObjectList.Add(c1);

            ConditionalFormattingObject c2 = new ConditionalFormattingObject("Green", ConditionTypes.Equal, "Berlin", "", true);
            c2.RowBackColor = Color.FromArgb(165, 244, 36);
            c2.RowForeColor = Color.Black;
            radGridView1.Columns["City"].ConditionalFormattingObjectList.Add(c2);
        }

        private void AddSummaries()
        {
            GridViewSummaryRowItem item1 = new GridViewSummaryRowItem();
            GridViewSummaryRowItem item2 = new GridViewSummaryRowItem();

            item1.Add(new GridViewSummaryItem("CompanyName", "Count: {0}", GridAggregateFunction.Count));
            item2.Add(new GridViewSummaryItem("ContactName", "Count: {0}", GridAggregateFunction.Count));

            this.radGridView1.MasterTemplate.SummaryRowsTop.Add(item1);
            this.radGridView1.MasterTemplate.SummaryRowsBottom.Add(item2);
        }

        private void RunExportToExcelML(string fileName, ref bool openExportFile)
        {
            ExportToExcelML excelExporter = new ExportToExcelML(this.radGridView1);

            if (this.radTextBoxSheet.Text != String.Empty)
            {
                excelExporter.SheetName = this.radTextBoxSheet.Text;

            }

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

            //set max sheet rows
            if (this.radRadioButton1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                excelExporter.SheetMaxRows = ExcelMaxRows._1048576;
            }
            else if (this.radRadioButton2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                excelExporter.SheetMaxRows = ExcelMaxRows._65536;
            }

            //set exporting visual settings
            excelExporter.ExportVisualSettings = this.exportVisualSettings;

            try
            {
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
        }

        private void RunExportToCSV(string fileName, ref bool openExportFile)
        {
            ExportToCSV csvExporter = new ExportToCSV(this.radGridView1);
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
            try
            {
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
        }

        private void RunExportToHTML(string fileName, ref bool openExportFile)
        {
            ExportToHTML htmlExporter = new ExportToHTML(this.radGridView1);

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

            //set exporting visual settings
            htmlExporter.ExportVisualSettings = this.exportVisualSettings;
            htmlExporter.TableCaption = this.radTextBoxSheet.Text;

            try
            {
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
        }

        private void RunExportToPDF(string fileName, ref bool openExportFile)
        {
            ExportToPDF pdfExporter = new ExportToPDF(this.radGridView1);
            pdfExporter.PdfExportSettings.Title = "My PDF Title";
            pdfExporter.PdfExportSettings.PageWidth = 297;
            pdfExporter.PdfExportSettings.PageHeight = 210;
            pdfExporter.PageTitle = this.radTextBoxSheet.Text;
            pdfExporter.FitToPageWidth = true;
                     
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

            //set exporting visual settings
            pdfExporter.ExportVisualSettings = this.exportVisualSettings;

            try
            {
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
        }

        protected override void WireEvents()
        {
            this.radButtonExport.Click += new System.EventHandler(this.radButtonExport_Click);
            this.radListBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radListBox1_SelectedIndexChanged);
        }
    }
}