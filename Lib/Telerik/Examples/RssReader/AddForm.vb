Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace CS
	Partial Public Class AddForm
		Inherits Telerik.WinControls.UI.RadForm
		Public Sub New()
			InitializeComponent()
			Me.StartPosition = FormStartPosition.CenterParent
			radTextBox1.Focus()
		End Sub

		Public ReadOnly Property Label() As RadLabel
			Get
				Return Me.radLabel1
			End Get
		End Property

		Public Property RaiseErrorOnEmptyString() As Boolean

'INSTANT VB NOTE: The variable errorText was renamed since Visual Basic does not allow class members with the same name:
		Private errorText_Renamed As String
		Public Property ErrorText() As String
			Get
				Return Me.errorText_Renamed
			End Get

			Set(ByVal value As String)
				Me.errorText_Renamed = value
			End Set
		End Property

		Public ReadOnly Property TextBox() As RadTextBox
			Get
				Return Me.radTextBox1
			End Get
		End Property

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			If RaiseErrorOnEmptyString AndAlso String.IsNullOrEmpty(radTextBox1.Text) Then
				errorProvider1.SetIconAlignment(radTextBox1, ErrorIconAlignment.MiddleLeft)
				errorProvider1.SetError(Me.radTextBox1, errorText_Renamed)
				Return
			End If
			Me.DialogResult = DialogResult.OK
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Me.DialogResult = DialogResult.Cancel
		End Sub
	End Class
End Namespace
