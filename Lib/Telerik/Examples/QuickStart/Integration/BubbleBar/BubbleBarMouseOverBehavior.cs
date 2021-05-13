using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using System.Drawing;

namespace Telerik.Examples.WinControls.Integration.BubbleBar
{
    /// <summary>
    /// Behavior class defining the OnMouseOver behavior of the BubbleBar
    /// </summary>
	public class BubbleBarMouseOverBehavior : PropertyChangeBehavior
	{
		public BubbleBarMouseOverBehavior()
			: base(RadItem.IsMouseOverProperty)
		{
		}

		public override void OnPropertyChange(RadElement element, RadPropertyChangedEventArgs e)
		{
			if ((bool)e.NewValue == true)
			{
                element.ResetValue(RadElement.ScaleTransformProperty);

                AnimatedPropertySetting animatedExpand = new AnimatedPropertySetting(
					RadElement.ScaleTransformProperty,
                    new SizeF(0.65f, 0.65f),
					new SizeF(1f, 1f), 
                    5, 30);

				animatedExpand.ApplyValue(element);
			}
			else
			{
                AnimatedPropertySetting animatedExpand = new AnimatedPropertySetting(
					RadElement.ScaleTransformProperty,
                    null, new SizeF(0.65f, 0.65f), 5, 30);

				animatedExpand.ApplyValue(element);
			}
		}
	}
}
