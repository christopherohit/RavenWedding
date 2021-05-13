using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;

namespace BookShelf
{
    public class AllCategoriesZoomOutPage : BookShelfPageBase
    {
        public override PageID PageID
        {
            get { return PageID.AllCategoriesZoomedOut; }
        }

        public override void SetupPage(MainForm form)
        {
            form.ButtonsPanelElement.Visibility = ElementVisibility.Collapsed;
            form.Panorama.PanoramaElement.ScrollBar.Value = 0;
            form.Panorama.Visible = false;
            form.ListView.Visible = true;
            form.SearchButton.Image = BookShelfApp.search_btn;

            ShowAllItemsBottonInButtomPanel(false);
            UpdateLogoImage("");
            form.UpdateDropDownListSelectedItem("None");
        }
    }
}
