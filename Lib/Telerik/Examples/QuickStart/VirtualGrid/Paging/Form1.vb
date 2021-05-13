Imports Microsoft.VisualBasic
Imports System
Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.VirtualGrid.Paging
	Public Partial Class Form1
		Inherits ExamplesForm
        Private [set] As NorthwindDataSet = New NorthwindDataSet()
		Private visibleColumns As String()
		Private columnHeaderss As String()

		Public Sub New()
			InitializeComponent()

			Me.radVirtualGrid1.TableElement.ColumnWidth = 170

			Dim adapter As OrdersTableAdapter = New OrdersTableAdapter()
			adapter.Fill([set].Orders)
			Me.visibleColumns = New String() { "OrderDate", "RequiredDate", "ShippedDate", "Freight", "ShipName", "ShipCity", "ShipCountry" }
			Me.columnHeaderss = New String() { "Order Date", "Required Date", "Shipped Date", "Freight", "Ship Name", "City", "Country" }

			Me.radVirtualGrid1.ColumnCount = Me.visibleColumns.Length
			Me.radVirtualGrid1.RowCount = [set].Orders.Rows.Count
			Me.radVirtualGrid1.AllowFiltering = False
			Me.radVirtualGrid1.AllowAddNewRow = False
			Me.radVirtualGrid1.EnablePaging = True
			Me.radVirtualGrid1.PageSize = 30

			AddHandler Me.radVirtualGrid1.CellFormatting, AddressOf radVirtualGrid1_CellFormatting
			AddHandler Me.radVirtualGrid1.CellValueNeeded, AddressOf radVirtualGrid1_CellValueNeeded
		End Sub

		Private Sub radVirtualGrid1_CellFormatting(ByVal sender As Object, ByVal e As VirtualGridCellElementEventArgs)
			If e.CellElement.RowIndex < 0 OrElse e.CellElement.ColumnIndex < 0 Then
				Return
			End If

			Dim columnName As String = Me.visibleColumns(e.CellElement.ColumnIndex)

			Select Case columnName
				Case "OrderDate", "ShippedDate", "RequiredDate"
					If Not e.CellElement.Value Is Nothing AndAlso Not e.CellElement.Value Is DBNull.Value Then
						e.CellElement.Text = (CDate(e.CellElement.Value)).ToLongDateString()
					End If

					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
				Case "Freight"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
				Case "ShipName", "ShipCity", "ShipCountry"
					e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			End Select
		End Sub

		Private Sub radVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs)
			If e.ColumnIndex < 0 Then
				Return
			End If

			If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
				e.Value = Me.columnHeaderss(e.ColumnIndex)
			End If

			If e.RowIndex < 0 Then
				Return
			End If

			If e.RowIndex < Me.radVirtualGrid1.RowCount Then
				e.Value = Me.set.Orders.Rows(e.RowIndex)(Me.visibleColumns(e.ColumnIndex))
			End If
		End Sub

		#Region "Settings event handlers"

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radSpinEditorPageSize.ValueChanged, AddressOf radSpinEditorPageSize_ValueChanged
			AddHandler Me.radSpinEditorPageButtons.ValueChanged, AddressOf radSpinEditorPageButtons_ValueChanged

			AddHandler Me.radCheckBoxButtonsStrip.ToggleStateChanged, AddressOf radCheckBoxButtonsStrip_ToggleStateChanged
			AddHandler Me.radCheckBoxTextBoxStrip.ToggleStateChanged, AddressOf radCheckBoxTextBoxStrip_ToggleStateChanged
			AddHandler Me.radCheckBoxFirstButton.ToggleStateChanged, AddressOf radCheckBoxFirstButton_ToggleStateChanged
			AddHandler Me.radCheckBoxPreviousButton.ToggleStateChanged, AddressOf radCheckBoxPreviousButton_ToggleStateChanged
			AddHandler Me.radCheckBoxFastBackButton.ToggleStateChanged, AddressOf radCheckBoxFastBackButton_ToggleStateChanged
			AddHandler Me.radCheckBoxNumericalButtons.ToggleStateChanged, AddressOf radCheckBoxNumericalButtons_ToggleStateChanged
			AddHandler Me.radCheckBoxFastForwardButton.ToggleStateChanged, AddressOf radCheckBoxFastForwardButton_ToggleStateChanged
			AddHandler Me.radCheckBoxNextButton.ToggleStateChanged, AddressOf radCheckBoxNextButton_ToggleStateChanged
			AddHandler Me.radCheckBoxLastButton.ToggleStateChanged, AddressOf radCheckBoxLastButton_ToggleStateChanged
			AddHandler Me.radCheckBoxButtonsStrip.ToggleStateChanged, AddressOf radCheckBoxFirstButton_ToggleStateChanged
			AddHandler Me.radCheckBoxTextBoxStrip.ToggleStateChanged, AddressOf radCheckBoxPreviousButton_ToggleStateChanged
		End Sub

		Private Sub radSpinEditorPageSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radVirtualGrid1.PageSize = CInt(Fix(Me.radSpinEditorPageSize.Value))
		End Sub

		Private Sub radSpinEditorPageButtons_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.NumericButtonsCount = CInt(Fix(Me.radSpinEditorPageButtons.Value))
		End Sub

		Private Sub radCheckBoxButtonsStrip_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowButtonsStripElement = Me.radCheckBoxButtonsStrip.Checked
		End Sub

		Private Sub radCheckBoxTextBoxStrip_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowTextBoxStripElement = Me.radCheckBoxTextBoxStrip.Checked
		End Sub

		Private Sub radCheckBoxFirstButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowFirstButton = Me.radCheckBoxFirstButton.Checked
		End Sub

		Private Sub radCheckBoxPreviousButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowPreviousButton = Me.radCheckBoxPreviousButton.Checked
		End Sub

		Private Sub radCheckBoxFastBackButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowFastBackButton = Me.radCheckBoxFastBackButton.Checked
		End Sub

		Private Sub radCheckBoxNumericalButtons_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowNumericalButtons = Me.radCheckBoxNumericalButtons.Checked
		End Sub

		Private Sub radCheckBoxFastForwardButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowFastForwardButton = Me.radCheckBoxFastForwardButton.Checked
		End Sub

		Private Sub radCheckBoxNextButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowNextButton = Me.radCheckBoxNextButton.Checked
		End Sub

		Private Sub radCheckBoxLastButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radVirtualGrid1.VirtualGridElement.TableElement.PagingPanelElement.ShowLastButton = Me.radCheckBoxLastButton.Checked
		End Sub

		#End Region
	End Class
End Namespace
