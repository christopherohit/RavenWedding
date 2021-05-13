Imports Telerik.Examples.WinControls.DataSources
Imports Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI.Data
Imports Telerik.WinControls.UI
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.GridView.ManipulateData.Paging
	Public Partial Class Form1
        Inherits ExamplesForm

		Public Sub New()
			InitializeComponent()
			Me.SelectedControl = Me.radGridView1
		End Sub

		Protected Overrides Sub OnLoad(e As EventArgs)
			MyBase.OnLoad(e)

			Me.PopulateRadGridView()
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.radSpinEditorPageSize.ValueChanged, AddressOf radSpinEditorPageSize_ValueChanged
			AddHandler Me.radDropDownListPagingGroupingPriority.SelectedIndexChanged, AddressOf radDropDownListPagingGroupingPriority_SelectedIndexChanged
			AddHandler Me.radSpinEditorPageButtons.ValueChanged, AddressOf radSpinEditorPageButtons_ValueChanged

			AddHandler Me.radCheckBoxButtonsStrip.ToggleStateChanged, AddressOf radCheckBoxButtonsStrip_ToggleStateChanged
			AddHandler Me.radCheckBoxTextBoxStrip.ToggleStateChanged, AddressOf radCheckBoxTextBoxStrip_ToggleStateChanged
			AddHandler Me.radCheckBoxFirstButton.ToggleStateChanged, AddressOf Me.radCheckBoxFirstButton_ToggleStateChanged
			AddHandler Me.radCheckBoxPreviousButton.ToggleStateChanged, AddressOf Me.radCheckBoxPreviousButton_ToggleStateChanged
			AddHandler Me.radCheckBoxFastBackButton.ToggleStateChanged, AddressOf Me.radCheckBoxFastBackButton_ToggleStateChanged
			AddHandler Me.radCheckBoxNumericalButtons.ToggleStateChanged, AddressOf Me.radCheckBoxNumericalButtons_ToggleStateChanged
			AddHandler Me.radCheckBoxFastForwardButton.ToggleStateChanged, AddressOf Me.radCheckBoxFastForwardButton_ToggleStateChanged
			AddHandler Me.radCheckBoxNextButton.ToggleStateChanged, AddressOf Me.radCheckBoxNextButton_ToggleStateChanged
			AddHandler Me.radCheckBoxLastButton.ToggleStateChanged, AddressOf Me.radCheckBoxLastButton_ToggleStateChanged
			AddHandler Me.radCheckBoxButtonsStrip.ToggleStateChanged, AddressOf Me.radCheckBoxFirstButton_ToggleStateChanged
			AddHandler Me.radCheckBoxTextBoxStrip.ToggleStateChanged, AddressOf Me.radCheckBoxPreviousButton_ToggleStateChanged
		End Sub

		Private Sub PopulateRadGridView()
			Dim [set] As New NorthwindDataSet()
			Dim adapter As New OrdersTableAdapter()
			adapter.Fill([set].Orders)

			radGridView1.DataSource = [set].Orders

			Me.radGridView1.Columns("EmployeeID").IsVisible = False
			Me.radGridView1.Columns("RequiredDate").IsVisible = False
			Me.radGridView1.Columns("ShipVia").IsVisible = False
			Me.radGridView1.Columns("ShipRegion").IsVisible = False
			DirectCast(Me.radGridView1.Columns("OrderDate"), GridViewDateTimeColumn).FormatString = "{0:dd MMMM yyyy}"
			DirectCast(Me.radGridView1.Columns("ShippedDate"), GridViewDateTimeColumn).FormatString = "{0:dd MMMM yyyy}"

			Me.radGridView1.BestFitColumns(BestFitColumnMode.AllCells)
            Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            Me.radGridView1.AutoExpandGroups = True
            Me.radGridView1.SortDescriptors.Add("ShipCountry", System.ComponentModel.ListSortDirection.Ascending)
            Me.radGridView1.GroupDescriptors.Add("ShipCountry", System.ComponentModel.ListSortDirection.Ascending)
            Me.radGridView1.MasterTemplate.DataView.PagingBeforeGrouping = True
		End Sub

		Private Sub radSpinEditorPageSize_ValueChanged(sender As Object, e As EventArgs)
			Me.radGridView1.PageSize = CInt(Me.radSpinEditorPageSize.Value)
		End Sub

		Private Sub radDropDownListPagingGroupingPriority_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radGridView1.MasterTemplate.DataView.PagingBeforeGrouping = (e.Position = 0)
		End Sub

		Private Sub radSpinEditorPageButtons_ValueChanged(sender As Object, e As EventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.NumericButtonsCount = CInt(Me.radSpinEditorPageButtons.Value)
		End Sub

		Private Sub radCheckBoxButtonsStrip_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowButtonsStripElement = Me.radCheckBoxButtonsStrip.Checked
		End Sub

		Private Sub radCheckBoxTextBoxStrip_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowTextBoxStripElement = Me.radCheckBoxTextBoxStrip.Checked
		End Sub

		Private Sub radCheckBoxFirstButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowFirstButton = Me.radCheckBoxFirstButton.Checked
		End Sub

		Private Sub radCheckBoxPreviousButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowPreviousButton = Me.radCheckBoxPreviousButton.Checked
		End Sub

		Private Sub radCheckBoxFastBackButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowFastBackButton = Me.radCheckBoxFastBackButton.Checked
		End Sub

		Private Sub radCheckBoxNumericalButtons_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowNumericalButtons = Me.radCheckBoxNumericalButtons.Checked
		End Sub

		Private Sub radCheckBoxFastForwardButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowFastForwardButton = Me.radCheckBoxFastForwardButton.Checked
		End Sub

		Private Sub radCheckBoxNextButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowNextButton = Me.radCheckBoxNextButton.Checked
		End Sub

		Private Sub radCheckBoxLastButton_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
			Me.radGridView1.GridViewElement.PagingPanelElement.ShowLastButton = Me.radCheckBoxLastButton.Checked
		End Sub
	End Class
End Namespace
