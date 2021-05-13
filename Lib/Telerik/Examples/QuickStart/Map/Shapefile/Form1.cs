using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.Shapefile
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private Font seatsFont = new Font("Arial", 7f, FontStyle.Bold);
        private List<MapGeometry> selectedSeats = new List<MapGeometry>();

        public Form1()
        {
            InitializeComponent();

            this.SetupProvider();
            this.SetupLayer();
            this.SetupData();
            this.SetupColorizerAndLegend();

            this.radMap1.Click += radMap1_Click;
        }

        private void SetupProvider()
        {
            EmptyMapProvider emptyProvider = new EmptyMapProvider();
            emptyProvider.MinZoomLevel = 16;
            emptyProvider.MaxZoomLevel = 16;
            emptyProvider.InitializationComplete += emptyProvider_InitializationComplete;

            this.radMap1.Providers.Add(emptyProvider);
        }

        private void SetupLayer()
        {
            MapLayer pinsLayer = new MapLayer("Hall Layout");
            this.radMap1.Layers.Add(pinsLayer);
        }

        private void SetupData()
        {
            using (MemoryStream seatsStream = new MemoryStream(Properties.Resources.theatre_seats_pol))
            using (MemoryStream seatsDataStream = new MemoryStream(Properties.Resources.theatre_seats_pol_data))
            using (MemoryStream aisleStream = new MemoryStream(Properties.Resources.theatre_aisle_labels))
            {
                ShapeFileReaderParameters parameters = new ShapeFileReaderParameters();
                parameters.ShapeStream = seatsStream;
                parameters.DbfStream = seatsDataStream;
                ShapeFileReader reader = new ShapeFileReader();
                List<MapVisualElement> elements = reader.Read(parameters);

                foreach (MapGeometry element in elements)
                {
                    element.Font = this.seatsFont;
                    element.ForeColor = Color.White;
                    element.Text = "$[CAPTION]";
                    element.BackColor = Color.FromArgb(
                        Convert.ToInt32(element.ExtendedData.GetValue("RGB0")),
                        Convert.ToInt32(element.ExtendedData.GetValue("RGB1")),
                        Convert.ToInt32(element.ExtendedData.GetValue("RGB2")));
                    element.BorderWidth = 0;
                }

                this.radMap1.Layers["Hall Layout"].AddRange(elements);

                parameters = new ShapeFileReaderParameters();
                parameters.ShapeStream = aisleStream;
                elements = reader.Read(parameters);
                this.radMap1.Layers["Hall Layout"].AddRange(elements);
            }
        }

        private void SetupColorizerAndLegend()
        {
            PropertyColorizationStrategy colorizer = new PropertyColorizationStrategy();
            colorizer.Colors = new List<Color>() {
                    Color.FromArgb(96, 57, 19),
                    Color.FromArgb(204, 0, 0),
                    Color.FromArgb(255, 255, 255),
                    Color.FromArgb(204, 204, 204) };

            colorizer.PropertyValues.Add(new PropertyColorizerItem(1.0, "Sold"));
            colorizer.PropertyValues.Add(new PropertyColorizerItem(2.0, "Reserved"));
            colorizer.PropertyValues.Add(new PropertyColorizerItem(-1, "Selected"));
            colorizer.PropertyValues.Add(new PropertyColorizerItem(3.0, "Not Available"));
            colorizer.ValueProvider = new MapGeometryPropertyValueProvider("STATUS");

            this.radMap1.MapElement.Layers["Hall Layout"].ColorizationStrategy = colorizer;

            this.radMap1.MapElement.LegendElement.LegendInfoProvider = colorizer;
            ((MapLegendItemElement)this.radMap1.MapElement.LegendElement.ItemStackElement.Children[2]).ColorElement.BorderWidth = 3;
        }

        private void emptyProvider_InitializationComplete(object sender, EventArgs e)
        {
            List<PointG> locations = new List<PointG>();

            foreach (MapVisualElement el in this.radMap1.Layers["Hall Layout"].Overlays)
            {
                locations.Add(el.Location);
            }

            this.radMap1.BringIntoView(RectangleG.GetBoundingRectangle(locations));
            this.radMap1.Pan(new SizeL(-200, -50));
            this.radMap1.MapElement.EnableZooming = false;
            this.radMap1.MapElement.EnablePanning = false;
        }

        private void radMap1_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = e as MouseEventArgs;

            PointL location = new PointL(args.Location.X - this.radMap1.MapElement.PanOffset.Width, args.Location.Y - this.radMap1.MapElement.PanOffset.Height);

            MapGeometry g = this.radMap1.Layers["Hall Layout"].HitTest(location) as MapGeometry;

            if (g != null)
            {
                if (this.selectedSeats.Contains(g))
                {
                    g.BorderWidth = 0;
                    this.selectedSeats.Remove(g);
                }
                else
                {
                    double status = (double)g.ExtendedData.GetValue("STATUS");

                    if (status == 0.0)
                    {
                        g.BorderWidth = 3;
                        g.BorderColor = Color.Black;
                        this.selectedSeats.Add(g);
                    }
                }
            }
        }

        private void radButtonBuyNow_Click(object sender, EventArgs e)
        {
            this.ShowBookingForm(false);
        }

        private void radButtonReserve_Click(object sender, EventArgs e)
        {
            this.ShowBookingForm(true);
        }

        private void ShowBookingForm(bool isReservation)
        {
            int totalPrice = 0;

            foreach (MapGeometry seat in this.selectedSeats)
            {
                totalPrice += Convert.ToInt32(seat.ExtendedData.GetValue("PRICE"));
            }

            BookingForm bookingForm = new BookingForm();
            ThemeResolutionService.ApplyThemeToControlTree(bookingForm, this.CurrentThemeName);

            if (bookingForm.ShowForm("Chicago", this.selectedSeats.Count, totalPrice, isReservation) == DialogResult.OK)
            {
                this.radMap1.BeginUpdate();

                foreach (MapGeometry geometry in this.selectedSeats)
                {
                    geometry.ExtendedData.SetValue("STATUS", isReservation ? 2.0 : 1.0);
                    geometry.BorderWidth = 0;
                }

                this.selectedSeats.Clear();
                this.radMap1.EndUpdate();
            }
        }
    }
}
