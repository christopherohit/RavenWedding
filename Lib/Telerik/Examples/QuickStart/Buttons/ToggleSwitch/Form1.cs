using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;

namespace Telerik.Examples.WinControls.Buttons.ToggleSwitch
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.doubleBufferedTableLayoutPanel1;

            this.radTimePicker1.TimePickerElement.ShowSpinButtons = false;
        }

        private void radToggleSwitchReminder_ValueChanged(object sender, EventArgs e)
        {
            this.radDateTimePicker1.Enabled = this.radToggleSwitchReminder.Value;
            this.radTimePicker1.Enabled = this.radToggleSwitchReminder.Value;
        }

        private void radToggleSwitchRecurrence_ValueChanged(object sender, EventArgs e)
        {
            this.radDropDownListRecurrence.Enabled = this.radToggleSwitchRecurrence.Value;
        }

        private void radSpinEditorSwitchElasticity_ValueChanged(object sender, EventArgs e)
        {
            this.radToggleSwitchReminder.SwitchElasticity = (double)this.radSpinEditorSwitchElasticity.Value;
            this.radToggleSwitchRecurrence.SwitchElasticity = (double)this.radSpinEditorSwitchElasticity.Value;
            this.radToggleSwitchPlaySound.SwitchElasticity = (double)this.radSpinEditorSwitchElasticity.Value;
        }

        private void radSpinEditorThumbTickness_ValueChanged(object sender, EventArgs e)
        {
            this.radToggleSwitchReminder.ThumbTickness = (int)this.radSpinEditorThumbTickness.Value;
            this.radToggleSwitchRecurrence.ThumbTickness = (int)this.radSpinEditorThumbTickness.Value;
            this.radToggleSwitchPlaySound.ThumbTickness = (int)this.radSpinEditorThumbTickness.Value;
        }

        private void radCheckBoxAllowAnimation_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radToggleSwitchReminder.AllowAnimation = this.radCheckBoxAllowAnimation.ToggleState == ToggleState.On;
            this.radToggleSwitchRecurrence.AllowAnimation = this.radCheckBoxAllowAnimation.ToggleState == ToggleState.On;
            this.radToggleSwitchPlaySound.AllowAnimation = this.radCheckBoxAllowAnimation.ToggleState == ToggleState.On;
        }

        private void radCheckBoxRightToLeft_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radToggleSwitchReminder.RightToLeft = this.radCheckBoxRightToLeft.ToggleState == ToggleState.On ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
            this.radToggleSwitchRecurrence.RightToLeft = this.radCheckBoxRightToLeft.ToggleState == ToggleState.On ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
            this.radToggleSwitchPlaySound.RightToLeft = this.radCheckBoxRightToLeft.ToggleState == ToggleState.On ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No;
        }

        private void radButtonCreateAppointment_Click(object sender, EventArgs e)
        {
            RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
            RadMessageBox.Instance.EnableBeep = this.radToggleSwitchPlaySound.Value;
            RadMessageBox.Show("Appointment:" + Environment.NewLine + radTextBox1.Text +
                Environment.NewLine + "Successfully created.");
        }

        private void radSpinEditorAnimationFrames_ValueChanged(object sender, EventArgs e)
        {
             this.radToggleSwitchReminder.AnimationFrames = (int)this.radSpinEditorAnimationFrames.Value;
             this.radToggleSwitchRecurrence.AnimationFrames = (int)this.radSpinEditorAnimationFrames.Value;
             this.radToggleSwitchPlaySound.AnimationFrames = (int)this.radSpinEditorAnimationFrames.Value;
        }
    }
}