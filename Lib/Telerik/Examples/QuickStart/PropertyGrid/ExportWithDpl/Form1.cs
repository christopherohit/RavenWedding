using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.PropertyGrid.ExportWithDpl
{
    public partial class Form1 : ExternalExampleHostForm
    {
        private readonly string ExternalExampleName = "PropertyGrid";

        public Form1(string themeName)
        {
            this.ThemeName = themeName;
        }

        protected override string GetExecutablePath()
        {
            return @"\..\..\ExportWithDpl\bin\ExportWithDpl.exe";
        }

        protected override string GetEntryPointAsString()
        {
            return "ExportWithDpl."+ExternalExampleName+".Form1";
        }

        protected override string GetExternalProcessArguments(string excutablePath)
        {
            return string.Format("{0} {1}", ExternalExampleName, string.IsNullOrEmpty(this.ThemeName) ? Utils.ThemeName : this.ThemeName);
        }

        protected override bool CanOpenMultipleInstances
        {
            get
            {
                return true;
            }
        }
    }
}
