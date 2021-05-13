Namespace Telerik.Examples.WinControls.WebCam.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.doubleBufferedTableLayoutPanel1 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.emailLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.cancelButton = New Telerik.WinControls.UI.RadButton()
            Me.saveButton = New Telerik.WinControls.UI.RadButton()
            Me.userNameLabel = New Telerik.WinControls.UI.RadLabel()
            Me.userNameTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.emailTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.editUserNameButton = New Telerik.WinControls.UI.RadButton()
            Me.editEmailButton = New Telerik.WinControls.UI.RadButton()
            Me.radWebCam1 = New Telerik.WinControls.UI.RadWebCam()
            Me.panel1 = New Telerik.WinControls.UI.RadPanel()
            Me.takePhotoLabel = New Telerik.WinControls.UI.RadLabel()
            Me.deletePhotoButton = New Telerik.WinControls.UI.RadButton()
            Me.circleShape1 = New Telerik.WinControls.CircleShape()
            Me.takePhotoButton = New Telerik.WinControls.UI.RadButton()
            Me.userProfileLabel = New Telerik.WinControls.UI.RadLabel()
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doubleBufferedTableLayoutPanel1.SuspendLayout()
            CType(Me.emailLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.userNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.userNameTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emailTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editUserNameButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editEmailButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radWebCam1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.takePhotoLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.deletePhotoButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.takePhotoButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.userProfileLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.panel1)
            Me.radPanelDemoHolder.Controls.Add(Me.userProfileLabel)
            Me.radPanelDemoHolder.Controls.Add(Me.doubleBufferedTableLayoutPanel1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(24, 33)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(636, 340)
            '
            'settingsPanel
            '
            '
            'doubleBufferedTableLayoutPanel1
            '
            Me.doubleBufferedTableLayoutPanel1.ColumnCount = 2
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.15033!))
            Me.doubleBufferedTableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.84967!))
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.emailLabel2, 0, 3)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.cancelButton, 0, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.saveButton, 1, 5)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.userNameLabel, 0, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.userNameTextBox, 0, 2)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.emailTextBox, 0, 4)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.editUserNameButton, 1, 1)
            Me.doubleBufferedTableLayoutPanel1.Controls.Add(Me.editEmailButton, 1, 3)
            Me.doubleBufferedTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.doubleBufferedTableLayoutPanel1.Location = New System.Drawing.Point(330, 0)
            Me.doubleBufferedTableLayoutPanel1.Name = "doubleBufferedTableLayoutPanel1"
            Me.doubleBufferedTableLayoutPanel1.RowCount = 7
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
            Me.doubleBufferedTableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.doubleBufferedTableLayoutPanel1.Size = New System.Drawing.Size(306, 340)
            Me.doubleBufferedTableLayoutPanel1.TabIndex = 2
            '
            'emailLabel2
            '
            Me.emailLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.emailLabel2.Location = New System.Drawing.Point(0, 156)
            Me.emailLabel2.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.emailLabel2.Name = "emailLabel2"
            Me.emailLabel2.Size = New System.Drawing.Size(35, 18)
            Me.emailLabel2.TabIndex = 4
            Me.emailLabel2.Text = "Email:"
            '
            'cancelButton
            '
            Me.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.cancelButton.Enabled = False
            Me.cancelButton.Location = New System.Drawing.Point(58, 225)
            Me.cancelButton.Name = "cancelButton"
            Me.cancelButton.Size = New System.Drawing.Size(120, 28)
            Me.cancelButton.TabIndex = 7
            Me.cancelButton.Text = "Cancel"
            CType(Me.cancelButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Cancel"
            CType(Me.cancelButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(0)
            '
            'saveButton
            '
            Me.saveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.saveButton.Enabled = False
            Me.saveButton.Location = New System.Drawing.Point(184, 225)
            Me.saveButton.Name = "saveButton"
            Me.saveButton.Size = New System.Drawing.Size(119, 28)
            Me.saveButton.TabIndex = 8
            Me.saveButton.Text = "Save Changes"
            CType(Me.saveButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Save Changes"
            CType(Me.saveButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(0)
            '
            'userNameLabel
            '
            Me.userNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.userNameLabel.Location = New System.Drawing.Point(0, 76)
            Me.userNameLabel.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
            Me.userNameLabel.Name = "userNameLabel"
            Me.userNameLabel.Size = New System.Drawing.Size(64, 18)
            Me.userNameLabel.TabIndex = 3
            Me.userNameLabel.Text = "User Name:"
            '
            'userNameTextBox
            '
            Me.userNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.userNameTextBox, 2)
            Me.userNameTextBox.Enabled = False
            Me.userNameTextBox.Location = New System.Drawing.Point(3, 107)
            Me.userNameTextBox.Name = "userNameTextBox"
            Me.userNameTextBox.Size = New System.Drawing.Size(300, 20)
            Me.userNameTextBox.TabIndex = 9
            Me.userNameTextBox.Text = "Tori"
            '
            'emailTextBox
            '
            Me.emailTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.doubleBufferedTableLayoutPanel1.SetColumnSpan(Me.emailTextBox, 2)
            Me.emailTextBox.Enabled = False
            Me.emailTextBox.Location = New System.Drawing.Point(3, 187)
            Me.emailTextBox.Name = "emailTextBox"
            Me.emailTextBox.Size = New System.Drawing.Size(300, 20)
            Me.emailTextBox.TabIndex = 10
            Me.emailTextBox.Text = "tori@example.com"
            '
            'editUserNameButton
            '
            Me.editUserNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.editUserNameButton.Location = New System.Drawing.Point(278, 70)
            Me.editUserNameButton.Name = "editUserNameButton"
            Me.editUserNameButton.Size = New System.Drawing.Size(25, 24)
            Me.editUserNameButton.TabIndex = 11
            Me.editUserNameButton.Text = "/"
            CType(Me.editUserNameButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "/"
            CType(Me.editUserNameButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(0)
            '
            'editEmailButton
            '
            Me.editEmailButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.editEmailButton.Location = New System.Drawing.Point(278, 150)
            Me.editEmailButton.Name = "editEmailButton"
            Me.editEmailButton.Size = New System.Drawing.Size(25, 24)
            Me.editEmailButton.TabIndex = 12
            Me.editEmailButton.Text = "/"
            CType(Me.editEmailButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "/"
            CType(Me.editEmailButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(0)
            '
            'radWebCam1
            '
            Me.radWebCam1.AutoStart = False
            Me.radWebCam1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radWebCam1.Location = New System.Drawing.Point(30, 20)
            Me.radWebCam1.Name = "radWebCam1"
            Me.radWebCam1.Size = New System.Drawing.Size(270, 250)
            Me.radWebCam1.TabIndex = 0
            CType(Me.radWebCam1.GetChildAt(0), Telerik.WinControls.UI.LightVisualElement).DrawFill = True
            CType(Me.radWebCam1.GetChildAt(0), Telerik.WinControls.UI.LightVisualElement).GradientStyle = Telerik.WinControls.GradientStyles.Solid
            CType(Me.radWebCam1.GetChildAt(0), Telerik.WinControls.UI.LightVisualElement).BackColor = System.Drawing.Color.Black
            '
            'panel1
            '
            Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.panel1.Controls.Add(Me.takePhotoLabel)
            Me.panel1.Controls.Add(Me.deletePhotoButton)
            Me.panel1.Controls.Add(Me.takePhotoButton)
            Me.panel1.Controls.Add(Me.radWebCam1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 50)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(30, 20, 30, 20)
            '
            '
            '
            Me.panel1.RootElement.EnableElementShadow = False
            Me.panel1.Size = New System.Drawing.Size(330, 290)
            Me.panel1.TabIndex = 1
            CType(Me.panel1.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(30, 20, 30, 20)
            CType(Me.panel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.panel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            '
            'takePhotoLabel
            '
            Me.takePhotoLabel.AutoSize = False
            Me.takePhotoLabel.Font = New System.Drawing.Font("Segoe UI", 13.5!)
            Me.takePhotoLabel.ForeColor = System.Drawing.Color.White
            Me.takePhotoLabel.Location = New System.Drawing.Point(4, 163)
            Me.takePhotoLabel.Name = "takePhotoLabel"
            Me.takePhotoLabel.Size = New System.Drawing.Size(320, 36)
            Me.takePhotoLabel.TabIndex = 3
            Me.takePhotoLabel.Text = "Take Photo"
            Me.takePhotoLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            '
            'deletePhotoButton
            '
            Me.deletePhotoButton.Enabled = False
            Me.deletePhotoButton.Location = New System.Drawing.Point(188, 112)
            Me.deletePhotoButton.Name = "deletePhotoButton"
            Me.deletePhotoButton.Size = New System.Drawing.Size(26, 26)
            Me.deletePhotoButton.TabIndex = 2
            Me.deletePhotoButton.Text = "D"
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "D"
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableElementShadow = False
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableFocusBorder = False
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableFocusBorderAnimation = True
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableHighlight = False
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableBorderHighlight = False
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ToolTipText = "Take Photo"
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
            CType(Me.deletePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Shape = Me.circleShape1
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Opacity = 0.7R
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).CustomFont = "TelerikWebUI"
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).CustomFontSize = 12.0!
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.deletePhotoButton.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            '
            'circleShape1
            '
            Me.circleShape1.IsRightToLeft = False
            '
            'takePhotoButton
            '
            Me.takePhotoButton.Location = New System.Drawing.Point(114, 93)
            Me.takePhotoButton.Name = "takePhotoButton"
            Me.takePhotoButton.Size = New System.Drawing.Size(64, 64)
            Me.takePhotoButton.TabIndex = 1
            Me.takePhotoButton.Text = "P"
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "P"
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableElementShadow = False
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableFocusBorder = False
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableFocusBorderAnimation = False
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableHighlight = False
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).EnableBorderHighlight = False
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ToolTipText = "Take Photo"
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
            CType(Me.takePhotoButton.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Shape = Me.circleShape1
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Opacity = 0.7R
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).CustomFont = "TelerikWebUI"
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).CustomFontSize = 24.0!
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.takePhotoButton.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            '
            'userProfileLabel
            '
            Me.userProfileLabel.AutoSize = False
            Me.userProfileLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.userProfileLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.userProfileLabel.Location = New System.Drawing.Point(0, 0)
            Me.userProfileLabel.Name = "userProfileLabel"
            Me.userProfileLabel.Size = New System.Drawing.Size(330, 50)
            Me.userProfileLabel.TabIndex = 4
            Me.userProfileLabel.Text = "USER PROFILE"
            Me.userProfileLabel.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2046, 1156)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doubleBufferedTableLayoutPanel1.ResumeLayout(False)
            Me.doubleBufferedTableLayoutPanel1.PerformLayout()
            CType(Me.emailLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cancelButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.saveButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.userNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.userNameTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emailTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editUserNameButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editEmailButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radWebCam1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.takePhotoLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.deletePhotoButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.takePhotoButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.userProfileLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private doubleBufferedTableLayoutPanel1 As Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel
        Private userNameLabel As Telerik.WinControls.UI.RadLabel
        Private emailLabel2 As Telerik.WinControls.UI.RadLabel
        Private WithEvents cancelButton As Telerik.WinControls.UI.RadButton
        Private WithEvents saveButton As Telerik.WinControls.UI.RadButton
        Private WithEvents radWebCam1 As Telerik.WinControls.UI.RadWebCam
        Private userNameTextBox As Telerik.WinControls.UI.RadTextBox
        Private emailTextBox As Telerik.WinControls.UI.RadTextBox
        Private WithEvents editUserNameButton As Telerik.WinControls.UI.RadButton
        Private WithEvents editEmailButton As Telerik.WinControls.UI.RadButton
        Private panel1 As Telerik.WinControls.UI.RadPanel
        Private userProfileLabel As Telerik.WinControls.UI.RadLabel
        Private WithEvents takePhotoButton As Telerik.WinControls.UI.RadButton
        Private takePhotoLabel As Telerik.WinControls.UI.RadLabel
        Private WithEvents deletePhotoButton As Telerik.WinControls.UI.RadButton
        Private circleShape1 As Telerik.WinControls.CircleShape
    End Class
End Namespace
