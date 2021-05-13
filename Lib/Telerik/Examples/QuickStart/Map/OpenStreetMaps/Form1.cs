using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.OpenStreetMaps
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupProviders();
            this.SetupLayer();
            this.SetupData();
        }

        private void SetupProviders()
        {
            OpenStreetMapProvider osmProvider = new OpenStreetMapProvider();
            MapTileDownloader tileDownloader = osmProvider.TileDownloader as MapTileDownloader;
            tileDownloader.WebHeaders.Add(System.Net.HttpRequestHeader.UserAgent, "Telerik Map Example");
            osmProvider.InitializationComplete += OsmProvider_InitializationComplete;
            
            this.radMap1.MapElement.Providers.Add(osmProvider);
        }
               
        private void OsmProvider_InitializationComplete(object sender, System.EventArgs e)
        {
            this.radMap1.Pan(new SizeL(-240, -440));
        }

        private void SetupLayer()
        {
            MapLayer pinsLayer = new MapLayer("Pins");
            this.radMap1.Layers.Add(pinsLayer);
        }

        private void SetupData()
        {
            this.radDropDownListClusterStrategy.Items.Add(new RadListDataItem("Element cluster strategy", new ElementClusterStrategy()));
            this.radDropDownListClusterStrategy.Items.Add(new RadListDataItem("Distance cluster strategy", new DistanceClusterStrategy()));
            this.radDropDownListClusterStrategy.SelectedIndex = 0;

            this.radMap1.BeginUpdate();

            using (StringReader reader = new StringReader(Properties.Resources.PhotoSpots))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] coordinates = line.Split(',');
                    double latitude = double.Parse(coordinates[0], CultureInfo.InvariantCulture);
                    double longitude = double.Parse(coordinates[1], CultureInfo.InvariantCulture);

                    MapPin pin = new MapPin(new PointG(latitude, longitude));
                    pin.BackColor = Color.FromArgb(37, 160, 218);
                    this.radMap1.Layers["Pins"].Add(pin);
                }
            }

            this.radMap1.EndUpdate();
        }
        
        private void radDropDownListClusterStrategy_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position > -1)
            {
                this.radMap1.Layers[0].ClusterStrategy = (IMapClusterStrategy)this.radDropDownListClusterStrategy.SelectedItem.Value;
            }
        }

        private void radSpinEditorDistance_ValueChanged(object sender, System.EventArgs e)
        {
            this.radMap1.Layers["Pins"].ClusterDistance = (long)this.radSpinEditorDistance.Value;
        }
    }   
}
