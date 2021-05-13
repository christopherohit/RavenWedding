using System;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.LayoutControl.FirstLook
{
    public partial class Form1 : RadForm, ISupportThemeName
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.EmployeeOrders' table. You can move, or remove it, as needed.
            this.employeeOrdersTableAdapter.Fill(this.northwindDataSet.EmployeeOrders);
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}
