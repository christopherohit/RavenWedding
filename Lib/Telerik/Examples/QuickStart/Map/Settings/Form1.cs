using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;

namespace Telerik.Examples.WinControls.Map.Settings
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupSettingsControls();
            this.SetupProviders();
            this.SetupLegend();
        }

        private void SetupProviders()
        {
            BingRestMapProvider bingProvider = new BingRestMapProvider();
            bingProvider.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            bingProvider.ImagerySet = ImagerySet.Road;
            bingProvider.UseSession = true;
            bingProvider.BingKey = Properties.Resources.BingKey;
            bingProvider.InitializationComplete += delegate (object sender, EventArgs e)
            {
                this.radMap1.BringIntoView(new PointG(49d, 10d), 5);
            };

            this.radMap1.MapElement.Providers.Add(bingProvider);
        }

        private void SetupLegend()
        {
            this.radMap1.MapElement.LegendElement.TitleElement.Text = "Legend";
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("10", Color.FromArgb(227, 242, 253)));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("100", Color.FromArgb(144, 202, 249)));
            this.radMap1.MapElement.LegendElement.ItemStackElement.Children.Add(new MapLegendItemElement("1000", Color.FromArgb(66, 165, 245)));
        }

        private void radCheckBoxShowSearchBar_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMap1.ShowSearchBar = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxShowLegend_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMap1.ShowLegend = args.ToggleState == ToggleState.On;

            this.radGroupBoxLegendSettings.Enabled = this.radMap1.ShowLegend;
        }

        private void radCheckBoxShowNavigationBar_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMap1.ShowNavigationBar = args.ToggleState == ToggleState.On;

            this.radGroupBoxNavigationBarSettings.Enabled = this.radMap1.ShowNavigationBar;
        }

        private void radCheckBoxShowScaleIndicator_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMap1.ShowScaleIndicator = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxShowMiniMap_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radMap1.ShowMiniMap = args.ToggleState == ToggleState.On;

            this.radGroupBoxMinimapSettings.Enabled = this.radMap1.ShowMiniMap;
        }

        private void radRadioButtonVertical_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.radMap1.MapElement.LegendElement.Orientation = Orientation.Vertical;
            }
            else
            {
                this.radMap1.MapElement.LegendElement.Orientation = Orientation.Horizontal;
            }
        }

        private void radDropDownListNavBarLocation_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radMap1.MapElement.NavigationBarLocation = (MapNavigationBarLocation)this.radDropDownListNavBarLocation.SelectedItem.Value;
        }

        private void radDropDownListMinimapMode_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radMap1.MapElement.MiniMapElement.MiniMapMode = (MiniMapMode)this.radDropDownListMinimapMode.SelectedItem.Value;
            this.radSpinEditorZoomOffset.Enabled = this.radMap1.MapElement.MiniMapElement.MiniMapMode == MiniMapMode.OffsetZoom;
        }

        private void radSpinEditorZoomOffset_ValueChanged(object sender, EventArgs e)
        {
            this.radMap1.MapElement.MiniMapElement.ZoomOffset = (int)this.radSpinEditorZoomOffset.Value;
        }

        private void SetupSettingsControls()
        {
            this.radDropDownListNavBarLocation.Items.Add(new RadListDataItem("Top right", MapNavigationBarLocation.TopRight));
            this.radDropDownListNavBarLocation.Items.Add(new RadListDataItem("Top left", MapNavigationBarLocation.TopLeft));
            this.radDropDownListNavBarLocation.Items.Add(new RadListDataItem("Bottom left", MapNavigationBarLocation.BottomLeft));
            this.radDropDownListNavBarLocation.Items.Add(new RadListDataItem("Bottom center", MapNavigationBarLocation.BottomCenter));
            this.radDropDownListNavBarLocation.Items.Add(new RadListDataItem("Bottom right", MapNavigationBarLocation.BottomRight));

            this.radDropDownListNavBarLocation.SelectedIndex = this.radDropDownListNavBarLocation.Items.Count - 1;

            this.radDropDownListMinimapMode.Items.Add(new RadListDataItem("Whole world", MiniMapMode.WholeWorld));
            this.radDropDownListMinimapMode.Items.Add(new RadListDataItem("Static zoom", MiniMapMode.StaticZoom));
            this.radDropDownListMinimapMode.Items.Add(new RadListDataItem("Offset zoom", MiniMapMode.OffsetZoom));

            this.radDropDownListMinimapMode.SelectedIndex = 0;
        }
    }
}
