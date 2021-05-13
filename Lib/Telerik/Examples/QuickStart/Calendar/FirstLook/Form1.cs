using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Calendar.FirstLook
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
            this.radCalendar1.HeaderNavigationMode = Telerik.WinControls.UI.HeaderNavigationMode.Zoom;
			this.SelectedControl = this.radCalendar1;
            this.radioButton16.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radCalendar1.ShowFooter = false;
        }

        #region Event Handlers

        private void chRowHeader_Click(object sender, EventArgs e)
		{
            this.radCalendar1.ShowRowHeaders = !(this.chRowHeader.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void chColumnHeader_Click(object sender, EventArgs e)
		{
            this.radCalendar1.ShowColumnHeaders = !(this.chColumnHeader.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void chShowSelector_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowViewSelector = !(this.chShowSelector.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void chNavigationButtons_Click(object sender, EventArgs e)
		{
			this.radCalendar1.ShowNavigationButtons = !(this.chNavigationButtons.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void chFastNavigationButtons_Click(object sender, EventArgs e)
		{
            this.radCalendar1.ShowFastNavigationButtons = !(this.chFastNavigationButtons.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void chViewHeader_Click(object sender, EventArgs e)
		{
            this.radCalendar1.ShowViewHeader = !(this.chViewHeader.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void chAllowFishEye_Click(object sender, EventArgs e)
		{
			this.radCalendar1.AllowFishEye = !(this.chAllowFishEye.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void nudHeaderWidth_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.HeaderWidth = (int)this.nudHeaderWidth.Value;
		}

		private void nudHeaderHeight_ValueChanged(object sender, EventArgs e)
		{
			this.radCalendar1.HeaderHeight = (int)this.nudHeaderHeight.Value;
		}

        private void cbTitleFormat_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radCalendar1.TitleFormat = this.cbTitleFormat.Items[this.cbTitleFormat.SelectedIndex].Text;
        }

		private void radCheckBox2_Click(object sender, EventArgs e)
		{
            this.radCalendar1.ShowHeader = !(this.radCheckBox2.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);
		}

		private void radCheckBox3_Click(object sender, EventArgs e)
		{
            bool rightToLeft = !(this.radCheckBox3.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On);

			if (rightToLeft)
				this.radCalendar1.RightToLeft = RightToLeft.Yes;
			else
				this.radCalendar1.RightToLeft = RightToLeft.No;
		}

        private void radioButton16_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radioButton16.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                this.radCalendar1.Orientation = Orientation.Horizontal;
        }

        private void radioButton15_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.radioButton15.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                this.radCalendar1.Orientation = Orientation.Vertical;
        }
        #endregion

        protected override void WireEvents()
        {
            this.radCheckBox2.Click += new System.EventHandler(this.radCheckBox2_Click);
            this.cbTitleFormat.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cbTitleFormat_SelectedIndexChanged);
            this.radCheckBox3.Click += new System.EventHandler(this.radCheckBox3_Click);
            this.chShowSelector.Click += new System.EventHandler(this.chShowSelector_Click);
            this.chRowHeader.Click += new System.EventHandler(this.chRowHeader_Click);
            this.chColumnHeader.Click += new System.EventHandler(this.chColumnHeader_Click);
            this.chNavigationButtons.Click += new System.EventHandler(this.chNavigationButtons_Click);
            this.chFastNavigationButtons.Click += new System.EventHandler(this.chFastNavigationButtons_Click);
            this.chViewHeader.Click += new System.EventHandler(this.chViewHeader_Click);
            this.chAllowFishEye.Click += new System.EventHandler(this.chAllowFishEye_Click);
            this.nudHeaderHeight.ValueChanged += new System.EventHandler(this.nudHeaderHeight_ValueChanged);
            this.nudHeaderWidth.ValueChanged += new System.EventHandler(this.nudHeaderWidth_ValueChanged);
            this.radioButton16.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioButton16_ToggleStateChanged);
            this.radioButton15.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radioButton15_ToggleStateChanged);
        }
    }
}