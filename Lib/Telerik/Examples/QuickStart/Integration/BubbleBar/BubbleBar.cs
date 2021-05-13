using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.Integration.BubbleBar
{
	public class BubbleBar : RadControl
	{
		BubbleBarElement element;

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public BubbleBarElement Element
		{
			get
			{
				return this.element;
			}
		}

		[RadEditItemsAction]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public RadItemOwnerCollection Items
		{
			get
			{
				return this.element.Items;
			}
		}

        protected override void CreateChildItems(RadElement parent)
        {
            this.element = new BubbleBarElement();
            this.element.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize;
            parent.Children.Add(this.element);
        }
	}
}
