using RichTextEditor.SampleData;
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
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.FormatProviders.Xaml;
using Telerik.WinForms.Documents.Model;

namespace RichTextEditor.DocumentProtection
{
    public partial class Form1 : RadRibbonForm
    {
        private const string SampleDocumentPath = "RadRichTextBoxProtection.xaml";
        RadDropDownListElement comboBoxLoggedUser;

        public Form1()
        {
            InitializeComponent();

            ExamplesDataContext dataContext = new ExamplesDataContext();

            this.radRichTextEditor1.Users = dataContext.Users;

            RibbonTab reviewTab = (RibbonTab)this.richTextEditorRibbonBar1.CommandTabs[this.richTextEditorRibbonBar1.CommandTabs.Count - 2];
            reviewTab.Items[0].Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            reviewTab.Items[1].Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            reviewTab.Items[2].Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            this.comboBoxLoggedUser = new RadDropDownListElement();
            ((RadRibbonBarGroup)reviewTab.Items.Last).Items.Add(this.comboBoxLoggedUser);
            this.comboBoxLoggedUser.DataSource = dataContext.CurrentUsers;
            this.comboBoxLoggedUser.DisplayMember = "RealName";
            this.comboBoxLoggedUser.SelectedIndex = 0;
            this.radRichTextEditor1.CurrentUser = this.comboBoxLoggedUser.SelectedValue as UserInfo;
            this.comboBoxLoggedUser.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.comboBoxLoggedUser.Alignment = ContentAlignment.MiddleCenter;
            this.comboBoxLoggedUser.SelectedValueChanged += comboBoxLoggedUser_SelectedValueChanged;

            LoadFile(SampleDocumentPath);
        }

        void comboBoxLoggedUser_SelectedValueChanged(object sender, Telerik.WinControls.UI.Data.ValueChangedEventArgs e)
        {
            this.radRichTextEditor1.CurrentUser = this.comboBoxLoggedUser.SelectedValue as UserInfo;
        }

        private void LoadFile(string file)
        {
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            DocumentFormatProviderBase provider = new XamlFormatProvider();

            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream("RichTextEditor.SampleDocuments." + file))
            {
                this.radRichTextEditor1.RichTextBoxElement.Document = provider.Import(stream);
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
    }
}
