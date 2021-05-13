using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.SingleMonthView
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radCalendar1;
            this.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
		}     

        private void radRadioRows_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radRadioRows.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.Orientation = Orientation.Horizontal;
            }

            if (this.radRadioCols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.Orientation = Orientation.Vertical;
            }
        }

        protected override void WireEvents()
        {
            this.radRadioRows.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
            this.radRadioCols.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
        }
	}
}