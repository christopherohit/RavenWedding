﻿using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.RssReader
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\RssReader\Bin\RssReader.exe";
        }       
    }
}