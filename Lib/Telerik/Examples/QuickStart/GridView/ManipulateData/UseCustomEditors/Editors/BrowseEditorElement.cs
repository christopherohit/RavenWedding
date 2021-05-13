using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
{
    public class BrowseEditorElement : LightVisualElement
    {
        RadTextBoxItem textBox;
        RadButtonElement button;

        public RadTextBoxItem TextBox
        {
            get
            {
                return this.textBox;
            }
        }

        public RadButtonElement Button
        {
            get
            {
                return this.button;
            }
        }

        protected override void CreateChildElements()
        {
            textBox = new RadTextBoxItem();
            textBox.RouteMessages = false;
            button = new RadButtonElement("...");
            button.Padding = new Padding(2, 0, 2, 0);
            this.Children.Add(textBox);
            this.Children.Add(button);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RectangleF clientRect = GetClientRectangle(finalSize);
            RectangleF buttonRect = new RectangleF(clientRect.Right - button.DesiredSize.Width, clientRect.Top,
                button.DesiredSize.Width, clientRect.Height);
            RectangleF textRect = new RectangleF(clientRect.Left, clientRect.Top + (clientRect.Height - textBox.DesiredSize.Height) / 2,
                buttonRect.Left - clientRect.Left - 2, textBox.DesiredSize.Height);

            foreach (RadElement element in this.Children)
            {
                if (element == this.textBox)
                {
                    element.Arrange(textRect);
                }
                else if (element == this.button)
                {
                    element.Arrange(buttonRect);
                }
                else
                {
                    ArrangeElement(element, finalSize);
                }
            }

            return finalSize;
        }
    }
}
