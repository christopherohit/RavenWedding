using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using System.ComponentModel;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using System.Drawing;
using System.Diagnostics;
using Telerik.WinControls.Layouts;

namespace Telerik.Examples.WinControls.Integration.BubbleBar
{
	public class BubbleBarElement : RadElement
	{
		FillPrimitive fill;
		BorderPrimitive border;
		StackLayoutPanel panel;
		RadItemOwnerCollection items;

		public BubbleBarElement()
		{
		}

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.Shape = new RoundRectShape(12);

            this.items = new RadItemOwnerCollection();
            this.items.ItemTypes = new Type[] { typeof(RadButtonElement) };
            this.items.ItemsChanged += new ItemChangedDelegate(items_ItemsChanged);
        }

		public RadItemOwnerCollection Items
		{
			get
			{
				return items;
			}
		}

        protected override void CreateChildElements()
		{
			fill = new FillPrimitive();
			fill.BackColor = Color.FromArgb(253, 253, 253);
			fill.BackColor2 = Color.FromArgb(112, 112, 112);
			fill.NumberOfColors = 2;
			fill.GradientStyle = GradientStyles.Linear;
			fill.GradientAngle = 90;
            fill.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize;
			this.Children.Add(fill);

			border = new BorderPrimitive();
			border.GradientStyle = GradientStyles.Solid;
			border.ForeColor = Color.FromArgb(0, 0, 0);
            border.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize;

			this.Children.Add(border);

            panel = new StackLayoutPanel();
            panel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //panel.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            panel.Alignment = ContentAlignment.MiddleCenter;
            panel.StretchHorizontally = false;
			this.Children.Add(panel);

			this.items.Owner = panel;
		}

		void items_ItemsChanged(RadItemCollection changed, RadItem target, ItemsChangeOperation operation)
		{
			if (operation == ItemsChangeOperation.Inserted || operation == ItemsChangeOperation.Set)
			{
				target.AddBehavior(new BubbleBarMouseOverBehavior());
			}
		}
	}
}
