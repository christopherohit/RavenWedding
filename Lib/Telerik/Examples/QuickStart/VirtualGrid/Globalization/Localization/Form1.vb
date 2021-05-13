
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Localization

Namespace Telerik.Examples.WinControls.VirtualGrid.Globalization.Localization
	Public Partial Class Form1
		Inherits ExamplesForm
		Private oldProvider As RadVirtualGridLocalizationProvider
		Private ReadOnly selectCommand As String = "SELECT ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products"
		Private columnNames As String() = New String() {"Product Name", "Unit Quantity", "Unit Price", "In Stock", "Ordered Units"}
		Private data As New List(Of Product)()

		Public Sub New()
			InitializeComponent()

			Me.radVirtualGrid1.ColumnCount = columnNames.Length
			Me.radVirtualGrid1.AllowDelete = False
			Me.radVirtualGrid1.AllowEdit = False
			Me.radVirtualGrid1.AllowSorting = False
			Me.radVirtualGrid1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill

			Me.oldProvider = RadVirtualGridLocalizationProvider.CurrentProvider
			RadVirtualGridLocalizationProvider.CurrentProvider = New MyGermanRadVirtualGridLocalizationProvider()

			SelectData()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radRadioButtonGerman.ToggleStateChanged, AddressOf radRadioButtonGerman_ToggleStateChanged
		End Sub

		Private Sub radRadioButtonGerman_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.[On] Then
				RadVirtualGridLocalizationProvider.CurrentProvider = New MyGermanRadVirtualGridLocalizationProvider()
			Else
				RadVirtualGridLocalizationProvider.CurrentProvider = Me.oldProvider
			End If

			Me.radVirtualGrid1.VirtualGridElement.TableElement.SynchronizeRows()
        End Sub

        Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            RadVirtualGridLocalizationProvider.CurrentProvider = Me.oldProvider
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

        Private Sub radVirtualGrid1_CellFormatting(sender As Object, e As VirtualGridCellElementEventArgs) Handles radVirtualGrid1.CellFormatting
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        End Sub

		#End Region

		#Region "OleDb CRUD"

        Private Sub radVirtualGrid1_FilterChanged(sender As Object, e As Telerik.WinControls.UI.VirtualGridEventArgs) Handles radVirtualGrid1.FilterChanged
            Throw New System.NotImplementedException()
        End Sub

        Private Sub radVirtualGrid1_SortChanged(sender As Object, e As Telerik.WinControls.UI.VirtualGridEventArgs) Handles radVirtualGrid1.SortChanged
            Throw New System.NotImplementedException()
        End Sub

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
					Dim customer As New Product(Convert.ToString(reader(0)), Convert.ToString(reader(1)), Convert.ToString(reader(2)), Convert.ToString(reader(3)), Convert.ToString(reader(4)))
					data.Add(customer)
				End While

				command.Connection.Close()
			End Using

			Me.radVirtualGrid1.RowCount = data.Count
		End Sub

		#End Region
    End Class
End Namespace