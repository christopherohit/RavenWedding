using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.StockSeries
{
    public class CandlestickViewModel : INotifyPropertyChanged
    {
        BindingList<CandleDataInfo> data;

        public CandlestickViewModel()
        {
            data = ParseData();
        }

        public BindingList<CandleDataInfo> Data
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

        internal static BindingList<CandleDataInfo> ParseData()
        {
            BindingList<CandleDataInfo> chartData = new BindingList<CandleDataInfo>();
            char[] separator = { '\r', '\n' };
            string fileContents = Properties.Resources.OhlcData;
            string[] lines = fileContents.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');
                CandleDataInfo dataItem = new CandleDataInfo()
                {
                    Date = DateTime.Parse(data[0], CultureInfo.InvariantCulture),
                    Open = double.Parse(data[1], CultureInfo.InvariantCulture),
                    High = double.Parse(data[2], CultureInfo.InvariantCulture),
                    Low = double.Parse(data[3], CultureInfo.InvariantCulture),
                    Close = double.Parse(data[4], CultureInfo.InvariantCulture)
                };

                chartData.Add(dataItem);
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
