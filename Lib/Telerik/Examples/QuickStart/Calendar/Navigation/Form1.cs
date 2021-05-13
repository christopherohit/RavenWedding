using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Calendar.Navigation
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();

			this.radCalendar1.MultiViewColumns = 1;
			this.radCalendar1.MultiViewColumns = 2;
			
			this.SelectedControl = this.radCalendar1;
   
            this.radCalendar1.RangeMinDate = this.radDateTimePicker1.Value;
            this.radCalendar1.RangeMaxDate = this.radDateTimePicker2.Value;
            this.radDateTimePicker3.Value = DateTime.Now;

            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ExamplesForm.FillComboFromEnum(this.radDropDownList1, typeof(HeaderNavigationMode), this.radCalendar1.HeaderNavigationMode);
            this.radDropDownList1.SelectedIndex = 2;
            this.radCalendar1.HeaderNavigationMode = HeaderNavigationMode.Zoom;
            this.radSpinEditor1.Enabled = false;
        }

		private void radCheckBox1_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowNavigationButtons = !(this.radCheckBox1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void radCheckBox2_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowFastNavigationButtons = !(this.radCheckBox2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void radCheckBox3_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowHeader = !(this.radCheckBox3.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.RangeMinDate = this.radDateTimePicker1.Value;
		}

		private void radDateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.RangeMaxDate = this.radDateTimePicker2.Value;
		}

		private void radDateTimePicker3_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.FocusedDate = this.radDateTimePicker3.Value;
		}

        private void radSpinNavigationStep_ValueChanged(object sender, EventArgs e)
        {
            this.radCalendar1.FastNavigationStep = (int)this.radSpinNavigationStep.Value;
        }

        void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radCalendar1.HeaderNavigationMode = (HeaderNavigationMode)this.radDropDownList1.SelectedItem.Value;
            if (this.radCalendar1.HeaderNavigationMode == HeaderNavigationMode.Popup)
            {
                this.radSpinEditor1.Enabled = true;
            }
            else 
            {
                this.radSpinEditor1.Enabled = false;
            }
        }

        void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            this.radCalendar1.CalendarElement.MonthStep = (int)this.radSpinEditor1.Value;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radCalendar1.RangeMinDate = this.radDateTimePicker1.Value;
            this.radCalendar1.RangeMaxDate = this.radDateTimePicker2.Value;
        }

        protected override void WireEvents()
        {
            this.radCheckBox1.Click += new System.EventHandler(this.radCheckBox1_Click);
            this.radCheckBox2.Click += new System.EventHandler(this.radCheckBox2_Click);
            this.radCheckBox3.Click += new System.EventHandler(this.radCheckBox3_Click);
            this.radDateTimePicker3.ValueChanged += new System.EventHandler(this.radDateTimePicker3_ValueChanged);
            this.radDateTimePicker2.ValueChanged += new System.EventHandler(this.radDateTimePicker2_ValueChanged);
            this.radSpinNavigationStep.ValueChanged += new System.EventHandler(this.radSpinNavigationStep_ValueChanged);
            this.radDateTimePicker1.ValueChanged += new System.EventHandler(this.radDateTimePicker1_ValueChanged);
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList1_SelectedIndexChanged);
            this.radSpinEditor1.ValueChanged += new EventHandler(radSpinEditor1_ValueChanged);
        }


	}
}