Namespace Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			Me.radCollapsiblePanel1 = New Telerik.WinControls.UI.RadCollapsiblePanel()
			Me.personInfoControl4 = New Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel.PersonInfoControl()
			Me.personInfoControl1 = New Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel.PersonInfoControl()
			Me.personInfoControl3 = New Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel.PersonInfoControl()
			Me.personInfoControl2 = New Telerik.Examples.WinControls.PanelsLabels.CollapsiblePanel.PersonInfoControl()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.animationEasingTypeDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.animationTypeDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.rightToLeftCheckBox = New Telerik.WinControls.UI.RadCheckBox()
			Me.verticalHeaderAlignmentDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.horizontalHeaderAlignmentDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.showHeaderLineCheckBox = New Telerik.WinControls.UI.RadCheckBox()
			Me.animationFramesSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.animationIntervalSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.contentSizingModeDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.enableAnimationCheckBox = New Telerik.WinControls.UI.RadCheckBox()
			Me.expandDirectionDropDownList = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.radCollapsiblePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radCollapsiblePanel1.PanelContainer.SuspendLayout()
			CType(Me.personInfoControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.personInfoControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.personInfoControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.personInfoControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.animationEasingTypeDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.animationTypeDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rightToLeftCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.verticalHeaderAlignmentDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.horizontalHeaderAlignmentDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showHeaderLineCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.animationFramesSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.animationIntervalSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.contentSizingModeDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.enableAnimationCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.expandDirectionDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(930, 46)
			Me.settingsPanel.Size = New Size(243, 749)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radCollapsiblePanel1)
			Me.radPanelDemoHolder.Location = New Point(0, 0)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			Me.radPanelDemoHolder.Size = New Size(750, 450)
			Me.radPanelDemoHolder.TabIndex = 2
			' 
			' radCollapsiblePanel1
			' 
			Me.radCollapsiblePanel1.Dock = DockStyle.Fill
			Me.radCollapsiblePanel1.Location = New Point(0, 0)
			Me.radCollapsiblePanel1.Name = "radCollapsiblePanel1"
			Me.radCollapsiblePanel1.OwnerBoundsCache = New Rectangle(0, 0, 150, 200)
			' 
			' radCollapsiblePanel1.PanelContainer
			' 

			Me.radCollapsiblePanel1.PanelContainer.Controls.Add(Me.personInfoControl4)
			Me.radCollapsiblePanel1.PanelContainer.Controls.Add(Me.personInfoControl1)
			Me.radCollapsiblePanel1.PanelContainer.Controls.Add(Me.personInfoControl3)
			Me.radCollapsiblePanel1.PanelContainer.Controls.Add(Me.personInfoControl2)
			Me.radCollapsiblePanel1.PanelContainer.Size = New Size(748, 422)
			Me.radCollapsiblePanel1.Size = New Size(750, 450)
			Me.radCollapsiblePanel1.TabIndex = 0
			Me.radCollapsiblePanel1.Text = "radCollapsiblePanel1"
			' 
			' personInfoControl4
			' 
			Me.personInfoControl4.Location = New Point(387, 73)
			Me.personInfoControl4.Name = "personInfoControl4"
			Me.personInfoControl4.PersonEmail = "Email: BobSmiil@mail.com"
			Me.personInfoControl4.PersonImage = (CType(resources.GetObject("personInfoControl4.PersonImage"), Image))
			Me.personInfoControl4.PersonName = "Bob Smiil"
			Me.personInfoControl4.PersonPhone = "Phone: 333 2334"
			Me.personInfoControl4.Size = New Size(300, 123)
			Me.personInfoControl4.TabIndex = 2
			Me.personInfoControl4.Text = "personInfoControl4"
			' 
			' personInfoControl1
			' 
			Me.personInfoControl1.Location = New Point(64, 73)
			Me.personInfoControl1.Name = "personInfoControl1"
			Me.personInfoControl1.PersonEmail = "Email: BobSmiil@mail.com"
			Me.personInfoControl1.PersonImage = (CType(resources.GetObject("personInfoControl1.PersonImage"), Image))
			Me.personInfoControl1.PersonName = "Bob Smiil"
			Me.personInfoControl1.PersonPhone = "Phone: 333 2334"
			Me.personInfoControl1.Size = New Size(300, 123)
			Me.personInfoControl1.TabIndex = 2
			Me.personInfoControl1.Text = "personInfoControl1"
			' 
			' personInfoControl3
			' 
			Me.personInfoControl3.Location = New Point(387, 231)
			Me.personInfoControl3.Name = "personInfoControl3"
			Me.personInfoControl3.PersonEmail = "Email: BobSmiil@mail.com"
			Me.personInfoControl3.PersonImage = (CType(resources.GetObject("personInfoControl3.PersonImage"), Image))
			Me.personInfoControl3.PersonName = "Bob Smiil"
			Me.personInfoControl3.PersonPhone = "Phone: 333 2334"
			Me.personInfoControl3.Size = New Size(300, 123)
			Me.personInfoControl3.TabIndex = 1
			Me.personInfoControl3.Text = "personInfoControl3"
			' 
			' personInfoControl2
			' 
			Me.personInfoControl2.Location = New Point(64, 231)
			Me.personInfoControl2.Name = "personInfoControl2"
			Me.personInfoControl2.PersonEmail = "Email: BobSmiil@mail.com"
			Me.personInfoControl2.PersonImage = (CType(resources.GetObject("personInfoControl2.PersonImage"), Image))
			Me.personInfoControl2.PersonName = "Bob Smiil"
			Me.personInfoControl2.PersonPhone = "Phone: 333 2334"
			Me.personInfoControl2.Size = New Size(300, 123)
			Me.personInfoControl2.TabIndex = 1
			Me.personInfoControl2.Text = "personInfoControl2"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.animationEasingTypeDropDownList)
			Me.radGroupBox1.Controls.Add(Me.radLabel8)
			Me.radGroupBox1.Controls.Add(Me.animationTypeDropDownList)
			Me.radGroupBox1.Controls.Add(Me.radLabel7)
			Me.radGroupBox1.Controls.Add(Me.rightToLeftCheckBox)
			Me.radGroupBox1.Controls.Add(Me.verticalHeaderAlignmentDropDownList)
			Me.radGroupBox1.Controls.Add(Me.radLabel6)
			Me.radGroupBox1.Controls.Add(Me.horizontalHeaderAlignmentDropDownList)
			Me.radGroupBox1.Controls.Add(Me.radLabel5)
			Me.radGroupBox1.Controls.Add(Me.showHeaderLineCheckBox)
			Me.radGroupBox1.Controls.Add(Me.animationFramesSpinEditor)
			Me.radGroupBox1.Controls.Add(Me.radLabel4)
			Me.radGroupBox1.Controls.Add(Me.animationIntervalSpinEditor)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.contentSizingModeDropDownList)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.enableAnimationCheckBox)
			Me.radGroupBox1.Controls.Add(Me.expandDirectionDropDownList)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.HeaderText = "Settings"
			Me.radGroupBox1.Location = New Point(10, 32)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Size = New Size(223, 574)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Settings"
			' 
			' animationEasingTypeDropDownList
			' 
			Me.animationEasingTypeDropDownList.Anchor = AnchorStyles.Top
			Me.animationEasingTypeDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.animationEasingTypeDropDownList.Location = New Point(5, 151)
			Me.animationEasingTypeDropDownList.Name = "animationEasingTypeDropDownList"
			Me.animationEasingTypeDropDownList.Size = New Size(213, 20)
			Me.animationEasingTypeDropDownList.TabIndex = 15
			' 
			' radLabel8
			' 
			Me.radLabel8.Anchor = AnchorStyles.Top
			Me.radLabel8.Location = New Point(5, 127)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New Size(122, 18)
			Me.radLabel8.TabIndex = 14
			Me.radLabel8.Text = "Animation Easing Type:"
			' 
			' animationTypeDropDownList
			' 
			Me.animationTypeDropDownList.Anchor = AnchorStyles.Top
			Me.animationTypeDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.animationTypeDropDownList.Location = New Point(5, 97)
			Me.animationTypeDropDownList.Name = "animationTypeDropDownList"
			Me.animationTypeDropDownList.Size = New Size(213, 20)
			Me.animationTypeDropDownList.TabIndex = 13
			' 
			' radLabel7
			' 
			Me.radLabel7.Anchor = AnchorStyles.Top
			Me.radLabel7.Location = New Point(5, 73)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New Size(86, 18)
			Me.radLabel7.TabIndex = 12
			Me.radLabel7.Text = "Animation Type:"
			' 
			' rightToLeftCheckBox
			' 
			Me.rightToLeftCheckBox.Anchor = AnchorStyles.Top
			Me.rightToLeftCheckBox.Location = New Point(5, 517)
			Me.rightToLeftCheckBox.Name = "rightToLeftCheckBox"
			Me.rightToLeftCheckBox.Size = New Size(78, 18)
			Me.rightToLeftCheckBox.TabIndex = 11
			Me.rightToLeftCheckBox.Text = "RightToLeft"
			' 
			' verticalHeaderAlignmentDropDownList
			' 
			Me.verticalHeaderAlignmentDropDownList.Anchor = AnchorStyles.Top
			Me.verticalHeaderAlignmentDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.verticalHeaderAlignmentDropDownList.Location = New Point(5, 490)
			Me.verticalHeaderAlignmentDropDownList.Name = "verticalHeaderAlignmentDropDownList"
			Me.verticalHeaderAlignmentDropDownList.Size = New Size(213, 20)
			Me.verticalHeaderAlignmentDropDownList.TabIndex = 10
			' 
			' radLabel6
			' 
			Me.radLabel6.Anchor = AnchorStyles.Top
			Me.radLabel6.Location = New Point(5, 465)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New Size(139, 18)
			Me.radLabel6.TabIndex = 9
			Me.radLabel6.Text = "Vertical Header Alignment:"
			' 
			' horizontalHeaderAlignmentDropDownList
			' 
			Me.horizontalHeaderAlignmentDropDownList.Anchor = AnchorStyles.Top
			Me.horizontalHeaderAlignmentDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.horizontalHeaderAlignmentDropDownList.Location = New Point(5, 430)
			Me.horizontalHeaderAlignmentDropDownList.Name = "horizontalHeaderAlignmentDropDownList"
			Me.horizontalHeaderAlignmentDropDownList.Size = New Size(213, 20)
			Me.horizontalHeaderAlignmentDropDownList.TabIndex = 9
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = AnchorStyles.Top
			Me.radLabel5.Location = New Point(5, 405)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New Size(154, 18)
			Me.radLabel5.TabIndex = 8
			Me.radLabel5.Text = "Horizontal Header Alignment:"
			' 
			' showHeaderLineCheckBox
			' 
			Me.showHeaderLineCheckBox.Anchor = AnchorStyles.Top
			Me.showHeaderLineCheckBox.CheckState = CheckState.Checked
			Me.showHeaderLineCheckBox.Location = New Point(5, 377)
			Me.showHeaderLineCheckBox.Name = "showHeaderLineCheckBox"
			Me.showHeaderLineCheckBox.Size = New Size(113, 18)
			Me.showHeaderLineCheckBox.TabIndex = 7
			Me.showHeaderLineCheckBox.Text = "Show Header Line:"
			Me.showHeaderLineCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' animationFramesSpinEditor
			' 
			Me.animationFramesSpinEditor.Anchor = AnchorStyles.Top
			Me.animationFramesSpinEditor.Location = New Point(5, 339)
			Me.animationFramesSpinEditor.Name = "animationFramesSpinEditor"
			Me.animationFramesSpinEditor.Size = New Size(213, 20)
			Me.animationFramesSpinEditor.TabIndex = 6
			Me.animationFramesSpinEditor.TabStop = False
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(5, 315)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(98, 18)
			Me.radLabel4.TabIndex = 6
			Me.radLabel4.Text = "Animation Frames:"
			' 
			' animationIntervalSpinEditor
			' 
			Me.animationIntervalSpinEditor.Anchor = AnchorStyles.Top
			Me.animationIntervalSpinEditor.Location = New Point(5, 289)
			Me.animationIntervalSpinEditor.Name = "animationIntervalSpinEditor"
			Me.animationIntervalSpinEditor.Size = New Size(213, 20)
			Me.animationIntervalSpinEditor.TabIndex = 5
			Me.animationIntervalSpinEditor.TabStop = False
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(5, 265)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(99, 18)
			Me.radLabel3.TabIndex = 4
			Me.radLabel3.Text = "Animation Interval:"
			' 
			' contentSizingModeDropDownList
			' 
			Me.contentSizingModeDropDownList.Anchor = AnchorStyles.Top
			Me.contentSizingModeDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.contentSizingModeDropDownList.Location = New Point(5, 205)
			Me.contentSizingModeDropDownList.Name = "contentSizingModeDropDownList"
			Me.contentSizingModeDropDownList.Size = New Size(213, 20)
			Me.contentSizingModeDropDownList.TabIndex = 3
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 180)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(113, 18)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "Content Sizing Mode:"
			' 
			' enableAnimationCheckBox
			' 
			Me.enableAnimationCheckBox.Anchor = AnchorStyles.Top
			Me.enableAnimationCheckBox.Location = New Point(5, 240)
			Me.enableAnimationCheckBox.Name = "enableAnimationCheckBox"
			Me.enableAnimationCheckBox.Size = New Size(108, 18)
			Me.enableAnimationCheckBox.TabIndex = 2
			Me.enableAnimationCheckBox.Text = "Enable Animation"
			' 
			' expandDirectionDropDownList
			' 
			Me.expandDirectionDropDownList.Anchor = AnchorStyles.Top
			Me.expandDirectionDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.expandDirectionDropDownList.Location = New Point(5, 47)
			Me.expandDirectionDropDownList.Name = "expandDirectionDropDownList"
			Me.expandDirectionDropDownList.Size = New Size(213, 20)
			Me.expandDirectionDropDownList.TabIndex = 1
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 22)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(93, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Expand Direction:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(96F, 96F)
			Me.AutoScaleMode = AutoScaleMode.Dpi
			Me.Controls.Add(Me.radPanelDemoHolder)
			Me.Name = "Form1"
			Me.Size = New Size(1409, 808)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radCollapsiblePanel1.PanelContainer.ResumeLayout(False)
			CType(Me.radCollapsiblePanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.personInfoControl4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.personInfoControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.personInfoControl3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.personInfoControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.animationEasingTypeDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.animationTypeDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rightToLeftCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.verticalHeaderAlignmentDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.horizontalHeaderAlignmentDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showHeaderLineCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.animationFramesSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.animationIntervalSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.contentSizingModeDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.enableAnimationCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.expandDirectionDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
		Private radCollapsiblePanel1 As Telerik.WinControls.UI.RadCollapsiblePanel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private expandDirectionDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private personInfoControl3 As PersonInfoControl
		Private personInfoControl2 As PersonInfoControl
		Private personInfoControl4 As PersonInfoControl
		Private personInfoControl1 As PersonInfoControl
		Private enableAnimationCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private contentSizingModeDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private animationFramesSpinEditor As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private animationIntervalSpinEditor As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private showHeaderLineCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private horizontalHeaderAlignmentDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private verticalHeaderAlignmentDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel6 As Telerik.WinControls.UI.RadLabel
		Private rightToLeftCheckBox As Telerik.WinControls.UI.RadCheckBox
		Private animationTypeDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel7 As Telerik.WinControls.UI.RadLabel
		Private animationEasingTypeDropDownList As Telerik.WinControls.UI.RadDropDownList
		Private radLabel8 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
