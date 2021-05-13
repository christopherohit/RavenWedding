namespace Telerik.Examples.WinControls.TreeView.Customize.ContextMenus
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
            this.radContextMenu1 = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radTreeViewDemo = new Telerik.WinControls.UI.RadTreeView();
            this.radGroupInfoPane = new Telerik.WinControls.UI.RadGroupBox();
            this.radLblSelectedItem = new Telerik.WinControls.UI.RadLabel();
            this.radLblItem = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLblSelectedNode = new Telerik.WinControls.UI.RadLabel();
            this.radLblNode = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupInfoPane)).BeginInit();
            this.radGroupInfoPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSelectedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSelectedNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblNode)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupInfoPane);
            this.settingsPanel.Location = new System.Drawing.Point(1023, 1);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupInfoPane, 0);
            // 
            // radContextMenu1
            // 
            this.radContextMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem4,
            this.radMenuItem5});
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Edit";
            this.radMenuItem1.AccessibleName = "Edit";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Edit";
            this.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "Disable";
            this.radMenuItem2.AccessibleName = "Disable";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Disable";
            this.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "Delete Node";
            this.radMenuItem4.AccessibleName = "Delete Node";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Delete Node";
            this.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "New Folder";
            this.radMenuItem5.AccessibleName = "New Folder";
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "New Folder";
            this.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "Copy node(Clone)";
            this.radMenuItem3.AccessibleName = "Copy node(Clone)";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Copy node(Clone)";
            this.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radMenuItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageList1.Images.SetKeyName(0, "0_Personal_Folders.gif");
            this.imageList1.Images.SetKeyName(1, "1_Deleted_Items.gif");
            this.imageList1.Images.SetKeyName(2, "2_Drafts.gif");
            this.imageList1.Images.SetKeyName(3, "3_Inbox.gif");
            this.imageList1.Images.SetKeyName(4, "4_Junk_E-mail.gif");
            this.imageList1.Images.SetKeyName(5, "5_Outbox.gif");
            this.imageList1.Images.SetKeyName(6, "6_Rss_Feeds.gif");
            this.imageList1.Images.SetKeyName(7, "7_Sent_Items.gif");
            this.imageList1.Images.SetKeyName(8, "8.1_Search.gif");
            this.imageList1.Images.SetKeyName(9, "8_Search.gif");
            // 
            // radTreeViewDemo
            // 
            this.radTreeViewDemo.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeViewDemo.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTreeViewDemo.ImageList = this.imageList1;
            this.radTreeViewDemo.ItemHeight = 27;
            this.radTreeViewDemo.Location = new System.Drawing.Point(0, 0);
            this.radTreeViewDemo.Name = "radTreeViewDemo";
            radTreeNode1.ContextMenu = this.radContextMenu1;
            radTreeNode1.Expanded = true;
            radTreeNode1.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode1.Image")));
            radTreeNode1.ImageIndex = 0;
            radTreeNode2.ContextMenu = this.radContextMenu1;
            radTreeNode2.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode2.Image")));
            radTreeNode2.ImageIndex = 1;
            radTreeNode2.Text = "Deleted Items(6)";
            radTreeNode3.ContextMenu = this.radContextMenu1;
            radTreeNode3.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode3.Image")));
            radTreeNode3.ImageKey = "2_Drafts.gif";
            radTreeNode3.Text = "Drafts";
            radTreeNode4.ContextMenu = this.radContextMenu1;
            radTreeNode4.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode4.Image")));
            radTreeNode4.ImageIndex = 3;
            radTreeNode4.Text = "Invoices";
            radTreeNode5.ContextMenu = this.radContextMenu1;
            radTreeNode5.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode5.Image")));
            radTreeNode5.ImageKey = "5_Outbox.gif";
            radTreeNode5.Text = "Junk e-mail";
            radTreeNode6.ContextMenu = this.radContextMenu1;
            radTreeNode6.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode6.Image")));
            radTreeNode6.ImageIndex = 5;
            radTreeNode6.Text = "OutBox";
            radTreeNode7.ContextMenu = this.radContextMenu1;
            radTreeNode7.Expanded = true;
            radTreeNode7.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode7.Image")));
            radTreeNode7.ImageKey = "7_Sent_Items.gif";
            radTreeNode7.Text = "Sent Items";
            radTreeNode8.ContextMenu = this.radContextMenu1;
            radTreeNode8.Expanded = true;
            radTreeNode8.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode8.Image")));
            radTreeNode8.ImageKey = "8_Search.gif";
            radTreeNode9.ContextMenu = this.radContextMenu1;
            radTreeNode9.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode9.Image")));
            radTreeNode9.ImageKey = "8.1_Search.gif";
            radTreeNode9.Text = "Form Follow Up";
            radTreeNode10.ContextMenu = this.radContextMenu1;
            radTreeNode10.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode10.Image")));
            radTreeNode10.ImageKey = "8.1_Search.gif";
            radTreeNode10.Text = "Large Mail";
            radTreeNode11.ContextMenu = this.radContextMenu1;
            radTreeNode11.Image = ((System.Drawing.Image)(resources.GetObject("radTreeNode11.Image")));
            radTreeNode11.ImageKey = "8.1_Search.gif";
            radTreeNode11.Text = "Unread Mail";
            radTreeNode8.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode9,
            radTreeNode10,
            radTreeNode11});
            radTreeNode8.Text = "Search Folders";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3,
            radTreeNode4,
            radTreeNode5,
            radTreeNode6,
            radTreeNode7,
            radTreeNode8});
            radTreeNode1.Text = "Personal Folders";
            this.radTreeViewDemo.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1});
            this.radTreeViewDemo.Size = new System.Drawing.Size(246, 506);
            this.radTreeViewDemo.SpacingBetweenNodes = -1;
            this.radTreeViewDemo.TabIndex = 0;
            this.radTreeViewDemo.Text = "radTreeView1";
            // 
            // radGroupInfoPane
            // 
            this.radGroupInfoPane.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupInfoPane.Controls.Add(this.radLblSelectedItem);
            this.radGroupInfoPane.Controls.Add(this.radLblItem);
            this.radGroupInfoPane.Controls.Add(this.radLabel2);
            this.radGroupInfoPane.Controls.Add(this.radLblSelectedNode);
            this.radGroupInfoPane.Controls.Add(this.radLblNode);
            this.radGroupInfoPane.HeaderMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radGroupInfoPane.HeaderText = " Info Pane ";
            this.radGroupInfoPane.Location = new System.Drawing.Point(15, 6);
            this.radGroupInfoPane.Name = "radGroupInfoPane";
            // 
            // 
            // 
            this.radGroupInfoPane.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupInfoPane.Size = new System.Drawing.Size(162, 100);
            this.radGroupInfoPane.TabIndex = 0;
            this.radGroupInfoPane.Text = " Info Pane ";
            // 
            // radLblSelectedItem
            // 
            this.radLblSelectedItem.ForeColor = System.Drawing.Color.Red;
            this.radLblSelectedItem.Location = new System.Drawing.Point(4, 74);
            this.radLblSelectedItem.Name = "radLblSelectedItem";
            this.radLblSelectedItem.Size = new System.Drawing.Size(55, 18);
            this.radLblSelectedItem.TabIndex = 1;
            this.radLblSelectedItem.Text = "radLabel2";
            // 
            // radLblItem
            // 
            this.radLblItem.Location = new System.Drawing.Point(4, 56);
            this.radLblItem.Name = "radLblItem";
            this.radLblItem.Size = new System.Drawing.Size(119, 18);
            this.radLblItem.TabIndex = 1;
            this.radLblItem.Text = "Context Item Selected:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 58);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "radLabel2";
            // 
            // radLblSelectedNode
            // 
            this.radLblSelectedNode.ForeColor = System.Drawing.Color.Red;
            this.radLblSelectedNode.Location = new System.Drawing.Point(4, 36);
            this.radLblSelectedNode.Name = "radLblSelectedNode";
            this.radLblSelectedNode.Size = new System.Drawing.Size(55, 18);
            this.radLblSelectedNode.TabIndex = 0;
            this.radLblSelectedNode.Text = "radLabel1";
            // 
            // radLblNode
            // 
            this.radLblNode.Location = new System.Drawing.Point(4, 20);
            this.radLblNode.Name = "radLblNode";
            this.radLblNode.Size = new System.Drawing.Size(82, 18);
            this.radLblNode.TabIndex = 0;
            this.radLblNode.Text = "Node Selected:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radTreeViewDemo);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1288, 516);
            this.Controls.SetChildIndex(this.radTreeViewDemo, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeViewDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupInfoPane)).EndInit();
            this.radGroupInfoPane.ResumeLayout(false);
            this.radGroupInfoPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSelectedItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblSelectedNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLblNode)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.ImageList imageList1;
		private Telerik.WinControls.UI.RadContextMenu radContextMenu1;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
		private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadTreeView radTreeViewDemo;
        private Telerik.WinControls.UI.RadGroupBox radGroupInfoPane;
        private Telerik.WinControls.UI.RadLabel radLblSelectedItem;
        private Telerik.WinControls.UI.RadLabel radLblItem;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLblSelectedNode;
        private Telerik.WinControls.UI.RadLabel radLblNode;
	}
}