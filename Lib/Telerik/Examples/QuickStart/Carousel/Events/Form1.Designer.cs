using System.Windows.Forms;

namespace Telerik.Examples.WinControls.Carousel.Events
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
            Telerik.WinControls.UI.CarouselBezierPath carouselBezierPath1 = new Telerik.WinControls.UI.CarouselBezierPath();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.radListEvents = new Telerik.WinControls.UI.RadListControl();
            this.radCarouselDemo = new Telerik.WinControls.UI.RadCarousel();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.radLblEvents = new Telerik.WinControls.UI.RadLabel();
            this.radRadioEllipse = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioBezier = new Telerik.WinControls.UI.RadRadioButton();
            this.radLblReflectionPerc = new Telerik.WinControls.UI.RadLabel();
            this.doubleBufferedTableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCarouselDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioBezier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblReflectionPerc)).BeginInit();
            this.doubleBufferedTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1267, 1);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupSettings);
            this.settingsPanel.PanelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(384, 704);
            this.settingsPanel.Size = new System.Drawing.Size(384, 704);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "Carousel01.png");
            this.imageList4.Images.SetKeyName(1, "Carousel02.png");
            this.imageList4.Images.SetKeyName(2, "Carousel03.png");
            this.imageList4.Images.SetKeyName(3, "Carousel04.png");
            this.imageList4.Images.SetKeyName(4, "Carousel05.png");
            this.imageList4.Images.SetKeyName(5, "Carousel06.png");
            this.imageList4.Images.SetKeyName(6, "Carousel07.png");
            // 
            // radListEvents
            // 
            this.radListEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListEvents.ItemHeight = 24;
            this.radListEvents.Location = new System.Drawing.Point(4, 270);
            this.radListEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radListEvents.Name = "radListEvents";
            this.radListEvents.Size = new System.Drawing.Size(242, 309);
            this.radListEvents.TabIndex = 1;
            // 
            // radCarouselDemo
            // 
            this.radCarouselDemo.AutoLoopPauseCondition = Telerik.WinControls.UI.AutoLoopPauseConditions.OnMouseOverItem;
            this.radCarouselDemo.BackColor = System.Drawing.Color.Transparent;
            carouselBezierPath1.CtrlPoint1 = new Telerik.WinControls.UI.Point3D(125.91508052708639D, 91.503267973856211D, 100D);
            carouselBezierPath1.CtrlPoint2 = new Telerik.WinControls.UI.Point3D(64.71449487554905D, -35.62091503267974D, -100D);
            carouselBezierPath1.FirstPoint = new Telerik.WinControls.UI.Point3D(5.2708638360175692D, 10.130718954248366D, 0D);
            carouselBezierPath1.LastPoint = new Telerik.WinControls.UI.Point3D(16.594516594516595D, 79.950495049504951D, 100D);
            carouselBezierPath1.ZScale = 500D;
            this.radCarouselDemo.CarouselPath = carouselBezierPath1;
            this.radCarouselDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarouselDemo.EnableAutoLoop = true;
            this.radCarouselDemo.Location = new System.Drawing.Point(0, 0);
            this.radCarouselDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCarouselDemo.Name = "radCarouselDemo";
            this.radCarouselDemo.Size = new System.Drawing.Size(2336, 1468);
            this.radCarouselDemo.TabIndex = 0;
            this.radCarouselDemo.Text = "radCarousel1";
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarouselDemo.GetChildAt(0).GetChildAt(3))).Image = global::Telerik.Examples.WinControls.Properties.Resources.carousel_leftArrow;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarouselDemo.GetChildAt(0).GetChildAt(4))).Image = global::Telerik.Examples.WinControls.Properties.Resources.carousel_rightArrow;
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.DecimalPlaces = 2;
            this.radSpinEditor1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.radSpinEditor1.Location = new System.Drawing.Point(4, 118);
            this.radSpinEditor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSpinEditor1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.NullableValue = new decimal(new int[] {
            33,
            0,
            0,
            131072});
            // 
            // 
            // 
            this.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditor1.Size = new System.Drawing.Size(215, 24);
            this.radSpinEditor1.TabIndex = 7;
            this.radSpinEditor1.TabStop = false;
            this.radSpinEditor1.Value = new decimal(new int[] {
            33,
            0,
            0,
            131072});
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox1.Location = new System.Drawing.Point(4, 156);
            this.radCheckBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(120, 22);
            this.radCheckBox1.TabIndex = 10;
            this.radCheckBox1.Text = "Enable Looping";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox2.Location = new System.Drawing.Point(4, 194);
            this.radCheckBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(134, 22);
            this.radCheckBox2.TabIndex = 11;
            this.radCheckBox2.Text = "Enable Auto Loop";
            this.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSettings.Controls.Add(this.doubleBufferedTableLayoutPanel1);
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.HeaderText = "Carousel Settings";
            this.radGroupSettings.Location = new System.Drawing.Point(29, 40);
            this.radGroupSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGroupSettings.Name = "radGroupSettings";
            this.radGroupSettings.Padding = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.radGroupSettings.Size = new System.Drawing.Size(278, 640);
            this.radGroupSettings.TabIndex = 1;
            this.radGroupSettings.Text = "Carousel Settings";
            // 
            // radLblEvents
            // 
            this.radLblEvents.Location = new System.Drawing.Point(4, 232);
            this.radLblEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLblEvents.Name = "radLblEvents";
            this.radLblEvents.Size = new System.Drawing.Size(50, 22);
            this.radLblEvents.TabIndex = 13;
            this.radLblEvents.Text = "Events:";
            // 
            // radRadioEllipse
            // 
            this.radRadioEllipse.Location = new System.Drawing.Point(4, 42);
            this.radRadioEllipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRadioEllipse.Name = "radRadioEllipse";
            this.radRadioEllipse.Size = new System.Drawing.Size(95, 22);
            this.radRadioEllipse.TabIndex = 12;
            this.radRadioEllipse.Text = "Ellipse Path";
            // 
            // radRadioBezier
            // 
            this.radRadioBezier.Location = new System.Drawing.Point(4, 4);
            this.radRadioBezier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRadioBezier.Name = "radRadioBezier";
            this.radRadioBezier.Size = new System.Drawing.Size(93, 22);
            this.radRadioBezier.TabIndex = 12;
            this.radRadioBezier.Text = "Bezier Path";
            // 
            // radLblReflectionPerc
            // 
            this.radLblReflectionPerc.Location = new System.Drawing.Point(4, 80);
            this.radLblReflectionPerc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radLblReflectionPerc.Name = "radLblReflectionPerc";
            this.radLblReflectionPerc.Size = new System.Drawing.Size(176, 22);
            this.radLblReflectionPerc.TabIndex = 1;
            this.radLblReflectionPerc.Text = "Item Reflection Percentage:";
            // 
            // tableLayoutPanel1
            // 
            this.doubleBufferedTableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferedTableLayoutPanel1.ColumnCount = 1;
            this.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radRadioBezier, 0, 0);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radListEvents, 0, 7);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLblEvents, 0, 6);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radRadioEllipse, 0, 1);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radLblReflectionPerc, 0, 2);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radCheckBox2, 0, 5);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radSpinEditor1, 0, 3);
            this.doubleBufferedTableLayoutPanel1.Controls.Add(this.radCheckBox1, 0, 4);
            this.doubleBufferedTableLayoutPanel1.Location = new System.Drawing.Point(6, 32);
            this.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1";
            this.doubleBufferedTableLayoutPanel1.RowCount = 8;
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.684673F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68467F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68467F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68467F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68467F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68467F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.68467F));
            this.doubleBufferedTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.2073F));
            this.doubleBufferedTableLayoutPanel1.Size = new System.Drawing.Size(250, 583);
            this.doubleBufferedTableLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.radCarouselDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2349, 1480);
            this.Controls.SetChildIndex(this.radCarouselDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCarouselDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLblEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioBezier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblReflectionPerc)).EndInit();
            this.doubleBufferedTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferedTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarouselDemo;
        private System.Windows.Forms.ImageList imageList4;
        private Telerik.WinControls.UI.RadListControl radListEvents;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupSettings;
        private Telerik.WinControls.UI.RadLabel radLblReflectionPerc;
        private Telerik.WinControls.UI.RadRadioButton radRadioEllipse;
        private Telerik.WinControls.UI.RadRadioButton radRadioBezier;
        private Telerik.WinControls.UI.RadLabel radLblEvents;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel doubleBufferedTableLayoutPanel1;
    }
}