using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Primitives;
using Telerik.WinControls;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
{
    public partial class LayoutProperties : ExamplesRadForm
    {
        RadTreeNode previouslySelectedNode = null;

        public LayoutProperties()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(AdvancedLayoutDesiger_FormClosing);
            this.radioHorizontal.ToggleStateChanged += new StateChangedEventHandler(radioHorizontal_ToggleStateChanged);
            this.radioVertical.ToggleStateChanged += new StateChangedEventHandler(radioVertical_ToggleStateChanged);
            this.checkSplitterFixed.ToggleStateChanged += new StateChangedEventHandler(checkSplitterFixed_ToggleStateChanged);
            this.checkFixed.ToggleStateChanged += new StateChangedEventHandler(checkFixed_ToggleStateChanged);
            this.checkCollapsed.ToggleStateChanged += new StateChangedEventHandler(checkCollapsed_ToggleStateChanged);
        }

        void checkCollapsed_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ((SplitPanel)this.radTreeView1.SelectedNode.Tag).Collapsed = this.checkCollapsed.ToggleState == ToggleState.On;

            RadTreeNode splitContNode = this.radTreeView1.SelectedNode.Parent;

            Telerik.WinControls.UI.RadSplitContainer splitContainer = (Telerik.WinControls.UI.RadSplitContainer)splitContNode.Tag;

            bool canRemoveNode = true;

            while (canRemoveNode)
            {
                if (splitContNode.Nodes[splitContNode.Nodes.Count - 1].Tag is SplitterElement)
                {
                    splitContNode.Nodes.RemoveAt(splitContNode.Nodes.Count - 1);
                }
                else
                {
                    canRemoveNode = false;
                }
            }

            for (int i = 0; i < splitContainer.Splitters.Count; i++)
            {
                RadTreeNode node = new RadTreeNode(string.Format("Splitter{0}", i + 1));
                node.Tag = splitContainer.Splitters[i];
                splitContNode.Nodes.Add(node);
            }
        }

        void checkFixed_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                ((SplitPanel)this.radTreeView1.SelectedNode.Tag).SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute;
            }
            else
            {
                ((SplitPanel)this.radTreeView1.SelectedNode.Tag).SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Auto;
            }
        }

        void checkSplitterFixed_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ((SplitterElement)this.radTreeView1.SelectedNode.Tag).Fixed = this.checkSplitterFixed.ToggleState == ToggleState.On;
        }

        void radioVertical_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                ((Telerik.WinControls.UI.RadSplitContainer)this.radTreeView1.SelectedNode.Tag).Orientation = Orientation.Vertical;
            }
        }

        void radioHorizontal_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                ((Telerik.WinControls.UI.RadSplitContainer)this.radTreeView1.SelectedNode.Tag).Orientation = Orientation.Horizontal;
            }
        }

        void AdvancedLayoutDesiger_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetDefaultColors();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radTreeView1.SelectedNodeChanged += new RadTreeView.RadTreeViewEventHandler(radTreeView1_SelectedNodeChanged);

            this.radTreeView1.TreeViewElement.DrawBorder = true;

            SetTreeNodeReferences();

        }

        private void SetTreeNodeReferences()
        {
            Telerik.Examples.WinControls.SplitContainer.FirstLook.Form1 ownerForm = (Telerik.Examples.WinControls.SplitContainer.FirstLook.Form1)this.Owner;

            this.radTreeView1.Nodes[0].Tag = ownerForm.RadSplitContainer1;
            this.radTreeView1.Nodes[0].Nodes[0].Tag = ownerForm.SplitPanel1;
            this.radTreeView1.Nodes[0].Nodes[1].Tag = ownerForm.SplitPanel2;
            this.radTreeView1.Nodes[0].Nodes[2].Tag = ownerForm.SplitPanel3;

            for (int i = 0; i < ownerForm.RadSplitContainer1.Splitters.Count; i++)
            {
                RadTreeNode node = new RadTreeNode(string.Format("Splitter{0}", i + 1));
                node.Tag = ownerForm.RadSplitContainer1.Splitters[i];
                this.radTreeView1.Nodes[0].Nodes.Add(node);
            }

            this.radTreeView1.Nodes[0].Nodes[2].Nodes[0].Tag = ownerForm.RadSplitContainer2;
            this.radTreeView1.Nodes[0].Nodes[2].Nodes[0].Nodes[0].Tag = ownerForm.SplitPanel4;
            this.radTreeView1.Nodes[0].Nodes[2].Nodes[0].Nodes[1].Tag = ownerForm.SplitPanel5;

            for (int i = 0; i < ownerForm.RadSplitContainer2.Splitters.Count; i++)
            {
                RadTreeNode node = new RadTreeNode(string.Format("Splitter{0}", i + 1));
                node.Tag = ownerForm.RadSplitContainer2.Splitters[i];
                this.radTreeView1.Nodes[0].Nodes[2].Nodes[0].Nodes.Add(node);
            }
        }

        void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            string type = e.Node.Tag.ToString();
            switch (type)
            {
                case "Telerik.WinControls.UI.RadSplitContainer":
                    LoadSplitContainerProperties((Telerik.WinControls.UI.RadSplitContainer)e.Node.Tag);
                    splitContainerLayout.BringToFront();
                    break;
                case "Telerik.WinControls.UI.SplitterElement":
                    LoadSplitterProperties((SplitterElement)e.Node.Tag);
                    splitterLayout.BringToFront();
                    break;
                case "Telerik.WinControls.UI.SplitPanel":
                    LoadSplitPanelProperties((SplitPanel)e.Node.Tag);
                    splitPanelLayout.BringToFront();
                    break;
            }

            SetDefaultColors();

            previouslySelectedNode = e.Node;
        }

        private void SetDefaultColors()
        {
            if (previouslySelectedNode != null)
            {
                string previousType = previouslySelectedNode.Tag.ToString();
                switch (previousType)
                {
                    case "Telerik.WinControls.UI.RadSplitContainer":
                        ((BorderPrimitive)((RadPanel)((Telerik.WinControls.UI.RadSplitContainer)previouslySelectedNode.Tag).Parent).PanelElement.Children[1]).ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local);
                        break;
                    case "Telerik.WinControls.UI.SplitterElement":
                        FillPrimitive fillP = (FillPrimitive)((SplitterElement)previouslySelectedNode.Tag).Children[0];
                        fillP.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
                        fillP.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local);
                        fillP.ResetValue(FillPrimitive.GradientStyleProperty, ValueResetFlags.Local);
                        fillP.ResetValue(RadElement.ShouldPaintProperty, ValueResetFlags.Local);
                        break;
                    case "Telerik.WinControls.UI.SplitPanel":
                        ((SplitPanel)previouslySelectedNode.Tag).SplitPanelElement.Border.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local);
                        break;
                }
            }
        }

        private void LoadSplitPanelProperties(SplitPanel panel)
        {
            this.checkFixed.ToggleState = panel.SizeInfo.SizeMode == Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute ? ToggleState.On : ToggleState.Off;
            this.checkCollapsed.ToggleState = panel.Collapsed ? ToggleState.On : ToggleState.Off;

            panel.SplitPanelElement.Border.ForeColor = Color.Red;
        }

        private void LoadSplitterProperties(SplitterElement splitter)
        {
            this.checkSplitterFixed.ToggleState = splitter.Fixed ? ToggleState.On : ToggleState.Off;

            FillPrimitive fillP = (FillPrimitive)splitter.Children[0];
            fillP.BackColor = Color.Red;
            fillP.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            fillP.Visibility = ElementVisibility.Visible;
            fillP.ShouldPaint = true;
        }

        private void LoadSplitContainerProperties(Telerik.WinControls.UI.RadSplitContainer splitContainer)
        {
            if (splitContainer.Orientation == Orientation.Horizontal)
            {
                this.radioHorizontal.ToggleState = ToggleState.On;
            }
            else
            {
                this.radioVertical.ToggleState = ToggleState.On;
            }

            ((BorderPrimitive)((RadPanel)splitContainer.Parent).PanelElement.Children[1]).ForeColor = Color.Red;
        }
    }
}
