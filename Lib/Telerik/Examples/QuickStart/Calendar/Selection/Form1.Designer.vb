Namespace Telerik.Examples.WinControls.Calendar.Selection
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
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radGroupAllowSelect = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioAllowSelectEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAllowSelectDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupMultiSelect = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioMultiSelectEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioMultiSelectDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupShowRowHeader = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioShowRowHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioShowRowHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
            Me.radGroupAllowViewSelector = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioEnableAllowViewSelectorEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioEnableAllowViewSelectorDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupAllowRowHeader = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioAllowRowHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAllowRowHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupAllowColumnHeader = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioAllowColumnHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioAllowColumnHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupColumnHeaders = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioColumnHeaderEnable = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioColumnHeaderDisable = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.PanelContainer.SuspendLayout()
			Me.settingsPanel.SuspendLayout()
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowSelect, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowSelect.SuspendLayout()
			CType(Me.radRadioAllowSelectEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAllowSelectDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupMultiSelect, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupMultiSelect.SuspendLayout()
			CType(Me.radRadioMultiSelectEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioMultiSelectDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupShowRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupShowRowHeader.SuspendLayout()
			CType(Me.radRadioShowRowHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioShowRowHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowViewSelector, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowViewSelector.SuspendLayout()
			CType(Me.radRadioEnableAllowViewSelectorEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioEnableAllowViewSelectorDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowRowHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowRowHeader.SuspendLayout()
			CType(Me.radRadioAllowRowHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAllowRowHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupAllowColumnHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupAllowColumnHeader.SuspendLayout()
			CType(Me.radRadioAllowColumnHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioAllowColumnHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupColumnHeaders, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupColumnHeaders.SuspendLayout()
			CType(Me.radRadioColumnHeaderEnable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioColumnHeaderDisable, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New Point(857, 1)
			Me.settingsPanel.Margin = New Padding(4, 4, 4, 4)
			' 
			' settingsPanel.PanelContainer
			' 
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupAllowSelect)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupMultiSelect)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupAllowColumnHeader)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupColumnHeaders)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupAllowRowHeader)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupAllowViewSelector)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupShowRowHeader)
			Me.settingsPanel.PanelContainer.Controls.Add(Me.radButton1)
			Me.settingsPanel.PanelContainer.Margin = New Padding(4, 4, 4, 4)
			Me.settingsPanel.PanelContainer.Size = New Size(364, 1072)
			Me.settingsPanel.Size = New Size(364, 1072)
			' 
			' optionsLabel
			' 
			Me.optionsLabel.Location = New Point(3, 3)
			Me.optionsLabel.Margin = New Padding(2, 2, 2, 2)
			Me.optionsLabel.Size = New Size(58, 19)
			' 
			' radButton1
			' 
			Me.radButton1.Location = New Point(19, 907)
			Me.radButton1.Margin = New Padding(4, 4, 4, 4)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New Size(240, 28)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "Clear Selections"
			' 
			' radCalendar1
			' 
			Me.radCalendar1.FocusedDate = New Date(2009, 3, 5, 0, 0, 0, 0)
			Me.radCalendar1.HeaderHeight = 23
			Me.radCalendar1.HeaderWidth = 23
            Me.radCalendar1.Location = New Point(20, 20)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.ShowViewSelector = True
			Me.radCalendar1.Size = New Size(384, 282)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radGroupAllowSelect
			' 
			Me.radGroupAllowSelect.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupAllowSelect.Anchor = AnchorStyles.Top
			Me.radGroupAllowSelect.Controls.Add(Me.radRadioAllowSelectEnable)
			Me.radGroupAllowSelect.Controls.Add(Me.radRadioAllowSelectDisable)
			Me.radGroupAllowSelect.HeaderText = "Allow Select"
			Me.radGroupAllowSelect.Location = New Point(19, 40)
			Me.radGroupAllowSelect.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupAllowSelect.Name = "radGroupAllowSelect"
			Me.radGroupAllowSelect.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupAllowSelect.Size = New Size(240, 110)
			Me.radGroupAllowSelect.TabIndex = 6
			Me.radGroupAllowSelect.Text = "Allow Select"
			' 
			' radRadioAllowSelectEnable
			' 
			Me.radRadioAllowSelectEnable.Location = New Point(23, 30)
			Me.radRadioAllowSelectEnable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioAllowSelectEnable.Name = "radRadioAllowSelectEnable"
			Me.radRadioAllowSelectEnable.Size = New Size(43, 15)
			Me.radRadioAllowSelectEnable.TabIndex = 7
			Me.radRadioAllowSelectEnable.Text = "Enable"
			' 
			' radRadioAllowSelectDisable
			' 
			Me.radRadioAllowSelectDisable.Location = New Point(23, 72)
			Me.radRadioAllowSelectDisable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioAllowSelectDisable.Name = "radRadioAllowSelectDisable"
			Me.radRadioAllowSelectDisable.Size = New Size(46, 15)
			Me.radRadioAllowSelectDisable.TabIndex = 7
			Me.radRadioAllowSelectDisable.Text = "Disable"
			' 
			' radGroupMultiSelect
			' 
			Me.radGroupMultiSelect.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupMultiSelect.Anchor = AnchorStyles.Top
			Me.radGroupMultiSelect.Controls.Add(Me.radRadioMultiSelectEnable)
			Me.radGroupMultiSelect.Controls.Add(Me.radRadioMultiSelectDisable)
			Me.radGroupMultiSelect.HeaderText = "Allow Multi Select"
			Me.radGroupMultiSelect.Location = New Point(19, 164)
			Me.radGroupMultiSelect.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupMultiSelect.Name = "radGroupMultiSelect"
			Me.radGroupMultiSelect.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupMultiSelect.Size = New Size(240, 110)
			Me.radGroupMultiSelect.TabIndex = 6
			Me.radGroupMultiSelect.Text = "Allow Multi Select"
			' 
			' radRadioMultiSelectEnable
			' 
			Me.radRadioMultiSelectEnable.Location = New Point(27, 30)
			Me.radRadioMultiSelectEnable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioMultiSelectEnable.Name = "radRadioMultiSelectEnable"
			Me.radRadioMultiSelectEnable.Size = New Size(43, 15)
			Me.radRadioMultiSelectEnable.TabIndex = 7
			Me.radRadioMultiSelectEnable.Text = "Enable"
			' 
			' radRadioMultiSelectDisable
			' 
			Me.radRadioMultiSelectDisable.Location = New Point(27, 72)
			Me.radRadioMultiSelectDisable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioMultiSelectDisable.Name = "radRadioMultiSelectDisable"
			Me.radRadioMultiSelectDisable.Size = New Size(46, 15)
			Me.radRadioMultiSelectDisable.TabIndex = 7
			Me.radRadioMultiSelectDisable.Text = "Disable"
			' 
			' radGroupShowRowHeader
			' 
			Me.radGroupShowRowHeader.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupShowRowHeader.Anchor = AnchorStyles.Top
			Me.radGroupShowRowHeader.Controls.Add(Me.radRadioShowRowHeaderEnable)
			Me.radGroupShowRowHeader.Controls.Add(Me.radRadioShowRowHeaderDisable)
			Me.radGroupShowRowHeader.HeaderText = "Show Row Selectors"
			Me.radGroupShowRowHeader.Location = New Point(19, 415)
			Me.radGroupShowRowHeader.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupShowRowHeader.Name = "radGroupShowRowHeader"
			Me.radGroupShowRowHeader.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupShowRowHeader.Size = New Size(240, 110)
			Me.radGroupShowRowHeader.TabIndex = 6
			Me.radGroupShowRowHeader.Text = "Show Row Selectors"
			' 
			' radRadioShowRowHeaderEnable
			' 
			Me.radRadioShowRowHeaderEnable.Location = New Point(29, 28)
			Me.radRadioShowRowHeaderEnable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioShowRowHeaderEnable.Name = "radRadioShowRowHeaderEnable"
			Me.radRadioShowRowHeaderEnable.Size = New Size(43, 15)
			Me.radRadioShowRowHeaderEnable.TabIndex = 7
			Me.radRadioShowRowHeaderEnable.Text = "Enable"
			' 
			' radRadioShowRowHeaderDisable
			' 
			Me.radRadioShowRowHeaderDisable.Location = New Point(29, 72)
			Me.radRadioShowRowHeaderDisable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioShowRowHeaderDisable.Name = "radRadioShowRowHeaderDisable"
			Me.radRadioShowRowHeaderDisable.Size = New Size(46, 15)
			Me.radRadioShowRowHeaderDisable.TabIndex = 7
			Me.radRadioShowRowHeaderDisable.Text = "Disable"
			' 
			' radGroupAllowViewSelector
			' 
			Me.radGroupAllowViewSelector.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupAllowViewSelector.Anchor = AnchorStyles.Top
			Me.radGroupAllowViewSelector.Controls.Add(Me.radRadioEnableAllowViewSelectorEnable)
			Me.radGroupAllowViewSelector.Controls.Add(Me.radRadioEnableAllowViewSelectorDisable)
			Me.radGroupAllowViewSelector.HeaderText = "Allow View Selector"
			Me.radGroupAllowViewSelector.Location = New Point(19, 293)
			Me.radGroupAllowViewSelector.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupAllowViewSelector.Name = "radGroupAllowViewSelector"
			Me.radGroupAllowViewSelector.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupAllowViewSelector.Size = New Size(240, 110)
			Me.radGroupAllowViewSelector.TabIndex = 6
			Me.radGroupAllowViewSelector.Text = "Allow View Selector"
			' 
			' radRadioEnableAllowViewSelectorEnable
			' 
			Me.radRadioEnableAllowViewSelectorEnable.Location = New Point(23, 28)
			Me.radRadioEnableAllowViewSelectorEnable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioEnableAllowViewSelectorEnable.Name = "radRadioEnableAllowViewSelectorEnable"
			Me.radRadioEnableAllowViewSelectorEnable.Size = New Size(43, 15)
			Me.radRadioEnableAllowViewSelectorEnable.TabIndex = 7
			Me.radRadioEnableAllowViewSelectorEnable.Text = "Enable"
			' 
			' radRadioEnableAllowViewSelectorDisable
			' 
			Me.radRadioEnableAllowViewSelectorDisable.Location = New Point(23, 72)
			Me.radRadioEnableAllowViewSelectorDisable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioEnableAllowViewSelectorDisable.Name = "radRadioEnableAllowViewSelectorDisable"
			Me.radRadioEnableAllowViewSelectorDisable.Size = New Size(46, 15)
			Me.radRadioEnableAllowViewSelectorDisable.TabIndex = 7
			Me.radRadioEnableAllowViewSelectorDisable.Text = "Disable"
			' 
			' radGroupAllowRowHeader
			' 
			Me.radGroupAllowRowHeader.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupAllowRowHeader.Anchor = AnchorStyles.Top
			Me.radGroupAllowRowHeader.Controls.Add(Me.radRadioAllowRowHeaderEnable)
			Me.radGroupAllowRowHeader.Controls.Add(Me.radRadioAllowRowHeaderDisable)
			Me.radGroupAllowRowHeader.HeaderText = "Allow Row Selectors"
			Me.radGroupAllowRowHeader.Location = New Point(19, 653)
			Me.radGroupAllowRowHeader.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupAllowRowHeader.Name = "radGroupAllowRowHeader"
			Me.radGroupAllowRowHeader.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupAllowRowHeader.Size = New Size(240, 110)
			Me.radGroupAllowRowHeader.TabIndex = 6
			Me.radGroupAllowRowHeader.Text = "Allow Row Selectors"
			' 
			' radRadioAllowRowHeaderEnable
			' 
			Me.radRadioAllowRowHeaderEnable.Location = New Point(27, 28)
			Me.radRadioAllowRowHeaderEnable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioAllowRowHeaderEnable.Name = "radRadioAllowRowHeaderEnable"
			Me.radRadioAllowRowHeaderEnable.Size = New Size(43, 15)
			Me.radRadioAllowRowHeaderEnable.TabIndex = 7
			Me.radRadioAllowRowHeaderEnable.Text = "Enable"
			' 
			' radRadioAllowRowHeaderDisable
			' 
			Me.radRadioAllowRowHeaderDisable.Location = New Point(27, 72)
			Me.radRadioAllowRowHeaderDisable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioAllowRowHeaderDisable.Name = "radRadioAllowRowHeaderDisable"
			Me.radRadioAllowRowHeaderDisable.Size = New Size(46, 15)
			Me.radRadioAllowRowHeaderDisable.TabIndex = 7
			Me.radRadioAllowRowHeaderDisable.Text = "Disable"
			' 
			' radGroupAllowColumnHeader
			' 
			Me.radGroupAllowColumnHeader.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupAllowColumnHeader.Anchor = AnchorStyles.Top
			Me.radGroupAllowColumnHeader.Controls.Add(Me.radRadioAllowColumnHeaderEnable)
			Me.radGroupAllowColumnHeader.Controls.Add(Me.radRadioAllowColumnHeaderDisable)
			Me.radGroupAllowColumnHeader.HeaderText = "Allow Column Selector"
			Me.radGroupAllowColumnHeader.Location = New Point(19, 771)
			Me.radGroupAllowColumnHeader.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupAllowColumnHeader.Name = "radGroupAllowColumnHeader"
			Me.radGroupAllowColumnHeader.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupAllowColumnHeader.Size = New Size(240, 110)
			Me.radGroupAllowColumnHeader.TabIndex = 6
			Me.radGroupAllowColumnHeader.Text = "Allow Column Selector"
			' 
			' radRadioAllowColumnHeaderEnable
			' 
			Me.radRadioAllowColumnHeaderEnable.Location = New Point(27, 26)
			Me.radRadioAllowColumnHeaderEnable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioAllowColumnHeaderEnable.Name = "radRadioAllowColumnHeaderEnable"
			Me.radRadioAllowColumnHeaderEnable.Size = New Size(43, 15)
			Me.radRadioAllowColumnHeaderEnable.TabIndex = 7
			Me.radRadioAllowColumnHeaderEnable.Text = "Enable"
			' 
			' radRadioAllowColumnHeaderDisable
			' 
			Me.radRadioAllowColumnHeaderDisable.Location = New Point(25, 72)
			Me.radRadioAllowColumnHeaderDisable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioAllowColumnHeaderDisable.Name = "radRadioAllowColumnHeaderDisable"
			Me.radRadioAllowColumnHeaderDisable.Size = New Size(46, 15)
			Me.radRadioAllowColumnHeaderDisable.TabIndex = 7
			Me.radRadioAllowColumnHeaderDisable.Text = "Disable"
			' 
			' radGroupColumnHeaders
			' 
			Me.radGroupColumnHeaders.AccessibleRole = AccessibleRole.Grouping
			Me.radGroupColumnHeaders.Anchor = AnchorStyles.Top
			Me.radGroupColumnHeaders.Controls.Add(Me.radRadioColumnHeaderEnable)
			Me.radGroupColumnHeaders.Controls.Add(Me.radRadioColumnHeaderDisable)
			Me.radGroupColumnHeaders.HeaderText = "Show Column Selectors"
			Me.radGroupColumnHeaders.Location = New Point(19, 535)
			Me.radGroupColumnHeaders.Margin = New Padding(4, 4, 4, 4)
			Me.radGroupColumnHeaders.Name = "radGroupColumnHeaders"
			Me.radGroupColumnHeaders.Padding = New Padding(13, 25, 13, 12)
			Me.radGroupColumnHeaders.Size = New Size(240, 110)
			Me.radGroupColumnHeaders.TabIndex = 6
			Me.radGroupColumnHeaders.Text = "Show Column Selectors"
			' 
			' radRadioColumnHeaderEnable
			' 
			Me.radRadioColumnHeaderEnable.Location = New Point(29, 28)
			Me.radRadioColumnHeaderEnable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioColumnHeaderEnable.Name = "radRadioColumnHeaderEnable"
			Me.radRadioColumnHeaderEnable.Size = New Size(43, 15)
			Me.radRadioColumnHeaderEnable.TabIndex = 7
			Me.radRadioColumnHeaderEnable.Text = "Enable"
			' 
			' radRadioColumnHeaderDisable
			' 
			Me.radRadioColumnHeaderDisable.Location = New Point(29, 72)
			Me.radRadioColumnHeaderDisable.Margin = New Padding(4, 4, 4, 4)
			Me.radRadioColumnHeaderDisable.Name = "radRadioColumnHeaderDisable"
			Me.radRadioColumnHeaderDisable.Size = New Size(46, 15)
			Me.radRadioColumnHeaderDisable.TabIndex = 7
			Me.radRadioColumnHeaderDisable.Text = "Disable"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New Size(2103, 1156)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.PanelContainer.ResumeLayout(False)
			Me.settingsPanel.PanelContainer.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowSelect, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowSelect.ResumeLayout(False)
			Me.radGroupAllowSelect.PerformLayout()
			CType(Me.radRadioAllowSelectEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAllowSelectDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupMultiSelect, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupMultiSelect.ResumeLayout(False)
			Me.radGroupMultiSelect.PerformLayout()
			CType(Me.radRadioMultiSelectEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioMultiSelectDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupShowRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupShowRowHeader.ResumeLayout(False)
			Me.radGroupShowRowHeader.PerformLayout()
			CType(Me.radRadioShowRowHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioShowRowHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowViewSelector, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowViewSelector.ResumeLayout(False)
			Me.radGroupAllowViewSelector.PerformLayout()
			CType(Me.radRadioEnableAllowViewSelectorEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioEnableAllowViewSelectorDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowRowHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowRowHeader.ResumeLayout(False)
			Me.radGroupAllowRowHeader.PerformLayout()
			CType(Me.radRadioAllowRowHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAllowRowHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupAllowColumnHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupAllowColumnHeader.ResumeLayout(False)
			Me.radGroupAllowColumnHeader.PerformLayout()
			CType(Me.radRadioAllowColumnHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioAllowColumnHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupColumnHeaders, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupColumnHeaders.ResumeLayout(False)
			Me.radGroupColumnHeaders.PerformLayout()
			CType(Me.radRadioColumnHeaderEnable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioColumnHeaderDisable, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radGroupAllowSelect As Telerik.WinControls.UI.RadGroupBox
		Private radGroupMultiSelect As Telerik.WinControls.UI.RadGroupBox
		Private radGroupShowRowHeader As Telerik.WinControls.UI.RadGroupBox
		Private radGroupAllowViewSelector As Telerik.WinControls.UI.RadGroupBox
		Private radGroupAllowRowHeader As Telerik.WinControls.UI.RadGroupBox
		Private radGroupAllowColumnHeader As Telerik.WinControls.UI.RadGroupBox
		Private radGroupColumnHeaders As Telerik.WinControls.UI.RadGroupBox
		Private radRadioAllowSelectEnable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAllowSelectDisable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioMultiSelectDisable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioMultiSelectEnable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioEnableAllowViewSelectorDisable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioEnableAllowViewSelectorEnable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioShowRowHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioShowRowHeaderDisable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioColumnHeaderDisable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioColumnHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAllowRowHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAllowRowHeaderDisable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAllowColumnHeaderEnable As Telerik.WinControls.UI.RadRadioButton
		Private radRadioAllowColumnHeaderDisable As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace