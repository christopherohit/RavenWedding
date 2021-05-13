using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DemoAppsHub.MagnifierExample
{
	public class Magnifier : RadControl
	{
		MagnifierElement element;
		Timer timer;
		Point mousePos;
		private float zoomFactor = 3;

        public Magnifier()
		{
			timer = new Timer();
			timer.Tick += timer_Tick;
			timer.Interval = 16;
		}

        protected override void OnLoad(Size desiredSize)
        {
            base.OnLoad(desiredSize);
            this.DisableGesture(GestureType.All);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                timer.Stop();
                timer.Tick -= timer_Tick;
                timer.Dispose();
            }
            base.Dispose(disposing);
        }

		[RadEditItemsAction]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public RadItemOwnerCollection Items
		{
			get
			{
				return Element.Items;
			}
		}

        [DefaultValue(3)]
        public int Columns
        {
            get { return Element.Layout.Columns; }
            set { Element.Layout.Columns = value; }
        }

        public Size DefaultCellSize
        {
            get { return Element.Layout.DefaultCellSize; }
            set { Element.Layout.DefaultCellSize = value; }
        }

		[DefaultValue(3f)]
		public float ZoomFactor
		{
			get { return zoomFactor; }
			set { zoomFactor = value; }
		}

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MagnifierElement Element
        {
            get
            {
                return this.element;
            }
        }

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			timer.Start();
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			timer.Stop();
			foreach (RadElement element in Element.Layout.Children)
				if (element.ScaleTransform.Width != 1f || element.ScaleTransform.Height != 1f)
					element.ScaleTransform = new SizeF(1f, 1f);
		}		

		void timer_Tick(object sender, EventArgs e)
		{
			Point point = PointToClient(Control.MousePosition);
			if (mousePos != point)
			{
				float maxFactor = 0f;
				RadElement topMostCandidate = null;
                for (int i = 0; i < Element.Layout.Children.Count; i++)
				{
                    RadElement element = Element.Layout.Children[i];
                    int column = i % Element.Layout.Columns;
                    int row = i / Element.Layout.Columns;

					element.ZIndex = 0;

                    Point location = element.BoundingRectangle.Location;
                    location.Offset((int)this.Element.Viewport.PositionOffset.Width, (int)this.Element.Viewport.PositionOffset.Height);
					double dx = location.X + element.BoundingRectangle.Width / 2f - point.X;
					double dy = location.Y + element.BoundingRectangle.Height / 2f - point.Y;
					double dist = Math.Sqrt(dx * dx + dy * dy);
					double rad = 150;

                    if (dist < rad)
                    {
                        float factor = (float)Math.Cos(.5 * Math.PI * Math.Abs(dist / rad)) * zoomFactor;
                        if (factor >= 1f)
                        {
                            element.ScaleTransform = new SizeF(factor, factor);
                        }

                        if (maxFactor < factor)
                        {
                            maxFactor = Math.Max(maxFactor, factor);
                            topMostCandidate = element;
                        }
                    }
                    else
                    {
                        element.ScaleTransform = new SizeF(1f, 1f);
                    }

                    Size cellSize = Element.Layout.DefaultCellSize;
				}

				if (topMostCandidate != null)
				{
					topMostCandidate.ZIndex = 1;
				}
			}
			mousePos = point;
		}

        protected override void CreateChildItems(RadElement parent)
        {
            this.element = new MagnifierElement();
            parent.Children.Add(this.element);
        }
	}
}
