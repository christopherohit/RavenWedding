Namespace Telerik.Examples.WinControls.VirtualKeyboard.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radCheckBoxScaleFont = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxSyncWithSystem = New Telerik.WinControls.UI.RadCheckBox()
            Me.radButtonSaveLayout = New Telerik.WinControls.UI.RadButton()
            Me.radListControlSentKeys = New Telerik.WinControls.UI.RadListControl()
            Me.radButtonClear = New Telerik.WinControls.UI.RadButton()
            Me.radLabelEvents = New Telerik.WinControls.UI.RadLabel()
            Me.radGroupBoxLayout = New Telerik.WinControls.UI.RadGroupBox()
            Me.radButtonLoadLayout = New Telerik.WinControls.UI.RadButton()
            Me.radRadioButtonNumpad = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonSimplified = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonExtended = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonColemak = New Telerik.WinControls.UI.RadRadioButton()
            Me.radRadioButtonDvorak = New Telerik.WinControls.UI.RadRadioButton()
            Me.radVirtualKeyboard1 = New Telerik.WinControls.UI.RadVirtualKeyboard()
            Me.radLabelLayoutType = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownListScaleFactor = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxScaleFont, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCheckBoxSyncWithSystem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radListControlSentKeys, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelEvents, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radGroupBoxLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupBoxLayout.SuspendLayout()
            CType(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonNumpad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonSimplified, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonExtended, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonColemak, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRadioButtonDvorak, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radVirtualKeyboard1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelLayoutType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDropDownListScaleFactor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radVirtualKeyboard1)
            Me.radPanelDemoHolder.Controls.Add(Me.radLabelLayoutType)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(80, 31)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(1030, 389)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1130, 14)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabel1)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownListScaleFactor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupBoxLayout)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelEvents)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radButtonClear)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radListControlSentKeys)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxSyncWithSystem)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxScaleFont)
            '
            'optionsLabel
            '
            Me.optionsLabel.Location = New System.Drawing.Point(122, 560)
            '
            'radCheckBoxScaleFont
            '
            Me.radCheckBoxScaleFont.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxScaleFont.Location = New System.Drawing.Point(5, 219)
            Me.radCheckBoxScaleFont.Name = "radCheckBoxScaleFont"
            Me.radCheckBoxScaleFont.Size = New System.Drawing.Size(122, 18)
            Me.radCheckBoxScaleFont.TabIndex = 3
            Me.radCheckBoxScaleFont.Text = "Scale Font on Resize"
            Me.radCheckBoxScaleFont.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radCheckBoxSyncWithSystem
            '
            Me.radCheckBoxSyncWithSystem.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxSyncWithSystem.Location = New System.Drawing.Point(5, 269)
            Me.radCheckBoxSyncWithSystem.Name = "radCheckBoxSyncWithSystem"
            Me.radCheckBoxSyncWithSystem.Size = New System.Drawing.Size(126, 18)
            Me.radCheckBoxSyncWithSystem.TabIndex = 4
            Me.radCheckBoxSyncWithSystem.Text = "Use system language"
            Me.radCheckBoxSyncWithSystem.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'radButtonSaveLayout
            '
            Me.radButtonSaveLayout.Location = New System.Drawing.Point(5, 145)
            Me.radButtonSaveLayout.Name = "radButtonSaveLayout"
            Me.radButtonSaveLayout.Size = New System.Drawing.Size(182, 24)
            Me.radButtonSaveLayout.TabIndex = 5
            Me.radButtonSaveLayout.Text = "Save Layout"
            '
            'radListControlSentKeys
            '
            Me.radListControlSentKeys.Location = New System.Drawing.Point(5, 317)
            Me.radListControlSentKeys.Name = "radListControlSentKeys"
            Me.radListControlSentKeys.Size = New System.Drawing.Size(192, 207)
            Me.radListControlSentKeys.TabIndex = 6
            '
            'radButtonClear
            '
            Me.radButtonClear.Location = New System.Drawing.Point(3, 530)
            Me.radButtonClear.Name = "radButtonClear"
            Me.radButtonClear.Size = New System.Drawing.Size(194, 24)
            Me.radButtonClear.TabIndex = 6
            Me.radButtonClear.Text = "Clear"
            '
            'radLabelEvents
            '
            Me.radLabelEvents.Location = New System.Drawing.Point(5, 293)
            Me.radLabelEvents.Name = "radLabelEvents"
            Me.radLabelEvents.Size = New System.Drawing.Size(62, 18)
            Me.radLabelEvents.TabIndex = 7
            Me.radLabelEvents.Text = "Key events:"
            '
            'radGroupBoxLayout
            '
            Me.radGroupBoxLayout.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupBoxLayout.Controls.Add(Me.radButtonLoadLayout)
            Me.radGroupBoxLayout.Controls.Add(Me.radRadioButtonNumpad)
            Me.radGroupBoxLayout.Controls.Add(Me.radRadioButtonSimplified)
            Me.radGroupBoxLayout.Controls.Add(Me.radRadioButtonExtended)
            Me.radGroupBoxLayout.Controls.Add(Me.radRadioButtonColemak)
            Me.radGroupBoxLayout.Controls.Add(Me.radRadioButtonDvorak)
            Me.radGroupBoxLayout.Controls.Add(Me.radButtonSaveLayout)
            Me.radGroupBoxLayout.HeaderText = "Choose Layout:"
            Me.radGroupBoxLayout.Location = New System.Drawing.Point(5, 3)
            Me.radGroupBoxLayout.Name = "radGroupBoxLayout"
            Me.radGroupBoxLayout.Size = New System.Drawing.Size(192, 210)
            Me.radGroupBoxLayout.TabIndex = 8
            Me.radGroupBoxLayout.Text = "Choose Layout:"
            '
            'radButtonLoadLayout
            '
            Me.radButtonLoadLayout.Location = New System.Drawing.Point(5, 175)
            Me.radButtonLoadLayout.Name = "radButtonLoadLayout"
            Me.radButtonLoadLayout.Size = New System.Drawing.Size(182, 24)
            Me.radButtonLoadLayout.TabIndex = 6
            Me.radButtonLoadLayout.Text = "Load Layout"
            '
            'radRadioButtonNumpad
            '
            Me.radRadioButtonNumpad.Location = New System.Drawing.Point(6, 121)
            Me.radRadioButtonNumpad.Name = "radRadioButtonNumpad"
            Me.radRadioButtonNumpad.Size = New System.Drawing.Size(64, 18)
            Me.radRadioButtonNumpad.TabIndex = 10
            Me.radRadioButtonNumpad.Text = "Numpad"
            '
            'radRadioButtonSimplified
            '
            Me.radRadioButtonSimplified.Location = New System.Drawing.Point(6, 97)
            Me.radRadioButtonSimplified.Name = "radRadioButtonSimplified"
            Me.radRadioButtonSimplified.Size = New System.Drawing.Size(117, 18)
            Me.radRadioButtonSimplified.TabIndex = 9
            Me.radRadioButtonSimplified.Text = "QWERTY Simplified"
            '
            'radRadioButtonExtended
            '
            Me.radRadioButtonExtended.Location = New System.Drawing.Point(6, 73)
            Me.radRadioButtonExtended.Name = "radRadioButtonExtended"
            Me.radRadioButtonExtended.Size = New System.Drawing.Size(113, 18)
            Me.radRadioButtonExtended.TabIndex = 8
            Me.radRadioButtonExtended.Text = "QWERTY Extended"
            '
            'radRadioButtonColemak
            '
            Me.radRadioButtonColemak.Location = New System.Drawing.Point(6, 49)
            Me.radRadioButtonColemak.Name = "radRadioButtonColemak"
            Me.radRadioButtonColemak.Size = New System.Drawing.Size(64, 18)
            Me.radRadioButtonColemak.TabIndex = 7
            Me.radRadioButtonColemak.Text = "Colemak"
            '
            'radRadioButtonDvorak
            '
            Me.radRadioButtonDvorak.Location = New System.Drawing.Point(6, 25)
            Me.radRadioButtonDvorak.Name = "radRadioButtonDvorak"
            Me.radRadioButtonDvorak.Size = New System.Drawing.Size(56, 18)
            Me.radRadioButtonDvorak.TabIndex = 6
            Me.radRadioButtonDvorak.Text = "Dvorak"
            '
            'radVirtualKeyboard1
            '
            Me.radVirtualKeyboard1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radVirtualKeyboard1.Location = New System.Drawing.Point(0, 55)
            Me.radVirtualKeyboard1.Name = "radVirtualKeyboard1"
            Me.radVirtualKeyboard1.Size = New System.Drawing.Size(1030, 334)
            Me.radVirtualKeyboard1.TabIndex = 0
            Me.radVirtualKeyboard1.TabStop = False
            '
            'radLabelLayoutType
            '
            Me.radLabelLayoutType.AutoSize = False
            Me.radLabelLayoutType.Dock = System.Windows.Forms.DockStyle.Top
            Me.radLabelLayoutType.Font = New System.Drawing.Font("Segoe UI", 16.25!)
            Me.radLabelLayoutType.Location = New System.Drawing.Point(0, 0)
            Me.radLabelLayoutType.Name = "radLabelLayoutType"
            Me.radLabelLayoutType.Size = New System.Drawing.Size(1030, 55)
            Me.radLabelLayoutType.TabIndex = 1
            Me.radLabelLayoutType.Text = "radLabelLayoutType"
            Me.radLabelLayoutType.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            '
            'radDropDownListScaleFactor
            '
            Me.radDropDownListScaleFactor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListScaleFactor.Location = New System.Drawing.Point(97, 243)
            Me.radDropDownListScaleFactor.Name = "radDropDownListScaleFactor"
            Me.radDropDownListScaleFactor.Size = New System.Drawing.Size(100, 20)
            Me.radDropDownListScaleFactor.TabIndex = 9
            Me.radDropDownListScaleFactor.Tag = "Right"
            '
            'radLabel1
            '
            Me.radLabel1.Location = New System.Drawing.Point(5, 243)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(66, 18)
            Me.radLabel1.TabIndex = 10
            Me.radLabel1.Text = "Scale factor:"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1991, 1156)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxScaleFont, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCheckBoxSyncWithSystem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonSaveLayout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radListControlSentKeys, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelEvents, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radGroupBoxLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupBoxLayout.ResumeLayout(False)
            Me.radGroupBoxLayout.PerformLayout()
            CType(Me.radButtonLoadLayout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonNumpad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonSimplified, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonExtended, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonColemak, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRadioButtonDvorak, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radVirtualKeyboard1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelLayoutType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDropDownListScaleFactor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents radCheckBoxSyncWithSystem As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radCheckBoxScaleFont As Telerik.WinControls.UI.RadCheckBox
        Private WithEvents radButtonSaveLayout As Telerik.WinControls.UI.RadButton
        Private radLabelEvents As Telerik.WinControls.UI.RadLabel
        Private WithEvents radButtonClear As Telerik.WinControls.UI.RadButton
        Private radListControlSentKeys As Telerik.WinControls.UI.RadListControl
        Private radGroupBoxLayout As Telerik.WinControls.UI.RadGroupBox
        Private WithEvents radRadioButtonNumpad As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioButtonSimplified As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioButtonExtended As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioButtonColemak As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radRadioButtonDvorak As Telerik.WinControls.UI.RadRadioButton
        Private WithEvents radButtonLoadLayout As Telerik.WinControls.UI.RadButton
        Private radLabelLayoutType As Telerik.WinControls.UI.RadLabel
        Private WithEvents radVirtualKeyboard1 As Telerik.WinControls.UI.RadVirtualKeyboard
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private WithEvents radDropDownListScaleFactor As Telerik.WinControls.UI.RadDropDownList
    End Class
End Namespace
