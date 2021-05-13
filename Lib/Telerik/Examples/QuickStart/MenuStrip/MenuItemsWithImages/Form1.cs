using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.MenuItemsWithImages
{
    public partial class Form1 : ExamplesForm
    {
		Size oldSize = Size.Empty;

        public Form1()
        {
            InitializeComponent();
        }

		private void menuHorizontalOrientationItem_Click(object sender, EventArgs e)
		{
			this.radMenuDemo.MenuElement.MinSize = oldSize;
			this.radMenuDemo.Orientation = Orientation.Horizontal;
		}

		private void menuVerticalOrientationItem_Click(object sender, EventArgs e)
		{
			oldSize = this.radMenuDemo.Size;
			this.radMenuDemo.MenuElement.MinSize = Size.Empty;
			this.radMenuDemo.Orientation = Orientation.Vertical;
		}

		private void itemHorizontalOrientationItem_Click(object sender, EventArgs e)
		{
			this.radMenuDemo.MenuElement.TextOrientation = Orientation.Horizontal;
			this.radMenuDemo.MenuElement.FlipText = false;
		}

		private void itemVerticalOrientationItem_Click(object sender, EventArgs e)
		{
			this.radMenuDemo.MenuElement.TextOrientation = Orientation.Vertical;
			this.radMenuDemo.MenuElement.FlipText = true;
		}

        protected override void WireEvents()
        {
        }
    }
}