using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.MergeDocuments
{
    public partial class Form1 : RadForm
    {
        private bool isFirst = true;

        public Form1()
        {
            InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            this.radRichTextEditor1.ProviderUILayerInitialized += radRichTextEditor1_ProviderUILayerInitialized;
        }

        void radRichTextEditor1_ProviderUILayerInitialized(object sender, ProviderUILayerInitilizedEventArgs e)
        {
            if (e.Layer.Name == "PagesLayer")
            {
                foreach (Telerik.WinControls.RichTextEditor.UI.UIElement element in e.Container.Children)
                {
                    element.BackColor = Telerik.WinControls.RichTextEditor.UI.Colors.White;
                }

                List<RadElement> headerFooters = this.radRichTextEditor1.RichTextBoxElement.GetDescendants(delegate(RadElement x) { return x is Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer; }, TreeTraversalMode.BreadthFirst);
                foreach (Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer container in headerFooters)
                {
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255);
                }
            }
        }

        private RadDocument LoadDocumentToInsert()
        {
            RadDocument document = null;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word Documents (*.docx)|*.docx|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string extension;

                extension = Path.GetExtension(ofd.SafeFileName).ToLower();
                IDocumentFormatProvider provider = DocumentFormatProvidersManager.GetProviderByExtension(extension);

                using (Stream stream = ofd.OpenFile())
                {
                    document = provider.Import(stream);
                }
            }

            return document;
        }

        private RadDocument LoadFile(string file)
        {
            DocumentFormatProviderBase provider = new DocxFormatProvider();
            RadDocument document = null;

            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream("RichTextEditor.SampleDocuments." + file))
            {
                document = provider.Import(stream);
            }

            return document;
        }

        private void InsertFragmentFromDocument(RadDocument document)
        {
            if (document != null)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    this.radRichTextEditor1.InsertSectionBreak(SectionBreakType.NextPage);
                }

                document.Selection.SelectAll();
                DocumentFragment frag = new DocumentFragment(document.Selection);
                radRichTextEditor1.InsertFragment(frag);

                CopySectionProperties(document, radRichTextEditor1.Document);
            }
        }

        private static void CopySectionProperties(RadDocument fromDocument, RadDocument toDocument)
        {
            CopyHeaderAndFooter(fromDocument, toDocument);

            RadDocumentEditor documentEditor = new RadDocumentEditor(toDocument);
            documentEditor.Document.CaretPosition.MoveToLastPositionInDocument();

            documentEditor.ChangeSectionPageOrientation(fromDocument.Sections.Last.PageOrientation);
            documentEditor.ChangeSectionPageSize(fromDocument.Sections.Last.PageSize);
            documentEditor.ChangeSectionPageMargin(fromDocument.Sections.Last.PageMargin);
            documentEditor.ChangeSectionFooterBottomMargin(fromDocument.Sections.Last.FooterBottomMargin);
            documentEditor.ChangeSectionHeaderTopMargin(fromDocument.Sections.Last.HeaderTopMargin);
        }

        private static void CopyHeaderAndFooter(RadDocument fromDocument, RadDocument toDocument)
        {
            RadDocumentEditor documentEditor = new RadDocumentEditor(toDocument);

            documentEditor.ChangeSectionHeaderLinkToPrevious(documentEditor.Document.Sections.Last, HeaderFooterType.Default, false);
            if (!fromDocument.Sections.First.Headers.Default.IsEmpty)
            {
                documentEditor.ChangeSectionHeader(documentEditor.Document.Sections.Last, HeaderFooterType.Default, fromDocument.Sections.Last.Headers.Default);
            }

            documentEditor.ChangeSectionFooterLinkToPrevious(documentEditor.Document.Sections.Last, HeaderFooterType.Default, false);
            if (!fromDocument.Sections.First.Footers.Default.IsEmpty)
            {
                documentEditor.ChangeSectionFooter(documentEditor.Document.Sections.Last, HeaderFooterType.Default, fromDocument.Sections.Last.Footers.Default);
            }
        }

        private void browseMenuItem_Click(object sender, EventArgs e)
        {
            InsertFragmentFromDocument(LoadDocumentToInsert());
        }

        private void loadDocument2_Click(object sender, EventArgs e)
        {
            InsertFragmentFromDocument(LoadFile("sampleDoc.docx"));
        }

        private void loadDocument1_Click(object sender, EventArgs e)
        {
            InsertFragmentFromDocument(LoadFile("overview.docx"));
        }

        private void clearDocument_Click(object sender, EventArgs e)
        {
            isFirst = true;
            this.radRichTextEditor1.Document = new RadDocument();
        }
    }
}
