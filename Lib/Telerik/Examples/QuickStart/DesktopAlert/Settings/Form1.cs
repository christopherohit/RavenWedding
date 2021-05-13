using System;
using System.Drawing;
using Telerik.Examples.WinControls.Editors;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.DesktopAlert.Settings
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.FillDropDownThemes();
            this.radDesktopAlert1.ThemeName = this.ddThemeName.SelectedItem.Text;
            this.CenterPanel = true;
        }

        protected override void WireEvents()
        {
            this.closeButtonCheck.ToggleStateChanged += new StateChangedEventHandler(this.closeButtonCheck_ToggleStateChanged);
            this.pinButtonCheck.ToggleStateChanged += new StateChangedEventHandler(this.pinButtonCheck_ToggleStateChanged);
            this.ddScreenPosition.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.OnPositionList_IndexChaned);
            this.ddThemeName.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.OnThemesList_IndexChanged);
            this.fadeOutCheck.ToggleStateChanged += new StateChangedEventHandler(this.fadeOutCheck_ToggleStateChanged);
            this.checkPopupAnimation.ToggleStateChanged += new StateChangedEventHandler(this.checkPopupAnimation_ToggleStateChanged);
            this.fadeInCheck.ToggleStateChanged += new StateChangedEventHandler(this.fadeInCheck_ToggleStateChanged);
            this.spinPopupAnimationFrames.ValueChanged += new EventHandler(this.spinPopupAnimationFrames_ValueChanged);
            this.btnPreview.Click += new EventHandler(this.btnPreview_Click);
            this.spinFadeDuration.ValueChanged += new EventHandler(this.spinFadeDuration_ValueChanged);
            this.autoCloseCheck.ToggleStateChanged += new StateChangedEventHandler(this.autoCloseCheck_ToggleStateChanged);
            this.spinFadeDuration.ValueChanged += new EventHandler(this.spinFadeDuration_ValueChanged);
            this.spinOpacity.ValueChanged += new EventHandler(this.SpinOpacity_ValueChanged);
            this.optionsButtonCheck.ToggleStateChanged += new StateChangedEventHandler(this.optionsButtonCheck_ToggleStateChanged);
            this.spinEditorHeight.ValueChanged += new EventHandler(this.SpinEditorHeight_ValueChanged);
            this.spinEditorWidth.ValueChanged += new EventHandler(this.SpinEditorWidth_ValueChanged);
            this.autoCloseDelaySpin.ValueChanged += new EventHandler(this.autoCloseDelaySpin_ValueChanged);
            this.autoCloseCheck.ToggleStateChanged += new StateChangedEventHandler(this.autoCloseCheck_ToggleStateChanged);
            this.ddAnimationDirection.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddAnimationDirection_SelectedIndexChanged);
            this.ddThemeName.ThemeNameChanged += ddThemeName_ThemeNameChanged;
            this.autoSizeCheck.ToggleStateChanged += autoSizeCheck_ToggleStateChanged;
        }

        private void FillDropDownThemes()
        {
            foreach (string themeName in Utils.AllThemes)
            {
                this.ddThemeName.Items.Add(themeName);
            }

            // This is needed to set the order of themes in the DropDownList the same as ThemePanel.
            this.ddThemeName.Items.RemoveAt(this.ddThemeName.Items.IndexOf(Utils.ThemeName));
            this.ddThemeName.Items.Insert(0, new RadListDataItem(Utils.ThemeName));
            this.ddThemeName.Items[0].Selected = true;
        }

        #region Event handling

        private void autoSizeCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.AutoSize = this.autoSizeCheck.IsChecked;
            if (this.radDesktopAlert1.AutoSize)
            {
                this.radDesktopAlert1.FixedSize = Size.Empty;
            }
            else
            {
                this.radDesktopAlert1.FixedSize = new Size((int)this.spinEditorWidth.Value, (int)this.spinEditorHeight.Value);
            }
        }

        private void OnThemesList_IndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDesktopAlert1.ThemeName = this.ddThemeName.SelectedItem.Text;
        }

        private void OnPositionList_IndexChaned(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDesktopAlert1.ScreenPosition = (AlertScreenPosition)Enum.Parse(typeof(AlertScreenPosition), this.ddScreenPosition.SelectedItem.Text);
        }

        private void SpinEditorWidth_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.FixedSize = new Size((int)this.spinEditorWidth.Value, (int)this.spinEditorHeight.Value);
        }

        private void SpinEditorHeight_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.FixedSize = new Size((int)this.spinEditorWidth.Value, (int)this.spinEditorHeight.Value);
        }

        private void fadeInCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.fadeInCheck.ToggleState == ToggleState.On)
            {
                this.radDesktopAlert1.FadeAnimationType = this.radDesktopAlert1.FadeAnimationType | FadeAnimationType.FadeIn;
            }
            else
            {
                this.radDesktopAlert1.FadeAnimationType = this.radDesktopAlert1.FadeAnimationType & ~FadeAnimationType.FadeIn;
            }
        }

        private void fadeOutCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.fadeOutCheck.ToggleState == ToggleState.On)
            {
                this.radDesktopAlert1.FadeAnimationType = this.radDesktopAlert1.FadeAnimationType | FadeAnimationType.FadeOut;
            }
            else
            {
                this.radDesktopAlert1.FadeAnimationType = (this.radDesktopAlert1.FadeAnimationType & ~FadeAnimationType.FadeOut);
            }
        }

        private void spinFadeDuration_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.FadeAnimationFrames = (int)this.spinFadeDuration.Value;
        }

        private void autoCloseCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.AutoClose = this.autoCloseCheck.ToggleState == ToggleState.On;
        }

        private void closeButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.ShowCloseButton = args.ToggleState == ToggleState.On;
        }

        private void pinButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.ShowPinButton = args.ToggleState == ToggleState.On;
        }

        private void optionsButtonCheck_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.ShowOptionsButton = args.ToggleState == ToggleState.On;
        }

        private void checkPopupAnimation_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radDesktopAlert1.PopupAnimation = args.ToggleState == ToggleState.On;
        }

        private void ddAnimationDirection_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radDesktopAlert1.PopupAnimationDirection = (RadDirection)Enum.Parse(typeof(RadDirection), this.ddAnimationDirection.SelectedItem.Text);
        }

        private void spinPopupAnimationFrames_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.PopupAnimationFrames = (int)this.spinPopupAnimationFrames.Value;
        }
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.radDesktopAlert1.CaptionText = this.txtCaption.Text;
            this.radDesktopAlert1.ContentText = this.txtContent.Text;
            this.radDesktopAlert1.Show();
        }

        private void SpinOpacity_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.Opacity = (float)this.spinOpacity.Value;
        }

        private void autoCloseDelaySpin_ValueChanged(object sender, EventArgs e)
        {
            this.radDesktopAlert1.AutoCloseDelay = (int)this.autoCloseDelaySpin.Value;
        }

        private void ddThemeName_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            this.ddThemeName.SelectedIndex = this.ddThemeName.Items.IndexOf(args.newThemeName);
        }

        #endregion
    }
}
