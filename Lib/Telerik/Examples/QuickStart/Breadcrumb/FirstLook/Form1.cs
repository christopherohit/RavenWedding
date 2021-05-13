using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.Examples.WinControls.Properties;
using Telerik.Examples.WinControls.TreeView;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Breadcrumb.FirstLook
{
    /// <summary>
    /// Form code
    /// </summary>
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radTreeView1.LazyMode = false;
            this.radTreeView1.ExpandAll();
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            this.radBreadCrumb1.UpdateBreadCrumb(this.radTreeView1.SelectedNode);
        }

        protected override void WireEvents()
        {
            this.radTreeView1.NodesNeeded += new Telerik.WinControls.UI.NodesNeededEventHandler(this.radTreeView1_NodesNeeded);
        }

        private void radTreeView1_NodesNeeded(object sender, NodesNeededEventArgs args)
        {
            if (args.Parent == null)
            {
                this.LoadRoot(args.Nodes);
                return;
            }

            if (args.Parent.Text == "Favorites")
            {
                this.LoadFavorites(args.Nodes);
                args.Parent.Expand();
            }
            else if (args.Parent.Text == "Libraries")
            {
                this.LoadLibraries(args.Nodes);
                args.Parent.Expand();
                this.radTreeView1.SelectedNode = args.Parent.Nodes["Pictures"];
            }
            else if (args.Parent.Text == "Computer")
            {
                this.LoadComputer(args.Nodes);
                args.Parent.Expand();
            }
            else if (args.Parent.Text == "Network")
            {
                this.LoadNetwork(args.Nodes);
                args.Parent.Expand();
            }
            else if (args.Parent.Text == "System")
            {
                this.LoadSystem(args.Nodes);
                args.Parent.Expand();
            }
        }

        private void LoadRoot(IList<RadTreeNode> nodes)
        {
            RadTreeNode node = new RadTreeNode("Favorites");
            node.ImageKey = "favorites";
            nodes.Add(node);

            node = new RadTreeNode("Libraries");
            node.ImageKey = "libraries";
            nodes.Add(node);

            node = new RadTreeNode("Computer");
            node.ImageKey = "computer";
            nodes.Add(node);

            node = new RadTreeNode("Network");
            node.ImageKey = "network";
            nodes.Add(node);
        }

        private void LoadFavorites(IList<RadTreeNode> nodes)
        {
            RadTreeNode node = new RadTreeNode("Work");
            node.ImageKey = "work";
            nodes.Add(node);

            node = new RadTreeNode("Downloads");
            node.ImageKey = "downloads";
            nodes.Add(node);

            node = new RadTreeNode("Desktop");
            node.ImageKey = "desktop";
            nodes.Add(node);

            node = new RadTreeNode("Virtual Machines");
            node.ImageKey = "virtual machines";
            nodes.Add(node);
        }

        private void LoadLibraries(IList<RadTreeNode> nodes)
        {
            RadTreeNode node = new RadTreeNode("Documents");
            node.ImageKey = "documents";
            nodes.Add(node);

            node = new RadTreeNode("Music");
            node.ImageKey = "music";
            nodes.Add(node);

            node = new RadTreeNode("Pictures");
            node.ImageKey = "pictures";
            nodes.Add(node);

            node = new RadTreeNode("Videos");
            node.ImageKey = "video";
            nodes.Add(node);
        }

        private void LoadComputer(IList<RadTreeNode> nodes)
        {
            RadTreeNode node = new RadTreeNode("System");
            node.ImageKey = "hdd";
            nodes.Add(node);

            node = new RadTreeNode("Resources");
            node.ImageKey = "network drive";
            nodes.Add(node);

            node = new RadTreeNode("Share");
            node.ImageKey = "network drive";
            nodes.Add(node);
        }

        private void LoadNetwork(IList<RadTreeNode> nodes)
        {
            RadTreeNode node = new RadTreeNode("PC1");
            node.ImageKey = "computer";
            nodes.Add(node);

            node = new RadTreeNode("PC2");
            node.ImageKey = "computer";
            nodes.Add(node);

            node = new RadTreeNode("Laptop1");
            node.ImageKey = "computer";
            nodes.Add(node);

            node = new RadTreeNode("Laptop2");
            node.ImageKey = "computer";
            nodes.Add(node);
        }

        private void LoadSystem(IList<RadTreeNode> nodes)
        {
            RadTreeNode node = new RadTreeNode("Program Files");
            node.ImageKey = "folder";
            nodes.Add(node);

            node = new RadTreeNode("Program Files (x86)");
            node.ImageKey = "folder";
            nodes.Add(node);

            node = new RadTreeNode("Users");
            node.ImageKey = "folder";
            nodes.Add(node);

            node = new RadTreeNode("Windows");
            node.ImageKey = "folder";
            nodes.Add(node);
        }

        private void AutoCompleteCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radBreadCrumb1.IsAutoCompleteEnabled = !this.radBreadCrumb1.IsAutoCompleteEnabled;
        }

        private void TextModeCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radBreadCrumb1.IsTextModeEnabled = !this.radBreadCrumb1.IsTextModeEnabled;
            this.autoCompleteCheckBox.Enabled = this.radBreadCrumb1.IsTextModeEnabled;
        }

        private void HistroyCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radBreadCrumb1.IsHistoryEnabled = !this.radBreadCrumb1.IsHistoryEnabled;
        }

        private void SelectTreeNodeCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radBreadCrumb1.SelectTreeNodeOnClick = !this.radBreadCrumb1.SelectTreeNodeOnClick;
        }
    }
}
