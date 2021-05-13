using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.Charting;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
{
    public class PerformanceModel : INotifyPropertyChanged
    {
        private IEnumerable<PerformanceData> q1;
        private IEnumerable<PerformanceData> q2;
        private IEnumerable<PerformanceData> q3;
        private IEnumerable<PerformanceData> q4;

        private ChartSeriesCombineMode barCombineMode = ChartSeriesCombineMode.Cluster;
        private Orientation chartOrientation = Orientation.Vertical;
        private bool isShowLabelsEnabled = true;
        private bool showLabels = false;

        private double gapLength = 0.2d;
        private double axisMaxValue = 20000d;
        private double axisStep = 5000d;
        private string axisTitle = "PROFIT (USD)";
        private string axisLabelFormat = "N0";

        public PerformanceModel()
        {
        }

        public IEnumerable<PerformanceData> Q1
        {
            get
            {
                if (this.q1 == null)
                {
                    this.q1 = new List<PerformanceData>() {
                        new PerformanceData("Jason Harley", "Q1, 2010", 17790),
                        new PerformanceData("Adam White", "Q1, 2010", 12820),
                        new PerformanceData("Barbara Smith", "Q1, 2010", 14350),
                        new PerformanceData("Susan Jones", "Q1, 2010", 11150),
                        new PerformanceData("Tom Marshall", "Q1, 2010", 11800)
                    };
                }

                return this.q1;
            }
        }

        public IEnumerable<PerformanceData> Q2
        {
            get
            {
                if (this.q2 == null)
                {
                    this.q2 = new List<PerformanceData>(){
                        new PerformanceData("Jason Harley", "Q2, 2010", 15320),
                        new PerformanceData("Adam White", "Q2, 2010", 14100),
                        new PerformanceData("Barbara Smith", "Q2, 2010", 13000),
                        new PerformanceData("Susan Jones", "Q2, 2010", 8850),
                        new PerformanceData("Tom Marshall", "Q2, 2010", 10900)
                    };
                }

                return this.q2;
            }
        }

        public IEnumerable<PerformanceData> Q3
        {
            get
            {
                if (this.q3 == null)
                {
                    this.q3 = new List<PerformanceData>(){
                        new PerformanceData("Jason Harley", "Q3, 2010", 13800),
                        new PerformanceData("Adam White", "Q3, 2010", 12300),
                        new PerformanceData("Barbara Smith", "Q3, 2010", 14900),
                        new PerformanceData("Susan Jones", "Q3, 2010", 10100),
                        new PerformanceData("Tom Marshall", "Q3, 2010", 8700)
                    };
                }

                return this.q3;
            }
        }

        public IEnumerable<PerformanceData> Q4
        {
            get
            {
                if (this.q4 == null)
                {
                    this.q4 = new List<PerformanceData>(){
                        new PerformanceData("Jason Harley", "Q4, 2010", 15850),
                        new PerformanceData("Adam White", "Q4, 2010", 11200),
                        new PerformanceData("Barbara Smith", "Q4, 2010", 14000),
                        new PerformanceData("Susan Jones", "Q4, 2010", 7500),
                        new PerformanceData("Tom Marshall", "Q4, 2010", 10000)
                    };
                }

                return this.q4;
            }
        }

        public IEnumerable<PerformanceData> GetData(int index)
        {
            if (index == 0)
            {
                return this.Q1;
            }

            if (index == 1)
            {
                return this.Q2;
            }

            if (index == 2)
            {
                return this.Q3;
            }

            if (index == 3)
            {
                return this.Q4;
            }

            return null;
        }

        public ChartSeriesCombineMode BarCombineMode
        {
            get
            {
                return this.barCombineMode;
            }
            set
            {
                if (this.barCombineMode != value)
                {
                    this.barCombineMode = value;
                    this.OnPropertyChanged("BarCombineMode");

                    this.UpdateLabelsConfiguration(this.barCombineMode);
                    this.UpdateAxisConfiguration(this.barCombineMode);
                }
            }
        }

        public bool ShowLabels
        {
            get
            {
                return this.showLabels;
            }
            set
            {
                if (this.showLabels != value)
                {
                    this.showLabels = value;
                    this.OnPropertyChanged("ShowLabels");
                }
            }
        }

        public bool IsShowLabelsEnabled
        {
            get
            {
                return this.isShowLabelsEnabled;
            }
            set
            {
                if (this.isShowLabelsEnabled != value)
                {
                    this.isShowLabelsEnabled = value;
                    this.OnPropertyChanged("IsShowLabelsEnabled");
                }
            }
        }

        public Orientation ChartOrientation
        {
            get
            {
                return this.chartOrientation;
            }
            set
            {
                if (this.chartOrientation != value)
                {
                    this.chartOrientation = value;
                    this.OnPropertyChanged("ChartOrientation");
                }
            }
        }

        public double GapLength
        {
            get
            {
                return this.gapLength;
            }
            set
            {
                if (this.gapLength != value)
                {
                    this.gapLength = value;
                    this.OnPropertyChanged("GapLength");
                }
            }
        }

        public double AxisMaxValue
        {
            get
            {
                return this.axisMaxValue;
            }
            set
            {
                if (this.axisMaxValue != value)
                {
                    this.axisMaxValue = value;
                    this.OnPropertyChanged("AxisMaxValue");
                }
            }
        }

        public double AxisStep
        {
            get
            {
                return this.axisStep;
            }
            set
            {
                if (this.axisStep != value)
                {
                    this.axisStep = value;
                    this.OnPropertyChanged("AxisStep");
                }
            }
        }

        public string AxisTitle
        {
            get
            {
                return this.axisTitle;
            }
            set
            {
                if (this.axisTitle != value)
                {
                    this.axisTitle = value;
                    this.OnPropertyChanged("AxisTitle");
                }
            }
        }

        public string AxisLabelFormat
        {
            get
            {
                return this.axisLabelFormat;
            }
            set
            {
                if (this.axisLabelFormat != value)
                {
                    this.axisLabelFormat = value;
                    this.OnPropertyChanged("AxisLabelFormat");
                }
            }
        }

        private void UpdateLabelsConfiguration(ChartSeriesCombineMode mode)
        {
            this.ShowLabels = false;
            this.IsShowLabelsEnabled = mode == ChartSeriesCombineMode.Cluster;
        }

        private void UpdateAxisConfiguration(ChartSeriesCombineMode mode)
        {
            if (mode == ChartSeriesCombineMode.Cluster)
            {
                this.GapLength = 0.2d;

                this.AxisMaxValue = 20000d;
                this.AxisStep = 5000d;

                this.AxisTitle = "PROFIT (USD)";
                this.AxisLabelFormat = "N0";
            }
            else if (mode == ChartSeriesCombineMode.Stack)
            {
                this.GapLength = 0.5d;

                this.AxisMaxValue = 70000d;
                this.AxisStep = 16500d;

                this.AxisTitle = "PROFIT (USD)";
                this.AxisLabelFormat = "N0";
            }
            else if (mode == ChartSeriesCombineMode.Stack100)
            {
                this.GapLength = 0.5d;

                this.AxisMaxValue = 1d;
                this.AxisStep = 0.25d;

                this.AxisTitle = "PROFIT (%)";
                this.AxisLabelFormat = "P0";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
