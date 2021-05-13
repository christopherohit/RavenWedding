using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.GridView.Globalization.RTL
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
			this.SelectedControl = this.radGridView1;
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindRadGridView.Customers);

            this.radGridView1.MasterTemplate.Columns[0].VisibleInColumnChooser = false;
            this.radGridView1.MasterTemplate.Columns[1].AllowGroup = false;

            this.radToggleButton1.ToggleState = ToggleState.On;
        }

        private void radToggleButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radToggleButton1.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.radGridView1.RightToLeft = RightToLeft.No;
            }
        }

        protected override void WireEvents()
        {
            this.radToggleButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radToggleButton1_ToggleStateChanged);
        }
	}	
}
