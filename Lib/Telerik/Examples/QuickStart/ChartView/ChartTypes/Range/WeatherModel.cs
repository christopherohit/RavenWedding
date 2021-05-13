using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Range
{
    public class WeatherModel : INotifyPropertyChanged
    {
        public WeatherModel()
        { }

        public IEnumerable<WeatherData> GetTemperatureData()
        {
            return new List<WeatherData>()
			{
				new WeatherData(new DateTime(2011, 1, 1), -14, 12),
				new WeatherData(new DateTime(2011, 2, 1), -9, 19),
				new WeatherData(new DateTime(2011, 3, 1), -7, 25),
				new WeatherData(new DateTime(2011, 4, 1), 2, 28),
				new WeatherData(new DateTime(2011, 5, 1), 8, 32),
				new WeatherData(new DateTime(2011, 6, 1), 13, 35),
				new WeatherData(new DateTime(2011, 7, 1), 17, 40),
				new WeatherData(new DateTime(2011, 8, 1), 15, 34),
				new WeatherData(new DateTime(2011, 9, 1), 11, 30),
				new WeatherData(new DateTime(2011, 10, 1), 1, 29),
				new WeatherData(new DateTime(2011, 11, 1), 2, 21),
				new WeatherData(new DateTime(2011, 12, 1), -1, 17),
				new WeatherData(new DateTime(2012, 1, 1), -11, 17),
				new WeatherData(new DateTime(2012, 2, 1), -7, 17),
				new WeatherData(new DateTime(2012, 3, 1), -4, 25),
				new WeatherData(new DateTime(2012, 4, 1), 3, 31),
				new WeatherData(new DateTime(2012, 5, 1), 9, 32),
				new WeatherData(new DateTime(2012, 6, 1), 11, 34),
				new WeatherData(new DateTime(2012, 7, 1), 16, 38),
				new WeatherData(new DateTime(2012, 8, 1), 16, 33),
				new WeatherData(new DateTime(2012, 9, 1), 12, 33),
				new WeatherData(new DateTime(2012, 10, 1), 3, 26),
				new WeatherData(new DateTime(2012, 11, 1), -1, 19),
				new WeatherData(new DateTime(2012, 12, 1), -2, 17),
			};
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
