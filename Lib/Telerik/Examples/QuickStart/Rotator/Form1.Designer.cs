namespace Telerik.Examples.WinControls.Rotator
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
            this.radRotator1 = new Telerik.WinControls.UI.RadRotator();
            this.radItemsContainer1 = new Telerik.WinControls.UI.RadItemsContainer();
            this.radImageItem1 = new Telerik.WinControls.UI.RadImageItem();
            this.radItemsContainer2 = new Telerik.WinControls.UI.RadItemsContainer();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radTextBoxElement1 = new Telerik.WinControls.UI.RadTextBoxElement();
            this.radWebBrowserItem1 = new Telerik.WinControls.UI.RadWebBrowserItem();
            this.radButtonPrevious = new Telerik.WinControls.UI.RadButton();
            this.radButtonNext = new Telerik.WinControls.UI.RadButton();
            this.radStartStopButton = new Telerik.WinControls.UI.RadButton();
            this.currentFrameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabelInterval = new Telerik.WinControls.UI.RadLabel();
            this.intervalTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radCheckBoxOpacity = new Telerik.WinControls.UI.RadCheckBox();
            this.locationAnimationTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabelMsec = new Telerik.WinControls.UI.RadLabel();
            this.radLabelLocationAnimation = new Telerik.WinControls.UI.RadLabel();
            this.radButtonApply = new Telerik.WinControls.UI.RadButton();
            this.radGroupSettings = new Telerik.WinControls.UI.RadGroupBox();
            this.tableLayoutPanel2 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.tableLayoutPanel1 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            this.tableLayoutPanel3 = new Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStartStopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFrameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationAnimationTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLocationAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).BeginInit();
            this.radGroupSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.ForeColor = System.Drawing.Color.Black;
            this.settingsPanel.Location = new System.Drawing.Point(1439, 1);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.radGroupSettings);
            this.settingsPanel.PanelContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(468, 1278);
            this.settingsPanel.Size = new System.Drawing.Size(468, 1278);
            // 
            // radRotator1
            // 
            this.radRotator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRotator1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radItemsContainer1,
            this.radItemsContainer2,
            this.radWebBrowserItem1});
            this.radRotator1.Location = new System.Drawing.Point(5, 5);
            this.radRotator1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radRotator1.Name = "radRotator1";
            this.radRotator1.Size = new System.Drawing.Size(1436, 1008);
            this.radRotator1.TabIndex = 0;
            this.radRotator1.Text = "radRotator1";
            // 
            // radItemsContainer1
            // 
            this.radItemsContainer1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radImageItem1});
            this.radItemsContainer1.Name = "radItemsContainer1";
            this.radItemsContainer1.Text = "radItemsContainer1";
            this.radItemsContainer1.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radImageItem1
            // 
            this.radImageItem1.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radImageItem1.Image = global::Telerik.Examples.WinControls.Properties.Resources.RadRotatorWinF;
            this.radImageItem1.Name = "radImageItem1";
            this.radImageItem1.StretchHorizontally = false;
            this.radImageItem1.StretchVertically = false;
            this.radImageItem1.Text = "radImageItem1";
            // 
            // radItemsContainer2
            // 
            this.radItemsContainer2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radLabelElement1,
            this.radTextBoxElement1});
            this.radItemsContainer2.Name = "radItemsContainer2";
            this.radItemsContainer2.Text = "radItemsContainer2";
            this.radItemsContainer2.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.radButtonElement1.StretchHorizontally = false;
            this.radButtonElement1.StretchVertically = false;
            this.radButtonElement1.Text = "Previous frame";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabelElement1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelElement1.Name = "radLabelElement1";
            this.radLabelElement1.Opacity = 0.25D;
            this.radLabelElement1.StretchHorizontally = false;
            this.radLabelElement1.StretchVertically = false;
            this.radLabelElement1.Text = "Second rotator frame";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radLabelElement1.TextWrap = true;
            // 
            // radTextBoxElement1
            // 
            this.radTextBoxElement1.Alignment = System.Drawing.ContentAlignment.BottomRight;
            this.radTextBoxElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radTextBoxElement1.BackColor = System.Drawing.Color.Black;
            this.radTextBoxElement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBoxElement1.ForeColor = System.Drawing.Color.White;
            this.radTextBoxElement1.MinSize = new System.Drawing.Size(781, 0);
            this.radTextBoxElement1.Name = "radTextBoxElement1";
            this.radTextBoxElement1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.radTextBoxElement1.StretchHorizontally = false;
            this.radTextBoxElement1.StretchVertically = false;
            this.radTextBoxElement1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // radWebBrowserItem1
            // 
            this.radWebBrowserItem1.DocumentText = "<HTML></HTML>\0";
            this.radWebBrowserItem1.Name = "radWebBrowserItem1";
            this.radWebBrowserItem1.Text = "radWebBrowserItem1";
            this.radWebBrowserItem1.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.radWebBrowserItem1.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radButtonPrevious
            // 
            this.radButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonPrevious.Location = new System.Drawing.Point(83, 24);
            this.radButtonPrevious.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radButtonPrevious.Name = "radButtonPrevious";
            this.radButtonPrevious.ShowItemToolTips = false;
            this.radButtonPrevious.Size = new System.Drawing.Size(68, 41);
            this.radButtonPrevious.TabIndex = 1;
            this.radButtonPrevious.Text = "|<";
            // 
            // radButtonNext
            // 
            this.radButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radButtonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButtonNext.Location = new System.Drawing.Point(239, 23);
            this.radButtonNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radButtonNext.Name = "radButtonNext";
            this.radButtonNext.Size = new System.Drawing.Size(68, 42);
            this.radButtonNext.TabIndex = 2;
            this.radButtonNext.Text = ">|";
            // 
            // radStartStopButton
            // 
            this.radStartStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radStartStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStartStopButton.Location = new System.Drawing.Point(161, 23);
            this.radStartStopButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radStartStopButton.Name = "radStartStopButton";
            this.radStartStopButton.Size = new System.Drawing.Size(68, 42);
            this.radStartStopButton.TabIndex = 3;
            // 
            // currentFrameTextBox
            // 
            this.currentFrameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.currentFrameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFrameTextBox.Location = new System.Drawing.Point(5, 26);
            this.currentFrameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.currentFrameTextBox.Name = "currentFrameTextBox";
            // 
            // 
            // 
            this.currentFrameTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.currentFrameTextBox.Size = new System.Drawing.Size(68, 37);
            this.currentFrameTextBox.TabIndex = 4;
            this.currentFrameTextBox.TabStop = false;
            // 
            // radLabelInterval
            // 
            this.radLabelInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabelInterval.Location = new System.Drawing.Point(5, 42);
            this.radLabelInterval.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radLabelInterval.Name = "radLabelInterval";
            this.radLabelInterval.Size = new System.Drawing.Size(53, 22);
            this.radLabelInterval.TabIndex = 5;
            this.radLabelInterval.Text = "Interval";
            this.radLabelInterval.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalTextBox.Location = new System.Drawing.Point(5, 91);
            this.intervalTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.intervalTextBox.MaxLength = 5;
            this.intervalTextBox.Name = "intervalTextBox";
            // 
            // 
            // 
            this.intervalTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.intervalTextBox.Size = new System.Drawing.Size(146, 25);
            this.intervalTextBox.TabIndex = 6;
            this.intervalTextBox.TabStop = false;
            this.intervalTextBox.Text = "2000";
            // 
            // radCheckBoxOpacity
            // 
            this.radCheckBoxOpacity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radCheckBoxOpacity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBoxOpacity.Location = new System.Drawing.Point(5, 299);
            this.radCheckBoxOpacity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radCheckBoxOpacity.Name = "radCheckBoxOpacity";
            this.radCheckBoxOpacity.Size = new System.Drawing.Size(140, 22);
            this.radCheckBoxOpacity.TabIndex = 7;
            this.radCheckBoxOpacity.Text = "Opacity Animation";
            this.radCheckBoxOpacity.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // locationAnimationTextBox
            // 
            this.locationAnimationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.locationAnimationTextBox.Location = new System.Drawing.Point(5, 229);
            this.locationAnimationTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.locationAnimationTextBox.Name = "locationAnimationTextBox";
            // 
            // 
            // 
            this.locationAnimationTextBox.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.locationAnimationTextBox.Size = new System.Drawing.Size(146, 25);
            this.locationAnimationTextBox.TabIndex = 8;
            this.locationAnimationTextBox.TabStop = false;
            this.locationAnimationTextBox.Text = "0, -1";
            // 
            // radLabelMsec
            // 
            this.radLabelMsec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabelMsec.Location = new System.Drawing.Point(161, 92);
            this.radLabelMsec.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radLabelMsec.Name = "radLabelMsec";
            this.radLabelMsec.Size = new System.Drawing.Size(25, 22);
            this.radLabelMsec.TabIndex = 9;
            this.radLabelMsec.Text = "ms";
            this.radLabelMsec.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // radLabelLocationAnimation
            // 
            this.radLabelLocationAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabelLocationAnimation.Location = new System.Drawing.Point(5, 180);
            this.radLabelLocationAnimation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radLabelLocationAnimation.Name = "radLabelLocationAnimation";
            this.radLabelLocationAnimation.Size = new System.Drawing.Size(130, 22);
            this.radLabelLocationAnimation.TabIndex = 10;
            this.radLabelLocationAnimation.Text = "Location animation:";
            this.radLabelLocationAnimation.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // radButtonApply
            // 
            this.radButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.radButtonApply, 2);
            this.radButtonApply.Location = new System.Drawing.Point(5, 361);
            this.radButtonApply.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radButtonApply.Name = "radButtonApply";
            this.radButtonApply.Size = new System.Drawing.Size(302, 38);
            this.radButtonApply.TabIndex = 11;
            this.radButtonApply.Text = "Apply";
            // 
            // radGroupSettings
            // 
            this.radGroupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupSettings.Controls.Add(this.tableLayoutPanel2);
            this.radGroupSettings.FooterText = "";
            this.radGroupSettings.HeaderText = " Settings ";
            this.radGroupSettings.Location = new System.Drawing.Point(20, 69);
            this.radGroupSettings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.radGroupSettings.Name = "radGroupSettings";
            this.radGroupSettings.Padding = new System.Windows.Forms.Padding(15, 31, 15, 15);
            this.radGroupSettings.Size = new System.Drawing.Size(355, 480);
            this.radGroupSettings.TabIndex = 0;
            this.radGroupSettings.Text = " Settings ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radLabelInterval, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radButtonApply, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.intervalTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radCheckBoxOpacity, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.radLabelMsec, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.locationAnimationTextBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.radLabelLocationAnimation, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 36);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(312, 415);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.currentFrameTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radButtonPrevious, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radButtonNext, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radStartStopButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1129, 1023);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 89);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.radRotator1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 8);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.94915F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.05085F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1446, 1324);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(800, 800);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStartStopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFrameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBoxOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationAnimationTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelMsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLocationAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupSettings)).EndInit();
            this.radGroupSettings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadRotator radRotator1;
        private Telerik.WinControls.UI.RadItemsContainer radItemsContainer1;
        private Telerik.WinControls.UI.RadImageItem radImageItem1;
        private Telerik.WinControls.UI.RadItemsContainer radItemsContainer2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadTextBoxElement radTextBoxElement1;
        private Telerik.WinControls.UI.RadButton radButtonPrevious;
        private Telerik.WinControls.UI.RadButton radButtonNext;
        private Telerik.WinControls.UI.RadButton radStartStopButton;
        private Telerik.WinControls.UI.RadTextBox currentFrameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabelInterval;
        private Telerik.WinControls.UI.RadTextBox intervalTextBox;
        private Telerik.WinControls.UI.RadCheckBox radCheckBoxOpacity;
        private Telerik.WinControls.UI.RadTextBox locationAnimationTextBox;
        private Telerik.WinControls.UI.RadLabel radLabelMsec;
        private Telerik.WinControls.UI.RadLabel radLabelLocationAnimation;
        private Telerik.WinControls.UI.RadButton radButtonApply;
        private Telerik.WinControls.UI.RadWebBrowserItem radWebBrowserItem1;
        private Telerik.WinControls.UI.RadGroupBox radGroupSettings;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel tableLayoutPanel3;
    }
}