using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PropertyGrid.FirstLook
{
    public class Surface : RadControl
    {
        public SurfaceElement Element;

        protected override void CreateChildItems(RadElement parent)
        {
            base.CreateChildItems(parent);
            this.Element = new SurfaceElement();
            parent.Children.Add(this.Element);
        }
    }
}
