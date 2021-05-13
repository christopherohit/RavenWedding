using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using BookShelf.Custom_Elements;
using Telerik.WinControls.UI;
using System.Drawing;

namespace BookShelf
{
    public class MainPage : BookShelfPageBase
    {

        readonly int numberOfItemsVisible = 7;

        public override PageID PageID
        {
            get { return PageID.Main; }
        }

        public override void SetupPage(MainForm form)
        {
            form.ButtonsPanelElement.Visibility = ElementVisibility.Collapsed;
            form.SearchPanel.Visible = false;
            form.ListView.Visible = false;
            form.Panorama.Visible = true;
            form.Panorama.ShowGroups = true;
            form.SearchButton.Image = BookShelfApp.search_btn;
            form.Panorama.PanoramaElement.ScrollBar.Value = 0;

            ShowAllItemsBottonInButtomPanel(true);
            UpdateLogoImage("");
            form.UpdateDropDownListSelectedItem("None");

            form.Panorama.Groups.Clear();
            form.Panorama.Items.Clear();

            CustomTileGroupElement popularGroups = new CustomTileGroupElement("Popular");
            form.Panorama.Groups.Add(popularGroups);
            int i = 0;
            foreach (Book book in BookShelfApp.Instance.Popular)
            {
                if (BookShelfApp.Instance.IsLoaded && i >= numberOfItemsVisible)
                {
                    break;
                }
                popularGroups.Items.Add(new VerticalTileElement(book, i++));
            }

            CustomTileGroupElement latestGroups = new CustomTileGroupElement("Latest");
            form.Panorama.Groups.Add(latestGroups);
            i = 0;
            foreach (Book book in BookShelfApp.Instance.Latest)
            {
                if (BookShelfApp.Instance.IsLoaded && i >= numberOfItemsVisible)
                {
                    break;
                }
                latestGroups.Items.Add(new VerticalTileElement(book, i++));
            }

            foreach (TileGroupElement el in form.Panorama.Groups)
            {
                el.CellSize = new Size(130,415);// (form.Panorama.PanoramaElement.Size.Height - form.Panorama.PanoramaElement.ScrollBar.Size.Height - (int)el.Layout.DesiredSize.Height) / el.RowsCount);
            }

            form.Panorama.PanoramaElement.UpdateViewOnScroll();
        }
    }
}
