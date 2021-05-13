using System;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using Telerik.WinControls;
using System.Windows.Forms;
using System.Drawing;

namespace Telerik.Examples.WinControls.ChartView.Appearance
{
    public class PaletteListVisualItem : RadListVisualItem
    {
        LightVisualElement[] boxes = new LightVisualElement[8];

        static PaletteListVisualItem()
        {
            RadListVisualItem.SynchronizationProperties.Add(PaletteListDataItem.PaletteProperty);
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadListVisualItem);
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            BoxLayout boxLayout = new BoxLayout();

            StackLayoutPanel stack = new StackLayoutPanel();
            stack.Orientation = Orientation.Horizontal;
            stack.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            stack.StretchHorizontally = false;
            stack.SetValue(BoxLayout.StripPositionProperty, BoxLayout.StripPosition.Last);

            for (int i = 0; i < 8; i++)
            {
                LightVisualElement element = new LightVisualElement();
                stack.Children.Add(element);

                element.MinSize = new Size(13, 0);
                element.DrawFill = true;
                element.GradientStyle = GradientStyles.Solid;
                element.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);

                element.DrawBorder = false;
                element.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
                element.BorderLeftWidth = 0;
                element.BorderLeftColor = Color.White;
                element.BorderRightColor = Color.White;
                element.BorderTopColor = Color.White;
                element.BorderBottomColor = Color.White;
                if (i == 0)
                {
                    element.BorderLeftWidth = 1;
                    element.MinSize = new Size(14, 10);
                }
                boxes[i] = element;
            }

            boxLayout.Children.Add(stack);
            this.Children.Add(boxLayout);
        }

        protected override void PropertySynchronized(RadProperty property)
        {
            PaletteListDataItem dataItem = (PaletteListDataItem)this.Data;
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].BackColor = dataItem.Palette.GlobalEntries[i].Fill;
            }
        }
    }
}
