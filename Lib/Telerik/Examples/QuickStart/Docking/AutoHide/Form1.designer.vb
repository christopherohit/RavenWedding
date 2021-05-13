Namespace Telerik.Examples.WinControls.Docking.AutoHide
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
			Me.timer1 = New Timer(Me.components)
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radSplitContainer3 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.toolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.toolTabStrip5 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow4 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radSplitContainer4 = New Telerik.WinControls.UI.RadSplitContainer()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			CType(Me.radSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer3.SuspendLayout()
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer2.SuspendLayout()
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip2.SuspendLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip1.SuspendLayout()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer1.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			Me.documentWindow1.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip4.SuspendLayout()
			CType(Me.toolTabStrip5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip5.SuspendLayout()
			CType(Me.radSplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(552, 1)
			' 
			' 
			' 
			Me.settingsPanel.Size = New Size(200, 723)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' timer1
			' 
			Me.timer1.Interval = 800

			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.toolWindow2
			Me.radDock1.Controls.Add(Me.radSplitContainer3)
			Me.radDock1.Controls.Add(Me.toolTabStrip5)
			Me.radDock1.Cursor = Cursors.Arrow
			Me.radDock1.Dock = DockStyle.Fill
			Me.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
			Me.radDock1.Location = New Point(5, 5)
			Me.radDock1.MainDocumentContainer = Me.documentContainer1
			Me.radDock1.Name = "radDock1"
			Me.radDock1.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New Size(25, 25)
			Me.radDock1.Size = New Size(743, 715)
			Me.radDock1.TabIndex = 1
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Location = New Point(1, 26)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.Size = New Size(571, 130)
			Me.toolWindow2.Text = "toolWindow2"
			' 
			' radSplitContainer3
			' 
			Me.radSplitContainer3.Controls.Add(Me.radSplitContainer2)
			Me.radSplitContainer3.Controls.Add(Me.toolTabStrip4)
			Me.radSplitContainer3.Cursor = Cursors.Arrow
			Me.radSplitContainer3.Location = New Point(0, 0)
			Me.radSplitContainer3.Name = "radSplitContainer3"
			' 
			' 
			' 
			Me.radSplitContainer3.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer3.Size = New Size(743, 556)
			Me.radSplitContainer3.SizeInfo.AbsoluteSize = New Size(200, 554)
			Me.radSplitContainer3.SizeInfo.SplitterCorrection = New Size(0, 44)
			Me.radSplitContainer3.TabIndex = 0
			Me.radSplitContainer3.TabStop = False
			' 
			' radSplitContainer2
			' 
			Me.radSplitContainer2.Controls.Add(Me.toolTabStrip2)
			Me.radSplitContainer2.Controls.Add(Me.radSplitContainer1)
			Me.radSplitContainer2.Location = New Point(0, 0)
			Me.radSplitContainer2.Name = "radSplitContainer2"
			Me.radSplitContainer2.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.radSplitContainer2.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer2.Size = New Size(573, 556)
			Me.radSplitContainer2.SizeInfo.AbsoluteSize = New Size(1005, 200)
			Me.radSplitContainer2.SizeInfo.SplitterCorrection = New Size(33, 0)
			Me.radSplitContainer2.TabIndex = 0
			Me.radSplitContainer2.TabStop = False
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Top
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New Point(0, 0)
			Me.toolTabStrip2.Name = "toolTabStrip2"
			' 
			' 
			' 
			Me.toolTabStrip2.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip2.SelectedIndex = 0
			Me.toolTabStrip2.Size = New Size(573, 157)
			Me.toolTabStrip2.SizeInfo.AbsoluteSize = New Size(200, 157)
			Me.toolTabStrip2.SizeInfo.SplitterCorrection = New Size(0, -43)
			Me.toolTabStrip2.TabIndex = 1
			Me.toolTabStrip2.TabStop = False
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip1)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer1)
			Me.radSplitContainer1.Cursor = Cursors.Arrow
			Me.radSplitContainer1.Location = New Point(0, 160)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.Size = New Size(573, 396)
			Me.radSplitContainer1.SizeInfo.AbsoluteSize = New Size(200, 350)
			Me.radSplitContainer1.SizeInfo.SplitterCorrection = New Size(0, 43)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip1
			' 
			Me.toolTabStrip1.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Left
			Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip1.Location = New Point(0, 0)
			Me.toolTabStrip1.Name = "toolTabStrip1"
			' 
			' 
			' 
			Me.toolTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New Size(178, 396)
			Me.toolTabStrip1.SizeInfo.AbsoluteSize = New Size(178, 200)
			Me.toolTabStrip1.SizeInfo.SplitterCorrection = New Size(-22, 0)
			Me.toolTabStrip1.TabIndex = 1
			Me.toolTabStrip1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Location = New Point(1, 26)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.Size = New Size(176, 369)
			Me.toolWindow1.Text = "toolWindow1"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Location = New Point(181, 0)
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New Size(25, 25)
			Me.documentContainer1.Size = New Size(392, 396)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.TabIndex = 2
			Me.documentContainer1.TabStop = False
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New Size(392, 396)
			Me.documentTabStrip1.SizeInfo.AbsoluteSize = New Size(791, 200)
			Me.documentTabStrip1.SizeInfo.SplitterCorrection = New Size(22, 0)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Controls.Add(Me.radGroupBox2)
			Me.documentWindow1.Controls.Add(Me.radGroupBox1)
			Me.documentWindow1.Location = New Point(5, 27)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.Size = New Size(382, 364)
			Me.documentWindow1.Text = "Demo options"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.radButton1)
			Me.radGroupBox2.Controls.Add(Me.radButton2)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New Padding(0)
			Me.radGroupBox2.HeaderText = "Toggle ToolWindows Visibility"
			Me.radGroupBox2.Location = New Point(251, 12)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(214, 141)
			Me.radGroupBox2.TabIndex = 5
			Me.radGroupBox2.Text = "Toggle ToolWindows Visibility"
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.None
			Me.radButton1.Location = New Point(61, 45)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.Size = New Size(92, 26)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "Hide all"

			' 
			' radButton2
			' 
			Me.radButton2.Anchor = AnchorStyles.None
			Me.radButton2.Location = New Point(61, 77)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.Size = New Size(92, 26)
			Me.radButton2.TabIndex = 1
			Me.radButton2.Text = "Show all"

			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radButton3)
			Me.radGroupBox1.Controls.Add(Me.radButton4)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Toggle ToolWindows Dock State"
			Me.radGroupBox1.Location = New Point(3, 12)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(214, 141)
			Me.radGroupBox1.TabIndex = 4
			Me.radGroupBox1.Text = "Toggle ToolWindows Dock State"
			' 
			' radButton3
			' 
			Me.radButton3.Anchor = AnchorStyles.None
			Me.radButton3.Location = New Point(61, 45)
			Me.radButton3.Name = "radButton3"
			' 
			' 
			' 
			Me.radButton3.Size = New Size(92, 26)
			Me.radButton3.TabIndex = 2
			Me.radButton3.Text = "Dock all"

			' 
			' radButton4
			' 
			Me.radButton4.Anchor = AnchorStyles.None
			Me.radButton4.Location = New Point(61, 77)
			Me.radButton4.Name = "radButton4"
			' 
			' 
			' 
			Me.radButton4.Size = New Size(92, 26)
			Me.radButton4.TabIndex = 3
			Me.radButton4.Text = "Auto-hide all"

			' 
			' toolTabStrip4
			' 
			Me.toolTabStrip4.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Right
			Me.toolTabStrip4.Controls.Add(Me.toolWindow3)
			Me.toolTabStrip4.Location = New Point(576, 0)
			Me.toolTabStrip4.Name = "toolTabStrip4"
			' 
			' 
			' 
			Me.toolTabStrip4.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip4.SelectedIndex = 0
			Me.toolTabStrip4.Size = New Size(167, 556)
			Me.toolTabStrip4.SizeInfo.AbsoluteSize = New Size(167, 200)
			Me.toolTabStrip4.SizeInfo.SplitterCorrection = New Size(-33, 0)
			Me.toolTabStrip4.TabIndex = 1
			Me.toolTabStrip4.TabStop = False
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Location = New Point(1, 26)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.Size = New Size(165, 529)
			Me.toolWindow3.Text = "toolWindow3"
			' 
			' toolTabStrip5
			' 
			Me.toolTabStrip5.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Bottom
			Me.toolTabStrip5.Controls.Add(Me.toolWindow4)
			Me.toolTabStrip5.Location = New Point(0, 559)
			Me.toolTabStrip5.Name = "toolTabStrip5"
			' 
			' 
			' 
			Me.toolTabStrip5.RootElement.ForeColor = Color.Black
			Me.toolTabStrip5.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip5.SelectedIndex = 0
			Me.toolTabStrip5.Size = New Size(743, 156)
			Me.toolTabStrip5.SizeInfo.AbsoluteSize = New Size(200, 156)
			Me.toolTabStrip5.SizeInfo.SplitterCorrection = New Size(0, -44)
			Me.toolTabStrip5.TabIndex = 1
			Me.toolTabStrip5.TabStop = False
			' 
			' toolWindow4
			' 
			Me.toolWindow4.Location = New Point(1, 26)
			Me.toolWindow4.Name = "toolWindow4"
			Me.toolWindow4.Size = New Size(741, 129)
			Me.toolWindow4.Text = "toolWindow4"
			' 
			' radSplitContainer4
			' 
			Me.radSplitContainer4.Location = New Point(0, 0)
			Me.radSplitContainer4.Name = "radSplitContainer4"
			Me.radSplitContainer4.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.radSplitContainer4.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer4.Size = New Size(200, 200)
			Me.radSplitContainer4.TabIndex = 0
			Me.radSplitContainer4.TabStop = False
			Me.radSplitContainer4.Visible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Controls.Add(Me.radDock1)
            Me.Name = "Form1"
			Me.Size = New Size(753, 725)
			Me.Controls.SetChildIndex(Me.radDock1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			CType(Me.radSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer3.ResumeLayout(False)
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer2.ResumeLayout(False)
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip2.ResumeLayout(False)
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip1.ResumeLayout(False)
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer1.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			Me.documentWindow1.ResumeLayout(False)
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip4.ResumeLayout(False)
			CType(Me.toolTabStrip5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip5.ResumeLayout(False)
			CType(Me.radSplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSplitContainer4 As Telerik.WinControls.UI.RadSplitContainer
		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow4 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer3 As Telerik.WinControls.UI.RadSplitContainer
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private toolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolTabStrip5 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private timer1 As Timer
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radButton4 As Telerik.WinControls.UI.RadButton
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox


	End Class
End Namespace
