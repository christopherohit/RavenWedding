using System;
using System.Drawing;
using System.IO;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;

namespace Telerik.Examples.WinControls.Map.BingSearch
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupProviders();
            this.SetupLayer();
        }

        private void SetupProviders()
        {
            BingRestMapProvider bingProvider = new BingRestMapProvider();
            bingProvider.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            bingProvider.UseSession = true;
            bingProvider.BingKey = Properties.Resources.BingKey;
            bingProvider.InitializationComplete += delegate(object sender, EventArgs e)
            {
                this.radMap1.Zoom(6);
                this.radMap1.MapElement.SearchBarElement.Search("Los Angelis, USA");
            };

            this.radMap1.MapElement.Providers.Add(bingProvider);

            this.radMap1.MapElement.SearchBarElement.SearchProvider = bingProvider;
            bingProvider.SearchCompleted += BingProvider_SearchCompleted;
            bingProvider.SearchError += BingProvider_SearchError;
        }

        private void BingProvider_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            RectangleG allPoints = new RectangleG(double.MinValue, double.MaxValue, double.MaxValue, double.MinValue);
            this.radMap1.Layers["Pins"].Clear();

            foreach (Location location in e.Locations)
            {
                PointG point = new PointG(location.Point.Coordinates[0], location.Point.Coordinates[1]);
                MapPin pin = new MapPin(point);
                pin.BackColor = Color.FromArgb(11, 195, 197);
                pin.ToolTipText = location.Address.FormattedAddress;
                this.radMap1.MapElement.Layers["Pins"].Add(pin);

                MapCallout callout = new MapCallout(pin);
                callout.Text = location.Name;
                this.radMap1.MapElement.Layers["Pins"].Add(callout);

                allPoints.North = Math.Max(allPoints.North, point.Latitude);
                allPoints.South = Math.Min(allPoints.South, point.Latitude);
                allPoints.West = Math.Min(allPoints.West, point.Longitude);
                allPoints.East = Math.Max(allPoints.East, point.Longitude);
            }

            if (e.Locations.Length > 0)
            {
                if (e.Locations.Length == 1)
                {
                    this.radMap1.BringIntoView(new PointG(e.Locations[0].Point.Coordinates[0], e.Locations[0].Point.Coordinates[1]));
                }
                else
                {
                    this.radMap1.MapElement.BringIntoView(allPoints);
                    this.radMap1.Zoom(this.radMap1.MapElement.ZoomLevel - 1);
                }
            }
            else
            {
                RadMessageBox.Show("No result found for the provided search query!");
            }
        }

        private void BingProvider_SearchError(object sender, SearchErrorEventArgs e)
        {
            RadMessageBox.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(e.Error.Message);
        }

        private void SetupLayer()
        {
            MapLayer pinsLayer = new MapLayer("Pins");
            this.radMap1.Layers.Add(pinsLayer);
        }
    }   
}
