using RichTextEditor.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.Design;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.Documents.Model.BibliographicReferences;
using Telerik.WinForms.Documents.RichTextBoxCommands;
using Telerik.WinForms.RichTextEditor;
using Telerik.WinForms.RichTextEditor.RichTextBoxUI.Dialogs.Styles;

namespace RichTextEditorRibbonUI
{
    [Designer(DesignerConsts.RichTextEditorRibbonBarDesignerString)]
    [Description("Provides a ribbon-user interface containing most of the features RichTextEditor provides.")]
    [ToolboxItem(true)]
    public class RichTextEditorRibbonBar : RadRibbonBar
    {
        #region Consts

        private const string DefineNewListStyleText = "Define new list style...";
        private const string InsertCustomWatermarkText = "Insert custom watermark...";
        private const string RemoveWatermarkText = "Remove watermark";
        private const string NextFootnoteText = "Next Footnote";
        private const string PreviousFootnoteText = "Previous Footnote";
        private const string NextEndnoteText = "Next Endnote";
        private const string PreviousEndnoteText = "Previous Endnote";
        private const string AddNewCitationSourceText = "Add New Source...";
        private const string AcceptChangeText = "Accept and Move to Next";
        private const string AcceptAllChangesText = "Accept All Changes";
        private const string RejectChangeText = "Reject and Move to Next";
        private const string RejectAllChangesText = "Reject All Changes";

        #endregion

        #region Fields

        private RadRichTextEditor associatedRichTextEditor;
        private RadRichTextBox activeEditorCache;
        private RadDocument documentCache;
        private RadRichTextEditor styleSnapshotRichTextBox;
        private RadRichTextEditor listStyleSnapshotRichTextBox;
        private ObservableStyleCollection observableStyleCollection;
        private ObservableListStyleCollection observableListStyleCollection;
        private ObservableTableStyleCollection observableTableStyleCollection;

        private Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion builtInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013;

        private RibbonTab openTabCache;

        private RichTextEditorRibbonTab tabHome;
        private RichTextEditorRibbonTab tabInsert;
        private RichTextEditorRibbonTab tabPageLayout;
        private RichTextEditorRibbonTab tabReferences;
        private RichTextEditorRibbonTab tabMailings;
        private RichTextEditorRibbonTab tabReview;
        private RichTextEditorRibbonTab tabView;
        private ContextualTabGroup tabGroupTable;
        private RichTextEditorRibbonTab tabTableStyle;
        private RichTextEditorRibbonTab tabTableLayout;
        private ContextualTabGroup tabGroupHeaderAndFooter;
        private RichTextEditorRibbonTab tabHeaderFooter;

        #region Application button

        private RadRibbonBarBackstageView backstageView = new RadRibbonBarBackstageView();

        private BackstageButtonItem backstageButtonNew = new BackstageButtonItem();
        private BackstageButtonItem backstageButtonOpen = new BackstageButtonItem();
        private BackstageButtonItem backstageButtonPrint = new BackstageButtonItem();
        private BackstageButtonItem backstageButtonSave = new BackstageButtonItem();
        private BackstageTabItem backstageTabItemSaveAs = new BackstageTabItem();
        private BackstageViewPage backstageViewPageSaveAs = new BackstageViewPage();
        private CustomFlowLayoutPanel flp = new CustomFlowLayoutPanel();
        private RadButton buttonSaveWord = new RadButton();
        private RadButton buttonSavePDF = new RadButton();
        private RadButton buttonSaveHTML = new RadButton();
        private RadButton buttonSaveRich = new RadButton();
        private RadButton buttonSavePlain = new RadButton();
        private RadButton buttonXAML = new RadButton();

        #endregion

        #region Quick access toolbar

        private RadButtonElement buttonSave;
        private RadButtonElement buttonUndo;
        private RadButtonElement buttonRedo;

        #endregion

        #region Home tab

        #region Clipboard group

        private RadRibbonBarGroup groupClipboard;

        private RadButtonElement buttonCut;
        private RadButtonElement buttonCopy;
        private RadButtonElement buttonPaste;

        #endregion

        #region Font group

        private RadRibbonBarGroup groupFont;

        private RadRibbonBarButtonGroup ribbonButtonGroupFontFontSizeIncreaseDecreaseFont;

        private RadDropDownListElement dropDownListFont;
        private RadDropDownListElement dropDownListFontSize;

        private RadRibbonBarButtonGroup ribbonButtonGroupIncreaseDecreaseFont;
        private RadButtonElement buttonDecreaseFontSize;
        private RadButtonElement buttonIncreaseFontSize;

        private RadRibbonBarButtonGroup ribbonButtonGroupClearFormattingFontStylesFontColors;
        private RadRibbonBarButtonGroup ribbonButtonGroupClearFormatting;
        private RadButtonElement buttonClearFormatting;

        private RadRibbonBarButtonGroup ribbonButtonGroupFontStyles;
        private RadToggleButtonElement toggleButtonUnderlineStyle;
        private RadToggleButtonElement toggleButtonBoldStyle;
        private RadToggleButtonElement toggleButtonItalicStyle;
        private RadToggleButtonElement toggleButtonStrikethroughStyle;
        private RadToggleButtonElement toggleButtonSubscript;
        private RadToggleButtonElement toggleButtonSuperscript;

        private RadRibbonBarButtonGroup ribbonButtonGroupFontColors;
        private RadButtonElement buttonBackColor;
        private RadButtonElement buttonForeColor;

        #endregion

        #region Paragraph group

        private RadRibbonBarGroup groupParagraph;

        private RadRibbonBarButtonGroup ribbonButtonGroupBulletsIndentDirection;

        private RadRibbonBarButtonGroup ribbonButtonGroupBullets;
        private RadToggleButtonElement toggleButtonBulletedList;
        private RadToggleButtonElement toggleButtonNumberedList;
        private RadDropDownButtonElement buttonMultilevelList;

        private RadRibbonBarButtonGroup ribbonButtonGroupIndent;
        private RadButtonElement buttonDecreaseIndent;
        private RadButtonElement buttonIncreaseIndent;

        private RadRibbonBarButtonGroup ribbonButtonGroupDirection;
        private RadToggleButtonElement toggleButtonLeftToRightTextDirection;
        private RadToggleButtonElement toggleButtonRightToLeftTextDirection;

        private RadRibbonBarButtonGroup ribbonButtonGroupFormattingSymbolsTextAlignParagraphBackColor;

        private RadRibbonBarButtonGroup ribbonButtonGroupFormattingSymbols;
        private RadToggleButtonElement toggleButtonShowFormattingSymbols;

        private RadRibbonBarButtonGroup ribbonButtonGroupTextAlign;
        private RadToggleButtonElement toggleButtonTextAlignLeft;
        private RadToggleButtonElement toggleButtonTextAlignCenter;
        private RadToggleButtonElement toggleButtonTextAlignRight;
        private RadToggleButtonElement toggleButtonTextAlignJustify;

        private RadRibbonBarButtonGroup ribbonButtonGroupParagraphBackColor;
        private RadButtonElement buttonParagraphBackColor;

        #endregion

        #region Editing & Proofing group

        private RadRibbonBarGroup groupEditingAndProofing;

        private RadButtonElement buttonFindAndReplace;
        private RadToggleButtonElement buttonEnableSpellCheck;
        private RadButtonElement buttonFindNextError;

        #endregion

        #region Styles group

        private RadRibbonBarGroup groupStyles;

        //TODO gallery with styles
        private RadGalleryElement galleryStyles;
        private RadButtonElement buttonChangeStyles;

        #endregion

        #endregion

        #region Insert tab

        #region Pages group

        private RadRibbonBarGroup groupPages;

        private RadButtonElement buttonPageBreak;

        #endregion

        #region Tables group

        private RadRibbonBarGroup groupTables;

        private RadDropDownButtonElement dropDownButtonInsertTables;

        #endregion

        #region Illustrations group

        private RadRibbonBarGroup groupIllustrations;

        private RadButtonElement buttonInsertImage;

        #endregion

        #region Links group

        private RadRibbonBarGroup groupLinks;

        private RadButtonElement buttonInsertHyperlink;
        private RadButtonElement buttonManageBookmarks;
        private RadButtonElement buttonInsertCrossReference;

        #endregion

        #region NewComments group

        private RadRibbonBarGroup groupNewComments;

        private RadButtonElement buttonInsertNewComment;

        #endregion

        #region HeaderAndFooter group

        private RadRibbonBarGroup groupHeaderAndFooter;

        private RadButtonElement buttonHeader;
        private RadButtonElement buttonFooter;

        #endregion

        #region Text group

        private RadRibbonBarGroup groupText;

        private RadButtonElement buttonDateAndTime;
        private RadButtonElement buttonPageNumber;
        private RadButtonElement buttonCode;

        #endregion

        #region Symbols group

        private RadRibbonBarGroup groupSymbols;

        private RadButtonElement buttonInsertSymbol;

        #endregion

        #endregion

        #region Page Layout tab

        #region Page setup group

        private RadRibbonBarGroup groupPageSetup;

        private RadDropDownButtonElement dropDownButtonSize;
        private RadDropDownButtonElement dropDownButtonMargins;
        private RadDropDownButtonElement dropDownButtonOrientation;

        private RadRibbonBarButtonGroup ribbonButtonGroupBreaks;
        private RadDropDownButtonElement dropDownButtonBreaks;

        #endregion

        #region Page background group

        private RadRibbonBarGroup groupPageBackground;

        private RadDropDownButtonElement dropDownButtonWatermark;

        #endregion

        #endregion

        #region References tab

        #region Table of contents group

        private RadRibbonBarGroup groupTableOfContents;

        private RadButtonElement buttonTableOfContents;

        #endregion

        #region Footnotes group

        private RadRibbonBarGroup groupFootnotes;

        private RadButtonElement buttonInsertFootnote;

        private RadRibbonBarButtonGroup ribbonButtonGroupEndnotesAndNavigation;
        private RadButtonElement buttonInsertEndnote;
        private RadSplitButtonElement splitButtonNavigateFootnotes;

        #endregion

        #region Citations & Bibliographyd group

        private RadRibbonBarGroup groupCitationsAndBibliography;

        private RadDropDownButtonElement dropDownButtonInsertCitation;

        private RadRibbonBarButtonGroup ribbonButtonGroupManageSourcesStyleBibliography;
        private RadButtonElement buttonManageSources;
        private RadRibbonBarButtonGroup ribbonButtonGroupCitationStyle;
        private RadLabelElement labelCitationStyle;
        private RadDropDownListElement dropDownListCitationStyle;
        private RadButtonElement buttonBibliography;

        #endregion

        #region Captions group

        private RadRibbonBarGroup groupCaptions;

        private RadButtonElement buttonInsertCaption;
        private RadButtonElement buttonCrossReference;

        #endregion

        #endregion

        #region Mailing tab

        #region Groups

        #endregion

        #region Write & Insert Fields group

        private RadRibbonBarGroup groupWriteAndInsertFields;

        private RadToggleButtonElement toggleButtonHighlightMergeFields;
        private RadDropDownButtonElement dropDownButtonInsertMergeField;

        #endregion

        #region Preview Results group

        private RadRibbonBarGroup groupPreviewResults;

        private RadButtonElement buttonShowAllFieldCodes;
        private RadButtonElement buttonShowAllFieldsNames;
        private RadButtonElement buttonPreviewResults;
        private RadButtonElement buttonNavigateFirst;
        private RadButtonElement buttonNavigatePrevious;
        private RadButtonElement buttonNavigateNext;
        private RadButtonElement buttonNavigateLast;

        #endregion

        #region Finish group

        private RadRibbonBarGroup groupFinish;

        private RadButtonElement buttonMailMerge;

        #endregion

        #endregion

        #region Review tab

        #region Proofing group

        private RadRibbonBarGroup groupProofing;

        private RadButtonElement buttonSpellCheck;

        #endregion

        #region Comments group

        private RadRibbonBarGroup groupComments;

        private RadButtonElement buttonNewComment;
        private RadButtonElement buttonDeleteComment;
        private RadButtonElement buttonPreviousComment;
        private RadButtonElement buttonNextComment;
        private RadToggleButtonElement toggleButtonShowHideComments;
        private RadButtonElement buttonDeleteAllComments;

        #endregion

        #region Tracking & Changes group

        private RadRibbonBarGroup groupTrackingAndChanges;

        private RadToggleButtonElement toggleButtonTrackChanges;
        private RadSplitButtonElement splitButtonAcceptChange;
        private RadSplitButtonElement splitButtonRejectChange;

        private RadRibbonBarButtonGroup ribbonButtonGroupPreviousNextChange;
        private RadButtonElement buttonPreviousChange;
        private RadButtonElement buttonNextChange;

        #endregion

        #region Protect group

        private RadRibbonBarGroup groupProtect;

        private RadToggleButtonElement toggleButtonProtectDocument;
        private RadButtonElement buttonEditingRestrictions;

        #endregion

        #endregion

        #region View tab

        #region Document views group

        private RadRibbonBarGroup groupDocumentViews;

        private RadButtonElement buttonWebLayout;
        private RadButtonElement buttonPrintLayout;

        #endregion

        #endregion

        #region Table Styles tab

        #region Table Style Options group

        private RadRibbonBarGroup groupTableStyleOptions;

        private RadRibbonBarButtonGroup buttonGroupTableRowsStyleOptions;

        private RadCheckBoxElement checkBoxHeaderRow;
        private RadCheckBoxElement checkBoxTotalRow;
        private RadCheckBoxElement checkBoxBandedRows;

        private RadRibbonBarButtonGroup buttonGroupTableColumnsStyleOptions;

        private RadCheckBoxElement checkBoxFirstColumn;
        private RadCheckBoxElement checkBoxLastColumn;
        private RadCheckBoxElement checkBoxBandedColumns;

        #endregion

        #region Table styles group

        private RadRibbonBarGroup groupTableStyles;

        private RadGalleryElement galleryTableStyles;

        #endregion

        #endregion

        #region Table Layout tab

        #region Table group

        private RadRibbonBarGroup groupTable;

        private RadDropDownButtonElement dropDownButtonSelect;
        private RadButtonElement buttonProperties;
        private RadButtonElement buttonDelete;

        #endregion

        #region Rows group

        private RadRibbonBarGroup groupRows;

        private RadButtonElement buttonInsertRow;
        private RadButtonElement buttonInsertBelow;
        private RadButtonElement buttonInsertAbove;
        private RadButtonElement buttonDeleteRow;

        #endregion

        #region Columns group

        private RadRibbonBarGroup groupColumns;

        private RadButtonElement buttonInsertColumn;
        private RadButtonElement buttonInsertLeft;
        private RadButtonElement buttonInsertRight;
        private RadButtonElement buttonDeleteColumn;

        #endregion

        #region Merge group

        private RadRibbonBarGroup groupMerge;

        private RadButtonElement buttonMergeCells;

        #endregion

        #region Cell Size group

        private RadRibbonBarGroup groupCellSize;

        private RadDropDownButtonElement dropDownButtonAutoFit;

        #endregion

        #region Alignment group

        private RadRibbonBarGroup groupAlignment;

        private RadRibbonBarButtonGroup buttonGroupTopAlignments;
        private RadRibbonBarButtonGroup buttonGroupMiddleAlignments;
        private RadRibbonBarButtonGroup buttonGroupBottomAlignments;

        private RadToggleButtonElement buttonTopLeftAlignment;
        private RadToggleButtonElement buttonTopCenterAlignment;
        private RadToggleButtonElement buttonTopRightAlignment;
        private RadToggleButtonElement buttonMiddleLeftAlignment;
        private RadToggleButtonElement buttonMiddleCenterAlignment;
        private RadToggleButtonElement buttonMiddleRightAlignment;
        private RadToggleButtonElement buttonBottomLeftAlignment;
        private RadToggleButtonElement buttonBottomCenterAlignment;
        private RadToggleButtonElement buttonBottomRightAlignment;

        #endregion

        #endregion

        #region Header Footer tab

        #region Insert group

        private RadRibbonBarGroup groupInsert;

        private RadButtonElement buttonInsertDateAndTime;
        private RadButtonElement buttonInsertPageNumber;

        #endregion

        #region Navigation group

        private RadRibbonBarGroup groupNavigation;

        private RadToggleButtonElement linkToPrevious;

        #endregion

        #region Options group

        private RadRibbonBarGroup groupOptions;

        private RadCheckBoxElement checkBoxDifferentFirstPage;
        private RadCheckBoxElement checkBoxDifferentOddAndEvenPages;

        #endregion

        #region Position group

        private RadRibbonBarGroup groupPosition;

        private RadRibbonBarButtonGroup buttonGroupHeaderPosition;
        private RadRibbonBarButtonGroup buttonGroupFooterPosition;

        private RadLabelElement labelHeaderFromTop;
        private RadSpinElement spinElementHeaderFromTop;
        private RadLabelElement labelFooterFromBottom;
        private RadSpinElement spinElementFooterFromBottom;

        #endregion

        #region Close group

        private RadRibbonBarGroup groupClose;

        private RadButtonElement buttonCloseHeaderAndFooter;

        #endregion

        #endregion

        #endregion

        #region Constructor & Initialization

        public RichTextEditorRibbonBar()
        {
            this.Initialize();
            this.TabStop = false;
            this.Focusable = false;
        }

        protected override bool ProcessFocusRequested(RadElement element)
        {
            return false;
        }

        private void Initialize()
        {
            #region Application button

            this.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView;

            this.RibbonBarElement.ApplicationButtonElement.Text = "File";
            this.RibbonBarElement.ApplicationButtonElement.DisplayStyle = DisplayStyle.Text;

            this.backstageView = new RadRibbonBarBackstageView();

            this.backstageButtonNew = new BackstageButtonItem();
            this.backstageButtonNew.Text = "New";
            this.backstageButtonNew.Image = Resources.new32;
            this.backstageView.Items.Add(this.backstageButtonNew);

            this.backstageButtonOpen = new BackstageButtonItem();
            this.backstageButtonOpen.Text = "Open";
            this.backstageButtonOpen.Image = Resources.open32;
            this.backstageView.Items.Add(this.backstageButtonOpen);

            this.backstageButtonPrint = new BackstageButtonItem();
            this.backstageButtonPrint.Text = "Print";
            this.backstageButtonPrint.Image = Resources.print;
            this.backstageView.Items.Add(this.backstageButtonPrint);

            this.backstageButtonSave = new BackstageButtonItem();
            this.backstageButtonSave.Text = "Save";
            this.backstageButtonSave.Image = Resources.save32;
            this.backstageView.Items.Add(this.backstageButtonSave);

            this.backstageTabItemSaveAs = new BackstageTabItem();
            this.backstageTabItemSaveAs.Text = "Save As";
            this.backstageTabItemSaveAs.Image = Resources.saveas32;
            this.backstageTabItemSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backstageTabItemSaveAs.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.backstageTabItemSaveAs.TextAlignment = ContentAlignment.MiddleLeft;
            this.backstageTabItemSaveAs.ImageAlignment = ContentAlignment.MiddleLeft;
            this.backstageView.Items.Add(this.backstageTabItemSaveAs);

            this.backstageViewPageSaveAs = new BackstageViewPage();
            this.backstageView.Controls.Add(this.backstageViewPageSaveAs);
            this.backstageTabItemSaveAs.Page = this.backstageViewPageSaveAs;

            this.flp = new CustomFlowLayoutPanel();
            this.backstageViewPageSaveAs.Controls.Add(flp);
            this.flp.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp.Padding = new System.Windows.Forms.Padding(15);

            System.Drawing.Size size = new System.Drawing.Size(150, 40);

            this.buttonSaveWord = new RadButton();
            this.buttonSaveWord.Tag = "docx";
            this.buttonSaveWord.Text = "Word Document";
            this.buttonSaveWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveWord.Image = Resources.worddoc;
            this.buttonSaveWord.Size = size;
            this.flp.Controls.Add(buttonSaveWord);

            this.buttonSavePDF = new RadButton();
            this.buttonSavePDF.Tag = "pdf";
            this.buttonSavePDF.Text = "PDF Document";
            this.buttonSavePDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSavePDF.Image = Resources.Pdf;
            this.buttonSavePDF.Size = size;
            this.flp.Controls.Add(buttonSavePDF);

            this.buttonSaveHTML = new RadButton();
            this.buttonSaveHTML.Tag = "html";
            this.buttonSaveHTML.Text = "Html Document";
            this.buttonSaveHTML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveHTML.Image = Resources.Html;
            this.buttonSaveHTML.Size = size;
            this.flp.Controls.Add(buttonSaveHTML);

            this.buttonSaveRich = new RadButton();
            this.buttonSaveRich.Tag = "rtf";
            this.buttonSaveRich.Text = "Rich Text Format";
            this.buttonSaveRich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveRich.Image = Resources.Rtf;
            this.buttonSaveRich.Size = size;
            this.flp.Controls.Add(buttonSaveRich);

            this.buttonSavePlain = new RadButton();
            this.buttonSavePlain.Tag = "txt";
            this.buttonSavePlain.Text = "Plain Text";
            this.buttonSavePlain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSavePlain.Image = Resources.PlainText;
            this.buttonSavePlain.Size = size;
            this.flp.Controls.Add(buttonSavePlain);

            this.buttonXAML = new RadButton();
            this.buttonXAML.Tag = "xaml";
            this.buttonXAML.Text = "XAML Document";
            this.buttonXAML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXAML.Image = Resources.Xaml;
            this.buttonXAML.Size = size;
            this.flp.Controls.Add(buttonXAML);

            this.backstageView.SelectedItem = this.backstageTabItemSaveAs;
            this.BackstageControl = backstageView;

            #endregion

            #region Quick access toolbar

            this.buttonSave = this.InitializeQuickAccessButton(Resources.save16, "Save");
            this.buttonUndo = this.InitializeQuickAccessButton(Resources.undo16, "Undo");
            this.buttonRedo = this.InitializeQuickAccessButton(Resources.redo16, "Redo");

            this.QuickAccessToolBarItems.Add(buttonSave);
            this.QuickAccessToolBarItems.Add(buttonUndo);
            this.QuickAccessToolBarItems.Add(buttonRedo);

            #endregion

            #region Home tab

            #region Clipboard group

            this.buttonCut = this.InitializeMediumButton(Resources.cut16, "Cut");

            this.buttonCopy = this.InitializeMediumButton(Resources.copy16, "Copy");
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);

