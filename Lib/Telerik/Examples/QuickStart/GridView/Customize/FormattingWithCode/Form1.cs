using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Customize.FormattingWithCode
{
    public partial class Form1 : ExamplesForm
    {
        private Font font;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radButtonForeColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid;
            this.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor = Color.Yellow;

            this.radButtonBackColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid;
            this.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = Color.Red;

            employeeOrdersTableAdapter.Fill(northwindDataSet.EmployeeOrders);

            this.radGridView1.MasterTemplate.AutoExpandGroups = true;
            this.radGridView1.GroupDescriptors.Add(new GridGroupByExpression("Title GroupBy Title"));
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "FirstName" && e.CellElement.RowInfo is GridViewDataRowInfo)
            {
                int quantity = -1;
                object quantityValue = e.CellElement.RowInfo.Cells["Quantity"].Value;

                if (quantityValue != null && !Convert.IsDBNull(quantityValue))
                {
                    quantity = (int)(short)quantityValue;
                }

                if (quantity >= (int)this.radSpinEditorGreater.Value &&
                    quantity <= (int)this.radSpinEditorLess.Value)
                {
                    e.CellElement.DrawFill = true;
                    e.CellElement.GradientStyle = GradientStyles.Solid;
                    e.CellElement.ForeColor = this.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor;
                    e.CellElement.BackColor = this.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor;
                }
                else
                {
                    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                    e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                    e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                    e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                }
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
            }
        }

        private void radGridView1_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (font == null)
            {
                font = new Font(e.RowElement.Font, FontStyle.Bold);
            }

            int quantity = -1;

            object quantityValue = e.RowElement.RowInfo.Cells["Quantity"].Value;

            if (quantityValue != null && !Convert.IsDBNull(quantityValue))
            {
                quantity = (int)(short)quantityValue;
            }

            if (quantity >= (int)this.radSpinEditorGreater.Value &&
                quantity <= (int)this.radSpinEditorLess.Value)
            {
                e.RowElement.Font = font;
                e.RowElement.BackColor = Color.FromArgb(190, 190, 190);
                e.RowElement.ForeColor = Color.Black;
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
            }
            else
            {
                e.RowElement.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
            }
        }

        private void radButtonForeColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();
            ((RadForm)dialog.ColorDialogForm).ThemeName = CurrentThemeName;
            dialog.SelectedColor = this.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radButtonForeColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor;
                this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
            }
        }

        private void radButtonBackColor_Click(object sender, EventArgs e)
        {
            RadColorDialog dialog = new RadColorDialog();
            ((RadForm)dialog.ColorDialogForm).ThemeName = CurrentThemeName;
            dialog.SelectedColor = this.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor;
                this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
            }
        }

        private void radSpinEditorGreater_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        private void radSpinEditorLess_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged);
        }

        protected override void WireEvents()
        {
            this.radButtonBackColor.Click += new System.EventHandler(this.radButtonBackColor_Click);
            this.radButtonForeColor.Click += new System.EventHandler(this.radButtonForeColor_Click);
            this.radSpinEditorLess.ValueChanged += new System.EventHandler(this.radSpinEditorLess_ValueChanged);
            this.radSpinEditorGreater.ValueChanged += new System.EventHandler(this.radSpinEditorGreater_ValueChanged);
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.radGridView1_RowFormatting);
        }
    }
}
