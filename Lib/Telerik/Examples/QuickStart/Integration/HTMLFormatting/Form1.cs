using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Integration.HTMLFormatting
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radTextBox1.Text = this.radLabel1.Text;
            this.radButton2.Click += new EventHandler(radButton2_Click);
            this.radTextBox1.Text = "<html><p><span style=\"font-size: large\">RadLabel</span></p><p><span style=\"font-size: medium\"><strong>Arial, Bold</strong></span></p><p><span style=\"font-size: small\"><em><span style=\"font-family: times new roman\">Times, Italic, <u>Underline</u></span></em></span></p><p><em><span style=\"font-family: times new roman; color: #0080ff; font-size: 18pt\">Sample Text</span></em></p></html>";
        }

        void radButton2_Click(object sender, EventArgs e)
        {
            using (RadMarkupDialog dialog = new RadMarkupDialog())
            {
                Telerik.WinControls.ThemeResolutionService.ApplyThemeToControlTree(dialog.Form, this.CurrentThemeName);
                dialog.Value = this.radTextBox1.Text;

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.radTextBox1.Text = dialog.Value;
                }
            }      
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.radLabel1.Text = this.radTextBox1.Text;
        }

        protected override void WireEvents()
        {
            this.radTextBox1.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
        }
    }
}