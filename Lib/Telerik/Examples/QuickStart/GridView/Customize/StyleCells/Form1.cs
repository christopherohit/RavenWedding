using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.GridView.Customize.StyleCells
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private const int ROWCOUNT = 10;
        private const int COLUMNCOUNT = 10;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.VirtualMode = true;
            this.radGridView1.RowCount = ROWCOUNT;
            this.radGridView1.ColumnCount = COLUMNCOUNT;
            this.radGridView1.BackColor = Color.Transparent;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.TableElement.DrawFill = false;
            this.radGridView1.TableElement.RowHeight = 50;
            this.radGridView1.TableElement.CellSpacing = 0;
            this.radGridView1.TableElement.RowSpacing = 0;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.MasterTemplate.ShowColumnHeaders = false;
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;

            this.radSpinEditorRow.Maximum = ROWCOUNT - 1;
            this.radSpinEditorColumn.Maximum = COLUMNCOUNT - 1;

            this.radButtonBackColor.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid;

            ApplyRandomColors();
            UpdateBackColor();
        }

        void radGridView1_CurrentCellChanged(object sender, CurrentCellChangedEventArgs e)
        {
            if (this.radGridView1.CurrentCell != null)
            {
                this.radSpinEditorRow.Value = this.radGridView1.CurrentCell.RowInfo.Index;
                this.radSpinEditorColumn.Value = this.radGridView1.CurrentCell.ColumnInfo.Index;
            }
        }

        private void ApplyRandomColors()
        {
            Random r = new Random();
            for (int y = 0; y < this.radGridView1.RowCount; y++)
            {
                for (int x = 0; x < this.radGridView1.ColumnCount; x++)
                {
                    this.radGridView1.Rows[y].Cells[x].Style.CustomizeFill = true;
                    this.radGridView1.Rows[y].Cells[x].Style.DrawFill = true;
                    this.radGridView1.Rows[y].Cells[x].Style.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                }
            }
        }

        private void UpdateBackColor()
        {
            int row = (int)this.radSpinEditorRow.Value;
            int column = (int)this.radSpinEditorColumn.Value;
            Color backColor = this.radGridView1.Rows[row].Cells[column].Style.BackColor;
            this.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = backColor;
        }

        private void SetCellBackground()
        {
            int row = (int)this.radSpinEditorRow.Value;
            int column = (int)this.radSpinEditorColumn.Value;
            RadColorDialog dialog = new RadColorDialog();
            ((RadForm)dialog.ColorDialogForm).ThemeName = CurrentThemeName;
            dialog.SelectedColor = this.radGridView1.Rows[row].Cells[column].Style.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radGridView1.Rows[row].Cells[column].Style.BackColor = dialog.SelectedColor;
                this.radButtonBackColor.ButtonElement.ButtonFillElement.BackColor = dialog.SelectedColor;
            }
        }

        private void radGridView1_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            e.RowElement.DrawBorder = false;
            e.RowElement.DrawFill = false;
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.IsCurrent)
            {
                e.CellElement.DrawBorder = true;
                e.CellElement.BorderWidth = 4;
                e.CellElement.BorderColor = Color.Yellow;
                e.CellElement.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            }
            else
            {
                e.CellElement.DrawBorder = false;
                e.CellElement.BorderWidth = 1;
            }
        }

        private void radSpinEditorRow_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.Rows[(int)this.radSpinEditorRow.Value].IsCurrent = true;
            UpdateBackColor();
        }

        private void radSpinEditorColumn_ValueChanged(object sender, EventArgs e)
        {
            this.radGridView1.Columns[(int)this.radSpinEditorColumn.Value].IsCurrent = true;
            UpdateBackColor();
        }

        private void radButtonRandom_Click(object sender, EventArgs e)
        {
            ApplyRandomColors();
        }

        private void radButtonBackColor_Click(object sender, EventArgs e)
        {
            SetCellBackground();
        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            SetCellBackground();
        }

        protected override void WireEvents()
        {
            this.radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            this.radGridView1.RowFormatting += new RowFormattingEventHandler(radGridView1_RowFormatting);
            this.radGridView1.CellDoubleClick += new GridViewCellEventHandler(radGridView1_CellDoubleClick);
            this.radGridView1.CurrentCellChanged += new CurrentCellChangedEventHandler(radGridView1_CurrentCellChanged);
            this.radButtonRandom.Click += new System.EventHandler(this.radButtonRandom_Click);
            this.radSpinEditorRow.ValueChanged += new System.EventHandler(this.radSpinEditorRow_ValueChanged);
            this.radSpinEditorColumn.ValueChanged += new System.EventHandler(this.radSpinEditorColumn_ValueChanged);
            this.radButtonBackColor.Click += new System.EventHandler(this.radButtonBackColor_Click);
        }
    }
}
