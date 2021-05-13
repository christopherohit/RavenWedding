Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.IO
Imports MediaFoundation
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Windows.MediaFoundation

Namespace Telerik.Examples.WinControls.WebCam.Settings
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private Shared ReadOnly SupportedVideoInputTypes As List(Of Guid) = New List(Of Guid)() From {
            MFMediaType.I420,
            MFMediaType.IYUV,
            MFMediaType.NV12,
            MFMediaType.YUY2,
            MFMediaType.YV12
        }

        Private cameraValidatedRecordingPath As String = String.Empty

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            Me.InitializeSettings()
        End Sub

        Public ReadOnly Property Camera As RadWebCam
            Get
                Return Me.radWebCam1
            End Get
        End Property

        Protected Overrides Sub WireEvents()
            MyBase.WireEvents()
            AddHandler Me.radWebCam1.SnapshotTaken, New EventHandler(Of SnapshotTakenEventArgs)(AddressOf Me.RadWebCam1_SnapshotTaken)
            AddHandler Me.radWebCam1.RecordingStarted, AddressOf Me.RadWebCam1_RecordingStarted
            AddHandler Me.radWebCam1.RecordingEnded, AddressOf Me.RadWebCam1_RecordingEnded
            AddHandler Me.filePathTextBox.Validating, New CancelEventHandler(AddressOf Me.FilePathTextBox_Validating)
            AddHandler Me.isRecordingCheckBox.ToggleStateChanged, New StateChangedEventHandler(AddressOf Me.IsRecordingCheckBox_ToggleStateChanged)
            AddHandler Me.previewSnapshotsCheckBox.ToggleStateChanged, New StateChangedEventHandler(AddressOf Me.PreviewSnapshotsCheckBox_ToggleStateChanged)
            AddHandler Me.cameraDevicesDropDownList.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.CameraDevicesDropDownList_SelectedIndexChanged)
            AddHandler Me.videoFormatsDropDownList.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.VideoFormatsDropDownList_SelectedIndexChanged)
            AddHandler Me.recordingDevicesDropDownList.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.RecordingDevicesDropDownList_SelectedIndexChanged)
            AddHandler Me.videoRecordingElapsedTimeFormatDropDownList.SelectedIndexChanged, New Telerik.WinControls.UI.Data.PositionChangedEventHandler(AddressOf Me.VideoRecordingElapsedTimeFormatDropDownList_SelectedIndexChanged)
        End Sub

        Private Sub RadWebCam1_RecordingStarted(ByVal sender As Object, ByVal e As CancelEventArgs)
            Me.cameraValidatedRecordingPath = Me.radWebCam1.RecordingFilePath
            Me.radWebCam1.RecordingFilePath = Me.cameraValidatedRecordingPath.Substring(0, Me.cameraValidatedRecordingPath.Length - ".mp4".Length) + DateTime.Now.ToString("HH-mm-ss") & ".mp4"
        End Sub

        Private Sub RadWebCam1_RecordingEnded(ByVal sender As Object, ByVal e As EventArgs)
            Me.radWebCam1.RecordingFilePath = Me.cameraValidatedRecordingPath
            System.Diagnostics.Process.Start(Path.GetDirectoryName(Me.cameraValidatedRecordingPath))
        End Sub

        Private Sub InitializeSettings()
            Dim cameraDevices As ReadOnlyCollection(Of MediaFoundationDeviceInfo) = RadWebCam.GetVideoCaptureDevices()
            Me.cameraDevicesDropDownList.DataSource = cameraDevices

            If cameraDevices.Count > 0 Then
                Dim defaultCamera As MediaFoundationDeviceInfo = cameraDevices(0)
                Me.cameraDevicesDropDownList.SelectedValue = defaultCamera
                Me.UpdateVideoFormats(defaultCamera)
            End If

            Dim recordingDevices As ReadOnlyCollection(Of MediaFoundationDeviceInfo) = RadWebCam.GetAudioCaptureDevices()
            Me.recordingDevicesDropDownList.DataSource = recordingDevices

            If recordingDevices.Count > 0 Then
                Me.recordingDevicesDropDownList.SelectedValue = recordingDevices(0)
            End If

            Me.Camera.RecordingFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "video.mp4")
            Me.filePathTextBox.Text = Me.Camera.RecordingFilePath
            Dim elapsedTimeFormats As List(Of String) = New List(Of String)() From {
                "t",
                "mm\:ss\:ff",
                "mm\:ss"
            }
            Me.videoRecordingElapsedTimeFormatDropDownList.DataSource = elapsedTimeFormats
            Me.videoRecordingElapsedTimeFormatDropDownList.SelectedIndex = 1

            If cameraDevices.Count = 0 Then
                Me.settingsPanel.Enabled = False
                Return
            End If

            AddHandler Me.Camera.CameraError, AddressOf Me.OnCameraError
        End Sub

        Private Sub RestartCamera()
            Dim videoDevice As MediaFoundationDeviceInfo = CType(Me.cameraDevicesDropDownList.SelectedValue, MediaFoundationDeviceInfo)
            Dim videoFormat As MediaFoundationVideoFormatInfo = CType(Me.videoFormatsDropDownList.SelectedValue, MediaFoundationVideoFormatInfo)
            Dim recordingDevice As MediaFoundationDeviceInfo = CType(Me.recordingDevicesDropDownList.SelectedValue, MediaFoundationDeviceInfo)

            If videoDevice IsNot Nothing AndAlso videoFormat IsNot Nothing Then
                Me.Camera.Initialize(videoDevice, videoFormat, recordingDevice)

                If Me.stopCameraButton.Enabled Then
                    Me.Camera.Start()
                End If
            End If
        End Sub

        Private Sub UpdateVideoFormats(ByVal defaultCamera As MediaFoundationDeviceInfo)
            Try
                Dim videoFormats As IEnumerable(Of MediaFoundationVideoFormatInfo) = RadWebCam.GetVideoFormats(defaultCamera, True).OrderByDescending(Function(x) x.FrameSizeHeight).ThenByDescending(Function(x) x.EffectiveFrameRate)

                For Each formatInfo As MediaFoundationVideoFormatInfo In videoFormats
                    Dim item As RadListDataItem = New RadListDataItem(Me.GetVideoFormatString(formatInfo), formatInfo)
                    Me.videoFormatsDropDownList.Items.Add(item)
                Next

                Dim defaultFormat As MediaFoundationVideoFormatInfo = videoFormats.FirstOrDefault(Function(f) SupportedVideoInputTypes.Contains(f.SubType))
                Me.videoFormatsDropDownList.SelectedValue = defaultFormat
            Catch __unusedUnauthorizedAccessException1__ As UnauthorizedAccessException
                Me.Enabled = False
            End Try
        End Sub

        Public Function ValidateVideoName(ByVal filePath As String) As String
            Dim fileName As String = Path.GetFileName(filePath)
            Dim fileExtension As String = Path.GetExtension(fileName)

            If Not fileExtension.Equals(".mp4") Then
                Return "Invalid file extension - use .mp4"
            End If

            Dim directoryPath As String = filePath.Replace(fileName, String.Empty)

            If Not Directory.Exists(directoryPath) Then
                Return "File directory doesn't exist"
            End If

            Return String.Empty
        End Function

        Private Sub OnCameraError(ByVal sender As Object, ByVal e As CameraErrorEventArgs)
            Me.Enabled = False
        End Sub

        Private Sub StartCameraButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles startCameraButton.Click
            Me.stopCameraButton.Enabled = True
            Me.startCameraButton.Enabled = False
            Me.isRecordingCheckBox.Enabled = True
            Me.Camera.Start()
        End Sub

        Private Sub StopCameraButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles stopCameraButton.Click
            Me.stopCameraButton.Enabled = False
            Me.startCameraButton.Enabled = True
            Me.isRecordingCheckBox.Enabled = False
            Me.Camera.[Stop]()
        End Sub

        Private Sub IsRecordingCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.Camera.IsRecording = Me.isRecordingCheckBox.IsChecked
        End Sub

        Private Sub CameraDevicesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim selectedCamera As MediaFoundationDeviceInfo = CType(Me.cameraDevicesDropDownList.SelectedValue, MediaFoundationDeviceInfo)
            Me.UpdateVideoFormats(selectedCamera)
            Me.RestartCamera()
        End Sub

        Private Sub VideoFormatsDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If Me.videoFormatsDropDownList.SelectedItem IsNot Nothing Then
                Me.RestartCamera()
                Dim selectedFormat As MediaFoundationVideoFormatInfo = CType(Me.videoFormatsDropDownList.SelectedValue, MediaFoundationVideoFormatInfo)

                If Not SupportedVideoInputTypes.Contains(selectedFormat.SubType) Then
                    Me.Camera.WebCamElement.ToggleRecordingButton.Visibility = ElementVisibility.Collapsed
                Else

                    If Me.Camera.WebCamElement.ToggleRecordingButton.Visibility = ElementVisibility.Collapsed Then
                        Me.Camera.WebCamElement.ToggleRecordingButton.Visibility = ElementVisibility.Visible
                    End If
                End If
            End If
        End Sub

        Private Sub RecordingDevicesDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.RestartCamera()
        End Sub

        Private Sub VideoRecordingElapsedTimeFormatDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.Camera.VideoRecordingElapsedTimeFormat = CStr(Me.videoRecordingElapsedTimeFormatDropDownList.SelectedValue)
        End Sub

        Private Sub PreviewSnapshotsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.Camera.PreviewSnapshots = Me.previewSnapshotsCheckBox.IsChecked
        End Sub

        Private Sub FilePathTextBox_Validating(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim errorMessage As String = Me.ValidateVideoName(Me.filePathTextBox.Text)

            If String.IsNullOrEmpty(errorMessage) Then
                Me.errorProvider1.SetError(Me.filePathTextBox, Nothing)
                Me.filePathTextBox.MaximumSize = New System.Drawing.Size(0, 0)
                Me.Camera.RecordingFilePath = Me.filePathTextBox.Text
            Else
                e.Cancel = True
                Me.errorProvider1.SetError(Me.filePathTextBox, errorMessage)
                Me.filePathTextBox.MaximumSize = New System.Drawing.Size(Me.cameraDevicesDropDownList.Width - 20, 0)
            End If
        End Sub

        Private Sub RadWebCam1_SnapshotTaken(ByVal sender As Object, ByVal e As SnapshotTakenEventArgs)
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = "Images|.png;.bmp;*.jpg"
            dialog.DefaultExt = ".png"
            dialog.FilterIndex = 0

            If dialog.ShowDialog() = DialogResult.OK Then
                e.Snapshot.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
            End If
        End Sub

        Private Function GetVideoFormatString(ByVal formatInfo As MediaFoundationVideoFormatInfo) As String
            Return String.Format("{0} x {1} @ {2} {3}", formatInfo.FrameSizeWidth, formatInfo.FrameSizeHeight, formatInfo.EffectiveFrameRate, formatInfo.SubTypeDisplayName)
        End Function
    End Class
End Namespace
