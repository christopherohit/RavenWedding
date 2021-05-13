using System;
using Telerik.Examples.WinControls.Editors;

namespace Telerik.Examples.WinControls.Buttons.RepeatButton
{
	/// <summary>
	/// Main class for the repeat button example
	/// </summary>
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radProgressBar1.Text = "";
            this.CenterPanel = true;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();
            if (this.CurrentThemeName == "VisualStudio2012Dark")
            {
                this.radPanelDemoHolder.PanelElement.PanelFill.BackColor = System.Drawing.Color.Black;
                this.radPanelDemoHolder.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            }
            else
            {
                this.radPanelDemoHolder.PanelElement.PanelFill.BackColor = System.Drawing.Color.Transparent;
                this.radPanelDemoHolder.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
        }
        private void radRepeatButton3_ButtonClick(object sender, EventArgs e)
		{
            if (this.radProgressBar1.Value1 < this.radProgressBar1.Maximum)
			{
                this.radProgressBar1.Value1 += 1;
			}
			else
			{
                this.radProgressBar1.Value1 = this.radProgressBar1.Minimum;
			}
		}

        protected override void WireEvents()
        {
            this.radRepeatButton3.ButtonClick += new System.EventHandler(this.radRepeatButton3_ButtonClick);
        }
    }
}