using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.MedicalApp
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\MedicalApp\MedicalAppCS\Bin\MedicalAppCS.exe";
        }
    }
}