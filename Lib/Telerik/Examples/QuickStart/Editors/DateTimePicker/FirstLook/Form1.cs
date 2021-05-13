using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.DateTimePicker.FirstLook
{

    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radDateTimePicker1;

            this.radDateTimePicker3.DateTimePickerElement.ShowCurrentTime = false;
            this.radDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker3.Culture = new System.Globalization.CultureInfo("en-US");
            this.radDateTimePicker3.CustomFormat = "hh:mm:ss tt";
            this.radRadio12Hours.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            // by default en-CA culture has AM/PM time format, so the timepicker can have correct hour scales
            this.radDateTimePicker4.Culture = new System.Globalization.CultureInfo("en-CA");
            this.radDateTimePicker4.Format = DateTimePickerFormat.Custom;
            this.radDateTimePicker4.CustomFormat = "MMM - dd - yyyy hh:mm tt";
            (this.radDateTimePicker4.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).ShowTimePicker = true;
            (this.radDateTimePicker4.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new System.Drawing.Size(330, 250);

            this.radDateTimePicker6.Culture = PersianCultureHelper.GetFixedPersianCulture();

            foreach (Control control in this.doubleBufferedTableLayoutPanel1.Controls)
            {
                if (control is RadLabel)
                {
                    control.Anchor = AnchorStyles.Right;
                }
                else
                {
                    control.Anchor = AnchorStyles.Left;
                }
             
            }
        }

        protected override void WireEvents()
        {
            this.radBtnClearAll.Click += new System.EventHandler(this.radButton1_Click);
            this.radRadio24Hours.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadRadioHourFormat_ToggleStateChanged);
            this.radRadio12Hours.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadRadioHourFormat_ToggleStateChanged);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radDateTimePicker1.SetToNullValue();
            this.radDateTimePicker2.SetToNullValue();
            this.radDateTimePicker3.SetToNullValue();
            this.radDateTimePicker4.SetToNullValue();
            this.radDateTimePicker5.SetToNullValue();
            this.radDateTimePicker6.SetToNullValue();
            this.radDateTimePicker7.SetToNullValue();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radDateTimePicker1.Value = DateTime.Now;
            this.radDateTimePicker2.Value = DateTime.Now;
            this.radDateTimePicker3.Value = DateTime.Now;
            this.radDateTimePicker4.Value = DateTime.Now;
            this.radDateTimePicker5.Value = DateTime.Now;
            this.radDateTimePicker6.Value = DateTime.Now;
            this.radDateTimePicker7.Value = DateTime.Now;
        }

        private void OnRadRadioHourFormat_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-CA");
            if (this.radRadio12Hours.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radDateTimePicker3.CustomFormat = "hh:mm:ss  tt";
                this.radDateTimePicker4.CustomFormat = "MMM - dd - yyyy hh:mm tt";
                (this.radDateTimePicker4.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new System.Drawing.Size(330, 250);
                (this.radDateTimePicker4.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMaxSize = new System.Drawing.Size(330, 250);
            }
            else
            {
                System.Globalization.DateTimeFormatInfo dateTimeFormat = new System.Globalization.DateTimeFormatInfo();
                dateTimeFormat.AMDesignator = string.Empty;
                dateTimeFormat.PMDesignator = string.Empty;
                culture.DateTimeFormat = dateTimeFormat;
                (this.radDateTimePicker4.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new System.Drawing.Size(330, 320);
                (this.radDateTimePicker4.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMaxSize = new System.Drawing.Size(330, 320);
                this.radDateTimePicker3.CustomFormat = "HH:mm:ss";
                this.radDateTimePicker4.CustomFormat = "MMM - dd - yyyy HH:mm";
            }

            this.radDateTimePicker4.Culture = culture;
        }
    }
}