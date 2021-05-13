using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.ERP
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\ERP\ERP.Client\bin\ERP.Client.exe";
        }
    }
}