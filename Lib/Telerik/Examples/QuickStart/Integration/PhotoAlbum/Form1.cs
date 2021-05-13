using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.PhotoAlbum
{
    public partial class Form1 : ExternalProcessForm
    {
        protected override string GetExecutablePath()
        {
            return @"\..\..\PhotoAlbum\Bin\PhotoAlbum.exe";
        }
    }
}