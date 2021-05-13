using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TreeView.Globalization.Localization
{
    public class GermanTreeViewLocalizationProvider: TreeViewLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case TreeViewStringId.ContextMenuCollapse:
                    return "Zusammenklappen";
                case TreeViewStringId.ContextMenuDelete:
                    return "Löschen";
                case TreeViewStringId.ContextMenuEdit:
                    return "Edieren";
                case TreeViewStringId.ContextMenuExpand:
                    return "Expandieren";
                case TreeViewStringId.ContextMenuNew:
                    return "Neu";
                case TreeViewStringId.ContextMenuCopy:
                    return "Kopie";
                case TreeViewStringId.ContextMenuPaste:
                    return "Shpacieren";
                case TreeViewStringId.ContextMenuCut:
                    return "Schneiden";
            }

            return "";
        }
    }
}
