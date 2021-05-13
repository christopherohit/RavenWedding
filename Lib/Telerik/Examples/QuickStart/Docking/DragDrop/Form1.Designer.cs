namespace Telerik.Examples.WinControls.Docking.DragDrop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.toolTabStrip3 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.toolWindow3 = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.tool1Drag = new Telerik.WinControls.UI.RadCheckBox();
            this.tool2Drag = new Telerik.WinControls.UI.RadCheckBox();
            this.tool3Drop = new Telerik.WinControls.UI.RadCheckBox();
            this.allowDockBottom = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).BeginInit();
            this.toolTabStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tool1Drag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool2Drag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool3Drop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowDockBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radCheckBox1);
            this.settingsPanel.Controls.Add(this.allowDockBottom);
            this.settingsPanel.Controls.Add(this.tool3Drop);
            this.settingsPanel.Controls.Add(this.tool2Drag);
            this.settingsPanel.Controls.Add(this.tool1Drag);
            this.settingsPanel.Location = new System.Drawing.Point(552, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 806);
            this.settingsPanel.ThemeName = "ControlDefault";
            this.settingsPanel.Controls.SetChildIndex(this.tool1Drag, 0);
            this.settingsPanel.Controls.SetChildIndex(this.tool2Drag, 0);
            this.settingsPanel.Controls.SetChildIndex(this.tool3Drop, 0);
            this.settingsPanel.Controls.SetChildIndex(this.allowDockBottom, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radCheckBox1, 0);
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.documentWindow1;
            this.radDock1.Controls.Add(this.radSplitContainer2);
            this.radDock1.Controls.Add(this.toolTabStrip3);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 0);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radDock1.Size = new System.Drawing.Size(1334, 754);
            this.radDock1.TabIndex = 1;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Location = new System.Drawing.Point(6, 29);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow1.Size = new System.Drawing.Size(904, 505);
            this.documentWindow1.Text = "documentWindow1";
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Controls.Add(this.radSplitContainer1);
            this.radSplitContainer2.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer2.IsCleanUpTarget = true;
            this.radSplitContainer2.Location = new System.Drawing.Point(5, 5);
            this.radSplitContainer2.Name = "radSplitContainer2";
            this.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radSplitContainer2.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radSplitContainer2.Size = new System.Drawing.Size(1120, 744);
            this.radSplitContainer2.SplitterWidth = 4;
            this.radSplitContainer2.TabIndex = 0;
            this.radSplitContainer2.TabStop = false;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.documentContainer1);
            this.radSplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.radSplitContainer1.Size = new System.Drawing.Size(1120, 540);
            this.radSplitContainer1.SplitterWidth = 4;
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.Controls.Add(this.toolWindow1);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(200, 540);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            // 
            // toolWindow1
            // 
            this.toolWindow1.Caption = null;
            this.toolWindow1.Location = new System.Drawing.Point(1, 24);
            this.toolWindow1.Name = "toolWindow1";
            this.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindow1.Size = new System.Drawing.Size(198, 514);
            this.toolWindow1.Text = "toolWindow1";
            // 
            // documentContainer1
            // 
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(916, 540);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.CanUpdateChildIndex = true;
            this.toolTabStrip2.Controls.Add(this.toolWindow2);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 544);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(1120, 200);
            this.toolTabStrip2.TabIndex = 1;
            this.toolTabStrip2.TabStop = false;
            // 
            // toolWindow2
            // 
            this.toolWindow2.Caption = null;
            this.toolWindow2.Location = new System.Drawing.Point(1, 24);
            this.toolWindow2.Name = "toolWindow2";
            this.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindow2.Size = new System.Drawing.Size(1118, 174);
            this.toolWindow2.Text = "toolWindow2";
            // 
            // toolTabStrip3
            // 
            this.toolTabStrip3.CanUpdateChildIndex = true;
            this.toolTabStrip3.Controls.Add(this.toolWindow3);
            this.toolTabStrip3.Location = new System.Drawing.Point(1129, 5);
            this.toolTabStrip3.Name = "toolTabStrip3";
            // 
            // 
            // 
            this.toolTabStrip3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip3.SelectedIndex = 0;
            this.toolTabStrip3.Size = new System.Drawing.Size(200, 744);
            this.toolTabStrip3.TabIndex = 1;
            this.toolTabStrip3.TabStop = false;
            // 
            // toolWindow3
            // 
            this.toolWindow3.Caption = null;
            this.toolWindow3.Location = new System.Drawing.Point(1, 24);
            this.toolWindow3.Name = "toolWindow3";
            this.toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindow3.Size = new System.Drawing.Size(198, 718);
            this.toolWindow3.Text = "toolWindow3";
            // 
            // tool1Drag
            // 
            this.tool1Drag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tool1Drag.Location = new System.Drawing.Point(10, 9);
            this.tool1Drag.Name = "tool1Drag";
            this.tool1Drag.Size = new System.Drawing.Size(146, 18);
            this.tool1Drag.TabIndex = 0;
            this.tool1Drag.Text = "Allow toolWindow1 Drag";
            this.tool1Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // tool2Drag
            // 
            this.tool2Drag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tool2Drag.Location = new System.Drawing.Point(10, 29);
            this.tool2Drag.Name = "tool2Drag";
            this.tool2Drag.Size = new System.Drawing.Size(146, 18);
            this.tool2Drag.TabIndex = 1;
            this.tool2Drag.Text = "Allow toolWindow2 Drag";
            this.tool2Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // tool3Drop
            // 
            this.tool3Drop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tool3Drop.Location = new System.Drawing.Point(10, 49);
            this.tool3Drop.Name = "tool3Drop";
            this.tool3Drop.Size = new System.Drawing.Size(189, 18);
            this.tool3Drop.TabIndex = 2;
            this.tool3Drop.Text = "Allow Drop on toolWindow3 Only";
            // 
            // allowDockBottom
            // 
            this.allowDockBottom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allowDockBottom.Location = new System.Drawing.Point(10, 69);
            this.allowDockBottom.Name = "allowDockBottom";
            this.allowDockBottom.Size = new System.Drawing.Size(182, 18);
            this.allowDockBottom.TabIndex = 3;
            this.allowDockBottom.Text = "Allow DockPosition.Bottom Only";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radCheckBox1.Location = new System.Drawing.Point(10, 89);
            this.radCheckBox1.Name = "radCheckBox1";
            // 
            // 
            // 
            this.radCheckBox1.RootElement.AutoSize = false;
            this.radCheckBox1.Size = new System.Drawing.Size(144, 18);
            this.radCheckBox1.TabIndex = 4;
            this.radCheckBox1.Text = "Preview DragDrop Mode";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radDock1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1334, 754);
            this.Controls.SetChildIndex(this.radDock1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).EndInit();
            this.toolTabStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tool1Drag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool2Drag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tool3Drop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowDockBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow3;
        private Telerik.WinControls.UI.RadCheckBox tool1Drag;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip3;
        private Telerik.WinControls.UI.RadCheckBox tool3Drop;
        private Telerik.WinControls.UI.RadCheckBox tool2Drag;
        private Telerik.WinControls.UI.RadCheckBox allowDockBottom;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}
