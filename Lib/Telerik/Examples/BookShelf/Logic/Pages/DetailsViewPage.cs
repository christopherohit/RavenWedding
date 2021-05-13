using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using BookShelf.Custom_Elements;
using Telerik.WinControls;
using System.Drawing;
using System.Windows.Forms;

namespace BookShelf
{
    public class DetailsViewPage : BookShelfPageBase
    {
        Category tileCategory;

        public override PageID PageID
        {
            get { return PageID.Details; }
        }

        public override bool ShouldUpdate()
        {
            return tileCategory != BookShelfApp.Instance.CurrentCategory;
        }

        public override void SetupPage(MainForm form)
        {
            tileCategory = BookShelfApp.Instance.CurrentCategory;

            form.ButtonsPanelElement.Visibility = ElementVisibility.Collapsed;
            form.SearchPanel.Visible = false;
            form.Panorama.ShowGroups = true;
            form.SearchButton.Image = BookShelfApp.search_btn;
            form.Panorama.PanoramaElement.ScrollBar.Value = 0;
            form.Panorama.Groups.Clear();
            form.Panorama.Items.Clear();

            ShowAllItemsBottonInButtomPanel(false);
            UpdateLogoImage(tileCategory.Name);
            form.UpdateDropDownListSelectedItem(tileCategory.Name);
            form.BottomPanel.Refresh();

            RadTileElement scrollToTile = null;
            foreach (Book book in tileCategory.Books)
            {
                TileGroupElement group = new TileGroupElement();
                group.Margin = new System.Windows.Forms.Padding(0, 0, 60, 0);
                group.Text = " "; //keeps the group title space available
                form.Panorama.Groups.Add(group);

                DetailsTileElement detailsTile = new DetailsTileElement(book);
                group.Items.Add(detailsTile);

                if (BookShelfApp.Instance.CurrentBook.Title == book.Title)
                {
                    scrollToTile = detailsTile;
                }
            }

            foreach (TileGroupElement el in form.Panorama.Groups)
            {
                el.CellSize = new Size(800, 400);
            }

            if (scrollToTile != null)
            {
                form.Panorama.PanoramaElement.UpdateViewOnScroll();
                form.Panorama.PanoramaElement.UpdateLayout(); //not sure if this is still needed
                form.Panorama.PanoramaElement.ScrollToItem(scrollToTile);
                form.Panorama.PanoramaElement.UpdateLayout(); //not sure if this is still needed
                Application.DoEvents(); //not sure if this is still needed

                int value = (form.BookShelfLabel.Location.X - form.BookShelfLabel.Margin.Left);
                if (form.Panorama.PanoramaElement.ScrollBar.Value - value >= 0)
                {
                    form.Panorama.PanoramaElement.ScrollBar.Value -= value;
                }
                else
                {
                    form.Panorama.PanoramaElement.ScrollBar.Value = 0;
                }
            }            
        }
    }
}
