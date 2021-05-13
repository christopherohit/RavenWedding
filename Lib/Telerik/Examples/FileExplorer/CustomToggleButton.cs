using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using System.Drawing;

namespace FileExplorer
{
    class CustomToggleButton : RadToggleButtonElement
    {

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
         
        }

        protected override void OnToggleStateChanged(StateChangedEventArgs e)
        {
            if (e.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                this.ButtonFillElement.ResetValue(FillPrimitive.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                this.ButtonFillElement.ResetValue(FillPrimitive.BackColor2Property, Telerik.WinControls.ValueResetFlags.Local);
                this.ButtonFillElement.ResetValue(FillPrimitive.BackColor3Property, Telerik.WinControls.ValueResetFlags.Local);
                this.ButtonFillElement.ResetValue(FillPrimitive.BackColor4Property, Telerik.WinControls.ValueResetFlags.Local);
            }
            else
            {
                this.ButtonFillElement.BackColor = Color.Transparent;
                this.ButtonFillElement.BackColor2 = Color.Transparent;
                this.ButtonFillElement.BackColor3 = Color.Transparent;
                this.ButtonFillElement.BackColor4 = Color.Transparent;
                this.BorderElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            base.OnToggleStateChanged(e);
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadToggleButtonElement);
            }
        }
    }
}
