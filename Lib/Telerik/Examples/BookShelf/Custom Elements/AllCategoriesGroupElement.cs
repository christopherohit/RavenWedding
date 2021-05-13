using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using BookShelf.Properties;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;

namespace BookShelf.Custom_Elements
{
    public class AllCategoriesGroupElement : TileGroupElement
    {
        LightVisualElement showAllButton;

        public AllCategoriesGroupElement(string text, int rowsCount, ElementVisibility visibility)
        {
            this.Text = text;
            if (rowsCount != 0)
            {
                this.RowsCount = rowsCount;
            }
            this.ShowAllButton.Visibility = visibility;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.Margin = new Padding(0, 0, 50, 0);
            this.Font = BookShelfApp.SegoeUI25Light;
            this.ForeColor = Color.Black;
            this.RowsCount = 10;
            this.ColumnsCount = 4;

            showAllButton = new LightVisualElement();
            showAllButton.Image = Resources.show_all;
            showAllButton.StretchHorizontally = false;
            showAllButton.StretchVertically = false;
            showAllButton.Alignment = ContentAlignment.TopRight;

            this.Children.Add(showAllButton);
        }

        public LightVisualElement ShowAllButton
        {
            get 
            {
                return this.showAllButton; 
            }
        }
    }
}
