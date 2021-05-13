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
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.SearchHighlight
{
    public partial class Form1 : RadForm
    {
        private const string SampleDocumentPath = "RadRichTextBoxCustomizePresentation.xaml";

        RadDocument radDocument;
        CustomLayersBuilder customLayersBuilder;

        public Form1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            this.LoadRadDocument();
            this.customLayersBuilder = new CustomLayersBuilder() { HighlightCurrentWord = true, HighlightSearchResult = true };
            this.radRichTextEditor1.RichTextBoxElement.UILayersBuilder = this.customLayersBuilder;

            this.radRichTextEditor1.ProviderUILayerInitialized += radRichTextEditor1_ProviderUILayerInitialized;
        }

        void radRichTextEditor1_ProviderUILayerInitialized(object sender, ProviderUILayerInitilizedEventArgs e)
        {
            if (e.Layer.Name == "PagesLayer")
            {
                foreach (Telerik.WinControls.RichTextEditor.UI.UIElement element in e.Container.Children)
                {
                    element.BackColor = Colors.White;
                }

                List<RadElement> headerFooters = this.radRichTextEditor1.RichTextBoxElement.GetDescendants(delegate(RadElement x) { return x is HeaderFooterContainer; }, TreeTraversalMode.BreadthFirst);
                foreach (HeaderFooterContainer container in headerFooters)
                {
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255);
                }
            }
        }

        private void LoadRadDocument()
        {
            this.radDocument = this.ImportRadDocument(SampleDocumentPath);
            this.SetupNewDocument(this.radDocument);
            this.radRichTextEditor1.Document = this.radDocument;
        }

        private RadDocument ImportRadDocument(string radDocumentPath)
        {
            RadDocument currentRadDocument;
            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(String.Format("RichTextEditor.SampleDocuments.{0}", radDocumentPath)))
            {
                IDocumentFormatProvider xamlProvider = DocumentFormatProvidersManager.GetProviderByExtension(".xaml");
                currentRadDocument = xamlProvider.Import(stream);
            }

            return currentRadDocument;
        }

        private void RecreateUI()
        {
            if (this.radRichTextEditor1.RichTextBoxElement.ActiveEditorPresenter != null)
            {
                this.radRichTextEditor1.RichTextBoxElement.ActiveEditorPresenter.RecreateUI();
                this.radRichTextEditor1.UpdateEditorLayout();
            }
        }

        private void SetupNewDocument(RadDocument document)
        {
            document.LayoutMode = DocumentLayoutMode.Paged;
            document.ParagraphDefaultSpacingAfter = 10;
            document.SectionDefaultPageMargin = new Telerik.WinForms.Documents.Layout.Padding(40);
        }
        
        private void textToSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.customLayersBuilder.HighlightSearchResult)
            {
                HighlightSearchedWordLayer.Word = this.commandBarTextBox1.Text;
                this.radRichTextEditor1.UpdateEditorLayout();
            }
        }

        private void toggleButtonSearchResults_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.customLayersBuilder.HighlightSearchResult = this.toggleButtonSearchResults.CheckState == CheckState.Checked;
            this.RecreateUI();
        }

        private void toggleButtonCurrentWord_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.customLayersBuilder.HighlightCurrentWord = this.toggleButtonCurrentWord.CheckState == CheckState.Checked;
            this.RecreateUI();
        }
        
        private void toggleButtonCurrentLine_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.customLayersBuilder.HighlightCurrentLine = this.toggleButtonCurrentLine.CheckState == CheckState.Checked;
            this.RecreateUI();
        }
    }
}
