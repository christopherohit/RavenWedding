using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using BookShelf.Custom_Elements;
using Telerik.WinControls;
using System.Collections;
using System.Drawing;

namespace BookShelf
{
    public class SingleCategoryPage : BookShelfPageBase
    {
        Category category;

        public override PageID PageID
        {
            get { return PageID.SingleCategory; }
        }

        public override bool ShouldUpdate()
        {
            return category != BookShelfApp.Instance.CurrentCategory;
        }

        public override void SetupPage(MainForm form)
        {
            category = BookShelfApp.Instance.CurrentCategory;

            form.ButtonsPanelElement.Visibility = ElementVisibility.Collapsed;
            form.SearchPanel.Visible = false;
            form.ListView.Visible = false;
            form.Panorama.Visible = true;
            form.Panorama.ShowGroups = true;
            form.Panorama.PanoramaElement.ScrollBar.Value = 0;
            form.SearchButton.Image = BookShelfApp.search_btn;

            ShowAllItemsBottonInButtomPanel(false);
            UpdateLogoImage(BookShelfApp.Instance.CurrentCategory != null ? BookShelfApp.Instance.CurrentCategory.Name : "");

            form.DropDownList.SelectedValue = category;

            form.Panorama.Groups.Clear();
            form.Panorama.Items.Clear();

            List<AllCategoriesGroupElement> categories = new List<AllCategoriesGroupElement>();
            categories.Add(new AllCategoriesGroupElement("A-E", 4, ElementVisibility.Collapsed));
            categories.Add(new AllCategoriesGroupElement("F-J", 4, ElementVisibility.Collapsed));
            categories.Add(new AllCategoriesGroupElement("K-O", 4, ElementVisibility.Collapsed));
            categories.Add(new AllCategoriesGroupElement("P-T", 4, ElementVisibility.Collapsed));
            categories.Add(new AllCategoriesGroupElement("U-Z", 4, ElementVisibility.Collapsed));
            categories.Add(new AllCategoriesGroupElement("#", 4, ElementVisibility.Collapsed));

            //get the needed books
            IEnumerator neededBooks;
            if (BookShelfApp.Instance.CurrentCategory == null)
            {
                neededBooks = BookShelfApp.Instance.Books.Values.GetEnumerator();
            }
            else
            {
                neededBooks = BookShelfApp.Instance.CurrentCategory.Books.GetEnumerator();              
            }

            int i = 0;
            while (neededBooks.MoveNext())
            {
                Book book = (Book)neededBooks.Current;

                int index = 5;
                char firstChar = char.ToLower(book.Title[0]);
                HorizontalTileElement tile = new HorizontalTileElement(book, 80);
                tile.Click += new EventHandler(tile_Click);

                if (firstChar >= 'a' && firstChar <= 'e') index = 0;
                else if (firstChar >= 'f' && firstChar <= 'j') index = 1;
                else if (firstChar >= 'k' && firstChar <= 'o') index = 2;
                else if (firstChar >= 'p' && firstChar <= 't') index = 3;
                else if (firstChar >= 'u' && firstChar <= 'z') index = 4;

                if (index >= 0 && index < categories.Count)
                {
                    tile.Row = categories[index].Items.Count % categories[index].RowsCount;
                    tile.Column = categories[index].Items.Count / categories[index].RowsCount; 
                    categories[index].Items.Add(tile); 
                }

                i++;
            }

            foreach (AllCategoriesGroupElement c in categories)
            {
                if (c.Items.Count != 0)
                {
                    form.Panorama.Groups.Add(c);
                }
            }

            foreach (TileGroupElement el in form.Panorama.Groups)
            {
                el.CellSize = new Size(235, 90);
            }

            form.Panorama.PanoramaElement.UpdateViewOnScroll(); //force update to show items
        }
    }
}
