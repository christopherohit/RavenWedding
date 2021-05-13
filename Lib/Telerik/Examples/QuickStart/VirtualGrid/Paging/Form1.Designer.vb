Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.VirtualGrid.Paging
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
			Me.radVirtualGrid1 = New Telerik.WinControls.UI.RadVirtualGrid()
			Me.radCheckBoxLastButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxNextButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxFastForwardButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxNumericalButtons = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxFastBackButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxTextBoxStrip = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxPreviousButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxButtonsStrip = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxFirstButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radSpinEditorPageButtons = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorPageSize = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxLastButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxNextButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxFastForwardButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxNumericalButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxFastBackButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxTextBoxStrip, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxPreviousButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxButtonsStrip, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxFirstButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorPageButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSpinEditorPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBoxLastButton)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxNextButton)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxFastForwardButton)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxNumericalButtons)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxFastBackButton)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxTextBoxStrip)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxPreviousButton)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxButtonsStrip)
			Me.settingsPanel.Controls.Add(Me.radCheckBoxFirstButton)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorPageButtons)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorPageSize)
			Me.settingsPanel.Controls.Add(Me.radLabel3)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Size = New System.Drawing.Size(230, 536)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorPageSize, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorPageButtons, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxFirstButton, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxButtonsStrip, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxPreviousButton, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxTextBoxStrip, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxFastBackButton, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxNumericalButtons, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxFastForwardButton, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxNextButton, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxLastButton, 0)
			' 
			' radVirtualGrid1
			' 
			Me.radVirtualGrid1.ColumnCount = 100
			Me.radVirtualGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radVirtualGrid1.Location = New System.Drawing.Point(0, 0)
			Me.radVirtualGrid1.Name = "radVirtualGrid1"
			Me.radVirtualGrid1.RowCount = 1000
			Me.radVirtualGrid1.Size = New System.Drawing.Size(1871, 1086)
			Me.radVirtualGrid1.StandardTab = False
			Me.radVirtualGrid1.TabIndex = 0
			Me.radVirtualGrid1.Text = "radVirtualGrid1"
			' 
			' radCheckBoxLastButton
			' 
			Me.radCheckBoxLastButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxLastButton.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxLastButton.Location = New System.Drawing.Point(10, 337)
			Me.radCheckBoxLastButton.Name = "radCheckBoxLastButton"
			Me.radCheckBoxLastButton.Size = New System.Drawing.Size(105, 18)
			Me.radCheckBoxLastButton.TabIndex = 11
			Me.radCheckBoxLastButton.Text = "Show last button"
			Me.radCheckBoxLastButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxNextButton
			' 
			Me.radCheckBoxNextButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxNextButton.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxNextButton.Location = New System.Drawing.Point(10, 313)
			Me.radCheckBoxNextButton.Name = "radCheckBoxNextButton"
			Me.radCheckBoxNextButton.Size = New System.Drawing.Size(109, 18)
			Me.radCheckBoxNextButton.TabIndex = 12
			Me.radCheckBoxNextButton.Text = "Show next button"
			Me.radCheckBoxNextButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxFastForwardButton
			' 
			Me.radCheckBoxFastForwardButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFastForwardButton.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxFastForwardButton.Location = New System.Drawing.Point(10, 289)
			Me.radCheckBoxFastForwardButton.Name = "radCheckBoxFastForwardButton"
			Me.radCheckBoxFastForwardButton.Size = New System.Drawing.Size(147, 18)
			Me.radCheckBoxFastForwardButton.TabIndex = 13
			Me.radCheckBoxFastForwardButton.Text = "Show fast forward button"
			Me.radCheckBoxFastForwardButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxNumericalButtons
			' 
			Me.radCheckBoxNumericalButtons.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxNumericalButtons.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxNumericalButtons.Location = New System.Drawing.Point(10, 265)
			Me.radCheckBoxNumericalButtons.Name = "radCheckBoxNumericalButtons"
			Me.radCheckBoxNumericalButtons.Size = New System.Drawing.Size(141, 18)
			Me.radCheckBoxNumericalButtons.TabIndex = 14
			Me.radCheckBoxNumericalButtons.Text = "Show numerical buttons"
			Me.radCheckBoxNumericalButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxFastBackButton
			' 
			Me.radCheckBoxFastBackButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFastBackButton.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxFastBackButton.Location = New System.Drawing.Point(10, 241)
			Me.radCheckBoxFastBackButton.Name = "radCheckBoxFastBackButton"
			Me.radCheckBoxFastBackButton.Size = New System.Drawing.Size(132, 18)
			Me.radCheckBoxFastBackButton.TabIndex = 15
			Me.radCheckBoxFastBackButton.Text = "Show fast back button"
			Me.radCheckBoxFastBackButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxTextBoxStrip
			' 
			Me.radCheckBoxTextBoxStrip.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxTextBoxStrip.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxTextBoxStrip.Location = New System.Drawing.Point(10, 169)
			Me.radCheckBoxTextBoxStrip.Name = "radCheckBoxTextBoxStrip"
			Me.radCheckBoxTextBoxStrip.Size = New System.Drawing.Size(113, 18)
			Me.radCheckBoxTextBoxStrip.TabIndex = 16
			Me.radCheckBoxTextBoxStrip.Text = "Show textbox strip"
			Me.radCheckBoxTextBoxStrip.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxPreviousButton
			' 
			Me.radCheckBoxPreviousButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxPreviousButton.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxPreviousButton.Location = New System.Drawing.Point(10, 217)
			Me.radCheckBoxPreviousButton.Name = "radCheckBoxPreviousButton"
			Me.radCheckBoxPreviousButton.Size = New System.Drawing.Size(130, 18)
			Me.radCheckBoxPreviousButton.TabIndex = 17
			Me.radCheckBoxPreviousButton.Text = "Show previous button"
			Me.radCheckBoxPreviousButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxButtonsStrip
			' 
			Me.radCheckBoxButtonsStrip.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxButtonsStrip.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxButtonsStrip.Location = New System.Drawing.Point(10, 145)
			Me.radCheckBoxButtonsStrip.Name = "radCheckBoxButtonsStrip"
			Me.radCheckBoxButtonsStrip.Size = New System.Drawing.Size(114, 18)
			Me.radCheckBoxButtonsStrip.TabIndex = 18
			Me.radCheckBoxButtonsStrip.Text = "Show buttons strip"
			Me.radCheckBoxButtonsStrip.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radCheckBoxFirstButton
			' 
			Me.radCheckBoxFirstButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFirstButton.CheckState = System.Windows.Forms.CheckState.Checked
			Me.radCheckBoxFirstButton.Location = New System.Drawing.Point(10, 193)
			Me.radCheckBoxFirstButton.Name = "radCheckBoxFirstButton"
			Me.radCheckBoxFirstButton.Size = New System.Drawing.Size(106, 18)
			Me.radCheckBoxFirstButton.TabIndex = 19
			Me.radCheckBoxFirstButton.Text = "Show first button"
			Me.radCheckBoxFirstButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radSpinEditorPageButtons
			' 
			Me.radSpinEditorPageButtons.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorPageButtons.Location = New System.Drawing.Point(10, 108)
			Me.radSpinEditorPageButtons.Maximum = New Decimal(New Integer() { 25, 0, 0, 0})
			Me.radSpinEditorPageButtons.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditorPageButtons.Name = "radSpinEditorPageButtons"
			Me.radSpinEditorPageButtons.Size = New System.Drawing.Size(210, 20)
			Me.radSpinEditorPageButtons.TabIndex = 8
			Me.radSpinEditorPageButtons.TabStop = False
			Me.radSpinEditorPageButtons.Value = New Decimal(New Integer() { 5, 0, 0, 0})
			' 
			' radSpinEditorPageSize
			' 
			Me.radSpinEditorPageSize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorPageSize.Location = New System.Drawing.Point(10, 57)
			Me.radSpinEditorPageSize.Maximum = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.radSpinEditorPageSize.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.radSpinEditorPageSize.Name = "radSpinEditorPageSize"
			Me.radSpinEditorPageSize.Size = New System.Drawing.Size(210, 20)
			Me.radSpinEditorPageSize.TabIndex = 9
			Me.radSpinEditorPageSize.TabStop = False
			Me.radSpinEditorPageSize.Value = New Decimal(New Integer() { 30, 0, 0, 0})
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel3.Location = New System.Drawing.Point(10, 83)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(129, 18)
			Me.radLabel3.TabIndex = 6
			Me.radLabel3.Text = "Number of page buttons"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 32)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(52, 18)
			Me.radLabel1.TabIndex = 7
			Me.radLabel1.Text = "Page size"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radVirtualGrid1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1881, 1096)
			Me.Controls.SetChildIndex(Me.radVirtualGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radVirtualGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxLastButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxNextButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxFastForwardButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxNumericalButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxFastBackButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxTextBoxStrip, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxPreviousButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxButtonsStrip, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxFirstButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorPageButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSpinEditorPageSize, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radVirtualGrid1 As Telerik.WinControls.UI.RadVirtualGrid
		Private radCheckBoxLastButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxNextButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFastForwardButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxNumericalButtons As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFastBackButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxTextBoxStrip As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxPreviousButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxButtonsStrip As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFirstButton As Telerik.WinControls.UI.RadCheckBox
		Private radSpinEditorPageButtons As Telerik.WinControls.UI.RadSpinEditor
		Private radSpinEditorPageSize As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace