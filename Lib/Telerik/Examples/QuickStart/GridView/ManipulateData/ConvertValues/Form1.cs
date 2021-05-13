using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using System.CodeDom.Compiler;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
{
    public partial class Form1 : ExamplesForm
    {
        #region Fields

        private GridViewDataColumn changedColumn = null;
        private RadOffice2007ScreenTipElement screenTip = new RadOffice2007ScreenTipElement();

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();

            this.radComboTimeZone.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radComboTimeZone_SelectedIndexChanged);
            this.gridView.CellFormatting += new CellFormattingEventHandler(gridView_CellFormatting);
            this.radTextBox1.ScreenTipNeeded += new ScreenTipNeededEventHandler(radTextBox1_ScreenTipNeeded);
            this.radComboTimeZone.ScreenTipNeeded += new ScreenTipNeededEventHandler(radComboTimeZone_ScreenTipNeeded);
        }

        #endregion

        #region Event Handlers

        private void gridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridCellElement cellElement = e.CellElement;
            GridViewDataColumn columnInfo = e.CellElement.ColumnInfo as GridViewDataColumn;

            if (cellElement is GridCheckBoxCellElement)
            { }

            if (columnInfo != null && !cellElement.RowInfo.IsCurrent && !cellElement.RowInfo.IsSelected &&
                cellElement.RowElement.RowVisualState != GridRowElement.RowVisualStates.Hovered &&
                (columnInfo.Name == "Category" && Object.Equals(cellElement.Text, columnInfo.NullValue) ||
                columnInfo == changedColumn))
            {

                e.CellElement.BackColor = columnInfo.Name == "Category" ? Color.Pink : Color.PaleGoldenrod;
                e.CellElement.GradientStyle = GradientStyles.Solid;
                e.CellElement.DrawFill = true;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
            }
        }

        private void radTextBox1_ScreenTipNeeded(object sender, ScreenTipNeededEventArgs e)
        {
            this.screenTip.CaptionLabel.Text = "Unit Price Expression";
            this.screenTip.MainTextLabel.Text = "UnitPriceConverter evaluates the equation for each Unit Price data cell and replace its display value with the result.";
            e.Item.ScreenTip = screenTip;
        }


        private void radComboTimeZone_ScreenTipNeeded(object sender, ScreenTipNeededEventArgs e)
        {
            this.screenTip.CaptionLabel.Text = "DateTime Zone";
            this.screenTip.MainTextLabel.Text = "DateTimeConverter converts OLE Automation date to DateTime date for concrete time zone.";
            e.Item.ScreenTip = screenTip;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.screenTip.MainTextLabel.Padding = new Padding(2);
            this.screenTip.CaptionLabel.Padding = new Padding(2);
            this.screenTip.EnableCustomSize = true;

            this.gridView.ShowGroupPanel = false;
            this.gridView.MasterTemplate.AllowAddNewRow = false;
            this.gridView.DataSource = Product.Generate();

            this.gridView.Columns["ProductID"].IsVisible = false;
            this.gridView.Columns["ProductName"].Width = 180;
            this.gridView.Columns["Category"].NullValue = "Type product's category";
            this.gridView.Columns["Category"].DataSourceNullValue = "Beverages";
            this.gridView.Columns["Category"].Width = 130;
            this.gridView.Columns["UnitPrice"].FormatString = "{0:c}";
            this.gridView.Columns["UnitPrice"].Width = 100;
            this.gridView.Columns["IsOrganic"].Width = 80;
            ((GridViewCheckBoxColumn)this.gridView.Columns["IsOrganic"]).ThreeState = true;
            this.gridView.Columns["UnitsInStock"].FormatString = "Quantity: {0}";
            this.gridView.Columns["UnitsInStock"].Width = 100;
            this.gridView.Columns["DeliveryDate"].FormatString = "{0}";
            this.gridView.Columns["DeliveryDate"].Width = 150;

            this.radComboTimeZone.DataSource = Telerik.WinControls.UI.TimeZoneInfo.GetSystemTimeZones();
            this.radComboTimeZone.DisplayMember = "DisplayName";
            this.radComboTimeZone.ValueMember = "Id";
            this.radComboTimeZone.SelectedValue = Telerik.WinControls.UI.TimeZoneInfo.Utc.Id;
            this.radComboTimeZone.DropDownMinSize = new Size(100, 400);

            this.radTextBox1.Text = "price + price * 0.20 + Math.Pow(price, 2)";
            this.SetUnitPriceExpression(this.radTextBox1.Text);
            this.changedColumn = null;
        }

        private void radComboTimeZone_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            GridViewDataColumn deliveryDateColumn = this.gridView.Columns["DeliveryDate"];
            DateTimeConverter timeConverter = deliveryDateColumn.DataTypeConverter as DateTimeConverter;
            timeConverter.TimeZoneInfo = this.radComboTimeZone.SelectedItem.DataBoundItem as Telerik.WinControls.UI.TimeZoneInfo;
            changedColumn = deliveryDateColumn;
            this.gridView.TableElement.UpdateView();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.SetUnitPriceExpression(this.radTextBox1.Text);
            this.gridView.TableElement.UpdateView();
        }

        private void SetUnitPriceExpression(string expression)
        {
            GridViewDataColumn unitPriceColumn = this.gridView.Columns["UnitPrice"];
            UnitPriceConverter unitPriceConverter = unitPriceColumn.DataTypeConverter as UnitPriceConverter;
            CompilerErrorCollection compilerErrors = unitPriceConverter.SetExpression(expression);

            if (!compilerErrors.HasErrors)
            {
                changedColumn = unitPriceColumn;
                return;
            }

            StringBuilder errorMessage = new StringBuilder();

            foreach (CompilerError error in compilerErrors)
            {
                errorMessage.AppendLine(error.ErrorText);
            }

            if (errorMessage.Length > 0)
            {
                RadMessageBox.Show(errorMessage.ToString(), "Expression Syntax Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        protected override void WireEvents()
        {
            this.btnEvaluate.Click += new System.EventHandler(this.radButton1_Click);
        }
    }
}
