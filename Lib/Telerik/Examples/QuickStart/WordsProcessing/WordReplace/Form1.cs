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
using Telerik.Windows.Documents.Flow.Model.Editing;
using System.Text.RegularExpressions;
using System.Windows.Media;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.WordsProcessing.WordReplace
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private readonly Dictionary<IFormatProvider<RadFlowDocument>, string> providers;
        private readonly List<ReplaceOption> replaceOptions;

        private RadFlowDocument document;
        private string fileName;

        private string sampleDocumentFile = @"..\WordsProcessing\WordReplace\SampleData\SampleDocument.docx";
        private string selectedFormat = "Docx";
        private bool isDocumentLoaded = false;
        private ReplaceOption selectedReplaceOption;

        public Form1()
        {
            InitializeComponent();

            this.pictureBox1.Image = Image.FromFile(@"..\WordsProcessing\WordReplace\Images\SampleDocumentLargeThumbnail.png");
            this.providers = new Dictionary<IFormatProvider<RadFlowDocument>, string>()
            {
                {new DocxFormatProvider(), "Docx"},
                {new RtfFormatProvider(), "Rtf"},
                {new HtmlFormatProvider(), "Html"},
                {new TxtFormatProvider(), "Txt"},
                {new PdfFormatProvider(), "Pdf"}
            };

            this.replaceOptions = new List<ReplaceOption>();
            foreach (ReplaceOption replaceOption in Enum.GetValues(typeof(ReplaceOption)))
            {
                replaceOptions.Add(replaceOption);
            }
            selectOption.DataSource = replaceOptions;
            UpdateSaveAndReplaceButton();
            docName.Text = "";
        }
        private void LoadCustomDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Docx files|*.docx|Rtf files|*.rtf|Html files|*.html|Text files|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                findWhat.Text = "";
                replaceWith.Text = "";
                string extension = Path.GetExtension(dialog.FileName);
                IFormatProvider<RadFlowDocument> provider = this.providers.Keys
                    .FirstOrDefault(p => p.SupportedExtensions.Any(ex => string.Equals(extension, ex, StringComparison.InvariantCultureIgnoreCase)));

                if (provider == null)
                {
                    MessageBox.Show("Not supported file type.");
                    return;
                }

                this.selectedFormat = this.providers[provider];

                using (Stream stream = dialog.OpenFile())
                {
                    try
                    {
                        this.document = provider.Import(stream);
                        this.fileName = Path.GetFileName(dialog.FileName);
                        this.docName.Text = fileName;
                        this.isDocumentLoaded = true;
                        this.UpdateSaveAndReplaceButton();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Could not open file.");
                        this.document = null;
                        this.fileName = null;
                        this.docName.Text = "";
                    }
                }
            }
        }
        private void LoadSampleDoc_Click(object sender, EventArgs e)
        {
            File.SetAttributes(sampleDocumentFile, FileAttributes.Normal);
            using (Stream stream = new FileStream(sampleDocumentFile, FileMode.Open))
            {
                this.document = new DocxFormatProvider().Import(stream);
                this.fileName = Path.GetFileName(this.sampleDocumentFile);
                this.docName.Text = fileName;
                this.isDocumentLoaded = true;
                this.UpdateSaveAndReplaceButton();

                this.selectedFormat = "Docx";
            }
        }
        private void ReplaceAndSave_Click(object sender, EventArgs e)
        {
            this.Replace();

            string selectedFromat = this.selectedFormat;
            bool result = this.SaveDocument(this.document, selectedFromat);

            if (result)
            {
                this.CleanDocument();
            }
        }
        private void Replace()
        {
            switch (this.selectedReplaceOption)
            {
                case ReplaceOption.ReplaceText:
                    this.ReplaceText();
                    break;
                case ReplaceOption.ReplaceStyling:
                    this.ReplaceStyling();
                    break;
            }
        }
        public bool SaveDocument(RadFlowDocument document, string selectedFormat)
        {
            IFormatProvider<RadFlowDocument> formatProvider = null;
            switch (selectedFormat)
            {
                case "Docx":
                    formatProvider = new DocxFormatProvider();
                    break;
                case "Rtf":
                    formatProvider = new RtfFormatProvider();
                    break;
                case "Html":
                    formatProvider = new HtmlFormatProvider();
                    break;
                case "Txt":
                    formatProvider = new TxtFormatProvider();
                    break;
                case "Pdf":
                    formatProvider = new PdfFormatProvider();
                    break;
            }

            if (formatProvider == null)
            {
                return false;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Result";
            dialog.Filter = String.Format("{0} files|*{1}|All files (*.*)|*.*",
                selectedFormat,
                formatProvider.SupportedExtensions.First());
            dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = dialog.OpenFile())
                {
                    formatProvider.Export(document, stream);
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        private void ReplaceText()
        {
            if (string.IsNullOrEmpty(this.findWhat.Text))
            {
                return;
            }

            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(this.document);

            if (this.useRegex.Checked)
            {
                Regex oldTextRegex = new Regex(this.findWhat.Text);
                editor.ReplaceText(oldTextRegex, this.replaceWith.Text);
            }
            else
            {
                editor.ReplaceText(this.findWhat.Text, this.replaceWith.Text, this.matchCase.Checked, this.matchWholeWord.Checked);
            }
        }

        private void ReplaceStyling()
        {
            if (string.IsNullOrEmpty(this.findWhat.Text))
            {
                return;
            }

            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(this.document);

            if (this.useRegex.Checked)
            {
                Regex searchedTextRegex = new Regex(this.findWhat.Text);
                editor.ReplaceStyling(searchedTextRegex, properties => properties.HighlightColor.LocalValue = Colors.Yellow);
            }
            else
            {
                editor.ReplaceStyling(this.findWhat.Text, this.matchCase.Checked, this.matchWholeWord.Checked, properties => properties.HighlightColor.LocalValue = Colors.Yellow);
            }
        }

        private void CleanDocument()
        {
            this.document = null;
            this.fileName = null;
            this.isDocumentLoaded = false;
            this.UpdateSaveAndReplaceButton();
        }

        private void SelectOption_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 0)
            {
                radLabel6.Visible = true;
                replaceWith.Visible = true;
                this.selectedReplaceOption = ReplaceOption.ReplaceText;
            }
            else
            {
                radLabel6.Visible = false;
                replaceWith.Visible = false;
                this.selectedReplaceOption = ReplaceOption.ReplaceStyling;
            }
        }

        private void UpdateSaveAndReplaceButton()
        {
            replaceAndSave.Enabled = this.isDocumentLoaded && this.selectOption.SelectedItem != null;
        }
    }
}
