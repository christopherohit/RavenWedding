using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.Xaml;

namespace Telerik.Examples.WinControls.RichTextEditor.SectionColumns
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
            this.richTextEditorRibbonBar1.RibbonBarElement.Text = "Section Columns";
            this.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = this.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.Items[2];

            var provider = new XamlFormatProvider();
            radRichTextEditor1.Document = provider.Import(File.ReadAllBytes(@"..\RichTextEditor\SectionColumns\SampleData\SectionColumns.xaml"));
          
            this.radRichTextEditor1.ProviderUILayerInitialized += radRichTextEditor1_ProviderUILayerInitialized;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.StopWaiting();
        }

        void radRichTextEditor1_ProviderUILayerInitialized(object sender, ProviderUILayerInitilizedEventArgs e)
        {
            if (e.Layer.Name == "PagesLayer")
            {
                foreach (UIElement element in e.Container.Children)
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
