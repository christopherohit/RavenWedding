using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;

namespace Telerik.Examples.WinControls.RibbonBar.MDILayout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radRibbonBarCommandTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarChunk2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement29 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radOffice2007ScreenTip1 = new Telerik.WinControls.UI.RadOffice2007ScreenTip();
            this.radOffice2007ScreenTip2 = new Telerik.WinControls.UI.RadOffice2007ScreenTip();
            this.radOffice2007ScreenTip3 = new Telerik.WinControls.UI.RadOffice2007ScreenTip();
            this.radOffice2007ScreenTip4 = new Telerik.WinControls.UI.RadOffice2007ScreenTip();
            this.radGalleryGroupFilter3 = new Telerik.WinControls.UI.RadGalleryGroupFilter();
            this.radGalleryGroupItem1 = new Telerik.WinControls.UI.RadGalleryGroupItem();
            this.radGalleryGroupItem2 = new Telerik.WinControls.UI.RadGalleryGroupItem();
            this.radGalleryGroupFilter1 = new Telerik.WinControls.UI.RadGalleryGroupFilter();
            this.radGalleryGroupFilter2 = new Telerik.WinControls.UI.RadGalleryGroupFilter();
            this.radMenuItem12 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem14 = new Telerik.WinControls.UI.RadMenuItem();
            this.radGalleryGroupFilter4 = new Telerik.WinControls.UI.RadGalleryGroupFilter();
            this.radGalleryGroupItem3 = new Telerik.WinControls.UI.RadGalleryGroupItem();
            this.radGalleryGroupItem4 = new Telerik.WinControls.UI.RadGalleryGroupItem();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radButtonElement41 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement42 = new Telerik.WinControls.UI.RadButtonElement();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBarCommandTab1
            // 
            this.radRibbonBarCommandTab1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.radRibbonBarCommandTab1.CanFocus = true;
            this.radRibbonBarCommandTab1.IsSelected = true;
            this.radRibbonBarCommandTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarChunk2,
            this.radRibbonBarGroup1});
            this.radRibbonBarCommandTab1.Name = "radRibbonBarCommandTab1";
            this.radRibbonBarCommandTab1.StretchHorizontally = false;
            this.radRibbonBarCommandTab1.Text = "Actions";
            // 
            // radRibbonBarChunk2
            // 
            this.radRibbonBarChunk2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement5,
            this.radButtonElement29});
            this.radRibbonBarChunk2.Name = "radRibbonBarChunk2";
            this.radRibbonBarChunk2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarChunk2.Text = "Pages";
            // 
            // radButtonElement5
            // 
            this.radButtonElement5.CanFocus = true;
            this.radButtonElement5.Image = global::Telerik.Examples.WinControls.Properties.Resources.insert2;
            this.radButtonElement5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.Padding = new System.Windows.Forms.Padding(2);
            this.radButtonElement5.StretchVertically = false;
            this.radButtonElement5.Text = "New Form";
            this.radButtonElement5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radButtonElement29
            // 
            this.radButtonElement29.CanFocus = true;
            this.radButtonElement29.Image = global::Telerik.Examples.WinControls.Properties.Resources.exitButton;
            this.radButtonElement29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radButtonElement29.Name = "radButtonElement29";
            this.radButtonElement29.Padding = new System.Windows.Forms.Padding(2);
            this.radButtonElement29.StretchVertically = false;
            this.radButtonElement29.Text = "Close Form";
            this.radButtonElement29.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2,
            this.radButtonElement3});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarGroup1.Text = "Themes";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.Image = global::Telerik.Examples.WinControls.Properties.Resources.Blue;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Padding = new System.Windows.Forms.Padding(2);
            this.radButtonElement1.StretchVertically = false;
            this.radButtonElement1.Text = "Office 2007 Blue";
            this.radButtonElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.CanFocus = true;
            this.radButtonElement2.Image = global::Telerik.Examples.WinControls.Properties.Resources.Black;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Padding = new System.Windows.Forms.Padding(2);
            this.radButtonElement2.StretchVertically = false;
            this.radButtonElement2.Text = "Office 2010 Black";
            this.radButtonElement2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.CanFocus = true;
            this.radButtonElement3.Image = global::Telerik.Examples.WinControls.Properties.Resources.Silver;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Padding = new System.Windows.Forms.Padding(2);
            this.radButtonElement3.StretchVertically = false;
            this.radButtonElement3.Text = "Office 2010 Silver";
            this.radButtonElement3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radOffice2007ScreenTip1
            // 
            this.radOffice2007ScreenTip1.CaptionVisible = true;
            this.radOffice2007ScreenTip1.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip1.FooterVisible = false;
            this.radOffice2007ScreenTip1.Location = new System.Drawing.Point(0, 0);
            this.radOffice2007ScreenTip1.Name = "radOffice2007ScreenTip1";
            // 
            // 
            // 
            this.radOffice2007ScreenTip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // 
            // 
            this.radOffice2007ScreenTip1.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip1.ScreenTipElement.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            this.radOffice2007ScreenTip1.ScreenTipElement.TipSize = new System.Drawing.Size(0, 0);
            this.radOffice2007ScreenTip1.Size = new System.Drawing.Size(195, 43);
            this.radOffice2007ScreenTip1.TabIndex = 0;
            this.radOffice2007ScreenTip1.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "Paste";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "Paste the contents of the clipboard";
            // 
            // radOffice2007ScreenTip2
            // 
            this.radOffice2007ScreenTip2.CaptionVisible = true;
            this.radOffice2007ScreenTip2.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip2.FooterVisible = false;
            this.radOffice2007ScreenTip2.Location = new System.Drawing.Point(0, 0);
            this.radOffice2007ScreenTip2.Name = "radOffice2007ScreenTip2";
            // 
            // 
            // 
            this.radOffice2007ScreenTip2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // 
            // 
            this.radOffice2007ScreenTip2.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip2.ScreenTipElement.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            this.radOffice2007ScreenTip2.ScreenTipElement.TipSize = new System.Drawing.Size(0, 0);
            this.radOffice2007ScreenTip2.Size = new System.Drawing.Size(336, 43);
            this.radOffice2007ScreenTip2.TabIndex = 0;
            this.radOffice2007ScreenTip2.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip2.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "Cut";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "Cut the selection from the document and put it on the clipboard";
            // 
            // radOffice2007ScreenTip3
            // 
            this.radOffice2007ScreenTip3.CaptionVisible = true;
            this.radOffice2007ScreenTip3.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip3.FooterVisible = false;
            this.radOffice2007ScreenTip3.Location = new System.Drawing.Point(0, 0);
            this.radOffice2007ScreenTip3.Name = "radOffice2007ScreenTip3";
            // 
            // 
            // 
            this.radOffice2007ScreenTip3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // 
            // 
            this.radOffice2007ScreenTip3.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip3.ScreenTipElement.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            this.radOffice2007ScreenTip3.ScreenTipElement.TipSize = new System.Drawing.Size(0, 0);
            this.radOffice2007ScreenTip3.Size = new System.Drawing.Size(247, 43);
            this.radOffice2007ScreenTip3.TabIndex = 0;
            this.radOffice2007ScreenTip3.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip3.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "Copy";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip3.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "Copy the selection and put it on the clipboard";
            // 
            // radOffice2007ScreenTip4
            // 
            this.radOffice2007ScreenTip4.CaptionVisible = true;
            this.radOffice2007ScreenTip4.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip4.FooterVisible = false;
            this.radOffice2007ScreenTip4.Location = new System.Drawing.Point(0, 0);
            this.radOffice2007ScreenTip4.Name = "radOffice2007ScreenTip4";
            // 
            // 
            // 
            this.radOffice2007ScreenTip4.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            // 
            // 
            // 
            this.radOffice2007ScreenTip4.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" +
    "nTime.";
            this.radOffice2007ScreenTip4.ScreenTipElement.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            this.radOffice2007ScreenTip4.ScreenTipElement.TipSize = new System.Drawing.Size(0, 0);
            this.radOffice2007ScreenTip4.Size = new System.Drawing.Size(293, 43);
            this.radOffice2007ScreenTip4.TabIndex = 0;
            this.radOffice2007ScreenTip4.TemplateType = typeof(Telerik.WinControls.UI.RadOffice2007ScreenTipElement);
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip4.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Text = "Format Painter";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radOffice2007ScreenTip4.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Text = "Copy formatting from one place and apply it to another";
            // 
            // radGalleryGroupFilter3
            // 
            this.radGalleryGroupFilter3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGalleryGroupItem1,
            this.radGalleryGroupItem2});
            this.radGalleryGroupFilter3.Name = "radGalleryGroupFilter3";
            this.radGalleryGroupFilter3.Text = "All Tables";
            // 
            // radGalleryGroupItem1
            // 
            this.radGalleryGroupItem1.Name = "radGalleryGroupItem1";
            this.radGalleryGroupItem1.Text = "Plain Tables";
            // 
            // radGalleryGroupItem2
            // 
            this.radGalleryGroupItem2.Name = "radGalleryGroupItem2";
            this.radGalleryGroupItem2.Text = "Built-In";
            // 
            // radGalleryGroupFilter1
            // 
            this.radGalleryGroupFilter1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGalleryGroupItem1});
            this.radGalleryGroupFilter1.Name = "radGalleryGroupFilter1";
            this.radGalleryGroupFilter1.Text = "Plain Tables";
            // 
            // radGalleryGroupFilter2
            // 
            this.radGalleryGroupFilter2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGalleryGroupItem2});
            this.radGalleryGroupFilter2.Name = "radGalleryGroupFilter2";
            this.radGalleryGroupFilter2.Text = "Built-In";
            // 
            // radMenuItem12
            // 
            this.radMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem12.Image")));
            this.radMenuItem12.Name = "radMenuItem12";
            this.radMenuItem12.Text = "&Modify Table Style...";
            this.radMenuItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem13.Image")));
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "&Clear";
            this.radMenuItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem14
            // 
            this.radMenuItem14.Image = ((System.Drawing.Image)(resources.GetObject("radMenuItem14.Image")));
            this.radMenuItem14.Name = "radMenuItem14";
            this.radMenuItem14.Text = "&New Table Style...";
            this.radMenuItem14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radGalleryGroupFilter4
            // 
            this.radGalleryGroupFilter4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radGalleryGroupItem3,
            this.radGalleryGroupItem4});
            this.radGalleryGroupFilter4.Name = "radGalleryGroupFilter4";
            this.radGalleryGroupFilter4.Text = "Greek Letters";
            // 
            // radGalleryGroupItem3
            // 
            this.radGalleryGroupItem3.Name = "radGalleryGroupItem3";
            this.radGalleryGroupItem3.Text = "Lowercase";
            // 
            // radGalleryGroupItem4
            // 
            this.radGalleryGroupItem4.Name = "radGalleryGroupItem4";
            this.radGalleryGroupItem4.Text = "Uppercase";
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarCommandTab1});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Alignment = System.Drawing.ContentAlignment.TopRight;
            this.radRibbonBar1.ExitButton.CanFocus = true;
            this.radRibbonBar1.ExitButton.Image = global::Telerik.Examples.WinControls.Properties.Resources.exitButton;
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.ExitButton.ZIndex = 2;
            this.radRibbonBar1.ImageList = this.imageList1;
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Alignment = System.Drawing.ContentAlignment.TopRight;
            this.radRibbonBar1.OptionsButton.CanFocus = true;
            this.radRibbonBar1.OptionsButton.Image = global::Telerik.Examples.WinControls.Properties.Resources.optionsButton;
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.OptionsButton.ZIndex = 2;
            this.radRibbonBar1.QuickAccessToolBarItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement41,
            this.radButtonElement42});
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(942, 167);
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            this.radRibbonBar1.StartMenuRightColumnItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem6,
            this.radMenuItem7,
            this.radMenuItem8});
            this.radRibbonBar1.TabIndex = 1;
            this.radRibbonBar1.Text = "RadRibbonBar";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "RadRibbonBar";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            this.imageList1.Images.SetKeyName(29, "");
            this.imageList1.Images.SetKeyName(30, "");
            this.imageList1.Images.SetKeyName(31, "");
            this.imageList1.Images.SetKeyName(32, "");
            this.imageList1.Images.SetKeyName(33, "pageLayout.gif");
            this.imageList1.Images.SetKeyName(34, "insert5.gif");
            this.imageList1.Images.SetKeyName(35, "insert6.gif");
            this.imageList1.Images.SetKeyName(36, "insert.gif");
            this.imageList1.Images.SetKeyName(37, "pageLayout1.gif");
            this.imageList1.Images.SetKeyName(38, "pageLayout2.gif");
            this.imageList1.Images.SetKeyName(39, "pageLayout3.gif");
            this.imageList1.Images.SetKeyName(40, "pageLayout4.gif");
            this.imageList1.Images.SetKeyName(41, "Eraser.gif");
            this.imageList1.Images.SetKeyName(42, "Letter_down.gif");
            this.imageList1.Images.SetKeyName(43, "Letter_up.gif");
            this.imageList1.Images.SetKeyName(44, "small1.GIF");
            this.imageList1.Images.SetKeyName(45, "small2.GIF");
            this.imageList1.Images.SetKeyName(46, "small3.GIF");
            this.imageList1.Images.SetKeyName(47, "small4.GIF");
            this.imageList1.Images.SetKeyName(48, "small5.GIF");
            this.imageList1.Images.SetKeyName(49, "small6.gif");
            this.imageList1.Images.SetKeyName(50, "small7.gif");
            this.imageList1.Images.SetKeyName(51, "small8.gif");
            this.imageList1.Images.SetKeyName(52, "small9.gif");
            this.imageList1.Images.SetKeyName(53, "small10.gif");
            this.imageList1.Images.SetKeyName(54, "small11.gif");
            this.imageList1.Images.SetKeyName(55, "small12.gif");
            this.imageList1.Images.SetKeyName(56, "small13.gif");
            this.imageList1.Images.SetKeyName(57, "small14.gif");
            this.imageList1.Images.SetKeyName(58, "small15.gif");
            this.imageList1.Images.SetKeyName(59, "small16.gif");
            this.imageList1.Images.SetKeyName(60, "small17.gif");
            this.imageList1.Images.SetKeyName(61, "small18.gif");
            this.imageList1.Images.SetKeyName(62, "small19.gif");
            this.imageList1.Images.SetKeyName(63, "small20.gif");
            this.imageList1.Images.SetKeyName(64, "small21.gif");
            this.imageList1.Images.SetKeyName(65, "small22.gif");
            this.imageList1.Images.SetKeyName(66, "small23.gif");
            this.imageList1.Images.SetKeyName(67, "small24.gif");
            this.imageList1.Images.SetKeyName(68, "small25.gif");
            this.imageList1.Images.SetKeyName(69, "small26.gif");
            this.imageList1.Images.SetKeyName(70, "small27.gif");
            this.imageList1.Images.SetKeyName(71, "small28.gif");
            this.imageList1.Images.SetKeyName(72, "small29.gif");
            this.imageList1.Images.SetKeyName(73, "small30.gif");
            this.imageList1.Images.SetKeyName(74, "big1.gif");
            this.imageList1.Images.SetKeyName(75, "big2.gif");
            this.imageList1.Images.SetKeyName(76, "big3.gif");
            this.imageList1.Images.SetKeyName(77, "big4.gif");
            this.imageList1.Images.SetKeyName(78, "big5.gif");
            this.imageList1.Images.SetKeyName(79, "big6.gif");
            this.imageList1.Images.SetKeyName(80, "big7.gif");
            this.imageList1.Images.SetKeyName(81, "big8.gif");
            this.imageList1.Images.SetKeyName(82, "big9.gif");
            this.imageList1.Images.SetKeyName(83, "big10.gif");
            this.imageList1.Images.SetKeyName(84, "big11.gif");
            this.imageList1.Images.SetKeyName(85, "big12.gif");
            this.imageList1.Images.SetKeyName(86, "big13.gif");
            this.imageList1.Images.SetKeyName(87, "big14.gif");
            this.imageList1.Images.SetKeyName(88, "big15.gif");
            this.imageList1.Images.SetKeyName(89, "big16.gif");
            this.imageList1.Images.SetKeyName(90, "big17.gif");
            this.imageList1.Images.SetKeyName(91, "big18.gif");
            this.imageList1.Images.SetKeyName(92, "big19.gif");
            this.imageList1.Images.SetKeyName(93, "big20.gif");
            this.imageList1.Images.SetKeyName(94, "big21.gif");
            this.imageList1.Images.SetKeyName(95, "big22.gif");
            this.imageList1.Images.SetKeyName(96, "big23.gif");
            this.imageList1.Images.SetKeyName(97, "big24.gif");
            // 
            // radButtonElement41
            // 
            this.radButtonElement41.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement41.CanFocus = true;
            this.radButtonElement41.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement41.Image = global::Telerik.Examples.WinControls.Properties.Resources.msIcon1;
            this.radButtonElement41.MaxSize = new System.Drawing.Size(0, 18);
            this.radButtonElement41.Name = "radButtonElement41";
            this.radButtonElement41.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.radButtonElement41.StretchHorizontally = false;
            this.radButtonElement41.StretchVertically = false;
            this.radButtonElement41.Text = "New";
            this.radButtonElement41.ZIndex = 1;
            // 
            // radButtonElement42
            // 
            this.radButtonElement42.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement42.CanFocus = true;
            this.radButtonElement42.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement42.Image = global::Telerik.Examples.WinControls.Properties.Resources.msIcon3;
            this.radButtonElement42.MaxSize = new System.Drawing.Size(0, 18);
            this.radButtonElement42.Name = "radButtonElement42";
            this.radButtonElement42.Padding = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.radButtonElement42.StretchHorizontally = false;
            this.radButtonElement42.StretchVertically = false;
            this.radButtonElement42.Text = "Save";
            this.radButtonElement42.ZIndex = 0;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuNewMagenta;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "New";
            this.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuOpenMagenta;
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Open";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Image = global::Telerik.Examples.WinControls.Properties.Resources.RibbonMenuSaveAsMagenta;
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Save As";
            this.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Enabled = false;
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Recent Documents";
            this.radMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Document1";
            this.radMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Document2";
            this.radMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(942, 667);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadRibbonBar";
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radOffice2007ScreenTip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private RadRibbonBarGroup radRibbonBarChunk2;
        private System.Windows.Forms.ImageList imageList1;
        private RadMenuItem radMenuItem1;
        private RadMenuItem radMenuItem2;
        private RadMenuItem radMenuItem3;
        private RadMenuItem radMenuItem6;
        private RadMenuItem radMenuItem7;
        private RadMenuItem radMenuItem8;
        private RadButtonElement radButtonElement29;
        private RadButtonElement radButtonElement5;
        private RadButtonElement radButtonElement41;
        private RadButtonElement radButtonElement42;
        private RadOffice2007ScreenTip radOffice2007ScreenTip1;
        private RadOffice2007ScreenTip radOffice2007ScreenTip2;
        private RadOffice2007ScreenTip radOffice2007ScreenTip3;
        private RadOffice2007ScreenTip radOffice2007ScreenTip4;
        private RadGalleryGroupItem radGalleryGroupItem1;
        private RadGalleryGroupItem radGalleryGroupItem2;
        private RadMenuItem radMenuItem12;
        private RadMenuItem radMenuItem13;
        private RadMenuItem radMenuItem14;
        private RadGalleryGroupFilter radGalleryGroupFilter1;
        private RadGalleryGroupFilter radGalleryGroupFilter2;
        private RadGalleryGroupFilter radGalleryGroupFilter3;
        private RadGalleryGroupFilter radGalleryGroupFilter4;
        private RadGalleryGroupItem radGalleryGroupItem3;
        private RadGalleryGroupItem radGalleryGroupItem4;
        private RibbonTab radRibbonBarCommandTab1;
        private RadRibbonBarGroup radRibbonBarGroup1;
        private RadButtonElement radButtonElement1;
        private RadButtonElement radButtonElement2;
        private RadButtonElement radButtonElement3;
    }
}