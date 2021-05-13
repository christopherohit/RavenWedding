using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.BugTracker
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\BugTracker\Bin\BugTracker.exe";
        }      
    }
}
