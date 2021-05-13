using System;
using System.Drawing;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;
        }

        protected override void WireEvents()
        {
            this.radCheckBox3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radCheckBox2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
        }

		private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
		{
			this.radTextBoxEvents.Text += string.Format("{0} toggled" + Environment.NewLine, (sender as RadCheckBox).Text);
            this.radTextBoxEvents.SelectionStart = this.radTextBoxEvents.Text.Length;
            this.radTextBoxEvents.ScrollToCaret();
		}
    }
}