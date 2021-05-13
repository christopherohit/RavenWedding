using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Telerik.Examples.WinControls.DataSources;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.MultiColumnComboBox.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        private string totalSumFormat = "<html>Total: <strong>{0}</strong></html>";
        private RadMultiColumnComboBoxSelectionExtender selectionExtender;
        private NorthwindDataSet.EmployeesRow selectedEmployee;
        private NorthwindDataSet.CustomersRow selectedCustomer;
        private int quantity = 1;

        public Form1()
        {
            InitializeComponent();

            this.SelectedProducts = new ObservableCollection<NorthwindDataSet.ProductsRow>();
            this.SelectedProducts.CollectionChanged += SelectedProducts_CollectionChanged;

            this.selectionExtender = new RadMultiColumnComboBoxSelectionExtender();
            this.selectionExtender.AssociatedRadMultiColumnComboBox = this.productsMultiColumnComboBox;
            this.selectionExtender.AutoCompleteBoxElement.Items.CollectionChanged += Items_CollectionChanged;
        }

        public NorthwindDataSet.EmployeesRow SelectedEmployee
        {
            get { return this.selectedEmployee; }
            set
            {
                this.selectedEmployee = value;
                this.CanExecuteSubmit();
            }
        }

        public NorthwindDataSet.CustomersRow SelectedCustomer
        {
            get { return this.selectedCustomer; }
            set
            {
                this.selectedCustomer = value;
                this.CanExecuteSubmit();
            }
        }

        public ObservableCollection<NorthwindDataSet.ProductsRow> SelectedProducts { get; set; }

        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                this.quantity = value;
                this.UpdateTotal();
                this.CanExecuteSubmit();
            }
        }

        public string TotalCost
        {
            get
            {
                decimal total = 0;
                foreach (NorthwindDataSet.ProductsRow product in this.SelectedProducts)
                {
                    total += product.UnitPrice * this.Quantity;
                }

                return total.ToString("C");
            }
        }

        private void SelectedProducts_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.UpdateTotal();
            this.CanExecuteSubmit();
        }

        private void Submit()
        {
            NorthwindDataSet.OrdersRow order = this.northwindDataSet.Orders.NewOrdersRow();
            order.CustomersRow = this.SelectedCustomer;
            order.EmployeesRow = this.SelectedEmployee;

            foreach (NorthwindDataSet.ProductsRow product in this.SelectedProducts)
            {
                NorthwindDataSet.Order_DetailsRow orderDetail = this.northwindDataSet.Order_Details.NewOrder_DetailsRow();
                orderDetail.ProductsRow = product;
                orderDetail.OrdersRow = order;
                orderDetail.Quantity = (short)this.Quantity;
                this.northwindDataSet.Order_Details.AddOrder_DetailsRow(orderDetail);
            }

            this.AddOrder(order);
            this.Clear();
        }

        private void AddOrder(NorthwindDataSet.OrdersRow order)
        {
            OrderInfoUserControl orderInfo = new OrderInfoUserControl();
            orderInfo.PopulateData(order);
            int count = this.openOrdersScrollablePanel.PanelContainer.Controls.Count;
            Point location = new Point((this.openOrdersScrollablePanel.Width - orderInfo.Width) / 2, count * (orderInfo.Height + 10) - this.openOrdersScrollablePanel.VerticalScrollbar.Value);
            this.openOrdersScrollablePanel.PanelContainer.Controls.Add(orderInfo);
            orderInfo.Location = location;
            if (this.openOrdersScrollablePanel.VerticalScrollbar.Visible)
            {
                this.openOrdersScrollablePanel.VerticalScrollbar.Value = this.openOrdersScrollablePanel.VerticalScrollbar.Maximum - this.openOrdersScrollablePanel.VerticalScrollbar.LargeChange;
            }
        }

        private void CanExecuteSubmit()
        {
            this.submitButton.Enabled = this.SelectedEmployee != null && this.SelectedCustomer != null && this.SelectedProducts.Count > 0 && this.Quantity > 0;
        }

        private void Clear()
        {
            this.SelectedCustomer = null;
            this.SelectedEmployee = null;
            this.employeeMultiColumnComboBox.SelectedItem = null;
            this.customerMultiColumnComboBox.SelectedItem = null;
            this.quantitySpinEditor.Value = 1;
            this.productsMultiColumnComboBox.MultiColumnComboBoxElement.Text = string.Empty;
            this.selectionExtender.AutoCompleteBoxElement.Clear();
            this.SelectedProducts.Clear();
            foreach (GridViewRowInfo item in this.selectionExtender.AssociatedRadMultiColumnComboBox.EditorControl.Rows)
            {
                item.Tag = null;
            }
        }

        private void SeedOrders()
        {
            NorthwindDataSet.OrdersRow order = this.northwindDataSet.Orders.NewOrdersRow();
            order.CustomersRow = this.northwindDataSet.Customers[0];
            order.EmployeesRow = this.northwindDataSet.Employees[0];

            IEnumerable<NorthwindDataSet.ProductsRow> products = this.northwindDataSet.Products.OfType<NorthwindDataSet.ProductsRow>().Take(3);
            foreach (NorthwindDataSet.ProductsRow product in products)
            {
                NorthwindDataSet.Order_DetailsRow orderDetail = this.northwindDataSet.Order_Details.NewOrder_DetailsRow();
                orderDetail.ProductsRow = product;
                orderDetail.OrdersRow = order;
                orderDetail.Quantity = 1;
                this.northwindDataSet.Order_Details.AddOrder_DetailsRow(orderDetail);
            }

            this.AddOrder(order);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            this.CenterControl(this.radPanel1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);

            this.SeedOrders();
            this.Clear();
        }

        private void UpdateTotal()
        {
            this.totalLabel.Text = string.Format(this.totalSumFormat, this.TotalCost);
        }

        private DataRowView GetDataRowView(GridViewRowInfo rowInfo)
        {
            if (rowInfo != null)
            {
                return rowInfo.DataBoundItem as DataRowView;
            }

            return null;
        }

        private void EmployeeMultiColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = this.GetDataRowView(this.employeeMultiColumnComboBox.SelectedItem as GridViewDataRowInfo);
            if (dataRow != null)
            {
                this.SelectedEmployee = dataRow.Row as NorthwindDataSet.EmployeesRow;
            }
        }

        private void CustomerMultiColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = this.GetDataRowView(this.customerMultiColumnComboBox.SelectedItem as GridViewDataRowInfo);
            if (dataRow != null)
            {
                this.SelectedCustomer = dataRow.Row as NorthwindDataSet.CustomersRow;
            }
        }

        private void Items_CollectionChanged(object sender, Telerik.WinControls.Data.NotifyCollectionChangedEventArgs e)
        {
            this.SelectedProducts.Clear();
            this.selectionExtender.UpdateItems(sender, e);
            foreach (GridViewRowInfo item in this.selectionExtender.AssociatedRadMultiColumnComboBox.EditorControl.Rows)
            {
                if (item.Tag != null && item.Tag.ToString() == Boolean.TrueString)
                {
                    DataRowView dataRow = this.GetDataRowView(item as GridViewDataRowInfo);
                    if (dataRow != null)
                    {
                        NorthwindDataSet.ProductsRow product = dataRow.Row as NorthwindDataSet.ProductsRow;
                        this.SelectedProducts.Add(product);
                    }
                }
            }
        }

        private void QuantitySpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.Quantity = (int)this.quantitySpinEditor.Value;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Submit();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}