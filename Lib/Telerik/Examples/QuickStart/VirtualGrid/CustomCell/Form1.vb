Imports Microsoft.VisualBasic
Imports System
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.CustomCell
	Public Partial Class Form1
		Inherits ExamplesForm
		Private [set] As NorthwindDataSet = New NorthwindDataSet()
		Private columns As String()
		Private fields As String()

		Public Sub New()
			InitializeComponent()

			Dim products As ProductsTableAdapter = New ProductsTableAdapter()
			products.Fill([set].Products)

			Me.columns = New String() { "Product Name", "Units in stock", "Units on order", "Discontinued" }
			Me.fields = New String() { "ProductName", "UnitsInStock", "UnitsOnOrder", "Discontinued" }

			Me.radVirtualGrid1.ColumnCount = Me.columns.Length
			Me.radVirtualGrid1.RowCount = [set].Products.Rows.Count

			Me.radVirtualGrid1.TableElement.ColumnWidth = 150
			Me.radVirtualGrid1.TableElement.SetColumnWidth(0, 500)

			AddHandler Me.radVirtualGrid1.CellValueNeeded, AddressOf radVirtualGrid1_CellValueNeeded
			AddHandler Me.radVirtualGrid1.CellValuePushed, AddressOf radVirtualGrid1_CellValuePushed
			AddHandler Me.radVirtualGrid1.CellFormatting, AddressOf radVirtualGrid1_CellFormatting
			AddHandler Me.radVirtualGrid1.EditorRequired, AddressOf radVirtualGrid1_EditorRequired
			AddHandler Me.radVirtualGrid1.CreateCellElement, AddressOf radVirtualGrid1_CreateCellElement
		End Sub

		Private Sub radVirtualGrid1_EditorRequired(ByVal sender As Object, ByVal e As VirtualGridEditorRequiredEventArgs)
			Dim columnName As String = Me.columns(e.ColumnIndex)

			Select Case columnName
				Case "ProductName"
					e.Editor = New VirtualGridTextBoxEditor()
				Case "UnitsInStock", "UnitsOnOrder"
					e.Editor = New VirtualGridSpinEditor()
				Case "Discontinued"
					e.Cancel = True
			End Select
		End Sub

		Private Sub radVirtualGrid1_CellFormatting(ByVal sender As Object, ByVal e As VirtualGridCellElementEventArgs)
			If e.CellElement.RowIndex < 0 OrElse e.CellElement.ColumnIndex < 0 Then
				Return
			End If

			Dim columnName As String = Me.fields(e.CellElement.ColumnIndex)

			Select Case columnName
				Case "ProductName"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
				Case "UnitsInStock", "UnitsOnOrder"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
			End Select
		End Sub

		Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As VirtualGridCellValueNeededEventArgs)
			If e.ColumnIndex < 0 Then
				Return
			End If

			If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
				e.Value = Me.columns(e.ColumnIndex)
			End If

			If e.RowIndex < 0 Then
				Return
			End If

			e.FieldName = Me.fields(e.ColumnIndex)
			e.Value = Me.set.Products.Rows(e.RowIndex)(e.FieldName)
		End Sub

		Private Sub radVirtualGrid1_CellValuePushed(ByVal sender As Object, ByVal e As VirtualGridCellValuePushedEventArgs)
			Try
				Me.set.Products.Rows(e.RowIndex)(Me.fields(e.ColumnIndex)) = e.Value
			Catch e1 As Exception
				'Indicate error
			End Try
		End Sub

		Private Sub radVirtualGrid1_CreateCellElement(ByVal sender As Object, ByVal e As VirtualGridCreateCellEventArgs)
			If e.ColumnIndex = 3 AndAlso e.RowIndex >= 0 Then
				e.CellElement = New MyVirtualGridCheckBoxCellElement()
			End If
		End Sub
	End Class
End Namespace
