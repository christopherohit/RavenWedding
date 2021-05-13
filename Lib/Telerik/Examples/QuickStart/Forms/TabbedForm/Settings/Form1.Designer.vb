Namespace Telerik.Examples.WinControls.Forms.TabbedForm.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
            Me.showTextCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.showIconCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.dragModeDropDown = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.pinnedItemsDropDown = New Telerik.WinControls.UI.RadDropDownList()
            Me.radLabel10 = New Telerik.WinControls.UI.RadLabel()
            Me.showNewBtnCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.showPinBtnCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.showCloseBtnCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.minTabWidthSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.tabWidthSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.tabSpacingSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
            Me.tabHeightSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.captionHeightSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
            Me.allowAeroCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.radLblCaption = New Telerik.WinControls.UI.RadLabel()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radGroupSettings), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radGroupSettings.SuspendLayout()
            CType((Me.showTextCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showIconCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dragModeDropDown), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pinnedItemsDropDown), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showNewBtnCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showPinBtnCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.showCloseBtnCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.minTabWidthSpinEditor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabWidthSpinEditor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabSpacingSpinEditor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabHeightSpinEditor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.captionHeightSpinEditor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowAeroCheckBox), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radLblCaption), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.settingsPanel.Location = New System.Drawing.Point(940, 20)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.radGroupSettings)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 513)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 513)
            Me.radGroupSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radGroupSettings.Controls.Add(Me.showTextCheckBox)
            Me.radGroupSettings.Controls.Add(Me.showIconCheckBox)
            Me.radGroupSettings.Controls.Add(Me.dragModeDropDown)
            Me.radGroupSettings.Controls.Add(Me.radLabel5)
            Me.radGroupSettings.Controls.Add(Me.pinnedItemsDropDown)
            Me.radGroupSettings.Controls.Add(Me.radLabel10)
            Me.radGroupSettings.Controls.Add(Me.showNewBtnCheckBox)
            Me.radGroupSettings.Controls.Add(Me.showPinBtnCheckBox)
            Me.radGroupSettings.Controls.Add(Me.showCloseBtnCheckBox)
            Me.radGroupSettings.Controls.Add(Me.minTabWidthSpinEditor)
            Me.radGroupSettings.Controls.Add(Me.radLabel4)
            Me.radGroupSettings.Controls.Add(Me.tabWidthSpinEditor)
            Me.radGroupSettings.Controls.Add(Me.radLabel2)
            Me.radGroupSettings.Controls.Add(Me.tabSpacingSpinEditor)
            Me.radGroupSettings.Controls.Add(Me.radLabel3)
            Me.radGroupSettings.Controls.Add(Me.tabHeightSpinEditor)
            Me.radGroupSettings.Controls.Add(Me.radLabel1)
            Me.radGroupSettings.Controls.Add(Me.captionHeightSpinEditor)
            Me.radGroupSettings.Controls.Add(Me.allowAeroCheckBox)
            Me.radGroupSettings.Controls.Add(Me.radLblCaption)
            Me.radGroupSettings.FooterText = ""
            Me.radGroupSettings.HeaderText = "RadTabbedForm Settings "
            Me.radGroupSettings.Location = New System.Drawing.Point(19, 2)
            Me.radGroupSettings.Name = "radGroupSettings"
            Me.radGroupSettings.Size = New System.Drawing.Size(180, 510)
            Me.radGroupSettings.TabIndex = 1
            Me.radGroupSettings.Text = "RadTabbedForm Settings "
            Me.showTextCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.showTextCheckBox.BackColor = System.Drawing.Color.Transparent
            Me.showTextCheckBox.Location = New System.Drawing.Point(4, 462)
            Me.showTextCheckBox.Name = "showTextCheckBox"
            Me.showTextCheckBox.Size = New System.Drawing.Size(71, 18)
            Me.showTextCheckBox.TabIndex = 30
            Me.showTextCheckBox.Text = "Show Text"
            Me.showIconCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.showIconCheckBox.BackColor = System.Drawing.Color.Transparent
            Me.showIconCheckBox.Location = New System.Drawing.Point(5, 438)
            Me.showIconCheckBox.Name = "showIconCheckBox"
            Me.showIconCheckBox.Size = New System.Drawing.Size(72, 18)
            Me.showIconCheckBox.TabIndex = 29
            Me.showIconCheckBox.Text = "Show Icon"
            Me.dragModeDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.dragModeDropDown.Location = New System.Drawing.Point(5, 408)
            Me.dragModeDropDown.Name = "dragModeDropDown"
            Me.dragModeDropDown.Size = New System.Drawing.Size(168, 24)
            Me.dragModeDropDown.TabIndex = 28
            Me.dragModeDropDown.Text = "radDropDownList2"
            Me.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel5.Location = New System.Drawing.Point(5, 386)
            Me.radLabel5.Name = "radLabel5"
            Me.radLabel5.Size = New System.Drawing.Size(114, 18)
            Me.radLabel5.TabIndex = 27
            Me.radLabel5.Text = "Item Drag Mode"
            Me.pinnedItemsDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.pinnedItemsDropDown.Location = New System.Drawing.Point(5, 360)
            Me.pinnedItemsDropDown.Name = "pinnedItemsDropDown"
            Me.pinnedItemsDropDown.Size = New System.Drawing.Size(168, 24)
            Me.pinnedItemsDropDown.TabIndex = 26
            Me.pinnedItemsDropDown.Text = "radDropDownList2"
            Me.radLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel10.Location = New System.Drawing.Point(5, 338)
            Me.radLabel10.Name = "radLabel10"
            Me.radLabel10.Size = New System.Drawing.Size(114, 18)
            Me.radLabel10.TabIndex = 25
            Me.radLabel10.Text = "Pinned Items Position"
            Me.showNewBtnCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.showNewBtnCheckBox.Location = New System.Drawing.Point(5, 314)
            Me.showNewBtnCheckBox.Name = "showNewBtnCheckBox"
            Me.showNewBtnCheckBox.Size = New System.Drawing.Size(131, 18)
            Me.showNewBtnCheckBox.TabIndex = 24
            Me.showNewBtnCheckBox.Text = "Show Tab New Button"
            Me.showPinBtnCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.showPinBtnCheckBox.Location = New System.Drawing.Point(5, 290)
            Me.showPinBtnCheckBox.Name = "showPinBtnCheckBox"
            Me.showPinBtnCheckBox.Size = New System.Drawing.Size(124, 18)
            Me.showPinBtnCheckBox.TabIndex = 23
            Me.showPinBtnCheckBox.Text = "Show Tab Pin Button"
            Me.showCloseBtnCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.showCloseBtnCheckBox.Location = New System.Drawing.Point(5, 266)
            Me.showCloseBtnCheckBox.Name = "showCloseBtnCheckBox"
            Me.showCloseBtnCheckBox.Size = New System.Drawing.Size(136, 18)
            Me.showCloseBtnCheckBox.TabIndex = 22
            Me.showCloseBtnCheckBox.Text = "Show Tab Close Button"
            Me.minTabWidthSpinEditor.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.minTabWidthSpinEditor.Location = New System.Drawing.Point(5, 236)
            Me.minTabWidthSpinEditor.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.minTabWidthSpinEditor.Name = "minTabWidthSpinEditor"
            Me.minTabWidthSpinEditor.Size = New System.Drawing.Size(168, 24)
            Me.minTabWidthSpinEditor.TabIndex = 21
            Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel4.Location = New System.Drawing.Point(5, 214)
            Me.radLabel4.Name = "radLabel4"
            Me.radLabel4.Size = New System.Drawing.Size(109, 18)
            Me.radLabel4.TabIndex = 20
            Me.radLabel4.Text = "Minimum Tab Width"
            Me.tabWidthSpinEditor.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.tabWidthSpinEditor.Location = New System.Drawing.Point(5, 188)
            Me.tabWidthSpinEditor.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.tabWidthSpinEditor.Name = "tabWidthSpinEditor"
            Me.tabWidthSpinEditor.Size = New System.Drawing.Size(168, 24)
            Me.tabWidthSpinEditor.TabIndex = 19
            Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel2.Location = New System.Drawing.Point(5, 166)
            Me.radLabel2.Name = "radLabel2"
            Me.radLabel2.Size = New System.Drawing.Size(58, 18)
            Me.radLabel2.TabIndex = 18
            Me.radLabel2.Text = "Tab Width"
            Me.tabSpacingSpinEditor.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.tabSpacingSpinEditor.Location = New System.Drawing.Point(5, 140)
            Me.tabSpacingSpinEditor.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
            Me.tabSpacingSpinEditor.Minimum = New Decimal(New Integer() {150, 0, 0, -2147483648})
            Me.tabSpacingSpinEditor.Name = "tabSpacingSpinEditor"
            Me.tabSpacingSpinEditor.Size = New System.Drawing.Size(168, 24)
            Me.tabSpacingSpinEditor.TabIndex = 17
            Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel3.Location = New System.Drawing.Point(5, 118)
            Me.radLabel3.Name = "radLabel3"
            Me.radLabel3.Size = New System.Drawing.Size(67, 18)
            Me.radLabel3.TabIndex = 16
            Me.radLabel3.Text = "Tab Spacing"
            Me.tabHeightSpinEditor.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.tabHeightSpinEditor.Location = New System.Drawing.Point(5, 92)
            Me.tabHeightSpinEditor.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.tabHeightSpinEditor.Name = "tabHeightSpinEditor"
            Me.tabHeightSpinEditor.Size = New System.Drawing.Size(168, 24)
            Me.tabHeightSpinEditor.TabIndex = 15
            Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLabel1.Location = New System.Drawing.Point(5, 70)
            Me.radLabel1.Name = "radLabel1"
            Me.radLabel1.Size = New System.Drawing.Size(61, 18)
            Me.radLabel1.TabIndex = 14
            Me.radLabel1.Text = "Tab Height"
            Me.captionHeightSpinEditor.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.captionHeightSpinEditor.Location = New System.Drawing.Point(5, 44)
            Me.captionHeightSpinEditor.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.captionHeightSpinEditor.Name = "captionHeightSpinEditor"
            Me.captionHeightSpinEditor.Size = New System.Drawing.Size(168, 24)
            Me.captionHeightSpinEditor.TabIndex = 13
            Me.allowAeroCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.allowAeroCheckBox.BackColor = System.Drawing.Color.Transparent
            Me.allowAeroCheckBox.Location = New System.Drawing.Point(5, 486)
            Me.allowAeroCheckBox.Name = "allowAeroCheckBox"
            Me.allowAeroCheckBox.Size = New System.Drawing.Size(75, 18)
            Me.allowAeroCheckBox.TabIndex = 9
            Me.allowAeroCheckBox.Text = "Allow Aero"
            Me.radLblCaption.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.radLblCaption.Location = New System.Drawing.Point(5, 22)
            Me.radLblCaption.Name = "radLblCaption"
            Me.radLblCaption.Size = New System.Drawing.Size(82, 18)
            Me.radLblCaption.TabIndex = 0
            Me.radLblCaption.Text = "Caption Height"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1724, 1156)
            Me.Controls.SetChildIndex(Me.settingsPanel, 0)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radGroupSettings), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radGroupSettings.ResumeLayout(False)
            Me.radGroupSettings.PerformLayout()
            CType((Me.showTextCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showIconCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dragModeDropDown), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pinnedItemsDropDown), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showNewBtnCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showPinBtnCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.showCloseBtnCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.minTabWidthSpinEditor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabWidthSpinEditor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabSpacingSpinEditor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabHeightSpinEditor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.captionHeightSpinEditor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowAeroCheckBox), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radLblCaption), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
        Private allowAeroCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private radLblCaption As Telerik.WinControls.UI.RadLabel
        Private captionHeightSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private tabWidthSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel2 As Telerik.WinControls.UI.RadLabel
        Private tabSpacingSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel3 As Telerik.WinControls.UI.RadLabel
        Private tabHeightSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel1 As Telerik.WinControls.UI.RadLabel
        Private dragModeDropDown As Telerik.WinControls.UI.RadDropDownList
        Private radLabel5 As Telerik.WinControls.UI.RadLabel
        Private pinnedItemsDropDown As Telerik.WinControls.UI.RadDropDownList
        Private radLabel10 As Telerik.WinControls.UI.RadLabel
        Private showNewBtnCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private showPinBtnCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private showCloseBtnCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private minTabWidthSpinEditor As Telerik.WinControls.UI.RadSpinEditor
        Private radLabel4 As Telerik.WinControls.UI.RadLabel
        Private showTextCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private showIconCheckBox As Telerik.WinControls.UI.RadCheckBox
    End Class
End Namespace
