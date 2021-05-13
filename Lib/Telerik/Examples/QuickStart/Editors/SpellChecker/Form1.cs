using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Editors.SpellChecker
{
    public partial class Form1 : ExternalExampleHostForm
    {
        private readonly string ExternalExampleName = "SpellCheckAsYouType";
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string themeName)
           : this()
        {
            this.ThemeName = themeName;
        }
        protected override string GetExecutablePath()
        {
            return @"\..\..\SpellCheckAsYouType\Bin\SpellCheckAsYouType.exe";
        }
        protected override string GetExternalProcessArguments(string excutablePath)
        {
            return string.Format("{0} {1}", string.IsNullOrEmpty(this.ThemeName) ? Utils.ThemeName : this.ThemeName, ExternalExampleName);
        }

        protected override bool CanOpenMultipleInstances
        {
            get { return true; }
        }
    }
}

