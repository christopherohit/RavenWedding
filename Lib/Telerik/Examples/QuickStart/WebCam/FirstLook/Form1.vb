Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.WebCam.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private DefaultImage As Image
        Private userNameCache As String
        Private emailCache As String

        Public Sub New()
            Me.InitializeComponent()
            Me.CenterPanel = True
            Me.DefaultImage = Image.FromFile("..\Resources\Tori.png")
            Me.SetPanelImage(Me.DefaultImage)
            Dim closeButton As RadButtonElement = New RadButtonElement()
            closeButton.SetDefaultValueOverride(RadButtonElement.PaddingProperty, New Padding(3))
            closeButton.TextElement.CustomFont = "Font Awesome 5 Free Solid"
            closeButton.TextElement.CustomFontSize = 12
            closeButton.Text = ""
            AddHandler closeButton.Click, AddressOf Me.StopCameraButtonClick
            Me.radWebCam1.WebCamElement.LeftElementsStack.Children.Add(closeButton)
            Me.radWebCam1.WebCamElement.ToggleRecordingButton.Visibility = ElementVisibility.Collapsed
            Me.radWebCam1.Hide()
            Me.takePhotoButton.Text = ""
            Me.deletePhotoButton.Text = ""
            Me.takePhotoButton.RootElement.BackColor = Color.Transparent
            Me.deletePhotoButton.RootElement.BackColor = Color.Transparent
            Me.editUserNameButton.ButtonElement.TextElement.CustomFont = "TelerikWebUI"
            Me.editUserNameButton.Text = ""
            Me.editEmailButton.ButtonElement.TextElement.CustomFont = "TelerikWebUI"
            Me.editEmailButton.Text = ""
        End Sub

        Private Sub SetPanelImage(ByVal image As Image)
            Dim widthCoefficient As Single = Me.radWebCam1.Width / CSng(image.Width)
            Dim heightCoefficient As Single = Me.radWebCam1.Height / CSng(image.Height)
            Dim scaleCoeff As Single = Math.Min(widthCoefficient, heightCoefficient)
            Dim scaledSize As Size = New Size(CInt(image.Width * scaleCoeff), CInt(image.Height * scaleCoeff))
            image = New Bitmap(image, scaledSize)
            Me.panel1.BackgroundImage = image
        End Sub

        Private Sub WebCam1_SnapshotTaken(ByVal sender As Object, ByVal e As SnapshotTakenEventArgs) Handles radWebCam1.SnapshotTaken
            Me.StopCamera()
            Me.SetPanelImage(e.Snapshot)
            Me.deletePhotoButton.Enabled = True
        End Sub

        Private Sub TakePhotoButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles takePhotoButton.Click
            Me.StartCamera()
        End Sub

        Private Sub DeletePhotoButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deletePhotoButton.Click
            Me.SetPanelImage(Me.DefaultImage)
            Me.deletePhotoButton.Enabled = False
        End Sub

        Private Sub StopCameraButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.StopCamera()
        End Sub

        Private Sub StartCamera()
            Me.takePhotoLabel.Visible = False
            Me.takePhotoButton.Visible = False
            Me.deletePhotoButton.Visible = False
            Me.radWebCam1.Visible = True
            Me.radWebCam1.Start()
        End Sub

        Private Sub StopCamera()
            Me.radWebCam1.[Stop]()

            If Me.radWebCam1.IsPreviewingSnapshot Then
                Me.radWebCam1.DiscardSnapshot()
            End If

            Me.radWebCam1.Hide()
            Me.takePhotoButton.Visible = True
            Me.deletePhotoButton.Visible = True
            Me.takePhotoLabel.Visible = True
        End Sub

        Private Sub EndEditButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click, cancelButton.Click
            Me.editUserNameButton.Enabled = True
            Me.userNameTextBox.Enabled = False
            Me.editEmailButton.Enabled = True
            Me.emailTextBox.Enabled = False
            Me.cancelButton.Enabled = False
            Me.saveButton.Enabled = False

            If sender Is Me.cancelButton Then
                Me.userNameTextBox.Text = Me.userNameCache
                Me.emailTextBox.Text = Me.emailCache
            End If

            Me.userNameCache = String.Empty
            Me.emailCache = String.Empty
        End Sub

        Private Sub EditButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles editUserNameButton.Click, editEmailButton.Click
            Me.editUserNameButton.Enabled = False
            Me.editEmailButton.Enabled = False
            Me.saveButton.Enabled = True
            Me.cancelButton.Enabled = True
            Me.userNameCache = Me.userNameTextBox.Text
            Me.emailCache = Me.emailTextBox.Text

            If sender Is Me.editUserNameButton Then
                Me.userNameTextBox.Enabled = True
                Me.userNameTextBox.Focus()
            Else
                Me.emailTextBox.Enabled = True
                Me.emailTextBox.Focus()
            End If
        End Sub
    End Class
End Namespace
