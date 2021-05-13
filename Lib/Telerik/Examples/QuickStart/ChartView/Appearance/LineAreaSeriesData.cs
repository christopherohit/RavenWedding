using System;

namespace Telerik.Examples.WinControls.ChartView.Appearance
{
    public class LineAreaSeriesData
    {
        private string month;
        private double profit;

        public LineAreaSeriesData(double profit, string month)
        {
            this.profit = profit;
            this.month = month;
        }

        public string Month
        {
            get
            {
                return this.month;
            }
        }

        public double Profit
        {
            get
            {
                return this.profit;
            }
        }
    }
}
