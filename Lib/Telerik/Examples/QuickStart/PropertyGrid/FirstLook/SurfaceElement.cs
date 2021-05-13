using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Drawing;

namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
{
    public class SurfaceElement : LightVisualElement
    {
        SurfaceObject currentObject;

        public event EventHandler CurrentObjectChanged;

        public SurfaceObject CurrentObject
        {
            get
            {
                return currentObject;
            }
            set
            {
                if (currentObject != value)
                {
                    currentObject = value;
                    this.Children.Remove(currentObject);
                    this.Children.Add(currentObject);
                    if (CurrentObjectChanged != null)
                    {
                        CurrentObjectChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            foreach (SurfaceObject element in this.Children)
            {
                element.Arrange(new RectangleF(element.Offset.X, element.Offset.Y, element.DesiredSize.Width, element.DesiredSize.Height));
            }
            return finalSize;
        }
    }
}
