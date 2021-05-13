using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Integration.Magnifier
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        public Form1()
        {
            ThemeResolutionService.LoadPackageResource("Telerik.Examples.WinControls.Integration.Magnifier" + ".OfficeGlass.tssp");
            InitializeComponent();

            this.CenteredControl = this.radPanel1;
            this.FillMagnifierWithButtons();

            this.radToggleButton1.ToggleState = ToggleState.On;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.magnifier1.ThemeName = "OfficeGlass";
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
                this.magnifier1.Items.Add(button);
            }
        }

        private void radToggleButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            Random rand = new Random();

            foreach (RadItem item in this.magnifier1.Items)
            {
                if (args.ToggleState == ToggleState.On)
                {
                    item.Opacity = (double)(rand.Next(100) + 10) / 100d;
                }
                else
                {
                    item.Opacity = 1;
                }
            }
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            this.magnifier1.ZoomFactor = (float)this.radSpinEditor1.Value;
        }

        protected override void WireEvents()
        {
            this.radToggleButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radToggleButton1_ToggleStateChanged);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
        }
    }
}
