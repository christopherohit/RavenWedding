using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.LayoutCustomization
{
	public partial class Form1 : ExamplesForm
	{
		private Size defaultSize;

		public Form1()
		{
			InitializeComponent();

			this.defaultSize = this.radCalendar1.Size;
            this.radRadio7Cols.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
		}

        #region Event Handlers
        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radRadio7Cols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_7columns_x_6rows;
                this.radCalendar1.Size = this.defaultSize;
            }

            if (this.radRadio14Cols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_14columns_x_3rows;
                this.radCalendar1.Size = new Size(this.defaultSize.Width * 2, this.defaultSize.Height / 2 + 20);
            }

            if (this.radRadio21Cols.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.MonthLayout = Telerik.WinControls.UI.MonthLayout.Layout_21columns_x_2rows;
                this.radCalendar1.Size = new Size(this.defaultSize.Width * 3-20, this.defaultSize.Height / 2 + 10);
            }
        }
        #endregion

        protected override void WireEvents()
        {
            this.radRadio7Cols.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radRadio21Cols.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radRadio14Cols.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
        }
    }
}