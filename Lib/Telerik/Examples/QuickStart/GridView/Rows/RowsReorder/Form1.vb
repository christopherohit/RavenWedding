Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Namespace Telerik.Examples.WinControls.GridView.Rows.RowsReorder
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub BindGrid()
			Me.radGridView1.Rows.Add(1, Me.imageList1.Images("TaskCompleted.png"), "Call Linda", Date.Now.AddHours(5))
			Me.radGridView1.Rows.Add(2, Me.imageList1.Images("TaskCompleted.png"), "Change car oil", Date.Now.AddDays(5))
			Me.radGridView1.Rows.Add(3, Me.imageList1.Images("TaskCompleted.png"), "Pick up laundry", Date.Now.AddDays(1))
			Me.radGridView1.Rows.Add(4, Me.imageList1.Images("TaskCompleted.png"), "Buy Helloween costume", Date.Now.AddMonths(1))
			Me.radGridView1.Rows.Add(5, Me.imageList1.Images("TaskCompleted.png"), "Walk the dog", Date.Now.AddHours(3))
			Me.radGridView1.Rows.Add(6, Me.imageList1.Images("TaskNotCompleted.png"), "Repair John's computer", Date.Now.AddDays(2))
			Me.radGridView1.Rows.Add(7, Me.imageList1.Images("TaskNotCompleted.png"), "Go to the library", Date.Now.AddDays(4))
			Me.radGridView1.Rows.Add(8, Me.imageList1.Images("TaskNotCompleted.png"), "Buy present for Mike's birthday", Date.Now.AddDays(1))
			Me.radGridView1.Rows.Add(9, Me.imageList1.Images("TaskNotCompleted.png"), "Pay all bills", Date.Now.AddDays(9))
			Me.radGridView1.Rows.Add(10, Me.imageList1.Images("TaskCompleted.png"), "Moving a house", Date.Now.AddDays(10))
		End Sub

		Private Sub MoveRow(ByVal moveUp As Boolean)
			Dim currentRow As GridViewRowInfo = Me.radGridView1.CurrentRow

			If currentRow Is Nothing Then
				Return
			End If

			Dim index As Integer = If(moveUp, currentRow.Index - 1, currentRow.Index + 1)

			If index < 0 OrElse index >= Me.radGridView1.RowCount Then
				Return
			End If

			Me.radGridView1.Rows.Move(index, currentRow.Index)
			Me.radGridView1.CurrentRow = Me.radGridView1.Rows(index)
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.radGridView1.TableElement.RowHeight = 50
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.AllowRowReorder = True
			Me.radGridView1.ReadOnly = True
			AddHandler radGridView1.Rows.CollectionChanged, AddressOf Rows_CollectionChanged

			Dim imageColumn As New GridViewImageColumn("Image", "Image")
			imageColumn.Width = 50
			imageColumn.HeaderText = String.Empty

			Dim priorityColumn As New GridViewDecimalColumn(GetType(Integer), "Priority", "Priority")
			priorityColumn.HeaderText = "#"
			priorityColumn.Width = 50
			priorityColumn.ReadOnly = True

			Dim taskColumn As New GridViewTextBoxColumn("Task", "Task")
			taskColumn.Width = 180

			Dim dueDateColumn As New GridViewDateTimeColumn("DueDate", "Due Date")
			dueDateColumn.Width = 120

			Me.radGridView1.Columns.Add(priorityColumn)
			Me.radGridView1.Columns.Add(imageColumn)
			Me.radGridView1.Columns.Add(taskColumn)
			Me.radGridView1.Columns.Add(dueDateColumn)

			Me.BindGrid()

			Me.btnMoveUp.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.btnMoveUp.TextImageRelation = TextImageRelation.ImageBeforeText
			Me.btnMoveDown.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.btnMoveDown.TextImageRelation = TextImageRelation.ImageBeforeText
		End Sub

		Private Sub btnMoveUp_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.MoveRow(True)
		End Sub

		Private Sub btnMoveDown_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.MoveRow(False)
		End Sub

		Private Sub Rows_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
			If e.Action = NotifyCollectionChangedAction.Move Then
				For i As Integer = 0 To Me.radGridView1.Rows.Count - 1
					Me.radGridView1.Rows(i).Cells("Priority").Value = i + 1
				Next i
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler btnMoveUp.Click, AddressOf btnMoveUp_Click
			AddHandler btnMoveDown.Click, AddressOf btnMoveDown_Click
		End Sub
	End Class
End Namespace
