using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders;
using Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx;
using Telerik.WinForms.Documents.Layout;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.Documents.RichTextBoxCommands;

namespace RichTextEditor.CommandBarUI
{
    public partial class Form1 : RadForm
    {
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
                    element.BackColor = Colors.White;
                }

                List<RadElement> headerFooters = this.radRichTextEditor1.RichTextBoxElement.GetDescendants(delegate(RadElement x) { return x is HeaderFooterContainer; }, TreeTraversalMode.BreadthFirst);
                foreach (HeaderFooterContainer container in headerFooters)
                {
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadFontFamilies();
            this.LoadFontSizes();

            this.LoadCurrentStyle();
            this.WireEvents();

            this.radRichTextEditor1.RichTextBoxElement.CurrentEditingStyleChanged += RichTextBoxElement_CurrentEditingStyleChanged;

            this.LoadFile("overview.docx");

            this.SetImages();
        }

        protected override void OnThemeChanged()
        {
            base.OnThemeChanged();

            this.SetImages();
        }

        private void LoadFile(string file)
        {
            DocumentFormatProviderBase provider = new DocxFormatProvider();

            using (Stream stream = typeof(Form1).Assembly.GetManifestResourceStream("RichTextEditor.SampleDocuments." + file))
            {
                this.radRichTextEditor1.RichTextBoxElement.Document = provider.Import(stream);
            }
        }

        private void SetImages()
        {
            if (this.toggleButtonBold == null)
            {
                return;
            }

            if (TelerikHelper.IsDarkTheme(this.ThemeName))
            {
                this.toggleButtonBold.Image = ImageHelper.ChangeImagePixels(this.toggleButtonBold.Image, System.Drawing.Color.White);
                this.toggleButtonItalic.Image = ImageHelper.ChangeImagePixels(this.toggleButtonItalic.Image, System.Drawing.Color.White);
                this.toggleButtonUnderline.Image = ImageHelper.ChangeImagePixels(this.toggleButtonUnderline.Image, System.Drawing.Color.White);
                this.toggleButtonStrikethrough.Image = ImageHelper.ChangeImagePixels(this.toggleButtonStrikethrough.Image, System.Drawing.Color.White);
                this.toggleButtonAlignLeft.Image = ImageHelper.ChangeImagePixels(this.toggleButtonAlignLeft.Image, System.Drawing.Color.White);
                this.toggleButtonAlignCenter.Image = ImageHelper.ChangeImagePixels(this.toggleButtonAlignCenter.Image, System.Drawing.Color.White);
                this.toggleButtonAlignRight.Image = ImageHelper.ChangeImagePixels(this.toggleButtonAlignRight.Image, System.Drawing.Color.White);
                this.toggleButtonJustify.Image = ImageHelper.ChangeImagePixels(this.toggleButtonJustify.Image, System.Drawing.Color.White);
                this.buttonOutdent.Image = ImageHelper.ChangeImagePixels(this.buttonOutdent.Image, System.Drawing.Color.White);
                this.buttonIndent.Image = ImageHelper.ChangeImagePixels(this.buttonIndent.Image, System.Drawing.Color.White);
                this.toggleButtonBulletList.Image = ImageHelper.ChangeImagePixels(this.toggleButtonBulletList.Image, System.Drawing.Color.White);
                this.toggleButtonNumberedList.Image = ImageHelper.ChangeImagePixels(this.toggleButtonNumberedList.Image, System.Drawing.Color.White);
                this.toggleButtonSubscript.Image = ImageHelper.ChangeImagePixels(this.toggleButtonSubscript.Image, System.Drawing.Color.White);
                this.toggleButtonSuperscript.Image = ImageHelper.ChangeImagePixels(this.toggleButtonSuperscript.Image, System.Drawing.Color.White);
            }
            else
            {
                this.toggleButtonBold.Image = global::RichTextEditor.Properties.Resources.bold16;
                this.toggleButtonItalic.Image = global::RichTextEditor.Properties.Resources.italic16;
                this.toggleButtonUnderline.Image = global::RichTextEditor.Properties.Resources.underline16;
                this.toggleButtonStrikethrough.Image = global::RichTextEditor.Properties.Resources.Strikethrough16;
                this.toggleButtonAlignLeft.Image = global::RichTextEditor.Properties.Resources.alignleft16;
                this.toggleButtonAlignCenter.Image = global::RichTextEditor.Properties.Resources.aligncenter16;
                this.toggleButtonAlignRight.Image = global::RichTextEditor.Properties.Resources.alignright16;
                this.toggleButtonJustify.Image = global::RichTextEditor.Properties.Resources.alignjustify16;
                this.buttonOutdent.Image = global::RichTextEditor.Properties.Resources.outdent16;
                this.buttonIndent.Image = global::RichTextEditor.Properties.Resources.indent16;
                this.toggleButtonBulletList.Image = global::RichTextEditor.Properties.Resources.list_bullets16;
                this.toggleButtonNumberedList.Image = global::RichTextEditor.Properties.Resources.list_numbered16;
                this.toggleButtonSubscript.Image = global::RichTextEditor.Properties.Resources.subscript16;
                this.toggleButtonSuperscript.Image = global::RichTextEditor.Properties.Resources.superscript16;
            }
        }

