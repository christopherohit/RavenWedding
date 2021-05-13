using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Customize.ContextMenus
{
    /// <summary>
    /// Form code
    /// </summary>
	public partial class Form1 : TreeExamplesControl
	{
        private Bitmap bottomRightBitmap = Resources.TV_email;
        private RadTreeNode clickedNode;
        
        public Form1()
		{
			InitializeComponent();
			this.radLblSelectedNode.Text = "";
            this.radLblSelectedItem.Text = "";

			this.SelectedControl = this.radTreeViewDemo;            
            this.radTreeViewDemo.AllowEdit = true;

            this.radContextMenu1.DropDownOpening += new System.ComponentModel.CancelEventHandler(radContextMenu1_DropDownOpening);
            this.radTreeViewDemo.SelectedNodeChanged += radTreeViewDemo_SelectedNodeChanged;
		}

        private void radTreeViewDemo_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            this.radLblSelectedNode.Text = e.Node.Text;
        }

        public override RadTreeView TreeControl
        {
            get { return this.radTreeViewDemo; }
        }

        public override Bitmap BottomRightImage
        {
            get { return bottomRightBitmap; }
        }

        public override string HeaderText
        {
            get { return "Mail"; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radMenuItem1.Click += new EventHandler(radMenuItem1_Click);
            this.radMenuItem2.Click += new EventHandler(radMenuItem2_Click);
            this.radMenuItem4.Click += new EventHandler(radMenuItem4_Click);
            this.radMenuItem5.Click += new EventHandler(radMenuItem5_Click);
        }

        private void SetLabel(object sender)
        {
            RadMenuItem item = sender as RadMenuItem;

            if (item != null)
            {
                radLblSelectedItem.Text = item.Text;
            }
        }

        private void radContextMenu1_DropDownOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Point mousePosition = this.radTreeViewDemo.PointToClient(Control.MousePosition);
            TreeNodeElement nodeElement = this.radTreeViewDemo.ElementTree.GetElementAtPoint(mousePosition) as TreeNodeElement;

            if (nodeElement == null)
            {
                return;
            }

            RadTreeNode node = nodeElement.Data;

            if (node == null)
            {
                return;
            }

            this.clickedNode = node;

            this.radMenuItem1.Enabled = this.clickedNode.Enabled;
            this.radMenuItem4.Enabled = this.clickedNode.Enabled;
            this.radMenuItem5.Enabled = this.clickedNode.Enabled;

            this.radMenuItem2.Text = (this.clickedNode.Enabled) ? "Disable" : "Enable";
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            SetLabel(sender);

            if (this.radTreeViewDemo.SelectedNode != null)
            {
                this.radTreeViewDemo.BeginEdit();
            }
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            SetLabel(sender);

            if (this.clickedNode == null)
            {
                return;
            }

            this.clickedNode.Enabled = !this.clickedNode.Enabled;
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            SetLabel(sender);

            if (this.radTreeViewDemo.SelectedNode != null)
            {
                this.radTreeViewDemo.SelectedNode.Remove();
            }
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            SetLabel(sender);

            if (this.radTreeViewDemo.SelectedNode != null)
            {
                this.radTreeViewDemo.SelectedNode.Expand();
                RadTreeNode newNode = this.radTreeViewDemo.SelectedNode.Nodes.Add("New Folder");

                if (newNode != null)
                {
                    this.radTreeViewDemo.SelectedNode = newNode;
                    this.radTreeViewDemo.BeginEdit();
                }
            }
        }
    }
}
