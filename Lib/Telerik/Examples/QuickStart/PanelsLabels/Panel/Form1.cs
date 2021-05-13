using System;
using System.Drawing;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls.Primitives;

namespace Telerik.Examples.WinControls.PanelsLabels.Panel
{
    public partial class Form1 : EditorExampleBaseForm
    {
        BorderPrimitive border = null;
        FillPrimitive fill = null;

        public Form1()
        {
            InitializeComponent();

            border = (BorderPrimitive)this.radPanel1.PanelElement.Children[1];
            fill = (FillPrimitive)this.radPanel1.PanelElement.Children[0];
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radRadioButton5.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            border.Width = 1;
            border.ForeColor = Color.FromArgb(7, 81, 172);
            border.GradientStyle = Telerik.WinControls.GradientStyles.Solid;

            fill.BackColor = Color.FromArgb(47, 152, 247);
            fill.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            fill.BackColor = Color.Transparent;
            fill.BackColor2 = Color.Transparent;
            fill.BackColor3 = Color.Transparent;
            fill.BackColor4 = Color.Transparent;
        }

        protected override void WireEvents()
        {
            this.radRadioButton3.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton3_ToggleStateChanged);
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radRadioButton4.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton4_ToggleStateChanged);
            this.radRadioButton5.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton5_ToggleStateChanged);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            this.radRadioButton6.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton6_ToggleStateChanged);
        }

        private void radRadioButton2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            fill.BackColor = Color.FromArgb(47, 152, 247);
            fill.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
        }

        private void radRadioButton3_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            fill.BackColor2 = Color.FromArgb(47, 152, 247);
            fill.BackColor = Color.FromArgb(213, 234, 253);
            fill.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            border.Width = (float) this.radSpinEditor1.Value;
        }

        private void radRadioButton4_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            border.ForeColor = Color.Transparent;
            border.ForeColor2 = Color.Transparent;
            border.ForeColor3 = Color.Transparent;
            border.ForeColor4 = Color.Transparent;
        }

        private void radRadioButton5_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            border.ForeColor = Color.FromArgb(7, 81, 172);
            border.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
        }

        private void radRadioButton6_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            border.ForeColor = Color.FromArgb(7, 81, 172);
            border.ForeColor2 = Color.FromArgb(7, 81, 172);
            border.ForeColor3 = Color.FromArgb(212, 0, 176);
            border.ForeColor4 = Color.FromArgb(212, 0, 176);
            border.GradientStyle = Telerik.WinControls.GradientStyles.Linear;
        }
    }
}
