using System.Drawing;
using Telerik.WinControls.Primitives;
namespace Telerik.Examples.WinControls.Gauges.Gallery
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            timer.Stop();
            timer.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPanel1 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radRadialGauge11 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc20 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc21 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeLabels7 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeTicks17 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge10 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc17 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc18 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc19 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks16 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels6 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle10 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radRadialGauge9 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc14 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc15 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc16 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks12 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks13 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle9 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeTicks14 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks15 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge8 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc12 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc13 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle8 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels5 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeSingleLabel3 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge5 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc6 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc7 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeLabels4 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeTicks11 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeSingleLabel1 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge4 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc5 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks9 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks10 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle5 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle6 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radRadialGauge1 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc1 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc2 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks1 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks2 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks3 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks4 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels1 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeLabels2 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle1 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle2 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radRadialGauge6 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radRadialGauge7 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc10 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc11 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle7 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeArc8 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc9 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeSingleLabel2 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge2 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc3 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle3 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeTicks5 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks6 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks7 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge3 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc4 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks8 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle4 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels3 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radPanel2 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radRadialGauge22 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc41 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc42 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeLabels14 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeTicks34 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge21 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc38 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc39 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc40 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks33 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels13 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle20 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radRadialGauge20 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc35 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc36 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc37 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks29 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks30 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle19 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeTicks31 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks32 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge19 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc33 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc34 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle18 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels12 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeSingleLabel6 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge17 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radRadialGauge18 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc31 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc32 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle17 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeArc29 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc30 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeSingleLabel5 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge16 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc27 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc28 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeLabels11 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeTicks28 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeSingleLabel4 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge14 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc25 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks25 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle14 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels10 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radRadialGauge13 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc24 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle13 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeTicks22 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks23 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks24 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge12 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc43 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc44 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks35 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks36 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks37 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks38 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels15 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeLabels16 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle21 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle22 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radRadialGauge15 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc26 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks26 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks27 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle15 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle16 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeArc22 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc23 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks18 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks19 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks20 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks21 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels8 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeLabels9 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle11 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle12 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radPanel3 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radRadialGauge33 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc64 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc65 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeLabels23 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeTicks55 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge32 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc61 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc62 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc63 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks54 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels22 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle32 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radRadialGauge31 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc58 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc59 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc60 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks50 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks51 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle31 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeTicks52 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks53 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge30 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc56 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc57 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle30 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels21 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeSingleLabel9 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge28 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radRadialGauge29 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc55 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle29 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeArc53 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc54 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeSingleLabel8 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge27 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc51 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc52 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeLabels20 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeTicks49 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeSingleLabel7 = new Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel();
            this.radRadialGauge26 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc49 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc50 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks47 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks48 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle27 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle28 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radRadialGauge25 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc48 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks46 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeNeedle26 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeLabels19 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radRadialGauge24 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc47 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeNeedle25 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeTicks43 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks44 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks45 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radRadialGauge23 = new Telerik.WinControls.UI.Gauges.RadRadialGauge();
            this.radialGaugeArc45 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeArc46 = new Telerik.WinControls.UI.Gauges.RadialGaugeArc();
            this.radialGaugeTicks39 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks40 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks41 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeTicks42 = new Telerik.WinControls.UI.Gauges.RadialGaugeTicks();
            this.radialGaugeLabels17 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeLabels18 = new Telerik.WinControls.UI.Gauges.RadialGaugeLabels();
            this.radialGaugeNeedle23 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radialGaugeNeedle24 = new Telerik.WinControls.UI.Gauges.RadialGaugeNeedle();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButton3 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.PanelContainer.SuspendLayout();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge6)).BeginInit();
            this.radRadialGauge6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.PanelContainer.SuspendLayout();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge17)).BeginInit();
            this.radRadialGauge17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.PanelContainer.SuspendLayout();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge28)).BeginInit();
            this.radRadialGauge28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radPanel1
            // 
            this.radPanel1.PanelElement.BackColor = System.Drawing.Color.White;
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radPanel1.PanelContainer
            // 
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge11);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge10);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge9);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge8);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge5);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge4);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge1);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge6);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge2);
            this.radPanel1.PanelContainer.Controls.Add(this.radRadialGauge3);
            this.radPanel1.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.PanelContainer.Size = new System.Drawing.Size(1193, 828);
            this.radPanel1.Size = new System.Drawing.Size(1193, 828);
            this.radPanel1.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radRadialGauge11
            // 
            
            this.radRadialGauge11.BackColor = System.Drawing.Color.White;
            this.radRadialGauge11.CausesValidation = false;
            this.radRadialGauge11.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc20,
            this.radialGaugeArc21,
            this.radialGaugeLabels7,
            this.radialGaugeTicks17});
            this.radRadialGauge11.Location = new System.Drawing.Point(258, 428);
            this.radRadialGauge11.Name = "radRadialGauge11";
            this.radRadialGauge11.RangeEnd = 180D;
            this.radRadialGauge11.RangeStart = 0D;
            this.radRadialGauge11.Size = new System.Drawing.Size(166, 164);
            this.radRadialGauge11.StartAngle = 120D;
            this.radRadialGauge11.SweepAngle = 300D;
            this.radRadialGauge11.TabIndex = 6;
            this.radRadialGauge11.Text = "radRadialGauge1";
            this.radRadialGauge11.Value = 100F;
            // 
            // radialGaugeArc20
            // 
            this.radialGaugeArc20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeArc20.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeArc20.BindEndRange = true;
            this.radialGaugeArc20.Name = "radialGaugeArc20";
            this.radialGaugeArc20.Radius = 0D;
            this.radialGaugeArc20.RangeEnd = 100D;
            this.radialGaugeArc20.RangeStart = 0D;
            this.radialGaugeArc20.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc20.Width = 24D;
            // 
            // radialGaugeArc21
            // 
            this.radialGaugeArc21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.radialGaugeArc21.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.radialGaugeArc21.BindStartRange = true;
            this.radialGaugeArc21.Name = "radialGaugeArc21";
            this.radialGaugeArc21.Radius = 87D;
            this.radialGaugeArc21.RangeEnd = 180D;
            this.radialGaugeArc21.RangeStart = 100D;
            this.radialGaugeArc21.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc21.Width = 14D;
            // 
            // radialGaugeLabels7
            // 
            this.radialGaugeLabels7.DrawText = false;
            this.radialGaugeLabels7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeLabels7.LabelFontSize = 6F;
            this.radialGaugeLabels7.LabelRadiusPercentage = 55F;
            this.radialGaugeLabels7.LabelsCount = 2;
            this.radialGaugeLabels7.Name = "radialGaugeLabels7";
            this.radialGaugeLabels7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks17
            // 
            this.radialGaugeTicks17.DrawText = false;
            this.radialGaugeTicks17.Name = "radialGaugeTicks17";
            this.radialGaugeTicks17.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeTicks17.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks17.TicksCount = 16;
            this.radialGaugeTicks17.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks17.TicksOffset = 0;
            this.radialGaugeTicks17.TicksRadiusPercentage = 64F;
            this.radialGaugeTicks17.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks17.TickThickness = 1F;
            this.radialGaugeTicks17.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge10
            // 
            
            this.radRadialGauge10.BackColor = System.Drawing.Color.White;
            this.radRadialGauge10.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc17,
            this.radialGaugeArc18,
            this.radialGaugeArc19,
            this.radialGaugeTicks16,
            this.radialGaugeLabels6,
            this.radialGaugeNeedle10});
            this.radRadialGauge10.Location = new System.Drawing.Point(13, 428);
            this.radRadialGauge10.Name = "radRadialGauge10";
            this.radRadialGauge10.RangeEnd = 180D;
            this.radRadialGauge10.RangeStart = 0D;
            this.radRadialGauge10.Size = new System.Drawing.Size(210, 198);
            this.radRadialGauge10.StartAngle = 130D;
            this.radRadialGauge10.SweepAngle = 280D;
            this.radRadialGauge10.TabIndex = 6;
            this.radRadialGauge10.Text = "radRadialGauge1";
            this.radRadialGauge10.Value = 90F;
            // 
            // radialGaugeArc17
            // 
            this.radialGaugeArc17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.radialGaugeArc17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.radialGaugeArc17.Name = "radialGaugeArc17";
            this.radialGaugeArc17.Radius = 0D;
            this.radialGaugeArc17.RangeEnd = 60D;
            this.radialGaugeArc17.RangeStart = 0D;
            this.radialGaugeArc17.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc17.Width = 4D;
            // 
            // radialGaugeArc18
            // 
            this.radialGaugeArc18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeArc18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeArc18.Name = "radialGaugeArc18";
            this.radialGaugeArc18.Radius = 0D;
            this.radialGaugeArc18.RangeEnd = 120D;
            this.radialGaugeArc18.RangeStart = 61D;
            this.radialGaugeArc18.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc18.Width = 4D;
            // 
            // radialGaugeArc19
            // 
            this.radialGaugeArc19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.radialGaugeArc19.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.radialGaugeArc19.Name = "radialGaugeArc19";
            this.radialGaugeArc19.Radius = 0D;
            this.radialGaugeArc19.RangeEnd = 180D;
            this.radialGaugeArc19.RangeStart = 121D;
            this.radialGaugeArc19.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc19.Width = 4D;
            // 
            // radialGaugeTicks16
            // 
            this.radialGaugeTicks16.DrawText = false;
            this.radialGaugeTicks16.Name = "radialGaugeTicks16";
            this.radialGaugeTicks16.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks16.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks16.TicksCount = 18;
            this.radialGaugeTicks16.TicksLenghtPercentage = 4F;
            this.radialGaugeTicks16.TicksOffset = 0;
            this.radialGaugeTicks16.TicksRadiusPercentage = 83F;
            this.radialGaugeTicks16.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks16.TickThickness = 1F;
            this.radialGaugeTicks16.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels6
            // 
            this.radialGaugeLabels6.DrawText = false;
            this.radialGaugeLabels6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels6.LabelFontSize = 5F;
            this.radialGaugeLabels6.LabelRadiusPercentage = 68F;
            this.radialGaugeLabels6.LabelsCount = 9;
            this.radialGaugeLabels6.Name = "radialGaugeLabels6";
            this.radialGaugeLabels6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle10
            // 
            this.radialGaugeNeedle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.radialGaugeNeedle10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.radialGaugeNeedle10.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle10.BindValue = true;
            this.radialGaugeNeedle10.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle10.LenghtPercentage = 70D;
            this.radialGaugeNeedle10.Name = "radialGaugeNeedle10";
            this.radialGaugeNeedle10.PointRadiusPercentage = 7D;
            this.radialGaugeNeedle10.Thickness = 1.5D;
            this.radialGaugeNeedle10.Value = 90F;
            this.radialGaugeNeedle10.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge9
            // 
            
            this.radRadialGauge9.BackColor = System.Drawing.Color.White;
            this.radRadialGauge9.CausesValidation = false;
            this.radRadialGauge9.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc14,
            this.radialGaugeArc15,
            this.radialGaugeArc16,
            this.radialGaugeTicks12,
            this.radialGaugeTicks13,
            this.radialGaugeNeedle9,
            this.radialGaugeTicks14,
            this.radialGaugeTicks15});
            this.radRadialGauge9.Location = new System.Drawing.Point(668, 211);
            this.radRadialGauge9.Name = "radRadialGauge9";
            this.radRadialGauge9.RangeEnd = 100D;
            this.radRadialGauge9.RangeStart = 0D;
            this.radRadialGauge9.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge9.StartAngle = 180D;
            this.radRadialGauge9.SweepAngle = 360D;
            this.radRadialGauge9.TabIndex = 6;
            this.radRadialGauge9.Text = "radRadialGauge1";
            this.radRadialGauge9.Value = 36F;
            // 
            // radialGaugeArc14
            // 
            this.radialGaugeArc14.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc14.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc14.Name = "radialGaugeArc14";
            this.radialGaugeArc14.Radius = 88D;
            this.radialGaugeArc14.RangeEnd = 33D;
            this.radialGaugeArc14.RangeStart = 0D;
            this.radialGaugeArc14.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc14.Width = 14D;
            // 
            // radialGaugeArc15
            // 
            this.radialGaugeArc15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.radialGaugeArc15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.radialGaugeArc15.Name = "radialGaugeArc15";
            this.radialGaugeArc15.Radius = 88D;
            this.radialGaugeArc15.RangeEnd = 100D;
            this.radialGaugeArc15.RangeStart = 33D;
            this.radialGaugeArc15.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc15.Width = 14D;
            // 
            // radialGaugeArc16
            // 
            this.radialGaugeArc16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.radialGaugeArc16.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.radialGaugeArc16.BindEndRange = true;
            this.radialGaugeArc16.Name = "radialGaugeArc16";
            this.radialGaugeArc16.Radius = 70D;
            this.radialGaugeArc16.RangeEnd = 36D;
            this.radialGaugeArc16.RangeStart = 0D;
            this.radialGaugeArc16.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc16.Width = 4D;
            // 
            // radialGaugeTicks12
            // 
            this.radialGaugeTicks12.DrawText = false;
            this.radialGaugeTicks12.Name = "radialGaugeTicks12";
            this.radialGaugeTicks12.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.radialGaugeTicks12.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks12.TicksCount = 24;
            this.radialGaugeTicks12.TicksLenghtPercentage = 8F;
            this.radialGaugeTicks12.TicksOffset = 0;
            this.radialGaugeTicks12.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks12.TickThickness = 1F;
            this.radialGaugeTicks12.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks13
            // 
            this.radialGaugeTicks13.DrawText = false;
            this.radialGaugeTicks13.Name = "radialGaugeTicks13";
            this.radialGaugeTicks13.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.radialGaugeTicks13.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks13.TicksCount = 72;
            this.radialGaugeTicks13.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks13.TicksOffset = 0;
            this.radialGaugeTicks13.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks13.TickThickness = 1F;
            this.radialGaugeTicks13.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle9
            // 
            this.radialGaugeNeedle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle9.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle9.BindValue = true;
            this.radialGaugeNeedle9.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle9.LenghtPercentage = 70D;
            this.radialGaugeNeedle9.Name = "radialGaugeNeedle9";
            this.radialGaugeNeedle9.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle9.Thickness = 0.4D;
            this.radialGaugeNeedle9.Value = 36F;
            this.radialGaugeNeedle9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks14
            // 
            this.radialGaugeTicks14.DrawText = false;
            this.radialGaugeTicks14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks14.Name = "radialGaugeTicks14";
            this.radialGaugeTicks14.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks14.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks14.TicksCount = 1;
            this.radialGaugeTicks14.TicksLenghtPercentage = 14F;
            this.radialGaugeTicks14.TicksOffset = 0;
            this.radialGaugeTicks14.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks14.TickThickness = 1F;
            this.radialGaugeTicks14.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks15
            // 
            this.radialGaugeTicks15.CircleTicks = true;
            this.radialGaugeTicks15.DrawText = false;
            this.radialGaugeTicks15.Name = "radialGaugeTicks15";
            this.radialGaugeTicks15.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks15.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks15.TicksCount = 1;
            this.radialGaugeTicks15.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks15.TicksOffset = 0;
            this.radialGaugeTicks15.TicksRadiusPercentage = 106F;
            this.radialGaugeTicks15.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks15.TickThickness = 1F;
            this.radialGaugeTicks15.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge8
            // 
            
            this.radRadialGauge8.BackColor = System.Drawing.Color.White;
            this.radRadialGauge8.CausesValidation = false;
            this.radRadialGauge8.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc12,
            this.radialGaugeArc13,
            this.radialGaugeNeedle8,
            this.radialGaugeLabels5,
            this.radialGaugeSingleLabel3});
            this.radRadialGauge8.Location = new System.Drawing.Point(447, 211);
            this.radRadialGauge8.Name = "radRadialGauge8";
            this.radRadialGauge8.RangeEnd = 50D;
            this.radRadialGauge8.RangeStart = 0D;
            this.radRadialGauge8.Size = new System.Drawing.Size(214, 201);
            this.radRadialGauge8.StartAngle = 205D;
            this.radRadialGauge8.SweepAngle = 130D;
            this.radRadialGauge8.TabIndex = 6;
            this.radRadialGauge8.Text = "radRadialGauge1";
            this.radRadialGauge8.Value = 33F;
            // 
            // radialGaugeArc12
            // 
            this.radialGaugeArc12.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc12.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc12.BindEndRange = true;
            this.radialGaugeArc12.Name = "radialGaugeArc12";
            this.radialGaugeArc12.Radius = 0D;
            this.radialGaugeArc12.RangeEnd = 33D;
            this.radialGaugeArc12.RangeStart = 0D;
            this.radialGaugeArc12.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc12.Width = 40D;
            // 
            // radialGaugeArc13
            // 
            this.radialGaugeArc13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc13.BindStartRange = true;
            this.radialGaugeArc13.Name = "radialGaugeArc13";
            this.radialGaugeArc13.Radius = 0D;
            this.radialGaugeArc13.RangeEnd = 50D;
            this.radialGaugeArc13.RangeStart = 33D;
            this.radialGaugeArc13.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc13.Width = 40D;
            // 
            // radialGaugeNeedle8
            // 
            this.radialGaugeNeedle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radialGaugeNeedle8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radialGaugeNeedle8.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle8.BindValue = true;
            this.radialGaugeNeedle8.InnerPointRadiusPercentage = 4D;
            this.radialGaugeNeedle8.LenghtPercentage = 115D;
            this.radialGaugeNeedle8.Name = "radialGaugeNeedle8";
            this.radialGaugeNeedle8.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle8.Thickness = 0.7D;
            this.radialGaugeNeedle8.Value = 33F;
            this.radialGaugeNeedle8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels5
            // 
            this.radialGaugeLabels5.DrawText = false;
            this.radialGaugeLabels5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels5.LabelFontSize = 5F;
            this.radialGaugeLabels5.LabelRadiusPercentage = 112F;
            this.radialGaugeLabels5.LabelsCount = 1;
            this.radialGaugeLabels5.Name = "radialGaugeLabels5";
            this.radialGaugeLabels5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeSingleLabel3
            // 
            this.radialGaugeSingleLabel3.BindValue = true;
            this.radialGaugeSingleLabel3.LabelFontSize = 11F;
            this.radialGaugeSingleLabel3.LabelFormat = "#0#.00##";
            this.radialGaugeSingleLabel3.LabelText = "Text";
            this.radialGaugeSingleLabel3.LocationPercentage = new System.Drawing.SizeF(0F, 0.25F);
            this.radialGaugeSingleLabel3.Name = "radialGaugeSingleLabel3";
            this.radialGaugeSingleLabel3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge5
            // 
            
            this.radRadialGauge5.BackColor = System.Drawing.Color.White;
            this.radRadialGauge5.CausesValidation = false;
            this.radRadialGauge5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc6,
            this.radialGaugeArc7,
            this.radialGaugeLabels4,
            this.radialGaugeTicks11,
            this.radialGaugeSingleLabel1});
            this.radRadialGauge5.Location = new System.Drawing.Point(4, 211);
            this.radRadialGauge5.Name = "radRadialGauge5";
            this.radRadialGauge5.RangeEnd = 180D;
            this.radRadialGauge5.RangeStart = 0D;
            this.radRadialGauge5.Size = new System.Drawing.Size(229, 210);
            this.radRadialGauge5.StartAngle = 120D;
            this.radRadialGauge5.SweepAngle = 300D;
            this.radRadialGauge5.TabIndex = 6;
            this.radRadialGauge5.Text = "radRadialGauge1";
            this.radRadialGauge5.Value = 90F;
            // 
            // radialGaugeArc6
            // 
            this.radialGaugeArc6.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc6.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc6.Name = "radialGaugeArc6";
            this.radialGaugeArc6.Radius = 80D;
            this.radialGaugeArc6.RangeEnd = 0D;
            this.radialGaugeArc6.RangeStart = 120D;
            this.radialGaugeArc6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc6.Width = 15D;
            // 
            // radialGaugeArc7
            // 
            this.radialGaugeArc7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.radialGaugeArc7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc7.Name = "radialGaugeArc7";
            this.radialGaugeArc7.Radius = 80D;
            this.radialGaugeArc7.RangeEnd = 180D;
            this.radialGaugeArc7.RangeStart = 120D;
            this.radialGaugeArc7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc7.Width = 15D;
            // 
            // radialGaugeLabels4
            // 
            this.radialGaugeLabels4.DrawText = false;
            this.radialGaugeLabels4.LabelFontSize = 5F;
            this.radialGaugeLabels4.LabelRadiusPercentage = 108F;
            this.radialGaugeLabels4.LabelsCount = 9;
            this.radialGaugeLabels4.Name = "radialGaugeLabels4";
            this.radialGaugeLabels4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks11
            // 
            this.radialGaugeTicks11.CircleTicks = true;
            this.radialGaugeTicks11.DrawText = false;
            this.radialGaugeTicks11.Name = "radialGaugeTicks11";
            this.radialGaugeTicks11.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.radialGaugeTicks11.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks11.TicksCount = 18;
            this.radialGaugeTicks11.TicksLenghtPercentage = 1F;
            this.radialGaugeTicks11.TicksOffset = 4;
            this.radialGaugeTicks11.TicksRadiusPercentage = 95F;
            this.radialGaugeTicks11.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks11.TickThickness = 1F;
            this.radialGaugeTicks11.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeSingleLabel1
            // 
            this.radialGaugeSingleLabel1.BindValue = true;
            this.radialGaugeSingleLabel1.ForeColor = System.Drawing.Color.Black;
            this.radialGaugeSingleLabel1.LabelFontSize = 9F;
            this.radialGaugeSingleLabel1.LabelText = "Text";
            this.radialGaugeSingleLabel1.LocationPercentage = new System.Drawing.SizeF(0F, 0F);
            this.radialGaugeSingleLabel1.Name = "radialGaugeSingleLabel1";
            this.radialGaugeSingleLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge4
            // 
            
            this.radRadialGauge4.BackColor = System.Drawing.Color.White;
            this.radRadialGauge4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc5,
            this.radialGaugeTicks9,
            this.radialGaugeTicks10,
            this.radialGaugeNeedle5,
            this.radialGaugeNeedle6});
            this.radRadialGauge4.Location = new System.Drawing.Point(661, 4);
            this.radRadialGauge4.Name = "radRadialGauge4";
            this.radRadialGauge4.RangeEnd = 100D;
            this.radRadialGauge4.RangeStart = 0D;
            this.radRadialGauge4.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge4.StartAngle = 0D;
            this.radRadialGauge4.SweepAngle = 360D;
            this.radRadialGauge4.TabIndex = 6;
            this.radRadialGauge4.Text = "radRadialGauge1";
            this.radRadialGauge4.Value = 90F;
            // 
            // radialGaugeArc5
            // 
            this.radialGaugeArc5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc5.Name = "radialGaugeArc5";
            this.radialGaugeArc5.Radius = 0D;
            this.radialGaugeArc5.RangeEnd = 100D;
            this.radialGaugeArc5.RangeStart = 0D;
            this.radialGaugeArc5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc5.Width = 2D;
            // 
            // radialGaugeTicks9
            // 
            this.radialGaugeTicks9.DrawText = false;
            this.radialGaugeTicks9.Name = "radialGaugeTicks9";
            this.radialGaugeTicks9.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks9.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks9.TicksCount = 24;
            this.radialGaugeTicks9.TicksLenghtPercentage = 2F;
            this.radialGaugeTicks9.TicksOffset = 6;
            this.radialGaugeTicks9.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks9.TickThickness = 1F;
            this.radialGaugeTicks9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks10
            // 
            this.radialGaugeTicks10.DrawText = false;
            this.radialGaugeTicks10.Name = "radialGaugeTicks10";
            this.radialGaugeTicks10.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks10.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks10.TicksCount = 72;
            this.radialGaugeTicks10.TicksLenghtPercentage = 1F;
            this.radialGaugeTicks10.TicksOffset = 1;
            this.radialGaugeTicks10.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks10.TickThickness = 1F;
            this.radialGaugeTicks10.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle5
            // 
            this.radialGaugeNeedle5.BackColor = System.Drawing.Color.Black;
            this.radialGaugeNeedle5.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeNeedle5.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle5.BindValue = true;
            this.radialGaugeNeedle5.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle5.LenghtPercentage = 70D;
            this.radialGaugeNeedle5.Name = "radialGaugeNeedle5";
            this.radialGaugeNeedle5.PointRadiusPercentage = 4D;
            this.radialGaugeNeedle5.Thickness = 1D;
            this.radialGaugeNeedle5.Value = 90F;
            this.radialGaugeNeedle5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle6
            // 
            this.radialGaugeNeedle6.BackColor = System.Drawing.Color.Black;
            this.radialGaugeNeedle6.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeNeedle6.BackLenghtPercentage = -55D;
            this.radialGaugeNeedle6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle6.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle6.LenghtPercentage = 70D;
            this.radialGaugeNeedle6.Name = "radialGaugeNeedle6";
            this.radialGaugeNeedle6.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle6.Thickness = 8D;
            this.radialGaugeNeedle6.Value = 60F;
            this.radialGaugeNeedle6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge1
            // 
            
            this.radRadialGauge1.BackColor = System.Drawing.Color.White;
            this.radRadialGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc1,
            this.radialGaugeArc2,
            this.radialGaugeTicks1,
            this.radialGaugeTicks2,
            this.radialGaugeTicks3,
            this.radialGaugeTicks4,
            this.radialGaugeLabels1,
            this.radialGaugeLabels2,
            this.radialGaugeNeedle1,
            this.radialGaugeNeedle2});
            this.radRadialGauge1.Location = new System.Drawing.Point(4, 4);
            this.radRadialGauge1.Name = "radRadialGauge1";
            this.radRadialGauge1.RangeEnd = 180D;
            this.radRadialGauge1.RangeStart = 0D;
            this.radRadialGauge1.Size = new System.Drawing.Size(229, 200);
            this.radRadialGauge1.StartAngle = 120D;
            this.radRadialGauge1.SweepAngle = 300D;
            this.radRadialGauge1.TabIndex = 1;
            this.radRadialGauge1.Text = "radRadialGauge2";
            this.radRadialGauge1.Value = 90F;
            // 
            // radialGaugeArc1
            // 
            this.radialGaugeArc1.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc1.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc1.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc1.Name = "radialGaugeArc1";
            this.radialGaugeArc1.Radius = 0D;
            this.radialGaugeArc1.RangeEnd = 120D;
            this.radialGaugeArc1.RangeStart = 0D;
            this.radialGaugeArc1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc1.Width = 2D;
            // 
            // radialGaugeArc2
            // 
            this.radialGaugeArc2.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc2.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc2.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc2.Name = "radialGaugeArc2";
            this.radialGaugeArc2.Radius = 0D;
            this.radialGaugeArc2.RangeEnd = 180D;
            this.radialGaugeArc2.RangeStart = 120D;
            this.radialGaugeArc2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc2.Width = 2D;
            // 
            // radialGaugeTicks1
            // 
            this.radialGaugeTicks1.DrawText = false;
            this.radialGaugeTicks1.Name = "radialGaugeTicks1";
            this.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks1.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks1.TicksCount = 18;
            this.radialGaugeTicks1.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks1.TicksOffset = 0;
            this.radialGaugeTicks1.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks1.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks1.TickThickness = 1F;
            this.radialGaugeTicks1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks2
            // 
            this.radialGaugeTicks2.DrawText = false;
            this.radialGaugeTicks2.Name = "radialGaugeTicks2";
            this.radialGaugeTicks2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks2.TickEndIndexVisibleRange = 35F;
            this.radialGaugeTicks2.TicksCount = 54;
            this.radialGaugeTicks2.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks2.TicksOffset = 0;
            this.radialGaugeTicks2.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks2.TickThickness = 1F;
            this.radialGaugeTicks2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks3
            // 
            this.radialGaugeTicks3.DrawText = false;
            this.radialGaugeTicks3.Name = "radialGaugeTicks3";
            this.radialGaugeTicks3.TickColor = System.Drawing.Color.Black;
            this.radialGaugeTicks3.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks3.TicksCount = 18;
            this.radialGaugeTicks3.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks3.TicksOffset = 0;
            this.radialGaugeTicks3.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks3.TickStartIndexVisibleRange = 12F;
            this.radialGaugeTicks3.TickThickness = 1F;
            this.radialGaugeTicks3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks4
            // 
            this.radialGaugeTicks4.DrawText = false;
            this.radialGaugeTicks4.Name = "radialGaugeTicks4";
            this.radialGaugeTicks4.TickColor = System.Drawing.Color.Black;
            this.radialGaugeTicks4.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks4.TicksCount = 54;
            this.radialGaugeTicks4.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks4.TicksOffset = 0;
            this.radialGaugeTicks4.TickStartIndexVisibleRange = 37F;
            this.radialGaugeTicks4.TickThickness = 1F;
            this.radialGaugeTicks4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels1
            // 
            this.radialGaugeLabels1.DrawText = false;
            this.radialGaugeLabels1.LabelEndVisibleRange = 100F;
            this.radialGaugeLabels1.LabelFontSize = 4F;
            this.radialGaugeLabels1.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels1.LabelsCount = 9;
            this.radialGaugeLabels1.Name = "radialGaugeLabels1";
            this.radialGaugeLabels1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels2
            // 
            this.radialGaugeLabels2.DrawText = false;
            this.radialGaugeLabels2.ForeColor = System.Drawing.Color.Black;
            this.radialGaugeLabels2.LabelFontSize = 4F;
            this.radialGaugeLabels2.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels2.LabelsCount = 9;
            this.radialGaugeLabels2.LabelStartVisibleRange = 120F;
            this.radialGaugeLabels2.Name = "radialGaugeLabels2";
            this.radialGaugeLabels2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle1
            // 
            this.radialGaugeNeedle1.BackColor = System.Drawing.Color.Black;
            this.radialGaugeNeedle1.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeNeedle1.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle1.BindValue = true;
            this.radialGaugeNeedle1.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle1.LenghtPercentage = 78D;
            this.radialGaugeNeedle1.Name = "radialGaugeNeedle1";
            this.radialGaugeNeedle1.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle1.Thickness = 2D;
            this.radialGaugeNeedle1.Value = 90F;
            this.radialGaugeNeedle1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle2
            // 
            this.radialGaugeNeedle2.BackColor = System.Drawing.Color.Black;
            this.radialGaugeNeedle2.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeNeedle2.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle2.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle2.LenghtPercentage = 78D;
            this.radialGaugeNeedle2.Name = "radialGaugeNeedle2";
            this.radialGaugeNeedle2.PointRadiusPercentage = 6D;
            this.radialGaugeNeedle2.Thickness = 2D;
            this.radialGaugeNeedle2.Value = 90F;
            this.radialGaugeNeedle2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge6
            // 
            
            this.radRadialGauge6.BackColor = System.Drawing.Color.White;
            this.radRadialGauge6.CausesValidation = false;
            this.radRadialGauge6.Controls.Add(this.radRadialGauge7);
            this.radRadialGauge6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc8,
            this.radialGaugeArc9,
            this.radialGaugeSingleLabel2});
            this.radRadialGauge6.Location = new System.Drawing.Point(240, 211);
            this.radRadialGauge6.Name = "radRadialGauge6";
            this.radRadialGauge6.RangeEnd = 100D;
            this.radRadialGauge6.RangeStart = 0D;
            this.radRadialGauge6.Size = new System.Drawing.Size(204, 210);
            this.radRadialGauge6.StartAngle = 180D;
            this.radRadialGauge6.SweepAngle = 180D;
            this.radRadialGauge6.TabIndex = 6;
            this.radRadialGauge6.Text = "radRadialGauge1";
            this.radRadialGauge6.Value = 60F;
            // 
            // radRadialGauge7
            // 
            
            this.radRadialGauge7.BackColor = System.Drawing.Color.White;
            this.radRadialGauge7.CausesValidation = false;
            this.radRadialGauge7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc10,
            this.radialGaugeArc11,
            this.radialGaugeNeedle7});
            this.radRadialGauge7.Location = new System.Drawing.Point(1, 100);
            this.radRadialGauge7.Name = "radRadialGauge7";
            this.radRadialGauge7.RangeEnd = 100D;
            this.radRadialGauge7.RangeStart = 0D;
            this.radRadialGauge7.Size = new System.Drawing.Size(200, 208);
            this.radRadialGauge7.StartAngle = 180D;
            this.radRadialGauge7.SweepAngle = 180D;
            this.radRadialGauge7.TabIndex = 6;
            this.radRadialGauge7.Text = "radRadialGauge1";
            this.radRadialGauge7.Value = 80F;
            // 
            // radialGaugeArc10
            // 
            this.radialGaugeArc10.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc10.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc10.BindEndRange = true;
            this.radialGaugeArc10.Name = "radialGaugeArc10";
            this.radialGaugeArc10.Radius = 0D;
            this.radialGaugeArc10.RangeEnd = 80D;
            this.radialGaugeArc10.RangeStart = 0D;
            this.radialGaugeArc10.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc10.Width = 40D;
            // 
            // radialGaugeArc11
            // 
            this.radialGaugeArc11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc11.BindStartRange = true;
            this.radialGaugeArc11.Name = "radialGaugeArc11";
            this.radialGaugeArc11.Radius = 0D;
            this.radialGaugeArc11.RangeEnd = 100D;
            this.radialGaugeArc11.RangeStart = 80D;
            this.radialGaugeArc11.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc11.Width = 40D;
            // 
            // radialGaugeNeedle7
            // 
            this.radialGaugeNeedle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radialGaugeNeedle7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radialGaugeNeedle7.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle7.BindValue = true;
            this.radialGaugeNeedle7.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle7.LenghtPercentage = 94D;
            this.radialGaugeNeedle7.Name = "radialGaugeNeedle7";
            this.radialGaugeNeedle7.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle7.Thickness = 5D;
            this.radialGaugeNeedle7.Value = 80F;
            this.radialGaugeNeedle7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeArc8
            // 
            this.radialGaugeArc8.BackColor = System.Drawing.Color.Black;
            this.radialGaugeArc8.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc8.BindEndRange = true;
            this.radialGaugeArc8.Name = "radialGaugeArc8";
            this.radialGaugeArc8.Radius = 0D;
            this.radialGaugeArc8.RangeEnd = 60D;
            this.radialGaugeArc8.RangeStart = 0D;
            this.radialGaugeArc8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc8.Width = 40D;
            // 
            // radialGaugeArc9
            // 
            this.radialGaugeArc9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc9.BindStartRange = true;
            this.radialGaugeArc9.Name = "radialGaugeArc9";
            this.radialGaugeArc9.Radius = 0D;
            this.radialGaugeArc9.RangeEnd = 100D;
            this.radialGaugeArc9.RangeStart = 60D;
            this.radialGaugeArc9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc9.Width = 40D;
            // 
            // radialGaugeSingleLabel2
            // 
            this.radialGaugeSingleLabel2.BindValue = true;
            this.radialGaugeSingleLabel2.ForeColor = System.Drawing.Color.Black;
            this.radialGaugeSingleLabel2.LabelFontSize = 10F;
            this.radialGaugeSingleLabel2.LabelText = "Text";
            this.radialGaugeSingleLabel2.LocationPercentage = new System.Drawing.SizeF(0F, -0.2F);
            this.radialGaugeSingleLabel2.Name = "radialGaugeSingleLabel2";
            this.radialGaugeSingleLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge2
            // 
            
            this.radRadialGauge2.BackColor = System.Drawing.Color.White;
            this.radRadialGauge2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc3,
            this.radialGaugeNeedle3,
            this.radialGaugeTicks5,
            this.radialGaugeTicks6,
            this.radialGaugeTicks7});
            this.radRadialGauge2.Location = new System.Drawing.Point(241, 4);
            this.radRadialGauge2.Name = "radRadialGauge2";
            this.radRadialGauge2.RangeEnd = 100D;
            this.radRadialGauge2.RangeStart = 0D;
            this.radRadialGauge2.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge2.StartAngle = 180D;
            this.radRadialGauge2.SweepAngle = 180D;
            this.radRadialGauge2.TabIndex = 3;
            this.radRadialGauge2.Text = "radRadialGauge4";
            this.radRadialGauge2.Value = 90F;
            // 
            // radialGaugeArc3
            // 
            this.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc3.Name = "radialGaugeArc3";
            this.radialGaugeArc3.Radius = 0D;
            this.radialGaugeArc3.RangeEnd = 100D;
            this.radialGaugeArc3.RangeStart = 0D;
            this.radialGaugeArc3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc3.Width = 1D;
            // 
            // radialGaugeNeedle3
            // 
            this.radialGaugeNeedle3.BackColor = System.Drawing.Color.Black;
            this.radialGaugeNeedle3.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeNeedle3.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle3.BindValue = true;
            this.radialGaugeNeedle3.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle3.LenghtPercentage = 80D;
            this.radialGaugeNeedle3.Name = "radialGaugeNeedle3";
            this.radialGaugeNeedle3.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle3.Thickness = 5D;
            this.radialGaugeNeedle3.Value = 90F;
            this.radialGaugeNeedle3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks5
            // 
            this.radialGaugeTicks5.DrawText = false;
            this.radialGaugeTicks5.Name = "radialGaugeTicks5";
            this.radialGaugeTicks5.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks5.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks5.TicksCount = 12;
            this.radialGaugeTicks5.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks5.TicksOffset = 5;
            this.radialGaugeTicks5.TickStartIndexVisibleRange = 1F;
            this.radialGaugeTicks5.TickThickness = 1F;
            this.radialGaugeTicks5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks6
            // 
            this.radialGaugeTicks6.DrawText = false;
            this.radialGaugeTicks6.Name = "radialGaugeTicks6";
            this.radialGaugeTicks6.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks6.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks6.TicksCount = 36;
            this.radialGaugeTicks6.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks6.TicksOffset = 0;
            this.radialGaugeTicks6.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks6.TickThickness = 1F;
            this.radialGaugeTicks6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks7
            // 
            this.radialGaugeTicks7.DrawText = false;
            this.radialGaugeTicks7.Name = "radialGaugeTicks7";
            this.radialGaugeTicks7.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks7.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks7.TicksCount = 1;
            this.radialGaugeTicks7.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks7.TicksOffset = 0;
            this.radialGaugeTicks7.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks7.TickThickness = 1F;
            this.radialGaugeTicks7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge3
            // 
            
            this.radRadialGauge3.BackColor = System.Drawing.Color.White;
            this.radRadialGauge3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc4,
            this.radialGaugeTicks8,
            this.radialGaugeNeedle4,
            this.radialGaugeLabels3});
            this.radRadialGauge3.Location = new System.Drawing.Point(447, 4);
            this.radRadialGauge3.Name = "radRadialGauge3";
            this.radRadialGauge3.RangeEnd = 100D;
            this.radRadialGauge3.RangeStart = 50D;
            this.radRadialGauge3.Size = new System.Drawing.Size(207, 200);
            this.radRadialGauge3.StartAngle = 270D;
            this.radRadialGauge3.SweepAngle = 90D;
            this.radRadialGauge3.TabIndex = 6;
            this.radRadialGauge3.Text = "radRadialGauge1";
            this.radRadialGauge3.Value = 90F;
            // 
            // radialGaugeArc4
            // 
            this.radialGaugeArc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.radialGaugeArc4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.radialGaugeArc4.Name = "radialGaugeArc4";
            this.radialGaugeArc4.Radius = 90D;
            this.radialGaugeArc4.RangeEnd = 100D;
            this.radialGaugeArc4.RangeStart = 0D;
            this.radialGaugeArc4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc4.Width = 1D;
            // 
            // radialGaugeTicks8
            // 
            this.radialGaugeTicks8.CircleTicks = true;
            this.radialGaugeTicks8.DrawText = false;
            this.radialGaugeTicks8.Name = "radialGaugeTicks8";
            this.radialGaugeTicks8.TickColor = System.Drawing.Color.Black;
            this.radialGaugeTicks8.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks8.TicksCount = 6;
            this.radialGaugeTicks8.TicksLenghtPercentage = 2F;
            this.radialGaugeTicks8.TicksOffset = 0;
            this.radialGaugeTicks8.TicksRadiusPercentage = 89F;
            this.radialGaugeTicks8.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks8.TickThickness = 1F;
            this.radialGaugeTicks8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle4
            // 
            this.radialGaugeNeedle4.BackColor = System.Drawing.Color.Red;
            this.radialGaugeNeedle4.BackColor2 = System.Drawing.Color.Red;
            this.radialGaugeNeedle4.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle4.BindValue = true;
            this.radialGaugeNeedle4.InnerPointRadiusPercentage = 1D;
            this.radialGaugeNeedle4.LenghtPercentage = 120D;
            this.radialGaugeNeedle4.Name = "radialGaugeNeedle4";
            this.radialGaugeNeedle4.PointRadiusPercentage = 3D;
            this.radialGaugeNeedle4.Thickness = 1D;
            this.radialGaugeNeedle4.Value = 90F;
            this.radialGaugeNeedle4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels3
            // 
            this.radialGaugeLabels3.DrawText = false;
            this.radialGaugeLabels3.LabelFontSize = 5F;
            this.radialGaugeLabels3.LabelRadiusPercentage = 105F;
            this.radialGaugeLabels3.LabelsCount = 1;
            this.radialGaugeLabels3.Name = "radialGaugeLabels3";
            this.radialGaugeLabels3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.White;
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Padding = new System.Windows.Forms.Padding(0);
            
            // 
            // radPanel2.PanelContainer
            // 
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge22);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge21);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge20);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge19);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge17);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge16);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge14);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge13);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge12);
            this.radPanel2.PanelContainer.Controls.Add(this.radRadialGauge15);
            this.radPanel2.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.PanelContainer.Size = new System.Drawing.Size(1193, 828);
            this.radPanel2.Size = new System.Drawing.Size(1193, 828);
            this.radPanel2.TabIndex = 7;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radRadialGauge22
            // 
            
            this.radRadialGauge22.BackColor = System.Drawing.Color.White;
            this.radRadialGauge22.CausesValidation = false;
            this.radRadialGauge22.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc41,
            this.radialGaugeArc42,
            this.radialGaugeLabels14,
            this.radialGaugeTicks34});
            this.radRadialGauge22.Location = new System.Drawing.Point(258, 428);
            this.radRadialGauge22.Name = "radRadialGauge22";
            this.radRadialGauge22.RangeEnd = 180D;
            this.radRadialGauge22.RangeStart = 0D;
            this.radRadialGauge22.Size = new System.Drawing.Size(166, 164);
            this.radRadialGauge22.StartAngle = 120D;
            this.radRadialGauge22.SweepAngle = 300D;
            this.radRadialGauge22.TabIndex = 6;
            this.radRadialGauge22.Text = "radRadialGauge1";
            this.radRadialGauge22.Value = 100F;
            // 
            // radialGaugeArc41
            // 
            this.radialGaugeArc41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.radialGaugeArc41.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.radialGaugeArc41.BindEndRange = true;
            this.radialGaugeArc41.Name = "radialGaugeArc41";
            this.radialGaugeArc41.Radius = 0D;
            this.radialGaugeArc41.RangeEnd = 100D;
            this.radialGaugeArc41.RangeStart = 0D;
            this.radialGaugeArc41.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc41.Width = 24D;
            // 
            // radialGaugeArc42
            // 
            this.radialGaugeArc42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc42.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc42.BindStartRange = true;
            this.radialGaugeArc42.Name = "radialGaugeArc42";
            this.radialGaugeArc42.Radius = 87D;
            this.radialGaugeArc42.RangeEnd = 180D;
            this.radialGaugeArc42.RangeStart = 100D;
            this.radialGaugeArc42.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc42.Width = 14D;
            // 
            // radialGaugeLabels14
            // 
            this.radialGaugeLabels14.DrawText = false;
            this.radialGaugeLabels14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels14.LabelFontSize = 6F;
            this.radialGaugeLabels14.LabelRadiusPercentage = 55F;
            this.radialGaugeLabels14.LabelsCount = 2;
            this.radialGaugeLabels14.Name = "radialGaugeLabels14";
            this.radialGaugeLabels14.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks34
            // 
            this.radialGaugeTicks34.DrawText = false;
            this.radialGaugeTicks34.Name = "radialGaugeTicks34";
            this.radialGaugeTicks34.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks34.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks34.TicksCount = 16;
            this.radialGaugeTicks34.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks34.TicksOffset = 0;
            this.radialGaugeTicks34.TicksRadiusPercentage = 64F;
            this.radialGaugeTicks34.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks34.TickThickness = 1F;
            this.radialGaugeTicks34.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge21
            // 
            
            this.radRadialGauge21.BackColor = System.Drawing.Color.White;
            this.radRadialGauge21.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc38,
            this.radialGaugeArc39,
            this.radialGaugeArc40,
            this.radialGaugeTicks33,
            this.radialGaugeLabels13,
            this.radialGaugeNeedle20});
            this.radRadialGauge21.Location = new System.Drawing.Point(13, 428);
            this.radRadialGauge21.Name = "radRadialGauge21";
            this.radRadialGauge21.RangeEnd = 180D;
            this.radRadialGauge21.RangeStart = 0D;
            this.radRadialGauge21.Size = new System.Drawing.Size(210, 198);
            this.radRadialGauge21.StartAngle = 130D;
            this.radRadialGauge21.SweepAngle = 280D;
            this.radRadialGauge21.TabIndex = 6;
            this.radRadialGauge21.Text = "radRadialGauge1";
            this.radRadialGauge21.Value = 90F;
            // 
            // radialGaugeArc38
            // 
            this.radialGaugeArc38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.radialGaugeArc38.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.radialGaugeArc38.Name = "radialGaugeArc38";
            this.radialGaugeArc38.Radius = 0D;
            this.radialGaugeArc38.RangeEnd = 60D;
            this.radialGaugeArc38.RangeStart = 0D;
            this.radialGaugeArc38.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc38.Width = 4D;
            // 
            // radialGaugeArc39
            // 
            this.radialGaugeArc39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc39.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc39.Name = "radialGaugeArc39";
            this.radialGaugeArc39.Radius = 0D;
            this.radialGaugeArc39.RangeEnd = 120D;
            this.radialGaugeArc39.RangeStart = 61D;
            this.radialGaugeArc39.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc39.Width = 4D;
            // 
            // radialGaugeArc40
            // 
            this.radialGaugeArc40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeArc40.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeArc40.Name = "radialGaugeArc40";
            this.radialGaugeArc40.Radius = 0D;
            this.radialGaugeArc40.RangeEnd = 180D;
            this.radialGaugeArc40.RangeStart = 121D;
            this.radialGaugeArc40.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc40.Width = 4D;
            // 
            // radialGaugeTicks33
            // 
            this.radialGaugeTicks33.DrawText = false;
            this.radialGaugeTicks33.Name = "radialGaugeTicks33";
            this.radialGaugeTicks33.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks33.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks33.TicksCount = 18;
            this.radialGaugeTicks33.TicksLenghtPercentage = 4F;
            this.radialGaugeTicks33.TicksOffset = 0;
            this.radialGaugeTicks33.TicksRadiusPercentage = 83F;
            this.radialGaugeTicks33.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks33.TickThickness = 1F;
            this.radialGaugeTicks33.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels13
            // 
            this.radialGaugeLabels13.DrawText = false;
            this.radialGaugeLabels13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels13.LabelFontSize = 5F;
            this.radialGaugeLabels13.LabelRadiusPercentage = 68F;
            this.radialGaugeLabels13.LabelsCount = 9;
            this.radialGaugeLabels13.Name = "radialGaugeLabels13";
            this.radialGaugeLabels13.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle20
            // 
            this.radialGaugeNeedle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeNeedle20.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeNeedle20.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle20.BindValue = true;
            this.radialGaugeNeedle20.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle20.LenghtPercentage = 70D;
            this.radialGaugeNeedle20.Name = "radialGaugeNeedle20";
            this.radialGaugeNeedle20.PointRadiusPercentage = 7D;
            this.radialGaugeNeedle20.Thickness = 1.5D;
            this.radialGaugeNeedle20.Value = 90F;
            this.radialGaugeNeedle20.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge20
            // 

            this.radRadialGauge20.BackColor = System.Drawing.Color.White;
            this.radRadialGauge20.CausesValidation = false;
            this.radRadialGauge20.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc35,
            this.radialGaugeArc36,
            this.radialGaugeArc37,
            this.radialGaugeTicks29,
            this.radialGaugeTicks30,
            this.radialGaugeNeedle19,
            this.radialGaugeTicks31,
            this.radialGaugeTicks32});
            this.radRadialGauge20.Location = new System.Drawing.Point(668, 211);
            this.radRadialGauge20.Name = "radRadialGauge20";
            this.radRadialGauge20.RangeEnd = 100D;
            this.radRadialGauge20.RangeStart = 0D;
            this.radRadialGauge20.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge20.StartAngle = 180D;
            this.radRadialGauge20.SweepAngle = 360D;
            this.radRadialGauge20.TabIndex = 6;
            this.radRadialGauge20.Text = "radRadialGauge1";
            this.radRadialGauge20.Value = 36F;
            // 
            // radialGaugeArc35
            // 
            this.radialGaugeArc35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.radialGaugeArc35.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(105)))), ((int)(((byte)(157)))));
            this.radialGaugeArc35.Name = "radialGaugeArc35";
            this.radialGaugeArc35.Radius = 88D;
            this.radialGaugeArc35.RangeEnd = 33D;
            this.radialGaugeArc35.RangeStart = 0D;
            this.radialGaugeArc35.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc35.Width = 14D;
            // 
            // radialGaugeArc36
            // 
            this.radialGaugeArc36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.radialGaugeArc36.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.radialGaugeArc36.Name = "radialGaugeArc36";
            this.radialGaugeArc36.Radius = 88D;
            this.radialGaugeArc36.RangeEnd = 100D;
            this.radialGaugeArc36.RangeStart = 33D;
            this.radialGaugeArc36.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc36.Width = 14D;
            // 
            // radialGaugeArc37
            // 
            this.radialGaugeArc37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(205)))), ((int)(((byte)(102)))));
            this.radialGaugeArc37.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(205)))), ((int)(((byte)(102)))));
            this.radialGaugeArc37.BindEndRange = true;
            this.radialGaugeArc37.Name = "radialGaugeArc37";
            this.radialGaugeArc37.Radius = 70D;
            this.radialGaugeArc37.RangeEnd = 36D;
            this.radialGaugeArc37.RangeStart = 0D;
            this.radialGaugeArc37.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc37.Width = 4D;
            // 
            // radialGaugeTicks29
            // 
            this.radialGaugeTicks29.DrawText = false;
            this.radialGaugeTicks29.Name = "radialGaugeTicks29";
            this.radialGaugeTicks29.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.radialGaugeTicks29.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks29.TicksCount = 24;
            this.radialGaugeTicks29.TicksLenghtPercentage = 8F;
            this.radialGaugeTicks29.TicksOffset = 0;
            this.radialGaugeTicks29.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks29.TickThickness = 1F;
            this.radialGaugeTicks29.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks30
            // 
            this.radialGaugeTicks30.DrawText = false;
            this.radialGaugeTicks30.Name = "radialGaugeTicks30";
            this.radialGaugeTicks30.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.radialGaugeTicks30.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks30.TicksCount = 72;
            this.radialGaugeTicks30.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks30.TicksOffset = 0;
            this.radialGaugeTicks30.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks30.TickThickness = 1F;
            this.radialGaugeTicks30.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle19
            // 
            this.radialGaugeNeedle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle19.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle19.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle19.BindValue = true;
            this.radialGaugeNeedle19.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle19.LenghtPercentage = 70D;
            this.radialGaugeNeedle19.Name = "radialGaugeNeedle19";
            this.radialGaugeNeedle19.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle19.Thickness = 0.4D;
            this.radialGaugeNeedle19.Value = 36F;
            this.radialGaugeNeedle19.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks31
            // 
            this.radialGaugeTicks31.DrawText = false;
            this.radialGaugeTicks31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks31.Name = "radialGaugeTicks31";
            this.radialGaugeTicks31.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks31.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks31.TicksCount = 1;
            this.radialGaugeTicks31.TicksLenghtPercentage = 14F;
            this.radialGaugeTicks31.TicksOffset = 0;
            this.radialGaugeTicks31.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks31.TickThickness = 1F;
            this.radialGaugeTicks31.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks32
            // 
            this.radialGaugeTicks32.CircleTicks = true;
            this.radialGaugeTicks32.DrawText = false;
            this.radialGaugeTicks32.Name = "radialGaugeTicks32";
            this.radialGaugeTicks32.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks32.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks32.TicksCount = 1;
            this.radialGaugeTicks32.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks32.TicksOffset = 0;
            this.radialGaugeTicks32.TicksRadiusPercentage = 106F;
            this.radialGaugeTicks32.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks32.TickThickness = 1F;
            this.radialGaugeTicks32.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge19
            // 
            
            this.radRadialGauge19.BackColor = System.Drawing.Color.White;
            this.radRadialGauge19.CausesValidation = false;
            this.radRadialGauge19.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc33,
            this.radialGaugeArc34,
            this.radialGaugeNeedle18,
            this.radialGaugeLabels12,
            this.radialGaugeSingleLabel6});
            this.radRadialGauge19.Location = new System.Drawing.Point(447, 211);
            this.radRadialGauge19.Name = "radRadialGauge19";
            this.radRadialGauge19.RangeEnd = 50D;
            this.radRadialGauge19.RangeStart = 0D;
            this.radRadialGauge19.Size = new System.Drawing.Size(214, 192);
            this.radRadialGauge19.StartAngle = 205D;
            this.radRadialGauge19.SweepAngle = 130D;
            this.radRadialGauge19.TabIndex = 6;
            this.radRadialGauge19.Text = "radRadialGauge1";
            this.radRadialGauge19.Value = 33F;
            // 
            // radialGaugeArc33
            // 
            this.radialGaugeArc33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(164)))));
            this.radialGaugeArc33.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(164)))));
            this.radialGaugeArc33.BindEndRange = true;
            this.radialGaugeArc33.Name = "radialGaugeArc33";
            this.radialGaugeArc33.Radius = 0D;
            this.radialGaugeArc33.RangeEnd = 33D;
            this.radialGaugeArc33.RangeStart = 0D;
            this.radialGaugeArc33.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc33.Width = 40D;
            // 
            // radialGaugeArc34
            // 
            this.radialGaugeArc34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc34.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc34.BindStartRange = true;
            this.radialGaugeArc34.Name = "radialGaugeArc34";
            this.radialGaugeArc34.Radius = 0D;
            this.radialGaugeArc34.RangeEnd = 50D;
            this.radialGaugeArc34.RangeStart = 33D;
            this.radialGaugeArc34.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc34.Width = 40D;
            // 
            // radialGaugeNeedle18
            // 
            this.radialGaugeNeedle18.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle18.BindValue = true;
            this.radialGaugeNeedle18.InnerPointRadiusPercentage = 4D;
            this.radialGaugeNeedle18.LenghtPercentage = 108D;
            this.radialGaugeNeedle18.Name = "radialGaugeNeedle18";
            this.radialGaugeNeedle18.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle18.Thickness = 0.7D;
            this.radialGaugeNeedle18.Value = 33F;
            this.radialGaugeNeedle18.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels12
            // 
            this.radialGaugeLabels12.DrawText = false;
            this.radialGaugeLabels12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels12.LabelRadiusPercentage = 112F;
            this.radialGaugeLabels12.LabelsCount = 1;
            this.radialGaugeLabels12.Name = "radialGaugeLabels12";
            this.radialGaugeLabels12.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeSingleLabel6
            // 
            this.radialGaugeSingleLabel6.BindValue = true;
            this.radialGaugeSingleLabel6.LabelFormat = "#0#.##";
            this.radialGaugeSingleLabel6.LabelText = "Text";
            this.radialGaugeSingleLabel6.LocationPercentage = new System.Drawing.SizeF(0F, 0.25F);
            this.radialGaugeSingleLabel6.Name = "radialGaugeSingleLabel6";
            this.radialGaugeSingleLabel6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge17
            // 
            
            this.radRadialGauge17.BackColor = System.Drawing.Color.White;
            this.radRadialGauge17.CausesValidation = false;
            this.radRadialGauge17.Controls.Add(this.radRadialGauge18);
            this.radRadialGauge17.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc29,
            this.radialGaugeArc30,
            this.radialGaugeSingleLabel5});
            this.radRadialGauge17.Location = new System.Drawing.Point(240, 211);
            this.radRadialGauge17.Name = "radRadialGauge17";
            this.radRadialGauge17.RangeEnd = 100D;
            this.radRadialGauge17.RangeStart = 0D;
            this.radRadialGauge17.Size = new System.Drawing.Size(204, 210);
            this.radRadialGauge17.StartAngle = 180D;
            this.radRadialGauge17.SweepAngle = 180D;
            this.radRadialGauge17.TabIndex = 6;
            this.radRadialGauge17.Text = "radRadialGauge1";
            this.radRadialGauge17.Value = 60F;
            // 
            // radRadialGauge18
            // 
            
            this.radRadialGauge18.BackColor = System.Drawing.Color.White;
            this.radRadialGauge18.CausesValidation = false;
            this.radRadialGauge18.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc31,
            this.radialGaugeArc32,
            this.radialGaugeNeedle17});
            this.radRadialGauge18.Location = new System.Drawing.Point(1, 100);
            this.radRadialGauge18.Name = "radRadialGauge18";
            this.radRadialGauge18.RangeEnd = 100D;
            this.radRadialGauge18.RangeStart = 0D;
            this.radRadialGauge18.Size = new System.Drawing.Size(200, 208);
            this.radRadialGauge18.StartAngle = 180D;
            this.radRadialGauge18.SweepAngle = 180D;
            this.radRadialGauge18.TabIndex = 6;
            this.radRadialGauge18.Text = "radRadialGauge1";
            this.radRadialGauge18.Value = 80F;
            // 
            // radialGaugeArc31
            // 
            this.radialGaugeArc31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(190)))), ((int)(((byte)(79)))));
            this.radialGaugeArc31.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(191)))), ((int)(((byte)(80)))));
            this.radialGaugeArc31.BindEndRange = true;
            this.radialGaugeArc31.Name = "radialGaugeArc31";
            this.radialGaugeArc31.Radius = 0D;
            this.radialGaugeArc31.RangeEnd = 80D;
            this.radialGaugeArc31.RangeStart = 0D;
            this.radialGaugeArc31.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc31.Width = 40D;
            // 
            // radialGaugeArc32
            // 
            this.radialGaugeArc32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc32.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc32.BindStartRange = true;
            this.radialGaugeArc32.Name = "radialGaugeArc32";
            this.radialGaugeArc32.Radius = 0D;
            this.radialGaugeArc32.RangeEnd = 100D;
            this.radialGaugeArc32.RangeStart = 80D;
            this.radialGaugeArc32.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc32.Width = 40D;
            // 
            // radialGaugeNeedle17
            // 
            this.radialGaugeNeedle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle17.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle17.BindValue = true;
            this.radialGaugeNeedle17.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle17.LenghtPercentage = 94D;
            this.radialGaugeNeedle17.Name = "radialGaugeNeedle17";
            this.radialGaugeNeedle17.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle17.Thickness = 5D;
            this.radialGaugeNeedle17.Value = 80F;
            this.radialGaugeNeedle17.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeArc29
            // 
            this.radialGaugeArc29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.radialGaugeArc29.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeArc29.BindEndRange = true;
            this.radialGaugeArc29.Name = "radialGaugeArc29";
            this.radialGaugeArc29.Radius = 0D;
            this.radialGaugeArc29.RangeEnd = 60D;
            this.radialGaugeArc29.RangeStart = 0D;
            this.radialGaugeArc29.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc29.Width = 40D;
            // 
            // radialGaugeArc30
            // 
            this.radialGaugeArc30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc30.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc30.BindStartRange = true;
            this.radialGaugeArc30.Name = "radialGaugeArc30";
            this.radialGaugeArc30.Radius = 0D;
            this.radialGaugeArc30.RangeEnd = 100D;
            this.radialGaugeArc30.RangeStart = 60D;
            this.radialGaugeArc30.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc30.Width = 40D;
            // 
            // radialGaugeSingleLabel5
            // 
            this.radialGaugeSingleLabel5.BindValue = true;
            this.radialGaugeSingleLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeSingleLabel5.LabelFontSize = 10F;
            this.radialGaugeSingleLabel5.LabelText = "Text";
            this.radialGaugeSingleLabel5.LocationPercentage = new System.Drawing.SizeF(0F, -0.2F);
            this.radialGaugeSingleLabel5.Name = "radialGaugeSingleLabel5";
            this.radialGaugeSingleLabel5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge16
            // 
            
            this.radRadialGauge16.BackColor = System.Drawing.Color.White;
            this.radRadialGauge16.CausesValidation = false;
            this.radRadialGauge16.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc27,
            this.radialGaugeArc28,
            this.radialGaugeLabels11,
            this.radialGaugeTicks28,
            this.radialGaugeSingleLabel4});
            this.radRadialGauge16.Location = new System.Drawing.Point(4, 211);
            this.radRadialGauge16.Name = "radRadialGauge16";
            this.radRadialGauge16.RangeEnd = 180D;
            this.radRadialGauge16.RangeStart = 0D;
            this.radRadialGauge16.Size = new System.Drawing.Size(229, 210);
            this.radRadialGauge16.StartAngle = 120D;
            this.radRadialGauge16.SweepAngle = 300D;
            this.radRadialGauge16.TabIndex = 6;
            this.radRadialGauge16.Text = "radRadialGauge1";
            this.radRadialGauge16.Value = 90F;
            // 
            // radialGaugeArc27
            // 
            this.radialGaugeArc27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.radialGaugeArc27.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(162)))));
            this.radialGaugeArc27.Name = "radialGaugeArc27";
            this.radialGaugeArc27.Radius = 80D;
            this.radialGaugeArc27.RangeEnd = 0D;
            this.radialGaugeArc27.RangeStart = 120D;
            this.radialGaugeArc27.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc27.Width = 15D;
            // 
            // radialGaugeArc28
            // 
            this.radialGaugeArc28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.radialGaugeArc28.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc28.Name = "radialGaugeArc28";
            this.radialGaugeArc28.Radius = 80D;
            this.radialGaugeArc28.RangeEnd = 180D;
            this.radialGaugeArc28.RangeStart = 120D;
            this.radialGaugeArc28.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc28.Width = 15D;
            // 
            // radialGaugeLabels11
            // 
            this.radialGaugeLabels11.DrawText = false;
            this.radialGaugeLabels11.LabelFontSize = 5F;
            this.radialGaugeLabels11.LabelRadiusPercentage = 108F;
            this.radialGaugeLabels11.LabelsCount = 9;
            this.radialGaugeLabels11.Name = "radialGaugeLabels11";
            this.radialGaugeLabels11.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks28
            // 
            this.radialGaugeTicks28.CircleTicks = true;
            this.radialGaugeTicks28.DrawText = false;
            this.radialGaugeTicks28.Name = "radialGaugeTicks28";
            this.radialGaugeTicks28.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.radialGaugeTicks28.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks28.TicksCount = 18;
            this.radialGaugeTicks28.TicksLenghtPercentage = 1F;
            this.radialGaugeTicks28.TicksOffset = 4;
            this.radialGaugeTicks28.TicksRadiusPercentage = 95F;
            this.radialGaugeTicks28.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks28.TickThickness = 1F;
            this.radialGaugeTicks28.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeSingleLabel4
            // 
            this.radialGaugeSingleLabel4.BindValue = true;
            this.radialGaugeSingleLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(109)))), ((int)(((byte)(161)))));
            this.radialGaugeSingleLabel4.LabelFontSize = 9F;
            this.radialGaugeSingleLabel4.LabelText = "Text";
            this.radialGaugeSingleLabel4.LocationPercentage = new System.Drawing.SizeF(0F, 0F);
            this.radialGaugeSingleLabel4.Name = "radialGaugeSingleLabel4";
            this.radialGaugeSingleLabel4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge14
            // 
            
            this.radRadialGauge14.BackColor = System.Drawing.Color.White;
            this.radRadialGauge14.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc25,
            this.radialGaugeTicks25,
            this.radialGaugeNeedle14,
            this.radialGaugeLabels10});
            this.radRadialGauge14.Location = new System.Drawing.Point(447, 4);
            this.radRadialGauge14.Name = "radRadialGauge14";
            this.radRadialGauge14.RangeEnd = 100D;
            this.radRadialGauge14.RangeStart = 50D;
            this.radRadialGauge14.Size = new System.Drawing.Size(207, 200);
            this.radRadialGauge14.StartAngle = 270D;
            this.radRadialGauge14.SweepAngle = 90D;
            this.radRadialGauge14.TabIndex = 6;
            this.radRadialGauge14.Text = "radRadialGauge1";
            this.radRadialGauge14.Value = 90F;
            // 
            // radialGaugeArc25
            // 
            this.radialGaugeArc25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.radialGaugeArc25.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.radialGaugeArc25.Name = "radialGaugeArc25";
            this.radialGaugeArc25.Radius = 90D;
            this.radialGaugeArc25.RangeEnd = 100D;
            this.radialGaugeArc25.RangeStart = 0D;
            this.radialGaugeArc25.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc25.Width = 1D;
            // 
            // radialGaugeTicks25
            // 
            this.radialGaugeTicks25.CircleTicks = true;
            this.radialGaugeTicks25.DrawText = false;
            this.radialGaugeTicks25.Name = "radialGaugeTicks25";
            this.radialGaugeTicks25.TickColor = System.Drawing.Color.Black;
            this.radialGaugeTicks25.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks25.TicksCount = 6;
            this.radialGaugeTicks25.TicksLenghtPercentage = 2F;
            this.radialGaugeTicks25.TicksOffset = 0;
            this.radialGaugeTicks25.TicksRadiusPercentage = 89F;
            this.radialGaugeTicks25.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks25.TickThickness = 1F;
            this.radialGaugeTicks25.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle14
            // 
            this.radialGaugeNeedle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.radialGaugeNeedle14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.radialGaugeNeedle14.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle14.BindValue = true;
            this.radialGaugeNeedle14.InnerPointRadiusPercentage = 1D;
            this.radialGaugeNeedle14.LenghtPercentage = 120D;
            this.radialGaugeNeedle14.Name = "radialGaugeNeedle14";
            this.radialGaugeNeedle14.PointRadiusPercentage = 3D;
            this.radialGaugeNeedle14.Thickness = 1D;
            this.radialGaugeNeedle14.Value = 90F;
            this.radialGaugeNeedle14.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels10
            // 
            this.radialGaugeLabels10.DrawText = false;
            this.radialGaugeLabels10.LabelFontSize = 5F;
            this.radialGaugeLabels10.LabelRadiusPercentage = 105F;
            this.radialGaugeLabels10.LabelsCount = 1;
            this.radialGaugeLabels10.Name = "radialGaugeLabels10";
            this.radialGaugeLabels10.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge13
            // 
            
            this.radRadialGauge13.BackColor = System.Drawing.Color.White;
            this.radRadialGauge13.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc24,
            this.radialGaugeNeedle13,
            this.radialGaugeTicks22,
            this.radialGaugeTicks23,
            this.radialGaugeTicks24});
            this.radRadialGauge13.Location = new System.Drawing.Point(241, 4);
            this.radRadialGauge13.Name = "radRadialGauge13";
            this.radRadialGauge13.RangeEnd = 100D;
            this.radRadialGauge13.RangeStart = 0D;
            this.radRadialGauge13.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge13.StartAngle = 180D;
            this.radRadialGauge13.SweepAngle = 180D;
            this.radRadialGauge13.TabIndex = 3;
            this.radRadialGauge13.Text = "radRadialGauge4";
            this.radRadialGauge13.Value = 90F;
            // 
            // radialGaugeArc24
            // 
            this.radialGaugeArc24.AccessibleDescription = "radialGaugeArc3";
            this.radialGaugeArc24.AccessibleName = "radialGaugeArc3";
            this.radialGaugeArc24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc24.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc24.Name = "radialGaugeArc24";
            this.radialGaugeArc24.Radius = 0D;
            this.radialGaugeArc24.RangeEnd = 100D;
            this.radialGaugeArc24.RangeStart = 0D;
            this.radialGaugeArc24.Text = "radialGaugeArc3";
            this.radialGaugeArc24.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc24.Width = 1D;
            // 
            // radialGaugeNeedle13
            // 
            this.radialGaugeNeedle13.AccessibleDescription = "radialGaugeNeedle3";
            this.radialGaugeNeedle13.AccessibleName = "radialGaugeNeedle3";
            this.radialGaugeNeedle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(164)))));
            this.radialGaugeNeedle13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(164)))));
            this.radialGaugeNeedle13.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle13.BindValue = true;
            this.radialGaugeNeedle13.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle13.LenghtPercentage = 80D;
            this.radialGaugeNeedle13.Name = "radialGaugeNeedle13";
            this.radialGaugeNeedle13.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle13.Text = "radialGaugeNeedle3";
            this.radialGaugeNeedle13.Thickness = 5D;
            this.radialGaugeNeedle13.Value = 90F;
            this.radialGaugeNeedle13.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks22
            // 
            this.radialGaugeTicks22.AccessibleDescription = "radialGaugeTicks5";
            this.radialGaugeTicks22.AccessibleName = "radialGaugeTicks5";
            this.radialGaugeTicks22.DrawText = false;
            this.radialGaugeTicks22.Name = "radialGaugeTicks22";
            this.radialGaugeTicks22.Text = "radialGaugeTicks5";
            this.radialGaugeTicks22.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks22.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks22.TicksCount = 12;
            this.radialGaugeTicks22.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks22.TicksOffset = 5;
            this.radialGaugeTicks22.TickStartIndexVisibleRange = 1F;
            this.radialGaugeTicks22.TickThickness = 1F;
            this.radialGaugeTicks22.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks23
            // 
            this.radialGaugeTicks23.AccessibleDescription = "radialGaugeTicks6";
            this.radialGaugeTicks23.AccessibleName = "radialGaugeTicks6";
            this.radialGaugeTicks23.DrawText = false;
            this.radialGaugeTicks23.Name = "radialGaugeTicks23";
            this.radialGaugeTicks23.Text = "radialGaugeTicks6";
            this.radialGaugeTicks23.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks23.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks23.TicksCount = 36;
            this.radialGaugeTicks23.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks23.TicksOffset = 0;
            this.radialGaugeTicks23.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks23.TickThickness = 1F;
            this.radialGaugeTicks23.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks24
            // 
            this.radialGaugeTicks24.AccessibleDescription = "radialGaugeTicks7";
            this.radialGaugeTicks24.AccessibleName = "radialGaugeTicks7";
            this.radialGaugeTicks24.DrawText = false;
            this.radialGaugeTicks24.Name = "radialGaugeTicks24";
            this.radialGaugeTicks24.Text = "radialGaugeTicks7";
            this.radialGaugeTicks24.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks24.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks24.TicksCount = 1;
            this.radialGaugeTicks24.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks24.TicksOffset = 0;
            this.radialGaugeTicks24.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks24.TickThickness = 1F;
            this.radialGaugeTicks24.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge12
            // 
            
            this.radRadialGauge12.BackColor = System.Drawing.Color.White;
            this.radRadialGauge12.CausesValidation = false;
            this.radRadialGauge12.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc43,
            this.radialGaugeArc44,
            this.radialGaugeTicks35,
            this.radialGaugeTicks36,
            this.radialGaugeTicks37,
            this.radialGaugeTicks38,
            this.radialGaugeLabels15,
            this.radialGaugeLabels16,
            this.radialGaugeNeedle21,
            this.radialGaugeNeedle22});
            this.radRadialGauge12.Location = new System.Drawing.Point(4, 4);
            this.radRadialGauge12.Name = "radRadialGauge12";
            this.radRadialGauge12.RangeEnd = 180D;
            this.radRadialGauge12.RangeStart = 0D;
            this.radRadialGauge12.Size = new System.Drawing.Size(229, 200);
            this.radRadialGauge12.StartAngle = 120D;
            this.radRadialGauge12.SweepAngle = 300D;
            this.radRadialGauge12.TabIndex = 1;
            this.radRadialGauge12.Text = "radRadialGauge2";
            this.radRadialGauge12.Value = 90F;
            // 
            // radialGaugeArc43
            // 
            this.radialGaugeArc43.AccessibleDescription = "radialGaugeArc1";
            this.radialGaugeArc43.AccessibleName = "radialGaugeArc1";
            this.radialGaugeArc43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc43.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc43.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc43.Name = "radialGaugeArc43";
            this.radialGaugeArc43.Radius = 0D;
            this.radialGaugeArc43.RangeEnd = 120D;
            this.radialGaugeArc43.RangeStart = 0D;
            this.radialGaugeArc43.Text = "radialGaugeArc1";
            this.radialGaugeArc43.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc43.Width = 1D;
            // 
            // radialGaugeArc44
            // 
            this.radialGaugeArc44.AccessibleDescription = "radialGaugeArc2";
            this.radialGaugeArc44.AccessibleName = "radialGaugeArc2";
            this.radialGaugeArc44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc44.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeArc44.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc44.Name = "radialGaugeArc44";
            this.radialGaugeArc44.Radius = 0D;
            this.radialGaugeArc44.RangeEnd = 180D;
            this.radialGaugeArc44.RangeStart = 120D;
            this.radialGaugeArc44.Text = "radialGaugeArc2";
            this.radialGaugeArc44.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc44.Width = 1D;
            // 
            // radialGaugeTicks35
            // 
            this.radialGaugeTicks35.AccessibleDescription = "radialGaugeTicks1";
            this.radialGaugeTicks35.AccessibleName = "radialGaugeTicks1";
            this.radialGaugeTicks35.DrawText = false;
            this.radialGaugeTicks35.Name = "radialGaugeTicks35";
            this.radialGaugeTicks35.Text = "radialGaugeTicks1";
            this.radialGaugeTicks35.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks35.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks35.TicksCount = 18;
            this.radialGaugeTicks35.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks35.TicksOffset = 0;
            this.radialGaugeTicks35.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks35.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks35.TickThickness = 1F;
            this.radialGaugeTicks35.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks36
            // 
            this.radialGaugeTicks36.AccessibleDescription = "radialGaugeTicks2";
            this.radialGaugeTicks36.AccessibleName = "radialGaugeTicks2";
            this.radialGaugeTicks36.DrawText = false;
            this.radialGaugeTicks36.Name = "radialGaugeTicks36";
            this.radialGaugeTicks36.Text = "radialGaugeTicks2";
            this.radialGaugeTicks36.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks36.TickEndIndexVisibleRange = 35F;
            this.radialGaugeTicks36.TicksCount = 54;
            this.radialGaugeTicks36.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks36.TicksOffset = 0;
            this.radialGaugeTicks36.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks36.TickThickness = 1F;
            this.radialGaugeTicks36.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks37
            // 
            this.radialGaugeTicks37.AccessibleDescription = "radialGaugeTicks3";
            this.radialGaugeTicks37.AccessibleName = "radialGaugeTicks3";
            this.radialGaugeTicks37.DrawText = false;
            this.radialGaugeTicks37.Name = "radialGaugeTicks37";
            this.radialGaugeTicks37.Text = "radialGaugeTicks3";
            this.radialGaugeTicks37.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks37.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks37.TicksCount = 18;
            this.radialGaugeTicks37.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks37.TicksOffset = 0;
            this.radialGaugeTicks37.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks37.TickStartIndexVisibleRange = 12F;
            this.radialGaugeTicks37.TickThickness = 1F;
            this.radialGaugeTicks37.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks38
            // 
            this.radialGaugeTicks38.AccessibleDescription = "radialGaugeTicks4";
            this.radialGaugeTicks38.AccessibleName = "radialGaugeTicks4";
            this.radialGaugeTicks38.DrawText = false;
            this.radialGaugeTicks38.Name = "radialGaugeTicks38";
            this.radialGaugeTicks38.Text = "radialGaugeTicks4";
            this.radialGaugeTicks38.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks38.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks38.TicksCount = 54;
            this.radialGaugeTicks38.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks38.TicksOffset = 0;
            this.radialGaugeTicks38.TickStartIndexVisibleRange = 37F;
            this.radialGaugeTicks38.TickThickness = 1F;
            this.radialGaugeTicks38.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels15
            // 
            this.radialGaugeLabels15.AccessibleDescription = "radialGaugeLabels1";
            this.radialGaugeLabels15.AccessibleName = "radialGaugeLabels1";
            this.radialGaugeLabels15.DrawText = false;
            this.radialGaugeLabels15.LabelEndVisibleRange = 100F;
            this.radialGaugeLabels15.LabelFontSize = 4F;
            this.radialGaugeLabels15.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels15.LabelsCount = 9;
            this.radialGaugeLabels15.Name = "radialGaugeLabels15";
            this.radialGaugeLabels15.Text = "radialGaugeLabels1";
            this.radialGaugeLabels15.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels16
            // 
            this.radialGaugeLabels16.AccessibleDescription = "radialGaugeLabels2";
            this.radialGaugeLabels16.AccessibleName = "radialGaugeLabels2";
            this.radialGaugeLabels16.DrawText = false;
            this.radialGaugeLabels16.ForeColor = System.Drawing.Color.Red;
            this.radialGaugeLabels16.LabelFontSize = 4F;
            this.radialGaugeLabels16.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels16.LabelsCount = 9;
            this.radialGaugeLabels16.LabelStartVisibleRange = 120F;
            this.radialGaugeLabels16.Name = "radialGaugeLabels16";
            this.radialGaugeLabels16.Text = "radialGaugeLabels2";
            this.radialGaugeLabels16.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle21
            // 
            this.radialGaugeNeedle21.AccessibleDescription = "radialGaugeNeedle1";
            this.radialGaugeNeedle21.AccessibleName = "radialGaugeNeedle1";
            this.radialGaugeNeedle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.radialGaugeNeedle21.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.radialGaugeNeedle21.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle21.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle21.LenghtPercentage = 78D;
            this.radialGaugeNeedle21.Name = "radialGaugeNeedle21";
            this.radialGaugeNeedle21.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle21.Text = "radialGaugeNeedle1";
            this.radialGaugeNeedle21.Thickness = 2D;
            this.radialGaugeNeedle21.Value = 90F;
            this.radialGaugeNeedle21.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle22
            // 
            this.radialGaugeNeedle22.AccessibleDescription = "radialGaugeNeedle2";
            this.radialGaugeNeedle22.AccessibleName = "radialGaugeNeedle2";
            this.radialGaugeNeedle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle22.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle22.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle22.BindValue = true;
            this.radialGaugeNeedle22.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle22.LenghtPercentage = 78D;
            this.radialGaugeNeedle22.Name = "radialGaugeNeedle22";
            this.radialGaugeNeedle22.PointRadiusPercentage = 6D;
            this.radialGaugeNeedle22.Text = "radialGaugeNeedle2";
            this.radialGaugeNeedle22.Thickness = 2D;
            this.radialGaugeNeedle22.Value = 90F;
            this.radialGaugeNeedle22.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge15
            // 
            
            this.radRadialGauge15.BackColor = System.Drawing.Color.White;
            this.radRadialGauge15.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc26,
            this.radialGaugeTicks26,
            this.radialGaugeTicks27,
            this.radialGaugeNeedle15,
            this.radialGaugeNeedle16});
            this.radRadialGauge15.Location = new System.Drawing.Point(661, 4);
            this.radRadialGauge15.Name = "radRadialGauge15";
            this.radRadialGauge15.RangeEnd = 100D;
            this.radRadialGauge15.RangeStart = 0D;
            this.radRadialGauge15.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge15.StartAngle = 0D;
            this.radRadialGauge15.SweepAngle = 360D;
            this.radRadialGauge15.TabIndex = 6;
            this.radRadialGauge15.Text = "radRadialGauge1";
            this.radRadialGauge15.Value = 90F;
            // 
            // radialGaugeArc26
            // 
            this.radialGaugeArc26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc26.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc26.Name = "radialGaugeArc26";
            this.radialGaugeArc26.Radius = 0D;
            this.radialGaugeArc26.RangeEnd = 100D;
            this.radialGaugeArc26.RangeStart = 0D;
            this.radialGaugeArc26.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc26.Width = 2D;
            // 
            // radialGaugeTicks26
            // 
            this.radialGaugeTicks26.DrawText = false;
            this.radialGaugeTicks26.Name = "radialGaugeTicks26";
            this.radialGaugeTicks26.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks26.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks26.TicksCount = 24;
            this.radialGaugeTicks26.TicksLenghtPercentage = 2F;
            this.radialGaugeTicks26.TicksOffset = 6;
            this.radialGaugeTicks26.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks26.TickThickness = 1F;
            this.radialGaugeTicks26.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks27
            // 
            this.radialGaugeTicks27.DrawText = false;
            this.radialGaugeTicks27.Name = "radialGaugeTicks27";
            this.radialGaugeTicks27.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks27.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks27.TicksCount = 72;
            this.radialGaugeTicks27.TicksLenghtPercentage = 1F;
            this.radialGaugeTicks27.TicksOffset = 1;
            this.radialGaugeTicks27.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks27.TickThickness = 1F;
            this.radialGaugeTicks27.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle15
            // 
            this.radialGaugeNeedle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(164)))));
            this.radialGaugeNeedle15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(112)))), ((int)(((byte)(164)))));
            this.radialGaugeNeedle15.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle15.BindValue = true;
            this.radialGaugeNeedle15.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle15.LenghtPercentage = 70D;
            this.radialGaugeNeedle15.Name = "radialGaugeNeedle15";
            this.radialGaugeNeedle15.PointRadiusPercentage = 4D;
            this.radialGaugeNeedle15.Thickness = 1D;
            this.radialGaugeNeedle15.Value = 90F;
            this.radialGaugeNeedle15.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle16
            // 
            this.radialGaugeNeedle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle16.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle16.BackLenghtPercentage = -55D;
            this.radialGaugeNeedle16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle16.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle16.LenghtPercentage = 70D;
            this.radialGaugeNeedle16.Name = "radialGaugeNeedle16";
            this.radialGaugeNeedle16.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle16.Thickness = 8D;
            this.radialGaugeNeedle16.Value = 60F;
            this.radialGaugeNeedle16.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeArc22
            // 
            this.radialGaugeArc22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc22.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc22.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc22.Name = "radialGaugeArc22";
            this.radialGaugeArc22.Radius = 0D;
            this.radialGaugeArc22.RangeEnd = 120D;
            this.radialGaugeArc22.RangeStart = 0D;
            this.radialGaugeArc22.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc22.Width = 1D;
            // 
            // radialGaugeArc23
            // 
            this.radialGaugeArc23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc23.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeArc23.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc23.Name = "radialGaugeArc23";
            this.radialGaugeArc23.Radius = 0D;
            this.radialGaugeArc23.RangeEnd = 180D;
            this.radialGaugeArc23.RangeStart = 120D;
            this.radialGaugeArc23.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc23.Width = 1D;
            // 
            // radialGaugeTicks18
            // 
            this.radialGaugeTicks18.DrawText = false;
            this.radialGaugeTicks18.Name = "radialGaugeTicks18";
            this.radialGaugeTicks18.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks18.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks18.TicksCount = 18;
            this.radialGaugeTicks18.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks18.TicksOffset = 0;
            this.radialGaugeTicks18.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks18.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks18.TickThickness = 1F;
            this.radialGaugeTicks18.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks19
            // 
            this.radialGaugeTicks19.DrawText = false;
            this.radialGaugeTicks19.Name = "radialGaugeTicks19";
            this.radialGaugeTicks19.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks19.TickEndIndexVisibleRange = 35F;
            this.radialGaugeTicks19.TicksCount = 54;
            this.radialGaugeTicks19.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks19.TicksOffset = 0;
            this.radialGaugeTicks19.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks19.TickThickness = 1F;
            this.radialGaugeTicks19.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks20
            // 
            this.radialGaugeTicks20.DrawText = false;
            this.radialGaugeTicks20.Name = "radialGaugeTicks20";
            this.radialGaugeTicks20.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks20.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks20.TicksCount = 18;
            this.radialGaugeTicks20.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks20.TicksOffset = 0;
            this.radialGaugeTicks20.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks20.TickStartIndexVisibleRange = 12F;
            this.radialGaugeTicks20.TickThickness = 1F;
            this.radialGaugeTicks20.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks21
            // 
            this.radialGaugeTicks21.DrawText = false;
            this.radialGaugeTicks21.Name = "radialGaugeTicks21";
            this.radialGaugeTicks21.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks21.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks21.TicksCount = 54;
            this.radialGaugeTicks21.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks21.TicksOffset = 0;
            this.radialGaugeTicks21.TickStartIndexVisibleRange = 37F;
            this.radialGaugeTicks21.TickThickness = 1F;
            this.radialGaugeTicks21.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels8
            // 
            this.radialGaugeLabels8.DrawText = false;
            this.radialGaugeLabels8.LabelEndVisibleRange = 100F;
            this.radialGaugeLabels8.LabelFontSize = 4F;
            this.radialGaugeLabels8.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels8.LabelsCount = 9;
            this.radialGaugeLabels8.Name = "radialGaugeLabels8";
            this.radialGaugeLabels8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels9
            // 
            this.radialGaugeLabels9.DrawText = false;
            this.radialGaugeLabels9.ForeColor = System.Drawing.Color.Red;
            this.radialGaugeLabels9.LabelFontSize = 4F;
            this.radialGaugeLabels9.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels9.LabelsCount = 9;
            this.radialGaugeLabels9.LabelStartVisibleRange = 120F;
            this.radialGaugeLabels9.Name = "radialGaugeLabels9";
            this.radialGaugeLabels9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle11
            // 
            this.radialGaugeNeedle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle11.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle11.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle11.LenghtPercentage = 78D;
            this.radialGaugeNeedle11.Name = "radialGaugeNeedle11";
            this.radialGaugeNeedle11.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle11.Thickness = 2D;
            this.radialGaugeNeedle11.Value = 90F;
            this.radialGaugeNeedle11.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle12
            // 
            this.radialGaugeNeedle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle12.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle12.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle12.LenghtPercentage = 78D;
            this.radialGaugeNeedle12.Name = "radialGaugeNeedle12";
            this.radialGaugeNeedle12.PointRadiusPercentage = 6D;
            this.radialGaugeNeedle12.Thickness = 2D;
            this.radialGaugeNeedle12.Value = 130F;
            this.radialGaugeNeedle12.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.White;
            this.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel3.Location = new System.Drawing.Point(0, 0);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radPanel3.PanelContainer
            // 
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge33);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge32);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge31);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge30);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge28);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge27);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge26);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge25);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge24);
            this.radPanel3.PanelContainer.Controls.Add(this.radRadialGauge23);
            this.radPanel3.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.radPanel3.PanelContainer.Size = new System.Drawing.Size(1193, 828);
            this.radPanel3.Size = new System.Drawing.Size(1193, 828);
            this.radPanel3.TabIndex = 7;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radRadialGauge33
            // 
            
            this.radRadialGauge33.BackColor = System.Drawing.Color.White;
            this.radRadialGauge33.CausesValidation = false;
            this.radRadialGauge33.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc64,
            this.radialGaugeArc65,
            this.radialGaugeLabels23,
            this.radialGaugeTicks55});
            this.radRadialGauge33.Location = new System.Drawing.Point(258, 428);
            this.radRadialGauge33.Name = "radRadialGauge33";
            this.radRadialGauge33.RangeEnd = 180D;
            this.radRadialGauge33.RangeStart = 0D;
            this.radRadialGauge33.Size = new System.Drawing.Size(166, 164);
            this.radRadialGauge33.StartAngle = 120D;
            this.radRadialGauge33.SweepAngle = 300D;
            this.radRadialGauge33.TabIndex = 6;
            this.radRadialGauge33.Text = "radRadialGauge1";
            this.radRadialGauge33.Value = 100F;
            // 
            // radialGaugeArc64
            // 
            this.radialGaugeArc64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc64.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc64.BindEndRange = true;
            this.radialGaugeArc64.Name = "radialGaugeArc64";
            this.radialGaugeArc64.Radius = 0D;
            this.radialGaugeArc64.RangeEnd = 100D;
            this.radialGaugeArc64.RangeStart = 0D;
            this.radialGaugeArc64.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc64.Width = 24D;
            // 
            // radialGaugeArc65
            // 
            this.radialGaugeArc65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.radialGaugeArc65.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.radialGaugeArc65.BindStartRange = true;
            this.radialGaugeArc65.Name = "radialGaugeArc65";
            this.radialGaugeArc65.Radius = 87D;
            this.radialGaugeArc65.RangeEnd = 180D;
            this.radialGaugeArc65.RangeStart = 100D;
            this.radialGaugeArc65.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc65.Width = 14D;
            // 
            // radialGaugeLabels23
            // 
            this.radialGaugeLabels23.DrawText = false;
            this.radialGaugeLabels23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels23.LabelFontSize = 6F;
            this.radialGaugeLabels23.LabelRadiusPercentage = 55F;
            this.radialGaugeLabels23.LabelsCount = 2;
            this.radialGaugeLabels23.Name = "radialGaugeLabels23";
            this.radialGaugeLabels23.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks55
            // 
            this.radialGaugeTicks55.DrawText = false;
            this.radialGaugeTicks55.Name = "radialGaugeTicks55";
            this.radialGaugeTicks55.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks55.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks55.TicksCount = 16;
            this.radialGaugeTicks55.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks55.TicksOffset = 0;
            this.radialGaugeTicks55.TicksRadiusPercentage = 64F;
            this.radialGaugeTicks55.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks55.TickThickness = 1F;
            this.radialGaugeTicks55.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge32
            // 
            
            this.radRadialGauge32.BackColor = System.Drawing.Color.White;
            this.radRadialGauge32.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc61,
            this.radialGaugeArc62,
            this.radialGaugeArc63,
            this.radialGaugeTicks54,
            this.radialGaugeLabels22,
            this.radialGaugeNeedle32});
            this.radRadialGauge32.Location = new System.Drawing.Point(13, 428);
            this.radRadialGauge32.Name = "radRadialGauge32";
            this.radRadialGauge32.RangeEnd = 180D;
            this.radRadialGauge32.RangeStart = 0D;
            this.radRadialGauge32.Size = new System.Drawing.Size(210, 198);
            this.radRadialGauge32.StartAngle = 130D;
            this.radRadialGauge32.SweepAngle = 280D;
            this.radRadialGauge32.TabIndex = 6;
            this.radRadialGauge32.Text = "radRadialGauge1";
            this.radRadialGauge32.Value = 90F;
            // 
            // radialGaugeArc61
            // 
            this.radialGaugeArc61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.radialGaugeArc61.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.radialGaugeArc61.Name = "radialGaugeArc61";
            this.radialGaugeArc61.Radius = 0D;
            this.radialGaugeArc61.RangeEnd = 60D;
            this.radialGaugeArc61.RangeStart = 0D;
            this.radialGaugeArc61.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc61.Width = 3D;
            // 
            // radialGaugeArc62
            // 
            this.radialGaugeArc62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc62.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc62.Name = "radialGaugeArc62";
            this.radialGaugeArc62.Radius = 0D;
            this.radialGaugeArc62.RangeEnd = 120D;
            this.radialGaugeArc62.RangeStart = 61D;
            this.radialGaugeArc62.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc62.Width = 3D;
            // 
            // radialGaugeArc63
            // 
            this.radialGaugeArc63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeArc63.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeArc63.Name = "radialGaugeArc63";
            this.radialGaugeArc63.Radius = 0D;
            this.radialGaugeArc63.RangeEnd = 180D;
            this.radialGaugeArc63.RangeStart = 121D;
            this.radialGaugeArc63.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc63.Width = 3D;
            // 
            // radialGaugeTicks54
            // 
            this.radialGaugeTicks54.DrawText = false;
            this.radialGaugeTicks54.Name = "radialGaugeTicks54";
            this.radialGaugeTicks54.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks54.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks54.TicksCount = 18;
            this.radialGaugeTicks54.TicksLenghtPercentage = 4F;
            this.radialGaugeTicks54.TicksOffset = 0;
            this.radialGaugeTicks54.TicksRadiusPercentage = 83F;
            this.radialGaugeTicks54.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks54.TickThickness = 1F;
            this.radialGaugeTicks54.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels22
            // 
            this.radialGaugeLabels22.DrawText = false;
            this.radialGaugeLabels22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels22.LabelFontSize = 5F;
            this.radialGaugeLabels22.LabelRadiusPercentage = 68F;
            this.radialGaugeLabels22.LabelsCount = 9;
            this.radialGaugeLabels22.Name = "radialGaugeLabels22";
            this.radialGaugeLabels22.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle32
            // 
            this.radialGaugeNeedle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeNeedle32.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.radialGaugeNeedle32.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle32.BindValue = true;
            this.radialGaugeNeedle32.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle32.LenghtPercentage = 70D;
            this.radialGaugeNeedle32.Name = "radialGaugeNeedle32";
            this.radialGaugeNeedle32.PointRadiusPercentage = 7D;
            this.radialGaugeNeedle32.Thickness = 1.5D;
            this.radialGaugeNeedle32.Value = 90F;
            this.radialGaugeNeedle32.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge31
            // 
            
            this.radRadialGauge31.BackColor = System.Drawing.Color.White;
            this.radRadialGauge31.CausesValidation = false;
            this.radRadialGauge31.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc58,
            this.radialGaugeArc59,
            this.radialGaugeArc60,
            this.radialGaugeTicks50,
            this.radialGaugeTicks51,
            this.radialGaugeNeedle31,
            this.radialGaugeTicks52,
            this.radialGaugeTicks53});
            this.radRadialGauge31.Location = new System.Drawing.Point(668, 211);
            this.radRadialGauge31.Name = "radRadialGauge31";
            this.radRadialGauge31.RangeEnd = 100D;
            this.radRadialGauge31.RangeStart = 0D;
            this.radRadialGauge31.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge31.StartAngle = 180D;
            this.radRadialGauge31.SweepAngle = 360D;
            this.radRadialGauge31.TabIndex = 6;
            this.radRadialGauge31.Text = "radRadialGauge1";
            this.radRadialGauge31.Value = 36F;
            // 
            // radialGaugeArc58
            // 
            this.radialGaugeArc58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.radialGaugeArc58.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.radialGaugeArc58.Name = "radialGaugeArc58";
            this.radialGaugeArc58.Radius = 88D;
            this.radialGaugeArc58.RangeEnd = 33D;
            this.radialGaugeArc58.RangeStart = 0D;
            this.radialGaugeArc58.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc58.Width = 14D;
            // 
            // radialGaugeArc59
            // 
            this.radialGaugeArc59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.radialGaugeArc59.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.radialGaugeArc59.Name = "radialGaugeArc59";
            this.radialGaugeArc59.Radius = 88D;
            this.radialGaugeArc59.RangeEnd = 100D;
            this.radialGaugeArc59.RangeStart = 33D;
            this.radialGaugeArc59.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc59.Width = 14D;
            // 
            // radialGaugeArc60
            // 
            this.radialGaugeArc60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(152)))), ((int)(((byte)(38)))));
            this.radialGaugeArc60.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(152)))), ((int)(((byte)(38)))));
            this.radialGaugeArc60.BindEndRange = true;
            this.radialGaugeArc60.Name = "radialGaugeArc60";
            this.radialGaugeArc60.Radius = 70D;
            this.radialGaugeArc60.RangeEnd = 36D;
            this.radialGaugeArc60.RangeStart = 0D;
            this.radialGaugeArc60.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc60.Width = 4D;
            // 
            // radialGaugeTicks50
            // 
            this.radialGaugeTicks50.DrawText = false;
            this.radialGaugeTicks50.Name = "radialGaugeTicks50";
            this.radialGaugeTicks50.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.radialGaugeTicks50.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks50.TicksCount = 24;
            this.radialGaugeTicks50.TicksLenghtPercentage = 8F;
            this.radialGaugeTicks50.TicksOffset = 0;
            this.radialGaugeTicks50.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks50.TickThickness = 1F;
            this.radialGaugeTicks50.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks51
            // 
            this.radialGaugeTicks51.DrawText = false;
            this.radialGaugeTicks51.Name = "radialGaugeTicks51";
            this.radialGaugeTicks51.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.radialGaugeTicks51.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks51.TicksCount = 72;
            this.radialGaugeTicks51.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks51.TicksOffset = 0;
            this.radialGaugeTicks51.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks51.TickThickness = 1F;
            this.radialGaugeTicks51.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle31
            // 
            this.radialGaugeNeedle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle31.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle31.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle31.BindValue = true;
            this.radialGaugeNeedle31.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle31.LenghtPercentage = 70D;
            this.radialGaugeNeedle31.Name = "radialGaugeNeedle31";
            this.radialGaugeNeedle31.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle31.Thickness = 0.4D;
            this.radialGaugeNeedle31.Value = 36F;
            this.radialGaugeNeedle31.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks52
            // 
            this.radialGaugeTicks52.DrawText = false;
            this.radialGaugeTicks52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks52.Name = "radialGaugeTicks52";
            this.radialGaugeTicks52.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks52.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks52.TicksCount = 1;
            this.radialGaugeTicks52.TicksLenghtPercentage = 14F;
            this.radialGaugeTicks52.TicksOffset = 0;
            this.radialGaugeTicks52.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks52.TickThickness = 1F;
            this.radialGaugeTicks52.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks53
            // 
            this.radialGaugeTicks53.CircleTicks = true;
            this.radialGaugeTicks53.DrawText = false;
            this.radialGaugeTicks53.Name = "radialGaugeTicks53";
            this.radialGaugeTicks53.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.radialGaugeTicks53.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks53.TicksCount = 1;
            this.radialGaugeTicks53.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks53.TicksOffset = 0;
            this.radialGaugeTicks53.TicksRadiusPercentage = 106F;
            this.radialGaugeTicks53.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks53.TickThickness = 1F;
            this.radialGaugeTicks53.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge30
            // 
            
            this.radRadialGauge30.BackColor = System.Drawing.Color.White;
            this.radRadialGauge30.CausesValidation = false;
            this.radRadialGauge30.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc56,
            this.radialGaugeArc57,
            this.radialGaugeNeedle30,
            this.radialGaugeLabels21,
            this.radialGaugeSingleLabel9});
            this.radRadialGauge30.Location = new System.Drawing.Point(447, 211);
            this.radRadialGauge30.Name = "radRadialGauge30";
            this.radRadialGauge30.RangeEnd = 50D;
            this.radRadialGauge30.RangeStart = 0D;
            this.radRadialGauge30.Size = new System.Drawing.Size(214, 192);
            this.radRadialGauge30.StartAngle = 205D;
            this.radRadialGauge30.SweepAngle = 130D;
            this.radRadialGauge30.TabIndex = 6;
            this.radRadialGauge30.Text = "radRadialGauge1";
            this.radRadialGauge30.Value = 33F;
            // 
            // radialGaugeArc56
            // 
            this.radialGaugeArc56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc56.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc56.BindEndRange = true;
            this.radialGaugeArc56.Name = "radialGaugeArc56";
            this.radialGaugeArc56.Radius = 0D;
            this.radialGaugeArc56.RangeEnd = 33D;
            this.radialGaugeArc56.RangeStart = 0D;
            this.radialGaugeArc56.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc56.Width = 40D;
            // 
            // radialGaugeArc57
            // 
            this.radialGaugeArc57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc57.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.radialGaugeArc57.BindStartRange = true;
            this.radialGaugeArc57.Name = "radialGaugeArc57";
            this.radialGaugeArc57.Radius = 0D;
            this.radialGaugeArc57.RangeEnd = 50D;
            this.radialGaugeArc57.RangeStart = 33D;
            this.radialGaugeArc57.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc57.Width = 40D;
            // 
            // radialGaugeNeedle30
            // 
            this.radialGaugeNeedle30.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle30.BindValue = true;
            this.radialGaugeNeedle30.InnerPointRadiusPercentage = 4D;
            this.radialGaugeNeedle30.LenghtPercentage = 110D;
            this.radialGaugeNeedle30.Name = "radialGaugeNeedle30";
            this.radialGaugeNeedle30.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle30.Thickness = 0.7D;
            this.radialGaugeNeedle30.Value = 33F;
            this.radialGaugeNeedle30.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels21
            // 
            this.radialGaugeLabels21.DrawText = false;
            this.radialGaugeLabels21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeLabels21.LabelRadiusPercentage = 112F;
            this.radialGaugeLabels21.LabelsCount = 1;
            this.radialGaugeLabels21.Name = "radialGaugeLabels21";
            this.radialGaugeLabels21.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeSingleLabel9
            // 
            this.radialGaugeSingleLabel9.BindValue = true;
            this.radialGaugeSingleLabel9.LabelFormat = "#0#.##";
            this.radialGaugeSingleLabel9.LabelText = "Text";
            this.radialGaugeSingleLabel9.LocationPercentage = new System.Drawing.SizeF(0F, 0.25F);
            this.radialGaugeSingleLabel9.Name = "radialGaugeSingleLabel9";
            this.radialGaugeSingleLabel9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge28
            // 
            
            this.radRadialGauge28.BackColor = System.Drawing.Color.White;
            this.radRadialGauge28.CausesValidation = false;
            this.radRadialGauge28.Controls.Add(this.radRadialGauge29);
            this.radRadialGauge28.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc53,
            this.radialGaugeArc54,
            this.radialGaugeSingleLabel8});
            this.radRadialGauge28.Location = new System.Drawing.Point(240, 211);
            this.radRadialGauge28.Name = "radRadialGauge28";
            this.radRadialGauge28.RangeEnd = 100D;
            this.radRadialGauge28.RangeStart = 0D;
            this.radRadialGauge28.Size = new System.Drawing.Size(204, 210);
            this.radRadialGauge28.StartAngle = 180D;
            this.radRadialGauge28.SweepAngle = 180D;
            this.radRadialGauge28.TabIndex = 6;
            this.radRadialGauge28.Text = "radRadialGauge1";
            this.radRadialGauge28.Value = 60F;
            // 
            // radRadialGauge29
            // 
            
            this.radRadialGauge29.BackColor = System.Drawing.Color.White;
            this.radRadialGauge29.CausesValidation = false;
            this.radRadialGauge29.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc55,
            this.radialGaugeNeedle29});
            this.radRadialGauge29.Location = new System.Drawing.Point(1, 101);
            this.radRadialGauge29.Name = "radRadialGauge29";
            this.radRadialGauge29.RangeEnd = 100D;
            this.radRadialGauge29.RangeStart = 0D;
            this.radRadialGauge29.Size = new System.Drawing.Size(204, 210);
            this.radRadialGauge29.StartAngle = 180D;
            this.radRadialGauge29.SweepAngle = 180D;
            this.radRadialGauge29.TabIndex = 6;
            this.radRadialGauge29.Text = "radRadialGauge1";
            this.radRadialGauge29.Value = 80F;
            // 
            // radialGaugeArc55
            // 
            this.radialGaugeArc55.BackColor = System.Drawing.Color.Red;
            this.radialGaugeArc55.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(191)))), ((int)(((byte)(80)))));
            this.radialGaugeArc55.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow;
            this.radialGaugeArc55.Name = "radialGaugeArc55";
            this.radialGaugeArc55.Radius = 0D;
            this.radialGaugeArc55.RangeEnd = 100D;
            this.radialGaugeArc55.RangeStart = 0D;
            this.radialGaugeArc55.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc55.Width = 44D;
            // 
            // radialGaugeNeedle29
            // 
            this.radialGaugeNeedle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle29.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle29.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle29.BindValue = true;
            this.radialGaugeNeedle29.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle29.LenghtPercentage = 94D;
            this.radialGaugeNeedle29.Name = "radialGaugeNeedle29";
            this.radialGaugeNeedle29.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle29.Thickness = 5D;
            this.radialGaugeNeedle29.Value = 80F;
            this.radialGaugeNeedle29.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeArc53
            // 
            this.radialGaugeArc53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(152)))), ((int)(((byte)(38)))));
            this.radialGaugeArc53.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(152)))), ((int)(((byte)(38)))));
            this.radialGaugeArc53.BindEndRange = true;
            this.radialGaugeArc53.Name = "radialGaugeArc53";
            this.radialGaugeArc53.Radius = 0D;
            this.radialGaugeArc53.RangeEnd = 60D;
            this.radialGaugeArc53.RangeStart = 0D;
            this.radialGaugeArc53.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc53.Width = 40D;
            // 
            // radialGaugeArc54
            // 
            this.radialGaugeArc54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc54.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc54.BindStartRange = true;
            this.radialGaugeArc54.Name = "radialGaugeArc54";
            this.radialGaugeArc54.Radius = 0D;
            this.radialGaugeArc54.RangeEnd = 100D;
            this.radialGaugeArc54.RangeStart = 60D;
            this.radialGaugeArc54.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc54.Width = 40D;
            // 
            // radialGaugeSingleLabel8
            // 
            this.radialGaugeSingleLabel8.BindValue = true;
            this.radialGaugeSingleLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(152)))), ((int)(((byte)(38)))));
            this.radialGaugeSingleLabel8.LabelFontSize = 10F;
            this.radialGaugeSingleLabel8.LabelText = "Text";
            this.radialGaugeSingleLabel8.LocationPercentage = new System.Drawing.SizeF(0F, -0.2F);
            this.radialGaugeSingleLabel8.Name = "radialGaugeSingleLabel8";
            this.radialGaugeSingleLabel8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge27
            // 
            
            this.radRadialGauge27.BackColor = System.Drawing.Color.White;
            this.radRadialGauge27.CausesValidation = false;
            this.radRadialGauge27.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc51,
            this.radialGaugeArc52,
            this.radialGaugeLabels20,
            this.radialGaugeTicks49,
            this.radialGaugeSingleLabel7});
            this.radRadialGauge27.Location = new System.Drawing.Point(4, 211);
            this.radRadialGauge27.Name = "radRadialGauge27";
            this.radRadialGauge27.RangeEnd = 180D;
            this.radRadialGauge27.RangeStart = 0D;
            this.radRadialGauge27.Size = new System.Drawing.Size(229, 210);
            this.radRadialGauge27.StartAngle = 120D;
            this.radRadialGauge27.SweepAngle = 300D;
            this.radRadialGauge27.TabIndex = 6;
            this.radRadialGauge27.Text = "radRadialGauge1";
            this.radRadialGauge27.Value = 90F;
            // 
            // radialGaugeArc51
            // 
            this.radialGaugeArc51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc51.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeArc51.Name = "radialGaugeArc51";
            this.radialGaugeArc51.Radius = 80D;
            this.radialGaugeArc51.RangeEnd = 0D;
            this.radialGaugeArc51.RangeStart = 120D;
            this.radialGaugeArc51.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc51.Width = 15D;
            // 
            // radialGaugeArc52
            // 
            this.radialGaugeArc52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.radialGaugeArc52.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.radialGaugeArc52.Name = "radialGaugeArc52";
            this.radialGaugeArc52.Radius = 80D;
            this.radialGaugeArc52.RangeEnd = 180D;
            this.radialGaugeArc52.RangeStart = 120D;
            this.radialGaugeArc52.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc52.Width = 15D;
            // 
            // radialGaugeLabels20
            // 
            this.radialGaugeLabels20.DrawText = false;
            this.radialGaugeLabels20.LabelFontSize = 5F;
            this.radialGaugeLabels20.LabelRadiusPercentage = 108F;
            this.radialGaugeLabels20.LabelsCount = 9;
            this.radialGaugeLabels20.Name = "radialGaugeLabels20";
            this.radialGaugeLabels20.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks49
            // 
            this.radialGaugeTicks49.CircleTicks = true;
            this.radialGaugeTicks49.DrawText = false;
            this.radialGaugeTicks49.Name = "radialGaugeTicks49";
            this.radialGaugeTicks49.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.radialGaugeTicks49.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks49.TicksCount = 18;
            this.radialGaugeTicks49.TicksLenghtPercentage = 1F;
            this.radialGaugeTicks49.TicksOffset = 4;
            this.radialGaugeTicks49.TicksRadiusPercentage = 95F;
            this.radialGaugeTicks49.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks49.TickThickness = 1F;
            this.radialGaugeTicks49.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeSingleLabel7
            // 
            this.radialGaugeSingleLabel7.BindValue = true;
            this.radialGaugeSingleLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeSingleLabel7.LabelText = "Text";
            this.radialGaugeSingleLabel7.LocationPercentage = new System.Drawing.SizeF(0F, 0F);
            this.radialGaugeSingleLabel7.Name = "radialGaugeSingleLabel7";
            this.radialGaugeSingleLabel7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge26
            // 
            
            this.radRadialGauge26.BackColor = System.Drawing.Color.White;
            this.radRadialGauge26.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc49,
            this.radialGaugeArc50,
            this.radialGaugeTicks47,
            this.radialGaugeTicks48,
            this.radialGaugeNeedle27,
            this.radialGaugeNeedle28});
            this.radRadialGauge26.Location = new System.Drawing.Point(661, 4);
            this.radRadialGauge26.Name = "radRadialGauge26";
            this.radRadialGauge26.RangeEnd = 100D;
            this.radRadialGauge26.RangeStart = 0D;
            this.radRadialGauge26.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge26.StartAngle = 0D;
            this.radRadialGauge26.SweepAngle = 360D;
            this.radRadialGauge26.TabIndex = 6;
            this.radRadialGauge26.Text = "radRadialGauge1";
            this.radRadialGauge26.Value = 90F;
            // 
            // radialGaugeArc49
            // 
            this.radialGaugeArc49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc49.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc49.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow2;
            this.radialGaugeArc49.Name = "radialGaugeArc49";
            this.radialGaugeArc49.Radius = 0D;
            this.radialGaugeArc49.RangeEnd = 102D;
            this.radialGaugeArc49.RangeStart = 50.1D;
            this.radialGaugeArc49.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc49.Width = 2D;
            // 
            // radialGaugeArc50
            // 
            this.radialGaugeArc50.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow3;
            this.radialGaugeArc50.Name = "radialGaugeArc50";
            this.radialGaugeArc50.Radius = 0D;
            this.radialGaugeArc50.RangeEnd = 51D;
            this.radialGaugeArc50.RangeStart = -1D;
            this.radialGaugeArc50.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc50.Width = 2D;
            // 
            // radialGaugeTicks47
            // 
            this.radialGaugeTicks47.DrawText = false;
            this.radialGaugeTicks47.Name = "radialGaugeTicks47";
            this.radialGaugeTicks47.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks47.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks47.TicksCount = 24;
            this.radialGaugeTicks47.TicksLenghtPercentage = 2F;
            this.radialGaugeTicks47.TicksOffset = 6;
            this.radialGaugeTicks47.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks47.TickThickness = 1F;
            this.radialGaugeTicks47.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks48
            // 
            this.radialGaugeTicks48.DrawText = false;
            this.radialGaugeTicks48.Name = "radialGaugeTicks48";
            this.radialGaugeTicks48.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks48.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks48.TicksCount = 72;
            this.radialGaugeTicks48.TicksLenghtPercentage = 1F;
            this.radialGaugeTicks48.TicksOffset = 1;
            this.radialGaugeTicks48.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks48.TickThickness = 1F;
            this.radialGaugeTicks48.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle27
            // 
            this.radialGaugeNeedle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle27.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle27.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle27.BindValue = true;
            this.radialGaugeNeedle27.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle27.LenghtPercentage = 70D;
            this.radialGaugeNeedle27.Name = "radialGaugeNeedle27";
            this.radialGaugeNeedle27.PointRadiusPercentage = 4D;
            this.radialGaugeNeedle27.Thickness = 1D;
            this.radialGaugeNeedle27.Value = 90F;
            this.radialGaugeNeedle27.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle28
            // 
            this.radialGaugeNeedle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle28.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.radialGaugeNeedle28.BackLenghtPercentage = -55D;
            this.radialGaugeNeedle28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle28.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle28.LenghtPercentage = 70D;
            this.radialGaugeNeedle28.Name = "radialGaugeNeedle28";
            this.radialGaugeNeedle28.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle28.Thickness = 8D;
            this.radialGaugeNeedle28.Value = 60F;
            this.radialGaugeNeedle28.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge25
            // 
            
            this.radRadialGauge25.BackColor = System.Drawing.Color.White;
            this.radRadialGauge25.CausesValidation = false;
            this.radRadialGauge25.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc48,
            this.radialGaugeTicks46,
            this.radialGaugeNeedle26,
            this.radialGaugeLabels19});
            this.radRadialGauge25.Location = new System.Drawing.Point(447, 4);
            this.radRadialGauge25.Name = "radRadialGauge25";
            this.radRadialGauge25.RangeEnd = 100D;
            this.radRadialGauge25.RangeStart = 50D;
            this.radRadialGauge25.Size = new System.Drawing.Size(207, 200);
            this.radRadialGauge25.StartAngle = 270D;
            this.radRadialGauge25.SweepAngle = 90D;
            this.radRadialGauge25.TabIndex = 6;
            this.radRadialGauge25.Text = "radRadialGauge1";
            this.radRadialGauge25.Value = 90F;
            // 
            // radialGaugeArc48
            // 
            this.radialGaugeArc48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.radialGaugeArc48.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.radialGaugeArc48.Name = "radialGaugeArc48";
            this.radialGaugeArc48.Radius = 90D;
            this.radialGaugeArc48.RangeEnd = 100D;
            this.radialGaugeArc48.RangeStart = 0D;
            this.radialGaugeArc48.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc48.Width = 1D;
            // 
            // radialGaugeTicks46
            // 
            this.radialGaugeTicks46.CircleTicks = true;
            this.radialGaugeTicks46.DrawText = false;
            this.radialGaugeTicks46.Name = "radialGaugeTicks46";
            this.radialGaugeTicks46.TickColor = System.Drawing.Color.Black;
            this.radialGaugeTicks46.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks46.TicksCount = 6;
            this.radialGaugeTicks46.TicksLenghtPercentage = 2F;
            this.radialGaugeTicks46.TicksOffset = 0;
            this.radialGaugeTicks46.TicksRadiusPercentage = 89F;
            this.radialGaugeTicks46.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks46.TickThickness = 1F;
            this.radialGaugeTicks46.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle26
            // 
            this.radialGaugeNeedle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle26.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle26.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle26.BindValue = true;
            this.radialGaugeNeedle26.InnerPointRadiusPercentage = 1D;
            this.radialGaugeNeedle26.LenghtPercentage = 120D;
            this.radialGaugeNeedle26.Name = "radialGaugeNeedle26";
            this.radialGaugeNeedle26.PointRadiusPercentage = 3D;
            this.radialGaugeNeedle26.Thickness = 1D;
            this.radialGaugeNeedle26.Value = 90F;
            this.radialGaugeNeedle26.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels19
            // 
            this.radialGaugeLabels19.DrawText = false;
            this.radialGaugeLabels19.LabelFontSize = 5F;
            this.radialGaugeLabels19.LabelRadiusPercentage = 105F;
            this.radialGaugeLabels19.LabelsCount = 1;
            this.radialGaugeLabels19.Name = "radialGaugeLabels19";
            this.radialGaugeLabels19.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge24
            // 
            
            this.radRadialGauge24.BackColor = System.Drawing.Color.White;
            this.radRadialGauge24.CausesValidation = false;
            this.radRadialGauge24.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc47,
            this.radialGaugeNeedle25,
            this.radialGaugeTicks43,
            this.radialGaugeTicks44,
            this.radialGaugeTicks45});
            this.radRadialGauge24.Location = new System.Drawing.Point(241, 4);
            this.radRadialGauge24.Name = "radRadialGauge24";
            this.radRadialGauge24.RangeEnd = 100D;
            this.radRadialGauge24.RangeStart = 0D;
            this.radRadialGauge24.Size = new System.Drawing.Size(200, 200);
            this.radRadialGauge24.StartAngle = 180D;
            this.radRadialGauge24.SweepAngle = 180D;
            this.radRadialGauge24.TabIndex = 3;
            this.radRadialGauge24.Text = "radRadialGauge4";
            this.radRadialGauge24.Value = 90F;
            // 
            // radialGaugeArc47
            // 
            this.radialGaugeArc47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc47.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc47.Name = "radialGaugeArc47";
            this.radialGaugeArc47.Radius = 0D;
            this.radialGaugeArc47.RangeEnd = 100D;
            this.radialGaugeArc47.RangeStart = 0D;
            this.radialGaugeArc47.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc47.Width = 1D;
            // 
            // radialGaugeNeedle25
            // 
            this.radialGaugeNeedle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle25.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle25.BackLenghtPercentage = 0D;
            this.radialGaugeNeedle25.BindValue = true;
            this.radialGaugeNeedle25.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle25.LenghtPercentage = 80D;
            this.radialGaugeNeedle25.Name = "radialGaugeNeedle25";
            this.radialGaugeNeedle25.PointRadiusPercentage = 5D;
            this.radialGaugeNeedle25.Thickness = 5D;
            this.radialGaugeNeedle25.Value = 90F;
            this.radialGaugeNeedle25.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks43
            // 
            this.radialGaugeTicks43.DrawText = false;
            this.radialGaugeTicks43.Name = "radialGaugeTicks43";
            this.radialGaugeTicks43.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks43.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks43.TicksCount = 12;
            this.radialGaugeTicks43.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks43.TicksOffset = 5;
            this.radialGaugeTicks43.TickStartIndexVisibleRange = 1F;
            this.radialGaugeTicks43.TickThickness = 1F;
            this.radialGaugeTicks43.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks44
            // 
            this.radialGaugeTicks44.DrawText = false;
            this.radialGaugeTicks44.Name = "radialGaugeTicks44";
            this.radialGaugeTicks44.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks44.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks44.TicksCount = 36;
            this.radialGaugeTicks44.TicksLenghtPercentage = 5F;
            this.radialGaugeTicks44.TicksOffset = 0;
            this.radialGaugeTicks44.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks44.TickThickness = 1F;
            this.radialGaugeTicks44.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks45
            // 
            this.radialGaugeTicks45.DrawText = false;
            this.radialGaugeTicks45.Name = "radialGaugeTicks45";
            this.radialGaugeTicks45.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks45.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks45.TicksCount = 1;
            this.radialGaugeTicks45.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks45.TicksOffset = 0;
            this.radialGaugeTicks45.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks45.TickThickness = 1F;
            this.radialGaugeTicks45.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radRadialGauge23
            // 
            
            this.radRadialGauge23.BackColor = System.Drawing.Color.White;
            this.radRadialGauge23.CausesValidation = false;
            this.radRadialGauge23.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radialGaugeArc45,
            this.radialGaugeArc46,
            this.radialGaugeTicks39,
            this.radialGaugeTicks40,
            this.radialGaugeTicks41,
            this.radialGaugeTicks42,
            this.radialGaugeLabels17,
            this.radialGaugeLabels18,
            this.radialGaugeNeedle23,
            this.radialGaugeNeedle24});
            this.radRadialGauge23.Location = new System.Drawing.Point(4, 4);
            this.radRadialGauge23.Name = "radRadialGauge23";
            this.radRadialGauge23.RangeEnd = 180D;
            this.radRadialGauge23.RangeStart = 0D;
            this.radRadialGauge23.Size = new System.Drawing.Size(229, 200);
            this.radRadialGauge23.StartAngle = 120D;
            this.radRadialGauge23.SweepAngle = 300D;
            this.radRadialGauge23.TabIndex = 1;
            this.radRadialGauge23.Text = "radRadialGauge2";
            this.radRadialGauge23.Value = 90F;
            // 
            // radialGaugeArc45
            // 
            this.radialGaugeArc45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc45.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc45.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc45.Name = "radialGaugeArc45";
            this.radialGaugeArc45.Radius = 0D;
            this.radialGaugeArc45.RangeEnd = 120D;
            this.radialGaugeArc45.RangeStart = 0D;
            this.radialGaugeArc45.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc45.Width = 1D;
            // 
            // radialGaugeArc46
            // 
            this.radialGaugeArc46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc46.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeArc46.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc46.Name = "radialGaugeArc46";
            this.radialGaugeArc46.Radius = 0D;
            this.radialGaugeArc46.RangeEnd = 180D;
            this.radialGaugeArc46.RangeStart = 120D;
            this.radialGaugeArc46.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radialGaugeArc46.Width = 1D;
            // 
            // radialGaugeTicks39
            // 
            this.radialGaugeTicks39.DrawText = false;
            this.radialGaugeTicks39.Name = "radialGaugeTicks39";
            this.radialGaugeTicks39.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks39.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks39.TicksCount = 18;
            this.radialGaugeTicks39.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks39.TicksOffset = 0;
            this.radialGaugeTicks39.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks39.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks39.TickThickness = 1F;
            this.radialGaugeTicks39.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks40
            // 
            this.radialGaugeTicks40.DrawText = false;
            this.radialGaugeTicks40.Name = "radialGaugeTicks40";
            this.radialGaugeTicks40.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks40.TickEndIndexVisibleRange = 35F;
            this.radialGaugeTicks40.TicksCount = 54;
            this.radialGaugeTicks40.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks40.TicksOffset = 0;
            this.radialGaugeTicks40.TickStartIndexVisibleRange = null;
            this.radialGaugeTicks40.TickThickness = 1F;
            this.radialGaugeTicks40.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks41
            // 
            this.radialGaugeTicks41.DrawText = false;
            this.radialGaugeTicks41.Name = "radialGaugeTicks41";
            this.radialGaugeTicks41.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks41.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks41.TicksCount = 18;
            this.radialGaugeTicks41.TicksLenghtPercentage = 10F;
            this.radialGaugeTicks41.TicksOffset = 0;
            this.radialGaugeTicks41.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks41.TickStartIndexVisibleRange = 12F;
            this.radialGaugeTicks41.TickThickness = 1F;
            this.radialGaugeTicks41.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeTicks42
            // 
            this.radialGaugeTicks42.DrawText = false;
            this.radialGaugeTicks42.Name = "radialGaugeTicks42";
            this.radialGaugeTicks42.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks42.TickEndIndexVisibleRange = null;
            this.radialGaugeTicks42.TicksCount = 54;
            this.radialGaugeTicks42.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks42.TicksOffset = 0;
            this.radialGaugeTicks42.TickStartIndexVisibleRange = 37F;
            this.radialGaugeTicks42.TickThickness = 1F;
            this.radialGaugeTicks42.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels17
            // 
            this.radialGaugeLabels17.DrawText = false;
            this.radialGaugeLabels17.LabelEndVisibleRange = 100F;
            this.radialGaugeLabels17.LabelFontSize = 4F;
            this.radialGaugeLabels17.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels17.LabelsCount = 9;
            this.radialGaugeLabels17.Name = "radialGaugeLabels17";
            this.radialGaugeLabels17.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeLabels18
            // 
            this.radialGaugeLabels18.DrawText = false;
            this.radialGaugeLabels18.ForeColor = System.Drawing.Color.Red;
            this.radialGaugeLabels18.LabelFontSize = 4F;
            this.radialGaugeLabels18.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels18.LabelsCount = 9;
            this.radialGaugeLabels18.LabelStartVisibleRange = 120F;
            this.radialGaugeLabels18.Name = "radialGaugeLabels18";
            this.radialGaugeLabels18.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle23
            // 
            this.radialGaugeNeedle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle23.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle23.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle23.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle23.LenghtPercentage = 78D;
            this.radialGaugeNeedle23.Name = "radialGaugeNeedle23";
            this.radialGaugeNeedle23.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle23.Thickness = 2D;
            this.radialGaugeNeedle23.Value = 90F;
            this.radialGaugeNeedle23.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radialGaugeNeedle24
            // 
            this.radialGaugeNeedle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle24.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle24.BackLenghtPercentage = 10D;
            this.radialGaugeNeedle24.BindValue = true;
            this.radialGaugeNeedle24.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle24.LenghtPercentage = 78D;
            this.radialGaugeNeedle24.Name = "radialGaugeNeedle24";
            this.radialGaugeNeedle24.PointRadiusPercentage = 6D;
            this.radialGaugeNeedle24.Thickness = 2D;
            this.radialGaugeNeedle24.Value = 90F;
            this.radialGaugeNeedle24.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radGroupBox1.Controls.Add(this.radRadioButton3);
            this.radGroupBox1.Controls.Add(this.radRadioButton2);
            this.radGroupBox1.Controls.Add(this.radRadioButton1);
            this.radGroupBox1.HeaderText = "Style";
            this.radGroupBox1.Location = new System.Drawing.Point(10, 33);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(210, 100);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Style";
            // 
            // radRadioButton3
            // 
            this.radRadioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radRadioButton3.Location = new System.Drawing.Point(5, 23);
            this.radRadioButton3.Name = "radRadioButton3";
            this.radRadioButton3.Size = new System.Drawing.Size(65, 18);
            this.radRadioButton3.TabIndex = 2;
            this.radRadioButton3.TabStop = true;
            this.radRadioButton3.Text = "Standard";
            this.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton2.Location = new System.Drawing.Point(5, 47);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(60, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.Text = "Vibrant";
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton1.Location = new System.Drawing.Point(5, 71);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(54, 18);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.Text = "Minimalistic";
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel3);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1203, 838);
            this.Controls.SetChildIndex(this.radPanel3, 0);
            this.Controls.SetChildIndex(this.radPanel1, 0);
            this.Controls.SetChildIndex(this.radPanel2, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.radPanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge6)).EndInit();
            this.radRadialGauge6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge3)).EndInit();
            this.radPanel2.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge17)).EndInit();
            this.radRadialGauge17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge15)).EndInit();
            this.radPanel3.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge28)).EndInit();
            this.radRadialGauge28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadialGauge23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScrollablePanel radPanel1;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge5;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc6;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc7;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels4;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks11;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel1;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge4;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc5;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks9;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks10;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle5;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle6;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge3;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc4;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks8;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle4;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels3;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc3;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle3;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks5;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks6;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks7;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks3;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks4;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels2;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle1;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle2;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge6;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge7;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc10;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc11;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle7;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc8;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc9;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel2;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge11;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc20;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc21;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels7;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks17;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge10;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc17;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc18;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc19;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks16;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels6;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle10;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge9;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc14;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc15;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc16;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks12;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks13;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle9;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks14;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks15;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge8;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc12;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc13;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle8;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels5;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel3;
        private Telerik.WinControls.UI.RadScrollablePanel radPanel2;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge17;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc29;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc30;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel5;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge16;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc27;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc28;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels11;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks28;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel4;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge14;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc25;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks25;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle14;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels10;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge13;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc24;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle13;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks22;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks23;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks24;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge12;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc22;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc23;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks18;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks19;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks20;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks21;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels8;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels9;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle11;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle12;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge15;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc26;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks26;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks27;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle15;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle16;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge18;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc31;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc32;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle17;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge22;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc41;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc42;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels14;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks34;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge21;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc38;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc39;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc40;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks33;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels13;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle20;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge20;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc35;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc36;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc37;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks29;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks30;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle19;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks31;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks32;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge19;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc33;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc34;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle18;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels12;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel6;
        private Telerik.WinControls.UI.RadScrollablePanel radPanel3;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc43;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc44;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks35;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks36;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks37;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks38;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels15;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels16;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle21;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle22;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge23;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge28;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge29;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc55;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle29;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc53;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc54;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel8;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge27;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc51;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc52;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels20;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks49;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel7;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge26;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc49;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc50;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks47;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks48;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle27;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle28;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge25;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc48;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks46;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle26;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels19;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge24;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc47;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle25;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks43;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks44;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks45;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc45;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc46;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks39;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks40;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks41;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks42;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels17;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels18;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle23;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle24;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge33;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc64;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc65;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels23;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks55;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge32;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc61;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc62;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc63;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks54;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels22;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle32;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge31;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc58;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc59;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc60;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks50;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks51;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle31;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks52;
        private Telerik.WinControls.UI.Gauges.RadialGaugeTicks radialGaugeTicks53;
        private Telerik.WinControls.UI.Gauges.RadRadialGauge radRadialGauge30;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc56;
        private Telerik.WinControls.UI.Gauges.RadialGaugeArc radialGaugeArc57;
        private Telerik.WinControls.UI.Gauges.RadialGaugeNeedle radialGaugeNeedle30;
        private Telerik.WinControls.UI.Gauges.RadialGaugeLabels radialGaugeLabels21;
        private Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel radialGaugeSingleLabel9;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton3;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
    }
}