using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupProviders();
            this.SetupLayers();
            this.SetupData();

            this.radMap1.MapElement.ViewportChanged += MapElement_ViewportChanged;
            this.radMap1.Click += RadMap1_Click;
            this.radMap1.Zoom(2);
        }

        private void SetupProviders()
        {
            BingRestMapProvider bingProvider = new BingRestMapProvider();
            bingProvider.BingKey = Properties.Resources.BingKey;
            bingProvider.UseSession = true;
            
            this.radMap1.MapElement.Providers.Add(bingProvider);
        }
        
        private void SetupLayers()
        {
            MapLayer pathLayer = new MapLayer("Path");
            this.radMap1.Layers.Add(pathLayer);

            MapLayer pinsLayer = new MapLayer("Pins");
            this.radMap1.Layers.Add(pinsLayer);

            MapLayer labelsLayer = new MapLayer("Labels");
            labelsLayer.IsVisible = false;
            this.radMap1.Layers.Add(labelsLayer);

            MapLayer calloutLayer = new MapLayer("Callout");
            this.radMap1.Layers.Add(calloutLayer);
        }

        private void SetupData()
        {
            List<TripCity> data = GetData();

            for (int i = 0; i < data.Count - 1; i++)
            {
                this.radMap1.Layers["Path"].Add(this.CreateTripSegment(data[i].Location, data[i + 1].Location, data[i].IsFlight));
            }

            this.radMap1.Layers["Path"].Add(this.CreateTripSegment(data[data.Count - 1].Location, new PointG(data[0].Location.Latitude, data[0].Location.Longitude + 360), data[data.Count - 1].IsFlight));

            ResourceManager myManager = new ResourceManager(typeof(Form1));

            for (int i = 0; i < data.Count; i++)
            {
                MapPin pin = new MapPin(data[i].Location);
                pin.Tag = data[i];
                pin.ToolTipText = data[i].Name;
                pin.BackColor = Color.FromArgb(11, 195, 197);
                this.radMap1.Layers["Pins"].Add(pin);

                MapLabel label = new MapLabel(data[i].Location, string.Format("{0}. {1}", data[i].TripStop, data[i].Name));
                label.BackColor = Color.FromArgb(180, 11, 195, 197);
                label.BorderColor = Color.White;
                label.ForeColor = Color.White;
                label.Image = (Image)myManager.GetObject(data[i].IsFlight ? "plane_16" : "bus_16");
                this.radMap1.Layers["Labels"].Add(label);
            }
        }

        private List<TripCity> GetData()
        {
            List<TripCity> data = new List<TripCity>();
            data.Add(new TripCity("Seattle", new PointG(47.6149425, -122.4059451), 1, true));
            data.Add(new TripCity("New York", new PointG(40.7058254, -74.1180854), 2, true));
            data.Add(new TripCity("London", new PointG(51.5287718, -0.2416795), 3, false));
            data.Add(new TripCity("Paris", new PointG(48.8589507, 2.2775177), 4, false));
            data.Add(new TripCity("Berlin", new PointG(52.5076682, 13.286064), 5, true));
            data.Add(new TripCity("Sofia", new PointG(42.688606, 23.416172), 6, true));
            data.Add(new TripCity("Cairo", new PointG(30.0595581, 31.223445), 7, true));
            data.Add(new TripCity("Mumbai", new PointG(19.0830943, 72.741121), 8, false));
            data.Add(new TripCity("New Delhi", new PointG(28.5274228, 77.1389454), 9, true));
            data.Add(new TripCity("Bangkok", new PointG(13.7248945, 100.4930278), 10, false));
            data.Add(new TripCity("Hanoi", new PointG(21.0227358, 105.819454), 11, true));
            data.Add(new TripCity("Tokyo", new PointG(35.6734622, 139.6403485), 12, true));

            return data;
        }

        private MapVisualElement CreateTripSegment(PointG start, PointG end, bool isFlight)
        {
            if (isFlight)
            {
                MapAirRoute airRoute = new MapAirRoute(start, end);
                airRoute.BorderColor = Color.FromArgb(11, 195, 197);
                airRoute.BorderWidth = 3;
                airRoute.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                airRoute.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                return airRoute;
            }

            MapRoute landRoute = new MapRoute(start, end);
            landRoute.BorderColor = Color.FromArgb(11, 195, 197);
            landRoute.BorderWidth = 3;
            landRoute.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            return landRoute;
        }

        private void MapElement_ViewportChanged(object sender, ViewportChangedEventArgs e)
        {
            if ((e.Action & ViewportChangeAction.Zoom) != 0)
            {
                this.radMap1.Layers["Pins"].IsVisible = this.radMap1.MapElement.ZoomLevel <= 3;
                this.radMap1.Layers["Callout"].IsVisible = this.radMap1.MapElement.ZoomLevel <= 3;
                this.radMap1.Layers["Labels"].IsVisible = this.radMap1.MapElement.ZoomLevel > 3;
            }
        }

        private void RadMap1_Click(object sender, System.EventArgs e)
        {
            MouseEventArgs args = e as MouseEventArgs;
            this.radMap1.Layers["Callout"].Clear();

            PointL point = new PointL(args.X - this.radMap1.MapElement.PanOffset.Width, args.Y - this.radMap1.MapElement.PanOffset.Height);
            MapPin pin = this.radMap1.Layers.HitTest(point) as MapPin;

            if (pin != null)
            {
                TripCity tripCity = pin.Tag as TripCity;
                MapCallout callout = new MapCallout(pin);
                callout.ForeColor = Color.White;
                callout.BackColor = Color.FromArgb(11, 195, 197);
                callout.BorderColor = Color.White;
                ResourceManager myManager = new ResourceManager(typeof(Form1));
                callout.Image = (Image)myManager.GetObject(tripCity.IsFlight ? "plane_16" : "bus_16");
                callout.Text = string.Format("Trip stop: {0}\nCity: {1}\nNext trip by {2}", tripCity.TripStop, tripCity.Name, tripCity.IsFlight ? "Plane" : "Train");
                this.radMap1.Layers["Callout"].Add(callout);
            }
        }
    }   
}
