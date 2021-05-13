Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.tableLayoutMainPanel = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.scrollableUserControlContainer = New Telerik.WinControls.UI.RadScrollablePanel()
            Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.tableLayoutPanel3 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.btnSelectFolder = New Telerik.WinControls.UI.RadButton()
            Me.textBoxFolder = New Telerik.WinControls.UI.RadTextBox()
            Me.labelChooseFile = New Telerik.WinControls.UI.RadLabel()
            Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.tableLayoutPanel4 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.btnUploadFile = New Telerik.WinControls.UI.RadButton()
            Me.btnCancel = New Telerik.WinControls.UI.RadButton()
            Me.labelFieSize = New Telerik.WinControls.UI.RadLabel()
            Me.btnClear = New Telerik.WinControls.UI.RadButton()
            Me.labelSuccess = New Telerik.WinControls.UI.RadLabel()
            Me.progressFileUpload = New Telerik.WinControls.UI.RadProgressBar()
            Me.tableLayoutPanel2 = New Telerik.WinControls.UI.DoubleBufferedTableLayoutPanel()
            Me.labelUploadFile = New Telerik.WinControls.UI.RadLabel()
            Me.labelFilesCount = New Telerik.WinControls.UI.RadLabel()
            Me.radOpenFileDialog1 = New Telerik.WinControls.UI.RadOpenFileDialog()
            Me.radOpenFolderDialog1 = New Telerik.WinControls.UI.RadOpenFolderDialog()
            Me.radSaveFileDialog1 = New Telerik.WinControls.UI.RadSaveFileDialog()
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanelDemoHolder.SuspendLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.settingsPanel.PanelContainer.SuspendLayout()
            Me.settingsPanel.SuspendLayout()
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutMainPanel.SuspendLayout()
            CType((Me.scrollableUserControlContainer), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.scrollableUserControlContainer.SuspendLayout()
            CType((Me.radPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel1.SuspendLayout()
            Me.tableLayoutPanel3.SuspendLayout()
            CType((Me.btnSelectFolder), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textBoxFolder), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelChooseFile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radPanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.radPanel2.SuspendLayout()
            Me.tableLayoutPanel4.SuspendLayout()
            CType((Me.btnUploadFile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnCancel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelFieSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnClear), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelSuccess), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.progressFileUpload), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel2.SuspendLayout()
            CType((Me.labelUploadFile), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelFilesCount), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.radPanelDemoHolder.Controls.Add(Me.tableLayoutMainPanel)
            Me.radPanelDemoHolder.Dock = System.Windows.Forms.DockStyle.None
            Me.radPanelDemoHolder.Location = New System.Drawing.Point(398, 213)
            Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(20)
            Me.radPanelDemoHolder.RootElement.EnableElementShadow = False
            Me.radPanelDemoHolder.Size = New System.Drawing.Size(760, 760)
            Me.settingsPanel.Location = New System.Drawing.Point(1668, 22)
            Me.tableLayoutMainPanel.ColumnCount = 1
            Me.tableLayoutMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700.0F))
            Me.tableLayoutMainPanel.Controls.Add(Me.scrollableUserControlContainer, 0, 4)
            Me.tableLayoutMainPanel.Controls.Add(Me.radPanel1, 0, 0)
            Me.tableLayoutMainPanel.Controls.Add(Me.labelChooseFile, 0, 1)
            Me.tableLayoutMainPanel.Controls.Add(Me.radPanel2, 0, 2)
            Me.tableLayoutMainPanel.Controls.Add(Me.tableLayoutPanel2, 0, 3)
            Me.tableLayoutMainPanel.Location = New System.Drawing.Point(30, 30)
            Me.tableLayoutMainPanel.Name = "tableLayoutMainPanel"
            Me.tableLayoutMainPanel.RowCount = 5
            Me.tableLayoutMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0F))
            Me.tableLayoutMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0F))
            Me.tableLayoutMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0F))
            Me.tableLayoutMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0F))
            Me.tableLayoutMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutMainPanel.Size = New System.Drawing.Size(700, 250)
            Me.tableLayoutMainPanel.TabIndex = 0
            Me.scrollableUserControlContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.scrollableUserControlContainer.Location = New System.Drawing.Point(3, 238)
            Me.scrollableUserControlContainer.Name = "scrollableUserControlContainer"
            Me.scrollableUserControlContainer.PanelContainer.Size = New System.Drawing.Size(692, 8)
            Me.scrollableUserControlContainer.Size = New System.Drawing.Size(694, 10)
            Me.scrollableUserControlContainer.TabIndex = 2
            Me.radPanel1.Controls.Add(Me.tableLayoutPanel3)
            Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel1.Location = New System.Drawing.Point(3, 3)
            Me.radPanel1.Name = "radPanel1"
            Me.radPanel1.Padding = New System.Windows.Forms.Padding(10)
            Me.radPanel1.Size = New System.Drawing.Size(694, 65)
            Me.radPanel1.TabIndex = 3
            Me.tableLayoutPanel3.ColumnCount = 3
            Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 530.0F))
            Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0F))
            Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0F))
            Me.tableLayoutPanel3.Controls.Add(Me.btnSelectFolder, 2, 0)
            Me.tableLayoutPanel3.Controls.Add(Me.textBoxFolder, 0, 0)
            Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel3.Location = New System.Drawing.Point(10, 10)
            Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
            Me.tableLayoutPanel3.RowCount = 1
            Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel3.Size = New System.Drawing.Size(674, 45)
            Me.tableLayoutPanel3.TabIndex = 0
            Me.btnSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnSelectFolder.Location = New System.Drawing.Point(543, 3)
            Me.btnSelectFolder.Name = "btnSelectFolder"
            Me.btnSelectFolder.Padding = New Padding(5)
            Me.btnSelectFolder.Size = New System.Drawing.Size(128, 39)
            Me.btnSelectFolder.TabIndex = 4
            Me.btnSelectFolder.Text = "Select Folder"
            AddHandler Me.btnSelectFolder.Click, AddressOf Me.btnSelectFolder_Click
            Me.textBoxFolder.Dock = System.Windows.Forms.DockStyle.Top
            Me.textBoxFolder.Location = New System.Drawing.Point(3, 3)
            Me.textBoxFolder.Name = "textBoxFolder"
            Me.textBoxFolder.Padding = New System.Windows.Forms.Padding(10, 12, 10, 8)
            Me.textBoxFolder.[ReadOnly] = True
            Me.textBoxFolder.Size = New System.Drawing.Size(524, 37)
            Me.textBoxFolder.TabIndex = 3
            Me.textBoxFolder.Text = "C:\users\admin\desktop"
            Me.tableLayoutMainPanel.SetColumnSpan(Me.labelChooseFile, 2)
            Me.labelChooseFile.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelChooseFile.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            Me.labelChooseFile.Location = New System.Drawing.Point(3, 74)
            Me.labelChooseFile.Name = "labelChooseFile"
            Me.labelChooseFile.Size = New System.Drawing.Size(694, 25)
            Me.labelChooseFile.TabIndex = 4
            Me.labelChooseFile.Text = "Choose a File to Upload"
            Me.radPanel2.Controls.Add(Me.tableLayoutPanel4)
            Me.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radPanel2.Location = New System.Drawing.Point(3, 105)
            Me.radPanel2.Name = "radPanel2"
            Me.radPanel2.Padding = New System.Windows.Forms.Padding(10)
            Me.radPanel2.Size = New System.Drawing.Size(694, 92)
            Me.radPanel2.TabIndex = 5
            Me.tableLayoutPanel4.ColumnCount = 6
            Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0F))
            Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0F))
            Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0F))
            Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0F))
            Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0F))
            Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0F))
            Me.tableLayoutPanel4.Controls.Add(Me.btnUploadFile, 0, 0)
            Me.tableLayoutPanel4.Controls.Add(Me.btnCancel, 2, 0)
            Me.tableLayoutPanel4.Controls.Add(Me.labelFieSize, 4, 0)
            Me.tableLayoutPanel4.Controls.Add(Me.btnClear, 5, 1)
            Me.tableLayoutPanel4.Controls.Add(Me.labelSuccess, 5, 0)
            Me.tableLayoutPanel4.Controls.Add(Me.progressFileUpload, 0, 1)
            Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel4.Location = New System.Drawing.Point(10, 10)
            Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
            Me.tableLayoutPanel4.RowCount = 2
            Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.tableLayoutPanel4.Size = New System.Drawing.Size(674, 72)
            Me.tableLayoutPanel4.TabIndex = 0
            Me.btnUploadFile.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnUploadFile.Location = New System.Drawing.Point(3, 3)
            Me.btnUploadFile.Name = "btnUploadFile"
            Me.btnUploadFile.Padding = New System.Windows.Forms.Padding(3)
            Me.btnUploadFile.Size = New System.Drawing.Size(94, 28)
            Me.btnUploadFile.TabIndex = 0
            Me.btnUploadFile.Text = "Upload File"
            AddHandler Me.btnUploadFile.Click, AddressOf Me.btnUploadFile_Click
            Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnCancel.Enabled = False
            Me.btnCancel.Location = New System.Drawing.Point(113, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Padding = New System.Windows.Forms.Padding(3)
            Me.btnCancel.Size = New System.Drawing.Size(74, 28)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            AddHandler Me.btnCancel.Click, AddressOf Me.btnCancel_Click
            Me.labelFieSize.AutoSize = False
            Me.labelFieSize.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelFieSize.Location = New System.Drawing.Point(543, 3)
            Me.labelFieSize.Name = "labelFieSize"
            Me.labelFieSize.Size = New System.Drawing.Size(88, 18)
            Me.labelFieSize.TabIndex = 2
            Me.labelFieSize.Text = "0 bytes"
            Me.labelFieSize.TextAlignment = System.Drawing.ContentAlignment.TopRight
            Me.btnClear.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnClear.Enabled = False
            Me.btnClear.Location = New System.Drawing.Point(637, 37)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(34, 32)
            Me.btnClear.TabIndex = 3
            Me.btnClear.Text = "X"
            AddHandler Me.btnClear.Click, AddressOf Me.btnClear_Click
            Me.labelSuccess.AutoSize = False
            Me.labelSuccess.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelSuccess.Location = New System.Drawing.Point(637, 3)
            Me.labelSuccess.Name = "labelSuccess"
            Me.labelSuccess.Size = New System.Drawing.Size(34, 28)
            Me.labelSuccess.TabIndex = 4
            Me.labelSuccess.Text = "✓"
            Me.labelSuccess.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.labelSuccess.Visible = False
            Me.progressFileUpload.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.tableLayoutPanel4.SetColumnSpan(Me.progressFileUpload, 5)
            Me.progressFileUpload.Enabled = False
            Me.progressFileUpload.Location = New System.Drawing.Point(3, 42)
            Me.progressFileUpload.Name = "progressFileUpload"
            Me.progressFileUpload.Size = New System.Drawing.Size(628, 22)
            Me.progressFileUpload.TabIndex = 5
            Me.tableLayoutPanel2.ColumnCount = 2
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0634F))
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9366F))
            Me.tableLayoutPanel2.Controls.Add(Me.labelUploadFile, 0, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.labelFilesCount, 1, 0)
            Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 203)
            Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
            Me.tableLayoutPanel2.RowCount = 1
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel2.Size = New System.Drawing.Size(694, 29)
            Me.tableLayoutPanel2.TabIndex = 6
            Me.labelUploadFile.AutoSize = False
            Me.labelUploadFile.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelUploadFile.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            Me.labelUploadFile.Location = New System.Drawing.Point(3, 3)
            Me.labelUploadFile.Name = "labelUploadFile"
            Me.labelUploadFile.Size = New System.Drawing.Size(507, 23)
            Me.labelUploadFile.TabIndex = 0
            Me.labelUploadFile.Text = "Uploaded Files"
            Me.labelFilesCount.AutoSize = False
            Me.labelFilesCount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelFilesCount.Location = New System.Drawing.Point(516, 3)
            Me.labelFilesCount.Name = "labelFilesCount"
            Me.labelFilesCount.Size = New System.Drawing.Size(175, 23)
            Me.labelFilesCount.TabIndex = 1
            Me.labelFilesCount.Text = "0"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Name = "Form1"
            Me.Size = New System.Drawing.Size(1674, 1130)
            CType((Me.radPanelDemoHolder), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanelDemoHolder.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.ResumeLayout(False)
            Me.settingsPanel.PanelContainer.PerformLayout()
            CType((Me.settingsPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.settingsPanel.ResumeLayout(False)
            CType((Me.optionsLabel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutMainPanel.ResumeLayout(False)
            Me.tableLayoutMainPanel.PerformLayout()
            CType((Me.scrollableUserControlContainer), System.ComponentModel.ISupportInitialize).EndInit()
            Me.scrollableUserControlContainer.ResumeLayout(False)
            CType((Me.radPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel1.ResumeLayout(False)
            Me.tableLayoutPanel3.ResumeLayout(False)
            Me.tableLayoutPanel3.PerformLayout()
            CType((Me.btnSelectFolder), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textBoxFolder), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelChooseFile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radPanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.radPanel2.ResumeLayout(False)
            Me.tableLayoutPanel4.ResumeLayout(False)
            CType((Me.btnUploadFile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnCancel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelFieSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnClear), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelSuccess), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.progressFileUpload), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel2.ResumeLayout(False)
            CType((Me.labelUploadFile), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelFilesCount), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private tableLayoutMainPanel As DoubleBufferedTableLayoutPanel
        Private radPanel1 As Telerik.WinControls.UI.RadPanel
        Private tableLayoutPanel3 As DoubleBufferedTableLayoutPanel
        Private btnSelectFolder As Telerik.WinControls.UI.RadButton
        Private textBoxFolder As Telerik.WinControls.UI.RadTextBox
        Private labelChooseFile As Telerik.WinControls.UI.RadLabel
        Private radPanel2 As Telerik.WinControls.UI.RadPanel
        Private tableLayoutPanel4 As DoubleBufferedTableLayoutPanel
        Private btnUploadFile As Telerik.WinControls.UI.RadButton
        Private btnCancel As Telerik.WinControls.UI.RadButton
        Private labelFieSize As Telerik.WinControls.UI.RadLabel
        Private btnClear As Telerik.WinControls.UI.RadButton
        Private labelSuccess As Telerik.WinControls.UI.RadLabel
        Private progressFileUpload As Telerik.WinControls.UI.RadProgressBar
        Private tableLayoutPanel2 As DoubleBufferedTableLayoutPanel
        Private labelUploadFile As RadLabel
        Private labelFilesCount As RadLabel
        Private scrollableUserControlContainer As RadScrollablePanel
        Private radOpenFileDialog1 As RadOpenFileDialog
        Private radOpenFolderDialog1 As RadOpenFolderDialog
        Private radSaveFileDialog1 As RadSaveFileDialog
    End Class
End Namespace
