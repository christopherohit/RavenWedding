
Namespace Telerik.Examples.WinControls.GridView.ManipulateData.Paging
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorPageSize = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radDropDownListPagingGroupingPriority = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radSpinEditorPageButtons = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckBoxFirstButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxPreviousButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxFastBackButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxNumericalButtons = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxFastForwardButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxNextButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxLastButton = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxButtonsStrip = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxTextBoxStrip = New Telerik.WinControls.UI.RadCheckBox()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radSpinEditorPageSize, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radDropDownListPagingGroupingPriority, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radSpinEditorPageButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxFirstButton, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxPreviousButton, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxFastBackButton, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxNumericalButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxFastForwardButton, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxNextButton, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxLastButton, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxButtonsStrip, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxTextBoxStrip, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.settingsPanel.Controls.Add(Me.radDropDownListPagingGroupingPriority)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorPageButtons)
			Me.settingsPanel.Controls.Add(Me.radSpinEditorPageSize)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.radLabel3)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Size = New System.Drawing.Size(230, 507)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel3, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorPageSize, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radSpinEditorPageButtons, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownListPagingGroupingPriority, 0)
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
			' radGridView1
			' 
			Me.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Location = New System.Drawing.Point(0, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.EnableFiltering = True
			Me.radGridView1.MasterTemplate.EnablePaging = True
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(1490, 1084)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
            DirectCast(Me.radGridView1.GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.PagingPanelElement).NumericButtonsCount = 10
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 33)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(52, 18)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Page size"
			' 
			' radSpinEditorPageSize
			' 
			Me.radSpinEditorPageSize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorPageSize.Location = New System.Drawing.Point(10, 58)
			Me.radSpinEditorPageSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
			Me.radSpinEditorPageSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
			Me.radSpinEditorPageSize.Name = "radSpinEditorPageSize"
			Me.radSpinEditorPageSize.Size = New System.Drawing.Size(210, 20)
			Me.radSpinEditorPageSize.TabIndex = 2
			Me.radSpinEditorPageSize.TabStop = False
			Me.radSpinEditorPageSize.Value = New Decimal(New Integer() {20, 0, 0, 0})
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(10, 84)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(150, 18)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "Paging and grouping priority"
			' 
			' radDropDownListPagingGroupingPriority
			' 
			Me.radDropDownListPagingGroupingPriority.Anchor = System.Windows.Forms.AnchorStyles.Top
            radListDataItem1.Text = "Paging before grouping"
			radListDataItem1.TextWrap = True
            radListDataItem2.Text = "Grouping before paging"
			radListDataItem2.TextWrap = True
			Me.radDropDownListPagingGroupingPriority.Items.Add(radListDataItem1)
			Me.radDropDownListPagingGroupingPriority.Items.Add(radListDataItem2)
			Me.radDropDownListPagingGroupingPriority.Location = New System.Drawing.Point(10, 109)
			Me.radDropDownListPagingGroupingPriority.Name = "radDropDownListPagingGroupingPriority"
			Me.radDropDownListPagingGroupingPriority.Size = New System.Drawing.Size(210, 20)
			Me.radDropDownListPagingGroupingPriority.TabIndex = 3
            Me.radDropDownListPagingGroupingPriority.Text = "Paging before grouping"
            Me.radDropDownListPagingGroupingPriority.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel3.Location = New System.Drawing.Point(10, 135)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(129, 18)
			Me.radLabel3.TabIndex = 1
			Me.radLabel3.Text = "Number of page buttons"
			' 
			' radSpinEditorPageButtons
			' 
			Me.radSpinEditorPageButtons.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radSpinEditorPageButtons.Location = New System.Drawing.Point(10, 160)
			Me.radSpinEditorPageButtons.Maximum = New Decimal(New Integer() {35, 0, 0, 0})
			Me.radSpinEditorPageButtons.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
			Me.radSpinEditorPageButtons.Name = "radSpinEditorPageButtons"
			Me.radSpinEditorPageButtons.Size = New System.Drawing.Size(210, 20)
			Me.radSpinEditorPageButtons.TabIndex = 2
			Me.radSpinEditorPageButtons.TabStop = False
			Me.radSpinEditorPageButtons.Value = New Decimal(New Integer() {10, 0, 0, 0})
			' 
			' radCheckBoxFirstButton
			' 
			Me.radCheckBoxFirstButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFirstButton.Location = New System.Drawing.Point(10, 245)
			Me.radCheckBoxFirstButton.Name = "radCheckBoxFirstButton"
			Me.radCheckBoxFirstButton.Size = New System.Drawing.Size(106, 18)
			Me.radCheckBoxFirstButton.TabIndex = 4
			Me.radCheckBoxFirstButton.Text = "Show first button"
			Me.radCheckBoxFirstButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxPreviousButton
			' 
			Me.radCheckBoxPreviousButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxPreviousButton.Location = New System.Drawing.Point(10, 269)
			Me.radCheckBoxPreviousButton.Name = "radCheckBoxPreviousButton"
			Me.radCheckBoxPreviousButton.Size = New System.Drawing.Size(130, 18)
			Me.radCheckBoxPreviousButton.TabIndex = 4
			Me.radCheckBoxPreviousButton.Text = "Show previous button"
			Me.radCheckBoxPreviousButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxFastBackButton
			' 
			Me.radCheckBoxFastBackButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFastBackButton.Location = New System.Drawing.Point(10, 293)
			Me.radCheckBoxFastBackButton.Name = "radCheckBoxFastBackButton"
			Me.radCheckBoxFastBackButton.Size = New System.Drawing.Size(132, 18)
			Me.radCheckBoxFastBackButton.TabIndex = 4
			Me.radCheckBoxFastBackButton.Text = "Show fast back button"
			Me.radCheckBoxFastBackButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxNumericalButtons
			' 
			Me.radCheckBoxNumericalButtons.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxNumericalButtons.Location = New System.Drawing.Point(10, 317)
			Me.radCheckBoxNumericalButtons.Name = "radCheckBoxNumericalButtons"
			Me.radCheckBoxNumericalButtons.Size = New System.Drawing.Size(141, 18)
			Me.radCheckBoxNumericalButtons.TabIndex = 4
			Me.radCheckBoxNumericalButtons.Text = "Show numerical buttons"
			Me.radCheckBoxNumericalButtons.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxFastForwardButton
			' 
			Me.radCheckBoxFastForwardButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFastForwardButton.Location = New System.Drawing.Point(10, 341)
			Me.radCheckBoxFastForwardButton.Name = "radCheckBoxFastForwardButton"
			Me.radCheckBoxFastForwardButton.Size = New System.Drawing.Size(147, 18)
			Me.radCheckBoxFastForwardButton.TabIndex = 4
			Me.radCheckBoxFastForwardButton.Text = "Show fast forward button"
			Me.radCheckBoxFastForwardButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxNextButton
			' 
			Me.radCheckBoxNextButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxNextButton.Location = New System.Drawing.Point(10, 365)
			Me.radCheckBoxNextButton.Name = "radCheckBoxNextButton"
			Me.radCheckBoxNextButton.Size = New System.Drawing.Size(109, 18)
			Me.radCheckBoxNextButton.TabIndex = 4
			Me.radCheckBoxNextButton.Text = "Show next button"
			Me.radCheckBoxNextButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxLastButton
			' 
			Me.radCheckBoxLastButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxLastButton.Location = New System.Drawing.Point(10, 389)
			Me.radCheckBoxLastButton.Name = "radCheckBoxLastButton"
			Me.radCheckBoxLastButton.Size = New System.Drawing.Size(105, 18)
			Me.radCheckBoxLastButton.TabIndex = 4
			Me.radCheckBoxLastButton.Text = "Show last button"
			Me.radCheckBoxLastButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxButtonsStrip
			' 
			Me.radCheckBoxButtonsStrip.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxButtonsStrip.Location = New System.Drawing.Point(10, 197)
			Me.radCheckBoxButtonsStrip.Name = "radCheckBoxButtonsStrip"
			Me.radCheckBoxButtonsStrip.Size = New System.Drawing.Size(114, 18)
			Me.radCheckBoxButtonsStrip.TabIndex = 4
			Me.radCheckBoxButtonsStrip.Text = "Show buttons strip"
			Me.radCheckBoxButtonsStrip.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxTextBoxStrip
			' 
			Me.radCheckBoxTextBoxStrip.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxTextBoxStrip.Location = New System.Drawing.Point(10, 221)
			Me.radCheckBoxTextBoxStrip.Name = "radCheckBoxTextBoxStrip"
			Me.radCheckBoxTextBoxStrip.Size = New System.Drawing.Size(113, 18)
			Me.radCheckBoxTextBoxStrip.TabIndex = 4
			Me.radCheckBoxTextBoxStrip.Text = "Show textbox strip"
			Me.radCheckBoxTextBoxStrip.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1500, 1094)
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			DirectCast(Me.radGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radSpinEditorPageSize, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radDropDownListPagingGroupingPriority, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radSpinEditorPageButtons, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxFirstButton, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxPreviousButton, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxFastBackButton, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxNumericalButtons, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxFastForwardButton, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxNextButton, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxLastButton, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxButtonsStrip, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxTextBoxStrip, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radDropDownListPagingGroupingPriority As Telerik.WinControls.UI.RadDropDownList
		Private radSpinEditorPageSize As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radSpinEditorPageButtons As Telerik.WinControls.UI.RadSpinEditor
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radCheckBoxLastButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxNextButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFastForwardButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxNumericalButtons As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFastBackButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxPreviousButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxFirstButton As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxTextBoxStrip As Telerik.WinControls.UI.RadCheckBox
		Private radCheckBoxButtonsStrip As Telerik.WinControls.UI.RadCheckBox

	End Class
End Namespace
