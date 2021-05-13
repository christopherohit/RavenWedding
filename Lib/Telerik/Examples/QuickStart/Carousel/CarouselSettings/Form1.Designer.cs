using System.Drawing;
namespace Telerik.Examples.WinControls.Carousel.CarouselSettings
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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.ThemeSource themeSource1 = new Telerik.WinControls.ThemeSource();
            Telerik.WinControls.ThemeSource themeSource2 = new Telerik.WinControls.ThemeSource();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCarouselDemo = new Telerik.WinControls.UI.RadCarousel();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement6 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement7 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement8 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement9 = new Telerik.WinControls.UI.RadButtonElement();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radTitleBar = new Telerik.WinControls.UI.RadTitleBar();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radComboAutoLoop = new Telerik.WinControls.UI.RadDropDownList();
            this.radCheckEnableLooping = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckAutoLoop = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckVirtualMode = new Telerik.WinControls.UI.RadCheckBox();
            this.radSpinRestoreDuration = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinVisibleElements = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLblAutoLoopDirection = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLblVItemCount = new Telerik.WinControls.UI.RadLabel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radCarouselDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboAutoLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnableLooping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAutoLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckVirtualMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinRestoreDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinVisibleElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblAutoLoopDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblVItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 306);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bezier path";
            // 
            // radCarouselDemo
            // 
            this.radCarouselDemo.AutoLoopPauseCondition = Telerik.WinControls.UI.AutoLoopPauseConditions.None;
            this.radCarouselDemo.BackColor = System.Drawing.Color.Black;
            this.radCarouselDemo.BackgroundImage = global::Telerik.Examples.WinControls.Properties.Resources.PlanetsBG;
            this.radCarouselDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(49.358974358974358D, 46.315789473684212D, -20D);
            carouselEllipsePath1.FinalAngle = 60D;
            carouselEllipsePath1.InitialAngle = 60D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(37.93530426465815D, -18.191666666666663D, 0D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(-11.489983091663683D, -15.391666666666662D, -20D);
            carouselEllipsePath1.ZScale = 60D;
            this.radCarouselDemo.CarouselPath = carouselEllipsePath1;
            this.radCarouselDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarouselDemo.EnableAutoLoop = true;
            this.radCarouselDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCarouselDemo.ForeColor = System.Drawing.Color.Black;
            this.radCarouselDemo.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.radCarouselDemo.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2,
            this.radButtonElement3,
            this.radButtonElement4,
            this.radButtonElement5,
            this.radButtonElement6,
            this.radButtonElement7,
            this.radButtonElement8,
            this.radButtonElement9});
            this.radCarouselDemo.Location = new System.Drawing.Point(0, 132);
            this.radCarouselDemo.MinFadeOpacity = 0.5D;
            this.radCarouselDemo.Name = "radCarouselDemo";
            this.radCarouselDemo.NavigationButtonsOffset = new System.Drawing.Size(15, 15);
            this.radCarouselDemo.SelectedIndex = 0;
            this.radCarouselDemo.Size = new System.Drawing.Size(780, 475);
            this.radCarouselDemo.TabIndex = 1;
            this.radCarouselDemo.Text = "radCarouselDemo";
            this.radCarouselDemo.ThemeName = "ControlDefault";
            this.radCarouselDemo.VisibleItemCount = 9;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarouselDemo.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarouselDemo.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarouselDemo.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarouselDemo.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarouselDemo.GetChildAt(0).GetChildAt(3))).Image = global::Telerik.Examples.WinControls.Properties.Resources.CarouselSettings_PrevBtn;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarouselDemo.GetChildAt(0).GetChildAt(4))).Image = global::Telerik.Examples.WinControls.Properties.Resources.CarouselSettings_NextBtn;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "radButtonElement1";
            this.radButtonElement1.AccessibleName = "radButtonElement1";
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement1.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement1.Image")));
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "radButtonElement1";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement1.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement1.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "radButtonElement2";
            this.radButtonElement2.AccessibleName = "radButtonElement2";
            this.radButtonElement2.CanFocus = true;
            this.radButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement2.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement2.Image")));
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "radButtonElement2";
            this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement2.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement2.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.AccessibleDescription = "radButtonElement3";
            this.radButtonElement3.AccessibleName = "radButtonElement3";
            this.radButtonElement3.CanFocus = true;
            this.radButtonElement3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement3.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement3.Image")));
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.ShowBorder = false;
            this.radButtonElement3.Text = "radButtonElement3";
            this.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement3.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement3.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.AccessibleDescription = "radButtonElement4";
            this.radButtonElement4.AccessibleName = "radButtonElement4";
            this.radButtonElement4.CanFocus = true;
            this.radButtonElement4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement4.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement4.Image")));
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.ShowBorder = false;
            this.radButtonElement4.Text = "radButtonElement4";
            this.radButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement4.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement4.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement5
            // 
            this.radButtonElement5.AccessibleDescription = "radButtonElement5";
            this.radButtonElement5.AccessibleName = "radButtonElement5";
            this.radButtonElement5.CanFocus = true;
            this.radButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement5.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement5.Image")));
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.ShowBorder = false;
            this.radButtonElement5.Text = "radButtonElement5";
            this.radButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement5.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement5.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement6
            // 
            this.radButtonElement6.AccessibleDescription = "radButtonElement6";
            this.radButtonElement6.AccessibleName = "radButtonElement6";
            this.radButtonElement6.CanFocus = true;
            this.radButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement6.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement6.Image")));
            this.radButtonElement6.Name = "radButtonElement6";
            this.radButtonElement6.ShowBorder = false;
            this.radButtonElement6.Text = "radButtonElement6";
            this.radButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement6.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement6.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement7
            // 
            this.radButtonElement7.AccessibleDescription = "radButtonElement7";
            this.radButtonElement7.AccessibleName = "radButtonElement7";
            this.radButtonElement7.CanFocus = true;
            this.radButtonElement7.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement7.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement7.Image")));
            this.radButtonElement7.Name = "radButtonElement7";
            this.radButtonElement7.ShowBorder = false;
            this.radButtonElement7.Text = "radButtonElement7";
            this.radButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement7.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement7.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement8
            // 
            this.radButtonElement8.AccessibleDescription = "radButtonElement8";
            this.radButtonElement8.AccessibleName = "radButtonElement8";
            this.radButtonElement8.CanFocus = true;
            this.radButtonElement8.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement8.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement8.Image")));
            this.radButtonElement8.Name = "radButtonElement8";
            this.radButtonElement8.ShowBorder = false;
            this.radButtonElement8.Text = "radButtonElement8";
            this.radButtonElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement8.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement8.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement9
            // 
            this.radButtonElement9.AccessibleDescription = "radButtonElement9";
            this.radButtonElement9.AccessibleName = "radButtonElement9";
            this.radButtonElement9.CanFocus = true;
            this.radButtonElement9.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButtonElement9.Image = ((System.Drawing.Image)(resources.GetObject("radButtonElement9.Image")));
            this.radButtonElement9.Name = "radButtonElement9";
            this.radButtonElement9.ShowBorder = false;
            this.radButtonElement9.Text = "radButtonElement9";
            this.radButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButtonElement9.GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButtonElement9.GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radThemeManager1
            // 
            themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource;
            themeSource1.ThemeLocation = "Telerik.Examples.WinControls.Carousel.CarouselSettings.CarouselButtons.xml";
            themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource;
            themeSource2.ThemeLocation = "TelerikExamples.Carousel.MusicLibrary.ButtonMusicLibrary.xml";
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource1,
            themeSource2});
            // 
            // radTitleBar
            // 
            this.radTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar.ForeColor = System.Drawing.Color.White;
            this.radTitleBar.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar.Name = "radTitleBar";
            this.radTitleBar.Size = new System.Drawing.Size(780, 52);
            this.radTitleBar.TabIndex = 14;
            this.radTitleBar.TabStop = false;
            this.radTitleBar.Text = "Solar System Settings";
            ((Telerik.WinControls.UI.RadTitleBarElement)(this.radTitleBar.GetChildAt(0))).Text = "Solar System Settings";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(0))).GradientPercentage = 0.25F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(0))).GradientPercentage2 = 0.25F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(1))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(1))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(1))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(1))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(1))).BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(2))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(2))).Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Image = global::Telerik.Examples.WinControls.Properties.Resources.CarouselSettings_Min;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, 0, -2, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).Image = global::Telerik.Examples.WinControls.Properties.Resources.CarouselSettings_Max;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0, 0, -2, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3))).Image = global::Telerik.Examples.WinControls.Properties.Resources.CarouselSettings_Close;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTitleBar.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radComboAutoLoop);
            this.radPanel1.Controls.Add(this.radCheckEnableLooping);
            this.radPanel1.Controls.Add(this.radCheckAutoLoop);
            this.radPanel1.Controls.Add(this.radCheckVirtualMode);
            this.radPanel1.Controls.Add(this.radSpinRestoreDuration);
            this.radPanel1.Controls.Add(this.radSpinVisibleElements);
            this.radPanel1.Controls.Add(this.radLblAutoLoopDirection);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radLblVItemCount);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 52);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(780, 80);
            this.radPanel1.TabIndex = 15;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(8);
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(228)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).NumberOfColors = 4;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(241)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).BoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(204)))));
            // 
            // radComboAutoLoop
            // 
            this.radComboAutoLoop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radComboAutoLoop.DropDownAnimationEnabled = true;
            this.radComboAutoLoop.Location = new System.Drawing.Point(332, 40);
            this.radComboAutoLoop.Name = "radComboAutoLoop";
            this.radComboAutoLoop.ShowImageInEditorArea = true;
            this.radComboAutoLoop.Size = new System.Drawing.Size(106, 20);
            this.radComboAutoLoop.TabIndex = 19;
            this.radComboAutoLoop.Text = "Forward";
            this.radComboAutoLoop.ThemeName = "Office2010Black";
            this.radComboAutoLoop.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;

            // 
            // radCheckEnableLooping
            // 
            this.radCheckEnableLooping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCheckEnableLooping.BackColor = System.Drawing.Color.Transparent;
            this.radCheckEnableLooping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckEnableLooping.Location = new System.Drawing.Point(93, 20);
            this.radCheckEnableLooping.Name = "radCheckEnableLooping";
            this.radCheckEnableLooping.Size = new System.Drawing.Size(98, 18);
            this.radCheckEnableLooping.TabIndex = 12;
            this.radCheckEnableLooping.Text = "Enable Looping";
            this.radCheckEnableLooping.ThemeName = "Office2010Black";
            this.radCheckEnableLooping.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            // 
            // radCheckAutoLoop
            // 
            this.radCheckAutoLoop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCheckAutoLoop.BackColor = System.Drawing.Color.Transparent;
            this.radCheckAutoLoop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckAutoLoop.Location = new System.Drawing.Point(93, 43);
            this.radCheckAutoLoop.Name = "radCheckAutoLoop";
            this.radCheckAutoLoop.Size = new System.Drawing.Size(70, 18);
            this.radCheckAutoLoop.TabIndex = 18;
            this.radCheckAutoLoop.Text = "AutoLoop";
            this.radCheckAutoLoop.ThemeName = "Office2010Black";
            this.radCheckAutoLoop.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            // 
            // radCheckVirtualMode
            // 
            this.radCheckVirtualMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radCheckVirtualMode.BackColor = System.Drawing.Color.Transparent;
            this.radCheckVirtualMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.radCheckVirtualMode.Location = new System.Drawing.Point(214, 31);
            this.radCheckVirtualMode.Name = "radCheckVirtualMode";
            this.radCheckVirtualMode.Size = new System.Drawing.Size(85, 18);
            this.radCheckVirtualMode.TabIndex = 17;
            this.radCheckVirtualMode.Text = "Virtual Mode";
            this.radCheckVirtualMode.ThemeName = "Office2010Black";
            this.radCheckVirtualMode.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        
            // 
            // radSpinRestoreDuration
            // 
            this.radSpinRestoreDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSpinRestoreDuration.Location = new System.Drawing.Point(597, 40);
            this.radSpinRestoreDuration.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.radSpinRestoreDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinRestoreDuration.Name = "radSpinRestoreDuration";
            // 
            // 
            // 
            this.radSpinRestoreDuration.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinRestoreDuration.ShowBorder = true;
            this.radSpinRestoreDuration.Size = new System.Drawing.Size(90, 20);
            this.radSpinRestoreDuration.TabIndex = 14;
            this.radSpinRestoreDuration.TabStop = false;
            this.radSpinRestoreDuration.ThemeName = "Office2010Black";
            this.radSpinRestoreDuration.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});

            // 
            // radSpinVisibleElements
            // 
            this.radSpinVisibleElements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSpinVisibleElements.Location = new System.Drawing.Point(471, 40);
            this.radSpinVisibleElements.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.radSpinVisibleElements.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinVisibleElements.Name = "radSpinVisibleElements";
            // 
            // 
            // 
            this.radSpinVisibleElements.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinVisibleElements.ShowBorder = true;
            this.radSpinVisibleElements.Size = new System.Drawing.Size(90, 20);
            this.radSpinVisibleElements.TabIndex = 13;
            this.radSpinVisibleElements.TabStop = false;
            this.radSpinVisibleElements.ThemeName = "Office2010Black";
            this.radSpinVisibleElements.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
          
            // 
            // radLblAutoLoopDirection
            // 
            this.radLblAutoLoopDirection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblAutoLoopDirection.BackColor = System.Drawing.Color.Transparent;
            this.radLblAutoLoopDirection.ForeColor = System.Drawing.Color.Black;
            this.radLblAutoLoopDirection.Location = new System.Drawing.Point(332, 20);
            this.radLblAutoLoopDirection.Name = "radLblAutoLoopDirection";
            this.radLblAutoLoopDirection.Size = new System.Drawing.Size(80, 18);
            this.radLblAutoLoopDirection.TabIndex = 20;
            this.radLblAutoLoopDirection.Text = "Loop Direction";
            this.radLblAutoLoopDirection.ThemeName = "Office2010Black";
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.ForeColor = System.Drawing.Color.Black;
            this.radLabel3.Location = new System.Drawing.Point(597, 20);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(91, 18);
            this.radLabel3.TabIndex = 16;
            this.radLabel3.Text = "Restore Duration";
            this.radLabel3.ThemeName = "Office2010Black";
            // 
            // radLblVItemCount
            // 
            this.radLblVItemCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLblVItemCount.BackColor = System.Drawing.Color.Transparent;
            this.radLblVItemCount.ForeColor = System.Drawing.Color.Black;
            this.radLblVItemCount.Location = new System.Drawing.Point(471, 20);
            this.radLblVItemCount.Name = "radLblVItemCount";
            this.radLblVItemCount.Size = new System.Drawing.Size(69, 18);
            this.radLblVItemCount.TabIndex = 15;
            this.radLblVItemCount.Text = "Visible Items";
            this.radLblVItemCount.ThemeName = "Office2010Black";
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.Radius = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(780, 607);
            this.Controls.Add(this.radCarouselDemo);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radTitleBar);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "Form1";
            this.Shape = this.roundRectShape1;
            this.Text = "Solar System Settings";
            ((System.ComponentModel.ISupportInitialize)(this.radCarouselDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radComboAutoLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckEnableLooping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckAutoLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckVirtualMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinRestoreDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinVisibleElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblAutoLoopDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblVItemCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarouselDemo;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement5;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement6;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement7;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement8;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement9;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadDropDownList radComboAutoLoop;
        private Telerik.WinControls.UI.RadCheckBox radCheckEnableLooping;
        private Telerik.WinControls.UI.RadCheckBox radCheckAutoLoop;
        private Telerik.WinControls.UI.RadCheckBox radCheckVirtualMode;
        private Telerik.WinControls.UI.RadSpinEditor radSpinRestoreDuration;
        private Telerik.WinControls.UI.RadSpinEditor radSpinVisibleElements;
        private Telerik.WinControls.UI.RadLabel radLblAutoLoopDirection;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLblVItemCount;
        private Telerik.WinControls.RoundRectShape roundRectShape1;

    }
}