Imports System.IO
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.UseCustomEditors
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim imagesPath As String = Path.Combine(Application.StartupPath, "..\GridView\ManipulateData\UseCustomEditors\Images")
			Dim images() As String = Directory.GetFiles(imagesPath, "*.jpg")

			Dim r As New Random()
			Dim table As New DataTable()

			table.Columns.Add("Image", GetType(Image))
			table.Columns.Add("FileName", GetType(String))
			table.Columns.Add("Opacity", GetType(Integer))

			For i As Integer = 0 To images.Length - 1
				table.Rows.Add(Image.FromFile(images(i)), images(i), r.Next(100))
			Next i

			Me.radGridView1.TableElement.BeginUpdate()

			Me.radGridView1.DataSource = table
			Me.radGridView1.TableElement.RowHeight = 89
			Me.radGridView1.Columns(0).Width = 120
			Me.radGridView1.Columns(0).MaxWidth = 120
			Me.radGridView1.Columns(1).Width = 500
			Me.radGridView1.Columns(2).Width = 200
			Me.radGridView1.Columns(2).FormatString = "{0} %"

            Me.radGridView1.TableElement.EndUpdate()
            Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			AddHandler radGridView1.ValueChanged, AddressOf radGridView1_ValueChanged
		End Sub

		' use this event to replace the default editor for a specific cell
		Private Sub radGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
			If e.EditorType Is GetType(GridSpinEditor) AndAlso (Not Me.radGridView1.Columns(0).IsCurrent) Then
				e.EditorType = GetType(TrackBarEditor)
			ElseIf e.EditorType Is GetType(RadTextBoxEditor) Then
				e.EditorType = GetType(BrowseEditor)
			End If
		End Sub

		' use the event to customize the cell appearance
		Private Sub radGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If TypeOf e.CellElement Is GridImageCellElement Then
				Dim opacityValue As Object = e.CellElement.RowInfo.Cells("Opacity").Value
				Dim opacity As Integer = 0

				If opacityValue IsNot Nothing AndAlso (Not Convert.IsDBNull(opacityValue)) Then
					opacity = Convert.ToInt32(opacityValue)
				End If

				e.CellElement.ImageOpacity = CDbl(opacity / 100.0)
				e.CellElement.ImageLayout = ImageLayout.Zoom
			End If
		End Sub

		' Fires when the cell changes its value
		Private Sub radGridView1_CellValueChanged(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
			Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
			If column IsNot Nothing AndAlso column.FieldName = "FileName" Then
				Dim value As Object = Nothing

				If e.Value IsNot Nothing AndAlso (Not Convert.IsDBNull(e.Value)) Then
					value = Image.FromFile(e.Value.ToString())
				End If

				Me.radGridView1.CurrentRow.Cells("Image").Value = value
			End If
		End Sub

		' Fires when the editor changes its value. The value is stored only inside the editor.
		Private Sub radGridView1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim editor As TrackBarEditor = TryCast(sender, TrackBarEditor)

			If editor IsNot Nothing Then
				Dim cell As GridCellElement = Me.radGridView1.TableElement.GetCellElement(Me.radGridView1.CurrentRow, Me.radGridView1.Columns("Opacity"))

				If cell IsNot Nothing Then
                    cell.Text = editor.Value.ToString() & " %"
				End If

				Dim imageCell As GridCellElement = Me.radGridView1.TableElement.GetCellElement(Me.radGridView1.CurrentRow, Me.radGridView1.Columns("Image"))

				If imageCell IsNot Nothing Then
					imageCell.ImageOpacity = CDbl(CSng(editor.Value) / 100.0)
				End If
			End If
		End Sub

		Protected Overrides Sub WireEvents()
			AddHandler radGridView1.CellFormatting, AddressOf radGridView1_CellFormatting
			AddHandler radGridView1.EditorRequired, AddressOf radGridView1_EditorRequired
			AddHandler radGridView1.CellValueChanged, AddressOf radGridView1_CellValueChanged
		End Sub
	End Class
End Namespace
