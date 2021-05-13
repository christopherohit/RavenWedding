Namespace Telerik.Examples.WinControls.Docking.TabStripProperties
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
			Me.documentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.docTabAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.toolTabAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.docTabsVisibleCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.toolTabsVisibleCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.docPinButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.docCloseButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.docPreviewTabCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.docTextOrientationCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.toolCloseButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.toolTextOrientationCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
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
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docTabAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docTabsVisibleCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabsVisibleCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.docPinButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docCloseButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docPreviewTabCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docTextOrientationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.toolCloseButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTextOrientationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New Point(552, 1)
			Me.settingsPanel.Size = New Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.documentWindow2
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
			Me.radDock1.RootElement.MinSize = New Size(0, 0)
			Me.radDock1.Size = New Size(1320, 1029)
			Me.radDock1.TabIndex = 1
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' documentWindow2
			' 
			Me.documentWindow2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.documentWindow2.Location = New Point(6, 29)
			Me.documentWindow2.Name = "documentWindow2"
			Me.documentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow2.Size = New Size(890, 780)
			Me.documentWindow2.Text = "documentWindow2"
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
			Me.radSplitContainer2.RootElement.MinSize = New Size(0, 0)
			Me.radSplitContainer2.Size = New Size(1106, 1019)
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
			Me.radSplitContainer1.Padding = New Padding(5)
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(0, 0)
			Me.radSplitContainer1.Size = New Size(1106, 815)
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
			Me.toolTabStrip1.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New Size(200, 815)
			Me.toolTabStrip1.TabIndex = 1
			Me.toolTabStrip1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Caption = Nothing
			Me.toolWindow1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow1.Location = New Point(1, 24)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow1.Size = New Size(198, 789)
			Me.toolWindow1.Text = "toolWindow1"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New Size(0, 0)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.TabIndex = 2
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.CanUpdateChildIndex = True
			Me.documentTabStrip1.Controls.Add(Me.documentWindow2)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New Size(0, 0)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New Size(902, 815)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.documentWindow1.Location = New Point(5, 27)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
			Me.documentWindow1.Size = New Size(549, 296)
			Me.documentWindow1.Text = "documentWindow1"
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.CanUpdateChildIndex = True
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New Point(0, 819)
			Me.toolTabStrip2.Name = "toolTabStrip2"
			' 
			' 
			' 
			Me.toolTabStrip2.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip2.SelectedIndex = 0
			Me.toolTabStrip2.Size = New Size(1106, 200)
			Me.toolTabStrip2.TabIndex = 1
			Me.toolTabStrip2.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Caption = Nothing
			Me.toolWindow2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow2.Location = New Point(1, 24)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow2.Size = New Size(1104, 174)
			Me.toolWindow2.Text = "toolWindow2"
			' 
			' toolTabStrip3
			' 
			Me.toolTabStrip3.CanUpdateChildIndex = True
			Me.toolTabStrip3.Controls.Add(Me.toolWindow3)
			Me.toolTabStrip3.Location = New Point(1115, 5)
			Me.toolTabStrip3.Name = "toolTabStrip3"
			' 
			' 
			' 
			Me.toolTabStrip3.RootElement.MinSize = New Size(0, 0)
			Me.toolTabStrip3.SelectedIndex = 0
			Me.toolTabStrip3.Size = New Size(200, 1019)
			Me.toolTabStrip3.TabIndex = 1
			Me.toolTabStrip3.TabStop = False
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Caption = Nothing
			Me.toolWindow3.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.toolWindow3.Location = New Point(1, 24)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
			Me.toolWindow3.Size = New Size(198, 993)
			Me.toolWindow3.Text = "toolWindow3"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = AnchorStyles.Top
			Me.radLabel1.Location = New Point(5, 23)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New Size(59, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Alignment:"
			' 
			' docTabAlignCombo
			' 
			Me.docTabAlignCombo.Anchor = AnchorStyles.Top
			Me.docTabAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.docTabAlignCombo.FormatString = "{0}"
			Me.docTabAlignCombo.Location = New Point(5, 43)
			Me.docTabAlignCombo.Name = "docTabAlignCombo"
			' 
			' 
			' 
			Me.docTabAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.docTabAlignCombo.Size = New Size(170, 20)
			Me.docTabAlignCombo.TabIndex = 2
			Me.docTabAlignCombo.Text = "radComboBox1"
			' 
			' toolTabAlignCombo
			' 
			Me.toolTabAlignCombo.Anchor = AnchorStyles.Top
			Me.toolTabAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.toolTabAlignCombo.FormatString = "{0}"
			Me.toolTabAlignCombo.Location = New Point(5, 43)
			Me.toolTabAlignCombo.Name = "toolTabAlignCombo"
			' 
			' 
			' 
			Me.toolTabAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.toolTabAlignCombo.Size = New Size(170, 20)
			Me.toolTabAlignCombo.TabIndex = 4
			Me.toolTabAlignCombo.Text = "radComboBox1"
			' 
			' docTabsVisibleCheck
			' 
			Me.docTabsVisibleCheck.Anchor = AnchorStyles.Top
			Me.docTabsVisibleCheck.Location = New Point(5, 209)
			Me.docTabsVisibleCheck.Name = "docTabsVisibleCheck"
			Me.docTabsVisibleCheck.Size = New Size(53, 18)
			Me.docTabsVisibleCheck.TabIndex = 5
			Me.docTabsVisibleCheck.Text = "Visible"
			' 
			' toolTabsVisibleCheck
			' 
			Me.toolTabsVisibleCheck.Anchor = AnchorStyles.Top
			Me.toolTabsVisibleCheck.Location = New Point(5, 139)
			Me.toolTabsVisibleCheck.Name = "toolTabsVisibleCheck"
			Me.toolTabsVisibleCheck.Size = New Size(53, 18)
			Me.toolTabsVisibleCheck.TabIndex = 6
			Me.toolTabsVisibleCheck.Text = "Visible"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.docPinButtonCheck)
			Me.radGroupBox1.Controls.Add(Me.docCloseButtonCheck)
			Me.radGroupBox1.Controls.Add(Me.docPreviewTabCombo)
			Me.radGroupBox1.Controls.Add(Me.docTextOrientationCombo)
			Me.radGroupBox1.Controls.Add(Me.radLabel2)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.docTabAlignCombo)
			Me.radGroupBox1.Controls.Add(Me.docTabsVisibleCheck)
			Me.radGroupBox1.HeaderText = "Document Tabs"
			Me.radGroupBox1.Location = New Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 234)
			Me.radGroupBox1.TabIndex = 7
			Me.radGroupBox1.Text = "Document Tabs"
			' 
			' docPinButtonCheck
			' 
			Me.docPinButtonCheck.Anchor = AnchorStyles.Top
			Me.docPinButtonCheck.Location = New Point(5, 185)
			Me.docPinButtonCheck.Name = "docPinButtonCheck"
			Me.docPinButtonCheck.Size = New Size(103, 18)
			Me.docPinButtonCheck.TabIndex = 8
			Me.docPinButtonCheck.Text = "Show Pin Button"
			' 
			' docCloseButtonCheck
			' 
			Me.docCloseButtonCheck.Anchor = AnchorStyles.Top
			Me.docCloseButtonCheck.Location = New Point(5, 161)
			Me.docCloseButtonCheck.Name = "docCloseButtonCheck"
			Me.docCloseButtonCheck.Size = New Size(114, 18)
			Me.docCloseButtonCheck.TabIndex = 8
			Me.docCloseButtonCheck.Text = "Show Close Button"
			' 
			' docPreviewTabCombo
			' 
			Me.docPreviewTabCombo.Anchor = AnchorStyles.Top
			Me.docPreviewTabCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.docPreviewTabCombo.FormatString = "{0}"
			Me.docPreviewTabCombo.Location = New Point(5, 135)
			Me.docPreviewTabCombo.Name = "docPreviewTabCombo"
			' 
			' 
			' 
			Me.docPreviewTabCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.docPreviewTabCombo.Size = New Size(170, 20)
			Me.docPreviewTabCombo.TabIndex = 7
			' 
			' docTextOrientationCombo
			' 
			Me.docTextOrientationCombo.Anchor = AnchorStyles.Top
			Me.docTextOrientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.docTextOrientationCombo.FormatString = "{0}"
			Me.docTextOrientationCombo.Location = New Point(5, 89)
			Me.docTextOrientationCombo.Name = "docTextOrientationCombo"
			' 
			' 
			' 
			Me.docTextOrientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.docTextOrientationCombo.Size = New Size(170, 20)
			Me.docTextOrientationCombo.TabIndex = 7
			Me.docTextOrientationCombo.Text = "radComboBox1"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = AnchorStyles.Top
			Me.radLabel2.Location = New Point(5, 115)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New Size(68, 18)
			Me.radLabel2.TabIndex = 6
			Me.radLabel2.Text = "Preview Tab:"
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = AnchorStyles.Top
			Me.radLabel3.Location = New Point(5, 69)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New Size(88, 18)
			Me.radLabel3.TabIndex = 6
			Me.radLabel3.Text = "Text Orientation:"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.toolCloseButtonCheck)
			Me.radGroupBox2.Controls.Add(Me.toolTextOrientationCombo)
			Me.radGroupBox2.Controls.Add(Me.radLabel4)
			Me.radGroupBox2.Controls.Add(Me.toolTabsVisibleCheck)
			Me.radGroupBox2.Controls.Add(Me.radLabel5)
			Me.radGroupBox2.Controls.Add(Me.toolTabAlignCombo)
			Me.radGroupBox2.HeaderText = "Tool Tabs"
			Me.radGroupBox2.Location = New Point(10, 277)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New Size(180, 167)
			Me.radGroupBox2.TabIndex = 8
			Me.radGroupBox2.Text = "Tool Tabs"
			' 
			' toolCloseButtonCheck
			' 
			Me.toolCloseButtonCheck.Anchor = AnchorStyles.Top
			Me.toolCloseButtonCheck.Location = New Point(5, 115)
			Me.toolCloseButtonCheck.Name = "toolCloseButtonCheck"
			Me.toolCloseButtonCheck.Size = New Size(114, 18)
			Me.toolCloseButtonCheck.TabIndex = 8
			Me.toolCloseButtonCheck.Text = "Show Close Button"
			' 
			' toolTextOrientationCombo
			' 
			Me.toolTextOrientationCombo.Anchor = AnchorStyles.Top
			Me.toolTextOrientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.toolTextOrientationCombo.FormatString = "{0}"
			Me.toolTextOrientationCombo.Location = New Point(5, 89)
			Me.toolTextOrientationCombo.Name = "toolTextOrientationCombo"
			' 
			' 
			' 
			Me.toolTextOrientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.toolTextOrientationCombo.Size = New Size(170, 20)
			Me.toolTextOrientationCombo.TabIndex = 7
			Me.toolTextOrientationCombo.Text = "radComboBox1"
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = AnchorStyles.Top
			Me.radLabel4.Location = New Point(5, 69)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New Size(88, 18)
			Me.radLabel4.TabIndex = 6
			Me.radLabel4.Text = "Text Orientation:"
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = AnchorStyles.Top
			Me.radLabel5.Location = New Point(5, 23)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New Size(59, 18)
			Me.radLabel5.TabIndex = 1
			Me.radLabel5.Text = "Alignment:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = AutoScaleMode.Dpi
            Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			Me.Size = New Size(1330, 1039)
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
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docTabAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docTabsVisibleCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabsVisibleCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.docPinButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docCloseButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docPreviewTabCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docTextOrientationCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.toolCloseButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTextOrientationCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private docTabAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private toolTabsVisibleCheck As Telerik.WinControls.UI.RadCheckBox
		Private docTabsVisibleCheck As Telerik.WinControls.UI.RadCheckBox
		Private toolTabAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private documentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private docTextOrientationCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private toolTextOrientationCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private docCloseButtonCheck As Telerik.WinControls.UI.RadCheckBox
		Private toolCloseButtonCheck As Telerik.WinControls.UI.RadCheckBox
		Private docPinButtonCheck As Telerik.WinControls.UI.RadCheckBox
		Private docPreviewTabCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
