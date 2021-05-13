using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;
using Telerik.WinControls.UI.Map.Bing;

namespace Telerik.Examples.WinControls.Map.BingElevation
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SetupLayers();
            this.SetupProviders();
            this.SetupSettingsControls();
            this.radMap1.InputBehavior = new ExampleMapInputBehavior();
        }

        private void SetupLayers()
        {
            MapLayer pinsLayer = new MapLayer("Pins");
            this.radMap1.Layers.Add(pinsLayer);

            MapLayer calloutsLayer = new MapLayer("Callouts");
            this.radMap1.Layers.Add(calloutsLayer);
        }

        private void SetupProviders()
        {
            BingRestMapProvider bingProvider = new BingRestMapProvider();
            bingProvider.UseSession = true;
            bingProvider.BingKey = Properties.Resources.BingKey;
            bingProvider.InitializationComplete += delegate
            {
                this.radMap1.BringIntoView(new RectangleG(65.256706493442579, 15.908203125, 19.890723023996898, 124.365234375));
                ElevationRequest request = new ElevationRequest();
                request.ElevationType = ElevationType.List;
                request.Points = new List<PointG>()
                {
                    new PointG(57.390087, 51.447880),
                    new PointG(48.710732, 80.891237),
                    new PointG(29.331682, 81.594362)
                };

                this.radMap1.Layers["Pins"].Clear();
                this.radMap1.Layers["Pins"].AddRange(new MapPin(request.Points[0]), new MapPin(request.Points[1]), new MapPin(request.Points[2]));

                bingProvider.CalculateElevationAsync(request);
            };

            this.radMap1.MapElement.Providers.Add(bingProvider);

            bingProvider.CalculateElevationCompleted += bingProvider_CalculateElevationCompleted;
            bingProvider.CalculateElevationError += bingProvider_CalculateElevationError;
        }

        private void SetupSettingsControls()
        {
            this.radDropDownList1.Items.Add(new RadListDataItem(ElevationType.List.ToString(), ElevationType.List));
            this.radDropDownList1.Items.Add(new RadListDataItem(ElevationType.Polyline.ToString(), ElevationType.Polyline));
            this.radDropDownList1.Items.Add(new RadListDataItem(ElevationType.Bounds.ToString(), ElevationType.Bounds));
            this.radDropDownList1.Items.Add(new RadListDataItem(ElevationType.SeaLevel.ToString(), ElevationType.SeaLevel));
            this.radDropDownList1.SelectedIndex = 0;

            this.radDropDownList1.SelectedIndexChanged += radDropDownList1_SelectedIndexChanged;
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ElevationType elevationType = (ElevationType)this.radDropDownList1.Items[e.Position].Value;

            switch (elevationType)
            {
                case ElevationType.List:
                case ElevationType.SeaLevel:
                    this.radGroupBoxBoundsSettings.Visible = false;
                    this.radGroupBoxPolylineSettings.Visible = false;
                    break;
                case ElevationType.Polyline:
                    this.radGroupBoxBoundsSettings.Visible = false;
                    this.radGroupBoxPolylineSettings.Visible = true;
                    break;
                case ElevationType.Bounds:
                    this.radGroupBoxBoundsSettings.Visible = true;
                    this.radGroupBoxPolylineSettings.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void radButtonCalculateElevations_Click(object sender, EventArgs e)
        {
            this.radMap1.Layers["Callouts"].Clear();
            ElevationType elevationType = (ElevationType)this.radDropDownList1.Items[this.radDropDownList1.SelectedIndex].Value;

            List<PointG> points = new List<PointG>();

            foreach (MapPin pin in this.radMap1.Layers["Pins"].Overlays)
            {
                points.Add(pin.Location);
            }

            if (points.Count == 0)
            {
                RadMessageBox.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show("You have to place at least one pin on the map to get elevation." + Environment.NewLine + "Double click on the map to place a pin");

                return;
            }

            if (elevationType == ElevationType.Bounds)
            {
                if (points.Count < 2)
                {
                    RadMessageBox.ThemeName = this.CurrentThemeName;
                    RadMessageBox.Show("You have to place at least two pins in order to define a bounding rectangle." + Environment.NewLine + "Double click on the map to place a pin");

                    return;
                }
            }

            ElevationRequest request = new ElevationRequest();
            request.ElevationType = elevationType;

            switch (elevationType)
            {
                case ElevationType.List:
                    request.Points = points;
                    break;
                case ElevationType.Polyline:
                    request.Points = points;
                    request.Samples = (int)this.radSpinEditorSamples.Value;
                    break;
                case ElevationType.Bounds:
                    request.Bounds = RectangleG.GetBoundingRectangle(points);
                    request.Rows = (int)this.radSpinEditorRows.Value;
                    request.Columns = (int)this.radSpinEditorColumns.Value;
                    break;
                case ElevationType.SeaLevel:
                    request.Points = points;
                    break;
            }

            IMapElevationProvider elevationProvider = this.radMap1.Providers[0] as IMapElevationProvider;
            elevationProvider.CalculateElevationAsync(request);
        }

        private void bingProvider_CalculateElevationCompleted(object sender, ElevationCompletedEventArgs e)
        {
            if (e.Elevations == null && e.SeaLevels == null)
            {
                RadMessageBox.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show("Could not retrieve elevation data." + Environment.NewLine + " Please, try again.");

                return;
            }

            ElevationType elevationType = (ElevationType)this.radDropDownList1.Items[this.radDropDownList1.SelectedIndex].Value;

            switch (elevationType)
            {
                case ElevationType.List:
                    this.HandleListElevationType(e.Elevations[0]);
                    break;
                case ElevationType.Polyline:
                    this.HandlePolylineElevationType(e.Elevations[0]);
                    break;
                case ElevationType.Bounds:
                    this.HandleBoundsElevationType(e.Elevations[0]);
                    break;
                case ElevationType.SeaLevel:
                    this.HandleSeaLevelElevationType(e.SeaLevels[0]);
                    break;
            }
        }

        private void HandleListElevationType(ElevationData elevationData)
        {
            for (int i = 0; i < this.radMap1.Layers["Pins"].Overlays.Count; i++)
            {
                MapPin pin = this.radMap1.Layers["Pins"].Overlays[i] as MapPin;

                if (pin != null)
                {
                    MapCallout callout = new MapCallout(pin);
                    callout.MaxWidth = 50;
                    callout.Text = elevationData.Elevations[i].ToString() + "m";
                    this.radMap1.Layers["Callouts"].Add(callout);
                }
            }
        }

        private void HandlePolylineElevationType(ElevationData elevationData)
        {
            List<PointG> points = new List<PointG>();

            for (int i = 0; i < this.radMap1.Layers["Pins"].Overlays.Count; i++)
            {
                MapPin pin = this.radMap1.Layers["Pins"].Overlays[i] as MapPin;

                if (pin != null)
                {
                    points.Add(pin.Location);
                }
            }

            this.radMap1.Layers["Pins"].Clear();

            MapPolyline polyline = new MapPolyline(points);
            this.radMap1.Layers["Callouts"].Add(polyline);

            List<PointG> p = this.CalculateEquidistantPointsAlongPolyline(polyline, this.radMap1.MapElement.ZoomLevel, elevationData.Elevations.Length);

            for (int i = 0; i < p.Count; i++)
            {
                MapPoint point = new MapPoint(p[i]);
                this.radMap1.Layers["Callouts"].Add(point);

                MapCallout callout = new MapCallout(point);
                callout.MaxWidth = 50;
                callout.Text = elevationData.Elevations[i].ToString() + "m";
                this.radMap1.Layers["Callouts"].Add(callout);
            }
        }

        private List<PointG> CalculateEquidistantPointsAlongPolyline(MapPolyline polyline, int zoomLevel, int numberOfPoints)
        {
            List<PointL> points = new List<PointL>();

            foreach (PointG point in polyline.Points)
            {
                points.Add(MapTileSystemHelper.LatLongToPixelXY(point, zoomLevel));
            }

            int totalDistance = 0;
            List<double> distances = new List<double>();

            for (int i = 0; i < points.Count - 1; i++)
            {
                totalDistance += (int)Math.Sqrt(Math.Pow(points[i + 1].X - points[i].X, 2) + Math.Pow(points[i + 1].Y - points[i].Y, 2));
                distances.Add(totalDistance);
            }

            List<PointL> equidistantPoints = new List<PointL>();
            double step = (double)totalDistance / (numberOfPoints - 1);
            double currentDistance = 0;

            while (currentDistance < totalDistance - 1)
            {
                int index = distances.BinarySearch(currentDistance);

                if (index < 0)
                {
                    index = ~index;
                }

                PointL p1 = points[index];
                PointL p2 = points[index + 1];
                double distance = index == 0 ? distances[index] : distances[index] - distances[index - 1];
                double dt = index == 0 ? currentDistance : currentDistance - distances[index - 1];

                double t = (double)dt / distance;
                double x = ((1d - t) * p1.X + t * p2.X);
                double y = ((1d - t) * p1.Y + t * p2.Y);

                equidistantPoints.Add(new PointL((long)Math.Round(x, MidpointRounding.AwayFromZero), (long)Math.Round(y, MidpointRounding.AwayFromZero)));
                currentDistance += step;
            }

            equidistantPoints.Add(points[points.Count - 1]);

            List<PointG> result = new List<PointG>();

            foreach (PointL point in equidistantPoints)
            {
                result.Add(MapTileSystemHelper.PixelXYToLatLong(point, zoomLevel));
            }

            return result;
        }

        private void HandleBoundsElevationType(ElevationData elevationData)
        {
            List<PointG> points = new List<PointG>();

            for (int i = 0; i < this.radMap1.Layers["Pins"].Overlays.Count; i++)
            {
                MapPin pin = this.radMap1.Layers["Pins"].Overlays[i] as MapPin;

                if (pin != null)
                {
                    points.Add(pin.Location);
                }
            }

            this.radMap1.Layers["Pins"].Clear();

            RectangleG rect = RectangleG.GetBoundingRectangle(points);
            PointG[,] p = this.CalculateEquidistantPointsInRectangle(rect, this.radMap1.MapElement.ZoomLevel, (int)this.radSpinEditorRows.Value, (int)this.radSpinEditorColumns.Value);

            int rows = p.GetLength(0);
            int flatIndex = 0;

            for (int i = p.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    MapPoint point = new MapPoint(p[i, j]);
                    this.radMap1.Layers["Callouts"].Add(point);

                    MapCallout callout = new MapCallout(point);
                    callout.MaxWidth = 50;
                    callout.Text = elevationData.Elevations[flatIndex++].ToString() + "m";
                    this.radMap1.Layers["Callouts"].Add(callout);
                }
            }
        }

        private PointG[,] CalculateEquidistantPointsInRectangle(RectangleG rect, int zoomLevel, int rows, int columns)
        {
            PointL topLeft = MapTileSystemHelper.LatLongToPixelXY(rect.North, rect.West, zoomLevel);
            PointL bottomRight = MapTileSystemHelper.LatLongToPixelXY(rect.South, rect.East, zoomLevel);
            RectangleL rectangle = new RectangleL(topLeft, new SizeL(bottomRight.X - topLeft.X, bottomRight.Y - topLeft.Y));

            PointG[,] result = new PointG[rows, columns];
            double xStep = (double)rectangle.Width / (columns - 1);
            double yStep = (double)rectangle.Height / (rows - 1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    PointL point = new PointL((long)Math.Round(rectangle.X + j * xStep, MidpointRounding.AwayFromZero), (long)Math.Round(rectangle.Y + i * yStep, MidpointRounding.AwayFromZero));
                    result[i, j] = MapTileSystemHelper.PixelXYToLatLong(point, zoomLevel);
                }
            }

            return result;
        }

        private void HandleSeaLevelElevationType(SeaLevelData seaLevelData)
        {
            for (int i = 0; i < this.radMap1.Layers["Pins"].Overlays.Count; i++)
            {
                MapPin pin = this.radMap1.Layers["Pins"].Overlays[i] as MapPin;

                if (pin != null)
                {
                    MapCallout callout = new MapCallout(pin);
                    callout.MaxWidth = 35;
                    callout.Text = seaLevelData.Offsets[i].ToString() + "m";
                    this.radMap1.Layers["Callouts"].Add(callout);
                }
            }
        }

        private void bingProvider_CalculateElevationError(object sender, CalculateElevationErrorEventArgs e)
        {
            RadMessageBox.ThemeName = this.CurrentThemeName;
            RadMessageBox.Show(e.Error.Message);
        }
    }
}
