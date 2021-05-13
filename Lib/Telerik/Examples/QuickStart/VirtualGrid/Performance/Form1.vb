Imports Microsoft.VisualBasic
Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Performance
	Public Partial Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()

			Me.radVirtualGrid1.ColumnCount = 0
			Me.radVirtualGrid1.RowCount = 0
			Me.radVirtualGrid1.AllowFiltering = False
			Me.radVirtualGrid1.AllowAddNewRow = False

			AddHandler Me.radVirtualGrid1.CellValueNeeded, AddressOf radVirtualGrid1_CellValueNeeded
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radSpinEditorRowSize.ValueChanged, AddressOf radSpinEditorRowSize_ValueChanged
			AddHandler Me.radSpinEditorColumnSize.ValueChanged, AddressOf radSpinEditorColumnSize_ValueChanged
			AddHandler Me.radButtonLoad.Click, AddressOf radButtonLoad_Click
		End Sub

		Private Sub radButtonLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.radVirtualGrid1.Visible = True

			RemoveHandler Me.radButtonLoad.Click, AddressOf radButtonLoad_Click
			Me.radButtonLoad.Parent.Controls.Remove(Me.radButtonLoad)

			Me.radVirtualGrid1.BeginUpdate()

			Me.radVirtualGrid1.ColumnCount = 1000
			Me.radVirtualGrid1.RowCount = 1000000

			Me.radVirtualGrid1.EndUpdate()
		End Sub

		Private Sub radSpinEditorColumnSize_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.radVirtualGrid1.BeginUpdate()

			Dim i As Integer = 0
			Do While i < Me.radVirtualGrid1.ColumnCount
				Me.radVirtualGrid1.VirtualGridElement.SetColumnWidth(i, CInt(Fix(Me.radSpinEditorColumnSize.Value)))
				i += 2
			Loop

			Me.radVirtualGrid1.EndUpdate()
		End Sub

		Private Sub radSpinEditorRowSize_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.radVirtualGrid1.BeginUpdate()

			Dim i As Integer = 0
			Do While i < Me.radVirtualGrid1.RowCount
				Me.radVirtualGrid1.VirtualGridElement.SetRowHeight(i, CInt(Fix(Me.radSpinEditorRowSize.Value)))
				i += 10
			Loop

			Me.radVirtualGrid1.EndUpdate()
		End Sub

		Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs)
			If e.ColumnIndex < 0 Then
				Return
			End If

			If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
				e.Value = e.ColumnIndex
			End If

			If e.RowIndex < 0 Then
				Return
			End If

			e.Value = "" & e.RowIndex & " x " & e.ColumnIndex
		End Sub
	End Class
End Namespace
