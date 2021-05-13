using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;

namespace Telerik.Examples.WinControls.RichTextEditor.RepeatHeaderRows
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            this.StartWaiting();

            InitializeComponent();
            this.richTextEditorRibbonBar1.CloseButton = false;
            this.richTextEditorRibbonBar1.MaximizeButton = false;
            this.richTextEditorRibbonBar1.MinimizeButton = false;
            this.richTextEditorRibbonBar1.RibbonBarElement.Text = "Repeat Header Rows";

            var provider = new DocxFormatProvider();
            radRichTextEditor1.Document = provider.Import(File.ReadAllBytes(@"..\RichTextEditor\RepeatHeaderRows\SampleData\RepeatHeaderRows.docx"));
           
            this.radRichTextEditor1.ProviderUILayerInitialized += radRichTextEditor1_ProviderUILayerInitialized;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.StopWaiting();
        }

        private void radRichTextEditor1_ProviderUILayerInitialized(object sender, ProviderUILayerInitilizedEventArgs e)
        {
            if (e.Layer.Name == "PagesLayer")
            {
                foreach (Telerik.WinControls.RichTextEditor.UI.UIElement element in e.Container.Children)
                {
                    element.BackColor = Colors.White;
                }
                List<RadElement> headerFooters = this.radRichTextEditor1.RichTextBoxElement.GetDescendants(delegate (RadElement x) { return x is HeaderFooterContainer; }, TreeTraversalMode.BreadthFirst);
                foreach (HeaderFooterContainer container in headerFooters)
                {
                    container.OverlayColor = System.Drawing.Color.White;
                }

            }
        }
    }
}
