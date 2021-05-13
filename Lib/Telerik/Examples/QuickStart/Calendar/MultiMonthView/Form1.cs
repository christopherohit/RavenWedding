using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.MultiMonthView
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			this.SelectedControl = this.radCalendar1;

			this.radCalendar1.HeaderWidth = 17;
			this.radCalendar1.HeaderHeight = 17;
            this.radRadioRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        #region Event Handlers
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radCalendar1.AllowMultipleView = true;
            this.radCalendar1.MultiViewRows = 2;
            this.radCalendar1.MultiViewColumns = 2;
            this.radCalendar1.FocusedDate = DateTime.Now;
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

        #endregion

        protected override void WireEvents()
        {
            this.radRadioRows.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
            this.radRadioCols.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRows_ToggleStateChanged);
        }
    }
}