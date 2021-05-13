Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TrackStatusControls.WaitingBar.Settings
	Public Partial Class Form1
		Inherits ExamplesForm
		Private lineRingWaitingBarIndicatorElement1 As LineRingWaitingBarIndicatorElement
		Private changingTheme As Boolean = False

		Public Sub New()
			InitializeComponent()
			AddHandler Me.radWaitingBar1.ThemeNameChanged, AddressOf radWaitingBar1_ThemeNameChanged
			Me.lineRingWaitingBarIndicatorElement1 = TryCast(Me.radWaitingBar1.WaitingIndicators(0), LineRingWaitingBarIndicatorElement)
		End Sub

		Protected Overrides Sub OnLoad(e As EventArgs)
			MyBase.OnLoad(e)
			ExamplesForm.FillComboFromEnum(Me.radDropDownList1, GetType(RotationDirection), RotationDirection.Clockwise)
			Me.radWaitingBar1.StartWaiting()
			Me.UpdateEditorValues()
		End Sub

		Private Sub UpdateEditorValues()
			Me.changingTheme = True

			Me.lineThicknessSpinEditor.Value = CDec(Me.lineRingWaitingBarIndicatorElement1.LineThickness)
			Me.elementCountSpinEditor.Value = Me.lineRingWaitingBarIndicatorElement1.ElementCount
			Me.radiusSpinEditor.Value = Me.lineRingWaitingBarIndicatorElement1.Radius
			Me.innerRadiusSpinEditor.Value = Me.lineRingWaitingBarIndicatorElement1.InnerRadius
			Me.radDropDownList1.SelectedValue = Me.lineRingWaitingBarIndicatorElement1.RotationDirection.ToString()
			Me.elementColorColorBox.Value = Me.lineRingWaitingBarIndicatorElement1.ElementColor
			Me.elementColor2ColorBox.Value = Me.lineRingWaitingBarIndicatorElement1.ElementColor2
			Me.elementColor3ColorBox.Value = Me.lineRingWaitingBarIndicatorElement1.ElementColor3
			Me.elementColor4ColorBox.Value = Me.lineRingWaitingBarIndicatorElement1.ElementColor4
			Me.gradientPercentageSpinEditor.Value = CDec(Me.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage)
			Me.gradientPercentage2SpinEditor.Value = CDec(Me.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage2)
			Me.numberOfColorsSpinEditor.Value = Me.lineRingWaitingBarIndicatorElement1.ElementNumberOfColors

			Me.changingTheme = False
		End Sub

		Private Sub radWaitingBar1_ThemeNameChanged(source As Object, args As Telerik.WinControls.ThemeNameChangedEventArgs)
			Me.UpdateEditorValues()
		End Sub

		Private Sub lineThicknessSpinEditor_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.LineThickness = CDbl(Me.lineThicknessSpinEditor.Value)
		End Sub

		Private Sub elementCountSpinEditor_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementCount = CInt(Me.elementCountSpinEditor.Value)
		End Sub

		Private Sub radiusSpinEditor_ValueChanging(sender As Object, e As ValueChangingEventArgs)
			If Me.changingTheme Then
				Return
			End If

			Try
				Me.lineRingWaitingBarIndicatorElement1.Radius = Convert.ToInt32(e.NewValue)
			Catch ex As Exception
				e.Cancel = True
				Me.lineRingWaitingBarIndicatorElement1.Radius = Convert.ToInt32(e.OldValue)
				RadMessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub innerRadiusSpinEditor_ValueChanging(sender As Object, e As ValueChangingEventArgs)
			If Me.changingTheme Then
				Return
			End If

			Try
				Me.lineRingWaitingBarIndicatorElement1.InnerRadius = Convert.ToInt32(e.NewValue)
			Catch ex As Exception
				e.Cancel = True
				Me.lineRingWaitingBarIndicatorElement1.InnerRadius = Convert.ToInt32(e.OldValue)
				RadMessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub radDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.RotationDirection = DirectCast(Me.radDropDownList1.SelectedValue, RotationDirection)
		End Sub

		Private Sub elementColorColorBox_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementColor = Me.elementColorColorBox.Value
		End Sub

		Private Sub elementColor2ColorBox_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementColor2 = Me.elementColor2ColorBox.Value
		End Sub

		Private Sub elementColor3ColorBox_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementColor3 = Me.elementColor3ColorBox.Value
		End Sub

		Private Sub elementColor4ColorBox_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementColor4 = Me.elementColor4ColorBox.Value
		End Sub

		Private Sub gradientPercentageSpinEditor_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage = CSng(Me.gradientPercentageSpinEditor.Value)
		End Sub

		Private Sub gradientPercentage2SpinEditor_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementGradientPercentage2 = CSng(Me.gradientPercentage2SpinEditor.Value)
		End Sub

		Private Sub numberOfColorsSpinEditor_ValueChanged(sender As Object, e As EventArgs)
			If Me.changingTheme Then
				Return
			End If

			Me.lineRingWaitingBarIndicatorElement1.ElementNumberOfColors = CInt(Me.numberOfColorsSpinEditor.Value)
		End Sub

		Private Sub animationSpeedSpinEditor_ValueChanged(sender As Object, e As EventArgs)
			Me.radWaitingBar1.WaitingSpeed = CInt(Me.animationSpeedSpinEditor.Value)
		End Sub

		Private Sub animationStepSpinEditor_ValueChanged(sender As Object, e As EventArgs)
			Me.radWaitingBar1.WaitingStep = CInt(Me.animationStepSpinEditor.Value)
		End Sub
	End Class
End Namespace