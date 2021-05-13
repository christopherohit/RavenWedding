using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Common.FormatProviders;
using Telerik.Windows.Documents.Flow.FormatProviders;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Html;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.FormatProviders.Txt;
using Telerik.Windows.Documents.Flow.Model;


namespace Telerik.Examples.WinControls.WordsProcessing.WordConvertion
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private static readonly string SampleDocumentFile = "Telerik.Examples.WinControls.WordsProcessing.WordConvertion.SampleData.SampleDocument.docx";
        private List<IFormatProvider<RadFlowDocument>> providers;
        public RadFlowDocument Document { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.fileExtensionsDropDownList.DataSource = this.ExportFormats;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fileExtensionsDropDownList.SelectedIndex = 1;
            this.providers = new List<IFormatProvider<RadFlowDocument>>()
            {
                new DocxFormatProvider(),
                new RtfFormatProvider(),
                new HtmlFormatProvider(),
                new TxtFormatProvider(),
                
            };       
        }

        private void loadCustomDocumentButton_Click(object sender, EventArgs args)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Docx files|*.docx|Rtf files|*.rtf|Html files|*.html|Text files|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(dialog.FileName);
                IFormatProvider<RadFlowDocument> provider = this.providers
                    .FirstOrDefault(p => p.SupportedExtensions
                        .Any(e => string.Compare(extension, e, StringComparison.InvariantCultureIgnoreCase) == 0));

                if (provider != null)
                {
                    try
                    {
                        using (Stream stream = dialog.OpenFile())
                        {
                            this.Document = provider.Import(stream);
                            this.FileName = Path.GetFileName(dialog.FileName);
                            this.saveButton.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not open file.");
                        this.Document = null;
                        this.FileName = null;
                    }
                }
                else
                {
                    MessageBox.Show("Could not open file.");
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
                    exportFormats = new string[] { "Docx", "Rtf", "Txt", "Html" };
                }

                return exportFormats;
            }
        }

        private void loadSampleDocumentButton_Click(object sender, EventArgs e)
        {
            using (Stream stream = FileHelper.GetSampleResourceStream(SampleDocumentFile))
            {
                this.Document = new DocxFormatProvider().Import(stream);
                this.FileName = Path.GetFileName( SampleDocumentFile);
                this.saveButton.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string selectedFromat = this.fileExtensionsDropDownList.Text;
            FileHelper.SaveDocument(this.Document, selectedFromat);
        }      
    }
}
