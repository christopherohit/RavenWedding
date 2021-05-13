using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.FileExplorer
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\FileExplorer\Bin\FileExplorer.exe";
        }       
    }
}
