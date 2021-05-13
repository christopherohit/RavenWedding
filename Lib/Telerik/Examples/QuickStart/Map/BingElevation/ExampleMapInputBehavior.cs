using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.BingElevation
{
    public class ExampleMapInputBehavior : MapInputBehavior
    {
        public override void OnDoubleClick(EventArgs e)
        {
            MouseEventArgs args = e as MouseEventArgs;

            PointL point = new PointL(args.X - this.MapElement.PanOffset.Width, args.Y - this.MapElement.PanOffset.Height);
            PointG location = MapTileSystemHelper.PixelXYToLatLong(point.X, point.Y, this.MapElement.ZoomLevel);

            while (location.Longitude > 180)
            {
                location.Longitude -= 360;
            }

            MapPin pin = this.MapElement.Layers["Pins"].HitTest(location) as MapPin;

            if (pin != null)
            {
                this.MapElement.Layers["Pins"].Remove(pin);

                return;
            }

            pin = new MapPin(location);
            this.MapElement.Layers["Pins"].Add(pin);
        }
    }
}
