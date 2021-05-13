using System;

namespace Telerik.Examples.WinControls.ChartView.Printing
{
    public class LineAreaSeriesData
    {
        private string month;
        private double expense;

        public LineAreaSeriesData(double expense, string month)
        {
            this.expense = expense;
            this.month = month;
        }

        public string Month
        {
            get
            {
                return this.month;
            }
        }

        public double Expense
        {
            get
            {
                return this.expense;
            }
        }
    }
}
