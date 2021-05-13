using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Rows.RowDetails
{
    public class RowDetailsViewDefinition : TableViewDefinition
    {
        public override IRowView CreateViewUIElement(GridViewInfo viewInfo)
        {
            GridTableElement tableElement = (GridTableElement)base.CreateViewUIElement(viewInfo);
            tableElement.ViewElement.RowLayout = CreateRowLayout();
            return tableElement;
        }

        public override IGridRowLayout CreateRowLayout()
        {
            return new RowDetailsLayout();
        }
    }
}
