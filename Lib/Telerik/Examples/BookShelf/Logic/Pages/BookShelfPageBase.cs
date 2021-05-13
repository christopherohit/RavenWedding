using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Windows.Forms;
using BookShelf.Custom_Elements;

namespace BookShelf
{
    public abstract class BookShelfPageBase: IBookShelfPage
    {
        public abstract PageID PageID
        {
            get;
        }

        public abstract void SetupPage(MainForm form);

        public virtual bool ShouldUpdate()
        {
            return false;
        }        

        protected void ShowButtonsPanel(bool show)
        {
            MainForm form = BookShelfApp.Instance.Form;

            form.ButtonsPanelElement.Visibility = show ? ElementVisibility.Visible : ElementVisibility.Collapsed;

            if (show)
            {
                form.Panorama.PanoramaElement.GroupLayout.Margin = new Padding(0, 0, 0, 0);

                foreach (RadToggleButtonElement btn in form.ButtonsPanelElement.Children)
                {
                    btn.BorderElement.Width = 3;
                    btn.BorderElement.BoxStyle = BorderBoxStyle.SingleBorder;
                    btn.BorderElement.ForeColor = BookShelfApp.Instance.GetColor(form.DropDownList.SelectedItem.Text);
                    btn.Enabled = false;
                    btn.ButtonFillElement.Visibility = ElementVisibility.Collapsed;
                    btn.ForeColor = BookShelfApp.Instance.GetColor(form.DropDownList.SelectedItem.Text);
                }
            }
        }

        protected void UpdateLogoImage(string categoryName)
        {
            MainForm form = BookShelfApp.Instance.Form;

            switch (categoryName)
            {
                case "Nonfiction":
                    form.Logo.Image = BookShelfApp.logo_sign_nonfiction;
                    break;
                case "Fiction & Literature":
                    form.Logo.Image = BookShelfApp.logo_sign_fiction;
                    break;
                case "Textbooks, Education":
                    form.Logo.Image = BookShelfApp.logo_sign_textbooks;
                    break;
                case "Children Young Adults":
                    form.Logo.Image = BookShelfApp.logo_sign_children;
                    break;
                case "Magazine Back Issues":
                    form.Logo.Image = BookShelfApp.logo_sign_magazine;
                    break;
                case "Antiquarian & Collectible":
                    form.Logo.Image = BookShelfApp.logo_sign_antiquarian;
                    break;
                case "Audiobooks":
                    form.Logo.Image = BookShelfApp.logo_sign_audiobooks;
                    break;
                case "Cookbooks":
                    form.Logo.Image = BookShelfApp.logo_sign_cookbooks;
                    break;
                case "Other":
                    form.Logo.Image = BookShelfApp.logo_sign_other;
                    break;
                default:
                    form.Logo.Image = BookShelfApp.logo_sign_home;
                    break;
            }
        }

        protected void ShowAllItemsBottonInButtomPanel(bool show)
        {
            MainForm form = BookShelfApp.Instance.Form;

            foreach (RadButton b in form.BottomPanel.Controls)
            {
                b.Visible = !show;
            }
            form.ShowAllItemsButton.Visible = show;
            LightVisualElement el = (LightVisualElement)form.BottomPanel.PanelElement.Children[form.BottomPanel.PanelElement.Children.Count - 1];
            el.BackgroundShape.Image = show ? BookShelfApp.bg_pattern : BookShelfApp.app_bar_bg;
            form.BottomPanel.Refresh();
        }

        protected void tile_Click(object sender, EventArgs e)
        {
            BaseTileElement tile = sender as BaseTileElement;
            if (tile == null)
            {
                return;
            }
            BookShelfApp.Instance.CurrentBook = tile.Book;
            BookShelfApp.Instance.CurrentPageID = PageID.Details;
            BookShelfApp.Instance.Form.BottomPanel.Refresh();
        }        
    }
}
