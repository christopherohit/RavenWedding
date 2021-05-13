using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Examples.WinControls.Properties;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.MenuWithHeaderColumn
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radMenuItem1.DropDown.HeaderText = "RadMenuStrip Header";
            RadDropDownMenuElement popupElement = this.radMenuItem1.DropDown.PopupElement as RadDropDownMenuElement;
            if (popupElement != null)
            {
                popupElement.HeaderColumn.TextImageRelation = TextImageRelation.ImageBeforeText;
                popupElement.HeaderColumnBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                popupElement.HeaderColumnFill.BackColor = Color.FromArgb(238, 238, 213);
                popupElement.HeaderColumnFill.BackColor2 = Color.FromArgb(153, 208, 221);
                popupElement.HeaderColumnFill.NumberOfColors = 2;
                popupElement.HeaderColumnText.ForeColor = Color.White;
                popupElement.HeaderColumn.TextAlignment = ContentAlignment.MiddleLeft;
                popupElement.HeaderColumnText.Font = new Font("Comic Sans", 16f, FontStyle.Bold);
            }
        }

        protected override void WireEvents()
        {
        }
    }
}
