Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Rows.RowsDragDrop
	Public Class CustomGridBehavior
		Inherits BaseGridBehavior
'INSTANT VB NOTE: The variable selectedRows was renamed since Visual Basic does not allow class members with the same name:
		Private selectedRows_Renamed As New List(Of GridViewRowInfo)()

		Public ReadOnly Property SelectedRows() As List(Of GridViewRowInfo)
			Get
				Return Me.selectedRows_Renamed
			End Get
		End Property

		Public Overrides Function OnMouseDown(ByVal e As MouseEventArgs) As Boolean
			selectedRows_Renamed.Clear()
			Dim result As Boolean = MyBase.OnMouseDown(e)

			If (Control.ModifierKeys And Keys.Control) = Keys.Control OrElse (Control.ModifierKeys And Keys.Shift) = Keys.Shift Then
				selectedRows_Renamed.AddRange(Me.GridControl.SelectedRows)
			Else
				selectedRows_Renamed.Add(Me.GridControl.CurrentRow)
			End If

			Return result
		End Function
	End Class
End Namespace
