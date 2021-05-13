using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Integration.BubbleBar
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            this.CenteredControl = this.bubbleBar1;
		}
	}
}