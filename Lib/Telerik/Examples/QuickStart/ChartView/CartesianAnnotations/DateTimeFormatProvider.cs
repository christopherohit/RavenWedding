using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
{
    public class DateTimeFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            DateTime val = (DateTime)arg;

            if (val.Month == 1)
            {
                return val.ToString("MMM") + Environment.NewLine + val.Year;
            }
            else
            {
                return val.ToString("MMM");
            }
        }
    }
}
