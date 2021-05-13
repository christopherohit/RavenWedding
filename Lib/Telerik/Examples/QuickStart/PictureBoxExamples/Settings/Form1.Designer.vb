Namespace Telerik.Examples.WinControls.PictureBoxExamples.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radPictureBox1 = New Telerik.WinControls.UI.RadPictureBox()
            Me.radLabelImageLayout = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelImageAlignment = New Telerik.WinControls.UI.RadLabel()
            Me.radButtonChooseImage = New Telerik.WinControls.UI.RadButton()
            Me.radDropDownListImageLayout = New Telerik.WinControls.UI.RadDropDownList()
            Me.radDropDownListImageAlignment = New Telerik.WinControls.UI.RadDropDownList()
            Me.radCheckBoxShowBorder = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxShowBackground = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxEnableZoom = New Telerik.WinControls.UI.RadCheckBox()
            Me.radCheckBoxEnableContextMenu = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLabelMinZoomFactor = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorMinZoomFactor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabelMaxZoomFactor = New Telerik.WinControls.UI.RadLabel()
            Me.radSpinEditorMaxZoomFactor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radCheckBoxShowPanels = New Telerik.WinControls.UI.RadCheckBox()
            Me.radDropDownListPanelDisplayMode = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabelPanelDisplayMode = New Telerik.WinControls.UI.RadLabel()
            Me.radLabelPanelOverflowMode = New Telerik.WinControls.UI.RadLabel()
            Me.radDropDownListPanelOverflowMode = New Telerik.WinControls.UI.RadDropDownList()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radPictureBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelImageLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelImageAlignment), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radButtonChooseImage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownListImageLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownListImageAlignment), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxShowBorder), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxShowBackground), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxEnableZoom), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxEnableContextMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelMinZoomFactor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorMinZoomFactor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelMaxZoomFactor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radSpinEditorMaxZoomFactor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radCheckBoxShowPanels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownListPanelDisplayMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelPanelDisplayMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabelPanelOverflowMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radDropDownListPanelOverflowMode), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.radPictureBox1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(104, 72)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(506, 412)
            Me.settingsPanel.Location = New System.Drawing.Point(715, 120)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownListPanelOverflowMode)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelPanelOverflowMode)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelPanelDisplayMode)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownListPanelDisplayMode)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxShowPanels)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radSpinEditorMaxZoomFactor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelMaxZoomFactor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radSpinEditorMinZoomFactor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelMinZoomFactor)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxEnableContextMenu)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxEnableZoom)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxShowBackground)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radCheckBoxShowBorder)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownListImageAlignment)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radDropDownListImageLayout)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radButtonChooseImage)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelImageAlignment)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radLabelImageLayout)
            Me.optionsLabel.Location = New System.Drawing.Point(3, 573)
            Me.radPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.radPictureBox1.Name = "radPictureBox1"
            Me.radPictureBox1.ShowBorder = True
            Me.radPictureBox1.Size = New System.Drawing.Size(506, 412)
            Me.radPictureBox1.TabIndex = 0
            Me.radLabelImageLayout.Location = New System.Drawing.Point(3, 93)
            Me.radLabelImageLayout.Name = "radLabelImageLayout"
            Me.radLabelImageLayout.Size = New System.Drawing.Size(76, 18)
            Me.radLabelImageLayout.TabIndex = 3
            Me.radLabelImageLayout.Text = "Image Layout:"
            Me.radLabelImageAlignment.Location = New System.Drawing.Point(3, 147)
            Me.radLabelImageAlignment.Name = "radLabelImageAlignment"
            Me.radLabelImageAlignment.Size = New System.Drawing.Size(95, 18)
            Me.radLabelImageAlignment.TabIndex = 4
            Me.radLabelImageAlignment.Text = "Image Alignment:"
            Me.radButtonChooseImage.Location = New System.Drawing.Point(3, 3)
            Me.radButtonChooseImage.Name = "radButtonChooseImage"
            Me.radButtonChooseImage.Size = New System.Drawing.Size(194, 24)
            Me.radButtonChooseImage.TabIndex = 5
            Me.radButtonChooseImage.Text = "Select image"
            AddHandler Me.radButtonChooseImage.Click, AddressOf Me.RadButtonChooseImage_Click
            Me.radDropDownListImageLayout.DropDownAnimationEnabled = False
            Me.radDropDownListImageLayout.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListImageLayout.Location = New System.Drawing.Point(3, 117)
            Me.radDropDownListImageLayout.Name = "radDropDownListImageLayout"
            Me.radDropDownListImageLayout.Size = New System.Drawing.Size(194, 20)
            Me.radDropDownListImageLayout.TabIndex = 6
            Me.radDropDownListImageLayout.Text = "radDropDownList1"
            AddHandler Me.radDropDownListImageLayout.SelectedIndexChanged, AddressOf Me.RadDropDownListImageLayout_SelectedIndexChanged
            Me.radDropDownListImageAlignment.DropDownAnimationEnabled = False
            Me.radDropDownListImageAlignment.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListImageAlignment.Location = New System.Drawing.Point(3, 171)
            Me.radDropDownListImageAlignment.Name = "radDropDownListImageAlignment"
            Me.radDropDownListImageAlignment.Size = New System.Drawing.Size(194, 20)
            Me.radDropDownListImageAlignment.TabIndex = 7
            Me.radDropDownListImageAlignment.Text = "radDropDownList2"
            AddHandler Me.radDropDownListImageAlignment.SelectedIndexChanged, AddressOf Me.RadDropDownListImageAlignment_SelectedIndexChanged
            Me.radCheckBoxShowBorder.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowBorder.Location = New System.Drawing.Point(3, 37)
            Me.radCheckBoxShowBorder.Name = "radCheckBoxShowBorder"
            Me.radCheckBoxShowBorder.Size = New System.Drawing.Size(84, 18)
            Me.radCheckBoxShowBorder.TabIndex = 8
            Me.radCheckBoxShowBorder.Text = "Show Border"
            Me.radCheckBoxShowBorder.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxShowBorder.ToggleStateChanged, AddressOf Me.RadCheckBoxShowBorder_ToggleStateChanged
            Me.radCheckBoxShowBackground.Location = New System.Drawing.Point(3, 65)
            Me.radCheckBoxShowBackground.Name = "radCheckBoxShowBackground"
            Me.radCheckBoxShowBackground.Size = New System.Drawing.Size(110, 18)
            Me.radCheckBoxShowBackground.TabIndex = 9
            Me.radCheckBoxShowBackground.Text = "Show Background"
            AddHandler Me.radCheckBoxShowBackground.ToggleStateChanged, AddressOf Me.RadCheckBoxShowBackground_ToggleStateChanged
            Me.radCheckBoxEnableZoom.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxEnableZoom.Location = New System.Drawing.Point(3, 229)
            Me.radCheckBoxEnableZoom.Name = "radCheckBoxEnableZoom"
            Me.radCheckBoxEnableZoom.Size = New System.Drawing.Size(86, 18)
            Me.radCheckBoxEnableZoom.TabIndex = 10
            Me.radCheckBoxEnableZoom.Text = "Enable Zoom"
            Me.radCheckBoxEnableZoom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxEnableZoom.ToggleStateChanged, AddressOf Me.RadCheckBoxEnableZoom_ToggleStateChanged
            Me.radCheckBoxEnableContextMenu.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxEnableContextMenu.Location = New System.Drawing.Point(3, 201)
            Me.radCheckBoxEnableContextMenu.Name = "radCheckBoxEnableContextMenu"
            Me.radCheckBoxEnableContextMenu.Size = New System.Drawing.Size(127, 18)
            Me.radCheckBoxEnableContextMenu.TabIndex = 11
            Me.radCheckBoxEnableContextMenu.Text = "Enable Context Menu"
            Me.radCheckBoxEnableContextMenu.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxEnableContextMenu.ToggleStateChanged, AddressOf Me.RadCheckBoxEnableContextMenu_ToggleStateChanged
            Me.radLabelMinZoomFactor.Location = New System.Drawing.Point(3, 257)
            Me.radLabelMinZoomFactor.Name = "radLabelMinZoomFactor"
            Me.radLabelMinZoomFactor.Size = New System.Drawing.Size(95, 18)
            Me.radLabelMinZoomFactor.TabIndex = 12
            Me.radLabelMinZoomFactor.Text = "Min Zoom Factor:"
            Me.radSpinEditorMinZoomFactor.DecimalPlaces = 2
            Me.radSpinEditorMinZoomFactor.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.radSpinEditorMinZoomFactor.Location = New System.Drawing.Point(3, 281)
            Me.radSpinEditorMinZoomFactor.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.radSpinEditorMinZoomFactor.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
            Me.radSpinEditorMinZoomFactor.Name = "radSpinEditorMinZoomFactor"
            Me.radSpinEditorMinZoomFactor.NullableValue = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.radSpinEditorMinZoomFactor.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorMinZoomFactor.TabIndex = 13
            Me.radSpinEditorMinZoomFactor.Value = New Decimal(New Integer() {1, 0, 0, 65536})
            AddHandler Me.radSpinEditorMinZoomFactor.ValueChanged, AddressOf Me.RadSpinEditorMinZoomFactor_ValueChanged
            Me.radLabelMaxZoomFactor.Location = New System.Drawing.Point(3, 311)
            Me.radLabelMaxZoomFactor.Name = "radLabelMaxZoomFactor"
            Me.radLabelMaxZoomFactor.Size = New System.Drawing.Size(96, 18)
            Me.radLabelMaxZoomFactor.TabIndex = 15
            Me.radLabelMaxZoomFactor.Text = "Max Zoom Factor:"
            Me.radSpinEditorMaxZoomFactor.DecimalPlaces = 2
            Me.radSpinEditorMaxZoomFactor.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.radSpinEditorMaxZoomFactor.Location = New System.Drawing.Point(3, 335)
            Me.radSpinEditorMaxZoomFactor.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.radSpinEditorMaxZoomFactor.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.radSpinEditorMaxZoomFactor.Name = "radSpinEditorMaxZoomFactor"
            Me.radSpinEditorMaxZoomFactor.NullableValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.radSpinEditorMaxZoomFactor.Size = New System.Drawing.Size(194, 20)
            Me.radSpinEditorMaxZoomFactor.TabIndex = 14
            Me.radSpinEditorMaxZoomFactor.Value = New Decimal(New Integer() {10, 0, 0, 0})
            AddHandler Me.radSpinEditorMaxZoomFactor.ValueChanged, AddressOf Me.RadSpinEditorMaxZoomFactor_ValueChanged
            Me.radCheckBoxShowPanels.CheckState = System.Windows.Forms.CheckState.Checked
            Me.radCheckBoxShowPanels.Location = New System.Drawing.Point(3, 365)
            Me.radCheckBoxShowPanels.Name = "radCheckBoxShowPanels"
            Me.radCheckBoxShowPanels.Size = New System.Drawing.Size(83, 18)
            Me.radCheckBoxShowPanels.TabIndex = 16
            Me.radCheckBoxShowPanels.Text = "Show Panels"
            Me.radCheckBoxShowPanels.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            AddHandler Me.radCheckBoxShowPanels.ToggleStateChanged, AddressOf Me.RadCheckBoxShowPanels_ToggleStateChanged
            Me.radDropDownListPanelDisplayMode.DropDownAnimationEnabled = False
            Me.radDropDownListPanelDisplayMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListPanelDisplayMode.Location = New System.Drawing.Point(3, 415)
            Me.radDropDownListPanelDisplayMode.Name = "radDropDownListPanelDisplayMode"
            Me.radDropDownListPanelDisplayMode.Size = New System.Drawing.Size(194, 20)
            Me.radDropDownListPanelDisplayMode.TabIndex = 17
            Me.radDropDownListPanelDisplayMode.Text = "radDropDownList1"
            AddHandler Me.radDropDownListPanelDisplayMode.SelectedIndexChanged, AddressOf Me.RadDropDownListPanelDisplayMode_SelectedIndexChanged
            Me.radLabelPanelDisplayMode.Location = New System.Drawing.Point(3, 391)
            Me.radLabelPanelDisplayMode.Name = "radLabelPanelDisplayMode"
            Me.radLabelPanelDisplayMode.Size = New System.Drawing.Size(110, 18)
            Me.radLabelPanelDisplayMode.TabIndex = 18
            Me.radLabelPanelDisplayMode.Text = "Panels Display Mode"
            Me.radLabelPanelOverflowMode.Location = New System.Drawing.Point(3, 445)
            Me.radLabelPanelOverflowMode.Name = "radLabelPanelOverflowMode"
            Me.radLabelPanelOverflowMode.Size = New System.Drawing.Size(119, 18)
            Me.radLabelPanelOverflowMode.TabIndex = 19
            Me.radLabelPanelOverflowMode.Text = "Panels Overflow Mode"
            Me.radDropDownListPanelOverflowMode.DropDownAnimationEnabled = False
            Me.radDropDownListPanelOverflowMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.radDropDownListPanelOverflowMode.Location = New System.Drawing.Point(3, 469)
            Me.radDropDownListPanelOverflowMode.Name = "radDropDownListPanelOverflowMode"
            Me.radDropDownListPanelOverflowMode.Size = New System.Drawing.Size(194, 20)
            Me.radDropDownListPanelOverflowMode.TabIndex = 20
            Me.radDropDownListPanelOverflowMode.Text = "radDropDownList1"
            AddHandler Me.radDropDownListPanelOverflowMode.SelectedIndexChanged, AddressOf Me.RadDropDownListPanelOverflowMode_SelectedIndexChanged
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1044, 788)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radPictureBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelImageLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelImageAlignment), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radButtonChooseImage), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownListImageLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownListImageAlignment), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxShowBorder), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxShowBackground), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxEnableZoom), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxEnableContextMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelMinZoomFactor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorMinZoomFactor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelMaxZoomFactor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radSpinEditorMaxZoomFactor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radCheckBoxShowPanels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownListPanelDisplayMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelPanelDisplayMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabelPanelOverflowMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radDropDownListPanelOverflowMode), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radPictureBox1 As Telerik.WinControls.UI.RadPictureBox
        Private radDropDownListImageAlignment As Telerik.WinControls.UI.RadDropDownList
        Private radDropDownListImageLayout As Telerik.WinControls.UI.RadDropDownList
        Private radButtonChooseImage As Telerik.WinControls.UI.RadButton
        Private radLabelImageAlignment As Telerik.WinControls.UI.RadLabel
        Private radLabelImageLayout As Telerik.WinControls.UI.RadLabel
        Private radCheckBoxShowBackground As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxShowBorder As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxEnableContextMenu As Telerik.WinControls.UI.RadCheckBox
        Private radCheckBoxEnableZoom As Telerik.WinControls.UI.RadCheckBox
        Private radLabelMaxZoomFactor As Telerik.WinControls.UI.RadLabel
        Private radSpinEditorMinZoomFactor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabelMinZoomFactor As Telerik.WinControls.UI.RadLabel
        Private radSpinEditorMaxZoomFactor As Telerik.WinControls.UI.RadSpinEditor
        Private radCheckBoxShowPanels As Telerik.WinControls.UI.RadCheckBox
        Private radLabelPanelDisplayMode As Telerik.WinControls.UI.RadLabel
        Private radDropDownListPanelDisplayMode As Telerik.WinControls.UI.RadDropDownList
        Private radDropDownListPanelOverflowMode As Telerik.WinControls.UI.RadDropDownList
        Private radLabelPanelOverflowMode As Telerik.WinControls.UI.RadLabel
    End Class
End Namespace
