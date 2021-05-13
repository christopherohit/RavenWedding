using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.MenuStrip.Animation
{
	public partial class Form1 : ExamplesForm
	{
		public Form1()
		{
			InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            this.radComboAnimation.DataSource = Enum.GetValues(typeof(RadEasingType));
            this.radCheckEnabled.Checked = this.radMenuDemo.DropDownAnimationEnabled;
            this.radComboAnimation.SelectedIndex = this.radComboAnimation.FindStringExact( this.radMenuDemo.DropDownAnimationEasing.ToString());
            this.WireEvents();
            base.OnLoad(e);
        }

		private void radSpinEditorFrames_ValueChanged(object sender, EventArgs e)
		{
			this.radMenuDemo.DropDownAnimationFrames = (int)this.radSpinEditorFrames.Value;
		}

        private void radComboAnimation_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			switch (this.radComboAnimation.SelectedText)
			{
				case "Linear":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.Linear;
					break;
				case "InQuad":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InQuad;
					break;
				case "OutQuad":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutQuad;
					break;
				case "InOutQuad":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutQuad;
					break;
				case "InCubic":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InCubic;
					break;
				case "OutCubic":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutCubic;
					break;
				case "InOutCubic":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutCubic;
					break;
				case "InQuart":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InQuart;
					break;
				case "OutQuart":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutQuart;
					break;
				case "InOutQuart":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutQuart;
					break;
				case "InQuint":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InQuint;
					break;
				case "OutQuint":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutQuint;
					break;
				case "InOutQuint":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutQuint;
					break;
				case "InSine":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InSine;
					break;
				case "OutSine":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutSine;
					break;
				case "InOutSine":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutSine;
					break;
				case "InExponential":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InExponential;
					break;
				case "OutExponential":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutExponential;
					break;
				case "InOutExponential":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutExponential;
					break;
				case "InCircular":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InCircular;
					break;
				case "OutCircular":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutCircular;
					break;
				case "InOutCircular":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutCircular;
					break;
				case "InElastic":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InElastic;
					break;
				case "OutElastic":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutElastic;
					break;
				case "InOutElastic":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutElastic;
					break;
				case "InBack":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InBack;
					break;
				case "OutBack":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutBack;
					break;
				case "InOutBack":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutBack;
					break;
				case "InBounce":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InBounce;
					break;
				case "OutBounce":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.OutBounce;
					break;
				case "InOutBounce":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.InOutBounce;
					break;
				case "Default":
					this.radMenuDemo.DropDownAnimationEasing = RadEasingType.Default;
					break;
			}
		}

        private void OnRadCheck_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radMenuDemo.DropDownAnimationEnabled = this.radCheckEnabled.Checked;

        }

        protected override void WireEvents()
        {
            this.radCheckEnabled.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadCheck_ToggleStateChanged);
            this.radSpinEditorFrames.ValueChanged += new System.EventHandler(this.radSpinEditorFrames_ValueChanged);
            this.radComboAnimation.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboAnimation_SelectedIndexChanged);
        }
	}
}
