using System.Drawing;
using Telerik.WinControls.Primitives;
namespace Telerik.Examples.WinControls.Gauges.LinearGallery
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radRadioButton3 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radScrollablePanel1 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radBulletGraph4 = new Telerik.WinControls.UI.Gauges.RadBulletGraph();
            this.bulletGraphQualitativeBar10 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar11 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar12 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphFeaturedMeasureBar4 = new Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar();
            this.linearGaugeNeedleIndicator10 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.linearGaugeLabels24 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radBulletGraph3 = new Telerik.WinControls.UI.Gauges.RadBulletGraph();
            this.bulletGraphQualitativeBar7 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar8 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar9 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphFeaturedMeasureBar3 = new Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar();
            this.linearGaugeNeedleIndicator9 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.linearGaugeLabels23 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge15 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar27 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar28 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine19 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks33 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels14 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge14 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar25 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar26 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine18 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks32 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels13 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge13 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar22 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar23 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar24 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine17 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks31 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels12 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeNeedleIndicator4 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.radLinearGauge12 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar20 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar21 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeTicks30 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.radLinearGauge11 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar18 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar19 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeTicks28 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLine16 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks29 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels11 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge10 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar16 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar17 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine14 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeLine15 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks24 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks25 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks26 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks27 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels9 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeLabels10 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge9 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar15 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine11 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeLine12 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks20 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels8 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeTicks21 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks22 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLine13 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks23 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeNeedleIndicator3 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.radScrollablePanel2 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radBulletGraph2 = new Telerik.WinControls.UI.Gauges.RadBulletGraph();
            this.bulletGraphQualitativeBar4 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar5 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar6 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphFeaturedMeasureBar2 = new Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar();
            this.linearGaugeNeedleIndicator8 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.linearGaugeLabels22 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radBulletGraph1 = new Telerik.WinControls.UI.Gauges.RadBulletGraph();
            this.bulletGraphQualitativeBar1 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar2 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar3 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphFeaturedMeasureBar1 = new Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar();
            this.linearGaugeNeedleIndicator7 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.linearGaugeLabels21 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge21 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar39 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar40 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine25 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks39 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels20 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge20 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar37 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar38 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine24 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks38 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels19 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge19 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar36 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine23 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks37 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels18 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeNeedleIndicator6 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.radLinearGauge8 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar13 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar14 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeTicks19 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.radLinearGauge7 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar11 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar12 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeTicks17 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLine10 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks18 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels7 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge6 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar9 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar10 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine9 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks15 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels6 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeTicks16 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.radLinearGauge5 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar8 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine7 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks12 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels5 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeTicks13 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLine8 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks14 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeNeedleIndicator2 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.radScrollablePanel3 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radBulletGraph6 = new Telerik.WinControls.UI.Gauges.RadBulletGraph();
            this.bulletGraphQualitativeBar16 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar17 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar18 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphFeaturedMeasureBar6 = new Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar();
            this.linearGaugeNeedleIndicator12 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.linearGaugeLabels26 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radBulletGraph5 = new Telerik.WinControls.UI.Gauges.RadBulletGraph();
            this.bulletGraphQualitativeBar13 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar14 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphQualitativeBar15 = new Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar();
            this.bulletGraphFeaturedMeasureBar5 = new Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar();
            this.linearGaugeNeedleIndicator11 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.linearGaugeLabels25 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge18 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar34 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar35 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine22 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks36 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels17 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge17 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar32 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar33 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine21 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks35 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels16 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge16 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar29 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar30 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar31 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine20 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks34 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels15 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeNeedleIndicator5 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            this.radLinearGauge4 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar6 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar7 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeTicks11 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.radLinearGauge3 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar4 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar5 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeTicks9 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLine6 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks10 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels4 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge2 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar2 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeBar3 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine4 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeLine5 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks5 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks6 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks7 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks8 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels2 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeLabels3 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.radLinearGauge1 = new Telerik.WinControls.UI.Gauges.RadLinearGauge();
            this.linearGaugeBar1 = new Telerik.WinControls.UI.Gauges.LinearGaugeBar();
            this.linearGaugeLine1 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeLine2 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks1 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLabels1 = new Telerik.WinControls.UI.Gauges.LinearGaugeLabels();
            this.linearGaugeTicks2 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeTicks3 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeLine3 = new Telerik.WinControls.UI.Gauges.LinearGaugeLine();
            this.linearGaugeTicks4 = new Telerik.WinControls.UI.Gauges.LinearGaugeTicks();
            this.linearGaugeNeedleIndicator1 = new Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).BeginInit();
            this.radScrollablePanel1.PanelContainer.SuspendLayout();
            this.radScrollablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel2)).BeginInit();
            this.radScrollablePanel2.PanelContainer.SuspendLayout();
            this.radScrollablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel3)).BeginInit();
            this.radScrollablePanel3.PanelContainer.SuspendLayout();
            this.radScrollablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.radGroupBox1);
            this.settingsPanel.Location = new System.Drawing.Point(1122, 0);
            this.settingsPanel.Controls.SetChildIndex(this.radGroupBox1, 0);
            // 
            // radialGaugeArc22
            // 
            this.radialGaugeArc22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc22.BackColor2 = System.Drawing.Color.Black;
            this.radialGaugeArc22.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeArc22.Name = "radialGaugeArc22";
            this.radialGaugeArc22.RangeEnd = 120D;
            this.radialGaugeArc22.Width = 1D;
            // 
            // radialGaugeArc23
            // 
            this.radialGaugeArc23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc23.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeArc23.BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.radialGaugeArc23.Name = "radialGaugeArc23";
            this.radialGaugeArc23.RangeEnd = 180D;
            this.radialGaugeArc23.RangeStart = 120D;
            this.radialGaugeArc23.Width = 1D;
            // 
            // radialGaugeTicks18
            // 
            this.radialGaugeTicks18.DrawText = false;
            this.radialGaugeTicks18.Name = "radialGaugeTicks18";
            this.radialGaugeTicks18.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks18.TickEndIndexVisibleRange = 11F;
            this.radialGaugeTicks18.TicksCount = 18;
            this.radialGaugeTicks18.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks18.TickThickness = 1F;
            // 
            // radialGaugeTicks19
            // 
            this.radialGaugeTicks19.DrawText = false;
            this.radialGaugeTicks19.Name = "radialGaugeTicks19";
            this.radialGaugeTicks19.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.radialGaugeTicks19.TickEndIndexVisibleRange = 35F;
            this.radialGaugeTicks19.TicksCount = 54;
            this.radialGaugeTicks19.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks19.TickThickness = 1F;
            // 
            // radialGaugeTicks20
            // 
            this.radialGaugeTicks20.DrawText = false;
            this.radialGaugeTicks20.Name = "radialGaugeTicks20";
            this.radialGaugeTicks20.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks20.TicksCount = 18;
            this.radialGaugeTicks20.TicksRadiusPercentage = 84F;
            this.radialGaugeTicks20.TickStartIndexVisibleRange = 12F;
            this.radialGaugeTicks20.TickThickness = 1F;
            // 
            // radialGaugeTicks21
            // 
            this.radialGaugeTicks21.DrawText = false;
            this.radialGaugeTicks21.Name = "radialGaugeTicks21";
            this.radialGaugeTicks21.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeTicks21.TicksCount = 54;
            this.radialGaugeTicks21.TicksLenghtPercentage = 3F;
            this.radialGaugeTicks21.TickStartIndexVisibleRange = 37F;
            this.radialGaugeTicks21.TickThickness = 1F;
            // 
            // radialGaugeLabels8
            // 
            this.radialGaugeLabels8.DrawText = false;
            this.radialGaugeLabels8.LabelEndVisibleRange = 100F;
            this.radialGaugeLabels8.LabelFontSize = 4F;
            this.radialGaugeLabels8.LabelRadiusPercentage = 75F;
            this.radialGaugeLabels8.LabelsCount = 9;
            this.radialGaugeLabels8.Name = "radialGaugeLabels8";
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
            // 
            // radialGaugeNeedle11
            // 
            this.radialGaugeNeedle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.radialGaugeNeedle11.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle11.LenghtPercentage = 78D;
            this.radialGaugeNeedle11.Name = "radialGaugeNeedle11";
            this.radialGaugeNeedle11.PointRadiusPercentage = 0D;
            this.radialGaugeNeedle11.Thickness = 2D;
            this.radialGaugeNeedle11.Value = 90F;
            // 
            // radialGaugeNeedle12
            // 
            this.radialGaugeNeedle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.radialGaugeNeedle12.InnerPointRadiusPercentage = 0D;
            this.radialGaugeNeedle12.LenghtPercentage = 78D;
            this.radialGaugeNeedle12.Name = "radialGaugeNeedle12";
            this.radialGaugeNeedle12.PointRadiusPercentage = 6D;
            this.radialGaugeNeedle12.Thickness = 2D;
            this.radialGaugeNeedle12.Value = 130F;
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
            this.radRadioButton3.Text = "Standard";
            this.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton2.Location = new System.Drawing.Point(5, 47);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(57, 18);
            this.radRadioButton2.TabIndex = 1;
            this.radRadioButton2.Text = "Vibrant";
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radRadioButton1.Location = new System.Drawing.Point(5, 71);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(80, 18);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.Text = "Minimalistic";
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // radScrollablePanel1
            // 
            this.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScrollablePanel1.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel1.Name = "radScrollablePanel1";
            this.radScrollablePanel1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radScrollablePanel1.PanelContainer
            // 
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radBulletGraph4);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radBulletGraph3);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radLinearGauge15);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radLinearGauge14);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radLinearGauge13);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radLinearGauge12);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radLinearGauge11);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radLinearGauge10);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radLinearGauge9);
            this.radScrollablePanel1.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel1.PanelContainer.Size = new System.Drawing.Size(1210, 804);
            this.radScrollablePanel1.Size = new System.Drawing.Size(1210, 804);
            this.radScrollablePanel1.TabIndex = 2;
            this.radScrollablePanel1.Text = "radScrollablePanel1";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radScrollablePanel1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radBulletGraph4
            // 
            this.radBulletGraph4.BackColor = System.Drawing.Color.White;
            this.radBulletGraph4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bulletGraphQualitativeBar10,
            this.bulletGraphQualitativeBar11,
            this.bulletGraphQualitativeBar12,
            this.bulletGraphFeaturedMeasureBar4,
            this.linearGaugeNeedleIndicator10,
            this.linearGaugeLabels24});
            this.radBulletGraph4.Location = new System.Drawing.Point(577, 249);
            this.radBulletGraph4.Name = "radBulletGraph4";
            this.radBulletGraph4.Padding = new System.Windows.Forms.Padding(5, 0, 10, 20);
            this.radBulletGraph4.Size = new System.Drawing.Size(280, 50);
            this.radBulletGraph4.TabIndex = 3;
            this.radBulletGraph4.Text = "radBulletGraph1";
            this.radBulletGraph4.Value = 0F;
            // 
            // bulletGraphQualitativeBar10
            // 
            this.bulletGraphQualitativeBar10.Name = "bulletGraphQualitativeBar10";
            this.bulletGraphQualitativeBar10.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar10.RangeEnd = 49F;
            // 
            // bulletGraphQualitativeBar11
            // 
            this.bulletGraphQualitativeBar11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar11.Name = "bulletGraphQualitativeBar11";
            this.bulletGraphQualitativeBar11.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar11.RangeEnd = 74F;
            this.bulletGraphQualitativeBar11.RangeStart = 50F;
            // 
            // bulletGraphQualitativeBar12
            // 
            this.bulletGraphQualitativeBar12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar12.Name = "bulletGraphQualitativeBar12";
            this.bulletGraphQualitativeBar12.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar12.RangeStart = 75F;
            // 
            // bulletGraphFeaturedMeasureBar4
            // 
            this.bulletGraphFeaturedMeasureBar4.AutoSize = false;
            this.bulletGraphFeaturedMeasureBar4.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.bulletGraphFeaturedMeasureBar4.Name = "bulletGraphFeaturedMeasureBar4";
            this.bulletGraphFeaturedMeasureBar4.Offset = 11F;
            this.bulletGraphFeaturedMeasureBar4.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphFeaturedMeasureBar4.RangeEnd = 85F;
            this.bulletGraphFeaturedMeasureBar4.Width = 10F;
            this.bulletGraphFeaturedMeasureBar4.Width2 = 10F;
            // 
            // linearGaugeNeedleIndicator10
            // 
            this.linearGaugeNeedleIndicator10.AutoSize = false;
            this.linearGaugeNeedleIndicator10.BackColor = System.Drawing.Color.Black;
            this.linearGaugeNeedleIndicator10.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.linearGaugeNeedleIndicator10.LenghtPercentage = 0F;
            this.linearGaugeNeedleIndicator10.LineLenght = 30F;
            this.linearGaugeNeedleIndicator10.LocationPercentage = 30F;
            this.linearGaugeNeedleIndicator10.Name = "linearGaugeNeedleIndicator10";
            this.linearGaugeNeedleIndicator10.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator10.Thickness = 3F;
            this.linearGaugeNeedleIndicator10.Value = 80F;
            // 
            // linearGaugeLabels24
            // 
            this.linearGaugeLabels24.AutoSize = false;
            this.linearGaugeLabels24.Bounds = new System.Drawing.Rectangle(0, 0, 280, 40);
            this.linearGaugeLabels24.LabelFontSize = 4F;
            this.linearGaugeLabels24.Name = "linearGaugeLabels24";
            this.linearGaugeLabels24.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radBulletGraph3
            // 
            this.radBulletGraph3.BackColor = System.Drawing.Color.White;
            this.radBulletGraph3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bulletGraphQualitativeBar7,
            this.bulletGraphQualitativeBar8,
            this.bulletGraphQualitativeBar9,
            this.bulletGraphFeaturedMeasureBar3,
            this.linearGaugeNeedleIndicator9,
            this.linearGaugeLabels23});
            this.radBulletGraph3.Location = new System.Drawing.Point(486, 18);
            this.radBulletGraph3.Name = "radBulletGraph3";
            this.radBulletGraph3.Padding = new System.Windows.Forms.Padding(0, 5, 30, 5);
            this.radBulletGraph3.Size = new System.Drawing.Size(65, 280);
            this.radBulletGraph3.TabIndex = 3;
            this.radBulletGraph3.Text = "radBulletGraph1";
            this.radBulletGraph3.Value = 0F;
            this.radBulletGraph3.Vertical = true;
            // 
            // bulletGraphQualitativeBar7
            // 
            this.bulletGraphQualitativeBar7.Name = "bulletGraphQualitativeBar7";
            this.bulletGraphQualitativeBar7.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar7.RangeEnd = 49F;
            // 
            // bulletGraphQualitativeBar8
            // 
            this.bulletGraphQualitativeBar8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar8.Name = "bulletGraphQualitativeBar8";
            this.bulletGraphQualitativeBar8.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar8.RangeEnd = 74F;
            this.bulletGraphQualitativeBar8.RangeStart = 50F;
            // 
            // bulletGraphQualitativeBar9
            // 
            this.bulletGraphQualitativeBar9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar9.Name = "bulletGraphQualitativeBar9";
            this.bulletGraphQualitativeBar9.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar9.RangeStart = 75F;
            // 
            // bulletGraphFeaturedMeasureBar3
            // 
            this.bulletGraphFeaturedMeasureBar3.AutoSize = false;
            this.bulletGraphFeaturedMeasureBar3.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.bulletGraphFeaturedMeasureBar3.Name = "bulletGraphFeaturedMeasureBar3";
            this.bulletGraphFeaturedMeasureBar3.Offset = 12F;
            this.bulletGraphFeaturedMeasureBar3.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphFeaturedMeasureBar3.RangeEnd = 85F;
            this.bulletGraphFeaturedMeasureBar3.Width = 10F;
            this.bulletGraphFeaturedMeasureBar3.Width2 = 10F;
            // 
            // linearGaugeNeedleIndicator9
            // 
            this.linearGaugeNeedleIndicator9.AutoSize = false;
            this.linearGaugeNeedleIndicator9.BackColor = System.Drawing.Color.Black;
            this.linearGaugeNeedleIndicator9.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.linearGaugeNeedleIndicator9.Direction = Telerik.WinControls.UI.Gauges.Direction.Left;
            this.linearGaugeNeedleIndicator9.LenghtPercentage = 0F;
            this.linearGaugeNeedleIndicator9.LineLenght = 36F;
            this.linearGaugeNeedleIndicator9.LocationPercentage = 35F;
            this.linearGaugeNeedleIndicator9.Name = "linearGaugeNeedleIndicator9";
            this.linearGaugeNeedleIndicator9.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator9.Thickness = 3F;
            this.linearGaugeNeedleIndicator9.Value = 80F;
            // 
            // linearGaugeLabels23
            // 
            this.linearGaugeLabels23.AutoSize = false;
            this.linearGaugeLabels23.Bounds = new System.Drawing.Rectangle(0, 0, 35, 278);
            this.linearGaugeLabels23.LabelFontSize = 4F;
            this.linearGaugeLabels23.LabelLocationPercentage = 52F;
            this.linearGaugeLabels23.Name = "linearGaugeLabels23";
            this.linearGaugeLabels23.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge15
            // 
            this.radLinearGauge15.BackColor = System.Drawing.Color.White;
            this.radLinearGauge15.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar27,
            this.linearGaugeBar28,
            this.linearGaugeLine19,
            this.linearGaugeTicks33,
            this.linearGaugeLabels14});
            this.radLinearGauge15.Location = new System.Drawing.Point(577, 154);
            this.radLinearGauge15.Name = "radLinearGauge15";
            this.radLinearGauge15.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.radLinearGauge15.RangeEnd = 120F;
            this.radLinearGauge15.Size = new System.Drawing.Size(280, 50);
            this.radLinearGauge15.TabIndex = 0;
            this.radLinearGauge15.Text = "radLinearGauge1";
            this.radLinearGauge15.Value = 70F;
            // 
            // linearGaugeBar27
            // 
            this.linearGaugeBar27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar27.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar27.BindEndRange = true;
            this.linearGaugeBar27.Name = "linearGaugeBar27";
            this.linearGaugeBar27.Offset = 35F;
            this.linearGaugeBar27.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar27.RangeEnd = 70F;
            // 
            // linearGaugeBar28
            // 
            this.linearGaugeBar28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar28.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar28.BindStartRange = true;
            this.linearGaugeBar28.BindStartRangeOffset = 1F;
            this.linearGaugeBar28.Name = "linearGaugeBar28";
            this.linearGaugeBar28.Offset = 35F;
            this.linearGaugeBar28.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar28.RangeEnd = 120F;
            this.linearGaugeBar28.RangeStart = 71F;
            // 
            // linearGaugeLine19
            // 
            this.linearGaugeLine19.Name = "linearGaugeLine19";
            this.linearGaugeLine19.Offset = 30F;
            this.linearGaugeLine19.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine19.RangeEnd = 120F;
            this.linearGaugeLine19.RangeStart = 80F;
            // 
            // linearGaugeTicks33
            // 
            this.linearGaugeTicks33.Name = "linearGaugeTicks33";
            this.linearGaugeTicks33.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks33.TicksCount = 3;
            this.linearGaugeTicks33.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks33.TicksLocationPercentage = 30F;
            this.linearGaugeTicks33.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks33.TickThickness = 0.7F;
            // 
            // linearGaugeLabels14
            // 
            this.linearGaugeLabels14.LabelFontSize = 3F;
            this.linearGaugeLabels14.LabelLocationPercentage = 15F;
            this.linearGaugeLabels14.LabelsCount = 3;
            this.linearGaugeLabels14.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels14.Name = "linearGaugeLabels14";
            this.linearGaugeLabels14.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge14
            // 
            this.radLinearGauge14.BackColor = System.Drawing.Color.White;
            this.radLinearGauge14.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar25,
            this.linearGaugeBar26,
            this.linearGaugeLine18,
            this.linearGaugeTicks32,
            this.linearGaugeLabels13});
            this.radLinearGauge14.Location = new System.Drawing.Point(577, 78);
            this.radLinearGauge14.Name = "radLinearGauge14";
            this.radLinearGauge14.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.radLinearGauge14.RangeEnd = 120F;
            this.radLinearGauge14.Size = new System.Drawing.Size(280, 50);
            this.radLinearGauge14.TabIndex = 0;
            this.radLinearGauge14.Text = "radLinearGauge1";
            this.radLinearGauge14.Value = 70F;
            // 
            // linearGaugeBar25
            // 
            this.linearGaugeBar25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar25.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar25.BindEndRange = true;
            this.linearGaugeBar25.Name = "linearGaugeBar25";
            this.linearGaugeBar25.Offset = 35F;
            this.linearGaugeBar25.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar25.RangeEnd = 70F;
            // 
            // linearGaugeBar26
            // 
            this.linearGaugeBar26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar26.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar26.BindStartRange = true;
            this.linearGaugeBar26.BindStartRangeOffset = 1F;
            this.linearGaugeBar26.Name = "linearGaugeBar26";
            this.linearGaugeBar26.Offset = 35F;
            this.linearGaugeBar26.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar26.RangeEnd = 120F;
            this.linearGaugeBar26.RangeStart = 71F;
            // 
            // linearGaugeLine18
            // 
            this.linearGaugeLine18.Name = "linearGaugeLine18";
            this.linearGaugeLine18.Offset = 30F;
            this.linearGaugeLine18.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine18.RangeEnd = 120F;
            this.linearGaugeLine18.RangeStart = 80F;
            // 
            // linearGaugeTicks32
            // 
            this.linearGaugeTicks32.Name = "linearGaugeTicks32";
            this.linearGaugeTicks32.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks32.TicksCount = 3;
            this.linearGaugeTicks32.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks32.TicksLocationPercentage = 30F;
            this.linearGaugeTicks32.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks32.TickThickness = 0.7F;
            // 
            // linearGaugeLabels13
            // 
            this.linearGaugeLabels13.LabelFontSize = 3F;
            this.linearGaugeLabels13.LabelLocationPercentage = 15F;
            this.linearGaugeLabels13.LabelsCount = 3;
            this.linearGaugeLabels13.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels13.Name = "linearGaugeLabels13";
            this.linearGaugeLabels13.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge13
            // 
            this.radLinearGauge13.BackColor = System.Drawing.Color.White;
            this.radLinearGauge13.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar22,
            this.linearGaugeBar23,
            this.linearGaugeBar24,
            this.linearGaugeLine17,
            this.linearGaugeTicks31,
            this.linearGaugeLabels12,
            this.linearGaugeNeedleIndicator4});
            this.radLinearGauge13.Location = new System.Drawing.Point(577, 18);
            this.radLinearGauge13.Name = "radLinearGauge13";
            this.radLinearGauge13.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.radLinearGauge13.RangeEnd = 120F;
            this.radLinearGauge13.Size = new System.Drawing.Size(280, 44);
            this.radLinearGauge13.TabIndex = 2;
            this.radLinearGauge13.Text = "radLinearGauge2";
            this.radLinearGauge13.Value = 90F;
            // 
            // linearGaugeBar22
            // 
            this.linearGaugeBar22.AutoSize = true;
            this.linearGaugeBar22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.linearGaugeBar22.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.linearGaugeBar22.Name = "linearGaugeBar22";
            this.linearGaugeBar22.Offset = 25F;
            this.linearGaugeBar22.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar22.RangeEnd = 40F;
            this.linearGaugeBar22.Width = 10F;
            this.linearGaugeBar22.Width2 = 25F;
            // 
            // linearGaugeBar23
            // 
            this.linearGaugeBar23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar23.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar23.Name = "linearGaugeBar23";
            this.linearGaugeBar23.Offset = 25F;
            this.linearGaugeBar23.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar23.RangeEnd = 80F;
            this.linearGaugeBar23.RangeStart = 41F;
            this.linearGaugeBar23.Width = 25F;
            this.linearGaugeBar23.Width2 = 40F;
            // 
            // linearGaugeBar24
            // 
            this.linearGaugeBar24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar24.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar24.Name = "linearGaugeBar24";
            this.linearGaugeBar24.Offset = 25F;
            this.linearGaugeBar24.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar24.RangeEnd = 120F;
            this.linearGaugeBar24.RangeStart = 81F;
            this.linearGaugeBar24.Width = 40F;
            this.linearGaugeBar24.Width2 = 55F;
            // 
            // linearGaugeLine17
            // 
            this.linearGaugeLine17.AutoSize = false;
            this.linearGaugeLine17.Bounds = new System.Drawing.Rectangle(0, 0, 15, 285);
            this.linearGaugeLine17.Name = "linearGaugeLine17";
            this.linearGaugeLine17.Offset = 22F;
            this.linearGaugeLine17.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine17.RangeEnd = 120F;
            this.linearGaugeLine17.Width = 1.5F;
            // 
            // linearGaugeTicks31
            // 
            this.linearGaugeTicks31.AutoSize = false;
            this.linearGaugeTicks31.Bounds = new System.Drawing.Rectangle(0, 0, 15, 261);
            this.linearGaugeTicks31.Name = "linearGaugeTicks31";
            this.linearGaugeTicks31.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks31.TicksCount = 12;
            this.linearGaugeTicks31.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks31.TicksLocationPercentage = 21F;
            this.linearGaugeTicks31.TicksOffset = 65;
            this.linearGaugeTicks31.TickThickness = 0.5F;
            // 
            // linearGaugeLabels12
            // 
            this.linearGaugeLabels12.AutoSize = false;
            this.linearGaugeLabels12.Bounds = new System.Drawing.Rectangle(0, 0, 219, 33);
            this.linearGaugeLabels12.LabelFontSize = 4F;
            this.linearGaugeLabels12.LabelLocationPercentage = 10F;
            this.linearGaugeLabels12.LabelsCount = 3;
            this.linearGaugeLabels12.Name = "linearGaugeLabels12";
            this.linearGaugeLabels12.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeNeedleIndicator4
            // 
            this.linearGaugeNeedleIndicator4.AutoSize = false;
            this.linearGaugeNeedleIndicator4.BindValue = true;
            this.linearGaugeNeedleIndicator4.Bounds = new System.Drawing.Rectangle(0, 0, 11, 223);
            this.linearGaugeNeedleIndicator4.Direction = Telerik.WinControls.UI.Gauges.Direction.Down;
            this.linearGaugeNeedleIndicator4.HorizontalLineWidth = 0;
            this.linearGaugeNeedleIndicator4.InnerPointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator4.LocationPercentage = 17F;
            this.linearGaugeNeedleIndicator4.Name = "linearGaugeNeedleIndicator4";
            this.linearGaugeNeedleIndicator4.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator4.Value = 90F;
            // 
            // radLinearGauge12
            // 
            this.radLinearGauge12.BackColor = System.Drawing.Color.White;
            this.radLinearGauge12.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar20,
            this.linearGaugeBar21,
            this.linearGaugeTicks30});
            this.radLinearGauge12.Location = new System.Drawing.Point(382, 18);
            this.radLinearGauge12.Name = "radLinearGauge12";
            this.radLinearGauge12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radLinearGauge12.RangeEnd = 120F;
            this.radLinearGauge12.Size = new System.Drawing.Size(59, 280);
            this.radLinearGauge12.TabIndex = 0;
            this.radLinearGauge12.Text = "radLinearGauge1";
            this.radLinearGauge12.Value = 70F;
            this.radLinearGauge12.Vertical = true;
            // 
            // linearGaugeBar20
            // 
            this.linearGaugeBar20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar20.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar20.BindEndRange = true;
            this.linearGaugeBar20.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeBar20.Name = "linearGaugeBar20";
            this.linearGaugeBar20.Offset = 30F;
            this.linearGaugeBar20.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar20.RangeEnd = 70F;
            this.linearGaugeBar20.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // linearGaugeBar21
            // 
            this.linearGaugeBar21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar21.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar21.BindStartRange = true;
            this.linearGaugeBar21.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeBar21.Name = "linearGaugeBar21";
            this.linearGaugeBar21.Offset = 30F;
            this.linearGaugeBar21.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar21.RangeEnd = 120F;
            this.linearGaugeBar21.RangeStart = 70F;
            this.linearGaugeBar21.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // linearGaugeTicks30
            // 
            this.linearGaugeTicks30.AutoSize = true;
            this.linearGaugeTicks30.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeTicks30.Name = "linearGaugeTicks30";
            this.linearGaugeTicks30.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeTicks30.TickColor = System.Drawing.Color.White;
            this.linearGaugeTicks30.TicksCount = 11;
            this.linearGaugeTicks30.TicksLenghtPercentage = 44F;
            this.linearGaugeTicks30.TicksLocationPercentage = 60F;
            this.linearGaugeTicks30.TicksOffset = 30;
            // 
            // radLinearGauge11
            // 
            this.radLinearGauge11.BackColor = System.Drawing.Color.White;
            this.radLinearGauge11.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar18,
            this.linearGaugeBar19,
            this.linearGaugeTicks28,
            this.linearGaugeLine16,
            this.linearGaugeTicks29,
            this.linearGaugeLabels11});
            this.radLinearGauge11.Location = new System.Drawing.Point(272, 18);
            this.radLinearGauge11.Name = "radLinearGauge11";
            this.radLinearGauge11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radLinearGauge11.RangeEnd = 120F;
            this.radLinearGauge11.Size = new System.Drawing.Size(59, 280);
            this.radLinearGauge11.TabIndex = 0;
            this.radLinearGauge11.Text = "radLinearGauge1";
            this.radLinearGauge11.Value = 70F;
            this.radLinearGauge11.Vertical = true;
            // 
            // linearGaugeBar18
            // 
            this.linearGaugeBar18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar18.BindEndRange = true;
            this.linearGaugeBar18.Name = "linearGaugeBar18";
            this.linearGaugeBar18.Offset = 30F;
            this.linearGaugeBar18.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar18.RangeEnd = 70F;
            // 
            // linearGaugeBar19
            // 
            this.linearGaugeBar19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar19.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeBar19.BindStartRange = true;
            this.linearGaugeBar19.Name = "linearGaugeBar19";
            this.linearGaugeBar19.Offset = 30F;
            this.linearGaugeBar19.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar19.RangeEnd = 120F;
            this.linearGaugeBar19.RangeStart = 70F;
            // 
            // linearGaugeTicks28
            // 
            this.linearGaugeTicks28.AutoSize = true;
            this.linearGaugeTicks28.Name = "linearGaugeTicks28";
            this.linearGaugeTicks28.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks28.TickColor = System.Drawing.Color.White;
            this.linearGaugeTicks28.TicksCount = 11;
            this.linearGaugeTicks28.TicksLenghtPercentage = 44F;
            this.linearGaugeTicks28.TicksLocationPercentage = 60F;
            this.linearGaugeTicks28.TicksOffset = 30;
            // 
            // linearGaugeLine16
            // 
            this.linearGaugeLine16.Name = "linearGaugeLine16";
            this.linearGaugeLine16.Offset = 30F;
            this.linearGaugeLine16.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine16.RangeEnd = 120F;
            this.linearGaugeLine16.RangeStart = 80F;
            // 
            // linearGaugeTicks29
            // 
            this.linearGaugeTicks29.Name = "linearGaugeTicks29";
            this.linearGaugeTicks29.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks29.TickEndIndexVisibleRange = 1F;
            this.linearGaugeTicks29.TicksCount = 3;
            this.linearGaugeTicks29.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks29.TicksLocationPercentage = 30F;
            this.linearGaugeTicks29.TickThickness = 0.7F;
            // 
            // linearGaugeLabels11
            // 
            this.linearGaugeLabels11.LabelFontSize = 3F;
            this.linearGaugeLabels11.LabelLocationPercentage = 10F;
            this.linearGaugeLabels11.LabelsCount = 3;
            this.linearGaugeLabels11.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels11.Name = "linearGaugeLabels11";
            this.linearGaugeLabels11.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge10
            // 
            this.radLinearGauge10.BackColor = System.Drawing.Color.White;
            this.radLinearGauge10.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar16,
            this.linearGaugeBar17,
            this.linearGaugeLine14,
            this.linearGaugeLine15,
            this.linearGaugeTicks24,
            this.linearGaugeTicks25,
            this.linearGaugeTicks26,
            this.linearGaugeTicks27,
            this.linearGaugeLabels9,
            this.linearGaugeLabels10});
            this.radLinearGauge10.Location = new System.Drawing.Point(166, 18);
            this.radLinearGauge10.Name = "radLinearGauge10";
            this.radLinearGauge10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radLinearGauge10.RangeEnd = 120F;
            this.radLinearGauge10.Size = new System.Drawing.Size(60, 280);
            this.radLinearGauge10.TabIndex = 0;
            this.radLinearGauge10.Text = "radLinearGauge1";
            this.radLinearGauge10.Value = 70F;
            this.radLinearGauge10.Vertical = true;
            // 
            // linearGaugeBar16
            // 
            this.linearGaugeBar16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar16.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar16.BindEndRange = true;
            this.linearGaugeBar16.Name = "linearGaugeBar16";
            this.linearGaugeBar16.Offset = 35F;
            this.linearGaugeBar16.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar16.RangeEnd = 70F;
            // 
            // linearGaugeBar17
            // 
            this.linearGaugeBar17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar17.BindStartRange = true;
            this.linearGaugeBar17.BindStartRangeOffset = 1F;
            this.linearGaugeBar17.Name = "linearGaugeBar17";
            this.linearGaugeBar17.Offset = 35F;
            this.linearGaugeBar17.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar17.RangeEnd = 120F;
            this.linearGaugeBar17.RangeStart = 71F;
            // 
            // linearGaugeLine14
            // 
            this.linearGaugeLine14.AutoSize = false;
            this.linearGaugeLine14.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine14.Name = "linearGaugeLine14";
            this.linearGaugeLine14.Offset = 35F;
            this.linearGaugeLine14.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine14.RangeEnd = 80F;
            this.linearGaugeLine14.Width = 2F;
            // 
            // linearGaugeLine15
            // 
            this.linearGaugeLine15.AutoSize = false;
            this.linearGaugeLine15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine15.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine15.Name = "linearGaugeLine15";
            this.linearGaugeLine15.Offset = 35F;
            this.linearGaugeLine15.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine15.RangeEnd = 120F;
            this.linearGaugeLine15.RangeStart = 80F;
            this.linearGaugeLine15.Width = 2F;
            // 
            // linearGaugeTicks24
            // 
            this.linearGaugeTicks24.Name = "linearGaugeTicks24";
            this.linearGaugeTicks24.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks24.TicksCount = 3;
            this.linearGaugeTicks24.TicksLenghtPercentage = 9F;
            this.linearGaugeTicks24.TicksLocationPercentage = 30F;
            this.linearGaugeTicks24.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks24.TickThickness = 0.7F;
            // 
            // linearGaugeTicks25
            // 
            this.linearGaugeTicks25.Name = "linearGaugeTicks25";
            this.linearGaugeTicks25.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks25.TicksCount = 12;
            this.linearGaugeTicks25.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks25.TicksLocationPercentage = 30F;
            this.linearGaugeTicks25.TickStartIndexVisibleRange = 5F;
            this.linearGaugeTicks25.TickThickness = 0.6F;
            // 
            // linearGaugeTicks26
            // 
            this.linearGaugeTicks26.Name = "linearGaugeTicks26";
            this.linearGaugeTicks26.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks26.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeTicks26.TickEndIndexVisibleRange = 4F;
            this.linearGaugeTicks26.TicksCount = 12;
            this.linearGaugeTicks26.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks26.TicksLocationPercentage = 30F;
            // 
            // linearGaugeTicks27
            // 
            this.linearGaugeTicks27.Name = "linearGaugeTicks27";
            this.linearGaugeTicks27.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks27.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeTicks27.TickEndIndexVisibleRange = 1F;
            this.linearGaugeTicks27.TicksCount = 3;
            this.linearGaugeTicks27.TicksLocationPercentage = 30F;
            // 
            // linearGaugeLabels9
            // 
            this.linearGaugeLabels9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLabels9.LabelFontSize = 3F;
            this.linearGaugeLabels9.LabelLocationPercentage = 15F;
            this.linearGaugeLabels9.LabelsCount = 3;
            this.linearGaugeLabels9.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels9.Name = "linearGaugeLabels9";
            this.linearGaugeLabels9.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeLabels10
            // 
            this.linearGaugeLabels10.LabelEndVisibleRange = 40F;
            this.linearGaugeLabels10.LabelFontSize = 3F;
            this.linearGaugeLabels10.LabelLocationPercentage = 15F;
            this.linearGaugeLabels10.LabelsCount = 3;
            this.linearGaugeLabels10.Name = "linearGaugeLabels10";
            this.linearGaugeLabels10.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge9
            // 
            this.radLinearGauge9.BackColor = System.Drawing.Color.White;
            this.radLinearGauge9.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar15,
            this.linearGaugeLine11,
            this.linearGaugeLine12,
            this.linearGaugeTicks20,
            this.linearGaugeLabels8,
            this.linearGaugeTicks21,
            this.linearGaugeTicks22,
            this.linearGaugeLine13,
            this.linearGaugeTicks23,
            this.linearGaugeNeedleIndicator3});
            this.radLinearGauge9.Location = new System.Drawing.Point(24, 18);
            this.radLinearGauge9.Name = "radLinearGauge9";
            this.radLinearGauge9.Padding = new System.Windows.Forms.Padding(0, 5, 40, 5);
            this.radLinearGauge9.RangeEnd = 120F;
            this.radLinearGauge9.Size = new System.Drawing.Size(103, 280);
            this.radLinearGauge9.TabIndex = 0;
            this.radLinearGauge9.Text = "radLinearGauge1";
            this.radLinearGauge9.Value = 70F;
            this.radLinearGauge9.Vertical = true;
            // 
            // linearGaugeBar15
            // 
            this.linearGaugeBar15.AutoSize = false;
            this.linearGaugeBar15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.linearGaugeBar15.BindEndRange = true;
            this.linearGaugeBar15.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeBar15.Name = "linearGaugeBar15";
            this.linearGaugeBar15.Offset = 35F;
            this.linearGaugeBar15.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar15.RangeEnd = 70F;
            this.linearGaugeBar15.Width = 24F;
            this.linearGaugeBar15.Width2 = 24F;
            // 
            // linearGaugeLine11
            // 
            this.linearGaugeLine11.AutoSize = false;
            this.linearGaugeLine11.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine11.Name = "linearGaugeLine11";
            this.linearGaugeLine11.Offset = 35F;
            this.linearGaugeLine11.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine11.RangeEnd = 80F;
            this.linearGaugeLine11.Width = 2F;
            // 
            // linearGaugeLine12
            // 
            this.linearGaugeLine12.AutoSize = false;
            this.linearGaugeLine12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine12.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeLine12.Name = "linearGaugeLine12";
            this.linearGaugeLine12.Offset = 35F;
            this.linearGaugeLine12.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine12.RangeEnd = 120F;
            this.linearGaugeLine12.RangeStart = 80F;
            this.linearGaugeLine12.Width = 2F;
            // 
            // linearGaugeTicks20
            // 
            this.linearGaugeTicks20.AutoSize = false;
            this.linearGaugeTicks20.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks20.Name = "linearGaugeTicks20";
            this.linearGaugeTicks20.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks20.TicksCount = 3;
            this.linearGaugeTicks20.TicksLenghtPercentage = 4F;
            this.linearGaugeTicks20.TicksLocationPercentage = 33F;
            // 
            // linearGaugeLabels8
            // 
            this.linearGaugeLabels8.LabelFontSize = 3F;
            this.linearGaugeLabels8.LabelLocationPercentage = 15F;
            this.linearGaugeLabels8.LabelsCount = 3;
            this.linearGaugeLabels8.Name = "linearGaugeLabels8";
            this.linearGaugeLabels8.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeTicks21
            // 
            this.linearGaugeTicks21.AutoSize = false;
            this.linearGaugeTicks21.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks21.Name = "linearGaugeTicks21";
            this.linearGaugeTicks21.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks21.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeTicks21.TickEndIndexVisibleRange = 4F;
            this.linearGaugeTicks21.TicksCount = 12;
            this.linearGaugeTicks21.TicksLenghtPercentage = 2F;
            this.linearGaugeTicks21.TicksLocationPercentage = 33F;
            // 
            // linearGaugeTicks22
            // 
            this.linearGaugeTicks22.AutoSize = false;
            this.linearGaugeTicks22.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks22.Name = "linearGaugeTicks22";
            this.linearGaugeTicks22.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks22.TicksCount = 12;
            this.linearGaugeTicks22.TicksLenghtPercentage = 2F;
            this.linearGaugeTicks22.TicksLocationPercentage = 33F;
            this.linearGaugeTicks22.TickStartIndexVisibleRange = 5F;
            // 
            // linearGaugeLine13
            // 
            this.linearGaugeLine13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine13.Name = "linearGaugeLine13";
            this.linearGaugeLine13.Offset = 69F;
            this.linearGaugeLine13.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine13.RangeEnd = 120F;
            // 
            // linearGaugeTicks23
            // 
            this.linearGaugeTicks23.AutoSize = false;
            this.linearGaugeTicks23.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks23.Name = "linearGaugeTicks23";
            this.linearGaugeTicks23.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks23.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeTicks23.TicksCount = 12;
            this.linearGaugeTicks23.TicksLenghtPercentage = 3F;
            this.linearGaugeTicks23.TicksLocationPercentage = 72F;
            // 
            // linearGaugeNeedleIndicator3
            // 
            this.linearGaugeNeedleIndicator3.AutoSize = false;
            this.linearGaugeNeedleIndicator3.BackColor = System.Drawing.Color.Red;
            this.linearGaugeNeedleIndicator3.Bounds = new System.Drawing.Rectangle(0, 0, 63, 270);
            this.linearGaugeNeedleIndicator3.CircleTicks = true;
            this.linearGaugeNeedleIndicator3.Direction = Telerik.WinControls.UI.Gauges.Direction.Left;
            this.linearGaugeNeedleIndicator3.DrawValue = true;
            this.linearGaugeNeedleIndicator3.InnerPointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator3.IsFilled = false;
            this.linearGaugeNeedleIndicator3.LenghtPercentage = 6F;
            this.linearGaugeNeedleIndicator3.LineLenght = 40F;
            this.linearGaugeNeedleIndicator3.LocationPercentage = 70F;
            this.linearGaugeNeedleIndicator3.Name = "linearGaugeNeedleIndicator3";
            this.linearGaugeNeedleIndicator3.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator3.PointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator3.TextOffsetFromIndicator = new System.Drawing.SizeF(2F, -5F);
            this.linearGaugeNeedleIndicator3.Value = 66F;
            // 
            // radScrollablePanel2
            // 
            this.radScrollablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScrollablePanel2.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel2.Name = "radScrollablePanel2";
            // 
            // radScrollablePanel2.PanelContainer
            // 
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radBulletGraph2);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radBulletGraph1);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLinearGauge21);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLinearGauge20);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLinearGauge19);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLinearGauge8);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLinearGauge7);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLinearGauge6);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLinearGauge5);
            this.radScrollablePanel2.PanelContainer.Size = new System.Drawing.Size(1208, 802);
            this.radScrollablePanel2.Size = new System.Drawing.Size(1210, 804);
            this.radScrollablePanel2.TabIndex = 3;
            this.radScrollablePanel2.Text = "radScrollablePanel2";
            // 
            // radBulletGraph2
            // 
            this.radBulletGraph2.BackColor = System.Drawing.Color.White;
            this.radBulletGraph2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bulletGraphQualitativeBar4,
            this.bulletGraphQualitativeBar5,
            this.bulletGraphQualitativeBar6,
            this.bulletGraphFeaturedMeasureBar2,
            this.linearGaugeNeedleIndicator8,
            this.linearGaugeLabels22});
            this.radBulletGraph2.Location = new System.Drawing.Point(577, 249);
            this.radBulletGraph2.Name = "radBulletGraph2";
            this.radBulletGraph2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 20);
            this.radBulletGraph2.Size = new System.Drawing.Size(280, 50);
            this.radBulletGraph2.TabIndex = 3;
            this.radBulletGraph2.Text = "radBulletGraph1";
            this.radBulletGraph2.Value = 0F;
            // 
            // bulletGraphQualitativeBar4
            // 
            this.bulletGraphQualitativeBar4.Name = "bulletGraphQualitativeBar4";
            this.bulletGraphQualitativeBar4.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar4.RangeEnd = 49F;
            // 
            // bulletGraphQualitativeBar5
            // 
            this.bulletGraphQualitativeBar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar5.Name = "bulletGraphQualitativeBar5";
            this.bulletGraphQualitativeBar5.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar5.RangeEnd = 74F;
            this.bulletGraphQualitativeBar5.RangeStart = 50F;
            // 
            // bulletGraphQualitativeBar6
            // 
            this.bulletGraphQualitativeBar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar6.Name = "bulletGraphQualitativeBar6";
            this.bulletGraphQualitativeBar6.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar6.RangeStart = 75F;
            // 
            // bulletGraphFeaturedMeasureBar2
            // 
            this.bulletGraphFeaturedMeasureBar2.AutoSize = false;
            this.bulletGraphFeaturedMeasureBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bulletGraphFeaturedMeasureBar2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bulletGraphFeaturedMeasureBar2.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.bulletGraphFeaturedMeasureBar2.Name = "bulletGraphFeaturedMeasureBar2";
            this.bulletGraphFeaturedMeasureBar2.Offset = 11F;
            this.bulletGraphFeaturedMeasureBar2.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphFeaturedMeasureBar2.RangeEnd = 85F;
            this.bulletGraphFeaturedMeasureBar2.Width = 10F;
            this.bulletGraphFeaturedMeasureBar2.Width2 = 10F;
            // 
            // linearGaugeNeedleIndicator8
            // 
            this.linearGaugeNeedleIndicator8.AutoSize = false;
            this.linearGaugeNeedleIndicator8.BackColor = System.Drawing.Color.Black;
            this.linearGaugeNeedleIndicator8.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.linearGaugeNeedleIndicator8.LenghtPercentage = 0F;
            this.linearGaugeNeedleIndicator8.LineLenght = 30F;
            this.linearGaugeNeedleIndicator8.LocationPercentage = 30F;
            this.linearGaugeNeedleIndicator8.Name = "linearGaugeNeedleIndicator8";
            this.linearGaugeNeedleIndicator8.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator8.Thickness = 3F;
            this.linearGaugeNeedleIndicator8.Value = 80F;
            // 
            // linearGaugeLabels22
            // 
            this.linearGaugeLabels22.AutoSize = false;
            this.linearGaugeLabels22.Bounds = new System.Drawing.Rectangle(0, 0, 280, 40);
            this.linearGaugeLabels22.LabelFontSize = 4F;
            this.linearGaugeLabels22.Name = "linearGaugeLabels22";
            this.linearGaugeLabels22.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radBulletGraph1
            // 
            this.radBulletGraph1.BackColor = System.Drawing.Color.White;
            this.radBulletGraph1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bulletGraphQualitativeBar1,
            this.bulletGraphQualitativeBar2,
            this.bulletGraphQualitativeBar3,
            this.bulletGraphFeaturedMeasureBar1,
            this.linearGaugeNeedleIndicator7,
            this.linearGaugeLabels21});
            this.radBulletGraph1.Location = new System.Drawing.Point(486, 18);
            this.radBulletGraph1.Name = "radBulletGraph1";
            this.radBulletGraph1.Padding = new System.Windows.Forms.Padding(0, 5, 30, 5);
            this.radBulletGraph1.Size = new System.Drawing.Size(65, 280);
            this.radBulletGraph1.TabIndex = 3;
            this.radBulletGraph1.Text = "radBulletGraph1";
            this.radBulletGraph1.Value = 0F;
            this.radBulletGraph1.Vertical = true;
            // 
            // bulletGraphQualitativeBar1
            // 
            this.bulletGraphQualitativeBar1.Name = "bulletGraphQualitativeBar1";
            this.bulletGraphQualitativeBar1.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar1.RangeEnd = 49F;
            // 
            // bulletGraphQualitativeBar2
            // 
            this.bulletGraphQualitativeBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bulletGraphQualitativeBar2.Name = "bulletGraphQualitativeBar2";
            this.bulletGraphQualitativeBar2.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar2.RangeEnd = 74F;
            this.bulletGraphQualitativeBar2.RangeStart = 50F;
            // 
            // bulletGraphQualitativeBar3
            // 
            this.bulletGraphQualitativeBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.bulletGraphQualitativeBar3.Name = "bulletGraphQualitativeBar3";
            this.bulletGraphQualitativeBar3.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar3.RangeStart = 75F;
            // 
            // bulletGraphFeaturedMeasureBar1
            // 
            this.bulletGraphFeaturedMeasureBar1.AutoSize = false;
            this.bulletGraphFeaturedMeasureBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bulletGraphFeaturedMeasureBar1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bulletGraphFeaturedMeasureBar1.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.bulletGraphFeaturedMeasureBar1.Name = "bulletGraphFeaturedMeasureBar1";
            this.bulletGraphFeaturedMeasureBar1.Offset = 12F;
            this.bulletGraphFeaturedMeasureBar1.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphFeaturedMeasureBar1.RangeEnd = 85F;
            this.bulletGraphFeaturedMeasureBar1.Width = 10F;
            this.bulletGraphFeaturedMeasureBar1.Width2 = 10F;
            // 
            // linearGaugeNeedleIndicator7
            // 
            this.linearGaugeNeedleIndicator7.AutoSize = false;
            this.linearGaugeNeedleIndicator7.BackColor = System.Drawing.Color.Black;
            this.linearGaugeNeedleIndicator7.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.linearGaugeNeedleIndicator7.Direction = Telerik.WinControls.UI.Gauges.Direction.Left;
            this.linearGaugeNeedleIndicator7.LenghtPercentage = 0F;
            this.linearGaugeNeedleIndicator7.LineLenght = 36F;
            this.linearGaugeNeedleIndicator7.LocationPercentage = 35F;
            this.linearGaugeNeedleIndicator7.Name = "linearGaugeNeedleIndicator7";
            this.linearGaugeNeedleIndicator7.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator7.Thickness = 3F;
            this.linearGaugeNeedleIndicator7.Value = 80F;
            // 
            // linearGaugeLabels21
            // 
            this.linearGaugeLabels21.AutoSize = false;
            this.linearGaugeLabels21.Bounds = new System.Drawing.Rectangle(0, 0, 35, 278);
            this.linearGaugeLabels21.LabelFontSize = 4F;
            this.linearGaugeLabels21.LabelLocationPercentage = 52F;
            this.linearGaugeLabels21.Name = "linearGaugeLabels21";
            this.linearGaugeLabels21.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge21
            // 
            this.radLinearGauge21.BackColor = System.Drawing.Color.White;
            this.radLinearGauge21.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar39,
            this.linearGaugeBar40,
            this.linearGaugeLine25,
            this.linearGaugeTicks39,
            this.linearGaugeLabels20});
            this.radLinearGauge21.Location = new System.Drawing.Point(577, 154);
            this.radLinearGauge21.Name = "radLinearGauge21";
            this.radLinearGauge21.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.radLinearGauge21.RangeEnd = 120F;
            this.radLinearGauge21.Size = new System.Drawing.Size(280, 50);
            this.radLinearGauge21.TabIndex = 0;
            this.radLinearGauge21.Text = "radLinearGauge1";
            this.radLinearGauge21.Value = 70F;
            // 
            // linearGaugeBar39
            // 
            this.linearGaugeBar39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(76)))));
            this.linearGaugeBar39.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(76)))));
            this.linearGaugeBar39.BindEndRange = true;
            this.linearGaugeBar39.Name = "linearGaugeBar39";
            this.linearGaugeBar39.Offset = 35F;
            this.linearGaugeBar39.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar39.RangeEnd = 70F;
            // 
            // linearGaugeBar40
            // 
            this.linearGaugeBar40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar40.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar40.BindStartRange = true;
            this.linearGaugeBar40.BindStartRangeOffset = 1F;
            this.linearGaugeBar40.Name = "linearGaugeBar40";
            this.linearGaugeBar40.Offset = 35F;
            this.linearGaugeBar40.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar40.RangeEnd = 120F;
            this.linearGaugeBar40.RangeStart = 71F;
            // 
            // linearGaugeLine25
            // 
            this.linearGaugeLine25.Name = "linearGaugeLine25";
            this.linearGaugeLine25.Offset = 30F;
            this.linearGaugeLine25.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine25.RangeEnd = 120F;
            this.linearGaugeLine25.RangeStart = 80F;
            // 
            // linearGaugeTicks39
            // 
            this.linearGaugeTicks39.Name = "linearGaugeTicks39";
            this.linearGaugeTicks39.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks39.TicksCount = 3;
            this.linearGaugeTicks39.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks39.TicksLocationPercentage = 30F;
            this.linearGaugeTicks39.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks39.TickThickness = 0.7F;
            // 
            // linearGaugeLabels20
            // 
            this.linearGaugeLabels20.LabelFontSize = 3F;
            this.linearGaugeLabels20.LabelLocationPercentage = 15F;
            this.linearGaugeLabels20.LabelsCount = 3;
            this.linearGaugeLabels20.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels20.Name = "linearGaugeLabels20";
            this.linearGaugeLabels20.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge20
            // 
            this.radLinearGauge20.BackColor = System.Drawing.Color.White;
            this.radLinearGauge20.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar37,
            this.linearGaugeBar38,
            this.linearGaugeLine24,
            this.linearGaugeTicks38,
            this.linearGaugeLabels19});
            this.radLinearGauge20.Location = new System.Drawing.Point(577, 78);
            this.radLinearGauge20.Name = "radLinearGauge20";
            this.radLinearGauge20.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.radLinearGauge20.RangeEnd = 120F;
            this.radLinearGauge20.Size = new System.Drawing.Size(280, 50);
            this.radLinearGauge20.TabIndex = 0;
            this.radLinearGauge20.Text = "radLinearGauge1";
            this.radLinearGauge20.Value = 70F;
            // 
            // linearGaugeBar37
            // 
            this.linearGaugeBar37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.linearGaugeBar37.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.linearGaugeBar37.BindEndRange = true;
            this.linearGaugeBar37.Name = "linearGaugeBar37";
            this.linearGaugeBar37.Offset = 35F;
            this.linearGaugeBar37.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar37.RangeEnd = 70F;
            // 
            // linearGaugeBar38
            // 
            this.linearGaugeBar38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar38.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar38.BindStartRange = true;
            this.linearGaugeBar38.BindStartRangeOffset = 1F;
            this.linearGaugeBar38.Name = "linearGaugeBar38";
            this.linearGaugeBar38.Offset = 35F;
            this.linearGaugeBar38.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar38.RangeEnd = 120F;
            this.linearGaugeBar38.RangeStart = 71F;
            // 
            // linearGaugeLine24
            // 
            this.linearGaugeLine24.Name = "linearGaugeLine24";
            this.linearGaugeLine24.Offset = 30F;
            this.linearGaugeLine24.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine24.RangeEnd = 120F;
            this.linearGaugeLine24.RangeStart = 80F;
            // 
            // linearGaugeTicks38
            // 
            this.linearGaugeTicks38.Name = "linearGaugeTicks38";
            this.linearGaugeTicks38.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks38.TicksCount = 3;
            this.linearGaugeTicks38.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks38.TicksLocationPercentage = 30F;
            this.linearGaugeTicks38.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks38.TickThickness = 0.7F;
            // 
            // linearGaugeLabels19
            // 
            this.linearGaugeLabels19.LabelFontSize = 3F;
            this.linearGaugeLabels19.LabelLocationPercentage = 15F;
            this.linearGaugeLabels19.LabelsCount = 3;
            this.linearGaugeLabels19.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels19.Name = "linearGaugeLabels19";
            this.linearGaugeLabels19.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge19
            // 
            this.radLinearGauge19.BackColor = System.Drawing.Color.White;
            this.radLinearGauge19.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar36,
            this.linearGaugeLine23,
            this.linearGaugeTicks37,
            this.linearGaugeLabels18,
            this.linearGaugeNeedleIndicator6});
            this.radLinearGauge19.Location = new System.Drawing.Point(577, 18);
            this.radLinearGauge19.Name = "radLinearGauge19";
            this.radLinearGauge19.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.radLinearGauge19.RangeEnd = 120F;
            this.radLinearGauge19.Size = new System.Drawing.Size(280, 44);
            this.radLinearGauge19.TabIndex = 2;
            this.radLinearGauge19.Text = "radLinearGauge2";
            this.radLinearGauge19.Value = 90F;
            // 
            // linearGaugeBar36
            // 
            this.linearGaugeBar36.AutoSize = true;
            this.linearGaugeBar36.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow;
            this.linearGaugeBar36.Name = "linearGaugeBar36";
            this.linearGaugeBar36.Offset = 25F;
            this.linearGaugeBar36.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar36.RangeEnd = 120F;
            this.linearGaugeBar36.Width = 10F;
            this.linearGaugeBar36.Width2 = 70F;
            // 
            // linearGaugeLine23
            // 
            this.linearGaugeLine23.AutoSize = false;
            this.linearGaugeLine23.Bounds = new System.Drawing.Rectangle(0, 0, 15, 285);
            this.linearGaugeLine23.Name = "linearGaugeLine23";
            this.linearGaugeLine23.Offset = 22F;
            this.linearGaugeLine23.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine23.RangeEnd = 120F;
            this.linearGaugeLine23.Width = 1.5F;
            // 
            // linearGaugeTicks37
            // 
            this.linearGaugeTicks37.AutoSize = false;
            this.linearGaugeTicks37.Bounds = new System.Drawing.Rectangle(0, 0, 15, 261);
            this.linearGaugeTicks37.Name = "linearGaugeTicks37";
            this.linearGaugeTicks37.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks37.TicksCount = 12;
            this.linearGaugeTicks37.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks37.TicksLocationPercentage = 21F;
            this.linearGaugeTicks37.TicksOffset = 65;
            this.linearGaugeTicks37.TickThickness = 0.5F;
            // 
            // linearGaugeLabels18
            // 
            this.linearGaugeLabels18.AutoSize = false;
            this.linearGaugeLabels18.Bounds = new System.Drawing.Rectangle(0, 0, 219, 33);
            this.linearGaugeLabels18.LabelFontSize = 4F;
            this.linearGaugeLabels18.LabelLocationPercentage = 10F;
            this.linearGaugeLabels18.LabelsCount = 3;
            this.linearGaugeLabels18.Name = "linearGaugeLabels18";
            this.linearGaugeLabels18.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeNeedleIndicator6
            // 
            this.linearGaugeNeedleIndicator6.AutoSize = false;
            this.linearGaugeNeedleIndicator6.BindValue = true;
            this.linearGaugeNeedleIndicator6.Bounds = new System.Drawing.Rectangle(0, 0, 11, 223);
            this.linearGaugeNeedleIndicator6.Direction = Telerik.WinControls.UI.Gauges.Direction.Down;
            this.linearGaugeNeedleIndicator6.HorizontalLineWidth = 0;
            this.linearGaugeNeedleIndicator6.InnerPointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator6.LocationPercentage = 17F;
            this.linearGaugeNeedleIndicator6.Name = "linearGaugeNeedleIndicator6";
            this.linearGaugeNeedleIndicator6.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator6.Value = 90F;
            // 
            // radLinearGauge8
            // 
            this.radLinearGauge8.BackColor = System.Drawing.Color.White;
            this.radLinearGauge8.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar13,
            this.linearGaugeBar14,
            this.linearGaugeTicks19});
            this.radLinearGauge8.Location = new System.Drawing.Point(382, 18);
            this.radLinearGauge8.Name = "radLinearGauge8";
            this.radLinearGauge8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radLinearGauge8.RangeEnd = 120F;
            this.radLinearGauge8.Size = new System.Drawing.Size(59, 280);
            this.radLinearGauge8.TabIndex = 0;
            this.radLinearGauge8.Text = "radLinearGauge1";
            this.radLinearGauge8.Value = 70F;
            this.radLinearGauge8.Vertical = true;
            // 
            // linearGaugeBar13
            // 
            this.linearGaugeBar13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar13.BindEndRange = true;
            this.linearGaugeBar13.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeBar13.Name = "linearGaugeBar13";
            this.linearGaugeBar13.Offset = 30F;
            this.linearGaugeBar13.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar13.RangeEnd = 70F;
            this.linearGaugeBar13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // linearGaugeBar14
            // 
            this.linearGaugeBar14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar14.BindStartRange = true;
            this.linearGaugeBar14.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeBar14.Name = "linearGaugeBar14";
            this.linearGaugeBar14.Offset = 30F;
            this.linearGaugeBar14.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar14.RangeEnd = 120F;
            this.linearGaugeBar14.RangeStart = 70F;
            this.linearGaugeBar14.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // linearGaugeTicks19
            // 
            this.linearGaugeTicks19.AutoSize = true;
            this.linearGaugeTicks19.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeTicks19.Name = "linearGaugeTicks19";
            this.linearGaugeTicks19.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks19.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeTicks19.TickColor = System.Drawing.Color.White;
            this.linearGaugeTicks19.TicksCount = 11;
            this.linearGaugeTicks19.TicksLenghtPercentage = 44F;
            this.linearGaugeTicks19.TicksLocationPercentage = 60F;
            this.linearGaugeTicks19.TicksOffset = 30;
            // 
            // radLinearGauge7
            // 
            this.radLinearGauge7.BackColor = System.Drawing.Color.White;
            this.radLinearGauge7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar11,
            this.linearGaugeBar12,
            this.linearGaugeTicks17,
            this.linearGaugeLine10,
            this.linearGaugeTicks18,
            this.linearGaugeLabels7});
            this.radLinearGauge7.Location = new System.Drawing.Point(272, 18);
            this.radLinearGauge7.Name = "radLinearGauge7";
            this.radLinearGauge7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radLinearGauge7.RangeEnd = 120F;
            this.radLinearGauge7.Size = new System.Drawing.Size(59, 280);
            this.radLinearGauge7.TabIndex = 0;
            this.radLinearGauge7.Text = "radLinearGauge1";
            this.radLinearGauge7.Value = 70F;
            this.radLinearGauge7.Vertical = true;
            // 
            // linearGaugeBar11
            // 
            this.linearGaugeBar11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar11.BindEndRange = true;
            this.linearGaugeBar11.Name = "linearGaugeBar11";
            this.linearGaugeBar11.Offset = 30F;
            this.linearGaugeBar11.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar11.RangeEnd = 70F;
            // 
            // linearGaugeBar12
            // 
            this.linearGaugeBar12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar12.BindStartRange = true;
            this.linearGaugeBar12.Name = "linearGaugeBar12";
            this.linearGaugeBar12.Offset = 30F;
            this.linearGaugeBar12.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar12.RangeEnd = 120F;
            this.linearGaugeBar12.RangeStart = 70F;
            // 
            // linearGaugeTicks17
            // 
            this.linearGaugeTicks17.AutoSize = true;
            this.linearGaugeTicks17.Name = "linearGaugeTicks17";
            this.linearGaugeTicks17.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks17.TickColor = System.Drawing.Color.White;
            this.linearGaugeTicks17.TicksCount = 11;
            this.linearGaugeTicks17.TicksLenghtPercentage = 44F;
            this.linearGaugeTicks17.TicksLocationPercentage = 60F;
            this.linearGaugeTicks17.TicksOffset = 30;
            // 
            // linearGaugeLine10
            // 
            this.linearGaugeLine10.Name = "linearGaugeLine10";
            this.linearGaugeLine10.Offset = 30F;
            this.linearGaugeLine10.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine10.RangeEnd = 120F;
            this.linearGaugeLine10.RangeStart = 80F;
            // 
            // linearGaugeTicks18
            // 
            this.linearGaugeTicks18.Name = "linearGaugeTicks18";
            this.linearGaugeTicks18.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks18.TickEndIndexVisibleRange = 1F;
            this.linearGaugeTicks18.TicksCount = 3;
            this.linearGaugeTicks18.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks18.TicksLocationPercentage = 30F;
            this.linearGaugeTicks18.TickThickness = 0.7F;
            // 
            // linearGaugeLabels7
            // 
            this.linearGaugeLabels7.LabelFontSize = 3F;
            this.linearGaugeLabels7.LabelLocationPercentage = 10F;
            this.linearGaugeLabels7.LabelsCount = 3;
            this.linearGaugeLabels7.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels7.Name = "linearGaugeLabels7";
            this.linearGaugeLabels7.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge6
            // 
            this.radLinearGauge6.BackColor = System.Drawing.Color.White;
            this.radLinearGauge6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar9,
            this.linearGaugeBar10,
            this.linearGaugeLine9,
            this.linearGaugeTicks15,
            this.linearGaugeLabels6,
            this.linearGaugeTicks16});
            this.radLinearGauge6.Location = new System.Drawing.Point(166, 18);
            this.radLinearGauge6.Name = "radLinearGauge6";
            this.radLinearGauge6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radLinearGauge6.RangeEnd = 120F;
            this.radLinearGauge6.Size = new System.Drawing.Size(60, 280);
            this.radLinearGauge6.TabIndex = 0;
            this.radLinearGauge6.Text = "radLinearGauge1";
            this.radLinearGauge6.Value = 70F;
            this.radLinearGauge6.Vertical = true;
            // 
            // linearGaugeBar9
            // 
            this.linearGaugeBar9.AutoSize = false;
            this.linearGaugeBar9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar9.BindEndRange = true;
            this.linearGaugeBar9.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeBar9.Name = "linearGaugeBar9";
            this.linearGaugeBar9.Offset = 35F;
            this.linearGaugeBar9.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar9.RangeEnd = 70F;
            this.linearGaugeBar9.Width = 15F;
            this.linearGaugeBar9.Width2 = 15F;
            // 
            // linearGaugeBar10
            // 
            this.linearGaugeBar10.AutoSize = false;
            this.linearGaugeBar10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar10.BindStartRange = true;
            this.linearGaugeBar10.BindStartRangeOffset = 1F;
            this.linearGaugeBar10.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeBar10.Name = "linearGaugeBar10";
            this.linearGaugeBar10.Offset = 35F;
            this.linearGaugeBar10.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar10.RangeEnd = 120F;
            this.linearGaugeBar10.RangeStart = 71F;
            this.linearGaugeBar10.Width = 15F;
            this.linearGaugeBar10.Width2 = 15F;
            // 
            // linearGaugeLine9
            // 
            this.linearGaugeLine9.Name = "linearGaugeLine9";
            this.linearGaugeLine9.Offset = 35F;
            this.linearGaugeLine9.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine9.RangeEnd = 120F;
            // 
            // linearGaugeTicks15
            // 
            this.linearGaugeTicks15.AutoSize = true;
            this.linearGaugeTicks15.Name = "linearGaugeTicks15";
            this.linearGaugeTicks15.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks15.TicksCount = 3;
            this.linearGaugeTicks15.TicksLenghtPercentage = 9F;
            this.linearGaugeTicks15.TicksLocationPercentage = 30F;
            this.linearGaugeTicks15.TickThickness = 0.5F;
            // 
            // linearGaugeLabels6
            // 
            this.linearGaugeLabels6.LabelFontSize = 3F;
            this.linearGaugeLabels6.LabelLocationPercentage = 15F;
            this.linearGaugeLabels6.LabelsCount = 3;
            this.linearGaugeLabels6.Name = "linearGaugeLabels6";
            this.linearGaugeLabels6.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeTicks16
            // 
            this.linearGaugeTicks16.AutoSize = false;
            this.linearGaugeTicks16.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeTicks16.Name = "linearGaugeTicks16";
            this.linearGaugeTicks16.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks16.TicksCount = 12;
            this.linearGaugeTicks16.TicksLenghtPercentage = 3F;
            this.linearGaugeTicks16.TicksLocationPercentage = 30F;
            this.linearGaugeTicks16.TickThickness = 0.6F;
            // 
            // radLinearGauge5
            // 
            this.radLinearGauge5.BackColor = System.Drawing.Color.White;
            this.radLinearGauge5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar8,
            this.linearGaugeLine7,
            this.linearGaugeTicks12,
            this.linearGaugeLabels5,
            this.linearGaugeTicks13,
            this.linearGaugeLine8,
            this.linearGaugeTicks14,
            this.linearGaugeNeedleIndicator2});
            this.radLinearGauge5.Location = new System.Drawing.Point(24, 18);
            this.radLinearGauge5.Name = "radLinearGauge5";
            this.radLinearGauge5.Padding = new System.Windows.Forms.Padding(0, 5, 40, 5);
            this.radLinearGauge5.RangeEnd = 120F;
            this.radLinearGauge5.Size = new System.Drawing.Size(99, 280);
            this.radLinearGauge5.TabIndex = 0;
            this.radLinearGauge5.Text = "radLinearGauge1";
            this.radLinearGauge5.Value = 70F;
            this.radLinearGauge5.Vertical = true;
            // 
            // linearGaugeBar8
            // 
            this.linearGaugeBar8.AutoSize = false;
            this.linearGaugeBar8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.linearGaugeBar8.BindEndRange = true;
            this.linearGaugeBar8.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeBar8.Name = "linearGaugeBar8";
            this.linearGaugeBar8.Offset = 35F;
            this.linearGaugeBar8.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar8.RangeEnd = 70F;
            this.linearGaugeBar8.Width = 15F;
            this.linearGaugeBar8.Width2 = 15F;
            // 
            // linearGaugeLine7
            // 
            this.linearGaugeLine7.AutoSize = false;
            this.linearGaugeLine7.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine7.Name = "linearGaugeLine7";
            this.linearGaugeLine7.Offset = 35F;
            this.linearGaugeLine7.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine7.RangeEnd = 120F;
            this.linearGaugeLine7.Width = 2F;
            // 
            // linearGaugeTicks12
            // 
            this.linearGaugeTicks12.AutoSize = false;
            this.linearGaugeTicks12.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks12.Name = "linearGaugeTicks12";
            this.linearGaugeTicks12.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks12.TicksCount = 3;
            this.linearGaugeTicks12.TicksLenghtPercentage = 4F;
            this.linearGaugeTicks12.TicksLocationPercentage = 33F;
            // 
            // linearGaugeLabels5
            // 
            this.linearGaugeLabels5.LabelFontSize = 3F;
            this.linearGaugeLabels5.LabelLocationPercentage = 15F;
            this.linearGaugeLabels5.LabelsCount = 3;
            this.linearGaugeLabels5.Name = "linearGaugeLabels5";
            this.linearGaugeLabels5.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeTicks13
            // 
            this.linearGaugeTicks13.AutoSize = false;
            this.linearGaugeTicks13.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks13.Name = "linearGaugeTicks13";
            this.linearGaugeTicks13.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks13.TicksCount = 12;
            this.linearGaugeTicks13.TicksLenghtPercentage = 2F;
            this.linearGaugeTicks13.TicksLocationPercentage = 33F;
            // 
            // linearGaugeLine8
            // 
            this.linearGaugeLine8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine8.Name = "linearGaugeLine8";
            this.linearGaugeLine8.Offset = 60F;
            this.linearGaugeLine8.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine8.RangeEnd = 120F;
            // 
            // linearGaugeTicks14
            // 
            this.linearGaugeTicks14.AutoSize = false;
            this.linearGaugeTicks14.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks14.Name = "linearGaugeTicks14";
            this.linearGaugeTicks14.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks14.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeTicks14.TicksCount = 12;
            this.linearGaugeTicks14.TicksLenghtPercentage = 3F;
            this.linearGaugeTicks14.TicksLocationPercentage = 64F;
            // 
            // linearGaugeNeedleIndicator2
            // 
            this.linearGaugeNeedleIndicator2.AutoSize = false;
            this.linearGaugeNeedleIndicator2.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeNeedleIndicator2.CircleTicks = true;
            this.linearGaugeNeedleIndicator2.Direction = Telerik.WinControls.UI.Gauges.Direction.Left;
            this.linearGaugeNeedleIndicator2.DrawValue = true;
            this.linearGaugeNeedleIndicator2.IsFilled = false;
            this.linearGaugeNeedleIndicator2.LenghtPercentage = 3F;
            this.linearGaugeNeedleIndicator2.LineLenght = 41F;
            this.linearGaugeNeedleIndicator2.LocationPercentage = 70F;
            this.linearGaugeNeedleIndicator2.Name = "linearGaugeNeedleIndicator2";
            this.linearGaugeNeedleIndicator2.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator2.PointRadiusPercentage = 1F;
            this.linearGaugeNeedleIndicator2.TextOffsetFromIndicator = new System.Drawing.SizeF(2F, -5F);
            this.linearGaugeNeedleIndicator2.Value = 66F;
            // 
            // radScrollablePanel3
            // 
            this.radScrollablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScrollablePanel3.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel3.Name = "radScrollablePanel3";
            // 
            // radScrollablePanel3.PanelContainer
            // 
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radBulletGraph6);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radBulletGraph5);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radLinearGauge18);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radLinearGauge17);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radLinearGauge16);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radLinearGauge4);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radLinearGauge3);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radLinearGauge2);
            this.radScrollablePanel3.PanelContainer.Controls.Add(this.radLinearGauge1);
            this.radScrollablePanel3.PanelContainer.Size = new System.Drawing.Size(1208, 802);
            this.radScrollablePanel3.Size = new System.Drawing.Size(1210, 804);
            this.radScrollablePanel3.TabIndex = 4;
            this.radScrollablePanel3.Text = "radScrollablePanel3";
            // 
            // radBulletGraph6
            // 
            this.radBulletGraph6.BackColor = System.Drawing.Color.White;
            this.radBulletGraph6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bulletGraphQualitativeBar16,
            this.bulletGraphQualitativeBar17,
            this.bulletGraphQualitativeBar18,
            this.bulletGraphFeaturedMeasureBar6,
            this.linearGaugeNeedleIndicator12,
            this.linearGaugeLabels26});
            this.radBulletGraph6.Location = new System.Drawing.Point(577, 249);
            this.radBulletGraph6.Name = "radBulletGraph6";
            this.radBulletGraph6.Padding = new System.Windows.Forms.Padding(5, 0, 10, 20);
            this.radBulletGraph6.Size = new System.Drawing.Size(280, 50);
            this.radBulletGraph6.TabIndex = 3;
            this.radBulletGraph6.Text = "radBulletGraph1";
            this.radBulletGraph6.Value = 0F;
            // 
            // bulletGraphQualitativeBar16
            // 
            this.bulletGraphQualitativeBar16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
            this.bulletGraphQualitativeBar16.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
            this.bulletGraphQualitativeBar16.Name = "bulletGraphQualitativeBar16";
            this.bulletGraphQualitativeBar16.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar16.RangeEnd = 49F;
            // 
            // bulletGraphQualitativeBar17
            // 
            this.bulletGraphQualitativeBar17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.bulletGraphQualitativeBar17.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.bulletGraphQualitativeBar17.Name = "bulletGraphQualitativeBar17";
            this.bulletGraphQualitativeBar17.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar17.RangeEnd = 74F;
            this.bulletGraphQualitativeBar17.RangeStart = 50F;
            // 
            // bulletGraphQualitativeBar18
            // 
            this.bulletGraphQualitativeBar18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.bulletGraphQualitativeBar18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.bulletGraphQualitativeBar18.Name = "bulletGraphQualitativeBar18";
            this.bulletGraphQualitativeBar18.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar18.RangeStart = 75F;
            // 
            // bulletGraphFeaturedMeasureBar6
            // 
            this.bulletGraphFeaturedMeasureBar6.AutoSize = false;
            this.bulletGraphFeaturedMeasureBar6.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.bulletGraphFeaturedMeasureBar6.Name = "bulletGraphFeaturedMeasureBar6";
            this.bulletGraphFeaturedMeasureBar6.Offset = 11F;
            this.bulletGraphFeaturedMeasureBar6.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphFeaturedMeasureBar6.RangeEnd = 85F;
            this.bulletGraphFeaturedMeasureBar6.Width = 10F;
            this.bulletGraphFeaturedMeasureBar6.Width2 = 10F;
            // 
            // linearGaugeNeedleIndicator12
            // 
            this.linearGaugeNeedleIndicator12.AutoSize = false;
            this.linearGaugeNeedleIndicator12.BackColor = System.Drawing.Color.Black;
            this.linearGaugeNeedleIndicator12.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.linearGaugeNeedleIndicator12.LenghtPercentage = 0F;
            this.linearGaugeNeedleIndicator12.LineLenght = 30F;
            this.linearGaugeNeedleIndicator12.LocationPercentage = 30F;
            this.linearGaugeNeedleIndicator12.Name = "linearGaugeNeedleIndicator12";
            this.linearGaugeNeedleIndicator12.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator12.Thickness = 3F;
            this.linearGaugeNeedleIndicator12.Value = 80F;
            // 
            // linearGaugeLabels26
            // 
            this.linearGaugeLabels26.AutoSize = false;
            this.linearGaugeLabels26.Bounds = new System.Drawing.Rectangle(0, 0, 280, 40);
            this.linearGaugeLabels26.LabelFontSize = 4F;
            this.linearGaugeLabels26.Name = "linearGaugeLabels26";
            this.linearGaugeLabels26.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radBulletGraph5
            // 
            this.radBulletGraph5.BackColor = System.Drawing.Color.White;
            this.radBulletGraph5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.bulletGraphQualitativeBar13,
            this.bulletGraphQualitativeBar14,
            this.bulletGraphQualitativeBar15,
            this.bulletGraphFeaturedMeasureBar5,
            this.linearGaugeNeedleIndicator11,
            this.linearGaugeLabels25});
            this.radBulletGraph5.Location = new System.Drawing.Point(486, 18);
            this.radBulletGraph5.Name = "radBulletGraph5";
            this.radBulletGraph5.Padding = new System.Windows.Forms.Padding(0, 5, 30, 5);
            this.radBulletGraph5.Size = new System.Drawing.Size(65, 280);
            this.radBulletGraph5.TabIndex = 3;
            this.radBulletGraph5.Text = "radBulletGraph1";
            this.radBulletGraph5.Value = 0F;
            this.radBulletGraph5.Vertical = true;
            // 
            // bulletGraphQualitativeBar13
            // 
            this.bulletGraphQualitativeBar13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
            this.bulletGraphQualitativeBar13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(197)))), ((int)(((byte)(218)))));
            this.bulletGraphQualitativeBar13.Name = "bulletGraphQualitativeBar13";
            this.bulletGraphQualitativeBar13.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar13.RangeEnd = 49F;
            // 
            // bulletGraphQualitativeBar14
            // 
            this.bulletGraphQualitativeBar14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.bulletGraphQualitativeBar14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.bulletGraphQualitativeBar14.Name = "bulletGraphQualitativeBar14";
            this.bulletGraphQualitativeBar14.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar14.RangeEnd = 74F;
            this.bulletGraphQualitativeBar14.RangeStart = 50F;
            // 
            // bulletGraphQualitativeBar15
            // 
            this.bulletGraphQualitativeBar15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.bulletGraphQualitativeBar15.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.bulletGraphQualitativeBar15.Name = "bulletGraphQualitativeBar15";
            this.bulletGraphQualitativeBar15.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphQualitativeBar15.RangeStart = 75F;
            // 
            // bulletGraphFeaturedMeasureBar5
            // 
            this.bulletGraphFeaturedMeasureBar5.AutoSize = false;
            this.bulletGraphFeaturedMeasureBar5.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.bulletGraphFeaturedMeasureBar5.Name = "bulletGraphFeaturedMeasureBar5";
            this.bulletGraphFeaturedMeasureBar5.Offset = 13F;
            this.bulletGraphFeaturedMeasureBar5.Padding = new System.Windows.Forms.Padding(0);
            this.bulletGraphFeaturedMeasureBar5.RangeEnd = 85F;
            this.bulletGraphFeaturedMeasureBar5.Width = 10F;
            this.bulletGraphFeaturedMeasureBar5.Width2 = 10F;
            // 
            // linearGaugeNeedleIndicator11
            // 
            this.linearGaugeNeedleIndicator11.AutoSize = false;
            this.linearGaugeNeedleIndicator11.BackColor = System.Drawing.Color.Black;
            this.linearGaugeNeedleIndicator11.Bounds = new System.Drawing.Rectangle(0, 0, 280, 50);
            this.linearGaugeNeedleIndicator11.Direction = Telerik.WinControls.UI.Gauges.Direction.Left;
            this.linearGaugeNeedleIndicator11.LenghtPercentage = 0F;
            this.linearGaugeNeedleIndicator11.LineLenght = 35F;
            this.linearGaugeNeedleIndicator11.LocationPercentage = 35F;
            this.linearGaugeNeedleIndicator11.Name = "linearGaugeNeedleIndicator11";
            this.linearGaugeNeedleIndicator11.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator11.Thickness = 3F;
            this.linearGaugeNeedleIndicator11.Value = 80F;
            // 
            // linearGaugeLabels25
            // 
            this.linearGaugeLabels25.AutoSize = false;
            this.linearGaugeLabels25.Bounds = new System.Drawing.Rectangle(0, 0, 35, 278);
            this.linearGaugeLabels25.LabelFontSize = 4F;
            this.linearGaugeLabels25.LabelLocationPercentage = 52F;
            this.linearGaugeLabels25.Name = "linearGaugeLabels25";
            this.linearGaugeLabels25.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge18
            // 
            this.radLinearGauge18.BackColor = System.Drawing.Color.White;
            this.radLinearGauge18.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar34,
            this.linearGaugeBar35,
            this.linearGaugeLine22,
            this.linearGaugeTicks36,
            this.linearGaugeLabels17});
            this.radLinearGauge18.Location = new System.Drawing.Point(577, 154);
            this.radLinearGauge18.Name = "radLinearGauge18";
            this.radLinearGauge18.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.radLinearGauge18.RangeEnd = 120F;
            this.radLinearGauge18.Size = new System.Drawing.Size(280, 50);
            this.radLinearGauge18.TabIndex = 0;
            this.radLinearGauge18.Text = "radLinearGauge1";
            this.radLinearGauge18.Value = 70F;
            // 
            // linearGaugeBar34
            // 
            this.linearGaugeBar34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.linearGaugeBar34.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.linearGaugeBar34.BindEndRange = true;
            this.linearGaugeBar34.Name = "linearGaugeBar34";
            this.linearGaugeBar34.Offset = 35F;
            this.linearGaugeBar34.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar34.RangeEnd = 70F;
            // 
            // linearGaugeBar35
            // 
            this.linearGaugeBar35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar35.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar35.BindStartRange = true;
            this.linearGaugeBar35.BindStartRangeOffset = 1F;
            this.linearGaugeBar35.Name = "linearGaugeBar35";
            this.linearGaugeBar35.Offset = 35F;
            this.linearGaugeBar35.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar35.RangeEnd = 120F;
            this.linearGaugeBar35.RangeStart = 71F;
            // 
            // linearGaugeLine22
            // 
            this.linearGaugeLine22.Name = "linearGaugeLine22";
            this.linearGaugeLine22.Offset = 30F;
            this.linearGaugeLine22.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine22.RangeEnd = 120F;
            this.linearGaugeLine22.RangeStart = 80F;
            // 
            // linearGaugeTicks36
            // 
            this.linearGaugeTicks36.Name = "linearGaugeTicks36";
            this.linearGaugeTicks36.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks36.TicksCount = 3;
            this.linearGaugeTicks36.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks36.TicksLocationPercentage = 30F;
            this.linearGaugeTicks36.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks36.TickThickness = 0.7F;
            // 
            // linearGaugeLabels17
            // 
            this.linearGaugeLabels17.LabelFontSize = 3F;
            this.linearGaugeLabels17.LabelLocationPercentage = 15F;
            this.linearGaugeLabels17.LabelsCount = 3;
            this.linearGaugeLabels17.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels17.Name = "linearGaugeLabels17";
            this.linearGaugeLabels17.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge17
            // 
            this.radLinearGauge17.BackColor = System.Drawing.Color.White;
            this.radLinearGauge17.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar32,
            this.linearGaugeBar33,
            this.linearGaugeLine21,
            this.linearGaugeTicks35,
            this.linearGaugeLabels16});
            this.radLinearGauge17.Location = new System.Drawing.Point(577, 78);
            this.radLinearGauge17.Name = "radLinearGauge17";
            this.radLinearGauge17.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.radLinearGauge17.RangeEnd = 120F;
            this.radLinearGauge17.Size = new System.Drawing.Size(280, 50);
            this.radLinearGauge17.TabIndex = 0;
            this.radLinearGauge17.Text = "radLinearGauge1";
            this.radLinearGauge17.Value = 70F;
            // 
            // linearGaugeBar32
            // 
            this.linearGaugeBar32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar32.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar32.BindEndRange = true;
            this.linearGaugeBar32.Name = "linearGaugeBar32";
            this.linearGaugeBar32.Offset = 35F;
            this.linearGaugeBar32.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar32.RangeEnd = 70F;
            // 
            // linearGaugeBar33
            // 
            this.linearGaugeBar33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar33.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.linearGaugeBar33.BindStartRange = true;
            this.linearGaugeBar33.BindStartRangeOffset = 1F;
            this.linearGaugeBar33.Name = "linearGaugeBar33";
            this.linearGaugeBar33.Offset = 35F;
            this.linearGaugeBar33.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar33.RangeEnd = 120F;
            this.linearGaugeBar33.RangeStart = 71F;
            // 
            // linearGaugeLine21
            // 
            this.linearGaugeLine21.Name = "linearGaugeLine21";
            this.linearGaugeLine21.Offset = 30F;
            this.linearGaugeLine21.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine21.RangeEnd = 120F;
            this.linearGaugeLine21.RangeStart = 80F;
            // 
            // linearGaugeTicks35
            // 
            this.linearGaugeTicks35.Name = "linearGaugeTicks35";
            this.linearGaugeTicks35.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks35.TicksCount = 3;
            this.linearGaugeTicks35.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks35.TicksLocationPercentage = 30F;
            this.linearGaugeTicks35.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks35.TickThickness = 0.7F;
            // 
            // linearGaugeLabels16
            // 
            this.linearGaugeLabels16.LabelFontSize = 3F;
            this.linearGaugeLabels16.LabelLocationPercentage = 15F;
            this.linearGaugeLabels16.LabelsCount = 3;
            this.linearGaugeLabels16.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels16.Name = "linearGaugeLabels16";
            this.linearGaugeLabels16.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge16
            // 
            this.radLinearGauge16.BackColor = System.Drawing.Color.White;
            this.radLinearGauge16.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar29,
            this.linearGaugeBar30,
            this.linearGaugeBar31,
            this.linearGaugeLine20,
            this.linearGaugeTicks34,
            this.linearGaugeLabels15,
            this.linearGaugeNeedleIndicator5});
            this.radLinearGauge16.Location = new System.Drawing.Point(577, 18);
            this.radLinearGauge16.Name = "radLinearGauge16";
            this.radLinearGauge16.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.radLinearGauge16.RangeEnd = 120F;
            this.radLinearGauge16.Size = new System.Drawing.Size(280, 44);
            this.radLinearGauge16.TabIndex = 2;
            this.radLinearGauge16.Text = "radLinearGauge2";
            this.radLinearGauge16.Value = 90F;
            // 
            // linearGaugeBar29
            // 
            this.linearGaugeBar29.AutoSize = true;
            this.linearGaugeBar29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.linearGaugeBar29.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.linearGaugeBar29.Name = "linearGaugeBar29";
            this.linearGaugeBar29.Offset = 25F;
            this.linearGaugeBar29.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar29.RangeEnd = 40F;
            this.linearGaugeBar29.Width = 10F;
            this.linearGaugeBar29.Width2 = 25F;
            // 
            // linearGaugeBar30
            // 
            this.linearGaugeBar30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.linearGaugeBar30.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.linearGaugeBar30.Name = "linearGaugeBar30";
            this.linearGaugeBar30.Offset = 25F;
            this.linearGaugeBar30.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar30.RangeEnd = 80F;
            this.linearGaugeBar30.RangeStart = 41F;
            this.linearGaugeBar30.Width = 25F;
            this.linearGaugeBar30.Width2 = 40F;
            // 
            // linearGaugeBar31
            // 
            this.linearGaugeBar31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.linearGaugeBar31.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.linearGaugeBar31.Name = "linearGaugeBar31";
            this.linearGaugeBar31.Offset = 25F;
            this.linearGaugeBar31.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar31.RangeEnd = 120F;
            this.linearGaugeBar31.RangeStart = 81F;
            this.linearGaugeBar31.Width = 40F;
            this.linearGaugeBar31.Width2 = 55F;
            // 
            // linearGaugeLine20
            // 
            this.linearGaugeLine20.AutoSize = false;
            this.linearGaugeLine20.Bounds = new System.Drawing.Rectangle(0, 0, 15, 285);
            this.linearGaugeLine20.Name = "linearGaugeLine20";
            this.linearGaugeLine20.Offset = 22F;
            this.linearGaugeLine20.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine20.RangeEnd = 120F;
            this.linearGaugeLine20.Width = 1.5F;
            // 
            // linearGaugeTicks34
            // 
            this.linearGaugeTicks34.AutoSize = false;
            this.linearGaugeTicks34.Bounds = new System.Drawing.Rectangle(0, 0, 15, 261);
            this.linearGaugeTicks34.Name = "linearGaugeTicks34";
            this.linearGaugeTicks34.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks34.TicksCount = 12;
            this.linearGaugeTicks34.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks34.TicksLocationPercentage = 21F;
            this.linearGaugeTicks34.TicksOffset = 65;
            this.linearGaugeTicks34.TickThickness = 0.5F;
            // 
            // linearGaugeLabels15
            // 
            this.linearGaugeLabels15.AutoSize = false;
            this.linearGaugeLabels15.Bounds = new System.Drawing.Rectangle(0, 0, 219, 33);
            this.linearGaugeLabels15.LabelFontSize = 4F;
            this.linearGaugeLabels15.LabelLocationPercentage = 10F;
            this.linearGaugeLabels15.LabelsCount = 3;
            this.linearGaugeLabels15.Name = "linearGaugeLabels15";
            this.linearGaugeLabels15.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeNeedleIndicator5
            // 
            this.linearGaugeNeedleIndicator5.AutoSize = false;
            this.linearGaugeNeedleIndicator5.BindValue = true;
            this.linearGaugeNeedleIndicator5.Bounds = new System.Drawing.Rectangle(0, 0, 11, 223);
            this.linearGaugeNeedleIndicator5.Direction = Telerik.WinControls.UI.Gauges.Direction.Down;
            this.linearGaugeNeedleIndicator5.HorizontalLineWidth = 0;
            this.linearGaugeNeedleIndicator5.InnerPointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator5.LocationPercentage = 17F;
            this.linearGaugeNeedleIndicator5.Name = "linearGaugeNeedleIndicator5";
            this.linearGaugeNeedleIndicator5.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator5.Value = 90F;
            // 
            // radLinearGauge4
            // 
            this.radLinearGauge4.BackColor = System.Drawing.Color.White;
            this.radLinearGauge4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar6,
            this.linearGaugeBar7,
            this.linearGaugeTicks11});
            this.radLinearGauge4.Location = new System.Drawing.Point(382, 18);
            this.radLinearGauge4.Name = "radLinearGauge4";
            this.radLinearGauge4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radLinearGauge4.RangeEnd = 120F;
            this.radLinearGauge4.Size = new System.Drawing.Size(59, 280);
            this.radLinearGauge4.TabIndex = 0;
            this.radLinearGauge4.Text = "radLinearGauge1";
            this.radLinearGauge4.Value = 70F;
            this.radLinearGauge4.Vertical = true;
            // 
            // linearGaugeBar6
            // 
            this.linearGaugeBar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.linearGaugeBar6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.linearGaugeBar6.BindEndRange = true;
            this.linearGaugeBar6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeBar6.Name = "linearGaugeBar6";
            this.linearGaugeBar6.Offset = 30F;
            this.linearGaugeBar6.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar6.RangeEnd = 70F;
            this.linearGaugeBar6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // linearGaugeBar7
            // 
            this.linearGaugeBar7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.linearGaugeBar7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.linearGaugeBar7.BindStartRange = true;
            this.linearGaugeBar7.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeBar7.Name = "linearGaugeBar7";
            this.linearGaugeBar7.Offset = 30F;
            this.linearGaugeBar7.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar7.RangeEnd = 120F;
            this.linearGaugeBar7.RangeStart = 70F;
            this.linearGaugeBar7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // linearGaugeTicks11
            // 
            this.linearGaugeTicks11.AutoSize = true;
            this.linearGaugeTicks11.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeTicks11.Name = "linearGaugeTicks11";
            this.linearGaugeTicks11.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.linearGaugeTicks11.TickColor = System.Drawing.Color.White;
            this.linearGaugeTicks11.TicksCount = 11;
            this.linearGaugeTicks11.TicksLenghtPercentage = 44F;
            this.linearGaugeTicks11.TicksLocationPercentage = 60F;
            this.linearGaugeTicks11.TicksOffset = 30;
            // 
            // radLinearGauge3
            // 
            this.radLinearGauge3.BackColor = System.Drawing.Color.White;
            this.radLinearGauge3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar4,
            this.linearGaugeBar5,
            this.linearGaugeTicks9,
            this.linearGaugeLine6,
            this.linearGaugeTicks10,
            this.linearGaugeLabels4});
            this.radLinearGauge3.Location = new System.Drawing.Point(272, 18);
            this.radLinearGauge3.Name = "radLinearGauge3";
            this.radLinearGauge3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.radLinearGauge3.RangeEnd = 120F;
            this.radLinearGauge3.Size = new System.Drawing.Size(59, 280);
            this.radLinearGauge3.TabIndex = 0;
            this.radLinearGauge3.Text = "radLinearGauge1";
            this.radLinearGauge3.Value = 70F;
            this.radLinearGauge3.Vertical = true;
            // 
            // linearGaugeBar4
            // 
            this.linearGaugeBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.linearGaugeBar4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(105)))));
            this.linearGaugeBar4.BindEndRange = true;
            this.linearGaugeBar4.Name = "linearGaugeBar4";
            this.linearGaugeBar4.Offset = 30F;
            this.linearGaugeBar4.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar4.RangeEnd = 70F;
            // 
            // linearGaugeBar5
            // 
            this.linearGaugeBar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.linearGaugeBar5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.linearGaugeBar5.BindStartRange = true;
            this.linearGaugeBar5.Name = "linearGaugeBar5";
            this.linearGaugeBar5.Offset = 30F;
            this.linearGaugeBar5.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar5.RangeEnd = 120F;
            this.linearGaugeBar5.RangeStart = 70F;
            // 
            // linearGaugeTicks9
            // 
            this.linearGaugeTicks9.AutoSize = true;
            this.linearGaugeTicks9.Name = "linearGaugeTicks9";
            this.linearGaugeTicks9.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks9.TickColor = System.Drawing.Color.White;
            this.linearGaugeTicks9.TicksCount = 11;
            this.linearGaugeTicks9.TicksLenghtPercentage = 44F;
            this.linearGaugeTicks9.TicksLocationPercentage = 60F;
            this.linearGaugeTicks9.TicksOffset = 30;
            // 
            // linearGaugeLine6
            // 
            this.linearGaugeLine6.Name = "linearGaugeLine6";
            this.linearGaugeLine6.Offset = 30F;
            this.linearGaugeLine6.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine6.RangeEnd = 120F;
            this.linearGaugeLine6.RangeStart = 80F;
            // 
            // linearGaugeTicks10
            // 
            this.linearGaugeTicks10.Name = "linearGaugeTicks10";
            this.linearGaugeTicks10.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks10.TickEndIndexVisibleRange = 1F;
            this.linearGaugeTicks10.TicksCount = 3;
            this.linearGaugeTicks10.TicksLenghtPercentage = 15F;
            this.linearGaugeTicks10.TicksLocationPercentage = 30F;
            this.linearGaugeTicks10.TickThickness = 0.7F;
            // 
            // linearGaugeLabels4
            // 
            this.linearGaugeLabels4.LabelFontSize = 3F;
            this.linearGaugeLabels4.LabelLocationPercentage = 10F;
            this.linearGaugeLabels4.LabelsCount = 3;
            this.linearGaugeLabels4.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels4.Name = "linearGaugeLabels4";
            this.linearGaugeLabels4.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge2
            // 
            this.radLinearGauge2.BackColor = System.Drawing.Color.White;
            this.radLinearGauge2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar2,
            this.linearGaugeBar3,
            this.linearGaugeLine4,
            this.linearGaugeLine5,
            this.linearGaugeTicks5,
            this.linearGaugeTicks6,
            this.linearGaugeTicks7,
            this.linearGaugeTicks8,
            this.linearGaugeLabels2,
            this.linearGaugeLabels3});
            this.radLinearGauge2.Location = new System.Drawing.Point(166, 18);
            this.radLinearGauge2.Name = "radLinearGauge2";
            this.radLinearGauge2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radLinearGauge2.RangeEnd = 120F;
            this.radLinearGauge2.Size = new System.Drawing.Size(60, 280);
            this.radLinearGauge2.TabIndex = 0;
            this.radLinearGauge2.Text = "radLinearGauge1";
            this.radLinearGauge2.Value = 70F;
            this.radLinearGauge2.Vertical = true;
            // 
            // linearGaugeBar2
            // 
            this.linearGaugeBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar2.BindEndRange = true;
            this.linearGaugeBar2.Name = "linearGaugeBar2";
            this.linearGaugeBar2.Offset = 35F;
            this.linearGaugeBar2.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar2.RangeEnd = 70F;
            // 
            // linearGaugeBar3
            // 
            this.linearGaugeBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linearGaugeBar3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linearGaugeBar3.BindStartRange = true;
            this.linearGaugeBar3.BindStartRangeOffset = 1F;
            this.linearGaugeBar3.Name = "linearGaugeBar3";
            this.linearGaugeBar3.Offset = 35F;
            this.linearGaugeBar3.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar3.RangeEnd = 120F;
            this.linearGaugeBar3.RangeStart = 71F;
            // 
            // linearGaugeLine4
            // 
            this.linearGaugeLine4.AutoSize = false;
            this.linearGaugeLine4.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine4.Name = "linearGaugeLine4";
            this.linearGaugeLine4.Offset = 35F;
            this.linearGaugeLine4.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine4.RangeEnd = 80F;
            this.linearGaugeLine4.Width = 2F;
            // 
            // linearGaugeLine5
            // 
            this.linearGaugeLine5.AutoSize = false;
            this.linearGaugeLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine5.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine5.Name = "linearGaugeLine5";
            this.linearGaugeLine5.Offset = 35F;
            this.linearGaugeLine5.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine5.RangeEnd = 120F;
            this.linearGaugeLine5.RangeStart = 80F;
            this.linearGaugeLine5.Width = 2F;
            // 
            // linearGaugeTicks5
            // 
            this.linearGaugeTicks5.Name = "linearGaugeTicks5";
            this.linearGaugeTicks5.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks5.TicksCount = 3;
            this.linearGaugeTicks5.TicksLenghtPercentage = 9F;
            this.linearGaugeTicks5.TicksLocationPercentage = 30F;
            this.linearGaugeTicks5.TickStartIndexVisibleRange = 2F;
            this.linearGaugeTicks5.TickThickness = 0.7F;
            // 
            // linearGaugeTicks6
            // 
            this.linearGaugeTicks6.Name = "linearGaugeTicks6";
            this.linearGaugeTicks6.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks6.TicksCount = 12;
            this.linearGaugeTicks6.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks6.TicksLocationPercentage = 30F;
            this.linearGaugeTicks6.TickStartIndexVisibleRange = 5F;
            this.linearGaugeTicks6.TickThickness = 0.6F;
            // 
            // linearGaugeTicks7
            // 
            this.linearGaugeTicks7.Name = "linearGaugeTicks7";
            this.linearGaugeTicks7.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks7.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeTicks7.TickEndIndexVisibleRange = 4F;
            this.linearGaugeTicks7.TicksCount = 12;
            this.linearGaugeTicks7.TicksLenghtPercentage = 5F;
            this.linearGaugeTicks7.TicksLocationPercentage = 30F;
            // 
            // linearGaugeTicks8
            // 
            this.linearGaugeTicks8.Name = "linearGaugeTicks8";
            this.linearGaugeTicks8.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks8.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeTicks8.TickEndIndexVisibleRange = 1F;
            this.linearGaugeTicks8.TicksCount = 3;
            this.linearGaugeTicks8.TicksLocationPercentage = 30F;
            // 
            // linearGaugeLabels2
            // 
            this.linearGaugeLabels2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLabels2.LabelFontSize = 3F;
            this.linearGaugeLabels2.LabelLocationPercentage = 15F;
            this.linearGaugeLabels2.LabelsCount = 3;
            this.linearGaugeLabels2.LabelStartVisibleRange = 80F;
            this.linearGaugeLabels2.Name = "linearGaugeLabels2";
            this.linearGaugeLabels2.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeLabels3
            // 
            this.linearGaugeLabels3.LabelEndVisibleRange = 40F;
            this.linearGaugeLabels3.LabelFontSize = 3F;
            this.linearGaugeLabels3.LabelLocationPercentage = 15F;
            this.linearGaugeLabels3.LabelsCount = 3;
            this.linearGaugeLabels3.Name = "linearGaugeLabels3";
            this.linearGaugeLabels3.Padding = new System.Windows.Forms.Padding(0);
            // 
            // radLinearGauge1
            // 
            this.radLinearGauge1.BackColor = System.Drawing.Color.White;
            this.radLinearGauge1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.linearGaugeBar1,
            this.linearGaugeLine1,
            this.linearGaugeLine2,
            this.linearGaugeTicks1,
            this.linearGaugeLabels1,
            this.linearGaugeTicks2,
            this.linearGaugeTicks3,
            this.linearGaugeLine3,
            this.linearGaugeTicks4,
            this.linearGaugeNeedleIndicator1});
            this.radLinearGauge1.Location = new System.Drawing.Point(24, 18);
            this.radLinearGauge1.Name = "radLinearGauge1";
            this.radLinearGauge1.Padding = new System.Windows.Forms.Padding(0, 5, 40, 5);
            this.radLinearGauge1.RangeEnd = 120F;
            this.radLinearGauge1.Size = new System.Drawing.Size(106, 280);
            this.radLinearGauge1.TabIndex = 0;
            this.radLinearGauge1.Text = "radLinearGauge1";
            this.radLinearGauge1.Value = 70F;
            this.radLinearGauge1.Vertical = true;
            // 
            // linearGaugeBar1
            // 
            this.linearGaugeBar1.AutoSize = false;
            this.linearGaugeBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(163)))));
            this.linearGaugeBar1.BindEndRange = true;
            this.linearGaugeBar1.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeBar1.Name = "linearGaugeBar1";
            this.linearGaugeBar1.Offset = 35F;
            this.linearGaugeBar1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeBar1.RangeEnd = 70F;
            this.linearGaugeBar1.Width = 24F;
            this.linearGaugeBar1.Width2 = 24F;
            // 
            // linearGaugeLine1
            // 
            this.linearGaugeLine1.AutoSize = false;
            this.linearGaugeLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeLine1.Bounds = new System.Drawing.Rectangle(0, 0, 60, 270);
            this.linearGaugeLine1.Name = "linearGaugeLine1";
            this.linearGaugeLine1.Offset = 35F;
            this.linearGaugeLine1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine1.RangeEnd = 80F;
            this.linearGaugeLine1.Width = 2F;
            // 
            // linearGaugeLine2
            // 
            this.linearGaugeLine2.AutoSize = false;
            this.linearGaugeLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeLine2.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeLine2.Name = "linearGaugeLine2";
            this.linearGaugeLine2.Offset = 35F;
            this.linearGaugeLine2.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine2.RangeEnd = 120F;
            this.linearGaugeLine2.RangeStart = 80F;
            this.linearGaugeLine2.Width = 2F;
            // 
            // linearGaugeTicks1
            // 
            this.linearGaugeTicks1.AutoSize = false;
            this.linearGaugeTicks1.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks1.Name = "linearGaugeTicks1";
            this.linearGaugeTicks1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeTicks1.TicksCount = 3;
            this.linearGaugeTicks1.TicksLenghtPercentage = 4F;
            this.linearGaugeTicks1.TicksLocationPercentage = 33F;
            // 
            // linearGaugeLabels1
            // 
            this.linearGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeLabels1.LabelFontSize = 3F;
            this.linearGaugeLabels1.LabelLocationPercentage = 15F;
            this.linearGaugeLabels1.LabelsCount = 3;
            this.linearGaugeLabels1.Name = "linearGaugeLabels1";
            this.linearGaugeLabels1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // linearGaugeTicks2
            // 
            this.linearGaugeTicks2.AutoSize = false;
            this.linearGaugeTicks2.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks2.Name = "linearGaugeTicks2";
            this.linearGaugeTicks2.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.linearGaugeTicks2.TickEndIndexVisibleRange = 4F;
            this.linearGaugeTicks2.TicksCount = 12;
            this.linearGaugeTicks2.TicksLenghtPercentage = 2F;
            this.linearGaugeTicks2.TicksLocationPercentage = 33F;
            // 
            // linearGaugeTicks3
            // 
            this.linearGaugeTicks3.AutoSize = false;
            this.linearGaugeTicks3.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks3.Name = "linearGaugeTicks3";
            this.linearGaugeTicks3.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks3.TicksCount = 12;
            this.linearGaugeTicks3.TicksLenghtPercentage = 2F;
            this.linearGaugeTicks3.TicksLocationPercentage = 33F;
            this.linearGaugeTicks3.TickStartIndexVisibleRange = 5F;
            // 
            // linearGaugeLine3
            // 
            this.linearGaugeLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeLine3.Name = "linearGaugeLine3";
            this.linearGaugeLine3.Offset = 69F;
            this.linearGaugeLine3.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeLine3.RangeEnd = 120F;
            // 
            // linearGaugeTicks4
            // 
            this.linearGaugeTicks4.AutoSize = false;
            this.linearGaugeTicks4.Bounds = new System.Drawing.Rectangle(0, 0, 59, 270);
            this.linearGaugeTicks4.Name = "linearGaugeTicks4";
            this.linearGaugeTicks4.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeTicks4.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.linearGaugeTicks4.TicksCount = 12;
            this.linearGaugeTicks4.TicksLenghtPercentage = 3F;
            this.linearGaugeTicks4.TicksLocationPercentage = 72F;
            // 
            // linearGaugeNeedleIndicator1
            // 
            this.linearGaugeNeedleIndicator1.AutoSize = false;
            this.linearGaugeNeedleIndicator1.BackColor = System.Drawing.Color.Red;
            this.linearGaugeNeedleIndicator1.Bounds = new System.Drawing.Rectangle(0, 0, 63, 270);
            this.linearGaugeNeedleIndicator1.CircleTicks = true;
            this.linearGaugeNeedleIndicator1.Direction = Telerik.WinControls.UI.Gauges.Direction.Left;
            this.linearGaugeNeedleIndicator1.DrawValue = true;
            this.linearGaugeNeedleIndicator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.linearGaugeNeedleIndicator1.InnerPointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator1.IsFilled = false;
            this.linearGaugeNeedleIndicator1.LenghtPercentage = 6F;
            this.linearGaugeNeedleIndicator1.LineLenght = 40F;
            this.linearGaugeNeedleIndicator1.LocationPercentage = 70F;
            this.linearGaugeNeedleIndicator1.Name = "linearGaugeNeedleIndicator1";
            this.linearGaugeNeedleIndicator1.Padding = new System.Windows.Forms.Padding(0);
            this.linearGaugeNeedleIndicator1.PointRadiusPercentage = 10F;
            this.linearGaugeNeedleIndicator1.TextOffsetFromIndicator = new System.Drawing.SizeF(2F, -5F);
            this.linearGaugeNeedleIndicator1.Value = 66F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScrollablePanel3);
            this.Controls.Add(this.radScrollablePanel2);
            this.Controls.Add(this.radScrollablePanel1);
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(1220, 814);
            this.Controls.SetChildIndex(this.radScrollablePanel1, 0);
            this.Controls.SetChildIndex(this.radScrollablePanel2, 0);
            this.Controls.SetChildIndex(this.radScrollablePanel3, 0);
            this.Controls.SetChildIndex(this.settingsPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            this.radScrollablePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).EndInit();
            this.radScrollablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge9)).EndInit();
            this.radScrollablePanel2.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel2)).EndInit();
            this.radScrollablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge5)).EndInit();
            this.radScrollablePanel3.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel3)).EndInit();
            this.radScrollablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBulletGraph5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLinearGauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton3;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel1;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel2;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel3;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge3;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar4;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar5;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks9;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine6;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks10;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels4;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar3;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine4;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine5;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks5;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks6;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks7;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks8;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels3;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks3;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine3;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks4;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator1;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge4;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar6;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar7;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks11;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge5;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar8;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine7;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks12;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels5;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks13;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine8;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks14;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator2;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge8;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar13;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar14;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks19;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge7;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar11;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar12;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks17;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine10;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks18;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels7;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge6;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar9;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar10;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine9;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks15;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels6;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks16;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge12;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar20;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar21;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks30;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge11;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar18;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar19;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks28;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine16;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks29;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels11;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge10;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar16;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar17;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine14;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine15;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks24;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks25;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks26;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks27;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels9;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels10;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge9;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar15;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine11;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine12;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks20;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels8;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks21;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks22;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine13;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks23;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator3;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge15;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar27;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar28;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine19;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks33;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels14;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge14;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar25;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar26;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine18;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks32;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels13;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge13;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar22;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar23;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar24;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine17;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks31;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels12;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator4;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge18;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar34;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar35;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine22;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks36;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels17;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge17;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar32;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar33;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine21;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks35;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels16;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge16;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar29;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar30;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar31;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine20;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks34;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels15;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator5;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge21;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar39;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar40;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine25;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks39;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels20;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge20;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar37;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar38;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine24;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks38;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels19;
        private Telerik.WinControls.UI.Gauges.RadLinearGauge radLinearGauge19;
        private Telerik.WinControls.UI.Gauges.LinearGaugeBar linearGaugeBar36;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLine linearGaugeLine23;
        private Telerik.WinControls.UI.Gauges.LinearGaugeTicks linearGaugeTicks37;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels18;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator6;
        private Telerik.WinControls.UI.Gauges.RadBulletGraph radBulletGraph2;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar4;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar5;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar6;
        private Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar bulletGraphFeaturedMeasureBar2;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator8;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels22;
        private Telerik.WinControls.UI.Gauges.RadBulletGraph radBulletGraph1;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar1;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar2;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar3;
        private Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar bulletGraphFeaturedMeasureBar1;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator7;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels21;
        private Telerik.WinControls.UI.Gauges.RadBulletGraph radBulletGraph4;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar10;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar11;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar12;
        private Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar bulletGraphFeaturedMeasureBar4;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator10;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels24;
        private Telerik.WinControls.UI.Gauges.RadBulletGraph radBulletGraph3;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar7;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar8;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar9;
        private Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar bulletGraphFeaturedMeasureBar3;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator9;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels23;
        private Telerik.WinControls.UI.Gauges.RadBulletGraph radBulletGraph6;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar16;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar17;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar18;
        private Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar bulletGraphFeaturedMeasureBar6;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator12;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels26;
        private Telerik.WinControls.UI.Gauges.RadBulletGraph radBulletGraph5;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar13;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar14;
        private Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar bulletGraphQualitativeBar15;
        private Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar bulletGraphFeaturedMeasureBar5;
        private Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator linearGaugeNeedleIndicator11;
        private Telerik.WinControls.UI.Gauges.LinearGaugeLabels linearGaugeLabels25;
    }
}