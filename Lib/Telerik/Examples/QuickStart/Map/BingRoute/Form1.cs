using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;

namespace Telerik.Examples.WinControls.Map.BingRoute
{
    public partial class Form1 : ExamplesForm
    {
        private MapPin currentPositionPin;

        public Form1()
        {
            InitializeComponent();

            this.SetupOptions();
            this.SetupProviders();
            this.SetupLayer();
        }

        private void SetupOptions()
        {
            this.radDropDownListUnits.Items.Add(new RadListDataItem("Kilometers", DistanceUnit.Kilometer));
            this.radDropDownListUnits.Items.Add(new RadListDataItem("Miles", DistanceUnit.Mile));

            this.radDropDownListMode.Items.Add(new RadListDataItem("Driving", TravelMode.Driving));
            this.radDropDownListMode.Items.Add(new RadListDataItem("Walking", TravelMode.Walking));

            this.radDropDownListOptimize.Items.Add(new RadListDataItem("Time", RouteOptimization.Time));
            this.radDropDownListOptimize.Items.Add(new RadListDataItem("Distance", RouteOptimization.Distance));
            this.radDropDownListOptimize.Items.Add(new RadListDataItem("Time (avoid closures)", RouteOptimization.TimeAvoidClosure));
            this.radDropDownListOptimize.Items.Add(new RadListDataItem("Time (acount for traffic)", RouteOptimization.TimeWithTraffic));

            this.radDropDownListAvoid.Items.Add(new RadListDataItem("None", RouteAvoidance.None));
            this.radDropDownListAvoid.Items.Add(new RadListDataItem("Highways", RouteAvoidance.Highways));
            this.radDropDownListAvoid.Items.Add(new RadListDataItem("Tolls", RouteAvoidance.Tolls));
            this.radDropDownListAvoid.Items.Add(new RadListDataItem("Minimize Highways", RouteAvoidance.MinimizeHighways));
            this.radDropDownListAvoid.Items.Add(new RadListDataItem("Minimize Tolls", RouteAvoidance.MinimizeTolls));

            this.radDropDownListUnits.SelectedIndex = this.radDropDownListMode.SelectedIndex = this.radDropDownListOptimize.SelectedIndex = this.radDropDownListAvoid.SelectedIndex = 0;
        }

        private void SetupProviders()
        {
            BingRestMapProvider bingProvider = new BingRestMapProvider();
            bingProvider.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            bingProvider.UseSession = true;
            bingProvider.BingKey = Properties.Resources.BingKey;
            bingProvider.InitializationComplete += delegate
            {
                RouteRequest request = new RouteRequest();
                request.DistanceUnit = DistanceUnit.Kilometer;
                request.Options.Mode = TravelMode.Driving;
                request.Options.Optimization = RouteOptimization.Time;
                request.Options.RouteAttributes = RouteAttributes.RoutePath;
                request.Options.RouteAvoidance = RouteAvoidance.None;
                this.radTextBoxStartPoint.Text = "Los Angelis, USA";
                this.radTextBoxEndPoint.Text= "San Francisco, USA";
                request.RoutePoints.Add(new Waypoint(this.radTextBoxStartPoint.Text));
                request.RoutePoints.Add(new Waypoint(this.radTextBoxEndPoint.Text));

                bingProvider.CalculateRouteAsync(request);
            };

            this.radMap1.MapElement.Providers.Add(bingProvider);
            
            bingProvider.CalculateRouteCompleted += BingProvider_CalculateRouteCompleted;
            bingProvider.CalculateRouteError += BingProvider_CalculateRouteError;
        }

        private void SetupLayer()
        {
            MapLayer pinsLayer = new MapLayer("Route");
            this.radMap1.Layers.Add(pinsLayer);
        }

