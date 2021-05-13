using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RichTextEditorRibbonUI
{
    public class ListViewMenuItem : RadMenuItemBase
    {
        #region Fields

        private RadListViewElement listViewElement;

        #endregion

        #region Constructor & Initialization

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.ShouldHandleMouseInput = true;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.listViewElement = new RadListViewElement();
            this.listViewElement.NotifyParentOnMouseInput = true;
            this.listViewElement.ViewType = ListViewType.IconsView;
            this.listViewElement.SelectLastAddedItem = false;
            IconListViewElement iconsView = this.listViewElement.ViewElement as IconListViewElement;
            iconsView.ItemSize = new System.Drawing.Size(100, 100);
            iconsView.MinSize = new System.Drawing.Size(320, 200);
            iconsView.MaxSize = new System.Drawing.Size(320, 200);

            this.Children.Add(listViewElement);
        }

        #endregion

        #region Properties

        public RadListViewElement ListViewElement
        {
            get { return listViewElement; }
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(RadMenuItem); }
        }

        #endregion

        #region Event handlers

        protected override void OnBubbleEvent(Telerik.WinControls.RadElement sender, Telerik.WinControls.RoutedEventArgs args)
        {
            if (args.RoutedEvent == RadElement.MouseDownEvent)
            {
                this.ListViewElement.ProcessMouseDown(args.OriginalEventArgs as MouseEventArgs);
            }
            else if (args.RoutedEvent == RadElement.MouseUpEvent)
            {
                this.ListViewElement.ProcessMouseUp(args.OriginalEventArgs as MouseEventArgs);
            }
                        
            base.OnBubbleEvent(sender, args);
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

            this.ListViewElement.Arrange(finalRect);

            return finalSize;
        }

        #endregion
    }
}
