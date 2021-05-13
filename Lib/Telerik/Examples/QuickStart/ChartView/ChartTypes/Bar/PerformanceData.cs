
namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
{
    public class PerformanceData
    {
        private string quarter;
        private string name;
        private double performance;

        public PerformanceData(string name, string quarter, double performance)
        {
            this.name = name;
            this.quarter = quarter;
            this.performance = performance;
        }

        public string QuarterName
        {
            get
            {
                return this.quarter;
            }
        }

        public string RepresentativeName
        {
            get
            {
                return this.name;
            }
        }

        public double Performance
        {
            get
            {
                return this.performance;
            }
        }
    }
}
