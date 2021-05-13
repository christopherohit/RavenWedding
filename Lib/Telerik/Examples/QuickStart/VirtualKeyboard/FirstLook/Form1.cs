using System;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;

namespace Telerik.Examples.WinControls.VirtualKeyboard.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        Control focusedControl = null;

        public Form1()
        {
            this.InitializeComponent();
            this.CenterPanel = true;
            this.radPanelDemoHolder.PanelElement.Padding = new Padding(0);
            this.focusedControl = this.radTextBoxTitle;
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radTextBoxTitle.GotFocus += this.RadTextBoxTitle_GotFocus;
            this.radTextBoxDescription.GotFocus += this.RadTextBoxTitle_GotFocus;
            this.radVirtualKeyboard1.MouseDown += this.RadVirtualKeyboard1_MouseDown;
        }

        private void RadTextBoxTitle_GotFocus(object sender, EventArgs e)
        {
            this.focusedControl = sender as Control;
            if (!this.radToggleSwitchEnableKeyboard.Value)
            {
                this.radToggleSwitchEnableKeyboard.Value = true;
            }
        }

        private void RadVirtualKeyboard1_MouseDown(object sender, MouseEventArgs e)
        {
            this.focusedControl.Focus();
        }

        private void ToggleKeyboardToggleSwitch_ValueChanged(object sender, EventArgs e)
        {
            this.radVirtualKeyboard1.Visible = this.radToggleSwitchEnableKeyboard.Value;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.radTextBoxTitle.Clear();
            this.radTextBoxDescription.Clear();
            this.radTextBoxTitle.Focus();
        }
    }
}