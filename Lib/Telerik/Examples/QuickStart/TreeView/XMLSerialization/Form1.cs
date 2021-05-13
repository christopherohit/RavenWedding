using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.XMLSerialization
{
    /// <summary>
    /// Form code
    /// </summary>
    public partial class Form1 : TreeExamplesControl
    {
        Bitmap bottomRightBitmap = Resources.TV_folders;

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radTreeView1;
            this.UpdateButtonStates();

            this.radTreeView1.AllowDefaultContextMenu = true;
            this.radTreeView1.SelectedNodeChanged += this.radTreeView1_Selected;
            this.radTreeView1.NodeFormatting += new TreeNodeFormattingEventHandler(radTreeView1_NodeFormatting);
        }

        protected override void WireEvents()
        {
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
        }

        public override RadTreeView TreeControl
        {
            get { return this.radTreeView1; }
        }

        public override Bitmap BottomRightImage
        {
            get { return bottomRightBitmap; }
        }

        public override string HeaderText
        {
            get { return "Serialization"; }
        }

        private void UpdateButtonStates()
        {
            RadTreeNode selectedNode = this.radTreeView1.SelectedNode;
            bool enabled = selectedNode != null;

            this.btnAddChild.Enabled = enabled;
            this.btnRemove.Enabled = enabled;
        }

        private void AddNode(RadTreeNodeCollection nodes)
        {
            RadTreeNode newNode = new RadTreeNode();
            newNode.Text = "RadTreeNode";
            nodes.Add(newNode);
            this.radTreeView1.SelectedNode = newNode;
        }

        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radTreeView1.AllowAdd = true;
            this.radTreeView1.AllowRemove = true;
        }

        private void radTreeView1_Selected(object sender, RadTreeViewEventArgs e)
        {
            this.UpdateButtonStates();
        }

        private void radTreeView1_NodeFormatting(object sender, TreeNodeFormattingEventArgs e)
        {
            e.NodeElement.ImageElement.Image = Resources.TV_Folder;
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            this.AddNode(this.radTreeView1.Nodes);
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            RadTreeNode selectedNode = this.radTreeView1.SelectedNode;
            if (selectedNode != null)
            {
                this.AddNode(selectedNode.Nodes);
                selectedNode.Expanded = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RadTreeNode selectedNode = this.radTreeView1.SelectedNode;
            if (selectedNode != null)
            {
                selectedNode.Remove();
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.AddExtension = true;
            openFileDialog.DefaultExt = ".xml";
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radTreeView1.LoadXML(openFileDialog.FileName);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".xml";
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radTreeView1.SaveXML(saveFileDialog.FileName);
            }
        }

        #endregion
    }
}