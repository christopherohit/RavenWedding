using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.Xaml;
using Telerik.WinForms.Documents.Model.Styles;

namespace RichTextEditor.StyleSheets
{
    public partial class Form1 : RadRibbonForm
    {        
        #region Constants

        private const string DefaultStyleSheetPath = "RichTextEditor.SampleDocuments.StyleSheetDefault.xaml";
        private const string CustomStyleSheetPath = "RichTextEditor.SampleDocuments.StyleSheetDemo.xaml";

        #endregion

        public Form1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            this.SetupRibbonBar();

            using (var stream = typeof(Form1).Assembly.GetManifestResourceStream("RichTextEditor.SampleDocuments.StyleSheetDemoDocument.xaml"))
            {
                this.radRichTextEditor1.Document = new XamlFormatProvider().Import(stream);
            }

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

        private void SetupRibbonBar()
        {
            RibbonTab homeTab = (RibbonTab)this.richTextEditorRibbonBar1.CommandTabs[0];
            homeTab.Items[0].Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            homeTab.Items[3].Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            RadRibbonBarGroup customStylesGroup = new RadRibbonBarGroup();
            customStylesGroup.StretchVertically = true;
            customStylesGroup.Text = "Load Styles";
            
            RadButtonElement defaultStyleButton = new RadButtonElement();
            defaultStyleButton.Text = "Load Default";
            defaultStyleButton.TextAlignment = ContentAlignment.MiddleLeft;
            defaultStyleButton.Padding = new System.Windows.Forms.Padding(2);
            defaultStyleButton.Click += loadDefaultStyleSheet_Click;

            RadButtonElement customStyleButton = new RadButtonElement();
            customStyleButton.Text = "Load Custom";
            customStyleButton.TextAlignment = ContentAlignment.MiddleLeft;
            customStyleButton.Padding = new System.Windows.Forms.Padding(2);
            customStyleButton.Click += loadCustomStyleSheet_Click;

            RadDropDownButtonElement externalStyleButton = new RadDropDownButtonElement();
            externalStyleButton.Text = "External Styles";
            externalStyleButton.TextAlignment = ContentAlignment.MiddleLeft;
            externalStyleButton.Padding = new System.Windows.Forms.Padding(2);
            
            RadMenuItem loadStyleSheetItem = new RadMenuItem("Load Style Sheet");
            loadStyleSheetItem.Click += LoadStyleSheet_Click;

            RadMenuItem saveStyleSheetItem = new RadMenuItem("Save Style Sheet");
            saveStyleSheetItem.Click += SaveStyleSheet_Click;

            externalStyleButton.Items.Add(loadStyleSheetItem);
            externalStyleButton.Items.Add(saveStyleSheetItem);

            RadRibbonBarButtonGroup group = new RadRibbonBarButtonGroup();
            group.Orientation = Orientation.Vertical;

            group.Items.Add(defaultStyleButton);
            group.Items.Add(customStyleButton);
            group.Items.Add(externalStyleButton);

            customStylesGroup.Items.Add(group);

            homeTab.Items.Insert(0, customStylesGroup);
        }

        private void LoadStyleSheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Xaml Files|*.xaml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var stream = ofd.OpenFile())
                {
                    Stylesheet stylesheet = XamlFormatProvider.LoadStylesheet(stream);
                    stylesheet.ApplyStylesheetToDocument(this.radRichTextEditor1.Document);
                }
            }
        }

        private void SaveStyleSheet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Xaml Files|*.xaml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var stream = sfd.OpenFile())
                {
                    Stylesheet stylesheet = new Stylesheet();
                    stylesheet.ExtractStylesheetFromDocument(this.radRichTextEditor1.Document);
                    XamlFormatProvider.SaveStylesheet(stylesheet, stream);
                }
            }
        }

        private void loadDefaultStyleSheet_Click(object sender, EventArgs e)
        {
            LoadStyleSheetFromResource(DefaultStyleSheetPath);
        }

        private void loadCustomStyleSheet_Click(object sender, EventArgs e)
        {
            LoadStyleSheetFromResource(CustomStyleSheetPath);
        }

        private void LoadStyleSheetFromResource(string rsourcePath)
        {
            using (var stream = typeof(Form1).Assembly.GetManifestResourceStream(rsourcePath))
            {
                Stylesheet stylesheet = XamlFormatProvider.LoadStylesheet(stream);
                stylesheet.ApplyStylesheetToDocument(this.radRichTextEditor1.Document);
            }
        }

        #endregion

    }
}
