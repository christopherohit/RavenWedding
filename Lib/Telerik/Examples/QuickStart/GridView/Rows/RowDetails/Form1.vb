Imports System.ComponentModel
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports System.IO
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.Rows.RowDetails
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
			Me.employeesTableAdapter.Fill(Me.northwindDataSet.Employees)

			Me.radGridView1.ReadOnly = True
			Me.radGridView1.AllowColumnReorder = False
			Me.radGridView1.AllowColumnResize = False
			Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radGridView1.AutoExpandGroups = True
			Me.radGridView1.TableElement.RowHeight = 40

			Me.radGridView1.GroupDescriptors.Add(New GridGroupByExpression("City GroupBy City"))
			Me.radGridView1.Groups(1)(0).IsCurrent = True

			Me.radGridView1.Columns("Photo").VisibleInColumnChooser = False
			Me.radGridView1.Columns("Photo").IsVisible = False
			Me.radGridView1.Columns("Notes").WrapText = True
			Me.radGridView1.Columns("LastName").SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending

			Me.radGridView1.DetailsColumn = Me.radGridView1.Columns("Notes")
		End Sub

		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs)
			If e.CellElement.RowInfo.IsCurrent AndAlso e.CellElement.ColumnInfo Is Me.radGridView1.DetailsColumn Then
                e.CellElement.TextImageRelation = TextImageRelation.ImageBeforeText
				e.CellElement.TextAlignment = ContentAlignment.TopLeft
				e.CellElement.ImageAlignment = ContentAlignment.MiddleLeft
				e.CellElement.Padding = New Padding(10)
				e.CellElement.ImageLayout = ImageLayout.Zoom

				Dim bytes() As Byte = CType(e.CellElement.RowInfo.Cells("Photo").Value, Byte())
				e.CellElement.Image = GetImageFromBytes(bytes)
			Else
				e.CellElement.ResetValue(LightVisualElement.ImageProperty, ValueResetFlags.Local)
				e.CellElement.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local)
			End If
		End Sub

		Private Const OleHeaderSize As Integer = 78

		Private Function GetImageFromBytes(ByVal bytes() As Byte) As Image
			If bytes Is Nothing OrElse bytes.Length = 0 Then
				Return Nothing
			End If

			Dim result As Image = Nothing
			Dim stream As MemoryStream = Nothing

			Try
				Dim count As Integer
				Dim start As Integer

				If IsOleContainer(bytes) Then
					count = bytes.Length - OleHeaderSize
					start = OleHeaderSize
				Else
					count = bytes.Length
					start = 0
				End If

				stream = New MemoryStream(bytes, start, count)
				result = Image.FromStream(stream)
			Catch
				result = Nothing
			Finally
				If stream IsNot Nothing Then
					stream.Close()
				End If
			End Try
			Return result
		End Function

		Private Function IsOleContainer(ByVal imageData() As Byte) As Boolean
			Return (imageData IsNot Nothing AndAlso imageData(0) = &H15 AndAlso imageData(1) = &H1C)
		End Function

		Protected Overrides Sub WireEvents()
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
		End Sub
	End Class
End Namespace
