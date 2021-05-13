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
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.Model;
using Size = Telerik.WinControls.RichTextEditor.UI.Size;
namespace RichTextEditor.DocumentAPI
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName;

            CreateDocument();

            this.radRichTextEditor1.Commands.ToggleBoldCommand.ToggleStateChanged += new EventHandler<Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs<bool>>(ToggleBoldCommand_ToggleStateChanged);
            this.radRichTextEditor1.Commands.ToggleItalicCommand.ToggleStateChanged += new EventHandler<Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs<bool>>(ToggleItalicCommand_ToggleStateChanged);
            this.radRichTextEditor1.Commands.ToggleUnderlineCommand.ToggleStateChanged += new EventHandler<Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs<bool>>(ToggleUnderlineCommand_ToggleStateChanged);
        }

        private void CreateDocument()
        {
            RadDocument document = new RadDocument();
            Section section = new Section();

            Paragraph paragraph1 = new Paragraph();
            Stream stream = typeof(Form1).Assembly.GetManifestResourceStream("RichTextEditor.DocumentAPI.winforms.png");
            Size size = new Size(375, 37);
            ImageInline imageInline = new ImageInline(stream, size, "png");
            paragraph1.Inlines.Add(imageInline);
            paragraph1.SpacingBefore = 10;
            paragraph1.LeftIndent = 10;
            section.Blocks.Add(paragraph1);

            Paragraph paragraph2 = new Paragraph();
            paragraph2.TextAlignment = Telerik.WinForms.Documents.Layout.RadTextAlignment.Center;
            Span span1 = new Span("Thank you for choosing Telerik");
            paragraph2.Inlines.Add(span1);

            Span span2 = new Span();
            span2.Text = " RadRichTextEditor!";
            span2.FontWeight = FontWeights.Bold;
            paragraph2.Inlines.Add(span2);
            section.Blocks.Add(paragraph2);

            Paragraph paragraph3 = new Paragraph();
            Span span3 = new Span("RadRichTextEditor");
            span3.FontWeight = FontWeights.Bold;
            paragraph3.Inlines.Add(span3);

            Span span4 = new Span(" is a control that is able to display and edit rich-text content including formatted text arranged in pages, paragraphs, spans (runs) etc.");
            paragraph3.Inlines.Add(span4);
            section.Blocks.Add(paragraph3);

            Table table = new Table();
            table.LayoutMode = TableLayoutMode.AutoFit;
            table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName;

            TableRow row1 = new TableRow();

            TableCell cell1 = new TableCell();
            Paragraph p1 = new Paragraph();
            Span s1 = new Span();
            s1.Text = "Cell 1";
            p1.Inlines.Add(s1);
            cell1.Blocks.Add(p1);
            row1.Cells.Add(cell1);

            TableCell cell2 = new TableCell();
            Paragraph p2 = new Paragraph();
            Span s2 = new Span();
            s2.Text = "Cell 2";
            p2.Inlines.Add(s2);
            cell2.Blocks.Add(p2);
            row1.Cells.Add(cell2);
            table.Rows.Add(row1);

            TableRow row2 = new TableRow();

            TableCell cell3 = new TableCell();
            cell3.ColumnSpan = 2;
            Paragraph p3 = new Paragraph();
            Span s3 = new Span();
            s3.Text = "Cell 3";
            p3.Inlines.Add(s3);
            cell3.Blocks.Add(p3);
            row2.Cells.Add(cell3);
            table.Rows.Add(row2);

            section.Blocks.Add(table);
            section.Blocks.Add(new Paragraph());
            document.Sections.Add(section);

            this.radRichTextEditor1.Document = document;

            this.radRichTextEditor1.ProviderUILayerInitialized += radRichTextEditor1_ProviderUILayerInitialized;
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();

            this.SetImages();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.SetImages();
        }

        private void SetImages()
        {
            if (this.commandBarToggleButtonBold == null)
            {
                return;
            }

            if (TelerikHelper.IsDarkTheme(this.ThemeName))
            {
                if (this.commandBarToggleButtonBold.Tag == null)
                {
                    this.commandBarToggleButtonBold.Tag = this.commandBarToggleButtonBold.Image;
                    this.commandBarToggleButtonItalic.Tag = this.commandBarToggleButtonItalic.Image;
                    this.commandBarToggleButtonUnderline.Tag = this.commandBarToggleButtonUnderline.Image;
                }

                this.commandBarToggleButtonBold.Image = ImageHelper.ChangeImagePixels(this.commandBarToggleButtonBold.Image, System.Drawing.Color.White);
                this.commandBarToggleButtonItalic.Image = ImageHelper.ChangeImagePixels(this.commandBarToggleButtonItalic.Image, System.Drawing.Color.White);
                this.commandBarToggleButtonUnderline.Image = ImageHelper.ChangeImagePixels(this.commandBarToggleButtonUnderline.Image, System.Drawing.Color.White);
            }
            else if (this.commandBarToggleButtonBold.Tag != null)
            {
                this.commandBarToggleButtonBold.Image = (System.Drawing.Image)(this.commandBarToggleButtonBold.Tag);
                this.commandBarToggleButtonItalic.Image = (System.Drawing.Image)(this.commandBarToggleButtonItalic.Tag);
                this.commandBarToggleButtonUnderline.Image = (System.Drawing.Image)(this.commandBarToggleButtonUnderline.Tag);
            }
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

        bool suspendToggleEvents = false;

        private void BoldButton_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs e)
        {
            if (suspendToggleEvents)
            {
                return;
            }

            this.radRichTextEditor1.ToggleBold();
            this.radRichTextEditor1.Focus();
        }

        private void ItalicButton_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs e)
        {
            if (suspendToggleEvents)
            {
                return;
            }

            this.radRichTextEditor1.ToggleItalic();
            this.radRichTextEditor1.Focus();
        }

        private void UnderlineButton_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs e)
        {
            if (suspendToggleEvents)
            {
                return;
            }

            this.radRichTextEditor1.ToggleUnderline();
            this.radRichTextEditor1.Focus();
        }

        void ToggleBoldCommand_ToggleStateChanged(object sender, Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs<bool> e)
        {
            suspendToggleEvents = true;
            commandBarToggleButtonBold.ToggleState = e.NewValue ? ToggleState.On : ToggleState.Off;
            suspendToggleEvents = false;
        }

        void ToggleUnderlineCommand_ToggleStateChanged(object sender, Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs<bool> e)
        {
            suspendToggleEvents = true;
            commandBarToggleButtonUnderline.ToggleState = e.NewValue ? ToggleState.On : ToggleState.Off;
            suspendToggleEvents = false;
        }

        void ToggleItalicCommand_ToggleStateChanged(object sender, Telerik.WinForms.Documents.RichTextBoxCommands.StylePropertyChangedEventArgs<bool> e)
        {
            suspendToggleEvents = true;
            commandBarToggleButtonItalic.ToggleState = e.NewValue ? ToggleState.On : ToggleState.Off;
            suspendToggleEvents = false;
        }
    }
}
