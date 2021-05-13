using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.FileDialogs;

namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private long uploadedFilesCount;
        private bool cancelUpload = false;

        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;
            this.textBoxFolder.KeyDown += this.RadTextBox1_KeyDown;
            this.textBoxFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            this.SetCustomFonts("TelerikWebUI", 10);
            this.UpdateDialogFormsTheme();
            this.UploadFile("dummy file.txt");
            this.UploadFile("dummy file 2.txt");
        }

        public long UploadedFilesCount
        {
            get
            {
                return this.uploadedFilesCount;
            }
            set
            {
                if (this.uploadedFilesCount == value)
                {
                    return;
                }

                this.uploadedFilesCount = value;
                this.OnUploadedFilesCountChanged();
            }
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            this.UpdateDialogFormsTheme();
        }

        private void UpdateDialogFormsTheme()
        {
            this.radOpenFolderDialog1.OpenFolderDialogForm.ThemeName = this.CurrentThemeName;
            this.radOpenFileDialog1.OpenFileDialogForm.ThemeName = this.CurrentThemeName;
            this.radSaveFileDialog1.SaveFileDialogForm.ThemeName = this.CurrentThemeName;
        }

        private void UploadFileAsync(string fileName)
        {
            Timer uploadFileTimer = new Timer();
            uploadFileTimer.Interval = 100;
            int uploadTimerCounter = 0;
            this.progressFileUpload.Value1 = 0;
            uploadFileTimer.Tick += (t, args) =>
            {
                if (this.cancelUpload)
                {
                    uploadFileTimer.Stop();
                    this.progressFileUpload.Value1 = 0;
                    this.DisableUploadFilesControls();
                    this.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(0, null);
                    this.cancelUpload = false;
                    return;
                }

                uploadTimerCounter++;
                int newValue = uploadTimerCounter * 10;
                if (newValue > this.progressFileUpload.Maximum)
                {
                    uploadFileTimer.Stop();
                    this.UploadFile(fileName);
                    this.progressFileUpload.Value1 = this.progressFileUpload.Maximum;
                    this.DisableUploadFilesControls();
                    this.EnableUploadFilesActions();
                }
                else
                {
                    this.progressFileUpload.Value1 = newValue;
                }
            };

            uploadFileTimer.Start();
        }

        private void UploadFile(string fileName)
        {
            StorageFile storageFile = new StorageFile(fileName);
            UploadedFileUserControl uploadedFileUI = new UploadedFileUserControl(storageFile)
            {
                Dock = DockStyle.Top,
                ThemeName = this.CurrentThemeName
            };

            uploadedFileUI.RemoveRequested += this.UploadedFileUI_RemoveRequested;
            uploadedFileUI.DownloadRequested += this.UploadedFileUI_DownloadRequested;

            if (!this.scrollableUserControlContainer.Visible)
            {
                this.scrollableUserControlContainer.Visible = true;
            }

            this.scrollableUserControlContainer.Controls.Add(uploadedFileUI);
            uploadedFileUI.Scale(this.scrollableUserControlContainer.RootElement.DpiScaleFactor);
            if (this.tableLayoutMainPanel.Bottom < this.CenteredControl.Height - uploadedFileUI.Height)
            {
                this.tableLayoutMainPanel.Height += uploadedFileUI.Height;
            }

            this.UploadedFilesCount++;
        }

        private void OnUploadedFilesCountChanged()
        {
            this.labelFilesCount.Text = this.UploadedFilesCount.ToString();
        }

        private void EnableUploadFilesIndicators()
        {
            this.labelSuccess.Visible = false;
            this.btnUploadFile.Enabled = false;
            this.btnCancel.Enabled = true;
            this.progressFileUpload.Enabled = true;
            this.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(0, null);
        }

        private void EnableUploadFilesActions()
        {
            this.btnUploadFile.Enabled = true;
            this.btnClear.Enabled = true;
            this.labelSuccess.Visible = true;
            this.progressFileUpload.Enabled = true;
            this.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(this.radOpenFileDialog1.OpenFileDialogViewModel.SelectedFileSystemObject.Size, null);
        }

        private void DisableUploadFilesControls()
        {
            this.btnUploadFile.Enabled = true;
            this.btnCancel.Enabled = false;
            this.progressFileUpload.Enabled = false;
            this.btnClear.Enabled = false;
            this.labelSuccess.Visible = false;
            this.labelFieSize.Text = RoundFileSizeConverter.ConvertToString(0, null);
        }

        private void SetCustomFonts(string fontName, int fontSize)
        {
            this.btnSelectFolder.ButtonElement.TextElement.CustomFont = fontName;
            this.btnSelectFolder.ButtonElement.TextElement.CustomFontSize = fontSize;
            this.btnSelectFolder.Text = "\ue901 Select Folder";

            this.btnClear.ButtonElement.TextElement.CustomFont = fontName;
            this.btnClear.ButtonElement.TextElement.CustomFontSize = fontSize;
            this.btnClear.Text = "\ue11B";

            this.labelSuccess.LabelElement.CustomFont = fontName;
            this.labelSuccess.LabelElement.CustomFontSize = fontSize;
            this.labelSuccess.Text = "\ue118";
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (this.radOpenFolderDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxFolder.Text = this.radOpenFolderDialog1.FileName;
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            this.radOpenFileDialog1.InitialDirectory = this.radOpenFolderDialog1.FileName;
            this.radOpenFileDialog1.FileName = string.Empty;
            if (this.radOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.EnableUploadFilesIndicators();
                string fileName = this.radOpenFileDialog1.FileName;
                if (this.radOpenFileDialog1.SafeFileNames.ToList().Count() > 0)
                {
                    fileName = this.radOpenFileDialog1.SafeFileNames.First();
                }

                this.UploadFileAsync(fileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cancelUpload = true;
        }

        private void RadTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.DisableUploadFilesControls();
        }

        private void UploadedFileUI_DownloadRequested(object sender, EventArgs e)
        {
            UploadedFileUserControl uploadedFileUserControl = (UploadedFileUserControl)sender;
            this.radSaveFileDialog1.InitialDirectory = this.radOpenFolderDialog1.FileName;
            this.radSaveFileDialog1.FileName = uploadedFileUserControl.StorageModel.Name;
            this.radSaveFileDialog1.Filter = "Word Documents (*.doc)|*.doc|Excel Worksheets (*.xls;*.xlsx)|*.xls;*.xlsx|PowerPoint Presentations (*.ppt)|*.ppt" +
                                              "|Office Files (*.doc;*.xls;*.ppt)|*.doc;*.xls;*.ppt" +
                                              "|All Files (*.*)|*.*";
            this.radSaveFileDialog1.FilterIndex = 5;
            if (this.radSaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string exceptionMessage = null;
                this.radSaveFileDialog1.FileName = Path.ChangeExtension(this.radSaveFileDialog1.FileName, ".txt");
                try
                {
                    Stream stream = radSaveFileDialog1.OpenFile();
                    using (StreamWriter sr = new StreamWriter(stream))
                    {
                        sr.WriteLine("This file is saved with RadSaveFileDialog.");
                    }
                }
                catch (NotSupportedException ex)
                {
                    exceptionMessage = ex.Message;
                }
                catch (System.Security.SecurityException ex)
                {
                    exceptionMessage = ex.Message;
                }
                catch (DirectoryNotFoundException ex)
                {
                    exceptionMessage = ex.Message;
                }
                catch (UnauthorizedAccessException ex)
                {
                    exceptionMessage = ex.Message;
                }
                catch (PathTooLongException ex)
                {
                    exceptionMessage = ex.Message;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    exceptionMessage = ex.Message;
                }
                catch (IOException ex)
                {
                    exceptionMessage = ex.Message;
                }

                if (exceptionMessage != null)
                {
                    RadMessageBox.Show(exceptionMessage, "Could not save file.", MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }
        }

        private void UploadedFileUI_RemoveRequested(object sender, EventArgs e)
        {
            UploadedFileUserControl uploadedFileUI = (UploadedFileUserControl)sender;
            this.scrollableUserControlContainer.Controls.Remove(uploadedFileUI);
            this.tableLayoutMainPanel.Height -= uploadedFileUI.Height;
            this.UploadedFilesCount--;
            if (this.UploadedFilesCount == 0)
            {
                this.scrollableUserControlContainer.Visible = false;
            }
        }
    }
}
