using System;
using System.Linq;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.CheckedDropDownList
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.RadMessageBox.Instance.ThemeName = CurrentThemeName;
            Telerik.WinControls.RadMessageBox.Show("Appointment created.", "Message");
        }

        private void radToggleButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            bool check = (this.radToggleButton1.CheckState == System.Windows.Forms.CheckState.Checked);            
            this.radCheckedDropDownList1.ShowCheckAllItems = check;
            this.radCheckedDropDownList2.ShowCheckAllItems = check;
        }
    }
}
