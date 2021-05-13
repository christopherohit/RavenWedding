Namespace Telerik.Examples.WinControls.Docking.DragDrop
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.tool1Drag = New Telerik.WinControls.UI.RadCheckBox()
			Me.tool2Drag = New Telerik.WinControls.UI.RadCheckBox()
			Me.tool3Drop = New Telerik.WinControls.UI.RadCheckBox()
			Me.allowDockBottom = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer2.SuspendLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip1.SuspendLayout()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer1.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip2.SuspendLayout()
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip3.SuspendLayout()
			CType(Me.tool1Drag, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tool2Drag, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tool3Drop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.allowDockBottom, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBox1)
			Me.settingsPanel.Controls.Add(Me.allowDockBottom)
			Me.settingsPanel.Controls.Add(Me.tool3Drop)
			Me.settingsPanel.Controls.Add(Me.tool2Drag)
			Me.settingsPanel.Controls.Add(Me.tool1Drag)
			Me.settingsPanel.Location = New Point(552, 1)
			Me.settingsPanel.Size = New Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.tool1Drag, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.tool2Drag, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.tool3Drop, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.allowDockBottom, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBox1, 0)
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.documentWindow1
			Me.radDock1.Controls.Add(Me.radSplitContainer2)
			Me.radDock1.Controls.Add(Me.toolTabStrip3)
			Me.radDock1.Dock = DockStyle.Fill
			Me.radDock1.IsCleanUpTarget = True
			Me.radDock1.Location = New Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer1
			Me.radDock1.Name = "radDock1"
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New Size(25, 25)
			Me.radDock1.RootElement.Padding = New Padding(5)
			Me.radDock1.Size = New Size(1334, 754)
			Me.radDock1.TabIndex = 1
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Location = New Point(6, 29)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow1.Size = New Size(904, 505)
			Me.documentWindow1.Text = "documentWindow1"
			' 
			' radSplitContainer2
			' 
			Me.radSplitContainer2.Controls.Add(Me.radSplitContainer1)
			Me.radSplitContainer2.Controls.Add(Me.toolTabStrip2)
			Me.radSplitContainer2.Cursor = Cursors.Arrow
			Me.radSplitContainer2.IsCleanUpTarget = True
			Me.radSplitContainer2.Location = New Point(5, 5)
			Me.radSplitContainer2.Name = "radSplitContainer2"
			Me.radSplitContainer2.Orientation = Orientation.Horizontal
			Me.radSplitContainer2.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radSplitContainer2.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer2.RootElement.Padding = New Padding(5)
			Me.radSplitContainer2.Size = New Size(1120, 744)
			Me.radSplitContainer2.SplitterWidth = 4
			Me.radSplitContainer2.TabIndex = 0
			Me.radSplitContainer2.TabStop = False
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip1)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer1)
			Me.radSplitContainer1.Cursor = Cursors.Arrow
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			Me.radSplitContainer1.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.RootElement.Padding = New Padding(5)
			Me.radSplitContainer1.Size = New Size(1120, 540)
			Me.radSplitContainer1.SplitterWidth = 4
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip1
			' 
			Me.toolTabStrip1.CanUpdateChildIndex = True
			Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip1.Location = New Point(0, 0)
			Me.toolTabStrip1.Name = "toolTabStrip1"
			' 
			' 
			' 
			Me.toolTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New Size(200, 540)
			Me.toolTabStrip1.TabIndex = 1
			Me.toolTabStrip1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Caption = Nothing
			Me.toolWindow1.Location = New Point(1, 24)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow1.Size = New Size(198, 514)
			Me.toolWindow1.Text = "toolWindow1"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New Size(25, 25)
			Me.documentContainer1.RootElement.Padding = New Padding(5)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.CanUpdateChildIndex = True
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New Size(916, 540)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.CanUpdateChildIndex = True
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New Point(0, 544)
			Me.toolTabStrip2.Name = "toolTabStrip2"
			' 
			' 
			' 
			Me.toolTabStrip2.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip2.SelectedIndex = 0
			Me.toolTabStrip2.Size = New Size(1120, 200)
			Me.toolTabStrip2.TabIndex = 1
			Me.toolTabStrip2.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Caption = Nothing
			Me.toolWindow2.Location = New Point(1, 24)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow2.Size = New Size(1118, 174)
			Me.toolWindow2.Text = "toolWindow2"
			' 
			' toolTabStrip3
			' 
			Me.toolTabStrip3.CanUpdateChildIndex = True
			Me.toolTabStrip3.Controls.Add(Me.toolWindow3)
			Me.toolTabStrip3.Location = New Point(1129, 5)
			Me.toolTabStrip3.Name = "toolTabStrip3"
			' 
			' 
			' 
			Me.toolTabStrip3.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip3.SelectedIndex = 0
			Me.toolTabStrip3.Size = New Size(200, 744)
			Me.toolTabStrip3.TabIndex = 1
			Me.toolTabStrip3.TabStop = False
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Caption = Nothing
			Me.toolWindow3.Location = New Point(1, 24)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow3.Size = New Size(198, 718)
			Me.toolWindow3.Text = "toolWindow3"
			' 
			' tool1Drag
			' 
			Me.tool1Drag.Anchor = AnchorStyles.Top
			Me.tool1Drag.Location = New Point(10, 9)
			Me.tool1Drag.Name = "tool1Drag"
			Me.tool1Drag.Size = New Size(146, 18)
			Me.tool1Drag.TabIndex = 0
			Me.tool1Drag.Text = "Allow toolWindow1 Drag"
			Me.tool1Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' tool2Drag
			' 
			Me.tool2Drag.Anchor = AnchorStyles.Top
			Me.tool2Drag.Location = New Point(10, 29)
			Me.tool2Drag.Name = "tool2Drag"
			Me.tool2Drag.Size = New Size(146, 18)
			Me.tool2Drag.TabIndex = 1
			Me.tool2Drag.Text = "Allow toolWindow2 Drag"
			Me.tool2Drag.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' tool3Drop
			' 
			Me.tool3Drop.Anchor = AnchorStyles.Top
			Me.tool3Drop.Location = New Point(10, 49)
			Me.tool3Drop.Name = "tool3Drop"
			Me.tool3Drop.Size = New Size(189, 18)
			Me.tool3Drop.TabIndex = 2
			Me.tool3Drop.Text = "Allow Drop on toolWindow3 Only"
			' 
			' allowDockBottom
			' 
			Me.allowDockBottom.Anchor = AnchorStyles.Top
			Me.allowDockBottom.Location = New Point(10, 69)
			Me.allowDockBottom.Name = "allowDockBottom"
			Me.allowDockBottom.Size = New Size(182, 18)
			Me.allowDockBottom.TabIndex = 3
			Me.allowDockBottom.Text = "Allow DockPosition.Bottom Only"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.Anchor = AnchorStyles.Top
			Me.radCheckBox1.Location = New Point(10, 89)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.AutoSize = False
			Me.radCheckBox1.Size = New Size(144, 18)
			Me.radCheckBox1.TabIndex = 4
			Me.radCheckBox1.Text = "Preview DragDrop Mode"

            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			Me.Size = New Size(1334, 754)
			Me.Controls.SetChildIndex(Me.radDock1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer2.ResumeLayout(False)
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip1.ResumeLayout(False)
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer1.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip2.ResumeLayout(False)
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip3.ResumeLayout(False)
			CType(Me.tool1Drag, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tool2Drag, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tool3Drop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.allowDockBottom, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private tool1Drag As Telerik.WinControls.UI.RadCheckBox
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private tool3Drop As Telerik.WinControls.UI.RadCheckBox
		Private tool2Drag As Telerik.WinControls.UI.RadCheckBox
		Private allowDockBottom As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
