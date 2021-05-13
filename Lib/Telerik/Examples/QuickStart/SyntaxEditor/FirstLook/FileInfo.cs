using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
{
    public class FileInfo
    {
        public FileInfo(string fullPath, string name)
        {
            this.FullPath = fullPath;
            this.Name = name;
        }

        public string FullPath
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
