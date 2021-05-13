Namespace Telerik.Examples.WinControls.Carousel.Events
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim carouselBezierPath1 As New Telerik.WinControls.UI.CarouselBezierPath()
			Me.imageList4 = New ImageList(Me.components)
			Me.radListEvents = New Telerik.WinControls.UI.RadListControl()
			Me.radCarouselDemo = New Telerik.WinControls.UI.RadCarousel()
			Me.radSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblEvents = New Telerik.WinControls.UI.RadLabel()
			Me.radRadioEllipse = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioBezier = New Telerik.WinControls.UI.RadRadioButton()
			Me.radLblReflectionPerc = New Telerik.WinControls.UI.RadLabel()
			Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radListEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCarouselDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radLblEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioEllipse, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioBezier, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblReflectionPerc, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(1267, 1)
			Me.settingsPanel.Margin = New Padding(4, 4, 4, 4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.PanelContainer.Margin = New Padding(4, 4, 4, 4)
			Me.settingsPanel.PanelContainer.Size = New Size(384, 704)
			Me.settingsPanel.Size = New Size(384, 704)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' imageList4
			' 
			Me.imageList4.ImageStream = (CType(resources.GetObject("imageList4.ImageStream"), ImageListStreamer))
			Me.imageList4.TransparentColor = Color.Transparent
			Me.imageList4.Images.SetKeyName(0, "Carousel01.png")
			Me.imageList4.Images.SetKeyName(1, "Carousel02.png")
			Me.imageList4.Images.SetKeyName(2, "Carousel03.png")
			Me.imageList4.Images.SetKeyName(3, "Carousel04.png")
			Me.imageList4.Images.SetKeyName(4, "Carousel05.png")
			Me.imageList4.Images.SetKeyName(5, "Carousel06.png")
			Me.imageList4.Images.SetKeyName(6, "Carousel07.png")
			' 
			' radListEvents
			' 
			Me.radListEvents.Dock = DockStyle.Fill
			Me.radListEvents.ItemHeight = 24
			Me.radListEvents.Location = New Point(4, 270)
			Me.radListEvents.Margin = New Padding(4, 4, 4, 4)
			Me.radListEvents.Name = "radListEvents"
			Me.radListEvents.Size = New Size(242, 309)
			Me.radListEvents.TabIndex = 1
			' 
			' radCarouselDemo
			' 
			Me.radCarouselDemo.AutoLoopPauseCondition = Telerik.WinControls.UI.AutoLoopPauseConditions.OnMouseOverItem
			Me.radCarouselDemo.BackColor = Color.Transparent
			carouselBezierPath1.CtrlPoint1 = New Telerik.WinControls.UI.Point3D(125.91508052708639R, 91.503267973856211R, 100R)
			carouselBezierPath1.CtrlPoint2 = New Telerik.WinControls.UI.Point3D(64.71449487554905R, -35.62091503267974R, -100R)
			carouselBezierPath1.FirstPoint = New Telerik.WinControls.UI.Point3D(5.2708638360175692R, 10.130718954248366R, 0R)
			carouselBezierPath1.LastPoint = New Telerik.WinControls.UI.Point3D(16.594516594516595R, 79.950495049504951R, 100R)
			carouselBezierPath1.ZScale = 500R
			Me.radCarouselDemo.CarouselPath = carouselBezierPath1
			Me.radCarouselDemo.Dock = DockStyle.Fill
			Me.radCarouselDemo.EnableAutoLoop = True
			Me.radCarouselDemo.Location = New Point(0, 0)
			Me.radCarouselDemo.Margin = New Padding(4, 4, 4, 4)
			Me.radCarouselDemo.Name = "radCarouselDemo"
			Me.radCarouselDemo.Size = New Size(2336, 1468)
			Me.radCarouselDemo.TabIndex = 0
			Me.radCarouselDemo.Text = "radCarousel1"
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.carousel_leftArrow
			CType(Me.radCarouselDemo.GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.carousel_rightArrow
			' 
			' radSpinEditor1
			' 
			Me.radSpinEditor1.DecimalPlaces = 2
			Me.radSpinEditor1.Increment = New Decimal(New Integer() { 1, 0, 0, 131072})
			Me.radSpinEditor1.Location = New Point(4, 118)
			Me.radSpinEditor1.Margin = New Padding(4, 4, 4, 4)
			Me.radSpinEditor1.Maximum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditor1.Name = "radSpinEditor1"
			Me.radSpinEditor1.NullableValue = New Decimal(New Integer() { 33, 0, 0, 131072})
			' 
			' 
			' 
			Me.radSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditor1.Size = New Size(215, 24)
			Me.radSpinEditor1.TabIndex = 7
			Me.radSpinEditor1.TabStop = False
			Me.radSpinEditor1.Value = New Decimal(New Integer() { 33, 0, 0, 131072})
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.CheckState = CheckState.Checked
			Me.radCheckBox1.Location = New Point(4, 156)
			Me.radCheckBox1.Margin = New Padding(4, 4, 4, 4)
			Me.radCheckBox1.Name = "radCheckBox1"
			Me.radCheckBox1.Size = New Size(120, 22)
			Me.radCheckBox1.TabIndex = 10
			Me.radCheckBox1.Text = "Enable Looping"
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.CheckState = CheckState.Checked
			Me.radCheckBox2.Location = New Point(4, 194)
			Me.radCheckBox2.Margin = New Padding(4, 4, 4, 4)
			Me.radCheckBox2.Name = "radCheckBox2"
			Me.radCheckBox2.Size = New Size(134, 22)
			Me.radCheckBox2.TabIndex = 11
			Me.radCheckBox2.Text = "Enable Auto Loop"
			Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupSettings.Anchor = AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.HeaderText = "Carousel Settings"
			Me.radGroupSettings.Location = New Point(29, 40)
			Me.radGroupSettings.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New Padding(3, 22, 3, 2)
			Me.radGroupSettings.Size = New Size(278, 640)
			Me.radGroupSettings.TabIndex = 1
			Me.radGroupSettings.Text = "Carousel Settings"
			' 
			' radLblEvents
			' 
			Me.radLblEvents.Location = New Point(4, 232)
			Me.radLblEvents.Margin = New Padding(4, 4, 4, 4)
			Me.radLblEvents.Name = "radLblEvents"
			Me.radLblEvents.Size = New Size(50, 22)
			Me.radLblEvents.TabIndex = 13
			Me.radLblEvents.Text = "Events:"
			' 
			' radRadioEllipse
			' 
			Me.radRadioEllipse.Location = New Point(4, 42)
			Me.radRadioEllipse.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioEllipse.Name = "radRadioEllipse"
			Me.radRadioEllipse.Size = New Size(95, 22)
			Me.radRadioEllipse.TabIndex = 12
			Me.radRadioEllipse.Text = "Ellipse Path"
			' 
			' radRadioBezier
			' 
			Me.radRadioBezier.Location = New Point(4, 4)
			Me.radRadioBezier.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioBezier.Name = "radRadioBezier"
			Me.radRadioBezier.Size = New Size(93, 22)
			Me.radRadioBezier.TabIndex = 12
			Me.radRadioBezier.Text = "Bezier Path"
			' 
			' radLblReflectionPerc
			' 
			Me.radLblReflectionPerc.Location = New Point(4, 80)
			Me.radLblReflectionPerc.Margin = New Padding(4, 4, 4, 4)
			Me.radLblReflectionPerc.Name = "radLblReflectionPerc"
			Me.radLblReflectionPerc.Size = New Size(176, 22)
			Me.radLblReflectionPerc.TabIndex = 1
			Me.radLblReflectionPerc.Text = "Item Reflection Percentage:"
			' 
			' tableLayoutPanel1
			' 
			Me.doubleBufferedTableLayoutPanel1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.doubleBufferedTableLayoutPanel1.ColumnCount = 1
			Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioBezier, 0, 0)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radListEvents, 0, 7)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLblEvents, 0, 6)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radRadioEllipse, 0, 1)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radLblReflectionPerc, 0, 2)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox2, 0, 5)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radSpinEditor1, 0, 3)
			Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.radCheckBox1, 0, 4)
			Me.doubleBufferedTableLayoutPanel1.Location = New Point(6, 32)
			Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
			Me.doubleBufferedTableLayoutPanel1.RowCount = 8
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.684673F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.68467F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.68467F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.68467F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.68467F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.68467F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.68467F))
			Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 53.2073F))
			Me.doubleBufferedTableLayoutPanel1.Size = New Size(250, 583)
			Me.doubleBufferedTableLayoutPanel1.TabIndex = 14
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
			Me.Controls.Add(Me.radCarouselDemo)
			Me.Name = "Form1"
			Me.Size = New Size(2349, 1480)
			Me.Controls.SetChildIndex(Me.radCarouselDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radListEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCarouselDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			CType(Me.radLblEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioEllipse, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioBezier, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblReflectionPerc, System.ComponentModel.ISupportInitialize).EndInit()
			Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
			Me.doubleBufferedTableLayoutPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCarouselDemo As Telerik.WinControls.UI.RadCarousel
		Private imageList4 As ImageList
		Private radListEvents As Telerik.WinControls.UI.RadListControl
		Private radSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblReflectionPerc As Telerik.WinControls.UI.RadLabel
		Private radRadioEllipse As Telerik.WinControls.UI.RadRadioButton
		Private radRadioBezier As Telerik.WinControls.UI.RadRadioButton
		Private radLblEvents As Telerik.WinControls.UI.RadLabel
		Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
	End Class
End Namespace