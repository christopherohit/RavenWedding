using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;

namespace BookShelf
{
    public class SearchPage : BookShelfPageBase
    {
        public override PageID PageID
        {
            get { return PageID.Search; }
        }

        public override void SetupPage(MainForm form)
        {
            form.ButtonsPanelElement.Visibility = ElementVisibility.Collapsed;
            form.SearchTextBox.Text = "";
            form.SearchButton.Image = BookShelfApp.search_btn_selected;
            form.SearchPanel.Visible = true;

            UpdateLogoImage("");
            ShowAllItemsBottonInButtomPanel(false);
            form.UpdateDropDownListSelectedItem("None");

            form.Panorama.Groups.Clear();
            form.Panorama.ShowGroups = false;
            form.Panorama.RowsCount = 4;
            form.Panorama.CellSize = new System.Drawing.Size(250, 90);
            form.Panorama.PanoramaElement.TileLayout.Margin = new System.Windows.Forms.Padding(95, 0, 0, 0);
        }
    }
}
