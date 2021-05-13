using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.ControllingBasicStates
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void disableItem_Click(object sender, EventArgs e)
        {
			RadMenuItem item = (RadMenuItem) sender;
			item.Enabled = false;
        }

        void removeItem_Click(object sender, EventArgs e)
        {
			IHierarchicalItem item = (IHierarchicalItem) sender;
            RadMenuItem parentItem = (RadMenuItem)item.HierarchyParent;
			parentItem.Items.Remove((RadMenuItem)sender);
        }

        void addItem_Click(object sender, EventArgs e)
        {
			RadMenuItem item = new RadMenuItem();
			item.Text = "New " + (sender as RadMenuItem).Text;

			IHierarchicalItem hItem = (IHierarchicalItem) sender;
            RadMenuItemBase parentItem = (RadMenuItemBase)hItem.HierarchyParent;
			parentItem.Items.Add(item);
        }

        protected override void WireEvents()
        {
            this.radMenuItem4.Click += new System.EventHandler(this.addItem_Click);
            this.radMenuItem5.Click += new System.EventHandler(this.addItem_Click);
            this.radMenuItem6.Click += new System.EventHandler(this.addItem_Click);
            this.radMenuItem7.Click += new System.EventHandler(this.addItem_Click);
            this.radMenuItem8.Click += new System.EventHandler(this.removeItem_Click);
            this.radMenuItem10.Click += new System.EventHandler(this.removeItem_Click);
            this.radMenuItem9.Click += new System.EventHandler(this.removeItem_Click);
            this.radMenuItem11.Click += new System.EventHandler(this.removeItem_Click);
            this.radMenuItem12.Click += new System.EventHandler(this.disableItem_Click);
            this.radMenuItem13.Click += new System.EventHandler(this.disableItem_Click);
            this.radMenuItem14.Click += new System.EventHandler(this.disableItem_Click);
            this.radMenuItem15.Click += new System.EventHandler(this.disableItem_Click);
        }
    }
}