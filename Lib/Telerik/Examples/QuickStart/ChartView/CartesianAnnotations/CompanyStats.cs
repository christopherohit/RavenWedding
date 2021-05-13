using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
{
    public class CompanyStats
    {
        private string name;
        private DateTime date;
        private double value;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
