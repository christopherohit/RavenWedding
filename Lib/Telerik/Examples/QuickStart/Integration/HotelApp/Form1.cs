using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.HotelApp
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\HotelApp\HotelAppCS\Bin\HotelApp.exe";
        }
    }
}