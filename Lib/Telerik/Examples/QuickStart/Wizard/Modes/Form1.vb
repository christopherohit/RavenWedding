Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.Wizard.Modes
	Partial Public Class Form1
        Inherits RadForm
        Implements ISupportThemeName
		#Region "Fields"

		Private timerSearch As Timer
		Private timerInstallation As Timer
		Private deviceFound As Boolean = False
		Private installationCompleted As Boolean = False

		#End Region

		#Region "Initialization"

		Public Sub New()
			InitializeComponent()
			Me.timerSearch = New Timer()
			Me.timerSearch.Interval = 5000
			Me.timerInstallation = New Timer()
			Me.timerInstallation.Interval = 1000

			AddHandler radWizard1.Cancel, AddressOf radWizard1_Cancel
			AddHandler radWizard1.Finish, AddressOf radWizard1_Finish
			AddHandler radWizard1.ModeChanged, AddressOf radWizard1_ModeChanged

			AddHandler radRadioButton97Mode.ToggleStateChanged, AddressOf radRadioButton97Mode_ToggleStateChanged
			AddHandler radRadioButtonAeroMode.ToggleStateChanged, AddressOf radRadioButtonAeroMode_ToggleStateChanged
			AddHandler radCheckBoxEnableAeroStyle.ToggleStateChanged, AddressOf radCheckBoxEnableAeroStyle_ToggleStateChanged

			AddHandler radWizard1.SelectedPageChanged, AddressOf radWizard1_SelectedPageChanged
			AddHandler radWizard1.Next, AddressOf radWizard1_Next
			AddHandler timerSearch.Tick, AddressOf timer_Tick
			AddHandler timerInstallation.Tick, AddressOf timerInstallation_Tick
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			For Each page As WizardPage In Me.radWizard1.Pages
				page.Icon = Me.radWizard1.PageHeaderIcon
			Next page
			Me.radWizard1.PageHeaderElement.IconElement.Margin = New Padding(0, 20, 18, 0)
		End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)

            If TelerikHelper.IsDarkTheme(Me.ThemeName) Then
                SetBackColor(Color.Black)
            Else
                SetBackColor(Color.White)
            End If
        End Sub
        Private Sub SetBackColor(ByVal color As Color)
            For Each page As WizardPage In radWizard1.Pages
                page.ContentArea.BackColor = color
            Next
        End Sub
#End Region

#Region "Event Handlers"

        Private Sub radWizard1_Cancel(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub radWizard1_Finish(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub radWizard1_ModeChanged(ByVal sender As Object, ByVal e As ModeChangedEventArgs)
			If e.CurrentMode = WizardMode.Wizard97 Then
				Me.radWizard1.PageHeaderElement.IconElement.Margin = New Padding(0, 20, 18, 0)
			Else
				Me.radWizard1.PageHeaderElement.IconElement.Margin = New Padding(6, 8, 0, 8)
			End If
		End Sub


		Private Sub radRadioButton97Mode_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.ChangeMode()
		End Sub

		Private Sub radRadioButtonAeroMode_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.ChangeMode()
		End Sub

		Private Sub radCheckBoxEnableAeroStyle_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radWizard1.EnableAeroStyle = Me.radCheckBoxEnableAeroStyle.ToggleState = ToggleState.On
		End Sub


		Private Sub radWizard1_SelectedPageChanged(ByVal sender As Object, ByVal e As SelectedPageChangedEventArgs)
			Me.radWizard1.HelpButton.Visibility = ElementVisibility.Hidden
			Me.radWizard1.NextButton.Text = "Next   >"

			If e.SelectedPage Is Me.wizardPage1 AndAlso (Not Me.deviceFound) Then
				Me.radWizard1.BackButton.Enabled = False
				Me.radWizard1.NextButton.Enabled = False
				Me.radWaitingBarSearch.StartWaiting()
				Me.timerSearch.Start()

				Me.deviceFound = True
			ElseIf e.SelectedPage Is Me.wizardPage2 AndAlso (Not Me.installationCompleted) Then
				Me.radWizard1.NextButton.Text = "Install"
			ElseIf e.SelectedPage Is Me.wizardPage3 Then
				Me.radWizard1.NextButton.SetDefaultValueOverride(RadElement.VisibilityProperty, ElementVisibility.Collapsed)
				Me.radWizard1.FinishButton.SetDefaultValueOverride(RadElement.VisibilityProperty, ElementVisibility.Visible)
			End If
		End Sub

		Private Sub radWizard1_Next(ByVal sender As Object, ByVal e As WizardCancelEventArgs)
			If Me.radWizard1.SelectedPage Is Me.wizardPage2 AndAlso (Not Me.installationCompleted) Then
				Me.radLabelInstallation.Visible = True
				Me.radProgressBarInstallation.Visible = True
				Me.radWizard1.BackButton.Enabled = False
				Me.radWizard1.NextButton.Enabled = False
				Me.timerInstallation.Start()

				e.Cancel = True
			End If
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.timerSearch.Stop()
			Me.radWaitingBarSearch.StopWaiting()

			Me.radLabelDevice.Text = "Web camera found."
			Me.radWaitingBarSearch.Visible = False
			Me.pictureBoxDevice.Visible = True
			Me.radWizard1.BackButton.Enabled = True
			Me.radWizard1.NextButton.Enabled = True
		End Sub

		Private Sub timerInstallation_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.radProgressBarInstallation.Value1 += 20
			If Me.radProgressBarInstallation.Value1 = Me.radProgressBarInstallation.Maximum Then
				Me.timerInstallation.Stop()
				Me.radWizard1.BackButton.Enabled = True
				Me.radWizard1.NextButton.Enabled = True
				Me.radWizard1.NextButton.Text = "Next   >"
				Me.installationCompleted = True
			End If
		End Sub

		#End Region

		#Region "Methods"

		Private Sub ChangeMode()
			If Me.radRadioButton97Mode.ToggleState = ToggleState.On Then
				Me.radWizard1.Mode = WizardMode.Wizard97
			Else
				Me.radWizard1.Mode = WizardMode.Aero
			End If

			Me.radCheckBoxEnableAeroStyle.Enabled = Me.radWizard1.Mode = WizardMode.Aero
        End Sub

        Public Sub ApplyTheme(themeName As String) Implements ISupportThemeName.ApplyTheme
            Me.ThemeName = themeName
            ThemeResolutionService.ApplyThemeToControlTree(Me, themeName)
        End Sub

		#End Region
	End Class
End Namespace