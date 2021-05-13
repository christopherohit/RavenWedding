Namespace Telerik.Examples.WinControls.Docking.CommandManager
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
			Me.documentWindow4 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow3 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.enableManager = New Telerik.WinControls.UI.RadCheckBox()
			Me.commandList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.executeCommand = New Telerik.WinControls.UI.RadButton()
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
			CType(Me.enableManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.commandList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.executeCommand, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.enableManager)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(552, 1)
			Me.settingsPanel.Size = New Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.enableManager, 0)
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.documentWindow4
			Me.radDock1.Controls.Add(Me.radSplitContainer2)
			Me.radDock1.Controls.Add(Me.toolTabStrip3)
			Me.radDock1.Dock = DockStyle.Fill
			Me.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
			Me.radDock1.Location = New Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer1
			Me.radDock1.Name = "radDock1"
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New Size(25, 25)
			Me.radDock1.Size = New Size(753, 808)
			Me.radDock1.TabIndex = 1
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' documentWindow4
			' 
			Me.documentWindow4.Location = New Point(5, 27)
			Me.documentWindow4.Name = "documentWindow4"
			Me.documentWindow4.Size = New Size(337, 573)
			Me.documentWindow4.Text = "documentWindow4"
			' 
			' radSplitContainer2
			' 
			Me.radSplitContainer2.Controls.Add(Me.radSplitContainer1)
			Me.radSplitContainer2.Controls.Add(Me.toolTabStrip2)
			Me.radSplitContainer2.Cursor = Cursors.Arrow
			Me.radSplitContainer2.IsCleanUpTarget = True
			Me.radSplitContainer2.Location = New Point(0, 0)
			Me.radSplitContainer2.Name = "radSplitContainer2"
			Me.radSplitContainer2.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.radSplitContainer2.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer2.Size = New Size(550, 808)
			Me.radSplitContainer2.TabIndex = 0
			Me.radSplitContainer2.TabStop = False
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip1)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer1)
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.Size = New Size(550, 605)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip1
			' 
			Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip1.Location = New Point(0, 0)
			Me.toolTabStrip1.Name = "toolTabStrip1"
			' 
			' 
			' 
			Me.toolTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New Size(200, 605)
			Me.toolTabStrip1.TabIndex = 1
			Me.toolTabStrip1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Location = New Point(1, 26)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.Size = New Size(198, 578)
			Me.toolWindow1.Text = "toolWindow1"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Location = New Point(203, 0)
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New Size(25, 25)
			Me.documentContainer1.Size = New Size(347, 605)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.TabIndex = 0
			Me.documentContainer1.TabStop = False
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.Controls.Add(Me.documentWindow4)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow3)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow2)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New Size(347, 605)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow3
			' 
			Me.documentWindow3.Location = New Point(5, 27)
			Me.documentWindow3.Name = "documentWindow3"
			Me.documentWindow3.Size = New Size(816, 367)
			Me.documentWindow3.Text = "documentWindow3"
			' 
			' documentWindow2
			' 
			Me.documentWindow2.Location = New Point(5, 27)
			Me.documentWindow2.Name = "documentWindow2"
			Me.documentWindow2.Size = New Size(816, 367)
			Me.documentWindow2.Text = "documentWindow2"
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Location = New Point(5, 27)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.Size = New Size(816, 367)
			Me.documentWindow1.Text = "documentWindow1"
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New Point(0, 608)
			Me.toolTabStrip2.Name = "toolTabStrip2"
			' 
			' 
			' 
			Me.toolTabStrip2.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip2.SelectedIndex = 0
			Me.toolTabStrip2.Size = New Size(550, 200)
			Me.toolTabStrip2.TabIndex = 1
			Me.toolTabStrip2.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Location = New Point(1, 26)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.Size = New Size(548, 173)
			Me.toolWindow2.Text = "toolWindow2"
			' 
			' toolTabStrip3
			' 
			Me.toolTabStrip3.Controls.Add(Me.toolWindow3)
			Me.toolTabStrip3.Location = New Point(553, 0)
			Me.toolTabStrip3.Name = "toolTabStrip3"
			' 
			' 
			' 
			Me.toolTabStrip3.RootElement.MinSize = New Size(25, 25)
			Me.toolTabStrip3.SelectedIndex = 0
			Me.toolTabStrip3.Size = New Size(200, 808)
			Me.toolTabStrip3.TabIndex = 1
			Me.toolTabStrip3.TabStop = False
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Location = New Point(1, 26)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.Size = New Size(198, 781)
			Me.toolWindow3.Text = "toolWindow3"
			' 
			' enableManager
			' 
			Me.enableManager.Anchor = AnchorStyles.Top
			Me.enableManager.AutoSize = True
			Me.enableManager.Location = New Point(10, 37)
			Me.enableManager.Name = "enableManager"
			Me.enableManager.Size = New Size(156, 14)
			Me.enableManager.TabIndex = 1
			Me.enableManager.Text = "Enable Command Manager"
			Me.enableManager.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' commandList
			' 
			Me.commandList.Anchor = AnchorStyles.Top
			Me.commandList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.commandList.Location = New Point(13, 23)
			Me.commandList.Name = "commandList"
			' 
			' 
			' 
			Me.commandList.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.commandList.RootElement.ForeColor = Color.Black
			Me.commandList.Size = New Size(154, 20)
			Me.commandList.TabIndex = 3
			Me.commandList.TabStop = False
			Me.commandList.Text = "radComboBox1"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.executeCommand)
			Me.radGroupBox1.Controls.Add(Me.commandList)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Available Commands"
			Me.radGroupBox1.Location = New Point(10, 57)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 83)
			Me.radGroupBox1.TabIndex = 4
			Me.radGroupBox1.Text = "Available Commands"
			' 
			' executeCommand
			' 
			Me.executeCommand.Location = New Point(92, 49)
			Me.executeCommand.Name = "executeCommand"
			Me.executeCommand.Size = New Size(75, 23)
			Me.executeCommand.TabIndex = 4
			Me.executeCommand.Text = "Execute"

            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			Me.Size = New Size(753, 808)
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
			CType(Me.enableManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.commandList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.executeCommand, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow4 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow3 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private enableManager As Telerik.WinControls.UI.RadCheckBox
		Private commandList As Telerik.WinControls.UI.RadDropDownList
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private executeCommand As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
