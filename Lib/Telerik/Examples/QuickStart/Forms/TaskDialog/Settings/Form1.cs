using System;
using System.Drawing;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.TaskDialog;

namespace Telerik.Examples.WinControls.Forms.TaskDialog.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;

            this.AddIconToIconsList(RadTaskDialogIcon.None, true);
            this.AddIconToIconsList(RadTaskDialogIcon.Information);
            this.AddIconToIconsList(RadTaskDialogIcon.Warning);
            this.AddIconToIconsList(RadTaskDialogIcon.Error);
            this.AddIconToIconsList(RadTaskDialogIcon.Shield);
            this.AddIconToIconsList(RadTaskDialogIcon.ShieldBlueBar);
            this.AddIconToIconsList(RadTaskDialogIcon.ShieldGrayBar);
            this.AddIconToIconsList(RadTaskDialogIcon.ShieldWarningYellowBar);
            this.AddIconToIconsList(RadTaskDialogIcon.ShieldErrorRedBar);
            this.AddIconToIconsList(RadTaskDialogIcon.ShieldSuccessGreenBar);
            this.radDropDownListIcon.ShowImageInEditorArea = true;

            FillComboFromEnum(this.radDropDownListProgressbarState, typeof(RadTaskDialogProgressBarState), RadTaskDialogProgressBarState.None);

            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.OK, true);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Cancel, true);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Retry);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Close);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.TryAgain);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Yes);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.No);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Continue);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Ignore);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Abort);
            this.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Help);
        }

        private void AddIconToIconsList(RadTaskDialogIcon icon, bool isSelected = false)
        {
            RadListDataItem item = new RadListDataItem(icon.IconType.ToString(), icon);
            if (icon.SvgImage != null)
            {
                item.SvgImage = (RadSvgImage)icon.SvgImage.Clone();
                item.SvgImage.Size = new Size(16, 16);
            }
            else
            {
                item.Text = "None";
            }

            if (isSelected)
            {
                item.Selected = true;
            }

            this.radDropDownListIcon.Items.Add(item);
        }

        private void AddCommandButtonToCommandButtonsList(RadTaskDialogButton button, bool isChecked = false)
        {
            RadCheckedListDataItem item = new RadCheckedListDataItem(button.Text, isChecked);
            item.Tag = button;
            this.radCheckedDropDownListCommandButtons.Items.Add(item);
        }

        private void RadButtonShowDialog_Click(object sender, EventArgs e)
        {
            RadTaskDialogPage page = new RadTaskDialogPage();
            page.Caption = this.radTextBoxCaption.Text;
            page.Heading = this.radTextBoxHeading.Text;

            page.Icon = (RadTaskDialogIcon)this.radDropDownListIcon.SelectedValue;

            page.Text = this.radTextBoxPageText.Text;

            page.ProgressBar.State = (RadTaskDialogProgressBarState)this.radDropDownListProgressbarState.SelectedValue;
            page.ProgressBar.Value = 75;
            page.ProgressBar.Text = "Loading";

            if (this.radCheckBoxRadioButtons.IsChecked)
            {
                page.RadioButtons.Add(new RadTaskDialogRadioButton("Expander position - After text") { Tag = RadTaskDialogExpanderPosition.AfterText, IsChecked = true });
                page.RadioButtons.Add(new RadTaskDialogRadioButton("Expander position - After footnote") { Tag = RadTaskDialogExpanderPosition.AfterFootnote });
                foreach (RadTaskDialogRadioButton rb in page.RadioButtons)
                {
                    rb.ToggleStateChanged += delegate (object sender1, StateChangedEventArgs args)
                    {
                        page.Expander.Position = (RadTaskDialogExpanderPosition)(sender1 as RadTaskDialogRadioButton).Tag;
                    };
                }
            }

            if (this.radCheckBoxCommandLinkButtons.IsChecked)
            {
                RadTaskDialogCommandLinkButton button = new RadTaskDialogCommandLinkButton("Caution", "This button will close the dialog.");
                button.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.GradientStop, new Size(26, 26));
                page.ContentAreaButtons.Add(button);

                button = new RadTaskDialogCommandLinkButton("Success", "This button will not close the dialog.", allowCloseDialog: false);
                button.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.GradientShieldSuccess, new Size(26, 26));
                page.ContentAreaButtons.Add(button);

                page.ContentAreaButtons.Add(new RadTaskDialogCommandLinkButton("Sample button"));
            }

            page.Expander.Text = this.radTextBoxExpander.Text;

            page.Verification.Text = this.radTextBoxVerification.Text;

            foreach (RadCheckedListDataItem item in this.radCheckedDropDownListCommandButtons.CheckedItems)
            {
                page.CommandAreaButtons.Add((RadTaskDialogButton)item.Tag);
            }

            page.Footnote.Text = this.radTextBoxFootnote.Text;

            RadTaskDialog.CurrentForm.ThemeName = this.CurrentThemeName;
            RadTaskDialog.Show(page);
        }
    }
}
