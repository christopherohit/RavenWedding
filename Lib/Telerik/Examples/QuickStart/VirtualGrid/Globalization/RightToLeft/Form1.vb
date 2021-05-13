
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.RightToLeft
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
			Me.radVirtualGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
			Me.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill

			SelectData()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radToggleButtonUseRTL.ToggleStateChanged, AddressOf radToggleButtonUseRTL_ToggleStateChanged
		End Sub

		Private Sub radToggleButtonUseRTL_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.[On] Then
				Me.radVirtualGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
			Else
				Me.radVirtualGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No
			End If
		End Sub

		#Region "VirtualGrid events"

        Private Sub radVirtualGrid1_CellValueNeeded(sender As Object, e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs) Handles radVirtualGrid1.CellValueNeeded
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