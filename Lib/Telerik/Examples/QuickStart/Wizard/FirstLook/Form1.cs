using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.Wizard.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        #region Initialization

        public Form1()
        {
            InitializeComponent();

            this.radWizard1.Cancel += new EventHandler(radWizard1_Cancel);
            this.radWizard1.Finish += new EventHandler(radWizard1_Finish);
            this.radWizard1.Help += new EventHandler(radWizard1_Help);

            this.radButtonWelcome.Click += new EventHandler(radButtonWelcome_Click);
            this.radButtonWelcomeBrowse.Click += new EventHandler(radButtonWelcomeBrowse_Click);
            this.radDropDownListWelcome.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListWelcome_SelectedIndexChanged);
            this.radButtonWelcomeBackColor.Click += new EventHandler(radButtonWelcomeBackColor_Click);
            this.radCheckBoxWelcomeImage.ToggleStateChanged += new StateChangedEventHandler(radCheckBoxWelcomeImage_ToggleStateChanged);
            this.radButtonWelcomeReset.Click += new EventHandler(radButtonWelcomeReset_Click);

            this.radTextBoxPage1Title.TextChanged += new EventHandler(radTextBoxPage1Title_TextChanged);
            this.radCheckBoxPage1Title.ToggleStateChanged += new StateChangedEventHandler(radCheckBoxPage1Title_ToggleStateChanged);
            this.radTextBoxPage1Header.TextChanged += new EventHandler(radTextBoxPage1Header_TextChanged);
            this.radCheckBoxPage1Header.ToggleStateChanged += new StateChangedEventHandler(radCheckBoPage1Header_ToggleStateChanged);
            this.radButtonPage1Icon.Click += new EventHandler(radButtonPage1Icon_Click);
            this.radDropDownListIconAlignment.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(radDropDownListIconAlignment_SelectedIndexChanged);
            this.radButtonPage1Reset.Click += new EventHandler(radButtonPage1Reset_Click);

            this.radGridViewPage2.ValueChanging += new ValueChangingEventHandler(radGridViewPage2_ValueChanging);
            this.radButtonPage2Reset.Click += new EventHandler(radButtonPage2Reset_Click);

            this.radWizard1.Next += new WizardCancelEventHandler(radWizard1_Next);
            this.radWizard1.Previous += new WizardCancelEventHandler(radWizard1_Previous);
            this.radWizard1.SelectedPageChanged += new SelectedPageChangedEventHandler(radWizard1_SelectedPageChanged);

            this.radWizard1.ThemeNameChanged += new ThemeNameChangedEventHandler(radWizard1_ThemeNameChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radDropDownListWelcome.Items.Add(ImageLayout.None.ToString());
            this.radDropDownListWelcome.Items.Add(ImageLayout.Tile.ToString());
            this.radDropDownListWelcome.Items.Add(ImageLayout.Center.ToString());
            this.radDropDownListWelcome.Items.Add(ImageLayout.Stretch.ToString());
            this.radDropDownListWelcome.Items.Add(ImageLayout.Zoom.ToString());
            this.radDropDownListWelcome.SelectedIndex = 0;
            this.radDropDownListWelcome.Enabled = false;

            this.radDropDownListIconAlignment.Items.Add("Right");
            this.radDropDownListIconAlignment.Items.Add("Left");
            this.radDropDownListIconAlignment.SelectedIndex = 0;

            this.wizardPage1.CustomizePageHeader = true;
            this.wizardPage1.Icon = this.radWizard1.PageHeaderIcon;

            this.radGridViewPage2.Rows.Add("Next", true, true);
            this.radGridViewPage2.Rows.Add("Back", true, true);
            this.radGridViewPage2.Rows.Add("Cancel", true, true);
            this.radGridViewPage2.Rows.Add("Finish", false, true);
            this.radGridViewPage2.Rows.Add("Help", true, true);


            foreach (WizardPage page in radWizard1.Pages)
            {
                Screen showScreen = Screen.FromControl(this);
                SizeF scale = NativeMethods.GetMonitorDpi(showScreen, NativeMethods.DpiType.Effective);
                foreach (Control item in page.ContentArea.Controls)
                {
                    item.Scale(scale);
                }

            }
        }

        #endregion

        #region Event Handlers

        private void radWizard1_Cancel(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName(this.radWizard1.ThemeName);
            RadMessageBox.Show("You can implement your RadWizard Canceling logic using this event.", "RadWizard Cancel");
        }

        private void radWizard1_Finish(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName(this.radWizard1.ThemeName);
            DialogResult result = RadMessageBox.Show("Would you like to start  over?", "RadWizard Finish", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.radWizard1.SelectedPage = this.wizardWelcomePage1;
            }
        }

        private void radWizard1_Help(object sender, EventArgs e)
        {
            RadMessageBox.SetThemeName(this.radWizard1.ThemeName);
            RadMessageBox.Show("You can provide your RadWizard Help using this event.", "RadWizard Help");
        }
        
        private void radButtonWelcome_Click(object sender, EventArgs e)
        {
            this.radWizard1.WelcomeImage = global::Telerik.Examples.WinControls.Properties.Resources.WizardWelcomeImage;
            if (this.radWizard1.WelcomeImage != null)
            {
                this.radDropDownListWelcome.Enabled = true;
            }
        }

        private void radButtonWelcomeBrowse_Click(object sender, EventArgs e)
        {
            Image image = this.LoadImage();
            if (image == null)
            {
                return;
            }

            this.radWizard1.WelcomeImage = image;
            if (this.radWizard1.WelcomeImage != null)
            {
                this.radDropDownListWelcome.Enabled = true;
            }
        }

        private void radDropDownListWelcome_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.radWizard1.WelcomeImageLayout = (ImageLayout)e.Position;
        }

        private void radButtonWelcomeBackColor_Click(object sender, EventArgs e)
        {
            RadColorDialog radColorDialog = new RadColorDialog();
            ((RadForm)radColorDialog.ColorDialogForm).ThemeName = CurrentThemeName;
            if (radColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.radWizard1.WelcomeImageElement.BackColor = radColorDialog.SelectedColor;
                this.radWizard1.WelcomeImageElement.DrawFill = true;
                this.radWizard1.WelcomeImageElement.GradientStyle = GradientStyles.Solid;
                this.radWizard1.WelcomeImageElement.BackgroundImage = null;
            }
        }

        private void radCheckBoxWelcomeImage_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radWizard1.HideWelcomeImage = this.radCheckBoxWelcomeImage.ToggleState == ToggleState.Off;
            this.radButtonWelcomeBrowse.Enabled = this.radCheckBoxWelcomeImage.ToggleState != ToggleState.Off;
            this.radButtonWelcome.Enabled = this.radCheckBoxWelcomeImage.ToggleState != ToggleState.Off;
            this.radButtonWelcomeBackColor.Enabled = this.radCheckBoxWelcomeImage.ToggleState != ToggleState.Off;
            this.radDropDownListWelcome.Enabled = this.radCheckBoxWelcomeImage.ToggleState != ToggleState.Off && this.radWizard1.WelcomeImage != null;
        }

        private void radButtonWelcomeReset_Click(object sender, EventArgs e)
        {
            this.radCheckBoxWelcomeImage.ToggleState = ToggleState.On;
            this.radWizard1.WelcomeImage = null;
            this.radDropDownListWelcome.SelectedIndex = 0;
            this.radWizard1.WelcomeImageLayout = ImageLayout.None;
            this.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
            this.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
            this.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
            this.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.BackgroundImageProperty, ValueResetFlags.Local);
        }


        private void radTextBoxPage1Title_TextChanged(object sender, EventArgs e)
        {
            this.wizardPage1.Title = this.radTextBoxPage1Title.Text;
        }

        private void radCheckBoxPage1Title_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ElementVisibility titleVisibility = this.radCheckBoxPage1Title.ToggleState == ToggleState.On ? ElementVisibility.Visible : ElementVisibility.Collapsed;
            this.wizardPage1.TitleVisibility = titleVisibility;
        }

        private void radTextBoxPage1Header_TextChanged(object sender, EventArgs e)
        {
            this.wizardPage1.Header = this.radTextBoxPage1Header.Text;
        }

        private void radCheckBoPage1Header_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ElementVisibility headerVisibility = this.radCheckBoxPage1Header.ToggleState == ToggleState.On ? ElementVisibility.Visible : ElementVisibility.Collapsed;
            this.wizardPage1.HeaderVisibility = headerVisibility;
        }

        private void radButtonPage1Icon_Click(object sender, EventArgs e)
        {
            Image image = this.LoadImage();
            if (image != null)
            {
                this.wizardPage1.Icon = image;
            }
        }

        private void radDropDownListIconAlignment_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 0)
            {
                this.radWizard1.PageHeaderIconAlignment = ContentAlignment.MiddleRight;
            }
            else if (e.Position == 1)
            {
                this.radWizard1.PageHeaderIconAlignment = ContentAlignment.MiddleLeft;
            }
        }

        private void radButtonPage1Reset_Click(object sender, EventArgs e)
        {
            this.wizardPage1.Title = "Page Title";
            this.radTextBoxPage1Title.Text = "Page Title";
            this.radCheckBoxPage1Title.ToggleState = ToggleState.On;
            this.wizardPage1.TitleVisibility = ElementVisibility.Visible;
            this.wizardPage1.Header = "Short description";
            this.radTextBoxPage1Header.Text = "Short description";
            this.radCheckBoxPage1Header.ToggleState = ToggleState.On;
            this.wizardPage1.HeaderVisibility = ElementVisibility.Visible;
            this.wizardPage1.Icon = this.radWizard1.PageHeaderIcon;
            this.radDropDownListIconAlignment.SelectedIndex = 0;
            this.radWizard1.PageHeaderIconAlignment = ContentAlignment.MiddleRight;
        }
        
        private void radGridViewPage2_ValueChanging(object sender, ValueChangingEventArgs e)
        {
            if (this.radGridViewPage2.CurrentColumn.Name == "VisibleColumn")
            {
                switch (this.radGridViewPage2.CurrentRow.Index)
                {
                    case 0:
                        this.radWizard1.NextButton.Visibility = (bool)e.NewValue ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                        break;
                    case 1:
                        this.radWizard1.BackButton.Visibility = (bool)e.NewValue ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                        break;
                    case 2:
                        this.radWizard1.CancelButton.Visibility = (bool)e.NewValue ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                        break;
                    case 3:
                        this.radWizard1.FinishButton.Visibility = (bool)e.NewValue ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                        break;
                    case 4:
                        this.radWizard1.HelpButton.Visibility = (bool)e.NewValue ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                        break;
                    default:
                        break;
                }
            }
            else if (this.radGridViewPage2.CurrentColumn.Name == "EnabledColumn")
            {
                switch (this.radGridViewPage2.CurrentRow.Index)
                {
                    case 0:
                        this.radWizard1.NextButton.Enabled = (bool)e.NewValue;
                        break;
                    case 1:
                        this.radWizard1.BackButton.Enabled = (bool)e.NewValue;
                        break;
                    case 2:
                        this.radWizard1.CancelButton.Enabled = (bool)e.NewValue;
                        break;
                    case 3:
                        this.radWizard1.FinishButton.Enabled = (bool)e.NewValue;
                        break;
                    case 4:
                        this.radWizard1.HelpButton.Enabled = (bool)e.NewValue;
                        break;
                    default:
                        break;
                }
            }
        }

        private void radButtonPage2Reset_Click(object sender, EventArgs e)
        {
            this.ResetGridData();
            this.ResetButtonStates();
            this.radWizard1.WizardElement.Refresh();
        }
        
        private void radWizard1_Next(object sender, WizardCancelEventArgs e)
        {
            if (this.radWizard1.SelectedPage != this.wizardPage3)
            {
                return;
            }
            e.Cancel = true;

            if (this.radRadioButtonCompletionPage1.ToggleState == ToggleState.On)
            {
                this.radWizard1.SelectedPage = this.radWizard1.CompletionPage;
            }
            else
            {
                this.radWizard1.SelectedPage = this.wizardPage4;
            }
        }

        private void radWizard1_Previous(object sender, WizardCancelEventArgs e)
        {
            if (this.radWizard1.SelectedPage != this.radWizard1.CompletionPage && this.radWizard1.SelectedPage != this.wizardPage4)
            {
                return;
            }
            e.Cancel = true;

            this.radWizard1.SelectedPage = this.wizardPage3;
        }

        private void radWizard1_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.SelectedPage == this.wizardPage4)
            {
                this.radWizard1.NextButton.Visibility = ElementVisibility.Collapsed;
                this.radWizard1.FinishButton.Visibility = ElementVisibility.Visible;
            }
            else if (e.SelectedPage == this.wizardPage2 || e.PreviousPage == this.wizardPage2)
            {
                this.ResetGridData();
                this.ResetButtonStates();
            }
        }


        private void radWizard1_ThemeNameChanged(object source, ThemeNameChangedEventArgs args)
        {
            this.wizardPage1.Icon = this.radWizard1.PageHeaderIcon;
        }

        #endregion

        #region Methods

        private Image LoadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose Icon Image";
            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image icon = Image.FromFile(openFileDialog.FileName);
                return icon;
            }

            return null;
        }

        private void ResetGridData()
        {
            this.radGridViewPage2.Rows[0].Cells[1].Value = true;
            this.radGridViewPage2.Rows[0].Cells[2].Value = true;
            this.radGridViewPage2.Rows[1].Cells[1].Value = true;
            this.radGridViewPage2.Rows[1].Cells[2].Value = true;
            this.radGridViewPage2.Rows[2].Cells[1].Value = true;
            this.radGridViewPage2.Rows[2].Cells[2].Value = true;
            this.radGridViewPage2.Rows[3].Cells[1].Value = false;
            this.radGridViewPage2.Rows[3].Cells[2].Value = true;
            this.radGridViewPage2.Rows[4].Cells[1].Value = true;
            this.radGridViewPage2.Rows[4].Cells[2].Value = true;
        }

        private void ResetButtonStates()
        {
            this.radWizard1.NextButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local);
            this.radWizard1.BackButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local);
            this.radWizard1.CancelButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local);
            this.radWizard1.FinishButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local);
            this.radWizard1.HelpButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local);

            this.radWizard1.NextButton.Enabled = true;
            this.radWizard1.BackButton.Enabled = true;
            this.radWizard1.CancelButton.Enabled = true;
            this.radWizard1.FinishButton.Enabled = true;
            this.radWizard1.HelpButton.Enabled = true;
        }

        #endregion
    }
}