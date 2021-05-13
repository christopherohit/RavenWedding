namespace Telerik.Examples.WinControls.Buttons.Button
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.tableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.radRadioImgAboveTxt = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioOverlay = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioImgBeforeTxt = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioTxtBeforeImg = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioTxtAboveImg = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel2 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgAboveTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgBeforeTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtBeforeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtAboveImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.tableLayoutPanel2);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(204, 348);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(800, 600);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1020, 21);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.groupBox1);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(200, 586);
            this.settingsPanel.Size = new System.Drawing.Size(200, 586);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageList1.Images.SetKeyName(0, "print.gif");
            this.imageList1.Images.SetKeyName(1, "bulb_on.GIF");
            this.imageList1.Images.SetKeyName(2, "bulb_off.GIF");
            this.imageList1.Images.SetKeyName(3, "iconDropDown.bmp");
            this.imageList1.Images.SetKeyName(4, "iconMoveToFolder.bmp");
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.FooterText = "";
            this.groupBox1.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupBox1.HeaderText = "Text Image Relation";
            this.groupBox1.Location = new System.Drawing.Point(17, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.groupBox1.Size = new System.Drawing.Size(180, 241);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Image Relation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radRadioImgAboveTxt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radRadioOverlay, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radRadioImgBeforeTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radRadioTxtBeforeImg, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radRadioTxtAboveImg, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 211);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // radRadioImgAboveTxt
            // 
            this.radRadioImgAboveTxt.Location = new System.Drawing.Point(3, 3);
            this.radRadioImgAboveTxt.Name = "radRadioImgAboveTxt";
            this.radRadioImgAboveTxt.Size = new System.Drawing.Size(110, 18);
            this.radRadioImgAboveTxt.TabIndex = 0;
            this.radRadioImgAboveTxt.Text = "Image Above Text";
            // 
            // radRadioOverlay
            // 
            this.radRadioOverlay.Location = new System.Drawing.Point(3, 171);
            this.radRadioOverlay.Name = "radRadioOverlay";
            this.radRadioOverlay.Size = new System.Drawing.Size(58, 18);
            this.radRadioOverlay.TabIndex = 0;
            this.radRadioOverlay.Text = "Overlay";
            // 
            // radRadioImgBeforeTxt
            // 
            this.radRadioImgBeforeTxt.Location = new System.Drawing.Point(3, 45);
            this.radRadioImgBeforeTxt.Name = "radRadioImgBeforeTxt";
            this.radRadioImgBeforeTxt.Size = new System.Drawing.Size(111, 18);
            this.radRadioImgBeforeTxt.TabIndex = 0;
            this.radRadioImgBeforeTxt.Text = "Image Before Text";
            // 
            // radRadioTxtBeforeImg
            // 
            this.radRadioTxtBeforeImg.Location = new System.Drawing.Point(3, 129);
            this.radRadioTxtBeforeImg.Name = "radRadioTxtBeforeImg";
            this.radRadioTxtBeforeImg.Size = new System.Drawing.Size(111, 18);
            this.radRadioTxtBeforeImg.TabIndex = 0;
            this.radRadioTxtBeforeImg.Text = "Text Before Image";
            // 
            // radRadioTxtAboveImg
            // 
            this.radRadioTxtAboveImg.Location = new System.Drawing.Point(3, 87);
            this.radRadioTxtAboveImg.Name = "radRadioTxtAboveImg";
            this.radRadioTxtAboveImg.Size = new System.Drawing.Size(110, 18);
            this.radRadioTxtAboveImg.TabIndex = 0;
            this.radRadioTxtAboveImg.Text = "Text Above Image";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(64, 18);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Text Button";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(3, 135);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(122, 18);
            this.radLabel3.TabIndex = 11;
            this.radLabel3.Text = "Text And Image Button";
            // 
            // radButton3
            // 
            this.radButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton3.ImageIndex = 3;
            this.radButton3.ImageList = this.imageList1;
            this.radButton3.Location = new System.Drawing.Point(198, 135);
            this.radButton3.Name = "radButton3";
            // 
            // 
            // 
            this.radButton3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radButton3.Size = new System.Drawing.Size(164, 62);
            this.radButton3.TabIndex = 9;
            this.radButton3.Text = "Check Mail";
            this.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).ImageIndex = 3;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Text = "Check Mail";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton3.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(4);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 69);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(74, 18);
            this.radLabel2.TabIndex = 12;
            this.radLabel2.Text = "Image Button";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(198, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(164, 25);
            this.radButton1.TabIndex = 7;
            this.radButton1.Text = "Check Mail";
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton2.ImageIndex = 3;
            this.radButton2.ImageList = this.imageList1;
            this.radButton2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.radButton2.Location = new System.Drawing.Point(198, 69);
            this.radButton2.Name = "radButton2";
            // 
            // 
            // 
            this.radButton2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radButton2.Size = new System.Drawing.Size(164, 25);
            this.radButton2.TabIndex = 8;
            this.radButton2.Text = "radButton2";
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.42466F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.57534F));
            this.tableLayoutPanel2.Controls.Add(this.radLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radLabel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radButton1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radButton3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.radButton2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(206, 210);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 200);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1831, 1148);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgAboveTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioImgBeforeTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtBeforeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioTxtAboveImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadGroupBox groupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioOverlay;
        private Telerik.WinControls.UI.RadRadioButton radRadioTxtBeforeImg;
        private Telerik.WinControls.UI.RadRadioButton radRadioTxtAboveImg;
        private Telerik.WinControls.UI.RadRadioButton radRadioImgBeforeTxt;
        private Telerik.WinControls.UI.RadRadioButton radRadioImgAboveTxt;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}
