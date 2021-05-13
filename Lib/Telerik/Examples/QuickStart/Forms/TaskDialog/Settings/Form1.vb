Imports System
Imports System.Drawing
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.TaskDialog

Namespace Telerik.Examples.WinControls.Forms.TaskDialog.Settings
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            Me.AddIconToIconsList(RadTaskDialogIcon.None, True)
            Me.AddIconToIconsList(RadTaskDialogIcon.Information)
            Me.AddIconToIconsList(RadTaskDialogIcon.Warning)
            Me.AddIconToIconsList(RadTaskDialogIcon.[Error])
            Me.AddIconToIconsList(RadTaskDialogIcon.Shield)
            Me.AddIconToIconsList(RadTaskDialogIcon.ShieldBlueBar)
            Me.AddIconToIconsList(RadTaskDialogIcon.ShieldGrayBar)
            Me.AddIconToIconsList(RadTaskDialogIcon.ShieldWarningYellowBar)
            Me.AddIconToIconsList(RadTaskDialogIcon.ShieldErrorRedBar)
            Me.AddIconToIconsList(RadTaskDialogIcon.ShieldSuccessGreenBar)
            Me.radDropDownListIcon.ShowImageInEditorArea = True
            FillComboFromEnum(Me.radDropDownListProgressbarState, GetType(RadTaskDialogProgressBarState), RadTaskDialogProgressBarState.None)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.OK, True)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Cancel, True)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Retry)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Close)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.TryAgain)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Yes)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.No)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.[Continue])
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Ignore)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Abort)
            Me.AddCommandButtonToCommandButtonsList(RadTaskDialogButton.Help)
        End Sub

        Private Sub AddIconToIconsList(ByVal icon As RadTaskDialogIcon, ByVal Optional isSelected As Boolean = False)
            Dim item As RadListDataItem = New RadListDataItem(icon.IconType.ToString(), icon)

            If icon.SvgImage IsNot Nothing Then
                item.SvgImage = CType(icon.SvgImage.Clone(), RadSvgImage)
                item.SvgImage.Size = New Size(16, 16)
            Else
                item.Text = "None"
            End If

            If isSelected Then
                item.Selected = True
            End If

            Me.radDropDownListIcon.Items.Add(item)
        End Sub

        Private Sub AddCommandButtonToCommandButtonsList(ByVal button As RadTaskDialogButton, ByVal Optional isChecked As Boolean = False)
            Dim item As RadCheckedListDataItem = New RadCheckedListDataItem(button.Text, isChecked)
            item.Tag = button
            Me.radCheckedDropDownListCommandButtons.Items.Add(item)
        End Sub

        Private Sub RadButtonShowDialog_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim page As RadTaskDialogPage = New RadTaskDialogPage()
            page.Caption = Me.radTextBoxCaption.Text
            page.Heading = Me.radTextBoxHeading.Text
            page.Icon = CType(Me.radDropDownListIcon.SelectedValue, RadTaskDialogIcon)
            page.Text = Me.radTextBoxPageText.Text
            page.ProgressBar.State = CType(Me.radDropDownListProgressbarState.SelectedValue, RadTaskDialogProgressBarState)
            page.ProgressBar.Value = 75
            page.ProgressBar.Text = "Loading"

            If Me.radCheckBoxRadioButtons.IsChecked Then
                page.RadioButtons.Add(New RadTaskDialogRadioButton("Expander position - After text") With {
                    .Tag = RadTaskDialogExpanderPosition.AfterText,
                    .IsChecked = True
                })
                page.RadioButtons.Add(New RadTaskDialogRadioButton("Expander position - After footnote") With {
                    .Tag = RadTaskDialogExpanderPosition.AfterFootnote
                })

                For Each rb As RadTaskDialogRadioButton In page.RadioButtons
                    AddHandler rb.ToggleStateChanged, Sub(ByVal sender1 As Object, ByVal args As StateChangedEventArgs)
                                                          page.Expander.Position = CType(TryCast(sender1, RadTaskDialogRadioButton).Tag, RadTaskDialogExpanderPosition)
                                                      End Sub
                Next
            End If

            If Me.radCheckBoxCommandLinkButtons.IsChecked Then
                Dim button As RadTaskDialogCommandLinkButton = New RadTaskDialogCommandLinkButton("Caution", "This button will close the dialog.")
                button.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.GradientStop, New Size(26, 26))
                page.ContentAreaButtons.Add(button)
                button = New RadTaskDialogCommandLinkButton("Success", "This button will not close the dialog.", allowCloseDialog:=False)
                button.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.GradientShieldSuccess, New Size(26, 26))
                page.ContentAreaButtons.Add(button)
                page.ContentAreaButtons.Add(New RadTaskDialogCommandLinkButton("Sample button"))
            End If

            page.Expander.Text = Me.radTextBoxExpander.Text
            page.Verification.Text = Me.radTextBoxVerification.Text

            For Each item As RadCheckedListDataItem In Me.radCheckedDropDownListCommandButtons.CheckedItems
                page.CommandAreaButtons.Add(CType(item.Tag, RadTaskDialogButton))
            Next

            page.Footnote.Text = Me.radTextBoxFootnote.Text
            RadTaskDialog.CurrentForm.ThemeName = Me.CurrentThemeName
            RadTaskDialog.Show(page)
        End Sub
    End Class
End Namespace
