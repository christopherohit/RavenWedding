using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Hierarchy
{
    public partial class Form1 : ExamplesForm
    {
        #region Initialization

        List<Employee> data = new List<Employee>();
        Timer expandTimer = new Timer();
        int rowToExpand;
        VirtualGridViewInfo viewInfoToExpand;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            this.radVirtualGrid1.TableElement.RowHeight = 120;

            expandTimer.Interval = 1000;
            expandTimer.Tick += expandTimer_Tick;
        }

        #endregion

        #region Populate Data

        private void LoadData()
        {
            employeesTableAdapter.Fill(northwindDataSet.Employees);
            customersTableAdapter.Fill(northwindDataSet.Customers);
            Random random = new Random();

            for (int i = 0; i < northwindDataSet.Employees.Count; i++)
            {
                Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow row = northwindDataSet.Employees[i];
                Employee employee = new Employee();
                employee.Name = row.FirstName + " " + row.LastName;
                employee.Photo = GetImageFromBytes(row.Photo);
                employee.Salary = random.Next(45000);
                employee.HireDate = row.HireDate;
                employee.Title = row.Title;

                int rowCount = random.Next(3, 10);

                for (int j = 0; j < rowCount; j++)
                {
                    int customerIndex = random.Next(0, northwindDataSet.Customers.Count);
                    Telerik.Examples.WinControls.DataSources.NorthwindDataSet.CustomersRow customerRow = northwindDataSet.Customers[customerIndex];

                    Customer customer = new Customer()
                    {
                        CompanyName = customerRow.CompanyName,
                        Country = customerRow.Country,
                        City = customerRow.City,
                        ContactName = customerRow.ContactName
                    };

                    int salesCount = random.Next(2, 6);

                    for (int k = 0; k < salesCount; k++)
                    {
                        customer.Sales.Add(new Sale()
                        {
                            ProductNumber = random.Next(1000),
                            Quantity = random.Next(50),
                            Discount = random.Next(100),
                            Total = random.Next(10000)
                        });
                    }

                    employee.Customers.Add(customer);
                }

                data.Add(employee);
            }

            this.radVirtualGrid1.RowCount = data.Count;
            this.radVirtualGrid1.ColumnCount = Employee.FieldNames.Length;
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ViewInfo == this.radVirtualGrid1.MasterViewInfo)
            {
                if (e.ColumnIndex < 0)
                {
                    return;
                }

                e.FieldName = Employee.FieldNames[e.ColumnIndex];

                if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
                {
                    e.Value = e.FieldName;
                }
                else if (e.RowIndex >= 0)
                {
                    e.Value = data[e.RowIndex][e.ColumnIndex];
                    if (e.ColumnIndex == 2)
                    {
                        e.FormatString = "${0:#,###}";
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        e.FormatString = "{0:MM/dd/yy}";
                    }
                }
            }
            else if (e.ViewInfo.HierarchyLevel == 1)
            {
                if (e.ColumnIndex < 0)
                {
                    return;
                }

                e.FieldName = Customer.FieldNames[e.ColumnIndex];

                if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
                {
                    e.Value = e.FieldName;
                }
                else if (e.RowIndex >= 0)
                {
                    e.Value = data[e.ViewInfo.ParentRowIndex].Customers[e.RowIndex][e.ColumnIndex];
                }
            }
            else
            {
                if (e.ColumnIndex < 0)
                {
                    return;
                }

                e.FieldName = Sale.FieldNames[e.ColumnIndex];

                if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
                {
                    e.Value = e.FieldName;
                }
                else if (e.RowIndex >= 0)
                {
                    e.Value = data[e.ViewInfo.ParentViewInfo.ParentRowIndex].Customers[e.ViewInfo.ParentRowIndex].Sales[e.RowIndex][e.ColumnIndex];

                    if(e.ColumnIndex == 0)
                    {
                        e.FormatString = "#{0}";
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        e.FormatString = "{0:F2}%";
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        e.FormatString = "${0}";
                    }
                }
            }
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.ColumnIndex < 0)
            {
                return;
            }

            if (e.CellElement.Value is Image)
            {
                e.CellElement.Image = (Image)e.CellElement.Value;
                e.CellElement.ImageLayout = ImageLayout.Zoom;
                e.CellElement.Text = "";
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local);
            }

            if (e.ViewInfo.HierarchyLevel == 1)
            {
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty);
            }
        }

        #endregion

        #region Hierarchy

        private void radVirtualGrid1_QueryHasChildRows(object sender, Telerik.WinControls.UI.VirtualGridQueryHasChildRowsEventArgs e)
        {
            e.HasChildRows = (e.RowIndex >= 0 && e.ViewInfo.HierarchyLevel < 2);
        }

        void expandTimer_Tick(object sender, EventArgs e)
        {
            expandTimer.Stop();
            viewInfoToExpand.StopRowWaiting(rowToExpand);
            viewInfoToExpand.ExpandRow(rowToExpand);
            viewInfoToExpand = null;
        }

        private void radVirtualGrid1_RowExpanding(object sender, Telerik.WinControls.UI.VirtualGridRowExpandingEventArgs e)
        {
            if (viewInfoToExpand == null)
            {
                e.Cancel = true;
                e.ViewInfo.StartRowWaiting(e.RowIndex);
                viewInfoToExpand = e.ViewInfo;
                rowToExpand = e.RowIndex;
                expandTimer.Start();
            }
            else
            {
                if (rowToExpand != e.RowIndex)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (e.ChildViewInfo.HierarchyLevel == 1)
                    {
                        e.ChildViewInfo.ColumnCount = Customer.FieldNames.Length;
                        e.ChildViewInfo.RowCount = data[e.ChildViewInfo.ParentRowIndex].Customers.Count;
                    }
                    else
                    {
                        e.ChildViewInfo.ColumnCount = Sale.FieldNames.Length;
                        e.ChildViewInfo.RowCount = data[e.ChildViewInfo.ParentViewInfo.ParentRowIndex].Customers[e.ChildViewInfo.ParentRowIndex].Sales.Count;
                    }
                }
            }
        }

        #endregion

        #region Helper Methods

        private Image GetImageFromBytes(byte[] bytes)
        {
            Image result = null;
            MemoryStream stream = null;

            try
            {
                stream = new MemoryStream(bytes, 78, bytes.Length - 78);
                result = Image.FromStream(stream);
            }
            catch
            {
                try
                {
                    stream = new MemoryStream(bytes, 0, bytes.Length);
                    result = Image.FromStream(stream);
                }
                catch
                {
                    result = null;
                }
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            return result;
        }

        #endregion
    }
}
