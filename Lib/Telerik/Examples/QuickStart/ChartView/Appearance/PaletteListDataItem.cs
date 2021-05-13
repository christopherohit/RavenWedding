using System;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ChartView.Appearance
{
    public class PaletteListDataItem : RadListDataItem
    {
        public static readonly RadProperty PaletteProperty = RadProperty.Register("Palette", typeof(ChartPalette), typeof(PaletteListDataItem), new RadElementPropertyMetadata(false));

        public ChartPalette Palette
        {
            get
            {
                return (ChartPalette)this.GetValue(PaletteListDataItem.PaletteProperty);
            }
            set
            {
                this.SetValue(PaletteListDataItem.PaletteProperty, value);
            }
        }
    }
}
