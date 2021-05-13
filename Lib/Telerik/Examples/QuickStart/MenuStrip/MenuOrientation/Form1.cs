using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.MenuOrientation
{
    public partial class Form1 : ExamplesForm
    {
		Size oldSize = Size.Empty;
		Point oldLocation = new Point(26, 27);

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radMenu1;
            this.WireEvents();
		}

        protected override void OnLoad(EventArgs e)
        {
            this.radButton1.ButtonElement.Margin = new Padding(2);
            this.radButton2.ButtonElement.Margin = new Padding(2);
            this.radButton1.Font =
            this.radButton2.Font = new Font("Segoe UI", 8);
        }
		
		private void radButton1_Click(object sender, EventArgs e)
		{
			if (this.radMenu1.MenuElement.Orientation == Orientation.Horizontal)
			{
				oldSize = this.radMenu1.Size;
                this.radMenu1.MenuElement.MinSize = Size.Empty;
                this.radMenu1.Orientation = System.Windows.Forms.Orientation.Vertical;
				this.radMenu1.Location = new Point(3, (int)(150 * this.radMenu1.RootElement.DpiScaleFactor.Width));
				this.radButton1.ButtonElement.ImagePrimitiveAngleTransform = 90;
			}
			else
			{
				this.radMenu1.Location = this.oldLocation;
				this.radMenu1.MenuElement.MinSize = oldSize;
				this.radMenu1.Orientation = System.Windows.Forms.Orientation.Horizontal;
				this.radButton1.ButtonElement.ImagePrimitiveAngleTransform = 0;
			}
		}

		private void radButton2_Click(object sender, EventArgs e)
		{
			if (this.radMenu1.MenuElement.TextOrientation == Orientation.Horizontal)
			{
				this.radMenu1.MenuElement.TextOrientation = Orientation.Vertical;
				this.radButton2.ButtonElement.ImagePrimitiveAngleTransform = 90;
			}
			else
			{
				this.radMenu1.MenuElement.TextOrientation = Orientation.Horizontal;
				this.radButton2.ButtonElement.ImagePrimitiveAngleTransform = 0;
			}
		}

        protected override void WireEvents()
        {
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
        }
    }
}