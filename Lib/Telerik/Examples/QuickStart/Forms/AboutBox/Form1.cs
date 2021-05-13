using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Forms.AboutBox
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.radPanel1.PanelElement.PanelFill.Visibility = ElementVisibility.Collapsed;
            this.radPanel1.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            RadAboutBox1 aboutBox = new RadAboutBox1();
            
            aboutBox.ThemeName = this.CurrentThemeName;
            aboutBox.ShowDialog(this);
        }

        protected override void WireEvents()
        {
            this.radButton1.Click += new EventHandler(radButton1_Click);
        }
    }
}
