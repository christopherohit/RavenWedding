using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Telerik.WinControls.Layouts;
using System.ComponentModel;
using System.Drawing;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Integration.Magnifier
{
	public class MagnifierLayout : LayoutPanel
	{
		int columns = 3;
		Size defaultCellSize = Size.Empty;

		[DefaultValue(3)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Columns
		{
			get { return columns; }
			set { columns = value; }
		}

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Size DefaultCellSize
		{
			get { return defaultCellSize; }
			set { defaultCellSize = value; }
		}

		protected override SizeF MeasureOverride(SizeF availableSize)
        {
            RadElementCollection children = this.Children;
            int rows = children.Count / this.columns;
            SizeF cellSize = availableSize;

            for (int i = 0; i < children.Count; i++)
            {
                RadElement child = children[i];
                child.Measure(cellSize);
            }

            return new SizeF(this.columns * this.defaultCellSize.Width, rows * this.defaultCellSize.Height);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RadElementCollection children = this.Children;

            PointF offset = new PointF((finalSize.Width - this.DesiredSize.Width) / 2, (finalSize.Height - this.DesiredSize.Height) / 2);
            if (offset.X < 0)
            {
                offset.X = 0;
            }

            if (offset.Y < 0)
            {
                offset.Y = 0;
            }

            int x = 0;
            int y = 0;
            for (int i = 0; i < children.Count; i++)
            {
                RadElement child = children[i];
                SizeF elementPrefferedSize = child.DesiredSize;
                elementPrefferedSize.Width = Math.Max(elementPrefferedSize.Width, this.defaultCellSize.Width);
                elementPrefferedSize.Height = Math.Max(elementPrefferedSize.Height, this.defaultCellSize.Height);
                PointF elementPosition = new PointF(x * this.defaultCellSize.Width, y * this.defaultCellSize.Height);
                elementPosition.X += offset.X + (this.defaultCellSize.Width - elementPrefferedSize.Width) / 2;
                elementPosition.Y += offset.Y + (this.defaultCellSize.Height - elementPrefferedSize.Height) / 2;
                
                child.Arrange(new RectangleF(elementPosition, elementPrefferedSize));

                if (x < this.columns - 1)
                {
                    x++;
                }
                else
                {
                    x = 0;
                    y++;
                }
            }

            return finalSize;
        }
	}
}
