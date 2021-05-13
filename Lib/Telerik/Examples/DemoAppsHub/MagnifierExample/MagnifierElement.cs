using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace DemoAppsHub.MagnifierExample
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

		public MagnifierElement()
		{
           // this.LayoutUpdated += new EventHandler(MagnifierElement_LayoutUpdated);
		}

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.items = new RadItemOwnerCollection();
            this.items.ItemTypes = new Type[] { typeof(RadButtonElement) };
        }

        protected override void DisposeManagedResources()
        {
           // this.LayoutUpdated -= new EventHandler(MagnifierElement_LayoutUpdated);

            base.DisposeManagedResources();
        }

        private void MagnifierElement_LayoutUpdated(object sender, EventArgs e)
        {
            this.Invalidate();
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
		}
	}
}
