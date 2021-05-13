using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
{
    public class DirectoryInfo : FileInfo
    {
        public DirectoryInfo(string fullPath, string name) : base(fullPath, name)
        {
            this.Children = new ObservableCollection<FileInfo>();
        }

        public ObservableCollection<FileInfo> Children
        {
            get;
            private set;
        }

        public void LoadChildren()
        {
            try
            {
                string[] dirs = Directory.GetDirectories(this.FullPath);
                foreach (string directory in dirs)
                {
                    System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(directory);
                    this.Children.Add(new DirectoryInfo(directory, directoryInfo.Name));
                }

                string[] files = Directory.GetFiles(this.FullPath);
                foreach (string file in files)
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                    this.Children.Add(new FileInfo(file, fileInfo.Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
