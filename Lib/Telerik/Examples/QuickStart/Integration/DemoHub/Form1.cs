using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Telerik.WinControls;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.DemoHub
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\DemoAppsHub\Bin\DemoAppsHub.exe";
        }       
    }
}
