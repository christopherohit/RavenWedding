using System;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.ChartView.FirstLook
{
    public class OrderData
    {
        private double amount;
        private string country;
        private DateTime date;
        private string productName;
        private string region;
        private double target;

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public double PercentTarget
        {
            get
            {
                return this.Amount / this.Target;
            }
        }

        public string Product
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        public double Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
            }
        }
    }

    public abstract class OrderView
    {
        private List<OrderData> data;

        public OrderView()
        {
            data = new List<OrderData>();
        }

        public virtual double Value
        {
            get
            {
                double Value = 0;
                foreach (OrderData order in data)
                {
                    Value += order.Amount;
                }
                return Value;
            }
        }

        public List<OrderData> Data
        {
            get
            {
                return this.data;
            }
        }

    }

    public class OrderByMonth : OrderView
    {
        private string month;

        public OrderByMonth(string month)
            : base()
        {
            this.month = month;
        }

        public string Month
        {
            get
            {
                return this.month;
            }
        }
    }

    public class OrderByMonthTotalRange : OrderByMonth
    {
        public OrderByMonthTotalRange(string month)
            : base(month)
        { }

        public override double Value
        {
            get
            {
                double value = 0;
                foreach (OrderData order in Data)
                {
                    value += order.PercentTarget;
                }
                return value;
            }
        }
    }

    public class OrdersByRegion : OrderView
    {
        private string name;

        public OrdersByRegion(string name)
            : base()
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}
