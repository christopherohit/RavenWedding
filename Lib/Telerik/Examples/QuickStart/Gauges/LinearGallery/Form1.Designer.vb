Imports System.Drawing
Imports Telerik.WinControls.Primitives
Namespace Telerik.Examples.WinControls.Gauges.LinearGallery
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            timer.[Stop]()
            timer.Dispose()
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radialGaugeArc22 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc23 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks18 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks19 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks20 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks21 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels8 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeLabels9 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle11 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeNeedle12 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radBulletGraph4 = New Telerik.WinControls.UI.Gauges.RadBulletGraph()
            Me.bulletGraphQualitativeBar10 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar11 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar12 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphFeaturedMeasureBar4 = New Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar()
            Me.linearGaugeNeedleIndicator10 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.linearGaugeLabels24 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radBulletGraph3 = New Telerik.WinControls.UI.Gauges.RadBulletGraph()
            Me.bulletGraphQualitativeBar7 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar8 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar9 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphFeaturedMeasureBar3 = New Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar()
            Me.linearGaugeNeedleIndicator9 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.linearGaugeLabels23 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge15 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar27 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar28 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine19 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks33 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels14 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge14 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar25 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar26 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine18 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks32 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels13 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge13 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar22 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar23 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar24 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine17 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks31 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels12 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeNeedleIndicator4 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.radLinearGauge12 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar20 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar21 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeTicks30 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.radLinearGauge11 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar18 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar19 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeTicks28 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLine16 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks29 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels11 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge10 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar16 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar17 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine14 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeLine15 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks24 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks25 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks26 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks27 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels9 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeLabels10 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge9 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar15 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine11 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeLine12 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks20 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels8 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeTicks21 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks22 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLine13 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks23 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeNeedleIndicator3 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.radScrollablePanel2 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radBulletGraph2 = New Telerik.WinControls.UI.Gauges.RadBulletGraph()
            Me.bulletGraphQualitativeBar4 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar5 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar6 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphFeaturedMeasureBar2 = New Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar()
            Me.linearGaugeNeedleIndicator8 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.linearGaugeLabels22 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radBulletGraph1 = New Telerik.WinControls.UI.Gauges.RadBulletGraph()
            Me.bulletGraphQualitativeBar1 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar2 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar3 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphFeaturedMeasureBar1 = New Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar()
            Me.linearGaugeNeedleIndicator7 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.linearGaugeLabels21 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge21 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar39 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar40 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine25 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks39 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels20 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge20 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar37 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar38 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine24 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks38 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels19 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge19 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar36 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine23 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks37 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels18 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeNeedleIndicator6 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.radLinearGauge8 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar13 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar14 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeTicks19 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.radLinearGauge7 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar11 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar12 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeTicks17 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLine10 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks18 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels7 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge6 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar9 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar10 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine9 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks15 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels6 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeTicks16 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.radLinearGauge5 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar8 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine7 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks12 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels5 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeTicks13 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLine8 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks14 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeNeedleIndicator2 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.radScrollablePanel3 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radBulletGraph6 = New Telerik.WinControls.UI.Gauges.RadBulletGraph()
            Me.bulletGraphQualitativeBar16 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar17 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar18 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphFeaturedMeasureBar6 = New Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar()
            Me.linearGaugeNeedleIndicator12 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.linearGaugeLabels26 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radBulletGraph5 = New Telerik.WinControls.UI.Gauges.RadBulletGraph()
            Me.bulletGraphQualitativeBar13 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar14 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphQualitativeBar15 = New Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar()
            Me.bulletGraphFeaturedMeasureBar5 = New Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar()
            Me.linearGaugeNeedleIndicator11 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.linearGaugeLabels25 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge18 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar34 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar35 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine22 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks36 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels17 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge17 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar32 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar33 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine21 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks35 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels16 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge16 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar29 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar30 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar31 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine20 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks34 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels15 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeNeedleIndicator5 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            Me.radLinearGauge4 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar6 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar7 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeTicks11 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.radLinearGauge3 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar4 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar5 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeTicks9 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLine6 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks10 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels4 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge2 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar2 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeBar3 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine4 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeLine5 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks5 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks6 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks7 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks8 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels2 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeLabels3 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.radLinearGauge1 = New Telerik.WinControls.UI.Gauges.RadLinearGauge()
            Me.linearGaugeBar1 = New Telerik.WinControls.UI.Gauges.LinearGaugeBar()
            Me.linearGaugeLine1 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeLine2 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks1 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLabels1 = New Telerik.WinControls.UI.Gauges.LinearGaugeLabels()
            Me.linearGaugeTicks2 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeTicks3 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeLine3 = New Telerik.WinControls.UI.Gauges.LinearGaugeLine()
            Me.linearGaugeTicks4 = New Telerik.WinControls.UI.Gauges.LinearGaugeTicks()
            Me.linearGaugeNeedleIndicator1 = New Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator()
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            DirectCast(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radScrollablePanel1.PanelContainer.SuspendLayout()
            Me.radScrollablePanel1.SuspendLayout()
            DirectCast(Me.radBulletGraph4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radBulletGraph3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge15, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge14, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge13, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge12, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge11, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge10, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge9, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radScrollablePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radScrollablePanel2.PanelContainer.SuspendLayout()
            Me.radScrollablePanel2.SuspendLayout()
            DirectCast(Me.radBulletGraph2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radBulletGraph1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge21, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge20, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge19, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radScrollablePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radScrollablePanel3.PanelContainer.SuspendLayout()
            Me.radScrollablePanel3.SuspendLayout()
            DirectCast(Me.radBulletGraph6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radBulletGraph5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge18, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge17, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge16, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radLinearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Location = New System.Drawing.Point(1122, 0)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            ' 
            ' radialGaugeArc22
            ' 
            Me.radialGaugeArc22.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.radialGaugeArc22.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc22.BackColor3 = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.radialGaugeArc22.Name = "radialGaugeArc22"
            Me.radialGaugeArc22.RangeEnd = 120.0
            Me.radialGaugeArc22.Width = 1.0
            ' 
            ' radialGaugeArc23
            ' 
            Me.radialGaugeArc23.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(91)), CInt(CByte(91)))
            Me.radialGaugeArc23.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(90)), CInt(CByte(90)))
            Me.radialGaugeArc23.BackColor3 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(91)), CInt(CByte(91)))
            Me.radialGaugeArc23.Name = "radialGaugeArc23"
            Me.radialGaugeArc23.RangeEnd = 180.0
            Me.radialGaugeArc23.RangeStart = 120.0
            Me.radialGaugeArc23.Width = 1.0
            ' 
            ' radialGaugeTicks18
            ' 
            Me.radialGaugeTicks18.DrawText = False
            Me.radialGaugeTicks18.Name = "radialGaugeTicks18"
            Me.radialGaugeTicks18.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.radialGaugeTicks18.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks18.TicksCount = 18
            Me.radialGaugeTicks18.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks18.TickThickness = 1.0F
            ' 
            ' radialGaugeTicks19
            ' 
            Me.radialGaugeTicks19.DrawText = False
            Me.radialGaugeTicks19.Name = "radialGaugeTicks19"
            Me.radialGaugeTicks19.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.radialGaugeTicks19.TickEndIndexVisibleRange = 35.0F
            Me.radialGaugeTicks19.TicksCount = 54
            Me.radialGaugeTicks19.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks19.TickThickness = 1.0F
            ' 
            ' radialGaugeTicks20
            ' 
            Me.radialGaugeTicks20.DrawText = False
            Me.radialGaugeTicks20.Name = "radialGaugeTicks20"
            Me.radialGaugeTicks20.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(90)), CInt(CByte(90)))
            Me.radialGaugeTicks20.TicksCount = 18
            Me.radialGaugeTicks20.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks20.TickStartIndexVisibleRange = 12.0F
            Me.radialGaugeTicks20.TickThickness = 1.0F
            ' 
            ' radialGaugeTicks21
            ' 
            Me.radialGaugeTicks21.DrawText = False
            Me.radialGaugeTicks21.Name = "radialGaugeTicks21"
            Me.radialGaugeTicks21.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(90)), CInt(CByte(90)))
            Me.radialGaugeTicks21.TicksCount = 54
            Me.radialGaugeTicks21.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks21.TickStartIndexVisibleRange = 37.0F
            Me.radialGaugeTicks21.TickThickness = 1.0F
            ' 
            ' radialGaugeLabels8
            ' 
            Me.radialGaugeLabels8.DrawText = False
            Me.radialGaugeLabels8.LabelEndVisibleRange = 100.0F
            Me.radialGaugeLabels8.LabelFontSize = 4.0F
            Me.radialGaugeLabels8.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels8.LabelsCount = 9
            Me.radialGaugeLabels8.Name = "radialGaugeLabels8"
            ' 
            ' radialGaugeLabels9
            ' 
            Me.radialGaugeLabels9.DrawText = False
            Me.radialGaugeLabels9.ForeColor = System.Drawing.Color.Red
            Me.radialGaugeLabels9.LabelFontSize = 4.0F
            Me.radialGaugeLabels9.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels9.LabelsCount = 9
            Me.radialGaugeLabels9.LabelStartVisibleRange = 120.0F
            Me.radialGaugeLabels9.Name = "radialGaugeLabels9"
            ' 
            ' radialGaugeNeedle11
            ' 
            Me.radialGaugeNeedle11.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.radialGaugeNeedle11.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.radialGaugeNeedle11.InnerPointRadiusPercentage = 0.0
            Me.radialGaugeNeedle11.LenghtPercentage = 78.0
            Me.radialGaugeNeedle11.Name = "radialGaugeNeedle11"
            Me.radialGaugeNeedle11.PointRadiusPercentage = 0.0
            Me.radialGaugeNeedle11.Thickness = 2.0
            Me.radialGaugeNeedle11.Value = 90.0F
            ' 
            ' radialGaugeNeedle12
            ' 
            Me.radialGaugeNeedle12.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(90)), CInt(CByte(90)))
            Me.radialGaugeNeedle12.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(90)), CInt(CByte(90)))
            Me.radialGaugeNeedle12.InnerPointRadiusPercentage = 0.0
            Me.radialGaugeNeedle12.LenghtPercentage = 78.0
            Me.radialGaugeNeedle12.Name = "radialGaugeNeedle12"
            Me.radialGaugeNeedle12.PointRadiusPercentage = 6.0
            Me.radialGaugeNeedle12.Thickness = 2.0
            Me.radialGaugeNeedle12.Value = 130.0F
            ' 
            ' radGroupBox1
            ' 
            Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupBox1.Controls.Add(Me.radRadioButton3)
            Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
            Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
            Me.radGroupBox1.HeaderText = "Style"
            Me.radGroupBox1.Location = New System.Drawing.Point(10, 33)
            Me.radGroupBox1.Name = "radGroupBox1"
            Me.radGroupBox1.Size = New System.Drawing.Size(210, 100)
            Me.radGroupBox1.TabIndex = 1
            Me.radGroupBox1.Text = "Style"
            ' 
            ' radRadioButton3
            ' 
            Me.radRadioButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButton3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radRadioButton3.Location = New System.Drawing.Point(5, 23)
            Me.radRadioButton3.Name = "radRadioButton3"
            Me.radRadioButton3.Size = New System.Drawing.Size(65, 18)
            Me.radRadioButton3.TabIndex = 2
            Me.radRadioButton3.Text = "Standard"
            Me.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radRadioButton3.ToggleStateChanged, AddressOf Me.radRadioButton1_ToggleStateChanged
            ' 
            ' radRadioButton2
            ' 
            Me.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButton2.Location = New System.Drawing.Point(5, 47)
            Me.radRadioButton2.Name = "radRadioButton2"
            Me.radRadioButton2.Size = New System.Drawing.Size(57, 18)
            Me.radRadioButton2.TabIndex = 1
            Me.radRadioButton2.Text = "Vibrant"
            AddHandler Me.radRadioButton2.ToggleStateChanged, AddressOf Me.radRadioButton1_ToggleStateChanged
            ' 
            ' radRadioButton1
            ' 
            Me.radRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButton1.Location = New System.Drawing.Point(5, 71)
            Me.radRadioButton1.Name = "radRadioButton1"
            Me.radRadioButton1.Size = New System.Drawing.Size(80, 18)
            Me.radRadioButton1.TabIndex = 0
            Me.radRadioButton1.Text = "Minimalistic"
            AddHandler Me.radRadioButton1.ToggleStateChanged, AddressOf Me.radRadioButton1_ToggleStateChanged
            ' 
            ' radScrollablePanel1
            ' 
            Me.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScrollablePanel1.Location = New System.Drawing.Point(0, 0)
            Me.radScrollablePanel1.Name = "radScrollablePanel1"
            Me.radScrollablePanel1.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radScrollablePanel1.PanelContainer
            ' 
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radBulletGraph4)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radBulletGraph3)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLinearGauge15)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLinearGauge14)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLinearGauge13)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLinearGauge12)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLinearGauge11)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLinearGauge10)
            Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.radLinearGauge9)
            Me.radScrollablePanel1.PanelContainer.Location = New System.Drawing.Point(0, 0)
            Me.radScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(1210, 804)
            Me.radScrollablePanel1.Size = New System.Drawing.Size(1210, 804)
            Me.radScrollablePanel1.TabIndex = 2
            Me.radScrollablePanel1.Text = "radScrollablePanel1"
            DirectCast(Me.radScrollablePanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' radBulletGraph4
            ' 
            Me.radBulletGraph4.BackColor = System.Drawing.Color.White
            Me.radBulletGraph4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.bulletGraphQualitativeBar10, Me.bulletGraphQualitativeBar11, Me.bulletGraphQualitativeBar12, Me.bulletGraphFeaturedMeasureBar4, Me.linearGaugeNeedleIndicator10, Me.linearGaugeLabels24})
            Me.radBulletGraph4.Location = New System.Drawing.Point(577, 249)
            Me.radBulletGraph4.Name = "radBulletGraph4"
            Me.radBulletGraph4.Padding = New System.Windows.Forms.Padding(5, 0, 10, 20)
            Me.radBulletGraph4.Size = New System.Drawing.Size(280, 50)
            Me.radBulletGraph4.TabIndex = 3
            Me.radBulletGraph4.Text = "radBulletGraph1"
            Me.radBulletGraph4.Value = 0.0F
            ' 
            ' bulletGraphQualitativeBar10
            ' 
            Me.bulletGraphQualitativeBar10.Name = "bulletGraphQualitativeBar10"
            Me.bulletGraphQualitativeBar10.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar10.RangeEnd = 49.0F
            ' 
            ' bulletGraphQualitativeBar11
            ' 
            Me.bulletGraphQualitativeBar11.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar11.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar11.Name = "bulletGraphQualitativeBar11"
            Me.bulletGraphQualitativeBar11.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar11.RangeEnd = 74.0F
            Me.bulletGraphQualitativeBar11.RangeStart = 50.0F
            ' 
            ' bulletGraphQualitativeBar12
            ' 
            Me.bulletGraphQualitativeBar12.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar12.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar12.Name = "bulletGraphQualitativeBar12"
            Me.bulletGraphQualitativeBar12.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar12.RangeStart = 75.0F
            ' 
            ' bulletGraphFeaturedMeasureBar4
            ' 
            Me.bulletGraphFeaturedMeasureBar4.AutoSize = False
            Me.bulletGraphFeaturedMeasureBar4.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.bulletGraphFeaturedMeasureBar4.Name = "bulletGraphFeaturedMeasureBar4"
            Me.bulletGraphFeaturedMeasureBar4.Offset = 11.0F
            Me.bulletGraphFeaturedMeasureBar4.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphFeaturedMeasureBar4.RangeEnd = 85.0F
            Me.bulletGraphFeaturedMeasureBar4.Width = 10.0F
            Me.bulletGraphFeaturedMeasureBar4.Width2 = 10.0F
            ' 
            ' linearGaugeNeedleIndicator10
            ' 
            Me.linearGaugeNeedleIndicator10.AutoSize = False
            Me.linearGaugeNeedleIndicator10.BackColor = System.Drawing.Color.Black
            Me.linearGaugeNeedleIndicator10.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.linearGaugeNeedleIndicator10.LenghtPercentage = 0.0F
            Me.linearGaugeNeedleIndicator10.LineLenght = 30.0F
            Me.linearGaugeNeedleIndicator10.LocationPercentage = 30.0F
            Me.linearGaugeNeedleIndicator10.Name = "linearGaugeNeedleIndicator10"
            Me.linearGaugeNeedleIndicator10.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator10.Thickness = 3.0F
            Me.linearGaugeNeedleIndicator10.Value = 80.0F
            ' 
            ' linearGaugeLabels24
            ' 
            Me.linearGaugeLabels24.AutoSize = False
            Me.linearGaugeLabels24.Bounds = New System.Drawing.Rectangle(0, 0, 280, 40)
            Me.linearGaugeLabels24.LabelFontSize = 4.0F
            Me.linearGaugeLabels24.Name = "linearGaugeLabels24"
            Me.linearGaugeLabels24.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radBulletGraph3
            ' 
            Me.radBulletGraph3.BackColor = System.Drawing.Color.White
            Me.radBulletGraph3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.bulletGraphQualitativeBar7, Me.bulletGraphQualitativeBar8, Me.bulletGraphQualitativeBar9, Me.bulletGraphFeaturedMeasureBar3, Me.linearGaugeNeedleIndicator9, Me.linearGaugeLabels23})
            Me.radBulletGraph3.Location = New System.Drawing.Point(486, 18)
            Me.radBulletGraph3.Name = "radBulletGraph3"
            Me.radBulletGraph3.Padding = New System.Windows.Forms.Padding(0, 5, 30, 5)
            Me.radBulletGraph3.Size = New System.Drawing.Size(65, 280)
            Me.radBulletGraph3.TabIndex = 3
            Me.radBulletGraph3.Text = "radBulletGraph1"
            Me.radBulletGraph3.Value = 0.0F
            Me.radBulletGraph3.Vertical = True
            ' 
            ' bulletGraphQualitativeBar7
            ' 
            Me.bulletGraphQualitativeBar7.Name = "bulletGraphQualitativeBar7"
            Me.bulletGraphQualitativeBar7.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar7.RangeEnd = 49.0F
            ' 
            ' bulletGraphQualitativeBar8
            ' 
            Me.bulletGraphQualitativeBar8.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar8.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar8.Name = "bulletGraphQualitativeBar8"
            Me.bulletGraphQualitativeBar8.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar8.RangeEnd = 74.0F
            Me.bulletGraphQualitativeBar8.RangeStart = 50.0F
            ' 
            ' bulletGraphQualitativeBar9
            ' 
            Me.bulletGraphQualitativeBar9.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar9.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar9.Name = "bulletGraphQualitativeBar9"
            Me.bulletGraphQualitativeBar9.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar9.RangeStart = 75.0F
            ' 
            ' bulletGraphFeaturedMeasureBar3
            ' 
            Me.bulletGraphFeaturedMeasureBar3.AutoSize = False
            Me.bulletGraphFeaturedMeasureBar3.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.bulletGraphFeaturedMeasureBar3.Name = "bulletGraphFeaturedMeasureBar3"
            Me.bulletGraphFeaturedMeasureBar3.Offset = 12.0F
            Me.bulletGraphFeaturedMeasureBar3.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphFeaturedMeasureBar3.RangeEnd = 85.0F
            Me.bulletGraphFeaturedMeasureBar3.Width = 10.0F
            Me.bulletGraphFeaturedMeasureBar3.Width2 = 10.0F
            ' 
            ' linearGaugeNeedleIndicator9
            ' 
            Me.linearGaugeNeedleIndicator9.AutoSize = False
            Me.linearGaugeNeedleIndicator9.BackColor = System.Drawing.Color.Black
            Me.linearGaugeNeedleIndicator9.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.linearGaugeNeedleIndicator9.Direction = Telerik.WinControls.UI.Gauges.Direction.Left
            Me.linearGaugeNeedleIndicator9.LenghtPercentage = 0.0F
            Me.linearGaugeNeedleIndicator9.LineLenght = 36.0F
            Me.linearGaugeNeedleIndicator9.LocationPercentage = 35.0F
            Me.linearGaugeNeedleIndicator9.Name = "linearGaugeNeedleIndicator9"
            Me.linearGaugeNeedleIndicator9.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator9.Thickness = 3.0F
            Me.linearGaugeNeedleIndicator9.Value = 80.0F
            ' 
            ' linearGaugeLabels23
            ' 
            Me.linearGaugeLabels23.AutoSize = False
            Me.linearGaugeLabels23.Bounds = New System.Drawing.Rectangle(0, 0, 35, 278)
            Me.linearGaugeLabels23.LabelFontSize = 4.0F
            Me.linearGaugeLabels23.LabelLocationPercentage = 52.0F
            Me.linearGaugeLabels23.Name = "linearGaugeLabels23"
            Me.linearGaugeLabels23.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge15
            ' 
            Me.radLinearGauge15.BackColor = System.Drawing.Color.White
            Me.radLinearGauge15.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar27, Me.linearGaugeBar28, Me.linearGaugeLine19, Me.linearGaugeTicks33, Me.linearGaugeLabels14})
            Me.radLinearGauge15.Location = New System.Drawing.Point(577, 154)
            Me.radLinearGauge15.Name = "radLinearGauge15"
            Me.radLinearGauge15.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.radLinearGauge15.RangeEnd = 120.0F
            Me.radLinearGauge15.Size = New System.Drawing.Size(280, 50)
            Me.radLinearGauge15.TabIndex = 0
            Me.radLinearGauge15.Text = "radLinearGauge1"
            Me.radLinearGauge15.Value = 70.0F
            ' 
            ' linearGaugeBar27
            ' 
            Me.linearGaugeBar27.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar27.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar27.BindEndRange = True
            Me.linearGaugeBar27.Name = "linearGaugeBar27"
            Me.linearGaugeBar27.Offset = 35.0F
            Me.linearGaugeBar27.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar27.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar28
            ' 
            Me.linearGaugeBar28.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar28.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar28.BindStartRange = True
            Me.linearGaugeBar28.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar28.Name = "linearGaugeBar28"
            Me.linearGaugeBar28.Offset = 35.0F
            Me.linearGaugeBar28.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar28.RangeEnd = 120.0F
            Me.linearGaugeBar28.RangeStart = 71.0F
            ' 
            ' linearGaugeLine19
            ' 
            Me.linearGaugeLine19.Name = "linearGaugeLine19"
            Me.linearGaugeLine19.Offset = 30.0F
            Me.linearGaugeLine19.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine19.RangeEnd = 120.0F
            Me.linearGaugeLine19.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks33
            ' 
            Me.linearGaugeTicks33.Name = "linearGaugeTicks33"
            Me.linearGaugeTicks33.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks33.TicksCount = 3
            Me.linearGaugeTicks33.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks33.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks33.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks33.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels14
            ' 
            Me.linearGaugeLabels14.LabelFontSize = 3.0F
            Me.linearGaugeLabels14.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels14.LabelsCount = 3
            Me.linearGaugeLabels14.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels14.Name = "linearGaugeLabels14"
            Me.linearGaugeLabels14.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge14
            ' 
            Me.radLinearGauge14.BackColor = System.Drawing.Color.White
            Me.radLinearGauge14.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar25, Me.linearGaugeBar26, Me.linearGaugeLine18, Me.linearGaugeTicks32, Me.linearGaugeLabels13})
            Me.radLinearGauge14.Location = New System.Drawing.Point(577, 78)
            Me.radLinearGauge14.Name = "radLinearGauge14"
            Me.radLinearGauge14.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.radLinearGauge14.RangeEnd = 120.0F
            Me.radLinearGauge14.Size = New System.Drawing.Size(280, 50)
            Me.radLinearGauge14.TabIndex = 0
            Me.radLinearGauge14.Text = "radLinearGauge1"
            Me.radLinearGauge14.Value = 70.0F
            ' 
            ' linearGaugeBar25
            ' 
            Me.linearGaugeBar25.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar25.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar25.BindEndRange = True
            Me.linearGaugeBar25.Name = "linearGaugeBar25"
            Me.linearGaugeBar25.Offset = 35.0F
            Me.linearGaugeBar25.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar25.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar26
            ' 
            Me.linearGaugeBar26.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar26.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar26.BindStartRange = True
            Me.linearGaugeBar26.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar26.Name = "linearGaugeBar26"
            Me.linearGaugeBar26.Offset = 35.0F
            Me.linearGaugeBar26.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar26.RangeEnd = 120.0F
            Me.linearGaugeBar26.RangeStart = 71.0F
            ' 
            ' linearGaugeLine18
            ' 
            Me.linearGaugeLine18.Name = "linearGaugeLine18"
            Me.linearGaugeLine18.Offset = 30.0F
            Me.linearGaugeLine18.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine18.RangeEnd = 120.0F
            Me.linearGaugeLine18.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks32
            ' 
            Me.linearGaugeTicks32.Name = "linearGaugeTicks32"
            Me.linearGaugeTicks32.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks32.TicksCount = 3
            Me.linearGaugeTicks32.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks32.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks32.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks32.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels13
            ' 
            Me.linearGaugeLabels13.LabelFontSize = 3.0F
            Me.linearGaugeLabels13.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels13.LabelsCount = 3
            Me.linearGaugeLabels13.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels13.Name = "linearGaugeLabels13"
            Me.linearGaugeLabels13.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge13
            ' 
            Me.radLinearGauge13.BackColor = System.Drawing.Color.White
            Me.radLinearGauge13.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar22, Me.linearGaugeBar23, Me.linearGaugeBar24, Me.linearGaugeLine17, Me.linearGaugeTicks31, Me.linearGaugeLabels12, _
                Me.linearGaugeNeedleIndicator4})
            Me.radLinearGauge13.Location = New System.Drawing.Point(577, 18)
            Me.radLinearGauge13.Name = "radLinearGauge13"
            Me.radLinearGauge13.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.radLinearGauge13.RangeEnd = 120.0F
            Me.radLinearGauge13.Size = New System.Drawing.Size(280, 44)
            Me.radLinearGauge13.TabIndex = 2
            Me.radLinearGauge13.Text = "radLinearGauge2"
            Me.radLinearGauge13.Value = 90.0F
            ' 
            ' linearGaugeBar22
            ' 
            Me.linearGaugeBar22.AutoSize = True
            Me.linearGaugeBar22.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(92)), CInt(CByte(92)), CInt(CByte(92)))
            Me.linearGaugeBar22.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(92)), CInt(CByte(92)), CInt(CByte(92)))
            Me.linearGaugeBar22.Name = "linearGaugeBar22"
            Me.linearGaugeBar22.Offset = 25.0F
            Me.linearGaugeBar22.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar22.RangeEnd = 40.0F
            Me.linearGaugeBar22.Width = 10.0F
            Me.linearGaugeBar22.Width2 = 25.0F
            ' 
            ' linearGaugeBar23
            ' 
            Me.linearGaugeBar23.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar23.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar23.Name = "linearGaugeBar23"
            Me.linearGaugeBar23.Offset = 25.0F
            Me.linearGaugeBar23.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar23.RangeEnd = 80.0F
            Me.linearGaugeBar23.RangeStart = 41.0F
            Me.linearGaugeBar23.Width = 25.0F
            Me.linearGaugeBar23.Width2 = 40.0F
            ' 
            ' linearGaugeBar24
            ' 
            Me.linearGaugeBar24.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar24.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar24.Name = "linearGaugeBar24"
            Me.linearGaugeBar24.Offset = 25.0F
            Me.linearGaugeBar24.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar24.RangeEnd = 120.0F
            Me.linearGaugeBar24.RangeStart = 81.0F
            Me.linearGaugeBar24.Width = 40.0F
            Me.linearGaugeBar24.Width2 = 55.0F
            ' 
            ' linearGaugeLine17
            ' 
            Me.linearGaugeLine17.AutoSize = False
            Me.linearGaugeLine17.Bounds = New System.Drawing.Rectangle(0, 0, 15, 285)
            Me.linearGaugeLine17.Name = "linearGaugeLine17"
            Me.linearGaugeLine17.Offset = 22.0F
            Me.linearGaugeLine17.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine17.RangeEnd = 120.0F
            Me.linearGaugeLine17.Width = 1.5F
            ' 
            ' linearGaugeTicks31
            ' 
            Me.linearGaugeTicks31.AutoSize = False
            Me.linearGaugeTicks31.Bounds = New System.Drawing.Rectangle(0, 0, 15, 261)
            Me.linearGaugeTicks31.Name = "linearGaugeTicks31"
            Me.linearGaugeTicks31.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks31.TicksCount = 12
            Me.linearGaugeTicks31.TicksLenghtPercentage = 5.0F
            Me.linearGaugeTicks31.TicksLocationPercentage = 21.0F
            Me.linearGaugeTicks31.TicksOffset = 65
            Me.linearGaugeTicks31.TickThickness = 0.5F
            ' 
            ' linearGaugeLabels12
            ' 
            Me.linearGaugeLabels12.AutoSize = False
            Me.linearGaugeLabels12.Bounds = New System.Drawing.Rectangle(0, 0, 219, 33)
            Me.linearGaugeLabels12.LabelFontSize = 4.0F
            Me.linearGaugeLabels12.LabelLocationPercentage = 10.0F
            Me.linearGaugeLabels12.LabelsCount = 3
            Me.linearGaugeLabels12.Name = "linearGaugeLabels12"
            Me.linearGaugeLabels12.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeNeedleIndicator4
            ' 
            Me.linearGaugeNeedleIndicator4.AutoSize = False
            Me.linearGaugeNeedleIndicator4.BindValue = True
            Me.linearGaugeNeedleIndicator4.Bounds = New System.Drawing.Rectangle(0, 0, 11, 223)
            Me.linearGaugeNeedleIndicator4.Direction = Telerik.WinControls.UI.Gauges.Direction.Down
            Me.linearGaugeNeedleIndicator4.HorizontalLineWidth = 0
            Me.linearGaugeNeedleIndicator4.InnerPointRadiusPercentage = 10.0F
            Me.linearGaugeNeedleIndicator4.LocationPercentage = 17.0F
            Me.linearGaugeNeedleIndicator4.Name = "linearGaugeNeedleIndicator4"
            Me.linearGaugeNeedleIndicator4.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator4.Value = 90.0F
            ' 
            ' radLinearGauge12
            ' 
            Me.radLinearGauge12.BackColor = System.Drawing.Color.White
            Me.radLinearGauge12.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar20, Me.linearGaugeBar21, Me.linearGaugeTicks30})
            Me.radLinearGauge12.Location = New System.Drawing.Point(382, 18)
            Me.radLinearGauge12.Name = "radLinearGauge12"
            Me.radLinearGauge12.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radLinearGauge12.RangeEnd = 120.0F
            Me.radLinearGauge12.Size = New System.Drawing.Size(59, 280)
            Me.radLinearGauge12.TabIndex = 0
            Me.radLinearGauge12.Text = "radLinearGauge1"
            Me.radLinearGauge12.Value = 70.0F
            Me.radLinearGauge12.Vertical = True
            ' 
            ' linearGaugeBar20
            ' 
            Me.linearGaugeBar20.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar20.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar20.BindEndRange = True
            Me.linearGaugeBar20.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeBar20.Name = "linearGaugeBar20"
            Me.linearGaugeBar20.Offset = 30.0F
            Me.linearGaugeBar20.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar20.RangeEnd = 70.0F
            Me.linearGaugeBar20.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            ' 
            ' linearGaugeBar21
            ' 
            Me.linearGaugeBar21.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar21.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar21.BindStartRange = True
            Me.linearGaugeBar21.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeBar21.Name = "linearGaugeBar21"
            Me.linearGaugeBar21.Offset = 30.0F
            Me.linearGaugeBar21.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar21.RangeEnd = 120.0F
            Me.linearGaugeBar21.RangeStart = 70.0F
            Me.linearGaugeBar21.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            ' 
            ' linearGaugeTicks30
            ' 
            Me.linearGaugeTicks30.AutoSize = True
            Me.linearGaugeTicks30.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeTicks30.Name = "linearGaugeTicks30"
            Me.linearGaugeTicks30.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeTicks30.TickColor = System.Drawing.Color.White
            Me.linearGaugeTicks30.TicksCount = 11
            Me.linearGaugeTicks30.TicksLenghtPercentage = 44.0F
            Me.linearGaugeTicks30.TicksLocationPercentage = 60.0F
            Me.linearGaugeTicks30.TicksOffset = 30
            ' 
            ' radLinearGauge11
            ' 
            Me.radLinearGauge11.BackColor = System.Drawing.Color.White
            Me.radLinearGauge11.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar18, Me.linearGaugeBar19, Me.linearGaugeTicks28, Me.linearGaugeLine16, Me.linearGaugeTicks29, Me.linearGaugeLabels11})
            Me.radLinearGauge11.Location = New System.Drawing.Point(272, 18)
            Me.radLinearGauge11.Name = "radLinearGauge11"
            Me.radLinearGauge11.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radLinearGauge11.RangeEnd = 120.0F
            Me.radLinearGauge11.Size = New System.Drawing.Size(59, 280)
            Me.radLinearGauge11.TabIndex = 0
            Me.radLinearGauge11.Text = "radLinearGauge1"
            Me.radLinearGauge11.Value = 70.0F
            Me.radLinearGauge11.Vertical = True
            ' 
            ' linearGaugeBar18
            ' 
            Me.linearGaugeBar18.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar18.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar18.BindEndRange = True
            Me.linearGaugeBar18.Name = "linearGaugeBar18"
            Me.linearGaugeBar18.Offset = 30.0F
            Me.linearGaugeBar18.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar18.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar19
            ' 
            Me.linearGaugeBar19.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar19.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeBar19.BindStartRange = True
            Me.linearGaugeBar19.Name = "linearGaugeBar19"
            Me.linearGaugeBar19.Offset = 30.0F
            Me.linearGaugeBar19.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar19.RangeEnd = 120.0F
            Me.linearGaugeBar19.RangeStart = 70.0F
            ' 
            ' linearGaugeTicks28
            ' 
            Me.linearGaugeTicks28.AutoSize = True
            Me.linearGaugeTicks28.Name = "linearGaugeTicks28"
            Me.linearGaugeTicks28.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks28.TickColor = System.Drawing.Color.White
            Me.linearGaugeTicks28.TicksCount = 11
            Me.linearGaugeTicks28.TicksLenghtPercentage = 44.0F
            Me.linearGaugeTicks28.TicksLocationPercentage = 60.0F
            Me.linearGaugeTicks28.TicksOffset = 30
            ' 
            ' linearGaugeLine16
            ' 
            Me.linearGaugeLine16.Name = "linearGaugeLine16"
            Me.linearGaugeLine16.Offset = 30.0F
            Me.linearGaugeLine16.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine16.RangeEnd = 120.0F
            Me.linearGaugeLine16.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks29
            ' 
            Me.linearGaugeTicks29.Name = "linearGaugeTicks29"
            Me.linearGaugeTicks29.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks29.TickEndIndexVisibleRange = 1.0F
            Me.linearGaugeTicks29.TicksCount = 3
            Me.linearGaugeTicks29.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks29.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks29.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels11
            ' 
            Me.linearGaugeLabels11.LabelFontSize = 3.0F
            Me.linearGaugeLabels11.LabelLocationPercentage = 10.0F
            Me.linearGaugeLabels11.LabelsCount = 3
            Me.linearGaugeLabels11.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels11.Name = "linearGaugeLabels11"
            Me.linearGaugeLabels11.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge10
            ' 
            Me.radLinearGauge10.BackColor = System.Drawing.Color.White
            Me.radLinearGauge10.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar16, Me.linearGaugeBar17, Me.linearGaugeLine14, Me.linearGaugeLine15, Me.linearGaugeTicks24, Me.linearGaugeTicks25, _
                Me.linearGaugeTicks26, Me.linearGaugeTicks27, Me.linearGaugeLabels9, Me.linearGaugeLabels10})
            Me.radLinearGauge10.Location = New System.Drawing.Point(166, 18)
            Me.radLinearGauge10.Name = "radLinearGauge10"
            Me.radLinearGauge10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.radLinearGauge10.RangeEnd = 120.0F
            Me.radLinearGauge10.Size = New System.Drawing.Size(60, 280)
            Me.radLinearGauge10.TabIndex = 0
            Me.radLinearGauge10.Text = "radLinearGauge1"
            Me.radLinearGauge10.Value = 70.0F
            Me.radLinearGauge10.Vertical = True
            ' 
            ' linearGaugeBar16
            ' 
            Me.linearGaugeBar16.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar16.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar16.BindEndRange = True
            Me.linearGaugeBar16.Name = "linearGaugeBar16"
            Me.linearGaugeBar16.Offset = 35.0F
            Me.linearGaugeBar16.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar16.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar17
            ' 
            Me.linearGaugeBar17.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar17.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar17.BindStartRange = True
            Me.linearGaugeBar17.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar17.Name = "linearGaugeBar17"
            Me.linearGaugeBar17.Offset = 35.0F
            Me.linearGaugeBar17.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar17.RangeEnd = 120.0F
            Me.linearGaugeBar17.RangeStart = 71.0F
            ' 
            ' linearGaugeLine14
            ' 
            Me.linearGaugeLine14.AutoSize = False
            Me.linearGaugeLine14.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeLine14.Name = "linearGaugeLine14"
            Me.linearGaugeLine14.Offset = 35.0F
            Me.linearGaugeLine14.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine14.RangeEnd = 80.0F
            Me.linearGaugeLine14.Width = 2.0F
            ' 
            ' linearGaugeLine15
            ' 
            Me.linearGaugeLine15.AutoSize = False
            Me.linearGaugeLine15.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLine15.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeLine15.Name = "linearGaugeLine15"
            Me.linearGaugeLine15.Offset = 35.0F
            Me.linearGaugeLine15.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine15.RangeEnd = 120.0F
            Me.linearGaugeLine15.RangeStart = 80.0F
            Me.linearGaugeLine15.Width = 2.0F
            ' 
            ' linearGaugeTicks24
            ' 
            Me.linearGaugeTicks24.Name = "linearGaugeTicks24"
            Me.linearGaugeTicks24.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks24.TicksCount = 3
            Me.linearGaugeTicks24.TicksLenghtPercentage = 9.0F
            Me.linearGaugeTicks24.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks24.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks24.TickThickness = 0.7F
            ' 
            ' linearGaugeTicks25
            ' 
            Me.linearGaugeTicks25.Name = "linearGaugeTicks25"
            Me.linearGaugeTicks25.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks25.TicksCount = 12
            Me.linearGaugeTicks25.TicksLenghtPercentage = 5.0F
            Me.linearGaugeTicks25.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks25.TickStartIndexVisibleRange = 5.0F
            Me.linearGaugeTicks25.TickThickness = 0.6F
            ' 
            ' linearGaugeTicks26
            ' 
            Me.linearGaugeTicks26.Name = "linearGaugeTicks26"
            Me.linearGaugeTicks26.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks26.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeTicks26.TickEndIndexVisibleRange = 4.0F
            Me.linearGaugeTicks26.TicksCount = 12
            Me.linearGaugeTicks26.TicksLenghtPercentage = 5.0F
            Me.linearGaugeTicks26.TicksLocationPercentage = 30.0F
            ' 
            ' linearGaugeTicks27
            ' 
            Me.linearGaugeTicks27.Name = "linearGaugeTicks27"
            Me.linearGaugeTicks27.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks27.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeTicks27.TickEndIndexVisibleRange = 1.0F
            Me.linearGaugeTicks27.TicksCount = 3
            Me.linearGaugeTicks27.TicksLocationPercentage = 30.0F
            ' 
            ' linearGaugeLabels9
            ' 
            Me.linearGaugeLabels9.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLabels9.LabelFontSize = 3.0F
            Me.linearGaugeLabels9.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels9.LabelsCount = 3
            Me.linearGaugeLabels9.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels9.Name = "linearGaugeLabels9"
            Me.linearGaugeLabels9.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeLabels10
            ' 
            Me.linearGaugeLabels10.LabelEndVisibleRange = 40.0F
            Me.linearGaugeLabels10.LabelFontSize = 3.0F
            Me.linearGaugeLabels10.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels10.LabelsCount = 3
            Me.linearGaugeLabels10.Name = "linearGaugeLabels10"
            Me.linearGaugeLabels10.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge9
            ' 
            Me.radLinearGauge9.BackColor = System.Drawing.Color.White
            Me.radLinearGauge9.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar15, Me.linearGaugeLine11, Me.linearGaugeLine12, Me.linearGaugeTicks20, Me.linearGaugeLabels8, Me.linearGaugeTicks21, _
                Me.linearGaugeTicks22, Me.linearGaugeLine13, Me.linearGaugeTicks23, Me.linearGaugeNeedleIndicator3})
            Me.radLinearGauge9.Location = New System.Drawing.Point(24, 18)
            Me.radLinearGauge9.Name = "radLinearGauge9"
            Me.radLinearGauge9.Padding = New System.Windows.Forms.Padding(0, 5, 40, 5)
            Me.radLinearGauge9.RangeEnd = 120.0F
            Me.radLinearGauge9.Size = New System.Drawing.Size(103, 280)
            Me.radLinearGauge9.TabIndex = 0
            Me.radLinearGauge9.Text = "radLinearGauge1"
            Me.radLinearGauge9.Value = 70.0F
            Me.radLinearGauge9.Vertical = True
            ' 
            ' linearGaugeBar15
            ' 
            Me.linearGaugeBar15.AutoSize = False
            Me.linearGaugeBar15.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar15.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(51)), CInt(CByte(51)), CInt(CByte(51)))
            Me.linearGaugeBar15.BindEndRange = True
            Me.linearGaugeBar15.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeBar15.Name = "linearGaugeBar15"
            Me.linearGaugeBar15.Offset = 35.0F
            Me.linearGaugeBar15.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar15.RangeEnd = 70.0F
            Me.linearGaugeBar15.Width = 24.0F
            Me.linearGaugeBar15.Width2 = 24.0F
            ' 
            ' linearGaugeLine11
            ' 
            Me.linearGaugeLine11.AutoSize = False
            Me.linearGaugeLine11.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeLine11.Name = "linearGaugeLine11"
            Me.linearGaugeLine11.Offset = 35.0F
            Me.linearGaugeLine11.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine11.RangeEnd = 80.0F
            Me.linearGaugeLine11.Width = 2.0F
            ' 
            ' linearGaugeLine12
            ' 
            Me.linearGaugeLine12.AutoSize = False
            Me.linearGaugeLine12.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLine12.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLine12.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeLine12.Name = "linearGaugeLine12"
            Me.linearGaugeLine12.Offset = 35.0F
            Me.linearGaugeLine12.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine12.RangeEnd = 120.0F
            Me.linearGaugeLine12.RangeStart = 80.0F
            Me.linearGaugeLine12.Width = 2.0F
            ' 
            ' linearGaugeTicks20
            ' 
            Me.linearGaugeTicks20.AutoSize = False
            Me.linearGaugeTicks20.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks20.Name = "linearGaugeTicks20"
            Me.linearGaugeTicks20.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks20.TicksCount = 3
            Me.linearGaugeTicks20.TicksLenghtPercentage = 4.0F
            Me.linearGaugeTicks20.TicksLocationPercentage = 33.0F
            ' 
            ' linearGaugeLabels8
            ' 
            Me.linearGaugeLabels8.LabelFontSize = 3.0F
            Me.linearGaugeLabels8.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels8.LabelsCount = 3
            Me.linearGaugeLabels8.Name = "linearGaugeLabels8"
            Me.linearGaugeLabels8.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeTicks21
            ' 
            Me.linearGaugeTicks21.AutoSize = False
            Me.linearGaugeTicks21.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks21.Name = "linearGaugeTicks21"
            Me.linearGaugeTicks21.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks21.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeTicks21.TickEndIndexVisibleRange = 4.0F
            Me.linearGaugeTicks21.TicksCount = 12
            Me.linearGaugeTicks21.TicksLenghtPercentage = 2.0F
            Me.linearGaugeTicks21.TicksLocationPercentage = 33.0F
            ' 
            ' linearGaugeTicks22
            ' 
            Me.linearGaugeTicks22.AutoSize = False
            Me.linearGaugeTicks22.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks22.Name = "linearGaugeTicks22"
            Me.linearGaugeTicks22.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks22.TicksCount = 12
            Me.linearGaugeTicks22.TicksLenghtPercentage = 2.0F
            Me.linearGaugeTicks22.TicksLocationPercentage = 33.0F
            Me.linearGaugeTicks22.TickStartIndexVisibleRange = 5.0F
            ' 
            ' linearGaugeLine13
            ' 
            Me.linearGaugeLine13.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeLine13.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeLine13.Name = "linearGaugeLine13"
            Me.linearGaugeLine13.Offset = 69.0F
            Me.linearGaugeLine13.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine13.RangeEnd = 120.0F
            ' 
            ' linearGaugeTicks23
            ' 
            Me.linearGaugeTicks23.AutoSize = False
            Me.linearGaugeTicks23.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks23.Name = "linearGaugeTicks23"
            Me.linearGaugeTicks23.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks23.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeTicks23.TicksCount = 12
            Me.linearGaugeTicks23.TicksLenghtPercentage = 3.0F
            Me.linearGaugeTicks23.TicksLocationPercentage = 72.0F
            ' 
            ' linearGaugeNeedleIndicator3
            ' 
            Me.linearGaugeNeedleIndicator3.AutoSize = False
            Me.linearGaugeNeedleIndicator3.BackColor = System.Drawing.Color.Red
            Me.linearGaugeNeedleIndicator3.Bounds = New System.Drawing.Rectangle(0, 0, 63, 270)
            Me.linearGaugeNeedleIndicator3.CircleTicks = True
            Me.linearGaugeNeedleIndicator3.Direction = Telerik.WinControls.UI.Gauges.Direction.Left
            Me.linearGaugeNeedleIndicator3.DrawValue = True
            Me.linearGaugeNeedleIndicator3.InnerPointRadiusPercentage = 10.0F
            Me.linearGaugeNeedleIndicator3.IsFilled = False
            Me.linearGaugeNeedleIndicator3.LenghtPercentage = 6.0F
            Me.linearGaugeNeedleIndicator3.LineLenght = 40.0F
            Me.linearGaugeNeedleIndicator3.LocationPercentage = 70.0F
            Me.linearGaugeNeedleIndicator3.Name = "linearGaugeNeedleIndicator3"
            Me.linearGaugeNeedleIndicator3.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator3.PointRadiusPercentage = 10.0F
            Me.linearGaugeNeedleIndicator3.TextOffsetFromIndicator = New System.Drawing.SizeF(2.0F, -5.0F)
            Me.linearGaugeNeedleIndicator3.Value = 66.0F
            ' 
            ' radScrollablePanel2
            ' 
            Me.radScrollablePanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScrollablePanel2.Location = New System.Drawing.Point(0, 0)
            Me.radScrollablePanel2.Name = "radScrollablePanel2"
            ' 
            ' radScrollablePanel2.PanelContainer
            ' 
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radBulletGraph2)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radBulletGraph1)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radLinearGauge21)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radLinearGauge20)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radLinearGauge19)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radLinearGauge8)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radLinearGauge7)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radLinearGauge6)
            Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.radLinearGauge5)
            Me.radScrollablePanel2.PanelContainer.Size = New System.Drawing.Size(1208, 802)
            Me.radScrollablePanel2.Size = New System.Drawing.Size(1210, 804)
            Me.radScrollablePanel2.TabIndex = 3
            Me.radScrollablePanel2.Text = "radScrollablePanel2"
            ' 
            ' radBulletGraph2
            ' 
            Me.radBulletGraph2.BackColor = System.Drawing.Color.White
            Me.radBulletGraph2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.bulletGraphQualitativeBar4, Me.bulletGraphQualitativeBar5, Me.bulletGraphQualitativeBar6, Me.bulletGraphFeaturedMeasureBar2, Me.linearGaugeNeedleIndicator8, Me.linearGaugeLabels22})
            Me.radBulletGraph2.Location = New System.Drawing.Point(577, 249)
            Me.radBulletGraph2.Name = "radBulletGraph2"
            Me.radBulletGraph2.Padding = New System.Windows.Forms.Padding(5, 0, 10, 20)
            Me.radBulletGraph2.Size = New System.Drawing.Size(280, 50)
            Me.radBulletGraph2.TabIndex = 3
            Me.radBulletGraph2.Text = "radBulletGraph1"
            Me.radBulletGraph2.Value = 0.0F
            ' 
            ' bulletGraphQualitativeBar4
            ' 
            Me.bulletGraphQualitativeBar4.Name = "bulletGraphQualitativeBar4"
            Me.bulletGraphQualitativeBar4.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar4.RangeEnd = 49.0F
            ' 
            ' bulletGraphQualitativeBar5
            ' 
            Me.bulletGraphQualitativeBar5.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar5.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar5.Name = "bulletGraphQualitativeBar5"
            Me.bulletGraphQualitativeBar5.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar5.RangeEnd = 74.0F
            Me.bulletGraphQualitativeBar5.RangeStart = 50.0F
            ' 
            ' bulletGraphQualitativeBar6
            ' 
            Me.bulletGraphQualitativeBar6.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar6.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar6.Name = "bulletGraphQualitativeBar6"
            Me.bulletGraphQualitativeBar6.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar6.RangeStart = 75.0F
            ' 
            ' bulletGraphFeaturedMeasureBar2
            ' 
            Me.bulletGraphFeaturedMeasureBar2.AutoSize = False
            Me.bulletGraphFeaturedMeasureBar2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.bulletGraphFeaturedMeasureBar2.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.bulletGraphFeaturedMeasureBar2.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.bulletGraphFeaturedMeasureBar2.Name = "bulletGraphFeaturedMeasureBar2"
            Me.bulletGraphFeaturedMeasureBar2.Offset = 11.0F
            Me.bulletGraphFeaturedMeasureBar2.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphFeaturedMeasureBar2.RangeEnd = 85.0F
            Me.bulletGraphFeaturedMeasureBar2.Width = 10.0F
            Me.bulletGraphFeaturedMeasureBar2.Width2 = 10.0F
            ' 
            ' linearGaugeNeedleIndicator8
            ' 
            Me.linearGaugeNeedleIndicator8.AutoSize = False
            Me.linearGaugeNeedleIndicator8.BackColor = System.Drawing.Color.Black
            Me.linearGaugeNeedleIndicator8.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.linearGaugeNeedleIndicator8.LenghtPercentage = 0.0F
            Me.linearGaugeNeedleIndicator8.LineLenght = 30.0F
            Me.linearGaugeNeedleIndicator8.LocationPercentage = 30.0F
            Me.linearGaugeNeedleIndicator8.Name = "linearGaugeNeedleIndicator8"
            Me.linearGaugeNeedleIndicator8.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator8.Thickness = 3.0F
            Me.linearGaugeNeedleIndicator8.Value = 80.0F
            ' 
            ' linearGaugeLabels22
            ' 
            Me.linearGaugeLabels22.AutoSize = False
            Me.linearGaugeLabels22.Bounds = New System.Drawing.Rectangle(0, 0, 280, 40)
            Me.linearGaugeLabels22.LabelFontSize = 4.0F
            Me.linearGaugeLabels22.Name = "linearGaugeLabels22"
            Me.linearGaugeLabels22.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radBulletGraph1
            ' 
            Me.radBulletGraph1.BackColor = System.Drawing.Color.White
            Me.radBulletGraph1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.bulletGraphQualitativeBar1, Me.bulletGraphQualitativeBar2, Me.bulletGraphQualitativeBar3, Me.bulletGraphFeaturedMeasureBar1, Me.linearGaugeNeedleIndicator7, Me.linearGaugeLabels21})
            Me.radBulletGraph1.Location = New System.Drawing.Point(486, 18)
            Me.radBulletGraph1.Name = "radBulletGraph1"
            Me.radBulletGraph1.Padding = New System.Windows.Forms.Padding(0, 5, 30, 5)
            Me.radBulletGraph1.Size = New System.Drawing.Size(65, 280)
            Me.radBulletGraph1.TabIndex = 3
            Me.radBulletGraph1.Text = "radBulletGraph1"
            Me.radBulletGraph1.Value = 0.0F
            Me.radBulletGraph1.Vertical = True
            ' 
            ' bulletGraphQualitativeBar1
            ' 
            Me.bulletGraphQualitativeBar1.Name = "bulletGraphQualitativeBar1"
            Me.bulletGraphQualitativeBar1.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar1.RangeEnd = 49.0F
            ' 
            ' bulletGraphQualitativeBar2
            ' 
            Me.bulletGraphQualitativeBar2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar2.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(204)), CInt(CByte(204)), CInt(CByte(204)))
            Me.bulletGraphQualitativeBar2.Name = "bulletGraphQualitativeBar2"
            Me.bulletGraphQualitativeBar2.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar2.RangeEnd = 74.0F
            Me.bulletGraphQualitativeBar2.RangeStart = 50.0F
            ' 
            ' bulletGraphQualitativeBar3
            ' 
            Me.bulletGraphQualitativeBar3.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar3.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(234)), CInt(CByte(234)), CInt(CByte(234)))
            Me.bulletGraphQualitativeBar3.Name = "bulletGraphQualitativeBar3"
            Me.bulletGraphQualitativeBar3.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar3.RangeStart = 75.0F
            ' 
            ' bulletGraphFeaturedMeasureBar1
            ' 
            Me.bulletGraphFeaturedMeasureBar1.AutoSize = False
            Me.bulletGraphFeaturedMeasureBar1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.bulletGraphFeaturedMeasureBar1.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.bulletGraphFeaturedMeasureBar1.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.bulletGraphFeaturedMeasureBar1.Name = "bulletGraphFeaturedMeasureBar1"
            Me.bulletGraphFeaturedMeasureBar1.Offset = 12.0F
            Me.bulletGraphFeaturedMeasureBar1.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphFeaturedMeasureBar1.RangeEnd = 85.0F
            Me.bulletGraphFeaturedMeasureBar1.Width = 10.0F
            Me.bulletGraphFeaturedMeasureBar1.Width2 = 10.0F
            ' 
            ' linearGaugeNeedleIndicator7
            ' 
            Me.linearGaugeNeedleIndicator7.AutoSize = False
            Me.linearGaugeNeedleIndicator7.BackColor = System.Drawing.Color.Black
            Me.linearGaugeNeedleIndicator7.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.linearGaugeNeedleIndicator7.Direction = Telerik.WinControls.UI.Gauges.Direction.Left
            Me.linearGaugeNeedleIndicator7.LenghtPercentage = 0.0F
            Me.linearGaugeNeedleIndicator7.LineLenght = 36.0F
            Me.linearGaugeNeedleIndicator7.LocationPercentage = 35.0F
            Me.linearGaugeNeedleIndicator7.Name = "linearGaugeNeedleIndicator7"
            Me.linearGaugeNeedleIndicator7.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator7.Thickness = 3.0F
            Me.linearGaugeNeedleIndicator7.Value = 80.0F
            ' 
            ' linearGaugeLabels21
            ' 
            Me.linearGaugeLabels21.AutoSize = False
            Me.linearGaugeLabels21.Bounds = New System.Drawing.Rectangle(0, 0, 35, 278)
            Me.linearGaugeLabels21.LabelFontSize = 4.0F
            Me.linearGaugeLabels21.LabelLocationPercentage = 52.0F
            Me.linearGaugeLabels21.Name = "linearGaugeLabels21"
            Me.linearGaugeLabels21.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge21
            ' 
            Me.radLinearGauge21.BackColor = System.Drawing.Color.White
            Me.radLinearGauge21.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar39, Me.linearGaugeBar40, Me.linearGaugeLine25, Me.linearGaugeTicks39, Me.linearGaugeLabels20})
            Me.radLinearGauge21.Location = New System.Drawing.Point(577, 154)
            Me.radLinearGauge21.Name = "radLinearGauge21"
            Me.radLinearGauge21.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.radLinearGauge21.RangeEnd = 120.0F
            Me.radLinearGauge21.Size = New System.Drawing.Size(280, 50)
            Me.radLinearGauge21.TabIndex = 0
            Me.radLinearGauge21.Text = "radLinearGauge1"
            Me.radLinearGauge21.Value = 70.0F
            ' 
            ' linearGaugeBar39
            ' 
            Me.linearGaugeBar39.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(190)), CInt(CByte(76)))
            Me.linearGaugeBar39.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(190)), CInt(CByte(76)))
            Me.linearGaugeBar39.BindEndRange = True
            Me.linearGaugeBar39.Name = "linearGaugeBar39"
            Me.linearGaugeBar39.Offset = 35.0F
            Me.linearGaugeBar39.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar39.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar40
            ' 
            Me.linearGaugeBar40.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar40.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar40.BindStartRange = True
            Me.linearGaugeBar40.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar40.Name = "linearGaugeBar40"
            Me.linearGaugeBar40.Offset = 35.0F
            Me.linearGaugeBar40.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar40.RangeEnd = 120.0F
            Me.linearGaugeBar40.RangeStart = 71.0F
            ' 
            ' linearGaugeLine25
            ' 
            Me.linearGaugeLine25.Name = "linearGaugeLine25"
            Me.linearGaugeLine25.Offset = 30.0F
            Me.linearGaugeLine25.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine25.RangeEnd = 120.0F
            Me.linearGaugeLine25.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks39
            ' 
            Me.linearGaugeTicks39.Name = "linearGaugeTicks39"
            Me.linearGaugeTicks39.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks39.TicksCount = 3
            Me.linearGaugeTicks39.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks39.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks39.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks39.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels20
            ' 
            Me.linearGaugeLabels20.LabelFontSize = 3.0F
            Me.linearGaugeLabels20.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels20.LabelsCount = 3
            Me.linearGaugeLabels20.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels20.Name = "linearGaugeLabels20"
            Me.linearGaugeLabels20.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge20
            ' 
            Me.radLinearGauge20.BackColor = System.Drawing.Color.White
            Me.radLinearGauge20.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar37, Me.linearGaugeBar38, Me.linearGaugeLine24, Me.linearGaugeTicks38, Me.linearGaugeLabels19})
            Me.radLinearGauge20.Location = New System.Drawing.Point(577, 78)
            Me.radLinearGauge20.Name = "radLinearGauge20"
            Me.radLinearGauge20.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.radLinearGauge20.RangeEnd = 120.0F
            Me.radLinearGauge20.Size = New System.Drawing.Size(280, 50)
            Me.radLinearGauge20.TabIndex = 0
            Me.radLinearGauge20.Text = "radLinearGauge1"
            Me.radLinearGauge20.Value = 70.0F
            ' 
            ' linearGaugeBar37
            ' 
            Me.linearGaugeBar37.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(90)), CInt(CByte(90)))
            Me.linearGaugeBar37.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(90)), CInt(CByte(90)))
            Me.linearGaugeBar37.BindEndRange = True
            Me.linearGaugeBar37.Name = "linearGaugeBar37"
            Me.linearGaugeBar37.Offset = 35.0F
            Me.linearGaugeBar37.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar37.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar38
            ' 
            Me.linearGaugeBar38.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar38.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar38.BindStartRange = True
            Me.linearGaugeBar38.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar38.Name = "linearGaugeBar38"
            Me.linearGaugeBar38.Offset = 35.0F
            Me.linearGaugeBar38.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar38.RangeEnd = 120.0F
            Me.linearGaugeBar38.RangeStart = 71.0F
            ' 
            ' linearGaugeLine24
            ' 
            Me.linearGaugeLine24.Name = "linearGaugeLine24"
            Me.linearGaugeLine24.Offset = 30.0F
            Me.linearGaugeLine24.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine24.RangeEnd = 120.0F
            Me.linearGaugeLine24.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks38
            ' 
            Me.linearGaugeTicks38.Name = "linearGaugeTicks38"
            Me.linearGaugeTicks38.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks38.TicksCount = 3
            Me.linearGaugeTicks38.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks38.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks38.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks38.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels19
            ' 
            Me.linearGaugeLabels19.LabelFontSize = 3.0F
            Me.linearGaugeLabels19.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels19.LabelsCount = 3
            Me.linearGaugeLabels19.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels19.Name = "linearGaugeLabels19"
            Me.linearGaugeLabels19.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge19
            ' 
            Me.radLinearGauge19.BackColor = System.Drawing.Color.White
            Me.radLinearGauge19.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar36, Me.linearGaugeLine23, Me.linearGaugeTicks37, Me.linearGaugeLabels18, Me.linearGaugeNeedleIndicator6})
            Me.radLinearGauge19.Location = New System.Drawing.Point(577, 18)
            Me.radLinearGauge19.Name = "radLinearGauge19"
            Me.radLinearGauge19.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.radLinearGauge19.RangeEnd = 120.0F
            Me.radLinearGauge19.Size = New System.Drawing.Size(280, 44)
            Me.radLinearGauge19.TabIndex = 2
            Me.radLinearGauge19.Text = "radLinearGauge2"
            Me.radLinearGauge19.Value = 90.0F
            ' 
            ' linearGaugeBar36
            ' 
            Me.linearGaugeBar36.AutoSize = True
            Me.linearGaugeBar36.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow
            Me.linearGaugeBar36.Name = "linearGaugeBar36"
            Me.linearGaugeBar36.Offset = 25.0F
            Me.linearGaugeBar36.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar36.RangeEnd = 120.0F
            Me.linearGaugeBar36.Width = 10.0F
            Me.linearGaugeBar36.Width2 = 70.0F
            ' 
            ' linearGaugeLine23
            ' 
            Me.linearGaugeLine23.AutoSize = False
            Me.linearGaugeLine23.Bounds = New System.Drawing.Rectangle(0, 0, 15, 285)
            Me.linearGaugeLine23.Name = "linearGaugeLine23"
            Me.linearGaugeLine23.Offset = 22.0F
            Me.linearGaugeLine23.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine23.RangeEnd = 120.0F
            Me.linearGaugeLine23.Width = 1.5F
            ' 
            ' linearGaugeTicks37
            ' 
            Me.linearGaugeTicks37.AutoSize = False
            Me.linearGaugeTicks37.Bounds = New System.Drawing.Rectangle(0, 0, 15, 261)
            Me.linearGaugeTicks37.Name = "linearGaugeTicks37"
            Me.linearGaugeTicks37.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks37.TicksCount = 12
            Me.linearGaugeTicks37.TicksLenghtPercentage = 5.0F
            Me.linearGaugeTicks37.TicksLocationPercentage = 21.0F
            Me.linearGaugeTicks37.TicksOffset = 65
            Me.linearGaugeTicks37.TickThickness = 0.5F
            ' 
            ' linearGaugeLabels18
            ' 
            Me.linearGaugeLabels18.AutoSize = False
            Me.linearGaugeLabels18.Bounds = New System.Drawing.Rectangle(0, 0, 219, 33)
            Me.linearGaugeLabels18.LabelFontSize = 4.0F
            Me.linearGaugeLabels18.LabelLocationPercentage = 10.0F
            Me.linearGaugeLabels18.LabelsCount = 3
            Me.linearGaugeLabels18.Name = "linearGaugeLabels18"
            Me.linearGaugeLabels18.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeNeedleIndicator6
            ' 
            Me.linearGaugeNeedleIndicator6.AutoSize = False
            Me.linearGaugeNeedleIndicator6.BindValue = True
            Me.linearGaugeNeedleIndicator6.Bounds = New System.Drawing.Rectangle(0, 0, 11, 223)
            Me.linearGaugeNeedleIndicator6.Direction = Telerik.WinControls.UI.Gauges.Direction.Down
            Me.linearGaugeNeedleIndicator6.HorizontalLineWidth = 0
            Me.linearGaugeNeedleIndicator6.InnerPointRadiusPercentage = 10.0F
            Me.linearGaugeNeedleIndicator6.LocationPercentage = 17.0F
            Me.linearGaugeNeedleIndicator6.Name = "linearGaugeNeedleIndicator6"
            Me.linearGaugeNeedleIndicator6.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator6.Value = 90.0F
            ' 
            ' radLinearGauge8
            ' 
            Me.radLinearGauge8.BackColor = System.Drawing.Color.White
            Me.radLinearGauge8.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar13, Me.linearGaugeBar14, Me.linearGaugeTicks19})
            Me.radLinearGauge8.Location = New System.Drawing.Point(382, 18)
            Me.radLinearGauge8.Name = "radLinearGauge8"
            Me.radLinearGauge8.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radLinearGauge8.RangeEnd = 120.0F
            Me.radLinearGauge8.Size = New System.Drawing.Size(59, 280)
            Me.radLinearGauge8.TabIndex = 0
            Me.radLinearGauge8.Text = "radLinearGauge1"
            Me.radLinearGauge8.Value = 70.0F
            Me.radLinearGauge8.Vertical = True
            ' 
            ' linearGaugeBar13
            ' 
            Me.linearGaugeBar13.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar13.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar13.BindEndRange = True
            Me.linearGaugeBar13.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeBar13.Name = "linearGaugeBar13"
            Me.linearGaugeBar13.Offset = 30.0F
            Me.linearGaugeBar13.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar13.RangeEnd = 70.0F
            Me.linearGaugeBar13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            ' 
            ' linearGaugeBar14
            ' 
            Me.linearGaugeBar14.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar14.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar14.BindStartRange = True
            Me.linearGaugeBar14.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeBar14.Name = "linearGaugeBar14"
            Me.linearGaugeBar14.Offset = 30.0F
            Me.linearGaugeBar14.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar14.RangeEnd = 120.0F
            Me.linearGaugeBar14.RangeStart = 70.0F
            Me.linearGaugeBar14.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            ' 
            ' linearGaugeTicks19
            ' 
            Me.linearGaugeTicks19.AutoSize = True
            Me.linearGaugeTicks19.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeTicks19.Name = "linearGaugeTicks19"
            Me.linearGaugeTicks19.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks19.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeTicks19.TickColor = System.Drawing.Color.White
            Me.linearGaugeTicks19.TicksCount = 11
            Me.linearGaugeTicks19.TicksLenghtPercentage = 44.0F
            Me.linearGaugeTicks19.TicksLocationPercentage = 60.0F
            Me.linearGaugeTicks19.TicksOffset = 30
            ' 
            ' radLinearGauge7
            ' 
            Me.radLinearGauge7.BackColor = System.Drawing.Color.White
            Me.radLinearGauge7.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar11, Me.linearGaugeBar12, Me.linearGaugeTicks17, Me.linearGaugeLine10, Me.linearGaugeTicks18, Me.linearGaugeLabels7})
            Me.radLinearGauge7.Location = New System.Drawing.Point(272, 18)
            Me.radLinearGauge7.Name = "radLinearGauge7"
            Me.radLinearGauge7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radLinearGauge7.RangeEnd = 120.0F
            Me.radLinearGauge7.Size = New System.Drawing.Size(59, 280)
            Me.radLinearGauge7.TabIndex = 0
            Me.radLinearGauge7.Text = "radLinearGauge1"
            Me.radLinearGauge7.Value = 70.0F
            Me.radLinearGauge7.Vertical = True
            ' 
            ' linearGaugeBar11
            ' 
            Me.linearGaugeBar11.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar11.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar11.BindEndRange = True
            Me.linearGaugeBar11.Name = "linearGaugeBar11"
            Me.linearGaugeBar11.Offset = 30.0F
            Me.linearGaugeBar11.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar11.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar12
            ' 
            Me.linearGaugeBar12.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar12.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar12.BindStartRange = True
            Me.linearGaugeBar12.Name = "linearGaugeBar12"
            Me.linearGaugeBar12.Offset = 30.0F
            Me.linearGaugeBar12.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar12.RangeEnd = 120.0F
            Me.linearGaugeBar12.RangeStart = 70.0F
            ' 
            ' linearGaugeTicks17
            ' 
            Me.linearGaugeTicks17.AutoSize = True
            Me.linearGaugeTicks17.Name = "linearGaugeTicks17"
            Me.linearGaugeTicks17.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks17.TickColor = System.Drawing.Color.White
            Me.linearGaugeTicks17.TicksCount = 11
            Me.linearGaugeTicks17.TicksLenghtPercentage = 44.0F
            Me.linearGaugeTicks17.TicksLocationPercentage = 60.0F
            Me.linearGaugeTicks17.TicksOffset = 30
            ' 
            ' linearGaugeLine10
            ' 
            Me.linearGaugeLine10.Name = "linearGaugeLine10"
            Me.linearGaugeLine10.Offset = 30.0F
            Me.linearGaugeLine10.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine10.RangeEnd = 120.0F
            Me.linearGaugeLine10.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks18
            ' 
            Me.linearGaugeTicks18.Name = "linearGaugeTicks18"
            Me.linearGaugeTicks18.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks18.TickEndIndexVisibleRange = 1.0F
            Me.linearGaugeTicks18.TicksCount = 3
            Me.linearGaugeTicks18.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks18.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks18.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels7
            ' 
            Me.linearGaugeLabels7.LabelFontSize = 3.0F
            Me.linearGaugeLabels7.LabelLocationPercentage = 10.0F
            Me.linearGaugeLabels7.LabelsCount = 3
            Me.linearGaugeLabels7.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels7.Name = "linearGaugeLabels7"
            Me.linearGaugeLabels7.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge6
            ' 
            Me.radLinearGauge6.BackColor = System.Drawing.Color.White
            Me.radLinearGauge6.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar9, Me.linearGaugeBar10, Me.linearGaugeLine9, Me.linearGaugeTicks15, Me.linearGaugeLabels6, Me.linearGaugeTicks16})
            Me.radLinearGauge6.Location = New System.Drawing.Point(166, 18)
            Me.radLinearGauge6.Name = "radLinearGauge6"
            Me.radLinearGauge6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.radLinearGauge6.RangeEnd = 120.0F
            Me.radLinearGauge6.Size = New System.Drawing.Size(60, 280)
            Me.radLinearGauge6.TabIndex = 0
            Me.radLinearGauge6.Text = "radLinearGauge1"
            Me.radLinearGauge6.Value = 70.0F
            Me.radLinearGauge6.Vertical = True
            ' 
            ' linearGaugeBar9
            ' 
            Me.linearGaugeBar9.AutoSize = False
            Me.linearGaugeBar9.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar9.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar9.BindEndRange = True
            Me.linearGaugeBar9.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeBar9.Name = "linearGaugeBar9"
            Me.linearGaugeBar9.Offset = 35.0F
            Me.linearGaugeBar9.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar9.RangeEnd = 70.0F
            Me.linearGaugeBar9.Width = 15.0F
            Me.linearGaugeBar9.Width2 = 15.0F
            ' 
            ' linearGaugeBar10
            ' 
            Me.linearGaugeBar10.AutoSize = False
            Me.linearGaugeBar10.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar10.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar10.BindStartRange = True
            Me.linearGaugeBar10.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar10.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeBar10.Name = "linearGaugeBar10"
            Me.linearGaugeBar10.Offset = 35.0F
            Me.linearGaugeBar10.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar10.RangeEnd = 120.0F
            Me.linearGaugeBar10.RangeStart = 71.0F
            Me.linearGaugeBar10.Width = 15.0F
            Me.linearGaugeBar10.Width2 = 15.0F
            ' 
            ' linearGaugeLine9
            ' 
            Me.linearGaugeLine9.Name = "linearGaugeLine9"
            Me.linearGaugeLine9.Offset = 35.0F
            Me.linearGaugeLine9.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine9.RangeEnd = 120.0F
            ' 
            ' linearGaugeTicks15
            ' 
            Me.linearGaugeTicks15.AutoSize = True
            Me.linearGaugeTicks15.Name = "linearGaugeTicks15"
            Me.linearGaugeTicks15.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks15.TicksCount = 3
            Me.linearGaugeTicks15.TicksLenghtPercentage = 9.0F
            Me.linearGaugeTicks15.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks15.TickThickness = 0.5F
            ' 
            ' linearGaugeLabels6
            ' 
            Me.linearGaugeLabels6.LabelFontSize = 3.0F
            Me.linearGaugeLabels6.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels6.LabelsCount = 3
            Me.linearGaugeLabels6.Name = "linearGaugeLabels6"
            Me.linearGaugeLabels6.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeTicks16
            ' 
            Me.linearGaugeTicks16.AutoSize = False
            Me.linearGaugeTicks16.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeTicks16.Name = "linearGaugeTicks16"
            Me.linearGaugeTicks16.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks16.TicksCount = 12
            Me.linearGaugeTicks16.TicksLenghtPercentage = 3.0F
            Me.linearGaugeTicks16.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks16.TickThickness = 0.6F
            ' 
            ' radLinearGauge5
            ' 
            Me.radLinearGauge5.BackColor = System.Drawing.Color.White
            Me.radLinearGauge5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar8, Me.linearGaugeLine7, Me.linearGaugeTicks12, Me.linearGaugeLabels5, Me.linearGaugeTicks13, Me.linearGaugeLine8, _
                Me.linearGaugeTicks14, Me.linearGaugeNeedleIndicator2})
            Me.radLinearGauge5.Location = New System.Drawing.Point(24, 18)
            Me.radLinearGauge5.Name = "radLinearGauge5"
            Me.radLinearGauge5.Padding = New System.Windows.Forms.Padding(0, 5, 40, 5)
            Me.radLinearGauge5.RangeEnd = 120.0F
            Me.radLinearGauge5.Size = New System.Drawing.Size(99, 280)
            Me.radLinearGauge5.TabIndex = 0
            Me.radLinearGauge5.Text = "radLinearGauge1"
            Me.radLinearGauge5.Value = 70.0F
            Me.radLinearGauge5.Vertical = True
            ' 
            ' linearGaugeBar8
            ' 
            Me.linearGaugeBar8.AutoSize = False
            Me.linearGaugeBar8.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar8.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(193)), CInt(CByte(193)))
            Me.linearGaugeBar8.BindEndRange = True
            Me.linearGaugeBar8.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeBar8.Name = "linearGaugeBar8"
            Me.linearGaugeBar8.Offset = 35.0F
            Me.linearGaugeBar8.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar8.RangeEnd = 70.0F
            Me.linearGaugeBar8.Width = 15.0F
            Me.linearGaugeBar8.Width2 = 15.0F
            ' 
            ' linearGaugeLine7
            ' 
            Me.linearGaugeLine7.AutoSize = False
            Me.linearGaugeLine7.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeLine7.Name = "linearGaugeLine7"
            Me.linearGaugeLine7.Offset = 35.0F
            Me.linearGaugeLine7.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine7.RangeEnd = 120.0F
            Me.linearGaugeLine7.Width = 2.0F
            ' 
            ' linearGaugeTicks12
            ' 
            Me.linearGaugeTicks12.AutoSize = False
            Me.linearGaugeTicks12.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks12.Name = "linearGaugeTicks12"
            Me.linearGaugeTicks12.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks12.TicksCount = 3
            Me.linearGaugeTicks12.TicksLenghtPercentage = 4.0F
            Me.linearGaugeTicks12.TicksLocationPercentage = 33.0F
            ' 
            ' linearGaugeLabels5
            ' 
            Me.linearGaugeLabels5.LabelFontSize = 3.0F
            Me.linearGaugeLabels5.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels5.LabelsCount = 3
            Me.linearGaugeLabels5.Name = "linearGaugeLabels5"
            Me.linearGaugeLabels5.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeTicks13
            ' 
            Me.linearGaugeTicks13.AutoSize = False
            Me.linearGaugeTicks13.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks13.Name = "linearGaugeTicks13"
            Me.linearGaugeTicks13.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks13.TicksCount = 12
            Me.linearGaugeTicks13.TicksLenghtPercentage = 2.0F
            Me.linearGaugeTicks13.TicksLocationPercentage = 33.0F
            ' 
            ' linearGaugeLine8
            ' 
            Me.linearGaugeLine8.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeLine8.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeLine8.Name = "linearGaugeLine8"
            Me.linearGaugeLine8.Offset = 60.0F
            Me.linearGaugeLine8.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine8.RangeEnd = 120.0F
            ' 
            ' linearGaugeTicks14
            ' 
            Me.linearGaugeTicks14.AutoSize = False
            Me.linearGaugeTicks14.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks14.Name = "linearGaugeTicks14"
            Me.linearGaugeTicks14.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks14.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeTicks14.TicksCount = 12
            Me.linearGaugeTicks14.TicksLenghtPercentage = 3.0F
            Me.linearGaugeTicks14.TicksLocationPercentage = 64.0F
            ' 
            ' linearGaugeNeedleIndicator2
            ' 
            Me.linearGaugeNeedleIndicator2.AutoSize = False
            Me.linearGaugeNeedleIndicator2.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeNeedleIndicator2.CircleTicks = True
            Me.linearGaugeNeedleIndicator2.Direction = Telerik.WinControls.UI.Gauges.Direction.Left
            Me.linearGaugeNeedleIndicator2.DrawValue = True
            Me.linearGaugeNeedleIndicator2.IsFilled = False
            Me.linearGaugeNeedleIndicator2.LenghtPercentage = 3.0F
            Me.linearGaugeNeedleIndicator2.LineLenght = 41.0F
            Me.linearGaugeNeedleIndicator2.LocationPercentage = 70.0F
            Me.linearGaugeNeedleIndicator2.Name = "linearGaugeNeedleIndicator2"
            Me.linearGaugeNeedleIndicator2.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator2.PointRadiusPercentage = 1.0F
            Me.linearGaugeNeedleIndicator2.TextOffsetFromIndicator = New System.Drawing.SizeF(2.0F, -5.0F)
            Me.linearGaugeNeedleIndicator2.Value = 66.0F
            ' 
            ' radScrollablePanel3
            ' 
            Me.radScrollablePanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radScrollablePanel3.Location = New System.Drawing.Point(0, 0)
            Me.radScrollablePanel3.Name = "radScrollablePanel3"
            ' 
            ' radScrollablePanel3.PanelContainer
            ' 
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radBulletGraph6)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radBulletGraph5)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radLinearGauge18)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radLinearGauge17)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radLinearGauge16)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radLinearGauge4)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radLinearGauge3)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radLinearGauge2)
            Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.radLinearGauge1)
            Me.radScrollablePanel3.PanelContainer.Size = New System.Drawing.Size(1208, 802)
            Me.radScrollablePanel3.Size = New System.Drawing.Size(1210, 804)
            Me.radScrollablePanel3.TabIndex = 4
            Me.radScrollablePanel3.Text = "radScrollablePanel3"
            ' 
            ' radBulletGraph6
            ' 
            Me.radBulletGraph6.BackColor = System.Drawing.Color.White
            Me.radBulletGraph6.Items.AddRange(New Telerik.WinControls.RadItem() {Me.bulletGraphQualitativeBar16, Me.bulletGraphQualitativeBar17, Me.bulletGraphQualitativeBar18, Me.bulletGraphFeaturedMeasureBar6, Me.linearGaugeNeedleIndicator12, Me.linearGaugeLabels26})
            Me.radBulletGraph6.Location = New System.Drawing.Point(577, 249)
            Me.radBulletGraph6.Name = "radBulletGraph6"
            Me.radBulletGraph6.Padding = New System.Windows.Forms.Padding(5, 0, 10, 20)
            Me.radBulletGraph6.Size = New System.Drawing.Size(280, 50)
            Me.radBulletGraph6.TabIndex = 3
            Me.radBulletGraph6.Text = "radBulletGraph1"
            Me.radBulletGraph6.Value = 0.0F
            ' 
            ' bulletGraphQualitativeBar16
            ' 
            Me.bulletGraphQualitativeBar16.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(184)), CInt(CByte(197)), CInt(CByte(218)))
            Me.bulletGraphQualitativeBar16.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(184)), CInt(CByte(197)), CInt(CByte(218)))
            Me.bulletGraphQualitativeBar16.Name = "bulletGraphQualitativeBar16"
            Me.bulletGraphQualitativeBar16.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar16.RangeEnd = 49.0F
            ' 
            ' bulletGraphQualitativeBar17
            ' 
            Me.bulletGraphQualitativeBar17.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(210)), CInt(CByte(219)), CInt(CByte(232)))
            Me.bulletGraphQualitativeBar17.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(210)), CInt(CByte(219)), CInt(CByte(232)))
            Me.bulletGraphQualitativeBar17.Name = "bulletGraphQualitativeBar17"
            Me.bulletGraphQualitativeBar17.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar17.RangeEnd = 74.0F
            Me.bulletGraphQualitativeBar17.RangeStart = 50.0F
            ' 
            ' bulletGraphQualitativeBar18
            ' 
            Me.bulletGraphQualitativeBar18.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(237)), CInt(CByte(240)), CInt(CByte(246)))
            Me.bulletGraphQualitativeBar18.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(237)), CInt(CByte(240)), CInt(CByte(246)))
            Me.bulletGraphQualitativeBar18.Name = "bulletGraphQualitativeBar18"
            Me.bulletGraphQualitativeBar18.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar18.RangeStart = 75.0F
            ' 
            ' bulletGraphFeaturedMeasureBar6
            ' 
            Me.bulletGraphFeaturedMeasureBar6.AutoSize = False
            Me.bulletGraphFeaturedMeasureBar6.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.bulletGraphFeaturedMeasureBar6.Name = "bulletGraphFeaturedMeasureBar6"
            Me.bulletGraphFeaturedMeasureBar6.Offset = 11.0F
            Me.bulletGraphFeaturedMeasureBar6.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphFeaturedMeasureBar6.RangeEnd = 85.0F
            Me.bulletGraphFeaturedMeasureBar6.Width = 10.0F
            Me.bulletGraphFeaturedMeasureBar6.Width2 = 10.0F
            ' 
            ' linearGaugeNeedleIndicator12
            ' 
            Me.linearGaugeNeedleIndicator12.AutoSize = False
            Me.linearGaugeNeedleIndicator12.BackColor = System.Drawing.Color.Black
            Me.linearGaugeNeedleIndicator12.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.linearGaugeNeedleIndicator12.LenghtPercentage = 0.0F
            Me.linearGaugeNeedleIndicator12.LineLenght = 30.0F
            Me.linearGaugeNeedleIndicator12.LocationPercentage = 30.0F
            Me.linearGaugeNeedleIndicator12.Name = "linearGaugeNeedleIndicator12"
            Me.linearGaugeNeedleIndicator12.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator12.Thickness = 3.0F
            Me.linearGaugeNeedleIndicator12.Value = 80.0F
            ' 
            ' linearGaugeLabels26
            ' 
            Me.linearGaugeLabels26.AutoSize = False
            Me.linearGaugeLabels26.Bounds = New System.Drawing.Rectangle(0, 0, 280, 40)
            Me.linearGaugeLabels26.LabelFontSize = 4.0F
            Me.linearGaugeLabels26.Name = "linearGaugeLabels26"
            Me.linearGaugeLabels26.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radBulletGraph5
            ' 
            Me.radBulletGraph5.BackColor = System.Drawing.Color.White
            Me.radBulletGraph5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.bulletGraphQualitativeBar13, Me.bulletGraphQualitativeBar14, Me.bulletGraphQualitativeBar15, Me.bulletGraphFeaturedMeasureBar5, Me.linearGaugeNeedleIndicator11, Me.linearGaugeLabels25})
            Me.radBulletGraph5.Location = New System.Drawing.Point(486, 18)
            Me.radBulletGraph5.Name = "radBulletGraph5"
            Me.radBulletGraph5.Padding = New System.Windows.Forms.Padding(0, 5, 30, 5)
            Me.radBulletGraph5.Size = New System.Drawing.Size(65, 280)
            Me.radBulletGraph5.TabIndex = 3
            Me.radBulletGraph5.Text = "radBulletGraph1"
            Me.radBulletGraph5.Value = 0.0F
            Me.radBulletGraph5.Vertical = True
            ' 
            ' bulletGraphQualitativeBar13
            ' 
            Me.bulletGraphQualitativeBar13.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(184)), CInt(CByte(197)), CInt(CByte(218)))
            Me.bulletGraphQualitativeBar13.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(184)), CInt(CByte(197)), CInt(CByte(218)))
            Me.bulletGraphQualitativeBar13.Name = "bulletGraphQualitativeBar13"
            Me.bulletGraphQualitativeBar13.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar13.RangeEnd = 49.0F
            ' 
            ' bulletGraphQualitativeBar14
            ' 
            Me.bulletGraphQualitativeBar14.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(210)), CInt(CByte(219)), CInt(CByte(232)))
            Me.bulletGraphQualitativeBar14.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(210)), CInt(CByte(219)), CInt(CByte(232)))
            Me.bulletGraphQualitativeBar14.Name = "bulletGraphQualitativeBar14"
            Me.bulletGraphQualitativeBar14.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar14.RangeEnd = 74.0F
            Me.bulletGraphQualitativeBar14.RangeStart = 50.0F
            ' 
            ' bulletGraphQualitativeBar15
            ' 
            Me.bulletGraphQualitativeBar15.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(237)), CInt(CByte(240)), CInt(CByte(246)))
            Me.bulletGraphQualitativeBar15.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(237)), CInt(CByte(240)), CInt(CByte(246)))
            Me.bulletGraphQualitativeBar15.Name = "bulletGraphQualitativeBar15"
            Me.bulletGraphQualitativeBar15.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphQualitativeBar15.RangeStart = 75.0F
            ' 
            ' bulletGraphFeaturedMeasureBar5
            ' 
            Me.bulletGraphFeaturedMeasureBar5.AutoSize = False
            Me.bulletGraphFeaturedMeasureBar5.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.bulletGraphFeaturedMeasureBar5.Name = "bulletGraphFeaturedMeasureBar5"
            Me.bulletGraphFeaturedMeasureBar5.Offset = 13.0F
            Me.bulletGraphFeaturedMeasureBar5.Padding = New System.Windows.Forms.Padding(0)
            Me.bulletGraphFeaturedMeasureBar5.RangeEnd = 85.0F
            Me.bulletGraphFeaturedMeasureBar5.Width = 10.0F
            Me.bulletGraphFeaturedMeasureBar5.Width2 = 10.0F
            ' 
            ' linearGaugeNeedleIndicator11
            ' 
            Me.linearGaugeNeedleIndicator11.AutoSize = False
            Me.linearGaugeNeedleIndicator11.BackColor = System.Drawing.Color.Black
            Me.linearGaugeNeedleIndicator11.Bounds = New System.Drawing.Rectangle(0, 0, 280, 50)
            Me.linearGaugeNeedleIndicator11.Direction = Telerik.WinControls.UI.Gauges.Direction.Left
            Me.linearGaugeNeedleIndicator11.LenghtPercentage = 0.0F
            Me.linearGaugeNeedleIndicator11.LineLenght = 35.0F
            Me.linearGaugeNeedleIndicator11.LocationPercentage = 35.0F
            Me.linearGaugeNeedleIndicator11.Name = "linearGaugeNeedleIndicator11"
            Me.linearGaugeNeedleIndicator11.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator11.Thickness = 3.0F
            Me.linearGaugeNeedleIndicator11.Value = 80.0F
            ' 
            ' linearGaugeLabels25
            ' 
            Me.linearGaugeLabels25.AutoSize = False
            Me.linearGaugeLabels25.Bounds = New System.Drawing.Rectangle(0, 0, 35, 278)
            Me.linearGaugeLabels25.LabelFontSize = 4.0F
            Me.linearGaugeLabels25.LabelLocationPercentage = 52.0F
            Me.linearGaugeLabels25.Name = "linearGaugeLabels25"
            Me.linearGaugeLabels25.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge18
            ' 
            Me.radLinearGauge18.BackColor = System.Drawing.Color.White
            Me.radLinearGauge18.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar34, Me.linearGaugeBar35, Me.linearGaugeLine22, Me.linearGaugeTicks36, Me.linearGaugeLabels17})
            Me.radLinearGauge18.Location = New System.Drawing.Point(577, 154)
            Me.radLinearGauge18.Name = "radLinearGauge18"
            Me.radLinearGauge18.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.radLinearGauge18.RangeEnd = 120.0F
            Me.radLinearGauge18.Size = New System.Drawing.Size(280, 50)
            Me.radLinearGauge18.TabIndex = 0
            Me.radLinearGauge18.Text = "radLinearGauge1"
            Me.radLinearGauge18.Value = 70.0F
            ' 
            ' linearGaugeBar34
            ' 
            Me.linearGaugeBar34.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(144)), CInt(CByte(206)), CInt(CByte(103)))
            Me.linearGaugeBar34.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(144)), CInt(CByte(206)), CInt(CByte(103)))
            Me.linearGaugeBar34.BindEndRange = True
            Me.linearGaugeBar34.Name = "linearGaugeBar34"
            Me.linearGaugeBar34.Offset = 35.0F
            Me.linearGaugeBar34.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar34.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar35
            ' 
            Me.linearGaugeBar35.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar35.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar35.BindStartRange = True
            Me.linearGaugeBar35.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar35.Name = "linearGaugeBar35"
            Me.linearGaugeBar35.Offset = 35.0F
            Me.linearGaugeBar35.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar35.RangeEnd = 120.0F
            Me.linearGaugeBar35.RangeStart = 71.0F
            ' 
            ' linearGaugeLine22
            ' 
            Me.linearGaugeLine22.Name = "linearGaugeLine22"
            Me.linearGaugeLine22.Offset = 30.0F
            Me.linearGaugeLine22.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine22.RangeEnd = 120.0F
            Me.linearGaugeLine22.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks36
            ' 
            Me.linearGaugeTicks36.Name = "linearGaugeTicks36"
            Me.linearGaugeTicks36.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks36.TicksCount = 3
            Me.linearGaugeTicks36.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks36.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks36.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks36.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels17
            ' 
            Me.linearGaugeLabels17.LabelFontSize = 3.0F
            Me.linearGaugeLabels17.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels17.LabelsCount = 3
            Me.linearGaugeLabels17.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels17.Name = "linearGaugeLabels17"
            Me.linearGaugeLabels17.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge17
            ' 
            Me.radLinearGauge17.BackColor = System.Drawing.Color.White
            Me.radLinearGauge17.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar32, Me.linearGaugeBar33, Me.linearGaugeLine21, Me.linearGaugeTicks35, Me.linearGaugeLabels16})
            Me.radLinearGauge17.Location = New System.Drawing.Point(577, 78)
            Me.radLinearGauge17.Name = "radLinearGauge17"
            Me.radLinearGauge17.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.radLinearGauge17.RangeEnd = 120.0F
            Me.radLinearGauge17.Size = New System.Drawing.Size(280, 50)
            Me.radLinearGauge17.TabIndex = 0
            Me.radLinearGauge17.Text = "radLinearGauge1"
            Me.radLinearGauge17.Value = 70.0F
            ' 
            ' linearGaugeBar32
            ' 
            Me.linearGaugeBar32.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(77)), CInt(CByte(110)), CInt(CByte(163)))
            Me.linearGaugeBar32.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(77)), CInt(CByte(110)), CInt(CByte(163)))
            Me.linearGaugeBar32.BindEndRange = True
            Me.linearGaugeBar32.Name = "linearGaugeBar32"
            Me.linearGaugeBar32.Offset = 35.0F
            Me.linearGaugeBar32.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar32.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar33
            ' 
            Me.linearGaugeBar33.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar33.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(214)), CInt(CByte(214)), CInt(CByte(214)))
            Me.linearGaugeBar33.BindStartRange = True
            Me.linearGaugeBar33.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar33.Name = "linearGaugeBar33"
            Me.linearGaugeBar33.Offset = 35.0F
            Me.linearGaugeBar33.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar33.RangeEnd = 120.0F
            Me.linearGaugeBar33.RangeStart = 71.0F
            ' 
            ' linearGaugeLine21
            ' 
            Me.linearGaugeLine21.Name = "linearGaugeLine21"
            Me.linearGaugeLine21.Offset = 30.0F
            Me.linearGaugeLine21.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine21.RangeEnd = 120.0F
            Me.linearGaugeLine21.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks35
            ' 
            Me.linearGaugeTicks35.Name = "linearGaugeTicks35"
            Me.linearGaugeTicks35.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks35.TicksCount = 3
            Me.linearGaugeTicks35.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks35.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks35.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks35.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels16
            ' 
            Me.linearGaugeLabels16.LabelFontSize = 3.0F
            Me.linearGaugeLabels16.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels16.LabelsCount = 3
            Me.linearGaugeLabels16.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels16.Name = "linearGaugeLabels16"
            Me.linearGaugeLabels16.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge16
            ' 
            Me.radLinearGauge16.BackColor = System.Drawing.Color.White
            Me.radLinearGauge16.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar29, Me.linearGaugeBar30, Me.linearGaugeBar31, Me.linearGaugeLine20, Me.linearGaugeTicks34, Me.linearGaugeLabels15, _
                Me.linearGaugeNeedleIndicator5})
            Me.radLinearGauge16.Location = New System.Drawing.Point(577, 18)
            Me.radLinearGauge16.Name = "radLinearGauge16"
            Me.radLinearGauge16.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
            Me.radLinearGauge16.RangeEnd = 120.0F
            Me.radLinearGauge16.Size = New System.Drawing.Size(280, 44)
            Me.radLinearGauge16.TabIndex = 2
            Me.radLinearGauge16.Text = "radLinearGauge2"
            Me.radLinearGauge16.Value = 90.0F
            ' 
            ' linearGaugeBar29
            ' 
            Me.linearGaugeBar29.AutoSize = True
            Me.linearGaugeBar29.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(144)), CInt(CByte(206)), CInt(CByte(103)))
            Me.linearGaugeBar29.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(144)), CInt(CByte(206)), CInt(CByte(103)))
            Me.linearGaugeBar29.Name = "linearGaugeBar29"
            Me.linearGaugeBar29.Offset = 25.0F
            Me.linearGaugeBar29.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar29.RangeEnd = 40.0F
            Me.linearGaugeBar29.Width = 10.0F
            Me.linearGaugeBar29.Width2 = 25.0F
            ' 
            ' linearGaugeBar30
            ' 
            Me.linearGaugeBar30.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(106)))
            Me.linearGaugeBar30.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(106)))
            Me.linearGaugeBar30.Name = "linearGaugeBar30"
            Me.linearGaugeBar30.Offset = 25.0F
            Me.linearGaugeBar30.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar30.RangeEnd = 80.0F
            Me.linearGaugeBar30.RangeStart = 41.0F
            Me.linearGaugeBar30.Width = 25.0F
            Me.linearGaugeBar30.Width2 = 40.0F
            ' 
            ' linearGaugeBar31
            ' 
            Me.linearGaugeBar31.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(88)), CInt(CByte(88)))
            Me.linearGaugeBar31.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(88)), CInt(CByte(88)))
            Me.linearGaugeBar31.Name = "linearGaugeBar31"
            Me.linearGaugeBar31.Offset = 25.0F
            Me.linearGaugeBar31.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar31.RangeEnd = 120.0F
            Me.linearGaugeBar31.RangeStart = 81.0F
            Me.linearGaugeBar31.Width = 40.0F
            Me.linearGaugeBar31.Width2 = 55.0F
            ' 
            ' linearGaugeLine20
            ' 
            Me.linearGaugeLine20.AutoSize = False
            Me.linearGaugeLine20.Bounds = New System.Drawing.Rectangle(0, 0, 15, 285)
            Me.linearGaugeLine20.Name = "linearGaugeLine20"
            Me.linearGaugeLine20.Offset = 22.0F
            Me.linearGaugeLine20.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine20.RangeEnd = 120.0F
            Me.linearGaugeLine20.Width = 1.5F
            ' 
            ' linearGaugeTicks34
            ' 
            Me.linearGaugeTicks34.AutoSize = False
            Me.linearGaugeTicks34.Bounds = New System.Drawing.Rectangle(0, 0, 15, 261)
            Me.linearGaugeTicks34.Name = "linearGaugeTicks34"
            Me.linearGaugeTicks34.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks34.TicksCount = 12
            Me.linearGaugeTicks34.TicksLenghtPercentage = 5.0F
            Me.linearGaugeTicks34.TicksLocationPercentage = 21.0F
            Me.linearGaugeTicks34.TicksOffset = 65
            Me.linearGaugeTicks34.TickThickness = 0.5F
            ' 
            ' linearGaugeLabels15
            ' 
            Me.linearGaugeLabels15.AutoSize = False
            Me.linearGaugeLabels15.Bounds = New System.Drawing.Rectangle(0, 0, 219, 33)
            Me.linearGaugeLabels15.LabelFontSize = 4.0F
            Me.linearGaugeLabels15.LabelLocationPercentage = 10.0F
            Me.linearGaugeLabels15.LabelsCount = 3
            Me.linearGaugeLabels15.Name = "linearGaugeLabels15"
            Me.linearGaugeLabels15.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeNeedleIndicator5
            ' 
            Me.linearGaugeNeedleIndicator5.AutoSize = False
            Me.linearGaugeNeedleIndicator5.BindValue = True
            Me.linearGaugeNeedleIndicator5.Bounds = New System.Drawing.Rectangle(0, 0, 11, 223)
            Me.linearGaugeNeedleIndicator5.Direction = Telerik.WinControls.UI.Gauges.Direction.Down
            Me.linearGaugeNeedleIndicator5.HorizontalLineWidth = 0
            Me.linearGaugeNeedleIndicator5.InnerPointRadiusPercentage = 10.0F
            Me.linearGaugeNeedleIndicator5.LocationPercentage = 17.0F
            Me.linearGaugeNeedleIndicator5.Name = "linearGaugeNeedleIndicator5"
            Me.linearGaugeNeedleIndicator5.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator5.Value = 90.0F
            ' 
            ' radLinearGauge4
            ' 
            Me.radLinearGauge4.BackColor = System.Drawing.Color.White
            Me.radLinearGauge4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar6, Me.linearGaugeBar7, Me.linearGaugeTicks11})
            Me.radLinearGauge4.Location = New System.Drawing.Point(382, 18)
            Me.radLinearGauge4.Name = "radLinearGauge4"
            Me.radLinearGauge4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radLinearGauge4.RangeEnd = 120.0F
            Me.radLinearGauge4.Size = New System.Drawing.Size(59, 280)
            Me.radLinearGauge4.TabIndex = 0
            Me.radLinearGauge4.Text = "radLinearGauge1"
            Me.radLinearGauge4.Value = 70.0F
            Me.radLinearGauge4.Vertical = True
            ' 
            ' linearGaugeBar6
            ' 
            Me.linearGaugeBar6.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(105)))
            Me.linearGaugeBar6.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(105)))
            Me.linearGaugeBar6.BindEndRange = True
            Me.linearGaugeBar6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeBar6.Name = "linearGaugeBar6"
            Me.linearGaugeBar6.Offset = 30.0F
            Me.linearGaugeBar6.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar6.RangeEnd = 70.0F
            Me.linearGaugeBar6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            ' 
            ' linearGaugeBar7
            ' 
            Me.linearGaugeBar7.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(88)), CInt(CByte(88)))
            Me.linearGaugeBar7.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(88)), CInt(CByte(88)))
            Me.linearGaugeBar7.BindStartRange = True
            Me.linearGaugeBar7.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeBar7.Name = "linearGaugeBar7"
            Me.linearGaugeBar7.Offset = 30.0F
            Me.linearGaugeBar7.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar7.RangeEnd = 120.0F
            Me.linearGaugeBar7.RangeStart = 70.0F
            Me.linearGaugeBar7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            ' 
            ' linearGaugeTicks11
            ' 
            Me.linearGaugeTicks11.AutoSize = True
            Me.linearGaugeTicks11.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeTicks11.Name = "linearGaugeTicks11"
            Me.linearGaugeTicks11.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.linearGaugeTicks11.TickColor = System.Drawing.Color.White
            Me.linearGaugeTicks11.TicksCount = 11
            Me.linearGaugeTicks11.TicksLenghtPercentage = 44.0F
            Me.linearGaugeTicks11.TicksLocationPercentage = 60.0F
            Me.linearGaugeTicks11.TicksOffset = 30
            ' 
            ' radLinearGauge3
            ' 
            Me.radLinearGauge3.BackColor = System.Drawing.Color.White
            Me.radLinearGauge3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar4, Me.linearGaugeBar5, Me.linearGaugeTicks9, Me.linearGaugeLine6, Me.linearGaugeTicks10, Me.linearGaugeLabels4})
            Me.radLinearGauge3.Location = New System.Drawing.Point(272, 18)
            Me.radLinearGauge3.Name = "radLinearGauge3"
            Me.radLinearGauge3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.radLinearGauge3.RangeEnd = 120.0F
            Me.radLinearGauge3.Size = New System.Drawing.Size(59, 280)
            Me.radLinearGauge3.TabIndex = 0
            Me.radLinearGauge3.Text = "radLinearGauge1"
            Me.radLinearGauge3.Value = 70.0F
            Me.radLinearGauge3.Vertical = True
            ' 
            ' linearGaugeBar4
            ' 
            Me.linearGaugeBar4.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(105)))
            Me.linearGaugeBar4.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(105)))
            Me.linearGaugeBar4.BindEndRange = True
            Me.linearGaugeBar4.Name = "linearGaugeBar4"
            Me.linearGaugeBar4.Offset = 30.0F
            Me.linearGaugeBar4.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar4.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar5
            ' 
            Me.linearGaugeBar5.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(88)), CInt(CByte(88)))
            Me.linearGaugeBar5.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(88)), CInt(CByte(88)))
            Me.linearGaugeBar5.BindStartRange = True
            Me.linearGaugeBar5.Name = "linearGaugeBar5"
            Me.linearGaugeBar5.Offset = 30.0F
            Me.linearGaugeBar5.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar5.RangeEnd = 120.0F
            Me.linearGaugeBar5.RangeStart = 70.0F
            ' 
            ' linearGaugeTicks9
            ' 
            Me.linearGaugeTicks9.AutoSize = True
            Me.linearGaugeTicks9.Name = "linearGaugeTicks9"
            Me.linearGaugeTicks9.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks9.TickColor = System.Drawing.Color.White
            Me.linearGaugeTicks9.TicksCount = 11
            Me.linearGaugeTicks9.TicksLenghtPercentage = 44.0F
            Me.linearGaugeTicks9.TicksLocationPercentage = 60.0F
            Me.linearGaugeTicks9.TicksOffset = 30
            ' 
            ' linearGaugeLine6
            ' 
            Me.linearGaugeLine6.Name = "linearGaugeLine6"
            Me.linearGaugeLine6.Offset = 30.0F
            Me.linearGaugeLine6.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine6.RangeEnd = 120.0F
            Me.linearGaugeLine6.RangeStart = 80.0F
            ' 
            ' linearGaugeTicks10
            ' 
            Me.linearGaugeTicks10.Name = "linearGaugeTicks10"
            Me.linearGaugeTicks10.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks10.TickEndIndexVisibleRange = 1.0F
            Me.linearGaugeTicks10.TicksCount = 3
            Me.linearGaugeTicks10.TicksLenghtPercentage = 15.0F
            Me.linearGaugeTicks10.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks10.TickThickness = 0.7F
            ' 
            ' linearGaugeLabels4
            ' 
            Me.linearGaugeLabels4.LabelFontSize = 3.0F
            Me.linearGaugeLabels4.LabelLocationPercentage = 10.0F
            Me.linearGaugeLabels4.LabelsCount = 3
            Me.linearGaugeLabels4.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels4.Name = "linearGaugeLabels4"
            Me.linearGaugeLabels4.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge2
            ' 
            Me.radLinearGauge2.BackColor = System.Drawing.Color.White
            Me.radLinearGauge2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar2, Me.linearGaugeBar3, Me.linearGaugeLine4, Me.linearGaugeLine5, Me.linearGaugeTicks5, Me.linearGaugeTicks6, _
                Me.linearGaugeTicks7, Me.linearGaugeTicks8, Me.linearGaugeLabels2, Me.linearGaugeLabels3})
            Me.radLinearGauge2.Location = New System.Drawing.Point(166, 18)
            Me.radLinearGauge2.Name = "radLinearGauge2"
            Me.radLinearGauge2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
            Me.radLinearGauge2.RangeEnd = 120.0F
            Me.radLinearGauge2.Size = New System.Drawing.Size(60, 280)
            Me.radLinearGauge2.TabIndex = 0
            Me.radLinearGauge2.Text = "radLinearGauge1"
            Me.radLinearGauge2.Value = 70.0F
            Me.radLinearGauge2.Vertical = True
            ' 
            ' linearGaugeBar2
            ' 
            Me.linearGaugeBar2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(77)), CInt(CByte(110)), CInt(CByte(163)))
            Me.linearGaugeBar2.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(77)), CInt(CByte(110)), CInt(CByte(163)))
            Me.linearGaugeBar2.BindEndRange = True
            Me.linearGaugeBar2.Name = "linearGaugeBar2"
            Me.linearGaugeBar2.Offset = 35.0F
            Me.linearGaugeBar2.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar2.RangeEnd = 70.0F
            ' 
            ' linearGaugeBar3
            ' 
            Me.linearGaugeBar3.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(224)), CInt(CByte(224)))
            Me.linearGaugeBar3.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(224)), CInt(CByte(224)), CInt(CByte(224)))
            Me.linearGaugeBar3.BindStartRange = True
            Me.linearGaugeBar3.BindStartRangeOffset = 1.0F
            Me.linearGaugeBar3.Name = "linearGaugeBar3"
            Me.linearGaugeBar3.Offset = 35.0F
            Me.linearGaugeBar3.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar3.RangeEnd = 120.0F
            Me.linearGaugeBar3.RangeStart = 71.0F
            ' 
            ' linearGaugeLine4
            ' 
            Me.linearGaugeLine4.AutoSize = False
            Me.linearGaugeLine4.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeLine4.Name = "linearGaugeLine4"
            Me.linearGaugeLine4.Offset = 35.0F
            Me.linearGaugeLine4.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine4.RangeEnd = 80.0F
            Me.linearGaugeLine4.Width = 2.0F
            ' 
            ' linearGaugeLine5
            ' 
            Me.linearGaugeLine5.AutoSize = False
            Me.linearGaugeLine5.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLine5.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeLine5.Name = "linearGaugeLine5"
            Me.linearGaugeLine5.Offset = 35.0F
            Me.linearGaugeLine5.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine5.RangeEnd = 120.0F
            Me.linearGaugeLine5.RangeStart = 80.0F
            Me.linearGaugeLine5.Width = 2.0F
            ' 
            ' linearGaugeTicks5
            ' 
            Me.linearGaugeTicks5.Name = "linearGaugeTicks5"
            Me.linearGaugeTicks5.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks5.TicksCount = 3
            Me.linearGaugeTicks5.TicksLenghtPercentage = 9.0F
            Me.linearGaugeTicks5.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks5.TickStartIndexVisibleRange = 2.0F
            Me.linearGaugeTicks5.TickThickness = 0.7F
            ' 
            ' linearGaugeTicks6
            ' 
            Me.linearGaugeTicks6.Name = "linearGaugeTicks6"
            Me.linearGaugeTicks6.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks6.TicksCount = 12
            Me.linearGaugeTicks6.TicksLenghtPercentage = 5.0F
            Me.linearGaugeTicks6.TicksLocationPercentage = 30.0F
            Me.linearGaugeTicks6.TickStartIndexVisibleRange = 5.0F
            Me.linearGaugeTicks6.TickThickness = 0.6F
            ' 
            ' linearGaugeTicks7
            ' 
            Me.linearGaugeTicks7.Name = "linearGaugeTicks7"
            Me.linearGaugeTicks7.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks7.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeTicks7.TickEndIndexVisibleRange = 4.0F
            Me.linearGaugeTicks7.TicksCount = 12
            Me.linearGaugeTicks7.TicksLenghtPercentage = 5.0F
            Me.linearGaugeTicks7.TicksLocationPercentage = 30.0F
            ' 
            ' linearGaugeTicks8
            ' 
            Me.linearGaugeTicks8.Name = "linearGaugeTicks8"
            Me.linearGaugeTicks8.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks8.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeTicks8.TickEndIndexVisibleRange = 1.0F
            Me.linearGaugeTicks8.TicksCount = 3
            Me.linearGaugeTicks8.TicksLocationPercentage = 30.0F
            ' 
            ' linearGaugeLabels2
            ' 
            Me.linearGaugeLabels2.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLabels2.LabelFontSize = 3.0F
            Me.linearGaugeLabels2.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels2.LabelsCount = 3
            Me.linearGaugeLabels2.LabelStartVisibleRange = 80.0F
            Me.linearGaugeLabels2.Name = "linearGaugeLabels2"
            Me.linearGaugeLabels2.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeLabels3
            ' 
            Me.linearGaugeLabels3.LabelEndVisibleRange = 40.0F
            Me.linearGaugeLabels3.LabelFontSize = 3.0F
            Me.linearGaugeLabels3.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels3.LabelsCount = 3
            Me.linearGaugeLabels3.Name = "linearGaugeLabels3"
            Me.linearGaugeLabels3.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radLinearGauge1
            ' 
            Me.radLinearGauge1.BackColor = System.Drawing.Color.White
            Me.radLinearGauge1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.linearGaugeBar1, Me.linearGaugeLine1, Me.linearGaugeLine2, Me.linearGaugeTicks1, Me.linearGaugeLabels1, Me.linearGaugeTicks2, _
                Me.linearGaugeTicks3, Me.linearGaugeLine3, Me.linearGaugeTicks4, Me.linearGaugeNeedleIndicator1})
            Me.radLinearGauge1.Location = New System.Drawing.Point(24, 18)
            Me.radLinearGauge1.Name = "radLinearGauge1"
            Me.radLinearGauge1.Padding = New System.Windows.Forms.Padding(0, 5, 40, 5)
            Me.radLinearGauge1.RangeEnd = 120.0F
            Me.radLinearGauge1.Size = New System.Drawing.Size(106, 280)
            Me.radLinearGauge1.TabIndex = 0
            Me.radLinearGauge1.Text = "radLinearGauge1"
            Me.radLinearGauge1.Value = 70.0F
            Me.radLinearGauge1.Vertical = True
            ' 
            ' linearGaugeBar1
            ' 
            Me.linearGaugeBar1.AutoSize = False
            Me.linearGaugeBar1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(77)), CInt(CByte(110)), CInt(CByte(163)))
            Me.linearGaugeBar1.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(77)), CInt(CByte(110)), CInt(CByte(163)))
            Me.linearGaugeBar1.BindEndRange = True
            Me.linearGaugeBar1.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeBar1.Name = "linearGaugeBar1"
            Me.linearGaugeBar1.Offset = 35.0F
            Me.linearGaugeBar1.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeBar1.RangeEnd = 70.0F
            Me.linearGaugeBar1.Width = 24.0F
            Me.linearGaugeBar1.Width2 = 24.0F
            ' 
            ' linearGaugeLine1
            ' 
            Me.linearGaugeLine1.AutoSize = False
            Me.linearGaugeLine1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.linearGaugeLine1.Bounds = New System.Drawing.Rectangle(0, 0, 60, 270)
            Me.linearGaugeLine1.Name = "linearGaugeLine1"
            Me.linearGaugeLine1.Offset = 35.0F
            Me.linearGaugeLine1.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine1.RangeEnd = 80.0F
            Me.linearGaugeLine1.Width = 2.0F
            ' 
            ' linearGaugeLine2
            ' 
            Me.linearGaugeLine2.AutoSize = False
            Me.linearGaugeLine2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLine2.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeLine2.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeLine2.Name = "linearGaugeLine2"
            Me.linearGaugeLine2.Offset = 35.0F
            Me.linearGaugeLine2.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine2.RangeEnd = 120.0F
            Me.linearGaugeLine2.RangeStart = 80.0F
            Me.linearGaugeLine2.Width = 2.0F
            ' 
            ' linearGaugeTicks1
            ' 
            Me.linearGaugeTicks1.AutoSize = False
            Me.linearGaugeTicks1.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks1.Name = "linearGaugeTicks1"
            Me.linearGaugeTicks1.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.linearGaugeTicks1.TicksCount = 3
            Me.linearGaugeTicks1.TicksLenghtPercentage = 4.0F
            Me.linearGaugeTicks1.TicksLocationPercentage = 33.0F
            ' 
            ' linearGaugeLabels1
            ' 
            Me.linearGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.linearGaugeLabels1.LabelFontSize = 3.0F
            Me.linearGaugeLabels1.LabelLocationPercentage = 15.0F
            Me.linearGaugeLabels1.LabelsCount = 3
            Me.linearGaugeLabels1.Name = "linearGaugeLabels1"
            Me.linearGaugeLabels1.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' linearGaugeTicks2
            ' 
            Me.linearGaugeTicks2.AutoSize = False
            Me.linearGaugeTicks2.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks2.Name = "linearGaugeTicks2"
            Me.linearGaugeTicks2.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks2.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(205)), CInt(CByte(47)), CInt(CByte(47)))
            Me.linearGaugeTicks2.TickEndIndexVisibleRange = 4.0F
            Me.linearGaugeTicks2.TicksCount = 12
            Me.linearGaugeTicks2.TicksLenghtPercentage = 2.0F
            Me.linearGaugeTicks2.TicksLocationPercentage = 33.0F
            ' 
            ' linearGaugeTicks3
            ' 
            Me.linearGaugeTicks3.AutoSize = False
            Me.linearGaugeTicks3.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks3.Name = "linearGaugeTicks3"
            Me.linearGaugeTicks3.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks3.TicksCount = 12
            Me.linearGaugeTicks3.TicksLenghtPercentage = 2.0F
            Me.linearGaugeTicks3.TicksLocationPercentage = 33.0F
            Me.linearGaugeTicks3.TickStartIndexVisibleRange = 5.0F
            ' 
            ' linearGaugeLine3
            ' 
            Me.linearGaugeLine3.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeLine3.BackColor2 = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeLine3.Name = "linearGaugeLine3"
            Me.linearGaugeLine3.Offset = 69.0F
            Me.linearGaugeLine3.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeLine3.RangeEnd = 120.0F
            ' 
            ' linearGaugeTicks4
            ' 
            Me.linearGaugeTicks4.AutoSize = False
            Me.linearGaugeTicks4.Bounds = New System.Drawing.Rectangle(0, 0, 59, 270)
            Me.linearGaugeTicks4.Name = "linearGaugeTicks4"
            Me.linearGaugeTicks4.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeTicks4.TickColor = System.Drawing.Color.FromArgb(CInt(CByte(153)), CInt(CByte(153)), CInt(CByte(153)))
            Me.linearGaugeTicks4.TicksCount = 12
            Me.linearGaugeTicks4.TicksLenghtPercentage = 3.0F
            Me.linearGaugeTicks4.TicksLocationPercentage = 72.0F
            ' 
            ' linearGaugeNeedleIndicator1
            ' 
            Me.linearGaugeNeedleIndicator1.AutoSize = False
            Me.linearGaugeNeedleIndicator1.BackColor = System.Drawing.Color.Red
            Me.linearGaugeNeedleIndicator1.Bounds = New System.Drawing.Rectangle(0, 0, 63, 270)
            Me.linearGaugeNeedleIndicator1.CircleTicks = True
            Me.linearGaugeNeedleIndicator1.Direction = Telerik.WinControls.UI.Gauges.Direction.Left
            Me.linearGaugeNeedleIndicator1.DrawValue = True
            Me.linearGaugeNeedleIndicator1.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(102)), CInt(CByte(102)))
            Me.linearGaugeNeedleIndicator1.InnerPointRadiusPercentage = 10.0F
            Me.linearGaugeNeedleIndicator1.IsFilled = False
            Me.linearGaugeNeedleIndicator1.LenghtPercentage = 6.0F
            Me.linearGaugeNeedleIndicator1.LineLenght = 40.0F
            Me.linearGaugeNeedleIndicator1.LocationPercentage = 70.0F
            Me.linearGaugeNeedleIndicator1.Name = "linearGaugeNeedleIndicator1"
            Me.linearGaugeNeedleIndicator1.Padding = New System.Windows.Forms.Padding(0)
            Me.linearGaugeNeedleIndicator1.PointRadiusPercentage = 10.0F
            Me.linearGaugeNeedleIndicator1.TextOffsetFromIndicator = New System.Drawing.SizeF(2.0F, -5.0F)
            Me.linearGaugeNeedleIndicator1.Value = 66.0F
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radScrollablePanel3)
            Me.Controls.Add(Me.radScrollablePanel2)
            Me.Controls.Add(Me.radScrollablePanel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1220, 814)
            Me.Controls.SetChildIndex(Me.radScrollablePanel1, 0)
            Me.Controls.SetChildIndex(Me.radScrollablePanel2, 0)
            Me.Controls.SetChildIndex(Me.radScrollablePanel3, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            DirectCast(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel1.PanelContainer.ResumeLayout(False)
            DirectCast(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel1.ResumeLayout(False)
            DirectCast(Me.radBulletGraph4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radBulletGraph3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge15, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge14, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge13, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge12, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge11, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge10, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge9, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel2.PanelContainer.ResumeLayout(False)
            DirectCast(Me.radScrollablePanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel2.ResumeLayout(False)
            DirectCast(Me.radBulletGraph2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radBulletGraph1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge21, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge20, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge19, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel3.PanelContainer.ResumeLayout(False)
            DirectCast(Me.radScrollablePanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radScrollablePanel3.ResumeLayout(False)
            DirectCast(Me.radBulletGraph6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radBulletGraph5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge18, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge17, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge16, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radLinearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radialGaugeArc22 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc23 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks18 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks19 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks20 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks21 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels8 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeLabels9 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle11 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeNeedle12 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
        Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
        Private radScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
        Private radScrollablePanel2 As Telerik.WinControls.UI.RadScrollablePanel
        Private radScrollablePanel3 As Telerik.WinControls.UI.RadScrollablePanel
        Private radLinearGauge3 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar4 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar5 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeTicks9 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLine6 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks10 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels4 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge2 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar2 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar3 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine4 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeLine5 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks5 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks6 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks7 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks8 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels2 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeLabels3 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge1 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar1 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine1 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeLine2 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks1 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels1 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeTicks2 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks3 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLine3 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks4 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeNeedleIndicator1 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private radLinearGauge4 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar6 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar7 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeTicks11 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private radLinearGauge5 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar8 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine7 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks12 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels5 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeTicks13 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLine8 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks14 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeNeedleIndicator2 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private radLinearGauge8 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar13 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar14 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeTicks19 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private radLinearGauge7 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar11 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar12 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeTicks17 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLine10 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks18 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels7 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge6 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar9 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar10 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine9 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks15 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels6 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeTicks16 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private radLinearGauge12 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar20 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar21 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeTicks30 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private radLinearGauge11 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar18 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar19 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeTicks28 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLine16 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks29 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels11 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge10 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar16 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar17 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine14 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeLine15 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks24 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks25 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks26 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks27 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels9 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeLabels10 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge9 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar15 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine11 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeLine12 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks20 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels8 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeTicks21 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeTicks22 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLine13 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks23 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeNeedleIndicator3 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private radLinearGauge15 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar27 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar28 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine19 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks33 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels14 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge14 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar25 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar26 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine18 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks32 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels13 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge13 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar22 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar23 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar24 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine17 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks31 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels12 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeNeedleIndicator4 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private radLinearGauge18 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar34 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar35 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine22 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks36 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels17 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge17 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar32 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar33 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine21 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks35 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels16 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge16 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar29 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar30 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar31 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine20 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks34 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels15 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeNeedleIndicator5 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private radLinearGauge21 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar39 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar40 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine25 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks39 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels20 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge20 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar37 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeBar38 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine24 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks38 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels19 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radLinearGauge19 As Telerik.WinControls.UI.Gauges.RadLinearGauge
        Private linearGaugeBar36 As Telerik.WinControls.UI.Gauges.LinearGaugeBar
        Private linearGaugeLine23 As Telerik.WinControls.UI.Gauges.LinearGaugeLine
        Private linearGaugeTicks37 As Telerik.WinControls.UI.Gauges.LinearGaugeTicks
        Private linearGaugeLabels18 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private linearGaugeNeedleIndicator6 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private radBulletGraph2 As Telerik.WinControls.UI.Gauges.RadBulletGraph
        Private bulletGraphQualitativeBar4 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar5 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar6 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphFeaturedMeasureBar2 As Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar
        Private linearGaugeNeedleIndicator8 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private linearGaugeLabels22 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radBulletGraph1 As Telerik.WinControls.UI.Gauges.RadBulletGraph
        Private bulletGraphQualitativeBar1 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar2 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar3 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphFeaturedMeasureBar1 As Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar
        Private linearGaugeNeedleIndicator7 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private linearGaugeLabels21 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radBulletGraph4 As Telerik.WinControls.UI.Gauges.RadBulletGraph
        Private bulletGraphQualitativeBar10 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar11 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar12 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphFeaturedMeasureBar4 As Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar
        Private linearGaugeNeedleIndicator10 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private linearGaugeLabels24 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radBulletGraph3 As Telerik.WinControls.UI.Gauges.RadBulletGraph
        Private bulletGraphQualitativeBar7 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar8 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar9 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphFeaturedMeasureBar3 As Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar
        Private linearGaugeNeedleIndicator9 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private linearGaugeLabels23 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radBulletGraph6 As Telerik.WinControls.UI.Gauges.RadBulletGraph
        Private bulletGraphQualitativeBar16 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar17 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar18 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphFeaturedMeasureBar6 As Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar
        Private linearGaugeNeedleIndicator12 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private linearGaugeLabels26 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
        Private radBulletGraph5 As Telerik.WinControls.UI.Gauges.RadBulletGraph
        Private bulletGraphQualitativeBar13 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar14 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphQualitativeBar15 As Telerik.WinControls.UI.Gauges.BulletGraphQualitativeBar
        Private bulletGraphFeaturedMeasureBar5 As Telerik.WinControls.UI.Gauges.BulletGraphFeaturedMeasureBar
        Private linearGaugeNeedleIndicator11 As Telerik.WinControls.UI.Gauges.LinearGaugeNeedleIndicator
        Private linearGaugeLabels25 As Telerik.WinControls.UI.Gauges.LinearGaugeLabels
    End Class
End Namespace