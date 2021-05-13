using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.TrackStatusControls.WaitingBar.Settings
{
    public partial class Form1 : ExamplesForm
    {
        private LineRingWaitingBarIndicatorElement lineRingWaitingBarIndicatorElement1;
        bool changingTheme = false;

        public Form1()
        {
            InitializeComponent();
            this.radWaitingBar1.ThemeNameChanged += radWaitingBar1_ThemeNameChanged;
            this.lineRingWaitingBarIndicatorElement1 = this.radWaitingBar1.WaitingIndicators[0] as LineRingWaitingBarIndicatorElement;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ExamplesForm.FillComboFromEnum(this.radDropDownList1, typeof(RotationDirection), RotationDirection.Clockwise);
            this.radWaitingBar1.StartWaiting();
            this.UpdateEditorValues();
        }

        private void UpdateEditorValues()
        {
            this.changingTheme = true;

            this.lineThicknessSpinEditor.Value = (decimal)this.lineRingWaitingBarIndicatorElement1.LineThickness;
            this.elementCountSpinEditor.Value = this.lineRingWaitingBarIndicatorElement1.ElementCount;
            this.radiusSpinEditor.Value = this.lineRingWaitingBarIndicatorElement1.Radius;
            this.innerRadiusSpinEditor.Value = this.lineRingWaitingBarIndicatorElement1.InnerRadius;
            this.radDropDownList1.SelectedValue = this.lineRingWaitingBarIndicatorElement1.RotationDirection.ToString();
            this.elementColorColorBox.Value = this.lineRingWaitingBarIndicatorElement1.ElementColor;
            this.elementColor2ColorBox.Value = this.lineRingWaitingBarIndicatorElement1.ElementColor2;
            this.elementColor3ColorBox.Value = this.lineRingWaitingBarIndicatorElement1.ElementColor3;
            this.elementColor4ColorBox.Value = this.lineRingWaitingBarIndicatorElement1.ElementColor4;
            this.gradientPercentageSpinEditor.Value = (decimal)this.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage;
            this.gradientPercentage2SpinEditor.Value = (decimal)this.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage2;
            this.numberOfColorsSpinEditor.Value = this.lineRingWaitingBarIndicatorElement1.ElementNumberOfColors;

            this.changingTheme = false;
        }

        private void radWaitingBar1_ThemeNameChanged(object source, Telerik.WinControls.ThemeNameChangedEventArgs args)
        {
            this.UpdateEditorValues();
        }

        private void lineThicknessSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

                this.lineRingWaitingBarIndicatorElement1.LineThickness = (double)this.lineThicknessSpinEditor.Value;
        }

        private void elementCountSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementCount = (int)this.elementCountSpinEditor.Value;
        }

        private void radiusSpinEditor_ValueChanging(object sender, ValueChangingEventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            try
            {
                this.lineRingWaitingBarIndicatorElement1.Radius = Convert.ToInt32(e.NewValue);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                this.lineRingWaitingBarIndicatorElement1.Radius = Convert.ToInt32(e.OldValue);
                RadMessageBox.Show(ex.Message);
            }
        }

        private void innerRadiusSpinEditor_ValueChanging(object sender, ValueChangingEventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            try
            {
                this.lineRingWaitingBarIndicatorElement1.InnerRadius = Convert.ToInt32(e.NewValue);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                this.lineRingWaitingBarIndicatorElement1.InnerRadius = Convert.ToInt32(e.OldValue);
                RadMessageBox.Show(ex.Message);
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.RotationDirection = (RotationDirection)this.radDropDownList1.SelectedValue;
        }

        private void elementColorColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementColor = this.elementColorColorBox.Value;
        }

        private void elementColor2ColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementColor2 = this.elementColor2ColorBox.Value;
        }

        private void elementColor3ColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementColor3 = this.elementColor3ColorBox.Value;
        }

        private void elementColor4ColorBox_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementColor4 = this.elementColor4ColorBox.Value;
        }

        private void gradientPercentageSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage = (float)this.gradientPercentageSpinEditor.Value;
        }

        private void gradientPercentage2SpinEditor_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage2 = (float)this.gradientPercentage2SpinEditor.Value;
        }

        private void numberOfColorsSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            if (this.changingTheme)
            {
                return;
            }

            this.lineRingWaitingBarIndicatorElement1.ElementNumberOfColors = (int)this.numberOfColorsSpinEditor.Value;
        }

        private void animationSpeedSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.radWaitingBar1.WaitingSpeed = (int)this.animationSpeedSpinEditor.Value;
        }

        private void animationStepSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.radWaitingBar1.WaitingStep = (int)this.animationStepSpinEditor.Value;
        }
    }
}
