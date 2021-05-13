using System;
using System.Collections.Generic;
using System.Text;
using BookShelf.Custom_Elements;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;
using System.Drawing;

namespace BookShelf
{
    public class CategoryZoomOutPage : BookShelfPageBase
    {
        public override PageID PageID
        {
            get { return PageID.SingleCategoryZommedOut; }
        }

        public override void SetupPage(MainForm form)
        {
            form.SearchPanel.Visible = false;
            form.Panorama.ShowGroups = true;
            form.Panorama.PanoramaElement.ScrollBar.Value = 0;
            form.Panorama.Groups.Clear();

            ShowButtonsPanel(true);
            ShowAllItemsBottonInButtomPanel(false);
            UpdateLogoImage(form.DropDownList.SelectedItem.Text);

            AllCategoriesGroupElement group = new AllCategoriesGroupElement(BookShelfApp.Instance.CurrentCategory.Name, 4, ElementVisibility.Collapsed);
            group.Margin = new Padding(150, 0, 0, 0);
            form.Panorama.Groups.Add(group);

            foreach (RadToggleButtonElement toggleButton in form.ButtonsPanelElement.Children)
            {
                //TODO if (toggleButton.Text.ToLower() == groupElement.Text.ToLower())
                //{
                //    toggleButton.ToggleState = ToggleState.Off;
                //    toggleButton.ToggleState = ToggleState.On;
                //}
            }

            foreach (TileGroupElement el in form.Panorama.Groups)
            {
                el.CellSize = new Size(235, 90);
            }
        }
    }
}
