using System;

namespace Telerik.Examples.WinControls.FileDialogs.FirstLook
{
    public class StorageFile
    {
        public string Name { get; set; }

        public string FileSystemInfoType { get; set; }

        public DateTime UploadedTime { get; set; }

        public StorageFile(string name)
        {
            this.Name = name;
            this.FileSystemInfoType = "File";
            this.UploadedTime = DateTime.Now;
        }
    }
}
