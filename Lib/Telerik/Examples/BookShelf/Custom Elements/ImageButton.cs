using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;

namespace BookShelf.Custom_Elements
{
    public class ImageButton: RadButton
    {
        #region Fields

        Image normal;
        Image pressed;
        Image hover;

        #endregion

        #region Properties

        public Image ImageNormal
        {
            get { return normal; }
            set { normal = value; }
        }

        public Image ImageHover
        {
            get { return hover; }
            set { hover = value; }
        }

        public Image ImagePressed
        {
            get { return pressed; }
            set { pressed = value; }
        }

        #endregion

        #region Methods

        public void SetImages(Image normal, Image pressed, Image hover)
        {
            this.normal = normal;
            this.pressed = pressed;
            this.hover = hover;
        }

        #endregion

        #region Event handlers

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Image = ImageHover;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Image = ImageNormal;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.Image = ImagePressed;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Image = ImageNormal;
        }

        #endregion
    }
}
