using System;
using System.Drawing;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Globalization.Localization
{
    /// <summary>
    /// Form code
    /// </summary>
    public partial class Form1 : TreeExamplesControl
    {
        Bitmap bottomRightBitmap = Resources.TV_email;
        TreeViewLocalizationProvider oldProvider;

        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radTreeView1;
        }

        protected override void WireEvents()
        {
            this.radRadioButtonGerman.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButtonGerman_ToggleStateChanged);           
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
            this.radTreeView1.Nodes.Add(new RadTreeNode("Persönliche Ordner", Resources.TV_RootFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Gelöschte Objekte", Resources.TV_RecycleBin));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Drafts", Resources.TV_DraftFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Posteingang", Resources.TV_InboxFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Junk-E-Mails", Resources.TV_JunkFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Postausgang", Resources.TV_OutboxFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Gesendete Objekte", Resources.TV_SentFolder));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Suchordner", Resources.TV_SearchFolder));

            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Von Follow-up", Resources.TV_SearchFolder));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Große Nachrichten", Resources.TV_SearchFolder));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Ungelesene Nachrichten", Resources.TV_SearchFolder));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
            this.radTreeView1.ExpandAll();
            this.radTreeView1.SelectedNode = this.radTreeView1.Nodes[0].Nodes[3];

            oldProvider = TreeViewLocalizationProvider.CurrentProvider;
            TreeViewLocalizationProvider.CurrentProvider = new GermanTreeViewLocalizationProvider();
            this.radTreeView1.AllowDefaultContextMenu = true;
        }

        protected override void DestroyHandle()
        {
            base.DestroyHandle();
            TreeViewLocalizationProvider.CurrentProvider = new TreeViewLocalizationProvider();
        }

        private void radRadioButtonGerman_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                TreeViewLocalizationProvider.CurrentProvider = new GermanTreeViewLocalizationProvider();
            }
            else
            {
                TreeViewLocalizationProvider.CurrentProvider = new TreeViewLocalizationProvider();
            }
        }
    }
}