            this.buttonPaste = this.InitializeMediumButton(Resources.paste16, "Paste");

            this.groupClipboard = this.InitializeGroup("Clipboard");
            this.groupClipboard.Items.AddRange(this.buttonCut, this.buttonCopy, this.buttonPaste);

            #endregion

            #region Font group

            this.ribbonButtonGroupFontFontSizeIncreaseDecreaseFont = this.InitializeButtoneGroup();
            this.ribbonButtonGroupFontFontSizeIncreaseDecreaseFont.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);

            this.dropDownListFont = new RadDropDownListElement();
            this.dropDownListFont.DropDownStyle = RadDropDownStyle.DropDownList;
            this.dropDownListFont.DropDownAnimationEnabled = false;
            this.dropDownListFont.DataSource = this.GetFontFamilyItems();

            this.dropDownListFontSize = new RadDropDownListElement() { Margin = new System.Windows.Forms.Padding(5, 0, 5, 0), MaxSize = new System.Drawing.Size(50, 0), DropDownStyle = RadDropDownStyle.DropDownList, DropDownAnimationEnabled = false };
            this.dropDownListFontSize.DataSource = this.GetFontSizeItems();

            this.ribbonButtonGroupIncreaseDecreaseFont = new RadRibbonBarButtonGroup();

            this.buttonDecreaseFontSize = this.InitializeSmallButton(Resources.font_decreasesize16, "Shrink Font");
            this.buttonIncreaseFontSize = this.InitializeSmallButton(Resources.font_increasesize16, "Grow Font");

            this.ribbonButtonGroupIncreaseDecreaseFont.Items.AddRange(this.buttonIncreaseFontSize, this.buttonDecreaseFontSize);

            this.ribbonButtonGroupFontFontSizeIncreaseDecreaseFont.Items.AddRange(this.dropDownListFont, this.dropDownListFontSize, this.ribbonButtonGroupIncreaseDecreaseFont);

