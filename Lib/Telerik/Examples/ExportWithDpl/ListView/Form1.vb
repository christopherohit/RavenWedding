Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Namespace ExportWithDpl.ListView
	Public Partial Class Form1
		Inherits RadForm
		Public Sub New()
			InitializeComponent()
			Me.WireEvents()
			Me.SetupInitialSettings()

			If Program.themeName <> "" Then 'set the example theme to the same theme QSF uses
				ThemeResolutionService.ApplicationThemeName = Program.themeName
			Else
				ThemeResolutionService.ApplicationThemeName = "TelerikMetro" 'set default theme
			End If
		End Sub

		Private Sub WireEvents()
			AddHandler Me.listViewShowGroupsCheckBox.ToggleStateChanged, AddressOf listViewShowGroupsCheckBox_ToggleStateChanged
			AddHandler Me.exportButton.Click, AddressOf exportButton_Click
			AddHandler Me.listViewTypeDropDownList.SelectedIndexChanged, AddressOf listViewTypeDropDownList_SelectedIndexChanged
		End Sub

		Private Sub SetupInitialSettings()
			Me.listViewShowGroupsCheckBox.ToggleState = ToggleState.On
			Me.exportVisualSettingsCheckBox.ToggleState = ToggleState.On
			Me.exportImagesCheckBox.ToggleState = ToggleState.On
			Me.groupChildItemsCheckBox.ToggleState = ToggleState.On
			Me.exportFormatXlsxRadioButton.ToggleState = ToggleState.On
			Me.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On
		End Sub

		Private Sub listViewShowGroupsCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radListView1.ShowGroups = args.ToggleState = ToggleState.On
		End Sub

		Private Sub listViewTypeDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
			Select Case Me.listViewTypeDropDownList.Text
				Case "List View"
					Me.radListView1.ViewType = ListViewType.ListView
					Me.radListView1.ItemSize = New Size(200, 32)
				Case "Icon View"
					Me.radListView1.ViewType = ListViewType.IconsView
					Me.radListView1.ItemSize = New Size(155, 46)
				Case "Detail View"
					Me.radListView1.ViewType = ListViewType.DetailsView
					Me.radListView1.ItemSize = New Size(200, 32)
			End Select
		End Sub

        Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim exporter As ListViewSpreadExport = New ListViewSpreadExport(Me.radListView1)

            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.FileName = "exportedFile"
            If Me.exportFormatXlsxRadioButton.ToggleState = ToggleState.On Then
                exporter.ExportFormat = SpreadExportFormat.Xlsx
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            ElseIf Me.exportFormatPdfRadioButton.ToggleState = ToggleState.On Then
                exporter.ExportFormat = SpreadExportFormat.Pdf
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
            ElseIf Me.exportFormatCsvRadioButton.ToggleState = ToggleState.On Then
                exporter.ExportFormat = SpreadExportFormat.Csv
                dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
            ElseIf Me.exportFormatTxtRadioButton.ToggleState = ToggleState.On Then
                exporter.ExportFormat = SpreadExportFormat.Txt
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            End If

            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If Me.customizeVisualSettingsCheckBox.ToggleState = ToggleState.On Then
                    AddHandler exporter.CellFormatting, AddressOf exporter_CellFormatting
                End If

                exporter.ExportVisualSettings = Me.exportVisualSettingsCheckBox.ToggleState = ToggleState.On
                exporter.ExportImages = Me.exportImagesCheckBox.ToggleState = ToggleState.On
                exporter.ExportChildItemsGrouped = Me.groupChildItemsCheckBox.ToggleState = ToggleState.On

                If Me.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On Then
                    exporter.CollapsedItemOption = HiddenOption.ExportAlways
                ElseIf Me.collapsedOptionDoNotExportRadioButton.ToggleState = ToggleState.On Then
                    exporter.CollapsedItemOption = HiddenOption.DoNotExport
                ElseIf Me.collapsedOptionExportAsHiddenRadioButton.ToggleState = ToggleState.On Then
                    exporter.CollapsedItemOption = HiddenOption.ExportAsHidden
                End If

                Dim renderer As SpreadExportRenderer = New SpreadExportRenderer()
                AddHandler renderer.WorkbookCreated, AddressOf renderer_WorkbookCreated
                exporter.RunExport(dialog.FileName, renderer)
            End If
        End Sub

        Private Sub renderer_WorkbookCreated(sender As Object, e As WorkbookCreatedEventArgs)
            Dim worksheet As Telerik.Windows.Documents.Spreadsheet.Model.Worksheet = e.Workbook.ActiveWorksheet
            worksheet.Columns(worksheet.UsedCellRange).AutoFitWidth()
        End Sub

		Private Sub exporter_CellFormatting(ByVal sender As Object, ByVal e As ListViewSpreadExportCellFormattingEventArgs)
			If TypeOf e.DataItem Is ListViewDataItemGroup Then
				e.ExportCell.BackColor = Color.AliceBlue
				e.ExportCell.ForeColor = Color.DarkGreen
				e.ExportCell.Font = New Font("SegoeUI", 12, FontStyle.Italic)
			ElseIf e.RowIndex Mod 2 = 0 Then
				e.ExportCell.BackColor = Color.LightGray
			End If
		End Sub
	End Class
End Namespace
