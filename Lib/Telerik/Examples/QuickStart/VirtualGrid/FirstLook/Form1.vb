Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.FirstLook
	Public Partial Class Form1
		Inherits ExamplesForm
		Private ReadOnly selectCommand As String = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, PostalCode FROM Customers"
		Private columnNames As String() = New String() { "Company Name", "Contact Name", "Contact Title", "Address", "Postal Code" }
		Private data As List(Of Customer) = New List(Of Customer)()

		Public Sub New()
			InitializeComponent()
			Me.radVirtualGrid1.ColumnCount = columnNames.Length
			SelectData()
		End Sub

		#Region "VirtualGrid events"

		Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs) Handles radVirtualGrid1.CellValueNeeded
			If e.ColumnIndex < 0 Then
			Return
			End If
			If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
				e.Value = columnNames(e.ColumnIndex)
			End If

			If e.RowIndex < 0 Then
				e.FieldName = columnNames(e.ColumnIndex).Replace(" ", "")
			End If

			If e.RowIndex >= 0 AndAlso e.RowIndex < data.Count Then
				e.Value = data(e.RowIndex)(e.ColumnIndex)
			End If
		End Sub

		Private Sub radVirtualGrid1_CellValuePushed(ByVal sender As Object, ByVal e As VirtualGridCellValuePushedEventArgs) Handles radVirtualGrid1.CellValuePushed
			Me.UpdateCellValue(data(e.RowIndex).CustomerId, columnNames(e.ColumnIndex).Replace(" ", ""), Convert.ToString(e.Value))
		End Sub

		Private Sub radVirtualGrid1_UserAddedRow(ByVal sender As Object, ByVal e As VirtualGridNewRowEventArgs) Handles radVirtualGrid1.UserAddedRow
			Dim newValues As List(Of Object) = New List(Of Object)()

			Dim i As Integer = 0
			Do While i < columnNames.Length
				If e.NewValues.ContainsKey(i) Then
					newValues.Add(e.NewValues(i))
				Else
					newValues.Add(DBNull.Value)
				End If
				i += 1
			Loop

			Me.AddDataRow(newValues)
		End Sub

		Private Sub radVirtualGrid1_UserDeletingRow(ByVal sender As Object, ByVal e As VirtualGridRowsEventArgs) Handles radVirtualGrid1.UserDeletedRow
			For Each rowIndex As Integer In e.RowIndices
				Me.DeleteDataRow(data(rowIndex).CustomerId)
			Next rowIndex
		End Sub

		Private Sub radVirtualGrid1_SortChanged(ByVal sender As Object, ByVal e As VirtualGridEventArgs) Handles radVirtualGrid1.SortChanged
			SelectData()
		End Sub

		Private Sub radVirtualGrid1_FilterChanged(ByVal sender As Object, ByVal e As VirtualGridEventArgs) Handles radVirtualGrid1.FilterChanged
			SelectData()
		End Sub

		Private Sub radVirtualGrid1_CellFormatting(ByVal sender As Object, ByVal e As VirtualGridCellElementEventArgs) Handles radVirtualGrid1.CellFormatting
		   e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
		End Sub

		#End Region

		#Region "OleDb CRUD"

		Private Sub SelectData()
			Dim sortExpression As String = Me.radVirtualGrid1.SortDescriptors.Expression
			Dim filterExpression As String = Me.radVirtualGrid1.FilterDescriptors.Expression
			If (Not String.IsNullOrEmpty(sortExpression)) Then
				sortExpression = "ORDER BY " & sortExpression
			End If

			If (Not String.IsNullOrEmpty(filterExpression)) Then
				filterExpression = "WHERE " & filterExpression
			End If

			Dim commandString As String = String.Format("{0} {1} {2}", selectCommand, filterExpression, sortExpression)
			Using command As OleDbCommand = New OleDbCommand(commandString)
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
				command.Connection.Open()
				Dim reader As IDataReader = command.ExecuteReader()
				data.Clear()

				Do While reader.Read()
					Dim customer As Customer = New Customer(Convert.ToString(reader(0)), Convert.ToString(reader(1)), Convert.ToString(reader(2)), Convert.ToString(reader(3)), Convert.ToString(reader(4)), Convert.ToString(reader(5)))
					data.Add(customer)
				Loop

				command.Connection.Close()
			End Using

			Me.radVirtualGrid1.RowCount = data.Count
		End Sub

		Private Sub DeleteDataRow(ByVal id As String)
			Using command As OleDbCommand = New OleDbCommand("DELETE FROM Customers where CustomerID = ?")
				command.Parameters.Add(New OleDbParameter("@customerId", id))
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
				command.Connection.Open()
				command.ExecuteNonQuery()
				command.Connection.Close()

			End Using

			SelectData()
		End Sub

		Private Sub AddDataRow(ByVal newValues As List(Of Object))
			Using command As OleDbCommand = New OleDbCommand("INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, PostalCode) " & ControlChars.CrLf & "values (?, ?, ?, ?, ?, ?)")
				command.Parameters.Add(New OleDbParameter("@param1", GenerateID()))
				command.Parameters.Add(New OleDbParameter("@param2", Convert.ToString(newValues(0))))
				command.Parameters.Add(New OleDbParameter("@param3", Convert.ToString(newValues(1))))
				command.Parameters.Add(New OleDbParameter("@param4", Convert.ToString(newValues(2))))
				command.Parameters.Add(New OleDbParameter("@param5", Convert.ToString(newValues(3))))
				command.Parameters.Add(New OleDbParameter("@param6", Convert.ToString(newValues(4))))
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
				command.Connection.Open()
				command.ExecuteNonQuery()
				command.Connection.Close()
			End Using

			Dim currentColumn As Integer = Me.radVirtualGrid1.VirtualGridElement.CurrentCell.ColumnIndex

			SelectData()

			Me.radVirtualGrid1.VirtualGridElement.InputBehavior.SelectCell (data.Count - 1, currentColumn, False, False, Me.radVirtualGrid1.VirtualGridElement.MasterViewInfo)
		End Sub

		Private Sub UpdateCellValue(ByVal id As String, ByVal columnName As String, ByVal value As String)
			Using command As OleDbCommand = New OleDbCommand("UPDATE Customers SET " & columnName & " = ? WHERE CustomerID = ?")
				command.Parameters.Add(New OleDbParameter("@columnValue", value))
				command.Parameters.Add(New OleDbParameter("@customerId", id))
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
				command.Connection.Open()
				command.ExecuteNonQuery()
				command.Connection.Close()
			End Using

			SelectData()
		End Sub

		Private Function GenerateID() As String
			Dim sb As StringBuilder = New StringBuilder()
			Dim rand As Random = New Random()

			For i As Integer = 0 To 4
                sb.Append(CChar("A"c & rand.Next(26)))
			Next i

			Return sb.ToString()
		End Function

		#End Region
	End Class
End Namespace
