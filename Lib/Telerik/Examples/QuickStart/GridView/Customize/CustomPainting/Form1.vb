Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports System.Drawing.Drawing2D

Namespace Telerik.Examples.WinControls.GridView.Customize.CustomPainting
	Partial Public Class Form1
		Inherits ExamplesForm
		Private r As New Random()

		Private fills() As Color = { Color.FromArgb(153, 255, 0), Color.FromArgb(255, 204, 204), Color.FromArgb(0, 255, 255) }

		Private borders() As Color = { Color.Green, Color.Red, Color.Blue }

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub AddRow(ByVal table As DataTable, ByVal rowID As Integer, ByVal task As String, ByVal project As String)
			Dim start As Integer = r.Next(4) + 6
			Dim [end] As Integer = start + r.Next(8)
			If [end] > 14 Then
				[end] = 14
			End If
			table.Rows.Add(rowID, task, project, start, [end], r.Next(3))
		End Sub

		Private Function GetCell(ByVal rowElement As GridRowElement, ByVal index As Integer) As GridDataCellElement
			For Each cell As GridCellElement In rowElement.VisualCells
				If cell.ColumnInfo IsNot Nothing AndAlso cell.ColumnInfo.Index = index Then
					Return TryCast(cell, GridDataCellElement)
				End If
			Next cell
			Return Nothing
		End Function

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim table As New DataTable()

			table.Columns.Add("ID", GetType(Integer))
			table.Columns.Add("Task", GetType(String))
			table.Columns.Add("Project", GetType(String))
			table.Columns.Add("StartCell", GetType(Integer))
			table.Columns.Add("EndCell", GetType(Integer))
			table.Columns.Add("Color", GetType(Integer))

			AddRow(table, 1, "Task 1", "Project 1")
			AddRow(table, 2, "Task 2", "Project 1")
			AddRow(table, 3, "Task 3", "Project 1")
			AddRow(table, 4, "Task 4", "Project 1")
			AddRow(table, 5, "Task 5", "Project 1")

			AddRow(table, 6, "Task 1", "Project 2")
			AddRow(table, 7, "Task 2", "Project 2")
			AddRow(table, 8, "Task 3", "Project 2")

			Me.radGridView1.EnableCustomDrawing = True

			Me.radGridView1.ReadOnly = True
			Me.radGridView1.AutoExpandGroups = True
			Me.radGridView1.DataSource = table
			Me.radGridView1.GroupDescriptors.Add(New Telerik.WinControls.Data.GroupDescriptor("Project"))

			Dim months() As String = { "Jan", "Feb", "Mar" }

			For i As Integer = 0 To months.Length - 1
				For j As Integer = 1 To 4
					Dim column As New GridViewTextBoxColumn(months(i) & "Week" & j)
					column.HeaderText = "Week " & j.ToString()
					Me.radGridView1.Columns.Add(column)
				Next j
			Next i

			Dim def As New ColumnGroupsViewDefinition()
			def.ColumnGroups.Add(New GridViewColumnGroup("Event"))
			def.ColumnGroups(0).ShowHeader = False
			def.ColumnGroups(0).Rows.Add(New GridViewColumnGroupRow())
            def.ColumnGroups(0).Rows(0).ColumnNames.Add(Me.radGridView1.Columns(0).Name)
            def.ColumnGroups(0).Rows(0).ColumnNames.Add(Me.radGridView1.Columns(1).Name)

			For i As Integer = 0 To months.Length - 1
				def.ColumnGroups.Add(New GridViewColumnGroup(months(i) & "'11"))
				def.ColumnGroups(1 + i).Rows.Add(New GridViewColumnGroupRow())
				For j As Integer = 1 To 4
                    def.ColumnGroups(1 + i).Rows(0).ColumnNames.Add(Me.radGridView1.Columns(months(i) & "Week" & j).Name)
				Next j
            Next i

			Me.radGridView1.ViewDefinition = def
		End Sub

		Private Sub radGridView1_CreateRowInfo(ByVal sender As Object, ByVal e As GridViewCreateRowInfoEventArgs)
			e.RowInfo.Height = 28
		End Sub

		Private Sub radGridView1_RowPaint(ByVal sender As Object, ByVal e As GridViewRowPaintEventArgs)
			If TypeOf e.Row Is GridDataRowElement Then
				Dim rowElement As GridDataRowElement = CType(e.Row, GridDataRowElement)
				Dim startIndex As Integer = CInt(Fix(e.Row.RowInfo.Cells("StartCell").Value))
				Dim endIndex As Integer = CInt(Fix(e.Row.RowInfo.Cells("EndCell").Value))
				Dim startCell As GridDataCellElement = GetCell(e.Row, startIndex)
				Dim endCell As GridDataCellElement = GetCell(e.Row, endIndex)

				If startCell IsNot Nothing OrElse endCell IsNot Nothing Then
					Dim left As Integer = If(startCell Is Nothing, rowElement.ScrollableColumns.BoundingRectangle.Left - 10, startCell.ControlBoundingRectangle.Left)
					Dim right As Integer = If(endCell Is Nothing, rowElement.ScrollableColumns.BoundingRectangle.Right + 10, endCell.ControlBoundingRectangle.Right)

					e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
					Dim clipRegion As Region = e.Graphics.Clip

					e.Graphics.SetClip(rowElement.ScrollableColumns.BoundingRectangle)

					Dim randomColor As Integer = CInt(Fix(e.Row.RowInfo.Cells("Color").Value))

					Using shape As New RoundRectShape(5)
					Using path As GraphicsPath = shape.CreatePath(New RectangleF(left + 5, 5, (right - left) - 10, e.Row.Size.Height - 10))
					Using brush As Brush = New SolidBrush(fills(randomColor))
					Using pen As New Pen(borders(randomColor), 2)
						e.Graphics.FillPath(brush, path)
						e.Graphics.DrawPath(pen, path)
					End Using
					End Using
					End Using
					End Using

					e.Graphics.Clip = clipRegion
				End If
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radGridView1.CreateRowInfo, AddressOf radGridView1_CreateRowInfo
			AddHandler radGridView1.RowPaint, AddressOf radGridView1_RowPaint
		End Sub
	End Class
End Namespace
