using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls.Primitives;

namespace FileExplorer
{
    class CustomButton : RadButtonElement
    {
        protected override void OnMouseEnter(EventArgs e)
        {
            this.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.ButtonFillElement.ResetValue(FillPrimitive.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
            this.ButtonFillElement.ResetValue(FillPrimitive.BackColor2Property, Telerik.WinControls.ValueResetFlags.Local);
            this.ButtonFillElement.ResetValue(FillPrimitive.BackColor3Property, Telerik.WinControls.ValueResetFlags.Local);
            this.ButtonFillElement.ResetValue(FillPrimitive.BackColor4Property, Telerik.WinControls.ValueResetFlags.Local);
            base.OnMouseEnter(e);
            Console.WriteLine("reset");
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ButtonFillElement.BackColor = Color.Transparent;
            this.ButtonFillElement.BackColor2 = Color.Transparent;
            this.ButtonFillElement.BackColor3 = Color.Transparent;
            this.ButtonFillElement.BackColor4 = Color.Transparent;
            this.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            base.OnMouseLeave(e);
            Console.WriteLine("transparent");
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadButtonElement);
            }
        }
    }
}
