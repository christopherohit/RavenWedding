using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Telerik.WinControls.RichTextEditor.UI;
using Telerik.WinForms.RichTextEditor.RichTextBoxUI.Dialogs.StyleFormattingProperties;

namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<FileData> files;
        private DelegateCommand addNewFileCommand;
        private DelegateCommand uploadFilesCommand;
        private DelegateCommand filePathChangedCommand;
        private DelegateCommand removeFileCommand;
        private bool isBusy;
        private DispatcherTimer progressTimer;
        private int progressValue;

        public ViewModel()
        {
            this.AddNewFileCommand = new DelegateCommand(this.OnAddNewFile, this.OnCanAddNewFile);
            this.UploadFilesCommand = new DelegateCommand(this.OnUploadFiles, this.OnCanUploadFiles);
            this.FilePathChangedCommand = new DelegateCommand(this.OnFilePathChanged);
            this.RemoveFileCommand = new DelegateCommand(this.OnRemoveFile, this.OnCanRemoveFile);

            this.progressTimer = new DispatcherTimer();
            this.progressTimer.Tick += new EventHandler(this.OnTimerTick);

            this.Files = this.CreateEmptyFiles();
            this.Files.CollectionChanged += Files_CollectionChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<FileData> Files
        {
            get
            {
                return files;
            }

            set
            {
                if (this.files != value)
                {
                    this.files = value;
                    this.OnPropertyChanged("Files");
                }
            }
        }

        public DelegateCommand AddNewFileCommand
        {
            get { return addNewFileCommand; }
            set
            {

                if (this.addNewFileCommand != value)
                {
                    this.addNewFileCommand = value;
                    this.OnPropertyChanged("AddNewFileCommand");
                }
            }
        }

        public DelegateCommand UploadFilesCommand
        {
            get { return uploadFilesCommand; }
            set
            {

                if (this.uploadFilesCommand != value)
                {
                    this.uploadFilesCommand = value;
                    this.OnPropertyChanged("UploadFilesCommand");
                }
            }
        }

        public DelegateCommand FilePathChangedCommand
        {
            get { return filePathChangedCommand; }
            set
            {

                if (this.filePathChangedCommand != value)
                {
                    this.filePathChangedCommand = value;
                    this.OnPropertyChanged("FilePathChangedCommand");
                }
            }
        }

        public DelegateCommand RemoveFileCommand
        {
            get { return removeFileCommand; }
            set
            {

                if (this.removeFileCommand != value)
                {
                    this.removeFileCommand = value;
                    this.OnPropertyChanged("RemoveFileCommand");
                }
            }
        }

        public bool IsBusy
        {
            get { return this.isBusy; }
            set
            {
                if (this.isBusy != value)
                {
                    this.isBusy = value;
                    this.OnPropertyChanged("IsBusy");
                }
            }
        }

        public int ProgressValue
        {
            get
            {
                return this.progressValue;
            }
            set
            {
                if (this.progressValue != value)
                {
                    this.progressValue = value;
                    this.OnPropertyChanged("ProgressValue");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Files_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.InvalidateCommands();
        }

        private void OnAddNewFile(object obj)
        {
            FileData fileData = obj as FileData;
            if (fileData == null)
            {
                fileData = new FileData();
            }

            this.Files.Add(fileData);
        }

        private bool OnCanAddNewFile(object obj)
        {
            return this.Files.Count < 5;
        }

        private void OnUploadFiles(object obj)
        {
            this.progressTimer.Interval = TimeSpan.FromMilliseconds(10);
            this.ProgressValue = 0;
            this.progressTimer.Start();

            this.IsBusy = true;
        }

        private bool OnCanUploadFiles(object obj)
        {
            bool canUploadFile = false;
            foreach (FileData fileData in this.Files)
            {
                if (!string.IsNullOrEmpty(fileData.FilePath))
                {
                    canUploadFile = true;
                    break;
                }
            }

            return canUploadFile;
        }

        public void OnFilePathChanged(object obj)
        {
            this.UploadFilesCommand.InvalidateCanExecute();
        }

        private void OnRemoveFile(object obj)
        {
            FileData fileData = obj as FileData;
            if (fileData != null)
            {
                this.Files.Remove(fileData);
            }
        }

        private bool OnCanRemoveFile(object obj)
        {
            return this.Files.Count > 1;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            this.ProgressValue++;

            if (this.ProgressValue == 100)
            {
                this.progressTimer.Stop();
                this.IsBusy = false;

                this.Files.Clear();
                this.InvalidateCommands();
            }
        }

        private ObservableCollection<FileData> CreateEmptyFiles()
        {
            ObservableCollection<FileData> files = new ObservableCollection<FileData>();

            FileData fileData = new FileData();
            files.Add(fileData);

            fileData = new FileData();
            files.Add(fileData);

            fileData = new FileData();
            files.Add(fileData);

            return files;
        }

        private void InvalidateCommands()
        {
            this.AddNewFileCommand.InvalidateCanExecute();
            this.RemoveFileCommand.InvalidateCanExecute();
            this.UploadFilesCommand.InvalidateCanExecute();
        }
    }
}
