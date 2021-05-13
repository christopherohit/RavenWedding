using System;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Forms.StatusStrip
{
    /// <summary>
    /// example form
    /// </summary>
    public partial class Form1 : ExamplesRadForm, ISupportThemeName
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.radSplitButtonElement1.GetChildAt(1).GetChildAt(0).GetChildAt(2).AutoSize = true;

            this.timer1.Start();
        }

        protected override void WireEvents()
        {
            this.radButtonElement1.Click += new EventHandler(this.radButtonElement1_Click);
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.radProgressBarElement1.PerformStepValue1();
            if (this.radProgressBarElement1.Value1 >= this.radProgressBarElement1.Maximum)
                this.radProgressBarElement1.Value1 = this.radProgressBarElement1.Minimum;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Thank you for clicking RadButton", "StatusBarClick event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}