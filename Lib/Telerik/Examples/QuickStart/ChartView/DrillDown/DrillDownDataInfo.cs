using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.ChartView.DrillDown
{
    public class DrillDownDataInfo : INotifyPropertyChanged
    {
        double value;
        DateTime date;

        public DrillDownDataInfo(DateTime date, double value)
        {
            this.date = date;
            this.value = value;
        }

        public double Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
                this.OnPropertyChanged("Value");
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
                this.OnPropertyChanged("Date");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
