using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;


namespace Telerik.Examples.WinControls.ChartView.DrillDown
{
    public class DrillDownViewModel : INotifyPropertyChanged
    {
        BindingList<DrillDownDataInfo> data;

        public DrillDownViewModel()
        {
            data = ParseDataByYear();
        }

        public BindingList<DrillDownDataInfo> Data
        {
            get
            {
                return data;
            }
            set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.OnPropertyChanged("Data");
                }
            }
        }

        internal static BindingList<DrillDownDataInfo> ParseDataByYear()
        {
            BindingList<DrillDownDataInfo> chartData = new BindingList<DrillDownDataInfo>();
            char[] separator = { '\r', '\n' };
            string fileContents = Properties.Resources.DJIA;
            string[] lines = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string line in lines)
            {
                if (count++ > 10)///top 10
                    break;

                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');
                DrillDownDataInfo dataItem = new DrillDownDataInfo(
                    DateTime.Parse(data[0], CultureInfo.InvariantCulture),
                    double.Parse(data[1], CultureInfo.InvariantCulture)
                    );                    
                

                chartData.Add(dataItem);
            }

            return chartData;
        }

        internal static BindingList<DrillDownDataInfo> ParseDataByMonth(int year)
        {
            BindingList<DrillDownDataInfo> chartData = new BindingList<DrillDownDataInfo>();
            char[] separator = { '\r', '\n' };
            string fileContents = Properties.Resources.DJIAM;
            string[] lines = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');
                DateTime date = DateTime.Parse(data[0], CultureInfo.InvariantCulture);
                if (date.Year == year)
                {

                    DrillDownDataInfo dataItem = new DrillDownDataInfo(
                        date,
                        double.Parse(data[1], CultureInfo.InvariantCulture)
                        );


                    chartData.Add(dataItem);
                }
            }

            return chartData;
        }

        internal static BindingList<DrillDownDataInfo> ParseDataByDay(int year, int month)
        {
            BindingList<DrillDownDataInfo> chartData = new BindingList<DrillDownDataInfo>();
            char[] separator = { '\r', '\n' };
            string fileContents = Properties.Resources.DJIAD;
            string[] lines = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');
                DateTime date = DateTime.Parse(data[0], CultureInfo.InvariantCulture);
                if (date.Year == year && date.Month == month && !string.IsNullOrEmpty(data[1]))
                {
                    
                    DrillDownDataInfo dataItem = new DrillDownDataInfo(
                        date,
                        double.Parse(data[1], CultureInfo.InvariantCulture)
                        );


                    chartData.Add(dataItem);
                }
            }

            return chartData;
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
