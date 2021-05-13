using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Forms.TabbedForm.Settings
{
    public partial class Form1 : ExamplesLauncherForm
    {
        private RadTabbedForm tabbedForm;

        public Form1()
        {
            InitializeComponent();

            this.radGroupSettings.Enabled = false;
            this.pinnedItemsDropDown.DataSource = Enum.GetValues(typeof(PinnedItemsPosition));
            this.dragModeDropDown.DataSource = Enum.GetValues(typeof(TabItemDragMode));
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (this.tabbedForm != null && this.tabbedForm.TabbedFormControl != null)
            {
                this.SyncTheme(this.tabbedForm);
            }
        }

        private void SyncTheme(RadTabbedForm form)
        {
            this.tabbedForm.ThemeName = this.CurrentThemeName;
            this.tabbedForm.TabbedFormControl.ThemeName = this.CurrentThemeName;
            this.UpdateSettings(this.tabbedForm.TabbedFormControl);
        }

        protected override void ShowForm()
        {
            if (this.tabbedForm == null || this.tabbedForm.IsDisposed)
            {
                this.tabbedForm = new RadTabbedForm();
                this.tabbedForm.ControlAdded += TabbedForm_ControlAdded;
                this.tabbedForm.FormClosed += TabbedForm_FormClosed;
                this.tabbedForm.TopMost = true;
                this.tabbedForm.Text = "Tabbed Form";
                this.tabbedForm.TabbedFormControlCreating += TabbedForm_TabbedFormControlCreating;

                this.tabbedForm.Show();
            }
        }

        protected override void CloseForm()
        {
            base.CloseForm();
            if (this.tabbedForm != null && this.tabbedForm.Visible)
            {
                this.tabbedForm.Close();
            }
        }

        private void TabbedForm_ControlAdded(object sender, ControlEventArgs e)
        {
            this.tabbedForm.ControlAdded -= TabbedForm_ControlAdded;
            this.SyncTheme(this.tabbedForm);

            this.captionHeightSpinEditor.ValueChanged += CaptionHeightSpinEditor_ValueChanged;
            this.tabHeightSpinEditor.ValueChanged += TabHeightSpinEditor_ValueChanged;
            this.tabSpacingSpinEditor.ValueChanged += TabSpacingSpinEditor_ValueChanged;
            this.tabWidthSpinEditor.ValueChanged += TabWidthSpinEditor_ValueChanged;
            this.minTabWidthSpinEditor.ValueChanged += MinTabWidthSpinEditor_ValueChanged;
            this.showCloseBtnCheckBox.CheckStateChanged += ShowCloseBtnCheckBox_CheckStateChanged;
            this.showPinBtnCheckBox.CheckStateChanged += ShowPinBtnCheckBox_CheckStateChanged;
            this.showNewBtnCheckBox.CheckStateChanged += ShowNewBtnCheckBox_CheckStateChanged;
            this.pinnedItemsDropDown.SelectedValueChanged += PinnedItemsDropDown_SelectedValueChanged;
            this.dragModeDropDown.SelectedValueChanged += DragModeDropDown_SelectedValueChanged;
            this.showIconCheckBox.CheckStateChanged += ShowIconCheckBox_CheckStateChanged;
            this.showTextCheckBox.CheckStateChanged += ShowTextCheckBox_CheckStateChanged;
            this.allowAeroCheckBox.CheckStateChanged += AllowAeroCheckBox_CheckStateChanged;
        }

        private void TabbedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.tabbedForm != null)
            {
                this.tabbedForm.TabbedFormControl.TabbedFormControlElement.ItemDragService.TabbedFormShown += ItemDragService_TabbedFormShown;
            }

            this.radGroupSettings.Enabled = false;

            this.captionHeightSpinEditor.ValueChanged -= CaptionHeightSpinEditor_ValueChanged;
            this.tabHeightSpinEditor.ValueChanged -= TabHeightSpinEditor_ValueChanged;
            this.tabSpacingSpinEditor.ValueChanged -= TabSpacingSpinEditor_ValueChanged;
            this.tabWidthSpinEditor.ValueChanged -= TabWidthSpinEditor_ValueChanged;
            this.minTabWidthSpinEditor.ValueChanged -= MinTabWidthSpinEditor_ValueChanged;
            this.showCloseBtnCheckBox.CheckStateChanged -= ShowCloseBtnCheckBox_CheckStateChanged;
            this.showPinBtnCheckBox.CheckStateChanged -= ShowPinBtnCheckBox_CheckStateChanged;
            this.showNewBtnCheckBox.CheckStateChanged -= ShowNewBtnCheckBox_CheckStateChanged;
            this.pinnedItemsDropDown.SelectedValueChanged -= PinnedItemsDropDown_SelectedValueChanged;
            this.dragModeDropDown.SelectedValueChanged -= DragModeDropDown_SelectedValueChanged;
            this.showIconCheckBox.CheckStateChanged -= ShowIconCheckBox_CheckStateChanged;
            this.showTextCheckBox.CheckStateChanged -= ShowTextCheckBox_CheckStateChanged;
            this.allowAeroCheckBox.CheckStateChanged -= AllowAeroCheckBox_CheckStateChanged;
            this.tabbedForm.FormClosed -= this.TabbedForm_FormClosed;
        }

        private void TabbedForm_TabbedFormControlCreating(object sender, TabbedFormControlCreatingEventArgs e)
        {
            this.tabbedForm.TabbedFormControlCreating -= this.TabbedForm_TabbedFormControlCreating;

            RadForm form = this.FindForm() as RadForm;
            if (form != null)
            {
                e.TabbedFormControl.Scale(form.RootElement.DpiScaleFactor);
            }

            this.radGroupSettings.Enabled = true;
            this.UpdateSettings(e.TabbedFormControl);
            e.TabbedFormControl.Tabs.Add(new RadTabbedFormControlTab());
            e.TabbedFormControl.Tabs.Add(new RadTabbedFormControlTab());

            e.TabbedFormControl.TabbedFormControlElement.ItemDragService.TabbedFormShown += ItemDragService_TabbedFormShown;
        }

        private void ItemDragService_TabbedFormShown(object sender, TabbedFormShownEventArgs e)
        {
            e.TabbedForm.TopMost = true;
        }

        private void ShowTextCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.ShowText = this.showTextCheckBox.Checked;
        }

        private void ShowIconCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            this.tabbedForm.ShowIcon = this.showIconCheckBox.Checked;
        }

        private void AllowAeroCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            this.tabbedForm.AllowAero = this.allowAeroCheckBox.IsChecked;
        }

        private void DragModeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.ItemDragMode = (TabItemDragMode)this.dragModeDropDown.SelectedValue;
        }

        private void PinnedItemsDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.PinnedItemsPosition = (PinnedItemsPosition)this.pinnedItemsDropDown.SelectedValue;
        }

        private void ShowNewBtnCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.ShowNewTabButton = this.showNewBtnCheckBox.IsChecked;
        }

        private void ShowPinBtnCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.ShowTabPinButton = this.showPinBtnCheckBox.IsChecked;
        }

        private void ShowCloseBtnCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.ShowTabCloseButton = this.showCloseBtnCheckBox.IsChecked;
        }

        private void MinTabWidthSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.MinimumTabWidth = (int)this.minTabWidthSpinEditor.Value;
        }

        private void TabWidthSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.TabWidth = (int)this.tabWidthSpinEditor.Value;
        }

        private void TabSpacingSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.TabSpacing = (int)this.tabSpacingSpinEditor.Value;
        }

        private void TabHeightSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.TabHeight = (int)this.tabHeightSpinEditor.Value;
        }

        private void CaptionHeightSpinEditor_ValueChanged(object sender, EventArgs e)
        {
            this.tabbedForm.TabbedFormControl.CaptionHeight = (int)this.captionHeightSpinEditor.Value;
        }

        private void UpdateSettings(RadTabbedFormControl tabbedControl)
        {
            SizeF descaleSize = new SizeF(1 / tabbedControl.RootElement.DpiScaleFactor.Width, 1 / tabbedControl.RootElement.DpiScaleFactor.Height);

            this.captionHeightSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.CaptionHeight, descaleSize);
            this.tabHeightSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.TabHeight, descaleSize);
            this.tabSpacingSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.TabSpacing, descaleSize);
            this.tabWidthSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.TabWidth, descaleSize);
            this.minTabWidthSpinEditor.Value = TelerikDpiHelper.ScaleInt(tabbedControl.MinimumTabWidth, descaleSize);
            this.showCloseBtnCheckBox.Checked = tabbedControl.ShowTabCloseButton;
            this.showPinBtnCheckBox.Checked = tabbedControl.ShowTabPinButton;
            this.showNewBtnCheckBox.Checked = tabbedControl.ShowNewTabButton;
            this.pinnedItemsDropDown.SelectedValue = tabbedControl.PinnedItemsPosition;
            this.dragModeDropDown.SelectedValue = tabbedControl.ItemDragMode;
        }
    }
}
