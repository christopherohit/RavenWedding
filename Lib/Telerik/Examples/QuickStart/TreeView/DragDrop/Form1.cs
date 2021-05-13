using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.DragDrop
{
    /// <summary>
    /// Form1
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        private RadTreeNode dragNode = null;

        /// <summary>
        /// Form1 constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.radTreeView1.ItemHeight = 27;
            this.radTreeView2.ItemHeight = 27;
            this.radTreeView1.ExpandAnimation = ExpandAnimation.None;
            this.radTreeView2.ExpandAnimation = ExpandAnimation.None;
            this.radTreeView2.FullRowSelect = false;
            this.radTreeView1.FullRowSelect = false;
            this.radTreeView1.MultiSelect = true;

            this.AutoScroll = false;
            this.radTextBox1.TextBoxElement.AllowDrop = true;

            TreeViewDragDropService dragDropService1 = this.radTreeView1.TreeViewElement.DragDropService;
            TreeViewDragDropService dragDropService2 = this.radTreeView2.TreeViewElement.DragDropService;

            dragDropService1.PreviewDragOver += new EventHandler<RadDragOverEventArgs>(DragDropService_PreviewDragOver);
            dragDropService2.PreviewDragOver += new EventHandler<RadDragOverEventArgs>(DragDropService_PreviewDragOver);
        }

        private void DragDropService_PreviewDragOver(object sender, RadDragOverEventArgs e)
        {
            RadTextBoxElement textBox = e.HitTarget as RadTextBoxElement;

            if (textBox == this.radTextBox1.TextBoxElement)
            {
                e.CanDrop = true;
            }
        }

        private void radTreeView1_DragEnded(object sender, RadTreeViewDragEventArgs e)
        {
            if (this.dragNode != null)
            {
                this.radTextBox1.Text = this.dragNode.Text;
            }
        }

        private void radTreeView1_ItemDrag(object sender, RadTreeViewEventArgs e)
        {
            this.dragNode = e.Node;
        }

        protected override void WireEvents()
        {
            this.radTreeView1.ItemDrag += new Telerik.WinControls.UI.RadTreeView.ItemDragHandler(radTreeView1_ItemDrag);
            this.radTreeView2.ItemDrag += new Telerik.WinControls.UI.RadTreeView.ItemDragHandler(radTreeView1_ItemDrag);
            this.radTreeView1.DragEnded += new RadTreeView.DragEndedHandler(radTreeView1_DragEnded);
            this.radTreeView2.DragEnded += new RadTreeView.DragEndedHandler(radTreeView1_DragEnded);
        }
    }
}
