Imports System.IO
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.FileDialogs

Namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private _uploadedFilesCount As Long
        Private cancelUpload As Boolean = False

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            AddHandler Me.textBoxFolder.KeyDown, AddressOf Me.RadTextBox1_KeyDown
            Me.textBoxFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Me.SetCustomFonts("TelerikWebUI", 10)
            Me.UpdateDialogFormsTheme()
            Me.UploadFile("dummy file.txt")
            Me.UploadFile("dummy file 2.txt")
        End Sub

        Public Property UploadedFilesCount As Long
            Get
                Return Me._uploadedFilesCount
            End Get
            Set(ByVal value As Long)

                If Me._uploadedFilesCount = value Then
                    Return
                End If

                Me._uploadedFilesCount = value
                Me.OnUploadedFilesCountChanged()
            End Set
        End Property

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()
            Me.UpdateDialogFormsTheme()
        End Sub

        Private Sub UpdateDialogFormsTheme()
            Me.radOpenFolderDialog1.OpenFolderDialogForm.ThemeName = Me.CurrentThemeName
            Me.radOpenFileDialog1.OpenFileDialogForm.ThemeName = Me.CurrentThemeName
            Me.radSaveFileDialog1.SaveFileDialogForm.ThemeName = Me.CurrentThemeName
        End Sub

        Private Sub UploadFileAsync(ByVal fileName As String)
            Dim uploadFileTimer As Timer = New Timer()
            uploadFileTimer.Interval = 100
            Dim uploadTimerCounter As Integer = 0
            Me.progressFileUpload.Value1 = 0
            AddHandler uploadFileTimer.Tick, Sub(t, args)

                                                 If Me.cancelUpload Then
                                                     uploadFileTimer.[Stop]()
                                                     Me.progressFileUpload.Value1 = 0
                                                     Me.DisableUploadFilesControls()
                                                     Me.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(0, Nothing)
                                                     Me.cancelUpload = False
                                                     Return
                                                 End If

                                                 uploadTimerCounter += 1
                                                 Dim newValue As Integer = uploadTimerCounter * 10

                                                 If newValue > Me.progressFileUpload.Maximum Then
                                                     uploadFileTimer.[Stop]()
                                                     Me.UploadFile(fileName)
                                                     Me.progressFileUpload.Value1 = Me.progressFileUpload.Maximum
                                                     Me.DisableUploadFilesControls()
                                                     Me.EnableUploadFilesActions()
                                                 Else
                                                     Me.progressFileUpload.Value1 = newValue
                                                 End If
                                             End Sub

            uploadFileTimer.Start()
        End Sub

        Private Sub UploadFile(ByVal fileName As String)
            Dim storageFile As StorageFile = New StorageFile(fileName)
            Dim uploadedFileUI As UploadedFileUserControl = New UploadedFileUserControl(storageFile) With {
                .Dock = DockStyle.Top,
                .ThemeName = Me.CurrentThemeName
            }

            AddHandler uploadedFileUI.RemoveRequested, AddressOf Me.UploadedFileUI_RemoveRequested
            AddHandler uploadedFileUI.DownloadRequested, AddressOf Me.UploadedFileUI_DownloadRequested

            If Not Me.scrollableUserControlContainer.Visible Then
                Me.scrollableUserControlContainer.Visible = True
            End If

            Me.scrollableUserControlContainer.Controls.Add(uploadedFileUI)
            uploadedFileUI.Scale(Me.scrollableUserControlContainer.RootElement.DpiScaleFactor)
            If Me.tableLayoutMainPanel.Bottom < Me.CenteredControl.Height - uploadedFileUI.Height Then
                Me.tableLayoutMainPanel.Height += uploadedFileUI.Height
            End If
            Me.UploadedFilesCount += 1
        End Sub

        Private Sub OnUploadedFilesCountChanged()
            Me.labelFilesCount.Text = Me.UploadedFilesCount.ToString()
        End Sub

        Private Sub EnableUploadFilesIndicators()
            Me.labelSuccess.Visible = False
            Me.btnUploadFile.Enabled = False
            Me.btnCancel.Enabled = True
            Me.progressFileUpload.Enabled = True
            Me.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(0, Nothing)
        End Sub

        Private Sub EnableUploadFilesActions()
            Me.btnUploadFile.Enabled = True
            Me.btnClear.Enabled = True
            Me.labelSuccess.Visible = True
            Me.progressFileUpload.Enabled = True
            Me.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(Me.radOpenFileDialog1.OpenFileDialogViewModel.SelectedFileSystemObject.Size, Nothing)
        End Sub

        Private Sub DisableUploadFilesControls()
            Me.btnUploadFile.Enabled = True
            Me.btnCancel.Enabled = False
            Me.progressFileUpload.Enabled = False
            Me.btnClear.Enabled = False
            Me.labelSuccess.Visible = False
            Me.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(0, Nothing)
        End Sub

        Private Sub SetCustomFonts(ByVal fontName As String, ByVal fontSize As Integer)
            Me.btnSelectFolder.ButtonElement.TextElement.CustomFont = fontName
            Me.btnSelectFolder.ButtonElement.TextElement.CustomFontSize = fontSize
            Me.btnSelectFolder.Text = ChrW(&HE901).ToString() & " Select Folder"
            Me.btnClear.ButtonElement.TextElement.CustomFont = fontName
            Me.btnClear.ButtonElement.TextElement.CustomFontSize = fontSize
            Me.btnClear.Text = ChrW(&HE11B).ToString()

            Me.labelSuccess.LabelElement.CustomFont = fontName
            Me.labelSuccess.LabelElement.CustomFontSize = fontSize
            Me.labelSuccess.Text = ChrW(&HE118).ToString()
        End Sub

        Private Sub btnSelectFolder_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radOpenFolderDialog1.ShowDialog() = DialogResult.OK Then
                Me.textBoxFolder.Text = Me.radOpenFolderDialog1.FileName
            End If
        End Sub

        Private Sub btnUploadFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radOpenFileDialog1.InitialDirectory = Me.radOpenFolderDialog1.FileName
            Me.radOpenFileDialog1.FileName = String.Empty

            If Me.radOpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Me.EnableUploadFilesIndicators()
                Dim fileName As String = Me.radOpenFileDialog1.FileName

                If Me.radOpenFileDialog1.SafeFileNames.ToList().Count() > 0 Then
                    fileName = Me.radOpenFileDialog1.SafeFileNames.First()
                End If

                Me.UploadFileAsync(fileName)
            End If
        End Sub

        Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.cancelUpload = True
        End Sub

        Private Sub RadTextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            e.SuppressKeyPress = True
        End Sub

        Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.DisableUploadFilesControls()
        End Sub

        Private Sub UploadedFileUI_DownloadRequested(ByVal sender As Object, ByVal e As EventArgs)
            Dim uploadedFileUserControl As UploadedFileUserControl = CType(sender, UploadedFileUserControl)
            Me.radSaveFileDialog1.InitialDirectory = Me.radOpenFolderDialog1.FileName
            Me.radSaveFileDialog1.FileName = uploadedFileUserControl.StorageModel.Name
            Me.radSaveFileDialog1.Filter = "Word Documents (*.doc)|*.doc|Excel Worksheets (*.xls;*.xlsx)|*.xls;*.xlsx|PowerPoint Presentations (*.ppt)|*.ppt" & "|Office Files (*.doc;*.xls;*.ppt)|*.doc;*.xls;*.ppt" & "|All Files (*.*)|*.*"
            Me.radSaveFileDialog1.FilterIndex = 5

            If Me.radSaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim exceptionMessage As String = Nothing
                Me.radSaveFileDialog1.FileName = Path.ChangeExtension(Me.radSaveFileDialog1.FileName, ".txt")

                Try
                    Dim stream As Stream = radSaveFileDialog1.OpenFile()

                    Using sr As StreamWriter = New StreamWriter(stream)
                        sr.WriteLine("This file is saved with RadSaveFileDialog.")
                    End Using

                Catch ex As NotSupportedException
                    exceptionMessage = ex.Message
                Catch ex As System.Security.SecurityException
                    exceptionMessage = ex.Message
                Catch ex As DirectoryNotFoundException
                    exceptionMessage = ex.Message
                Catch ex As UnauthorizedAccessException
                    exceptionMessage = ex.Message
                Catch ex As PathTooLongException
                    exceptionMessage = ex.Message
                Catch ex As ArgumentOutOfRangeException
                    exceptionMessage = ex.Message
                Catch ex As IOException
                    exceptionMessage = ex.Message
                End Try

                If exceptionMessage IsNot Nothing Then
                    RadMessageBox.Show(exceptionMessage, "Could not save file.", MessageBoxButtons.OK, RadMessageIcon.[Error])
                End If
            End If
        End Sub

        Private Sub UploadedFileUI_RemoveRequested(ByVal sender As Object, ByVal e As EventArgs)
            Dim uploadedFileUI As UploadedFileUserControl = CType(sender, UploadedFileUserControl)
            Me.scrollableUserControlContainer.Controls.Remove(uploadedFileUI)
            Me.tableLayoutMainPanel.Height -= uploadedFileUI.Height
            Me.UploadedFilesCount -= 1

            If Me.UploadedFilesCount = 0 Then
                Me.scrollableUserControlContainer.Visible = False
            End If
        End Sub
    End Class
End Namespace
