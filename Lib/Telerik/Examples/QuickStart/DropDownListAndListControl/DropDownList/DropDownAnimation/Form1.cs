using System;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DropDownListAndListControl.DropDownList.DropDownAnimation
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private Timer showDropDownTimeout;

        public Form1()
        {
            InitializeComponent();

            this.radSpinFrames.Value = this.radComboDemo.DropDownAnimationFrames;
            this.radSpinFrames.Minimum = this.radComboDemo.DropDownAnimationFrames;

            this.radComboAnimType.Items.Add(new RadListDataItem("Select Animation:"));

            Array easingTypes = Enum.GetValues(typeof(RadEasingType));

            for (int i = 0; i < easingTypes.Length; i++)
            {
                this.radComboAnimType.Items.Add(new RadListDataItem(easingTypes.GetValue(i).ToString()));
            }

            this.radComboDemo.DropDownAnimationEnabled = true;
            this.radCheckEnableAnim.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radComboDemo.DropDownAnimationFrames = 7;
            this.radComboAnimType.SelectedIndex = 0;

            this.SelectedControl = this.radComboDemo;

            this.showDropDownTimeout = new Timer(this.components);
            this.showDropDownTimeout.Tick += new EventHandler(showDropDownTimeout_Tick);
            this.showDropDownTimeout.Interval = 1000;
            this.showDropDownTimeout.Start();

        }

        void showDropDownTimeout_Tick(object sender, EventArgs e)
        {
            this.showDropDownTimeout.Stop();
            this.radComboDemo.Focus();
            this.radComboDemo.ShowDropDown();
        }

        protected override void WireEvents()
        {
            this.radSpinFrames.ValueChanged += new System.EventHandler(this.OnRadSpinFrames_ValueChanged);
            this.radCheckEnableAnim.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnEnableAnimation_ToggleStateChanged);
            this.radComboAnimType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radComboAnimType_SelectedIndexChanged);
        }

        private void OnRadSpinFrames_ValueChanged(object sender, EventArgs e)
        {
            this.radComboDemo.DropDownAnimationFrames = (int)this.radSpinFrames.Value;
        }

        void radComboAnimType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            string easing = this.radComboAnimType.SelectedText;

            if (Enum.IsDefined(typeof(RadEasingType), easing))
                this.radComboDemo.DropDownAnimationEasing =
                    (RadEasingType)Enum.Parse(typeof(RadEasingType), this.radComboAnimType.SelectedText);
        }

        private void OnEnableAnimation_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radComboDemo.DropDownAnimationEnabled = this.radCheckEnableAnim.Checked;

        }

    }
}