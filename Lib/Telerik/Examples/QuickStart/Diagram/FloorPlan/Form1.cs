using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Diagram.FloorPlan
{   
    public partial class Form1 : ExternalExampleHostForm
    {
        private readonly string ExternalExampleName = "FloorPlan";
        public Form1()
        {
               
        }
        public Form1(string themeName)
        {
            this.ThemeName = themeName;            
        }

        public override string ExampleName
        {
            get
            {
                return ExternalExampleName;
            }
        }

        protected override string GetEntryPointAsString()
        {
            return "DiagramFirstLook.Form1";
        }


        protected override string GetExecutablePath()
        {
            return @"\..\..\Diagram\DiagramFirstLook\bin\DiagramFirstLook.exe";
        }     
  
        protected override string GetExternalProcessArguments(string excutablePath)
        {
            return string.Format("{0} {1}", string.IsNullOrEmpty(this.ThemeName) ? Utils.ThemeName : this.ThemeName, ExternalExampleName);
        }
    }   
}
