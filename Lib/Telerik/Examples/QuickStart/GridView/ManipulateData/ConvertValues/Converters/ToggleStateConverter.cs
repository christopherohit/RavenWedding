using System;
using System.ComponentModel;
using System.Globalization;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
{
    public class ToggleStateConverter : TypeConverter
    {
        #region Convert To Methods

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(ToggleState);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            char charValue = (char)value;

            switch (charValue)
            {
                case 'Y':
                    return ToggleState.On;
                case 'N':
                    return ToggleState.Off;
                case 'M':
                case '\0':
                    return ToggleState.Indeterminate;
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        #endregion

        #region Convert From Methods

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(ToggleState);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            ToggleState state = (ToggleState)value;

            switch (state)
            {
                case ToggleState.On:
                    return 'Y';
                case ToggleState.Off:
                    return 'N';
                case ToggleState.Indeterminate:
                    return 'M';
            }

            return base.ConvertFrom(context, culture, value);
        }

        #endregion
    }
}
