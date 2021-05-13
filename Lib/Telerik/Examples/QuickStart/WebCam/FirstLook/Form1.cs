using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Editors;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.WebCam.FirstLook
{
    public partial class Form1 : EditorExampleBaseForm
    {
        private Image DefaultImage;
        private string userNameCache;
        private string emailCache;

        public Form1()
        {
            this.InitializeComponent();
            this.CenterPanel = true;

            this.DefaultImage = Image.FromFile(@"..\Resources\Tori.png");
            this.SetPanelImage(this.DefaultImage);

            RadButtonElement closeButton = new RadButtonElement();
            closeButton.SetDefaultValueOverride(RadButtonElement.PaddingProperty, new Padding(3));
            closeButton.TextElement.CustomFont = "Font Awesome 5 Free Solid";
            closeButton.TextElement.CustomFontSize = 12;
            closeButton.Text = "\uf00d";
            closeButton.Click += this.StopCameraButtonClick;
            this.radWebCam1.WebCamElement.LeftElementsStack.Children.Add(closeButton);

            this.radWebCam1.WebCamElement.ToggleRecordingButton.Visibility = ElementVisibility.Collapsed;
            this.radWebCam1.Hide();

            this.takePhotoButton.Text = "\ue500";
            this.deletePhotoButton.Text = "\ue10C";
            this.takePhotoButton.RootElement.BackColor = Color.Transparent;
            this.deletePhotoButton.RootElement.BackColor = Color.Transparent;

            this.editUserNameButton.ButtonElement.TextElement.CustomFont = "TelerikWebUI";
            this.editUserNameButton.Text = "\ue10B";

            this.editEmailButton.ButtonElement.TextElement.CustomFont = "TelerikWebUI";
            this.editEmailButton.Text = "\ue10B";
        }

        private void SetPanelImage(Image image)
        {
            float widthCoefficient = this.radWebCam1.Width / (float)image.Width;
            float heightCoefficient = this.radWebCam1.Height / (float)image.Height;
            float scaleCoeff = Math.Min(widthCoefficient, heightCoefficient);
            Size scaledSize = new Size((int)(image.Width * scaleCoeff), (int)(image.Height * scaleCoeff));
            
            image = new Bitmap(image, scaledSize);
            this.panel1.BackgroundImage = image;
        }

        private void WebCam1_SnapshotTaken(object sender, SnapshotTakenEventArgs e)
        {
            this.StopCamera();

            this.SetPanelImage(e.Snapshot);
            this.deletePhotoButton.Enabled = true;
        }

        private void TakePhotoButton_Click(object sender, EventArgs e)
        {
            this.StartCamera();
        }

        private void DeletePhotoButton_Click(object sender, EventArgs e)
        {
            this.SetPanelImage(this.DefaultImage);
            this.deletePhotoButton.Enabled = false;
        }

        private void StopCameraButtonClick(object sender, EventArgs e)
        {
            this.StopCamera();
        }

        private void StartCamera()
        {
            this.takePhotoLabel.Visible = false;
            this.takePhotoButton.Visible = false;
            this.deletePhotoButton.Visible = false;
            this.radWebCam1.Visible = true;

            this.radWebCam1.Start();
        }

        private void StopCamera()
        {
            this.radWebCam1.Stop();
            if (this.radWebCam1.IsPreviewingSnapshot)
            {
                this.radWebCam1.DiscardSnapshot();
            }

            this.radWebCam1.Hide();
            this.takePhotoButton.Visible = true;
            this.deletePhotoButton.Visible = true;
            this.takePhotoLabel.Visible = true;
        }

        private void EndEditButtonClick(object sender, EventArgs e)
        {
            this.editUserNameButton.Enabled = true;
            this.userNameTextBox.Enabled = false;
            this.editEmailButton.Enabled = true;
            this.emailTextBox.Enabled = false;
            this.cancelButton.Enabled = false;
            this.saveButton.Enabled = false;

            if (sender == this.cancelButton)
            {
                this.userNameTextBox.Text = this.userNameCache;
                this.emailTextBox.Text = this.emailCache;
            }

            this.userNameCache = string.Empty;
            this.emailCache = string.Empty;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.editUserNameButton.Enabled = false;
            this.editEmailButton.Enabled = false;
            this.saveButton.Enabled = true;
            this.cancelButton.Enabled = true;

            this.userNameCache = this.userNameTextBox.Text;
            this.emailCache = this.emailTextBox.Text;
            if (sender == this.editUserNameButton)
            {
                this.userNameTextBox.Enabled = true;
                this.userNameTextBox.Focus();
            }
            else
            {
                this.emailTextBox.Enabled = true;
                this.emailTextBox.Focus();
            }
        }
    }
}