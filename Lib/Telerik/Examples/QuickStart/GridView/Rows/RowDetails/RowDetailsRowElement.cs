using System;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls.Data;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Rows.RowDetails
{
    public class RowDetailsRowElement : GridDataRowElement
    {
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataRowElement);
            }
        }

        public override void UpdateInfo()
        {
            if (!this.RowInfo.IsCurrent)
            {
                this.RowInfo.Height = TableElement.RowHeight;
            }
            else
            {
                this.RowInfo.Height = ((RowDetailsGrid)this.GridControl).DetailsRowHeight;
            }
            base.UpdateInfo();
        }
    }
}