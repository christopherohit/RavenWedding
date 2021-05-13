using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Integration.Magnifier
{
    public class Magnifier : RadControl
    {
        private MagnifierElement element;
        private Timer timer;
        private Point mousePos;
        private float zoomFactor = 3;

        public Magnifier()
        {
            this.timer = new Timer();
            this.timer.Tick += this.Timer_Tick;
            this.timer.Interval = 16;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.timer.Stop();
                this.timer.Tick -= this.Timer_Tick;
                this.timer.Dispose();
            }

            base.Dispose(disposing);
        }

        [RadEditItemsAction]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RadItemOwnerCollection Items
        {
            get { return this.Element.Items; }
        }

        [DefaultValue(3)]
        public int Columns
        {
            get { return this.Element.Layout.Columns; }
            set { this.Element.Layout.Columns = value; }
        }

        public Size DefaultCellSize
        {
            get { return this.Element.Layout.DefaultCellSize; }
            set { this.Element.Layout.DefaultCellSize = value; }
        }

        [DefaultValue(3f)]
        public float ZoomFactor
        {
            get { return this.zoomFactor; }
            set { this.zoomFactor = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MagnifierElement Element
        {
            get { return this.element; }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.timer.Start();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.timer.Stop();
            foreach (RadElement element in this.Element.Layout.Children)
            {
                if (element.ScaleTransform.Width != 1f || element.ScaleTransform.Height != 1f)
                {
                    element.ScaleTransform = new SizeF(1f, 1f);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Point point = this.PointToClient(Control.MousePosition);
            if (this.mousePos != point)
            {
                float maxFactor = 0f;
                RadElement topMostCandidate = null;
                double halfPi = 0.5 * Math.PI;
                foreach (RadElement element in this.Element.Layout.Children)
                {
                    element.ZIndex = 0;
                    Rectangle boundingRect = element.BoundingRectangle;
                    double dx = boundingRect.X + boundingRect.Width / 2f - point.X;
                    double dy = boundingRect.Y + boundingRect.Height / 2f - point.Y;
                    double dist = Math.Sqrt(dx * dx + dy * dy);
                    double rad = 150;

                    if (dist < rad)
                    {
                        float factor = (float)Math.Cos(halfPi * (dist / rad)) * this.ZoomFactor;
                        if (factor >= 1f)
                        {
                            element.ScaleTransform = new SizeF(factor, factor);
                        }

                        if (maxFactor < factor)
                        {
                            maxFactor = factor;
                            topMostCandidate = element;
                        }
                    }
                    else
                    {
                        element.ScaleTransform = new SizeF(1f, 1f);
                    }
                }

                if (topMostCandidate != null)
                {
                    topMostCandidate.ZIndex = 1;
                }
            }

            this.mousePos = point;
        }

        protected override void CreateChildItems(RadElement parent)
        {
            this.element = new MagnifierElement();
            parent.Children.Add(this.element);
        }
    }
}
