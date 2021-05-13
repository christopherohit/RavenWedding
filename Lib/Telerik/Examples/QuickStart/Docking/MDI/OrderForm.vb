Imports System.ComponentModel
Imports System.Text

Namespace Telerik.Examples.WinControls.Docking.MDI
	Partial Public Class OrderForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ordersBindingNavigatorSaveItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Validate()
			Me.ordersBindingSource.EndEdit()
			Me.ordersTableAdapter.Update(Me.nwindRadGridView.Orders)

		End Sub


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' TODO: This line of code loads data into the 'nwindRadGridView.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindRadGridView.Orders)
		End Sub
	End Class
End Namespace