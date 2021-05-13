using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;

namespace BookShelf.Custom_Elements
{
    public class CustomTileGroupElement : TileGroupElement
    {
        public CustomTileGroupElement(string text)
        {
            this.Text = text;
            this.Font = BookShelfApp.SegoeUI35Light;
            this.ForeColor = Color.Black;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.ContentElement.Margin = new Padding(5, 0, 0, 0);
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(TileGroupElement);
            }
        }
    }
}
