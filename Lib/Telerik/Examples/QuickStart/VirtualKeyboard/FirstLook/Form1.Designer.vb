Namespace Telerik.Examples.WinControls.VirtualKeyboard.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radVirtualKeyboard1 = New Telerik.WinControls.UI.RadVirtualKeyboard()
            Me.tableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.radLabelRequest = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelOnscreenKeyboard = New Telerik.WinControls.UI.RadLabel()
            Me.radToggleSwitchEnableKeyboard = New Telerik.WinControls.UI.RadToggleSwitch()
            Me.radLabelDescription = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBoxDescription = New Telerik.WinControls.UI.RadTextBox()
            Me.radButtonSubmit = New Telerik.WinControls.UI.RadButton()
            Me.radLabelTitle = New Telerik.WinControls.UI.RadLabel()
            Me.radTextBoxTitle = New Telerik.WinControls.UI.RadTextBox()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radVirtualKeyboard1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            CType(Me.radLabelRequest, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelOnscreenKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radToggleSwitchEnableKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radButtonSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radLabelTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radTextBoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.tableLayoutPanel1)
            Me.radPanelDemoHolder.Controls.Add(Me.radVirtualKeyboard1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(114, 77)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(850, 553)
            '
            'settingsPanel
            '
            '
            'radVirtualKeyboard1
            '
            Me.radVirtualKeyboard1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.radVirtualKeyboard1.LayoutType = Telerik.WinControls.VirtualKeyboard.KeyboardLayoutType.Simplified
            Me.radVirtualKeyboard1.Location = New System.Drawing.Point(0, 303)
            Me.radVirtualKeyboard1.Margin = New System.Windows.Forms.Padding(0)
            Me.radVirtualKeyboard1.Name = "radVirtualKeyboard1"
            Me.radVirtualKeyboard1.Size = New System.Drawing.Size(850, 250)
            Me.radVirtualKeyboard1.TabIndex = 0
            Me.radVirtualKeyboard1.TabStop = False
            '
            'tableLayoutPanel1
            '
            Me.tableLayoutPanel1.ColumnCount = 4
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelRequest, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelOnscreenKeyboard, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radToggleSwitchEnableKeyboard, 3, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelDescription, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxDescription, 0, 4)
            Me.tableLayoutPanel1.Controls.Add(Me.radButtonSubmit, 0, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.radLabelTitle, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.radTextBoxTitle, 0, 2)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(149, 38)
            Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 6
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(552, 235)
            Me.tableLayoutPanel1.TabIndex = 1
            '
            'radLabelRequest
            '
            Me.radLabelRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radLabelRequest.AutoSize = False
            Me.radLabelRequest.Font = New System.Drawing.Font("Segoe UI", 16.25!)
            Me.radLabelRequest.Location = New System.Drawing.Point(0, 0)
            Me.radLabelRequest.Margin = New System.Windows.Forms.Padding(0)
            Me.radLabelRequest.Name = "radLabelRequest"
            Me.radLabelRequest.Size = New System.Drawing.Size(182, 50)
            Me.radLabelRequest.TabIndex = 0
            Me.radLabelRequest.Text = "Make a request!"
            CType(Me.radLabelRequest.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Make a request!"
            CType(Me.radLabelRequest.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Padding = New System.Windows.Forms.Padding(-4, 0, 0, 0)
            '
            'radLabelOnscreenKeyboard
            '
            Me.radLabelOnscreenKeyboard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radLabelOnscreenKeyboard.AutoSize = False
            Me.tableLayoutPanel1.SetColumnSpan(Me.radLabelOnscreenKeyboard, 2)
            Me.radLabelOnscreenKeyboard.Location = New System.Drawing.Point(182, 0)
            Me.radLabelOnscreenKeyboard.Margin = New System.Windows.Forms.Padding(0)
            Me.radLabelOnscreenKeyboard.Name = "radLabelOnscreenKeyboard"
            Me.radLabelOnscreenKeyboard.Size = New System.Drawing.Size(303, 50)
            Me.radLabelOnscreenKeyboard.TabIndex = 1
            Me.radLabelOnscreenKeyboard.Text = "Keyboard on screen"
            Me.radLabelOnscreenKeyboard.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            '
            'radToggleSwitchEnableKeyboard
            '
            Me.radToggleSwitchEnableKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.radToggleSwitchEnableKeyboard.Location = New System.Drawing.Point(499, 15)
            Me.radToggleSwitchEnableKeyboard.Name = "radToggleSwitchEnableKeyboard"
            Me.radToggleSwitchEnableKeyboard.Size = New System.Drawing.Size(50, 20)
            Me.radToggleSwitchEnableKeyboard.TabIndex = 2
            '
            'radLabelDescription
            '
            Me.radLabelDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radLabelDescription.AutoSize = False
            Me.tableLayoutPanel1.SetColumnSpan(Me.radLabelDescription, 4)
            Me.radLabelDescription.Location = New System.Drawing.Point(0, 120)
            Me.radLabelDescription.Margin = New System.Windows.Forms.Padding(0)
            Me.radLabelDescription.Name = "radLabelDescription"
            Me.radLabelDescription.Size = New System.Drawing.Size(552, 30)
            Me.radLabelDescription.TabIndex = 5
            Me.radLabelDescription.Text = "Description"
            Me.radLabelDescription.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            '
            'radTextBoxDescription
            '
            Me.radTextBoxDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tableLayoutPanel1.SetColumnSpan(Me.radTextBoxDescription, 4)
            Me.radTextBoxDescription.Location = New System.Drawing.Point(3, 153)
            Me.radTextBoxDescription.Multiline = True
            Me.radTextBoxDescription.Name = "radTextBoxDescription"
            Me.radTextBoxDescription.NullText = "Describe your problem here..."
            '
            '
            '
            Me.radTextBoxDescription.RootElement.StretchVertically = True
            Me.radTextBoxDescription.Size = New System.Drawing.Size(546, 39)
            Me.radTextBoxDescription.TabIndex = 6
            '
            'radButtonSubmit
            '
            Me.radButtonSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tableLayoutPanel1.SetColumnSpan(Me.radButtonSubmit, 4)
            Me.radButtonSubmit.Location = New System.Drawing.Point(443, 208)
            Me.radButtonSubmit.MaximumSize = New System.Drawing.Size(0, 24)
            Me.radButtonSubmit.Name = "radButtonSubmit"
            '
            '
            '
            Me.radButtonSubmit.RootElement.MaxSize = New System.Drawing.Size(0, 24)
            Me.radButtonSubmit.Size = New System.Drawing.Size(106, 24)
            Me.radButtonSubmit.TabIndex = 7
            Me.radButtonSubmit.Text = "Submit"
            '
            'radLabelTitle
            '
            Me.radLabelTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radLabelTitle.AutoSize = False
            Me.tableLayoutPanel1.SetColumnSpan(Me.radLabelTitle, 4)
            Me.radLabelTitle.Location = New System.Drawing.Point(0, 50)
            Me.radLabelTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.radLabelTitle.Name = "radLabelTitle"
            Me.radLabelTitle.Size = New System.Drawing.Size(552, 30)
            Me.radLabelTitle.TabIndex = 3
            Me.radLabelTitle.Text = "Title"
            Me.radLabelTitle.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
            '
            'radTextBoxTitle
            '
            Me.radTextBoxTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tableLayoutPanel1.SetColumnSpan(Me.radTextBoxTitle, 4)
            Me.radTextBoxTitle.Location = New System.Drawing.Point(3, 90)
            Me.radTextBoxTitle.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.radTextBoxTitle.Name = "radTextBoxTitle"
            Me.radTextBoxTitle.NullText = "Enter request title..."
            Me.radTextBoxTitle.Size = New System.Drawing.Size(546, 20)
            Me.radTextBoxTitle.TabIndex = 4
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
            CType(Me.radVirtualKeyboard1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            CType(Me.radLabelRequest, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelOnscreenKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radToggleSwitchEnableKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radButtonSubmit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radLabelTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radTextBoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private tableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private radLabelRequest As Telerik.WinControls.UI.RadLabel
        Private radLabelOnscreenKeyboard As Telerik.WinControls.UI.RadLabel
        Private WithEvents radToggleSwitchEnableKeyboard As Telerik.WinControls.UI.RadToggleSwitch
        Private radVirtualKeyboard1 As Telerik.WinControls.UI.RadVirtualKeyboard
        Private radLabelDescription As Telerik.WinControls.UI.RadLabel
        Private radTextBoxDescription As Telerik.WinControls.UI.RadTextBox
        Private WithEvents radButtonSubmit As Telerik.WinControls.UI.RadButton
        Private radLabelTitle As Telerik.WinControls.UI.RadLabel
        Private radTextBoxTitle As Telerik.WinControls.UI.RadTextBox
    End Class
End Namespace
