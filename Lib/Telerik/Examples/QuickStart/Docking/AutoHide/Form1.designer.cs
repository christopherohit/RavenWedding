namespace Telerik.Examples.WinControls.Docking.AutoHide
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radSplitContainer3 = new Telerik.WinControls.UI.RadSplitContainer();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.toolTabStrip4 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.toolTabStrip5 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow4 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radSplitContainer4 = new Telerik.WinControls.UI.RadSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer3)).BeginInit();
            this.radSplitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip4)).BeginInit();
            this.toolTabStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip5)).BeginInit();
            this.toolTabStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer4)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(552, 1);
            // 
            // 
            // 
            this.settingsPanel.Size = new System.Drawing.Size(200, 723);
            this.settingsPanel.ThemeName = "ControlDefault";
            // 
            // timer1
            // 
            this.timer1.Interval = 800;

            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.toolWindow2;
            this.radDock1.Controls.Add(this.radSplitContainer3);
            this.radDock1.Controls.Add(this.toolTabStrip5);
            this.radDock1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.radDock1.Location = new System.Drawing.Point(5, 5);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            this.radDock1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(743, 715);
            this.radDock1.TabIndex = 1;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // toolWindow2
            // 
            this.toolWindow2.Location = new System.Drawing.Point(1, 26);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.Size = new System.Drawing.Size(571, 130);
            this.toolWindow2.Text = "toolWindow2";
            // 
            // radSplitContainer3
            // 
            this.radSplitContainer3.Controls.Add(this.radSplitContainer2);
            this.radSplitContainer3.Controls.Add(this.toolTabStrip4);
            this.radSplitContainer3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer3.Name = "radSplitContainer3";
            // 
            // 
            // 
            this.radSplitContainer3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer3.Size = new System.Drawing.Size(743, 556);
            this.radSplitContainer3.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 554);
            this.radSplitContainer3.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 44);
            this.radSplitContainer3.TabIndex = 0;
            this.radSplitContainer3.TabStop = false;
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer2.Controls.Add(this.radSplitContainer1);
            this.radSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer2.Name = "radSplitContainer2";
            this.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(573, 556);
            this.radSplitContainer2.SizeInfo.AbsoluteSize = new System.Drawing.Size(1005, 200);
            this.radSplitContainer2.SizeInfo.SplitterCorrection = new System.Drawing.Size(33, 0);
            this.radSplitContainer2.TabIndex = 0;
            this.radSplitContainer2.TabStop = false;
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Top;
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(573, 157);
            this.toolTabStrip2.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 157);
            this.toolTabStrip2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -43);
            this.toolTabStrip2.TabIndex = 1;
            this.toolTabStrip2.TabStop = false;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.documentContainer1);
            this.radSplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 160);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(573, 396);
            this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 350);
            this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 43);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Left;
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(178, 396);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(178, 200);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-22, 0);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Location = new System.Drawing.Point(1, 26);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.Size = new System.Drawing.Size(176, 369);
            this.toolWindow1.Text = "toolWindow1";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Location = new System.Drawing.Point(181, 0);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.Size = new System.Drawing.Size(392, 396);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.TabIndex = 2;
            this.documentContainer1.TabStop = false;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(392, 396);
            this.documentTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(791, 200);
            this.documentTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(22, 0);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // documentWindow1
            // 
            this.documentWindow1.Controls.Add(this.radGroupBox2);
            this.documentWindow1.Controls.Add(this.radGroupBox1);
            this.documentWindow1.Location = new System.Drawing.Point(5, 27);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.Size = new System.Drawing.Size(382, 364);
            this.documentWindow1.Text = "Demo options";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.radButton2);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Toggle ToolWindows Visibility";
            this.radGroupBox2.Location = new System.Drawing.Point(251, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox2.Size = new System.Drawing.Size(214, 141);
            this.radGroupBox2.TabIndex = 5;
            this.radGroupBox2.Text = "Toggle ToolWindows Visibility";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton1.Location = new System.Drawing.Point(61, 45);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.Size = new System.Drawing.Size(92, 26);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Hide all";

            // 
            // radButton2
            // 
            this.radButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton2.Location = new System.Drawing.Point(61, 77);
            this.radButton2.Name = "radButton2";
            // 
            // 
            // 
            this.radButton2.Size = new System.Drawing.Size(92, 26);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Show all";
 
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radButton3);
            this.radGroupBox1.Controls.Add(this.radButton4);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Toggle ToolWindows Dock State";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(214, 141);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Toggle ToolWindows Dock State";
            // 
            // radButton3
            // 
            this.radButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton3.Location = new System.Drawing.Point(61, 45);
            this.radButton3.Name = "radButton3";
            // 
            // 
            // 
            this.radButton3.Size = new System.Drawing.Size(92, 26);
            this.radButton3.TabIndex = 2;
            this.radButton3.Text = "Dock all";
          
            // 
            // radButton4
            // 
            this.radButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radButton4.Location = new System.Drawing.Point(61, 77);
            this.radButton4.Name = "radButton4";
            // 
            // 
            // 
            this.radButton4.Size = new System.Drawing.Size(92, 26);
            this.radButton4.TabIndex = 3;
            this.radButton4.Text = "Auto-hide all";

            // 
            // toolTabStrip4
            // 
            this.toolTabStrip4.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Right;
            this.toolTabStrip4.Controls.Add(this.toolWindow3);
            this.toolTabStrip4.Location = new System.Drawing.Point(576, 0);
            this.toolTabStrip4.Name = "toolTabStrip4";
            // 
            // 
            // 
            this.toolTabStrip4.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip4.SelectedIndex = 0;
            this.toolTabStrip4.Size = new System.Drawing.Size(167, 556);
            this.toolTabStrip4.SizeInfo.AbsoluteSize = new System.Drawing.Size(167, 200);
            this.toolTabStrip4.SizeInfo.SplitterCorrection = new System.Drawing.Size(-33, 0);
            this.toolTabStrip4.TabIndex = 1;
            this.toolTabStrip4.TabStop = false;
            // 
            // toolWindow3
            // 
            this.toolWindow3.Location = new System.Drawing.Point(1, 26);
            this.toolWindow3.Name = "toolWindow3";
            this.toolWindow3.Size = new System.Drawing.Size(165, 529);
            this.toolWindow3.Text = "toolWindow3";
            // 
            // toolTabStrip5
            // 
            this.toolTabStrip5.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Bottom;
            this.toolTabStrip5.Controls.Add(this.toolWindow4);
            this.toolTabStrip5.Location = new System.Drawing.Point(0, 559);
            this.toolTabStrip5.Name = "toolTabStrip5";
            // 
            // 
            // 
            this.toolTabStrip5.RootElement.ForeColor = System.Drawing.Color.Black;
            this.toolTabStrip5.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip5.SelectedIndex = 0;
            this.toolTabStrip5.Size = new System.Drawing.Size(743, 156);
            this.toolTabStrip5.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 156);
            this.toolTabStrip5.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -44);
            this.toolTabStrip5.TabIndex = 1;
            this.toolTabStrip5.TabStop = false;
            // 
            // toolWindow4
            // 
            this.toolWindow4.Location = new System.Drawing.Point(1, 26);
            this.toolWindow4.Name = "toolWindow4";
            this.toolWindow4.Size = new System.Drawing.Size(741, 129);
            this.toolWindow4.Text = "toolWindow4";
            // 
            // radSplitContainer4
            // 
            this.radSplitContainer4.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer4.Name = "radSplitContainer4";
            this.radSplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer4.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer4.Size = new System.Drawing.Size(200, 200);
            this.radSplitContainer4.TabIndex = 0;
            this.radSplitContainer4.TabStop = false;
            this.radSplitContainer4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radDock1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(753, 725);
            this.Controls.SetChildIndex(this.radDock1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer3)).EndInit();
            this.radSplitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip4)).EndInit();
            this.toolTabStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip5)).EndInit();
            this.toolTabStrip5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer4)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer4;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow4;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer3;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip4;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip5;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;


    }
}
