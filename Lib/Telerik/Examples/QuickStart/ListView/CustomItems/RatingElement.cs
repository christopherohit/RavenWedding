using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls.Paint;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.ListView.CustomItems
{
    public class RatingElement : LightVisualElement
    {
        public static Bitmap starOnInternal;
        public static Bitmap starOffInternal;

        private int rating;

        public Bitmap StarOn { get; set; }
        public Bitmap StarOff { get; set; }

        public int Stars { get; set; }

        public int Rating
        {
            get { return rating; }
            set
            {
                if (rating != value)
                {
                    rating = value;
                    Invalidate();
                }
            }
        }
          
        public int StarSpacing { get; set; }

        static RatingElement()
        {
            starOnInternal = Resources.starOn;
            starOffInternal = Resources.starOff; 
        }

        public RatingElement()
        {
            Stars = 10;
            StarOn = starOnInternal;
            StarOff = starOffInternal;
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.StretchHorizontally = true;
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF desiredSize = SizeF.Empty;

            Bitmap star = StarOn;

            System.Windows.Forms.Padding border = GetBorderThickness(false);
            desiredSize.Height = star.Height + border.Vertical + Padding.Vertical;
            desiredSize.Width = (star.Width + StarSpacing) * Stars + border.Horizontal + Padding.Horizontal;

            desiredSize.Width += 40;

            return desiredSize;
        }

        protected override void PaintElement(IGraphics graphics, float angle, SizeF scale)
        {
            RectangleF clientRect = GetClientRectangle(this.Size);
            int x = (int)clientRect.X;
            int y = (int)clientRect.Y;
            int i = 0;
            for (; i < Rating; i++)
            {
                graphics.DrawBitmap(StarOn, x, y);
                x += starOnInternal.Width + StarSpacing;
            }
            for (; i < Stars; i++)
            {
                graphics.DrawBitmap(StarOff, x, y);
                x += starOnInternal.Width + StarSpacing;
            }

            Graphics g = (Graphics)graphics.UnderlayGraphics;
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            { 
                y += 3; 
                g.DrawString(string.Format("{0}/{1}", Rating, Stars), this.Font, brush, new PointF(x + 4, y - 2));
            }
        }
    }
}
