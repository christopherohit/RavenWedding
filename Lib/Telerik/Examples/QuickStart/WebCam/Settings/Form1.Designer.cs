namespace Telerik.Examples.WinControls.WebCam.Settings
{
    partial class Form1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radWebCam1 = new Telerik.WinControls.UI.RadWebCam();
            this.startCameraButton = new Telerik.WinControls.UI.RadButton();
            this.stopCameraButton = new Telerik.WinControls.UI.RadButton();
            this.recordPathLabel = new Telerik.WinControls.UI.RadLabel();
            this.filePathTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.isRecordingCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.previewSnapshotsCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.cameraLabel = new Telerik.WinControls.UI.RadLabel();
            this.cameraDevicesDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.videoFormatsDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.videoFormatLabel = new Telerik.WinControls.UI.RadLabel();
            this.recordingDevicesDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.microphoneLabel = new Telerik.WinControls.UI.RadLabel();
            this.videoRecordingElapsedTimeFormatDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.videoElapsedTimeFormatStringLabel = new Telerik.WinControls.UI.RadLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).BeginInit();
            this.radPanelDemoHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).BeginInit();
            this.settingsPanel.PanelContainer.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWebCam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCameraButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopCameraButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordPathLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePathTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRecordingCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewSnapshotsCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDevicesDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoFormatsDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoFormatLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingDevicesDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microphoneLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRecordingElapsedTimeFormatDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoElapsedTimeFormatStringLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDemoHolder
            // 
            this.radPanelDemoHolder.Controls.Add(this.radWebCam1);
            this.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None;
            this.radPanelDemoHolder.Location = new System.Drawing.Point(56, 33);
            // 
            // 
            // 
            this.radPanelDemoHolder.RootElement.EnableElementShadow = false;
            this.radPanelDemoHolder.Size = new System.Drawing.Size(800, 600);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(1059, 33);
            // 
            // settingsPanel.PanelContainer
            // 
            this.settingsPanel.PanelContainer.Controls.Add(this.videoRecordingElapsedTimeFormatDropDownList);
            this.settingsPanel.PanelContainer.Controls.Add(this.videoElapsedTimeFormatStringLabel);
            this.settingsPanel.PanelContainer.Controls.Add(this.recordingDevicesDropDownList);
            this.settingsPanel.PanelContainer.Controls.Add(this.microphoneLabel);
            this.settingsPanel.PanelContainer.Controls.Add(this.videoFormatsDropDownList);
            this.settingsPanel.PanelContainer.Controls.Add(this.videoFormatLabel);
            this.settingsPanel.PanelContainer.Controls.Add(this.cameraDevicesDropDownList);
            this.settingsPanel.PanelContainer.Controls.Add(this.cameraLabel);
            this.settingsPanel.PanelContainer.Controls.Add(this.previewSnapshotsCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.isRecordingCheckBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.filePathTextBox);
            this.settingsPanel.PanelContainer.Controls.Add(this.recordPathLabel);
            this.settingsPanel.PanelContainer.Controls.Add(this.stopCameraButton);
            this.settingsPanel.PanelContainer.Controls.Add(this.startCameraButton);
            this.settingsPanel.PanelContainer.Size = new System.Drawing.Size(200, 446);
            this.settingsPanel.Size = new System.Drawing.Size(200, 463);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Location = new System.Drawing.Point(9, 406);
            // 
            // radWebCam1
            // 
            this.radWebCam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radWebCam1.Location = new System.Drawing.Point(0, 0);
            this.radWebCam1.Name = "radWebCam1";
            this.radWebCam1.Size = new System.Drawing.Size(800, 600);
            this.radWebCam1.TabIndex = 0;
            this.radWebCam1.Text = "radWebCam1";
            // 
            // startCameraButton
            // 
            this.startCameraButton.Enabled = false;
            this.startCameraButton.Location = new System.Drawing.Point(3, 3);
            this.startCameraButton.Name = "startCameraButton";
            this.startCameraButton.Size = new System.Drawing.Size(194, 24);
            this.startCameraButton.TabIndex = 1;
            this.startCameraButton.Text = "Start Camera";
            this.startCameraButton.Click += new System.EventHandler(this.StartCameraButton_Click);
            // 
            // stopCameraButton
            // 
            this.stopCameraButton.Location = new System.Drawing.Point(3, 37);
            this.stopCameraButton.Name = "stopCameraButton";
            this.stopCameraButton.Size = new System.Drawing.Size(194, 24);
            this.stopCameraButton.TabIndex = 2;
            this.stopCameraButton.Text = "Stop Camera";
            this.stopCameraButton.Click += new System.EventHandler(this.StopCameraButton_Click);
            // 
            // recordPathLabel
            // 
            this.recordPathLabel.Location = new System.Drawing.Point(4, 68);
            this.recordPathLabel.Name = "recordPathLabel";
            this.recordPathLabel.Size = new System.Drawing.Size(105, 18);
            this.recordPathLabel.TabIndex = 3;
            this.recordPathLabel.Text = "Recording File Path:";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(3, 92);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(194, 20);
            this.filePathTextBox.TabIndex = 4;
            // 
            // isRecordingCheckBox
            // 
            this.isRecordingCheckBox.Location = new System.Drawing.Point(4, 126);
            this.isRecordingCheckBox.Name = "isRecordingCheckBox";
            this.isRecordingCheckBox.Size = new System.Drawing.Size(82, 18);
            this.isRecordingCheckBox.TabIndex = 5;
            this.isRecordingCheckBox.Text = "Is Recording";
            // 
            // previewSnapshotsCheckBox
            // 
            this.previewSnapshotsCheckBox.Location = new System.Drawing.Point(4, 382);
            this.previewSnapshotsCheckBox.Name = "previewSnapshotsCheckBox";
            this.previewSnapshotsCheckBox.Size = new System.Drawing.Size(113, 18);
            this.previewSnapshotsCheckBox.TabIndex = 6;
            this.previewSnapshotsCheckBox.Text = "Preview Snapshots";
            // 
            // cameraLabel
            // 
            this.cameraLabel.Location = new System.Drawing.Point(3, 150);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(47, 18);
            this.cameraLabel.TabIndex = 7;
            this.cameraLabel.Text = "Camera:";
            // 
            // cameraDevicesDropDownList
            // 
            this.cameraDevicesDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cameraDevicesDropDownList.Location = new System.Drawing.Point(3, 174);
            this.cameraDevicesDropDownList.Name = "cameraDevicesDropDownList";
            this.cameraDevicesDropDownList.Size = new System.Drawing.Size(194, 20);
            this.cameraDevicesDropDownList.TabIndex = 8;
            this.cameraDevicesDropDownList.Text = "No camera";
            // 
            // videoFormatsDropDownList
            // 
            this.videoFormatsDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.videoFormatsDropDownList.Location = new System.Drawing.Point(3, 232);
            this.videoFormatsDropDownList.Name = "videoFormatsDropDownList";
            this.videoFormatsDropDownList.Size = new System.Drawing.Size(194, 20);
            this.videoFormatsDropDownList.TabIndex = 10;
            this.videoFormatsDropDownList.Text = "No camera";
            // 
            // videoFormatLabel
            // 
            this.videoFormatLabel.Location = new System.Drawing.Point(3, 208);
            this.videoFormatLabel.Name = "videoFormatLabel";
            this.videoFormatLabel.Size = new System.Drawing.Size(76, 18);
            this.videoFormatLabel.TabIndex = 9;
            this.videoFormatLabel.Text = "Video Format:";
            // 
            // recordingDevicesDropDownList
            // 
            this.recordingDevicesDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.recordingDevicesDropDownList.Location = new System.Drawing.Point(3, 290);
            this.recordingDevicesDropDownList.Name = "recordingDevicesDropDownList";
            this.recordingDevicesDropDownList.Size = new System.Drawing.Size(194, 20);
            this.recordingDevicesDropDownList.TabIndex = 13;
            this.recordingDevicesDropDownList.Text = "No camera";
            // 
            // microphoneLabel
            // 
            this.microphoneLabel.Location = new System.Drawing.Point(3, 266);
            this.microphoneLabel.Name = "microphoneLabel";
            this.microphoneLabel.Size = new System.Drawing.Size(69, 18);
            this.microphoneLabel.TabIndex = 12;
            this.microphoneLabel.Text = "Microphone:";
            // 
            // videoRecordingElapsedTimeFormatDropDownList
            // 
            this.videoRecordingElapsedTimeFormatDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.videoRecordingElapsedTimeFormatDropDownList.Location = new System.Drawing.Point(4, 348);
            this.videoRecordingElapsedTimeFormatDropDownList.Name = "videoRecordingElapsedTimeFormatDropDownList";
            this.videoRecordingElapsedTimeFormatDropDownList.Size = new System.Drawing.Size(194, 20);
            this.videoRecordingElapsedTimeFormatDropDownList.TabIndex = 15;
            this.videoRecordingElapsedTimeFormatDropDownList.Text = "No camera";
            // 
            // videoElapsedTimeFormatStringLabel
            // 
            this.videoElapsedTimeFormatStringLabel.Location = new System.Drawing.Point(4, 324);
            this.videoElapsedTimeFormatStringLabel.Name = "videoElapsedTimeFormatStringLabel";
            this.videoElapsedTimeFormatStringLabel.Size = new System.Drawing.Size(199, 18);
            this.videoElapsedTimeFormatStringLabel.TabIndex = 14;
            this.videoElapsedTimeFormatStringLabel.Text = "Video Recording Elapsed Time Format:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Form1";
            this.Size = new System.Drawing.Size(2046, 1156);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDemoHolder)).EndInit();
            this.radPanelDemoHolder.ResumeLayout(false);
            this.settingsPanel.PanelContainer.ResumeLayout(false);
            this.settingsPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPanel)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWebCam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCameraButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopCameraButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordPathLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePathTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRecordingCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewSnapshotsCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDevicesDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoFormatsDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoFormatLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordingDevicesDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microphoneLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRecordingElapsedTimeFormatDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoElapsedTimeFormatStringLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWebCam radWebCam1;
        private Telerik.WinControls.UI.RadButton startCameraButton;
        private Telerik.WinControls.UI.RadTextBox filePathTextBox;
        private Telerik.WinControls.UI.RadLabel recordPathLabel;
        private Telerik.WinControls.UI.RadButton stopCameraButton;
        private Telerik.WinControls.UI.RadDropDownList recordingDevicesDropDownList;
        private Telerik.WinControls.UI.RadLabel microphoneLabel;
        private Telerik.WinControls.UI.RadDropDownList videoFormatsDropDownList;
        private Telerik.WinControls.UI.RadLabel videoFormatLabel;
        private Telerik.WinControls.UI.RadDropDownList cameraDevicesDropDownList;
        private Telerik.WinControls.UI.RadLabel cameraLabel;
        private Telerik.WinControls.UI.RadCheckBox previewSnapshotsCheckBox;
        private Telerik.WinControls.UI.RadCheckBox isRecordingCheckBox;
        private Telerik.WinControls.UI.RadDropDownList videoRecordingElapsedTimeFormatDropDownList;
        private Telerik.WinControls.UI.RadLabel videoElapsedTimeFormatStringLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
