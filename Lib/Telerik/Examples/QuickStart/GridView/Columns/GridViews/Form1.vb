Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.GridView.Columns.GridViews
	Partial Public Class Form1
		Inherits ExamplesForm
		#Region "Fields"

		Private tableView As TableViewDefinition
		Private columnGroupsView As ColumnGroupsViewDefinition
		Private htmlView As HtmlViewDefinition

		#End Region

		Public Sub New()
			InitializeComponent()
			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.ShowFilteringRow = False
			Me.radGridView1.ShowHeaderCellButtons = True
			Me.WireEvents()
		End Sub

        Private Sub InitializeGrid()
            Me.columnGroupsView = New ColumnGroupsViewDefinition()
            Me.columnGroupsView.ColumnGroups.Add(New GridViewColumnGroup("General"))
            Me.columnGroupsView.ColumnGroups.Add(New GridViewColumnGroup("Details"))
            Me.columnGroupsView.ColumnGroups(1).Groups.Add(New GridViewColumnGroup("Address"))
            Me.columnGroupsView.ColumnGroups(1).Groups.Add(New GridViewColumnGroup())
            Dim groupRow As GridViewColumnGroupRow = New GridViewColumnGroupRow()
            groupRow.MinHeight = 50
            Me.columnGroupsView.ColumnGroups(0).Rows.Add(groupRow)
            groupRow = New GridViewColumnGroupRow()
            groupRow.MinHeight = 50
            Me.columnGroupsView.ColumnGroups(0).Rows.Add(groupRow)
            Me.columnGroupsView.ColumnGroups(0).Rows(0).ColumnNames.Add("CustomerID")
            Me.columnGroupsView.ColumnGroups(0).Rows(0).ColumnNames.Add("ContactName")
            Me.columnGroupsView.ColumnGroups(0).Rows(1).ColumnNames.Add("CompanyName")
            groupRow = New GridViewColumnGroupRow()
            groupRow.MinHeight = 50
            Me.columnGroupsView.ColumnGroups(1).Groups(0).Rows.Add(groupRow)
            Me.columnGroupsView.ColumnGroups(1).Groups(0).Rows(0).ColumnNames.Add("City")
            Me.columnGroupsView.ColumnGroups(1).Groups(0).Rows(0).ColumnNames.Add("Country")
            groupRow = New GridViewColumnGroupRow()
            groupRow.MinHeight = 50
            Me.columnGroupsView.ColumnGroups(1).Groups(1).Rows.Add(groupRow)
            Me.columnGroupsView.ColumnGroups(1).Groups(1).Rows(0).ColumnNames.Add("Phone")
            Me.htmlView = New HtmlViewDefinition()
            Dim rowDef As RowDefinition = New RowDefinition()
            rowDef.Height = 50
            Me.htmlView.RowTemplate.Rows.Add(rowDef)
            Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("CustomerID"))
            Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("ContactName"))
            Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("City"))
            Me.htmlView.RowTemplate.Rows(0).Cells.Add(New CellDefinition("Country"))
            Me.htmlView.RowTemplate.Rows(0).Cells(2).RowSpan = 2
            Me.htmlView.RowTemplate.Rows(0).Cells(3).RowSpan = 2
            rowDef = New RowDefinition()
            rowDef.Height = 50
            Me.htmlView.RowTemplate.Rows.Add(rowDef)
            Me.htmlView.RowTemplate.Rows(1).Cells.Add(New CellDefinition("CompanyName"))
            Me.htmlView.RowTemplate.Rows(1).Cells(0).ColSpan = 2
        End Sub

		#Region "Event Handlers"

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			Me.customersTableAdapter.Fill(Me.northwindDataSet.Customers)

			' table view
			Me.tableView = CType(Me.radGridView1.ViewDefinition, TableViewDefinition)
			InitializeGrid()
			Me.radRadioHTML.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radGridView1.ViewDefinition = htmlView
		End Sub

		Private Sub radSpinEditor1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.CellSpacing = CInt(Fix(Me.radSpinEditor1.Value))
		End Sub

		Private Sub radSpinEditor2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.radGridView1.TableElement.RowSpacing = CInt(Fix(Me.radSpinEditor2.Value))
		End Sub

		Private Sub radRadioTable_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioGCView.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.ViewDefinition = columnGroupsView
				Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			End If

			If Me.radRadioHTML.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.ViewDefinition = htmlView
				Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
			End If

			If Me.radRadioTable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.ViewDefinition = tableView
				Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			End If

			Me.radGridView1.TableElement.CellSpacing = CInt(Fix(radSpinEditor1.Value))
			Me.radGridView1.TableElement.RowSpacing = CInt(Fix(radSpinEditor2.Value))
		End Sub

		#End Region ' Event Handlers

		Protected Overrides Sub WireEvents()
			AddHandler radSpinEditor1.ValueChanged, AddressOf radSpinEditor1_ValueChanged
			AddHandler radSpinEditor2.ValueChanged, AddressOf radSpinEditor2_ValueChanged
			AddHandler radRadioGCView.ToggleStateChanged, AddressOf radRadioTable_ToggleStateChanged
			AddHandler radRadioHTML.ToggleStateChanged, AddressOf radRadioTable_ToggleStateChanged
			AddHandler radRadioTable.ToggleStateChanged, AddressOf radRadioTable_ToggleStateChanged
		End Sub
	End Class
End Namespace
