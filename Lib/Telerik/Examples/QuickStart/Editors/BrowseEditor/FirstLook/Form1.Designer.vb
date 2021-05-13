Namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.filesHolderPanel = New Telerik.WinControls.UI.RadPanel()
            Me.uploadFilesBtn = New Telerik.WinControls.UI.RadButton()
            Me.addNewBtn = New Telerik.WinControls.UI.RadButton()
            Me.filePathUserControl3 = New Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook.FilePathUserControl()
            Me.filePathUserControl2 = New Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook.FilePathUserControl()
            Me.filePathUserControl1 = New Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook.FilePathUserControl()
            Me.headerLabel = New Telerik.WinControls.UI.RadLabel()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filesHolderPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.filesHolderPanel.SuspendLayout()
            CType((Me.uploadFilesBtn), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.addNewBtn), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.headerLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.filesHolderPanel)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(1634, 1126)
            Me.filesHolderPanel.Controls.Add(Me.uploadFilesBtn)
            Me.filesHolderPanel.Controls.Add(Me.addNewBtn)
            Me.filesHolderPanel.Controls.Add(Me.filePathUserControl3)
            Me.filesHolderPanel.Controls.Add(Me.filePathUserControl2)
            Me.filesHolderPanel.Controls.Add(Me.filePathUserControl1)
            Me.filesHolderPanel.Controls.Add(Me.headerLabel)
            Me.filesHolderPanel.Location = New System.Drawing.Point(101, 202)
            Me.filesHolderPanel.Name = "filesHolderPanel"
            Me.filesHolderPanel.Padding = New System.Windows.Forms.Padding(5)
            Me.filesHolderPanel.Size = New System.Drawing.Size(500, 520)
            Me.filesHolderPanel.TabIndex = 0
            Me.uploadFilesBtn.Enabled = False
            Me.uploadFilesBtn.Location = New System.Drawing.Point(343, 468)
            Me.uploadFilesBtn.Name = "uploadFilesBtn"
            Me.uploadFilesBtn.Size = New System.Drawing.Size(88, 28)
            Me.uploadFilesBtn.TabIndex = 7
            Me.uploadFilesBtn.Text = "Upload files"
            AddHandler Me.uploadFilesBtn.Click, AddressOf Me.UploadFilesBtn_Click
            Me.addNewBtn.Location = New System.Drawing.Point(245, 468)
            Me.addNewBtn.Name = "addNewBtn"
            Me.addNewBtn.Size = New System.Drawing.Size(88, 28)
            Me.addNewBtn.TabIndex = 6
            Me.addNewBtn.Tag = ""
            Me.addNewBtn.Text = "Add more"
            AddHandler Me.addNewBtn.Click, AddressOf Me.AddNewBtn_Click
            Me.filePathUserControl3.Dock = System.Windows.Forms.DockStyle.Top
            Me.filePathUserControl3.Location = New System.Drawing.Point(5, 167)
            Me.filePathUserControl3.Name = "filePathUserControl3"
            Me.filePathUserControl3.Size = New System.Drawing.Size(490, 56)
            Me.filePathUserControl3.TabIndex = 9
            Me.filePathUserControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.filePathUserControl2.Location = New System.Drawing.Point(5, 111)
            Me.filePathUserControl2.Name = "filePathUserControl2"
            Me.filePathUserControl2.Size = New System.Drawing.Size(490, 56)
            Me.filePathUserControl2.TabIndex = 8
            Me.filePathUserControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.filePathUserControl1.Location = New System.Drawing.Point(5, 55)
            Me.filePathUserControl1.Name = "filePathUserControl1"
            Me.filePathUserControl1.Size = New System.Drawing.Size(490, 56)
            Me.filePathUserControl1.TabIndex = 4
            Me.headerLabel.AutoSize = False
            Me.headerLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.headerLabel.Font = New System.Drawing.Font("Segoe UI", 16.0F)
            Me.headerLabel.Location = New System.Drawing.Point(5, 5)
            Me.headerLabel.Name = "headerLabel"
            Me.headerLabel.Size = New System.Drawing.Size(490, 50)
            Me.headerLabel.TabIndex = 0
            Me.headerLabel.Text = "Select Files to Upload"
            Me.headerLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1634, 1126)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filesHolderPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.filesHolderPanel.ResumeLayout(False)
            CType((Me.uploadFilesBtn), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.addNewBtn), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.headerLabel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private filesHolderPanel As Telerik.WinControls.UI.RadPanel
        Private headerLabel As Telerik.WinControls.UI.RadLabel
        Private uploadFilesBtn As Telerik.WinControls.UI.RadButton
        Private addNewBtn As Telerik.WinControls.UI.RadButton
        Private filePathUserControl1 As FilePathUserControl
        Private filePathUserControl2 As FilePathUserControl
        Private filePathUserControl3 As FilePathUserControl
    End Class
End Namespace
