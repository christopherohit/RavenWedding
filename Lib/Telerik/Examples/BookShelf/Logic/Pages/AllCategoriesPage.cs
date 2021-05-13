using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using BookShelf.Custom_Elements;
using Telerik.WinControls.UI;
using System.Drawing;

namespace BookShelf
{
    public class AllCategoriesPage: BookShelfPageBase
    {
        public override PageID PageID
        {
            get { return PageID.AllCategories; }
        }

        public override void SetupPage(MainForm form)
        {
            form.ButtonsPanelElement.Visibility = ElementVisibility.Collapsed;
            form.SearchPanel.Visible = false;
            form.Panorama.Visible = true;
            form.ListView.Visible = false;
            form.Panorama.ShowGroups = true;
            form.SearchButton.Image = BookShelfApp.search_btn;
            form.Panorama.PanoramaElement.ScrollBar.Value = 0;

            ShowAllItemsBottonInButtomPanel(false);
            UpdateLogoImage("");
            form.UpdateDropDownListSelectedItem("None");

            form.Panorama.Groups.Clear();
            form.Panorama.Items.Clear();

            foreach (Category category in BookShelfApp.Instance.Categories.Values)
            {
                AllCategoriesGroupElement group = new AllCategoriesGroupElement(category.Name, 0, ElementVisibility.Visible);
                group.Tag = category;
                group.ShowAllButton.Click += new EventHandler(ShowAllButton_Click);
                int row = -1;
                for (int i = 0; i < 6 && i < category.Books.Count; i++)
                {
                    HorizontalTileElement tile = new HorizontalTileElement(category.Books[i], int.MaxValue);
                    tile.Column = i % 2;
                    tile.Row = i % 2 == 0 ? ++row : row;
                    tile.Click += new EventHandler(tile_Click);
                    group.Items.Add(tile);
                }
                form.Panorama.Groups.Add(group);
            }

            foreach (TileGroupElement el in form.Panorama.Groups)
            {
                el.CellSize = new Size(245, 123);
            }

            form.Panorama.PanoramaElement.UpdateViewOnScroll();
        }

        void ShowAllButton_Click(object sender, EventArgs e)
        {
            LightVisualElement element = sender as LightVisualElement;
            if (element == null)
            {
                return;
            }
            TileGroupElement group = element.FindAncestor<TileGroupElement>();
            if (group != null)
            {
                BookShelfApp.Instance.CurrentCategory = (Category)group.Tag;
                BookShelfApp.Instance.CurrentPageID = PageID.SingleCategory;
            }
        }
    }
}
