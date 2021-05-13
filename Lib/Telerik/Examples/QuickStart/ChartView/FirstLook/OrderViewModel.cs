using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Telerik.Examples.WinControls.ChartView.FirstLook
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        #region Fields

        private List<OrderData> data;
        private List<OrdersByRegion> regions;

        private List<OrderData> ordersSnacks;
        private List<OrderData> ordersBeverages;

        private IEnumerable<OrderByMonth> barSnackData;
        private IEnumerable<OrderByMonth> barBeverageData;

        private IEnumerable<OrderByMonthTotalRange> lineStackData;
        private IEnumerable<OrderByMonthTotalRange> lineBeverageData;
        #endregion

        #region Constructor

        public OrderViewModel()
        {
            data = ParseData();
            GetDataCompleted();
        }
        #endregion

        #region Properties

        public IEnumerable<OrderByMonth> BarSnackData
        {
            get
            {
                return this.barSnackData;
            }
            private set
            {
                if (this.barSnackData == value)
                    return;

                this.barSnackData = value;
                this.OnPropertyChanged("BarSnackData");
            }
        }

        public IEnumerable<OrderByMonth> BarBeverageData
        {
            get
            {
                return this.barBeverageData;
            }
            private set
            {
                if (this.barBeverageData == value)
                    return;

                this.barBeverageData = value;
                this.OnPropertyChanged("BarBeverageData");
            }
        }

        public IEnumerable<OrderByMonthTotalRange> LineStackData
        {
            get
            {
                return this.lineStackData;
            }
            private set
            {
                if (this.lineStackData == value)
                    return;

                this.lineStackData = value;
                this.OnPropertyChanged("LineStackData");
            }
        }

        public IEnumerable<OrderByMonthTotalRange> LineBeverageData
        {
            get
            {
                return this.lineBeverageData;
            }
            private set
            {
                if (this.lineBeverageData == value)
                    return;

                this.lineBeverageData = value;
                this.OnPropertyChanged("LineBeverageData");
            }
        }

        public List<OrderData> Data
        {
            get
            {
                return this.data;
            }
            set
            {
                if (data != value)
                {
                    data = value;
                    OnPropertyChanged("Data");
                }
            }
        }

        public List<OrdersByRegion> Regions
        {
            get
            {
                return this.regions;
            }
            set
            {
                if (regions != value)
                {
                    regions = value;
                    OnPropertyChanged("Regions");
                }
            }
        }
        #endregion

        #region Methods

        string[] allRegions = new string[] { "Europe", "Asia", "North America", "Other" };
    
        protected void GetDataCompleted()
        {
            this.Regions = InitializeRegionData();

            ordersSnacks = SeparateOrdersByProducts("Snacks", this.Data);
            ordersBeverages = SeparateOrdersByProducts("Beverages", this.Data);

            this.BarSnackData = InitializeBarData(ordersSnacks);
            this.BarBeverageData = InitializeBarData(ordersBeverages);

            this.LineStackData = InitializeLineData(ordersSnacks);
            this.LineBeverageData = InitializeLineData(ordersBeverages);
        }

        private List<OrderData> SeparateOrdersByProducts(string productName, List<OrderData> data)
        {  
            List<OrderData> products = new List<OrderData>();

            foreach (OrderData item in data)
            {
                if (item.Product == productName)
                {
                    products.Add(item);
                }
            }
            return products;
        }

        private List<OrdersByRegion> InitializeRegionData()
        {
            List<OrdersByRegion> regions = new List<OrdersByRegion>();

            foreach (string region in allRegions)
            {
                OrdersByRegion ov = new OrdersByRegion(region);

                foreach (OrderData order in this.Data)
                {
                    if (order.Region == region)
                        ov.Data.Add(order);
                }
                regions.Add(ov);
            }

            return regions;
        }

        private List<OrderByMonthTotalRange> InitializeLineData(List<OrderData> products)
        {
            List<OrderByMonthTotalRange> productsByMonths = new List<OrderByMonthTotalRange>();
            for (int i = 0; i < 12; i++)
            {
                string month = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(i + 1);
                productsByMonths.Add(new OrderByMonthTotalRange(month));
            }

            foreach (OrderData item in products)
            {
                productsByMonths[item.Date.Month - 1].Data.Add(item);
            }
            return productsByMonths;
        }

        private List<OrderByMonth> InitializeBarData(List<OrderData> products)
        {
            List<OrderByMonth> productsByMonths = new List<OrderByMonth>();
            for (int i = 0; i < 12; i++)
            {
                string month = DateTimeFormatInfo.InvariantInfo.GetAbbreviatedMonthName(i + 1);
                productsByMonths.Add(new OrderByMonth(month));
            }

            foreach (OrderData item in products)
            {
                productsByMonths[item.Date.Month - 1].Data.Add(item);
            }
            return productsByMonths;
        }

        protected List<OrderData> ParseData()
        {
            List<OrderData> chartData = new List<OrderData>();

            char[] delimiter = { '\r', '\n' };
            string fileContents = Properties.Resources.Dashboard;
            string[] lines = fileContents.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                string[] data = line.Split(',');

                OrderData newOrderData = new OrderData();
                newOrderData.Date = DateTime.Parse(data[0], CultureInfo.InvariantCulture);
                newOrderData.Amount = int.Parse(data[1], CultureInfo.InvariantCulture);
                newOrderData.Target = int.Parse(data[2], CultureInfo.InvariantCulture);
                newOrderData.Product = data[3].Trim();
                newOrderData.Country = data[4].Trim();
                newOrderData.Region = data[5].Trim();
                chartData.Add(newOrderData);
            }

            return chartData;
        }

        #endregion

        #region Impl

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
