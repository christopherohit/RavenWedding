using System;
using System.ComponentModel;
using System.Drawing;
using Telerik.Examples.WinControls.Properties;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;


namespace Telerik.Examples.WinControls.TreeView.Events
{
    /// <summary>
    /// Form code
    /// </summary>
    public partial class Form1 : TreeExamplesControl
    {
        Bitmap bottomRightBitmap = Resources.TV_email; 
        int insertIndex = 0;
        bool loading = true;

        public Form1()
        {
            InitializeComponent();

            this.radTreeView1.SelectedNodeChanged += radTreeView1_Selected;
            this.radTreeView1.SelectedNodeChanging += new Telerik.WinControls.UI.RadTreeView.RadTreeViewCancelEventHandler(radTreeView1_Selecting);
            this.radTreeView1.EditorRequired += new Telerik.WinControls.UI.RadTreeView.EditorRequiredHandler(radTreeView1_EditorRequired);
            this.radTreeView1.Editing += new TreeNodeEditingEventHandler(radTreeView1_Editing);
            this.radTreeView1.Edited += new TreeNodeEditedEventHandler(radTreeView1_Edited);
            this.radTreeView1.ValueChanging += new TreeNodeValueChangingEventHandler(radTreeView1_ValueChanging);
            this.radTreeView1.ValueChanged += new TreeNodeValueChangedEventHandler(radTreeView1_ValueChanged);
            this.radTreeView1.NodeExpandedChanging += new Telerik.WinControls.UI.RadTreeView.RadTreeViewCancelEventHandler(radTreeView1_NodeExpandedChanging);
            this.radTreeView1.NodeExpandedChanged += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(radTreeView1_NodeExpandedChanged);

            this.SelectedControl = this.radTreeView1;
        }

        protected override void WireEvents()
        {
            this.clearEventsBtn.Click += new System.EventHandler(this.clearEventsBtn_Click);
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

        private void AddEventRoot(string text)
        {
            RadListDataItem item = new RadListDataItem();
            item.Text = text;
            this.AddEventRoot(item);
        }

        private void AddEventRoot(RadListDataItem item)
        {
            if (!loading)
            {
                item.Text = "<html><b>" + item.Text;
                radListBox1.Items.Insert(insertIndex++, item);
                radListBox1.SelectedIndex = insertIndex - 1;
                radListBox1.ListElement.ScrollToItem(item);
            }
        }

        private void AddTextToListBox(RadListDataItem item)
        {
            if (!loading)
            {
                if (radListBox1.Items.Count > 100)
                {
                    radListBox1.Items.Clear();
                    insertIndex = 0;
                }
                radListBox1.Items.Insert(insertIndex, item);
                insertIndex++;
                radListBox1.SelectedIndex = insertIndex - 1;
                radListBox1.ListElement.ScrollToItem(item);
            }
        }

        private void AddTextToListBox(string text)
        {
            if (!loading)
            {
                RadListDataItem label = new RadListDataItem();
                label.Text = text;
                AddTextToListBox(label);
            }
        }

        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadData();

            this.radTreeView1.AllowAdd = true;
            this.radTreeView1.AllowRemove = true;
            this.radTreeView1.ExpandAll();

            loading = false;
        }

        void radTreeView1_Selecting(object sender, RadTreeViewCancelEventArgs e)
        {
            AddEventRoot("Selecting");
        }

        void radTreeView1_Selected(object sender, RadTreeViewEventArgs e)
        {
            AddEventRoot("Selected");
        }

        void radTreeView1_NodeExpandedChanged(object sender, RadTreeViewEventArgs e)
        {
            AddEventRoot("NodeExpandedChanged");
        }

        void radTreeView1_NodeExpandedChanging(object sender, RadTreeViewCancelEventArgs e)
        {
            AddEventRoot("NodeExpandedChanging");
        }

        void radTreeView1_ValueChanged(object sender, TreeNodeValueChangedEventArgs e)
        {
            AddEventRoot("ValueChanged");
        }

        void radTreeView1_ValueChanging(object sender, TreeNodeValueChangingEventArgs e)
        {
            AddEventRoot("ValueChanging");
        }

        void radTreeView1_Edited(object sender, TreeNodeEditedEventArgs e)
        {
            AddEventRoot("Edited");
            AddTextToListBox(string.Format("    Node: {0}", e.Node.Text));
        }

        void radTreeView1_Editing(object sender, TreeNodeEditingEventArgs e)
        {
            AddEventRoot("Editing");
            AddTextToListBox(string.Format("    Node: {0}", e.Node.Text));
        }

        void radTreeView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            AddEventRoot("EditorRequired");
            AddTextToListBox(string.Format("    Editor type: {0}", e.EditorType.ToString()));
        }

        void clearEventsBtn_Click(object sender, EventArgs e)
        {
            insertIndex = 0;
            this.radListBox1.Items.Clear();
        }

        #endregion
    }
}


