Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports System.Threading

Namespace SpellCheckAsYouType
	Public Partial Class Form1
		Inherits RadForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub radToggleButton1_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			If Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
				Me.radSpellChecker1.AutoSpellCheckControl = Me.textBox1
			Else
				Me.radSpellChecker1.AutoSpellCheckControl = Nothing
			End If

		End Sub

		Private Sub radToggleButton2_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			If Me.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
				Me.radSpellChecker2.AutoSpellCheckControl = Me.radTextBox1
			Else
				Me.radSpellChecker2.AutoSpellCheckControl = Nothing
			End If
		End Sub

		Private Sub radCheckBox3_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			If Me.radCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
				Me.radSpellChecker3.AutoSpellCheckControl = Me.radTextBoxControl1
			Else
				Me.radSpellChecker3.AutoSpellCheckControl = Nothing
			End If
		End Sub

		Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Form1.Shown
			Me.radSpellChecker1.AutoSpellCheckControl = Me.textBox1
			Me.radSpellChecker2.AutoSpellCheckControl = Me.radTextBox1
			Me.radSpellChecker3.AutoSpellCheckControl = Me.radTextBoxControl1
		End Sub
	End Class
End Namespace