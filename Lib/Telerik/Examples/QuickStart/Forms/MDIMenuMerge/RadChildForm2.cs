using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Forms.MDIMenuMerge
{
    public partial class RadChildForm2 : ExamplesRadForm
    {
        public RadChildForm2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.radProgressBarElement1.PerformStepValue1();
            if (this.radProgressBarElement1.Value1 >= this.radProgressBarElement1.Maximum)
                this.radProgressBarElement1.Value1 = this.radProgressBarElement1.Minimum;
        }

        protected override void WireEvents()
        {
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Thank you for clicking RadButton", "StatusBarClick event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
