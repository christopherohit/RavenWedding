using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.ReadOnlyView
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

            this.SelectedControl = this.radCalendar1;
            this.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
		}

        private void radCheckReadOnly_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radCalendar1.ReadOnly = this.radCheckReadOnly.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        protected override void WireEvents()
        {
            this.radCheckReadOnly.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckReadOnly_ToggleStateChanged);
        }
	}
}