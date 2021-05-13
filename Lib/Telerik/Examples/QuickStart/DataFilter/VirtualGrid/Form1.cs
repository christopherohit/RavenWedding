using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DataFilter.VirtualGrid
{
    public partial class Form1 : ExamplesForm
    {
        private readonly string selectCommand = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
        private readonly string selectProductNameCommand = "SELECT ProductID, ProductName FROM Products";
        private string[] columnNames = new string[] { "Order Id", "Product Id", "Unit Price", "Quantity", "Discount" };
        private List<OrderDetail> data = new List<OrderDetail>();
        private Dictionary<int, string> productNames = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();

            this.radChartView1.View.Margin = new Padding(10, 10, 0, 20);
            this.radChartView1.ShowTitle = true;
            this.radChartView1.Title = "Product Sales";
            this.radChartView1.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter;
            this.radChartView1.ChartElement.TitleElement.Font = new Font("SegoeUI", 16f);
            this.radChartView1.ChartElement.TitleElement.Padding = new Padding(0, 10, 0, 0);

            this.radVirtualGrid1.ColumnCount = columnNames.Length;
            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.AllowDelete = false;
            this.radVirtualGrid1.AllowEdit = false;
            this.radVirtualGrid1.AllowRowResize = true;
            this.radVirtualGrid1.AllowColumnResize = true;
            this.radVirtualGrid1.AllowFiltering = false;
            this.radVirtualGrid1.CellValueNeeded += radVirtualGrid1_CellValueNeeded;

            this.radDataFilter1.AllowDragDrop = false;

            this.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill;

            DataFilterDescriptorItem descriptor1 = new DataFilterDescriptorItem("OrderId", typeof(int));
            DataFilterDescriptorItem descriptor2 = new DataFilterDescriptorItem("ProductId", typeof(int));
            DataFilterDescriptorItem descriptor3 = new DataFilterDescriptorItem("UnitPrice", typeof(decimal));
            DataFilterDescriptorItem descriptor4 = new DataFilterDescriptorItem("Quantity", typeof(short));
            DataFilterDescriptorItem descriptor5 = new DataFilterDescriptorItem("Discount", typeof(float));

            this.radDataFilter1.Descriptors.Add(descriptor1);
            this.radDataFilter1.Descriptors.Add(descriptor2);
            this.radDataFilter1.Descriptors.Add(descriptor3);
            this.radDataFilter1.Descriptors.Add(descriptor4);
            this.radDataFilter1.Descriptors.Add(descriptor5);

            this.radDataFilter1.Expression = "[UnitPrice] > 10 AND [Quantity] > 20";

            this.radDataFilter1.NodeRemoved += radDataFilter1_NodeRemoved;
            this.radDataFilter1.Edited += radDataFilter1_Edited;
            this.radDataFilter1.DragEnded += radDataFilter1_DragEnded;

            this.FillProductNames();
            this.SelectData();
            radChartView1.BackColor = Color.White;
        }
      
        void radDataFilter1_DragEnded(object sender, RadTreeViewDragEventArgs e)
        {
            this.ApplyFilter();
        }

        void radDataFilter1_NodeRemoved(object sender, RadTreeViewEventArgs e)
        {
            this.ApplyFilter();
        }

        void radDataFilter1_Edited(object sender, TreeNodeEditedEventArgs e)
        {
            DataFilterCriteriaNode criteriaNode = e.Node as DataFilterCriteriaNode;
            if (criteriaNode != null)
            {
                bool isFieldNameEmpty = TelerikHelper.StringIsNullOrWhiteSpace(criteriaNode.PropertyName);
                bool isOperatorValid = criteriaNode.FilterOperator != FilterOperator.None;
                bool isValueRequired = criteriaNode.FilterOperator != FilterOperator.IsNull && criteriaNode.FilterOperator != FilterOperator.IsNotNull;
                bool hasValue = criteriaNode.DescriptorValue != null && criteriaNode.DescriptorValue.ToString() != string.Empty;

                if (!isFieldNameEmpty &&
                    isOperatorValid &&
                    (!isValueRequired ||
                    (isValueRequired && hasValue)))
                {
                    this.ApplyFilter();
                }
            }

            DataFilterGroupNode groupNode = e.Node as DataFilterGroupNode;
            if (groupNode != null)
            {
                this.ApplyFilter();
            }
        }

        private void ApplyFilter()
        {
            try
            {
                this.SelectData();
            }
            catch (Exception)
            {
                RadMessageBox.Show(this.radDataFilter1, "Please, enter valid parameters", "Expression is not valid");
            }
        }

        private void UpdateChartData()
        {
            List<int> barSeriesValues = new List<int>();
            Dictionary<int, decimal> productOrders = new Dictionary<int, decimal>();

            foreach (OrderDetail od in this.data)
            {
                if (!productOrders.ContainsKey(od.ProductId))
                {
                    productOrders.Add(od.ProductId, 0);
                }
                else
                {
                    decimal totalPrice = od.Quantity * od.UnitPrice;
                    productOrders[od.ProductId] += totalPrice - totalPrice * (decimal)od.Discount;
                }
            }

            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.Series.Clear();

            foreach (KeyValuePair<int, decimal> kvp in productOrders)
            {
                if (kvp.Value > 0)
                {
                    BarSeries serie = new BarSeries();
                    CategoricalDataPoint point = new CategoricalDataPoint((double)kvp.Value, this.productNames[kvp.Key]);
                    serie.DataPoints.Add(point);
                    area.Series.Add(serie);
                    serie.ShowLabels = true;
                    CategoricalAxis horizontalAxis = serie.HorizontalAxis as CategoricalAxis;
                    if (horizontalAxis != null)
                    {
                        horizontalAxis.ClipLabels = false;
                       // if (productOrders.Count <= 8)
                        {
                            horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine;
                        }
                        //else
                        //{
                           // horizontalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
                        //}
                    }
                }
            }
        }

        private void SelectData()
        {
            string filterExpression = this.radDataFilter1.Expression;

            if (!string.IsNullOrEmpty(filterExpression))
            {
                filterExpression = "WHERE " + filterExpression;
            }

            string commandString = String.Format("{0} {1}", selectCommand, filterExpression);

            //int productsCount = 0;
            using (OleDbCommand command = new OleDbCommand(commandString))
            {
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                IDataReader reader = command.ExecuteReader();
                data.Clear();

                while (reader.Read())
                {
                    OrderDetail customer = new OrderDetail(
                        Convert.ToInt32(reader[0]),
                        Convert.ToInt32(reader[1]),
                        Convert.ToDecimal(reader[2]),
                        Convert.ToInt16(reader[3]),
                        Convert.ToSingle(reader[4]));

                    if (customer.ProductId <= 10)
                    {
                        // limit number of records
                        data.Add(customer);
                    }
                }

                command.Connection.Close();
            }



            this.radVirtualGrid1.RowCount = data.Count;
            this.radVirtualGrid1.TableElement.SynchronizeRows();
            this.UpdateChartData();
        }

        private void FillProductNames()
        {
            string commandString = selectProductNameCommand;
            using (OleDbCommand command = new OleDbCommand(commandString))
            {
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                IDataReader reader = command.ExecuteReader();
                this.productNames.Clear();

                while (reader.Read())
                {
                    int productId = Convert.ToInt32(reader[0]);
                    string productName = Convert.ToString(reader[1]);
                    this.productNames[productId] = productName;
                }

                command.Connection.Close();
            }
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = columnNames[e.ColumnIndex];
            }

            if (e.RowIndex < 0)
            {
                e.FieldName = columnNames[e.ColumnIndex].Replace(" ", "");
            }

            if (e.RowIndex >= 0 && e.RowIndex < data.Count)
            {
                e.Value = data[e.RowIndex][e.ColumnIndex];
            }
        }
    }

    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public OrderDetail(int orderId, int productId, decimal unitPrice, short quantity, float discount)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.Discount = discount;
        }

        public object this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return OrderId;
                    case 1: return ProductId;
                    case 2: return UnitPrice;
                    case 3: return Quantity;
                    case 4: return Discount;
                    default: return String.Empty;
                }
            }
        }
    }
}
