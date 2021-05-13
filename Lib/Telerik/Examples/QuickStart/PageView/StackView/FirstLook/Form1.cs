using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.PageView.StackView.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.radioPositionBottom.Tag = StackViewPosition.Bottom;
            this.radioPositionTop.Tag = StackViewPosition.Top;
            this.radioPositionLeft.Tag = StackViewPosition.Left;
            this.radioPositionRight.Tag = StackViewPosition.Right;
            this.radioContentWithSelected.Tag = StackViewItemSelectionMode.ContentWithSelected;
            this.radioContentAfterSelected.Tag = StackViewItemSelectionMode.ContentAfterSelected;
            this.radioStandard.Tag = StackViewItemSelectionMode.Standard;

            this.radSpinEditor1.Value = 1;

            this.radioPositionBottom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.radioStandard.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.showHeaderCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void OnRadioSelectionSetting_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            RadRadioButton radioButton = sender as RadRadioButton;
            if (radioButton.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                (this.pageView1.ViewElement as RadPageViewStackElement).ItemSelectionMode = (StackViewItemSelectionMode)radioButton.Tag;
            }
        }

        private void OnRadioStackPositionSetting_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            RadRadioButton radioButton = sender as RadRadioButton;
            if (radioButton.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                (this.pageView1.ViewElement as RadPageViewStackElement).StackPosition = (StackViewPosition)radioButton.Tag;
            }
        }

        private void OnShowHeader_Checked(object sender, StateChangedEventArgs args)
        {
            this.pageView1.ViewElement.Header.Visibility = this.showHeaderCheck.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? ElementVisibility.Visible : ElementVisibility.Collapsed;
        }

        private void OnShowFooter_Checked(object sender, StateChangedEventArgs args)
        {
            this.pageView1.ViewElement.Footer.Visibility = this.showFooterCheck.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? ElementVisibility.Visible : ElementVisibility.Collapsed;
        }

        private void OnItemSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.pageView1.ViewElement.ItemSpacing = (int)this.radSpinEditor1.Value;
        }

        protected override void WireEvents()
        {
            this.radioContentWithSelected.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioSelectionSetting_ToggleStateChanged);
            this.radioContentAfterSelected.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioSelectionSetting_ToggleStateChanged);
            this.radioStandard.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioSelectionSetting_ToggleStateChanged);
            this.radioPositionRight.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioStackPositionSetting_ToggleStateChanged);
            this.radioPositionLeft.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioStackPositionSetting_ToggleStateChanged);
            this.radioPositionBottom.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioStackPositionSetting_ToggleStateChanged);
            this.radioPositionTop.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnRadioStackPositionSetting_ToggleStateChanged);
            this.showHeaderCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnShowHeader_Checked);
            this.showFooterCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.OnShowFooter_Checked);
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.OnItemSpacing_ValueChanged);
        }
    }
}
