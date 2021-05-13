using System.Collections.Generic;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
{
    public class ExpandableGridViewFilteringRowInfo : GridViewFilteringRowInfo
    {
        #region Fields

        private GridViewChildRowCollection childRows;

        #endregion

        #region Initialization

        public ExpandableGridViewFilteringRowInfo(GridViewInfo view)
            : base(view)
        {
            this.SuspendPropertyNotifications();
            this.IsExpanded = true;
            this.ResumePropertyNotifications();

            this.childRows = new GridViewChildRowCollection();
            List<GridViewRowInfo> list = new List<GridViewRowInfo>();
            list.Add(new GridViewFilteringChildRowInfo(view));
            this.childRows.Load(list);
        }

        #endregion

        #region Properties

        public override bool HasChildViews
        {
            get { return this.IsExpanded; }
        }

        public override GridViewChildRowCollection ChildRows
        {
            get { return this.childRows; }
        }

        #endregion
    }
}
