using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.ImageEditor.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radImageEditor1.OpenImage(Properties.Resources.ballons_image);
        }
    }
}
