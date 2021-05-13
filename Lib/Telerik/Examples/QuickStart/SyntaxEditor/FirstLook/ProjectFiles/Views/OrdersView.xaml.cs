using System.Windows.Controls;
using Telerik.Windows.Controls;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace Telerik.Windows.Examples.GridView.FirstLook
{
    public partial class OrdersView : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersView"/>.
        /// </summary>
        public OrdersView()
        {
            InitializeComponent();

            Expression<Func<Order, double>> expression = order => (from orderDetail in order.Details
                                                                              select orderDetail.Quantity * orderDetail.UnitPrice *
                                                                                  (1 - orderDetail.Discount)).Sum();
            GridViewExpressionColumn column = this.RadGridView1.Columns["TotalValue"] as GridViewExpressionColumn;
            column.Expression = expression;
        }
    }
}
