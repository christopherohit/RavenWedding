using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Customize.Basics
{
    public partial class Form1 : TreeExamplesControl
    {
        Bitmap bottomRightBitmap = Resources.TV_email;

        public Form1()
        {
            InitializeComponent();
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

            this.radTreeView1.Nodes[0].Nodes[2].Nodes[0].ItemHeight = 50;
        }

        protected override void WireEvents()
        {
            this.radCheckBoxShowLines.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowLines_ToggleStateChanged);
            this.radCheckBoxAlternatingRowColor.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAlternatingRowColor_ToggleStateChanged);
            this.radButtonAlternatingRowColor.Click += new System.EventHandler(this.radButtonAlternatingRowColor_Click);
            this.radSpinEditorItemHeight.ValueChanged += new System.EventHandler(this.radSpinEditorItemHeight_ValueChanged);
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
            this.radCheckBoxShowRootLines.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxShowRootLines_ToggleStateChanged);
            this.radCheckBoxExpandCollapse.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxExpandCollapse_ToggleStateChanged);
            this.radCheckBoxFullRowSelect.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxFullRowSelect_ToggleStateChanged);
            this.radButtonLineColor.Click += new System.EventHandler(this.radButtonLineColor_Click);
            this.radCheckBoxAutoSizeItems.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAutoSizeItems_ToggleStateChanged);
            this.radCheckBoxAnimations.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxAnimations_ToggleStateChanged);
            this.radSpinEditorItemSpacing.ValueChanged += new System.EventHandler(this.radSpinEditorItemSpacing_ValueChanged);
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radTreeView1.ItemHeight = 27;

            this.radCheckBoxShowLines.IsChecked = this.radTreeView1.ShowLines;
            this.radCheckBoxShowRootLines.IsChecked = this.radTreeView1.ShowRootLines;
            this.radCheckBoxExpandCollapse.IsChecked = this.radTreeView1.ShowExpandCollapse;
            this.radCheckBoxFullRowSelect.IsChecked = this.radTreeView1.FullRowSelect;
            this.radCheckBoxAlternatingRowColor.IsChecked = this.radTreeView1.TreeViewElement.AllowAlternatingRowColor;
            this.radCheckBoxAutoSizeItems.IsChecked = this.radTreeView1.TreeViewElement.AutoSizeItems;
            this.radSpinEditorItemHeight.Value = this.radTreeView1.ItemHeight;
            this.radSpinEditorItemSpacing.Value = this.radTreeView1.SpacingBetweenNodes;

            this.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid;
            this.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor = this.radTreeView1.TreeViewElement.AlternatingRowColor;

            this.radButtonLineColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid;
            this.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor = this.radTreeView1.LineColor;
            this.radButtonLineColor.Enabled = false;
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.AllowDefaultContextMenu = true;

            LoadData();

            this.radTreeView1.ExpandAll();
            this.radTreeView1.Nodes[0].Nodes[1].Current = true;
            this.radTreeView1.Nodes[0].Nodes[1].Selected = true;
            this.radTreeView1.AllowAdd = true;
            this.radTreeView1.AllowRemove = true;

            this.radDropDownList1.SelectedIndex = 2;
            this.radDropDownList1.Enabled = false;

            this.radTreeView1.ExpandAnimation = ExpandAnimation.None;
            this.radTreeView1.AllowPlusMinusAnimation = false;
            this.radTreeView1.PlusMinusAnimationStep = 1;
        }

        private void radButtonAlternatingRowColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();
            ((RadForm)dialog.ColorDialogForm).ThemeName = CurrentThemeName;
            dialog.SelectedColor = this.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radButtonAlternatingRowColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor;
                this.radTreeView1.TreeViewElement.AlternatingRowColor = dialog.SelectedColor;
            }
        }

        private void radButtonLineColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();
            ((RadForm)dialog.ColorDialogForm).ThemeName = CurrentThemeName;
            dialog.SelectedColor = this.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radButtonLineColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor;
                this.radTreeView1.LineColor = dialog.SelectedColor;
            }
        }

        private void radSpinEditorItemHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radTreeView1.ItemHeight = (int)radSpinEditorItemHeight.Value;
        }

        private void radSpinEditorItemSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radTreeView1.SpacingBetweenNodes = (int)radSpinEditorItemSpacing.Value;
        }

        private void radCheckBoxAutoSizeItems_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.TreeViewElement.AutoSizeItems = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
            this.radSpinEditorItemHeight.Enabled = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off;
            if (this.radSpinEditorItemHeight.Enabled)
            {
                this.radTreeView1.Nodes[0].Nodes[2].Nodes[0].ItemHeight = 50;
            }
        }

        private void radCheckBoxAlternatingRowColor_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.TreeViewElement.AllowAlternatingRowColor = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
            this.radButtonAlternatingRowColor.Enabled = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBoxFullRowSelect_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.FullRowSelect = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBoxExpandCollapse_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.ShowExpandCollapse = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBoxShowRootLines_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.ShowRootLines = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radCheckBoxShowLines_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.ShowLines = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
            this.radButtonLineColor.Enabled = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
            this.radDropDownList1.Enabled = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radTreeView1.LineStyle = (TreeLineStyle)e.Position;
        }

        private void radCheckBoxAnimations_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radTreeView1.ExpandAnimation = ExpandAnimation.Opacity;
                this.radTreeView1.AllowPlusMinusAnimation = true;
            }
            else
            {
                this.radTreeView1.ExpandAnimation = ExpandAnimation.None;
                this.radTreeView1.AllowPlusMinusAnimation = false;
            }
        }
    }
}
