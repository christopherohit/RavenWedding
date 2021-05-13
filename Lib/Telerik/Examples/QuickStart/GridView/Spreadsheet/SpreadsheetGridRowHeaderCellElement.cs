using System.Drawing;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Spreadsheet
{
    public class SpreadsheetGridRowHeaderCellElement : GridRowHeaderCellElement
    {
        #region Initialization

        public SpreadsheetGridRowHeaderCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
            
        }

        public override void Initialize(GridViewColumn column, GridRowElement row)
        {
            base.Initialize(column, row);
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();

            base.DrawFill = true;
            base.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            base.NumberOfColors = 4;
            base.BackColor = Color.FromArgb(231, 240, 252);
            base.BackColor2 = Color.FromArgb(218, 233, 251);
            base.BackColor3 = Color.FromArgb(216, 231, 251);
            base.BackColor4 = Color.FromArgb(209, 226, 247);
            base.DrawBorder = true;
            base.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            base.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
            base.BorderColor = Color.FromArgb(209, 225, 245);
            base.BorderInnerColor = Color.White;
        }

        public override void SetContent()
        {
            int rowNumber = this.ViewTemplate.Rows.IndexOf(this.RowInfo) + 1;
            this.Text = rowNumber.ToString();
        }

        #endregion
    }
}