        private void radButtonCalculateRoute_Click(object sender, EventArgs e)
        {
            if (TelerikHelper.StringIsNullOrWhiteSpace(this.radTextBoxStartPoint.Text))
            {
                RadMessageBox.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show("Please enter valid start point.");
                this.radTextBoxStartPoint.Focus();

                return;
            }

            if (TelerikHelper.StringIsNullOrWhiteSpace(this.radTextBoxEndPoint.Text))
            {
                RadMessageBox.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show("Please enter valid end point.");
                this.radTextBoxEndPoint.Focus();

                return;
            }

            RouteRequest request = new RouteRequest();
            request.DistanceUnit = (DistanceUnit)this.radDropDownListUnits.SelectedItem.Value;
            request.Options.Mode = (TravelMode)this.radDropDownListMode.SelectedItem.Value;
            request.Options.RouteAttributes = RouteAttributes.RoutePath;

            if (request.Options.Mode == TravelMode.Driving)
            {
                request.Options.Optimization = (RouteOptimization)this.radDropDownListOptimize.SelectedItem.Value;
                request.Options.RouteAvoidance = (RouteAvoidance)this.radDropDownListAvoid.SelectedItem.Value; 
            }

            request.RoutePoints.Add(new Waypoint(this.radTextBoxStartPoint.Text));
            request.RoutePoints.Add(new Waypoint(this.radTextBoxEndPoint.Text));

            IMapRouteProvider routeProvider = this.radMap1.Providers[0] as IMapRouteProvider;
            routeProvider.CalculateRouteAsync(request);
        }

        private void BingProvider_CalculateRouteCompleted(object sender, RoutingCompletedEventArgs e)
        {
            Route route = e.Routes[0];
            List<PointG> points = new List<PointG>();

            foreach (double[] coordinatePair in route.RoutePath.Line.Coordinates)
            {
                PointG point = new PointG(coordinatePair[0], coordinatePair[1]);
                points.Add(point);
            }

            this.radMap1.Layers["Route"].Clear();

            RectangleG boundingRectangle = new RectangleG(route.BBox[2], route.BBox[1], route.BBox[0], route.BBox[3]);
            MapRoute routeElement = new MapRoute(points, boundingRectangle);
            routeElement.BorderColor = Color.FromArgb(11, 195, 197);
            routeElement.BorderWidth = 3;
            MapPin start = new MapPin(new PointG(route.RouteLegs[0].ActualStart.Coordinates[0], route.RouteLegs[0].ActualStart.Coordinates[1]));
            start.BackColor = Color.FromArgb(11, 195, 197);
            MapPin end = new MapPin(new PointG(route.RouteLegs[route.RouteLegs.Length - 1].ActualEnd.Coordinates[0], route.RouteLegs[route.RouteLegs.Length - 1].ActualEnd.Coordinates[1]));
            end.BackColor = Color.FromArgb(11, 195, 197);

            this.currentPositionPin = new MapPin(start.Location);
            currentPositionPin.BackColor = Color.White;
            currentPositionPin.BorderColor = Color.FromArgb(11, 195, 197);

            this.radMap1.MapElement.Layers["Route"].Add(routeElement);
            this.radMap1.MapElement.Layers["Route"].Add(start);
            this.radMap1.MapElement.Layers["Route"].Add(end);
            this.radMap1.MapElement.Layers["Route"].Add(currentPositionPin);

            this.radListView1.DisplayMember = "Instruction.Text";
            this.radListView1.ValueMember = "ManeuverPoint";
            this.radListView1.DataSource = route.RouteLegs[0].ItineraryItems;
            
            this.radMap1.BringIntoView(boundingRectangle);
            this.radMap1.Zoom(this.radMap1.MapElement.ZoomLevel - 1);
            this.radSplitContainer1.SplitPanels[1].Collapsed = false;
        }

        private void BingProvider_CalculateRouteError(object sender, CalculateRouteErrorEventArgs e)
        {
            RadMessageBox.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(e.Error.Message);
        }

        private void radListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.radListView1.SelectedItem != null)
            {
                ItineraryItem item = this.radListView1.SelectedItem.DataBoundItem as ItineraryItem;

                if (item != null)
                {
                    this.currentPositionPin.Location = new PointG(item.ManeuverPoint.Coordinates[0], item.ManeuverPoint.Coordinates[1]);
                    this.radMap1.BringIntoView(this.currentPositionPin.Location);
                }
            }
        }

        private void radDropDownListMode_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            bool driving = (TravelMode)this.radDropDownListMode.SelectedItem.Value == TravelMode.Driving;

            this.radLabelAvoid.Enabled = driving;
            this.radDropDownListAvoid.Enabled = driving;
            this.radLabelOptimize.Enabled = driving;
            this.radDropDownListOptimize.Enabled = driving;
        }
    }   
}
