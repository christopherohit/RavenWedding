using System.Linq;
using System.Windows.Forms;
using Telerik.Examples.WinControls.DataSources;

namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
{
    public partial class OrderInfoUserControl : UserControl
    {
        public OrderInfoUserControl()
        {
            InitializeComponent();
        }

        public void PopulateData(NorthwindDataSet.OrdersRow order)
        {
            this.firstNameLabel.Text = order.EmployeesRow.FirstName;
            this.lastNameLabel.Text = order.EmployeesRow.LastName;
            this.initialsLabel.Text = this.firstNameLabel.Text.ToUpper()[0].ToString() + this.lastNameLabel.Text.ToUpper()[0].ToString();
            this.customerLabel.Text = order.CustomersRow.ContactName;
            this.productCountLabel.Text = order.GetOrder_DetailsRows().Count().ToString();
        }
    }
}