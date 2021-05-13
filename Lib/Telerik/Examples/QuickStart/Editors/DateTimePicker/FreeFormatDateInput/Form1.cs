using System;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.DateTimePicker.FreeFormatDateInput
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private ErrorProvider errorProvider;

        public Form1()
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();

            this.SetupEditors();
            this.LoadCultureInfos();

        }

        private void SetupEditors()
        {
            this.radDateTimePicker2.Value = new DateTime(DateTime.Now.Year -100, DateTime.Now.Month, DateTime.Now.Day,0,0,0);
            this.radDateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.radDateTimePicker2.CustomFormat = "MMM - dd - yyyy hh:mm tt";
            (this.radDateTimePicker2.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).ShowTimePicker = true;
            (this.radDateTimePicker2.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new System.Drawing.Size(300, 250);
            (this.radDateTimePicker2.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).Calendar.HeaderNavigationMode = HeaderNavigationMode.Zoom;

            this.radDateTimePicker3.Value = new DateTime(DateTime.Now.Year + 100, DateTime.Now.Month, DateTime.Now.Day,23, 59, 59);
            this.radDateTimePicker3.Format = DateTimePickerFormat.Custom;
            this.radDateTimePicker3.CustomFormat = "MMM - dd - yyyy hh:mm tt";
            (this.radDateTimePicker3.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).ShowTimePicker = true;
            (this.radDateTimePicker3.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).DropDownMinSize = new System.Drawing.Size(300, 250);
            (this.radDateTimePicker3.DateTimePickerElement.CurrentBehavior as RadDateTimePickerCalendar).Calendar.HeaderNavigationMode = HeaderNavigationMode.Zoom;


            this.radMaskedEditBox1.Value = DateTime.Now;
            (this.radMaskedEditBox1.MaskedEditBoxElement.Provider as FreeFormDateTimeProvider).MinDate = this.radDateTimePicker2.Value;
            (this.radMaskedEditBox1.MaskedEditBoxElement.Provider as FreeFormDateTimeProvider).MaxDate = this.radDateTimePicker3.Value;
            (this.radMaskedEditBox1.MaskedEditBoxElement.Provider as FreeFormDateTimeProvider).ParsingDateTime += new ParsingDateTimeEventHandler(Form1_ParsingDateTime);

            this.radDateTimePicker1.Value = DateTime.Now;
            this.radDateTimePicker1.MinDate = this.radDateTimePicker2.Value;
            this.radDateTimePicker1.MaxDate = this.radDateTimePicker3.Value;
            this.radDateTimePicker1.DateTimePickerElement.TextBoxElement.MaskType = MaskType.FreeFormDateTime;
            (this.radDateTimePicker1.DateTimePickerElement.TextBoxElement.Provider as FreeFormDateTimeProvider).ParsingDateTime+=new ParsingDateTimeEventHandler(Form1_ParsingDateTime);

            this.radTimePicker1.Value = DateTime.Now;
            this.radTimePicker1.TimePickerElement.MaskedEditBox.MaskType = MaskType.FreeFormDateTime;
            this.radTimePicker1.TimePickerElement.MinValue = this.radDateTimePicker2.Value;
            this.radTimePicker1.TimePickerElement.MaxValue = this.radDateTimePicker3.Value;
            (this.radTimePicker1.TimePickerElement.MaskedEditBox.Provider as FreeFormDateTimeProvider).ParsingDateTime+=new ParsingDateTimeEventHandler(Form1_ParsingDateTime);

        }

        void Form1_ParsingDateTime(object sender, ParsingDateTimeEventArgs e)
        {
            Control control = ((Telerik.WinControls.UI.MaskDateTimeProvider)(sender)).Owner.ElementTree.Control;

            if (e.Result == null)
            {
                this.errorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
                this.errorProvider.SetIconPadding(control, 2);
                this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
                this.errorProvider.SetError(control, "Invalid Input");

                e.Cancel = true;
            }         
            else 
            {
                this.errorProvider.SetError(control, "");
            }
        }

        private void LoadCultureInfos()
        {
            SortedList cultures = new SortedList();

            CultureInfo temp;
            for (int i = 0; i < CultureInfo.GetCultures(CultureTypes.SpecificCultures).Length; i++)
            {
                temp = CultureInfo.GetCultures(CultureTypes.SpecificCultures)[i];

                if (!cultures.ContainsKey(temp.EnglishName))
                {
                    cultures.Add(temp.EnglishName, temp);
                }
            }

            IEnumerator ie = cultures.Keys.GetEnumerator();
            while (ie.MoveNext())
            {
                string name = (string)ie.Current;
                this.radComboCultures.Items.Add(new RadListDataItem(name, cultures[name]/*.ToString()*/));
            }

            radComboCultures.SelectedItem = radComboCultures.Items[radComboCultures.FindStringExact(CultureInfo.CurrentCulture.EnglishName)];
        }

        protected override void WireEvents()
        {
            this.radDateTimePicker2.Validated += new EventHandler(radDateTimePicker2_Validated);
            this.radDateTimePicker3.Validated += new EventHandler(radDateTimePicker3_Validated);
            this.radComboCultures.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(CulturesList_SelectedIndexChanged);
        }

        void radDateTimePicker3_Validated(object sender, EventArgs e)
        {
            (this.radMaskedEditBox1.MaskedEditBoxElement.Provider as FreeFormDateTimeProvider).MaxDate = this.radDateTimePicker3.Value;
            this.radDateTimePicker1.MaxDate = this.radDateTimePicker3.Value;
            this.radTimePicker1.TimePickerElement.MaxValue = this.radDateTimePicker3.Value;
        }

        void radDateTimePicker2_Validated(object sender, EventArgs e)
        {
            (this.radMaskedEditBox1.MaskedEditBoxElement.Provider as FreeFormDateTimeProvider).MinDate = this.radDateTimePicker2.Value;
            this.radDateTimePicker1.MinDate = this.radDateTimePicker2.Value;
            this.radTimePicker1.TimePickerElement.MinValue = this.radDateTimePicker2.Value;
        }

        void CulturesList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            CultureInfo culture = radComboCultures.SelectedValue as CultureInfo;
            this.radMaskedEditBox1.Culture = culture;
            this.radDateTimePicker1.Culture = culture;
            this.radTimePicker1.Culture = culture;
        }
    }
}