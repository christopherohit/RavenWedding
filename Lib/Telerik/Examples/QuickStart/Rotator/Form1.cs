using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.Globalization;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.Rotator
{
    /// <summary>
    /// RadRotator example
    /// </summary>
    public partial class Form1 : ExamplesForm
    {
        private static Uri telerikUrl = new Uri("http://www.telerik.com/products/winforms.aspx");

        public Form1()
        {
            InitializeComponent();

			this.SelectedControl = this.radRotator1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radRotator1.StartRotation += new CancelEventHandler(radRotator1_StartRotation);
            this.locationAnimationTextBox.Text = SizeFToString(radRotator1.LocationAnimation);

            this.radTextBoxElement1.TextBoxItem.GotFocus += new EventHandler(TextBoxItem_GotFocus);

            radRotator1.Start();
        }

        private void TextBoxItem_GotFocus(object sender, EventArgs e)
        {
            radRotator1.Stop();
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            this.radRotator1.Previous();
        }

        private void locationAnimationTextBox_Click(object sender, EventArgs e)
        {
            this.radRotator1.Running = !this.radRotator1.Running;
        }

        private void radRotator1_BeginRotate(object sender, Telerik.WinControls.UI.BeginRotateEventArgs e)
        {
            this.currentFrameTextBox.Text = e.To.ToString();
        }

        private void radRotator1_StartRotation(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.radStartStopButton.Text = "||";

            string newURL = this.radTextBoxElement1.Text;
            Uri newUri = null;

            if (!string.IsNullOrEmpty(newURL) && !Uri.TryCreate(newURL, UriKind.Absolute, out newUri))
            {
                Uri.TryCreate(string.Format("http://{0}", newURL), UriKind.Absolute, out newUri);
            }

            if (newUri == null)
            {
                this.radWebBrowserItem1.Url = telerikUrl;
            }
            else
            {
                this.radWebBrowserItem1.Url = newUri;
            }

            this.radWebBrowserItem1.WebBrowserControl.ScriptErrorsSuppressed = true;
        }

        private void radRotator1_StopRotation(object sender, EventArgs e)
        {
            this.radStartStopButton.Text = ">";
        }

        private void radCheckBoxOpacity_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radRotator1.OpacityAnimation = radCheckBoxOpacity.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radButtonApply_Click(object sender, EventArgs e)
        {

            string newFramesValue = SetFramesInterval(intervalTextBox.Text);
            string newLocationValue = SetLocationAnimation(locationAnimationTextBox.Text);

            if (newFramesValue != null)
                this.intervalTextBox.Text = newFramesValue;

            if (newLocationValue != null)
                this.locationAnimationTextBox.Text = newLocationValue;
        }

        private string SetFramesInterval(string value)
        {
            int interval = 0;

            try
            {
                interval = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                return "500";
            }

            string result = null;

            if (interval < 500)
            {
                result = "500";
                interval = 500;
            }

            radRotator1.Interval = interval;

            return result;
        }

        private string SetLocationAnimation(string value)
        {
            string[] values = value.Split(',');

            if (values.Length != 2)
                return SizeFToString(radRotator1.LocationAnimation);

            
            SizeF newValue = new SizeF(0, 0);

            try
            {
                newValue.Width = float.Parse(values[0], CultureInfo.InvariantCulture);
                newValue.Height = float.Parse(values[1], CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return SizeFToString(radRotator1.LocationAnimation);
            }

            radRotator1.LocationAnimation = newValue;

            return null;
        }

        private string SizeFToString(SizeF value)
        {
            return string.Format("{0}, {1}", value.Width, value.Height);
        }

        private void currentFrameTextBox_TextChanged(object sender, EventArgs e)
        {
            //int frame;
            //try
            //{
            //    frame = Convert.ToInt32(radTextBox1.Text);
            //}
            //catch(Exception)
            //{
            //    return;
            //}

            //if (frame != this.radRotator1.CurrentIndex)
            //{
            //    this.radRotator1.CurrentIndex = frame;
            //}
        }

        private void radButtonPrevious_Click(object sender, EventArgs e)
        {
            this.radRotator1.Previous();
        }

        private void radButtonNext_Click(object sender, EventArgs e)
        {
            this.radRotator1.Next();
        }

        protected override void WireEvents()
        {
            this.radRotator1.BeginRotate += new Telerik.WinControls.UI.BeginRotateEventHandler(this.radRotator1_BeginRotate);
            this.radRotator1.StopRotation += new System.EventHandler(this.radRotator1_StopRotation);
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            this.radButtonPrevious.Click += new System.EventHandler(this.radButtonPrevious_Click);
            this.radButtonNext.Click += new System.EventHandler(this.radButtonNext_Click);
            this.radStartStopButton.Click += new System.EventHandler(this.locationAnimationTextBox_Click);
            this.currentFrameTextBox.TextChanged += new System.EventHandler(this.currentFrameTextBox_TextChanged);
            this.radCheckBoxOpacity.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBoxOpacity_ToggleStateChanged);
            this.radButtonApply.Click += new System.EventHandler(this.radButtonApply_Click);
        }
    }
}