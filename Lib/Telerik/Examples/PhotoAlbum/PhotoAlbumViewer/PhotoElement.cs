using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Drawing;
using Telerik.WinControls.Layouts;
using System.Drawing.Drawing2D;

namespace PhotoAlbumCS
{
    class PhotoElement : RadButtonElement
    {
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadButtonElement);
            }
        }

        protected override void OnGesture(Telerik.WinControls.GestureEventArgs args)
        {
            base.OnGesture(args);

            if (args.IsBegin)
            {
                this.BringToFront();
            }

            if (args.GestureType == Telerik.WinControls.GestureType.Pan && !args.IsBegin && !args.IsEnd)
            {
                PanGestureEventArgs panArgs = (PanGestureEventArgs)args;
                Size offset = panArgs.Offset;

                if (this.ControlBoundingRectangle.X + offset.Width < 0 && offset.Width < 0)
                {
                    offset.Width = -this.ControlBoundingRectangle.X;
                }
                if (this.ControlBoundingRectangle.Right + offset.Width > this.Parent.ControlBoundingRectangle.Right && offset.Width > 0)
                {
                    offset.Width = this.Parent.ControlBoundingRectangle.Right - this.ControlBoundingRectangle.Right;
                }

                if (this.ControlBoundingRectangle.Y + offset.Height < 0 && offset.Height < 0)
                {
                    offset.Height = -this.ControlBoundingRectangle.Y;
                }
                if (this.ControlBoundingRectangle.Bottom + offset.Height > this.Parent.ControlBoundingRectangle.Bottom && offset.Height > 0)
                {
                    offset.Height = this.Parent.ControlBoundingRectangle.Bottom - this.ControlBoundingRectangle.Bottom;
                }

                this.Location = new System.Drawing.Point(this.Location.X + offset.Width, this.Location.Y + offset.Height); ;
            }

            if (args.GestureType == GestureType.Rotate)
            {
                RotateGestureEventArgs rotateArgs = (RotateGestureEventArgs)args;
                Console.WriteLine((float)(rotateArgs.Angle * 180.0 / Math.PI));
                float newAngle = this.AngleTransform - (float)(rotateArgs.Angle * 180.0 / Math.PI);

                PropertySetting setting = new PropertySetting(RadElement.AngleTransformProperty, newAngle);
                setting.ApplyValue(this);
            }

            if (args.GestureType == GestureType.Zoom)
            {
                ZoomGestureEventArgs zoomArgs = (ZoomGestureEventArgs)args;
                this.ScaleTransform = new System.Drawing.SizeF(this.ScaleTransform.Width * (float)zoomArgs.ZoomFactor, this.ScaleTransform.Height * (float)zoomArgs.ZoomFactor);

                PointF oldDir = new PointF(this.Location.X - zoomArgs.Center.X, this.Location.Y - zoomArgs.Center.Y);
                PointF newDir = new PointF(oldDir.X * (float)zoomArgs.ZoomFactor, oldDir.Y * (float)zoomArgs.ZoomFactor);
                PointF offset = new PointF(newDir.X - oldDir.X, newDir.Y - oldDir.Y);

                this.Location = new Point(this.Location.X + (int)offset.X, this.Location.Y + (int)offset.Y);
            }

            args.Handled = true;
        }

        protected override bool PerformPaintTransformation(ref RadMatrix matrix)
        {
            bool res = false;
            float angleTransform = this.AngleTransform;

            if (angleTransform != 0f)
            {
                res = true;
                RectangleF bounds = new RectangleF(PointF.Empty, this.Bounds.Size);
                TelerikHelper.PerformCenteredRotation(ref matrix, bounds, angleTransform);
            }

            SizeF scaleTransform = this.ScaleTransform;
            if ((scaleTransform.Width > 0) && (scaleTransform.Height > 0))
            {
                if ((scaleTransform.Width != 1) || (scaleTransform.Height != 1))
                {
                    res = true;
                    matrix.Scale(scaleTransform.Width, scaleTransform.Height, MatrixOrder.Append);
                }
            }

            SizeF posOffset = this.PositionOffset;
            if (posOffset != SizeF.Empty)
            {
                res = true;
                matrix.Translate(
                    this.RightToLeft ? -posOffset.Width : posOffset.Width,
                    posOffset.Height, MatrixOrder.Append);
            }

            return res;
        }
    }
}
