using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Settings
{
    public partial class Form1 : ExamplesForm
    {
        #region Initialization

        List<Employee> data = new List<Employee>();

        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radSpinEditorRowSpacing.ValueChanged += radSpinEditorRowSpacing_ValueChanged;
            this.radSpinEditorCellSpacing.ValueChanged += radSpinEditorCellSpacing_ValueChanged;
            this.radSpinEditorColumnWidth.ValueChanged += radSpinEditorColumnWidth_ValueChanged;
            this.radSpinEditorDataRowHeight.ValueChanged += radSpinEditorDataRowHeight_ValueChanged;
            this.radSpinEditorFilterRowHeight.ValueChanged += radSpinEditorFilterRowHeight_ValueChanged;
            this.radSpinEditorNewRowHeight.ValueChanged += radSpinEditorNewRowHeight_ValueChanged;
            this.radSpinEditorHeaderRowHeight.ValueChanged += radSpinEditorHeaderRowHeight_ValueChanged;
            this.radCheckBoxShowFilterRow.ToggleStateChanged += radCheckBoxShowFilterRow_ToggleStateChanged;
            this.radCheckBoxShowNewRow.ToggleStateChanged += radCheckBoxShowNewRow_ToggleStateChanged;
            this.radCheckBoxShowHeaderRow.ToggleStateChanged += radCheckBoxShowHeaderRow_ToggleStateChanged;
            this.radCheckBoxHotTracking.ToggleStateChanged += radCheckBoxHotTracking_ToggleStateChanged;
            this.radCheckBoxAlternatingRowColors.ToggleStateChanged += radCheckBoxAlternatingRowColors_ToggleStateChanged;
            this.radCheckBoxFitColumns.ToggleStateChanged += radCheckBoxFitColumns_ToggleStateChanged;

        }

        #endregion

        #region Settings

        private void radSpinEditorRowSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.TableElement.RowSpacing = (int)this.radSpinEditorRowSpacing.Value;
        }

        private void radSpinEditorCellSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.TableElement.CellSpacing = (int)this.radSpinEditorCellSpacing.Value;
        }

        private void radSpinEditorColumnWidth_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.TableElement.SetColumnWidth((int)this.radSpinEditorColumnWidth.Value, 0, 1, 2, 3, 4);
        }

        private void radSpinEditorDataRowHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.TableElement.RowHeight = (int)this.radSpinEditorDataRowHeight.Value;
        }

        private void radSpinEditorFilterRowHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.TableElement.FilterRowHeight = (int)this.radSpinEditorFilterRowHeight.Value;
        }

        private void radSpinEditorNewRowHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.TableElement.NewRowHeight = (int)this.radSpinEditorNewRowHeight.Value;
        }

        private void radSpinEditorHeaderRowHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualGrid1.TableElement.HeaderRowHeight = (int)this.radSpinEditorHeaderRowHeight.Value;
        }

        private void radCheckBoxShowFilterRow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.AllowFiltering = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxShowNewRow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.AllowAddNewRow = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxShowHeaderRow_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.ShowHeaderRow = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxHotTracking_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.EnableHotTracking = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxAlternatingRowColors_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radVirtualGrid1.EnableAlternatingRowColor = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxFitColumns_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill;
            }
            else
            {
                this.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.None;
            }
        }

        #endregion

        #region Populate Data

        private void LoadData()
        {
            employeesTableAdapter.Fill(northwindDataSet.Employees);
            Random random = new Random();

            for (int i = 0; i < northwindDataSet.Employees.Count; i++)
            {
                Telerik.Examples.WinControls.DataSources.NorthwindDataSet.EmployeesRow row = northwindDataSet.Employees[i];
                Employee employee = new Employee();
                employee.Name = row.FirstName + " " + row.LastName;
                employee.Photo = GetImageFromBytes(row.Photo);
                employee.Salary = random.Next(45000, 90000);
                employee.HireDate = row.HireDate;
                employee.Title = row.Title;

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
