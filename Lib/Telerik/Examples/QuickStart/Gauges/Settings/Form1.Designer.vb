Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Gauges.Settings
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New System.ComponentModel.Container()
            Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Me.radRadialGauge1 = New Telerik.WinControls.UI.Gauges.RadRadialGauge()
            Me.radialGaugeArc1 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc2 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeArc3 = New Telerik.WinControls.UI.Gauges.RadialGaugeArc()
            Me.radialGaugeTicks1 = New Telerik.WinControls.UI.Gauges.RadialGaugeTicks()
            Me.radialGaugeLabels1 = New Telerik.WinControls.UI.Gauges.RadialGaugeLabels()
            Me.radialGaugeNeedle1 = New Telerik.WinControls.UI.Gauges.RadialGaugeNeedle()
            Me.spinNeedleLenght = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinArc1Radius = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinArc1Width = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinLabelRadius = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinLabelCount = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinTicksLenght = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinTickTickness = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinTicksCount = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinPointRadiusPercentage = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinInnerPointRadiusPercentage = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinNeedleThickness = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel13 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel9 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.radLabel16 = New Telerik.WinControls.UI.RadLabel()
            Me.colorBoxTicks = New Telerik.WinControls.UI.RadColorBox()
            Me.radLabel17 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel18 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel19 = New Telerik.WinControls.UI.RadLabel()
            Me.radLabel20 = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel21 = New Telerik.WinControls.UI.RadLabel()
            Me.colorBoxArc = New Telerik.WinControls.UI.RadColorBox()
            Me.radLabel11 = New Telerik.WinControls.UI.RadLabel()
            Me.radButton1 = New Telerik.WinControls.UI.RadButton()
            Me.radButton2 = New Telerik.WinControls.UI.RadButton()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadialGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinNeedleLenght, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinArc1Radius, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinArc1Width, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinLabelRadius, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinLabelCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinTicksLenght, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinTickTickness, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinTicksCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinPointRadiusPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinInnerPointRadiusPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinNeedleThickness, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.colorBoxTicks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.colorBoxArc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(5, 39)
            Me.settingsPanel.Size = New System.Drawing.Size(230, 755)
            '
            'radRadialGauge1
            '
            Me.radRadialGauge1.BackColor = System.Drawing.Color.White
            Me.radRadialGauge1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radialGaugeArc1, Me.radialGaugeArc2, Me.radialGaugeArc3, Me.radialGaugeTicks1, Me.radialGaugeLabels1, Me.radialGaugeNeedle1})
            Me.radRadialGauge1.Location = New System.Drawing.Point(7, 7)
            Me.radRadialGauge1.Name = "radRadialGauge1"
            Me.radRadialGauge1.RangeEnd = 180.0R
            Me.radRadialGauge1.Size = New System.Drawing.Size(400, 400)
            Me.radRadialGauge1.StartAngle = 130.0R
            Me.radRadialGauge1.SweepAngle = 280.0R
            Me.radRadialGauge1.TabIndex = 6
            Me.radRadialGauge1.Text = "radRadialGauge1"
            '
            'radialGaugeArc1
            '
            Me.radialGaugeArc1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(103, Byte), Integer))
            Me.radialGaugeArc1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(103, Byte), Integer))
            Me.radialGaugeArc1.Name = "radialGaugeArc1"
            Me.radialGaugeArc1.Radius = 99.0R
            Me.radialGaugeArc1.RangeEnd = 60.0R
            Me.radialGaugeArc1.Width = 3.0R
            '
            'radialGaugeArc2
            '
            Me.radialGaugeArc2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
            Me.radialGaugeArc2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
            Me.radialGaugeArc2.Name = "radialGaugeArc2"
            Me.radialGaugeArc2.Radius = 99.0R
            Me.radialGaugeArc2.RangeEnd = 120.0R
            Me.radialGaugeArc2.RangeStart = 61.0R
            Me.radialGaugeArc2.Width = 3.0R
            '
            'radialGaugeArc3
            '
            Me.radialGaugeArc3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
            Me.radialGaugeArc3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
            Me.radialGaugeArc3.Name = "radialGaugeArc3"
            Me.radialGaugeArc3.Radius = 99.0R
            Me.radialGaugeArc3.RangeEnd = 180.0R
            Me.radialGaugeArc3.RangeStart = 121.0R
            Me.radialGaugeArc3.Width = 3.0R
            '
            'radialGaugeTicks1
            '
            Me.radialGaugeTicks1.DrawText = False
            Me.radialGaugeTicks1.Name = "radialGaugeTicks1"
            Me.radialGaugeTicks1.TickColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
            Me.radialGaugeTicks1.TicksCount = 18
            Me.radialGaugeTicks1.TicksLenghtPercentage = 4.0!
            Me.radialGaugeTicks1.TicksRadiusPercentage = 83.0!
            Me.radialGaugeTicks1.TickThickness = 1.0!
            '
            'radialGaugeLabels1
            '
            Me.radialGaugeLabels1.DrawText = False
            Me.radialGaugeLabels1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
            Me.radialGaugeLabels1.LabelFontSize = 5.0!
            Me.radialGaugeLabels1.LabelRadiusPercentage = 68.0!
            Me.radialGaugeLabels1.LabelsCount = 9
            Me.radialGaugeLabels1.Name = "radialGaugeLabels1"
            '
            'radialGaugeNeedle1
            '
            Me.radialGaugeNeedle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
            Me.radialGaugeNeedle1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
            Me.radialGaugeNeedle1.BackLenghtPercentage = 0.0R
            Me.radialGaugeNeedle1.InnerPointRadiusPercentage = 0.0R
            Me.radialGaugeNeedle1.LenghtPercentage = 70.0R
            Me.radialGaugeNeedle1.Name = "radialGaugeNeedle1"
            Me.radialGaugeNeedle1.PointRadiusPercentage = 7.0R
            Me.radialGaugeNeedle1.Thickness = 1.5R
            Me.radialGaugeNeedle1.Value = 130.0!
            '
            'spinNeedleLenght
            '
            Me.spinNeedleLenght.Location = New System.Drawing.Point(426, 51)
            Me.spinNeedleLenght.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.spinNeedleLenght.Name = "spinNeedleLenght"
            Me.spinNeedleLenght.Size = New System.Drawing.Size(96, 20)
            Me.spinNeedleLenght.TabIndex = 1
            Me.spinNeedleLenght.TabStop = False
            Me.spinNeedleLenght.Value = New Decimal(New Integer() {70, 0, 0, 0})
            '
            'spinArc1Radius
            '
            Me.spinArc1Radius.Location = New System.Drawing.Point(537, 451)
            Me.spinArc1Radius.Name = "spinArc1Radius"
            Me.spinArc1Radius.Size = New System.Drawing.Size(96, 20)
            Me.spinArc1Radius.TabIndex = 11
            Me.spinArc1Radius.TabStop = False
            Me.spinArc1Radius.Value = New Decimal(New Integer() {99, 0, 0, 0})
            '
            'spinArc1Width
            '
            Me.spinArc1Width.Location = New System.Drawing.Point(426, 451)
            Me.spinArc1Width.Name = "spinArc1Width"
            Me.spinArc1Width.Size = New System.Drawing.Size(96, 20)
            Me.spinArc1Width.TabIndex = 11
            Me.spinArc1Width.TabStop = False
            Me.spinArc1Width.Value = New Decimal(New Integer() {3, 0, 0, 0})
            '
            'spinLabelRadius
            '
            Me.spinLabelRadius.Location = New System.Drawing.Point(537, 319)
            Me.spinLabelRadius.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
            Me.spinLabelRadius.Name = "spinLabelRadius"
            Me.spinLabelRadius.Size = New System.Drawing.Size(96, 20)
            Me.spinLabelRadius.TabIndex = 10
            Me.spinLabelRadius.TabStop = False
            Me.spinLabelRadius.Value = New Decimal(New Integer() {68, 0, 0, 0})
            '
            'spinLabelCount
            '
            Me.spinLabelCount.Location = New System.Drawing.Point(426, 319)
            Me.spinLabelCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.spinLabelCount.Name = "spinLabelCount"
            Me.spinLabelCount.Size = New System.Drawing.Size(96, 20)
            Me.spinLabelCount.TabIndex = 9
            Me.spinLabelCount.TabStop = False
            Me.spinLabelCount.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'spinTicksLenght
            '
            Me.spinTicksLenght.Location = New System.Drawing.Point(537, 185)
            Me.spinTicksLenght.Name = "spinTicksLenght"
            Me.spinTicksLenght.Size = New System.Drawing.Size(96, 20)
            Me.spinTicksLenght.TabIndex = 8
            Me.spinTicksLenght.TabStop = False
            Me.spinTicksLenght.Value = New Decimal(New Integer() {4, 0, 0, 0})
            '
            'spinTickTickness
            '
            Me.spinTickTickness.Location = New System.Drawing.Point(426, 235)
            Me.spinTickTickness.Name = "spinTickTickness"
            Me.spinTickTickness.Size = New System.Drawing.Size(96, 20)
            Me.spinTickTickness.TabIndex = 7
            Me.spinTickTickness.TabStop = False
            Me.spinTickTickness.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'spinTicksCount
            '
            Me.spinTicksCount.Location = New System.Drawing.Point(426, 185)
            Me.spinTicksCount.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.spinTicksCount.Name = "spinTicksCount"
            Me.spinTicksCount.Size = New System.Drawing.Size(96, 20)
            Me.spinTicksCount.TabIndex = 6
            Me.spinTicksCount.TabStop = False
            Me.spinTicksCount.Value = New Decimal(New Integer() {19, 0, 0, 0})
            '
            'spinPointRadiusPercentage
            '
            Me.spinPointRadiusPercentage.Location = New System.Drawing.Point(537, 101)
            Me.spinPointRadiusPercentage.Name = "spinPointRadiusPercentage"
            Me.spinPointRadiusPercentage.Size = New System.Drawing.Size(96, 20)
            Me.spinPointRadiusPercentage.TabIndex = 5
            Me.spinPointRadiusPercentage.TabStop = False
            Me.spinPointRadiusPercentage.Value = New Decimal(New Integer() {7, 0, 0, 0})
            '
            'spinInnerPointRadiusPercentage
            '
            Me.spinInnerPointRadiusPercentage.Location = New System.Drawing.Point(537, 51)
            Me.spinInnerPointRadiusPercentage.Name = "spinInnerPointRadiusPercentage"
            Me.spinInnerPointRadiusPercentage.Size = New System.Drawing.Size(96, 20)
            Me.spinInnerPointRadiusPercentage.TabIndex = 4
            Me.spinInnerPointRadiusPercentage.TabStop = False
            '
            'spinNeedleThickness
            '
            Me.spinNeedleThickness.DecimalPlaces = 1
            Me.spinNeedleThickness.Location = New System.Drawing.Point(426, 101)
            Me.spinNeedleThickness.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinNeedleThickness.Name = "spinNeedleThickness"
            Me.spinNeedleThickness.Size = New System.Drawing.Size(96, 20)
            Me.spinNeedleThickness.TabIndex = 3
            Me.spinNeedleThickness.TabStop = False
            Me.spinNeedleThickness.Value = New Decimal(New Integer() {15, 0, 0, 65536})
            '
            'radLabel7
            '
            Me.radLabel7.Location = New System.Drawing.Point(534, 165)
            Me.radLabel7.Name = "radLabel7"
            Me.radLabel7.Size = New System.Drawing.Size(41, 18)
            Me.radLabel7.TabIndex = 2
            Me.radLabel7.Text = "Lenght"
            '
            'radLabel8
            '
            Me.radLabel8.Location = New System.Drawing.Point(423, 299)
            Me.radLabel8.Name = "radLabel8"
            Me.radLabel8.Size = New System.Drawing.Size(36, 18)
            Me.radLabel8.TabIndex = 2
            Me.radLabel8.Text = "Count"
            '
            'radLabel13
            '
            Me.radLabel13.Location = New System.Drawing.Point(534, 431)
            Me.radLabel13.Name = "radLabel13"
            Me.radLabel13.Size = New System.Drawing.Size(39, 18)
            Me.radLabel13.TabIndex = 2
            Me.radLabel13.Text = "Radius"
            '
            'radLabel10
            '
            Me.radLabel10.Location = New System.Drawing.Point(423, 431)
            Me.radLabel10.Name = "radLabel10"
            Me.radLabel10.Size = New System.Drawing.Size(36, 18)
            Me.radLabel10.TabIndex = 2
            Me.radLabel10.Text = "Width"
            '
            'radLabel6
            '
            Me.radLabel6.Location = New System.Drawing.Point(423, 215)
            Me.radLabel6.Name = "radLabel6"
            Me.radLabel6.Size = New System.Drawing.Size(48, 18)
            Me.radLabel6.TabIndex = 2
            Me.radLabel6.Text = "Tickness"
            '
            'radLabel5
            '
            Me.radLabel5.Location = New System.Drawing.Point(423, 165)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(36, 18)
            Me.radLabel5.TabIndex = 2
            Me.radLabel5.Text = "Count"
            '
            'radLabel9
            '
            Me.radLabel9.Location = New System.Drawing.Point(534, 299)
            Me.radLabel9.Name = "radLabel9"
            Me.radLabel9.Size = New System.Drawing.Size(39, 18)
            Me.radLabel9.TabIndex = 2
            Me.radLabel9.Text = "Radius"
            '
            'radLabel4
            '
            Me.radLabel4.Location = New System.Drawing.Point(534, 82)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(66, 18)
            Me.radLabel4.TabIndex = 2
            Me.radLabel4.Text = "Point radius"
            '
            'radLabel3
            '
            Me.radLabel3.Location = New System.Drawing.Point(534, 31)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(95, 18)
            Me.radLabel3.TabIndex = 2
            Me.radLabel3.Text = "Inner point radius"
            '
            'radLabel2
            '
            Me.radLabel2.Location = New System.Drawing.Point(423, 82)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(48, 18)
            Me.radLabel2.TabIndex = 2
            Me.radLabel2.Text = "Tickness"
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(423, 31)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(41, 18)
            Me.radLabel1.TabIndex = 2
            Me.radLabel1.Text = "Length"
            '
            'radLabel16
            '
            Me.radLabel16.Location = New System.Drawing.Point(534, 215)
            Me.radLabel16.Name = "radLabel16"
            Me.radLabel16.Size = New System.Drawing.Size(33, 18)
            Me.radLabel16.TabIndex = 12
            Me.radLabel16.Text = "Color"
            '
            'colorBoxTicks
            '
            Me.colorBoxTicks.AutoSize = False
            Me.colorBoxTicks.Location = New System.Drawing.Point(537, 235)
            Me.colorBoxTicks.Name = "colorBoxTicks"
            Me.colorBoxTicks.Size = New System.Drawing.Size(96, 22)
            Me.colorBoxTicks.TabIndex = 13
            Me.colorBoxTicks.Text = "radColorBox1"
            Me.colorBoxTicks.Value = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
            '
            'radLabel17
            '
            Me.radLabel17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.radLabel17.Location = New System.Drawing.Point(422, 8)
            Me.radLabel17.Name = "radLabel17"
            Me.radLabel17.Size = New System.Drawing.Size(89, 18)
            Me.radLabel17.TabIndex = 14
            Me.radLabel17.Text = "Needle settings"
            '
            'radLabel18
            '
            Me.radLabel18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.radLabel18.Location = New System.Drawing.Point(423, 140)
            Me.radLabel18.Name = "radLabel18"
            Me.radLabel18.Size = New System.Drawing.Size(78, 18)
            Me.radLabel18.TabIndex = 14
            Me.radLabel18.Text = "Ticks settings"
            '
            'radLabel19
            '
            Me.radLabel19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.radLabel19.Location = New System.Drawing.Point(423, 272)
            Me.radLabel19.Name = "radLabel19"
            Me.radLabel19.Size = New System.Drawing.Size(85, 18)
            Me.radLabel19.TabIndex = 14
            Me.radLabel19.Text = "Labels settings"
            '
            'radLabel20
            '
            Me.radLabel20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.radLabel20.Location = New System.Drawing.Point(423, 356)
            Me.radLabel20.Name = "radLabel20"
            Me.radLabel20.Size = New System.Drawing.Size(74, 18)
            Me.radLabel20.TabIndex = 14
            Me.radLabel20.Text = "Arcs settings"
            '
            'radDropDownList1
            '
            Me.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            RadListDataItem1.Text = "Arc 1"
            RadListDataItem2.Text = "Arc 2"
            RadListDataItem3.Text = "Arc 3"
            Me.radDropDownList1.Items.Add(RadListDataItem1)
            Me.radDropDownList1.Items.Add(RadListDataItem2)
            Me.radDropDownList1.Items.Add(RadListDataItem3)
            Me.radDropDownList1.Location = New System.Drawing.Point(426, 403)
            Me.radDropDownList1.Name = "radDropDownList1"
            Me.radDropDownList1.Size = New System.Drawing.Size(96, 20)
            Me.radDropDownList1.TabIndex = 15
            '
            'radLabel21
            '
            Me.radLabel21.Location = New System.Drawing.Point(423, 383)
            Me.radLabel21.Name = "radLabel21"
            Me.radLabel21.Size = New System.Drawing.Size(55, 18)
            Me.radLabel21.TabIndex = 2
            Me.radLabel21.Text = "Select Arc"
            '
            'colorBoxArc
            '
            Me.colorBoxArc.AutoSize = False
            Me.colorBoxArc.Location = New System.Drawing.Point(537, 403)
            Me.colorBoxArc.Name = "colorBoxArc"
            Me.colorBoxArc.Size = New System.Drawing.Size(96, 22)
            Me.colorBoxArc.TabIndex = 13
            Me.colorBoxArc.Text = "radColorBox1"
            Me.colorBoxArc.Value = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
            '
            'radLabel11
            '
            Me.radLabel11.Location = New System.Drawing.Point(534, 383)
            Me.radLabel11.Name = "radLabel11"
            Me.radLabel11.Size = New System.Drawing.Size(33, 18)
            Me.radLabel11.TabIndex = 2
            Me.radLabel11.Text = "Color"
            '
            'radButton1
            '
            Me.radButton1.Location = New System.Drawing.Point(10, 450)
            Me.radButton1.Name = "radButton1"
            Me.radButton1.Size = New System.Drawing.Size(190, 24)
            Me.radButton1.TabIndex = 16
            Me.radButton1.Text = "Save layout"
            '
            'radButton2
            '
            Me.radButton2.Location = New System.Drawing.Point(210, 450)
            Me.radButton2.Name = "radButton2"
            Me.radButton2.Size = New System.Drawing.Size(190, 24)
            Me.radButton2.TabIndex = 17
            Me.radButton2.Text = "Load layout"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.radButton1)
            Me.Controls.Add(Me.radButton2)
            Me.Controls.Add(Me.radLabel17)
            Me.Controls.Add(Me.radDropDownList1)
            Me.Controls.Add(Me.radLabel6)
            Me.Controls.Add(Me.radLabel20)
            Me.Controls.Add(Me.radLabel5)
            Me.Controls.Add(Me.radRadialGauge1)
            Me.Controls.Add(Me.radLabel19)
            Me.Controls.Add(Me.radLabel3)
            Me.Controls.Add(Me.radLabel7)
            Me.Controls.Add(Me.spinLabelCount)
            Me.Controls.Add(Me.radLabel18)
            Me.Controls.Add(Me.spinLabelRadius)
            Me.Controls.Add(Me.radLabel9)
            Me.Controls.Add(Me.radLabel4)
            Me.Controls.Add(Me.spinPointRadiusPercentage)
            Me.Controls.Add(Me.radLabel2)
            Me.Controls.Add(Me.colorBoxArc)
            Me.Controls.Add(Me.radLabel13)
            Me.Controls.Add(Me.colorBoxTicks)
            Me.Controls.Add(Me.spinArc1Width)
            Me.Controls.Add(Me.spinTicksCount)
            Me.Controls.Add(Me.radLabel21)
            Me.Controls.Add(Me.radLabel16)
            Me.Controls.Add(Me.radLabel11)
            Me.Controls.Add(Me.spinInnerPointRadiusPercentage)
            Me.Controls.Add(Me.spinNeedleLenght)
            Me.Controls.Add(Me.spinTickTickness)
            Me.Controls.Add(Me.radLabel8)
            Me.Controls.Add(Me.spinNeedleThickness)
            Me.Controls.Add(Me.spinArc1Radius)
            Me.Controls.Add(Me.spinTicksLenght)
            Me.Controls.Add(Me.radLabel10)
            Me.Controls.Add(Me.radLabel1)
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1502, 654)
            Me.Controls.SetChildIndex(Me.radLabel1, 0)
            Me.Controls.SetChildIndex(Me.radLabel10, 0)
            Me.Controls.SetChildIndex(Me.spinTicksLenght, 0)
            Me.Controls.SetChildIndex(Me.spinArc1Radius, 0)
            Me.Controls.SetChildIndex(Me.spinNeedleThickness, 0)
            Me.Controls.SetChildIndex(Me.radLabel8, 0)
            Me.Controls.SetChildIndex(Me.spinTickTickness, 0)
            Me.Controls.SetChildIndex(Me.spinNeedleLenght, 0)
            Me.Controls.SetChildIndex(Me.spinInnerPointRadiusPercentage, 0)
            Me.Controls.SetChildIndex(Me.radLabel11, 0)
            Me.Controls.SetChildIndex(Me.radLabel16, 0)
            Me.Controls.SetChildIndex(Me.radLabel21, 0)
            Me.Controls.SetChildIndex(Me.spinTicksCount, 0)
            Me.Controls.SetChildIndex(Me.spinArc1Width, 0)
            Me.Controls.SetChildIndex(Me.colorBoxTicks, 0)
            Me.Controls.SetChildIndex(Me.radLabel13, 0)
            Me.Controls.SetChildIndex(Me.colorBoxArc, 0)
            Me.Controls.SetChildIndex(Me.radLabel2, 0)
            Me.Controls.SetChildIndex(Me.spinPointRadiusPercentage, 0)
            Me.Controls.SetChildIndex(Me.radLabel4, 0)
            Me.Controls.SetChildIndex(Me.radLabel9, 0)
            Me.Controls.SetChildIndex(Me.spinLabelRadius, 0)
            Me.Controls.SetChildIndex(Me.radLabel18, 0)
            Me.Controls.SetChildIndex(Me.spinLabelCount, 0)
            Me.Controls.SetChildIndex(Me.radLabel7, 0)
            Me.Controls.SetChildIndex(Me.radLabel3, 0)
            Me.Controls.SetChildIndex(Me.radLabel19, 0)
            Me.Controls.SetChildIndex(Me.radRadialGauge1, 0)
            Me.Controls.SetChildIndex(Me.radLabel5, 0)
            Me.Controls.SetChildIndex(Me.radLabel20, 0)
            Me.Controls.SetChildIndex(Me.radLabel6, 0)
            Me.Controls.SetChildIndex(Me.radDropDownList1, 0)
            Me.Controls.SetChildIndex(Me.radLabel17, 0)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.Controls.SetChildIndex(Me.radButton2, 0)
            Me.Controls.SetChildIndex(Me.radButton1, 0)
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadialGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinNeedleLenght, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinArc1Radius, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinArc1Width, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinLabelRadius, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinLabelCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinTicksLenght, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinTickTickness, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinTicksCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinPointRadiusPercentage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinInnerPointRadiusPercentage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinNeedleThickness, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.colorBoxTicks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel21, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.colorBoxArc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private radRadialGauge1 As Telerik.WinControls.UI.Gauges.RadRadialGauge
		Private radialGaugeArc1 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
		Private radialGaugeArc2 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
		Private radialGaugeArc3 As Telerik.WinControls.UI.Gauges.RadialGaugeArc
		Private radialGaugeTicks1 As Telerik.WinControls.UI.Gauges.RadialGaugeTicks
		Private radialGaugeLabels1 As Telerik.WinControls.UI.Gauges.RadialGaugeLabels
		Private radialGaugeNeedle1 As Telerik.WinControls.UI.Gauges.RadialGaugeNeedle
		Private WithEvents spinNeedleLenght As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinNeedleThickness As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private timer1 As System.Windows.Forms.Timer
		Private WithEvents spinInnerPointRadiusPercentage As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinPointRadiusPercentage As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinTicksCount As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinTickTickness As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinLabelCount As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinTicksLenght As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinLabelRadius As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel9 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinArc1Width As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel10 As Telerik.WinControls.UI.RadLabel
		Private WithEvents spinArc1Radius As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel13 As Telerik.WinControls.UI.RadLabel
		Private radLabel16 As Telerik.WinControls.UI.RadLabel
		Private WithEvents colorBoxTicks As Telerik.WinControls.UI.RadColorBox
		Private radLabel17 As Telerik.WinControls.UI.RadLabel
		Private radLabel18 As Telerik.WinControls.UI.RadLabel
		Private radLabel19 As Telerik.WinControls.UI.RadLabel
		Private radLabel20 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radDropDownList1 As Telerik.WinControls.UI.RadDropDownList
		Private radLabel21 As Telerik.WinControls.UI.RadLabel
		Private WithEvents colorBoxArc As Telerik.WinControls.UI.RadColorBox
		Private radLabel11 As Telerik.WinControls.UI.RadLabel
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace