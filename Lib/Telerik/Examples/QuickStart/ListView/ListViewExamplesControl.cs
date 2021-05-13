using System;
using System.Collections.Generic;
using System.Text;
using Telerik.QuickStart.WinControls;
using System.Drawing;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.ListView
{
    public class ListViewExamplesControl : ExamplesForm
    {
        public virtual Bitmap BottomRightImage { get { return null; } }

        public virtual Bitmap TopRightImage { get { return null; } }

        public virtual Control ContentControl { get { return null; } }

        protected virtual void PaintImages(Graphics g)
        {
            if (TopRightImage != null)
            {
                g.DrawImage(TopRightImage, new Point(this.Size.Width - TopRightImage.Width, 0));
            }
            if (BottomRightImage != null)
            {
                g.DrawImage(BottomRightImage, new Point(this.Size.Width - BottomRightImage.Width, this.Size.Height - BottomRightImage.Height));
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintImages(e.Graphics);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.ContentControl != null)
            {
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;
                //this.ContentControl.Location = new Point((width - ContentControl.Size.Width) / 2, this.ContentControl.Location.Y);
            }
        }

        protected override void WireEvents()
        {
        }
    }
}