        private void RichTextBoxElement_CurrentEditingStyleChanged(object sender, EventArgs e)
        {
            this.UnwireEvents();
            this.LoadCurrentStyle();
            this.WireEvents();
        }

        private void LoadCurrentStyle()
        {
            StyleUIHelper helper = new StyleUIHelper(this.radRichTextEditor1.RichTextBoxElement);

            //Font
            Telerik.WinControls.RichTextEditor.UI.FontFamily family = helper.GetFontFamilyOfSpanStyle();

            if (family != null)
            {
                this.dropDownListFont.SelectedValue = family.Source;
            }

            //Font size         
            double? fontSize = helper.GetFontSizeOfSpanStyle();

            if (fontSize.HasValue)
            {
                int size = (int)Math.Round(Unit.DipToPoint(fontSize.Value));

                BindingList<int> sizes = this.dropDownListFontSize.DataSource as BindingList<int>;

                if (!sizes.Contains(size))
                {
                    int index = 0;

                    while (index < sizes.Count)
                    {
                        if (sizes[index] > size)
                        {
                            break;
                        }

                        index++;
                    }

                    sizes.Insert(index, size);
                }

                this.dropDownListFontSize.SelectedValue = size;
            }

            //Bold
            FontWeight? fontWeight = helper.GetFontWeightOfSpanStyle();

            if (fontWeight.HasValue)
            {
                this.toggleButtonBold.ToggleState = (fontWeight.Value.ToOpenTypeWeight() > 400) ? ToggleState.On : ToggleState.Off;
            }

            //Italic
            Telerik.WinControls.RichTextEditor.UI.FontStyle? fontStyle = helper.GetFontStyleOfSpanStyle();

            if (fontStyle.HasValue)
            {
                this.toggleButtonItalic.ToggleState = (fontStyle.Value != FontStyles.Normal) ? ToggleState.On : ToggleState.Off;
            }

            //Underline
            bool? underline = helper.GetUnderline();

            if (underline.HasValue)
            {
                this.toggleButtonUnderline.ToggleState = (underline.Value) ? ToggleState.On : ToggleState.Off;
            }

            //Striketrough
            bool? strikethrough = helper.GetStrikeThroughOfSpanStyle();

            if (strikethrough.HasValue)
            {
                this.toggleButtonStrikethrough.ToggleState = (strikethrough.Value) ? ToggleState.On : ToggleState.Off;
            }

            //Baseline alignment
            BaselineAlignment? baselineAlignment = helper.GetBaselineAlignment();

            if (baselineAlignment.HasValue)
            {
                this.toggleButtonSubscript.ToggleState = (baselineAlignment.Value == BaselineAlignment.Subscript) ? ToggleState.On : ToggleState.Off;
                this.toggleButtonSuperscript.ToggleState = (baselineAlignment.Value == BaselineAlignment.Superscript) ? ToggleState.On : ToggleState.Off;
            }

            //Bullets
            this.toggleButtonBulletList.ToggleState = (helper.GetIsBulleted()) ? ToggleState.On : ToggleState.Off;
            this.toggleButtonNumberedList.ToggleState = (helper.GetIsNumbered()) ? ToggleState.On : ToggleState.Off;

            //Text alignment
            Telerik.WinForms.Documents.Layout.RadTextAlignment? textAlignment = helper.GetTextAlignmentOfParagraphStyle();

            if (textAlignment.HasValue)
            {
                this.toggleButtonAlignLeft.ToggleState = (textAlignment.Value == RadTextAlignment.Left) ? ToggleState.On : ToggleState.Off;
                this.toggleButtonAlignCenter.ToggleState = (textAlignment.Value == RadTextAlignment.Center) ? ToggleState.On : ToggleState.Off;
                this.toggleButtonAlignRight.ToggleState = (textAlignment.Value == RadTextAlignment.Right) ? ToggleState.On : ToggleState.Off;
                this.toggleButtonJustify.ToggleState = (textAlignment.Value == RadTextAlignment.Justify) ? ToggleState.On : ToggleState.Off;
            }
        }

