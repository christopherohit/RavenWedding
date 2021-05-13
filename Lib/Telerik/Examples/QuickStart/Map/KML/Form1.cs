using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.KML
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupLayer();
            this.SetupData();
            this.SetupLegend();
            this.SetupProvider();
        }

        private void SetupProvider()
        {
            BingRestMapProvider bingProvider = new BingRestMapProvider();
            bingProvider.BingKey = Properties.Resources.BingKey;
            bingProvider.UseSession = true;
            bingProvider.InitializationComplete += BingProvider_InitializationComplete;

            this.radMap1.Providers.Add(bingProvider);
        }

        private void BingProvider_InitializationComplete(object sender, EventArgs e)
        {
            List<PointG> locations = new List<PointG>();

            foreach (MapVisualElement el in this.radMap1.Layers["Slopes"].Overlays)
            {
                locations.Add(el.Location);
            }

            this.radMap1.BringIntoView(RectangleG.GetBoundingRectangle(locations));
            this.radMap1.Pan(new SizeL(-200, -50));
        }

        private void SetupLayer()
        {
            MapLayer slopesLayer = new MapLayer("Slopes");
            this.radMap1.Layers.Add(slopesLayer);
        }

        private void SetupData()
        {
            using (FileStream fs = new FileStream("..\\Resources\\adelboden.kml", FileMode.Open, FileAccess.Read))
            {
                List<MapVisualElement> elements = KmlReader.Read(fs);
                this.radMap1.Layers["Slopes"].AddRange(elements);
            }
        }

        private void SetupLegend()
        {
            this.radMap1.MapElement.LegendElement.TitleElement.Text = "LEGEND";

            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("Lift", Color.Red));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("Downhill Easy", Color.Lime));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("Downhill Intermediate", Color.Blue));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("Downhill Advanced", Color.Black));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("Downhill Unrated", Color.Violet));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("Walking path ", Color.Brown));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("River", Color.LightBlue));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("Bus route", Color.Yellow));
        }
    }
}
