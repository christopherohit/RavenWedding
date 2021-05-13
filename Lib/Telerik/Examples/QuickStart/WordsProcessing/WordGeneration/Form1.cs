using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Telerik.QuickStart.WinControls;
using Telerik.Windows.Documents.Flow.Model;
using Telerik.Windows.Documents.Flow.Model.Editing;
using Telerik.Windows.Documents.Flow.Model.Styles;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace Telerik.Examples.WinControls.WordsProcessing.WordGeneration
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {       
        private IEnumerable<string> exportFormats;
        private static readonly ThemableColor GreenColor = ThemableColor.FromArgb(255, 92, 230, 0);

        public bool IncludeHeader { get; set; }
        public bool IncludeFooter { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.exportFormatDropDownList.DataSource = ExportFormats;
            this.exportFormatDropDownList.SelectedIndex = 0;
            this.IncludeHeader = true;
            this.IncludeFooter = true;
        }

        public IEnumerable<string> ExportFormats
        {
            get
            {
                if (this.exportFormats == null)
                {
                    exportFormats = new string[] { "Docx", "Rtf", "Txt" };
                }

                return this.exportFormats;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            RadFlowDocument document = this.CreateDocument();

            string selectedFromat = this.exportFormatDropDownList.Text;
            FileHelper.SaveDocument(document, selectedFromat);
        }


        private void Generate(object obj)
        {
            RadFlowDocument document = this.CreateDocument();

            string selectedFromat = this.exportFormatDropDownList.Text;
            FileHelper.SaveDocument(document, selectedFromat);
        }

        private RadFlowDocument CreateDocument()
        {
            RadFlowDocument document = new RadFlowDocument();
            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
            editor.ParagraphFormatting.TextAlignment.LocalValue = Alignment.Justified;

            // Body
            editor.InsertLine("Dear Telerik User,");
            editor.InsertText("We’re happy to introduce the new Telerik RadWordsProcessing component for WPF. High performance library that enables you to read, write and manipulate documents in DOCX, RTF and plain text format. The document model is independent from UI and ");
            Run run = editor.InsertText("does not require");
            run.Underline.Pattern = UnderlinePattern.Single;
            editor.InsertLine(" Microsoft Office.");

            editor.InsertText("The current community preview version comes with full rich-text capabilities including ");
            editor.InsertText("bold, ").FontWeight = FontWeights.Bold;
            editor.InsertText("italic, ").FontStyle = FontStyles.Italic;
            editor.InsertText("underline,").Underline.Pattern = UnderlinePattern.Single;
            editor.InsertText(" font sizes and ").FontSize = 20;
            editor.InsertText("colors ").ForegroundColor = GreenColor;

            editor.InsertLine("as well as text alignment and indentation. Other options include tables, hyperlinks, inline and floating images. Even more sweetness is added by the built-in styles and themes.");

            editor.InsertText("Here at Telerik we strive to provide the best services possible and fulfill all needs you as a customer may have. We would appreciate any feedback you send our way through the ");
            editor.InsertHyperlink("public forums", "http://www.telerik.com/forums", false, "Telerik Forums");
            editor.InsertLine(" or support ticketing system.");

            editor.InsertLine("We hope you’ll enjoy RadWordsProcessing as much as we do. Happy coding!");
            editor.InsertParagraph();
            editor.InsertText("Kind regards,");

            this.CreateSignature(editor);

            this.CreateHeader(editor);

            this.CreateFooter(editor);

            return document;
        }

        private void CreateSignature(RadFlowDocumentEditor editor)
        {
            Table signatureTable = editor.InsertTable(1, 2);
            signatureTable.Rows[0].Cells[0].Borders = new TableCellBorders(
                new Border(Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.None),
                new Border(Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.None),
                new Border(4, Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.Single, GreenColor),
                new Border(Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.None));

            // Create paragraph with image
            signatureTable.Rows[0].Cells[0].PreferredWidth = new TableWidthUnit(140);
            Paragraph paragraphWithImage = signatureTable.Rows[0].Cells[0].Blocks.AddParagraph();
            paragraphWithImage.Spacing.SpacingAfter = 0;
            editor.MoveToParagraphStart(paragraphWithImage);
            using (Stream stream = FileHelper.GetSampleResourceStream("Telerik.Examples.WinControls.WordsProcessing.WordGeneration.SampleData.progress-logo.png"))
            {
                editor.InsertImageInline(stream, "png", new System.Windows.Size(120, 29));
            }

            // Create cell with name and position
            signatureTable.Rows[0].Cells[1].PreferredWidth = new TableWidthUnit(100);
            signatureTable.Rows[0].Cells[1].Padding = new Telerik.Windows.Documents.Primitives.Padding(12, 0, 0, 0);
            Paragraph cellParagraph = signatureTable.Rows[0].Cells[1].Blocks.AddParagraph();
            cellParagraph.Spacing.SpacingAfter = 0;
            editor.MoveToParagraphStart(cellParagraph);
            editor.CharacterFormatting.FontSize.LocalValue = 12;

            editor.InsertText("Jane Doe").FontWeight = FontWeights.Bold;
            editor.InsertParagraph().Spacing.SpacingAfter = 0;
            editor.InsertText("Support Officer");
        }

        private void CreateFooter(RadFlowDocumentEditor editor)
        {
            if (this.IncludeFooter)
            {
                Footer footer = editor.Document.Sections.First().Footers.Add();
                Paragraph paragraph = footer.Blocks.AddParagraph();
                paragraph.TextAlignment = Alignment.Right;

                editor.MoveToParagraphStart(paragraph);
                editor.InsertHyperlink("telerik.com", "http://www.telerik.com", false, "Telerik Site");
            }
        }

        private void CreateHeader(RadFlowDocumentEditor editor)
        {
            if (this.IncludeHeader)
            {
                Header header = editor.Document.Sections.First().Headers.Add();
                editor.MoveToParagraphStart(header.Blocks.AddParagraph());
                using (Stream stream = FileHelper.GetSampleResourceStream("Telerik.Examples.WinControls.WordsProcessing.WordGeneration.SampleData.progress-big-logo.png"))
                {
                    editor.InsertImageInline(stream, "png", new System.Windows.Size(660, 222));
                }
            }
        }

        private void radCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.IncludeHeader = this.radCheckBox1.Checked;
        }

        private void radCheckBox2_CheckStateChanged(object sender, EventArgs e)
        {
            this.IncludeFooter = this.radCheckBox1.Checked;
        }
    }
}
