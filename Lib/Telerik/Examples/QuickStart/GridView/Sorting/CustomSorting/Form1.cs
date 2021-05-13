using System;
using System.ComponentModel;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Sorting.CustomSorting
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
			
            this.radGridView.EnableCustomSorting = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);
            this.SelectedControl = this.radGridView;
        }

        private void radGridView1_CustomSorting(object sender, GridViewCustomSortingEventArgs e)
        {
            if (this.radGridView.SortDescriptors.Count == 0)
            {
                return;
            }

            int result = 0;
            for (int i = 0; i < this.radGridView.SortDescriptors.Count; i++)
            {
                string cellValue1 = e.Row1.Cells[this.radGridView.SortDescriptors[i].PropertyName].Value.ToString();
                string cellValue2 = e.Row2.Cells[this.radGridView.SortDescriptors[i].PropertyName].Value.ToString();

                result = cellValue1.Length - cellValue2.Length;
                if (result != 0)
                {
                    if (this.radGridView.SortDescriptors[i].Direction == ListSortDirection.Descending)
                    {
                        result *= -1;
                    }
                    break;
                }
            }

            e.SortResult = result;
        }

        protected override void WireEvents()
        {
            this.radGridView.CustomSorting += new Telerik.WinControls.UI.GridViewCustomSortingEventHandler(this.radGridView1_CustomSorting);
        }
    }
}
