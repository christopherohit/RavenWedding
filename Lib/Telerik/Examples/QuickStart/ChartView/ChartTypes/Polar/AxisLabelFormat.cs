using System;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Polar
{
    public class AxisLabelFormat : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }

            return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            double value;

            if (double.TryParse(arg.ToString(), out value))
            {
                return string.Format("-{0}dB", 25 * (1 - value));
            }

            return String.Empty;
        }
    }
}
