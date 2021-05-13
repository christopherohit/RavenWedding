using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private ViewModel viewModel;
        private RadWaitingBar waitingBar;
        private bool isInTouchTheme;

        public Form1()
        {
            InitializeComponent();

            this.waitingBar = new RadWaitingBar();
            this.waitingBar.Parent = this;
            this.waitingBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsLine;

            this.CenterPanel = true;
            this.CenteredControl = this.filesHolderPanel;

            this.DataContext = new ViewModel();
            this.DataContext.Files.CollectionChanged += this.Files_CollectionChanged;
            this.BindInitialFileDataViewModels();
        }

        private void Files_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove && e.OldItems != null && e.OldItems.Count == 1)
            {
                FilePathUserControl filePathUserControl = null;
                foreach (Control child in this.filesHolderPanel.Controls)
                {
                    filePathUserControl = child as FilePathUserControl;
                    if (filePathUserControl == null)
                    {
                        continue;
                    }

                    if (e.OldItems[0] == filePathUserControl.FileViewModel)
                    {
                        break;
                    }

                    filePathUserControl = null;
                }

                if (filePathUserControl != null)
                {
                    this.filesHolderPanel.Controls.Remove(filePathUserControl);
                }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
            {
                if (this.waitingBar.IsWaiting)
                {
                    this.waitingBar.StopWaiting();
                    this.waitingBar.AssociatedControl = null;
                }

                for (int i = this.filesHolderPanel.Controls.Count - 1; i >= 0; i--)
                {
                    if (this.filesHolderPanel.Controls[i] is FilePathUserControl)
                    {
                        this.filesHolderPanel.Controls.RemoveAt(i);
                    }
                }

                this.BeginInvoke(new Action(this.AddNewFile));
            }

            if (this.DataContext.RemoveFileCommand.CanExecute(null))
            {
                foreach (Control child in this.filesHolderPanel.Controls)
                {
                    FilePathUserControl filePathUserControl = child as FilePathUserControl;
                    if (filePathUserControl == null)
                    {
                        continue;
                    }

                    filePathUserControl.DeleteButton.Enabled = true;
                }
            }
            else
            {
                foreach (Control child in this.filesHolderPanel.Controls)
                {
                    FilePathUserControl filePathUserControl = child as FilePathUserControl;
                    if (filePathUserControl == null)
                    {
                        continue;
                    }

                    filePathUserControl.DeleteButton.Enabled = false;
                }
            }

            if (this.DataContext.UploadFilesCommand.CanExecute(null))
            {
                this.uploadFilesBtn.Enabled = true;
            }
            else
            {
                this.uploadFilesBtn.Enabled = false;
            }

            if (this.DataContext.AddNewFileCommand.CanExecute(null))
            {
                this.addNewBtn.Enabled = true;
            }
            else
            {
                this.addNewBtn.Enabled = false;
            }
        }

        public ViewModel DataContext
        {
            get { return this.viewModel; }
            internal set { this.viewModel = value; }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            this.AddNewFile();
        }

        private void AddNewFile()
        {
            if (this.DataContext.AddNewFileCommand.CanExecute(null))
            {
                FileData data = new FileData();
                data.PropertyChanged += this.Data_PropertyChanged;
                FilePathUserControl filePathUserControl = new FilePathUserControl(data);
                ThemeResolutionService.ApplyThemeToControlTree(filePathUserControl, this.CurrentThemeName);
                if (this.isInTouchTheme)
                {                    
                    filePathUserControl.Height += TelerikDpiHelper.ScaleInt(10, this.filesHolderPanel.RootElement.DpiScaleFactor);
                }

                this.filesHolderPanel.Controls.Add(filePathUserControl);
                filePathUserControl.Scale(this.filesHolderPanel.RootElement.DpiScaleFactor);
                this.filesHolderPanel.Controls.SetChildIndex(filePathUserControl, 0);
                filePathUserControl.Dock = DockStyle.Top;

                this.DataContext.AddNewFileCommand.Execute(data);
            }
        }

        private void UploadFilesBtn_Click(object sender, EventArgs e)
        {
            if (this.DataContext.UploadFilesCommand.CanExecute(null))
            {
                this.DataContext.UploadFilesCommand.Execute(null);
                this.waitingBar.AssociatedControl = this.filesHolderPanel;
                this.waitingBar.StartWaiting();
            }
        }

        private void Data_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            FileData data = sender as FileData;
            if (e.PropertyName == "State" && data != null && data.State == FileDataState.Deleted)
            {
                if (this.DataContext.RemoveFileCommand.CanExecute(null))
                {
                    this.DataContext.RemoveFileCommand.Execute(data);
                }
                else
                {
                    data.State = FileDataState.Added;
                }
            }
            else if (e.PropertyName == "FilePath")
            {
                this.DataContext.FilePathChangedCommand.Execute(data);
                if (this.DataContext.UploadFilesCommand.CanExecute(null))
                {
                    this.uploadFilesBtn.Enabled = true;
                }
                else
                {
                    this.uploadFilesBtn.Enabled = false;
                }
            }
        }

        private void BindInitialFileDataViewModels()
        {
            this.filePathUserControl1.FileViewModel = this.DataContext.Files[0];
            this.filePathUserControl1.FileViewModel.PropertyChanged += Data_PropertyChanged;
            this.filePathUserControl2.FileViewModel = this.DataContext.Files[1];
            this.filePathUserControl2.FileViewModel.PropertyChanged += Data_PropertyChanged;
            this.filePathUserControl3.FileViewModel = this.DataContext.Files[2];
            this.filePathUserControl3.FileViewModel.PropertyChanged += Data_PropertyChanged;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (!this.isInTouchTheme && (TelerikHelper.IsMaterialTheme(this.CurrentThemeName) || TelerikHelper.IsMetroTouchTheme(this.CurrentThemeName)))
            {
                this.isInTouchTheme = true;
                int xOffset = TelerikDpiHelper.ScaleInt(50, this.addNewBtn.RootElement.DpiScaleFactor);
                int yOffset = TelerikDpiHelper.ScaleInt(10, this.addNewBtn.RootElement.DpiScaleFactor);
                this.headerLabel.Font = new Font(this.headerLabel.Font.Name, 20, this.headerLabel.Font.Style);
                foreach (Control child in this.filesHolderPanel.Controls)
                {
                    FilePathUserControl filePathUserControl = child as FilePathUserControl;
                    if (filePathUserControl == null)
                    {
                        continue;
                    }

                    filePathUserControl.Height += yOffset;
                }

                this.addNewBtn.Location = new Point(this.addNewBtn.Location.X - xOffset, this.addNewBtn.Location.Y + yOffset * 4);
                this.addNewBtn.Width += xOffset / 2;
                this.uploadFilesBtn.Location = new Point(this.uploadFilesBtn.Location.X - xOffset / 2, this.uploadFilesBtn.Location.Y + yOffset * 4);
                this.uploadFilesBtn.Width += xOffset / 2;
                this.headerLabel.Height += yOffset * 2;
                this.filesHolderPanel.Height += yOffset * 4;
            }
            else if (!this.isInTouchTheme)
            {
                this.headerLabel.Font = new Font(this.headerLabel.Font.Name, 16, this.headerLabel.Font.Style);
            }
        }
    }
}
