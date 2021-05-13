using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.VirtualGrid.Validation
{
    public partial class Form1 : ExamplesForm
    {
        private readonly string selectCommand = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
        private string[] columnNames = new string[] { "Order Id", "Product Id", "UnitPrice", "Quantity", "Discount" };
        List<OrderDetails> data = new List<OrderDetails>();

        public Form1()
        {
            InitializeComponent();

            this.radVirtualGrid1.ColumnCount = columnNames.Length;
            this.radVirtualGrid1.AllowAddNewRow = false;
            this.radVirtualGrid1.AllowDelete = false;

            this.SelectData();
            this.InitializeDropDowns();

            this.radSpinEditorFirstCondition.DecimalPlaces = 2;
            this.radSpinEditorFirstCondition.Step = 0.1M;
            this.radSpinEditorSecondCondition.DecimalPlaces = 2;
            this.radSpinEditorSecondCondition.Step = 0.1M;
        }

        private void InitializeDropDowns()
        {
            this.radDropDownListColumnName.Items.Add(new RadListDataItem("UnitPrice", new ColumnValidationInfo(2, 0, 1, 2, 50)));
            this.radDropDownListColumnName.Items.Add(new RadListDataItem("Quantity", new ColumnValidationInfo(3, 1, 1, 2, 41)));
            this.radDropDownListColumnName.Items.Add(new RadListDataItem("Discount", new ColumnValidationInfo(4, 1, 0, 3, (decimal)0.3)));

            for (int i = 0; i < ColumnValidationInfo.validators.Count; i++)
            {
                this.radDropDownListFirstCondition.Items.Add(new RadListDataItem(ColumnValidationInfo.validators[i].Name, ColumnValidationInfo.validators[i]));
                this.radDropDownListSecondCondition.Items.Add(new RadListDataItem(ColumnValidationInfo.validators[i].Name, ColumnValidationInfo.validators[i]));
            }
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radDropDownListColumnName.SelectedIndexChanged += radDropDownListColumnName_SelectedIndexChanged;
            this.radDropDownListFirstCondition.SelectedIndexChanged += radDropDownListFirstCondition_SelectedIndexChanged;
            this.radDropDownListSecondCondition.SelectedIndexChanged += radDropDownListSecondCondition_SelectedIndexChanged;
            this.radSpinEditorFirstCondition.ValueChanged += radSpinEditorFirstCondition_ValueChanged;
            this.radSpinEditorSecondCondition.ValueChanged += radSpinEditorSecondCondition_ValueChanged;
            this.radVirtualGrid1.CellValidating += radVirtualGrid1_CellValidating;
            this.radVirtualGrid1.CellFormatting += radVirtualGrid1_CellFormatting;
            this.radVirtualGrid1.RowFormatting += radVirtualGrid1_RowFormatting;
            this.radVirtualGrid1.CellValuePushed += radVirtualGrid1_CellValuePushed;
            this.radVirtualGrid1.EditorRequired += radVirtualGrid1_EditorRequired;

            this.radDropDownListColumnName.SelectedIndex = 0;
        }

        private void radVirtualGrid1_EditorRequired(object sender, VirtualGridEditorRequiredEventArgs e)
        {
            e.Editor = new VirtualGridSpinEditor();
        }

        private void radDropDownListColumnName_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)this.radDropDownListColumnName.SelectedValue;
            this.radDropDownListFirstCondition.SelectedIndex = validationInfo.Validator1;
            this.radDropDownListSecondCondition.SelectedIndex = validationInfo.Validator2;
            this.radSpinEditorFirstCondition.Value = validationInfo.Value1;
            this.radSpinEditorSecondCondition.Value = validationInfo.Value2;
        }

        private void radDropDownListFirstCondition_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)this.radDropDownListColumnName.SelectedValue;
            validationInfo.Validator1 = radDropDownListFirstCondition.SelectedIndex;
            radDropDownListSecondCondition.Visible = radDropDownListFirstCondition.SelectedIndex != 4;
            radSpinEditorSecondCondition.Visible = radDropDownListFirstCondition.SelectedIndex != 4;
            radLabel1.Visible = radDropDownListFirstCondition.SelectedIndex != 4;
            this.radVirtualGrid1.TableElement.SynchronizeRows();
        }

        private void radDropDownListSecondCondition_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)this.radDropDownListColumnName.SelectedValue;
            validationInfo.Validator2 = radDropDownListSecondCondition.SelectedIndex;
            this.radVirtualGrid1.TableElement.SynchronizeRows();
        }

        private void radSpinEditorFirstCondition_ValueChanged(object sender, EventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)this.radDropDownListColumnName.SelectedValue;
            validationInfo.Value1 = radSpinEditorFirstCondition.Value;
            this.radVirtualGrid1.TableElement.SynchronizeRows();
        }

        private void radSpinEditorSecondCondition_ValueChanged(object sender, EventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)this.radDropDownListColumnName.SelectedValue;
            validationInfo.Value2 = radSpinEditorSecondCondition.Value;
            this.radVirtualGrid1.TableElement.SynchronizeRows();
        }

        private void radVirtualGrid1_CellValidating(object sender, VirtualGridCellValidatingEventArgs e)
        {
            if (this.radVirtualGrid1.IsInEditMode)
            {
                ColumnValidationInfo validationInfo = GetColumnValidationInfo(e.ColumnIndex);

                if (validationInfo != null && !validationInfo.Validate(Convert.ToDecimal(this.radVirtualGrid1.ActiveEditor.Value)))
                {
                    e.Cancel = true;
                    e.ViewInfo.SetRowErrorText(e.RowIndex, "Validation Error!");
                }
            }
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.RowIndex < 0)
            {
                return;
            }

            ColumnValidationInfo validationInfo = GetColumnValidationInfo(e.CellElement.ColumnIndex);

            if (validationInfo == null)
            {
                return;
            }

            object value = e.CellElement.Value;

            if (Convert.IsDBNull(value))
            {
                value = null;
            }

            if (!validationInfo.Validate(Convert.ToDecimal(value)))
            {
                e.CellElement.DrawFill = true;
                e.CellElement.GradientStyle = GradientStyles.Linear;
                e.CellElement.GradientPercentage = 0.45f;
                e.CellElement.GradientPercentage2 = 0.53f;
                e.CellElement.NumberOfColors = 4;
                e.CellElement.BackColor = Color.FromArgb(253, 141, 142);
                e.CellElement.BackColor2 = Color.FromArgb(254, 86, 86);
                e.CellElement.BackColor3 = Color.FromArgb(254, 55, 55);
                e.CellElement.BackColor4 = Color.FromArgb(254, 31, 32);
                e.CellElement.ZIndex = 100;
            }
            else if (e.CellElement.BackColor == Color.FromArgb(253, 141, 142))
            {
                e.CellElement.ResetValue(RadItem.BackColorProperty);
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty);
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty);
                e.CellElement.ResetValue(LightVisualElement.GradientPercentageProperty);
                e.CellElement.ResetValue(LightVisualElement.GradientPercentage2Property);
                e.CellElement.ResetValue(LightVisualElement.NumberOfColorsProperty);
                e.CellElement.ResetValue(LightVisualElement.BackColor2Property);
                e.CellElement.ResetValue(LightVisualElement.BackColor3Property);
                e.CellElement.ResetValue(LightVisualElement.BackColor4Property);
                e.CellElement.ResetValue(RadElement.ZIndexProperty);
            }
        }

        private void radVirtualGrid1_RowFormatting(object sender, VirtualGridRowElementEventArgs e)
        {
            if (e.RowElement.RowIndex >= 0)
            {
                SetRowErrorText(e.RowElement.RowIndex);
            }
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs e)
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

        private void radVirtualGrid1_SortChanged(object sender, VirtualGridEventArgs e)
        {
            SelectData();
        }

        private void radVirtualGrid1_FilterChanged(object sender, VirtualGridEventArgs e)
        {
            SelectData();
        }

        private void radVirtualGrid1_CellValuePushed(object sender, VirtualGridCellValuePushedEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.data[e.RowIndex][e.ColumnIndex] = Convert.ToString(e.Value);
            }

            SetRowErrorText(e.RowIndex);
        }

        private ColumnValidationInfo GetColumnValidationInfo(int columnIndex)
        {
            foreach (RadListDataItem item in this.radDropDownListColumnName.Items)
            {
                ColumnValidationInfo validationInfo = (ColumnValidationInfo)item.Value;

                if (validationInfo.ColumnIndex == columnIndex)
                {
                    return validationInfo;
                }
            }

            return null;
        }

        private void SetRowErrorText(int rowIndex)
        {
            bool validationFailed = false;
            StringBuilder validationMessage = new StringBuilder();

            foreach (RadListDataItem item in this.radDropDownListColumnName.Items)
            {
                ColumnValidationInfo validationInfo = (ColumnValidationInfo)item.Value;
                object value = this.data[rowIndex][validationInfo.ColumnIndex];

                if (Convert.IsDBNull(value))
                {
                    value = null;
                }

                if (!validationInfo.Validate(Convert.ToDecimal(value)))
                {
                    validationFailed = true;
                    validationMessage.Append(this.columnNames[validationInfo.ColumnIndex] + " " + validationInfo.GetMessage(Convert.ToDecimal(value)) + "\n");
                }

                if (this.radVirtualGrid1.IsInEditMode && this.radVirtualGrid1.CurrentCell.RowIndex == rowIndex && this.radVirtualGrid1.CurrentCell.ColumnIndex == validationInfo.ColumnIndex)
                {
                    object editorValue = this.radVirtualGrid1.ActiveEditor.Value;

                    if (Convert.IsDBNull(editorValue))
                    {
                        editorValue = value;
                    }

                    if (!validationInfo.Validate(Convert.ToDecimal(editorValue)))
                    {
                        validationFailed = true;
                        validationMessage.Append(this.columnNames[validationInfo.ColumnIndex] + " " + validationInfo.GetMessage(Convert.ToDecimal(editorValue)) + "\n");
                    }
                }
            }

            this.radVirtualGrid1.MasterViewInfo.SetRowErrorText(rowIndex, validationFailed ? validationMessage.ToString() : string.Empty);
        }

        #region OleDb CRUD

        private void SelectData()
        {
            string sortExpression = this.radVirtualGrid1.SortDescriptors.Expression;
            string filterExpression = this.radVirtualGrid1.FilterDescriptors.Expression;

            if (!string.IsNullOrEmpty(sortExpression))
            {
                sortExpression = "ORDER BY " + sortExpression;
            }

            if (!string.IsNullOrEmpty(filterExpression))
            {
                filterExpression = "WHERE " + filterExpression;
            }

            string commandString = String.Format("{0} {1} {2}", selectCommand, filterExpression, sortExpression);

            using (OleDbCommand command = new OleDbCommand(commandString))
            {
                command.Connection = new OleDbConnection(Properties.Settings.Default.NwindConnectionString);
                command.Connection.Open();
                IDataReader reader = command.ExecuteReader();
                data.Clear();

                while (reader.Read())
                {
                    OrderDetails customer = new OrderDetails(
                        Convert.ToString(reader[0]),
                        Convert.ToString(reader[1]),
                        Convert.ToString(reader[2]),
                        Convert.ToString(reader[3]),
                        Convert.ToString(reader[4]));
                    data.Add(customer);
                }

                command.Connection.Close();
            }

            this.radVirtualGrid1.RowCount = data.Count;
        }

        #endregion
    }

    #region Validators

    public class ColumnValidationInfo
    {
        static public List<ICellValidator> validators = new List<ICellValidator>();

        public int ColumnIndex;
        public int Validator1;
        public int Validator2;
        public decimal Value1;
        public decimal Value2;

        static ColumnValidationInfo()
        {
            validators.Add(new GreaterThanValidator());
            validators.Add(new GreaterThanOrEqualValidator());
            validators.Add(new LessThanValidator());
            validators.Add(new LessThanOrEqualValidator());
            validators.Add(new DoesNotEqualValidator());
        }

        public ColumnValidationInfo(int columnIndex, int validator1, decimal value1, int validator2, decimal value2)
        {
            this.ColumnIndex = columnIndex;
            this.Validator1 = validator1;
            this.Value1 = value1;
            this.Validator2 = validator2;
            this.Value2 = value2;
        }

        public bool Validate(decimal value)
        {
            if (Validator1 == 4)
            {
                return validators[Validator1].Validate(value, Value1);
            }

            return validators[Validator1].Validate(value, Value1) && validators[Validator2].Validate(value, Value2);
        }

        public string GetMessage(decimal value)
        {
            if (Validator1 == 4)
            {
                return validators[Validator1].ErrorMesssage + " " + Value1;
            }

            string s1 = string.Empty;

            if (!validators[Validator1].Validate(value, Value1))
                s1 = validators[Validator1].ErrorMesssage + " " + Value1;

            string s2 = string.Empty;
            if (!validators[Validator2].Validate(value, Value2))
                s2 = validators[Validator2].ErrorMesssage + " " + Value2;

            if (string.IsNullOrEmpty(s1))
                return s2;

            if (string.IsNullOrEmpty(s2))
                return s1;

            return s1 + " and " + s2;
        }
    }

    public interface ICellValidator
    {
        string Name { get; }
        string ErrorMesssage { get; }
        bool Validate(decimal value1, decimal value2);
    }

    public class GreaterThanValidator : ICellValidator
    {
        public string Name
        {
            get { return "is greater than"; }
        }

        public string ErrorMesssage
        {
            get { return "should be greater than"; }
        }

        public bool Validate(decimal value1, decimal value2)
        {
            return value1 > value2;
        }
    }

    public class GreaterThanOrEqualValidator : ICellValidator
    {
        public string Name
        {
            get { return "is greater than or equal"; }
        }

        public string ErrorMesssage
        {
            get { return "should be greater than or equal"; }
        }

        public bool Validate(decimal value1, decimal value2)
        {
            return value1 >= value2;
        }
    }

    public class LessThanValidator : ICellValidator
    {
        public string Name
        {
            get { return "is less than"; }
        }

        public string ErrorMesssage
        {
            get { return "should be less than"; }
        }

        public bool Validate(decimal value1, decimal value2)
        {
            return value1 < value2;
        }
    }

    public class LessThanOrEqualValidator : ICellValidator
    {
        public string Name
        {
            get { return "is less than or equal"; }
        }

        public string ErrorMesssage
        {
            get { return "should be less than or equal"; }
        }

        public bool Validate(decimal value1, decimal value2)
        {
            return value1 <= value2;
        }
    }

    public class DoesNotEqualValidator : ICellValidator
    {
        public string Name
        {
            get { return "does not equal"; }
        }

        public string ErrorMesssage
        {
            get { return "should be not equal"; }
        }

        public bool Validate(decimal value1, decimal value2)
        {
            return value1 != value2;
        }
    }

    #endregion
}
