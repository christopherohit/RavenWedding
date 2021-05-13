using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Chat.CarInsurance
{
    public partial class Form1 : ExternalExampleHostForm
    {
        private readonly string ExternalExampleName = "CarInsurance";

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string themeName)
            : this()
        {
            this.ThemeName = themeName;
        }

        public override string ExampleName
        {
            get { return ExternalExampleName; }
        }

        protected override string GetEntryPointAsString()
        {
            return "RadChatExamples.CarInsurance.Form1";
        }

        protected override string GetExecutablePath()
        {
            return @"\..\..\RadChatExamples\bin\RadChatExamples.exe";
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
