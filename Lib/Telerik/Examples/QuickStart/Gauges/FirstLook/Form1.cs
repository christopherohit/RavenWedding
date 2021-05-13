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
using Telerik.WinControls.UI.Gauges;

namespace Telerik.Examples.WinControls.Gauges.FirstLook
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        Timer timer = new Timer();
        
        float step1=0f;
        float step2=0f;
        float step3=0f;

        public Form1()
        {
            InitializeComponent();           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.radRadialGauge3.ValueChanged += radRadialGauge3_ValueChanged;
            this.radRadialGauge2.ValueChanged += radRadialGauge2_ValueChanged;
            this.radRadialGauge1.ValueChanged += radRadialGauge1_ValueChanged;

            step1 = -(float)(radRadialGauge1.RangeEnd - radRadialGauge1.RangeStart) / 10f;
            step2 = (float)(radRadialGauge2.RangeEnd - radRadialGauge2.RangeStart) / 10f;
            step3 = -(float)(radRadialGauge3.RangeEnd - radRadialGauge3.RangeStart) / 10f;

            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void radRadialGauge1_ValueChanged(object sender, EventArgs e)
        {
            if (this.radRadialGauge1.Value >= 6f)
            {
                this.radialGaugeNeedle2.BackColor = Color.FromArgb(224, 90, 90);
                this.radialGaugeNeedle2.BackColor2 = Color.FromArgb(224, 90, 90);
            }
            else
            {
                this.radialGaugeNeedle2.BackColor = Color.Black;
                this.radialGaugeNeedle2.BackColor2 = Color.Black;
            }
        }


        protected override void Dispose(bool disposing)        
        {
            this.timer.Stop();
            this.timer.Dispose();
             if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }        

        void timer_Tick(object sender, EventArgs e)
        {
            
            ApplyValueToGauge(this.radRadialGauge1,ref step1);
            ApplyValueToGauge(this.radRadialGauge2,ref step2);
            ApplyValueToGauge(this.radRadialGauge3,ref step3);
        }

       
        
        private void ApplyValueToGauge(RadRadialGauge radRadialGauge, ref float step)
        {            
            if (radRadialGauge.Value + step > radRadialGauge.RangeEnd ||
                radRadialGauge.Value + step < radRadialGauge.RangeStart)
            {
                step = -step;
            }
           
            AnimatedPropertySetting setting = new AnimatedPropertySetting(
                RadRadialGaugeElement.ValueProperty,
                radRadialGauge.Value,
                radRadialGauge.Value + step,
                12,
                40);
            setting.ApplyEasingType = RadEasingType.OutBounce;
            setting.ApplyValue(radRadialGauge.GaugeElement);
        }

        void radRadialGauge2_ValueChanged(object sender, EventArgs e)
        {
            if (this.radRadialGauge2.Value >= 50)
            {
                this.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb(119, 190, 79);
                this.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb(121, 191, 80);
            }
            else
            {
                this.radialGaugeArc3.BackColor = Color.FromArgb(224, 70, 71);
                this.radialGaugeArc3.BackColor2 = Color.FromArgb(224, 70, 71);
            }
        }

        void radRadialGauge3_ValueChanged(object sender, EventArgs e)
        {
            if (this.radRadialGauge3.Value < 50)
            {
                this.radialGaugeArc5.BackColor = System.Drawing.Color.FromArgb(119, 190, 79);
                this.radialGaugeArc5.BackColor2 = System.Drawing.Color.FromArgb(121, 191, 80);
            }
            else
            {
                this.radialGaugeArc5.BackColor = Color.FromArgb(224, 70, 71);
                this.radialGaugeArc5.BackColor2 = Color.FromArgb(224, 70, 71);
            }
        }  

    }
}
