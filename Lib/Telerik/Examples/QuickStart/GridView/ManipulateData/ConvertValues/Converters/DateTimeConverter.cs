using System;
using System.ComponentModel;
using System.Globalization;


namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
{
    public class DateTimeConverter : TypeConverter
    {
        #region Fields

        private Telerik.WinControls.UI.TimeZoneInfo timeZoneInfo = Telerik.WinControls.UI.TimeZoneInfo.Local;

        #endregion

        #region Properties

        public Telerik.WinControls.UI.TimeZoneInfo TimeZoneInfo
        {
            get
            {
                return this.timeZoneInfo;
            }
            set
            {
                if (value == null)
                {
                    this.timeZoneInfo = Telerik.WinControls.UI.TimeZoneInfo.Local;
                    return;
                }

                this.timeZoneInfo = value;
            }
        }

        #endregion

        #region Convert To Methods

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(DateTime) || destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value == null)
            {
                if (destinationType == typeof(DateTime))
                {
                    return DateTime.MinValue;
                }

                return String.Empty;
            }

            double doubleValue = (double)value;
            DateTime dateTime = DateTime.FromOADate(doubleValue);
            dateTime = Telerik.WinControls.UI.TimeZoneInfo.ConvertTimeFromUtc(dateTime, this.timeZoneInfo);

            if (destinationType == typeof(string))
            {
                return Convert.ToString(dateTime);
            }

            return dateTime;
        }

        #endregion

        #region Convert From Methods

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(DateTime);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value == null)
            {
                return 0;
            }

            DateTime dateTimeValue = (DateTime)value;
            dateTimeValue = Telerik.WinControls.UI.TimeZoneInfo.ConvertTimeToUtc(dateTimeValue, this.timeZoneInfo);
            return dateTimeValue.ToOADate();
        }

        #endregion
    }
}
