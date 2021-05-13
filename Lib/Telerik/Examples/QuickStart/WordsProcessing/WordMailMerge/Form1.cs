using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using Telerik.Windows.Documents.Common.FormatProviders;
using Telerik.Windows.Documents.Flow.FormatProviders.Pdf;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Html;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.FormatProviders.Txt;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.WordsProcessing.WordMailMerge
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private static readonly ThemableColor greenColor = new ThemableColor(System.Windows.Media.Color.FromArgb(255, 92, 230, 0));
        private IEnumerable<string> exportFormats;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"..\WordsProcessing\WordMailMerge\Images\MailMergeThumbnail.png");
            radDropDownList1.DataSource = ExportFormats;
            radDropDownList1.SelectedIndex = 1;
            radDropDownList1.SelectedIndexChanged += RadDropDownList1_SelectedIndexChanged;
            this.SelectedExportFormat = radDropDownList1.SelectedItem.Text;
        }

        public string SelectedExportFormat { get; private set; }

        public IEnumerable<string> ExportFormats
        {
            get
            {
                if (exportFormats == null)
                {
                    exportFormats = new string[] { "Docx", "Rtf", "Html" };
                }

                return exportFormats;
            }
        }

        private void RadDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.SelectedExportFormat = radDropDownList1.SelectedItem.Text;
        }

        private void MailMerge()
        {
            RadFlowDocument document = this.CreateDocument();

            RadFlowDocument mailMergeDocument = document.MailMerge(Person.Persons);
            mailMergeDocument.DocumentVariables.Add("sender", "Telerik Team");
            mailMergeDocument.UpdateFields();

            string selectedFromat = this.SelectedExportFormat;
            SaveDocument(mailMergeDocument, selectedFromat);
        }

        public static bool SaveDocument(RadFlowDocument document, string selectedFormat)
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

            if (dialog.ShowDialog() ==  DialogResult.OK)
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

        private RadFlowDocument CreateDocument()
        {
            RadFlowDocument document = new RadFlowDocument();
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
            editor.ParagraphFormatting.TextAlignment.LocalValue = Alignment.Justified;

            Paragraph paragraphWithText = editor.InsertParagraph();
            editor.MoveToParagraphStart(paragraphWithText);

            editor.InsertText("Dear ");
            editor.InsertField("MERGEFIELD FirstName", "");
            editor.InsertText(" ");
            editor.InsertField("MERGEFIELD LastName", "");
            editor.InsertLine(",");
            editor.InsertLine("We're happy to introduce the new Telerik RadWordsProcessing component for WPF. High performance library that enables you to read, write and manipulate documents in DOCX, RTF, HTML and plain text format.");

            editor.InsertText("The current beta version comes with full rich-text capabilities including ");
            editor.InsertText("bold, ").FontWeight = FontWeights.Bold;
            editor.InsertText("italic, ").FontStyle = FontStyles.Italic;
            Run underlined = editor.InsertText("underline,");
            underlined.Underline.Pattern = UnderlinePattern.Dotted;
            underlined.Underline.Color = new ThemableColor(Colors.Black);
            editor.InsertText(" font sizes and ").FontSize = 20;
            editor.InsertText("colors ").ForegroundColor = greenColor;
            editor.InsertLine("as well as text alignment and indentation. Other options include tables, lists, hyperlinks, bookmarks and comments, inline and floating images. Even more sweetness is added by the built-in styles and themes.");

            editor.InsertLine("We hope you'll enjoy RadWordsProcessing as much as we do. Happy coding!");

            editor.InsertParagraph().Spacing.SpacingAfter = 0;
            editor.InsertLine("Regards,");
            editor.InsertField("DOCVARIABLE sender", "");

            editor.InsertParagraph();

            File.SetAttributes(@"..\WordsProcessing\WordMailMerge\Images\TelerikLogoSmall.png", FileAttributes.Normal);
            using (Stream stream = new FileStream(@"..\WordsProcessing\WordMailMerge\Images\TelerikLogoSmall.png", FileMode.Open))
            {
                editor.InsertImageInline(stream, "png", new System.Windows.Size(93, 42));
            }

            return document;
        }

        private void mailMergeButton_Click(object sender, EventArgs e)
        {
            this.MailMerge();
        }
    }
}