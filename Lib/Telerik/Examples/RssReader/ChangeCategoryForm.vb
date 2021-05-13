Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace CS
	Partial Public Class ChangeCategoryForm
		Inherits Telerik.WinControls.UI.RadForm
		Public Sub New()
			InitializeComponent()
			radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList
		End Sub
		Public ReadOnly Property CheckBox() As RadCheckBox
			Get
				Return Me.radCheckBox1
			End Get
		End Property

		Public ReadOnly Property RadDropDownList() As RadDropDownList
			Get
				Return Me.radDropDownList1
			End Get
		End Property

		Public ReadOnly Property NewCategoryNameTextBox() As RadTextBox
			Get
				Return Me.radTextBox1
			End Get
		End Property

		Public ReadOnly Property NameTextBox() As RadTextBox
			Get
				Return Me.radTextBox2
			End Get
		End Property



		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				radTextBox1.Enabled = True
				radDropDownList1.Enabled = False
			Else
				radTextBox1.Enabled = False
				radDropDownList1.Enabled = True
			End If
		End Sub

		Public Property ErrorText() As String

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			If radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On AndAlso String.IsNullOrEmpty(radTextBox1.Text) Then
				errorProvider1.SetIconAlignment(radTextBox1, ErrorIconAlignment.MiddleLeft)
				errorProvider1.SetError(Me.radTextBox1, ErrorText)
				Return
			End If
			Me.DialogResult = DialogResult.OK
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Me.DialogResult = DialogResult.Cancel
		End Sub

		Protected Overrides Sub OnShown(ByVal e As EventArgs)
			MyBase.OnShown(e)
			Me.NameTextBox.TextBoxElement.TextBoxItem.HostedControl.Focus()
		End Sub


	End Class
End Namespace
