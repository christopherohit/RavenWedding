Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations

Namespace Telerik.Examples.WinControls.Forms.ColorSelector
	''' <summary>
	''' Color selector example form
	''' </summary>
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			radColorSelector1.SelectedColor = Color.Red
			AddHandler radColorSelector1.OkButtonClicked, AddressOf radColorSelector1_OkButtonClicked
			AddHandler radColorSelector1.CancelButtonClicked, AddressOf radColorSelector1_CancelButtonClicked

			radCheckBox1.ToggleState = If(radColorSelector1.ShowBasicColors, ToggleState.On, ToggleState.Off)
			radCheckBox2.ToggleState = If(radColorSelector1.ShowSystemColors, ToggleState.On, ToggleState.Off)
			radCheckBox3.ToggleState = If(radColorSelector1.ShowWebColors, ToggleState.On, ToggleState.Off)
			radCheckBox4.ToggleState = If(radColorSelector1.ShowProfessionalColors, ToggleState.On, ToggleState.Off)

			radCheckBox5.ToggleState = If(radColorSelector1.ShowHEXColorValue, ToggleState.On, ToggleState.Off)
			radCheckBox6.ToggleState = If(radColorSelector1.ShowCustomColors, ToggleState.On, ToggleState.Off)
			radCheckBox7.ToggleState = If(radColorSelector1.AllowColorSaving, ToggleState.On, ToggleState.Off)
			radCheckBox8.ToggleState = If(radColorSelector1.AllowEditHEXValue, ToggleState.On, ToggleState.Off)
			radCheckBox9.ToggleState = If(radColorSelector1.AllowColorPickFromScreen, ToggleState.On, ToggleState.Off)

			radTextBox1.Text = radColorSelector1.SelectedColorLabelHeading
			radTextBox2.Text = radColorSelector1.OldColorLabelHeading
			radTextBox3.Text = radColorSelector1.AddNewColorButtonText
		End Sub

		Private Sub radColorSelector1_CancelButtonClicked(ByVal sender As Object, ByVal args As ColorChangedEventArgs)

		End Sub

		Private Sub radColorSelector1_OkButtonClicked(ByVal sender As Object, ByVal args As ColorChangedEventArgs)

		End Sub

		Private Sub radColorSelector1_ColorChanged(ByVal sender As Object, ByVal args As ColorChangedEventArgs)

		End Sub

		Private Sub radTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			radColorSelector1.SelectedColorLabelHeading = radTextBox1.Text
			radColorSelector1.Refresh()
		End Sub

		Private Sub radTextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			radColorSelector1.OldColorLabelHeading = radTextBox2.Text
			radColorSelector1.Refresh()
		End Sub

		Private Sub radTextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			radColorSelector1.AddNewColorButtonText = radTextBox3.Text
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox1_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If (Not radColorSelector1.ShowWebColors) AndAlso (Not radColorSelector1.ShowSystemColors) AndAlso (Not radColorSelector1.ShowProfessionalColors) Then
				radCheckBox1.ToggleState = ToggleState.On
				Return
			End If
			radColorSelector1.ShowBasicColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox2_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If (Not radColorSelector1.ShowWebColors) AndAlso (Not radColorSelector1.ShowBasicColors) AndAlso (Not radColorSelector1.ShowProfessionalColors) Then
				radCheckBox2.ToggleState = ToggleState.On
				Return
			End If

			radColorSelector1.ShowSystemColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox3_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If (Not radColorSelector1.ShowSystemColors) AndAlso (Not radColorSelector1.ShowBasicColors) AndAlso (Not radColorSelector1.ShowProfessionalColors) Then
				radCheckBox3.ToggleState = ToggleState.On
				Return
			End If

			radColorSelector1.ShowWebColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox4_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			If (Not radColorSelector1.ShowWebColors) AndAlso (Not radColorSelector1.ShowBasicColors) AndAlso (Not radColorSelector1.ShowSystemColors) Then
				radCheckBox4.ToggleState = ToggleState.On
				Return
			End If

			radColorSelector1.ShowProfessionalColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox6_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			radColorSelector1.ShowCustomColors = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			'when the custom colors are not shown, the user cannot add to them
			If Not radColorSelector1.ShowCustomColors Then
				radCheckBox7.Enabled = False
				radCheckBox7.ToggleState = ToggleState.Off
				radColorSelector1.AllowColorSaving = False
			Else
				radCheckBox7.Enabled = True
				radCheckBox7.ToggleState = ToggleState.On
				radColorSelector1.AllowColorSaving = True
			End If
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox7_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			radColorSelector1.AllowColorSaving = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox5_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			radColorSelector1.ShowHEXColorValue = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox8_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			radColorSelector1.AllowEditHEXValue = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub radCheckBox9_Click(ByVal sender As Object, ByVal e As StateChangedEventArgs)
			radColorSelector1.AllowColorPickFromScreen = e.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			radColorSelector1.Refresh()
		End Sub

		Private Sub groupBox3_Enter(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radColorSelector1.ColorChanged, AddressOf radColorSelector1_ColorChanged
			AddHandler radCheckBox9.ToggleStateChanged, AddressOf radCheckBox9_Click
			AddHandler radCheckBox5.ToggleStateChanged, AddressOf radCheckBox5_Click
			AddHandler radCheckBox6.ToggleStateChanged, AddressOf radCheckBox6_Click
			AddHandler radCheckBox7.ToggleStateChanged, AddressOf radCheckBox7_Click
			AddHandler radCheckBox8.ToggleStateChanged, AddressOf radCheckBox8_Click
			AddHandler radTextBox1.TextChanged, AddressOf radTextBox1_TextChanged
			AddHandler radTextBox2.TextChanged, AddressOf radTextBox2_TextChanged
			AddHandler radTextBox3.TextChanged, AddressOf radTextBox3_TextChanged
			AddHandler radCheckBox3.ToggleStateChanged, AddressOf radCheckBox3_Click
			AddHandler radCheckBox2.ToggleStateChanged, AddressOf radCheckBox2_Click
			AddHandler radCheckBox1.ToggleStateChanged, AddressOf radCheckBox1_Click
			AddHandler radCheckBox4.ToggleStateChanged, AddressOf radCheckBox4_Click
		End Sub
	End Class
End Namespace