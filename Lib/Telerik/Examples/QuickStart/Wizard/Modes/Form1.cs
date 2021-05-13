using System;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Wizard.Modes
{
    public partial class Form1 : RadForm, ISupportThemeName
    {
        #region Fields

        private Timer timerSearch;
        private Timer timerInstallation;
        private bool deviceFound = false;
        private bool installationCompleted = false;

        #endregion

        #region Initialization

        public Form1()
        {
            InitializeComponent();
            this.timerSearch = new Timer();
            this.timerSearch.Interval = 5000;
            this.timerInstallation = new Timer();
            this.timerInstallation.Interval = 1000;

            this.radWizard1.Cancel += new EventHandler(radWizard1_Cancel);
            this.radWizard1.Finish += new EventHandler(radWizard1_Finish);
            this.radWizard1.ModeChanged += new ModeChangedEventHandler(radWizard1_ModeChanged);

            this.radRadioButton97Mode.ToggleStateChanged += new StateChangedEventHandler(radRadioButton97Mode_ToggleStateChanged);
            this.radRadioButtonAeroMode.ToggleStateChanged += new StateChangedEventHandler(radRadioButtonAeroMode_ToggleStateChanged);
            this.radCheckBoxEnableAeroStyle.ToggleStateChanged += new StateChangedEventHandler(radCheckBoxEnableAeroStyle_ToggleStateChanged);

            this.radWizard1.SelectedPageChanged += new SelectedPageChangedEventHandler(radWizard1_SelectedPageChanged);
            this.radWizard1.Next += new WizardCancelEventHandler(radWizard1_Next);
            this.timerSearch.Tick += new EventHandler(timer_Tick);
            this.timerInstallation.Tick += new EventHandler(timerInstallation_Tick);
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            foreach (WizardPage page in this.radWizard1.Pages)
            {
                page.Icon = this.radWizard1.PageHeaderIcon;
            }

            this.radWizard1.PageHeaderElement.IconElement.Margin = new Padding(0, 20, 18, 0);
        }

        #endregion

        #region Event Handlers

        private void radWizard1_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radWizard1_Finish(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radWizard1_ModeChanged(object sender, ModeChangedEventArgs e)
        {
            if (e.CurrentMode == WizardMode.Wizard97)
            {
                this.radWizard1.PageHeaderElement.IconElement.Margin = new Padding(0, 20, 18, 0);
            }
            else
            {
                this.radWizard1.PageHeaderElement.IconElement.Margin = new Padding(6, 8, 0, 8);
            }
        }
        
        private void radRadioButton97Mode_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.ChangeMode();
        }

        private void radRadioButtonAeroMode_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.ChangeMode();
        }

        private void radCheckBoxEnableAeroStyle_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radWizard1.EnableAeroStyle = this.radCheckBoxEnableAeroStyle.ToggleState == ToggleState.On;
        }
        
        private void radWizard1_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            this.radWizard1.HelpButton.Visibility = ElementVisibility.Hidden;
            this.radWizard1.NextButton.Text = "Next   >";

            if (e.SelectedPage == this.wizardPage1 && !this.deviceFound)
            {
                this.radWizard1.BackButton.Enabled = false;
                this.radWizard1.NextButton.Enabled = false;
                this.radWaitingBarSearch.StartWaiting();
                this.timerSearch.Start();

                this.deviceFound = true;
            }
            else if (e.SelectedPage == this.wizardPage2 && !this.installationCompleted)
            {
                this.radWizard1.NextButton.Text = "Install";
            }
            else if (e.SelectedPage == this.wizardPage3)
            {
                this.radWizard1.NextButton.SetDefaultValueOverride(RadElement.VisibilityProperty, ElementVisibility.Collapsed);
                this.radWizard1.FinishButton.SetDefaultValueOverride(RadElement.VisibilityProperty, ElementVisibility.Visible);
            }
        }

        private void radWizard1_Next(object sender, WizardCancelEventArgs e)
        {
            if (this.radWizard1.SelectedPage == this.wizardPage2 && !this.installationCompleted)
            {
                this.radLabelInstallation.Visible = true;
                this.radProgressBarInstallation.Visible = true;
                this.radWizard1.BackButton.Enabled = false;
                this.radWizard1.NextButton.Enabled = false;
                this.timerInstallation.Start();

                e.Cancel = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.timerSearch.Stop();
            this.radWaitingBarSearch.StopWaiting();

            this.radLabelDevice.Text = "Web camera found.";
            this.radWaitingBarSearch.Visible = false;
            this.pictureBoxDevice.Visible = true;
            this.radWizard1.BackButton.Enabled = true;
            this.radWizard1.NextButton.Enabled = true;
        }

        private void timerInstallation_Tick(object sender, EventArgs e)
        {
            this.radProgressBarInstallation.Value1 += 20;
            if (this.radProgressBarInstallation.Value1 == this.radProgressBarInstallation.Maximum)
            {
                this.timerInstallation.Stop();
                this.radWizard1.BackButton.Enabled = true;
                this.radWizard1.NextButton.Enabled = true;
                this.radWizard1.NextButton.Text = "Next   >";
                this.installationCompleted = true;
            }
        }

        #endregion

        #region Methods

        private void ChangeMode()
        {
            if (this.radRadioButton97Mode.ToggleState == ToggleState.On)
            {
                this.radWizard1.Mode = WizardMode.Wizard97;
            }
            else
            {
                this.radWizard1.Mode = WizardMode.Aero;
            }

            this.radCheckBoxEnableAeroStyle.Enabled = this.radWizard1.Mode == WizardMode.Aero;
        }

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }

        #endregion
    }
}