using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using BookShelf.Custom_Elements;
using System.Windows.Forms;

namespace BookShelf
{
    public class HistoryItem
    {
       public PageID page;
       public Category currentCategory;
       public Book currentBook;
       public int scrollValue;
       public string searchText;

        public HistoryItem()
        {
            currentCategory = BookShelfApp.Instance.CurrentCategory;
            currentBook = BookShelfApp.Instance.CurrentBook;
            page = BookShelfApp.Instance.CurrentPageID;
            scrollValue = BookShelfApp.Instance.Form.Panorama.PanoramaElement.ScrollBar.Value;
            searchText = BookShelfApp.Instance.Form.SearchTextBox.Text;
        }

        public void Apply()
        {
            BookShelfApp.Instance.CurrentCategory = currentCategory;
            BookShelfApp.Instance.CurrentBook = currentBook;
            BookShelfApp.Instance.CurrentPageID = page;
            BookShelfApp.Instance.Form.Panorama.PanoramaElement.UpdateLayout();
            Application.DoEvents();
            SetScrollValue(BookShelfApp.Instance.Form.Panorama.PanoramaElement.ScrollBar, 0);
            SetScrollValue(BookShelfApp.Instance.Form.Panorama.PanoramaElement.ScrollBar, scrollValue);
            BookShelfApp.Instance.Form.SearchTextBox.Text = searchText;
            if (!string.IsNullOrEmpty(BookShelfApp.Instance.Form.SearchTextBox.Text))
            {
                BookShelfApp.Instance.Form.SearchButtonElement.PerformClick();
            }
        }

        void SetScrollValue(RadScrollBarElement scrollbar, int newValue)
        {
            if (newValue > scrollbar.Maximum - scrollbar.LargeChange + 1)
            {
                newValue = scrollbar.Maximum - scrollbar.LargeChange + 1;
            }
            if (newValue < scrollbar.Minimum)
            {
                newValue = scrollbar.Minimum;
            }
            scrollbar.Value = newValue;
        }
    }
}
