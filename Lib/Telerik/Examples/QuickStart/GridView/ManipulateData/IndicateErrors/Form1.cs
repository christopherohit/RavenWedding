using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.IndicateErrors
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateState(GridViewRowInfo row, GridViewColumn column)
        {
            if (row != null && column != null)
            {
                this.radTextBoxRowError.Text = row.ErrorText;
                this.radTextBoxCellError.Text = row.Cells[column.Name].ErrorText;

                bool isEnabled = !string.IsNullOrEmpty(row.ErrorText) ||
                        !string.IsNullOrEmpty(row.Cells[column.Name].ErrorText);

                IDataErrorInfo dataErrorInfo = row.DataBoundItem as IDataErrorInfo;

                if (dataErrorInfo != null && isEnabled)
                {
                    string error = dataErrorInfo[column.Name];
                    isEnabled = String.IsNullOrEmpty(error);
                }

                this.radButtonClear.Enabled = isEnabled;
                this.UpdateSetButtonState();

                this.radTextBoxRowError.Enabled = true;
                this.radTextBoxCellError.Enabled = true;
            }
            else
            {
                this.radButtonClear.Enabled = false;
                this.radButtonSet.Enabled = false;
                this.radTextBoxCellError.Enabled = false;
                this.radTextBoxRowError.Enabled = false;
            }
        }

        private void UpdateSetButtonState()
        {
            this.radButtonSet.Enabled = !string.IsNullOrEmpty(this.radTextBoxCellError.Text) ||
                !string.IsNullOrEmpty(this.radTextBoxRowError.Text);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(radGridView1_CellFormatting);
            this.radGridView1.CurrentCellChanged += new CurrentCellChangedEventHandler(radGridView1_CurrentCellChanged);
            this.radTextBoxCellError.TextChanged += new EventHandler(radTextBoxCellError_TextChanged);
            this.radTextBoxRowError.TextChanged += new EventHandler(radTextBoxRowError_TextChanged);

            BindingList<Employee> employees = new BindingList<Employee>();
            employees.Add(new Employee(1, "Fuller, Andrew", "London", "andrew@gmail.com", "555-235-2359", EmployeePosition.VicePresident));
            employees.Add(new Employee(2, "Davolio, Nancy", "London", "nancy.davoilo@gmail.com", "555-435-1265", EmployeePosition.SalesManager));
            employees.Add(new Employee(3, "Peacock, Margaret", "London", "peacock@gmail.com", "555-645-5513", EmployeePosition.SalesRepresentative));
            employees.Add(new Employee(4, "King, Robert", "Seattle", "king", "555-331-6578", EmployeePosition.SalesRepresentative));
            employees.Add(new Employee(5, "Dodsworth, Anne", "Tacoma", "anne@gmail.com", "555-236-6845", EmployeePosition.SalesRepresentative));
            employees.Add(new Employee(6, "Callahan, Laura", "Seattle", "laura@gmail.com", "555-875-343", EmployeePosition.SalesRepresentative));
            employees.Add(new Employee(7, "Steven, Buchanan", "London", "steven@gmail.com", "555-348-8267", EmployeePosition.Coordinator));

            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            this.radGridView1.ShowGroupedColumns = true;
            this.radGridView1.EnableGrouping = false;
            this.radGridView1.AllowDeleteRow = false;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.TableElement.RowHeight = 40;
            this.radGridView1.DataSource = employees;

            this.radGridView1.Columns["Name"].Width = 180;
            this.radGridView1.Columns["EMail"].Width = 180;
            this.radGridView1.Columns["Phone"].Width = 100;
            this.radGridView1.Columns["City"].Width = 80;
            this.radGridView1.Columns["Position"].Width = 150;

            this.radSpinEditorRow.Maximum = this.radGridView1.Rows.Count - 1;
            this.radSpinEditorColumn.Maximum = this.radGridView1.Columns.Count - 1;
        }

        private void radTextBoxRowError_TextChanged(object sender, EventArgs e)
        {
            UpdateSetButtonState();
        }

        private void radTextBoxCellError_TextChanged(object sender, EventArgs e)
        {
            UpdateSetButtonState();
        }

        private void radSpinEditorRow_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.Rows[(int)this.radSpinEditorRow.Value].IsCurrent = true;
        }

        private void radSpinEditorColumn_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.Columns[(int)this.radSpinEditorColumn.Value].IsCurrent = true;
        }

        private void radGridView1_CurrentCellChanged(object sender, CurrentCellChangedEventArgs e)
        {
            if (e.NewCell != null)
            {
                this.radSpinEditorRow.Value = this.radGridView1.Rows.IndexOf(e.NewCell.RowInfo);
                this.radSpinEditorColumn.Value = this.radGridView1.Columns.IndexOf((GridViewDataColumn)e.NewCell.ColumnInfo);
            }
            UpdateState(e.NewCell != null ? e.NewCell.RowInfo : null, e.NewCell != null ? e.NewCell.ColumnInfo : null);
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridDataCellElement cell = e.CellElement as GridDataCellElement;
            if (cell != null)
            {
                if (cell.ContainsErrors)
                {
                    cell.DrawBorder = true;
                    cell.BorderBoxStyle = BorderBoxStyle.FourBorders;

                    cell.BorderBottomColor = cell.BorderTopColor = cell.BorderRightShadowColor = cell.BorderLeftShadowColor = 
                            cell.BorderBottomShadowColor = cell.BorderTopShadowColor = cell.BorderRightColor = cell.BorderLeftColor = Color.Red;
                    cell.BorderBottomWidth = cell.BorderTopWidth = cell.BorderRightWidth = cell.BorderLeftWidth = 2;

                    cell.ZIndex = 500;
                }
                else
                {
                    cell.ResetValue(LightVisualElement.DrawBorderProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local);

                    cell.ResetValue(LightVisualElement.BorderBottomColorProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderBottomShadowColorProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderBottomWidthProperty, ValueResetFlags.Local);

                    cell.ResetValue(LightVisualElement.BorderTopColorProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderTopShadowColorProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderTopWidthProperty, ValueResetFlags.Local);

                    cell.ResetValue(LightVisualElement.BorderLeftColorProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderLeftShadowColorProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.BorderLeftWidthProperty, ValueResetFlags.Local);

                    cell.ResetValue(LightVisualElement.BorderDrawModeProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.ZIndexProperty, ValueResetFlags.Local);
                }
            }
        }

        private void radButtonSet_Click(object sender, EventArgs e)
        {
            int row = (int)radSpinEditorRow.Value;
            int column = (int)radSpinEditorColumn.Value;

            string columnError = radTextBoxCellError.Text;
            string rowError = radTextBoxRowError.Text;
            IDataErrorInfo dataErrorInfo = this.radGridView1.Rows[row].DataBoundItem as IDataErrorInfo;

            if (dataErrorInfo != null)
            {
                string propertyError = dataErrorInfo[this.radGridView1.Columns[column].Name];
                string dataError = dataErrorInfo.Error;

                bool showMessage = false;

                if (String.IsNullOrEmpty(columnError) && !String.IsNullOrEmpty(propertyError))
                {
                    columnError = propertyError;
                    radTextBoxCellError.Text = columnError;
                    showMessage = true;
                }

                if (String.IsNullOrEmpty(rowError) && !String.IsNullOrEmpty(dataError))
                {
                    rowError = dataError;
                    radTextBoxRowError.Text = rowError;
                    showMessage = true;
                }

                if (showMessage)
                {
                    RadMessageBox.Show("You cannot set error text to String.Empty, because IDataErrorInfo interface has errors.", "Information", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }

            this.radGridView1.Rows[row].ErrorText = rowError;
            this.radGridView1.Rows[row].Cells[column].ErrorText = columnError;
            this.UpdateState(this.radGridView1.CurrentRow, this.radGridView1.CurrentColumn);
        }

        private void radButtonClear_Click(object sender, EventArgs e)
        {
            int row = (int)radSpinEditorRow.Value;
            int column = (int)radSpinEditorColumn.Value;
            this.radGridView1.Rows[row].ErrorText = string.Empty;
            this.radGridView1.Rows[row].Cells[column].ErrorText = string.Empty;
            this.radTextBoxCellError.Text = string.Empty;
            this.radTextBoxRowError.Text = string.Empty;
            this.radButtonClear.Enabled = false;
            this.radButtonSet.Enabled = false;
        }

        protected override void WireEvents()
        {
            this.radButtonSet.Click += new System.EventHandler(this.radButtonSet_Click);
            this.radSpinEditorRow.ValueChanged += new System.EventHandler(this.radSpinEditorRow_ValueChanged);
            this.radSpinEditorColumn.ValueChanged += new System.EventHandler(this.radSpinEditorColumn_ValueChanged);
            this.radButtonClear.Click += new System.EventHandler(this.radButtonClear_Click);
        }
    }
}
