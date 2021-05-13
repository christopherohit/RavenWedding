using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.Integration.Magnifier
{
	public class MagnifierElement : RadScrollViewer
	{
		MagnifierLayout layout;
		RadItemOwnerCollection items;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public MagnifierLayout Layout
		{
			get
			{
				return layout;
			}
		}

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.items = new RadItemOwnerCollection();
            this.items.ItemTypes = new Type[] { typeof(RadButtonElement) };
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public RadItemOwnerCollection Items
		{
			get
			{
				return items;
			}
		}

		protected override void CreateChildElements()
		{
            base.CreateChildElements();

			this.layout = new MagnifierLayout();
            this.Viewport = layout;
			this.items.Owner = layout;

            this.ShowBorder = false;
            this.ShowFill = false;
           
		}
	}
}
