using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.ValidateChanges
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radGridView1;
        }

        #region Event handlers

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.TableElement.BeginUpdate();

            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            this.radGridView1.TableElement.RowHeaderColumnWidth = 40;
            foreach (GridViewDataColumn column in this.radGridView1.Columns)
            {
                column.Width = 100;
            }
            this.radGridView1.TableElement.EndUpdate();

            this.radGridView1.EnableGrouping = false;
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;

            this.InitComboBoxes();

            this.radSpinEditor1.DecimalPlaces = 2;
            this.radSpinEditor1.Step = 0.1M;
            this.radSpinEditor2.DecimalPlaces = 2;
            this.radSpinEditor2.Step = 0.1M;
        }

        private void radComboBox1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)radComboBox1.SelectedValue;
            this.radComboBox2.SelectedIndex = validationInfo.Validator1;
            this.radComboBox3.SelectedIndex = validationInfo.Validator2;
            this.radSpinEditor1.Value = validationInfo.Value1;
            this.radSpinEditor2.Value = validationInfo.Value2;
        }

        private void radComboBox2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)radComboBox1.SelectedValue;
            validationInfo.Validator1 = radComboBox2.SelectedIndex;
            radComboBox3.Visible = radComboBox2.SelectedIndex != 4;
            radSpinEditor2.Visible = radComboBox2.SelectedIndex != 4;
            radLabel1.Visible = radComboBox2.SelectedIndex != 4;
            radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radComboBox3_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)radComboBox1.SelectedValue;
            validationInfo.Validator2 = radComboBox3.SelectedIndex;
            radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)radComboBox1.SelectedValue;
            validationInfo.Value1 = radSpinEditor1.Value;
            radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            ColumnValidationInfo validationInfo = (ColumnValidationInfo)radComboBox1.SelectedValue;
            validationInfo.Value2 = radSpinEditor2.Value;
            radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radGridView1_CellValidating(object sender, CellValidatingEventArgs e)
        {
            if (radGridView1.IsInEditMode)
            {
                ColumnValidationInfo validationInfo = GetColumnValidationInfo(e.Column);
                if (validationInfo != null && !validationInfo.Validate(Convert.ToDecimal(e.Value)))
                {
                    e.Cancel = true;
                    e.Row.ErrorText = "Validation Error!";
                }
            }
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowElement is GridDataRowElement)
            {
                ColumnValidationInfo validationInfo = GetColumnValidationInfo(e.CellElement.ColumnInfo);
                if (validationInfo != null)
                {
                    object value = ((GridDataCellElement)e.CellElement).Value;

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
                        e.CellElement.BorderGradientStyle = GradientStyles.Solid;
                        e.CellElement.BorderColor = Color.FromArgb(254, 31, 32);
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
                        e.CellElement.ResetValue(LightVisualElement.BorderGradientStyleProperty);
                        e.CellElement.ResetValue(LightVisualElement.BorderColorProperty);
                        e.CellElement.ResetValue(RadElement.ZIndexProperty);
                    }
                }
            }
        }

        private void radGridView1_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            SetRowErrorText(e.RowElement.RowInfo);
        }

        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            SetRowErrorText(e.Row);
        }

        #endregion

        #region Validators

        public class ColumnValidationInfo
        {
            static public List<ICellValidator> validators = new List<ICellValidator>();

            public GridViewColumn Column;
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

            public ColumnValidationInfo(GridViewColumn column, int validator1, decimal value1, int validator2, decimal value2)
            {
                this.Column = column;
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
            public string Name { get { return "is greater than"; } }
            public string ErrorMesssage { get { return "should be greater than"; } }
            public bool Validate(decimal value1, decimal value2) { return value1 > value2; }
        }

        public class GreaterThanOrEqualValidator : ICellValidator
        {
            public string Name { get { return "is greater than or equal"; } }
            public string ErrorMesssage { get { return "should be greater than or equal"; } }
            public bool Validate(decimal value1, decimal value2) { return value1 >= value2; }
        }

        public class LessThanValidator : ICellValidator
        {
            public string Name { get { return "is less than"; } }
            public string ErrorMesssage { get { return "should be less than"; } }
            public bool Validate(decimal value1, decimal value2) { return value1 < value2; }
        }

        public class LessThanOrEqualValidator : ICellValidator
        {
            public string Name { get { return "is less than or equal"; } }
            public string ErrorMesssage { get { return "should be less than or equal"; } }
            public bool Validate(decimal value1, decimal value2) { return value1 <= value2; }
        }

        public class DoesNotEqualValidator : ICellValidator
        {
            public string Name { get { return "does not equal"; } }
            public string ErrorMesssage { get { return "should be not equal"; } }
            public bool Validate(decimal value1, decimal value2) { return value1 != value2; }
        }

        #endregion

        void InitComboBoxes()
        {
            this.radComboBox1.Items.Add(new RadListDataItem("UnitPrice", new ColumnValidationInfo(this.radGridView1.Columns["UnitPrice"], 0, 1, 2, 50)));
            this.radComboBox1.Items.Add(new RadListDataItem("Quantity", new ColumnValidationInfo(this.radGridView1.Columns["Quantity"], 1, 1, 2, 41)));
            this.radComboBox1.Items.Add(new RadListDataItem("Discount", new ColumnValidationInfo(this.radGridView1.Columns["Discount"], 1, 0, 3, (decimal)0.3)));

            for (int i = 0; i < ColumnValidationInfo.validators.Count; i++)
            {
                this.radComboBox2.Items.Add(new RadListDataItem(ColumnValidationInfo.validators[i].Name, ColumnValidationInfo.validators[i]));
                this.radComboBox3.Items.Add(new RadListDataItem(ColumnValidationInfo.validators[i].Name, ColumnValidationInfo.validators[i]));
            }

            this.radComboBox1.SelectedIndex = 0;
        }

        void SetRowErrorText(GridViewRowInfo row)
        {
            if (row != null)
            {
                bool validationFailed = false;
                StringBuilder validationMessage = new StringBuilder();
                foreach (RadListDataItem item in radComboBox1.Items)
                {
                    ColumnValidationInfo validationInfo = (ColumnValidationInfo)item.Value;
                    object value = row.Cells[validationInfo.Column.HeaderText].Value;

                    if (Convert.IsDBNull(value))
                    {
                        value = null;
                    }

                    if (!validationInfo.Validate(Convert.ToDecimal(value)))
                    {
                        validationFailed = true;
                        validationMessage.Append(validationInfo.Column.HeaderText + " "
                            + validationInfo.GetMessage(Convert.ToDecimal(value)) + "\n");
                    }
                    if (radGridView1.IsInEditMode
                        && radGridView1.CurrentRow == row
                        && radGridView1.CurrentColumn == validationInfo.Column)
                    {
                        object editorValue = radGridView1.ActiveEditor.Value;

                        if (Convert.IsDBNull(editorValue))
                        {
                            editorValue = value;
                        }

                        if (!validationInfo.Validate(Convert.ToDecimal(editorValue)))
                        {
                            validationFailed = true;
                            validationMessage.Append(validationInfo.Column.HeaderText + " " +
                                validationInfo.GetMessage(Convert.ToDecimal(editorValue)) + "\n");
                        }
                    }
                }

                row.ErrorText = validationFailed ? validationMessage.ToString() : string.Empty;
            }
        }

        ColumnValidationInfo GetColumnValidationInfo(GridViewColumn column)
        {
            foreach (RadListDataItem item in radComboBox1.Items)
            {
                ColumnValidationInfo validationInfo = (ColumnValidationInfo)item.Value;
                if (validationInfo.Column == column)
                {
                    return validationInfo;
                }
            }
            return null;
        }

        protected override void WireEvents()
        {
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            this.radGridView1.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.radGridView1_RowFormatting);
            this.radGridView1.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.radGridView1_CellValidating);
            this.radSpinEditor2.ValueChanged += new System.EventHandler(this.radSpinEditor2_ValueChanged);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            this.radComboBox3.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox3_SelectedIndexChanged);
            this.radComboBox2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox2_SelectedIndexChanged);
            this.radComboBox1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboBox1_SelectedIndexChanged);
        }
    }
}
