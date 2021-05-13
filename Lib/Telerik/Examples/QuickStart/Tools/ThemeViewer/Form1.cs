using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Tools.ThemeViewer
{
    public partial class Form1 : Telerik.QuickStart.WinControls.ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Release\ThemeViewer.exe")) // Release
            {
                return @"\..\..\..\..\Bin\Release\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Release\net40\ThemeViewer.exe")) // Release40
            {
                return @"\..\..\..\..\Bin\Release\net40\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe")) // ReleaseTrial
            {
                return @"\..\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe")) // ReleaseTrial40, ReleaseTrial461
            {
                return @"\..\..\..\..\Bin\ReleaseTrial\net40\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Debug\net40\ThemeViewer.exe")) // Debug40
            {
                return @"\..\..\..\Bin\Debug\net40\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Debug\ThemeViewer.exe")) /// Debug
            {
                return @"\..\..\..\Bin\Debug\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ThemeViewer.exe"))
            {
                return @"\..\..\..\Bin\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin40\ThemeViewer.exe"))
            {
                return @"\..\..\..\Bin40\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\Bin\ReleaseTrial\ThemeViewer.exe")) //qsf as exe case
            {
                return @"\..\..\..\Bin\ReleaseTrial\ThemeViewer.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\Bin\ReleaseTrial40\ThemeViewer.exe")) //qsf as exe case
            {
                return @"\..\..\..\Bin\ReleaseTrial40\ThemeViewer.exe";
            }
            else
            {
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error);
            }

            return string.Empty;
        }

        protected override string GetExternalProcessArguments(string excutablePath)
        {
            return "Office2019Light";
        }
    }
}
