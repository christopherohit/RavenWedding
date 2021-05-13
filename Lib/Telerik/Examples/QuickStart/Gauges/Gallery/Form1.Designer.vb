Imports Microsoft.VisualBasic
Imports System.Drawing
Imports Telerik.WinControls.Primitives
Namespace Telerik.Examples.WinControls.Gauges.Gallery
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Timer.Stop()
            Timer.Dispose()
            If disposing AndAlso (Not components Is Nothing) Then
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
            Me.radPanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radRadialGauge11 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc20 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc21 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeLabels7 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeTicks17 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge10 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc17 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc18 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc19 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks16 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels6 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle10 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radRadialGauge9 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc14 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc15 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc16 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks12 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks13 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle9 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeTicks14 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks15 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge8 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc12 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc13 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle8 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeLabels5 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeSingleLabel3 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge5 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc6 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc7 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeLabels4 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeTicks11 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeSingleLabel1 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge4 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc5 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks9 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks10 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle5 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeNeedle6 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radRadialGauge1 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc1 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc2 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks1 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks2 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks3 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks4 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels1 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeLabels2 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle1 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeNeedle2 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radRadialGauge6 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radRadialGauge7 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc10 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc11 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle7 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeArc8 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc9 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeSingleLabel2 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge2 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc3 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle3 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeTicks5 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks6 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks7 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge3 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc4 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks8 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle4 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeLabels3 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radPanel2 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radRadialGauge22 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc41 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc42 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeLabels14 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeTicks34 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge21 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc38 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc39 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc40 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks33 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels13 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle20 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radRadialGauge20 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc35 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc36 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc37 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks29 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks30 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle19 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeTicks31 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks32 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge19 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc33 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc34 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle18 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeLabels12 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeSingleLabel6 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge17 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radRadialGauge18 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc31 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc32 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle17 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeArc29 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc30 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeSingleLabel5 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge16 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc27 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc28 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeLabels11 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeTicks28 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeSingleLabel4 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge14 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc25 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks25 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle14 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeLabels10 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radRadialGauge13 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc24 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle13 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeTicks22 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks23 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks24 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge12 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc43 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc44 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks35 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks36 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks37 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks38 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels15 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeLabels16 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle21 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeNeedle22 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radRadialGauge15 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc26 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks26 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks27 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle15 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeNeedle16 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
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
            Me.radPanel3 = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radRadialGauge33 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc64 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc65 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeLabels23 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeTicks55 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge32 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc61 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc62 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc63 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks54 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels22 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle32 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radRadialGauge31 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc58 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc59 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc60 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks50 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks51 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle31 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeTicks52 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks53 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge30 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc56 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc57 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle30 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeLabels21 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeSingleLabel9 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge28 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radRadialGauge29 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc55 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle29 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeArc53 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc54 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeSingleLabel8 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge27 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc51 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc52 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeLabels20 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeTicks49 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeSingleLabel7 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radRadialGauge26 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc49 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc50 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks47 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks48 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle27 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeNeedle28 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radRadialGauge25 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc48 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks46 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeNeedle26 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeLabels19 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radRadialGauge24 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc47 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle25 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeTicks43 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks44 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks45 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radRadialGauge23 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc45 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc46 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks39 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks40 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks41 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks42 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels17 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeLabels18 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle23 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeNeedle24 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.SuspendLayout()
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.PanelContainer.SuspendLayout()
            Me.radPanel1.SuspendLayout()
            CType(Me.radRadialGauge11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radRadialGauge6.SuspendLayout()
            CType(Me.radRadialGauge7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel2.PanelContainer.SuspendLayout()
            Me.radPanel2.SuspendLayout()
            CType(Me.radRadialGauge22, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge17, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radRadialGauge17.SuspendLayout()
            CType(Me.radRadialGauge18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel3.PanelContainer.SuspendLayout()
            Me.radPanel3.SuspendLayout()
            CType(Me.radRadialGauge33, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge32, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge31, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge30, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge28, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radRadialGauge28.SuspendLayout()
            CType(Me.radRadialGauge29, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge27, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge26, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge25, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge24, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge23, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBox1.SuspendLayout()
            CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Controls.Add(Me.radGroupBox1)
            Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
            ' 
            ' radPanel1
            ' 
            Me.radPanel1.PanelElement.BackColor = System.Drawing.Color.White
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel1.Location = New System.Drawing.Point(0, 0)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radPanel1.PanelContainer
            ' 
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge11)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge10)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge9)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge8)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge5)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge4)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge1)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge6)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge2)
            Me.radPanel1.PanelContainer.Controls.Add(Me.radRadialGauge3)
            Me.radPanel1.PanelContainer.Location = New System.Drawing.Point(0, 0)
            Me.radPanel1.PanelContainer.Size = New System.Drawing.Size(1193, 828)
            Me.radPanel1.Size = New System.Drawing.Size(1193, 828)
            Me.radPanel1.TabIndex = 0
            CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' radRadialGauge11
            ' 

            Me.radRadialGauge11.BackColor = System.Drawing.Color.White
            Me.radRadialGauge11.CausesValidation = False
            Me.radRadialGauge11.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc20, Me.radialGaugeArc21, Me.radialGaugeLabels7, Me.radialGaugeTicks17})
            Me.radRadialGauge11.Location = New System.Drawing.Point(258, 428)
            Me.radRadialGauge11.Name = "radRadialGauge11"
            Me.radRadialGauge11.RangeEnd = 180.0R
            Me.radRadialGauge11.RangeStart = 0.0R
            Me.radRadialGauge11.Size = New System.Drawing.Size(166, 164)
            Me.radRadialGauge11.StartAngle = 120.0R
            Me.radRadialGauge11.SweepAngle = 300.0R
            Me.radRadialGauge11.TabIndex = 6
            Me.radRadialGauge11.Text = "radRadialGauge1"
            Me.radRadialGauge11.Value = 100.0F
            ' 
            ' radialGaugeArc20
            ' 
            Me.radialGaugeArc20.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeArc20.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeArc20.BindEndRange = True
            Me.radialGaugeArc20.Name = "radialGaugeArc20"
            Me.radialGaugeArc20.Radius = 0.0R
            Me.radialGaugeArc20.RangeEnd = 100.0R
            Me.radialGaugeArc20.RangeStart = 0.0R
            Me.radialGaugeArc20.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc20.Width = 24.0R
            ' 
            ' radialGaugeArc21
            ' 
            Me.radialGaugeArc21.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(214))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(214))))))
            Me.radialGaugeArc21.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(214))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(214))))))
            Me.radialGaugeArc21.BindStartRange = True
            Me.radialGaugeArc21.Name = "radialGaugeArc21"
            Me.radialGaugeArc21.Radius = 87.0R
            Me.radialGaugeArc21.RangeEnd = 180.0R
            Me.radialGaugeArc21.RangeStart = 100.0R
            Me.radialGaugeArc21.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc21.Width = 14.0R
            ' 
            ' radialGaugeLabels7
            ' 
            Me.radialGaugeLabels7.DrawText = False
            Me.radialGaugeLabels7.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeLabels7.LabelFontSize = 6.0F
            Me.radialGaugeLabels7.LabelRadiusPercentage = 55.0F
            Me.radialGaugeLabels7.LabelsCount = 2
            Me.radialGaugeLabels7.Name = "radialGaugeLabels7"
            Me.radialGaugeLabels7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks17
            ' 
            Me.radialGaugeTicks17.DrawText = False
            Me.radialGaugeTicks17.Name = "radialGaugeTicks17"
            Me.radialGaugeTicks17.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeTicks17.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks17.TicksCount = 16
            Me.radialGaugeTicks17.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks17.TicksOffset = 0
            Me.radialGaugeTicks17.TicksRadiusPercentage = 64.0F
            Me.radialGaugeTicks17.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks17.TickThickness = 1.0F
            Me.radialGaugeTicks17.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge10
            ' 

            Me.radRadialGauge10.BackColor = System.Drawing.Color.White
            Me.radRadialGauge10.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc17, Me.radialGaugeArc18, Me.radialGaugeArc19, Me.radialGaugeTicks16, Me.radialGaugeLabels6, Me.radialGaugeNeedle10})
            Me.radRadialGauge10.Location = New System.Drawing.Point(13, 428)
            Me.radRadialGauge10.Name = "radRadialGauge10"
            Me.radRadialGauge10.RangeEnd = 180.0R
            Me.radRadialGauge10.RangeStart = 0.0R
            Me.radRadialGauge10.Size = New System.Drawing.Size(210, 198)
            Me.radRadialGauge10.StartAngle = 130.0R
            Me.radRadialGauge10.SweepAngle = 280.0R
            Me.radRadialGauge10.TabIndex = 6
            Me.radRadialGauge10.Text = "radRadialGauge1"
            Me.radRadialGauge10.Value = 90.0F
            ' 
            ' radialGaugeArc17
            ' 
            Me.radialGaugeArc17.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(92))))), (CInt(Fix((CByte(92))))), (CInt(Fix((CByte(92))))))
            Me.radialGaugeArc17.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(92))))), (CInt(Fix((CByte(92))))), (CInt(Fix((CByte(92))))))
            Me.radialGaugeArc17.Name = "radialGaugeArc17"
            Me.radialGaugeArc17.Radius = 0.0R
            Me.radialGaugeArc17.RangeEnd = 60.0R
            Me.radialGaugeArc17.RangeStart = 0.0R
            Me.radialGaugeArc17.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc17.Width = 4.0R
            ' 
            ' radialGaugeArc18
            ' 
            Me.radialGaugeArc18.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeArc18.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeArc18.Name = "radialGaugeArc18"
            Me.radialGaugeArc18.Radius = 0.0R
            Me.radialGaugeArc18.RangeEnd = 120.0R
            Me.radialGaugeArc18.RangeStart = 61.0R
            Me.radialGaugeArc18.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc18.Width = 4.0R
            ' 
            ' radialGaugeArc19
            ' 
            Me.radialGaugeArc19.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(205))))), (CInt(Fix((CByte(47))))), (CInt(Fix((CByte(47))))))
            Me.radialGaugeArc19.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(205))))), (CInt(Fix((CByte(47))))), (CInt(Fix((CByte(47))))))
            Me.radialGaugeArc19.Name = "radialGaugeArc19"
            Me.radialGaugeArc19.Radius = 0.0R
            Me.radialGaugeArc19.RangeEnd = 180.0R
            Me.radialGaugeArc19.RangeStart = 121.0R
            Me.radialGaugeArc19.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc19.Width = 4.0R
            ' 
            ' radialGaugeTicks16
            ' 
            Me.radialGaugeTicks16.DrawText = False
            Me.radialGaugeTicks16.Name = "radialGaugeTicks16"
            Me.radialGaugeTicks16.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks16.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks16.TicksCount = 18
            Me.radialGaugeTicks16.TicksLenghtPercentage = 4.0F
            Me.radialGaugeTicks16.TicksOffset = 0
            Me.radialGaugeTicks16.TicksRadiusPercentage = 83.0F
            Me.radialGaugeTicks16.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks16.TickThickness = 1.0F
            Me.radialGaugeTicks16.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels6
            ' 
            Me.radialGaugeLabels6.DrawText = False
            Me.radialGaugeLabels6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels6.LabelFontSize = 5.0F
            Me.radialGaugeLabels6.LabelRadiusPercentage = 68.0F
            Me.radialGaugeLabels6.LabelsCount = 9
            Me.radialGaugeLabels6.Name = "radialGaugeLabels6"
            Me.radialGaugeLabels6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle10
            ' 
            Me.radialGaugeNeedle10.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(205))))), (CInt(Fix((CByte(47))))), (CInt(Fix((CByte(47))))))
            Me.radialGaugeNeedle10.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(205))))), (CInt(Fix((CByte(47))))), (CInt(Fix((CByte(47))))))
            Me.radialGaugeNeedle10.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle10.BindValue = True
            Me.radialGaugeNeedle10.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle10.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle10.Name = "radialGaugeNeedle10"
            Me.radialGaugeNeedle10.PointRadiusPercentage = 7.0R
            Me.radialGaugeNeedle10.Thickness = 1.5R
            Me.radialGaugeNeedle10.Value = 90.0F
            Me.radialGaugeNeedle10.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge9
            ' 

            Me.radRadialGauge9.BackColor = System.Drawing.Color.White
            Me.radRadialGauge9.CausesValidation = False
            Me.radRadialGauge9.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc14, Me.radialGaugeArc15, Me.radialGaugeArc16, Me.radialGaugeTicks12, Me.radialGaugeTicks13, Me.radialGaugeNeedle9, Me.radialGaugeTicks14, Me.radialGaugeTicks15})
            Me.radRadialGauge9.Location = New System.Drawing.Point(668, 211)
            Me.radRadialGauge9.Name = "radRadialGauge9"
            Me.radRadialGauge9.RangeEnd = 100.0R
            Me.radRadialGauge9.RangeStart = 0.0R
            Me.radRadialGauge9.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge9.StartAngle = 180.0R
            Me.radRadialGauge9.SweepAngle = 360.0R
            Me.radRadialGauge9.TabIndex = 6
            Me.radRadialGauge9.Text = "radRadialGauge1"
            Me.radRadialGauge9.Value = 36.0F
            ' 
            ' radialGaugeArc14
            ' 
            Me.radialGaugeArc14.BackColor = System.Drawing.Color.Black
            Me.radialGaugeArc14.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc14.Name = "radialGaugeArc14"
            Me.radialGaugeArc14.Radius = 88.0R
            Me.radialGaugeArc14.RangeEnd = 33.0R
            Me.radialGaugeArc14.RangeStart = 0.0R
            Me.radialGaugeArc14.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc14.Width = 14.0R
            ' 
            ' radialGaugeArc15
            ' 
            Me.radialGaugeArc15.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))))
            Me.radialGaugeArc15.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))))
            Me.radialGaugeArc15.Name = "radialGaugeArc15"
            Me.radialGaugeArc15.Radius = 88.0R
            Me.radialGaugeArc15.RangeEnd = 100.0R
            Me.radialGaugeArc15.RangeStart = 33.0R
            Me.radialGaugeArc15.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc15.Width = 14.0R
            ' 
            ' radialGaugeArc16
            ' 
            Me.radialGaugeArc16.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(112))))))
            Me.radialGaugeArc16.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(112))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(112))))))
            Me.radialGaugeArc16.BindEndRange = True
            Me.radialGaugeArc16.Name = "radialGaugeArc16"
            Me.radialGaugeArc16.Radius = 70.0R
            Me.radialGaugeArc16.RangeEnd = 36.0R
            Me.radialGaugeArc16.RangeStart = 0.0R
            Me.radialGaugeArc16.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc16.Width = 4.0R
            ' 
            ' radialGaugeTicks12
            ' 
            Me.radialGaugeTicks12.DrawText = False
            Me.radialGaugeTicks12.Name = "radialGaugeTicks12"
            Me.radialGaugeTicks12.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))))
            Me.radialGaugeTicks12.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks12.TicksCount = 24
            Me.radialGaugeTicks12.TicksLenghtPercentage = 8.0F
            Me.radialGaugeTicks12.TicksOffset = 0
            Me.radialGaugeTicks12.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks12.TickThickness = 1.0F
            Me.radialGaugeTicks12.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks13
            ' 
            Me.radialGaugeTicks13.DrawText = False
            Me.radialGaugeTicks13.Name = "radialGaugeTicks13"
            Me.radialGaugeTicks13.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))))
            Me.radialGaugeTicks13.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks13.TicksCount = 72
            Me.radialGaugeTicks13.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks13.TicksOffset = 0
            Me.radialGaugeTicks13.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks13.TickThickness = 1.0F
            Me.radialGaugeTicks13.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle9
            ' 
            Me.radialGaugeNeedle9.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle9.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle9.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle9.BindValue = True
            Me.radialGaugeNeedle9.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle9.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle9.Name = "radialGaugeNeedle9"
            Me.radialGaugeNeedle9.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle9.Thickness = 0.4R
            Me.radialGaugeNeedle9.Value = 36.0F
            Me.radialGaugeNeedle9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks14
            ' 
            Me.radialGaugeTicks14.DrawText = False
            Me.radialGaugeTicks14.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks14.Name = "radialGaugeTicks14"
            Me.radialGaugeTicks14.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks14.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks14.TicksCount = 1
            Me.radialGaugeTicks14.TicksLenghtPercentage = 14.0F
            Me.radialGaugeTicks14.TicksOffset = 0
            Me.radialGaugeTicks14.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks14.TickThickness = 1.0F
            Me.radialGaugeTicks14.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks15
            ' 
            Me.radialGaugeTicks15.CircleTicks = True
            Me.radialGaugeTicks15.DrawText = False
            Me.radialGaugeTicks15.Name = "radialGaugeTicks15"
            Me.radialGaugeTicks15.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks15.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks15.TicksCount = 1
            Me.radialGaugeTicks15.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks15.TicksOffset = 0
            Me.radialGaugeTicks15.TicksRadiusPercentage = 106.0F
            Me.radialGaugeTicks15.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks15.TickThickness = 1.0F
            Me.radialGaugeTicks15.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge8
            ' 

            Me.radRadialGauge8.BackColor = System.Drawing.Color.White
            Me.radRadialGauge8.CausesValidation = False
            Me.radRadialGauge8.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc12, Me.radialGaugeArc13, Me.radialGaugeNeedle8, Me.radialGaugeLabels5, Me.radialGaugeSingleLabel3})
            Me.radRadialGauge8.Location = New System.Drawing.Point(447, 211)
            Me.radRadialGauge8.Name = "radRadialGauge8"
            Me.radRadialGauge8.RangeEnd = 50.0R
            Me.radRadialGauge8.RangeStart = 0.0R
            Me.radRadialGauge8.Size = New System.Drawing.Size(214, 201)
            Me.radRadialGauge8.StartAngle = 205.0R
            Me.radRadialGauge8.SweepAngle = 130.0R
            Me.radRadialGauge8.TabIndex = 6
            Me.radRadialGauge8.Text = "radRadialGauge1"
            Me.radRadialGauge8.Value = 33.0F
            ' 
            ' radialGaugeArc12
            ' 
            Me.radialGaugeArc12.BackColor = System.Drawing.Color.Black
            Me.radialGaugeArc12.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc12.BindEndRange = True
            Me.radialGaugeArc12.Name = "radialGaugeArc12"
            Me.radialGaugeArc12.Radius = 0.0R
            Me.radialGaugeArc12.RangeEnd = 33.0R
            Me.radialGaugeArc12.RangeStart = 0.0R
            Me.radialGaugeArc12.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc12.Width = 40.0R
            ' 
            ' radialGaugeArc13
            ' 
            Me.radialGaugeArc13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))))
            Me.radialGaugeArc13.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))))
            Me.radialGaugeArc13.BindStartRange = True
            Me.radialGaugeArc13.Name = "radialGaugeArc13"
            Me.radialGaugeArc13.Radius = 0.0R
            Me.radialGaugeArc13.RangeEnd = 50.0R
            Me.radialGaugeArc13.RangeStart = 33.0R
            Me.radialGaugeArc13.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc13.Width = 40.0R
            ' 
            ' radialGaugeNeedle8
            ' 
            Me.radialGaugeNeedle8.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(40))))), (CInt(Fix((CByte(40))))))
            Me.radialGaugeNeedle8.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(40))))), (CInt(Fix((CByte(40))))))
            Me.radialGaugeNeedle8.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle8.BindValue = True
            Me.radialGaugeNeedle8.InnerPointRadiusPercentage = 4.0R
            Me.radialGaugeNeedle8.LenghtPercentage = 115.0R
            Me.radialGaugeNeedle8.Name = "radialGaugeNeedle8"
            Me.radialGaugeNeedle8.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle8.Thickness = 0.7R
            Me.radialGaugeNeedle8.Value = 33.0F
            Me.radialGaugeNeedle8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels5
            ' 
            Me.radialGaugeLabels5.DrawText = False
            Me.radialGaugeLabels5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels5.LabelFontSize = 5.0F
            Me.radialGaugeLabels5.LabelRadiusPercentage = 112.0F
            Me.radialGaugeLabels5.LabelsCount = 1
            Me.radialGaugeLabels5.Name = "radialGaugeLabels5"
            Me.radialGaugeLabels5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel3
            ' 
            Me.radialGaugeSingleLabel3.BindValue = True
            Me.radialGaugeSingleLabel3.LabelFontSize = 11.0F
            Me.radialGaugeSingleLabel3.LabelFormat = "#0#.00##"
            Me.radialGaugeSingleLabel3.LabelText = "Text"
            Me.radialGaugeSingleLabel3.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.25F)
            Me.radialGaugeSingleLabel3.Name = "radialGaugeSingleLabel3"
            Me.radialGaugeSingleLabel3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge5
            ' 

            Me.radRadialGauge5.BackColor = System.Drawing.Color.White
            Me.radRadialGauge5.CausesValidation = False
            Me.radRadialGauge5.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc6, Me.radialGaugeArc7, Me.radialGaugeLabels4, Me.radialGaugeTicks11, Me.radialGaugeSingleLabel1})
            Me.radRadialGauge5.Location = New System.Drawing.Point(4, 211)
            Me.radRadialGauge5.Name = "radRadialGauge5"
            Me.radRadialGauge5.RangeEnd = 180.0R
            Me.radRadialGauge5.RangeStart = 0.0R
            Me.radRadialGauge5.Size = New System.Drawing.Size(229, 210)
            Me.radRadialGauge5.StartAngle = 120.0R
            Me.radRadialGauge5.SweepAngle = 300.0R
            Me.radRadialGauge5.TabIndex = 6
            Me.radRadialGauge5.Text = "radRadialGauge1"
            Me.radRadialGauge5.Value = 90.0F
            ' 
            ' radialGaugeArc6
            ' 
            Me.radialGaugeArc6.BackColor = System.Drawing.Color.Black
            Me.radialGaugeArc6.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc6.Name = "radialGaugeArc6"
            Me.radialGaugeArc6.Radius = 80.0R
            Me.radialGaugeArc6.RangeEnd = 0.0R
            Me.radialGaugeArc6.RangeStart = 120.0R
            Me.radialGaugeArc6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc6.Width = 15.0R
            ' 
            ' radialGaugeArc7
            ' 
            Me.radialGaugeArc7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(181))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(181))))))
            Me.radialGaugeArc7.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc7.Name = "radialGaugeArc7"
            Me.radialGaugeArc7.Radius = 80.0R
            Me.radialGaugeArc7.RangeEnd = 180.0R
            Me.radialGaugeArc7.RangeStart = 120.0R
            Me.radialGaugeArc7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc7.Width = 15.0R
            ' 
            ' radialGaugeLabels4
            ' 
            Me.radialGaugeLabels4.DrawText = False
            Me.radialGaugeLabels4.LabelFontSize = 5.0F
            Me.radialGaugeLabels4.LabelRadiusPercentage = 108.0F
            Me.radialGaugeLabels4.LabelsCount = 9
            Me.radialGaugeLabels4.Name = "radialGaugeLabels4"
            Me.radialGaugeLabels4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks11
            ' 
            Me.radialGaugeTicks11.CircleTicks = True
            Me.radialGaugeTicks11.DrawText = False
            Me.radialGaugeTicks11.Name = "radialGaugeTicks11"
            Me.radialGaugeTicks11.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(109))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(109))))))
            Me.radialGaugeTicks11.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks11.TicksCount = 18
            Me.radialGaugeTicks11.TicksLenghtPercentage = 1.0F
            Me.radialGaugeTicks11.TicksOffset = 4
            Me.radialGaugeTicks11.TicksRadiusPercentage = 95.0F
            Me.radialGaugeTicks11.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks11.TickThickness = 1.0F
            Me.radialGaugeTicks11.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel1
            ' 
            Me.radialGaugeSingleLabel1.BindValue = True
            Me.radialGaugeSingleLabel1.ForeColor = System.Drawing.Color.Black
            Me.radialGaugeSingleLabel1.LabelFontSize = 9.0F
            Me.radialGaugeSingleLabel1.LabelText = "Text"
            Me.radialGaugeSingleLabel1.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.0F)
            Me.radialGaugeSingleLabel1.Name = "radialGaugeSingleLabel1"
            Me.radialGaugeSingleLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge4
            ' 

            Me.radRadialGauge4.BackColor = System.Drawing.Color.White
            Me.radRadialGauge4.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc5, Me.radialGaugeTicks9, Me.radialGaugeTicks10, Me.radialGaugeNeedle5, Me.radialGaugeNeedle6})
            Me.radRadialGauge4.Location = New System.Drawing.Point(661, 4)
            Me.radRadialGauge4.Name = "radRadialGauge4"
            Me.radRadialGauge4.RangeEnd = 100.0R
            Me.radRadialGauge4.RangeStart = 0.0R
            Me.radRadialGauge4.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge4.StartAngle = 0.0R
            Me.radRadialGauge4.SweepAngle = 360.0R
            Me.radRadialGauge4.TabIndex = 6
            Me.radRadialGauge4.Text = "radRadialGauge1"
            Me.radRadialGauge4.Value = 90.0F
            ' 
            ' radialGaugeArc5
            ' 
            Me.radialGaugeArc5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc5.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc5.Name = "radialGaugeArc5"
            Me.radialGaugeArc5.Radius = 0.0R
            Me.radialGaugeArc5.RangeEnd = 100.0R
            Me.radialGaugeArc5.RangeStart = 0.0R
            Me.radialGaugeArc5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc5.Width = 2.0R
            ' 
            ' radialGaugeTicks9
            ' 
            Me.radialGaugeTicks9.DrawText = False
            Me.radialGaugeTicks9.Name = "radialGaugeTicks9"
            Me.radialGaugeTicks9.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks9.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks9.TicksCount = 24
            Me.radialGaugeTicks9.TicksLenghtPercentage = 2.0F
            Me.radialGaugeTicks9.TicksOffset = 6
            Me.radialGaugeTicks9.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks9.TickThickness = 1.0F
            Me.radialGaugeTicks9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks10
            ' 
            Me.radialGaugeTicks10.DrawText = False
            Me.radialGaugeTicks10.Name = "radialGaugeTicks10"
            Me.radialGaugeTicks10.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks10.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks10.TicksCount = 72
            Me.radialGaugeTicks10.TicksLenghtPercentage = 1.0F
            Me.radialGaugeTicks10.TicksOffset = 1
            Me.radialGaugeTicks10.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks10.TickThickness = 1.0F
            Me.radialGaugeTicks10.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle5
            ' 
            Me.radialGaugeNeedle5.BackColor = System.Drawing.Color.Black
            Me.radialGaugeNeedle5.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeNeedle5.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle5.BindValue = True
            Me.radialGaugeNeedle5.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle5.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle5.Name = "radialGaugeNeedle5"
            Me.radialGaugeNeedle5.PointRadiusPercentage = 4.0R
            Me.radialGaugeNeedle5.Thickness = 1.0R
            Me.radialGaugeNeedle5.Value = 90.0F
            Me.radialGaugeNeedle5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle6
            ' 
            Me.radialGaugeNeedle6.BackColor = System.Drawing.Color.Black
            Me.radialGaugeNeedle6.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeNeedle6.BackLenghtPercentage = -55.0R
            Me.radialGaugeNeedle6.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle6.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle6.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle6.Name = "radialGaugeNeedle6"
            Me.radialGaugeNeedle6.PointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle6.Thickness = 8.0R
            Me.radialGaugeNeedle6.Value = 60.0F
            Me.radialGaugeNeedle6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge1
            ' 

            Me.radRadialGauge1.BackColor = System.Drawing.Color.White
            Me.radRadialGauge1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc1, Me.radialGaugeArc2, Me.radialGaugeTicks1, Me.radialGaugeTicks2, Me.radialGaugeTicks3, Me.radialGaugeTicks4, Me.radialGaugeLabels1, Me.radialGaugeLabels2, Me.radialGaugeNeedle1, Me.radialGaugeNeedle2})
            Me.radRadialGauge1.Location = New System.Drawing.Point(4, 4)
            Me.radRadialGauge1.Name = "radRadialGauge1"
            Me.radRadialGauge1.RangeEnd = 180.0R
            Me.radRadialGauge1.RangeStart = 0.0R
            Me.radRadialGauge1.Size = New System.Drawing.Size(229, 200)
            Me.radRadialGauge1.StartAngle = 120.0R
            Me.radRadialGauge1.SweepAngle = 300.0R
            Me.radRadialGauge1.TabIndex = 1
            Me.radRadialGauge1.Text = "radRadialGauge2"
            Me.radRadialGauge1.Value = 90.0F
            ' 
            ' radialGaugeArc1
            ' 
            Me.radialGaugeArc1.BackColor = System.Drawing.Color.Black
            Me.radialGaugeArc1.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc1.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc1.Name = "radialGaugeArc1"
            Me.radialGaugeArc1.Radius = 0.0R
            Me.radialGaugeArc1.RangeEnd = 120.0R
            Me.radialGaugeArc1.RangeStart = 0.0R
            Me.radialGaugeArc1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc1.Width = 2.0R
            ' 
            ' radialGaugeArc2
            ' 
            Me.radialGaugeArc2.BackColor = System.Drawing.Color.Black
            Me.radialGaugeArc2.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc2.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc2.Name = "radialGaugeArc2"
            Me.radialGaugeArc2.Radius = 0.0R
            Me.radialGaugeArc2.RangeEnd = 180.0R
            Me.radialGaugeArc2.RangeStart = 120.0R
            Me.radialGaugeArc2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc2.Width = 2.0R
            ' 
            ' radialGaugeTicks1
            ' 
            Me.radialGaugeTicks1.DrawText = False
            Me.radialGaugeTicks1.Name = "radialGaugeTicks1"
            Me.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks1.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks1.TicksCount = 18
            Me.radialGaugeTicks1.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks1.TicksOffset = 0
            Me.radialGaugeTicks1.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks1.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks1.TickThickness = 1.0F
            Me.radialGaugeTicks1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks2
            ' 
            Me.radialGaugeTicks2.DrawText = False
            Me.radialGaugeTicks2.Name = "radialGaugeTicks2"
            Me.radialGaugeTicks2.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks2.TickEndIndexVisibleRange = 35.0F
            Me.radialGaugeTicks2.TicksCount = 54
            Me.radialGaugeTicks2.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks2.TicksOffset = 0
            Me.radialGaugeTicks2.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks2.TickThickness = 1.0F
            Me.radialGaugeTicks2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks3
            ' 
            Me.radialGaugeTicks3.DrawText = False
            Me.radialGaugeTicks3.Name = "radialGaugeTicks3"
            Me.radialGaugeTicks3.TickColor = System.Drawing.Color.Black
            Me.radialGaugeTicks3.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks3.TicksCount = 18
            Me.radialGaugeTicks3.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks3.TicksOffset = 0
            Me.radialGaugeTicks3.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks3.TickStartIndexVisibleRange = 12.0F
            Me.radialGaugeTicks3.TickThickness = 1.0F
            Me.radialGaugeTicks3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks4
            ' 
            Me.radialGaugeTicks4.DrawText = False
            Me.radialGaugeTicks4.Name = "radialGaugeTicks4"
            Me.radialGaugeTicks4.TickColor = System.Drawing.Color.Black
            Me.radialGaugeTicks4.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks4.TicksCount = 54
            Me.radialGaugeTicks4.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks4.TicksOffset = 0
            Me.radialGaugeTicks4.TickStartIndexVisibleRange = 37.0F
            Me.radialGaugeTicks4.TickThickness = 1.0F
            Me.radialGaugeTicks4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels1
            ' 
            Me.radialGaugeLabels1.DrawText = False
            Me.radialGaugeLabels1.LabelEndVisibleRange = 100.0F
            Me.radialGaugeLabels1.LabelFontSize = 4.0F
            Me.radialGaugeLabels1.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels1.LabelsCount = 9
            Me.radialGaugeLabels1.Name = "radialGaugeLabels1"
            Me.radialGaugeLabels1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels2
            ' 
            Me.radialGaugeLabels2.DrawText = False
            Me.radialGaugeLabels2.ForeColor = System.Drawing.Color.Black
            Me.radialGaugeLabels2.LabelFontSize = 4.0F
            Me.radialGaugeLabels2.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels2.LabelsCount = 9
            Me.radialGaugeLabels2.LabelStartVisibleRange = 120.0F
            Me.radialGaugeLabels2.Name = "radialGaugeLabels2"
            Me.radialGaugeLabels2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle1
            ' 
            Me.radialGaugeNeedle1.BackColor = System.Drawing.Color.Black
            Me.radialGaugeNeedle1.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeNeedle1.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle1.BindValue = True
            Me.radialGaugeNeedle1.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle1.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle1.Name = "radialGaugeNeedle1"
            Me.radialGaugeNeedle1.PointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle1.Thickness = 2.0R
            Me.radialGaugeNeedle1.Value = 90.0F
            Me.radialGaugeNeedle1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle2
            ' 
            Me.radialGaugeNeedle2.BackColor = System.Drawing.Color.Black
            Me.radialGaugeNeedle2.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeNeedle2.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle2.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle2.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle2.Name = "radialGaugeNeedle2"
            Me.radialGaugeNeedle2.PointRadiusPercentage = 6.0R
            Me.radialGaugeNeedle2.Thickness = 2.0R
            Me.radialGaugeNeedle2.Value = 90.0F
            Me.radialGaugeNeedle2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge6
            ' 

            Me.radRadialGauge6.BackColor = System.Drawing.Color.White
            Me.radRadialGauge6.CausesValidation = False
            Me.radRadialGauge6.Controls.Add(Me.radRadialGauge7)
            Me.radRadialGauge6.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc8, Me.radialGaugeArc9, Me.radialGaugeSingleLabel2})
            Me.radRadialGauge6.Location = New System.Drawing.Point(240, 211)
            Me.radRadialGauge6.Name = "radRadialGauge6"
            Me.radRadialGauge6.RangeEnd = 100.0R
            Me.radRadialGauge6.RangeStart = 0.0R
            Me.radRadialGauge6.Size = New System.Drawing.Size(204, 210)
            Me.radRadialGauge6.StartAngle = 180.0R
            Me.radRadialGauge6.SweepAngle = 180.0R
            Me.radRadialGauge6.TabIndex = 6
            Me.radRadialGauge6.Text = "radRadialGauge1"
            Me.radRadialGauge6.Value = 60.0F
            ' 
            ' radRadialGauge7
            ' 

            Me.radRadialGauge7.BackColor = System.Drawing.Color.White
            Me.radRadialGauge7.CausesValidation = False
            Me.radRadialGauge7.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc10, Me.radialGaugeArc11, Me.radialGaugeNeedle7})
            Me.radRadialGauge7.Location = New System.Drawing.Point(1, 100)
            Me.radRadialGauge7.Name = "radRadialGauge7"
            Me.radRadialGauge7.RangeEnd = 100.0R
            Me.radRadialGauge7.RangeStart = 0.0R
            Me.radRadialGauge7.Size = New System.Drawing.Size(200, 208)
            Me.radRadialGauge7.StartAngle = 180.0R
            Me.radRadialGauge7.SweepAngle = 180.0R
            Me.radRadialGauge7.TabIndex = 6
            Me.radRadialGauge7.Text = "radRadialGauge1"
            Me.radRadialGauge7.Value = 80.0F
            ' 
            ' radialGaugeArc10
            ' 
            Me.radialGaugeArc10.BackColor = System.Drawing.Color.Black
            Me.radialGaugeArc10.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc10.BindEndRange = True
            Me.radialGaugeArc10.Name = "radialGaugeArc10"
            Me.radialGaugeArc10.Radius = 0.0R
            Me.radialGaugeArc10.RangeEnd = 80.0R
            Me.radialGaugeArc10.RangeStart = 0.0R
            Me.radialGaugeArc10.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc10.Width = 40.0R
            ' 
            ' radialGaugeArc11
            ' 
            Me.radialGaugeArc11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc11.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc11.BindStartRange = True
            Me.radialGaugeArc11.Name = "radialGaugeArc11"
            Me.radialGaugeArc11.Radius = 0.0R
            Me.radialGaugeArc11.RangeEnd = 100.0R
            Me.radialGaugeArc11.RangeStart = 80.0R
            Me.radialGaugeArc11.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc11.Width = 40.0R
            ' 
            ' radialGaugeNeedle7
            ' 
            Me.radialGaugeNeedle7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(40))))), (CInt(Fix((CByte(40))))))
            Me.radialGaugeNeedle7.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(40))))), (CInt(Fix((CByte(40))))))
            Me.radialGaugeNeedle7.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle7.BindValue = True
            Me.radialGaugeNeedle7.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle7.LenghtPercentage = 94.0R
            Me.radialGaugeNeedle7.Name = "radialGaugeNeedle7"
            Me.radialGaugeNeedle7.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle7.Thickness = 5.0R
            Me.radialGaugeNeedle7.Value = 80.0F
            Me.radialGaugeNeedle7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeArc8
            ' 
            Me.radialGaugeArc8.BackColor = System.Drawing.Color.Black
            Me.radialGaugeArc8.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc8.BindEndRange = True
            Me.radialGaugeArc8.Name = "radialGaugeArc8"
            Me.radialGaugeArc8.Radius = 0.0R
            Me.radialGaugeArc8.RangeEnd = 60.0R
            Me.radialGaugeArc8.RangeStart = 0.0R
            Me.radialGaugeArc8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc8.Width = 40.0R
            ' 
            ' radialGaugeArc9
            ' 
            Me.radialGaugeArc9.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc9.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc9.BindStartRange = True
            Me.radialGaugeArc9.Name = "radialGaugeArc9"
            Me.radialGaugeArc9.Radius = 0.0R
            Me.radialGaugeArc9.RangeEnd = 100.0R
            Me.radialGaugeArc9.RangeStart = 60.0R
            Me.radialGaugeArc9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc9.Width = 40.0R
            ' 
            ' radialGaugeSingleLabel2
            ' 
            Me.radialGaugeSingleLabel2.BindValue = True
            Me.radialGaugeSingleLabel2.ForeColor = System.Drawing.Color.Black
            Me.radialGaugeSingleLabel2.LabelFontSize = 10.0F
            Me.radialGaugeSingleLabel2.LabelText = "Text"
            Me.radialGaugeSingleLabel2.LocationPercentage = New System.Drawing.SizeF(0.0F, -0.2F)
            Me.radialGaugeSingleLabel2.Name = "radialGaugeSingleLabel2"
            Me.radialGaugeSingleLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge2
            ' 

            Me.radRadialGauge2.BackColor = System.Drawing.Color.White
            Me.radRadialGauge2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc3, Me.radialGaugeNeedle3, Me.radialGaugeTicks5, Me.radialGaugeTicks6, Me.radialGaugeTicks7})
            Me.radRadialGauge2.Location = New System.Drawing.Point(241, 4)
            Me.radRadialGauge2.Name = "radRadialGauge2"
            Me.radRadialGauge2.RangeEnd = 100.0R
            Me.radRadialGauge2.RangeStart = 0.0R
            Me.radRadialGauge2.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge2.StartAngle = 180.0R
            Me.radRadialGauge2.SweepAngle = 180.0R
            Me.radRadialGauge2.TabIndex = 3
            Me.radRadialGauge2.Text = "radRadialGauge4"
            Me.radRadialGauge2.Value = 90.0F
            ' 
            ' radialGaugeArc3
            ' 
            Me.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc3.Name = "radialGaugeArc3"
            Me.radialGaugeArc3.Radius = 0.0R
            Me.radialGaugeArc3.RangeEnd = 100.0R
            Me.radialGaugeArc3.RangeStart = 0.0R
            Me.radialGaugeArc3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc3.Width = 1.0R
            ' 
            ' radialGaugeNeedle3
            ' 
            Me.radialGaugeNeedle3.BackColor = System.Drawing.Color.Black
            Me.radialGaugeNeedle3.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeNeedle3.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle3.BindValue = True
            Me.radialGaugeNeedle3.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle3.LenghtPercentage = 80.0R
            Me.radialGaugeNeedle3.Name = "radialGaugeNeedle3"
            Me.radialGaugeNeedle3.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle3.Thickness = 5.0R
            Me.radialGaugeNeedle3.Value = 90.0F
            Me.radialGaugeNeedle3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks5
            ' 
            Me.radialGaugeTicks5.DrawText = False
            Me.radialGaugeTicks5.Name = "radialGaugeTicks5"
            Me.radialGaugeTicks5.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks5.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks5.TicksCount = 12
            Me.radialGaugeTicks5.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks5.TicksOffset = 5
            Me.radialGaugeTicks5.TickStartIndexVisibleRange = 1.0F
            Me.radialGaugeTicks5.TickThickness = 1.0F
            Me.radialGaugeTicks5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks6
            ' 
            Me.radialGaugeTicks6.DrawText = False
            Me.radialGaugeTicks6.Name = "radialGaugeTicks6"
            Me.radialGaugeTicks6.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks6.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks6.TicksCount = 36
            Me.radialGaugeTicks6.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks6.TicksOffset = 0
            Me.radialGaugeTicks6.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks6.TickThickness = 1.0F
            Me.radialGaugeTicks6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks7
            ' 
            Me.radialGaugeTicks7.DrawText = False
            Me.radialGaugeTicks7.Name = "radialGaugeTicks7"
            Me.radialGaugeTicks7.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks7.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks7.TicksCount = 1
            Me.radialGaugeTicks7.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks7.TicksOffset = 0
            Me.radialGaugeTicks7.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks7.TickThickness = 1.0F
            Me.radialGaugeTicks7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge3
            ' 

            Me.radRadialGauge3.BackColor = System.Drawing.Color.White
            Me.radRadialGauge3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc4, Me.radialGaugeTicks8, Me.radialGaugeNeedle4, Me.radialGaugeLabels3})
            Me.radRadialGauge3.Location = New System.Drawing.Point(447, 4)
            Me.radRadialGauge3.Name = "radRadialGauge3"
            Me.radRadialGauge3.RangeEnd = 100.0R
            Me.radRadialGauge3.RangeStart = 50.0R
            Me.radRadialGauge3.Size = New System.Drawing.Size(207, 200)
            Me.radRadialGauge3.StartAngle = 270.0R
            Me.radRadialGauge3.SweepAngle = 90.0R
            Me.radRadialGauge3.TabIndex = 6
            Me.radRadialGauge3.Text = "radRadialGauge1"
            Me.radRadialGauge3.Value = 90.0F
            ' 
            ' radialGaugeArc4
            ' 
            Me.radialGaugeArc4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))))
            Me.radialGaugeArc4.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))))
            Me.radialGaugeArc4.Name = "radialGaugeArc4"
            Me.radialGaugeArc4.Radius = 90.0R
            Me.radialGaugeArc4.RangeEnd = 100.0R
            Me.radialGaugeArc4.RangeStart = 0.0R
            Me.radialGaugeArc4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc4.Width = 1.0R
            ' 
            ' radialGaugeTicks8
            ' 
            Me.radialGaugeTicks8.CircleTicks = True
            Me.radialGaugeTicks8.DrawText = False
            Me.radialGaugeTicks8.Name = "radialGaugeTicks8"
            Me.radialGaugeTicks8.TickColor = System.Drawing.Color.Black
            Me.radialGaugeTicks8.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks8.TicksCount = 6
            Me.radialGaugeTicks8.TicksLenghtPercentage = 2.0F
            Me.radialGaugeTicks8.TicksOffset = 0
            Me.radialGaugeTicks8.TicksRadiusPercentage = 89.0F
            Me.radialGaugeTicks8.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks8.TickThickness = 1.0F
            Me.radialGaugeTicks8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle4
            ' 
            Me.radialGaugeNeedle4.BackColor = System.Drawing.Color.Red
            Me.radialGaugeNeedle4.BackColor2 = System.Drawing.Color.Red
            Me.radialGaugeNeedle4.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle4.BindValue = True
            Me.radialGaugeNeedle4.InnerPointRadiusPercentage = 1.0R
            Me.radialGaugeNeedle4.LenghtPercentage = 120.0R
            Me.radialGaugeNeedle4.Name = "radialGaugeNeedle4"
            Me.radialGaugeNeedle4.PointRadiusPercentage = 3.0R
            Me.radialGaugeNeedle4.Thickness = 1.0R
            Me.radialGaugeNeedle4.Value = 90.0F
            Me.radialGaugeNeedle4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels3
            ' 
            Me.radialGaugeLabels3.DrawText = False
            Me.radialGaugeLabels3.LabelFontSize = 5.0F
            Me.radialGaugeLabels3.LabelRadiusPercentage = 105.0F
            Me.radialGaugeLabels3.LabelsCount = 1
            Me.radialGaugeLabels3.Name = "radialGaugeLabels3"
            Me.radialGaugeLabels3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radPanel2
            ' 
            Me.radPanel2.BackColor = System.Drawing.Color.White
            Me.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel2.Location = New System.Drawing.Point(0, 0)
            Me.radPanel2.Name = "radPanel2"
            Me.radPanel2.Padding = New System.Windows.Forms.Padding(0)

            ' 
            ' radPanel2.PanelContainer
            ' 
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge22)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge21)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge20)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge19)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge17)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge16)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge14)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge13)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge12)
            Me.radPanel2.PanelContainer.Controls.Add(Me.radRadialGauge15)
            Me.radPanel2.PanelContainer.Location = New System.Drawing.Point(0, 0)
            Me.radPanel2.PanelContainer.Size = New System.Drawing.Size(1193, 828)
            Me.radPanel2.Size = New System.Drawing.Size(1193, 828)
            Me.radPanel2.TabIndex = 7
            CType(Me.radPanel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' radRadialGauge22
            ' 

            Me.radRadialGauge22.BackColor = System.Drawing.Color.White
            Me.radRadialGauge22.CausesValidation = False
            Me.radRadialGauge22.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc41, Me.radialGaugeArc42, Me.radialGaugeLabels14, Me.radialGaugeTicks34})
            Me.radRadialGauge22.Location = New System.Drawing.Point(258, 428)
            Me.radRadialGauge22.Name = "radRadialGauge22"
            Me.radRadialGauge22.RangeEnd = 180.0R
            Me.radRadialGauge22.RangeStart = 0.0R
            Me.radRadialGauge22.Size = New System.Drawing.Size(166, 164)
            Me.radRadialGauge22.StartAngle = 120.0R
            Me.radRadialGauge22.SweepAngle = 300.0R
            Me.radRadialGauge22.TabIndex = 6
            Me.radRadialGauge22.Text = "radRadialGauge1"
            Me.radRadialGauge22.Value = 100.0F
            ' 
            ' radialGaugeArc41
            ' 
            Me.radialGaugeArc41.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(163))))))
            Me.radialGaugeArc41.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(163))))))
            Me.radialGaugeArc41.BindEndRange = True
            Me.radialGaugeArc41.Name = "radialGaugeArc41"
            Me.radialGaugeArc41.Radius = 0.0R
            Me.radialGaugeArc41.RangeEnd = 100.0R
            Me.radialGaugeArc41.RangeStart = 0.0R
            Me.radialGaugeArc41.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc41.Width = 24.0R
            ' 
            ' radialGaugeArc42
            ' 
            Me.radialGaugeArc42.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc42.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc42.BindStartRange = True
            Me.radialGaugeArc42.Name = "radialGaugeArc42"
            Me.radialGaugeArc42.Radius = 87.0R
            Me.radialGaugeArc42.RangeEnd = 180.0R
            Me.radialGaugeArc42.RangeStart = 100.0R
            Me.radialGaugeArc42.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc42.Width = 14.0R
            ' 
            ' radialGaugeLabels14
            ' 
            Me.radialGaugeLabels14.DrawText = False
            Me.radialGaugeLabels14.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels14.LabelFontSize = 6.0F
            Me.radialGaugeLabels14.LabelRadiusPercentage = 55.0F
            Me.radialGaugeLabels14.LabelsCount = 2
            Me.radialGaugeLabels14.Name = "radialGaugeLabels14"
            Me.radialGaugeLabels14.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks34
            ' 
            Me.radialGaugeTicks34.DrawText = False
            Me.radialGaugeTicks34.Name = "radialGaugeTicks34"
            Me.radialGaugeTicks34.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks34.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks34.TicksCount = 16
            Me.radialGaugeTicks34.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks34.TicksOffset = 0
            Me.radialGaugeTicks34.TicksRadiusPercentage = 64.0F
            Me.radialGaugeTicks34.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks34.TickThickness = 1.0F
            Me.radialGaugeTicks34.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge21
            ' 

            Me.radRadialGauge21.BackColor = System.Drawing.Color.White
            Me.radRadialGauge21.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc38, Me.radialGaugeArc39, Me.radialGaugeArc40, Me.radialGaugeTicks33, Me.radialGaugeLabels13, Me.radialGaugeNeedle20})
            Me.radRadialGauge21.Location = New System.Drawing.Point(13, 428)
            Me.radRadialGauge21.Name = "radRadialGauge21"
            Me.radRadialGauge21.RangeEnd = 180.0R
            Me.radRadialGauge21.RangeStart = 0.0R
            Me.radRadialGauge21.Size = New System.Drawing.Size(210, 198)
            Me.radRadialGauge21.StartAngle = 130.0R
            Me.radRadialGauge21.SweepAngle = 280.0R
            Me.radRadialGauge21.TabIndex = 6
            Me.radRadialGauge21.Text = "radRadialGauge1"
            Me.radRadialGauge21.Value = 90.0F
            ' 
            ' radialGaugeArc38
            ' 
            Me.radialGaugeArc38.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(144))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(103))))))
            Me.radialGaugeArc38.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(144))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(103))))))
            Me.radialGaugeArc38.Name = "radialGaugeArc38"
            Me.radialGaugeArc38.Radius = 0.0R
            Me.radialGaugeArc38.RangeEnd = 60.0R
            Me.radialGaugeArc38.RangeStart = 0.0R
            Me.radialGaugeArc38.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc38.Width = 4.0R
            ' 
            ' radialGaugeArc39
            ' 
            Me.radialGaugeArc39.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc39.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc39.Name = "radialGaugeArc39"
            Me.radialGaugeArc39.Radius = 0.0R
            Me.radialGaugeArc39.RangeEnd = 120.0R
            Me.radialGaugeArc39.RangeStart = 61.0R
            Me.radialGaugeArc39.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc39.Width = 4.0R
            ' 
            ' radialGaugeArc40
            ' 
            Me.radialGaugeArc40.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeArc40.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeArc40.Name = "radialGaugeArc40"
            Me.radialGaugeArc40.Radius = 0.0R
            Me.radialGaugeArc40.RangeEnd = 180.0R
            Me.radialGaugeArc40.RangeStart = 121.0R
            Me.radialGaugeArc40.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc40.Width = 4.0R
            ' 
            ' radialGaugeTicks33
            ' 
            Me.radialGaugeTicks33.DrawText = False
            Me.radialGaugeTicks33.Name = "radialGaugeTicks33"
            Me.radialGaugeTicks33.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks33.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks33.TicksCount = 18
            Me.radialGaugeTicks33.TicksLenghtPercentage = 4.0F
            Me.radialGaugeTicks33.TicksOffset = 0
            Me.radialGaugeTicks33.TicksRadiusPercentage = 83.0F
            Me.radialGaugeTicks33.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks33.TickThickness = 1.0F
            Me.radialGaugeTicks33.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels13
            ' 
            Me.radialGaugeLabels13.DrawText = False
            Me.radialGaugeLabels13.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels13.LabelFontSize = 5.0F
            Me.radialGaugeLabels13.LabelRadiusPercentage = 68.0F
            Me.radialGaugeLabels13.LabelsCount = 9
            Me.radialGaugeLabels13.Name = "radialGaugeLabels13"
            Me.radialGaugeLabels13.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle20
            ' 
            Me.radialGaugeNeedle20.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeNeedle20.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeNeedle20.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle20.BindValue = True
            Me.radialGaugeNeedle20.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle20.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle20.Name = "radialGaugeNeedle20"
            Me.radialGaugeNeedle20.PointRadiusPercentage = 7.0R
            Me.radialGaugeNeedle20.Thickness = 1.5R
            Me.radialGaugeNeedle20.Value = 90.0F
            Me.radialGaugeNeedle20.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge20
            ' 

            Me.radRadialGauge20.BackColor = System.Drawing.Color.White
            Me.radRadialGauge20.CausesValidation = False
            Me.radRadialGauge20.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc35, Me.radialGaugeArc36, Me.radialGaugeArc37, Me.radialGaugeTicks29, Me.radialGaugeTicks30, Me.radialGaugeNeedle19, Me.radialGaugeTicks31, Me.radialGaugeTicks32})
            Me.radRadialGauge20.Location = New System.Drawing.Point(668, 211)
            Me.radRadialGauge20.Name = "radRadialGauge20"
            Me.radRadialGauge20.RangeEnd = 100.0R
            Me.radRadialGauge20.RangeStart = 0.0R
            Me.radRadialGauge20.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge20.StartAngle = 180.0R
            Me.radRadialGauge20.SweepAngle = 360.0R
            Me.radRadialGauge20.TabIndex = 6
            Me.radRadialGauge20.Text = "radRadialGauge1"
            Me.radRadialGauge20.Value = 36.0F
            ' 
            ' radialGaugeArc35
            ' 
            Me.radialGaugeArc35.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(93))))), (CInt(Fix((CByte(116))))), (CInt(Fix((CByte(157))))))
            Me.radialGaugeArc35.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(73))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(157))))))
            Me.radialGaugeArc35.Name = "radialGaugeArc35"
            Me.radialGaugeArc35.Radius = 88.0R
            Me.radialGaugeArc35.RangeEnd = 33.0R
            Me.radialGaugeArc35.RangeStart = 0.0R
            Me.radialGaugeArc35.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc35.Width = 14.0R
            ' 
            ' radialGaugeArc36
            ' 
            Me.radialGaugeArc36.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))))
            Me.radialGaugeArc36.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))))
            Me.radialGaugeArc36.Name = "radialGaugeArc36"
            Me.radialGaugeArc36.Radius = 88.0R
            Me.radialGaugeArc36.RangeEnd = 100.0R
            Me.radialGaugeArc36.RangeStart = 33.0R
            Me.radialGaugeArc36.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc36.Width = 14.0R
            ' 
            ' radialGaugeArc37
            ' 
            Me.radialGaugeArc37.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(205))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc37.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(205))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc37.BindEndRange = True
            Me.radialGaugeArc37.Name = "radialGaugeArc37"
            Me.radialGaugeArc37.Radius = 70.0R
            Me.radialGaugeArc37.RangeEnd = 36.0R
            Me.radialGaugeArc37.RangeStart = 0.0R
            Me.radialGaugeArc37.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc37.Width = 4.0R
            ' 
            ' radialGaugeTicks29
            ' 
            Me.radialGaugeTicks29.DrawText = False
            Me.radialGaugeTicks29.Name = "radialGaugeTicks29"
            Me.radialGaugeTicks29.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))))
            Me.radialGaugeTicks29.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks29.TicksCount = 24
            Me.radialGaugeTicks29.TicksLenghtPercentage = 8.0F
            Me.radialGaugeTicks29.TicksOffset = 0
            Me.radialGaugeTicks29.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks29.TickThickness = 1.0F
            Me.radialGaugeTicks29.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks30
            ' 
            Me.radialGaugeTicks30.DrawText = False
            Me.radialGaugeTicks30.Name = "radialGaugeTicks30"
            Me.radialGaugeTicks30.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))))
            Me.radialGaugeTicks30.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks30.TicksCount = 72
            Me.radialGaugeTicks30.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks30.TicksOffset = 0
            Me.radialGaugeTicks30.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks30.TickThickness = 1.0F
            Me.radialGaugeTicks30.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle19
            ' 
            Me.radialGaugeNeedle19.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle19.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle19.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle19.BindValue = True
            Me.radialGaugeNeedle19.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle19.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle19.Name = "radialGaugeNeedle19"
            Me.radialGaugeNeedle19.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle19.Thickness = 0.4R
            Me.radialGaugeNeedle19.Value = 36.0F
            Me.radialGaugeNeedle19.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks31
            ' 
            Me.radialGaugeTicks31.DrawText = False
            Me.radialGaugeTicks31.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks31.Name = "radialGaugeTicks31"
            Me.radialGaugeTicks31.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks31.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks31.TicksCount = 1
            Me.radialGaugeTicks31.TicksLenghtPercentage = 14.0F
            Me.radialGaugeTicks31.TicksOffset = 0
            Me.radialGaugeTicks31.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks31.TickThickness = 1.0F
            Me.radialGaugeTicks31.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks32
            ' 
            Me.radialGaugeTicks32.CircleTicks = True
            Me.radialGaugeTicks32.DrawText = False
            Me.radialGaugeTicks32.Name = "radialGaugeTicks32"
            Me.radialGaugeTicks32.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks32.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks32.TicksCount = 1
            Me.radialGaugeTicks32.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks32.TicksOffset = 0
            Me.radialGaugeTicks32.TicksRadiusPercentage = 106.0F
            Me.radialGaugeTicks32.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks32.TickThickness = 1.0F
            Me.radialGaugeTicks32.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge19
            ' 

            Me.radRadialGauge19.BackColor = System.Drawing.Color.White
            Me.radRadialGauge19.CausesValidation = False
            Me.radRadialGauge19.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc33, Me.radialGaugeArc34, Me.radialGaugeNeedle18, Me.radialGaugeLabels12, Me.radialGaugeSingleLabel6})
            Me.radRadialGauge19.Location = New System.Drawing.Point(447, 211)
            Me.radRadialGauge19.Name = "radRadialGauge19"
            Me.radRadialGauge19.RangeEnd = 50.0R
            Me.radRadialGauge19.RangeStart = 0.0R
            Me.radRadialGauge19.Size = New System.Drawing.Size(214, 192)
            Me.radRadialGauge19.StartAngle = 205.0R
            Me.radRadialGauge19.SweepAngle = 130.0R
            Me.radRadialGauge19.TabIndex = 6
            Me.radRadialGauge19.Text = "radRadialGauge1"
            Me.radRadialGauge19.Value = 33.0F
            ' 
            ' radialGaugeArc33
            ' 
            Me.radialGaugeArc33.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(164))))))
            Me.radialGaugeArc33.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(164))))))
            Me.radialGaugeArc33.BindEndRange = True
            Me.radialGaugeArc33.Name = "radialGaugeArc33"
            Me.radialGaugeArc33.Radius = 0.0R
            Me.radialGaugeArc33.RangeEnd = 33.0R
            Me.radialGaugeArc33.RangeStart = 0.0R
            Me.radialGaugeArc33.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc33.Width = 40.0R
            ' 
            ' radialGaugeArc34
            ' 
            Me.radialGaugeArc34.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))))
            Me.radialGaugeArc34.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))))
            Me.radialGaugeArc34.BindStartRange = True
            Me.radialGaugeArc34.Name = "radialGaugeArc34"
            Me.radialGaugeArc34.Radius = 0.0R
            Me.radialGaugeArc34.RangeEnd = 50.0R
            Me.radialGaugeArc34.RangeStart = 33.0R
            Me.radialGaugeArc34.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc34.Width = 40.0R
            ' 
            ' radialGaugeNeedle18
            ' 
            Me.radialGaugeNeedle18.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle18.BindValue = True
            Me.radialGaugeNeedle18.InnerPointRadiusPercentage = 4.0R
            Me.radialGaugeNeedle18.LenghtPercentage = 108.0R
            Me.radialGaugeNeedle18.Name = "radialGaugeNeedle18"
            Me.radialGaugeNeedle18.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle18.Thickness = 0.7R
            Me.radialGaugeNeedle18.Value = 33.0F
            Me.radialGaugeNeedle18.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels12
            ' 
            Me.radialGaugeLabels12.DrawText = False
            Me.radialGaugeLabels12.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels12.LabelRadiusPercentage = 112.0F
            Me.radialGaugeLabels12.LabelsCount = 1
            Me.radialGaugeLabels12.Name = "radialGaugeLabels12"
            Me.radialGaugeLabels12.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel6
            ' 
            Me.radialGaugeSingleLabel6.BindValue = True
            Me.radialGaugeSingleLabel6.LabelFormat = "#0#.##"
            Me.radialGaugeSingleLabel6.LabelText = "Text"
            Me.radialGaugeSingleLabel6.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.25F)
            Me.radialGaugeSingleLabel6.Name = "radialGaugeSingleLabel6"
            Me.radialGaugeSingleLabel6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge17
            ' 

            Me.radRadialGauge17.BackColor = System.Drawing.Color.White
            Me.radRadialGauge17.CausesValidation = False
            Me.radRadialGauge17.Controls.Add(Me.radRadialGauge18)
            Me.radRadialGauge17.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc29, Me.radialGaugeArc30, Me.radialGaugeSingleLabel5})
            Me.radRadialGauge17.Location = New System.Drawing.Point(240, 211)
            Me.radRadialGauge17.Name = "radRadialGauge17"
            Me.radRadialGauge17.RangeEnd = 100.0R
            Me.radRadialGauge17.RangeStart = 0.0R
            Me.radRadialGauge17.Size = New System.Drawing.Size(204, 210)
            Me.radRadialGauge17.StartAngle = 180.0R
            Me.radRadialGauge17.SweepAngle = 180.0R
            Me.radRadialGauge17.TabIndex = 6
            Me.radRadialGauge17.Text = "radRadialGauge1"
            Me.radRadialGauge17.Value = 60.0F
            ' 
            ' radRadialGauge18
            ' 

            Me.radRadialGauge18.BackColor = System.Drawing.Color.White
            Me.radRadialGauge18.CausesValidation = False
            Me.radRadialGauge18.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc31, Me.radialGaugeArc32, Me.radialGaugeNeedle17})
            Me.radRadialGauge18.Location = New System.Drawing.Point(1, 100)
            Me.radRadialGauge18.Name = "radRadialGauge18"
            Me.radRadialGauge18.RangeEnd = 100.0R
            Me.radRadialGauge18.RangeStart = 0.0R
            Me.radRadialGauge18.Size = New System.Drawing.Size(200, 208)
            Me.radRadialGauge18.StartAngle = 180.0R
            Me.radRadialGauge18.SweepAngle = 180.0R
            Me.radRadialGauge18.TabIndex = 6
            Me.radRadialGauge18.Text = "radRadialGauge1"
            Me.radRadialGauge18.Value = 80.0F
            ' 
            ' radialGaugeArc31
            ' 
            Me.radialGaugeArc31.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(119))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(79))))))
            Me.radialGaugeArc31.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(121))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(80))))))
            Me.radialGaugeArc31.BindEndRange = True
            Me.radialGaugeArc31.Name = "radialGaugeArc31"
            Me.radialGaugeArc31.Radius = 0.0R
            Me.radialGaugeArc31.RangeEnd = 80.0R
            Me.radialGaugeArc31.RangeStart = 0.0R
            Me.radialGaugeArc31.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc31.Width = 40.0R
            ' 
            ' radialGaugeArc32
            ' 
            Me.radialGaugeArc32.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc32.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc32.BindStartRange = True
            Me.radialGaugeArc32.Name = "radialGaugeArc32"
            Me.radialGaugeArc32.Radius = 0.0R
            Me.radialGaugeArc32.RangeEnd = 100.0R
            Me.radialGaugeArc32.RangeStart = 80.0R
            Me.radialGaugeArc32.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc32.Width = 40.0R
            ' 
            ' radialGaugeNeedle17
            ' 
            Me.radialGaugeNeedle17.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle17.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle17.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle17.BindValue = True
            Me.radialGaugeNeedle17.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle17.LenghtPercentage = 94.0R
            Me.radialGaugeNeedle17.Name = "radialGaugeNeedle17"
            Me.radialGaugeNeedle17.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle17.Thickness = 5.0R
            Me.radialGaugeNeedle17.Value = 80.0F
            Me.radialGaugeNeedle17.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeArc29
            ' 
            Me.radialGaugeArc29.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(68))))))
            Me.radialGaugeArc29.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeArc29.BindEndRange = True
            Me.radialGaugeArc29.Name = "radialGaugeArc29"
            Me.radialGaugeArc29.Radius = 0.0R
            Me.radialGaugeArc29.RangeEnd = 60.0R
            Me.radialGaugeArc29.RangeStart = 0.0R
            Me.radialGaugeArc29.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc29.Width = 40.0R
            ' 
            ' radialGaugeArc30
            ' 
            Me.radialGaugeArc30.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc30.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc30.BindStartRange = True
            Me.radialGaugeArc30.Name = "radialGaugeArc30"
            Me.radialGaugeArc30.Radius = 0.0R
            Me.radialGaugeArc30.RangeEnd = 100.0R
            Me.radialGaugeArc30.RangeStart = 60.0R
            Me.radialGaugeArc30.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc30.Width = 40.0R
            ' 
            ' radialGaugeSingleLabel5
            ' 
            Me.radialGaugeSingleLabel5.BindValue = True
            Me.radialGaugeSingleLabel5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeSingleLabel5.LabelFontSize = 10.0F
            Me.radialGaugeSingleLabel5.LabelText = "Text"
            Me.radialGaugeSingleLabel5.LocationPercentage = New System.Drawing.SizeF(0.0F, -0.2F)
            Me.radialGaugeSingleLabel5.Name = "radialGaugeSingleLabel5"
            Me.radialGaugeSingleLabel5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge16
            ' 

            Me.radRadialGauge16.BackColor = System.Drawing.Color.White
            Me.radRadialGauge16.CausesValidation = False
            Me.radRadialGauge16.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc27, Me.radialGaugeArc28, Me.radialGaugeLabels11, Me.radialGaugeTicks28, Me.radialGaugeSingleLabel4})
            Me.radRadialGauge16.Location = New System.Drawing.Point(4, 211)
            Me.radRadialGauge16.Name = "radRadialGauge16"
            Me.radRadialGauge16.RangeEnd = 180.0R
            Me.radRadialGauge16.RangeStart = 0.0R
            Me.radRadialGauge16.Size = New System.Drawing.Size(229, 210)
            Me.radRadialGauge16.StartAngle = 120.0R
            Me.radRadialGauge16.SweepAngle = 300.0R
            Me.radRadialGauge16.TabIndex = 6
            Me.radRadialGauge16.Text = "radRadialGauge1"
            Me.radRadialGauge16.Value = 90.0F
            ' 
            ' radialGaugeArc27
            ' 
            Me.radialGaugeArc27.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(71))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(155))))))
            Me.radialGaugeArc27.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(162))))))
            Me.radialGaugeArc27.Name = "radialGaugeArc27"
            Me.radialGaugeArc27.Radius = 80.0R
            Me.radialGaugeArc27.RangeEnd = 0.0R
            Me.radialGaugeArc27.RangeStart = 120.0R
            Me.radialGaugeArc27.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc27.Width = 15.0R
            ' 
            ' radialGaugeArc28
            ' 
            Me.radialGaugeArc28.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(181))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(181))))))
            Me.radialGaugeArc28.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc28.Name = "radialGaugeArc28"
            Me.radialGaugeArc28.Radius = 80.0R
            Me.radialGaugeArc28.RangeEnd = 180.0R
            Me.radialGaugeArc28.RangeStart = 120.0R
            Me.radialGaugeArc28.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc28.Width = 15.0R
            ' 
            ' radialGaugeLabels11
            ' 
            Me.radialGaugeLabels11.DrawText = False
            Me.radialGaugeLabels11.LabelFontSize = 5.0F
            Me.radialGaugeLabels11.LabelRadiusPercentage = 108.0F
            Me.radialGaugeLabels11.LabelsCount = 9
            Me.radialGaugeLabels11.Name = "radialGaugeLabels11"
            Me.radialGaugeLabels11.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks28
            ' 
            Me.radialGaugeTicks28.CircleTicks = True
            Me.radialGaugeTicks28.DrawText = False
            Me.radialGaugeTicks28.Name = "radialGaugeTicks28"
            Me.radialGaugeTicks28.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(109))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(109))))))
            Me.radialGaugeTicks28.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks28.TicksCount = 18
            Me.radialGaugeTicks28.TicksLenghtPercentage = 1.0F
            Me.radialGaugeTicks28.TicksOffset = 4
            Me.radialGaugeTicks28.TicksRadiusPercentage = 95.0F
            Me.radialGaugeTicks28.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks28.TickThickness = 1.0F
            Me.radialGaugeTicks28.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel4
            ' 
            Me.radialGaugeSingleLabel4.BindValue = True
            Me.radialGaugeSingleLabel4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(76))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(161))))))
            Me.radialGaugeSingleLabel4.LabelFontSize = 9.0F
            Me.radialGaugeSingleLabel4.LabelText = "Text"
            Me.radialGaugeSingleLabel4.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.0F)
            Me.radialGaugeSingleLabel4.Name = "radialGaugeSingleLabel4"
            Me.radialGaugeSingleLabel4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge14
            ' 

            Me.radRadialGauge14.BackColor = System.Drawing.Color.White
            Me.radRadialGauge14.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc25, Me.radialGaugeTicks25, Me.radialGaugeNeedle14, Me.radialGaugeLabels10})
            Me.radRadialGauge14.Location = New System.Drawing.Point(447, 4)
            Me.radRadialGauge14.Name = "radRadialGauge14"
            Me.radRadialGauge14.RangeEnd = 100.0R
            Me.radRadialGauge14.RangeStart = 50.0R
            Me.radRadialGauge14.Size = New System.Drawing.Size(207, 200)
            Me.radRadialGauge14.StartAngle = 270.0R
            Me.radRadialGauge14.SweepAngle = 90.0R
            Me.radRadialGauge14.TabIndex = 6
            Me.radRadialGauge14.Text = "radRadialGauge1"
            Me.radRadialGauge14.Value = 90.0F
            ' 
            ' radialGaugeArc25
            ' 
            Me.radialGaugeArc25.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))))
            Me.radialGaugeArc25.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))))
            Me.radialGaugeArc25.Name = "radialGaugeArc25"
            Me.radialGaugeArc25.Radius = 90.0R
            Me.radialGaugeArc25.RangeEnd = 100.0R
            Me.radialGaugeArc25.RangeStart = 0.0R
            Me.radialGaugeArc25.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc25.Width = 1.0R
            ' 
            ' radialGaugeTicks25
            ' 
            Me.radialGaugeTicks25.CircleTicks = True
            Me.radialGaugeTicks25.DrawText = False
            Me.radialGaugeTicks25.Name = "radialGaugeTicks25"
            Me.radialGaugeTicks25.TickColor = System.Drawing.Color.Black
            Me.radialGaugeTicks25.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks25.TicksCount = 6
            Me.radialGaugeTicks25.TicksLenghtPercentage = 2.0F
            Me.radialGaugeTicks25.TicksOffset = 0
            Me.radialGaugeTicks25.TicksRadiusPercentage = 89.0F
            Me.radialGaugeTicks25.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks25.TickThickness = 1.0F
            Me.radialGaugeTicks25.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle14
            ' 
            Me.radialGaugeNeedle14.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(163))))))
            Me.radialGaugeNeedle14.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(163))))))
            Me.radialGaugeNeedle14.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle14.BindValue = True
            Me.radialGaugeNeedle14.InnerPointRadiusPercentage = 1.0R
            Me.radialGaugeNeedle14.LenghtPercentage = 120.0R
            Me.radialGaugeNeedle14.Name = "radialGaugeNeedle14"
            Me.radialGaugeNeedle14.PointRadiusPercentage = 3.0R
            Me.radialGaugeNeedle14.Thickness = 1.0R
            Me.radialGaugeNeedle14.Value = 90.0F
            Me.radialGaugeNeedle14.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels10
            ' 
            Me.radialGaugeLabels10.DrawText = False
            Me.radialGaugeLabels10.LabelFontSize = 5.0F
            Me.radialGaugeLabels10.LabelRadiusPercentage = 105.0F
            Me.radialGaugeLabels10.LabelsCount = 1
            Me.radialGaugeLabels10.Name = "radialGaugeLabels10"
            Me.radialGaugeLabels10.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge13
            ' 

            Me.radRadialGauge13.BackColor = System.Drawing.Color.White
            Me.radRadialGauge13.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc24, Me.radialGaugeNeedle13, Me.radialGaugeTicks22, Me.radialGaugeTicks23, Me.radialGaugeTicks24})
            Me.radRadialGauge13.Location = New System.Drawing.Point(241, 4)
            Me.radRadialGauge13.Name = "radRadialGauge13"
            Me.radRadialGauge13.RangeEnd = 100.0R
            Me.radRadialGauge13.RangeStart = 0.0R
            Me.radRadialGauge13.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge13.StartAngle = 180.0R
            Me.radRadialGauge13.SweepAngle = 180.0R
            Me.radRadialGauge13.TabIndex = 3
            Me.radRadialGauge13.Text = "radRadialGauge4"
            Me.radRadialGauge13.Value = 90.0F
            ' 
            ' radialGaugeArc24
            ' 
            Me.radialGaugeArc24.AccessibleDescription = "radialGaugeArc3"
            Me.radialGaugeArc24.AccessibleName = "radialGaugeArc3"
            Me.radialGaugeArc24.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc24.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc24.Name = "radialGaugeArc24"
            Me.radialGaugeArc24.Radius = 0.0R
            Me.radialGaugeArc24.RangeEnd = 100.0R
            Me.radialGaugeArc24.RangeStart = 0.0R
            Me.radialGaugeArc24.Text = "radialGaugeArc3"
            Me.radialGaugeArc24.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc24.Width = 1.0R
            ' 
            ' radialGaugeNeedle13
            ' 
            Me.radialGaugeNeedle13.AccessibleDescription = "radialGaugeNeedle3"
            Me.radialGaugeNeedle13.AccessibleName = "radialGaugeNeedle3"
            Me.radialGaugeNeedle13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(164))))))
            Me.radialGaugeNeedle13.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(164))))))
            Me.radialGaugeNeedle13.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle13.BindValue = True
            Me.radialGaugeNeedle13.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle13.LenghtPercentage = 80.0R
            Me.radialGaugeNeedle13.Name = "radialGaugeNeedle13"
            Me.radialGaugeNeedle13.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle13.Text = "radialGaugeNeedle3"
            Me.radialGaugeNeedle13.Thickness = 5.0R
            Me.radialGaugeNeedle13.Value = 90.0F
            Me.radialGaugeNeedle13.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks22
            ' 
            Me.radialGaugeTicks22.AccessibleDescription = "radialGaugeTicks5"
            Me.radialGaugeTicks22.AccessibleName = "radialGaugeTicks5"
            Me.radialGaugeTicks22.DrawText = False
            Me.radialGaugeTicks22.Name = "radialGaugeTicks22"
            Me.radialGaugeTicks22.Text = "radialGaugeTicks5"
            Me.radialGaugeTicks22.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks22.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks22.TicksCount = 12
            Me.radialGaugeTicks22.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks22.TicksOffset = 5
            Me.radialGaugeTicks22.TickStartIndexVisibleRange = 1.0F
            Me.radialGaugeTicks22.TickThickness = 1.0F
            Me.radialGaugeTicks22.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks23
            ' 
            Me.radialGaugeTicks23.AccessibleDescription = "radialGaugeTicks6"
            Me.radialGaugeTicks23.AccessibleName = "radialGaugeTicks6"
            Me.radialGaugeTicks23.DrawText = False
            Me.radialGaugeTicks23.Name = "radialGaugeTicks23"
            Me.radialGaugeTicks23.Text = "radialGaugeTicks6"
            Me.radialGaugeTicks23.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks23.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks23.TicksCount = 36
            Me.radialGaugeTicks23.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks23.TicksOffset = 0
            Me.radialGaugeTicks23.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks23.TickThickness = 1.0F
            Me.radialGaugeTicks23.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks24
            ' 
            Me.radialGaugeTicks24.AccessibleDescription = "radialGaugeTicks7"
            Me.radialGaugeTicks24.AccessibleName = "radialGaugeTicks7"
            Me.radialGaugeTicks24.DrawText = False
            Me.radialGaugeTicks24.Name = "radialGaugeTicks24"
            Me.radialGaugeTicks24.Text = "radialGaugeTicks7"
            Me.radialGaugeTicks24.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks24.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks24.TicksCount = 1
            Me.radialGaugeTicks24.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks24.TicksOffset = 0
            Me.radialGaugeTicks24.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks24.TickThickness = 1.0F
            Me.radialGaugeTicks24.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge12
            ' 

            Me.radRadialGauge12.BackColor = System.Drawing.Color.White
            Me.radRadialGauge12.CausesValidation = False
            Me.radRadialGauge12.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc43, Me.radialGaugeArc44, Me.radialGaugeTicks35, Me.radialGaugeTicks36, Me.radialGaugeTicks37, Me.radialGaugeTicks38, Me.radialGaugeLabels15, Me.radialGaugeLabels16, Me.radialGaugeNeedle21, Me.radialGaugeNeedle22})
            Me.radRadialGauge12.Location = New System.Drawing.Point(4, 4)
            Me.radRadialGauge12.Name = "radRadialGauge12"
            Me.radRadialGauge12.RangeEnd = 180.0R
            Me.radRadialGauge12.RangeStart = 0.0R
            Me.radRadialGauge12.Size = New System.Drawing.Size(229, 200)
            Me.radRadialGauge12.StartAngle = 120.0R
            Me.radRadialGauge12.SweepAngle = 300.0R
            Me.radRadialGauge12.TabIndex = 1
            Me.radRadialGauge12.Text = "radRadialGauge2"
            Me.radRadialGauge12.Value = 90.0F
            ' 
            ' radialGaugeArc43
            ' 
            Me.radialGaugeArc43.AccessibleDescription = "radialGaugeArc1"
            Me.radialGaugeArc43.AccessibleName = "radialGaugeArc1"
            Me.radialGaugeArc43.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc43.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc43.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc43.Name = "radialGaugeArc43"
            Me.radialGaugeArc43.Radius = 0.0R
            Me.radialGaugeArc43.RangeEnd = 120.0R
            Me.radialGaugeArc43.RangeStart = 0.0R
            Me.radialGaugeArc43.Text = "radialGaugeArc1"
            Me.radialGaugeArc43.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc43.Width = 1.0R
            ' 
            ' radialGaugeArc44
            ' 
            Me.radialGaugeArc44.AccessibleDescription = "radialGaugeArc2"
            Me.radialGaugeArc44.AccessibleName = "radialGaugeArc2"
            Me.radialGaugeArc44.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc44.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeArc44.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc44.Name = "radialGaugeArc44"
            Me.radialGaugeArc44.Radius = 0.0R
            Me.radialGaugeArc44.RangeEnd = 180.0R
            Me.radialGaugeArc44.RangeStart = 120.0R
            Me.radialGaugeArc44.Text = "radialGaugeArc2"
            Me.radialGaugeArc44.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc44.Width = 1.0R
            ' 
            ' radialGaugeTicks35
            ' 
            Me.radialGaugeTicks35.AccessibleDescription = "radialGaugeTicks1"
            Me.radialGaugeTicks35.AccessibleName = "radialGaugeTicks1"
            Me.radialGaugeTicks35.DrawText = False
            Me.radialGaugeTicks35.Name = "radialGaugeTicks35"
            Me.radialGaugeTicks35.Text = "radialGaugeTicks1"
            Me.radialGaugeTicks35.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks35.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks35.TicksCount = 18
            Me.radialGaugeTicks35.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks35.TicksOffset = 0
            Me.radialGaugeTicks35.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks35.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks35.TickThickness = 1.0F
            Me.radialGaugeTicks35.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks36
            ' 
            Me.radialGaugeTicks36.AccessibleDescription = "radialGaugeTicks2"
            Me.radialGaugeTicks36.AccessibleName = "radialGaugeTicks2"
            Me.radialGaugeTicks36.DrawText = False
            Me.radialGaugeTicks36.Name = "radialGaugeTicks36"
            Me.radialGaugeTicks36.Text = "radialGaugeTicks2"
            Me.radialGaugeTicks36.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks36.TickEndIndexVisibleRange = 35.0F
            Me.radialGaugeTicks36.TicksCount = 54
            Me.radialGaugeTicks36.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks36.TicksOffset = 0
            Me.radialGaugeTicks36.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks36.TickThickness = 1.0F
            Me.radialGaugeTicks36.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks37
            ' 
            Me.radialGaugeTicks37.AccessibleDescription = "radialGaugeTicks3"
            Me.radialGaugeTicks37.AccessibleName = "radialGaugeTicks3"
            Me.radialGaugeTicks37.DrawText = False
            Me.radialGaugeTicks37.Name = "radialGaugeTicks37"
            Me.radialGaugeTicks37.Text = "radialGaugeTicks3"
            Me.radialGaugeTicks37.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks37.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks37.TicksCount = 18
            Me.radialGaugeTicks37.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks37.TicksOffset = 0
            Me.radialGaugeTicks37.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks37.TickStartIndexVisibleRange = 12.0F
            Me.radialGaugeTicks37.TickThickness = 1.0F
            Me.radialGaugeTicks37.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks38
            ' 
            Me.radialGaugeTicks38.AccessibleDescription = "radialGaugeTicks4"
            Me.radialGaugeTicks38.AccessibleName = "radialGaugeTicks4"
            Me.radialGaugeTicks38.DrawText = False
            Me.radialGaugeTicks38.Name = "radialGaugeTicks38"
            Me.radialGaugeTicks38.Text = "radialGaugeTicks4"
            Me.radialGaugeTicks38.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks38.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks38.TicksCount = 54
            Me.radialGaugeTicks38.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks38.TicksOffset = 0
            Me.radialGaugeTicks38.TickStartIndexVisibleRange = 37.0F
            Me.radialGaugeTicks38.TickThickness = 1.0F
            Me.radialGaugeTicks38.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels15
            ' 
            Me.radialGaugeLabels15.AccessibleDescription = "radialGaugeLabels1"
            Me.radialGaugeLabels15.AccessibleName = "radialGaugeLabels1"
            Me.radialGaugeLabels15.DrawText = False
            Me.radialGaugeLabels15.LabelEndVisibleRange = 100.0F
            Me.radialGaugeLabels15.LabelFontSize = 4.0F
            Me.radialGaugeLabels15.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels15.LabelsCount = 9
            Me.radialGaugeLabels15.Name = "radialGaugeLabels15"
            Me.radialGaugeLabels15.Text = "radialGaugeLabels1"
            Me.radialGaugeLabels15.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels16
            ' 
            Me.radialGaugeLabels16.AccessibleDescription = "radialGaugeLabels2"
            Me.radialGaugeLabels16.AccessibleName = "radialGaugeLabels2"
            Me.radialGaugeLabels16.DrawText = False
            Me.radialGaugeLabels16.ForeColor = System.Drawing.Color.Red
            Me.radialGaugeLabels16.LabelFontSize = 4.0F
            Me.radialGaugeLabels16.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels16.LabelsCount = 9
            Me.radialGaugeLabels16.LabelStartVisibleRange = 120.0F
            Me.radialGaugeLabels16.Name = "radialGaugeLabels16"
            Me.radialGaugeLabels16.Text = "radialGaugeLabels2"
            Me.radialGaugeLabels16.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle21
            ' 
            Me.radialGaugeNeedle21.AccessibleDescription = "radialGaugeNeedle1"
            Me.radialGaugeNeedle21.AccessibleName = "radialGaugeNeedle1"
            Me.radialGaugeNeedle21.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(163))))))
            Me.radialGaugeNeedle21.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(77))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(163))))))
            Me.radialGaugeNeedle21.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle21.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle21.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle21.Name = "radialGaugeNeedle21"
            Me.radialGaugeNeedle21.PointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle21.Text = "radialGaugeNeedle1"
            Me.radialGaugeNeedle21.Thickness = 2.0R
            Me.radialGaugeNeedle21.Value = 90.0F
            Me.radialGaugeNeedle21.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle22
            ' 
            Me.radialGaugeNeedle22.AccessibleDescription = "radialGaugeNeedle2"
            Me.radialGaugeNeedle22.AccessibleName = "radialGaugeNeedle2"
            Me.radialGaugeNeedle22.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle22.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle22.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle22.BindValue = True
            Me.radialGaugeNeedle22.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle22.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle22.Name = "radialGaugeNeedle22"
            Me.radialGaugeNeedle22.PointRadiusPercentage = 6.0R
            Me.radialGaugeNeedle22.Text = "radialGaugeNeedle2"
            Me.radialGaugeNeedle22.Thickness = 2.0R
            Me.radialGaugeNeedle22.Value = 90.0F
            Me.radialGaugeNeedle22.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge15
            ' 

            Me.radRadialGauge15.BackColor = System.Drawing.Color.White
            Me.radRadialGauge15.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc26, Me.radialGaugeTicks26, Me.radialGaugeTicks27, Me.radialGaugeNeedle15, Me.radialGaugeNeedle16})
            Me.radRadialGauge15.Location = New System.Drawing.Point(661, 4)
            Me.radRadialGauge15.Name = "radRadialGauge15"
            Me.radRadialGauge15.RangeEnd = 100.0R
            Me.radRadialGauge15.RangeStart = 0.0R
            Me.radRadialGauge15.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge15.StartAngle = 0.0R
            Me.radRadialGauge15.SweepAngle = 360.0R
            Me.radRadialGauge15.TabIndex = 6
            Me.radRadialGauge15.Text = "radRadialGauge1"
            Me.radRadialGauge15.Value = 90.0F
            ' 
            ' radialGaugeArc26
            ' 
            Me.radialGaugeArc26.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc26.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc26.Name = "radialGaugeArc26"
            Me.radialGaugeArc26.Radius = 0.0R
            Me.radialGaugeArc26.RangeEnd = 100.0R
            Me.radialGaugeArc26.RangeStart = 0.0R
            Me.radialGaugeArc26.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc26.Width = 2.0R
            ' 
            ' radialGaugeTicks26
            ' 
            Me.radialGaugeTicks26.DrawText = False
            Me.radialGaugeTicks26.Name = "radialGaugeTicks26"
            Me.radialGaugeTicks26.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks26.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks26.TicksCount = 24
            Me.radialGaugeTicks26.TicksLenghtPercentage = 2.0F
            Me.radialGaugeTicks26.TicksOffset = 6
            Me.radialGaugeTicks26.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks26.TickThickness = 1.0F
            Me.radialGaugeTicks26.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks27
            ' 
            Me.radialGaugeTicks27.DrawText = False
            Me.radialGaugeTicks27.Name = "radialGaugeTicks27"
            Me.radialGaugeTicks27.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks27.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks27.TicksCount = 72
            Me.radialGaugeTicks27.TicksLenghtPercentage = 1.0F
            Me.radialGaugeTicks27.TicksOffset = 1
            Me.radialGaugeTicks27.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks27.TickThickness = 1.0F
            Me.radialGaugeTicks27.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle15
            ' 
            Me.radialGaugeNeedle15.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(164))))))
            Me.radialGaugeNeedle15.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(164))))))
            Me.radialGaugeNeedle15.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle15.BindValue = True
            Me.radialGaugeNeedle15.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle15.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle15.Name = "radialGaugeNeedle15"
            Me.radialGaugeNeedle15.PointRadiusPercentage = 4.0R
            Me.radialGaugeNeedle15.Thickness = 1.0R
            Me.radialGaugeNeedle15.Value = 90.0F
            Me.radialGaugeNeedle15.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle16
            ' 
            Me.radialGaugeNeedle16.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle16.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle16.BackLenghtPercentage = -55.0R
            Me.radialGaugeNeedle16.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle16.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle16.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle16.Name = "radialGaugeNeedle16"
            Me.radialGaugeNeedle16.PointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle16.Thickness = 8.0R
            Me.radialGaugeNeedle16.Value = 60.0F
            Me.radialGaugeNeedle16.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeArc22
            ' 
            Me.radialGaugeArc22.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc22.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc22.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc22.Name = "radialGaugeArc22"
            Me.radialGaugeArc22.Radius = 0.0R
            Me.radialGaugeArc22.RangeEnd = 120.0R
            Me.radialGaugeArc22.RangeStart = 0.0R
            Me.radialGaugeArc22.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc22.Width = 1.0R
            ' 
            ' radialGaugeArc23
            ' 
            Me.radialGaugeArc23.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc23.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeArc23.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc23.Name = "radialGaugeArc23"
            Me.radialGaugeArc23.Radius = 0.0R
            Me.radialGaugeArc23.RangeEnd = 180.0R
            Me.radialGaugeArc23.RangeStart = 120.0R
            Me.radialGaugeArc23.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc23.Width = 1.0R
            ' 
            ' radialGaugeTicks18
            ' 
            Me.radialGaugeTicks18.DrawText = False
            Me.radialGaugeTicks18.Name = "radialGaugeTicks18"
            Me.radialGaugeTicks18.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks18.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks18.TicksCount = 18
            Me.radialGaugeTicks18.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks18.TicksOffset = 0
            Me.radialGaugeTicks18.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks18.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks18.TickThickness = 1.0F
            Me.radialGaugeTicks18.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks19
            ' 
            Me.radialGaugeTicks19.DrawText = False
            Me.radialGaugeTicks19.Name = "radialGaugeTicks19"
            Me.radialGaugeTicks19.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks19.TickEndIndexVisibleRange = 35.0F
            Me.radialGaugeTicks19.TicksCount = 54
            Me.radialGaugeTicks19.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks19.TicksOffset = 0
            Me.radialGaugeTicks19.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks19.TickThickness = 1.0F
            Me.radialGaugeTicks19.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks20
            ' 
            Me.radialGaugeTicks20.DrawText = False
            Me.radialGaugeTicks20.Name = "radialGaugeTicks20"
            Me.radialGaugeTicks20.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks20.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks20.TicksCount = 18
            Me.radialGaugeTicks20.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks20.TicksOffset = 0
            Me.radialGaugeTicks20.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks20.TickStartIndexVisibleRange = 12.0F
            Me.radialGaugeTicks20.TickThickness = 1.0F
            Me.radialGaugeTicks20.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks21
            ' 
            Me.radialGaugeTicks21.DrawText = False
            Me.radialGaugeTicks21.Name = "radialGaugeTicks21"
            Me.radialGaugeTicks21.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks21.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks21.TicksCount = 54
            Me.radialGaugeTicks21.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks21.TicksOffset = 0
            Me.radialGaugeTicks21.TickStartIndexVisibleRange = 37.0F
            Me.radialGaugeTicks21.TickThickness = 1.0F
            Me.radialGaugeTicks21.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels8
            ' 
            Me.radialGaugeLabels8.DrawText = False
            Me.radialGaugeLabels8.LabelEndVisibleRange = 100.0F
            Me.radialGaugeLabels8.LabelFontSize = 4.0F
            Me.radialGaugeLabels8.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels8.LabelsCount = 9
            Me.radialGaugeLabels8.Name = "radialGaugeLabels8"
            Me.radialGaugeLabels8.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
            Me.radialGaugeLabels9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle11
            ' 
            Me.radialGaugeNeedle11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle11.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle11.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle11.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle11.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle11.Name = "radialGaugeNeedle11"
            Me.radialGaugeNeedle11.PointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle11.Thickness = 2.0R
            Me.radialGaugeNeedle11.Value = 90.0F
            Me.radialGaugeNeedle11.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle12
            ' 
            Me.radialGaugeNeedle12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle12.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle12.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle12.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle12.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle12.Name = "radialGaugeNeedle12"
            Me.radialGaugeNeedle12.PointRadiusPercentage = 6.0R
            Me.radialGaugeNeedle12.Thickness = 2.0R
            Me.radialGaugeNeedle12.Value = 130.0F
            Me.radialGaugeNeedle12.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radPanel3
            ' 
            Me.radPanel3.BackColor = System.Drawing.Color.White
            Me.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel3.Location = New System.Drawing.Point(0, 0)
            Me.radPanel3.Name = "radPanel3"
            Me.radPanel3.Padding = New System.Windows.Forms.Padding(0)
            ' 
            ' radPanel3.PanelContainer
            ' 
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge33)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge32)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge31)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge30)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge28)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge27)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge26)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge25)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge24)
            Me.radPanel3.PanelContainer.Controls.Add(Me.radRadialGauge23)
            Me.radPanel3.PanelContainer.Location = New System.Drawing.Point(0, 0)
            Me.radPanel3.PanelContainer.Size = New System.Drawing.Size(1193, 828)
            Me.radPanel3.Size = New System.Drawing.Size(1193, 828)
            Me.radPanel3.TabIndex = 7
            CType(Me.radPanel3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' radRadialGauge33
            ' 

            Me.radRadialGauge33.BackColor = System.Drawing.Color.White
            Me.radRadialGauge33.CausesValidation = False
            Me.radRadialGauge33.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc64, Me.radialGaugeArc65, Me.radialGaugeLabels23, Me.radialGaugeTicks55})
            Me.radRadialGauge33.Location = New System.Drawing.Point(258, 428)
            Me.radRadialGauge33.Name = "radRadialGauge33"
            Me.radRadialGauge33.RangeEnd = 180.0R
            Me.radRadialGauge33.RangeStart = 0.0R
            Me.radRadialGauge33.Size = New System.Drawing.Size(166, 164)
            Me.radRadialGauge33.StartAngle = 120.0R
            Me.radRadialGauge33.SweepAngle = 300.0R
            Me.radRadialGauge33.TabIndex = 6
            Me.radRadialGauge33.Text = "radRadialGauge1"
            Me.radRadialGauge33.Value = 100.0F
            ' 
            ' radialGaugeArc64
            ' 
            Me.radialGaugeArc64.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc64.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc64.BindEndRange = True
            Me.radialGaugeArc64.Name = "radialGaugeArc64"
            Me.radialGaugeArc64.Radius = 0.0R
            Me.radialGaugeArc64.RangeEnd = 100.0R
            Me.radialGaugeArc64.RangeStart = 0.0R
            Me.radialGaugeArc64.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc64.Width = 24.0R
            ' 
            ' radialGaugeArc65
            ' 
            Me.radialGaugeArc65.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))))
            Me.radialGaugeArc65.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))), (CInt(Fix((CByte(173))))))
            Me.radialGaugeArc65.BindStartRange = True
            Me.radialGaugeArc65.Name = "radialGaugeArc65"
            Me.radialGaugeArc65.Radius = 87.0R
            Me.radialGaugeArc65.RangeEnd = 180.0R
            Me.radialGaugeArc65.RangeStart = 100.0R
            Me.radialGaugeArc65.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc65.Width = 14.0R
            ' 
            ' radialGaugeLabels23
            ' 
            Me.radialGaugeLabels23.DrawText = False
            Me.radialGaugeLabels23.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels23.LabelFontSize = 6.0F
            Me.radialGaugeLabels23.LabelRadiusPercentage = 55.0F
            Me.radialGaugeLabels23.LabelsCount = 2
            Me.radialGaugeLabels23.Name = "radialGaugeLabels23"
            Me.radialGaugeLabels23.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks55
            ' 
            Me.radialGaugeTicks55.DrawText = False
            Me.radialGaugeTicks55.Name = "radialGaugeTicks55"
            Me.radialGaugeTicks55.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks55.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks55.TicksCount = 16
            Me.radialGaugeTicks55.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks55.TicksOffset = 0
            Me.radialGaugeTicks55.TicksRadiusPercentage = 64.0F
            Me.radialGaugeTicks55.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks55.TickThickness = 1.0F
            Me.radialGaugeTicks55.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge32
            ' 

            Me.radRadialGauge32.BackColor = System.Drawing.Color.White
            Me.radRadialGauge32.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc61, Me.radialGaugeArc62, Me.radialGaugeArc63, Me.radialGaugeTicks54, Me.radialGaugeLabels22, Me.radialGaugeNeedle32})
            Me.radRadialGauge32.Location = New System.Drawing.Point(13, 428)
            Me.radRadialGauge32.Name = "radRadialGauge32"
            Me.radRadialGauge32.RangeEnd = 180.0R
            Me.radRadialGauge32.RangeStart = 0.0R
            Me.radRadialGauge32.Size = New System.Drawing.Size(210, 198)
            Me.radRadialGauge32.StartAngle = 130.0R
            Me.radRadialGauge32.SweepAngle = 280.0R
            Me.radRadialGauge32.TabIndex = 6
            Me.radRadialGauge32.Text = "radRadialGauge1"
            Me.radRadialGauge32.Value = 90.0F
            ' 
            ' radialGaugeArc61
            ' 
            Me.radialGaugeArc61.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(144))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(103))))))
            Me.radialGaugeArc61.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(144))))), (CInt(Fix((CByte(206))))), (CInt(Fix((CByte(103))))))
            Me.radialGaugeArc61.Name = "radialGaugeArc61"
            Me.radialGaugeArc61.Radius = 0.0R
            Me.radialGaugeArc61.RangeEnd = 60.0R
            Me.radialGaugeArc61.RangeStart = 0.0R
            Me.radialGaugeArc61.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc61.Width = 3.0R
            ' 
            ' radialGaugeArc62
            ' 
            Me.radialGaugeArc62.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc62.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc62.Name = "radialGaugeArc62"
            Me.radialGaugeArc62.Radius = 0.0R
            Me.radialGaugeArc62.RangeEnd = 120.0R
            Me.radialGaugeArc62.RangeStart = 61.0R
            Me.radialGaugeArc62.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc62.Width = 3.0R
            ' 
            ' radialGaugeArc63
            ' 
            Me.radialGaugeArc63.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeArc63.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeArc63.Name = "radialGaugeArc63"
            Me.radialGaugeArc63.Radius = 0.0R
            Me.radialGaugeArc63.RangeEnd = 180.0R
            Me.radialGaugeArc63.RangeStart = 121.0R
            Me.radialGaugeArc63.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc63.Width = 3.0R
            ' 
            ' radialGaugeTicks54
            ' 
            Me.radialGaugeTicks54.DrawText = False
            Me.radialGaugeTicks54.Name = "radialGaugeTicks54"
            Me.radialGaugeTicks54.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks54.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks54.TicksCount = 18
            Me.radialGaugeTicks54.TicksLenghtPercentage = 4.0F
            Me.radialGaugeTicks54.TicksOffset = 0
            Me.radialGaugeTicks54.TicksRadiusPercentage = 83.0F
            Me.radialGaugeTicks54.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks54.TickThickness = 1.0F
            Me.radialGaugeTicks54.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels22
            ' 
            Me.radialGaugeLabels22.DrawText = False
            Me.radialGaugeLabels22.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels22.LabelFontSize = 5.0F
            Me.radialGaugeLabels22.LabelRadiusPercentage = 68.0F
            Me.radialGaugeLabels22.LabelsCount = 9
            Me.radialGaugeLabels22.Name = "radialGaugeLabels22"
            Me.radialGaugeLabels22.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle32
            ' 
            Me.radialGaugeNeedle32.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeNeedle32.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(88))))), (CInt(Fix((CByte(88))))))
            Me.radialGaugeNeedle32.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle32.BindValue = True
            Me.radialGaugeNeedle32.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle32.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle32.Name = "radialGaugeNeedle32"
            Me.radialGaugeNeedle32.PointRadiusPercentage = 7.0R
            Me.radialGaugeNeedle32.Thickness = 1.5R
            Me.radialGaugeNeedle32.Value = 90.0F
            Me.radialGaugeNeedle32.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge31
            ' 

            Me.radRadialGauge31.BackColor = System.Drawing.Color.White
            Me.radRadialGauge31.CausesValidation = False
            Me.radRadialGauge31.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc58, Me.radialGaugeArc59, Me.radialGaugeArc60, Me.radialGaugeTicks50, Me.radialGaugeTicks51, Me.radialGaugeNeedle31, Me.radialGaugeTicks52, Me.radialGaugeTicks53})
            Me.radRadialGauge31.Location = New System.Drawing.Point(668, 211)
            Me.radRadialGauge31.Name = "radRadialGauge31"
            Me.radRadialGauge31.RangeEnd = 100.0R
            Me.radRadialGauge31.RangeStart = 0.0R
            Me.radRadialGauge31.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge31.StartAngle = 180.0R
            Me.radRadialGauge31.SweepAngle = 360.0R
            Me.radRadialGauge31.TabIndex = 6
            Me.radRadialGauge31.Text = "radRadialGauge1"
            Me.radRadialGauge31.Value = 36.0F
            ' 
            ' radialGaugeArc58
            ' 
            Me.radialGaugeArc58.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(184))))))
            Me.radialGaugeArc58.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(184))))))
            Me.radialGaugeArc58.Name = "radialGaugeArc58"
            Me.radialGaugeArc58.Radius = 88.0R
            Me.radialGaugeArc58.RangeEnd = 33.0R
            Me.radialGaugeArc58.RangeStart = 0.0R
            Me.radialGaugeArc58.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc58.Width = 14.0R
            ' 
            ' radialGaugeArc59
            ' 
            Me.radialGaugeArc59.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))))
            Me.radialGaugeArc59.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(191))))))
            Me.radialGaugeArc59.Name = "radialGaugeArc59"
            Me.radialGaugeArc59.Radius = 88.0R
            Me.radialGaugeArc59.RangeEnd = 100.0R
            Me.radialGaugeArc59.RangeStart = 33.0R
            Me.radialGaugeArc59.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc59.Width = 14.0R
            ' 
            ' radialGaugeArc60
            ' 
            Me.radialGaugeArc60.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(252))))), (CInt(Fix((CByte(152))))), (CInt(Fix((CByte(38))))))
            Me.radialGaugeArc60.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(252))))), (CInt(Fix((CByte(152))))), (CInt(Fix((CByte(38))))))
            Me.radialGaugeArc60.BindEndRange = True
            Me.radialGaugeArc60.Name = "radialGaugeArc60"
            Me.radialGaugeArc60.Radius = 70.0R
            Me.radialGaugeArc60.RangeEnd = 36.0R
            Me.radialGaugeArc60.RangeStart = 0.0R
            Me.radialGaugeArc60.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc60.Width = 4.0R
            ' 
            ' radialGaugeTicks50
            ' 
            Me.radialGaugeTicks50.DrawText = False
            Me.radialGaugeTicks50.Name = "radialGaugeTicks50"
            Me.radialGaugeTicks50.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))))
            Me.radialGaugeTicks50.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks50.TicksCount = 24
            Me.radialGaugeTicks50.TicksLenghtPercentage = 8.0F
            Me.radialGaugeTicks50.TicksOffset = 0
            Me.radialGaugeTicks50.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks50.TickThickness = 1.0F
            Me.radialGaugeTicks50.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks51
            ' 
            Me.radialGaugeTicks51.DrawText = False
            Me.radialGaugeTicks51.Name = "radialGaugeTicks51"
            Me.radialGaugeTicks51.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(124))))))
            Me.radialGaugeTicks51.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks51.TicksCount = 72
            Me.radialGaugeTicks51.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks51.TicksOffset = 0
            Me.radialGaugeTicks51.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks51.TickThickness = 1.0F
            Me.radialGaugeTicks51.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle31
            ' 
            Me.radialGaugeNeedle31.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle31.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle31.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle31.BindValue = True
            Me.radialGaugeNeedle31.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle31.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle31.Name = "radialGaugeNeedle31"
            Me.radialGaugeNeedle31.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle31.Thickness = 0.4R
            Me.radialGaugeNeedle31.Value = 36.0F
            Me.radialGaugeNeedle31.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks52
            ' 
            Me.radialGaugeTicks52.DrawText = False
            Me.radialGaugeTicks52.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks52.Name = "radialGaugeTicks52"
            Me.radialGaugeTicks52.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks52.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks52.TicksCount = 1
            Me.radialGaugeTicks52.TicksLenghtPercentage = 14.0F
            Me.radialGaugeTicks52.TicksOffset = 0
            Me.radialGaugeTicks52.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks52.TickThickness = 1.0F
            Me.radialGaugeTicks52.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks53
            ' 
            Me.radialGaugeTicks53.CircleTicks = True
            Me.radialGaugeTicks53.DrawText = False
            Me.radialGaugeTicks53.Name = "radialGaugeTicks53"
            Me.radialGaugeTicks53.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(115))))))
            Me.radialGaugeTicks53.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks53.TicksCount = 1
            Me.radialGaugeTicks53.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks53.TicksOffset = 0
            Me.radialGaugeTicks53.TicksRadiusPercentage = 106.0F
            Me.radialGaugeTicks53.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks53.TickThickness = 1.0F
            Me.radialGaugeTicks53.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge30
            ' 

            Me.radRadialGauge30.BackColor = System.Drawing.Color.White
            Me.radRadialGauge30.CausesValidation = False
            Me.radRadialGauge30.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc56, Me.radialGaugeArc57, Me.radialGaugeNeedle30, Me.radialGaugeLabels21, Me.radialGaugeSingleLabel9})
            Me.radRadialGauge30.Location = New System.Drawing.Point(447, 211)
            Me.radRadialGauge30.Name = "radRadialGauge30"
            Me.radRadialGauge30.RangeEnd = 50.0R
            Me.radRadialGauge30.RangeStart = 0.0R
            Me.radRadialGauge30.Size = New System.Drawing.Size(214, 192)
            Me.radRadialGauge30.StartAngle = 205.0R
            Me.radRadialGauge30.SweepAngle = 130.0R
            Me.radRadialGauge30.TabIndex = 6
            Me.radRadialGauge30.Text = "radRadialGauge1"
            Me.radRadialGauge30.Value = 33.0F
            ' 
            ' radialGaugeArc56
            ' 
            Me.radialGaugeArc56.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc56.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc56.BindEndRange = True
            Me.radialGaugeArc56.Name = "radialGaugeArc56"
            Me.radialGaugeArc56.Radius = 0.0R
            Me.radialGaugeArc56.RangeEnd = 33.0R
            Me.radialGaugeArc56.RangeStart = 0.0R
            Me.radialGaugeArc56.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc56.Width = 40.0R
            ' 
            ' radialGaugeArc57
            ' 
            Me.radialGaugeArc57.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))))
            Me.radialGaugeArc57.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(209))))))
            Me.radialGaugeArc57.BindStartRange = True
            Me.radialGaugeArc57.Name = "radialGaugeArc57"
            Me.radialGaugeArc57.Radius = 0.0R
            Me.radialGaugeArc57.RangeEnd = 50.0R
            Me.radialGaugeArc57.RangeStart = 33.0R
            Me.radialGaugeArc57.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc57.Width = 40.0R
            ' 
            ' radialGaugeNeedle30
            ' 
            Me.radialGaugeNeedle30.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle30.BindValue = True
            Me.radialGaugeNeedle30.InnerPointRadiusPercentage = 4.0R
            Me.radialGaugeNeedle30.LenghtPercentage = 110.0R
            Me.radialGaugeNeedle30.Name = "radialGaugeNeedle30"
            Me.radialGaugeNeedle30.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle30.Thickness = 0.7R
            Me.radialGaugeNeedle30.Value = 33.0F
            Me.radialGaugeNeedle30.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels21
            ' 
            Me.radialGaugeLabels21.DrawText = False
            Me.radialGaugeLabels21.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeLabels21.LabelRadiusPercentage = 112.0F
            Me.radialGaugeLabels21.LabelsCount = 1
            Me.radialGaugeLabels21.Name = "radialGaugeLabels21"
            Me.radialGaugeLabels21.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel9
            ' 
            Me.radialGaugeSingleLabel9.BindValue = True
            Me.radialGaugeSingleLabel9.LabelFormat = "#0#.##"
            Me.radialGaugeSingleLabel9.LabelText = "Text"
            Me.radialGaugeSingleLabel9.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.25F)
            Me.radialGaugeSingleLabel9.Name = "radialGaugeSingleLabel9"
            Me.radialGaugeSingleLabel9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge28
            ' 

            Me.radRadialGauge28.BackColor = System.Drawing.Color.White
            Me.radRadialGauge28.CausesValidation = False
            Me.radRadialGauge28.Controls.Add(Me.radRadialGauge29)
            Me.radRadialGauge28.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc53, Me.radialGaugeArc54, Me.radialGaugeSingleLabel8})
            Me.radRadialGauge28.Location = New System.Drawing.Point(240, 211)
            Me.radRadialGauge28.Name = "radRadialGauge28"
            Me.radRadialGauge28.RangeEnd = 100.0R
            Me.radRadialGauge28.RangeStart = 0.0R
            Me.radRadialGauge28.Size = New System.Drawing.Size(204, 210)
            Me.radRadialGauge28.StartAngle = 180.0R
            Me.radRadialGauge28.SweepAngle = 180.0R
            Me.radRadialGauge28.TabIndex = 6
            Me.radRadialGauge28.Text = "radRadialGauge1"
            Me.radRadialGauge28.Value = 60.0F
            ' 
            ' radRadialGauge29
            ' 

            Me.radRadialGauge29.BackColor = System.Drawing.Color.White
            Me.radRadialGauge29.CausesValidation = False
            Me.radRadialGauge29.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc55, Me.radialGaugeNeedle29})
            Me.radRadialGauge29.Location = New System.Drawing.Point(1, 101)
            Me.radRadialGauge29.Name = "radRadialGauge29"
            Me.radRadialGauge29.RangeEnd = 100.0R
            Me.radRadialGauge29.RangeStart = 0.0R
            Me.radRadialGauge29.Size = New System.Drawing.Size(204, 210)
            Me.radRadialGauge29.StartAngle = 180.0R
            Me.radRadialGauge29.SweepAngle = 180.0R
            Me.radRadialGauge29.TabIndex = 6
            Me.radRadialGauge29.Text = "radRadialGauge1"
            Me.radRadialGauge29.Value = 80.0F
            ' 
            ' radialGaugeArc55
            ' 
            Me.radialGaugeArc55.BackColor = System.Drawing.Color.Red
            Me.radialGaugeArc55.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(121))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(80))))))
            Me.radialGaugeArc55.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow
            Me.radialGaugeArc55.Name = "radialGaugeArc55"
            Me.radialGaugeArc55.Radius = 0.0R
            Me.radialGaugeArc55.RangeEnd = 100.0R
            Me.radialGaugeArc55.RangeStart = 0.0R
            Me.radialGaugeArc55.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc55.Width = 44.0R
            ' 
            ' radialGaugeNeedle29
            ' 
            Me.radialGaugeNeedle29.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle29.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle29.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle29.BindValue = True
            Me.radialGaugeNeedle29.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle29.LenghtPercentage = 94.0R
            Me.radialGaugeNeedle29.Name = "radialGaugeNeedle29"
            Me.radialGaugeNeedle29.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle29.Thickness = 5.0R
            Me.radialGaugeNeedle29.Value = 80.0F
            Me.radialGaugeNeedle29.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeArc53
            ' 
            Me.radialGaugeArc53.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(252))))), (CInt(Fix((CByte(152))))), (CInt(Fix((CByte(38))))))
            Me.radialGaugeArc53.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(252))))), (CInt(Fix((CByte(152))))), (CInt(Fix((CByte(38))))))
            Me.radialGaugeArc53.BindEndRange = True
            Me.radialGaugeArc53.Name = "radialGaugeArc53"
            Me.radialGaugeArc53.Radius = 0.0R
            Me.radialGaugeArc53.RangeEnd = 60.0R
            Me.radialGaugeArc53.RangeStart = 0.0R
            Me.radialGaugeArc53.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc53.Width = 40.0R
            ' 
            ' radialGaugeArc54
            ' 
            Me.radialGaugeArc54.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc54.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc54.BindStartRange = True
            Me.radialGaugeArc54.Name = "radialGaugeArc54"
            Me.radialGaugeArc54.Radius = 0.0R
            Me.radialGaugeArc54.RangeEnd = 100.0R
            Me.radialGaugeArc54.RangeStart = 60.0R
            Me.radialGaugeArc54.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc54.Width = 40.0R
            ' 
            ' radialGaugeSingleLabel8
            ' 
            Me.radialGaugeSingleLabel8.BindValue = True
            Me.radialGaugeSingleLabel8.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(252))))), (CInt(Fix((CByte(152))))), (CInt(Fix((CByte(38))))))
            Me.radialGaugeSingleLabel8.LabelFontSize = 10.0F
            Me.radialGaugeSingleLabel8.LabelText = "Text"
            Me.radialGaugeSingleLabel8.LocationPercentage = New System.Drawing.SizeF(0.0F, -0.2F)
            Me.radialGaugeSingleLabel8.Name = "radialGaugeSingleLabel8"
            Me.radialGaugeSingleLabel8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge27
            ' 

            Me.radRadialGauge27.BackColor = System.Drawing.Color.White
            Me.radRadialGauge27.CausesValidation = False
            Me.radRadialGauge27.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc51, Me.radialGaugeArc52, Me.radialGaugeLabels20, Me.radialGaugeTicks49, Me.radialGaugeSingleLabel7})
            Me.radRadialGauge27.Location = New System.Drawing.Point(4, 211)
            Me.radRadialGauge27.Name = "radRadialGauge27"
            Me.radRadialGauge27.RangeEnd = 180.0R
            Me.radRadialGauge27.RangeStart = 0.0R
            Me.radRadialGauge27.Size = New System.Drawing.Size(229, 210)
            Me.radRadialGauge27.StartAngle = 120.0R
            Me.radRadialGauge27.SweepAngle = 300.0R
            Me.radRadialGauge27.TabIndex = 6
            Me.radRadialGauge27.Text = "radRadialGauge1"
            Me.radRadialGauge27.Value = 90.0F
            ' 
            ' radialGaugeArc51
            ' 
            Me.radialGaugeArc51.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc51.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc51.Name = "radialGaugeArc51"
            Me.radialGaugeArc51.Radius = 80.0R
            Me.radialGaugeArc51.RangeEnd = 0.0R
            Me.radialGaugeArc51.RangeStart = 120.0R
            Me.radialGaugeArc51.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc51.Width = 15.0R
            ' 
            ' radialGaugeArc52
            ' 
            Me.radialGaugeArc52.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(181))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(181))))))
            Me.radialGaugeArc52.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc52.Name = "radialGaugeArc52"
            Me.radialGaugeArc52.Radius = 80.0R
            Me.radialGaugeArc52.RangeEnd = 180.0R
            Me.radialGaugeArc52.RangeStart = 120.0R
            Me.radialGaugeArc52.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc52.Width = 15.0R
            ' 
            ' radialGaugeLabels20
            ' 
            Me.radialGaugeLabels20.DrawText = False
            Me.radialGaugeLabels20.LabelFontSize = 5.0F
            Me.radialGaugeLabels20.LabelRadiusPercentage = 108.0F
            Me.radialGaugeLabels20.LabelsCount = 9
            Me.radialGaugeLabels20.Name = "radialGaugeLabels20"
            Me.radialGaugeLabels20.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks49
            ' 
            Me.radialGaugeTicks49.CircleTicks = True
            Me.radialGaugeTicks49.DrawText = False
            Me.radialGaugeTicks49.Name = "radialGaugeTicks49"
            Me.radialGaugeTicks49.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(109))))), (CInt(Fix((CByte(109))))), (CInt(Fix((CByte(109))))))
            Me.radialGaugeTicks49.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks49.TicksCount = 18
            Me.radialGaugeTicks49.TicksLenghtPercentage = 1.0F
            Me.radialGaugeTicks49.TicksOffset = 4
            Me.radialGaugeTicks49.TicksRadiusPercentage = 95.0F
            Me.radialGaugeTicks49.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks49.TickThickness = 1.0F
            Me.radialGaugeTicks49.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel7
            ' 
            Me.radialGaugeSingleLabel7.BindValue = True
            Me.radialGaugeSingleLabel7.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeSingleLabel7.LabelText = "Text"
            Me.radialGaugeSingleLabel7.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.0F)
            Me.radialGaugeSingleLabel7.Name = "radialGaugeSingleLabel7"
            Me.radialGaugeSingleLabel7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge26
            ' 

            Me.radRadialGauge26.BackColor = System.Drawing.Color.White
            Me.radRadialGauge26.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc49, Me.radialGaugeArc50, Me.radialGaugeTicks47, Me.radialGaugeTicks48, Me.radialGaugeNeedle27, Me.radialGaugeNeedle28})
            Me.radRadialGauge26.Location = New System.Drawing.Point(661, 4)
            Me.radRadialGauge26.Name = "radRadialGauge26"
            Me.radRadialGauge26.RangeEnd = 100.0R
            Me.radRadialGauge26.RangeStart = 0.0R
            Me.radRadialGauge26.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge26.StartAngle = 0.0R
            Me.radRadialGauge26.SweepAngle = 360.0R
            Me.radRadialGauge26.TabIndex = 6
            Me.radRadialGauge26.Text = "radRadialGauge1"
            Me.radRadialGauge26.Value = 90.0F
            ' 
            ' radialGaugeArc49
            ' 
            Me.radialGaugeArc49.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc49.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc49.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow2
            Me.radialGaugeArc49.Name = "radialGaugeArc49"
            Me.radialGaugeArc49.Radius = 0.0R
            Me.radialGaugeArc49.RangeEnd = 102.0R
            Me.radialGaugeArc49.RangeStart = 50.1R
            Me.radialGaugeArc49.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc49.Width = 2.0R
            ' 
            ' radialGaugeArc50
            ' 
            Me.radialGaugeArc50.BrushType = Telerik.WinControls.UI.Gauges.GaugeBrushType.Rainbow3
            Me.radialGaugeArc50.Name = "radialGaugeArc50"
            Me.radialGaugeArc50.Radius = 0.0R
            Me.radialGaugeArc50.RangeEnd = 51.0R
            Me.radialGaugeArc50.RangeStart = -1.0R
            Me.radialGaugeArc50.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc50.Width = 2.0R
            ' 
            ' radialGaugeTicks47
            ' 
            Me.radialGaugeTicks47.DrawText = False
            Me.radialGaugeTicks47.Name = "radialGaugeTicks47"
            Me.radialGaugeTicks47.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks47.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks47.TicksCount = 24
            Me.radialGaugeTicks47.TicksLenghtPercentage = 2.0F
            Me.radialGaugeTicks47.TicksOffset = 6
            Me.radialGaugeTicks47.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks47.TickThickness = 1.0F
            Me.radialGaugeTicks47.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks48
            ' 
            Me.radialGaugeTicks48.DrawText = False
            Me.radialGaugeTicks48.Name = "radialGaugeTicks48"
            Me.radialGaugeTicks48.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks48.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks48.TicksCount = 72
            Me.radialGaugeTicks48.TicksLenghtPercentage = 1.0F
            Me.radialGaugeTicks48.TicksOffset = 1
            Me.radialGaugeTicks48.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks48.TickThickness = 1.0F
            Me.radialGaugeTicks48.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle27
            ' 
            Me.radialGaugeNeedle27.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle27.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle27.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle27.BindValue = True
            Me.radialGaugeNeedle27.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle27.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle27.Name = "radialGaugeNeedle27"
            Me.radialGaugeNeedle27.PointRadiusPercentage = 4.0R
            Me.radialGaugeNeedle27.Thickness = 1.0R
            Me.radialGaugeNeedle27.Value = 90.0F
            Me.radialGaugeNeedle27.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle28
            ' 
            Me.radialGaugeNeedle28.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle28.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle28.BackLenghtPercentage = -55.0R
            Me.radialGaugeNeedle28.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle28.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle28.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle28.Name = "radialGaugeNeedle28"
            Me.radialGaugeNeedle28.PointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle28.Thickness = 8.0R
            Me.radialGaugeNeedle28.Value = 60.0F
            Me.radialGaugeNeedle28.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge25
            ' 

            Me.radRadialGauge25.BackColor = System.Drawing.Color.White
            Me.radRadialGauge25.CausesValidation = False
            Me.radRadialGauge25.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc48, Me.radialGaugeTicks46, Me.radialGaugeNeedle26, Me.radialGaugeLabels19})
            Me.radRadialGauge25.Location = New System.Drawing.Point(447, 4)
            Me.radRadialGauge25.Name = "radRadialGauge25"
            Me.radRadialGauge25.RangeEnd = 100.0R
            Me.radRadialGauge25.RangeStart = 50.0R
            Me.radRadialGauge25.Size = New System.Drawing.Size(207, 200)
            Me.radRadialGauge25.StartAngle = 270.0R
            Me.radRadialGauge25.SweepAngle = 90.0R
            Me.radRadialGauge25.TabIndex = 6
            Me.radRadialGauge25.Text = "radRadialGauge1"
            Me.radRadialGauge25.Value = 90.0F
            ' 
            ' radialGaugeArc48
            ' 
            Me.radialGaugeArc48.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))))
            Me.radialGaugeArc48.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))), (CInt(Fix((CByte(104))))))
            Me.radialGaugeArc48.Name = "radialGaugeArc48"
            Me.radialGaugeArc48.Radius = 90.0R
            Me.radialGaugeArc48.RangeEnd = 100.0R
            Me.radialGaugeArc48.RangeStart = 0.0R
            Me.radialGaugeArc48.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc48.Width = 1.0R
            ' 
            ' radialGaugeTicks46
            ' 
            Me.radialGaugeTicks46.CircleTicks = True
            Me.radialGaugeTicks46.DrawText = False
            Me.radialGaugeTicks46.Name = "radialGaugeTicks46"
            Me.radialGaugeTicks46.TickColor = System.Drawing.Color.Black
            Me.radialGaugeTicks46.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks46.TicksCount = 6
            Me.radialGaugeTicks46.TicksLenghtPercentage = 2.0F
            Me.radialGaugeTicks46.TicksOffset = 0
            Me.radialGaugeTicks46.TicksRadiusPercentage = 89.0F
            Me.radialGaugeTicks46.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks46.TickThickness = 1.0F
            Me.radialGaugeTicks46.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle26
            ' 
            Me.radialGaugeNeedle26.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle26.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle26.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle26.BindValue = True
            Me.radialGaugeNeedle26.InnerPointRadiusPercentage = 1.0R
            Me.radialGaugeNeedle26.LenghtPercentage = 120.0R
            Me.radialGaugeNeedle26.Name = "radialGaugeNeedle26"
            Me.radialGaugeNeedle26.PointRadiusPercentage = 3.0R
            Me.radialGaugeNeedle26.Thickness = 1.0R
            Me.radialGaugeNeedle26.Value = 90.0F
            Me.radialGaugeNeedle26.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels19
            ' 
            Me.radialGaugeLabels19.DrawText = False
            Me.radialGaugeLabels19.LabelFontSize = 5.0F
            Me.radialGaugeLabels19.LabelRadiusPercentage = 105.0F
            Me.radialGaugeLabels19.LabelsCount = 1
            Me.radialGaugeLabels19.Name = "radialGaugeLabels19"
            Me.radialGaugeLabels19.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge24
            ' 

            Me.radRadialGauge24.BackColor = System.Drawing.Color.White
            Me.radRadialGauge24.CausesValidation = False
            Me.radRadialGauge24.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc47, Me.radialGaugeNeedle25, Me.radialGaugeTicks43, Me.radialGaugeTicks44, Me.radialGaugeTicks45})
            Me.radRadialGauge24.Location = New System.Drawing.Point(241, 4)
            Me.radRadialGauge24.Name = "radRadialGauge24"
            Me.radRadialGauge24.RangeEnd = 100.0R
            Me.radRadialGauge24.RangeStart = 0.0R
            Me.radRadialGauge24.Size = New System.Drawing.Size(200, 200)
            Me.radRadialGauge24.StartAngle = 180.0R
            Me.radRadialGauge24.SweepAngle = 180.0R
            Me.radRadialGauge24.TabIndex = 3
            Me.radRadialGauge24.Text = "radRadialGauge4"
            Me.radRadialGauge24.Value = 90.0F
            ' 
            ' radialGaugeArc47
            ' 
            Me.radialGaugeArc47.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc47.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc47.Name = "radialGaugeArc47"
            Me.radialGaugeArc47.Radius = 0.0R
            Me.radialGaugeArc47.RangeEnd = 100.0R
            Me.radialGaugeArc47.RangeStart = 0.0R
            Me.radialGaugeArc47.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc47.Width = 1.0R
            ' 
            ' radialGaugeNeedle25
            ' 
            Me.radialGaugeNeedle25.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle25.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle25.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle25.BindValue = True
            Me.radialGaugeNeedle25.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle25.LenghtPercentage = 80.0R
            Me.radialGaugeNeedle25.Name = "radialGaugeNeedle25"
            Me.radialGaugeNeedle25.PointRadiusPercentage = 5.0R
            Me.radialGaugeNeedle25.Thickness = 5.0R
            Me.radialGaugeNeedle25.Value = 90.0F
            Me.radialGaugeNeedle25.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks43
            ' 
            Me.radialGaugeTicks43.DrawText = False
            Me.radialGaugeTicks43.Name = "radialGaugeTicks43"
            Me.radialGaugeTicks43.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks43.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks43.TicksCount = 12
            Me.radialGaugeTicks43.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks43.TicksOffset = 5
            Me.radialGaugeTicks43.TickStartIndexVisibleRange = 1.0F
            Me.radialGaugeTicks43.TickThickness = 1.0F
            Me.radialGaugeTicks43.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks44
            ' 
            Me.radialGaugeTicks44.DrawText = False
            Me.radialGaugeTicks44.Name = "radialGaugeTicks44"
            Me.radialGaugeTicks44.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks44.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks44.TicksCount = 36
            Me.radialGaugeTicks44.TicksLenghtPercentage = 5.0F
            Me.radialGaugeTicks44.TicksOffset = 0
            Me.radialGaugeTicks44.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks44.TickThickness = 1.0F
            Me.radialGaugeTicks44.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks45
            ' 
            Me.radialGaugeTicks45.DrawText = False
            Me.radialGaugeTicks45.Name = "radialGaugeTicks45"
            Me.radialGaugeTicks45.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks45.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks45.TicksCount = 1
            Me.radialGaugeTicks45.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks45.TicksOffset = 0
            Me.radialGaugeTicks45.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks45.TickThickness = 1.0F
            Me.radialGaugeTicks45.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radRadialGauge23
            ' 

            Me.radRadialGauge23.BackColor = System.Drawing.Color.White
            Me.radRadialGauge23.CausesValidation = False
            Me.radRadialGauge23.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc45, Me.radialGaugeArc46, Me.radialGaugeTicks39, Me.radialGaugeTicks40, Me.radialGaugeTicks41, Me.radialGaugeTicks42, Me.radialGaugeLabels17, Me.radialGaugeLabels18, Me.radialGaugeNeedle23, Me.radialGaugeNeedle24})
            Me.radRadialGauge23.Location = New System.Drawing.Point(4, 4)
            Me.radRadialGauge23.Name = "radRadialGauge23"
            Me.radRadialGauge23.RangeEnd = 180.0R
            Me.radRadialGauge23.RangeStart = 0.0R
            Me.radRadialGauge23.Size = New System.Drawing.Size(229, 200)
            Me.radRadialGauge23.StartAngle = 120.0R
            Me.radRadialGauge23.SweepAngle = 300.0R
            Me.radRadialGauge23.TabIndex = 1
            Me.radRadialGauge23.Text = "radRadialGauge2"
            Me.radRadialGauge23.Value = 90.0F
            ' 
            ' radialGaugeArc45
            ' 
            Me.radialGaugeArc45.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc45.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc45.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc45.Name = "radialGaugeArc45"
            Me.radialGaugeArc45.Radius = 0.0R
            Me.radialGaugeArc45.RangeEnd = 120.0R
            Me.radialGaugeArc45.RangeStart = 0.0R
            Me.radialGaugeArc45.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc45.Width = 1.0R
            ' 
            ' radialGaugeArc46
            ' 
            Me.radialGaugeArc46.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc46.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeArc46.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc46.Name = "radialGaugeArc46"
            Me.radialGaugeArc46.Radius = 0.0R
            Me.radialGaugeArc46.RangeEnd = 180.0R
            Me.radialGaugeArc46.RangeStart = 120.0R
            Me.radialGaugeArc46.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc46.Width = 1.0R
            ' 
            ' radialGaugeTicks39
            ' 
            Me.radialGaugeTicks39.DrawText = False
            Me.radialGaugeTicks39.Name = "radialGaugeTicks39"
            Me.radialGaugeTicks39.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks39.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks39.TicksCount = 18
            Me.radialGaugeTicks39.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks39.TicksOffset = 0
            Me.radialGaugeTicks39.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks39.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks39.TickThickness = 1.0F
            Me.radialGaugeTicks39.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks40
            ' 
            Me.radialGaugeTicks40.DrawText = False
            Me.radialGaugeTicks40.Name = "radialGaugeTicks40"
            Me.radialGaugeTicks40.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks40.TickEndIndexVisibleRange = 35.0F
            Me.radialGaugeTicks40.TicksCount = 54
            Me.radialGaugeTicks40.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks40.TicksOffset = 0
            Me.radialGaugeTicks40.TickStartIndexVisibleRange = Nothing
            Me.radialGaugeTicks40.TickThickness = 1.0F
            Me.radialGaugeTicks40.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks41
            ' 
            Me.radialGaugeTicks41.DrawText = False
            Me.radialGaugeTicks41.Name = "radialGaugeTicks41"
            Me.radialGaugeTicks41.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks41.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks41.TicksCount = 18
            Me.radialGaugeTicks41.TicksLenghtPercentage = 10.0F
            Me.radialGaugeTicks41.TicksOffset = 0
            Me.radialGaugeTicks41.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks41.TickStartIndexVisibleRange = 12.0F
            Me.radialGaugeTicks41.TickThickness = 1.0F
            Me.radialGaugeTicks41.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks42
            ' 
            Me.radialGaugeTicks42.DrawText = False
            Me.radialGaugeTicks42.Name = "radialGaugeTicks42"
            Me.radialGaugeTicks42.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks42.TickEndIndexVisibleRange = Nothing
            Me.radialGaugeTicks42.TicksCount = 54
            Me.radialGaugeTicks42.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks42.TicksOffset = 0
            Me.radialGaugeTicks42.TickStartIndexVisibleRange = 37.0F
            Me.radialGaugeTicks42.TickThickness = 1.0F
            Me.radialGaugeTicks42.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels17
            ' 
            Me.radialGaugeLabels17.DrawText = False
            Me.radialGaugeLabels17.LabelEndVisibleRange = 100.0F
            Me.radialGaugeLabels17.LabelFontSize = 4.0F
            Me.radialGaugeLabels17.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels17.LabelsCount = 9
            Me.radialGaugeLabels17.Name = "radialGaugeLabels17"
            Me.radialGaugeLabels17.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels18
            ' 
            Me.radialGaugeLabels18.DrawText = False
            Me.radialGaugeLabels18.ForeColor = System.Drawing.Color.Red
            Me.radialGaugeLabels18.LabelFontSize = 4.0F
            Me.radialGaugeLabels18.LabelRadiusPercentage = 75.0F
            Me.radialGaugeLabels18.LabelsCount = 9
            Me.radialGaugeLabels18.LabelStartVisibleRange = 120.0F
            Me.radialGaugeLabels18.Name = "radialGaugeLabels18"
            Me.radialGaugeLabels18.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle23
            ' 
            Me.radialGaugeNeedle23.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle23.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeNeedle23.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle23.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle23.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle23.Name = "radialGaugeNeedle23"
            Me.radialGaugeNeedle23.PointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle23.Thickness = 2.0R
            Me.radialGaugeNeedle23.Value = 90.0F
            Me.radialGaugeNeedle23.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle24
            ' 
            Me.radialGaugeNeedle24.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle24.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle24.BackLenghtPercentage = 10.0R
            Me.radialGaugeNeedle24.BindValue = True
            Me.radialGaugeNeedle24.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle24.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle24.Name = "radialGaugeNeedle24"
            Me.radialGaugeNeedle24.PointRadiusPercentage = 6.0R
            Me.radialGaugeNeedle24.Thickness = 2.0R
            Me.radialGaugeNeedle24.Value = 90.0F
            Me.radialGaugeNeedle24.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
            Me.radRadioButton3.TabStop = True
            Me.radRadioButton3.Text = "Standard"
            Me.radRadioButton3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            '			Me.radRadioButton3.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
            ' 
            ' radRadioButton2
            ' 
            Me.radRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButton2.Location = New System.Drawing.Point(5, 47)
            Me.radRadioButton2.Name = "radRadioButton2"
            Me.radRadioButton2.Size = New System.Drawing.Size(60, 18)
            Me.radRadioButton2.TabIndex = 1
            Me.radRadioButton2.Text = "Vibrant"
            '			Me.radRadioButton2.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
            ' 
            ' radRadioButton1
            ' 
            Me.radRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radRadioButton1.Location = New System.Drawing.Point(5, 71)
            Me.radRadioButton1.Name = "radRadioButton1"
            Me.radRadioButton1.Size = New System.Drawing.Size(54, 18)
            Me.radRadioButton1.TabIndex = 0
            Me.radRadioButton1.Text = "Minimalistic"
            '			Me.radRadioButton1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radPanel2)
            Me.Controls.Add(Me.radPanel1)
            Me.Controls.Add(Me.radPanel3)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1203, 838)
            Me.Controls.SetChildIndex(Me.radPanel3, 0)
            Me.Controls.SetChildIndex(Me.radPanel1, 0)
            Me.Controls.SetChildIndex(Me.radPanel2, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            Me.settingsPanel.PerformLayout()
            Me.radPanel1.PanelContainer.ResumeLayout(False)
            CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            CType(Me.radRadialGauge11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radRadialGauge6.ResumeLayout(False)
            CType(Me.radRadialGauge7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel2.PanelContainer.ResumeLayout(False)
            CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel2.ResumeLayout(False)
            CType(Me.radRadialGauge22, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge17, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radRadialGauge17.ResumeLayout(False)
            CType(Me.radRadialGauge18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge15, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel3.PanelContainer.ResumeLayout(False)
            CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel3.ResumeLayout(False)
            CType(Me.radRadialGauge33, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge32, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge31, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge30, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge28, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radRadialGauge28.ResumeLayout(False)
            CType(Me.radRadialGauge29, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge27, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge26, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge25, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge24, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge23, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBox1.ResumeLayout(False)
            Me.radGroupBox1.PerformLayout()
            CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private radPanel1 As Telerik.WinControls.UI.RadScrollablePanel
        Private radRadialGauge5 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc6 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc7 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeLabels4 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeTicks11 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeSingleLabel1 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radRadialGauge4 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc5 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks9 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks10 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle5 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeNeedle6 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge3 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc4 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks8 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle4 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeLabels3 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radRadialGauge2 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc3 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle3 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeTicks5 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks6 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks7 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge1 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc1 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc2 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks1 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks2 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks3 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks4 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels1 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeLabels2 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle1 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeNeedle2 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge6 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radRadialGauge7 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc10 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc11 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle7 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeArc8 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc9 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeSingleLabel2 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radRadialGauge11 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc20 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc21 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeLabels7 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeTicks17 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge10 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc17 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc18 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc19 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks16 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels6 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle10 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge9 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc14 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc15 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc16 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks12 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks13 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle9 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeTicks14 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks15 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge8 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc12 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc13 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle8 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeLabels5 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeSingleLabel3 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radPanel2 As Telerik.WinControls.UI.RadScrollablePanel
        Private radRadialGauge17 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc29 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc30 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeSingleLabel5 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radRadialGauge16 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc27 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc28 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeLabels11 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeTicks28 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeSingleLabel4 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radRadialGauge14 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc25 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks25 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle14 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeLabels10 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radRadialGauge13 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc24 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle13 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeTicks22 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks23 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks24 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge12 As Telerik.WinControls.UI.Gauges.RadRadialGauge
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
        Private radRadialGauge15 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc26 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks26 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks27 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle15 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeNeedle16 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge18 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc31 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc32 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle17 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge22 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc41 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc42 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeLabels14 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeTicks34 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge21 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc38 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc39 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc40 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks33 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels13 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle20 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge20 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc35 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc36 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc37 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks29 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks30 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle19 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeTicks31 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks32 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge19 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc33 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc34 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle18 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeLabels12 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeSingleLabel6 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radPanel3 As Telerik.WinControls.UI.RadScrollablePanel
        Private radialGaugeArc43 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc44 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks35 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks36 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks37 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks38 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels15 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeLabels16 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle21 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeNeedle22 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge23 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radRadialGauge28 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radRadialGauge29 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc55 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle29 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeArc53 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc54 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeSingleLabel8 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radRadialGauge27 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc51 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc52 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeLabels20 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeTicks49 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeSingleLabel7 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radRadialGauge26 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc49 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc50 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks47 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks48 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle27 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeNeedle28 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge25 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc48 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks46 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle26 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeLabels19 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radRadialGauge24 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc47 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle25 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeTicks43 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks44 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks45 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeArc45 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc46 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks39 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks40 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks41 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks42 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels17 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeLabels18 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle23 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeNeedle24 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge33 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc64 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc65 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeLabels23 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeTicks55 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge32 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc61 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc62 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc63 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks54 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels22 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle32 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radRadialGauge31 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc58 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc59 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc60 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks50 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks51 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeNeedle31 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeTicks52 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks53 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radRadialGauge30 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc56 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc57 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle30 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeLabels21 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeSingleLabel9 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    End Class
End Namespace