        private void LoadFontFamilies()
        {
            InstalledFontCollection font = new InstalledFontCollection();

            List<string> families = new List<string>();

            foreach (System.Drawing.FontFamily family in font.Families)
            {
                if (family.IsStyleAvailable(System.Drawing.FontStyle.Regular) &&
                    family.IsStyleAvailable(System.Drawing.FontStyle.Italic) &&
                    family.IsStyleAvailable(System.Drawing.FontStyle.Bold) &&
                    family.IsStyleAvailable(System.Drawing.FontStyle.Strikeout))
                {
                    families.Add(family.Name);
                }
            }

            this.dropDownListFont.ValueMember = "Name";
            this.dropDownListFont.DisplayMember = "Name";
            this.dropDownListFont.DataSource = families;
        }

        private void LoadFontSizes()
        {
            BindingList<int> sizes = new BindingList<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            this.dropDownListFontSize.DataSource = sizes;
        }

        private void WireEvents()
        {
            this.buttonInsertImage.Click += this.buttonInsertImage_Click;
            this.buttonInsertHyperlink.Click += this.buttonInsertHyperlink_Click;
            this.toggleButtonBold.ToggleStateChanged += this.toggleButtonBold_ToggleStateChanged;
            this.toggleButtonItalic.ToggleStateChanged += this.toggleButtonItalic_ToggleStateChanged;
            this.toggleButtonUnderline.ToggleStateChanged += this.toggleButtonUnderline_ToggleStateChanged;
            this.toggleButtonStrikethrough.ToggleStateChanged += this.toggleButtonStrikethrough_ToggleStateChanged;
            this.toggleButtonAlignLeft.ToggleStateChanged += this.toggleButtonAlignLeft_ToggleStateChanged;
            this.toggleButtonAlignCenter.ToggleStateChanged += this.toggleButtonAlignCenter_ToggleStateChanged;
            this.toggleButtonAlignRight.ToggleStateChanged += this.toggleButtonAlignRight_ToggleStateChanged;
            this.toggleButtonJustify.ToggleStateChanged += this.toggleButtonJustify_ToggleStateChanged;
            this.toggleButtonBulletList.ToggleStateChanged += this.toggleButtonBulletList_ToggleStateChanged;
            this.toggleButtonNumberedList.ToggleStateChanged += this.toggleButtonNumberedList_ToggleStateChanged;
            this.buttonOutdent.Click += this.buttonOutdent_Click;
            this.buttonIndent.Click += this.buttonIndent_Click;
            this.buttonInsertSymbol.Click += this.buttonInsertSymbol_Click;
            this.buttonInsertTable.Click += this.buttonInsertTable_Click;
            this.toggleButtonSubscript.ToggleStateChanged += this.toggleButtonSubscript_ToggleStateChanged;
            this.toggleButtonSuperscript.ToggleStateChanged += this.toggleButtonSuperscript_ToggleStateChanged;
            this.dropDownListFont.SelectedIndexChanged += this.dropDownListFont_SelectedIndexChanged;
            this.dropDownListFontSize.SelectedIndexChanged += this.dropDownListFontSize_SelectedIndexChanged;
        }

