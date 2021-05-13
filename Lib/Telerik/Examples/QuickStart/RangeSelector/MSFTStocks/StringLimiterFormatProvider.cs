using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.RangeSelector.MSFTStocks
{
    class StringLimiterFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string s = arg.ToString();
            if (s != null)
            {
                if (s.Length == 1)
                {
                    return "0";
                }

                return s.Remove(s.Length - 6);
            }
            else 
            {
                return null;
            }
        }
    }
}
