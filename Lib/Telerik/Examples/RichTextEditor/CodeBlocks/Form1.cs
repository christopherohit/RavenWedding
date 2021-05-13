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
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.FormatProviders.Xaml;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.Documents.Model.Code;
using Telerik.WinForms.Documents.Model.Styles;

namespace RichTextEditor.CodeBlocks
{
    public partial class Form1 : RadRibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            this.LoadFile("CodeBlocks.xaml");

            this.AdjustRibbon();

            this.AddTagger(this.radRichTextEditor1.Document);
        }

        private void AdjustRibbon()
        {
            RadItem codeButton = ((RadRibbonBarGroup)(((RibbonTab)(this.richTextEditorRibbonBar1.CommandTabs[1])).Items[6])).Items[2];
            codeButton.Text = "Code";

            RadRibbonBarGroup newGroup = new RadRibbonBarGroup();

            newGroup.Text = "Insert";
            RibbonTab homeTab = ((RibbonTab)this.richTextEditorRibbonBar1.CommandTabs[0]);
            homeTab.Items.RemoveAt(homeTab.Items.Count - 1);
            homeTab.Items.RemoveAt(homeTab.Items.Count - 1);
            homeTab.Items.Add(newGroup);
            newGroup.Items.Add(codeButton);

        }

        private void LoadFile(string file)
        {
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            DocumentFormatProviderBase provider = new XamlFormatProvider();

            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream("RichTextEditor.SampleDocuments." + file))
            {
                this.radRichTextEditor1.RichTextBoxElement.Document = provider.Import(stream);
                this.radRichTextEditor1.RichTextBoxElement.Document.CaretPosition.MoveToLastPositionInDocument();
            }

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

        private void AddTagger(RadDocument document)
        {
            CodeLanguage vbCodeLanguage = new CodeLanguage("VB");

            RegexTagger vbRegexTagger = GetVbTagger();

            document.CodeFormatter.RegisterCodeLanguage(vbCodeLanguage, vbRegexTagger);

            StyleDefinition vbKeywordStyle = new StyleDefinition("vbKeywordStyle", StyleType.Character);
            vbKeywordStyle.SpanProperties.ForeColor = Colors.Orange;

            document.CodeFormatter.RegisterClassificationType(ClassificationTypes.Keyword, vbCodeLanguage, vbKeywordStyle);
        }

        private static RegexTagger GetVbTagger()
        {
            Regex keywordRegex = RegexTagger.GetKeywordsRegex(Keywords.Vb);
            Regex preprocessorRegex = new Regex(@"^\s*#.*$", RegexOptions.Multiline);
            Regex stringRegex = new Regex(DefaultRegexPatterns.StringPattern, RegexOptions.Multiline);
            Regex singleCommentRegex = new Regex(DefaultRegexPatterns.SingleLineCommentPattern, RegexOptions.Multiline);
            Regex multiLineCommentRegex = new Regex(DefaultRegexPatterns.MultilineCommentPattern, RegexOptions.Multiline);

            Dictionary<Regex, ClassificationType> collection = new Dictionary<Regex, ClassificationType>();
            collection.Add(keywordRegex, ClassificationTypes.Keyword);
            collection.Add(preprocessorRegex, ClassificationTypes.PreprocessorKeyword);
            collection.Add(stringRegex, ClassificationTypes.StringLiteral);
            collection.Add(singleCommentRegex, ClassificationTypes.Comment);
            collection.Add(multiLineCommentRegex, ClassificationTypes.Comment);

            RegexTagger regexVbTagger = new RegexTagger(collection);

            return regexVbTagger;
        }
    }
}
