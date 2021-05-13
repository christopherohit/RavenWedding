using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.Editors.BrowseEditor.FirstLook
{
    public enum FileDataState
    {
        Added,
        Deleted
    }

    public class FileData : INotifyPropertyChanged
    {
        private string filePath;
        private string fileName;
        private long fileSize;
        private FileDataState state;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FilePath
        {
            get
            {
                return this.filePath;
            }

            set
            {
                if (this.filePath != value)
                {
                    this.filePath = value;

                    if (!string.IsNullOrEmpty(this.filePath))
                    {
                        FileInfo fileInfo = new FileInfo(this.FilePath);

                        if (fileInfo != null)
                        {
                            this.FileName = fileInfo.Name;
                            this.FileSize = fileInfo.Length;
                        }
                    }

                    this.OnPropertyChanged("FilePath");
                }
            }
        }

        public FileDataState State
        {
            get
            {
                return this.state;
            }

            set
            {
                if (this.state != value)
                {
                    this.state = value;
                    this.OnPropertyChanged("State");
                }
            }
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }

            set
            {
                if (this.fileName != value)
                {
                    this.fileName = value;
                    this.OnPropertyChanged("FileName");
                }
            }
        }

        public long FileSize
        {
            get
            {
                return this.fileSize;
            }

            set
            {
                if (this.fileSize != value)
                {
                    this.fileSize = value;
                    this.OnPropertyChanged("FileSize");
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
    }
}
