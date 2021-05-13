using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.ToastNotificationManager.FirstLook
{
    public partial class Form1 : ExternalExampleHostForm, ICustomThemeExamplesForm
    {
        private readonly string ExternalExampleName = "FirstLook";

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
            return "ToastNotificationManagerExamples.FirstLook.Form1";
        }

        protected override string GetExecutablePath()
        {
            return @"\..\..\ToastNotificationManagerExamples\bin\ToastNotificationManagerExamples.exe";
        }

        protected override string GetExternalProcessArguments(string excutablePath)
        {
            return string.Format("{0} {1}", string.IsNullOrEmpty(this.ThemeName) ? Utils.ThemeName : this.ThemeName, ExternalExampleName);
        }

        protected override bool CanOpenMultipleInstances
        {
            get { return false; }
        }
    }
}
