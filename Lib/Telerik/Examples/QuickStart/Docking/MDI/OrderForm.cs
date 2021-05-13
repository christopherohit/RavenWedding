using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.Docking.MDI
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.ordersTableAdapter.Update(this.nwindRadGridView.Orders);

        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // TODO: This line of code loads data into the 'nwindRadGridView.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindRadGridView.Orders);
        }
    }
}