using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.Xls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadConvertion
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private static readonly string SampleDocumentFile = "Telerik.Examples.WinControls.SpreadProcessing.SpreadConvertion.SampleData.SampleDocument.xlsx";
        private List<IWorkbookFormatProvider> providers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fileExtensionsDropDownList.SelectedIndex = 2;
            this.providers = new List<IWorkbookFormatProvider>()
            {
                new XlsFormatProvider(),
                new XlsxFormatProvider(),
                new CsvFormatProvider(),
                new TxtFormatProvider()
            };            
        }

        private void loadCustomDocumentButton_Click(object sender, EventArgs args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Xlsx files|*.xlsx|Xls files|*.xls|Csv files|*.Csv|Text files|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(dialog.FileName);
                IWorkbookFormatProvider provider = this.providers
                    .FirstOrDefault(p => p.SupportedExtensions
                        .Any(e => string.Compare(extension, e, StringComparison.InvariantCultureIgnoreCase) == 0));

                if (provider != null)
                {
                    try
                    {
                        using (Stream stream = dialog.OpenFile())
                        {
                            this.Workbook = provider.Import(stream);
                            this.FileName = Path.GetFileName(dialog.FileName);
                            this.saveButton.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not open file.");
                        this.Workbook = null;
                        this.FileName = null;
                    }
                }
                
                else
                {
                    MessageBox.Show("Could not open file.");
                }
            }
        }

        private Workbook workbook;
        public Workbook Workbook
        {
            get
            {
                return this.workbook;
            }
            set
            {
                if (this.workbook != value)
                {
                    this.workbook = value;
                    this.IsDocumentLoaded = value != null;                    
                }
            }
        }

        private bool isDocumentLoaded;
        public bool IsDocumentLoaded
        {
            get
            {
                return this.isDocumentLoaded;
            }
            set
            {
                if (this.isDocumentLoaded != value)
                {
                    this.isDocumentLoaded = value;                 
                }
            }
        }

        private string fileName;
        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                if (this.fileName != value)
                {
                    this.fileName = value;
                    this.fileNameLabel.Text = value;
                }
            }
        }

        private IEnumerable<string> exportFormats;
        public IEnumerable<string> ExportFormats
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

        private void loadSampleDocumentButton_Click(object sender, EventArgs e)
        {
            using (Stream stream = FileHelper.GetSampleResourceStream(SampleDocumentFile))
            {
                this.Workbook = new XlsxFormatProvider().Import(stream);
                this.FileName = Path.GetFileName(SampleDocumentFile);
                this.saveButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string selectedFromat = this.fileExtensionsDropDownList.Text;
            FileHelper.SaveDocument(this.Workbook, selectedFromat);
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
