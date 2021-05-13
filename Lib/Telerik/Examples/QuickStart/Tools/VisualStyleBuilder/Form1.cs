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

namespace Telerik.Examples.WinControls.Tools.VisualStyleBuilder
{
    public partial class Form1 :  Telerik.QuickStart.WinControls.ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Release\VisualStyleBuilder.exe")) // Release
            {
                return @"\..\..\..\..\Bin\Release\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Release\net40\VisualStyleBuilder.exe")) // Release40
            {
                return @"\..\..\..\..\Bin\Release\net40\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe")) // ReleaseTrial
            {
                return @"\..\..\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe")) // ReleaseTrial40, ReleaseTrial461
            {
                return @"\..\..\..\..\Bin\ReleaseTrial\net40\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Debug\VisualStyleBuilder.exe")) // Debug
            {
                return @"\..\..\..\Bin\Debug\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\Debug\net40\VisualStyleBuilder.exe")) // Debug40
            {
                return @"\..\..\..\Bin\Debug\net40\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin\VisualStyleBuilder.exe"))
            {
                return @"\..\..\..\Bin\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\..\Bin40\VisualStyleBuilder.exe"))
            {
                return @"\..\..\..\Bin40\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe")) //qsf as exe case
            {
                return @"\..\..\Bin\ReleaseTrial\VisualStyleBuilder.exe";
            }
            else if (File.Exists(Application.StartupPath + @"\..\..\Bin\ReleaseTrial40\VisualStyleBuilder.exe")) //qsf as exe case
            {
                return @"\..\..\Bin\ReleaseTrial40\VisualStyleBuilder.exe";
            }
            else
            {
                RadMessageBox.Show("Could not locate executable!", "Error!", MessageBoxButtons.OK, RadMessageIcon.Error);
            }

            return string.Empty;
        }         
    }
}
