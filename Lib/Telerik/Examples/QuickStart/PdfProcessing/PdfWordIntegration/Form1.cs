using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Windows.Documents.Common.FormatProviders;
using Telerik.Windows.Documents.Flow.FormatProviders.Pdf;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Html;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.FormatProviders.Txt;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.PdfProcessing.PdfWordIntegration
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private RadFlowDocument document;
        private readonly List<IFormatProvider<RadFlowDocument>> providers;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"..\PdfProcessing\PdfWordIntegration\SampleData\CustomDocumentImage.png");
            pictureBox2.Image = Image.FromFile(@"..\PdfProcessing\PdfWordIntegration\SampleData\JohnGrishamThumbnail.png");
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.providers = new List<IFormatProvider<RadFlowDocument>>()
            {
                new DocxFormatProvider(),
                new  RtfFormatProvider(),
                new HtmlFormatProvider(),
                new TxtFormatProvider(),
                new PdfFormatProvider()
            };
            radDropDownList1.SelectedIndex = 0;
        }

        private void loadCustomDocButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Docx files|*.docx|Rtf files|*.rtf|Html files|*.html|Text files|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(dialog.FileName);
                IFormatProvider<RadFlowDocument> provider = this.providers.FirstOrDefault(p => p.SupportedExtensions
                        .Any(x => string.Equals(extension, x, StringComparison.InvariantCultureIgnoreCase)));

                if (provider == null)
                {
                    MessageBox.Show("Not supported file type.");
                    return;
                }

                using (Stream stream = dialog.OpenFile())
                {
                    try
                    {
                        this.document = provider.Import(stream);
                        this.documentPathLabel.Text = Path.GetFileName(dialog.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not open file.");
                        this.document = null;
                        this.documentPathLabel.Text = "";
                    }
                }
            }
        }

        private void loadSampleDocButton_Click(object sender, EventArgs e)
        {
            string path = @"..\PdfProcessing\PdfWordIntegration\SampleData\JohnGrisham.docx";
            File.SetAttributes(path, FileAttributes.Normal);
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                this.document = new DocxFormatProvider().Import(stream);
                this.documentPathLabel.Text = Path.GetFileName(path);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            IFormatProvider<RadFlowDocument> formatProvider = new PdfFormatProvider();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = String.Format("Pdf files|*{0}|All files (*.*)|*.*", formatProvider.SupportedExtensions.First());
            dialog.FileName = "Result";
            dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = dialog.OpenFile())
                {
                    formatProvider.Export(document, stream);
                }
            } 
        }
    }
}
