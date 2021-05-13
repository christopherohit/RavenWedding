using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.SplitContainer.CollapsingPanels
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radSplitContainer1.EnableCollapsing = true;
            this.radCheckBox1.IsChecked = true;

            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ExamplesForm.FillComboFromEnum(this.radDropDownList1, typeof(Orientation), this.radSplitContainer1.Orientation);
            this.radSplitContainer1.UseSplitterButtons = true;
            this.radCheckBox2.Checked = true;

        }

        protected override void WireEvents()
        {
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownList1_SelectedIndexChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(radCheckBox1_ToggleStateChanged);
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(radCheckBox2_ToggleStateChanged);
        }


        void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radSplitContainer1.Orientation = (Orientation)this.radDropDownList1.SelectedItem.Value;
        }

        void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radSplitContainer1.EnableCollapsing = this.radCheckBox1.IsChecked;
            if (this.radCheckBox1.IsChecked && this.radCheckBox2.IsChecked) 
            {
                this.radSplitContainer1.UseSplitterButtons = true;
            }
        }

        void radCheckBox2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radSplitContainer1.UseSplitterButtons = this.radCheckBox2.IsChecked;
        }
    }
}