            this.ribbonButtonGroupClearFormattingFontStylesFontColors = this.InitializeButtoneGroup();
            this.ribbonButtonGroupClearFormattingFontStylesFontColors.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);

            this.buttonClearFormatting = this.InitializeSmallButton(Resources.ClearFormatting16, "Clear Formatting");

            this.ribbonButtonGroupClearFormatting = new RadRibbonBarButtonGroup();
            this.ribbonButtonGroupClearFormatting.Items.Add(this.buttonClearFormatting);

            this.toggleButtonBoldStyle = this.InitializeToggleButton(Resources.bold16, "Bold");
            this.toggleButtonItalicStyle = this.InitializeToggleButton(Resources.italic16, "Itelic");
            this.toggleButtonUnderlineStyle = this.InitializeToggleButton(Resources.underline16, "Underline");
            this.toggleButtonStrikethroughStyle = this.InitializeToggleButton(Resources.Strikethrough16, "Strikethrough");
            this.toggleButtonSubscript = this.InitializeToggleButton(Resources.subscript16, "Subscript");
            this.toggleButtonSuperscript = this.InitializeToggleButton(Resources.superscript16, "Superscript");

            this.ribbonButtonGroupFontStyles = new RadRibbonBarButtonGroup();
            this.ribbonButtonGroupFontStyles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ribbonButtonGroupFontStyles.Items.AddRange(this.toggleButtonBoldStyle, this.toggleButtonItalicStyle, this.toggleButtonUnderlineStyle, this.toggleButtonStrikethroughStyle, this.toggleButtonSubscript, this.toggleButtonSuperscript);

            this.buttonBackColor = this.InitializeSmallButton(Resources.highlight16, "Text Highlight Color");
            this.buttonForeColor = this.InitializeSmallButton(Resources.fontcolor16, "Font Color");

            this.ribbonButtonGroupFontColors = new RadRibbonBarButtonGroup();
            this.ribbonButtonGroupFontColors.Items.AddRange(this.buttonBackColor, this.buttonForeColor);

            this.ribbonButtonGroupClearFormattingFontStylesFontColors.Items.AddRange(this.ribbonButtonGroupClearFormatting, this.ribbonButtonGroupFontStyles, this.ribbonButtonGroupFontColors);

            this.groupFont = this.InitializeGroup("Font");
            this.groupFont.ShowDialogButton = true;
            this.groupFont.Items.AddRange(this.ribbonButtonGroupFontFontSizeIncreaseDecreaseFont, this.ribbonButtonGroupClearFormattingFontStylesFontColors);

            #endregion

            #region Paragraph group

            this.ribbonButtonGroupBulletsIndentDirection = this.InitializeButtoneGroup();
            this.ribbonButtonGroupBulletsIndentDirection.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);

            this.ribbonButtonGroupBullets = new RadRibbonBarButtonGroup() { ShowBackColor = false };
            this.toggleButtonBulletedList = this.InitializeToggleButton(Resources.list_bullets16, "Bullets");
            this.toggleButtonNumberedList = this.InitializeToggleButton(Resources.list_numbered16, "Numbering");
            this.buttonMultilevelList = this.InitializeSmallDropDownButton(Resources.MultilevelList16, "Multilevel");
            this.buttonMultilevelList.Items.AddRange(this.GetMultiLevelListItems());
            this.buttonMultilevelList.DropDownClosing += dropDownButtonWithListViewMenuItem_DropDownClosing;

            this.ribbonButtonGroupIndent = new RadRibbonBarButtonGroup() { Margin = new System.Windows.Forms.Padding(5, 0, 5, 0), ShowBackColor = false };

            this.buttonDecreaseIndent = this.InitializeSmallButton(Resources.outdent16, "Decrease Indent");
            this.buttonIncreaseIndent = this.InitializeSmallButton(Resources.indent16, "Increase Indent");

            this.ribbonButtonGroupDirection = new RadRibbonBarButtonGroup() { ShowBackColor = false };

            this.toggleButtonLeftToRightTextDirection = this.InitializeToggleButton(Resources.LeftToRightFlowDirection16, "Left to right flow");
            this.toggleButtonRightToLeftTextDirection = this.InitializeToggleButton(Resources.RightToLeftFlowDirection16, "Right to left flow");

            this.ribbonButtonGroupFormattingSymbolsTextAlignParagraphBackColor = this.InitializeButtoneGroup();
            this.ribbonButtonGroupFormattingSymbolsTextAlignParagraphBackColor.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);

            this.ribbonButtonGroupFormattingSymbols = new RadRibbonBarButtonGroup() { ShowBackColor = false };
            this.toggleButtonShowFormattingSymbols = this.InitializeToggleButton(Resources.formatting_symbols16, "Show/Hide formatting symbols");

            this.ribbonButtonGroupTextAlign = new RadRibbonBarButtonGroup() { Margin = new System.Windows.Forms.Padding(5, 0, 5, 0), ShowBackColor = false };

            this.toggleButtonTextAlignLeft = this.InitializeToggleButton(Resources.alignleft16, "Align text left");
            this.toggleButtonTextAlignCenter = this.InitializeToggleButton(Resources.aligncenter16, "Center");
            this.toggleButtonTextAlignRight = this.InitializeToggleButton(Resources.alignright16, "Align text right");
            this.toggleButtonTextAlignJustify = this.InitializeToggleButton(Resources.alignjustify16, "Justify");

            this.ribbonButtonGroupParagraphBackColor = new RadRibbonBarButtonGroup() { ShowBackColor = false };

            this.buttonParagraphBackColor = this.InitializeSmallButton(Resources.ParagraphBackgroundColor16, "Shading");

            this.ribbonButtonGroupBullets.Items.AddRange(this.toggleButtonBulletedList, this.toggleButtonNumberedList, this.buttonMultilevelList);
            this.ribbonButtonGroupIndent.Items.AddRange(this.buttonDecreaseIndent, this.buttonIncreaseIndent);
            this.ribbonButtonGroupDirection.Items.AddRange(this.toggleButtonLeftToRightTextDirection, this.toggleButtonRightToLeftTextDirection);
            this.ribbonButtonGroupFormattingSymbols.Items.AddRange(this.toggleButtonShowFormattingSymbols);
            this.ribbonButtonGroupTextAlign.Items.AddRange(this.toggleButtonTextAlignLeft, this.toggleButtonTextAlignCenter, this.toggleButtonTextAlignRight, this.toggleButtonTextAlignJustify);

            this.ribbonButtonGroupParagraphBackColor.Items.AddRange(this.buttonParagraphBackColor);

            this.ribbonButtonGroupBulletsIndentDirection.Items.AddRange(this.ribbonButtonGroupBullets, this.ribbonButtonGroupIndent, this.ribbonButtonGroupDirection);
            this.ribbonButtonGroupFormattingSymbolsTextAlignParagraphBackColor.Items.AddRange(this.ribbonButtonGroupFormattingSymbols, this.ribbonButtonGroupTextAlign, this.ribbonButtonGroupParagraphBackColor);

            this.groupParagraph = this.InitializeGroup("Paragraph");
            this.groupParagraph.ShowDialogButton = true;
            this.groupParagraph.Items.AddRange(this.ribbonButtonGroupBulletsIndentDirection, this.ribbonButtonGroupFormattingSymbolsTextAlignParagraphBackColor);

            #endregion

            #region Editing & Proofing group

            this.buttonFindAndReplace = this.InitializeMediumButton(Resources.find16, "Find/Replace");
            this.buttonEnableSpellCheck = this.InitializeToggleButton(Resources.EnableSpellCheck16, "Enable spell check");
            this.buttonEnableSpellCheck.DisplayStyle = DisplayStyle.ImageAndText;
            this.buttonEnableSpellCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEnableSpellCheck.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);

            this.buttonFindNextError = this.InitializeMediumButton(Resources.FindNextSpellingError16, "Find Next Error");
            this.buttonFindNextError.Enabled = false;

            this.groupEditingAndProofing = this.InitializeGroup("Editing && Proofing");
            this.groupEditingAndProofing.Items.AddRange(this.buttonFindAndReplace, this.buttonEnableSpellCheck, this.buttonFindNextError);

            #endregion

            #region Styles group

            this.galleryStyles = new RadGalleryElement();
            this.galleryStyles.MaxColumns = 5;
            this.galleryStyles.MaxRows = 1;
            this.galleryStyles.MinSize = new System.Drawing.Size(250, 0);

            this.buttonChangeStyles = this.InitializeBigButton(Resources.ChangeStyles32, "Change\nStyles");

            this.groupStyles = this.InitializeGroup("Styles");
            this.groupStyles.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupStyles.Items.AddRange(this.galleryStyles, this.buttonChangeStyles);

            #endregion

            this.tabHome = this.InitializeTab("Home", true);
            this.tabHome.Items.AddRange(this.groupClipboard, this.groupFont, this.groupParagraph, this.groupEditingAndProofing, this.groupStyles);

            #endregion

            #region Insert tab

            #region Pages group

            this.buttonPageBreak = this.InitializeBigButton(Resources.PageBreak32, "Page\nBreak");

            this.groupPages = this.InitializeGroup("Pages");
            this.groupPages.Items.Add(this.buttonPageBreak);

            #endregion

            #region Tables group

            this.dropDownButtonInsertTables = this.InitializeBigDropDownButton(Resources.InsertTable32, "Table");
            this.dropDownButtonInsertTables.Items.AddRange(this.GetInsertTableItems());

            this.groupTables = this.InitializeGroup("Tables");
            this.groupTables.Items.Add(this.dropDownButtonInsertTables);

            #endregion

            #region Illustrations group

            this.buttonInsertImage = this.InitializeBigButton(Resources.Picture32, "Picture");

            this.groupIllustrations = this.InitializeGroup("Illustrations");
            this.groupIllustrations.Items.Add(this.buttonInsertImage);

            #endregion

            #region Links group

            this.buttonInsertHyperlink = this.InitializeBigButton(Resources.inserthyperlink32, "Hyperlink");
            this.buttonManageBookmarks = this.InitializeBigButton(Resources.InsertBookmark32, "Bookmark");
            this.buttonInsertCrossReference = this.InitializeBigButton(Resources.InsertCrossReference32, "Cross-Reference");

            this.groupLinks = this.InitializeGroup("Links");
            this.groupLinks.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupLinks.Items.AddRange(this.buttonInsertHyperlink, this.buttonManageBookmarks, this.buttonInsertCrossReference);

            #endregion

            #region Comments group

            this.buttonInsertNewComment = this.InitializeBigButton(Resources.NewComment32, "New\nComment");

            this.groupNewComments = this.InitializeGroup("Comments");
            this.groupNewComments.Items.Add(this.buttonInsertNewComment);

            #endregion

            #region Header & Footer

            this.buttonHeader = this.InitializeBigButton(Resources.EditHeader32, "Header");
            this.buttonFooter = this.InitializeBigButton(Resources.EditFooter32, "Footer");

            this.groupHeaderAndFooter = this.InitializeGroup("Header && Footer");
            this.groupHeaderAndFooter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupHeaderAndFooter.Items.AddRange(this.buttonHeader, this.buttonFooter);

            #endregion

            #region Text group

            this.buttonDateAndTime = this.InitializeBigButton(Resources.InsertDateTime32, "Date\n&& Time");
            this.buttonPageNumber = this.InitializeBigButton(Resources.InsertPageNumber32, "Page\nNumber");
            this.buttonCode = this.InitializeBigButton(Resources.CodeBlock32, "Code");

            this.groupText = this.InitializeGroup("Text");
            this.groupText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupText.Items.AddRange(this.buttonDateAndTime, this.buttonPageNumber, this.buttonCode);

            #endregion

            #region Symbols

            this.buttonInsertSymbol = this.InitializeBigButton(Resources.Symbol32, "Symbol");

            this.groupSymbols = this.InitializeGroup("Symbols");
            this.groupSymbols.Items.Add(this.buttonInsertSymbol);

            #endregion

            this.tabInsert = this.InitializeTab("Insert", false);
            this.tabInsert.Items.AddRange(this.groupPages, this.groupTables, this.groupIllustrations, this.groupLinks, this.groupNewComments, this.groupHeaderAndFooter, this.groupText, this.groupSymbols);

            #endregion

            #region Page Layout tab

            #region Page Setup group

            this.dropDownButtonSize = this.InitializeBigDropDownButton(Resources.PageSize32, "Size");
            this.dropDownButtonSize.Items.AddRange(this.GetPaperSizeItems());

            this.dropDownButtonMargins = this.InitializeBigDropDownButton(Resources.PageMargin32, "Margins");
            this.dropDownButtonMargins.Items.AddRange(this.GetPageMarginItems());

            this.dropDownButtonOrientation = this.InitializeBigDropDownButton(Resources.PageOrientation32, "Orientation");
            this.dropDownButtonOrientation.Items.AddRange(this.GetPageOrientationItems());

            this.dropDownButtonBreaks = this.InitializeMediumDropDownButton(Resources.Break16, "Breaks");
            this.dropDownButtonBreaks.Items.AddRange(this.GetPageBreakItems());

            this.ribbonButtonGroupBreaks = this.InitializeButtoneGroup();
            this.ribbonButtonGroupBreaks.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ribbonButtonGroupBreaks.Items.Add(this.dropDownButtonBreaks);

            this.groupPageSetup = this.InitializeGroup("Page Setup");
            this.groupPageSetup.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupPageSetup.Items.AddRange(this.dropDownButtonSize, this.dropDownButtonMargins, this.dropDownButtonOrientation, this.ribbonButtonGroupBreaks);

            #endregion

            #region Page Background group

            this.dropDownButtonWatermark = this.InitializeBigDropDownButton(Resources.Watermark32, "Watermark");
            this.dropDownButtonWatermark.DropDownClosing += dropDownButtonWithListViewMenuItem_DropDownClosing;
            this.dropDownButtonWatermark.Items.AddRange(this.GetWatermarkItems());

            this.groupPageBackground = this.InitializeGroup("Page Background");
            this.groupPageBackground.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupPageBackground.Items.AddRange(this.dropDownButtonWatermark);

            #endregion

            this.tabPageLayout = this.InitializeTab("Page Layout", false);
            this.tabPageLayout.Items.AddRange(this.groupPageSetup, this.groupPageBackground);

            #endregion

            #region References tab

            #region Table of Contents group

            this.buttonTableOfContents = this.InitializeBigButton(Resources.InsertTableOfContents32, "Table of\nContents");

            this.groupTableOfContents = this.InitializeGroup("Table of Contents");
            this.groupTableOfContents.Items.AddRange(this.buttonTableOfContents);

            #endregion

            #region Footnotes group

            this.buttonInsertFootnote = this.InitializeBigButton(Resources.InsertFootnote32, "Insert\nFootnote");

            this.buttonInsertEndnote = this.InitializeMediumButton(Resources.InsertEndnote16, "Insert Endnote");
            this.buttonInsertEndnote.ShowBorder = false;
            this.splitButtonNavigateFootnotes = this.InitializeMediumSplitButton(Resources.NextNote16, "Next Footnote");
            this.splitButtonNavigateFootnotes.Items.AddRange(this.GetNotesNavigationItems());
            this.splitButtonNavigateFootnotes.DefaultItem = this.splitButtonNavigateFootnotes.Items[0];

            this.ribbonButtonGroupEndnotesAndNavigation = this.InitializeButtoneGroup();
            this.ribbonButtonGroupEndnotesAndNavigation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ribbonButtonGroupEndnotesAndNavigation.Items.AddRange(this.buttonInsertEndnote, this.splitButtonNavigateFootnotes);

            this.groupFootnotes = this.InitializeGroup("Footnotes");
            this.groupFootnotes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupFootnotes.Items.AddRange(this.buttonInsertFootnote, this.ribbonButtonGroupEndnotesAndNavigation);
            this.groupFootnotes.ShowDialogButton = true;

            #endregion

            #region Citations & Bibliography group

            this.dropDownButtonInsertCitation = this.InitializeBigDropDownButton(Resources.InsertCitation32, "Insert\nCitation");
            this.dropDownButtonInsertCitation.ArrowPosition = DropDownButtonArrowPosition.Right;
            this.dropDownButtonInsertCitation.Items.AddRange(this.GetInsertCitationItems());

            this.buttonManageSources = this.InitializeMediumButton(Resources.ManageSources16, "Manage Sources");
            this.buttonManageSources.ShowBorder = false;

            this.labelCitationStyle = new RadLabelElement();
            this.labelCitationStyle.Class = "RibbonBarLabelElement";
            this.labelCitationStyle.Image = Resources.BibliographyStyle16;
            this.labelCitationStyle.Text = "Style:";
            this.labelCitationStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.labelCitationStyle.TextWrap = true;

            this.dropDownListCitationStyle = new RadDropDownListElement();
            this.dropDownListCitationStyle.MaxSize = new System.Drawing.Size(80, 0);
            this.dropDownListCitationStyle.DropDownStyle = RadDropDownStyle.DropDownList;
            this.dropDownListCitationStyle.DropDownAnimationEnabled = false;
            this.dropDownListCitationStyle.DisplayMember = "Name";
            this.dropDownListCitationStyle.ValueMember = "Key";
            this.dropDownListCitationStyle.DataSource = this.GetCitationStyleItems();

            this.ribbonButtonGroupCitationStyle = this.InitializeButtoneGroup();
            this.ribbonButtonGroupCitationStyle.Items.AddRange(this.labelCitationStyle, this.dropDownListCitationStyle);

            this.buttonBibliography = this.InitializeMediumButton(Resources.InsertBibliography16, "Bibliography");
            this.buttonBibliography.ShowBorder = false;

            this.ribbonButtonGroupManageSourcesStyleBibliography = this.InitializeButtoneGroup();
            this.ribbonButtonGroupManageSourcesStyleBibliography.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ribbonButtonGroupManageSourcesStyleBibliography.Items.AddRange(this.buttonManageSources, this.ribbonButtonGroupCitationStyle, this.buttonBibliography);

            this.groupCitationsAndBibliography = this.InitializeGroup("Citations && Bibliography");
            this.groupCitationsAndBibliography.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupCitationsAndBibliography.Items.AddRange(this.dropDownButtonInsertCitation, this.ribbonButtonGroupManageSourcesStyleBibliography);

            #endregion

            #region Captions group

            this.buttonInsertCaption = this.InitializeBigButton(Resources.InsertCaption32, "Insert\nCaption");
            this.buttonCrossReference = this.InitializeBigButton(Resources.InsertCrossReference32, "Cross-reference");

            this.groupCaptions = this.InitializeGroup("Captions");
            this.groupCaptions.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupCaptions.Items.AddRange(this.buttonInsertCaption, this.buttonCrossReference);

            #endregion

            this.tabReferences = this.InitializeTab("References", false);
            this.tabReferences.Items.AddRange(this.groupTableOfContents, this.groupFootnotes, this.groupCitationsAndBibliography, this.groupCaptions);

            #endregion

            #region Mailings tab

            #region Write & Insert fields group

            this.toggleButtonHighlightMergeFields = this.InitializeToggleButton(Resources.HighlightMergeFields32, "Highlight\nMergeFields");
            this.toggleButtonHighlightMergeFields.DisplayStyle = DisplayStyle.ImageAndText;
            this.toggleButtonHighlightMergeFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            this.dropDownButtonInsertMergeField = this.InitializeBigDropDownButton(Resources.InsertMergeField32, "Insert\nMerge Field");
            this.dropDownButtonInsertMergeField.ArrowPosition = DropDownButtonArrowPosition.Right;
            this.dropDownButtonInsertMergeField.Items.Add(new RadItem());

            this.groupWriteAndInsertFields = this.InitializeGroup("Write && Insert Fields");
            this.groupWriteAndInsertFields.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupWriteAndInsertFields.Items.AddRange(this.toggleButtonHighlightMergeFields, this.dropDownButtonInsertMergeField);

            #endregion

            #region Preview Results group

            this.buttonShowAllFieldCodes = this.InitializeBigButton(Resources.ShowAllFieldsCodes32, "Show all\nFields Codes");
            this.buttonShowAllFieldsNames = this.InitializeBigButton(Resources.ShowAllFieldsDisplayNames32, "Show all\nFields Names");
            this.buttonPreviewResults = this.InitializeBigButton(Resources.ShowAllFieldsResults32, "Preview\nResults");
            this.buttonNavigateFirst = this.InitializeBigButton(Resources.First32, "First");
            this.buttonNavigatePrevious = this.InitializeBigButton(Resources.Previous32, "Previous");
            this.buttonNavigateNext = this.InitializeBigButton(Resources.Next32, "Next");
            this.buttonNavigateLast = this.InitializeBigButton(Resources.Last32, "Last");

            this.groupPreviewResults = this.InitializeGroup("Preview Results");
            this.groupPreviewResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupPreviewResults.Items.AddRange(this.buttonShowAllFieldCodes, this.buttonShowAllFieldsNames, this.buttonPreviewResults, this.buttonNavigateFirst, this.buttonNavigatePrevious, this.buttonNavigateNext, this.buttonNavigateLast);

            #endregion

            #region Finish group

            this.buttonMailMerge = this.InitializeBigButton(Resources.MailMerge32, "Mail\nMerge");

            this.groupFinish = this.InitializeGroup("Finish");
            this.groupFinish.Items.AddRange(this.buttonMailMerge);

            #endregion

            this.tabMailings = this.InitializeTab("Mailings", false);
            this.tabMailings.Items.AddRange(this.groupWriteAndInsertFields, this.groupPreviewResults, this.groupFinish);

            #endregion

            #region Review tab

            #region Proofing group

            this.buttonSpellCheck = this.InitializeBigButton(Resources.EnableSpellCheck32, "Spell\nCheck");

            this.groupProofing = this.InitializeGroup("Proofing");
            this.groupProofing.Items.AddRange(this.buttonSpellCheck);

            #endregion

            #region Comments group

            this.buttonNewComment = this.InitializeBigButton(Resources.NewComment32, "New\nComment");
            this.buttonDeleteComment = this.InitializeBigButton(Resources.DeleteComment32, "Delete");
            this.buttonPreviousComment = this.InitializeBigButton(Resources.PreviousComment32, "Previous");
            this.buttonNextComment = this.InitializeBigButton(Resources.NextComment32, "Next");
            this.toggleButtonShowHideComments = this.InitializeToggleButton(Resources.ShowHideComments32, "Show/Hide\nComments");
            this.toggleButtonShowHideComments.DisplayStyle = DisplayStyle.ImageAndText;
            this.toggleButtonShowHideComments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteAllComments = this.InitializeBigButton(Resources.DeleteAllComments32, "Delete\nAll");

            this.groupComments = this.InitializeGroup("Comments");
            this.groupComments.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupComments.Items.AddRange(this.buttonNewComment, this.buttonDeleteComment, this.buttonPreviousComment, this.buttonNextComment, this.toggleButtonShowHideComments, this.buttonDeleteAllComments);

            #endregion

            #region Tracking & Changes group

            this.toggleButtonTrackChanges = this.InitializeToggleButton(Resources.TrackChanges32, "Track\nChanges");
            this.toggleButtonTrackChanges.DisplayStyle = DisplayStyle.ImageAndText;
            this.toggleButtonTrackChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            this.splitButtonAcceptChange = this.InitializeBigSplitButton(Resources.AcceptChange32, "Accept");
            this.splitButtonAcceptChange.Items.AddRange(this.GetAcceptChangeItems());
            this.splitButtonAcceptChange.DefaultItem = this.splitButtonAcceptChange.Items[0];

            this.splitButtonRejectChange = this.InitializeBigSplitButton(Resources.RejectChange32, "Reject");
            this.splitButtonRejectChange.Items.AddRange(this.GetRejectChangeItems());
            this.splitButtonRejectChange.DefaultItem = this.splitButtonRejectChange.Items[0];

            this.buttonPreviousChange = this.InitializeMediumButton(Resources.PreviousChange16, "Previous");
            this.buttonPreviousChange.ShowBorder = false;
            this.buttonNextChange = this.InitializeMediumButton(Resources.NextChange16, "Next");
            this.buttonNextChange.ShowBorder = false;

            this.ribbonButtonGroupPreviousNextChange = this.InitializeButtoneGroup();
            this.ribbonButtonGroupPreviousNextChange.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ribbonButtonGroupPreviousNextChange.Items.AddRange(this.buttonPreviousChange, this.buttonNextChange);

            this.groupTrackingAndChanges = this.InitializeGroup("Tracking && Changes");
            this.groupTrackingAndChanges.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupTrackingAndChanges.Items.AddRange(this.toggleButtonTrackChanges, this.splitButtonAcceptChange, this.splitButtonRejectChange, this.ribbonButtonGroupPreviousNextChange);

            #endregion

            #region Protect group

            this.toggleButtonProtectDocument = this.InitializeToggleButton(Resources.ProtectDocument32, "Protect\nDocument");
            this.toggleButtonProtectDocument.DisplayStyle = DisplayStyle.ImageAndText;
            this.toggleButtonProtectDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            this.buttonEditingRestrictions = this.InitializeBigButton(Resources.ChangeEditingPermissions32, "Editing\nRestrictions");

            this.groupProtect = this.InitializeGroup("Proofing");
            this.groupProtect.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupProtect.Items.AddRange(this.toggleButtonProtectDocument, this.buttonEditingRestrictions);

            #endregion

            this.tabReview = this.InitializeTab("Review", false);
            this.tabReview.Items.AddRange(this.groupProofing, this.groupComments, this.groupTrackingAndChanges, this.groupProtect);

            #endregion

            #region View tab

            #region Document Views group

            this.buttonWebLayout = this.InitializeBigButton(Resources.web_C_PNG32, "Web\nLayout");
            this.buttonPrintLayout = this.InitializeBigButton(Resources.PageBreak32, "Print\nLayout");

            this.groupDocumentViews = this.InitializeGroup("Document Views");
            this.groupDocumentViews.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupDocumentViews.Items.AddRange(this.buttonWebLayout, this.buttonPrintLayout);

            #endregion

            this.tabView = this.InitializeTab("View", false);
            this.tabView.Items.AddRange(this.groupDocumentViews);

            #endregion

            #region Table Styles tab

            #region Table Style Options group

            this.checkBoxHeaderRow = this.InitializeCheckBox("Header Row");
            this.checkBoxTotalRow = this.InitializeCheckBox("Total Row");
            this.checkBoxBandedRows = this.InitializeCheckBox("Banded Rows");

            this.buttonGroupTableRowsStyleOptions = this.InitializeButtoneGroup();
            this.buttonGroupTableRowsStyleOptions.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.buttonGroupTableRowsStyleOptions.Items.AddRange(this.checkBoxHeaderRow, this.checkBoxTotalRow, this.checkBoxBandedRows);

            this.checkBoxFirstColumn = this.InitializeCheckBox("First Column");
            this.checkBoxLastColumn = this.InitializeCheckBox("Total Column");
            this.checkBoxBandedColumns = this.InitializeCheckBox("Banded Column");

            this.buttonGroupTableColumnsStyleOptions = this.InitializeButtoneGroup();
            this.buttonGroupTableColumnsStyleOptions.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.buttonGroupTableColumnsStyleOptions.Items.AddRange(this.checkBoxFirstColumn, this.checkBoxLastColumn, this.checkBoxBandedColumns);

            this.groupTableStyleOptions = this.InitializeGroup("Table Style Options");
            this.groupTableStyleOptions.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupTableStyleOptions.Items.AddRange(this.buttonGroupTableRowsStyleOptions, this.buttonGroupTableColumnsStyleOptions);

            #endregion

            #region Table styles group

            this.galleryTableStyles = new RadGalleryElement();
            this.galleryTableStyles.MaxColumns = 7;
            this.galleryTableStyles.MaxRows = 1;
            this.galleryTableStyles.MinSize = new System.Drawing.Size(400, 0);

            this.groupTableStyles = this.InitializeGroup("Table Styles");
            this.groupTableStyles.Items.AddRange(this.galleryTableStyles);

            #endregion

            this.tabTableStyle = this.InitializeTab("Design", false);
            this.tabTableStyle.Items.AddRange(this.groupTableStyleOptions, this.groupTableStyles);

            #endregion

            #region Table Layout tab

            #region Table group

            this.dropDownButtonSelect = this.InitializeBigDropDownButton(Resources.SelectTableTools32, "Select");
            this.dropDownButtonSelect.Items.AddRange(this.GetTableToolsItems());
            this.buttonProperties = this.InitializeBigButton(Resources.TableProperties32, "Properties");
            this.buttonDelete = this.InitializeBigButton(Resources.DeleteTable32, "Delete");

            this.groupTable = this.InitializeGroup("Table");
            this.groupTable.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupTable.Items.AddRange(this.dropDownButtonSelect, this.buttonProperties, this.buttonDelete);

            #endregion

            #region Rows group

            this.buttonInsertRow = this.InitializeBigButton(Resources.InsertTableRow32, "Insert\nRow");
            this.buttonInsertBelow = this.InitializeBigButton(Resources.InsertTableRowBelow32, "Insert\nBelow");
            this.buttonInsertAbove = this.InitializeBigButton(Resources.InsertTableRowAbove32, "Insert\nAbove");
            this.buttonDeleteRow = this.InitializeBigButton(Resources.DeleteTableRows32, "Delete\nRow");

            this.groupRows = this.InitializeGroup("Rows");
            this.groupRows.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupRows.Items.AddRange(this.buttonInsertRow, this.buttonInsertBelow, this.buttonInsertAbove, this.buttonDeleteRow);

            #endregion

            #region Columns group

            this.buttonInsertColumn = this.InitializeBigButton(Resources.InsertTableColumn32, "Insert\nColumn");
            this.buttonInsertLeft = this.InitializeBigButton(Resources.InsertTableColumnToTheLeft32, "Insert\nLeft");
            this.buttonInsertRight = this.InitializeBigButton(Resources.InsertTableColumnToTheRight32, "Insert\nRight");
            this.buttonDeleteColumn = this.InitializeBigButton(Resources.DeleteTableColumns32, "Delete\nColumn");

            this.groupColumns = this.InitializeGroup("Columns");
            this.groupColumns.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupColumns.Items.AddRange(this.buttonInsertColumn, this.buttonInsertLeft, this.buttonInsertRight, this.buttonDeleteColumn);

            #endregion

            #region Merge group

            this.buttonMergeCells = this.InitializeBigButton(Resources.MergeTableCells32, "Merge\nCells");

            this.groupMerge = this.InitializeGroup("Merge");
            this.groupMerge.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupMerge.Items.AddRange(this.buttonMergeCells);

            #endregion

            #region Cell Size group

            this.dropDownButtonAutoFit = this.InitializeBigDropDownButton(Resources.AutoFit32, "AutoFit");
            this.dropDownButtonAutoFit.Items.AddRange(this.GetAutoFitItems());

            this.groupCellSize = this.InitializeGroup("Cell Size");
            this.groupCellSize.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupCellSize.Items.AddRange(this.dropDownButtonAutoFit);

            #endregion

            #region Alignment group

            this.buttonTopLeftAlignment = this.InitializeToggleButton(Resources.LeftTopCellAlignment16, String.Empty);
            this.buttonTopLeftAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Left, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Top);
            this.buttonTopCenterAlignment = this.InitializeToggleButton(Resources.CenterTopCellAlignment16, String.Empty);
            this.buttonTopCenterAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Center, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Top);
            this.buttonTopRightAlignment = this.InitializeToggleButton(Resources.RightTopCellAlignment16, String.Empty);
            this.buttonTopRightAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Right, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Top);

            this.buttonGroupTopAlignments = this.InitializeButtoneGroup();
            this.buttonGroupTopAlignments.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.buttonGroupTopAlignments.Items.AddRange(this.buttonTopLeftAlignment, this.buttonTopCenterAlignment, this.buttonTopRightAlignment);

            this.buttonMiddleLeftAlignment = this.InitializeToggleButton(Resources.LeftMiddleCellAlignment16, String.Empty);
            this.buttonMiddleLeftAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Left, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Center);
            this.buttonMiddleCenterAlignment = this.InitializeToggleButton(Resources.CenterMiddleCellAlignment16, String.Empty);
            this.buttonMiddleCenterAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Center, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Center);
            this.buttonMiddleRightAlignment = this.InitializeToggleButton(Resources.RightMiddleCellAlignment16, String.Empty);
            this.buttonMiddleRightAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Right, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Center);

            this.buttonGroupMiddleAlignments = this.InitializeButtoneGroup();
            this.buttonGroupMiddleAlignments.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.buttonGroupMiddleAlignments.Items.AddRange(this.buttonMiddleLeftAlignment, this.buttonMiddleCenterAlignment, this.buttonMiddleRightAlignment);

            this.buttonBottomLeftAlignment = this.InitializeToggleButton(Resources.LeftBottomCellAlignment16, String.Empty);
            this.buttonBottomLeftAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Left, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Bottom);
            this.buttonBottomCenterAlignment = this.InitializeToggleButton(Resources.CenterBottomCellAlignment16, String.Empty);
            this.buttonBottomCenterAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Center, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Bottom);
            this.buttonBottomRightAlignment = this.InitializeToggleButton(Resources.RightBottomCellAlignment16, String.Empty);
            this.buttonBottomRightAlignment.Tag = new TableCellContentAlignmentCommandParameter(Telerik.WinForms.Documents.Layout.RadTextAlignment.Right, Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Bottom);

            this.buttonGroupBottomAlignments = this.InitializeButtoneGroup();
            this.buttonGroupBottomAlignments.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.buttonGroupBottomAlignments.Items.AddRange(this.buttonBottomLeftAlignment, this.buttonBottomCenterAlignment, this.buttonBottomRightAlignment);

            this.groupAlignment = this.InitializeGroup("Alignment");
            this.groupAlignment.Items.AddRange(this.buttonGroupTopAlignments, this.buttonGroupMiddleAlignments, this.buttonGroupBottomAlignments);

            #endregion

            this.tabTableLayout = this.InitializeTab("Layout", false);
            this.tabTableLayout.Items.AddRange(this.groupTable, this.groupRows, this.groupColumns, this.groupMerge, this.groupCellSize, this.groupAlignment);

            #endregion

            #region Header Footer tab

            #region Insert group

            this.buttonInsertDateAndTime = this.InitializeBigButton(Resources.InsertDateTime32, "Date & Time");
            this.buttonInsertPageNumber = this.InitializeBigButton(Resources.InsertPageNumber32, "Page Number");

            this.groupInsert = this.InitializeGroup("Insert");
            this.groupInsert.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.groupInsert.Items.AddRange(this.buttonInsertDateAndTime, this.buttonInsertPageNumber);

            #endregion

            #region Navigation group

            this.linkToPrevious = this.InitializeToggleButton(Resources.LinkToPreviousHeaderFooter16, "Link to Previous");
            this.linkToPrevious.DisplayStyle = DisplayStyle.ImageAndText;
            this.linkToPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;

            this.groupNavigation = this.InitializeGroup("Navigation");
            this.groupNavigation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.groupNavigation.Items.AddRange(this.linkToPrevious);

            #endregion

            #region Options group

            this.checkBoxDifferentFirstPage = this.InitializeCheckBox("Different First Page");
            this.checkBoxDifferentOddAndEvenPages = this.InitializeCheckBox("Different Odd & Even Pages");

            this.groupOptions = this.InitializeGroup("Options");
            this.groupOptions.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.groupOptions.Items.AddRange(this.checkBoxDifferentFirstPage, this.checkBoxDifferentOddAndEvenPages);

            #endregion

            #region Position group

            this.labelHeaderFromTop = new RadLabelElement();
            this.labelHeaderFromTop.Text = "Header from Top:";
            this.labelHeaderFromTop.Image = Resources.HeaderFromTop16;
            this.labelHeaderFromTop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.spinElementHeaderFromTop = new RadSpinElement();
            this.spinElementHeaderFromTop.MinSize = new System.Drawing.Size(80, 0);

            this.buttonGroupHeaderPosition = this.InitializeButtoneGroup();
            this.buttonGroupHeaderPosition.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.buttonGroupHeaderPosition.Items.AddRange(this.labelHeaderFromTop, this.spinElementHeaderFromTop);

            this.labelFooterFromBottom = new RadLabelElement();
            this.labelFooterFromBottom.Text = "Header from Top:";
            this.labelFooterFromBottom.Image = Resources.FooterFromBottom16;
            this.labelFooterFromBottom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.spinElementFooterFromBottom = new RadSpinElement();
            this.spinElementFooterFromBottom.MinSize = new System.Drawing.Size(80, 0);

            this.buttonGroupFooterPosition = this.InitializeButtoneGroup();
            this.buttonGroupFooterPosition.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.buttonGroupFooterPosition.Items.AddRange(this.labelFooterFromBottom, this.spinElementFooterFromBottom);

            this.groupPosition = this.InitializeGroup("Position");
            this.groupPosition.Items.AddRange(this.buttonGroupHeaderPosition, this.buttonGroupFooterPosition);

            #endregion

            #region Close group

            this.buttonCloseHeaderAndFooter = this.InitializeBigButton(Resources.ExitHeaderFooterEditMode32, "Close\nHeader and Footer");

            this.groupClose = this.InitializeGroup("Close");
            this.groupClose.Items.AddRange(this.buttonCloseHeaderAndFooter);

            #endregion

            this.tabHeaderFooter = this.InitializeTab("Design", false);
            this.tabHeaderFooter.Items.AddRange(this.groupInsert, this.groupNavigation, this.groupOptions, this.groupPosition, this.groupClose);

            #endregion

            this.tabGroupTable = new ContextualTabGroup();
            this.tabGroupTable.Text = "Table tools";

            this.tabGroupHeaderAndFooter = new ContextualTabGroup();
            this.tabGroupHeaderAndFooter.Text = "Header & Footer Tools";

            this.CommandTabs.AddRange(this.tabHome, this.tabInsert, this.tabPageLayout, this.tabReferences, this.tabMailings, this.tabReview, this.tabView);

            this.WireEvents();
        }

        private void InitializeSnapshotRichTextBox()
        {
            this.styleSnapshotRichTextBox = new RadRichTextEditor();
            this.styleSnapshotRichTextBox.RichTextBoxElement.ShouldHandleMouseInput = false;
            this.styleSnapshotRichTextBox.RichTextBoxElement.BorderThickness = new System.Windows.Forms.Padding(0);
            this.styleSnapshotRichTextBox.RichTextBoxElement.Background = System.Drawing.Brushes.White;
            this.styleSnapshotRichTextBox.RichTextBoxElement.BackColor = System.Drawing.Color.Transparent;
            this.styleSnapshotRichTextBox.RichTextBoxElement.HorizontalAlignment = HorizontalAlignment.Left;
            this.styleSnapshotRichTextBox.RichTextBoxElement.VerticalAlignment = VerticalAlignment.Top;
            this.styleSnapshotRichTextBox.RichTextBoxElement.IsContextMenuEnabled = false;
            this.styleSnapshotRichTextBox.RichTextBoxElement.IsReadOnly = true;
            this.styleSnapshotRichTextBox.RichTextBoxElement.IsSelectionEnabled = false;
            this.styleSnapshotRichTextBox.RichTextBoxElement.IsSpellCheckingEnabled = false;
            this.styleSnapshotRichTextBox.RichTextBoxElement.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
            this.styleSnapshotRichTextBox.RichTextBoxElement.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            this.styleSnapshotRichTextBox.RichTextBoxElement.LayoutMode = DocumentLayoutMode.FlowNoWrap;
            this.styleSnapshotRichTextBox.RichTextBoxElement.Margin = new System.Windows.Forms.Padding(0);
            this.styleSnapshotRichTextBox.RichTextBoxElement.Height = 180;
            this.styleSnapshotRichTextBox.RichTextBoxElement.Width = 200;
            RadDocument doc = new RadDocument();
            Section section = new Section();
            Paragraph par = new Paragraph();
            Span span = new Span("AaBbCcDd");
            par.Children.Add(span);
            par.SpacingAfter = 0;
            par.SpacingBefore = 0;
            par.LineSpacingType = LineSpacingType.Auto;
            par.LineSpacing = 1;
            par.LeftIndent = 0;
            par.RightIndent = 0;
            par.HangingIndent = 0;
            par.TextAlignment = Telerik.WinForms.Documents.Layout.RadTextAlignment.Left;
            section.Children.Add(par);
            doc.Sections.Add(section);
            this.styleSnapshotRichTextBox.Document = doc;

            // set some default settings
            this.styleSnapshotRichTextBox.Document.CaretPosition.MoveToFirstPositionInDocument();
            this.styleSnapshotRichTextBox.Document.FlowModePadding = new Telerik.WinForms.Documents.Layout.Padding(0);
            this.styleSnapshotRichTextBox.Document.ParagraphDefaultSpacingBefore = 0;
            this.styleSnapshotRichTextBox.Document.ParagraphDefaultSpacingAfter = 0;
            this.styleSnapshotRichTextBox.Document.LineSpacing = DocumentDefaultSettings.DEFAULT_LINE_SPACING;
            this.styleSnapshotRichTextBox.Document.LineSpacingType = LineSpacingType.Auto;

            foreach (Paragraph paragraph in this.styleSnapshotRichTextBox.Document.EnumerateChildrenOfType<Paragraph>())
            {
                paragraph.SpacingAfter = 0;
                paragraph.SpacingBefore = 0;
                paragraph.FirstLineIndent = 0;
                paragraph.LeftIndent = 0;
            }

            this.styleSnapshotRichTextBox.LoadElementTree();
            this.styleSnapshotRichTextBox.RichTextBoxElement.UpdateEditorLayout();
            this.styleSnapshotRichTextBox.RichTextBoxElement.Measure(new System.Drawing.SizeF(float.PositiveInfinity, float.PositiveInfinity));
            this.styleSnapshotRichTextBox.RichTextBoxElement.DocumentChanged += RichTextBoxElement_DocumentChanged;

            this.SetQuickStyleItemSource(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.SetTableStyleItemSource(this.AssociatedRichTextEditor.RichTextBoxElement);
        }

        private void InitializeListSnapshotRichTextBox()
        {
            this.listStyleSnapshotRichTextBox = new RadRichTextEditor();
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.ShouldHandleMouseInput = false;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.BorderThickness = new System.Windows.Forms.Padding(0);
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.Background = System.Drawing.Brushes.White;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.BackColor = System.Drawing.Color.Transparent;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.HorizontalAlignment = HorizontalAlignment.Left;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.VerticalAlignment = VerticalAlignment.Top;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.IsContextMenuEnabled = false;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.IsReadOnly = true;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.IsSelectionEnabled = false;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.IsSpellCheckingEnabled = false;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.LayoutMode = DocumentLayoutMode.FlowNoWrap;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.Margin = new System.Windows.Forms.Padding(0);
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.Height = 100;
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.Width = 100;

            RadDocument doc = new RadDocument();
            Section section = new Section();
            Paragraph p = new Paragraph() { RightIndent = 0d, SpacingAfter = 10d, SpacingBefore = 0d };
            ImageInline ii = new ImageInline() { Extension = "png", Height = 2d, RawData = "iVBORw0KGgoAAAANSUhEUgAAADcAAAACCAIAAABzDtMPAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAadEVYdFNvZnR3YXJlAFBhaW50Lk5FVCB2My41LjEwMPRyoQAAABFJREFUKFNjWDUUAMNQcOQqACL22yWEJ8z7AAAAAElFTkSuQmCC", RotateAngle = 0d, Width = 55 };
            p.Children.Add(ii);
            section.Children.Add(p);
            p = new Paragraph() { RightIndent = 0d, SpacingAfter = 10d, SpacingBefore = 0d };
            ii = new ImageInline() { Extension = "png", Height = 2d, RawData = "iVBORw0KGgoAAAANSUhEUgAAADcAAAACCAIAAABzDtMPAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAadEVYdFNvZnR3YXJlAFBhaW50Lk5FVCB2My41LjEwMPRyoQAAABFJREFUKFNjWDUUAMNQcOQqACL22yWEJ8z7AAAAAElFTkSuQmCC", RotateAngle = 0d, Width = 55 };
            p.Children.Add(ii);
            section.Children.Add(p);
            p = new Paragraph() { RightIndent = 0d, SpacingAfter = 10d, SpacingBefore = 0d };
            ii = new ImageInline() { Extension = "png", Height = 2d, RawData = "iVBORw0KGgoAAAANSUhEUgAAADcAAAACCAIAAABzDtMPAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAadEVYdFNvZnR3YXJlAFBhaW50Lk5FVCB2My41LjEwMPRyoQAAABFJREFUKFNjWDUUAMNQcOQqACL22yWEJ8z7AAAAAElFTkSuQmCC", RotateAngle = 0d, Width = 55 };
            p.Children.Add(ii);
            section.Children.Add(p);
            p = new Paragraph() { RightIndent = 0d, SpacingAfter = 10d, SpacingBefore = 0d };
            section.Children.Add(p);
            doc.Children.Add(section);
            this.listStyleSnapshotRichTextBox.Document = doc;

            // set some default settings
            this.listStyleSnapshotRichTextBox.Document.CaretPosition.MoveToFirstPositionInDocument();
            this.listStyleSnapshotRichTextBox.Document.FlowModePadding = new Telerik.WinForms.Documents.Layout.Padding(10);

            this.listStyleSnapshotRichTextBox.LoadElementTree();
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.UpdateEditorLayout();
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.Measure(new System.Drawing.SizeF(float.PositiveInfinity, float.PositiveInfinity));
            this.listStyleSnapshotRichTextBox.RichTextBoxElement.DocumentChanged += RichTextBoxElement_DocumentChanged;

            this.SetListStyleItemSource(this.AssociatedRichTextEditor.RichTextBoxElement);
        }

        private void WireEvents()
        {
            #region Application menu

            this.backstageButtonNew.Click += backstageButtonNew_Click;
            this.backstageButtonOpen.Click += backstageButtonOpen_Click;
            this.backstageButtonPrint.Click += backstageButtonPrint_Click;
            this.backstageButtonSave.Click += backstageButtonSave_Click;
            this.buttonSaveWord.Click += buttonSaveWord_Click;
            this.buttonSavePDF.Click += buttonSavePDF_Click;
            this.buttonSaveHTML.Click += buttonSaveHTML_Click;
            this.buttonSaveRich.Click += buttonSaveRich_Click;
            this.buttonSavePlain.Click += buttonSavePlain_Click;
            this.buttonXAML.Click += buttonXAML_Click;

            #endregion

            #region Quick access toolbar

            this.buttonSave.Click += buttonSave_Click;
            this.buttonUndo.Click += buttonUndo_Click;
            this.buttonRedo.Click += buttonRedo_Click;

            #endregion

            #region Home tab

            #region Clipboard group

            this.buttonCut.Click += buttonCut_Click;
            this.buttonCopy.Click += buttonCopy_Click;
            this.buttonPaste.Click += buttonPaste_Click;

            #endregion

            #region Font group

            this.dropDownListFont.SelectedIndexChanged += dropDownListFont_SelectedIndexChanged;
            this.dropDownListFontSize.SelectedIndexChanged += dropDownListFontSize_SelectedIndexChanged;
            this.buttonIncreaseFontSize.Click += buttonIncreaseFontSize_Click;
            this.buttonDecreaseFontSize.Click += buttonDecreaseFontSize_Click;
            this.buttonClearFormatting.Click += buttonClearFormatting_Click;
            this.toggleButtonBoldStyle.ToggleStateChanged += toggleButtonBoldStyle_ToggleStateChanged;
            this.toggleButtonItalicStyle.ToggleStateChanged += toggleButtonItalicStyle_ToggleStateChanged;
            this.toggleButtonUnderlineStyle.ToggleStateChanged += toggleButtonUnderlineStyle_ToggleStateChanged;
            this.toggleButtonStrikethroughStyle.ToggleStateChanged += toggleButtonStrikethroughStyle_ToggleStateChanged;
            this.toggleButtonSubscript.ToggleStateChanged += toggleButtonSubscript_ToggleStateChanged;
            this.toggleButtonSuperscript.ToggleStateChanged += toggleButtonSuperscript_ToggleStateChanged;
            this.buttonBackColor.Click += buttonBackColor_Click;
            this.buttonForeColor.Click += buttonForeColor_Click;

            this.groupFont.DialogButtonClick += groupFont_DialogButtonClick;

            #endregion

            #region Paragraph group

            this.toggleButtonBulletedList.ToggleStateChanged += toggleButtonBulletedList_ToggleStateChanged;
            this.toggleButtonNumberedList.ToggleStateChanged += toggleButtonNumberedList_ToggleStateChanged;
            this.buttonMultilevelList.Items.Where(x => x.Text == DefineNewListStyleText).First().Click += menuItemDefineNewListStyle_Click;
            this.buttonDecreaseIndent.Click += buttonDecreaseIndent_Click;
            this.buttonIncreaseIndent.Click += buttonIncreaseIndent_Click;
            this.toggleButtonLeftToRightTextDirection.ToggleStateChanged += toggleButtonLeftToRightTextDirection_ToggleStateChanged;
            this.toggleButtonRightToLeftTextDirection.ToggleStateChanged += toggleButtonRightToLeftTextDirection_ToggleStateChanged;
            this.toggleButtonShowFormattingSymbols.ToggleStateChanged += toggleButtonShowFormattingSymbols_ToggleStateChanged;
            this.toggleButtonTextAlignLeft.ToggleStateChanged += toggleButtonTextAlignLeft_ToggleStateChanged;
            this.toggleButtonTextAlignCenter.ToggleStateChanged += toggleButtonTextAlignCenter_ToggleStateChanged;
            this.toggleButtonTextAlignRight.ToggleStateChanged += toggleButtonTextAlignRight_ToggleStateChanged;
            this.toggleButtonTextAlignJustify.ToggleStateChanged += toggleButtonTextAlignJustify_ToggleStateChanged;
            this.buttonParagraphBackColor.Click += buttonParagraphBackColor_Click;

            this.groupParagraph.DialogButtonClick += groupParagraph_DialogButtonClick;

            #endregion

            #region Editing & Proofing group

            buttonFindAndReplace.Click += buttonFindAndReplace_Click;
            buttonEnableSpellCheck.ToggleStateChanged += buttonEnableSpellCheck_ToggleStateChanged;
            buttonFindNextError.Click += buttonFindNextError_Click;

            #endregion

            #region Styles group
            //TODO Styeles gallery
            this.buttonChangeStyles.Click += buttonChangeStyles_Click;

            #endregion

            #endregion

            #region Insert tab

            #region Pages group

            this.buttonPageBreak.Click += buttonPageBreak_Click;

            #endregion

            #region Tables group

            #endregion

            #region Illustrations group

            this.buttonInsertImage.Click += buttonInsertImage_Click;

            #endregion

            #region Links group

            this.buttonInsertHyperlink.Click += buttonInsertHyperlink_Click;
            this.buttonManageBookmarks.Click += buttonManageBookmarks_Click;
            this.buttonInsertCrossReference.Click += buttonInsertCrossReference_Click;

            #endregion

            #region Comments group

            this.buttonInsertNewComment.Click += buttonInsertNewComment_Click;

            #endregion

            #region Header & Footer

            this.buttonHeader.Click += buttonHeader_Click;
            this.buttonFooter.Click += buttonFooter_Click;

            #endregion

            #region Text group

            this.buttonDateAndTime.Click += buttonDateAndTime_Click;
            this.buttonPageNumber.Click += buttonPageNumber_Click;
            this.buttonCode.Click += buttonCode_Click;

            #endregion

            #region Symbols

            this.buttonInsertSymbol.Click += buttonInsertSymbol_Click;

            #endregion

            #endregion

            #region Page Layout tab

            #region Page Setup group

            foreach (RadMenuItemBase item in this.dropDownButtonSize.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += DropDownButtonSize_ItemClick;
            }

            foreach (RadMenuItemBase item in this.dropDownButtonMargins.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += dropDownButtonMargins_ItemClick;
            }

            foreach (RadMenuItemBase item in this.dropDownButtonOrientation.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += dropDownButtonOrientation_ItemClick;
            }

            foreach (RadMenuItemBase item in this.dropDownButtonBreaks.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += dropDownButtonBreaks_ItemClick;
            }

            #endregion

            #region Page Background group

            foreach (RadMenuItemBase item in this.dropDownButtonWatermark.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += DropDownButtonWatermark_ItemClick;
            }

            #endregion

            #endregion

            #region References

            #region Table of Contents group

            this.buttonTableOfContents.Click += buttonTableOfContents_Click;

            #endregion

            #region Footnotes group

            this.buttonInsertFootnote.Click += buttonInsertFootnote_Click;
            this.buttonInsertEndnote.Click += buttonInsertEndnote_Click;
            this.groupFootnotes.DialogButtonClick += groupFootnotes_DialogButtonClick;

            foreach (RadMenuItemBase item in this.splitButtonNavigateFootnotes.Items)
            {
                item.Click += NavigateFootnotes_ItemClick;
            }

            #endregion

            #region Citations & Bibliography group

            this.dropDownButtonInsertCitation.DropDownOpening += dropDownButtonInsertCitation_DropDownOpening;

            foreach (RadMenuItemBase item in this.dropDownButtonInsertCitation.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += InsertCitation_ItemClick;
            }

            this.buttonManageSources.Click += buttonManageSources_Click;
            this.dropDownListCitationStyle.SelectedIndexChanged += dropDownListCitationStyle_SelectedIndexChanged;
            this.buttonBibliography.Click += buttonBibliography_Click;

            #endregion

            #region Captions group

            this.buttonInsertCaption.Click += buttonInsertCaption_Click;
            this.buttonCrossReference.Click += buttonCrossReference_Click;

            #endregion

            #endregion

            #region Mailings tabs

            #region Write & Insert Fields group

            this.toggleButtonHighlightMergeFields.Click += toggleButtonHighlightMergeFields_Click;

            this.dropDownButtonInsertMergeField.DropDownOpening += dropDownButtonInsertMergeField_DropDownOpening;

            #endregion

            #region Preview Results group

            this.buttonShowAllFieldCodes.Click += buttonShowAllFieldCodes_Click;
            this.buttonShowAllFieldsNames.Click += buttonShowAllFieldsNames_Click;
            this.buttonPreviewResults.Click += buttonPreviewResults_Click;
            this.buttonNavigateFirst.Click += buttonNavigateFirst_Click;
            this.buttonNavigatePrevious.Click += buttonNavigatePrevious_Click;
            this.buttonNavigateNext.Click += buttonNavigateNext_Click;
            this.buttonNavigateLast.Click += buttonNavigateLast_Click;

            #endregion

            #region Finish group

            this.buttonMailMerge.Click += buttonMailMerge_Click;

            #endregion

            #endregion

            #region Review tab

            #region Proofing group

            this.buttonSpellCheck.Click += buttonSpellCheck_Click;

            #endregion

            #region Comments group

            this.buttonNewComment.Click += buttonNewComment_Click;
            this.buttonDeleteComment.Click += buttonDeleteComment_Click;
            this.buttonPreviousComment.Click += buttonPreviousComment_Click;
            this.buttonNextComment.Click += buttonNextComment_Click;
            this.toggleButtonShowHideComments.ToggleStateChanged += toggleButtonShowHideComments_ToggleStateChanged;
            this.buttonDeleteAllComments.Click += buttonDeleteAllComments_Click;

            #endregion

            #region Tracking & Changes group

            this.toggleButtonTrackChanges.ToggleStateChanged += toggleButtonTrackChanges_ToggleStateChanged;

            foreach (RadMenuItemBase item in this.splitButtonAcceptChange.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += SplitButtonAcceptChange_ItemClick;
            }

            foreach (RadMenuItemBase item in this.splitButtonRejectChange.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += SplitButtonRejectChange_ItemClick;
            }

            this.buttonPreviousChange.Click += buttonPreviousChange_Click;
            this.buttonNextChange.Click += buttonNextChange_Click;

            #endregion

            #region Protect group

            this.toggleButtonProtectDocument.Click += toggleButtonProtectDocument_Click;
            this.buttonEditingRestrictions.Click += buttonEditingRestrictions_Click;

            #endregion

            #endregion

            #region View tab

            #region Document views group

            this.buttonWebLayout.Click += buttonWebLayout_Click;
            this.buttonPrintLayout.Click += buttonPrintLayout_Click;

            #endregion

            #endregion

            #region Table Styles tab

            #region Table Style Options group

            this.checkBoxHeaderRow.ToggleStateChanged += checkBoxHeaderRow_ToggleStateChanged;
            this.checkBoxTotalRow.ToggleStateChanged += checkBoxTotalRow_ToggleStateChanged;
            this.checkBoxBandedRows.ToggleStateChanged += checkBoxBandedRows_ToggleStateChanged;

            this.checkBoxFirstColumn.ToggleStateChanged += checkBoxFirstColumn_ToggleStateChanged;
            this.checkBoxLastColumn.ToggleStateChanged += checkBoxLastColumn_ToggleStateChanged;
            this.checkBoxBandedColumns.ToggleStateChanged += checkBoxBandedColumns_ToggleStateChanged;

            #endregion

            #region Table styles group

            #endregion

            #endregion

            #region Table Layout tab

            #region Table group

            foreach (RadMenuItemBase item in this.dropDownButtonSelect.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += dropDownButtonSelect_ItemClick;
            }

            this.buttonProperties.Click += buttonProperties_Click;
            this.buttonDelete.Click += buttonDelete_Click;

            #endregion

            #region Rows group

            this.buttonInsertRow.Click += buttonInsertRow_Click;
            this.buttonInsertBelow.Click += buttonInsertBelow_Click;
            this.buttonInsertAbove.Click += buttonInsertAbove_Click;
            this.buttonDeleteRow.Click += buttonDeleteRow_Click;

            #endregion

            #region Columns group

            this.buttonInsertColumn.Click += buttonInsertColumn_Click;
            this.buttonInsertLeft.Click += buttonInsertLeft_Click;
            this.buttonInsertRight.Click += buttonInsertRight_Click;
            this.buttonDeleteColumn.Click += buttonDeleteColumn_Click;

            #endregion

            #region Merge group

            this.buttonMergeCells.Click += buttonMergeCells_Click;

            #endregion

            #region Cell Size group

            foreach (RadMenuItemBase item in this.dropDownButtonAutoFit.Items)
            {
                if (!(item is RadMenuItem))
                {
                    continue;
                }

                item.Click += dropDownButtonAutoFit_ItemClick;
            }

            #endregion

            #region Alignment group

            this.SubscribeToTableCellAlignmentItemEvents();

            #endregion

            #endregion

            #region Header Footer tab

            #region Insert group

            this.buttonInsertDateAndTime.Click += buttonInsertDateAndTime_Click;
            this.buttonInsertPageNumber.Click += buttonInsertPageNumber_Click;

            #endregion

            #region Navigation group

            this.linkToPrevious.ToggleStateChanged += linkToPrevious_ToggleStateChanged;

            #endregion

            #region Options group

            this.checkBoxDifferentFirstPage.ToggleStateChanged += checkBoxDifferentFirstPage_ToggleStateChanged;
            this.checkBoxDifferentOddAndEvenPages.ToggleStateChanged += checkBoxDifferentOddAndEvenPages_ToggleStateChanged;

            #endregion

            #region Position group

            this.spinElementHeaderFromTop.ValueChanged += spinElementHeaderFromTop_ValueChanged;
            this.spinElementFooterFromBottom.ValueChanged += spinElementFooterFromBottom_ValueChanged;

            #endregion

            #region Close group

            this.buttonCloseHeaderAndFooter.Click += buttonCloseHeaderAndFooter_Click;

            #endregion

            #endregion
        }

        #endregion

        #region Disposal

        protected override void Dispose(bool disposing)
        {
            if (this.AssociatedRichTextEditor != null)
            {
                this.activeEditorCache.CurrentEditingStyleChanged -= ActiveEditor_CurrentEditingStyleChanged;
                this.activeEditorCache = null;
                this.documentCache.CommandExecuted -= Document_CommandExecuted;
                this.documentCache = null;
                this.associatedRichTextEditor.RichTextBoxElement.ActiveDocumentEditorChanged -= RichTextBoxElement_ActiveDocumentEditorChanged;
                this.associatedRichTextEditor.RichTextBoxElement.DocumentChanged -= RichTextBoxElement_DocumentChanged;
                this.associatedRichTextEditor = null;
            }

            base.Dispose(disposing);
        }

        #endregion

        #region Properties

        [Editor(DesignerConsts.RichTextEditorAssociatedEditorString, typeof(UITypeEditor))]
        public RadRichTextEditor AssociatedRichTextEditor
        {
            get { return this.associatedRichTextEditor; }
            set
            {
                if (this.associatedRichTextEditor != value)
                {
                    if (this.associatedRichTextEditor != null)
                    {
                        this.associatedRichTextEditor.RichTextBoxElement.IsInHeaderFooterEditModeChanged -= RichTextBoxElement_IsInHeaderFooterEditModeChanged;
                        this.activeEditorCache.CurrentEditingStyleChanged -= ActiveEditor_CurrentEditingStyleChanged;
                        this.activeEditorCache.CommandExecuted -= ActiveEditor_CommandExecuted;
                        this.activeEditorCache = null;
                        this.associatedRichTextEditor.RichTextBoxElement.ActiveDocumentEditorChanged -= RichTextBoxElement_ActiveDocumentEditorChanged;
                        this.associatedRichTextEditor.RichTextBoxElement.DocumentChanged -= RichTextBoxElement_DocumentChanged;
                        this.documentCache.CommandExecuted -= Document_CommandExecuted;
                        this.documentCache = null;
                    }

                    this.associatedRichTextEditor = value;

                    if (this.associatedRichTextEditor != null)
                    {
                        this.associatedRichTextEditor.RichTextBoxElement.IsInHeaderFooterEditModeChanged += RichTextBoxElement_IsInHeaderFooterEditModeChanged;
                        this.activeEditorCache = this.RichTextBoxActiveEditor;
                        this.activeEditorCache.CurrentEditingStyleChanged += ActiveEditor_CurrentEditingStyleChanged;
                        this.activeEditorCache.CommandExecuted += ActiveEditor_CommandExecuted;
                        this.associatedRichTextEditor.RichTextBoxElement.ActiveDocumentEditorChanged += RichTextBoxElement_ActiveDocumentEditorChanged;
                        this.associatedRichTextEditor.RichTextBoxElement.DocumentChanged += RichTextBoxElement_DocumentChanged;
                        this.documentCache = this.associatedRichTextEditor.RichTextBoxElement.Document;
                        this.documentCache.CommandExecuted += Document_CommandExecuted;
                        this.HandleDocumentCommandExecuted(this.AssociatedRichTextEditor.RichTextBoxElement.Document);
                    }

                    this.OnNotifyPropertyChanged("AssociatedRichTextEditor");
                }
            }
        }

        public Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion BuiltInStylesVersion
        {
            get { return builtInStylesVersion; }
            set
            {
                if (this.builtInStylesVersion != value)
                {
                    builtInStylesVersion = value;

                    this.SetTableStyleItemSource(this.AssociatedRichTextEditor.RichTextBoxElement);
                }
            }
        }

        public override string ThemeClassName
        {
            get { return typeof(RadRibbonBar).ToString(); }
        }

        [Browsable(true), Category(RadDesignCategory.DataCategory)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RadEditItemsAction]
        [RadDescription("CommandTabs", typeof(RadRibbonBarElement))]
        [RadNewItem("Add New Tab...", true, true, false)]
        [Editor(DesignerConsts.RichTextEditorCommandTabsCollectionEditorString, typeof(UITypeEditor))]
        public override RadRibbonBarCommandTabCollection CommandTabs
        {
            get { return base.CommandTabs; }
        }

        [Browsable(true), Category(RadDesignCategory.DataCategory)]
        [RadEditItemsAction]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RadDescription("QuickAccessMenuItems", typeof(RadRibbonBarElement))]
        [RadNewItem("Type here", true, false)]
        [Editor(DesignerConsts.RichTextEditorQuickAccessToolBarItemsCollectionEditorString, typeof(UITypeEditor))]
        public override RadItemOwnerCollection QuickAccessToolBarItems
        {
            get { return base.QuickAccessToolBarItems; }
        }

        [Browsable(false), Category(RadDesignCategory.DataCategory)]
        [RadEditItemsAction]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RadDescription("StartMenuItems", typeof(RadRibbonBarElement))]
        public override RadItemOwnerCollection StartMenuItems
        {
            get { return base.StartMenuItems; }
        }

        [Browsable(false), Category(RadDesignCategory.DataCategory)]
        [RadEditItemsAction]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RadDescription("StartMenuRightColumnItems", typeof(RadRibbonBarElement))]
        public override RadItemOwnerCollection StartMenuRightColumnItems
        {
            get { return base.StartMenuRightColumnItems; }
        }

        #endregion

        #region Implementation

        #region Element Creation

        private RichTextEditorRibbonTab InitializeTab(string text, bool selected)
        {
            RichTextEditorRibbonTab result;
            result = new RichTextEditorRibbonTab();
            result.Class = "RibbonTab";
            result.Text = text;
            result.IsSelected = selected;

            return result;
        }

        private RadRibbonBarGroup InitializeGroup(string text)
        {
            RadRibbonBarGroup group = new RadRibbonBarGroup();
            group.Margin = new System.Windows.Forms.Padding(-1, -1, 0, -1);
            group.Orientation = System.Windows.Forms.Orientation.Vertical;
            group.Text = text;

            return group;
        }

        private RadRibbonBarButtonGroup InitializeButtoneGroup()
        {
            RadRibbonBarButtonGroup group = new RadRibbonBarButtonGroup();
            group.ShowBackColor = false;
            group.ShowBorder = false;

            return group;
        }

        private RadCheckBoxElement InitializeCheckBox(string text)
        {
            RadCheckBoxElement checkBox = new RadCheckBoxElement();

            checkBox.Text = text;

            return checkBox;
        }

        private RadButtonElement InitializeSmallButton(System.Drawing.Image img, string text)
        {
            RadButtonElement button = new RadButtonElement();

            button.DisplayStyle = DisplayStyle.Image;
            button.Image = img;
            button.ImageAlignment = ContentAlignment.MiddleCenter;
            button.MinSize = new System.Drawing.Size(20, 20);
            button.Text = text;
            button.ShowBorder = false;

            return button;
        }

        private RadButtonElement InitializeMediumButton(System.Drawing.Image img, string text)
        {
            RadButtonElement button = new RadButtonElement();
            button.Image = img;
            button.TextAlignment = ContentAlignment.MiddleLeft;
            button.Text = text;
            button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;

            return button;
        }

        private RadButtonElement InitializeBigButton(System.Drawing.Image img, string text)
        {
            RadButtonElement button = new RadButtonElement();
            button.Image = img;
            button.ImageAlignment = ContentAlignment.TopCenter;
            button.TextAlignment = ContentAlignment.TopCenter;
            button.Text = text;
            button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            return button;
        }

        private RadDropDownButtonElement InitializeMediumDropDownButton(System.Drawing.Image img, string text)
        {
            RadDropDownButtonElement dropDownButton = new RadDropDownButtonElement();

            dropDownButton.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            dropDownButton.DropDownDirection = RadDirection.Down;
            dropDownButton.ExpandArrowButton = false;
            dropDownButton.Image = img;
            dropDownButton.ImageAlignment = ContentAlignment.MiddleCenter;
            dropDownButton.Text = text;
            dropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;

            return dropDownButton;
        }

        private RadDropDownButtonElement InitializeSmallDropDownButton(System.Drawing.Image img, string text)
        {
            RadDropDownButtonElement dropDownButton = new RadDropDownButtonElement();

            dropDownButton.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            dropDownButton.ArrowPosition = DropDownButtonArrowPosition.Right;
            dropDownButton.DisplayStyle = DisplayStyle.Image;
            dropDownButton.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            dropDownButton.ExpandArrowButton = false;
            dropDownButton.Image = img;
            dropDownButton.Text = text;
            dropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;

            return dropDownButton;
        }

        private RadDropDownButtonElement InitializeBigDropDownButton(System.Drawing.Image img, string text)
        {
            RadDropDownButtonElement dropDownButton = new RadDropDownButtonElement();

            dropDownButton.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            dropDownButton.ArrowPosition = DropDownButtonArrowPosition.Bottom;
            dropDownButton.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down;
            dropDownButton.ExpandArrowButton = false;
            dropDownButton.Image = img;
            dropDownButton.ImageAlignment = ContentAlignment.TopCenter;
            dropDownButton.TextAlignment = ContentAlignment.TopCenter;
            dropDownButton.Text = text;
            dropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            return dropDownButton;
        }

        private RadSplitButtonElement InitializeMediumSplitButton(System.Drawing.Image img, string text)
        {
            RadSplitButtonElement splitButton = new RadSplitButtonElement();

            splitButton.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            splitButton.DropDownDirection = RadDirection.Down;
            splitButton.ExpandArrowButton = false;
            splitButton.Image = img;
            splitButton.ImageAlignment = ContentAlignment.MiddleCenter;
            splitButton.Text = text;
            splitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;

            return splitButton;
        }

        private RadSplitButtonElement InitializeBigSplitButton(System.Drawing.Image img, string text)
        {
            RadSplitButtonElement splitButton = new RadSplitButtonElement();

            splitButton.ArrowButtonMinSize = new System.Drawing.Size(12, 12);
            splitButton.ArrowPosition = DropDownButtonArrowPosition.Bottom;
            splitButton.DropDownDirection = RadDirection.Down;
            splitButton.ExpandArrowButton = false;
            splitButton.Image = img;
            splitButton.ImageAlignment = ContentAlignment.TopCenter;
            splitButton.Text = text;
            splitButton.TextAlignment = ContentAlignment.TopCenter;
            splitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;

            return splitButton;
        }

        private RadToggleButtonElement InitializeToggleButton(System.Drawing.Image img, string text)
        {
            RadToggleButtonElement toggleButton = new RadToggleButtonElement();
            toggleButton.Text = text;
            toggleButton.DisplayStyle = DisplayStyle.Image;
            toggleButton.Image = img;
            toggleButton.ImageAlignment = ContentAlignment.MiddleCenter;
            toggleButton.MinSize = new System.Drawing.Size(20, 20);
            return toggleButton;
        }

        private RadButtonElement InitializeQuickAccessButton(System.Drawing.Image img, string text)
        {
            RichTextEditorQuickAccessToolbarButtonElement button = new RichTextEditorQuickAccessToolbarButtonElement();

            button.Class = "RibbonBarButtonElement";
            button.DisplayStyle = DisplayStyle.Image;
            button.Text = text;
            button.Image = img;
            button.ImageAlignment = ContentAlignment.MiddleCenter;
            button.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);

            return button;
        }

        #endregion

        #region Populate drop downs

        private List<string> GetFontFamilyItems()
        {
            InstalledFontCollection font = new InstalledFontCollection();

            List<string> families = new List<string>();

            foreach (System.Drawing.FontFamily familiy in font.Families)
            {
                if (familiy.IsStyleAvailable(System.Drawing.FontStyle.Regular) &&
                    familiy.IsStyleAvailable(System.Drawing.FontStyle.Italic) &&
                    familiy.IsStyleAvailable(System.Drawing.FontStyle.Bold))
                {
                    families.Add(familiy.Name);
                }
            }

            return families;
        }

        private BindingList<int> GetFontSizeItems()
        {
            BindingList<int> sizes = new BindingList<int>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            return sizes;
        }

        private RadItemCollection GetMultiLevelListItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuHeaderItem header = new RadMenuHeaderItem("List Library");
            collection.Add(header);

            ListViewMenuItem listView = new ListViewMenuItem();
            listView.ListViewElement.Items.AddRange(this.GetGetMultiLevelListViewDataItems().ToArray());
            listView.ListViewElement.ViewElement.ClearSelection();

            collection.Add(listView);

            listView.ListViewElement.CurrentItemChanging += ListViewElement_CurrentItemChanging;

            RadMenuItem item = new RadMenuItem(DefineNewListStyleText);
            collection.Add(item);

            return collection;
        }

        private List<ListViewDataItem> GetGetMultiLevelListViewDataItems()
        {
            List<ListViewDataItem> result = new List<ListViewDataItem>();

            ListViewDataItem listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.MultilevelListNone;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "None";
            result.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.MultilevelListBulleted;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "Bulleted";
            result.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.MultilevelListNumbered;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "Numbered";
            result.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.MultilevelListNumberedParenthesis;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "NumberedParenthesis";
            result.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.MultilevelListNumberedHierarchical;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "NumberedHierarchical";
            result.Add(listViewItem);

            return result;
        }

        private RadItemCollection GetInsertTableItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuInsertTableItem insertTable = new RadMenuInsertTableItem();
            collection.Add(insertTable);
            insertTable.SelectionChanged += insertTable_SelectionChanged;

            RadMenuItem item = new RadMenuItem("Insert Table...");
            item.Click += item_Click;
            item.Image = Resources.InsertTable16;

            collection.Add(item);

            return collection;
        }

        private IEnumerable<PaperSize> GetPaperSizes()
        {
            yield return new PaperSize("A0", 3305, 4678);
            yield return new PaperSize("A1", 2339, 3305);
            yield return new PaperSize("A2", 1653, 2339);
            yield return new PaperSize("A3", 1170, 1653);
            yield return new PaperSize("A4", 826, 1170);
            yield return new PaperSize("A5", 583, 826);
            yield return new PaperSize("RA0", 3386, 4803);
            yield return new PaperSize("RA1", 2401, 3386);
            yield return new PaperSize("RA2", 1693, 2401);
            yield return new PaperSize("RA3", 1201, 1693);
            yield return new PaperSize("RA4", 846, 1201);
            yield return new PaperSize("RA5", 476, 846);
            yield return new PaperSize("B0", 3938, 5567);
            yield return new PaperSize("B1", 2783, 3938);
            yield return new PaperSize("B2", 5905, 1968);
            yield return new PaperSize("B3", 1391, 1968);
            yield return new PaperSize("B4", 1013, 1433);
            yield return new PaperSize("B5", 717, 1013);
            yield return new PaperSize("Quarto", 800, 1000);
            yield return new PaperSize("Foolscap", 800, 1300);
            yield return new PaperSize("Executive", 750, 1000);
            yield return new PaperSize("GovernmentLetter", 1050, 800);
            yield return new PaperSize("Letter", 850, 1100);
            yield return new PaperSize("Legal", 850, 1400);
            yield return new PaperSize("Ledger", 1700, 1100);
            yield return new PaperSize("Tabloid", 1100, 1700);
            yield return new PaperSize("Post", 1564, 1925);
            yield return new PaperSize("Crown", 2000, 1500);
            yield return new PaperSize("LargePost", 1650, 2100);
            yield return new PaperSize("Demy", 1750, 2200);
            yield return new PaperSize("Medium", 1800, 2300);
            yield return new PaperSize("Royal", 2000, 2500);
            yield return new PaperSize("Elephant", 2174, 2800);
            yield return new PaperSize("DoubleDemy", 2350, 3500);
            yield return new PaperSize("QuadDemy", 3500, 4500);
            yield return new PaperSize("STMT", 550, 850);
            yield return new PaperSize("Folio", 850, 1300);
            yield return new PaperSize("Statement", 550, 850);
            yield return new PaperSize("Size10x14", 1000, 1400);
        }

        private RadItemCollection GetPaperSizeItems()
        {
            RadItemCollection collection = new RadItemCollection();

            foreach (PaperSize paperSize in this.GetPaperSizes())
            {
                float width = (float)paperSize.Width / 100f;
                float height = (float)paperSize.Height / 100f;
                string formatString = string.Empty;

                if (System.Globalization.RegionInfo.CurrentRegion.IsMetric)
                {
                    width *= 2.54f;
                    height *= 2.54f;
                    formatString = "<html><b>{0}</b> ({1:F1}cm x {2:F1}cm)</html>";
                }
                else
                {
                    formatString = "<html><b>{0}</b> ({1:F1}\" x {2:F1}\")</html>";
                }

                RadMenuItem item = new RadMenuItem();
                item.Text = string.Format(formatString, paperSize.PaperName, width, height);
                item.Tag = Enum.Parse(typeof(PaperTypes), paperSize.PaperName);

                collection.Add(item);
            }

            return collection;
        }

        private RadItemCollection GetPageMarginItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuItem item = new RadMenuItem("Normal");
            item.Image = Resources.PageMarginNormal;
            item.Tag = PageMarginTypes.Normal;
            collection.Add(item);

            item = new RadMenuItem("Narrow");
            item.Image = Resources.PageMarginNarrow;
            item.Tag = PageMarginTypes.Narrow;
            collection.Add(item);

            item = new RadMenuItem("Moderate");
            item.Image = Resources.PageMarginModerate;
            item.Tag = PageMarginTypes.Moderate;
            collection.Add(item);

            item = new RadMenuItem("Wide");
            item.Image = Resources.PageMarginWide;
            item.Tag = PageMarginTypes.Wide;
            collection.Add(item);

            item = new RadMenuItem("Office2003");
            item.Image = Resources.PageMarginNormal;
            item.Tag = PageMarginTypes.Office2003;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetPageOrientationItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuItem item = new RadMenuItem("Portrait");
            item.Image = Resources.PageOrientationPortrait32;
            item.Tag = PageOrientation.Portrait;
            collection.Add(item);

            item = new RadMenuItem("Landscape");
            item.Image = Resources.PageOrientationLandscape32;
            item.Tag = PageOrientation.Landscape;
            collection.Add(item);

            item = new RadMenuItem("Rotate 180");
            item.Image = Resources.PageOrientationRotate18032;
            item.Tag = PageOrientation.Rotate180;
            collection.Add(item);

            item = new RadMenuItem("Rotate 270");
            item.Image = Resources.PageOrientationRotate27032;
            item.Tag = PageOrientation.Rotate270;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetPageBreakItems()
        {
            RadItemCollection collection = new RadItemCollection();

            collection.Add(new RadMenuHeaderItem("Page Breaks"));

            RadMenuItem item = new RadMenuItem("Page");
            item.Image = Resources.PageBreak32;
            collection.Add(item);

            collection.Add(new RadMenuHeaderItem("Page Breaks"));

            item = new RadMenuItem("Next Page");
            item.Image = Resources.NextPageSectionBreak32;
            item.Tag = SectionBreakType.NextPage;
            collection.Add(item);

            item = new RadMenuItem("Even Page");
            item.Image = Resources.EvenPageSectionBreak32;
            item.Tag = SectionBreakType.EvenPage;
            collection.Add(item);

            item = new RadMenuItem("Odd Page");
            item.Image = Resources.OddPageSectionBreak32;
            item.Tag = SectionBreakType.OddPage;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetWatermarkItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuHeaderItem header = new RadMenuHeaderItem("Predefined");
            collection.Add(header);

            ListViewMenuItem listItem = new ListViewMenuItem();

            ListViewDataItem listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.confidentialR;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "ConfidentialRotated";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.confidential;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "Confidential";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.doNotCopyR;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "DoNotCopyRotated";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.doNotCopy;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "DoNotCopy";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.draftR;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "DraftRotated";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.draft;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "Draft";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.sampleR;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "SampleRotated";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.sample;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "Sample";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.asapR;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "AsapRotated";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.asap;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "Asap";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.urgentR;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "UrgentRotated";
            listItem.ListViewElement.Items.Add(listViewItem);

            listViewItem = new ListViewDataItem();
            listViewItem.Image = Resources.urgent;
            listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
            listViewItem.Tag = "Urgent";
            listItem.ListViewElement.Items.Add(listViewItem);

            collection.Add(listItem);

            listItem.ListViewElement.SelectedIndexChanged += WatermarkListView_SelectedIndexChanged;

            RadMenuSeparatorItem separator = new RadMenuSeparatorItem();
            collection.Add(separator);

            RadMenuItem item = new RadMenuItem(InsertCustomWatermarkText);
            item.Image = Resources.Watermark16;
            collection.Add(item);

            item = new RadMenuItem(RemoveWatermarkText);
            item.Image = Resources.RemoveWatermark16;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetNotesNavigationItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuItem item = new RadMenuItem("Next Footnote");
            item.Image = Resources.NextNote16;
            collection.Add(item);

            item = new RadMenuItem("Previous Footnote");
            item.Image = Resources.PreviousNote16;
            collection.Add(item);

            item = new RadMenuItem("Next Endnote");
            item.Image = Resources.NextNote16;
            collection.Add(item);

            item = new RadMenuItem("Previous Endnote");
            item.Image = Resources.PreviousNote16;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetInsertCitationItems()
        {
            RadItemCollection collection = new RadItemCollection();

            collection.Add(new RadMenuSeparatorItem());

            RadMenuItem item = new RadMenuItem(AddNewCitationSourceText);
            item.Image = Resources.AddNewSource16;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetTableToolsItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuItem item = new RadMenuItem("Select Cell");
            item.Image = Resources.SelectTableCell16;
            collection.Add(item);

            item = new RadMenuItem("Select Column");
            item.Image = Resources.SelectTableColumn16;
            collection.Add(item);

            item = new RadMenuItem("Select Row");
            item.Image = Resources.SelectTableRow16;
            collection.Add(item);

            item = new RadMenuItem("Select Table");
            item.Image = Resources.SelectTable16;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetAutoFitItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuItem item = new RadMenuItem("AutoFit to Window");
            item.Image = Resources.AutoFItToWindow16;
            item.Tag = "AutoFit";
            collection.Add(item);

            item = new RadMenuItem("Fixed Column Width");
            item.Image = Resources.FixedColumnWidth16;
            item.Tag = "Fixed";
            collection.Add(item);

            return collection;
        }

        private void dropDownButtonInsertCitation_DropDownOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            while (this.dropDownButtonInsertCitation.Items.Count > 2)
            {
                this.dropDownButtonInsertCitation.Items.RemoveAt(0);
            }

            foreach (BibliographicSource source in this.AssociatedRichTextEditor.Document.BibliographicSources)
            {
                RadMenuItem item = new RadMenuItem();
                item.Text = source.SourceListDisplayString;
                item.Tag = source;
                item.Click += InsertCitation_ItemClick;

                this.dropDownButtonInsertCitation.Items.Insert(this.dropDownButtonInsertCitation.Items.Count - 2, item);
            }
        }

        private IEnumerable<BibliographicReferenceStyleBase> GetCitationStyleItems()
        {
            List<BibliographicReferenceStyleBase> list = new List<BibliographicReferenceStyleBase>();

            list.Add(new APAFifthEditionStyle());
            list.Add(new HarvardAnglia2008Style());
            list.Add(new ISO690_FirstElementAndDateStyle());

            return list;
        }

        private void dropDownButtonInsertMergeField_DropDownOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.dropDownButtonInsertMergeField.Items.Clear();

            foreach (string fieldName in this.AssociatedRichTextEditor.Document.MailMergeDataSource.GetColumnNames())
            {
                RadMenuItem item = new RadMenuItem();
                item.Text = fieldName;
                item.Click += DropDownButtonInsertMergeField_ItemClick;

                this.dropDownButtonInsertMergeField.Items.Add(item);
            }
        }

        private RadItemCollection GetAcceptChangeItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuItem item = new RadMenuItem(AcceptChangeText);
            item.Image = Resources.AcceptChange16;
            collection.Add(item);

            item = new RadMenuItem(AcceptAllChangesText);
            item.Image = Resources.AcceptChange16;
            collection.Add(item);

            return collection;
        }

        private RadItemCollection GetRejectChangeItems()
        {
            RadItemCollection collection = new RadItemCollection();

            RadMenuItem item = new RadMenuItem(RejectChangeText);
            item.Image = Resources.RejectChange16;
            collection.Add(item);

            item = new RadMenuItem(RejectAllChangesText);
            item.Image = Resources.RejectChange16;
            collection.Add(item);

            return collection;
        }

        #endregion

        #region Commands

        private void ExecuteCommand(RichTextBoxCommandBase command)
        {
            command.Execute();
            this.AssociatedRichTextEditor.ElementTree.Control.Focus();
        }

        private void ExecuteCommand(RichTextBoxCommandBase command, object parameter)
        {
            command.Execute(parameter);
            this.AssociatedRichTextEditor.ElementTree.Control.Focus();
        }

        private void HandleDocumentCommandExecuted(RadDocument document)
        {
            bool hasComments = document.EnumerateChildrenOfType<CommentRangeStart>().Count() > 0;

            this.buttonPreviousComment.Enabled = hasComments;
            this.buttonNextComment.Enabled = hasComments;
            this.buttonDeleteComment.Enabled = hasComments;
            this.buttonDeleteAllComments.Enabled = hasComments;

            this.buttonUndo.Enabled = document.History.CanUndo;
            this.buttonRedo.Enabled = document.History.CanRedo;
        }

        #endregion

        #region Helper Methods

        private void WireStyleEvents()
        {
            this.dropDownListFont.SelectedIndexChanged += dropDownListFont_SelectedIndexChanged;
            this.dropDownListFontSize.SelectedIndexChanged += dropDownListFontSize_SelectedIndexChanged;
            this.toggleButtonBoldStyle.ToggleStateChanged += toggleButtonBoldStyle_ToggleStateChanged;
            this.toggleButtonItalicStyle.ToggleStateChanged += toggleButtonItalicStyle_ToggleStateChanged;
            this.toggleButtonUnderlineStyle.ToggleStateChanged += toggleButtonUnderlineStyle_ToggleStateChanged;
            this.toggleButtonStrikethroughStyle.ToggleStateChanged += toggleButtonStrikethroughStyle_ToggleStateChanged;
            this.toggleButtonSubscript.ToggleStateChanged += toggleButtonSubscript_ToggleStateChanged;
            this.toggleButtonSuperscript.ToggleStateChanged += toggleButtonSuperscript_ToggleStateChanged;
            this.toggleButtonBulletedList.ToggleStateChanged += toggleButtonBulletedList_ToggleStateChanged;
            this.toggleButtonNumberedList.ToggleStateChanged += toggleButtonNumberedList_ToggleStateChanged;
            this.toggleButtonLeftToRightTextDirection.ToggleStateChanged += toggleButtonLeftToRightTextDirection_ToggleStateChanged;
            this.toggleButtonRightToLeftTextDirection.ToggleStateChanged += toggleButtonRightToLeftTextDirection_ToggleStateChanged;
            this.toggleButtonTextAlignLeft.ToggleStateChanged += toggleButtonTextAlignLeft_ToggleStateChanged;
            this.toggleButtonTextAlignCenter.ToggleStateChanged += toggleButtonTextAlignCenter_ToggleStateChanged;
            this.toggleButtonTextAlignRight.ToggleStateChanged += toggleButtonTextAlignRight_ToggleStateChanged;
            this.toggleButtonTextAlignJustify.ToggleStateChanged += toggleButtonTextAlignJustify_ToggleStateChanged;
        }

        private void UnwireStyleEvents()
        {
            this.dropDownListFont.SelectedIndexChanged -= dropDownListFont_SelectedIndexChanged;
            this.dropDownListFontSize.SelectedIndexChanged -= dropDownListFontSize_SelectedIndexChanged;
            this.toggleButtonBoldStyle.ToggleStateChanged -= toggleButtonBoldStyle_ToggleStateChanged;
            this.toggleButtonItalicStyle.ToggleStateChanged -= toggleButtonItalicStyle_ToggleStateChanged;
            this.toggleButtonUnderlineStyle.ToggleStateChanged -= toggleButtonUnderlineStyle_ToggleStateChanged;
            this.toggleButtonStrikethroughStyle.ToggleStateChanged -= toggleButtonStrikethroughStyle_ToggleStateChanged;
            this.toggleButtonSubscript.ToggleStateChanged -= toggleButtonSubscript_ToggleStateChanged;
            this.toggleButtonSuperscript.ToggleStateChanged -= toggleButtonSuperscript_ToggleStateChanged;
            this.toggleButtonBulletedList.ToggleStateChanged -= toggleButtonBulletedList_ToggleStateChanged;
            this.toggleButtonNumberedList.ToggleStateChanged -= toggleButtonNumberedList_ToggleStateChanged;
            this.toggleButtonLeftToRightTextDirection.ToggleStateChanged -= toggleButtonLeftToRightTextDirection_ToggleStateChanged;
            this.toggleButtonRightToLeftTextDirection.ToggleStateChanged -= toggleButtonRightToLeftTextDirection_ToggleStateChanged;
            this.toggleButtonTextAlignLeft.ToggleStateChanged -= toggleButtonTextAlignLeft_ToggleStateChanged;
            this.toggleButtonTextAlignCenter.ToggleStateChanged -= toggleButtonTextAlignCenter_ToggleStateChanged;
            this.toggleButtonTextAlignRight.ToggleStateChanged -= toggleButtonTextAlignRight_ToggleStateChanged;
            this.toggleButtonTextAlignJustify.ToggleStateChanged -= toggleButtonTextAlignJustify_ToggleStateChanged;
        }

        private void SubscribeToTableCellAlignmentItemEvents()
        {
            this.buttonTopLeftAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonTopCenterAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonTopRightAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonMiddleLeftAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonMiddleCenterAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonMiddleRightAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonBottomLeftAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonBottomCenterAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
            this.buttonBottomRightAlignment.ToggleStateChanged += buttonCellAlignment_ToggleStateChanged;
        }

        private void UnsubscribeToTableCellAlignmentItemEvents()
        {
            this.buttonTopLeftAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonTopCenterAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonTopRightAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonMiddleLeftAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonMiddleCenterAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonMiddleRightAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonBottomLeftAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonBottomCenterAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
            this.buttonBottomRightAlignment.ToggleStateChanged -= buttonCellAlignment_ToggleStateChanged;
        }

        private void SubscribeFromTableLookItemEvents()
        {
            this.checkBoxHeaderRow.ToggleStateChanged += checkBoxHeaderRow_ToggleStateChanged;
            this.checkBoxTotalRow.ToggleStateChanged += checkBoxTotalRow_ToggleStateChanged;
            this.checkBoxBandedRows.ToggleStateChanged += checkBoxBandedRows_ToggleStateChanged;

            this.checkBoxFirstColumn.ToggleStateChanged += checkBoxFirstColumn_ToggleStateChanged;
            this.checkBoxLastColumn.ToggleStateChanged += checkBoxLastColumn_ToggleStateChanged;
            this.checkBoxBandedColumns.ToggleStateChanged += checkBoxBandedColumns_ToggleStateChanged;
        }

        private void UnsubscribeFromTableLookItemEvents()
        {
            this.checkBoxHeaderRow.ToggleStateChanged -= checkBoxHeaderRow_ToggleStateChanged;
            this.checkBoxTotalRow.ToggleStateChanged -= checkBoxTotalRow_ToggleStateChanged;
            this.checkBoxBandedRows.ToggleStateChanged -= checkBoxBandedRows_ToggleStateChanged;

            this.checkBoxFirstColumn.ToggleStateChanged -= checkBoxFirstColumn_ToggleStateChanged;
            this.checkBoxLastColumn.ToggleStateChanged -= checkBoxLastColumn_ToggleStateChanged;
            this.checkBoxBandedColumns.ToggleStateChanged -= checkBoxBandedColumns_ToggleStateChanged;
        }

        private void ToggleCellAlignmentButton(RadToggleButtonElement button)
        {
            this.buttonTopLeftAlignment.IsChecked = this.buttonTopLeftAlignment.Equals(button);
            this.buttonTopCenterAlignment.IsChecked = this.buttonTopCenterAlignment.Equals(button);
            this.buttonTopRightAlignment.IsChecked = this.buttonTopRightAlignment.Equals(button);
            this.buttonMiddleLeftAlignment.IsChecked = this.buttonMiddleLeftAlignment.Equals(button);
            this.buttonMiddleCenterAlignment.IsChecked = this.buttonMiddleCenterAlignment.Equals(button);
            this.buttonMiddleRightAlignment.IsChecked = this.buttonMiddleRightAlignment.Equals(button);
            this.buttonBottomLeftAlignment.IsChecked = this.buttonBottomLeftAlignment.Equals(button);
            this.buttonBottomCenterAlignment.IsChecked = this.buttonBottomCenterAlignment.Equals(button);
            this.buttonBottomRightAlignment.IsChecked = this.buttonBottomRightAlignment.Equals(button);
        }

        private void HandleFontStylePropertiesOnCurrentEditingStyleChanged()
        {
            this.UnwireStyleEvents();

            StyleUIHelper helper = new StyleUIHelper(this.RichTextBoxActiveEditor);

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
                this.toggleButtonBoldStyle.IsChecked = fontWeight.Value.ToOpenTypeWeight() > 400;
            }

            //Italic
            Telerik.WinControls.RichTextEditor.UI.FontStyle? fontStyle = helper.GetFontStyleOfSpanStyle();

            if (fontStyle.HasValue)
            {
                this.toggleButtonItalicStyle.IsChecked = fontStyle.Value != FontStyles.Normal;
            }

            //Underline
            bool? underline = helper.GetUnderline();

            if (underline.HasValue)
            {
                this.toggleButtonUnderlineStyle.IsChecked = underline.Value;
            }

            //Striketrough
            bool? strikethrough = helper.GetStrikeThroughOfSpanStyle();

            if (strikethrough.HasValue)
            {
                this.toggleButtonStrikethroughStyle.IsChecked = strikethrough.Value;
            }

            //Baseline alignment
            BaselineAlignment? baselineAlignment = helper.GetBaselineAlignment();

            if (baselineAlignment.HasValue)
            {
                this.toggleButtonSubscript.IsChecked = baselineAlignment.Value == BaselineAlignment.Subscript;
                this.toggleButtonSuperscript.IsChecked = baselineAlignment.Value == BaselineAlignment.Superscript;
            }

            //Bullets
            this.toggleButtonBulletedList.IsChecked = helper.GetIsBulleted();
            this.toggleButtonNumberedList.IsChecked = helper.GetIsNumbered();

            //Text flow
            FlowDirection? flow = helper.GetParagraphTextFlowDirection();

            if (flow.HasValue)
            {
                this.toggleButtonLeftToRightTextDirection.IsChecked = flow.Value == FlowDirection.LeftToRight;
                this.toggleButtonRightToLeftTextDirection.IsChecked = flow.Value == FlowDirection.RightToLeft;
            }

            //Text alignment
            Telerik.WinForms.Documents.Layout.RadTextAlignment? textAlignment = helper.GetTextAlignmentOfParagraphStyle();

            if (textAlignment.HasValue)
            {
                this.toggleButtonTextAlignLeft.IsChecked = textAlignment.Value == Telerik.WinForms.Documents.Layout.RadTextAlignment.Left;
                this.toggleButtonTextAlignCenter.IsChecked = textAlignment.Value == Telerik.WinForms.Documents.Layout.RadTextAlignment.Center;
                this.toggleButtonTextAlignRight.IsChecked = textAlignment.Value == Telerik.WinForms.Documents.Layout.RadTextAlignment.Right;
                this.toggleButtonTextAlignJustify.IsChecked = textAlignment.Value == Telerik.WinForms.Documents.Layout.RadTextAlignment.Justify;
            }

            this.WireStyleEvents();
        }

        private void HandleTableStylePropertiesOnCurrentEditingStyleChanged()
        {
            Paragraph p = this.GetCurrentParagraph();

            if (p == null)
            {
                return;
            }

            TableCell cell = p.Parent as TableCell;

            if (cell != null)
            {
                this.UnsubscribeToTableCellAlignmentItemEvents();

                switch (cell.VerticalAlignment)
                {
                    case Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Top:
                        switch (cell.TextAlignment)
                        {
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Left:
                                this.ToggleCellAlignmentButton(this.buttonTopLeftAlignment);
                                break;
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Center:
                                this.ToggleCellAlignmentButton(this.buttonTopCenterAlignment);
                                break;
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Right:
                                this.ToggleCellAlignmentButton(this.buttonTopRightAlignment);
                                break;
                        }
                        break;
                    case Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Center:
                        switch (cell.TextAlignment)
                        {
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Left:
                                this.ToggleCellAlignmentButton(this.buttonMiddleLeftAlignment);
                                break;
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Center:
                                this.ToggleCellAlignmentButton(this.buttonMiddleCenterAlignment);
                                break;
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Right:
                                this.ToggleCellAlignmentButton(this.buttonMiddleRightAlignment);
                                break;
                        }
                        break;
                    case Telerik.WinForms.Documents.Layout.RadVerticalAlignment.Bottom:
                        switch (cell.TextAlignment)
                        {
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Left:
                                this.ToggleCellAlignmentButton(this.buttonBottomLeftAlignment);
                                break;
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Center:
                                this.ToggleCellAlignmentButton(this.buttonBottomCenterAlignment);
                                break;
                            case Telerik.WinForms.Documents.Layout.RadTextAlignment.Right:
                                this.ToggleCellAlignmentButton(this.buttonBottomRightAlignment);
                                break;
                        }
                        break;
                }

                this.SubscribeToTableCellAlignmentItemEvents();

                Table table = ((TableCell)p.Parent).Row.Table;

                if (!this.tabTableLayout.IsSelected && !this.tabTableStyle.IsSelected)
                {
                    this.UnsubscribeFromTableLookItemEvents();

                    this.checkBoxHeaderRow.IsChecked = table.TableLook.ApplyFirstRow;
                    this.checkBoxTotalRow.IsChecked = table.TableLook.ApplyLastRow;
                    this.checkBoxBandedRows.IsChecked = table.TableLook.ApplyRowBanding;
                    this.checkBoxFirstColumn.IsChecked = table.TableLook.ApplyFirstColumn;
                    this.checkBoxLastColumn.IsChecked = table.TableLook.ApplyLastColumn;
                    this.checkBoxBandedColumns.IsChecked = table.TableLook.ApplyColumnBanding;

                    this.TableLook.ApplyColumnBanding = this.checkBoxBandedColumns.IsChecked;
                    this.TableLook.ApplyFirstColumn = this.checkBoxFirstColumn.IsChecked;
                    this.TableLook.ApplyLastColumn = this.checkBoxLastColumn.IsChecked;
                    this.TableLook.ApplyRowBanding = this.checkBoxBandedRows.IsChecked;
                    this.TableLook.ApplyFirstRow = this.checkBoxHeaderRow.IsChecked;
                    this.TableLook.ApplyLastRow = this.checkBoxTotalRow.IsChecked;

                    this.SubscribeFromTableLookItemEvents();

                    if (!CommandTabs.Contains(this.tabTableStyle))
                    {
                        this.CommandTabs.AddRange(this.tabTableStyle, this.tabTableLayout);
                        this.ContextualTabGroups.AddRange(this.tabGroupTable);

                        this.tabGroupTable.TabItems.AddRange(this.tabTableStyle, this.tabTableLayout);

                        this.openTabCache = this.SelectedCommandTab;
                        this.tabTableStyle.IsSelected = true;
                        this.RibbonBarElement.InvalidateMeasure(true);
                        this.RibbonBarElement.UpdateLayout();
                    }
                }
            }
            else
            {
                if (this.openTabCache != null)
                {
                    this.openTabCache.IsSelected = true;
                }
                else
                {
                    this.tabHome.IsSelected = true;
                }

                this.CommandTabs.Remove(this.tabTableStyle);
                this.CommandTabs.Remove(this.tabTableLayout);
                this.tabTableStyle.IsSelected = false;
                this.tabTableLayout.IsSelected = false;
                this.ContextualTabGroups.Remove(this.tabGroupTable);
                this.tabGroupTable.TabItems.Remove(this.tabTableStyle);
                this.tabGroupTable.TabItems.Remove(this.tabTableLayout);
            }
        }

        #endregion

        #endregion

        #region Event handlers

        #region Application menu

        private void backstageButtonNew_Click(object sender, EventArgs e)
        {
            NewDocumentCommand command = new NewDocumentCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);

            this.backstageView.Hide();
        }

        private void backstageButtonOpen_Click(object sender, EventArgs e)
        {
            OpenDocumentCommand command = new OpenDocumentCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);

            this.backstageView.Hide();
        }

        private void backstageButtonPrint_Click(object sender, EventArgs e)
        {
            this.backstageView.Hide();

            PrintCommand command = new PrintCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
        }

        private void backstageButtonSave_Click(object sender, EventArgs e)
        {
            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
        }

        private void buttonSaveWord_Click(object sender, EventArgs e)
        {
            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, "docx");
        }

        private void buttonSavePDF_Click(object sender, EventArgs e)
        {
            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, "pdf");
        }

        private void buttonSaveHTML_Click(object sender, EventArgs e)
        {
            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, "html");
        }

        private void buttonSaveRich_Click(object sender, EventArgs e)
        {
            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, "rtf");
        }

        private void buttonSavePlain_Click(object sender, EventArgs e)
        {
            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, "txt");
        }

        private void buttonXAML_Click(object sender, EventArgs e)
        {
            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, "xaml");
        }

        #endregion

        #region Quick access toolbar

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.BackstageControl.HidePopup();

            SaveCommand command = new SaveCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            this.BackstageControl.HidePopup();

            UndoCommand command = new UndoCommand(this.AssociatedRichTextEditor.RichTextBoxElement.ActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            this.BackstageControl.HidePopup();

            RedoCommand command = new RedoCommand(this.AssociatedRichTextEditor.RichTextBoxElement.ActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Home tab

        #region Clipboard group

        private void buttonCut_Click(object sender, EventArgs e)
        {
            this.AssociatedRichTextEditor.RichTextBoxElement.Commands.CutCommand.Execute();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            this.AssociatedRichTextEditor.RichTextBoxElement.Commands.CopyCommand.Execute();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            this.AssociatedRichTextEditor.RichTextBoxElement.Commands.PasteCommand.Execute();
        }

        #endregion

        #region Font group

        private RadRichTextBox RichTextBoxActiveEditor
        {
            get
            {
                return (this.AssociatedRichTextEditor.RichTextBoxElement.ActiveDocumentEditor as RadRichTextBox);
            }
        }

        private void dropDownListFont_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.AssociatedRichTextEditor == null)
            {
                return;
            }

            ChangeFontFamilyCommand command = new ChangeFontFamilyCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, this.dropDownListFont.SelectedItem.DataBoundItem);
        }

        private void dropDownListFontSize_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.AssociatedRichTextEditor == null)
            {
                return;
            }

            ChangeFontSizeCommand command = new ChangeFontSizeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, this.dropDownListFontSize.SelectedValue.ToString());
        }

        private void buttonIncreaseFontSize_Click(object sender, EventArgs e)
        {
            IncrementFontSizeCommand command = new IncrementFontSizeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonDecreaseFontSize_Click(object sender, EventArgs e)
        {
            DecrementFontSizeCommand command = new DecrementFontSizeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonClearFormatting_Click(object sender, EventArgs e)
        {
            ClearAllFormattingCommand command = new ClearAllFormattingCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonBoldStyle_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleBoldCommand command = new ToggleBoldCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonItalicStyle_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleItalicCommand command = new ToggleItalicCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonUnderlineStyle_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleUnderlineCommand command = new ToggleUnderlineCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonStrikethroughStyle_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleStrikethroughCommand command = new ToggleStrikethroughCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonSubscript_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleSubscriptCommand command = new ToggleSubscriptCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonSuperscript_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleSuperscriptCommand command = new ToggleSuperscriptCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ChangeFontHighlightColorCommand command = new ChangeFontHighlightColorCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command, (Telerik.WinControls.RichTextEditor.UI.Color)dialog.SelectedColor);
            }
        }

        private void buttonForeColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ChangeFontForeColorCommand command = new ChangeFontForeColorCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command, (Telerik.WinControls.RichTextEditor.UI.Color)dialog.SelectedColor);
            }
        }

        private void groupFont_DialogButtonClick(object sender, EventArgs e)
        {
            ShowFontPropertiesDialogCommand command = new ShowFontPropertiesDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Paragraph group

        private void toggleButtonBulletedList_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleBulletsCommand command = new ToggleBulletsCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonNumberedList_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleNumberedCommand command = new ToggleNumberedCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void menuItemDefineNewListStyle_Click(object sender, EventArgs e)
        {
            ShowDefineNewListStyleDialogCommand command = new ShowDefineNewListStyleDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }


        void ListViewElement_CurrentItemChanging(object sender, ListViewItemChangingEventArgs e)
        {
            RadListViewElement listView = sender as RadListViewElement;
            ChangeListStyleCommand command = new ChangeListStyleCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, listView.SelectedItem.Tag);

            listView.ViewElement.ClearSelection();
            e.Cancel = true;
        }

        private void buttonDecreaseIndent_Click(object sender, EventArgs e)
        {
            DecrementParagraphLeftIndentCommand command = new DecrementParagraphLeftIndentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonIncreaseIndent_Click(object sender, EventArgs e)
        {
            IncrementParagraphLeftIndentCommand command = new IncrementParagraphLeftIndentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonLeftToRightTextDirection_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ChangeParagraphFlowDirectionCommand command = new ChangeParagraphFlowDirectionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, FlowDirection.LeftToRight);
        }

        private void toggleButtonRightToLeftTextDirection_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ChangeParagraphFlowDirectionCommand command = new ChangeParagraphFlowDirectionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, FlowDirection.RightToLeft);
        }

        private void toggleButtonShowFormattingSymbols_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleFormattingSymbolsCommand command = new ToggleFormattingSymbolsCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonTextAlignLeft_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, Telerik.WinForms.Documents.Layout.RadTextAlignment.Left);
        }

        private void toggleButtonTextAlignCenter_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, Telerik.WinForms.Documents.Layout.RadTextAlignment.Center);
        }

        private void toggleButtonTextAlignRight_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, Telerik.WinForms.Documents.Layout.RadTextAlignment.Right);
        }

        private void toggleButtonTextAlignJustify_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ChangeTextAlignmentCommand command = new ChangeTextAlignmentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, Telerik.WinForms.Documents.Layout.RadTextAlignment.Justify);
        }

        private void buttonParagraphBackColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ChangeParagraphBackgroundColorCommand command = new ChangeParagraphBackgroundColorCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command, (Telerik.WinControls.RichTextEditor.UI.Color)dialog.SelectedColor);
            }
        }

        private void groupParagraph_DialogButtonClick(object sender, EventArgs e)
        {
            ShowParagraphPropertiesDialogCommand command = new ShowParagraphPropertiesDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Editing & Proofing group

        private void buttonFindAndReplace_Click(object sender, EventArgs e)
        {
            ShowFindReplaceDialogCommand command = new ShowFindReplaceDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonEnableSpellCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleSpellCheckingCommand command = new ToggleSpellCheckingCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);

            this.buttonFindNextError.Enabled = args.ToggleState == ToggleState.On;
        }

        private void buttonFindNextError_Click(object sender, EventArgs e)
        {
            OpenContextMenuOnNextSpellingErrorCommand command = new OpenContextMenuOnNextSpellingErrorCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Styles group

        private void buttonChangeStyles_Click(object sender, EventArgs e)
        {
            ShowManageStylesDialogCommand command = new ShowManageStylesDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #endregion

        #region Insert tab

        #region Pages group

        private void buttonPageBreak_Click(object sender, EventArgs e)
        {
            InsertPageBreakCommand command = new InsertPageBreakCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Tables group

        private void insertTable_SelectionChanged(object sender, TableSelectionChangedEventArgs e)
        {
            InsertTableCommand command = new InsertTableCommand(this.RichTextBoxActiveEditor);
            InsertTableCommandParameter parameter = new InsertTableCommandParameter(e.RowIndex + 1, e.ColumnIndex + 1);
            this.ExecuteCommand(command, parameter);
        }

        private void item_Click(object sender, EventArgs e)
        {
            this.RichTextBoxActiveEditor.ShowInsertTableDialog();
        }

        #endregion

        #region Illustrations group

        private void buttonInsertImage_Click(object sender, EventArgs e)
        {
            InsertPictureCommand command = new InsertPictureCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Links group

        private void buttonInsertHyperlink_Click(object sender, EventArgs e)
        {
            ShowInsertHyperlinkDialogCommand command = new ShowInsertHyperlinkDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonManageBookmarks_Click(object sender, EventArgs e)
        {
            ShowManageBookmarksDialogCommand command = new ShowManageBookmarksDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonInsertCrossReference_Click(object sender, EventArgs e)
        {
            ShowInsertCrossReferenceWindowCommand command = new ShowInsertCrossReferenceWindowCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Comments group

        private void buttonInsertNewComment_Click(object sender, EventArgs e)
        {
            InsertCommentCommand command = new InsertCommentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Header & Footer group

        private void buttonHeader_Click(object sender, EventArgs e)
        {
            EditHeaderCommand command = new EditHeaderCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonFooter_Click(object sender, EventArgs e)
        {
            EditFooterCommand command = new EditFooterCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Text group

        private void buttonDateAndTime_Click(object sender, EventArgs e)
        {
            ShowInsertDateTimeDialogCommand command = new ShowInsertDateTimeDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonPageNumber_Click(object sender, EventArgs e)
        {
            InsertPageFieldCommand command = new InsertPageFieldCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            ShowCodeFormattingDialogCommand command = new ShowCodeFormattingDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Symbols group

        private void buttonInsertSymbol_Click(object sender, EventArgs e)
        {
            ShowInsertSymbolWindowCommand command = new ShowInsertSymbolWindowCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #endregion

        #region Page Layout tab

        #region Page Setup group

        private void DropDownButtonSize_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            ChangePaperTypeCommand command = new ChangePaperTypeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, item.Tag);
        }

        private void dropDownButtonMargins_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            ChangePageMarginsTypeCommand command = new ChangePageMarginsTypeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, item.Tag);
        }

        private void dropDownButtonOrientation_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            ChangePageOrientationCommand command = new ChangePageOrientationCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, item.Tag);
        }

        private void dropDownButtonBreaks_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item.Tag == null)
            {
                InsertPageBreakCommand command = new InsertPageBreakCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else
            {
                InsertSectionBreakCommand command = new InsertSectionBreakCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command, item.Tag);
            }
        }

        #endregion

        #region Page Background group

        private void DropDownButtonWatermark_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item.Text == InsertCustomWatermarkText)
            {
                ShowWatermarkSettingsDialogCommand command = new ShowWatermarkSettingsDialogCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else if (item.Text == RemoveWatermarkText)
            {
                RemoveWatermarkCommand command = new RemoveWatermarkCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
        }

        private void WatermarkListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadListViewElement listView = sender as RadListViewElement;
            ChangeIntegratedWatermarkTypeCommand command = new ChangeIntegratedWatermarkTypeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, listView.SelectedItem.Tag);

            listView.SelectedIndexChanged -= WatermarkListView_SelectedIndexChanged;
            listView.ViewElement.ClearSelection();
            listView.SelectedIndexChanged += WatermarkListView_SelectedIndexChanged;
        }

        #endregion

        #endregion

        #region References tab

        #region Table of Contents group

        private void buttonTableOfContents_Click(object sender, EventArgs e)
        {
            ShowInsertTableOfContentsDialogCommand command = new ShowInsertTableOfContentsDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Footnotes group

        private void groupFootnotes_DialogButtonClick(object sender, EventArgs e)
        {
            ShowNotesDialogCommand command = new ShowNotesDialogCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
        }

        private void buttonInsertFootnote_Click(object sender, EventArgs e)
        {
            InsertFootnoteCommand command = new InsertFootnoteCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonInsertEndnote_Click(object sender, EventArgs e)
        {
            InsertEndnoteCommand command = new InsertEndnoteCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void NavigateFootnotes_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item.Text == NextFootnoteText)
            {
                GoToNextFootnoteCommand command = new GoToNextFootnoteCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else if (item.Text == PreviousFootnoteText)
            {
                GoToPreviousFootnoteCommand command = new GoToPreviousFootnoteCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else if (item.Text == NextEndnoteText)
            {
                GoToNextEndnoteCommand command = new GoToNextEndnoteCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else if (item.Text == PreviousEndnoteText)
            {
                GoToPreviousEndnoteCommand command = new GoToPreviousEndnoteCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
        }

        #endregion

        #region Citation & Bibliography group

        private void InsertCitation_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item.Text == AddNewCitationSourceText)
            {
                ShowAddNewBibliographicReferenceDialogCommand command = new ShowAddNewBibliographicReferenceDialogCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else if (item.Tag != null)
            {
                InsertCitationFieldCommand command = new InsertCitationFieldCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command, item.Tag);
            }
        }

        private void buttonManageSources_Click(object sender, EventArgs e)
        {
            ShowManageBibliographicSourcesDialogCommand command = new ShowManageBibliographicSourcesDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void dropDownListCitationStyle_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.AssociatedRichTextEditor == null)
            {
                return;
            }

            ChangeBibliographicStyleCommand command = new ChangeBibliographicStyleCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, this.dropDownListCitationStyle.SelectedItem.DataBoundItem);
        }

        private void buttonBibliography_Click(object sender, EventArgs e)
        {
            InsertBibliographyFieldCommand command = new InsertBibliographyFieldCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Captions group

        private void buttonInsertCaption_Click(object sender, EventArgs e)
        {
            ShowInsertCaptionDialogCommand command = new ShowInsertCaptionDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonCrossReference_Click(object sender, EventArgs e)
        {
            ShowInsertCrossReferenceWindowCommand command = new ShowInsertCrossReferenceWindowCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #endregion

        #region Mailings tabs

        #region Write & Insert Fields group

        private void toggleButtonHighlightMergeFields_Click(object sender, EventArgs e)
        {
            ToggleMergeFieldsHighlightCommand command = new ToggleMergeFieldsHighlightCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void DropDownButtonInsertMergeField_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            MergeField parameter = new MergeField();
            parameter.PropertyPath = item.Text;
            parameter.DisplayMode = this.AssociatedRichTextEditor.RichTextBoxElement.Document.FieldsDisplayMode;

            InsertFieldCommand command = new InsertFieldCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, parameter);
        }

        #endregion

        #region Preview Results group

        private void buttonShowAllFieldCodes_Click(object sender, EventArgs e)
        {
            ChangeAllFieldsDisplayModeCommand command = new ChangeAllFieldsDisplayModeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, FieldDisplayMode.Code);
        }

        private void buttonShowAllFieldsNames_Click(object sender, EventArgs e)
        {
            ChangeAllFieldsDisplayModeCommand command = new ChangeAllFieldsDisplayModeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, FieldDisplayMode.DisplayName);
        }

        private void buttonPreviewResults_Click(object sender, EventArgs e)
        {
            ChangeAllFieldsDisplayModeCommand command = new ChangeAllFieldsDisplayModeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, FieldDisplayMode.Result);
        }

        private void buttonNavigateFirst_Click(object sender, EventArgs e)
        {
            PreviewFirstMailMergeDataRecordCommand command = new PreviewFirstMailMergeDataRecordCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonNavigatePrevious_Click(object sender, EventArgs e)
        {
            PreviewPreviousMailMergeDataRecordCommand command = new PreviewPreviousMailMergeDataRecordCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonNavigateNext_Click(object sender, EventArgs e)
        {
            PreviewNextMailMergeDataRecordCommand command = new PreviewNextMailMergeDataRecordCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonNavigateLast_Click(object sender, EventArgs e)
        {
            PreviewLastMailMergeDataRecordCommand command = new PreviewLastMailMergeDataRecordCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Preview Results group

        private void buttonMailMerge_Click(object sender, EventArgs e)
        {
            MailMergeCommand command = new MailMergeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #endregion

        #region Review tab

        #region Proofing group

        private void buttonSpellCheck_Click(object sender, EventArgs e)
        {
            ShowSpellCheckingDialogCommand command = new ShowSpellCheckingDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Comments group

        private void buttonNewComment_Click(object sender, EventArgs e)
        {
            InsertCommentCommand command = new InsertCommentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonDeleteComment_Click(object sender, EventArgs e)
        {
            DeleteCommentCommand command = new DeleteCommentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonPreviousComment_Click(object sender, EventArgs e)
        {
            GoToPreviousCommentCommand command = new GoToPreviousCommentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonNextComment_Click(object sender, EventArgs e)
        {
            GoToNextCommentCommand command = new GoToNextCommentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void toggleButtonShowHideComments_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleCommentsCommand command = new ToggleCommentsCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonDeleteAllComments_Click(object sender, EventArgs e)
        {
            DeleteAllCommentsCommand command = new DeleteAllCommentsCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Tracking & Changes group

        private void toggleButtonTrackChanges_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleTrackChangesCommand command = new ToggleTrackChangesCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void SplitButtonAcceptChange_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item.Text == AcceptChangeText)
            {
                AcceptRevisionCommand command = new AcceptRevisionCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else if (item.Text == AcceptAllChangesText)
            {
                AcceptAllRevisionsCommand command = new AcceptAllRevisionsCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
        }

        private void SplitButtonRejectChange_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item.Text == RejectChangeText)
            {
                RejectRevisionCommand command = new RejectRevisionCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
            else if (item.Text == RejectAllChangesText)
            {
                RejectAllRevisionsCommand command = new RejectAllRevisionsCommand(this.RichTextBoxActiveEditor);
                this.ExecuteCommand(command);
            }
        }

        private void buttonPreviousChange_Click(object sender, EventArgs e)
        {
            GoToPreviousRevisionCommand command = new GoToPreviousRevisionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonNextChange_Click(object sender, EventArgs e)
        {
            GoToNextRevisionCommand command = new GoToNextRevisionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Protect group

        private void toggleButtonProtectDocument_Click(object sender, EventArgs e)
        {
            ToggleDocumentProtectionCommand command = new ToggleDocumentProtectionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonEditingRestrictions_Click(object sender, EventArgs e)
        {
            ShowChangeEditingPermissionsDialogCommand command = new ShowChangeEditingPermissionsDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #endregion

        #region View tab

        #region Document views group

        private void buttonWebLayout_Click(object sender, EventArgs e)
        {
            ChangeLayoutModeCommand command = new ChangeLayoutModeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, DocumentLayoutMode.Flow);
        }

        private void buttonPrintLayout_Click(object sender, EventArgs e)
        {
            ChangeLayoutModeCommand command = new ChangeLayoutModeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, DocumentLayoutMode.Paged);
        }

        #endregion

        #endregion

        #region Table Styles tab

        #region Table Style Options group

        private void checkBoxHeaderRow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleTableLookFirstRowOptionCommand command = new ToggleTableLookFirstRowOptionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);

            this.TableLook.ApplyFirstRow = args.ToggleState == ToggleState.On;
        }

        private void checkBoxTotalRow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleTableLookLastRowOptionCommand command = new ToggleTableLookLastRowOptionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);

            this.TableLook.ApplyLastRow = args.ToggleState == ToggleState.On;
        }

        private void checkBoxBandedRows_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleTableLookRowBandingOptionCommand command = new ToggleTableLookRowBandingOptionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);

            this.TableLook.ApplyRowBanding = args.ToggleState == ToggleState.On;
        }

        private void checkBoxFirstColumn_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleTableLookFirstColumnOptionCommand command = new ToggleTableLookFirstColumnOptionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);

            this.TableLook.ApplyFirstColumn = args.ToggleState == ToggleState.On;
        }

        private void checkBoxLastColumn_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleTableLookLastColumnOptionCommand command = new ToggleTableLookLastColumnOptionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);

            this.TableLook.ApplyLastColumn = args.ToggleState == ToggleState.On;
        }

        private void checkBoxBandedColumns_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleTableLookColumnBandingOptionCommand command = new ToggleTableLookColumnBandingOptionCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);

            this.TableLook.ApplyColumnBanding = args.ToggleState == ToggleState.On;
        }

        #endregion

        #region Table styles group

        #endregion

        #endregion

        #region Table Layout tab

        #region Table group

        private void dropDownButtonSelect_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;
            RichTextBoxCommandBase command = null;

            if (item.Text == "Select Cell")
            {
                command = new SelectTableCellCommand(this.RichTextBoxActiveEditor);
            }
            else if (item.Text == "Select Column")
            {
                command = new SelectTableColumnCommand(this.RichTextBoxActiveEditor);
            }
            else if (item.Text == "Select Row")
            {
                command = new SelectTableRowCommand(this.RichTextBoxActiveEditor);
            }
            else if (item.Text == "Select Table")
            {
                command = new SelectTableCommand(this.RichTextBoxActiveEditor);
            }

            this.ExecuteCommand(command);
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            ShowTablePropertiesDialogCommand command = new ShowTablePropertiesDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteTableCommand command = new DeleteTableCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Rows group

        private void buttonInsertRow_Click(object sender, EventArgs e)
        {
            InsertTableRowCommand command = new InsertTableRowCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonInsertBelow_Click(object sender, EventArgs e)
        {
            InsertTableRowBelowCommand command = new InsertTableRowBelowCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonInsertAbove_Click(object sender, EventArgs e)
        {
            InsertTableRowAboveCommand command = new InsertTableRowAboveCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            DeleteTableRowCommand command = new DeleteTableRowCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Columns group

        private void buttonInsertColumn_Click(object sender, EventArgs e)
        {
            InsertTableColumnCommand command = new InsertTableColumnCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonInsertLeft_Click(object sender, EventArgs e)
        {
            InsertTableColumnToTheLeftCommand command = new InsertTableColumnToTheLeftCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonInsertRight_Click(object sender, EventArgs e)
        {
            InsertTableColumnToTheRightCommand command = new InsertTableColumnToTheRightCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonDeleteColumn_Click(object sender, EventArgs e)
        {
            DeleteTableColumnCommand command = new DeleteTableColumnCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Merge group

        private void buttonMergeCells_Click(object sender, EventArgs e)
        {
            MergeTableCellsCommand command = new MergeTableCellsCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Cell Size group

        private void dropDownButtonAutoFit_ItemClick(object sender, EventArgs e)
        {
            RadMenuItem item = sender as RadMenuItem;

            ChangeTableColumnsLayoutModeCommand command = new ChangeTableColumnsLayoutModeCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, item.Tag);
        }

        #endregion

        #region Alignment group

        private void buttonCellAlignment_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState != ToggleState.On)
            {
                return;
            }

            RadToggleButtonElement button = sender as RadToggleButtonElement;

            this.UnsubscribeToTableCellAlignmentItemEvents();

            this.ToggleCellAlignmentButton(button);

            TableCellContentAlignmentCommand command = new TableCellContentAlignmentCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, button.Tag);

            this.SubscribeToTableCellAlignmentItemEvents();
        }

        #endregion

        #endregion

        #region Header Footer tab

        #region Insert group

        private void buttonInsertDateAndTime_Click(object sender, EventArgs e)
        {
            ShowInsertDateTimeDialogCommand command = new ShowInsertDateTimeDialogCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        private void buttonInsertPageNumber_Click(object sender, EventArgs e)
        {
            InsertPageFieldCommand command = new InsertPageFieldCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Navigation group

        private void linkToPrevious_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleHeaderFooterLinkToPreviousCommand command = new ToggleHeaderFooterLinkToPreviousCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Options group

        private void checkBoxDifferentFirstPage_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleDifferentFirstPageHeaderFooterCommand command = new ToggleDifferentFirstPageHeaderFooterCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
        }

        private void checkBoxDifferentOddAndEvenPages_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ToggleDifferentOddAndEvenPagesHeaderFooterCommand command = new ToggleDifferentOddAndEvenPagesHeaderFooterCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
        }

        #endregion

        #region Position group

        private void spinElementHeaderFromTop_ValueChanged(object sender, EventArgs e)
        {
            ChangeSectionHeaderTopMarginCommand command = new ChangeSectionHeaderTopMarginCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, (int)this.spinElementHeaderFromTop.Value);
        }

        private void spinElementFooterFromBottom_ValueChanged(object sender, EventArgs e)
        {
            ChangeSectionFooterBottomMarginCommand command = new ChangeSectionFooterBottomMarginCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command, (int)this.spinElementFooterFromBottom.Value);
        }

        #endregion

        #region Close group

        private void buttonCloseHeaderAndFooter_Click(object sender, EventArgs e)
        {
            ExitHeaderFooterEditModeCommand command = new ExitHeaderFooterEditModeCommand(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.ExecuteCommand(command);
            this.buttonCloseHeaderAndFooter.IsMouseOver = false;
        }

        #endregion

        #endregion

        #region Other

        private void dropDownButtonWithListViewMenuItem_DropDownClosing(object sender, RadPopupClosingEventArgs args)
        {
            if (args.CloseReason == RadPopupCloseReason.Mouse)
            {
                RadDropDownButtonElement dropDown = sender as RadDropDownButtonElement;

                foreach (RadItem item in dropDown.Items)
                {
                    ListViewMenuItem listViewItem = item as ListViewMenuItem;

                    if (listViewItem != null && listViewItem.ListViewElement.ViewElement.VScrollBar.IsMouseOverElement)
                    {
                        args.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void RichTextBoxElement_ActiveDocumentEditorChanged(object sender, Telerik.WinForms.Documents.UI.ActiveDocumentEditorChangedEventArgs e)
        {
            this.activeEditorCache.CurrentEditingStyleChanged -= ActiveEditor_CurrentEditingStyleChanged;
            this.activeEditorCache.CommandExecuted -= ActiveEditor_CommandExecuted;
            e.NewActiveEditor.CurrentEditingStyleChanged += ActiveEditor_CurrentEditingStyleChanged;
            e.NewActiveEditor.CommandExecuted += ActiveEditor_CommandExecuted;
        }

        private void ActiveEditor_CommandExecuted(object sender, CommandExecutedEventArgs e)
        {
            this.HandleDocumentCommandExecuted(((RadRichTextBox)sender).Document);
        }

        private void ActiveEditor_CurrentEditingStyleChanged(object sender, EventArgs e)
        {
            this.HandleFontStylePropertiesOnCurrentEditingStyleChanged();
            this.HandleTableStylePropertiesOnCurrentEditingStyleChanged();
        }

        private void RichTextBoxElement_DocumentChanged(object sender, EventArgs e)
        {
            this.documentCache.CommandExecuted -= Document_CommandExecuted;
            this.documentCache = this.associatedRichTextEditor.RichTextBoxElement.Document;
            this.associatedRichTextEditor.RichTextBoxElement.Document.CommandExecuted += Document_CommandExecuted;
            this.HandleDocumentCommandExecuted(this.AssociatedRichTextEditor.RichTextBoxElement.Document);

            this.SetQuickStyleItemSource(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.SetListStyleItemSource(this.AssociatedRichTextEditor.RichTextBoxElement);
            this.SetTableStyleItemSource(this.AssociatedRichTextEditor.RichTextBoxElement);
        }

        private void Document_CommandExecuted(object sender, Telerik.WinForms.Documents.History.DocumentCommandExecutedEventArgs e)
        {
            this.HandleDocumentCommandExecuted(sender as RadDocument);
        }

        private void RichTextBoxElement_IsInHeaderFooterEditModeChanged(object sender, EventArgs e)
        {
            if (this.AssociatedRichTextEditor.RichTextBoxElement.IsInHeaderFooterEditMode)
            {
                this.openTabCache = this.SelectedCommandTab;

                this.AssociatedRichTextEditor.RichTextBoxElement.CurrentEditingContext.PropertyChanged += CurrentEditingContext_PropertyChanged;

                this.CommandTabs.Add(this.tabHeaderFooter);
                this.ContextualTabGroups.Add(this.tabGroupHeaderAndFooter);
                this.tabGroupHeaderAndFooter.TabItems.Add(this.tabHeaderFooter);
                this.tabHeaderFooter.IsSelected = true;
            }
            else
            {
                this.AssociatedRichTextEditor.RichTextBoxElement.CurrentEditingContext.PropertyChanged -= CurrentEditingContext_PropertyChanged;

                if (this.openTabCache != null)
                {
                    this.openTabCache.IsSelected = true;
                }
                else
                {
                    this.tabHome.IsSelected = true;
                }

                this.CommandTabs.Remove(this.tabHeaderFooter);
                this.tabHeaderFooter.IsSelected = false;
                this.ContextualTabGroups.Remove(this.tabGroupHeaderAndFooter);
                this.tabGroupHeaderAndFooter.TabItems.Remove(this.tabHeaderFooter);
            }
        }

        private void CurrentEditingContext_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Type" && this.AssociatedRichTextEditor.RichTextBoxElement.CurrentEditingContext.Type == Telerik.WinForms.Documents.UI.EditingContextTypes.HeaderFooter)
            {
                this.linkToPrevious.ToggleStateChanged -= this.linkToPrevious_ToggleStateChanged;
                this.checkBoxDifferentFirstPage.ToggleStateChanged -= this.checkBoxDifferentFirstPage_ToggleStateChanged;
                this.checkBoxDifferentOddAndEvenPages.ToggleStateChanged -= this.checkBoxDifferentOddAndEvenPages_ToggleStateChanged;
                this.spinElementHeaderFromTop.ValueChanged -= this.spinElementHeaderFromTop_ValueChanged;
                this.spinElementFooterFromBottom.ValueChanged -= this.spinElementFooterFromBottom_ValueChanged;


                if (this.AssociatedRichTextEditor.RichTextBoxElement.CurrentEditingContext.HeaderContext != null)
                {
                    Telerik.WinForms.Documents.UI.HeaderFooterEditingContext currentEditingContext = this.AssociatedRichTextEditor.RichTextBoxElement.CurrentEditingContext.HeaderContext;
                    this.linkToPrevious.IsChecked = currentEditingContext.CurrentSection.IsHeaderLinkedToPrevious(currentEditingContext.CurrentHeaderFooterType);
                    this.checkBoxDifferentFirstPage.IsChecked = currentEditingContext.CurrentSection.HasDifferentFirstPageHeaderFooter;
                    this.spinElementHeaderFromTop.Value = currentEditingContext.CurrentSection.HeaderTopMargin;
                    this.spinElementFooterFromBottom.Value = currentEditingContext.CurrentSection.FooterBottomMargin;
                }
                else if (this.AssociatedRichTextEditor.RichTextBoxElement.CurrentEditingContext.FooterContext != null)
                {
                    Telerik.WinForms.Documents.UI.HeaderFooterEditingContext currentEditingContext = this.AssociatedRichTextEditor.RichTextBoxElement.CurrentEditingContext.FooterContext;
                    this.linkToPrevious.IsChecked = currentEditingContext.CurrentSection.IsFooterLinkedToPrevious(currentEditingContext.CurrentHeaderFooterType);
                    this.checkBoxDifferentFirstPage.IsChecked = currentEditingContext.CurrentSection.HasDifferentFirstPageHeaderFooter;
                    this.spinElementHeaderFromTop.Value = currentEditingContext.CurrentSection.HeaderTopMargin;
                    this.spinElementFooterFromBottom.Value = currentEditingContext.CurrentSection.FooterBottomMargin;
                }

                this.checkBoxDifferentOddAndEvenPages.IsChecked = this.AssociatedRichTextEditor.RichTextBoxElement.Document.HasDifferentEvenAndOddHeadersFooters;

                this.spinElementFooterFromBottom.ValueChanged += this.spinElementFooterFromBottom_ValueChanged;
                this.spinElementHeaderFromTop.ValueChanged += this.spinElementHeaderFromTop_ValueChanged;
                this.checkBoxDifferentOddAndEvenPages.ToggleStateChanged += this.checkBoxDifferentOddAndEvenPages_ToggleStateChanged;
                this.checkBoxDifferentFirstPage.ToggleStateChanged += this.checkBoxDifferentFirstPage_ToggleStateChanged;
                this.linkToPrevious.ToggleStateChanged += this.linkToPrevious_ToggleStateChanged;
            }
        }

        private Paragraph GetCurrentParagraph()
        {
            Telerik.WinForms.Documents.Layout.ParagraphLayoutBox pb = this.GetCurrentParagraphBox();

            if (pb != null)
            {
                return pb.AssociatedParagraph;
            }

            return null;
        }

        private Telerik.WinForms.Documents.Layout.ParagraphLayoutBox GetCurrentParagraphBox()
        {
            if (this.RichTextBoxActiveEditor.Document.Selection.IsEmpty)
            {
                Telerik.WinForms.Documents.Layout.ParagraphLayoutBox pb = this.RichTextBoxActiveEditor.Document.CaretPosition.GetCurrentParagraphBox();

                return pb;
            }

            return this.RichTextBoxActiveEditor.Document.Selection.Ranges.First.StartPosition.GetCurrentParagraphBox();
        }

        #endregion

        #endregion

        #region Style gallery

        protected override void OnNotifyPropertyChanged(string propertyName)
        {
            base.OnNotifyPropertyChanged(propertyName);

            if (propertyName == "AssociatedRichTextEditor" && this.AssociatedRichTextEditor != null)
            {
                this.InitializeSnapshotRichTextBox();
                this.InitializeListSnapshotRichTextBox();
            }
        }

        private void observableStyleCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.FillStylesGallery();
        }

        private void SetQuickStyleItemSource(RadRichTextBox radRichTextBox)
        {
            if (this.observableStyleCollection != null)
            {
                this.observableStyleCollection.CollectionChanged -= observableStyleCollection_CollectionChanged;
                this.observableStyleCollection.DetachEvents();
            }

            this.styleSnapshotRichTextBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                this.SetInitialQuickStyleItemSource(radRichTextBox);
            }));
        }

        private void SetInitialQuickStyleItemSource(RadRichTextBox radRichTextBox)
        {
            if (radRichTextBox != null)
            {
                this.observableStyleCollection = new Telerik.WinForms.RichTextEditor.RichTextBoxUI.Dialogs.Styles.ObservableStyleCollection(this.AssociatedRichTextEditor.Document, this.styleSnapshotRichTextBox, 200, 200, false, true);
                this.observableStyleCollection.CollectionChanged += observableStyleCollection_CollectionChanged;
                this.FillStylesGallery();
            }
        }

        private void FillStylesGallery()
        {
            foreach (StyleGalleryItem item in this.galleryStyles.Items)
            {
                item.Click -= styleGalleryItem_Click;
            }

            this.galleryStyles.Items.Clear();

            foreach (Telerik.WinForms.RichTextEditor.RichTextBoxUI.Dialogs.Styles.StyleData style in this.observableStyleCollection)
            {
                StyleGalleryItem item = new StyleGalleryItem(style.DisplayName, style);
                item.DisplayStyle = DisplayStyle.ImageAndText;
                item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                item.MaxSize = new System.Drawing.Size(64, 64);
                item.MinSize = new System.Drawing.Size(64, 64);
                item.TextAlignment = ContentAlignment.BottomCenter;
                item.ClipDrawing = true;
                item.Click += styleGalleryItem_Click;
                this.galleryStyles.Items.Add(item);
            }
        }

        private void styleGalleryItem_Click(object sender, EventArgs e)
        {
            StyleGalleryItem item = sender as StyleGalleryItem;

            if (item == null)
            {
                return;
            }

            if (item.StyleData != null && this.AssociatedRichTextEditor != null)
            {
                this.AssociatedRichTextEditor.RichTextBoxElement.ChangeStyleNameToActiveEditor(item.StyleData.RealStyleDefinition.Name);
            }
        }

        private void RadRichTextBox_DocumentChanged(object sender, EventArgs e)
        {
            RadRichTextBox radRichTextBox = sender as RadRichTextBox;

            if (radRichTextBox != null)
            {
                this.SetQuickStyleItemSource(radRichTextBox);
            }
        }

        #endregion

        #region List Style list view

        private void SetListStyleItemSource(RadRichTextBox radRichTextBox)
        {
            if (this.observableListStyleCollection != null)
            {
                this.observableListStyleCollection.CollectionChanged -= observableStyleCollection_CollectionChanged;
                this.observableListStyleCollection.DetachEvents();
            }

            this.styleSnapshotRichTextBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                this.SetInitialListStyleItemSource(radRichTextBox);
            }));
        }

        private void SetInitialListStyleItemSource(RadRichTextBox radRichTextBox)
        {
            if (radRichTextBox != null)
            {
                this.observableListStyleCollection = new ObservableListStyleCollection(this.AssociatedRichTextEditor.Document, this.listStyleSnapshotRichTextBox);
                this.observableListStyleCollection.CollectionChanged += observableListStyleCollection_CollectionChanged;
                this.FillListStylesListView();
            }
        }

        private void observableListStyleCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.FillListStylesListView();
        }

        private void FillListStylesListView()
        {
            ListViewMenuItem listView = buttonMultilevelList.Items[1] as ListViewMenuItem;
            listView.ListViewElement.Items.Clear();
            listView.ListViewElement.Items.AddRange(this.GetGetMultiLevelListViewDataItems().ToArray());

            foreach (Telerik.WinForms.Controls.RichTextBoxUI.Dialogs.Styles.ListStyleData style in this.observableListStyleCollection)
            {
                ListViewDataItem listViewItem = new ListViewDataItem();
                listViewItem.Image = style.Image.Bitmap;
                listViewItem.ImageAlignment = ContentAlignment.MiddleCenter;
                listViewItem.Tag = style.ListStyle;
                listView.ListViewElement.Items.Add(listViewItem);
            }
        }

        #endregion

        #region Table Styles gallery

        private void SetTableStyleItemSource(RadRichTextBox radRichTextBox)
        {
            if (this.observableTableStyleCollection != null)
            {
                this.observableTableStyleCollection.CollectionChanged -= observableStyleCollection_CollectionChanged;
                this.observableTableStyleCollection.DetachEvents();
            }

            this.styleSnapshotRichTextBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                this.SetInitialTableStyleItemSource(radRichTextBox);
            }));
        }

        private void SetInitialTableStyleItemSource(RadRichTextBox radRichTextBox)
        {
            if (radRichTextBox != null)
            {
                this.observableTableStyleCollection = new ObservableTableStyleCollection(this.AssociatedRichTextEditor.Document.StyleRepository, Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013);

                this.FillTableStylesGallery();
            }
        }

        private TableLook tableLook;

        private TableLook TableLook
        {
            get
            {
                if (this.tableLook == null)
                {
                    this.tableLook = new TableLook()
                    {
                        ApplyColumnBanding = this.checkBoxBandedColumns.IsChecked,
                        ApplyFirstColumn = this.checkBoxFirstColumn.IsChecked,
                        ApplyLastColumn = this.checkBoxLastColumn.IsChecked,
                        ApplyRowBanding = this.checkBoxBandedRows.IsChecked,
                        ApplyFirstRow = this.checkBoxHeaderRow.IsChecked,
                        ApplyLastRow = this.checkBoxTotalRow.IsChecked
                    };
                }

                return this.tableLook;
            }
        }

        private void FillTableStylesGallery()
        {
            foreach (TableStyleGalleryItem item in this.galleryTableStyles.Items)
            {
                item.Click -= tableStyleGalleryItem_Click;
            }

            this.galleryTableStyles.Items.Clear();
            this.galleryTableStyles.Groups.Clear();

            foreach (TableStyleItemData style in this.observableTableStyleCollection)
            {
                TableStyleGalleryItem item = new TableStyleGalleryItem(style.StyleDefinition.DisplayName, style, this.TableLook);
                item.DisplayStyle = DisplayStyle.Image;
                item.MaxSize = new System.Drawing.Size(64, 45);
                item.MinSize = new System.Drawing.Size(64, 45);
                item.Click += tableStyleGalleryItem_Click;

                RadGalleryGroupItem group = this.GetOrAddGroupItem(style.TableStyleGroupName);
                group.Items.Add(item);
                this.galleryTableStyles.Items.Add(item);
            }
        }

        public RadGalleryGroupItem GetOrAddGroupItem(string groupName)
        {
            foreach (RadGalleryGroupItem group in this.galleryTableStyles.Groups)
            {
                if (group.Text == groupName)
                {
                    return group;
                }
            }

            RadGalleryGroupItem newItem = new RadGalleryGroupItem(groupName);
            this.galleryTableStyles.Groups.Add(newItem);

            return newItem;
        }

        private void tableStyleGalleryItem_Click(object sender, EventArgs e)
        {
            TableStyleGalleryItem item = sender as TableStyleGalleryItem;

            ChangeStyleNameCommand command = new ChangeStyleNameCommand(this.RichTextBoxActiveEditor);
            this.ExecuteCommand(command, item.StyleData.StyleDefinition.Name);
        }

        #endregion
    }
}
