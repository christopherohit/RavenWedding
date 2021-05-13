using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
{
    public class SurfaceObject : LightVisualElement
    {
        Point offset;

        public Point Offset
        {
            get
            {
                return offset;
            }
            set
            {
                if (offset != value)
                {
                    if (this.Parent != null)
                    {
                        if (value.X < 0)
                            value.X = 1;
                        if (value.Y < 1)
                            value.Y = 1;
                        if (value.X + this.Size.Width + 1 > this.Parent.Size.Width)
                            value.X = this.Parent.Size.Width - this.Size.Width - 1;
                        if (value.Y + this.Size.Height + 1 > this.Parent.Size.Height)
                            value.Y = this.Parent.Size.Height - this.Size.Height - 1;
                    }
                    offset = value;
                    if (this.Parent != null)
                    {
                        this.Parent.InvalidateMeasure();
                        this.Parent.UpdateLayout();
                    }
                }
            }
        }

        public bool IsCurrent
        {
            get
            {
                return FindAncestor<SurfaceElement>().CurrentObject == this;
            }
        }

        public SurfaceObject(int x, int y, RadElement content)
        {
            this.Offset = new Point(x, y);
            content.ShouldHandleMouseInput = false;
            content.NotifyParentOnMouseInput = true;
            this.Children.Add(content);
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();
            //this.AutoSize = false;
            this.MinSize = new Size(100, 20);
        }

        Point mouseDownPoint;
        Point mouseDownLocation;
        bool dragging;
        bool mouseIsDown;

        private bool IsRealDrag(Point location)
        {
            return location.X - mouseDownPoint.X > SystemInformation.DragSize.Width ||
                location.Y - mouseDownPoint.Y > SystemInformation.DragSize.Height;
        }

        private void DragTo(Point location)
        {
            Point delta = new Point(location.X - mouseDownPoint.X, location.Y - mouseDownPoint.Y);
            this.Offset = new Point(mouseDownLocation.X + delta.X, mouseDownLocation.Y + delta.Y);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                FindAncestor<SurfaceElement>().CurrentObject = this;
                mouseDownPoint = e.Location;
                mouseDownLocation = Offset;
                mouseIsDown = true;
                this.Capture = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Capture = false;
            mouseIsDown = false;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.ElementTree.Control.Cursor = Cursors.Hand;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.ElementTree.Control.Cursor = Cursors.Arrow;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left && mouseIsDown)
            {
                if (dragging)
                {
                    DragTo(e.Location);
                }
                else if (IsRealDrag(e.Location))
                {
                    DragTo(e.Location);
                    dragging = true;
                }
            }
        }

        protected override void PaintElement(Telerik.WinControls.Paint.IGraphics graphics, float angle, SizeF scale)
        {
            base.PaintElement(graphics, angle, scale);

            if (IsCurrent)
            {
                Graphics g = (Graphics)graphics.UnderlayGraphics;
                using (Pen pen = new Pen(Color.Black))
                {
                    Rectangle rect = new Rectangle(-1, -1, this.Size.Width + 1, this.Size.Height + 1);
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    g.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
