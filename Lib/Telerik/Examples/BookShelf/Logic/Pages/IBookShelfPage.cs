using System;
using System.Collections.Generic;
using System.Text;

namespace BookShelf
{
    public interface IBookShelfPage
    {
        PageID PageID { get; }

        void SetupPage(MainForm form);

        bool ShouldUpdate();
    }
}
