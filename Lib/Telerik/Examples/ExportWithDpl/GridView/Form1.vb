Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports Telerik.Windows.Documents.Spreadsheet.Model

Namespace ExportWithDpl.GridView
	Public Partial Class Form1
		Inherits RadForm
		Private spreadExporter As GridViewSpreadExport
		Private pdfExporter As GridViewPdfExport

		Public Sub New()
			InitializeComponent()
			Me.WireEvents()

			If Program.themeName <> "" Then 'set the example theme to the same theme QSF uses
				ThemeResolutionService.ApplicationThemeName = Program.themeName
			Else
				ThemeResolutionService.ApplicationThemeName = "TelerikMetro" 'set default theme
			End If
		End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            'TODO: This line of code loads data into the 'NwindDataSet.Orders' table. You can move, or remove it, as needed.
            Me.OrdersTableAdapter.Fill(Me.NwindDataSet.Orders)
            'TODO: This line of code loads data into the 'NwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            Me.Order_DetailsTableAdapter.Fill(Me.NwindDataSet.Order_Details)
            'TODO: This line of code loads data into the 'NwindDataSet.Customers' table. You can move, or remove it, as needed.
            Me.CustomersTableAdapter.Fill(Me.NwindDataSet.Customers)

            Me.SetupExample()

            Me.spreadExporter = New GridViewSpreadExport(Me.radGridView1)
            AddHandler Me.spreadExporter.CellFormatting, AddressOf spreadExporter_CellFormatting

            Me.pdfExporter = New GridViewPdfExport(Me.radGridView1)
            AddHandler Me.pdfExporter.CellFormatting, AddressOf pdfExporter_CellFormatting

            Me.SetupInitialSettings()
        End Sub

		Private Sub SetupInitialSettings()
			Me.exportVisualSettingsCheckBox.ToggleState = ToggleState.On
			Me.exportHierarchyCheckBox.ToggleState = ToggleState.On
			Me.xlsxRadioButton.ToggleState = ToggleState.On
			Me.hiddenColumnDoNotExportRadioButton.ToggleState = ToggleState.On
			Me.hiddenRowDoNotExportRadioButton.ToggleState = ToggleState.On
			Me.summariesExportAllRadioButton.ToggleState = ToggleState.On
			Me.pagingCurrentPageOnlyRadioButton.ToggleState = ToggleState.On
			Me.hideColumnsCheckBox.ToggleState = ToggleState.On

			Me.radCheckBoxExportVisualSettingsPdfExport.ToggleState = ToggleState.On
			Me.radCheckBoxExportHierarchyPdfExport.ToggleState = ToggleState.On
			Me.radRadioButtonHiddenColumnDoNotExportPdfExport.ToggleState = ToggleState.On
			Me.radRadioButtonHiddenRowDoNotExportPdfExport.ToggleState = ToggleState.On
			Me.radRadioButtonSummariesExportAllPdfExport.ToggleState = ToggleState.On
			Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.ToggleState = ToggleState.On
			Me.radCheckBoxHideSomeColumnsPdfExport.ToggleState = ToggleState.On
		End Sub

        Private Sub SetupExample()
            Me.radGridView1.DataSource = NwindDataSet
            Me.radGridView1.DataMember = "Customers"
            Me.radGridView1.AutoGenerateHierarchy = True
            Me.SetupMasterForAutoGenerateHierarchy()

            Me.radGridView1.GroupDescriptors.Add(New GroupDescriptor(New SortDescriptor("City", ListSortDirection.Ascending)))
            Me.radGridView1.Groups(0).Expand()

            Me.radGridView1.Groups(0).GetItems()(0).IsExpanded = True
            Me.radGridView1.Groups(0).GetItems()(0).ChildRows(0).IsExpanded = True
        End Sub

		Private Sub SetupMasterForAutoGenerateHierarchy()
			Me.radGridView1.MasterTemplate.Columns("CompanyName").HeaderText = "Company Name"
			Me.radGridView1.MasterTemplate.Columns("ContactName").HeaderText = "Contact Name"

			Me.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Dim template As GridViewTemplate = Me.radGridView1.MasterTemplate.Templates(0)
			template.Columns("OrderID").HeaderText = "Order ID"
			template.Columns("ShipAddress").HeaderText = "Ship Address"
			template.Columns("OrderDate").HeaderText = "Order Date"
			template.Columns("OrderDate").TextAlignment = ContentAlignment.MiddleRight
			template.Columns("OrderDate").FormatString = "{0: ddd, MM/dd}"
			template.Columns("OrderDate").ExcelExportFormatString = "ddd, MM/dd"
			template.Columns("OrderDate").ExcelExportType = DisplayFormatType.Custom
			template.Columns("CustomerID").IsVisible = False
			template.Columns("EmployeeID").IsVisible = False
			template.Columns("RequiredDate").IsVisible = False
			template.Columns("ShippedDate").IsVisible = False
			template.Columns("ShipVia").IsVisible = False
			template.Columns("ShipName").IsVisible = False
			template.Columns("ShipCity").IsVisible = False
			template.Columns("ShipRegion").IsVisible = False
			template.Columns("ShipPostalCode").IsVisible = False
			template.Columns("ShipCity").IsVisible = False
			template.Columns("ShipName").IsVisible = False
			template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.MasterTemplate.Templates(0).Templates.RemoveAt(0)
		End Sub

		Private Sub WireEvents()
			AddHandler Me.Load, AddressOf Form1_Load

			' Spread Export
			AddHandler Me.hideColumnsCheckBox.ToggleStateChanged, AddressOf hideColumnsCheckBox_ToggleStateChanged
			AddHandler Me.hideFirstRowCheckBox.ToggleStateChanged, AddressOf hideFirstRowCheckBox_ToggleStateChanged
			AddHandler Me.showSummaryCheckBox.ToggleStateChanged, AddressOf showSummaryCheckBox_ToggleStateChanged
			AddHandler Me.enablePagingCheckBox.ToggleStateChanged, AddressOf enablePagingCheckBox_ToggleStateChanged
			AddHandler Me.createHtmlViewDefinitionCheckBox.ToggleStateChanged, AddressOf createHtmlViewDefinitionCheckBox_ToggleStateChanged
			AddHandler Me.spreadExportButton.Click, AddressOf spreadExportButton_Click
			AddHandler Me.exportVisualSettingsCheckBox.ToggleStateChanged, AddressOf exportVisualSettingsCheckBox_ToggleStateChanged
			AddHandler Me.exportHierarchyCheckBox.ToggleStateChanged, AddressOf exportHierarchyCheckBox_ToggleStateChanged
			AddHandler Me.exportChildRowsGroupedCheckBox.ToggleStateChanged, AddressOf exportChildRowsGroupedCheckBox_ToggleStateChanged
			AddHandler Me.hiddenColumnExportAlwaysRadioButton.ToggleStateChanged, AddressOf hiddenColumnRadioButton_ToggleStateChanged
			AddHandler Me.hiddenColumnDoNotExportRadioButton.ToggleStateChanged, AddressOf hiddenColumnRadioButton_ToggleStateChanged
			AddHandler Me.hiddenColumnExportAsHiddenRadioButton.ToggleStateChanged, AddressOf hiddenColumnRadioButton_ToggleStateChanged
			AddHandler Me.hiddenRowExportAlwaysRadioButton.ToggleStateChanged, AddressOf hiddenRowRadioButton_ToggleStateChanged
			AddHandler Me.hiddenRowDoNotExportRadioButton.ToggleStateChanged, AddressOf hiddenRowRadioButton_ToggleStateChanged
			AddHandler Me.hiddenRowExportAsHiddenRadioButton.ToggleStateChanged, AddressOf hiddenRowRadioButton_ToggleStateChanged
			AddHandler Me.summariesExportAllRadioButton.ToggleStateChanged, AddressOf summariesRadioButton_ToggleStateChanged
			AddHandler Me.summariesExportOnlyTopRadioButton.ToggleStateChanged, AddressOf summariesRadioButton_ToggleStateChanged
			AddHandler Me.summariesExportOnlyBottomRadioButton.ToggleStateChanged, AddressOf summariesRadioButton_ToggleStateChanged
			AddHandler Me.summariesDoNotExportRadioButton.ToggleStateChanged, AddressOf summariesRadioButton_ToggleStateChanged
			AddHandler Me.pagingCurrentPageOnlyRadioButton.ToggleStateChanged, AddressOf pagingRadioButton_ToggleStateChanged
			AddHandler Me.pagingAllPagesRadioButton.ToggleStateChanged, AddressOf pagingRadioButton_ToggleStateChanged
			AddHandler Me.pinSomeRowsAndColumnsCheckBox.ToggleStateChanged, AddressOf pinSomeRowsAndColumnsCheckBox_ToggleStateChanged
			AddHandler Me.freezeHeaderRowCheckBox.ToggleStateChanged, AddressOf freezeHeaderRowCheckBox_ToggleStateChanged
			AddHandler Me.freezePinnedRowsCheckBox.ToggleStateChanged, AddressOf freezePinnedRowsCheckBox_ToggleStateChanged
			AddHandler Me.freezePinnedColumnsCheckBox.ToggleStateChanged, AddressOf freezePinnedColumnsCheckBox_ToggleStateChanged
			AddHandler Me.exportViewDefinitionCheckBox.ToggleStateChanged, AddressOf exportViewDefinitionCheckBox_ToggleStateChanged

			' PDF Export
			AddHandler Me.radCheckBoxHideSomeColumnsPdfExport.ToggleStateChanged, AddressOf hideColumnsCheckBox_ToggleStateChanged
			AddHandler Me.radCheckBoxHideFirstRowPdfExport.ToggleStateChanged, AddressOf hideFirstRowCheckBox_ToggleStateChanged
			AddHandler Me.radCheckBoxShowSummaryPdfExport.ToggleStateChanged, AddressOf showSummaryCheckBox_ToggleStateChanged
			AddHandler Me.radCheckBoxEnablePagingPdfExport.ToggleStateChanged, AddressOf enablePagingCheckBox_ToggleStateChanged
			AddHandler Me.radCheckBoxCreateViewDefinitionPdfExport.ToggleStateChanged, AddressOf createHtmlViewDefinitionCheckBox_ToggleStateChanged
			AddHandler Me.radButtonPdfExport.Click, AddressOf radButtonPdfExport_Click
			AddHandler Me.radCheckBoxExportVisualSettingsPdfExport.ToggleStateChanged, AddressOf radCheckBoxExportVisualSettingsPdfExport_ToggleStateChanged
			AddHandler Me.radCheckBoxExportHierarchyPdfExport.ToggleStateChanged, AddressOf radCheckBoxExportHierarchyPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.ToggleStateChanged, AddressOf radRadioButtonHiddenColumnPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonHiddenColumnDoNotExportPdfExport.ToggleStateChanged, AddressOf radRadioButtonHiddenColumnPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.ToggleStateChanged, AddressOf radRadioButtonHiddenColumnPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonHiddenRowExportAlwaysPdfExport.ToggleStateChanged, AddressOf radRadioButtonHiddenRowPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonHiddenRowDoNotExportPdfExport.ToggleStateChanged, AddressOf radRadioButtonHiddenRowPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.ToggleStateChanged, AddressOf radRadioButtonHiddenRowPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonSummariesExportAllPdfExport.ToggleStateChanged, AddressOf radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonSummariesExportOnlyTopPdfExport.ToggleStateChanged, AddressOf radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonSummariesExportOnlyBottomPdfExport.ToggleStateChanged, AddressOf radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonSummariesDoNotExportPdfExport.ToggleStateChanged, AddressOf radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.ToggleStateChanged, AddressOf radRadioButtonPagingOptionPdfExport_ToggleStateChanged
			AddHandler Me.radRadioButtonPagingOptionAllPAgesPdfExport.ToggleStateChanged, AddressOf radRadioButtonPagingOptionPdfExport_ToggleStateChanged
			AddHandler Me.radCheckBoxExportViewDefinitionPdfExport.ToggleStateChanged, AddressOf radCheckBoxExportViewDefinitionPdfExport_ToggleStateChanged
		End Sub

		#Region "Event handlers"

		Private Sub hideColumnsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radGridView1.MasterTemplate.Columns("CustomerID").IsVisible = args.ToggleState = ToggleState.Off
			Me.radGridView1.MasterTemplate.Columns("ContactTitle").IsVisible = args.ToggleState = ToggleState.Off
			Me.radGridView1.MasterTemplate.Columns("Region").IsVisible = args.ToggleState = ToggleState.Off
			Me.radGridView1.MasterTemplate.Columns("PostalCode").IsVisible = args.ToggleState = ToggleState.Off
			Me.radGridView1.MasterTemplate.Columns("Country").IsVisible = args.ToggleState = ToggleState.Off
			Me.radGridView1.MasterTemplate.Columns("Fax").IsVisible = args.ToggleState = ToggleState.Off

			If Me.hideColumnsCheckBox.ToggleState <> args.ToggleState Then
				Me.hideColumnsCheckBox.ToggleState = args.ToggleState
			End If

			If Me.radCheckBoxHideSomeColumnsPdfExport.ToggleState <> args.ToggleState Then
				Me.radCheckBoxHideSomeColumnsPdfExport.ToggleState = args.ToggleState
			End If
		End Sub

		Private Sub hideFirstRowCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radGridView1.ChildRows(0).IsVisible = args.ToggleState = ToggleState.Off
			If Me.hideFirstRowCheckBox.ToggleState <> args.ToggleState Then
				Me.hideFirstRowCheckBox.ToggleState = args.ToggleState
			End If

			If Me.radCheckBoxHideFirstRowPdfExport.ToggleState <> args.ToggleState Then
				Me.radCheckBoxHideFirstRowPdfExport.ToggleState = args.ToggleState
			End If
		End Sub

		Private Sub showSummaryCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Dim summaryItem As GridViewSummaryItem = New GridViewSummaryItem()
				summaryItem.Name = "CompanyName"
				summaryItem.Aggregate = GridAggregateFunction.Count

				Dim summaryRowTopItem As GridViewSummaryRowItem = New GridViewSummaryRowItem()
				summaryRowTopItem.Add(summaryItem)
				Me.radGridView1.SummaryRowsTop.Add(summaryRowTopItem)

				Dim summaryRowBottomItem As GridViewSummaryRowItem = New GridViewSummaryRowItem()
				summaryRowBottomItem.Add(summaryItem)
				Me.radGridView1.SummaryRowsBottom.Add(summaryRowBottomItem)
			Else
				Me.radGridView1.SummaryRowsBottom.Clear()
				Me.radGridView1.SummaryRowsTop.Clear()
			End If

            If Me.showSummaryCheckBox.ToggleState <> args.ToggleState Then
                RemoveHandler Me.showSummaryCheckBox.ToggleStateChanged, AddressOf showSummaryCheckBox_ToggleStateChanged
                Me.showSummaryCheckBox.ToggleState = args.ToggleState
                AddHandler Me.showSummaryCheckBox.ToggleStateChanged, AddressOf showSummaryCheckBox_ToggleStateChanged
            End If

            If Me.radCheckBoxShowSummaryPdfExport.ToggleState <> args.ToggleState Then
                RemoveHandler Me.radCheckBoxShowSummaryPdfExport.ToggleStateChanged, AddressOf showSummaryCheckBox_ToggleStateChanged
                Me.radCheckBoxShowSummaryPdfExport.ToggleState = args.ToggleState
                AddHandler Me.radCheckBoxShowSummaryPdfExport.ToggleStateChanged, AddressOf showSummaryCheckBox_ToggleStateChanged
            End If
		End Sub

		Private Sub enablePagingCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radGridView1.EnablePaging = args.ToggleState = ToggleState.On
			If Me.enablePagingCheckBox.ToggleState <> args.ToggleState Then
				Me.enablePagingCheckBox.ToggleState = args.ToggleState
			End If

			If Me.radCheckBoxEnablePagingPdfExport.ToggleState <> args.ToggleState Then
				Me.radCheckBoxEnablePagingPdfExport.ToggleState = args.ToggleState
			End If
		End Sub

		Private Sub createHtmlViewDefinitionCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Dim view As HtmlViewDefinition = New HtmlViewDefinition()
				view.RowTemplate.Rows.Add(New RowDefinition())
				view.RowTemplate.Rows.Add(New RowDefinition())
				view.RowTemplate.Rows.Add(New RowDefinition())
				view.RowTemplate.Rows(0).Cells.Add(New CellDefinition("PostalCode", 0, 1, 1))
				view.RowTemplate.Rows(0).Cells.Add(New CellDefinition("CompanyName", 0, 1, 3))
				view.RowTemplate.Rows(0).Cells.Add(New CellDefinition("ContactTitle", 0, 1, 1))
				view.RowTemplate.Rows(0).Cells.Add(New CellDefinition("Address", 0, 1, 1))
				view.RowTemplate.Rows(0).Cells.Add(New CellDefinition("CustomerID", 0, 1, 1))
				view.RowTemplate.Rows(1).Cells.Add(New CellDefinition("Country", 0, 1, 2))
				view.RowTemplate.Rows(1).Cells.Add(New CellDefinition("City", 0, 2, 1))
				view.RowTemplate.Rows(1).Cells.Add(New CellDefinition("Phone", 0, 1, 1))
				view.RowTemplate.Rows(2).Cells.Add(New CellDefinition("Fax", 0, 2, 1))
				view.RowTemplate.Rows(2).Cells.Add(New CellDefinition("ContactName", 0, 1, 1))
				Me.radGridView1.ViewDefinition = view

				Me.radGridView1.GroupDescriptors.Clear()
				Me.exportViewDefinitionCheckBox.ToggleState = ToggleState.On
				Me.radCheckBoxExportViewDefinitionPdfExport.ToggleState = ToggleState.On
				Me.exportHierarchyCheckBox.ToggleState = ToggleState.Off
				Me.radCheckBoxExportHierarchyPdfExport.ToggleState = ToggleState.Off
				Me.hideColumnsCheckBox.ToggleState = ToggleState.Off
				Me.radCheckBoxHideSomeColumnsPdfExport.ToggleState = ToggleState.Off
			Else
				Me.radGridView1.ViewDefinition = New TableViewDefinition()
				Me.exportViewDefinitionCheckBox.ToggleState = ToggleState.Off
				Me.radCheckBoxExportViewDefinitionPdfExport.ToggleState = ToggleState.Off
			End If
		End Sub

		#Region "SpreadExport"

		Private Sub spreadExportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As SaveFileDialog = New SaveFileDialog()
			dialog.FileName = "exportedFile"
			If xlsxRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.ExportFormat = SpreadExportFormat.Xlsx
				dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
			ElseIf csvRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.ExportFormat = SpreadExportFormat.Csv
				dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
			ElseIf pdfRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.ExportFormat = SpreadExportFormat.Pdf
				dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
			ElseIf txtRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.ExportFormat = SpreadExportFormat.Txt
				dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
			End If

			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim renderer As SpreadExportRenderer = New SpreadExportRenderer()
				AddHandler renderer.WorkbookCreated, AddressOf renderer_WorkbookCreated
				Me.spreadExporter.RunExport(dialog.FileName, renderer)
			End If
		End Sub

		Private Sub renderer_WorkbookCreated(ByVal sender As Object, ByVal e As WorkbookCreatedEventArgs)
			Dim worksheet As Worksheet = e.Workbook.ActiveWorksheet
			worksheet.Columns(worksheet.UsedCellRange).AutoFitWidth()
		End Sub

		Private Sub spreadExporter_CellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.Export.CellFormattingEventArgs)
			If Me.customizeVisualSettingsCheckBox.ToggleState <> ToggleState.On Then
				Return
			End If

			If e.GridRowInfoType Is GetType(GridViewTableHeaderRowInfo) Then
				e.CellStyleInfo.Underline = True

				If e.GridCellInfo.RowInfo.HierarchyLevel = 0 Then
					e.CellStyleInfo.BackColor = Color.DeepSkyBlue
				ElseIf e.GridCellInfo.RowInfo.HierarchyLevel = 1 Then
					e.CellStyleInfo.BackColor = Color.LightSkyBlue
				End If
			End If

			If e.GridRowInfoType Is GetType(GridViewHierarchyRowInfo) Then
				If e.GridCellInfo.RowInfo.HierarchyLevel = 0 Then
					e.CellStyleInfo.IsItalic = True
					e.CellStyleInfo.FontSize = 12
					e.CellStyleInfo.BackColor = Color.GreenYellow
				ElseIf e.GridCellInfo.RowInfo.HierarchyLevel = 1 Then
					e.CellStyleInfo.ForeColor = Color.DarkGreen
					e.CellStyleInfo.BackColor = Color.LightGreen
				End If
			End If
		End Sub

		Private Sub exportVisualSettingsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles exportVisualSettingsCheckBox.ToggleStateChanged
			Me.spreadExporter.ExportVisualSettings = args.ToggleState = ToggleState.On
		End Sub

		Private Sub exportHierarchyCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.spreadExporter.ExportHierarchy = args.ToggleState = ToggleState.On
		End Sub

		Private Sub exportChildRowsGroupedCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.spreadExporter.ExportChildRowsGrouped = args.ToggleState = ToggleState.On
		End Sub

		Private Sub hiddenColumnRadioButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.hiddenColumnExportAlwaysRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.HiddenColumnOption = HiddenOption.ExportAlways
			ElseIf Me.hiddenColumnDoNotExportRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.HiddenColumnOption = HiddenOption.DoNotExport
			ElseIf Me.hiddenColumnExportAsHiddenRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.HiddenColumnOption = HiddenOption.ExportAsHidden
			End If
		End Sub

		Private Sub hiddenRowRadioButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.hiddenRowExportAlwaysRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.HiddenRowOption = HiddenOption.ExportAlways
			ElseIf Me.hiddenRowDoNotExportRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.HiddenRowOption = HiddenOption.DoNotExport
			ElseIf Me.hiddenRowExportAsHiddenRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.HiddenRowOption = HiddenOption.ExportAsHidden
			End If
		End Sub

		Private Sub summariesRadioButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.summariesExportAllRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.SummariesExportOption = SummariesOption.ExportAll
			ElseIf Me.summariesExportOnlyTopRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.SummariesExportOption = SummariesOption.ExportOnlyTop
			ElseIf Me.summariesExportOnlyBottomRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom
			ElseIf Me.summariesDoNotExportRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.SummariesExportOption = SummariesOption.DoNotExport
			End If
		End Sub

		Private Sub pagingRadioButton_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.pagingCurrentPageOnlyRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.PagingExportOption = PagingExportOption.CurrentPageOnly
			ElseIf Me.pagingAllPagesRadioButton.ToggleState = ToggleState.On Then
				Me.spreadExporter.PagingExportOption = PagingExportOption.AllPages
			End If
		End Sub

		Private Sub pinSomeRowsAndColumnsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If args.ToggleState = ToggleState.On Then
				Me.radGridView1.GroupDescriptors.Clear()
				Me.radGridView1.Rows(0).IsPinned = True
				Me.radGridView1.Columns("CompanyName").IsPinned = True
				Me.exportHierarchyCheckBox.ToggleState = ToggleState.Off
			Else
				Me.radGridView1.Rows(0).IsPinned = False
				Me.radGridView1.Columns("CompanyName").IsPinned = False
			End If
		End Sub

		Private Sub freezeHeaderRowCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.spreadExporter.FreezeHeaderRow = args.ToggleState = ToggleState.On
		End Sub

		Private Sub freezePinnedRowsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.spreadExporter.FreezePinnedRows = args.ToggleState = ToggleState.On
		End Sub

		Private Sub freezePinnedColumnsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.spreadExporter.FreezePinnedColumns = args.ToggleState = ToggleState.On
		End Sub

		Private Sub exportViewDefinitionCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.spreadExporter.ExportViewDefinition = args.ToggleState = ToggleState.On
		End Sub

		#End Region

		#Region "PDF Export"

		Private Sub radButtonPdfExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonPdfExport.Click
			Dim dialog As SaveFileDialog = New SaveFileDialog()
			dialog.FileName = "exportedFile"
			dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"

			If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.pdfExporter.RunExport(dialog.FileName, New PdfExportRenderer())
			End If
		End Sub

		Private Sub pdfExporter_CellFormatting(ByVal sender As Object, ByVal e As PdfExportCellFormattingEventArgs)
			If Me.radCheckBoxCustomizeVisualSettingsPdfExport.ToggleState <> ToggleState.On Then
				Return
			End If

			If TypeOf e.Row Is GridViewTableHeaderRowInfo Then
				If e.Row.HierarchyLevel = 0 Then
					e.CellElement.BackColor = Color.DeepSkyBlue
				ElseIf e.Row.HierarchyLevel = 1 Then
					e.CellElement.BackColor = Color.LightSkyBlue
				End If
			End If

			If TypeOf e.Row Is GridViewHierarchyRowInfo Then
				If e.Row.HierarchyLevel = 0 Then
					e.CellElement.Font = New Font("Segoe UI", 12)
					e.CellElement.BackColor = Color.GreenYellow
				ElseIf e.Row.HierarchyLevel = 1 Then
					e.CellElement.ForeColor = Color.DarkGreen
					e.CellElement.BackColor = Color.LightGreen
				End If
			End If
		End Sub

		Private Sub radCheckBoxExportVisualSettingsPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxExportVisualSettingsPdfExport.ToggleStateChanged
			Me.pdfExporter.ExportVisualSettings = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radCheckBoxExportHierarchyPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.pdfExporter.ExportHierarchy = args.ToggleState = ToggleState.On
		End Sub

		Private Sub radRadioButtonHiddenColumnPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioButtonHiddenColumnExportAlwaysPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.HiddenColumnOption = HiddenOption.ExportAlways
			ElseIf Me.radRadioButtonHiddenColumnDoNotExportPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.HiddenColumnOption = HiddenOption.DoNotExport
			ElseIf Me.radRadioButtonHiddenColumnExportAsHiddenPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.HiddenColumnOption = HiddenOption.ExportAsHidden
			End If
		End Sub

		Private Sub radRadioButtonHiddenRowPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioButtonHiddenRowExportAlwaysPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.HiddenRowOption = HiddenOption.ExportAlways
			ElseIf Me.radRadioButtonHiddenRowDoNotExportPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.HiddenRowOption = HiddenOption.DoNotExport
			ElseIf Me.radRadioButtonHiddenRowExportAsHiddenPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.HiddenRowOption = HiddenOption.ExportAsHidden
			End If
		End Sub

		Private Sub radRadioButtonSummariesExportAllPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioButtonSummariesExportAllPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.SummariesExportOption = SummariesOption.ExportAll
			ElseIf Me.radRadioButtonSummariesExportOnlyTopPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyTop
			ElseIf Me.radRadioButtonSummariesExportOnlyBottomPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom
			ElseIf Me.radRadioButtonSummariesDoNotExportPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.SummariesExportOption = SummariesOption.DoNotExport
			End If
		End Sub

		Private Sub radRadioButtonPagingOptionPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			If Me.radRadioButtonPagingOptionCurrentPageOnlyPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.PagingExportOption = PagingExportOption.CurrentPageOnly
			ElseIf Me.radRadioButtonPagingOptionAllPAgesPdfExport.ToggleState = ToggleState.On Then
				Me.pdfExporter.PagingExportOption = PagingExportOption.AllPages
			End If
		End Sub

		Private Sub radCheckBoxExportViewDefinitionPdfExport_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.pdfExporter.ExportViewDefinition = args.ToggleState = ToggleState.On
		End Sub

		#End Region

		#End Region
    End Class
End Namespace