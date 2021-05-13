using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Charting;

namespace Telerik.Windows.Examples.GridView.FirstLook
{
    public partial class PerformanceChart : UserControl
    {
        public PerformanceChart()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(PerformanceChart_Loaded);
        }

        #region Methods
        private void PerformanceChart_Loaded(object sender, RoutedEventArgs e)
        {
            if (radChart.DataContext != null)
            {
                Employee employee = (Employee)radChart.DataContext;

                if (radChart.Series.Count == 0)
                {
					radChart.HorizontalAxis = new DateTimeCategoricalAxis () { LabelFormat = "dd/MM" };
					radChart.VerticalAxis = new LinearAxis() { LabelFormat = "C0" };


                    IEnumerable<Order> orders = (from o in employee.Orders
                                                  orderby o.OrderDate
                                                  select o).Skip(employee.Orders.Count() - 10);

					BarSeries series = new BarSeries();

                    foreach (Order order in orders)
                    {
                        CategoricalDataPoint dataPoint = new CategoricalDataPoint();
                        dataPoint.Value = (from orderDetail in order.Details
                                                     select orderDetail.Quantity * orderDetail.UnitPrice *
                                                         (1 - orderDetail.Discount)).Sum();
						dataPoint.Category = order.OrderDate;
                        series.DataPoints.Add(dataPoint);
                    }

                    radChart.Series.Add(series);
                }
            }
        }
        #endregion
    }
}
