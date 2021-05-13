using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
{
    public partial class UploadedFileUserControl : UserControl
    {
        public event EventHandler<EventArgs> RemoveRequested;

        public event EventHandler<EventArgs> DownloadRequested;

        private StorageFile storageModel;
        private string themeName;

        public UploadedFileUserControl(StorageFile storageModel)
        {
            InitializeComponent();

            this.SetCustomFonts("TelerikWebUI", 9);
            this.StorageModel = storageModel;
            this.labelFileName.Text = "\ue906 " + this.StorageModel.Name;
        }

        public StorageFile StorageModel
        {
            get
            {
                return this.storageModel;
            }
            set
            {
                if (this.storageModel == value)
                {
                    return;
                }

                this.storageModel = value;
                this.BindControls();
            }
        }

        public string ThemeName
        {
            get
            {
                return this.themeName;
            }
            set
            {
                if (this.themeName == value)
                {
                    return;
                }

                this.themeName = value;
                this.UpdateControlsTheme(this);
            }
        }

        private void SetCustomFonts(string fontName, int fontSize)
        {
            this.labelFileName.LabelElement.CustomFont = fontName;
            this.labelFileName.LabelElement.CustomFontSize = fontSize;

            this.btnRemove.ButtonElement.TextElement.CustomFont = fontName;
            this.btnRemove.ButtonElement.TextElement.CustomFontSize = fontSize;
            this.btnRemove.Text = "\ue11B";
        }

        private void UpdateControlsTheme(Control control)
        {
            IComponentTreeHandler themableControl = control as IComponentTreeHandler;
            if (themableControl != null)
            {
                themableControl.ThemeName = this.ThemeName;
            }

            foreach (Control c in control.Controls)
            {
                this.UpdateControlsTheme(c);
            }
        }

        private void BindControls()
        {
            this.labelFileType.DataBindings.Clear();
            this.labelFileType.DataBindings.Add("Text", this.storageModel, "FileSystemInfoType", false, DataSourceUpdateMode.OnPropertyChanged);
            this.labelUploadDate.DataBindings.Clear();
            this.labelUploadDate.DataBindings.Add("Text", this.storageModel, "UploadedTime", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.RemoveRequested != null)
            {
                this.RemoveRequested(this, e);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (this.DownloadRequested != null)
            {
                this.DownloadRequested(this, e);
            }
        }
    }
}
