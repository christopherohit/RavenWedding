using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
{
    public class GridFilteringChildRowElement : GridRowElement
    {
        #region Fields

        private GridCellElement cellElement;
        private AdvanceFilterControl hostedControl;

        #endregion

        #region Initialization

        public GridFilteringChildRowElement()
        {
        }

        public override void Initialize(GridViewRowInfo rowInfo)
        {
            base.Initialize(rowInfo);

            rowInfo.SuspendPropertyNotifications();
            rowInfo.Height = this.hostedControl.Size.Height;
            rowInfo.ResumePropertyNotifications();
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.cellElement = new GridCellElement(null, this);
            this.cellElement.StretchHorizontally = true;
            this.cellElement.StretchVertically = true;
            this.Children.Add(cellElement);

            this.hostedControl = new AdvanceFilterControl();
            RadHostItem hostItem = new RadHostItem(this.hostedControl);
            this.cellElement.Children.Add(hostItem);
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            RadGridView grid = this.GridControl;
            this.hostedControl.GridView = grid;
        }

        #endregion

        #region Methods

        public override bool IsCompatible(GridViewRowInfo data, object context)
        {
            return data is GridViewFilteringChildRowInfo;
        }

        #endregion
    }
}
