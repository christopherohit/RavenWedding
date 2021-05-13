using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.MediaFoundation;

namespace Telerik.Examples.WinControls.WebCam.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private static readonly List<Guid> SupportedVideoInputTypes = new List<Guid>()
        {
            MFMediaType.I420,
            MFMediaType.IYUV,
            MFMediaType.NV12,
            MFMediaType.YUY2,
            MFMediaType.YV12
        };

        private string cameraValidatedRecordingPath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            this.CenterPanel = true;

            this.InitializeSettings();
        }

        public RadWebCam Camera { get { return this.radWebCam1; } }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radWebCam1.SnapshotTaken += new EventHandler<SnapshotTakenEventArgs>(this.RadWebCam1_SnapshotTaken);
            this.radWebCam1.RecordingStarted += this.RadWebCam1_RecordingStarted;
            this.radWebCam1.RecordingEnded += this.RadWebCam1_RecordingEnded;
            this.filePathTextBox.Validating += new CancelEventHandler(this.FilePathTextBox_Validating);
            this.isRecordingCheckBox.ToggleStateChanged += new StateChangedEventHandler(this.IsRecordingCheckBox_ToggleStateChanged);
            this.previewSnapshotsCheckBox.ToggleStateChanged += new StateChangedEventHandler(this.PreviewSnapshotsCheckBox_ToggleStateChanged);
            this.cameraDevicesDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CameraDevicesDropDownList_SelectedIndexChanged);
            this.videoFormatsDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.VideoFormatsDropDownList_SelectedIndexChanged);
            this.recordingDevicesDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.RecordingDevicesDropDownList_SelectedIndexChanged);
            this.videoRecordingElapsedTimeFormatDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.VideoRecordingElapsedTimeFormatDropDownList_SelectedIndexChanged);
        }

        private void RadWebCam1_RecordingStarted(object sender, CancelEventArgs e)
        {
            this.cameraValidatedRecordingPath = this.radWebCam1.RecordingFilePath;
            this.radWebCam1.RecordingFilePath = this.cameraValidatedRecordingPath.Substring(0, this.cameraValidatedRecordingPath.Length - ".mp4".Length) + DateTime.Now.ToString("HH-mm-ss") + ".mp4";
        }

        private void RadWebCam1_RecordingEnded(object sender, EventArgs e)
        {
            this.radWebCam1.RecordingFilePath = this.cameraValidatedRecordingPath;
            System.Diagnostics.Process.Start(Path.GetDirectoryName(this.cameraValidatedRecordingPath));
        }

        private void InitializeSettings()
        {
            ReadOnlyCollection<MediaFoundationDeviceInfo> cameraDevices = RadWebCam.GetVideoCaptureDevices();
            this.cameraDevicesDropDownList.DataSource = cameraDevices;
            if (cameraDevices.Count > 0)
            {
                var defaultCamera = cameraDevices[0];
                this.cameraDevicesDropDownList.SelectedValue = defaultCamera;
                this.UpdateVideoFormats(defaultCamera);
            }

            ReadOnlyCollection<MediaFoundationDeviceInfo> recordingDevices = RadWebCam.GetAudioCaptureDevices();
            this.recordingDevicesDropDownList.DataSource = recordingDevices;
            if (recordingDevices.Count > 0)
            {
                this.recordingDevicesDropDownList.SelectedValue = recordingDevices[0];
            }

            this.Camera.RecordingFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "video.mp4");
            this.filePathTextBox.Text = this.Camera.RecordingFilePath;

            List<string> elapsedTimeFormats = new List<string>() { "t", "mm\\:ss\\:ff", "mm\\:ss", };
            this.videoRecordingElapsedTimeFormatDropDownList.DataSource = elapsedTimeFormats;
            this.videoRecordingElapsedTimeFormatDropDownList.SelectedIndex = 1;

            if (cameraDevices.Count == 0)
            {
                this.settingsPanel.Enabled = false;
                return;
            }

            this.Camera.CameraError += this.OnCameraError;
        }

        private void RestartCamera()
        {
            MediaFoundationDeviceInfo videoDevice = (MediaFoundationDeviceInfo)this.cameraDevicesDropDownList.SelectedValue;
            MediaFoundationVideoFormatInfo videoFormat = (MediaFoundationVideoFormatInfo)this.videoFormatsDropDownList.SelectedValue;
            MediaFoundationDeviceInfo recordingDevice = (MediaFoundationDeviceInfo)this.recordingDevicesDropDownList.SelectedValue;
            if (videoDevice != null && videoFormat != null)
            {
                this.Camera.Initialize(videoDevice, videoFormat, recordingDevice);
                if (this.stopCameraButton.Enabled)
                {
                    this.Camera.Start();
                }
            }
        }

        private void UpdateVideoFormats(MediaFoundationDeviceInfo defaultCamera)
        {
            try
            {
                IEnumerable<MediaFoundationVideoFormatInfo> videoFormats = RadWebCam.GetVideoFormats(defaultCamera, true).OrderByDescending(x => x.FrameSizeHeight).ThenByDescending(x => x.EffectiveFrameRate);
                foreach (MediaFoundationVideoFormatInfo formatInfo in videoFormats)
                {
                    RadListDataItem item = new RadListDataItem(this.GetVideoFormatString(formatInfo), formatInfo);
                    this.videoFormatsDropDownList.Items.Add(item);
                }

                MediaFoundationVideoFormatInfo defaultFormat = videoFormats.FirstOrDefault(f => SupportedVideoInputTypes.Contains(f.SubType));
                this.videoFormatsDropDownList.SelectedValue = defaultFormat;
            }
            catch (UnauthorizedAccessException)
            {
                this.Enabled = false;
            }
        }

        public string Validate(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(fileName);
            if (!fileExtension.Equals(".mp4"))
            {
                return "Invalid file extension - use .mp4";
            }

            string directoryPath = filePath.Replace(fileName, string.Empty);
            if (!Directory.Exists(directoryPath))
            {
                return "File directory doesn't exist";
            }

            return string.Empty;
        }

        private void OnCameraError(object sender, CameraErrorEventArgs e)
        {
            this.Enabled = false;
        }

        private void StartCameraButton_Click(object sender, EventArgs e)
        {
            this.stopCameraButton.Enabled = true;
            this.startCameraButton.Enabled = false;
            this.isRecordingCheckBox.Enabled = true;
            this.Camera.Start();
        }

        private void StopCameraButton_Click(object sender, EventArgs e)
        {
            this.stopCameraButton.Enabled = false;
            this.startCameraButton.Enabled = true;
            this.isRecordingCheckBox.Enabled = false;
            this.Camera.Stop();
        }

        private void IsRecordingCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.Camera.IsRecording = this.isRecordingCheckBox.IsChecked;
        }

        private void CameraDevicesDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            MediaFoundationDeviceInfo selectedCamera = (MediaFoundationDeviceInfo)this.cameraDevicesDropDownList.SelectedValue;
            this.UpdateVideoFormats(selectedCamera);
            this.RestartCamera();
        }

        private void VideoFormatsDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.videoFormatsDropDownList.SelectedItem != null)
            {
                this.RestartCamera();
                MediaFoundationVideoFormatInfo selectedFormat = (MediaFoundationVideoFormatInfo)this.videoFormatsDropDownList.SelectedValue;
                if (!SupportedVideoInputTypes.Contains(selectedFormat.SubType))
                {
                    this.Camera.WebCamElement.ToggleRecordingButton.Visibility = ElementVisibility.Collapsed;
                    //this.recordingButtonVisibilityCheckBox.Enabled = false;
                }
                else
                {
                    if (this.Camera.WebCamElement.ToggleRecordingButton.Visibility == ElementVisibility.Collapsed)
                    {
                        this.Camera.WebCamElement.ToggleRecordingButton.Visibility = ElementVisibility.Visible;
                        //this.recordingButtonVisibilityCheckBox.Enabled = true;
                    }
                }

                //     this.videoFormatsDropDownList.SelectedItem.Text = this.GetVideoFormatString(selectedFormat);
            }
        }

        private void RecordingDevicesDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.RestartCamera();
        }

        private void VideoRecordingElapsedTimeFormatDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.Camera.VideoRecordingElapsedTimeFormat = (string)this.videoRecordingElapsedTimeFormatDropDownList.SelectedValue;
        }

        private void PreviewSnapshotsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.Camera.PreviewSnapshots = this.previewSnapshotsCheckBox.IsChecked;
        }

        private void FilePathTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = this.Validate(this.filePathTextBox.Text);
            if (string.IsNullOrEmpty(errorMessage))
            {
                this.errorProvider1.SetError(this.filePathTextBox, null);
                this.filePathTextBox.MaximumSize = new System.Drawing.Size(0, 0);
                this.Camera.RecordingFilePath = this.filePathTextBox.Text;
            }
            else
            {
                e.Cancel = true;
                this.errorProvider1.SetError(this.filePathTextBox, errorMessage);
                this.filePathTextBox.MaximumSize = new System.Drawing.Size(this.cameraDevicesDropDownList.Width - 20, 0);
            }
        }

        private void RadWebCam1_SnapshotTaken(object sender, SnapshotTakenEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Images|.png;.bmp;*.jpg";
            dialog.DefaultExt = ".png";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                e.Snapshot.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private string GetVideoFormatString(MediaFoundationVideoFormatInfo formatInfo)
        {
            return string.Format("{0} x {1} @ {2} {3}", formatInfo.FrameSizeWidth, formatInfo.FrameSizeHeight, formatInfo.EffectiveFrameRate, formatInfo.SubTypeDisplayName);
        }
    }
}
