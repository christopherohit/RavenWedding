using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using System.Drawing;
using Telerik.WinControls;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.ListView.CustomItems
{
    class CustomVisualItem : IconListViewVisualItem
    {
        private LightVisualElement imageElement;
        private LightVisualElement titleElement;
        private LightVisualElement artistElement;
        private RatingElement ratingElement;
        private StackLayoutPanel stackLayout;

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            stackLayout = new StackLayoutPanel();
            stackLayout.Orientation = System.Windows.Forms.Orientation.Vertical; 

            imageElement = new LightVisualElement();
            imageElement.DrawText = false;
            imageElement.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            imageElement.StretchVertically = false;
            imageElement.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);

            stackLayout.Children.Add(imageElement);

            titleElement = new LightVisualElement();
            titleElement.TextAlignment = ContentAlignment.MiddleLeft;
            titleElement.Margin = new Padding(10, 5, 10, 5);
            titleElement.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.Point);
            titleElement.ForeColor = Color.Black;
            stackLayout.Children.Add(titleElement);

            artistElement = new LightVisualElement();
            artistElement.TextAlignment = ContentAlignment.MiddleLeft;
            artistElement.Margin = new Padding(10, 5, 10, 5);
            artistElement.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            artistElement.ForeColor = Color.FromArgb(255, 114, 118, 125);
            stackLayout.Children.Add(artistElement);

            ratingElement = new RatingElement();
            ratingElement.StarSpacing = -4;
            ratingElement.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            ratingElement.ForeColor = Color.Black;
            stackLayout.Children.Add(ratingElement);

            this.Children.Add(stackLayout);

            this.Padding = new Padding(5);
            this.Shape = new RoundRectShape(3);
            this.BorderColor = Color.FromArgb(255, 110, 153, 210);
            this.BorderGradientStyle = GradientStyles.Solid;
            this.DrawBorder = true;
            this.DrawFill = true;
            this.BackColor = Color.FromArgb(255, 230, 238, 254);
            this.GradientStyle = GradientStyles.Solid;
        }

        protected override void SynchronizeProperties()
        {
            this.imageElement.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])this.Data["Image"]));
            this.titleElement.Text = Convert.ToString(this.Data["AlbumName"]);
            this.artistElement.Text = Convert.ToString(this.Data["ArtistName"]);
            double rating = 7 + 3.9 * (double)this.Data["Rating"];
            this.ratingElement.Rating = (int)rating;
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF measuredSize = base.MeasureOverride(availableSize);

            this.stackLayout.Measure(measuredSize);

            return measuredSize;
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);

            this.stackLayout.Arrange(new RectangleF(PointF.Empty, finalSize));

            return finalSize;
        }
    }
}
