Namespace Telerik.Examples.WinControls.Docking.DocumentManager
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
			Me.documentWindow11 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow4 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow8 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow3 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow5 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow6 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.documentTabStrip5 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentTabStrip6 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow10 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentTabStrip3 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow7 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.documentWindow9 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.sortNone = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.sortByActivation = New Telerik.WinControls.UI.RadRadioButton()
			Me.sortByText = New Telerik.WinControls.UI.RadRadioButton()
			Me.addDoc = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer1.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer2.SuspendLayout()
			CType(Me.documentTabStrip5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip5.SuspendLayout()
			CType(Me.documentTabStrip6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip6.SuspendLayout()
			CType(Me.documentTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip3.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sortNone, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.sortByActivation, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sortByText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addDoc, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.addDoc)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radButton2)
			Me.settingsPanel.Controls.Add(Me.radButton1)
			Me.settingsPanel.Location = New Point(552, 1)
			Me.settingsPanel.Size = New Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.addDoc, 0)
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.documentWindow11
			Me.radDock1.CausesValidation = False
			Me.radDock1.Controls.Add(Me.documentContainer1)
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
			' documentWindow11
			' 
			Me.documentWindow11.Location = New Point(5, 27)
			Me.documentWindow11.Name = "documentWindow11"
			Me.documentWindow11.Size = New Size(743, 370)
			Me.documentWindow11.Text = "documentWindow7"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.CausesValidation = False
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Controls.Add(Me.radSplitContainer1)
			Me.documentContainer1.Cursor = Cursors.Arrow
			Me.documentContainer1.Location = New Point(0, 0)
			Me.documentContainer1.Name = "documentContainer1"
			Me.documentContainer1.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New Size(25, 25)
			Me.documentContainer1.Size = New Size(753, 808)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.TabIndex = 0
			Me.documentContainer1.TabStop = False
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.CausesValidation = False
			Me.documentTabStrip1.Controls.Add(Me.documentWindow11)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow4)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow8)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow3)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow5)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow6)
			Me.documentTabStrip1.Location = New Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New Size(753, 402)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow4
			' 
			Me.documentWindow4.Location = New Point(5, 27)
			Me.documentWindow4.Name = "documentWindow4"
			Me.documentWindow4.Size = New Size(831, 228)
			Me.documentWindow4.Text = "documentWindow4"
			' 
			' documentWindow8
			' 
			Me.documentWindow8.Location = New Point(5, 27)
			Me.documentWindow8.Name = "documentWindow8"
			Me.documentWindow8.Size = New Size(831, 228)
			Me.documentWindow8.Text = "documentWindow10"
			' 
			' documentWindow3
			' 
			Me.documentWindow3.Location = New Point(5, 27)
			Me.documentWindow3.Name = "documentWindow3"
			Me.documentWindow3.Size = New Size(831, 228)
			Me.documentWindow3.Text = "documentWindow3"
			' 
			' documentWindow5
			' 
			Me.documentWindow5.Location = New Point(5, 27)
			Me.documentWindow5.Name = "documentWindow5"
			Me.documentWindow5.Size = New Size(831, 228)
			Me.documentWindow5.Text = "documentWindow9"
			' 
			' documentWindow6
			' 
			Me.documentWindow6.Location = New Point(5, 27)
			Me.documentWindow6.Name = "documentWindow6"
			Me.documentWindow6.Size = New Size(1299, 252)
			Me.documentWindow6.Text = "documentWindow8"
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.radSplitContainer2)
			Me.radSplitContainer1.Controls.Add(Me.documentTabStrip3)
			Me.radSplitContainer1.Cursor = Cursors.Arrow
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New Point(0, 405)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer1.Size = New Size(753, 403)
			Me.radSplitContainer1.TabIndex = 2
			Me.radSplitContainer1.TabStop = False
			' 
			' radSplitContainer2
			' 
			Me.radSplitContainer2.Controls.Add(Me.documentTabStrip5)
			Me.radSplitContainer2.Controls.Add(Me.documentTabStrip6)
			Me.radSplitContainer2.IsCleanUpTarget = True
			Me.radSplitContainer2.Location = New Point(0, 0)
			Me.radSplitContainer2.Name = "radSplitContainer2"
			Me.radSplitContainer2.Orientation = Orientation.Horizontal
			' 
			' 
			' 
			Me.radSplitContainer2.RootElement.MinSize = New Size(25, 25)
			Me.radSplitContainer2.Size = New Size(375, 403)
			Me.radSplitContainer2.TabIndex = 4
			Me.radSplitContainer2.TabStop = False
			' 
			' documentTabStrip5
			' 
			Me.documentTabStrip5.Controls.Add(Me.documentWindow2)
			Me.documentTabStrip5.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip5.Location = New Point(0, 0)
			Me.documentTabStrip5.Name = "documentTabStrip5"
			' 
			' 
			' 
			Me.documentTabStrip5.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip5.SelectedIndex = 0
			Me.documentTabStrip5.Size = New Size(375, 200)
			Me.documentTabStrip5.TabIndex = 2
			Me.documentTabStrip5.TabStop = False
			' 
			' documentWindow2
			' 
			Me.documentWindow2.Location = New Point(5, 27)
			Me.documentWindow2.Name = "documentWindow2"
			Me.documentWindow2.Size = New Size(365, 168)
			Me.documentWindow2.Text = "documentWindow2"
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Location = New Point(5, 27)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.Size = New Size(831, 227)
			Me.documentWindow1.Text = "documentWindow1"
			' 
			' documentTabStrip6
			' 
			Me.documentTabStrip6.Controls.Add(Me.documentWindow10)
			Me.documentTabStrip6.Location = New Point(0, 203)
			Me.documentTabStrip6.Name = "documentTabStrip6"
			' 
			' 
			' 
			Me.documentTabStrip6.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip6.SelectedIndex = 0
			Me.documentTabStrip6.Size = New Size(375, 200)
			Me.documentTabStrip6.TabIndex = 3
			Me.documentTabStrip6.TabStop = False
			' 
			' documentWindow10
			' 
			Me.documentWindow10.Location = New Point(5, 27)
			Me.documentWindow10.Name = "documentWindow10"
			Me.documentWindow10.Size = New Size(365, 168)
			Me.documentWindow10.Text = "documentWindow6"
			' 
			' documentTabStrip3
			' 
			Me.documentTabStrip3.Controls.Add(Me.documentWindow7)
			Me.documentTabStrip3.Controls.Add(Me.documentWindow9)

			Me.documentTabStrip3.Location = New Point(378, 0)
			Me.documentTabStrip3.Name = "documentTabStrip3"
			' 
			' 
			' 
			Me.documentTabStrip3.RootElement.MinSize = New Size(25, 25)
			Me.documentTabStrip3.SelectedIndex = 0
			Me.documentTabStrip3.Size = New Size(375, 403)
			Me.documentTabStrip3.TabIndex = 3
			Me.documentTabStrip3.TabStop = False
			' 
			' documentWindow7
			' 
			Me.documentWindow7.Location = New Point(5, 27)
			Me.documentWindow7.Name = "documentWindow7"
			Me.documentWindow7.Size = New Size(365, 371)
			Me.documentWindow7.Text = "documentWindow5"
			' 
			' documentWindow9
			' 
			Me.documentWindow9.Location = New Point(5, 27)
			Me.documentWindow9.Name = "documentWindow9"
			Me.documentWindow9.Size = New Size(643, 251)
			Me.documentWindow9.Text = "documentWindow11"
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = AnchorStyles.Top
			Me.radButton1.Location = New Point(10, 90)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(180, 47)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Next Document (CTRL+F6)"

			' 
			' radButton2
			' 
			Me.radButton2.Anchor = AnchorStyles.Top
			Me.radButton2.Location = New Point(10, 143)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New Size(180, 47)
			Me.radButton2.TabIndex = 2
			Me.radButton2.Text = "Prev. Document (CTRL+SHIFT+F6)"
			Me.radButton2.TextWrap = True

			' 
			' sortNone
			' 
			Me.sortNone.Anchor = AnchorStyles.Top
			Me.sortNone.AutoSize = True
			Me.sortNone.Location = New Point(13, 23)
			Me.sortNone.Name = "sortNone"
			Me.sortNone.Size = New Size(47, 16)
			Me.sortNone.TabIndex = 3
			Me.sortNone.Text = "None"

			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.sortByActivation)
			Me.radGroupBox1.Controls.Add(Me.sortByText)
			Me.radGroupBox1.Controls.Add(Me.sortNone)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New Padding(0)
			Me.radGroupBox1.HeaderText = "Active Document Sort Order"
			Me.radGroupBox1.Location = New Point(10, 203)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New Size(180, 100)
			Me.radGroupBox1.TabIndex = 4
			Me.radGroupBox1.Text = "Active Document Sort Order"
			' 
			' sortByActivation
			' 
			Me.sortByActivation.Anchor = AnchorStyles.Top
			Me.sortByActivation.AutoSize = True
			Me.sortByActivation.Location = New Point(13, 67)
			Me.sortByActivation.Name = "sortByActivation"
			Me.sortByActivation.Size = New Size(118, 16)
			Me.sortByActivation.TabIndex = 5
			Me.sortByActivation.Text = "By Activation Order"

			' 
			' sortByText
			' 
			Me.sortByText.Anchor = AnchorStyles.Top
			Me.sortByText.AutoSize = True
			Me.sortByText.Location = New Point(13, 45)
			Me.sortByText.Name = "sortByText"
			Me.sortByText.Size = New Size(58, 16)
			Me.sortByText.TabIndex = 4
			Me.sortByText.Text = "By Text"
			Me.sortByText.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On

			' 
			' addDoc
			' 
			Me.addDoc.Anchor = AnchorStyles.Top
			Me.addDoc.Location = New Point(10, 37)
			Me.addDoc.Name = "addDoc"
			Me.addDoc.Size = New Size(180, 47)
			Me.addDoc.TabIndex = 5
			Me.addDoc.Text = "Add Document"

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
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer1.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer2.ResumeLayout(False)
			CType(Me.documentTabStrip5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip5.ResumeLayout(False)
			CType(Me.documentTabStrip6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip6.ResumeLayout(False)
			CType(Me.documentTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip3.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sortNone, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.sortByActivation, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sortByText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addDoc, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private documentWindow4 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow3 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private sortNone As Telerik.WinControls.UI.RadRadioButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private documentWindow6 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow5 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private documentTabStrip3 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow7 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow8 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow9 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow10 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private documentWindow11 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private sortByActivation As Telerik.WinControls.UI.RadRadioButton
		Private sortByText As Telerik.WinControls.UI.RadRadioButton
		Private addDoc As Telerik.WinControls.UI.RadButton
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private documentTabStrip5 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentTabStrip6 As Telerik.WinControls.UI.Docking.DocumentTabStrip
	End Class
End Namespace
