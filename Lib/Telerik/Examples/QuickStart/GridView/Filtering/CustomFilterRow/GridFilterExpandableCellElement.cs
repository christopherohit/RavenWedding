using System;
using Telerik.WinControls.UI;
using System.Drawing;

namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFilterRow
{
    public class GridFilterExpandableCellElement : GridRowHeaderCellElement
    {
        #region Fields

        private GridExpanderItem expander;

        #endregion

        #region Initialization

        public GridFilterExpandableCellElement(GridViewColumn col, GridRowElement row)
            : base(col, row)
        {

        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.expander = new GridExpanderItem();
            this.expander.SignStyle = SignStyles.Image;
            this.expander.DrawSignBorder = false;
            this.expander.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Expander_PropertyChanged);
            this.Children.Add(expander);
        }

        public override void Initialize(GridViewColumn column, GridRowElement row)
        {
            base.Initialize(column, row);
            this.expander.Expanded = this.RowInfo.IsExpanded;
            SetExpanderImageOrientation(this.expander.Expanded);
        }

        #endregion

        #region Properties

        protected override Type ThemeEffectiveType
        {
            get { return typeof(GridGroupExpanderCellElement); }
        }

        #endregion

        #region Methods

        protected override void UpdateImage()
        {
            this.Image = null;
        }
       
        #endregion

        #region Layout

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);

            RectangleF clientRect = this.GetClientRectangle(finalSize);

            float expanderWidth = this.expander.DesiredSize.Width;
            float imgLeftPos = clientRect.X + (clientRect.Width - expanderWidth) / 2;

            float expanderHeight = this.expander.DesiredSize.Height;
            float imgTopPos = clientRect.Y + (clientRect.Height - expanderHeight) / 2;

            RectangleF imgArea = new RectangleF(imgLeftPos, imgTopPos, expanderWidth, expanderHeight);
            this.expander.Arrange(imgArea);

            return finalSize;
        }

        #endregion

        #region Event Handlers

        private void Expander_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (this.RowInfo != null)
            {
                this.RowInfo.IsExpanded = expander.Expanded;
            }
        }

        protected override void OnRowPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnRowPropertyChanged(e);
            this.expander.Expanded = this.RowInfo.IsExpanded;
            SetExpanderImageOrientation(this.expander.Expanded);
        }

        private void SetExpanderImageOrientation(bool isExpanded)
        {
            if (isExpanded)
            {
                this.expander.SignImage = Properties.Resources.chevron_up;
            }
            else
            {
                this.expander.SignImage = Properties.Resources.chevron_down;
            }
        }

        #endregion
    }
}
