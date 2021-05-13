using System;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Range
{
    public class WeatherData
    {
        private DateTime time;
        private double low;
        private double high;

        public WeatherData(DateTime time, double low, double high)
        {
            this.time = time;
            this.low = low;
            this.high = high;
        }

        public DateTime Time
        {
            get { return time; }
        }

        public double Low
        {
            get { return low; }
        }

        public double High
        {
            get { return high; }
        }
    }
}
