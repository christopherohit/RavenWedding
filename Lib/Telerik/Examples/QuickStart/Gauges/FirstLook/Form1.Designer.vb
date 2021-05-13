Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Gauges.FirstLook
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
            Me.radRadialGauge1 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc1 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc2 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks1 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks2 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks3 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks4 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks5 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks7 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks8 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeTicks9 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels1 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeLabels2 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle2 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeTicks6 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radLabel12 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel13 = New Telerik.WinControls.UI.RadLabel()
            Me.radRadialGauge2 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc3 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc4 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle1 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeSingleLabel1 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radLabel14 = New Telerik.WinControls.UI.RadLabel()
            Me.radRadialGauge3 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc5 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc6 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeNeedle3 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.radialGaugeSingleLabel2 = New Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel()
            Me.radLabel15 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' settingsPanel
            ' 
            Me.settingsPanel.Location = New System.Drawing.Point(1000, 33)
            ' 
            ' radLabel1
            ' 
            Me.radLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0F)
            Me.radLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(26))))), (CInt(Fix((CByte(155))))), (CInt(Fix((CByte(86))))))
            Me.radLabel1.Location = New System.Drawing.Point(3, 3)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(196, 23)
            Me.radLabel1.TabIndex = 0
            Me.radLabel1.Text = "CALL CENTER MONITORING"
            ' 
            ' panel1
            ' 
            Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
            Me.panel1.Controls.Add(Me.radLabel9)
            Me.panel1.Controls.Add(Me.radLabel8)
            Me.panel1.Controls.Add(Me.radLabel7)
            Me.panel1.Controls.Add(Me.radLabel6)
            Me.panel1.Controls.Add(Me.radLabel5)
            Me.panel1.Controls.Add(Me.radLabel4)
            Me.panel1.Controls.Add(Me.radLabel3)
            Me.panel1.Controls.Add(Me.radLabel2)
            Me.panel1.Location = New System.Drawing.Point(3, 33)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(676, 73)
            Me.panel1.TabIndex = 1
            ' 
            ' radLabel9
            ' 
            Me.radLabel9.Font = New System.Drawing.Font("Segoe UI", 16.0F)
            Me.radLabel9.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(165))))))
            Me.radLabel9.Location = New System.Drawing.Point(358, 37)
            Me.radLabel9.Name = "radLabel9"
            Me.radLabel9.Size = New System.Drawing.Size(62, 33)
            Me.radLabel9.TabIndex = 1
            Me.radLabel9.Text = "03:37"
            ' 
            ' radLabel8
            ' 
            Me.radLabel8.Font = New System.Drawing.Font("Segoe UI", 16.0F)
            Me.radLabel8.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(165))))))
            Me.radLabel8.Location = New System.Drawing.Point(238, 37)
            Me.radLabel8.Name = "radLabel8"
            Me.radLabel8.Size = New System.Drawing.Size(62, 33)
            Me.radLabel8.TabIndex = 1
            Me.radLabel8.Text = "03:37"
            ' 
            ' radLabel7
            ' 
            Me.radLabel7.Font = New System.Drawing.Font("Segoe UI", 16.0F)
            Me.radLabel7.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(164))))))
            Me.radLabel7.Location = New System.Drawing.Point(134, 37)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(62, 33)
            Me.radLabel7.TabIndex = 1
            Me.radLabel7.Text = "03:37"
            CType(Me.radLabel7.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.TopLeft
            CType(Me.radLabel7.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(79))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(165))))))
            ' 
            ' radLabel6
            ' 
            Me.radLabel6.Font = New System.Drawing.Font("Segoe UI", 16.0F)
            Me.radLabel6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radLabel6.Location = New System.Drawing.Point(8, 37)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(62, 33)
            Me.radLabel6.TabIndex = 1
            Me.radLabel6.Text = "03:37"
            CType(Me.radLabel6.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.TopLeft
            CType(Me.radLabel6.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(91))))))
            ' 
            ' radLabel5
            ' 
            Me.radLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radLabel5.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))))
            Me.radLabel5.Location = New System.Drawing.Point(356, 11)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(111, 21)
            Me.radLabel5.TabIndex = 0
            Me.radLabel5.Text = "AVG No of Holds"
            ' 
            ' radLabel4
            ' 
            Me.radLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radLabel4.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))))
            Me.radLabel4.Location = New System.Drawing.Point(236, 11)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(100, 21)
            Me.radLabel4.TabIndex = 0
            Me.radLabel4.Text = "AVG Hold Time"
            ' 
            ' radLabel3
            ' 
            Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radLabel3.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))))
            Me.radLabel3.Location = New System.Drawing.Point(132, 11)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(91, 21)
            Me.radLabel3.TabIndex = 0
            Me.radLabel3.Text = "Duration Goal"
            ' 
            ' radLabel2
            ' 
            Me.radLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))), (CInt(Fix((CByte(42))))))
            Me.radLabel2.Location = New System.Drawing.Point(10, 11)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(114, 21)
            Me.radLabel2.TabIndex = 0
            Me.radLabel2.Text = "AVG Handle Time"
            ' 
            ' radLabel10
            ' 
            Me.radLabel10.Font = New System.Drawing.Font("Segoe UI", 11.0F)
            Me.radLabel10.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radLabel10.Location = New System.Drawing.Point(3, 137)
            Me.radLabel10.Name = "radLabel10"
            Me.radLabel10.Size = New System.Drawing.Size(153, 23)
            Me.radLabel10.TabIndex = 2
            Me.radLabel10.Text = "Average Call Duration"
            ' 
            ' radLabel11
            ' 
            Me.radLabel11.Font = New System.Drawing.Font("Segoe UI", 11.0F)
            Me.radLabel11.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radLabel11.Location = New System.Drawing.Point(239, 137)
            Me.radLabel11.Name = "radLabel11"
            Me.radLabel11.Size = New System.Drawing.Size(141, 23)
            Me.radLabel11.TabIndex = 2
            Me.radLabel11.Text = "Agents' Productivity"
            ' 
            ' radRadialGauge1
            ' 
            Me.radRadialGauge1.BackColor = System.Drawing.Color.White
            Me.radRadialGauge1.CausesValidation = False
            Me.radRadialGauge1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc1, Me.radialGaugeArc2, Me.radialGaugeTicks1, Me.radialGaugeTicks2, Me.radialGaugeTicks3, Me.radialGaugeTicks4, Me.radialGaugeTicks5, Me.radialGaugeTicks7, Me.radialGaugeTicks8, Me.radialGaugeTicks9, Me.radialGaugeLabels1, Me.radialGaugeLabels2, Me.radialGaugeNeedle2})
            Me.radRadialGauge1.Location = New System.Drawing.Point(17, 220)
            Me.radRadialGauge1.Name = "radRadialGauge1"
            Me.radRadialGauge1.RangeEnd = 9.0R
            Me.radRadialGauge1.Size = New System.Drawing.Size(204, 214)
            Me.radRadialGauge1.TabIndex = 1
            Me.radRadialGauge1.Text = "radRadialGauge2"
            Me.radRadialGauge1.Value = 6.0F
            ' 
            ' radialGaugeArc1
            ' 
            Me.radialGaugeArc1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc1.BackColor2 = System.Drawing.Color.Black
            Me.radialGaugeArc1.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeArc1.Name = "radialGaugeArc1"
            Me.radialGaugeArc1.RangeEnd = 120.0R
            Me.radialGaugeArc1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc1.Width = 1.0R
            ' 
            ' radialGaugeArc2
            ' 
            Me.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeArc2.BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(91))))), (CInt(Fix((CByte(91))))))
            Me.radialGaugeArc2.Name = "radialGaugeArc2"
            Me.radialGaugeArc2.RangeEnd = 180.0R
            Me.radialGaugeArc2.RangeStart = 120.0R
            Me.radialGaugeArc2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc2.Width = 1.0R
            ' 
            ' radialGaugeTicks1
            ' 
            Me.radialGaugeTicks1.DrawText = False
            Me.radialGaugeTicks1.Name = "radialGaugeTicks1"
            Me.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks1.TickEndIndexVisibleRange = 11.0F
            Me.radialGaugeTicks1.TicksCount = 18
            Me.radialGaugeTicks1.TicksRadiusPercentage = 84.0F
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
            Me.radialGaugeTicks2.TickThickness = 1.0F
            Me.radialGaugeTicks2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks3
            ' 
            Me.radialGaugeTicks3.DrawText = False
            Me.radialGaugeTicks3.Name = "radialGaugeTicks3"
            Me.radialGaugeTicks3.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks3.TicksCount = 18
            Me.radialGaugeTicks3.TicksRadiusPercentage = 84.0F
            Me.radialGaugeTicks3.TickStartIndexVisibleRange = 12.0F
            Me.radialGaugeTicks3.TickThickness = 1.0F
            Me.radialGaugeTicks3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks4
            ' 
            Me.radialGaugeTicks4.DrawText = False
            Me.radialGaugeTicks4.Name = "radialGaugeTicks4"
            Me.radialGaugeTicks4.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeTicks4.TicksCount = 54
            Me.radialGaugeTicks4.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks4.TickStartIndexVisibleRange = 37.0F
            Me.radialGaugeTicks4.TickThickness = 1.0F
            Me.radialGaugeTicks4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks5
            ' 
            Me.radialGaugeTicks5.AccessibleDescription = "radialGaugeTicks5"
            Me.radialGaugeTicks5.AccessibleName = "radialGaugeTicks5"
            Me.radialGaugeTicks5.DrawText = False
            Me.radialGaugeTicks5.Name = "radialGaugeTicks5"
            Me.radialGaugeTicks5.Text = "radialGaugeTicks5"
            Me.radialGaugeTicks5.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks5.TickEndIndexVisibleRange = 5.0F
            Me.radialGaugeTicks5.TicksCount = 18
            Me.radialGaugeTicks5.TicksRadiusPercentage = 103.0F
            Me.radialGaugeTicks5.TickStartIndexVisibleRange = 5.0F
            Me.radialGaugeTicks5.TickThickness = 1.0F
            Me.radialGaugeTicks5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks7
            ' 
            Me.radialGaugeTicks7.AccessibleDescription = "radialGaugeTicks7"
            Me.radialGaugeTicks7.AccessibleName = "radialGaugeTicks7"
            Me.radialGaugeTicks7.DrawText = False
            Me.radialGaugeTicks7.Name = "radialGaugeTicks7"
            Me.radialGaugeTicks7.Text = "radialGaugeTicks7"
            Me.radialGaugeTicks7.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks7.TickEndIndexVisibleRange = 9.0F
            Me.radialGaugeTicks7.TicksCount = 18
            Me.radialGaugeTicks7.TicksRadiusPercentage = 103.0F
            Me.radialGaugeTicks7.TickStartIndexVisibleRange = 9.0F
            Me.radialGaugeTicks7.TickThickness = 1.0F
            Me.radialGaugeTicks7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks8
            ' 
            Me.radialGaugeTicks8.AccessibleDescription = "radialGaugeTicks8"
            Me.radialGaugeTicks8.AccessibleName = "radialGaugeTicks8"
            Me.radialGaugeTicks8.CircleTicks = True
            Me.radialGaugeTicks8.DrawText = False
            Me.radialGaugeTicks8.Name = "radialGaugeTicks8"
            Me.radialGaugeTicks8.Text = "radialGaugeTicks8"
            Me.radialGaugeTicks8.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks8.TickEndIndexVisibleRange = 5.0F
            Me.radialGaugeTicks8.TicksCount = 18
            Me.radialGaugeTicks8.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks8.TicksRadiusPercentage = 115.0F
            Me.radialGaugeTicks8.TickStartIndexVisibleRange = 5.0F
            Me.radialGaugeTicks8.TickThickness = 1.0F
            Me.radialGaugeTicks8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks9
            ' 
            Me.radialGaugeTicks9.AccessibleDescription = "radialGaugeTicks9"
            Me.radialGaugeTicks9.AccessibleName = "radialGaugeTicks9"
            Me.radialGaugeTicks9.CircleTicks = True
            Me.radialGaugeTicks9.DrawText = False
            Me.radialGaugeTicks9.Name = "radialGaugeTicks9"
            Me.radialGaugeTicks9.Text = "radialGaugeTicks9"
            Me.radialGaugeTicks9.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks9.TickEndIndexVisibleRange = 9.0F
            Me.radialGaugeTicks9.TicksCount = 18
            Me.radialGaugeTicks9.TicksLenghtPercentage = 3.0F
            Me.radialGaugeTicks9.TicksRadiusPercentage = 115.0F
            Me.radialGaugeTicks9.TickStartIndexVisibleRange = 9.0F
            Me.radialGaugeTicks9.TickThickness = 1.0F
            Me.radialGaugeTicks9.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels1
            ' 
            Me.radialGaugeLabels1.DrawText = False
            Me.radialGaugeLabels1.LabelEndVisibleRange = 5.0F
            Me.radialGaugeLabels1.LabelFontSize = 5.0F
            Me.radialGaugeLabels1.LabelFormat = "#,##0.00#"
            Me.radialGaugeLabels1.LabelRadiusPercentage = 68.0F
            Me.radialGaugeLabels1.LabelsCount = 9
            Me.radialGaugeLabels1.Name = "radialGaugeLabels1"
            Me.radialGaugeLabels1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeLabels2
            ' 
            Me.radialGaugeLabels2.DrawText = False
            Me.radialGaugeLabels2.ForeColor = System.Drawing.Color.Red
            Me.radialGaugeLabels2.LabelFontSize = 5.0F
            Me.radialGaugeLabels2.LabelFormat = "#,##0.00#"
            Me.radialGaugeLabels2.LabelRadiusPercentage = 68.0F
            Me.radialGaugeLabels2.LabelsCount = 9
            Me.radialGaugeLabels2.LabelStartVisibleRange = 6.0F
            Me.radialGaugeLabels2.Name = "radialGaugeLabels2"
            Me.radialGaugeLabels2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeNeedle2
            ' 
            Me.radialGaugeNeedle2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle2.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(90))))), (CInt(Fix((CByte(90))))))
            Me.radialGaugeNeedle2.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle2.BindValue = True
            Me.radialGaugeNeedle2.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle2.LenghtPercentage = 78.0R
            Me.radialGaugeNeedle2.Name = "radialGaugeNeedle2"
            Me.radialGaugeNeedle2.PointRadiusPercentage = 6.0R
            Me.radialGaugeNeedle2.Thickness = 0.2R
            Me.radialGaugeNeedle2.Value = 6.0F
            Me.radialGaugeNeedle2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeTicks6
            ' 
            Me.radialGaugeTicks6.AccessibleDescription = "radialGaugeTicks5"
            Me.radialGaugeTicks6.AccessibleName = "radialGaugeTicks5"
            Me.radialGaugeTicks6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.radialGaugeTicks6.DrawText = False
            Me.radialGaugeTicks6.Name = "radialGaugeTicks6"
            Me.radialGaugeTicks6.Text = "radialGaugeTicks5"
            Me.radialGaugeTicks6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.radialGaugeTicks6.TickColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))), (CInt(Fix((CByte(102))))))
            Me.radialGaugeTicks6.TickEndIndexVisibleRange = 5.0F
            Me.radialGaugeTicks6.TicksCount = 18
            Me.radialGaugeTicks6.TicksRadiusPercentage = 103.0F
            Me.radialGaugeTicks6.TickStartIndexVisibleRange = 5.0F
            Me.radialGaugeTicks6.TickThickness = 1.0F
            Me.radialGaugeTicks6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radLabel12
            ' 
            Me.radLabel12.AutoSize = False
            Me.radLabel12.Font = New System.Drawing.Font("Segoe UI", 8.0F)
            Me.radLabel12.Location = New System.Drawing.Point(0, 231)
            Me.radLabel12.Name = "radLabel12"
            Me.radLabel12.Size = New System.Drawing.Size(68, 31)
            Me.radLabel12.TabIndex = 0
            Me.radLabel12.Text = "Industry best practice"
            ' 
            ' radLabel13
            ' 
            Me.radLabel13.AutoSize = False
            Me.radLabel13.Font = New System.Drawing.Font("Segoe UI", 8.0F)
            Me.radLabel13.Location = New System.Drawing.Point(92, 192)
            Me.radLabel13.Name = "radLabel13"
            Me.radLabel13.Size = New System.Drawing.Size(68, 31)
            Me.radLabel13.TabIndex = 0
            Me.radLabel13.Text = "Company AVG"
            ' 
            ' radRadialGauge2
            ' 
            Me.radRadialGauge2.BackColor = System.Drawing.Color.White
            Me.radRadialGauge2.CausesValidation = False
            Me.radRadialGauge2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc3, Me.radialGaugeArc4, Me.radialGaugeNeedle1, Me.radialGaugeSingleLabel1})
            Me.radRadialGauge2.Location = New System.Drawing.Point(238, 222)
            Me.radRadialGauge2.Name = "radRadialGauge2"
            Me.radRadialGauge2.Size = New System.Drawing.Size(202, 212)
            Me.radRadialGauge2.StartAngle = 180.0R
            Me.radRadialGauge2.SweepAngle = 180.0R
            Me.radRadialGauge2.TabIndex = 6
            Me.radRadialGauge2.Text = "radRadialGauge1"
            Me.radRadialGauge2.Value = 50.0F
            ' 
            ' radialGaugeArc3
            ' 
            Me.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(119))))), (CInt(Fix((CByte(190))))), (CInt(Fix((CByte(79))))))
            Me.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(121))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(80))))))
            Me.radialGaugeArc3.BindEndRange = True
            Me.radialGaugeArc3.Name = "radialGaugeArc3"
            Me.radialGaugeArc3.RangeEnd = 50.0R
            Me.radialGaugeArc3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc3.Width = 40.0R
            ' 
            ' radialGaugeArc4
            ' 
            Me.radialGaugeArc4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc4.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc4.BindStartRange = True
            Me.radialGaugeArc4.Name = "radialGaugeArc4"
            Me.radialGaugeArc4.RangeEnd = 100.0R
            Me.radialGaugeArc4.RangeStart = 50.0R
            Me.radialGaugeArc4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc4.Width = 40.0R
            ' 
            ' radialGaugeNeedle1
            ' 
            Me.radialGaugeNeedle1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle1.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle1.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle1.BindValue = True
            Me.radialGaugeNeedle1.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle1.LenghtPercentage = 94.0R
            Me.radialGaugeNeedle1.Name = "radialGaugeNeedle1"
            Me.radialGaugeNeedle1.Thickness = 0.5R
            Me.radialGaugeNeedle1.Value = 50.0F
            Me.radialGaugeNeedle1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel1
            ' 
            Me.radialGaugeSingleLabel1.AccessibleDescription = "radialGaugeSingleLabel1"
            Me.radialGaugeSingleLabel1.AccessibleName = "radialGaugeSingleLabel1"
            Me.radialGaugeSingleLabel1.BindValue = True
            Me.radialGaugeSingleLabel1.LabelFontSize = 10.0F
            Me.radialGaugeSingleLabel1.LabelFormat = "#"
            Me.radialGaugeSingleLabel1.LabelText = "Text"
            Me.radialGaugeSingleLabel1.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.5F)
            Me.radialGaugeSingleLabel1.Name = "radialGaugeSingleLabel1"
            Me.radialGaugeSingleLabel1.Text = "radialGaugeSingleLabel1"
            Me.radialGaugeSingleLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radLabel14
            ' 
            Me.radLabel14.AutoSize = False
            Me.radLabel14.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radLabel14.Location = New System.Drawing.Point(239, 168)
            Me.radLabel14.Name = "radLabel14"
            Me.radLabel14.Size = New System.Drawing.Size(129, 44)
            Me.radLabel14.TabIndex = 7
            Me.radLabel14.Text = "Contacts handled per agent"
            ' 
            ' radRadialGauge3
            ' 
            Me.radRadialGauge3.BackColor = System.Drawing.Color.White
            Me.radRadialGauge3.CausesValidation = False
            Me.radRadialGauge3.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc5, Me.radialGaugeArc6, Me.radialGaugeNeedle3, Me.radialGaugeSingleLabel2})
            Me.radRadialGauge3.Location = New System.Drawing.Point(468, 222)
            Me.radRadialGauge3.Name = "radRadialGauge3"
            Me.radRadialGauge3.Size = New System.Drawing.Size(211, 212)
            Me.radRadialGauge3.StartAngle = 180.0R
            Me.radRadialGauge3.SweepAngle = 180.0R
            Me.radRadialGauge3.TabIndex = 6
            Me.radRadialGauge3.Text = "radRadialGauge1"
            Me.radRadialGauge3.Value = 50.0F
            ' 
            ' radialGaugeArc5
            ' 
            Me.radialGaugeArc5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(70))))), (CInt(Fix((CByte(71))))))
            Me.radialGaugeArc5.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(70))))), (CInt(Fix((CByte(71))))))
            Me.radialGaugeArc5.BindEndRange = True
            Me.radialGaugeArc5.Name = "radialGaugeArc5"
            Me.radialGaugeArc5.RangeEnd = 50.0R
            Me.radialGaugeArc5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc5.Width = 40.0R
            ' 
            ' radialGaugeArc6
            ' 
            Me.radialGaugeArc6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(193))))))
            Me.radialGaugeArc6.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(194))))))
            Me.radialGaugeArc6.BindStartRange = True
            Me.radialGaugeArc6.Name = "radialGaugeArc6"
            Me.radialGaugeArc6.RangeEnd = 100.0R
            Me.radialGaugeArc6.RangeStart = 50.0R
            Me.radialGaugeArc6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.radialGaugeArc6.Width = 40.0R
            ' 
            ' radialGaugeNeedle3
            ' 
            Me.radialGaugeNeedle3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle3.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))), (CInt(Fix((CByte(51))))))
            Me.radialGaugeNeedle3.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle3.BindValue = True
            Me.radialGaugeNeedle3.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle3.LenghtPercentage = 94.0R
            Me.radialGaugeNeedle3.Name = "radialGaugeNeedle3"
            Me.radialGaugeNeedle3.Thickness = 0.5R
            Me.radialGaugeNeedle3.Value = 50.0F
            Me.radialGaugeNeedle3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radialGaugeSingleLabel2
            ' 
            Me.radialGaugeSingleLabel2.AccessibleDescription = "radialGaugeSingleLabel2"
            Me.radialGaugeSingleLabel2.AccessibleName = "radialGaugeSingleLabel2"
            Me.radialGaugeSingleLabel2.BindValue = True
            Me.radialGaugeSingleLabel2.LabelFontSize = 10.0F
            Me.radialGaugeSingleLabel2.LabelFormat = "#'%"
            Me.radialGaugeSingleLabel2.LabelText = "Text"
            Me.radialGaugeSingleLabel2.LocationPercentage = New System.Drawing.SizeF(0.0F, 0.5F)
            Me.radialGaugeSingleLabel2.Name = "radialGaugeSingleLabel2"
            Me.radialGaugeSingleLabel2.Text = "radialGaugeSingleLabel2"
            Me.radialGaugeSingleLabel2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' radLabel15
            ' 
            Me.radLabel15.AutoSize = False
            Me.radLabel15.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.radLabel15.Location = New System.Drawing.Point(498, 168)
            Me.radLabel15.Name = "radLabel15"
            Me.radLabel15.Size = New System.Drawing.Size(129, 44)
            Me.radLabel15.TabIndex = 7
            Me.radLabel15.Text = "Talk time (%)"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radRadialGauge3)
            Me.Controls.Add(Me.radLabel15)
            Me.Controls.Add(Me.radLabel14)
            Me.Controls.Add(Me.radRadialGauge2)
            Me.Controls.Add(Me.radLabel13)
            Me.Controls.Add(Me.radLabel12)
            Me.Controls.Add(Me.radRadialGauge1)
            Me.Controls.Add(Me.radLabel11)
            Me.Controls.Add(Me.radLabel10)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.radLabel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1532, 878)
            '			Me.Load += New System.EventHandler(Me.Form1_Load);
            Me.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.Controls.SetChildIndex(Me.panel1, 0)
            Me.Controls.SetChildIndex(Me.radLabel10, 0)
            Me.Controls.SetChildIndex(Me.radLabel11, 0)
            Me.Controls.SetChildIndex(Me.radRadialGauge1, 0)
            Me.Controls.SetChildIndex(Me.radLabel12, 0)
            Me.Controls.SetChildIndex(Me.radLabel13, 0)
            Me.Controls.SetChildIndex(Me.radRadialGauge2, 0)
            Me.Controls.SetChildIndex(Me.radLabel14, 0)
            Me.Controls.SetChildIndex(Me.radLabel15, 0)
            Me.Controls.SetChildIndex(Me.radRadialGauge3, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel15, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private panel1 As System.Windows.Forms.Panel
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private radLabel9 As Telerik.WinControls.UI.RadLabel
        Private radLabel8 As Telerik.WinControls.UI.RadLabel
        Private radLabel7 As Telerik.WinControls.UI.RadLabel
        Private radLabel6 As Telerik.WinControls.UI.RadLabel
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private radLabel10 As Telerik.WinControls.UI.RadLabel
        Private radLabel11 As Telerik.WinControls.UI.RadLabel
        Private radRadialGauge1 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc1 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc2 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeTicks1 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks2 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks3 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks4 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeLabels1 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeLabels2 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
        Private radialGaugeNeedle2 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeTicks5 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks6 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks7 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks8 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radialGaugeTicks9 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
        Private radLabel12 As Telerik.WinControls.UI.RadLabel
        Private radLabel13 As Telerik.WinControls.UI.RadLabel
        Private radRadialGauge2 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc3 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc4 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle1 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeSingleLabel1 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radLabel14 As Telerik.WinControls.UI.RadLabel
        Private radRadialGauge3 As Telerik.WinControls.UI.Gauges.RadRadialGauge
        Private radialGaugeArc5 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeArc6 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
        Private radialGaugeNeedle3 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
        Private radialGaugeSingleLabel2 As Telerik.WinControls.UI.Gauges.RadialGaugeSingleLabel
        Private radLabel15 As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace