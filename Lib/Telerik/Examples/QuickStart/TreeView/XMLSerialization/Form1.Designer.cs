namespace Telerik.Examples.WinControls.TreeView.XMLSerialization
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode8 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode9 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode10 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode11 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode12 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode13 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode14 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode15 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode16 = new Telerik.WinControls.UI.RadTreeNode();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.btnAddRoot = new Telerik.WinControls.UI.RadButton();
            this.btnAddChild = new Telerik.WinControls.UI.RadButton();
            this.btnLoadFile = new Telerik.WinControls.UI.RadButton();
            this.btnSaveFile = new Telerik.WinControls.UI.RadButton();
            this.btnRemove = new Telerik.WinControls.UI.RadButton();
            this.radGroupNodeOpts = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupXml = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNodeOpts)).BeginInit();
            this.radGroupNodeOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupXml)).BeginInit();
            this.radGroupXml.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupXml);
            this.settingsPanel.Controls.Add(this.radGroupNodeOpts);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Size = new System.Drawing.Size(200, 735);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupNodeOpts, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupXml, 0);
            // 
            // radTreeView1
            // 
            this.radTreeView1.AllowDragDrop = true;
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            radTreeNode1.Expanded = true;
            radTreeNode2.Expanded = true;
            radTreeNode3.Text = "Node15";
            radTreeNode4.Text = "Node16";
            radTreeNode2.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode3,
            radTreeNode4});
            radTreeNode2.Text = "Node7";
            radTreeNode5.Expanded = true;
            radTreeNode6.Text = "Node14";
            radTreeNode5.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode6});
            radTreeNode5.Text = "Node8";
            radTreeNode7.Text = "Node9";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode5,
            radTreeNode7});
            radTreeNode1.Text = "Node1";
            radTreeNode8.Expanded = true;
            radTreeNode9.Text = "Node10";
            radTreeNode10.Text = "Node11";
            radTreeNode8.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode9,
            radTreeNode10});
            radTreeNode8.Text = "Node2";
            radTreeNode11.Text = "Node3";
            radTreeNode12.Expanded = true;
            radTreeNode13.Text = "Node12";
            radTreeNode14.Text = "Node13";
            radTreeNode12.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode13,
            radTreeNode14});
            radTreeNode12.Text = "Node4";
            radTreeNode15.Text = "Node5";
            radTreeNode16.Text = "Node6";
            this.radTreeView1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode8,
            radTreeNode11,
            radTreeNode12,
            radTreeNode15,
            radTreeNode16});
            this.radTreeView1.Size = new System.Drawing.Size(290, 752);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 0;
            this.radTreeView1.Text = "radTreeView1";
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoot.Location = new System.Drawing.Point(14, 31);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(153, 23);
            this.btnAddRoot.TabIndex = 1;
            this.btnAddRoot.Text = "Add Root Node";
           
            // 
            // btnAddChild
            // 
            this.btnAddChild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddChild.Location = new System.Drawing.Point(14, 60);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(153, 23);
            this.btnAddChild.TabIndex = 2;
            this.btnAddChild.Text = "Add Child Node";

            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFile.Location = new System.Drawing.Point(14, 28);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(153, 23);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "Load XML File";
   
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFile.Location = new System.Drawing.Point(14, 57);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(153, 23);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save XML File";

            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(14, 89);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(153, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Selected Node";

            // 
            // radGroupNodeOpts
            // 
            this.radGroupNodeOpts.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupNodeOpts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupNodeOpts.Controls.Add(this.btnAddRoot);
            this.radGroupNodeOpts.Controls.Add(this.btnRemove);
            this.radGroupNodeOpts.Controls.Add(this.btnAddChild);
            this.radGroupNodeOpts.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupNodeOpts.HeaderText = "Node Actions";
            this.radGroupNodeOpts.Location = new System.Drawing.Point(10, 6);
            this.radGroupNodeOpts.Name = "radGroupNodeOpts";
            this.radGroupNodeOpts.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupNodeOpts.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupNodeOpts.Size = new System.Drawing.Size(180, 125);
            this.radGroupNodeOpts.TabIndex = 0;
            this.radGroupNodeOpts.Text = "Node Actions";
            // 
            // radGroupXml
            // 
            this.radGroupXml.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupXml.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupXml.Controls.Add(this.btnLoadFile);
            this.radGroupXml.Controls.Add(this.btnSaveFile);
            this.radGroupXml.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupXml.HeaderText = "XML Actions";
            this.radGroupXml.Location = new System.Drawing.Point(10, 151);
            this.radGroupXml.Name = "radGroupXml";
            this.radGroupXml.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupXml.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupXml.Size = new System.Drawing.Size(180, 95);
            this.radGroupXml.TabIndex = 1;
            this.radGroupXml.Text = "XML Actions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radTreeView1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1028, 762);
            this.Controls.SetChildIndex(this.radTreeView1, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupNodeOpts)).EndInit();
            this.radGroupNodeOpts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupXml)).EndInit();
            this.radGroupXml.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.UI.RadTreeView radTreeView1;
		private Telerik.WinControls.UI.RadButton btnAddRoot;
		private Telerik.WinControls.UI.RadButton btnAddChild;
		private Telerik.WinControls.UI.RadButton btnLoadFile;
		private Telerik.WinControls.UI.RadButton btnSaveFile;
		private Telerik.WinControls.UI.RadButton btnRemove;
        private Telerik.WinControls.UI.RadGroupBox radGroupXml;
        private Telerik.WinControls.UI.RadGroupBox radGroupNodeOpts;
	}
}