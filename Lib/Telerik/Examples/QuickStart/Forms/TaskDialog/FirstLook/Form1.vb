Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.TaskDialog

Namespace Telerik.Examples.WinControls.Forms.TaskDialog.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm
        Public Sub New()
            InitializeComponent()
            Me.CenterPanel = True
            Me.radLabelInstallationImage.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.FlatShieldWarning, New Size(46, 46))
            Me.radLabelWarningImage.SvgImage = RadTaskDialogIcon.GetSvgImage(RadTaskDialogIconImage.FlatShieldWarning, New Size(46, 46))
            Dim border As BorderPrimitive = Me.radPanelInstallation.PanelElement.PanelBorder
            border.Width = 1
            border.GradientStyle = GradientStyles.Solid
            border = Me.radPanelWarning.PanelElement.PanelBorder
            border.Width = 1
            border.GradientStyle = GradientStyles.Solid
            border = Me.radPanelGameDifficulty.PanelElement.PanelBorder
            border.Width = 1
            border.GradientStyle = GradientStyles.Solid
            Me.radLabelGameDescription.ForeColor = MainForm.AccentColor
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If TelerikHelper.IsMaterialTheme(Me.CurrentThemeName) Then
                Me.radPanelInstallation.PanelElement.PanelBorder.ForeColor = Color.LightGray
                Me.radPanelWarning.PanelElement.PanelBorder.ForeColor = Color.LightGray
                Me.radPanelGameDifficulty.PanelElement.PanelBorder.ForeColor = Color.LightGray
            End If
        End Sub

        Private Sub ButtonInstallation_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim result As String = Me.ShowInstallationExample()
        End Sub

        Private Sub ButtonDifficulty_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim result As String = Me.ShowDiffucultyExample()
        End Sub

        Private Sub ButtonWarning_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim result As String = Me.ShowWarningExample()
        End Sub

        Private Function ShowInstallationExample() As String
            ' Disable the "Yes" button and only enable it when the check box is checked.
            ' Also, don't close the dialog when this button is clicked.
            Dim initialButtonYes As RadTaskDialogButton = RadTaskDialogButton.[Continue]
            initialButtonYes.Enabled = False
            initialButtonYes.AllowCloseDialog = False
            Dim initialPage As RadTaskDialogPage = New RadTaskDialogPage() With {
                .Caption = "Hardware Installation",
                .Heading = "Installation Warning",
                .Text = "The software you are installing for this hardware:" & vbLf & "Printers" & vbLf & "has not passed Windows Logo testing to verify its compatibility with Windows",
                .Icon = RadTaskDialogIcon.ShieldWarningYellowBar,
                .AllowCancel = True,
                .Verification = New RadTaskDialogVerificationCheckBox() With {
                    .Text = "Install anyway"
                },
                .CommandAreaButtons = New Telerik.WinControls.UI.TaskDialog.RadItemOwnerGenericCollection(Of RadTaskDialogButton) From {
                    initialButtonYes,
                    RadTaskDialogButton.Cancel
                },
                .DefaultButton = RadTaskDialogButton.Cancel
            }

            Dim inProgressPage As RadTaskDialogPage = New RadTaskDialogPage() With {
                .Caption = "Hardware Installation",
                .Heading = "Installation in progress...",
                .Text = "Please wait while the installation is in progress.",
                .Icon = RadTaskDialogIcon.Information,
                .ProgressBar = New RadTaskDialogProgressBar() With {
                    .State = RadTaskDialogProgressBarState.Marquee
                },
                .Expander = New RadTaskDialogExpander() With {
                    .Text = "Initializing...",
                    .Position = RadTaskDialogExpanderPosition.AfterFootnote
                },
                .CommandAreaButtons = New Telerik.WinControls.UI.TaskDialog.RadItemOwnerGenericCollection(Of RadTaskDialogButton) From {
                    RadTaskDialogButton.Cancel
                }
            }

            Dim finishedPage As RadTaskDialogPage = New RadTaskDialogPage() With {
                .Caption = "Hardware Installation",
                .Heading = "Success!",
                .Text = "The Printer installation completed successfully.",
                .Icon = RadTaskDialogIcon.ShieldSuccessGreenBar,
                .CommandAreaButtons = New Telerik.WinControls.UI.TaskDialog.RadItemOwnerGenericCollection(Of RadTaskDialogButton) From {
                    New RadTaskDialogButton("Finish")
                }
            }
            Dim checkBox As RadTaskDialogVerificationCheckBox = initialPage.Verification
            AddHandler checkBox.CheckedChanged, Sub(sender, e) initialButtonYes.Enabled = checkBox.Checked

            ' When the user clicks "Yes", navigate to the second page.
            ' Navigate to the "In Progress" page that displays the
            ' current progress of the background work.
            AddHandler initialButtonYes.Click, Sub(sender, e) initialPage.Navigate(inProgressPage)
            AddHandler inProgressPage.Created, Sub(ByVal s As Object, ByVal e As EventArgs)
                                                   Dim progressBar As RadTaskDialogProgressBar = inProgressPage.ProgressBar
                                                   Dim timer As Timer = New Timer()
                                                   timer.Interval = 2800
                                                   Dim progressValue As Integer = 0
                                                   timer.Start()
                                                   AddHandler timer.Tick, Sub(ByVal sender As Object, ByVal args As EventArgs)
                                                                              timer.Interval = 40

                                                                              ' When we display the first progress, switch the marquee progress bar
                                                                              ' to a regular one.
                                                                              If progressBar.State = RadTaskDialogProgressBarState.Marquee Then progressBar.State = RadTaskDialogProgressBarState.Normal
                                                                              progressBar.Value = progressValue
                                                                              inProgressPage.Expander.Text = String.Format("Installation Progress: {0} %", progressValue)

                                                                              If progressValue = 100 Then
                                                                                  timer.[Stop]()
                                                                                  timer.Dispose()

                                                                                  ' Work is finished, so navigate to the third page.
                                                                                  inProgressPage.Navigate(finishedPage)
                                                                              End If

                                                                              progressValue += 1
                                                                          End Sub
                                               End Sub

            RadTaskDialog.CurrentForm.ThemeName = Me.CurrentThemeName
            Dim result As RadTaskDialogButton = RadTaskDialog.ShowDialog(initialPage, RadTaskDialogStartupLocation.CenterScreen)

            If result IsNot Nothing AndAlso result.Text Is "Finish" Then
                Return "Printer successfully installed"
            Else
                Return "Printer installation aborted"
            End If
        End Function

        Private Function ShowDiffucultyExample() As String
            Dim page As RadTaskDialogPage = New RadTaskDialogPage() With {
                .Caption = "Select Difficulty",
                .Heading = "What level of difficulty do you want to play?",
                .Icon = RadTaskDialogIcon.None,
                .AllowCancel = True,
                .Footnote = New RadTaskDialogFootnote("Note: You can change the difficulty level by clicking options in the game menu."),
                .ContentAreaButtons = New Telerik.WinControls.UI.TaskDialog.RadItemOwnerGenericCollection(Of RadTaskDialogCommandLinkButton) From {
                    New RadTaskDialogCommandLinkButton("Beginner", "10x10 cells"),
                    New RadTaskDialogCommandLinkButton("Intermediate", "40x40 cells"),
                    New RadTaskDialogCommandLinkButton("Advanced", "100x100 cells")
                }
            }
            RadTaskDialog.CurrentForm.ThemeName = Me.CurrentThemeName
            Dim result As RadTaskDialogButton = RadTaskDialog.ShowDialog(page, RadTaskDialogStartupLocation.CenterScreen)

            If result Is Nothing Then
                Return "Game closed"
            Else
                Return String.Format("You have chosen {0} difficulty", result.Text)
            End If
        End Function

        Private Function ShowWarningExample() As String
            Dim page As RadTaskDialogPage = New RadTaskDialogPage() With {
                .Caption = "Windows Security Difficulty",
                .Heading = "Opening these files might be harmful to your computer",
                .Text = "Your internet security settings blocked one or more files from being opened. Do you want to open these files anyway?",
                .Icon = RadTaskDialogIcon.ShieldWarningYellowBar,
                .AllowCancel = True,
                .Footnote = New RadTaskDialogFootnote("Note: How do I decide whether to open these files?"),
                .CommandAreaButtons = New Telerik.WinControls.UI.TaskDialog.RadItemOwnerGenericCollection(Of RadTaskDialogButton) From {
                    RadTaskDialogButton.Yes,
                    RadTaskDialogButton.No
                }
            }
            RadTaskDialog.CurrentForm.ThemeName = Me.CurrentThemeName
            Dim result As RadTaskDialogButton = RadTaskDialog.ShowDialog(page, RadTaskDialogStartupLocation.CenterScreen)

            If result Is Nothing OrElse result = RadTaskDialogButton.No Then
                Return "User prevented the files from being opened."
            Else
                Return "User agreed to open the files."
            End If
        End Function
    End Class
End Namespace
