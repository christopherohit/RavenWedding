Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.Buttons.ToggleSwitch
	Partial Public Class Form1
        Inherits ExamplesForm
		Public Sub New()
            InitializeComponent()
            Me.CenteredControl = Me.doubleBufferedTableLayoutPanel1

			Me.radTimePicker1.TimePickerElement.ShowSpinButtons = False
		End Sub

        Private Sub radToggleSwitchReminder_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radDateTimePicker1.Enabled = Me.radToggleSwitchReminder.Value
            Me.radTimePicker1.Enabled = Me.radToggleSwitchReminder.Value
        End Sub

        Private Sub radToggleSwitchRecurrence_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radDropDownListRecurrence.Enabled = Me.radToggleSwitchRecurrence.Value
        End Sub

        Private Sub radSpinEditorSwitchElasticity_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radToggleSwitchReminder.SwitchElasticity = CDbl(Me.radSpinEditorSwitchElasticity.Value)
            Me.radToggleSwitchRecurrence.SwitchElasticity = CDbl(Me.radSpinEditorSwitchElasticity.Value)
            Me.radToggleSwitchPlaySound.SwitchElasticity = CDbl(Me.radSpinEditorSwitchElasticity.Value)
        End Sub

        Private Sub radSpinEditorThumbTickness_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radToggleSwitchReminder.ThumbTickness = CInt(Fix(Me.radSpinEditorThumbTickness.Value))
            Me.radToggleSwitchRecurrence.ThumbTickness = CInt(Fix(Me.radSpinEditorThumbTickness.Value))
            Me.radToggleSwitchPlaySound.ThumbTickness = CInt(Fix(Me.radSpinEditorThumbTickness.Value))
        End Sub

        Private Sub radCheckBoxAllowAnimation_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radToggleSwitchReminder.AllowAnimation = Me.radCheckBoxAllowAnimation.ToggleState = ToggleState.On
            Me.radToggleSwitchRecurrence.AllowAnimation = Me.radCheckBoxAllowAnimation.ToggleState = ToggleState.On
            Me.radToggleSwitchPlaySound.AllowAnimation = Me.radCheckBoxAllowAnimation.ToggleState = ToggleState.On
        End Sub

        Private Sub radCheckBoxRightToLeft_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.radToggleSwitchReminder.RightToLeft = If(Me.radCheckBoxRightToLeft.ToggleState = ToggleState.On, RightToLeft.Yes, RightToLeft.No)
            Me.radToggleSwitchRecurrence.RightToLeft = If(Me.radCheckBoxRightToLeft.ToggleState = ToggleState.On, RightToLeft.Yes, RightToLeft.No)
            Me.radToggleSwitchPlaySound.RightToLeft = If(Me.radCheckBoxRightToLeft.ToggleState = ToggleState.On, RightToLeft.Yes, RightToLeft.No)
        End Sub

        Private Sub radButtonCreateAppointment_Click(ByVal sender As Object, ByVal e As EventArgs)
            RadMessageBox.Instance.ThemeName = Me.CurrentThemeName
            RadMessageBox.Instance.EnableBeep = Me.radToggleSwitchPlaySound.Value
            RadMessageBox.Show("Appointment:" & Environment.NewLine & radTextBox1.Text & Environment.NewLine & "Successfully created.")
        End Sub

        Private Sub radSpinEditorAnimationFrames_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.radToggleSwitchReminder.AnimationFrames = CInt(Fix(Me.radSpinEditorAnimationFrames.Value))
            Me.radToggleSwitchRecurrence.AnimationFrames = CInt(Fix(Me.radSpinEditorAnimationFrames.Value))
            Me.radToggleSwitchPlaySound.AnimationFrames = CInt(Fix(Me.radSpinEditorAnimationFrames.Value))
        End Sub
	End Class
End Namespace