        private void UnwireEvents()
        {
            this.buttonInsertImage.Click -= this.buttonInsertImage_Click;
            this.buttonInsertHyperlink.Click -= this.buttonInsertHyperlink_Click;
            this.toggleButtonBold.ToggleStateChanged -= this.toggleButtonBold_ToggleStateChanged;
            this.toggleButtonItalic.ToggleStateChanged -= this.toggleButtonItalic_ToggleStateChanged;
            this.toggleButtonUnderline.ToggleStateChanged -= this.toggleButtonUnderline_ToggleStateChanged;
            this.toggleButtonStrikethrough.ToggleStateChanged -= this.toggleButtonStrikethrough_ToggleStateChanged;
            this.toggleButtonAlignLeft.ToggleStateChanged -= this.toggleButtonAlignLeft_ToggleStateChanged;
            this.toggleButtonAlignCenter.ToggleStateChanged -= this.toggleButtonAlignCenter_ToggleStateChanged;
            this.toggleButtonAlignRight.ToggleStateChanged -= this.toggleButtonAlignRight_ToggleStateChanged;
            this.toggleButtonJustify.ToggleStateChanged -= this.toggleButtonJustify_ToggleStateChanged;
            this.toggleButtonBulletList.ToggleStateChanged -= this.toggleButtonBulletList_ToggleStateChanged;
            this.toggleButtonNumberedList.ToggleStateChanged -= this.toggleButtonNumberedList_ToggleStateChanged;
            this.buttonOutdent.Click -= this.buttonOutdent_Click;
            this.buttonIndent.Click -= this.buttonIndent_Click;
            this.buttonInsertSymbol.Click -= this.buttonInsertSymbol_Click;
            this.buttonInsertTable.Click -= this.buttonInsertTable_Click;
            this.toggleButtonSubscript.ToggleStateChanged -= this.toggleButtonSubscript_ToggleStateChanged;
            this.toggleButtonSuperscript.ToggleStateChanged -= this.toggleButtonSuperscript_ToggleStateChanged;
            this.dropDownListFont.SelectedIndexChanged -= this.dropDownListFont_SelectedIndexChanged;
            this.dropDownListFontSize.SelectedIndexChanged -= this.dropDownListFontSize_SelectedIndexChanged;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintCommand command = new PrintCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonSpellCheck_Click(object sender, EventArgs e)
        {
            ShowSpellCheckingDialogCommand command = new ShowSpellCheckingDialogCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonFindAndReplace_Click(object sender, EventArgs e)
        {
            ShowFindReplaceDialogCommand command = new ShowFindReplaceDialogCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            CutCommand command = new CutCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyCommand command = new CopyCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            PasteCommand command = new PasteCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            UndoCommand command = new UndoCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            RedoCommand command = new RedoCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ChangeFontForeColorCommand command = new ChangeFontForeColorCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
                command.Execute((Telerik.WinControls.RichTextEditor.UI.Color)dialog.SelectedColor);
            }
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ChangeFontHighlightColorCommand command = new ChangeFontHighlightColorCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
                command.Execute((Telerik.WinControls.RichTextEditor.UI.Color)dialog.SelectedColor);
            }
        }

        private void buttonClearFormatting_Click(object sender, EventArgs e)
        {
            ClearFormattingCommand command = new ClearFormattingCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonInsertImage_Click(object sender, EventArgs e)
        {
            InsertPictureCommand command = new InsertPictureCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonInsertHyperlink_Click(object sender, EventArgs e)
        {
            ShowInsertHyperlinkDialogCommand command = new ShowInsertHyperlinkDialogCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonBold_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleBoldCommand command = new ToggleBoldCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonItalic_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleItalicCommand command = new ToggleItalicCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonUnderline_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleUnderlineCommand command = new ToggleUnderlineCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonStrikethrough_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleStrikethroughCommand command = new ToggleStrikethroughCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonAlignLeft_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
                command.Execute(RadTextAlignment.Left);
            }
        }

        private void toggleButtonAlignCenter_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
                command.Execute(RadTextAlignment.Center);
            }
        }

        private void toggleButtonAlignRight_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
                command.Execute(RadTextAlignment.Right);
            }
        }

        private void toggleButtonJustify_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
                command.Execute(RadTextAlignment.Justify);
            }
        }

        private void buttonOutdent_Click(object sender, EventArgs e)
        {
            DecrementParagraphLeftIndentCommand command = new DecrementParagraphLeftIndentCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonIndent_Click(object sender, EventArgs e)
        {
            IncrementParagraphLeftIndentCommand command = new IncrementParagraphLeftIndentCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonBulletList_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleBulletsCommand command = new ToggleBulletsCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonNumberedList_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleNumberedCommand command = new ToggleNumberedCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonInsertSymbol_Click(object sender, EventArgs e)
        {
            ShowInsertSymbolWindowCommand command = new ShowInsertSymbolWindowCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void buttonInsertTable_Click(object sender, EventArgs e)
        {
            ShowInsertTableDialogCommand command = new ShowInsertTableDialogCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonSubscript_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleSubscriptCommand command = new ToggleSubscriptCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void toggleButtonSuperscript_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleSuperscriptCommand command = new ToggleSuperscriptCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute();
        }

        private void dropDownListFont_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ChangeFontFamilyCommand command = new ChangeFontFamilyCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            command.Execute(this.dropDownListFont.SelectedText);
        }

        private void dropDownListFontSize_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ChangeFontSizeCommand command = new ChangeFontSizeCommand(this.radRichTextEditor1.RichTextBoxElement.ActiveEditor);
            double dip = Unit.PointToDip(double.Parse(this.dropDownListFontSize.SelectedValue.ToString()));
            command.Execute(dip);
        }
    }
}
