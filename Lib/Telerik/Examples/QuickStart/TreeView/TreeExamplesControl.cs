using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView
{
    public class TreeExamplesControl : ExamplesForm
    {
        Bitmap topRightBitmap = Resources.TV_gradient;

        public TreeExamplesControl()
        {
        }

        public virtual RadTreeView TreeControl { get { return null; } }

        public virtual Bitmap BottomRightImage { get { return null; } }

        public virtual string HeaderText { get { return ""; } }

        public virtual Bitmap TopRightImage
        {
            get { return this.topRightBitmap; }
        }          

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (TreeControl != null)
            {
                this.TreeControl.ItemHeight = 27;
                this.TreeControl.ShowLines = false;
                this.TreeControl.FullRowSelect = true;
                this.TreeControl.ExpandAnimation = ExpandAnimation.None;
                //this.headerPanel.Text = HeaderText;
                this.TreeControl.AllowEdit = true;
                this.TreeControl.AllowAdd = false;
                this.TreeControl.AllowRemove = false;
                this.TreeControl.AllowDefaultContextMenu = true;
                this.TreeControl.Size = new Size(300, 0);
                this.TreeControl.Dock = DockStyle.Left;
            }
        }

        protected override void WireEvents()
        {

        }
    }
}
