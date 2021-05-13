using System;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.Xaml;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.References
{
    public partial class Form1 : RadRibbonForm
    {
        private const string FootnoteDocumentPath = "ReferencesFootnote.xaml";
        private const string EndnoteDocumentPath = "ReferencesEndnote.xaml";
        private const string BibliographyDocumentPath = "ReferencesBibliography.xaml";

        public Form1()
        {
            InitializeComponent();

            RibbonTab referencesTab = (RibbonTab)this.richTextEditorRibbonBar1.CommandTabs[3];

            RadRibbonBarButtonGroup group = new RadRibbonBarButtonGroup();
            group.Orientation = Orientation.Vertical;
            group.ShowBackColor = false;
            group.ShowBorder = false;

            group.Items.Add(this.CreateButton("Footnotes", LoadFootnotes));
            group.Items.Add(this.CreateButton("EndNotes", LoadEndnotes));
            group.Items.Add(this.CreateButton("Citations && Bibliography", LoadBibliography));

            referencesTab.Items.Add(group);

            RadRibbonBarGroup ribbonGroup = new RadRibbonBarGroup();
            ribbonGroup.Orientation = System.Windows.Forms.Orientation.Vertical;
            ribbonGroup.Text = "Load document";
            ribbonGroup.Items.Add(group);

            referencesTab.Items.Insert(0, ribbonGroup);

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

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

                System.Collections.Generic.List<RadElement> headerFooters = this.radRichTextEditor1.RichTextBoxElement.GetDescendants(delegate(RadElement x) { return x is HeaderFooterContainer; }, TreeTraversalMode.BreadthFirst);
                foreach (HeaderFooterContainer container in headerFooters)
                {
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadDocument(FootnoteDocumentPath);
        }

        private RadButtonElement CreateButton(string text, EventHandler OnClick)
        {
            RadButtonElement button = new RadButtonElement();
            button.DisplayStyle = DisplayStyle.Text;
            button.MinSize = new System.Drawing.Size(20, 20);
            button.Text = text;
            button.ShowBorder = false;
            button.Click += OnClick;

            return button;
        }

        private void LoadFootnotes(object sender, EventArgs e)
        {
            LoadDocument(FootnoteDocumentPath);
        }

        private void LoadEndnotes(object sender, EventArgs e)
        {
            LoadDocument(EndnoteDocumentPath);
        }

        private void LoadBibliography(object sender, EventArgs e)
        {
            LoadDocument(BibliographyDocumentPath);
        }

        private void LoadDocument(string path)
        {
            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(String.Format("RichTextEditor.SampleDocuments.{0}", path)))
            {
                this.radRichTextEditor1.Document = new XamlFormatProvider().Import(stream);
            }
            
            this.UpdateHeaderImage();
            this.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = this.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.Items[3];
        }

        private void UpdateHeaderImage()
        {
            RadDocument document = new RadDocument();
            Section section = new Section();
            Paragraph paragraph = new Paragraph();
            ImageInline image;
            Telerik.WinControls.RichTextEditor.UI.Size size = new Telerik.WinControls.RichTextEditor.UI.Size(375, 37);
            using (MemoryStream ms = new MemoryStream())
            {                
                RichTextEditor.Properties.Resources.winforms.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                image = new ImageInline(ms, size, "png");
            }

            paragraph.Inlines.Add(image);
            section.Children.Add(paragraph);
            document.Sections.Add(section);
            Header header = new Header()
            {
                Body = document,
                IsLinkedToPrevious = false
            };
            this.radRichTextEditor1.UpdateHeader(this.radRichTextEditor1.Document.Sections.First, HeaderFooterType.Default, header);
        }
    }
}
