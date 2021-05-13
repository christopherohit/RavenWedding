using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Tools.VisualStyleBuilder
{
    public partial class LaunchForm : ExamplesLauncherForm, ICustomThemeExamplesForm
    {
        public LaunchForm()
        {
            InitializeComponent();

            this.pictureBoxLaunchExample.ButtonImage = Telerik.Examples.WinControls.Properties.Resources.launch;
        }
    }
}
