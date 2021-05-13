using System;
using System.ComponentModel;
using System.Drawing;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;
            ExamplesForm.FillComboFromEnum(this.editModeDropDownList, typeof(TimeSpanEditMode), TimeSpanEditMode.Combined);
            this.exampleTimeSpanPicker.PopupContentElement.ComponentsCreated += PopupContentElement_ComponentsCreated;
            this.exampleTimeSpanPicker.PopupOpened += ExampleTimeSpanPicker_PopupOpened;
        }

        private void ExampleTimeSpanPicker_PopupOpened(object sender, EventArgs e)
        {
            foreach (ITimeSpanPickerComponent component in this.exampleTimeSpanPicker.PopupContentElement.Components)
            {
                ListTimeSpanPickerUIComponent listUiCompoinent = component.TimeSpanPickerUIComponent as ListTimeSpanPickerUIComponent;
                if (this.changeStylesCheckBox.IsChecked)
                {
                    listUiCompoinent.Header.DrawFill = true;
                    listUiCompoinent.Header.GradientStyle = GradientStyles.Solid;
                    listUiCompoinent.Header.ForeColor = Color.OliveDrab;
                    listUiCompoinent.Header.BackColor = Color.LightGoldenrodYellow;
                }
                else
                {
                    listUiCompoinent.Header.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                    listUiCompoinent.Header.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                    listUiCompoinent.Header.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
                    listUiCompoinent.Header.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                }
            }

            TimeSpanPickerDoneButtonElement buttonPanel = (this.exampleTimeSpanPicker.PopupContentElement as RadTimeSpanPickerContentElement).FooterPanel;
            if (this.changeStylesCheckBox.IsChecked)
            {
                buttonPanel.DrawFill = true;
                buttonPanel.GradientStyle = GradientStyles.Solid;
                buttonPanel.BackColor = Color.OliveDrab;

                buttonPanel.ButtonElement.ButtonFillElement.Visibility = ElementVisibility.Visible;
                buttonPanel.ButtonElement.ButtonFillElement.GradientStyle = GradientStyles.Solid;
                buttonPanel.ButtonElement.ButtonFillElement.BackColor = Color.LightGoldenrodYellow;
                buttonPanel.ButtonElement.ForeColor = Color.OliveDrab;
            }
            else
            {
                buttonPanel.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                buttonPanel.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                buttonPanel.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);

                buttonPanel.ResetValue(Telerik.WinControls.Primitives.FillPrimitive.VisibilityProperty, ValueResetFlags.Local);
                buttonPanel.ResetValue(Telerik.WinControls.Primitives.FillPrimitive.GradientStyleProperty, ValueResetFlags.Local);
                buttonPanel.ResetValue(Telerik.WinControls.Primitives.FillPrimitive.BackColorProperty, ValueResetFlags.Local);
                buttonPanel.ResetValue(RadButtonElement.ForeColorProperty, ValueResetFlags.Local);
            }
        }

        private void PopupContentElement_ComponentsCreated(object sender, EventArgs e)
        {
            foreach (ITimeSpanPickerComponent component in this.exampleTimeSpanPicker.PopupContentElement.Components)
            {
                ListTimeSpanPickerUIComponent listUiCompoinent = component.TimeSpanPickerUIComponent as ListTimeSpanPickerUIComponent;
                listUiCompoinent.ListElement.Tag = this.exampleTimeSpanPicker.PopupContentElement.Components.IndexOf(component as RadItem);
                listUiCompoinent.ListElement.VisualItemFormatting += ListElement_VisualItemFormatting;
            }
        }

        private void ListElement_VisualItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            int componentIndex = (int)args.VisualItem.Data.Owner.Tag;
            if (this.changeStylesCheckBox.IsChecked && (args.VisualItem.Data.RowIndex + componentIndex) % 3 == 0)
            {
                Color backColor = Color.LemonChiffon;
                Color foreColor = Color.HotPink;
                if (componentIndex % 2 == 0)
                {
                    backColor = Color.YellowGreen;
                    foreColor = Color.LightGoldenrodYellow;
                }

                args.VisualItem.BackColor = backColor;
                args.VisualItem.GradientStyle = GradientStyles.Solid;
                args.VisualItem.ForeColor = foreColor;
            }
            else
            {
                args.VisualItem.ResetValue(RadListVisualItem.BackColorProperty, ValueResetFlags.Local);
                args.VisualItem.ResetValue(RadListVisualItem.GradientStyleProperty, ValueResetFlags.Local);
                args.VisualItem.ResetValue(RadListVisualItem.ForeColorProperty, ValueResetFlags.Local);
            }
        }

        private void EditModeDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.editModeDropDownList.SelectedValue != null)
            {
                this.exampleTimeSpanPicker.EditMode = (TimeSpanEditMode)this.editModeDropDownList.SelectedValue;
            }
        }

        private void SetFormatButton_Click(object sender, EventArgs e)
        {
            string text = this.formatTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                RadMessageBox.Show("Format String must be a non empty string.");
                this.formatTextBox.Text = this.exampleTimeSpanPicker.Format;
                return;
            }

            this.exampleTimeSpanPicker.Format = text;
        }

        private void spinButtonsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.exampleTimeSpanPicker.ShowSpinButtons = this.spinButtonsCheckBox.IsChecked;
        }

        private void MinValueTimeSpanPicker_ValueChanging(object sender, CancelEventArgs e)
        {
            ValueChangingEventArgs args = e as ValueChangingEventArgs;
            if (args != null)
            {
                TimeSpan newValue = (TimeSpan)args.NewValue;
                if (this.exampleTimeSpanPicker.MaxValue < newValue)
                {
                    args.Cancel = true;
                    RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                    RadMessageBox.Show("Minimum value must be lower than Maximum.");
                }
            }
        }

        private void MinValueTimeSpanPicker_ValueChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.MinValue = this.minValueTimeSpanPicker.Value.Value;
        }

        private void MaxValueTimeSpanPicker_ValueChanging(object sender, CancelEventArgs e)
        {
            ValueChangingEventArgs args = e as ValueChangingEventArgs;
            if (args != null)
            {
                TimeSpan newValue = (TimeSpan)args.NewValue;
                if (this.exampleTimeSpanPicker.MinValue > newValue)
                {
                    args.Cancel = true;
                    RadMessageBox.Instance.ThemeName = this.CurrentThemeName;
                    RadMessageBox.Show("Maximum value must be greater than Minimum.");
                }
            }
        }

        private void MaxValueTimeSpanPicker_ValueChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.MaxValue = this.maxValueTimeSpanPicker.Value.Value;
        }

        private void DaysStepSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.DaysStep = (int)this.daysStepSpinEditor.Value;
        }

        private void HoursStepSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.HoursStep = (int)this.hoursStepSpinEditor.Value;
        }

        private void MinutesStepSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.MinutesStep = (int)this.minutesStepSpinEditor.Value;
        }

        private void SecondsStepSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.SecondsStep = (int)this.secondsStepSpinEditor.Value;
        }

        private void MillisecondsStepSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.MillisecondsStep = (int)this.millisecondsStepSpinEditor.Value;
        }

        private void EnablNullValueCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.exampleTimeSpanPicker.EnableNullValueInput = this.enableNullValueCheckBox.IsChecked;
            this.nullTextTextBox.Enabled = this.enableNullValueCheckBox.IsChecked;
        }

        private void NullTextTextBox_TextChanged(object sender, EventArgs e)
        {
            this.exampleTimeSpanPicker.NullText = this.nullTextTextBox.Text;
        }
    }
}