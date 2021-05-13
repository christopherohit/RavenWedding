using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.TreeView.ManipulateData.OptionsTree
{
    public partial class Form1 : TreeExamplesControl
    {
        Bitmap bottomRightBitmap = Resources.TV_car;
        private bool suspendCheckTypeChange = false;

        public Form1()
        {
            InitializeComponent();

            this.radTreeView1.ExpandAll();
            this.radTreeView1.SelectedNodeChanged += new RadTreeView.RadTreeViewEventHandler(radTreeView1_SelectedNodeChanged);
            this.radTreeView1.SelectedNode = this.radTreeView1.Nodes[0];
            this.rcbTriState.IsChecked = this.radTreeView1.TriStateMode;
        }

        protected override void WireEvents()
        {
            this.rrbNone.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbNone_ToggleStateChanged);
            this.rrbShowRadioButton.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbbShowRadioButton_ToggleStateChanged);
            this.rrbShowCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbShowCheckBox_ToggleStateChanged);
            this.rcbTriState.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rcbTriState_ToggleStateChanged);
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
            get { return "Car configurator"; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radTreeView1.AllowEdit = false;
        }

        private void SetEnabled(RadGroupBox groupBox, bool value)
        {
            foreach (Control child in groupBox.Controls)
            {
                child.Enabled = value;
            }
        }

        private void SetSelectedNodeNodeCheckType(CheckType type)
        {
            RadTreeNode node = this.radTreeView1.SelectedNode;

            if (node != null && !suspendCheckTypeChange)
            {
                node.CheckType = type;
            }
        }

        private void rcbTriState_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radTreeView1.TriStateMode = this.rcbTriState.IsChecked;
        }

        private void rrbShowCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.SetSelectedNodeNodeCheckType(CheckType.CheckBox);
        }

        private void rbbShowRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.SetSelectedNodeNodeCheckType(CheckType.RadioButton);
        }

        private void rrbNone_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.SetSelectedNodeNodeCheckType(CheckType.None);
        }
    
        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            RadTreeNode selectedNode = this.radTreeView1.SelectedNode;

            if (selectedNode != null)
            {
                this.SetEnabled(this.radGroupBox1, true);
                this.suspendCheckTypeChange = true;
                this.rrbShowCheckBox.IsChecked = selectedNode.CheckType == CheckType.CheckBox;
                this.rrbShowRadioButton.IsChecked = selectedNode.CheckType == CheckType.RadioButton;
                this.rrbNone.IsChecked = selectedNode.CheckType == CheckType.None;
                this.suspendCheckTypeChange = false;

            }
            else
            {
                this.SetEnabled(this.radGroupBox1, false);
            }
        }
    }
}
