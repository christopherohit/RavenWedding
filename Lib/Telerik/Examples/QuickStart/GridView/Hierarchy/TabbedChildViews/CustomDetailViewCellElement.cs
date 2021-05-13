using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.GridView.Hierarchy.TabbedChildViews
{
    public class CustomDetailViewCellElement: GridDetailViewCellElement
    {
        public CustomDetailViewCellElement(GridViewColumn column, GridRowElement row): base(column, row)
        {
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDetailViewCellElement);
            }
        }

        protected override RadPageViewItem CreatePageViewItem(IRadPageViewProvider pageViewProvider, GridViewInfo viewInfo)
        {
            RadPageViewItem item = base.CreatePageViewItem(pageViewProvider, viewInfo);

            RadPageViewExplorerBarItem explorerBarItem = item as RadPageViewExplorerBarItem;
            if (explorerBarItem != null)
            {
                explorerBarItem.AssociatedContentAreaElement.Children[0].MaxSize = new System.Drawing.Size(0, 152);
            }

            return item;
        }
    }
}
