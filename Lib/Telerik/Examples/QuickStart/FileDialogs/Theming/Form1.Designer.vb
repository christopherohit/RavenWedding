Namespace Telerik.Examples.WinControls.FileDialogs.Theming
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.openFileDialogButton = New Telerik.WinControls.UI.RadButton()
            Me.openFolderDialogButton = New Telerik.WinControls.UI.RadButton()
            Me.saveFileDialogButton = New Telerik.WinControls.UI.RadButton()
            Me.radOpenFileDialog1 = New Telerik.WinControls.UI.RadOpenFileDialog()
            Me.radSaveFileDialog1 = New Telerik.WinControls.UI.RadSaveFileDialog()
            Me.radOpenFolderDialog1 = New Telerik.WinControls.UI.RadOpenFolderDialog()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.openFileDialogButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.openFolderDialogButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.saveFileDialogButton), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.saveFileDialogButton)
            Me.radPanelDemoHolder.Controls.Add(Me.openFolderDialogButton)
            Me.radPanelDemoHolder.Controls.Add(Me.openFileDialogButton)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(185, 165)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(419, 220)
            Me.openFileDialogButton.Location = New System.Drawing.Point(83, 46)
            Me.openFileDialogButton.Name = "openFileDialogButton"
            Me.openFileDialogButton.Size = New System.Drawing.Size(250, 28)
            Me.openFileDialogButton.TabIndex = 0
            Me.openFileDialogButton.Text = "Open RadOpenFileDialog"
            AddHandler Me.openFileDialogButton.Click, AddressOf Me.OpenFileDialogButton_Click
            Me.openFolderDialogButton.Location = New System.Drawing.Point(83, 90)
            Me.openFolderDialogButton.Name = "openFolderDialogButton"
            Me.openFolderDialogButton.Size = New System.Drawing.Size(250, 28)
            Me.openFolderDialogButton.TabIndex = 1
            Me.openFolderDialogButton.Text = "Open RadOpenFolderDialog"
            AddHandler Me.openFolderDialogButton.Click, AddressOf Me.OpenFolderDialogButton_Click
            Me.saveFileDialogButton.Location = New System.Drawing.Point(83, 135)
            Me.saveFileDialogButton.Name = "saveFileDialogButton"
            Me.saveFileDialogButton.Size = New System.Drawing.Size(250, 28)
            Me.saveFileDialogButton.TabIndex = 1
            Me.saveFileDialogButton.Text = "Open RadSaveFileDialog"
            AddHandler Me.saveFileDialogButton.Click, AddressOf Me.SaveFileDialogButton_Click
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(2142, 1156)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.openFileDialogButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.openFolderDialogButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.saveFileDialogButton), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private saveFileDialogButton As Telerik.WinControls.UI.RadButton
        Private openFolderDialogButton As Telerik.WinControls.UI.RadButton
        Private openFileDialogButton As Telerik.WinControls.UI.RadButton
        Private radOpenFileDialog1 As Telerik.WinControls.UI.RadOpenFileDialog
        Private radSaveFileDialog1 As Telerik.WinControls.UI.RadSaveFileDialog
        Private radOpenFolderDialog1 As Telerik.WinControls.UI.RadOpenFolderDialog
    End Class
End Namespace