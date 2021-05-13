using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.TimePicker
{
	public partial class Form1 : EditorExampleBaseForm
	{
        Timer timer = new Timer();

		public Form1()
		{
			InitializeComponent();
            this.SelectedControl = this.radTimePicker1;
            this.radTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 4, 20, 0);
            this.radTimePicker3.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 45, 0);
            this.radTimePicker1.TimePickerElement.MinValue = (DateTime)this.radTimePicker2.Value;
            this.radTimePicker1.TimePickerElement.MaxValue = (DateTime)this.radTimePicker3.Value;

            this.radTimePicker1.Validated += new EventHandler(radTimePicker1_Validated);
            this.radClock1.ShowSystemTime = false;

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;          
		}

        protected override void WireEvents()
        {
            this.radTimePicker1.ValueChanged += new System.EventHandler(this.radTimePicker1_ValueChanged);
            this.TablesDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.TablesDropDownList_SelectedIndexChanged);
            this.ClockPossitionDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ClockPossitionDropDownList_SelectedIndexChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.Disposed += new System.EventHandler(this.Form1_Disposed);
            this.radPageView1.SelectedPageChanging += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.radPageView1_SelectedPageChanging);
            this.radTimePicker2.ValueChanged += new EventHandler(radTimePicker2_ValueChanged);
            this.radTimePicker3.ValueChanged += new EventHandler(radTimePicker3_ValueChanged);
        }

        void radTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.radTimePicker1.TimePickerElement.MinValue = (DateTime)this.radTimePicker2.Value;
        }

        void radTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            this.radTimePicker1.TimePickerElement.MaxValue = (DateTime)this.radTimePicker3.Value;
        }

        void SynchronizeTime()
        {
            if (this.radClock1.Value == null)
            {
                this.radClock1.Value = DateTime.Now;
            }

            DateTime currentTime = this.radClock1.Value.Value;
            currentTime = currentTime.AddSeconds(1);
            this.radLabelDate.Text = currentTime.ToLongDateString();
            this.radClock1.Value = currentTime;
            if (this.radTimePicker1.Value == null)
            {
                this.radTimePicker1.Value = DateTime.Now;
            }
            if (this.radTimePicker1.Value < this.radTimePicker1.TimePickerElement.MinValue ||
               this.radTimePicker1.Value > this.radTimePicker1.TimePickerElement.MinValue) 
            {
                return;
            }
            if (this.radTimePicker1.Value.Value.Minute != currentTime.Minute ||
                this.radTimePicker1.Value.Value.Hour != currentTime.Hour)
            {
                this.radTimePicker1.Value = currentTime;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            SynchronizeTime();
        }

        private void radPageView1_SelectedPageChanging(object sender, Telerik.WinControls.UI.RadPageViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
        
        private void radTimePicker1_ValueChanged(object sender, EventArgs e)
		{
            if (this.radTimePicker1.Value >= this.radTimePicker1.TimePickerElement.MinValue &&
                this.radTimePicker1.Value <= this.radTimePicker1.TimePickerElement.MinValue)
            {
                this.radClock1.Value = this.radTimePicker1.Value;
            }
        }

        void radTimePicker1_Validated(object sender, EventArgs e)
        {
            this.radClock1.Value = this.radTimePicker1.Value;
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
		{
			this.radTimePicker1.ReadOnly = this.radCheckBox1.IsChecked;
		}

		private void TablesDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			this.radTimePicker1.TimeTables = (TimeTables)(e.Position);
		}

		private void ClockPossitionDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			this.radTimePicker1.ClockPosition = (ClockPosition)(e.Position);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            TablesDropDownList.SelectedIndex = 1;
            ClockPossitionDropDownList.SelectedIndex = 0;

            DateTime currentTime = DateTime.Now;
            this.radTimePicker1.Value = currentTime;

            SynchronizeTime();
            timer.Start();

            try
            {
                RegistryKey timeZoneInfoKey = Registry.LocalMachine.
                    OpenSubKey(@"SYSTEM\CurrentControlSet\Control\TimeZoneInformation");
                if (timeZoneInfoKey != null)
                {
                    object timeZoneKeyName = timeZoneInfoKey.GetValue("TimeZoneKeyName");
                    if (timeZoneKeyName != null)
                    {
                        RegistryKey timeZoneNameKey = Registry.LocalMachine.
                            OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Time Zones\" + timeZoneKeyName);
                        if (timeZoneKeyName != null)
                        {
                            object displayName = timeZoneNameKey.GetValue("Display");
                            if (displayName != null)
                            {
                                radLabelTimeZone.Text = displayName.ToString();
                                return;
                            }
                        }
                    }
                }

                TimeZone localZone = TimeZone.CurrentTimeZone;
                int hours = localZone.GetUtcOffset(currentTime).Hours;
                radLabelTimeZone.Text = "UTC" + (hours > 0 ? "+" : "-") + Math.Abs(hours).ToString();
            }
            catch { }
            this.radTimePicker1.Value = null;
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}
