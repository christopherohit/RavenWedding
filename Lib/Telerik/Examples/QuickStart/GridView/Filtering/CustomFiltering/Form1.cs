using System;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.Filtering.CustomFiltering
{
    public partial class Form1 : ExamplesForm
    {
        
        public Form1()
        {
            InitializeComponent();

            this.radGridView.EnableGrouping = false;
            this.radGridView.EnableHotTracking = true;
            this.radGridView.ShowFilteringRow = false;
            this.radGridView.EnableFiltering = true;
            this.radGridView.EnableCustomFiltering = true;            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);

            this.SelectedControl = this.filterTextBox;
        }

        private void radGridView1_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            if (string.IsNullOrEmpty(this.filterTextBox.Text))
            {
                this.radGridView.BeginUpdate();
                e.Visible = true;
                for (int i = 0; i < this.radGridView.ColumnCount; i++)
                {
                    e.Row.Cells[i].Style.Reset();                   
                }

                this.radGridView.EndUpdate(false);
                return;
            }
            this.radGridView.BeginUpdate();
            e.Visible = false;
            for (int i = 0; i < this.radGridView.ColumnCount; i++)
            {
                string text = e.Row.Cells[i].Value.ToString();
                if (text.IndexOf(this.filterTextBox.Text, 0, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    e.Visible = true;
                    e.Row.Cells[i].Style.CustomizeFill = true;
                    e.Row.Cells[i].Style.DrawFill = true;
                    e.Row.Cells[i].Style.BackColor = Color.FromArgb(201, 252, 254);
                }
                else
                {
                    e.Row.Cells[i].Style.Reset();                    
                }

                this.radGridView.EndUpdate(false);
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            this.radGridView.MasterTemplate.Refresh();
        }

        protected override void WireEvents()
        {
            this.radGridView.CustomFiltering += new Telerik.WinControls.UI.GridViewCustomFilteringEventHandler(this.radGridView1_CustomFiltering);
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
        }
    }
}
