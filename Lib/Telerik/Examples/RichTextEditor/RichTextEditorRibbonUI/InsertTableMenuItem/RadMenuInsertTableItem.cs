using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace RichTextEditorRibbonUI
{
    public class RadMenuInsertTableItem : RadMenuItemBase
    {
        #region Constants

        private const string HeaderText = "Insert Table";

        #endregion

        #region Fields

        private UniformGrid uniformGrid;
        private LightVisualElement header;
        private StackLayoutElement stackLayout;
        private int currentColumnIndex = -1;
        private int currentRowIndex = -1;

        #endregion

        #region Intialization

        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.ShouldHandleMouseInput = true;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            int rowsCount = 8;
            int columnsCount = 10;
            Size boxSize = new Size(16, 16);

            this.stackLayout = new StackLayoutElement();
            this.stackLayout.Orientation = Orientation.Vertical;
            this.stackLayout.StretchHorizontally = true;
            this.stackLayout.StretchVertically = true;
            this.stackLayout.NotifyParentOnMouseInput = true;
            this.Children.Add(this.stackLayout);

            this.header = new LightVisualElement();
            this.header.TextAlignment = ContentAlignment.MiddleLeft;
            this.header.StretchVertically = false;
            this.header.Text = RadMenuInsertTableItem.HeaderText;
            this.header.DrawFill = true;
            this.header.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            this.header.GradientStyle = GradientStyles.Solid;
            this.header.BackColor = Color.FromArgb(240, 242, 245);
            this.stackLayout.Children.Add(this.header);

            this.uniformGrid = new UniformGrid();
            this.uniformGrid.StretchVertically = true;
            this.uniformGrid.NotifyParentOnMouseInput = true;
            this.uniformGrid.Rows = rowsCount;
            this.uniformGrid.Columns = columnsCount;
            this.uniformGrid.MinSize = new Size(160, 140);
            this.uniformGrid.Margin = new Padding(5, 5, 0, 0);
            this.stackLayout.Children.Add(this.uniformGrid);

            for (int i = 1; i <= rowsCount * columnsCount; i++)
            {
                LightVisualElement box = new LightVisualElement();
                box.DrawBorder = true;
                box.BorderGradientStyle = GradientStyles.Solid;
                box.BorderBoxStyle = BorderBoxStyle.OuterInnerBorders;
                box.MaxSize = boxSize;
                box.MinSize = boxSize;
                box.NotifyParentOnMouseInput = true;
                box.MouseMove += new MouseEventHandler(OnBoxMouseMove);
                box.MouseDown += new MouseEventHandler(OnBoxMouseDown);
                this.uniformGrid.Children.Add(box);
            }
        }

        #endregion

        #region Properties

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadMenuItem);
            }
        }

        #endregion

        #region Events

        public event EventHandler<TableSelectionChangedEventArgs> SelectionChanged;

        protected virtual void OnSelectionChanged(TableSelectionChangedEventArgs e)
        {
            EventHandler<TableSelectionChangedEventArgs> handler = this.SelectionChanged;

            if (handler != null)
            {
                handler(this, e);
            }

            RadDropDownButtonElement buttonElement = this.Owner as RadDropDownButtonElement;

            if (buttonElement != null)
            {
                buttonElement.DropDownMenu.ClosePopup(RadPopupCloseReason.Mouse);
                this.ResetVisuals();
            }
        }

        private void ResetVisuals()
        {
            this.header.Text = RadMenuInsertTableItem.HeaderText;

            foreach (LightVisualElement element in this.uniformGrid.Children)
            {
                element.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local);
                element.ResetValue(LightVisualElement.BorderInnerColorProperty, ValueResetFlags.Local);
            }
        }

        private void OnBoxMouseMove(object sender, MouseEventArgs e)
        {
            this.SelectBoxes(e.Location);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.SelectBoxes(e.Location);
        }

        private void OnBoxMouseDown(object sender, MouseEventArgs e)
        {
            this.OnSelectionChanged(new TableSelectionChangedEventArgs(currentColumnIndex, currentRowIndex));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                this.OnSelectionChanged(new TableSelectionChangedEventArgs(currentColumnIndex, currentRowIndex));
            }
        }

        protected override void OnPropertyChanged(RadPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.Property == LightVisualElement.ContainsMouseProperty)
            {
                if (!(bool)e.NewValue)
                {
                    this.ResetVisuals();
                }
            }
        }

        #endregion

        #region Methods

        private void SelectBoxes(Point location)
        {
            this.currentColumnIndex = -1;
            this.currentRowIndex = -1;

            foreach (LightVisualElement element in this.uniformGrid.Children)
            {
                RectangleF elementBounds = element.ControlBoundingRectangle;

                if (elementBounds.X <= location.X &&
                    elementBounds.Y <= location.Y)
                {
                    int columnIndex = UniformGrid.GetColumnIndex(element);
                    int rowIndex = UniformGrid.GetRowIndex(element);

                    currentColumnIndex = Math.Max(currentColumnIndex, columnIndex);
                    currentRowIndex = Math.Max(currentRowIndex, rowIndex);

                    element.BorderColor = Color.DarkOrange;
                    element.BorderInnerColor = Color.OrangeRed;
                }
                else
                {
                    element.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local);
                    element.ResetValue(LightVisualElement.BorderInnerColorProperty, ValueResetFlags.Local);
                }
            }

            string text = RadMenuInsertTableItem.HeaderText;

            if (currentColumnIndex >= 0 && currentRowIndex >= 0)
            {
                text = String.Format("{0}x{1}", currentColumnIndex + 1, currentRowIndex + 1);
            }

            this.header.Text = text;
        }

        #endregion

        #region Layout

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RadDropDownMenuLayout menuLayout = this.Parent as RadDropDownMenuLayout;
            float x = Math.Max(menuLayout.LeftColumnWidth, menuLayout.LeftColumnMinWidth) + menuLayout.LeftColumnMaxPadding;

            SizeF size = finalSize;
            size.Width -= x;

            RectangleF finalRect = new RectangleF(new PointF(x, 0), size);

            this.stackLayout.Arrange(finalRect);
            return finalSize;
        }

        #endregion
    }
}
