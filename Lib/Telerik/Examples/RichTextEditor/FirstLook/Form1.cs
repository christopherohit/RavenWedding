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
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;
using Telerik.WinForms.Documents.FormatProviders.Txt;

namespace RichTextEditor.FirstLook
{
    public partial class Form1 : RadRibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            this.LoadFile("overview.docx");

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

        private void LoadFile(string file)
        {
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            DocumentFormatProviderBase provider = new DocxFormatProvider();

            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream("RichTextEditor.SampleDocuments." + file))
            {
                this.radRichTextEditor1.Document = provider.Import(stream);
            }
        }
    }
}
