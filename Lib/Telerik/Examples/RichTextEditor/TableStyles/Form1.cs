using System;
using System.IO;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.Xaml;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.TableStyles
{
    public partial class Form1 : RadRibbonForm
    {
        private const string SampleDocumentPath = "TableStylesGalleryDemo.xaml";

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

                System.Collections.Generic.List<RadElement> headerFooters = this.radRichTextEditor1.RichTextBoxElement.GetDescendants(delegate(RadElement x) { return x is Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer; }, TreeTraversalMode.BreadthFirst);
                foreach (Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer container in headerFooters)
                {
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(String.Format("RichTextEditor.SampleDocuments.{0}", SampleDocumentPath)))
            {
                this.radRichTextEditor1.Document = new XamlFormatProvider().Import(stream);
            }

            Table table = this.radRichTextEditor1.Document.EnumerateChildrenOfType<Table>().FirstOrDefault();

            if (table != null)
            {
                this.radRichTextEditor1.Document.CaretPosition.MoveToStartOfDocumentElement(table);
            }
        }
    }
}
