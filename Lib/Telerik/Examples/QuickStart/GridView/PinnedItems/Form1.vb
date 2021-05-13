Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.GridView.PinnedItems
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Constructor"

		Public Sub New()
			InitializeComponent()

			Me.SelectedControl = Me.radGridView1
		End Sub

		#End Region

		#Region "Events"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.BindGrid()
			Me.BindColumnsCombo()
			Me.BindSystemRowsPositionCombo()
			Me.BindRowsPositionCombo()
			Me.BindSystemRowsCombo()
		End Sub

		Private Sub radComboBoxColumns_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim dataColumn As GridViewDataColumn = Nothing

			Dim radComboBoxItem As RadListDataItem = TryCast(Me.radComboBoxColumns.SelectedItem, RadListDataItem)

			If radComboBoxItem.Value IsNot Nothing Then
				dataColumn = TryCast(radComboBoxItem.Value, GridViewDataColumn)
			End If

			If dataColumn IsNot Nothing Then
				Select Case dataColumn.PinPosition
					Case PinnedColumnPosition.None
						Me.radRadioButtonColumnPinnedNone.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
					Case PinnedColumnPosition.Left
						Me.radRadioButtonColumnPinnedLeft.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
					Case PinnedColumnPosition.Right
						Me.radRadioButtonColumnPinnedRight.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
				End Select
			End If
		End Sub

		Private Sub radRadioButtonColumnPinnedNone_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.SetColumnPinPosition(PinnedColumnPosition.None)
		End Sub

		Private Sub radRadioButtonColumnPinnedLeft_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.SetColumnPinPosition(PinnedColumnPosition.Left)
		End Sub

		Private Sub radRadioButtonColumnPinnedRight_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			Me.SetColumnPinPosition(PinnedColumnPosition.Right)
		End Sub

		Private Sub radComboBoxSystemRows_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim radComboBoxItem As RadListDataItem = TryCast(Me.radComboBoxSystemRows.SelectedItem, RadListDataItem)

			If radComboBoxItem Is Nothing Then
				Return
			End If

			Dim systemRow As GridViewSystemRowInfo = TryCast(radComboBoxItem.Value, GridViewSystemRowInfo)

			If systemRow IsNot Nothing Then
				Me.radComboBoxRowPinPosition.SelectedValue = systemRow.PinPosition
				Me.radComboBoxSystemRowPosition.SelectedValue = systemRow.RowPosition
			End If
		End Sub

		Private Sub radComboBoxRowPinPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim radComboBoxRowPinPositionItem As RadListDataItem = TryCast(Me.radComboBoxRowPinPosition.SelectedItem, RadListDataItem)

			If radComboBoxRowPinPositionItem Is Nothing Then
				Return
			End If

			Dim rowPosition As PinnedRowPosition = CType(radComboBoxRowPinPositionItem.Value, PinnedRowPosition)

			Dim radComboBoxItem As RadListDataItem = TryCast(Me.radComboBoxSystemRows.SelectedItem, RadListDataItem)

			If radComboBoxItem Is Nothing Then
				Return
			End If

			Dim systemRow As GridViewSystemRowInfo = TryCast(radComboBoxItem.Value, GridViewSystemRowInfo)

			If systemRow IsNot Nothing Then
				systemRow.PinPosition = rowPosition

				Dim isNone As Boolean = rowPosition = PinnedRowPosition.None

				Me.radLabelSystemRowPosition.Enabled = isNone
				Me.radComboBoxSystemRowPosition.Enabled = isNone
			End If
		End Sub

		Private Sub radComboBoxSystemRowPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Dim radComboBoxSystemRowPositionItem As RadListDataItem = TryCast(Me.radComboBoxSystemRowPosition.SelectedItem, RadListDataItem)

			If radComboBoxSystemRowPositionItem Is Nothing Then
				Return
			End If

			Dim sysRowPosition As SystemRowPosition = CType(radComboBoxSystemRowPositionItem.Value, SystemRowPosition)

			Dim radComboBoxItem As RadListDataItem = TryCast(Me.radComboBoxSystemRows.SelectedItem, RadListDataItem)

			If radComboBoxItem Is Nothing Then
				Return
			End If

			Dim systemRow As GridViewSystemRowInfo = TryCast(radComboBoxItem.Value, GridViewSystemRowInfo)

			If systemRow IsNot Nothing Then
				systemRow.RowPosition = sysRowPosition
			End If
		End Sub

		#End Region

		#Region "Methods"

		Private Sub BindGrid()
			Me.aggregatesSampleTableTableAdapter.Fill(nwindRadGridView.EmployeeOrders)
			Me.radGridView1.DataSource = Me.aggregatesSampleTableBindingSource

			Me.radGridView1.Columns("UnitPrice").FormatString = "${0:F2}"
			Me.radGridView1.Columns("ShipName").PinPosition = PinnedColumnPosition.Left
			Me.radGridView1.Columns("Quantity").PinPosition = PinnedColumnPosition.Right

			For Each column As GridViewColumn In Me.radGridView1.Columns
				column.Width = 120
			Next column
		End Sub

		Private Sub BindSystemRowsPositionCombo()
			Me.radComboBoxSystemRowPosition.Items.Add(New RadListDataItem("Top", SystemRowPosition.Top))
			Me.radComboBoxSystemRowPosition.Items.Add(New RadListDataItem("Bottom", SystemRowPosition.Bottom))
		End Sub

		Private Sub BindRowsPositionCombo()
			Me.radComboBoxRowPinPosition.Items.Add(New RadListDataItem("None", PinnedRowPosition.None))
			Me.radComboBoxRowPinPosition.Items.Add(New RadListDataItem("Top", PinnedRowPosition.Top))
			Me.radComboBoxRowPinPosition.Items.Add(New RadListDataItem("Bottom", PinnedRowPosition.Bottom))
		End Sub

		Private Sub BindSystemRowsCombo()
			Me.radComboBoxSystemRows.Items.Add(New RadListDataItem("Table Header", Me.radGridView1.MasterView.TableHeaderRow))
			Me.radComboBoxSystemRows.Items.Add(New RadListDataItem("Add new row", Me.radGridView1.MasterView.TableAddNewRow))

			Me.radComboBoxSystemRows.SelectedValue = Me.radGridView1.MasterView.SystemRows(0)
		End Sub

		Private Sub BindColumnsCombo()
			For Each dataColumn As GridViewDataColumn In Me.radGridView1.Columns
				Me.radComboBoxColumns.Items.Add(New RadListDataItem(dataColumn.Name, dataColumn))
			Next dataColumn

			Me.radComboBoxColumns.SelectedValue = Me.radGridView1.Columns("ShipName")
		End Sub

		Private Sub SetColumnPinPosition(ByVal position As PinnedColumnPosition)
			Dim dataColumn As GridViewDataColumn = Nothing

			Dim radComboBoxItem As RadListDataItem = TryCast(Me.radComboBoxColumns.SelectedItem, RadListDataItem)

			If radComboBoxItem.Value IsNot Nothing Then
				dataColumn = TryCast(radComboBoxItem.Value, GridViewDataColumn)
			End If

			If dataColumn IsNot Nothing Then
				dataColumn.PinPosition = position
			End If
		End Sub

		#End Region

		Protected Overrides Sub WireEvents()
			AddHandler radRadioButtonColumnPinnedRight.ToggleStateChanged, AddressOf radRadioButtonColumnPinnedRight_ToggleStateChanged
			AddHandler radRadioButtonColumnPinnedLeft.ToggleStateChanged, AddressOf radRadioButtonColumnPinnedLeft_ToggleStateChanged
			AddHandler radRadioButtonColumnPinnedNone.ToggleStateChanged, AddressOf radRadioButtonColumnPinnedNone_ToggleStateChanged
			AddHandler radComboBoxColumns.SelectedIndexChanged, AddressOf radComboBoxColumns_SelectedIndexChanged
			AddHandler radComboBoxSystemRows.SelectedIndexChanged, AddressOf radComboBoxSystemRows_SelectedIndexChanged
			AddHandler radComboBoxRowPinPosition.SelectedIndexChanged, AddressOf radComboBoxRowPinPosition_SelectedIndexChanged
			AddHandler radComboBoxSystemRowPosition.SelectedIndexChanged, AddressOf radComboBoxSystemRowPosition_SelectedIndexChanged
		End Sub
	End Class
End Namespace
