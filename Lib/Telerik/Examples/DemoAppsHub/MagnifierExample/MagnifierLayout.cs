using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Telerik.WinControls.Layouts;
using System.ComponentModel;
using System.Drawing;
using Telerik.WinControls;

namespace DemoAppsHub.MagnifierExample
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
            //SizeF cellSize = new SizeF(availableSize.Width / this.columns, availableSize.Height / rows);
            //SizeF cellSize = this.defaultCellSize;
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

            int x = 0;
            int y = 0;
            for (int i = 0; i < children.Count; i++)
            {
                RadElement child = children[i];
                SizeF elementPrefferedSize = child.DesiredSize;
                elementPrefferedSize.Width = Math.Max(elementPrefferedSize.Width, this.defaultCellSize.Width);
                elementPrefferedSize.Height = Math.Max(elementPrefferedSize.Height, this.defaultCellSize.Height);
                PointF elementPosition = new PointF(x * this.defaultCellSize.Width, y * this.defaultCellSize.Height);
                elementPosition.X += (this.defaultCellSize.Width - elementPrefferedSize.Width) / 2;
                elementPosition.Y += (this.defaultCellSize.Height - elementPrefferedSize.Height) / 2;
                
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
