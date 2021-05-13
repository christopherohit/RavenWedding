using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.Scheduler.CustomWorkTime
{
    class MyTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(DateTime))
            {
                return true;
            }

            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is DateTime)
            {
                return ((DateTime)value).TimeOfDay;
            }

            return base.ConvertFrom(context, culture, value);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string) || destinationType == typeof(TimeSpan) || destinationType == typeof(DateTime))
            {
                return true;
            }

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && context is Telerik.WinControls.UI.GridDataCellElement)
            {
                Telerik.WinControls.UI.GridDataCellElement cell = (Telerik.WinControls.UI.GridDataCellElement)context;
                TimeSpan span = (TimeSpan)value;

                return span.Hours.ToString("00") + ":" + span.Minutes.ToString("00");
            }

            if (destinationType == typeof(TimeSpan))
            {
                return value;
            }

            if (destinationType == typeof(DateTime))
            {
                DateTime dt;
                if (DateTime.TryParse(value.ToString(), out dt))
                {
                    return dt;
                }
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}