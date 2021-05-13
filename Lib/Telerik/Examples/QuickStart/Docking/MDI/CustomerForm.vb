Imports System.ComponentModel
Imports System.Text

Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class CustomerForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub customersBindingNavigatorSaveItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Validate()
			Me.customersBindingSource.EndEdit()
			Me.customersTableAdapter.Update(Me.nwindRadGridView.Customers)

		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' TODO: This line of code loads data into the 'nwindRadGridView.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
		End Sub
	End Class
End Namespace