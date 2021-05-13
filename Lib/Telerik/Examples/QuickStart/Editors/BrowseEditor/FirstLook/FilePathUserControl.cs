using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
{
    public partial class FilePathUserControl : UserControl
    {
        private FileData fileViewModel;

        public FilePathUserControl()
        {
            InitializeComponent();

            this.deleteBtn.ButtonElement.Padding = new Padding(0, 2, 0, 0);
            this.deleteBtn.ButtonElement.TextElement.CustomFont = "TelerikWebUI";
            this.deleteBtn.Text = "\ue11B";

            this.radBrowseEditor1.DialogType = Telerik.WinControls.UI.BrowseEditorDialogType.OpenFileDialog;
            this.radBrowseEditor1.ValueChanged += this.RadBrowseEditor1_ValueChanged;
        }

        public FilePathUserControl(FileData fileData)
            : this()
        {
            this.FileViewModel = fileData;
        }

        public FileData FileViewModel
        {
            get
            {
                return this.fileViewModel;
            }
            internal set
            {
                if (this.fileViewModel != value)
                {
                    this.fileViewModel = value;
                    this.fileViewModel.State = FileDataState.Added;
                    this.fileViewModel.PropertyChanged += this.FileViewModel_PropertyChanged;
                }
            }
        }

        public RadButton DeleteButton
        {
            get
            {
                return this.deleteBtn;
            }
        }

        private void RadBrowseEditor1_ValueChanged(object sender, EventArgs e)
        {
            if (this.FileViewModel != null)
            {
                this.FileViewModel.FilePath = this.radBrowseEditor1.Value;
            }
        }

        private void FileViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "FilePath" && !string.IsNullOrEmpty(this.FileViewModel.FileName) && !string.IsNullOrEmpty(this.FileViewModel.FilePath))
            {
                this.fileLabel.Text = string.Format("Name: {0}, {1} bytes", this.FileViewModel.FileName, this.FileViewModel.FileSize);
                if (!this.fileLabel.Visible)
                {
                    int heightStep = TelerikDpiHelper.ScaleInt(20, this.fileLabel.RootElement.DpiScaleFactor);

                    this.labelHolderPanel.Height += heightStep;
                    this.Height += heightStep;
                }

                this.fileLabel.Visible = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.fileViewModel.State = FileDataState.Deleted;
        }
    }
}
