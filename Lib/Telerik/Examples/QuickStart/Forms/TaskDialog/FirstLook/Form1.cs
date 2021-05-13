using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.TaskDialog;

namespace Telerik.Examples.WinControls.Forms.TaskDialog.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        public Form1()
        {
            InitializeComponent();

            this.CenterPanel = true;

            this.radLabelInstallationImage.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.FlatShieldWarning, new Size(46, 46));
            this.radLabelWarningImage.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.FlatShieldWarning, new Size(46, 46));

            var border = this.radPanelInstallation.PanelElement.PanelBorder;
            border.Width = 1;
            border.GradientStyle = GradientStyles.Solid;

            border = this.radPanelWarning.PanelElement.PanelBorder;
            border.Width = 1;
            border.GradientStyle = GradientStyles.Solid;

            border = this.radPanelGameDifficulty.PanelElement.PanelBorder;
            border.Width = 1;
            border.GradientStyle = GradientStyles.Solid;

            this.radLabelGameDescription.ForeColor = MainForm.AccentColor;
        }

        public override void OnThemeChanged()
        {
            base.OnThemeChanged();

            if (TelerikHelper.IsMaterialTheme(this.CurrentThemeName))
            {
                this.radPanelInstallation.PanelElement.PanelBorder.ForeColor =
                    this.radPanelWarning.PanelElement.PanelBorder.ForeColor =
                    this.radPanelGameDifficulty.PanelElement.PanelBorder.ForeColor = Color.LightGray;
            }
        }

        private void ButtonInstallation_Click(object sender, EventArgs e)
        {
            string result = this.ShowInstallationExample();
        }

        private void ButtonDifficulty_Click(object sender, EventArgs e)
        {
            string result = this.ShowDiffucultyExample();
        }

        private void ButtonWarning_Click(object sender, EventArgs e)
        {
            string result = this.ShowWarningExample();
        }

        private string ShowInstallationExample()
        {
            // Disable the "Yes" button and only enable it when the check box is checked.
            // Also, don't close the dialog when this button is clicked.
            RadTaskDialogButton initialButtonYes = RadTaskDialogButton.Continue;
            initialButtonYes.Enabled = false;
            initialButtonYes.AllowCloseDialog = false;

            RadTaskDialogPage initialPage = new RadTaskDialogPage()
            {
                Caption = "Hardware Installation",
                Heading = "Installation Warning",
                Text = "The software you are installing for this hardware:\nPrinters\nhas not passed Windows Logo testing to verify its compatibility with Windows",
                Icon = RadTaskDialogIcon.ShieldWarningYellowBar,
                AllowCancel = true,

                Verification = new RadTaskDialogVerificationCheckBox()
                {
                    Text = "Install anyway"
                },

                CommandAreaButtons =
                {
                    initialButtonYes,
                    RadTaskDialogButton.Cancel
                },
                DefaultButton = RadTaskDialogButton.Cancel
            };

            RadTaskDialogPage inProgressPage = new RadTaskDialogPage()
            {
                Caption = "Hardware Installation",
                Heading = "Installation in progress...",
                Text = "Please wait while the installation is in progress.",
                Icon = RadTaskDialogIcon.Information,

                ProgressBar = new RadTaskDialogProgressBar()
                {
                    State = RadTaskDialogProgressBarState.Marquee
                },

                Expander = new RadTaskDialogExpander()
                {
                    Text = "Initializing...",
                    Position = RadTaskDialogExpanderPosition.AfterFootnote
                },

                CommandAreaButtons =
                {
                     RadTaskDialogButton.Cancel
                }
            };

            RadTaskDialogPage finishedPage = new RadTaskDialogPage()
            {
                Caption = "Hardware Installation",
                Heading = "Success!",
                Text = "The Printer installation completed successfully.",
                Icon = RadTaskDialogIcon.ShieldSuccessGreenBar,
                CommandAreaButtons =
                {
                    new RadTaskDialogButton("Finish")
                }
            };

            RadTaskDialogVerificationCheckBox checkBox = initialPage.Verification;
            checkBox.CheckedChanged += (sender, e) =>
            {
                initialButtonYes.Enabled = checkBox.Checked;
            };

            // When the user clicks "Yes", navigate to the second page.
            initialButtonYes.Click += (sender, e) =>
            {
                // Navigate to the "In Progress" page that displays the
                // current progress of the background work.
                initialPage.Navigate(inProgressPage);
            };

            inProgressPage.Created += delegate (object s, EventArgs e)
            {
                RadTaskDialogProgressBar progressBar = inProgressPage.ProgressBar;
                Timer timer = new Timer();
                timer.Interval = 2800;

                int progressValue = 0;
                timer.Start();
                timer.Tick += delegate (object sender, EventArgs args)
                {
                    timer.Interval = 40;

                    // When we display the first progress, switch the marquee progress bar
                    // to a regular one.
                    if (progressBar.State == RadTaskDialogProgressBarState.Marquee)
                        progressBar.State = RadTaskDialogProgressBarState.Normal;

                    progressBar.Value = progressValue;
                    inProgressPage.Expander.Text = string.Format("Installation Progress: {0} %", progressValue);

                    if (progressValue == 100)
                    {
                        timer.Stop();
                        timer.Dispose();

                        // Work is finished, so navigate to the third page.
                        inProgressPage.Navigate(finishedPage);
                    }

                    progressValue++;
                };
            };

            RadTaskDialog.CurrentForm.ThemeName = this.CurrentThemeName;
            RadTaskDialogButton result = RadTaskDialog.ShowDialog(initialPage, RadTaskDialogStartupLocation.CenterScreen);
            if (result != null && result.Text == "Finish")
            {
                return "Printer successfully installed";
            }
            else
            {
                return "Printer installation aborted";
            }
        }

        private string ShowDiffucultyExample()
        {
            RadTaskDialogPage page = new RadTaskDialogPage()
            {
                Caption = "Select Difficulty",
                Heading = "What level of difficulty do you want to play?",
                Icon = RadTaskDialogIcon.None,
                AllowCancel = true,
                Footnote = new RadTaskDialogFootnote("Note: You can change the difficulty level by clicking options in the game menu."),
                ContentAreaButtons =
                {
                    new RadTaskDialogCommandLinkButton ("Beginner", "10x10 cells"),
                    new RadTaskDialogCommandLinkButton ("Intermediate", "40x40 cells"),
                    new RadTaskDialogCommandLinkButton ("Advanced", "100x100 cells")
                }
            };

            RadTaskDialog.CurrentForm.ThemeName = this.CurrentThemeName;
            RadTaskDialogButton result = RadTaskDialog.ShowDialog(page, RadTaskDialogStartupLocation.CenterScreen);
            if (result == null)
            {
                return "Game closed";
            }
            else
            {
                return string.Format("You have chosen {0} difficulty", result.Text);
            }
        }

        private string ShowWarningExample()
        {
            RadTaskDialogPage page = new RadTaskDialogPage()
            {
                Caption = "Windows Security Difficulty",
                Heading = "Opening these files might be harmful to your computer",
                Text = "Your internet security settings blocked one or more files from being opened. Do you want to open these files anyway?",
                Icon = RadTaskDialogIcon.ShieldWarningYellowBar,
                AllowCancel = true,
                Footnote = new RadTaskDialogFootnote("Note: How do I decide whether to open these files?"),
                CommandAreaButtons = {
                    RadTaskDialogButton.Yes,
                    RadTaskDialogButton.No
                }
            };

            RadTaskDialog.CurrentForm.ThemeName = this.CurrentThemeName;
            RadTaskDialogButton result = RadTaskDialog.ShowDialog(page, RadTaskDialogStartupLocation.CenterScreen);
            if (result == null || result == RadTaskDialogButton.No)
            {
                return "User prevented the files from being opened.";
            }
            else
            {
                return "User agreed to open the files.";
            }
        }
    }
}
