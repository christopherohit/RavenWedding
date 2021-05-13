using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace DemoAppsHub.MagnifierExample
{
    public partial class MagnifierExampleUserControl : UserControl
    {
        private Magnifier magnifier;

        public MagnifierExampleUserControl()
        {
            InitializeComponent();

            this.Size = new Size(430, 430);
            ThemeResolutionService.LoadPackageResource("DemoAppsHub.MagnifierExample.OfficeGlass.tssp");
            this.magnifier = new Magnifier(); 

            this.magnifier.BackColor = System.Drawing.Color.Transparent;
            this.magnifier.Columns = 7;
            this.magnifier.DefaultCellSize = new System.Drawing.Size(56, 56);
            this.magnifier.ForeColor = System.Drawing.Color.Black;
            this.magnifier.Name = "magnifier1";
            this.magnifier.RootElement.ForeColor = System.Drawing.Color.Black;
            this.magnifier.Size = new System.Drawing.Size(429 + 30, 411 + 30);
            this.magnifier.TabIndex = 0;
            this.magnifier.Element.Layout.Margin = new Padding(30);
            this.magnifier.Text = "magnifier1";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.magnifier.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.magnifier.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;

            FillMagnifierWithButtons();
            this.magnifier.ThemeName = "OfficeGlass";
            this.Controls.Add(magnifier);
        }

        private void FillMagnifierWithButtons()
        {
            for (int i = 0; i < 49; i++)
            {
                RadButtonElement button = new RadButtonElement(i.ToString());

                button.StretchHorizontally = false;
                button.StretchVertically = false;
                button.Alignment = ContentAlignment.MiddleCenter;
                button.TextAlignment = ContentAlignment.MiddleCenter;
                button.TextElement.Parent.Alignment = ContentAlignment.MiddleCenter;
                button.MinSize = new Size(33, 33);
                this.magnifier.Items.Add(button);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.magnifier != null)
            {
                this.magnifier.Location = new Point((this.Width - this.magnifier.Width) / 2 - 15, 0);
            }
        }
         
    }
}
