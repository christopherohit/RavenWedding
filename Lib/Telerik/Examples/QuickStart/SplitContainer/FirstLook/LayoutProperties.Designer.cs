namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
{
    partial class LayoutProperties
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.splitContainerLayout = new Telerik.WinControls.UI.RadPanel();
            this.radioVertical = new Telerik.WinControls.UI.RadRadioButton();
            this.radioHorizontal = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.splitPanelLayout = new Telerik.WinControls.UI.RadPanel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.checkCollapsed = new Telerik.WinControls.UI.RadCheckBox();
            this.checkFixed = new Telerik.WinControls.UI.RadCheckBox();
            this.splitterLayout = new Telerik.WinControls.UI.RadPanel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.checkSplitterFixed = new Telerik.WinControls.UI.RadCheckBox();
            this.initialPanel = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLayout)).BeginInit();
            this.splitContainerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanelLayout)).BeginInit();
            this.splitPanelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCollapsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterLayout)).BeginInit();
            this.splitterLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSplitterFixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTreeView1
            // 
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeView1.Font = new System.Drawing.Font("Tahoma", 8.6F);
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Expanded = true;
            radTreeNode2.Text = "SplitPanel1";
            radTreeNode3.Text = "SplitPanel2";
            radTreeNode4.Expanded = true;
            radTreeNode5.Expanded = true;
            radTreeNode6.Text = "SplitPanel4";
            radTreeNode7.Text = "SplitPanel5";
            radTreeNode5.Nodes.Add(radTreeNode6);
            radTreeNode5.Nodes.Add(radTreeNode7);
            radTreeNode5.Text = "RadSplitContainer2";
            radTreeNode4.Nodes.Add(radTreeNode5);
            radTreeNode4.Text = "SplitPanel3";
            radTreeNode1.Nodes.Add(radTreeNode2);
            radTreeNode1.Nodes.Add(radTreeNode3);
            radTreeNode1.Nodes.Add(radTreeNode4);
            radTreeNode1.Text = "RadSplitContainer1";
            this.radTreeView1.Nodes.Add(radTreeNode1);
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView1.Size = new System.Drawing.Size(195, 211);
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // splitContainerLayout
            // 
            this.splitContainerLayout.Controls.Add(this.radioVertical);
            this.splitContainerLayout.Controls.Add(this.radioHorizontal);
            this.splitContainerLayout.Controls.Add(this.radLabel1);
            this.splitContainerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLayout.Location = new System.Drawing.Point(195, 0);
            this.splitContainerLayout.Name = "splitContainerLayout";
            this.splitContainerLayout.Size = new System.Drawing.Size(165, 211);
            this.splitContainerLayout.TabIndex = 1;
            ((Telerik.WinControls.UI.RadPanelElement)(this.splitContainerLayout.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            // 
            // radioVertical
            // 
            this.radioVertical.Location = new System.Drawing.Point(76, 12);
            this.radioVertical.Name = "radioVertical";
            this.radioVertical.Size = new System.Drawing.Size(58, 18);
            this.radioVertical.TabIndex = 2;
            this.radioVertical.Text = "Vertical";
            // 
            // radioHorizontal
            // 
            this.radioHorizontal.Location = new System.Drawing.Point(76, 35);
            this.radioHorizontal.Name = "radioHorizontal";
            this.radioHorizontal.Size = new System.Drawing.Size(75, 18);
            this.radioHorizontal.TabIndex = 1;
            this.radioHorizontal.Text = "Horizontal";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(7, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(63, 14);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Orientation:";
            this.radLabel1.TextWrap = true;
            // 
            // splitPanelLayout
            // 
            this.splitPanelLayout.Controls.Add(this.radLabel4);
            this.splitPanelLayout.Controls.Add(this.radLabel3);
            this.splitPanelLayout.Controls.Add(this.checkCollapsed);
            this.splitPanelLayout.Controls.Add(this.checkFixed);
            this.splitPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPanelLayout.Location = new System.Drawing.Point(195, 0);
            this.splitPanelLayout.Name = "splitPanelLayout";
            this.splitPanelLayout.Size = new System.Drawing.Size(165, 211);
            this.splitPanelLayout.TabIndex = 3;
            ((Telerik.WinControls.UI.RadPanelElement)(this.splitPanelLayout.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(4, 141);
            this.radLabel4.MaximumSize = new System.Drawing.Size(160, 0);
            this.radLabel4.Name = "radLabel4";
            // 
            // 
            // 
            this.radLabel4.RootElement.MaxSize = new System.Drawing.Size(160, 0);
            this.radLabel4.Size = new System.Drawing.Size(160, 42);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "- When a SplitPanel is Collapsed, it is hidden from view";
            this.radLabel4.TextWrap = true;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(4, 78);
            this.radLabel3.MaximumSize = new System.Drawing.Size(160, 0);
            this.radLabel3.Name = "radLabel3";
            // 
            // 
            // 
            this.radLabel3.RootElement.MaxSize = new System.Drawing.Size(160, 0);
            this.radLabel3.Size = new System.Drawing.Size(160, 56);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "- When a SplitPanel is Fixed, it is not resized when the form is resized";
            this.radLabel3.TextWrap = true;
            // 
            // checkCollapsed
            // 
            this.checkCollapsed.Location = new System.Drawing.Point(11, 38);
            this.checkCollapsed.Name = "checkCollapsed";
            this.checkCollapsed.Size = new System.Drawing.Size(100, 18);
            this.checkCollapsed.TabIndex = 1;
            this.checkCollapsed.Text = "Collapsed";
            // 
            // checkFixed
            // 
            this.checkFixed.Location = new System.Drawing.Point(11, 13);
            this.checkFixed.Name = "checkFixed";
            this.checkFixed.Size = new System.Drawing.Size(100, 18);
            this.checkFixed.TabIndex = 0;
            this.checkFixed.Text = "Fixed";
            // 
            // splitterLayout
            // 
            this.splitterLayout.Controls.Add(this.radLabel2);
            this.splitterLayout.Controls.Add(this.checkSplitterFixed);
            this.splitterLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterLayout.Location = new System.Drawing.Point(195, 0);
            this.splitterLayout.Name = "splitterLayout";
            this.splitterLayout.Size = new System.Drawing.Size(165, 211);
            this.splitterLayout.TabIndex = 2;
            ((Telerik.WinControls.UI.RadPanelElement)(this.splitterLayout.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 41);
            this.radLabel2.MaximumSize = new System.Drawing.Size(160, 0);
            this.radLabel2.Name = "radLabel2";
            // 
            // 
            // 
            this.radLabel2.RootElement.MaxSize = new System.Drawing.Size(160, 0);
            this.radLabel2.Size = new System.Drawing.Size(160, 42);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "- When a Splitter is Fixed, it cannot be dragged and moved";
            this.radLabel2.TextWrap = true;
            // 
            // checkSplitterFixed
            // 
            this.checkSplitterFixed.Location = new System.Drawing.Point(11, 13);
            this.checkSplitterFixed.Name = "checkSplitterFixed";
            this.checkSplitterFixed.Size = new System.Drawing.Size(100, 18);
            this.checkSplitterFixed.TabIndex = 0;
            this.checkSplitterFixed.Text = "Fixed";
            // 
            // initialPanel
            // 
            this.initialPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialPanel.Location = new System.Drawing.Point(195, 0);
            this.initialPanel.Name = "initialPanel";
            this.initialPanel.Size = new System.Drawing.Size(165, 211);
            this.initialPanel.TabIndex = 3;
            this.initialPanel.Text = "Select an element";
            ((Telerik.WinControls.UI.RadPanelElement)(this.initialPanel.GetChildAt(0))).Text = "Select an element";
            ((Telerik.WinControls.UI.RadPanelElement)(this.initialPanel.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.initialPanel.GetChildAt(0).GetChildAt(2))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(360, 211);
            this.Controls.Add(this.initialPanel);
            this.Controls.Add(this.splitterLayout);
            this.Controls.Add(this.splitPanelLayout);
            this.Controls.Add(this.splitContainerLayout);
            this.Controls.Add(this.radTreeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LayoutProperties";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Layout Properties";
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLayout)).EndInit();
            this.splitContainerLayout.ResumeLayout(false);
            this.splitContainerLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanelLayout)).EndInit();
            this.splitPanelLayout.ResumeLayout(false);
            this.splitPanelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkCollapsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterLayout)).EndInit();
            this.splitterLayout.ResumeLayout(false);
            this.splitterLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSplitterFixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadPanel splitContainerLayout;
        private Telerik.WinControls.UI.RadPanel splitPanelLayout;
        private Telerik.WinControls.UI.RadRadioButton radioVertical;
        private Telerik.WinControls.UI.RadRadioButton radioHorizontal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel splitterLayout;
        private Telerik.WinControls.UI.RadCheckBox checkSplitterFixed;
        private Telerik.WinControls.UI.RadCheckBox checkCollapsed;
        private Telerik.WinControls.UI.RadCheckBox checkFixed;
        private Telerik.WinControls.UI.RadPanel initialPanel;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}