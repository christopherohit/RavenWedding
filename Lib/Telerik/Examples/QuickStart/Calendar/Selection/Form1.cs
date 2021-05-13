using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.Selection
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            
            SetUpCalendar();            
            this.radCalendar1.FocusedDate = DateTime.Now;
            this.radRadioAllowSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioMultiSelectEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioEnableAllowViewSelectorEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioShowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioAllowRowHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioAllowColumnHeaderEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

		}

        private void SetUpCalendar()
        {
            this.SelectedControl = this.radCalendar1;
            this.radCalendar1.AllowColumnHeaderSelectors = true;
            this.radCalendar1.AllowRowHeaderSelectors = true;
            this.radCalendar1.AllowViewSelector = true;
            this.radCalendar1.AllowMultipleSelect = true;
            this.radCalendar1.ShowRowHeaders = true;
        }

        #region Event Handlers

        private void radRadioAllowSelectEnable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioAllowSelectEnable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowSelect = true;
            }

            if (this.radRadioAllowSelectDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowSelect = false;
            }
        }

        private void radRadioMultiSelectEnable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioMultiSelectEnable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowMultipleSelect = true;
            }

            if (this.radRadioMultiSelectDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowMultipleSelect = false;
            }
        }

        private void radRadioEnableAllowViewSelectorEnable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioEnableAllowViewSelectorEnable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowViewSelector = true;
            }

            if (this.radRadioEnableAllowViewSelectorDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowViewSelector = false;
            }
        }

        private void radRadioColumnHeaderEnable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioColumnHeaderEnable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.ShowColumnHeaders = true;
            }

            if (this.radRadioColumnHeaderDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.ShowColumnHeaders = false;
            }
        }

        private void radRadioRowHeaderEnable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioShowRowHeaderEnable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.ShowRowHeaders = true;
            }

            if (this.radRadioShowRowHeaderDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.ShowRowHeaders = false;
            }
        }

        private void radRadioAllowRowHeader_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioAllowRowHeaderEnable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowRowHeaderSelectors = true;
            }

            if (this.radRadioAllowRowHeaderDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowRowHeaderSelectors = false;
            }
        }

        private void radRadioAllowColumnHeaderEnable_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radRadioAllowColumnHeaderEnable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowColumnHeaderSelectors = true;
            }

            if (this.radRadioAllowColumnHeaderDisable.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radCalendar1.AllowColumnHeaderSelectors = false;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (this.radCalendar1.SelectedDates.Count > 0)
            {
                this.radCalendar1.SelectedDates.Clear();
            }
        }
        #endregion

        protected override void WireEvents()
        {
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radRadioAllowSelectEnable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioAllowSelectEnable_ToggleStateChanged);
            this.radRadioAllowSelectDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioAllowSelectEnable_ToggleStateChanged);
            this.radRadioMultiSelectEnable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioMultiSelectEnable_ToggleStateChanged);
            this.radRadioMultiSelectDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioMultiSelectEnable_ToggleStateChanged);
            this.radRadioShowRowHeaderEnable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRowHeaderEnable_ToggleStateChanged);
            this.radRadioShowRowHeaderDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioRowHeaderEnable_ToggleStateChanged);
            this.radRadioEnableAllowViewSelectorEnable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioEnableAllowViewSelectorEnable_ToggleStateChanged);
            this.radRadioAllowRowHeaderEnable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioAllowRowHeader_ToggleStateChanged);
            this.radRadioAllowRowHeaderDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioAllowRowHeader_ToggleStateChanged);
            this.radRadioAllowColumnHeaderEnable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioAllowColumnHeaderEnable_ToggleStateChanged);
            this.radRadioAllowColumnHeaderDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioAllowColumnHeaderEnable_ToggleStateChanged);
            this.radRadioColumnHeaderEnable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioColumnHeaderEnable_ToggleStateChanged);
            this.radRadioColumnHeaderDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioColumnHeaderEnable_ToggleStateChanged);
            this.radRadioEnableAllowViewSelectorDisable.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioEnableAllowViewSelectorEnable_ToggleStateChanged);
        }
    }
}