using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Forms.MDIMenuMerge
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class RadChildForm : ExamplesRadForm
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public RadChildForm()
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