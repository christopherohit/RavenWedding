Namespace Telerik.Examples.WinControls.WebCam.Settings
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.radWebCam1 = New Telerik.WinControls.UI.RadWebCam()
            Me.startCameraButton = New Telerik.WinControls.UI.RadButton()
            Me.stopCameraButton = New Telerik.WinControls.UI.RadButton()
            Me.recordPathLabel = New Telerik.WinControls.UI.RadLabel()
            Me.filePathTextBox = New Telerik.WinControls.UI.RadTextBox()
            Me.isRecordingCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.previewSnapshotsCheckBox = New Telerik.WinControls.UI.RadCheckBox()
            Me.cameraLabel = New Telerik.WinControls.UI.RadLabel()
            Me.cameraDevicesDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.videoFormatsDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.videoFormatLabel = New Telerik.WinControls.UI.RadLabel()
            Me.recordingDevicesDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.microphoneLabel = New Telerik.WinControls.UI.RadLabel()
            Me.videoRecordingElapsedTimeFormatDropDownList = New Telerik.WinControls.UI.RadDropDownList()
            Me.videoElapsedTimeFormatStringLabel = New Telerik.WinControls.UI.RadLabel()
            Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
            CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType(Me.optionsLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radWebCam1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.startCameraButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.stopCameraButton, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recordPathLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.filePathTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.isRecordingCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.previewSnapshotsCheckBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cameraLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cameraDevicesDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.videoFormatsDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.videoFormatLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recordingDevicesDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.microphoneLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.videoRecordingElapsedTimeFormatDropDownList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.videoElapsedTimeFormatStringLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radPanelDemoHolder
            '
            Me.radPanelDemoHolder.Controls.Add(Me.radWebCam1)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(56, 33)
            '
            '
            '
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(800, 600)
            '
            'settingsPanel
            '
            Me.settingsPanel.Location = New System.Drawing.Point(1059, 33)
            '
            'settingsPanel.PanelContainer
            '
            Me.settingsPanel.PanelContainer.Controls.Add(Me.videoRecordingElapsedTimeFormatDropDownList)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.videoElapsedTimeFormatStringLabel)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.recordingDevicesDropDownList)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.microphoneLabel)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.videoFormatsDropDownList)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.videoFormatLabel)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.cameraDevicesDropDownList)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.cameraLabel)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.previewSnapshotsCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.isRecordingCheckBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.filePathTextBox)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.recordPathLabel)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.stopCameraButton)
            Me.settingsPanel.PanelContainer.Controls.Add(Me.startCameraButton)
            Me.settingsPanel.PanelContainer.Size = New System.Drawing.Size(200, 446)
            Me.settingsPanel.Size = New System.Drawing.Size(200, 463)
            '
            'optionsLabel
            '
            Me.optionsLabel.Location = New System.Drawing.Point(9, 406)
            '
            'radWebCam1
            '
            Me.radWebCam1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radWebCam1.Location = New System.Drawing.Point(0, 0)
            Me.radWebCam1.Name = "radWebCam1"
            Me.radWebCam1.Size = New System.Drawing.Size(800, 600)
            Me.radWebCam1.TabIndex = 0
            Me.radWebCam1.Text = "radWebCam1"
            '
            'startCameraButton
            '
            Me.startCameraButton.Enabled = False
            Me.startCameraButton.Location = New System.Drawing.Point(3, 3)
            Me.startCameraButton.Name = "startCameraButton"
            Me.startCameraButton.Size = New System.Drawing.Size(194, 24)
            Me.startCameraButton.TabIndex = 1
            Me.startCameraButton.Text = "Start Camera"
            '
            'stopCameraButton
            '
            Me.stopCameraButton.Location = New System.Drawing.Point(3, 37)
            Me.stopCameraButton.Name = "stopCameraButton"
            Me.stopCameraButton.Size = New System.Drawing.Size(194, 24)
            Me.stopCameraButton.TabIndex = 2
            Me.stopCameraButton.Text = "Stop Camera"
            '
            'recordPathLabel
            '
            Me.recordPathLabel.Location = New System.Drawing.Point(4, 68)
            Me.recordPathLabel.Name = "recordPathLabel"
            Me.recordPathLabel.Size = New System.Drawing.Size(105, 18)
            Me.recordPathLabel.TabIndex = 3
            Me.recordPathLabel.Text = "Recording File Path:"
            '
            'filePathTextBox
            '
            Me.filePathTextBox.Location = New System.Drawing.Point(3, 92)
            Me.filePathTextBox.Name = "filePathTextBox"
            Me.filePathTextBox.Size = New System.Drawing.Size(194, 20)
            Me.filePathTextBox.TabIndex = 4
            '
            'isRecordingCheckBox
            '
            Me.isRecordingCheckBox.Location = New System.Drawing.Point(4, 126)
            Me.isRecordingCheckBox.Name = "isRecordingCheckBox"
            Me.isRecordingCheckBox.Size = New System.Drawing.Size(82, 18)
            Me.isRecordingCheckBox.TabIndex = 5
            Me.isRecordingCheckBox.Text = "Is Recording"
            '
            'previewSnapshotsCheckBox
            '
            Me.previewSnapshotsCheckBox.Location = New System.Drawing.Point(4, 382)
            Me.previewSnapshotsCheckBox.Name = "previewSnapshotsCheckBox"
            Me.previewSnapshotsCheckBox.Size = New System.Drawing.Size(113, 18)
            Me.previewSnapshotsCheckBox.TabIndex = 6
            Me.previewSnapshotsCheckBox.Text = "Preview Snapshots"
            '
            'cameraLabel
            '
            Me.cameraLabel.Location = New System.Drawing.Point(3, 150)
            Me.cameraLabel.Name = "cameraLabel"
            Me.cameraLabel.Size = New System.Drawing.Size(47, 18)
            Me.cameraLabel.TabIndex = 7
            Me.cameraLabel.Text = "Camera:"
            '
            'cameraDevicesDropDownList
            '
            Me.cameraDevicesDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.cameraDevicesDropDownList.Location = New System.Drawing.Point(3, 174)
            Me.cameraDevicesDropDownList.Name = "cameraDevicesDropDownList"
            Me.cameraDevicesDropDownList.Size = New System.Drawing.Size(194, 20)
            Me.cameraDevicesDropDownList.TabIndex = 8
            Me.cameraDevicesDropDownList.Text = "No camera"
            '
            'videoFormatsDropDownList
            '
            Me.videoFormatsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.videoFormatsDropDownList.Location = New System.Drawing.Point(3, 232)
            Me.videoFormatsDropDownList.Name = "videoFormatsDropDownList"
            Me.videoFormatsDropDownList.Size = New System.Drawing.Size(194, 20)
            Me.videoFormatsDropDownList.TabIndex = 10
            Me.videoFormatsDropDownList.Text = "No camera"
            '
            'videoFormatLabel
            '
            Me.videoFormatLabel.Location = New System.Drawing.Point(3, 208)
            Me.videoFormatLabel.Name = "videoFormatLabel"
            Me.videoFormatLabel.Size = New System.Drawing.Size(76, 18)
            Me.videoFormatLabel.TabIndex = 9
            Me.videoFormatLabel.Text = "Video Format:"
            '
            'recordingDevicesDropDownList
            '
            Me.recordingDevicesDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.recordingDevicesDropDownList.Location = New System.Drawing.Point(3, 290)
            Me.recordingDevicesDropDownList.Name = "recordingDevicesDropDownList"
            Me.recordingDevicesDropDownList.Size = New System.Drawing.Size(194, 20)
            Me.recordingDevicesDropDownList.TabIndex = 13
            Me.recordingDevicesDropDownList.Text = "No camera"
            '
            'microphoneLabel
            '
            Me.microphoneLabel.Location = New System.Drawing.Point(3, 266)
            Me.microphoneLabel.Name = "microphoneLabel"
            Me.microphoneLabel.Size = New System.Drawing.Size(69, 18)
            Me.microphoneLabel.TabIndex = 12
            Me.microphoneLabel.Text = "Microphone:"
            '
            'videoRecordingElapsedTimeFormatDropDownList
            '
            Me.videoRecordingElapsedTimeFormatDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.videoRecordingElapsedTimeFormatDropDownList.Location = New System.Drawing.Point(4, 348)
            Me.videoRecordingElapsedTimeFormatDropDownList.Name = "videoRecordingElapsedTimeFormatDropDownList"
            Me.videoRecordingElapsedTimeFormatDropDownList.Size = New System.Drawing.Size(194, 20)
            Me.videoRecordingElapsedTimeFormatDropDownList.TabIndex = 15
            Me.videoRecordingElapsedTimeFormatDropDownList.Text = "No camera"
            '
            'videoElapsedTimeFormatStringLabel
            '
            Me.videoElapsedTimeFormatStringLabel.Location = New System.Drawing.Point(4, 324)
            Me.videoElapsedTimeFormatStringLabel.Name = "videoElapsedTimeFormatStringLabel"
            Me.videoElapsedTimeFormatStringLabel.Size = New System.Drawing.Size(199, 18)
            Me.videoElapsedTimeFormatStringLabel.TabIndex = 14
            Me.videoElapsedTimeFormatStringLabel.Text = "Video Recording Elapsed Time Format:"
            '
            'errorProvider1
            '
            Me.errorProvider1.ContainerControl = Me
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
            CType(Me.radWebCam1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.startCameraButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.stopCameraButton, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recordPathLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.filePathTextBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.isRecordingCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.previewSnapshotsCheckBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cameraLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cameraDevicesDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.videoFormatsDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.videoFormatLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recordingDevicesDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.microphoneLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.videoRecordingElapsedTimeFormatDropDownList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.videoElapsedTimeFormatStringLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private radWebCam1 As Telerik.WinControls.UI.RadWebCam
        Private WithEvents startCameraButton As Telerik.WinControls.UI.RadButton
        Private filePathTextBox As Telerik.WinControls.UI.RadTextBox
        Private recordPathLabel As Telerik.WinControls.UI.RadLabel
        Private WithEvents stopCameraButton As Telerik.WinControls.UI.RadButton
        Private recordingDevicesDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private microphoneLabel As Telerik.WinControls.UI.RadLabel
        Private videoFormatsDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private videoFormatLabel As Telerik.WinControls.UI.RadLabel
        Private cameraDevicesDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private cameraLabel As Telerik.WinControls.UI.RadLabel
        Private previewSnapshotsCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private isRecordingCheckBox As Telerik.WinControls.UI.RadCheckBox
        Private videoRecordingElapsedTimeFormatDropDownList As Telerik.WinControls.UI.RadDropDownList
        Private videoElapsedTimeFormatStringLabel As Telerik.WinControls.UI.RadLabel
        Private errorProvider1 As System.Windows.Forms.ErrorProvider
    End Class
End Namespace
