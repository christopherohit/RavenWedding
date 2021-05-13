using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Gauges;

namespace Telerik.Examples.WinControls.Gauges.Gallery
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        Timer timer = new Timer();
        RadScrollablePanel activePanel;
        public Form1()
        {
            InitializeComponent();
            this.activePanel = this.radPanel2;
            ((FillPrimitive)this.activePanel.PanelElement.Children[0]).BackColor = Color.White;
        }

        protected override void OnLoad(EventArgs e)
        {            
            base.OnLoad(e);
            timer.Interval = 1000;
            timer.Tick+=timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            foreach (Control childControl in activePanel.Controls[0].Controls)
            {
                ApplyValueToGauge(childControl as RadRadialGauge);
            }
        }

        int lastSeed = DateTime.Now.Millisecond;
        private void ApplyValueToGauge(RadRadialGauge radRadialGauge)
        {
            if( radRadialGauge==null)
            {
                return;
            }
            ++lastSeed;
            Random rnd = new Random(DateTime.Now.Millisecond + lastSeed);
            double seed = (radRadialGauge.RangeEnd - radRadialGauge.RangeStart) / 10d;
            double val = rnd.NextDouble() * seed - seed / 2;
            AnimatedPropertySetting setting = new AnimatedPropertySetting(
                RadRadialGaugeElement.ValueProperty,
                radRadialGauge.Value,
                radRadialGauge.Value + (float)val,
                12,
                40);
            setting.ApplyEasingType = RadEasingType.OutBounce;
            setting.ApplyValue(radRadialGauge.GaugeElement);

            if (radRadialGauge.Controls.Count > 0)
            {
                ApplyValueToGauge(radRadialGauge.Controls[0] as RadRadialGauge);
            }
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radRadioButton1.IsChecked)
            {
                this.activePanel = this.radPanel1;
                this.radPanel1.Visible = true;
                this.radPanel2.Visible = false;
                this.radPanel3.Visible = false;
            }
            if (this.radRadioButton3.IsChecked)
            {
                this.activePanel = this.radPanel2;
                this.radPanel1.Visible = false;
                this.radPanel2.Visible = true;
                this.radPanel3.Visible = false;
            }
            if (this.radRadioButton2.IsChecked)
            {
                this.activePanel = this.radPanel3;
                this.radPanel1.Visible = false;
                this.radPanel2.Visible = false;
                this.radPanel3.Visible = true;
            }

            ((FillPrimitive)this.activePanel.PanelElement.Children[0]).BackColor = Color.White;
        }
    }
}
