namespace RichTextEditor.CommandBarUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.buttonPrint = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonSpellCheck = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonFindAndReplace = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.buttonCut = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonCopy = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonPaste = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.buttonUndo = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonRedo = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.dropDownListFont = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.dropDownListFontSize = new Telerik.WinControls.UI.CommandBarDropDownList();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.buttonForeColor = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonBackColor = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonClearFormatting = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.buttonInsertImage = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonInsertHyperlink = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator5 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.toggleButtonBold = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonItalic = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonUnderline = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonStrikethrough = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarSeparator6 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.toggleButtonAlignLeft = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonAlignCenter = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonAlignRight = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonJustify = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarSeparator7 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.buttonOutdent = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonIndent = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator8 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.toggleButtonBulletList = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonNumberedList = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.commandBarSeparator9 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.buttonInsertSymbol = new Telerik.WinControls.UI.CommandBarButton();
            this.buttonInsertTable = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator10 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.toggleButtonSubscript = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.toggleButtonSuperscript = new Telerik.WinControls.UI.CommandBarToggleButton();
            this.radRichTextEditorRuler1 = new Telerik.WinControls.UI.RadRichTextEditorRuler();
            this.radRichTextEditor1 = new Telerik.WinControls.UI.RadRichTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditorRuler1)).BeginInit();
            this.radRichTextEditorRuler1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1,
            this.commandBarRowElement2});
            this.radCommandBar1.Size = new System.Drawing.Size(769, 60);
            this.radCommandBar1.TabIndex = 0;
            this.radCommandBar1.Text = "radCommandBar1";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.buttonPrint,
            this.buttonSpellCheck,
            this.buttonFindAndReplace,
            this.commandBarSeparator1,
            this.buttonCut,
            this.buttonCopy,
            this.buttonPaste,
            this.commandBarSeparator2,
            this.buttonUndo,
            this.buttonRedo,
            this.commandBarSeparator3,
            this.dropDownListFont,
            this.dropDownListFontSize,
            this.commandBarSeparator4,
            this.buttonForeColor,
            this.buttonBackColor,
            this.buttonClearFormatting});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // buttonPrint
            // 
            this.buttonPrint.AccessibleDescription = "Print";
            this.buttonPrint.AccessibleName = "Print";
            this.buttonPrint.DisplayName = "commandBarButton1";
            this.buttonPrint.Image = global::RichTextEditor.Properties.Resources.print16;
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Text = "Print";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSpellCheck
            // 
            this.buttonSpellCheck.AccessibleDescription = "Spell Check";
            this.buttonSpellCheck.AccessibleName = "Spell Check";
            this.buttonSpellCheck.DisplayName = "commandBarButton2";
            this.buttonSpellCheck.Image = global::RichTextEditor.Properties.Resources.EnableSpellCheck16;
            this.buttonSpellCheck.Name = "buttonSpellCheck";
            this.buttonSpellCheck.Text = "Spell Check";
            this.buttonSpellCheck.Click += new System.EventHandler(this.buttonSpellCheck_Click);
            // 
            // buttonFindAndReplace
            // 
            this.buttonFindAndReplace.AccessibleDescription = "Find And Replace";
            this.buttonFindAndReplace.AccessibleName = "Find And Replace";
            this.buttonFindAndReplace.DisplayName = "commandBarButton3";
            this.buttonFindAndReplace.Image = global::RichTextEditor.Properties.Resources.find16;
            this.buttonFindAndReplace.Name = "buttonFindAndReplace";
            this.buttonFindAndReplace.Text = "Find And Replace";
            this.buttonFindAndReplace.Click += new System.EventHandler(this.buttonFindAndReplace_Click);
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // buttonCut
            // 
            this.buttonCut.AccessibleDescription = "Cut";
            this.buttonCut.AccessibleName = "Cut";
            this.buttonCut.DisplayName = "commandBarButton4";
            this.buttonCut.Image = global::RichTextEditor.Properties.Resources.cut16;
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Text = "Cut";
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.AccessibleDescription = "Copy";
            this.buttonCopy.AccessibleName = "Copy";
            this.buttonCopy.DisplayName = "commandBarButton5";
            this.buttonCopy.Image = global::RichTextEditor.Properties.Resources.copy16;
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.AccessibleDescription = "Paste";
            this.buttonPaste.AccessibleName = "Paste";
            this.buttonPaste.DisplayName = "commandBarButton6";
            this.buttonPaste.Image = global::RichTextEditor.Properties.Resources.paste16;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2";
            this.commandBarSeparator2.AccessibleName = "commandBarSeparator2";
            this.commandBarSeparator2.DisplayName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // buttonUndo
            // 
            this.buttonUndo.AccessibleDescription = "Undo";
            this.buttonUndo.AccessibleName = "Undo";
            this.buttonUndo.DisplayName = "commandBarButton7";
            this.buttonUndo.Image = global::RichTextEditor.Properties.Resources.undo16;
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.AccessibleDescription = "Redo";
            this.buttonRedo.AccessibleName = "Redo";
            this.buttonRedo.DisplayName = "commandBarButton8";
            this.buttonRedo.Image = global::RichTextEditor.Properties.Resources.redo16;
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3";
            this.commandBarSeparator3.AccessibleName = "commandBarSeparator3";
            this.commandBarSeparator3.DisplayName = "commandBarSeparator3";
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // dropDownListFont
            // 
            this.dropDownListFont.DisplayName = "commandBarDropDownList1";
            this.dropDownListFont.DropDownAnimationEnabled = true;
            this.dropDownListFont.MaxDropDownItems = 0;
            this.dropDownListFont.MinSize = new System.Drawing.Size(220, 22);
            this.dropDownListFont.Name = "dropDownListFont";
            this.dropDownListFont.Text = "";
            // 
            // dropDownListFontSize
            // 
            this.dropDownListFontSize.DisplayName = "commandBarDropDownList2";
            this.dropDownListFontSize.DropDownAnimationEnabled = true;
            this.dropDownListFontSize.MaxDropDownItems = 0;
            this.dropDownListFontSize.MinSize = new System.Drawing.Size(90, 22);
            this.dropDownListFontSize.Name = "dropDownListFontSize";
            this.dropDownListFontSize.Text = "";
            // 
            // commandBarSeparator4
            // 
            this.commandBarSeparator4.AccessibleDescription = "commandBarSeparator4";
            this.commandBarSeparator4.AccessibleName = "commandBarSeparator4";
            this.commandBarSeparator4.DisplayName = "commandBarSeparator4";
            this.commandBarSeparator4.Name = "commandBarSeparator4";
            this.commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // buttonForeColor
            // 
            this.buttonForeColor.AccessibleDescription = "Fore Color";
            this.buttonForeColor.AccessibleName = "Fore Color";
            this.buttonForeColor.DisplayName = "commandBarButton9";
            this.buttonForeColor.Image = global::RichTextEditor.Properties.Resources.fontcolor16;
            this.buttonForeColor.Name = "buttonForeColor";
            this.buttonForeColor.Text = "Fore Color";
            this.buttonForeColor.Click += new System.EventHandler(this.buttonForeColor_Click);
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.AccessibleDescription = "Back Color";
            this.buttonBackColor.AccessibleName = "Back Color";
            this.buttonBackColor.DisplayName = "commandBarButton10";
            this.buttonBackColor.Image = global::RichTextEditor.Properties.Resources.highlight16;
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Text = "Back Color";
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // buttonClearFormatting
            // 
            this.buttonClearFormatting.AccessibleDescription = "Clear Formatting";
            this.buttonClearFormatting.AccessibleName = "Clear Formatting";
            this.buttonClearFormatting.DisplayName = "commandBarButton11";
            this.buttonClearFormatting.Image = global::RichTextEditor.Properties.Resources.ClearFormatting16;
            this.buttonClearFormatting.Name = "buttonClearFormatting";
            this.buttonClearFormatting.Text = "Clear Formatting";
            this.buttonClearFormatting.Click += new System.EventHandler(this.buttonClearFormatting_Click);
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement2});
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.buttonInsertImage,
            this.buttonInsertHyperlink,
            this.commandBarSeparator5,
            this.toggleButtonBold,
            this.toggleButtonItalic,
            this.toggleButtonUnderline,
            this.toggleButtonStrikethrough,
            this.commandBarSeparator6,
            this.toggleButtonAlignLeft,
            this.toggleButtonAlignCenter,
            this.toggleButtonAlignRight,
            this.toggleButtonJustify,
            this.commandBarSeparator7,
            this.buttonOutdent,
            this.buttonIndent,
            this.commandBarSeparator8,
            this.toggleButtonBulletList,
            this.toggleButtonNumberedList,
            this.commandBarSeparator9,
            this.buttonInsertSymbol,
            this.buttonInsertTable,
            this.commandBarSeparator10,
            this.toggleButtonSubscript,
            this.toggleButtonSuperscript});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            // 
            // buttonInsertImage
            // 
            this.buttonInsertImage.AccessibleDescription = "Insert Image";
            this.buttonInsertImage.AccessibleName = "Insert Image";
            this.buttonInsertImage.DisplayName = "commandBarButton12";
            this.buttonInsertImage.Image = global::RichTextEditor.Properties.Resources.picture16;
            this.buttonInsertImage.Name = "buttonInsertImage";
            this.buttonInsertImage.Text = "Insert Image";
            // 
            // buttonInsertHyperlink
            // 
            this.buttonInsertHyperlink.AccessibleDescription = "Insert Hyperlink";
            this.buttonInsertHyperlink.AccessibleName = "Insert Hyperlink";
            this.buttonInsertHyperlink.DisplayName = "commandBarButton13";
            this.buttonInsertHyperlink.Image = global::RichTextEditor.Properties.Resources.inserthyperlink16;
            this.buttonInsertHyperlink.Name = "buttonInsertHyperlink";
            this.buttonInsertHyperlink.Text = "Insert Hyperlink";
            // 
            // commandBarSeparator5
            // 
            this.commandBarSeparator5.AccessibleDescription = "commandBarSeparator5";
            this.commandBarSeparator5.AccessibleName = "commandBarSeparator5";
            this.commandBarSeparator5.DisplayName = "commandBarSeparator5";
            this.commandBarSeparator5.Name = "commandBarSeparator5";
            this.commandBarSeparator5.VisibleInOverflowMenu = false;
            // 
            // toggleButtonBold
            // 
            this.toggleButtonBold.AccessibleDescription = "Bold";
            this.toggleButtonBold.AccessibleName = "Bold";
            this.toggleButtonBold.DisplayName = "commandBarToggleButton1";
            this.toggleButtonBold.Image = global::RichTextEditor.Properties.Resources.bold16;
            this.toggleButtonBold.Name = "toggleButtonBold";
            this.toggleButtonBold.Text = "Bold";
            // 
            // toggleButtonItalic
            // 
            this.toggleButtonItalic.AccessibleDescription = "Italic";
            this.toggleButtonItalic.AccessibleName = "Italic";
            this.toggleButtonItalic.DisplayName = "commandBarToggleButton2";
            this.toggleButtonItalic.Image = global::RichTextEditor.Properties.Resources.italic16;
            this.toggleButtonItalic.Name = "toggleButtonItalic";
            this.toggleButtonItalic.Text = "Italic";
            // 
            // toggleButtonUnderline
            // 
            this.toggleButtonUnderline.AccessibleDescription = "Underline";
            this.toggleButtonUnderline.AccessibleName = "Underline";
            this.toggleButtonUnderline.DisplayName = "commandBarToggleButton3";
            this.toggleButtonUnderline.Image = global::RichTextEditor.Properties.Resources.underline16;
            this.toggleButtonUnderline.Name = "toggleButtonUnderline";
            this.toggleButtonUnderline.Text = "Underline";
            // 
            // toggleButtonStrikethrough
            // 
            this.toggleButtonStrikethrough.AccessibleDescription = "Striketrough";
            this.toggleButtonStrikethrough.AccessibleName = "Striketrough";
            this.toggleButtonStrikethrough.DisplayName = "commandBarToggleButton4";
            this.toggleButtonStrikethrough.Image = global::RichTextEditor.Properties.Resources.Strikethrough16;
            this.toggleButtonStrikethrough.Name = "toggleButtonStrikethrough";
            this.toggleButtonStrikethrough.Text = "Striketrough";
            // 
            // commandBarSeparator6
            // 
            this.commandBarSeparator6.AccessibleDescription = "commandBarSeparator6";
            this.commandBarSeparator6.AccessibleName = "commandBarSeparator6";
            this.commandBarSeparator6.DisplayName = "commandBarSeparator6";
            this.commandBarSeparator6.Name = "commandBarSeparator6";
            this.commandBarSeparator6.VisibleInOverflowMenu = false;
            // 
            // toggleButtonAlignLeft
            // 
            this.toggleButtonAlignLeft.AccessibleDescription = "Left";
            this.toggleButtonAlignLeft.AccessibleName = "Left";
            this.toggleButtonAlignLeft.DisplayName = "commandBarToggleButton5";
            this.toggleButtonAlignLeft.Image = global::RichTextEditor.Properties.Resources.alignleft16;
            this.toggleButtonAlignLeft.Name = "toggleButtonAlignLeft";
            this.toggleButtonAlignLeft.Text = "Left";
            // 
            // toggleButtonAlignCenter
            // 
            this.toggleButtonAlignCenter.AccessibleDescription = "Center";
            this.toggleButtonAlignCenter.AccessibleName = "Center";
            this.toggleButtonAlignCenter.DisplayName = "commandBarToggleButton6";
            this.toggleButtonAlignCenter.Image = global::RichTextEditor.Properties.Resources.aligncenter16;
            this.toggleButtonAlignCenter.Name = "toggleButtonAlignCenter";
            this.toggleButtonAlignCenter.Text = "Center";
            // 
            // toggleButtonAlignRight
            // 
            this.toggleButtonAlignRight.AccessibleDescription = "Right";
            this.toggleButtonAlignRight.AccessibleName = "Right";
            this.toggleButtonAlignRight.DisplayName = "commandBarToggleButton7";
            this.toggleButtonAlignRight.Image = global::RichTextEditor.Properties.Resources.alignright16;
            this.toggleButtonAlignRight.Name = "toggleButtonAlignRight";
            this.toggleButtonAlignRight.Text = "Right";
            // 
            // toggleButtonJustify
            // 
            this.toggleButtonJustify.AccessibleDescription = "Justify";
            this.toggleButtonJustify.AccessibleName = "Justify";
            this.toggleButtonJustify.DisplayName = "commandBarToggleButton8";
            this.toggleButtonJustify.Image = global::RichTextEditor.Properties.Resources.alignjustify16;
            this.toggleButtonJustify.Name = "toggleButtonJustify";
            this.toggleButtonJustify.Text = "Justify";
            // 
            // commandBarSeparator7
            // 
            this.commandBarSeparator7.AccessibleDescription = "commandBarSeparator7";
            this.commandBarSeparator7.AccessibleName = "commandBarSeparator7";
            this.commandBarSeparator7.DisplayName = "commandBarSeparator7";
            this.commandBarSeparator7.Name = "commandBarSeparator7";
            this.commandBarSeparator7.VisibleInOverflowMenu = false;
            // 
            // buttonOutdent
            // 
            this.buttonOutdent.AccessibleDescription = "Outdent";
            this.buttonOutdent.AccessibleName = "Outdent";
            this.buttonOutdent.DisplayName = "commandBarButton14";
            this.buttonOutdent.Image = global::RichTextEditor.Properties.Resources.outdent16;
            this.buttonOutdent.Name = "buttonOutdent";
            this.buttonOutdent.Text = "Outdent";
            // 
            // buttonIndent
            // 
            this.buttonIndent.AccessibleDescription = "Indent";
            this.buttonIndent.AccessibleName = "Indent";
            this.buttonIndent.DisplayName = "commandBarButton15";
            this.buttonIndent.Image = global::RichTextEditor.Properties.Resources.indent16;
            this.buttonIndent.Name = "buttonIndent";
            this.buttonIndent.Text = "Indent";
            // 
            // commandBarSeparator8
            // 
            this.commandBarSeparator8.AccessibleDescription = "commandBarSeparator8";
            this.commandBarSeparator8.AccessibleName = "commandBarSeparator8";
            this.commandBarSeparator8.DisplayName = "commandBarSeparator8";
            this.commandBarSeparator8.Name = "commandBarSeparator8";
            this.commandBarSeparator8.VisibleInOverflowMenu = false;
            // 
            // toggleButtonBulletList
            // 
            this.toggleButtonBulletList.AccessibleDescription = "Bullet list";
            this.toggleButtonBulletList.AccessibleName = "Bullet list";
            this.toggleButtonBulletList.DisplayName = "commandBarToggleButton9";
            this.toggleButtonBulletList.Image = global::RichTextEditor.Properties.Resources.list_bullets16;
            this.toggleButtonBulletList.Name = "toggleButtonBulletList";
            this.toggleButtonBulletList.Text = "Bullet list";
            // 
            // toggleButtonNumberedList
            // 
            this.toggleButtonNumberedList.AccessibleDescription = "Numbered list";
            this.toggleButtonNumberedList.AccessibleName = "Numbered list";
            this.toggleButtonNumberedList.DisplayName = "commandBarToggleButton10";
            this.toggleButtonNumberedList.Image = global::RichTextEditor.Properties.Resources.list_numbered16;
            this.toggleButtonNumberedList.Name = "toggleButtonNumberedList";
            this.toggleButtonNumberedList.Text = "Numbered list";
            // 
            // commandBarSeparator9
            // 
            this.commandBarSeparator9.AccessibleDescription = "commandBarSeparator9";
            this.commandBarSeparator9.AccessibleName = "commandBarSeparator9";
            this.commandBarSeparator9.DisplayName = "commandBarSeparator9";
            this.commandBarSeparator9.Name = "commandBarSeparator9";
            this.commandBarSeparator9.VisibleInOverflowMenu = false;
            // 
            // buttonInsertSymbol
            // 
            this.buttonInsertSymbol.AccessibleDescription = "Insert Symbol";
            this.buttonInsertSymbol.AccessibleName = "Insert Symbol";
            this.buttonInsertSymbol.DisplayName = "commandBarButton16";
            this.buttonInsertSymbol.Image = global::RichTextEditor.Properties.Resources.symbol16;
            this.buttonInsertSymbol.Name = "buttonInsertSymbol";
            this.buttonInsertSymbol.Text = "Insert Symbol";
            // 
            // buttonInsertTable
            // 
            this.buttonInsertTable.AccessibleDescription = "Insert Table";
            this.buttonInsertTable.AccessibleName = "Insert Table";
            this.buttonInsertTable.DisplayName = "commandBarButton17";
            this.buttonInsertTable.Image = global::RichTextEditor.Properties.Resources.InsertTable16;
            this.buttonInsertTable.Name = "buttonInsertTable";
            this.buttonInsertTable.Text = "Insert Table";
            // 
            // commandBarSeparator10
            // 
            this.commandBarSeparator10.AccessibleDescription = "commandBarSeparator10";
            this.commandBarSeparator10.AccessibleName = "commandBarSeparator10";
            this.commandBarSeparator10.DisplayName = "commandBarSeparator10";
            this.commandBarSeparator10.Name = "commandBarSeparator10";
            this.commandBarSeparator10.VisibleInOverflowMenu = false;
            // 
            // toggleButtonSubscript
            // 
            this.toggleButtonSubscript.AccessibleDescription = "Subscript";
            this.toggleButtonSubscript.AccessibleName = "Subscript";
            this.toggleButtonSubscript.DisplayName = "commandBarToggleButton11";
            this.toggleButtonSubscript.Image = global::RichTextEditor.Properties.Resources.subscript16;
            this.toggleButtonSubscript.Name = "toggleButtonSubscript";
            this.toggleButtonSubscript.Text = "Subscript";
            // 
            // toggleButtonSuperscript
            // 
            this.toggleButtonSuperscript.AccessibleDescription = "Superscript";
            this.toggleButtonSuperscript.AccessibleName = "Superscript";
            this.toggleButtonSuperscript.DisplayName = "commandBarToggleButton12";
            this.toggleButtonSuperscript.Image = global::RichTextEditor.Properties.Resources.superscript16;
            this.toggleButtonSuperscript.Name = "toggleButtonSuperscript";
            this.toggleButtonSuperscript.Text = "Superscript";
            // 
            // radRichTextEditorRuler1
            // 
            this.radRichTextEditorRuler1.AssociatedRichTextBox = this.radRichTextEditor1;
            this.radRichTextEditorRuler1.Controls.Add(this.radRichTextEditor1);
            this.radRichTextEditorRuler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRichTextEditorRuler1.Location = new System.Drawing.Point(0, 60);
            this.radRichTextEditorRuler1.Name = "radRichTextEditorRuler1";
            this.radRichTextEditorRuler1.Size = new System.Drawing.Size(769, 593);
            this.radRichTextEditorRuler1.TabIndex = 1;
            this.radRichTextEditorRuler1.Text = "radRichTextEditorRuler1";
            // 
            // radRichTextEditor1
            // 
            this.radRichTextEditor1.IsSelectionMiniToolBarEnabled = false;
            this.radRichTextEditor1.Location = new System.Drawing.Point(29, 29);
            this.radRichTextEditor1.Name = "radRichTextEditor1";
            this.radRichTextEditor1.Size = new System.Drawing.Size(739, 563);
            this.radRichTextEditor1.TabIndex = 0;
            this.radRichTextEditor1.Text = "radRichTextEditor1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 653);
            this.Controls.Add(this.radRichTextEditorRuler1);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "CommandBar UI";
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditorRuler1)).EndInit();
            this.radRichTextEditorRuler1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRichTextEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton buttonPrint;
        private Telerik.WinControls.UI.CommandBarButton buttonSpellCheck;
        private Telerik.WinControls.UI.CommandBarButton buttonFindAndReplace;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarButton buttonCut;
        private Telerik.WinControls.UI.CommandBarButton buttonCopy;
        private Telerik.WinControls.UI.CommandBarButton buttonPaste;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarButton buttonUndo;
        private Telerik.WinControls.UI.CommandBarButton buttonRedo;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.CommandBarDropDownList dropDownListFont;
        private Telerik.WinControls.UI.CommandBarDropDownList dropDownListFontSize;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator4;
        private Telerik.WinControls.UI.CommandBarButton buttonForeColor;
        private Telerik.WinControls.UI.CommandBarButton buttonBackColor;
        private Telerik.WinControls.UI.CommandBarButton buttonClearFormatting;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton buttonInsertImage;
        private Telerik.WinControls.UI.CommandBarButton buttonInsertHyperlink;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator5;
        private Telerik.WinControls.UI.RadRichTextEditorRuler radRichTextEditorRuler1;
        private Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonBold;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonItalic;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonUnderline;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonStrikethrough;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator6;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonAlignLeft;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonAlignCenter;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonAlignRight;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonJustify;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator7;
        private Telerik.WinControls.UI.CommandBarButton buttonOutdent;
        private Telerik.WinControls.UI.CommandBarButton buttonIndent;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator8;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonBulletList;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonNumberedList;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator9;
        private Telerik.WinControls.UI.CommandBarButton buttonInsertSymbol;
        private Telerik.WinControls.UI.CommandBarButton buttonInsertTable;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator10;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonSubscript;
        private Telerik.WinControls.UI.CommandBarToggleButton toggleButtonSuperscript;
    }
}