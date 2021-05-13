using RichTextEditor.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.SyntaxHighlight
{
    public partial class Form1 : RadForm
    {
        #region Constants

        private static readonly string XamlResource = "SampleXAML.txt";
        private static readonly string CsResource = "SampleCS.txt";

        #endregion

        #region Fields

        private RadDocument XamlDocument;
        private RadDocument CsDocument;

        #endregion

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

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.commandBarDropDownList1.SelectedIndex = 0;

            this.SetImages();
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();

            this.SetImages();
        }

        private void commandBarDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 0)
            {
                this.LoadSampleXamlDocument();
            }
            else
            {
                this.LoadSampleCsDocument();
            }
        }

        private void SetImages()
        {
            if (this.commandBarToggleButton1 == null)
            {
                return;
            }

            if (TelerikHelper.IsDarkTheme(this.ThemeName))
            {
                if (this.commandBarToggleButton1.Tag == null)
                {
                    this.commandBarToggleButton1.Tag = this.commandBarToggleButton1.Image;
                }

                this.commandBarToggleButton1.Image = ImageHelper.ChangeImagePixels(this.commandBarToggleButton1.Image, System.Drawing.Color.White);
            }
            else if (this.commandBarToggleButton1.Tag != null)
            {
                this.commandBarToggleButton1.Image = (Image)this.commandBarToggleButton1.Tag;
            }
        }

        private void ToggleFormattingSymbols_Click(object sender, StateChangedEventArgs e)
        {
            this.radRichTextEditor1.ShowFormattingSymbols = this.commandBarToggleButton1.CheckState == CheckState.Checked;
        }

        private void LoadSampleXamlDocument()
        {
            if (this.XamlDocument == null)
            {
                Stream xamlStream = typeof(Form1).Assembly.GetManifestResourceStream(
                   "RichTextEditor.SampleDocuments." + XamlResource);

                using (StreamReader reader = new StreamReader(xamlStream))
                {
                    this.XamlDocument = CreateFormattedDocument(reader.ReadToEnd(), ".xaml");
                }
            }

            this.radRichTextEditor1.Document = this.XamlDocument;
        }

        private void LoadSampleCsDocument()
        {
            if (this.CsDocument == null)
            {
                Stream csStream = typeof(Form1).Assembly.GetManifestResourceStream(
                   "RichTextEditor.SampleDocuments." + CsResource);

                using (StreamReader reader = new StreamReader(csStream))
                {
                    this.CsDocument = CreateFormattedDocument(reader.ReadToEnd(), ".cs");
                }
            }

            this.radRichTextEditor1.Document = this.CsDocument;
        }

        private RadDocument CreateFormattedDocument(string text, string fileFormat)
        {
            RadDocument document = new RadDocument();
            document.LayoutMode = DocumentLayoutMode.Flow;
            document.SectionDefaultPageMargin = new Telerik.WinForms.Documents.Layout.Padding(25);

            Section section = new Section();
            document.Sections.Add(section);

            Tokenizer tokenizer = new Tokenizer();
            List<Token> tokens = tokenizer.TokenizeCode(text, fileFormat);

            Paragraph currentParagraph = new Paragraph();
            currentParagraph.SpacingAfter = 0;
            section.Blocks.Add(currentParagraph);
            foreach (Token token in tokens)
            {
                string[] lines = Regex.Split(token.Value, DocumentEnvironment.NewLine);

                bool createParagraph = false;
                foreach (string line in lines)
                {
                    if (createParagraph)
                    {
                        currentParagraph = new Paragraph();
                        currentParagraph.SpacingAfter = 0;
                        section.Blocks.Add(currentParagraph);
                    }
                    createParagraph = true;

                    if (!string.IsNullOrEmpty(line))
                    {
                        Span span = token.GetSpanStyle();
                        span.Text = line;
                        currentParagraph.Inlines.Add(span);
                    }
                }
            }

            return document;
        }

        #endregion

    }
}
