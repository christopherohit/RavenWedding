Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.SaveLoadLayout
	Public Partial Class Form1
		Inherits ExamplesForm
		Private ReadOnly selectCommand As String = "SELECT CustomerID, CompanyName, ContactName, Country, City FROM Customers"
		Private columnNames As String() = New String() {"Customer Id", "Company Name", "Contact Name", "Country", "City"}
		Private data As New List(Of Customer)()

		Public Sub New()
			InitializeComponent()

			Me.radVirtualGrid1.ColumnCount = columnNames.Length
			Me.radVirtualGrid1.AllowAddNewRow = False
			Me.radVirtualGrid1.AllowDelete = False
			Me.radVirtualGrid1.AllowEdit = False
			Me.radVirtualGrid1.AllowRowResize = True
			Me.radVirtualGrid1.AllowColumnResize = True

			SelectData()

			Me.radVirtualGrid1.TableElement.SetRowPinPosition(2, PinnedRowPosition.Top)
			Me.radVirtualGrid1.TableElement.SetRowPinPosition(12, PinnedRowPosition.Top)
			Me.radVirtualGrid1.TableElement.SetRowPinPosition(22, PinnedRowPosition.Top)

			Me.radVirtualGrid1.TableElement.SetRowPinPosition(1, PinnedRowPosition.Bottom)
			Me.radVirtualGrid1.TableElement.SetRowPinPosition(11, PinnedRowPosition.Bottom)
			Me.radVirtualGrid1.TableElement.SetRowPinPosition(21, PinnedRowPosition.Bottom)

			Me.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radButtonSaveLayout.Click, AddressOf radButtonSaveLayout_Click
			AddHandler Me.radButtonLoadLayout.Click, AddressOf radButtonLoadLayout_Click
		End Sub

		Private Sub radButtonSaveLayout_Click(sender As Object, e As EventArgs)
			Dim dialog As New SaveFileDialog()
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            dialog.Title = "Select a xml file"

			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radVirtualGrid1.SaveLayout(dialog.FileName)
			End If
		End Sub

		Private Sub radButtonLoadLayout_Click(sender As Object, e As EventArgs)
			Dim dialog As New OpenFileDialog()
            dialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            dialog.Title = "Select a xml file"

			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radVirtualGrid1.LoadLayout(dialog.FileName)
			End If
		End Sub

		#Region "VirtualGrid events"

        Private Sub radVirtualGrid1_CellValueNeeded(sender As Object, e As VirtualGridCellValueNeededEventArgs) Handles radVirtualGrid1.CellValueNeeded
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

        Private Sub radVirtualGrid1_SortChanged(sender As Object, e As VirtualGridEventArgs) Handles radVirtualGrid1.SortChanged
            SelectData()
        End Sub

        Private Sub radVirtualGrid1_FilterChanged(sender As Object, e As VirtualGridEventArgs) Handles radVirtualGrid1.FilterChanged
            SelectData()
        End Sub

        Private Sub radVirtualGrid1_CellFormatting(sender As Object, e As VirtualGridCellElementEventArgs) Handles radVirtualGrid1.CellFormatting
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        End Sub

		#End Region

		#Region "OleDb CRUD"

		Private Sub SelectData()
			Dim sortExpression As String = Me.radVirtualGrid1.SortDescriptors.Expression
			Dim filterExpression As String = Me.radVirtualGrid1.FilterDescriptors.Expression

			If Not String.IsNullOrEmpty(sortExpression) Then
				sortExpression = Convert.ToString("ORDER BY ") & sortExpression
			End If

			If Not String.IsNullOrEmpty(filterExpression) Then
				filterExpression = Convert.ToString("WHERE ") & filterExpression
			End If

			Dim commandString As String = [String].Format("{0} {1} {2}", selectCommand, filterExpression, sortExpression)

			Using command As New OleDbCommand(commandString)
                command.Connection = New OleDbConnection(My.Settings.NwindConnectionString)
				command.Connection.Open()
				Dim reader As IDataReader = command.ExecuteReader()
				data.Clear()

				While reader.Read()
					Dim customer As New Customer(Convert.ToString(reader(0)), Convert.ToString(reader(1)), Convert.ToString(reader(2)), Convert.ToString(reader(3)), Convert.ToString(reader(4)))
					data.Add(customer)
				End While

				command.Connection.Close()
			End Using

			Me.radVirtualGrid1.RowCount = data.Count
		End Sub

		#End Region
	End Class
End Namespace