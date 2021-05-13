using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Scatter
{
    public class HourlyEarnings
    {
        private string sector;
        private double wage;
        private int age;

        public HourlyEarnings(string sector, double wage, int age)
        {
            this.sector = sector;
            this.wage = wage;
            this.age = age;
        }

        public string Sector
        {
            get { return this.sector; }
        }

        public double Wage
        {
            get { return this.wage; }
        }

        public int Age
        {
            get { return this.age; }
        }
    }
}
