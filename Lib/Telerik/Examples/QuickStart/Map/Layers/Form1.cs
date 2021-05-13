using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;

namespace Telerik.Examples.WinControls.Map.Layers
{
    public partial class Form1 : ExamplesForm
    {
        private Dictionary<string, Color> colors = new Dictionary<string, Color>();
        private Font calloutFont;

        public Form1()
        {
            InitializeComponent();

            this.calloutFont = new Font(this.radMap1.Font.FontFamily, 10.5f);

            this.SetupProviders();
            this.SetupLayers();
            this.SetupData();
            this.SetupLegend();
        }

        private void SetupProviders()
        {
            BingRestMapProvider bingProvider = new BingRestMapProvider();
            bingProvider.ImagerySet = ImagerySet.Road;
            bingProvider.UseSession = true;
            bingProvider.BingKey = Properties.Resources.BingKey;

            bingProvider.InitializationComplete += delegate(object sender, EventArgs e)
            {
                this.radMap1.BringIntoView(new PointG(40d, -99d), 4);
            };

            this.radMap1.MapElement.Providers.Add(bingProvider);
        }

        private void SetupLayers()
        {
            MapLayer nflLayer = new MapLayer("NFL");
            this.radMap1.Layers.Add(nflLayer);
            MapLayer nhlLayer = new MapLayer("NHL");
            this.radMap1.Layers.Add(nhlLayer);
            MapLayer nbaLayer = new MapLayer("NBA");
            this.radMap1.Layers.Add(nbaLayer);
            MapLayer mlbLayer = new MapLayer("MLB");
            this.radMap1.Layers.Add(mlbLayer);
            MapLayer calloutLayer = new MapLayer("Callout");
            this.radMap1.Layers.Add(calloutLayer);
        }

        private void SetupLegend()
        {
            this.radMap1.MapElement.LegendElement.TitleElement.Text = "Leagues";
            this.radMap1.MapElement.LegendElement.SubtitleElement.Text = "Click to show or hide";
            this.radMap1.MapElement.LegendElement.Orientation = Orientation.Horizontal;

            foreach (KeyValuePair<string, Color> teamData in this.colors)
            {
                MapLegendItemElement legendItem = new MapLegendItemElement(teamData.Key, teamData.Value);
                legendItem.TextElement.DrawText = false;
                legendItem.ColorElement.BorderColor = teamData.Value;
                legendItem.ColorElement.DrawFill = false;
                legendItem.ColorElement.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(teamData.Key);
                this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(legendItem);
            }
        }

        private void SetupData()
        {
            this.colors.Add("NFL", Color.FromArgb(0, 160, 23));
            this.colors.Add("NHL", Color.FromArgb(36, 30, 32));
            this.colors.Add("NBA", Color.FromArgb(237, 23, 75));
            this.colors.Add("MLB", Color.FromArgb(0, 69, 132));

            foreach (SportTeamInfo teamInfo in SportTeamsDataModel.GetNflData())
            {
                MapPin element = new MapPin(teamInfo.Location);
                element.Text = string.Format("{0} {1}", teamInfo.City, teamInfo.Name);
                element.BackColor = this.colors["NFL"];
                element.Tag = teamInfo;
                this.radMap1.Layers["NFL"].Add(element);
            }

            foreach (SportTeamInfo teamInfo in SportTeamsDataModel.GetNhlData())
            {
                MapPin element = new MapPin(teamInfo.Location);                
                element.Text = string.Format("{0} {1}", teamInfo.City, teamInfo.Name);
                element.BackColor = this.colors["NHL"];
                element.Tag = teamInfo;
                this.radMap1.Layers["NHL"].Add(element);
            }

            foreach (SportTeamInfo teamInfo in SportTeamsDataModel.GetNbaData())
            {
                MapPin element = new MapPin(teamInfo.Location);
                element.Text = string.Format("{0} {1}", teamInfo.City, teamInfo.Name);
                element.BackColor = this.colors["NBA"];
                element.Tag = teamInfo;
                this.radMap1.Layers["NBA"].Add(element);
            }

            foreach (SportTeamInfo teamInfo in SportTeamsDataModel.GetMlbData())
            {
                MapPin element = new MapPin(teamInfo.Location);
                element.Text = string.Format("{0} {1}", teamInfo.City, teamInfo.Name);
                element.BackColor = this.colors["MLB"];
                element.Tag = teamInfo;
                this.radMap1.Layers["MLB"].Add(element);
            }
        }

        private void radMap1_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = e as MouseEventArgs;
            this.radMap1.Layers["Callout"].Clear();

            PointL point = new PointL(args.X - this.radMap1.MapElement.PanOffset.Width, args.Y - this.radMap1.MapElement.PanOffset.Height);
            MapPin pin = this.radMap1.Layers.HitTest(point) as MapPin;

            if (pin != null)
            {
                SportTeamInfo teamInfo = pin.Tag as SportTeamInfo;
                MapCallout callout = new MapCallout(pin);
                callout.Font = this.calloutFont;
                callout.ForeColor = Color.FromArgb(68, 68, 68);
                callout.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(pin.Layer.Name + teamInfo.Name.Replace(" ", ""));
                callout.Text = string.Format("{0} {1}\n{2}\n{3}", teamInfo.City, teamInfo.Name, teamInfo.Arena, pin.Layer.Name);
                this.radMap1.Layers["Callout"].Add(callout);

                return;
            }

            MapLegendItemElement item = this.radMap1.ElementTree.GetElementAtPoint<MapLegendItemElement>(args.Location);

            if (item != null)
            {
                item.Enabled = this.radMap1.Layers[item.TextElement.Text].IsVisible ^= true;
            }
        }
    }
}
