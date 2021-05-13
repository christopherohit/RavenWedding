using RichTextEditor.SampleData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.Xaml;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.Documents.RichTextBoxCommands;

namespace RichTextEditor.MailMerge
{
    public partial class Form1 : RadRibbonForm
    {
        private const string SampleDocumentPath = "RadRichTextBoxMailMerge.xaml";

        public Form1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;
            PopulateListView();

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

        private void PopulateListView()
        {
            radListView1.Items.Add(this.CreateItem("female1.png", 0, "Maria Anders"));
            radListView1.Items.Add(this.CreateItem("female2.png", 4, "Anabela Domingues"));
            radListView1.Items.Add(this.CreateItem("female3.png", 5, "Anne Dodsworth"));
            radListView1.Items.Add(this.CreateItem("male1.png", 1, "Antonio Taqueria"));
            radListView1.Items.Add(this.CreateItem("male2.png", 2, "Thomas Hardy"));
            radListView1.Items.Add(this.CreateItem("male3.png", 3, "Martin Sommer"));
        }

        private ListViewDataItem CreateItem(string imageFileName, int index, string name)
        {
            ListViewDataItem item = new ListViewDataItem();
            item.Text = name;
            item.TextAlignment = ContentAlignment.MiddleCenter;
            item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            item.Image = Image.FromStream(typeof(Form1).Assembly.GetManifestResourceStream(String.Format("RichTextEditor.Images.{0}", imageFileName)));
            item.ImageAlignment = ContentAlignment.MiddleCenter;
            item.Tag = index;

            return item;
        }

        private void radListView1_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            this.radRichTextEditor1.Document.MailMergeDataSource.MoveToIndex((int)e.Item.Tag);
            this.radRichTextEditor1.UpdateAllFields(FieldDisplayMode.Result);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream(String.Format("RichTextEditor.SampleDocuments.{0}", SampleDocumentPath)))
            {
                this.radRichTextEditor1.Document = new XamlFormatProvider().Import(stream);
            }

            this.radRichTextEditor1.Document.MailMergeDataSource.ItemsSource = new ExamplesDataContext().MailMessageInfos;
            this.radRichTextEditor1.CommandExecuting += radRichTextEditor1_CommandExecuting;
            this.radRichTextEditor1.StreamFromUriResolving += radRichTextEditor1_StreamFromUriResolving;

            radListView1.SelectedIndex = 0;
            this.radRichTextEditor1.Document.MailMergeDataSource.MoveToIndex(0);
            this.radRichTextEditor1.UpdateAllFields(FieldDisplayMode.Result);
        }

        private void radRichTextEditor1_StreamFromUriResolving(object sender, StreamFromUriResolvingEventArgs e)
        {
            e.Stream = typeof(Form1).Assembly.GetManifestResourceStream(String.Format("RichTextEditor.Images.{0}", e.Uri));
        }

        private void radRichTextEditor1_CommandExecuting(object sender, Telerik.WinForms.Documents.RichTextBoxCommands.CommandExecutingEventArgs e)
        {
            if (e.Command is InsertFieldCommand && e.CommandParameter is MergeField)
            {
                string fieldName = (e.CommandParameter as MergeField).PropertyPath;

                if (fieldName.ToUpper() == "RECIPIENTPHOTO")
                {
                    e.Cancel = true;

                    MergeField mf = new MergeField();
                    mf.PropertyPath = fieldName;
                    IncludePictureField picField = new IncludePictureField();
                    picField.SetPropertyValue(IncludePictureField.ImageUriProperty, mf);
                    this.radRichTextEditor1.InsertField(picField);
                }
            }
        }
    }
}
