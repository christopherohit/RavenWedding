using System;
using System.Drawing;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Selection
{
    /// <summary>
    /// Form code
    /// </summary>
	public partial class Form1 : TreeExamplesControl
	{
        Bitmap bottomRightBitmap = Resources.TV_email;
        
        public Form1()
		{
			InitializeComponent();
			this.SelectedControl = this.radTreeView1;
		}

        protected override void WireEvents()
        {
            this.radCheckBoxAllowMultiSelect.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAllowMultiSelect_ToggleStateChanged);
            this.radButtonSelectAll.Click += new System.EventHandler(this.radButtonSelectAll_Click);
            this.radButtonClearSelection.Click += new System.EventHandler(this.radButtonClearSelection_Click);
            this.radButtonToggleSelection.Click += new System.EventHandler(this.radButtonToggleSelection_Click);
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
            get { return "Mail"; }
        }

        private void LoadData()
        {
            this.radTreeView1.Nodes.Add(new RadTreeNode("Personal Folders", Resources.TV_RootFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Deleted Items", Resources.TV_RecycleBin));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Drafts", Resources.TV_DraftFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Inbox", Resources.TV_InboxFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Junk E-mails", Resources.TV_JunkFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Outbox", Resources.TV_OutboxFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Sent Items", Resources.TV_SentFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Search Folder", Resources.TV_SearchFolder));

            this.radTreeView1.Nodes[0].Nodes[2].Nodes.Add(new RadTreeNode("Folders", Resources.TV_Folder));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("From Follow up", Resources.TV_SearchFolder));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Large Mail", Resources.TV_SearchFolder));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Unread Mail", Resources.TV_SearchFolder));
        }        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
            this.radTreeView1.ExpandAll();
            this.radTreeView1.MultiSelect = true;
            this.radTreeView1.AllowEdit = false;
            this.radTreeView1.KeyboardSearchEnabled = true;
        }

        private void radCheckBoxAllowMultiSelect_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.MultiSelect = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radButtonSelectAll_Click(object sender, EventArgs e)
        {
            this.radTreeView1.SelectAll();
        }

        private void radButtonClearSelection_Click(object sender, EventArgs e)
        {
            this.radTreeView1.ClearSelection();
        }

        private void radButtonToggleSelection_Click(object sender, EventArgs e)
        {
            if (this.radTreeView1.SelectedNode != null)
            {
                this.radTreeView1.SelectedNode.Selected = !this.radTreeView1.SelectedNode.Selected;
            }
        }

        private void radCheckBoxAllowKeyboardSelection_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.KeyboardSearchEnabled = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }
	}
}