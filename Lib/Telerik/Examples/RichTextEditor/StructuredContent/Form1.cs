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
using Telerik.WinForms.Documents.FormatProviders.Xaml;

namespace RichTextEditor.StructuredContent
{
    public partial class Form1 : RadRibbonForm
    {
        #region Fields

        private const string FirstDocumentPath =  "RichTextEditor.SampleDocuments.Recipe1.xaml";
        private const string SecondDocumentPath = "RichTextEditor.SampleDocuments.Recipe2.xaml";
        private const string ThirdDocumentPath =  "RichTextEditor.SampleDocuments.Recipe3.xaml";
        private const string ForthDocumentPath =  "RichTextEditor.SampleDocuments.Recipe4.xaml";
        private const int RefreshInterval = 1;

        private bool hasRadRichTextBoxChanged;

        #endregion

        #region Properties

        private DocumentInfo[] GetSampleDocumentsInfos()
        {
            return new DocumentInfo[] 
            {
                new DocumentInfo("Italian Salad", FirstDocumentPath),
                new DocumentInfo("Tiramisu Cake", SecondDocumentPath),
                new DocumentInfo("Pommes Frites", ThirdDocumentPath),
                new DocumentInfo("Italian Ravioli Soup",  ForthDocumentPath),
            };
        }
        
        #endregion

        public Form1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            AttachEvents();

            InitializeData();

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

        private void InitializeData()
        {
            this.hasRadRichTextBoxChanged = false;

            this.radListControl1.DataSource = GetSampleDocumentsInfos();
            this.radListControl1.DisplayMember = "Name";
            this.radListControl1.SelectedIndex = 0;

        }

        private void AttachEvents()
        {
            this.radListControl1.SelectedIndexChanged += listBox_documents_SelectionChanged;

            this.radPageViewMain.SelectedPageChanged += radPageView1_SelectedPageChanged;

            this.radRichTextEditor1.DocumentChanged += editor_DocumentChanged;
            this.radRichTextEditor1.DocumentContentChanged += Document_DocumentContentChanged;
        }

        void Document_DocumentContentChanged(object sender, EventArgs e)
        {
            this.hasRadRichTextBoxChanged = true;
        }

        void listBox_documents_SelectionChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.hasRadRichTextBoxChanged = false;

            DocumentInfo documentInfo = (DocumentInfo)this.radListControl1.SelectedValue;

            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(documentInfo.Path))
            {
                this.radRichTextEditor1.Document = new XamlFormatProvider().Import(stream);
            }

            this.radTextBox1.Text = new HRecipeFormatProvider().ExportCustomAnnotationsToHtml(this.radRichTextEditor1.Document);
            this.webBrowser1.DocumentText = this.radTextBox1.Text;
        }

        private void editor_DocumentChanged(object sender, EventArgs e)
        {
            this.radTextBox1.Text = new HRecipeFormatProvider().ExportCustomAnnotationsToHtml(this.radRichTextEditor1.Document);
        }

        void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (this.radPageViewMain.SelectedPage == pageViewPageHTML)
            {
                if (this.hasRadRichTextBoxChanged)
                {
                    this.radTextBox1.Text = new HRecipeFormatProvider().ExportCustomAnnotationsToHtml(this.radRichTextEditor1.Document);
                }
            }
            else if (this.radPageViewMain.SelectedPage == pageViewPagePreview)
            {
                if (this.hasRadRichTextBoxChanged == true)
                {
                    this.radTextBox1.Text = new HRecipeFormatProvider().ExportCustomAnnotationsToHtml(this.radRichTextEditor1.Document);
                }
                this.webBrowser1.DocumentText = this.radTextBox1.Text;
            }
        }
        
        #endregion
    }
}
