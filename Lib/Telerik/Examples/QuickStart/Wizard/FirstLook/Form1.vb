Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Wizard.FirstLook
    Partial Public Class Form1
        Inherits ExamplesForm

        Public Sub New()
            InitializeComponent()
            AddHandler radWizard1.Cancel, AddressOf radWizard1_Cancel
            AddHandler radWizard1.Finish, AddressOf radWizard1_Finish
            AddHandler radWizard1.Help, AddressOf radWizard1_Help

            AddHandler radButtonWelcome.Click, AddressOf radButtonWelcome_Click
            AddHandler radButtonWelcomeBrowse.Click, AddressOf radButtonWelcomeBrowse_Click
            AddHandler radDropDownListWelcome.SelectedIndexChanged, AddressOf radDropDownListWelcome_SelectedIndexChanged
            AddHandler radButtonWelcomeBackColor.Click, AddressOf radButtonWelcomeBackColor_Click
            AddHandler radCheckBoxWelcomeImage.ToggleStateChanged, AddressOf radCheckBoxWelcomeImage_ToggleStateChanged
            AddHandler radButtonWelcomeReset.Click, AddressOf radButtonWelcomeReset_Click

            AddHandler radTextBoxPage1Title.TextChanged, AddressOf radTextBoxPage1Title_TextChanged
            AddHandler radCheckBoxPage1Title.ToggleStateChanged, AddressOf radCheckBoxPage1Title_ToggleStateChanged
            AddHandler radTextBoxPage1Header.TextChanged, AddressOf radTextBoxPage1Header_TextChanged
            AddHandler radCheckBoxPage1Header.ToggleStateChanged, AddressOf radCheckBoPage1Header_ToggleStateChanged
            AddHandler radButtonPage1Icon.Click, AddressOf radButtonPage1Icon_Click
            AddHandler radDropDownListIconAlignment.SelectedIndexChanged, AddressOf radDropDownListIconAlignment_SelectedIndexChanged
            AddHandler radButtonPage1Reset.Click, AddressOf radButtonPage1Reset_Click

            AddHandler radGridViewPage2.ValueChanging, AddressOf radGridViewPage2_ValueChanging
            AddHandler radButtonPage2Reset.Click, AddressOf radButtonPage2Reset_Click

            AddHandler radWizard1.Next, AddressOf radWizard1_Next
            AddHandler radWizard1.Previous, AddressOf radWizard1_Previous
            AddHandler radWizard1.SelectedPageChanged, AddressOf radWizard1_SelectedPageChanged

            AddHandler radWizard1.ThemeNameChanged, AddressOf radWizard1_ThemeNameChanged
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.radDropDownListWelcome.Items.Add(ImageLayout.None.ToString())
            Me.radDropDownListWelcome.Items.Add(ImageLayout.Tile.ToString())
            Me.radDropDownListWelcome.Items.Add(ImageLayout.Center.ToString())
            Me.radDropDownListWelcome.Items.Add(ImageLayout.Stretch.ToString())
            Me.radDropDownListWelcome.Items.Add(ImageLayout.Zoom.ToString())
            Me.radDropDownListWelcome.SelectedIndex = 0
            Me.radDropDownListWelcome.Enabled = False
            Me.radDropDownListIconAlignment.Items.Add("Right")
            Me.radDropDownListIconAlignment.Items.Add("Left")
            Me.radDropDownListIconAlignment.SelectedIndex = 0
            Me.wizardPage1.CustomizePageHeader = True
            Me.wizardPage1.Icon = Me.radWizard1.PageHeaderIcon
            Me.radGridViewPage2.Rows.Add("Next", True, True)
            Me.radGridViewPage2.Rows.Add("Back", True, True)
            Me.radGridViewPage2.Rows.Add("Cancel", True, True)
            Me.radGridViewPage2.Rows.Add("Finish", False, True)
            Me.radGridViewPage2.Rows.Add("Help", True, True)

            For Each page As WizardPage In radWizard1.Pages
                Dim showScreen As Screen = Screen.FromControl(Me)
                Dim scale As SizeF = NativeMethods.GetMonitorDpi(showScreen, NativeMethods.DpiType.Effective)

                For Each item As Control In page.ContentArea.Controls
                    item.Scale(scale)
                Next
            Next
        End Sub

        Private Sub radWizard1_Cancel(ByVal sender As Object, ByVal e As EventArgs)
            RadMessageBox.SetThemeName(Me.radWizard1.ThemeName)
            RadMessageBox.Show("You can implement your RadWizard Canceling logic using this event.", "RadWizard Cancel")
        End Sub

        Private Sub radWizard1_Finish(ByVal sender As Object, ByVal e As EventArgs)
            RadMessageBox.SetThemeName(Me.radWizard1.ThemeName)
            Dim result As DialogResult = RadMessageBox.Show("Would you like to start  over?", "RadWizard Finish", MessageBoxButtons.OKCancel)

            If result = DialogResult.OK Then
                Me.radWizard1.SelectedPage = Me.wizardWelcomePage1
            End If
        End Sub

        Private Sub radWizard1_Help(ByVal sender As Object, ByVal e As EventArgs)
            RadMessageBox.SetThemeName(Me.radWizard1.ThemeName)
            RadMessageBox.Show("You can provide your RadWizard Help using this event.", "RadWizard Help")
        End Sub

        Private Sub radButtonWelcome_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radWizard1.WelcomeImage = My.Resources.WizardWelcomeImage

            If Me.radWizard1.WelcomeImage IsNot Nothing Then
                Me.radDropDownListWelcome.Enabled = True
            End If
        End Sub

        Private Sub radButtonWelcomeBrowse_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim image As Image = Me.LoadImage()

            If image Is Nothing Then
                Return
            End If

            Me.radWizard1.WelcomeImage = image

            If Me.radWizard1.WelcomeImage IsNot Nothing Then
                Me.radDropDownListWelcome.Enabled = True
            End If
        End Sub

        Private Sub radDropDownListWelcome_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radWizard1.WelcomeImageLayout = CType(e.Position, ImageLayout)
        End Sub

        Private Sub radButtonWelcomeBackColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim radColorDialog As RadColorDialog = New RadColorDialog()
            CType(radColorDialog.ColorDialogForm, RadForm).ThemeName = CurrentThemeName

            If radColorDialog.ShowDialog() = DialogResult.OK Then
                Me.radWizard1.WelcomeImageElement.BackColor = radColorDialog.SelectedColor
                Me.radWizard1.WelcomeImageElement.DrawFill = True
                Me.radWizard1.WelcomeImageElement.GradientStyle = GradientStyles.Solid
                Me.radWizard1.WelcomeImageElement.BackgroundImage = Nothing
            End If
        End Sub

        Private Sub radCheckBoxWelcomeImage_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Me.radWizard1.HideWelcomeImage = Me.radCheckBoxWelcomeImage.ToggleState = ToggleState.Off
            Me.radButtonWelcomeBrowse.Enabled = Me.radCheckBoxWelcomeImage.ToggleState <> ToggleState.Off
            Me.radButtonWelcome.Enabled = Me.radCheckBoxWelcomeImage.ToggleState <> ToggleState.Off
            Me.radButtonWelcomeBackColor.Enabled = Me.radCheckBoxWelcomeImage.ToggleState <> ToggleState.Off
            Me.radDropDownListWelcome.Enabled = Me.radCheckBoxWelcomeImage.ToggleState <> ToggleState.Off AndAlso Me.radWizard1.WelcomeImage IsNot Nothing
        End Sub

        Private Sub radButtonWelcomeReset_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.radCheckBoxWelcomeImage.ToggleState = ToggleState.[On]
            Me.radWizard1.WelcomeImage = Nothing
            Me.radDropDownListWelcome.SelectedIndex = 0
            Me.radWizard1.WelcomeImageLayout = ImageLayout.None
            Me.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            Me.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            Me.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
            Me.radWizard1.WelcomeImageElement.ResetValue(LightVisualElement.BackgroundImageProperty, ValueResetFlags.Local)
        End Sub

        Private Sub radTextBoxPage1Title_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.wizardPage1.Title = Me.radTextBoxPage1Title.Text
        End Sub

        Private Sub radCheckBoxPage1Title_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Dim titleVisibility As ElementVisibility = If(Me.radCheckBoxPage1Title.ToggleState = ToggleState.[On], ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.wizardPage1.TitleVisibility = titleVisibility
        End Sub

        Private Sub radTextBoxPage1Header_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.wizardPage1.Header = Me.radTextBoxPage1Header.Text
        End Sub

        Private Sub radCheckBoPage1Header_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            Dim headerVisibility As ElementVisibility = If(Me.radCheckBoxPage1Header.ToggleState = ToggleState.[On], ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.wizardPage1.HeaderVisibility = headerVisibility
        End Sub

        Private Sub radButtonPage1Icon_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim image As Image = Me.LoadImage()

            If image IsNot Nothing Then
                Me.wizardPage1.Icon = image
            End If
        End Sub

        Private Sub radDropDownListIconAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If e.Position = 0 Then
                Me.radWizard1.PageHeaderIconAlignment = ContentAlignment.MiddleRight
            ElseIf e.Position = 1 Then
                Me.radWizard1.PageHeaderIconAlignment = ContentAlignment.MiddleLeft
            End If
        End Sub

        Private Sub radButtonPage1Reset_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.wizardPage1.Title = "Page Title"
            Me.radTextBoxPage1Title.Text = "Page Title"
            Me.radCheckBoxPage1Title.ToggleState = ToggleState.[On]
            Me.wizardPage1.TitleVisibility = ElementVisibility.Visible
            Me.wizardPage1.Header = "Short description"
            Me.radTextBoxPage1Header.Text = "Short description"
            Me.radCheckBoxPage1Header.ToggleState = ToggleState.[On]
            Me.wizardPage1.HeaderVisibility = ElementVisibility.Visible
            Me.wizardPage1.Icon = Me.radWizard1.PageHeaderIcon
            Me.radDropDownListIconAlignment.SelectedIndex = 0
            Me.radWizard1.PageHeaderIconAlignment = ContentAlignment.MiddleRight
        End Sub

        Private Sub radGridViewPage2_ValueChanging(ByVal sender As Object, ByVal e As ValueChangingEventArgs)
            If Me.radGridViewPage2.CurrentColumn.Name = "VisibleColumn" Then

                Select Case Me.radGridViewPage2.CurrentRow.Index
                    Case 0
                        Me.radWizard1.NextButton.Visibility = If(CBool(e.NewValue), ElementVisibility.Visible, ElementVisibility.Collapsed)
                    Case 1
                        Me.radWizard1.BackButton.Visibility = If(CBool(e.NewValue), ElementVisibility.Visible, ElementVisibility.Collapsed)
                    Case 2
                        Me.radWizard1.CancelButton.Visibility = If(CBool(e.NewValue), ElementVisibility.Visible, ElementVisibility.Collapsed)
                    Case 3
                        Me.radWizard1.FinishButton.Visibility = If(CBool(e.NewValue), ElementVisibility.Visible, ElementVisibility.Collapsed)
                    Case 4
                        Me.radWizard1.HelpButton.Visibility = If(CBool(e.NewValue), ElementVisibility.Visible, ElementVisibility.Collapsed)
                    Case Else
                End Select
            ElseIf Me.radGridViewPage2.CurrentColumn.Name = "EnabledColumn" Then

                Select Case Me.radGridViewPage2.CurrentRow.Index
                    Case 0
                        Me.radWizard1.NextButton.Enabled = CBool(e.NewValue)
                    Case 1
                        Me.radWizard1.BackButton.Enabled = CBool(e.NewValue)
                    Case 2
                        Me.radWizard1.CancelButton.Enabled = CBool(e.NewValue)
                    Case 3
                        Me.radWizard1.FinishButton.Enabled = CBool(e.NewValue)
                    Case 4
                        Me.radWizard1.HelpButton.Enabled = CBool(e.NewValue)
                    Case Else
                End Select
            End If
        End Sub

        Private Sub radButtonPage2Reset_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ResetGridData()
            Me.ResetButtonStates()
            Me.radWizard1.WizardElement.Refresh()
        End Sub

        Private Sub radWizard1_Next(ByVal sender As Object, ByVal e As WizardCancelEventArgs)
            If Not Me.radWizard1.SelectedPage Is Me.wizardPage3 Then
                Return
            End If

            e.Cancel = True

            If Me.radRadioButtonCompletionPage1.ToggleState = ToggleState.[On] Then
                Me.radWizard1.SelectedPage = Me.radWizard1.CompletionPage
            Else
                Me.radWizard1.SelectedPage = Me.wizardPage4
            End If
        End Sub

        Private Sub radWizard1_Previous(ByVal sender As Object, ByVal e As WizardCancelEventArgs)
            If Not Me.radWizard1.SelectedPage IsNot Me.radWizard1.CompletionPage AndAlso Me.radWizard1.SelectedPage IsNot Me.wizardPage4 Then
                Return
            End If

            e.Cancel = True
            Me.radWizard1.SelectedPage = Me.wizardPage3
        End Sub

        Private Sub radWizard1_SelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
            If e.SelectedPage Is Me.wizardPage4 Then
                Me.radWizard1.NextButton.Visibility = ElementVisibility.Collapsed
                Me.radWizard1.FinishButton.Visibility = ElementVisibility.Visible
            ElseIf e.SelectedPage Is Me.wizardPage2 OrElse e.PreviousPage Is Me.wizardPage2 Then
                Me.ResetGridData()
                Me.ResetButtonStates()
            End If
        End Sub

        Private Sub radWizard1_ThemeNameChanged(ByVal source As Object, ByVal args As ThemeNameChangedEventArgs)
            Me.wizardPage1.Icon = Me.radWizard1.PageHeaderIcon
        End Sub

        Private Function LoadImage() As Image
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Title = "Choose Icon Image"
            openFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim icon As Image = Image.FromFile(openFileDialog.FileName)
                Return icon
            End If

            Return Nothing
        End Function

        Private Sub ResetGridData()
            Me.radGridViewPage2.Rows(0).Cells(1).Value = True
            Me.radGridViewPage2.Rows(0).Cells(2).Value = True
            Me.radGridViewPage2.Rows(1).Cells(1).Value = True
            Me.radGridViewPage2.Rows(1).Cells(2).Value = True
            Me.radGridViewPage2.Rows(2).Cells(1).Value = True
            Me.radGridViewPage2.Rows(2).Cells(2).Value = True
            Me.radGridViewPage2.Rows(3).Cells(1).Value = False
            Me.radGridViewPage2.Rows(3).Cells(2).Value = True
            Me.radGridViewPage2.Rows(4).Cells(1).Value = True
            Me.radGridViewPage2.Rows(4).Cells(2).Value = True
        End Sub

        Private Sub ResetButtonStates()
            Me.radWizard1.NextButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local)
            Me.radWizard1.BackButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local)
            Me.radWizard1.CancelButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local)
            Me.radWizard1.FinishButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local)
            Me.radWizard1.HelpButton.ResetValue(RadElement.VisibilityProperty, ValueResetFlags.Local)
            Me.radWizard1.NextButton.Enabled = True
            Me.radWizard1.BackButton.Enabled = True
            Me.radWizard1.CancelButton.Enabled = True
            Me.radWizard1.FinishButton.Enabled = True
            Me.radWizard1.HelpButton.Enabled = True
        End Sub
    End Class
End Namespace
