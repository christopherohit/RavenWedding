Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports Telerik.Windows.Documents.Spreadsheet.Model

Namespace ExportWithDpl.PropertyGrid
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
			AddHandler Me.exportButton.Click, AddressOf exportButton_Click
		End Sub

		Private Sub SetupInitialSettings()
			Me.exportVisualSettingsCheckBox.ToggleState = ToggleState.On
			Me.groupChildItemsCheckBox.ToggleState = ToggleState.On
			Me.exportFormatXlsxRadioButton.ToggleState = ToggleState.On
			Me.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On
		End Sub

		Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim exporter As PropertyGridSpreadExport = New PropertyGridSpreadExport(Me.radPropertyGrid1)

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
				exporter.ExportChildItemsGrouped = Me.groupChildItemsCheckBox.ToggleState = ToggleState.On

				If Me.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On Then
					exporter.CollapsedItemOption = HiddenOption.ExportAlways
				ElseIf Me.collapsedOptionDoNotExportRadioButton.ToggleState = ToggleState.On Then
					exporter.CollapsedItemOption = HiddenOption.DoNotExport
				ElseIf Me.collapsedOptionExportAsHiddenRadioButton.ToggleState = ToggleState.On Then
					exporter.CollapsedItemOption = HiddenOption.ExportAsHidden
				End If

				Dim renderer As SpreadExportRenderer = New SpreadExportRenderer()
				If Me.exportDescriptionsCheckBox.ToggleState = ToggleState.On Then
					exporter.ExportDescriptions = True
					AddHandler renderer.WorkbookCreated, AddressOf renderer_WorkbookCreated
				End If
				exporter.RunExport(dialog.FileName, renderer)
			End If
		End Sub

		Private Sub renderer_WorkbookCreated(ByVal sender As Object, ByVal e As WorkbookCreatedEventArgs)
			Dim worksheet As Worksheet = e.Workbook.ActiveWorksheet
			worksheet.Columns(worksheet.UsedCellRange.GetLastColumn()).AutoFitWidth()
		End Sub

		Private Sub exporter_CellFormatting(ByVal sender As Object, ByVal e As PropertyGridSpreadExportCellFormattingEventArgs)
			If TypeOf e.Item Is PropertyGridGroupItem Then
				e.ExportCell.BackColor = Color.Cornsilk
				e.ExportCell.ForeColor = Color.YellowGreen
			ElseIf e.Item.GridItems.Count > 0 Then
				e.ExportCell.BackColor = Color.LightSteelBlue
			End If
		End Sub
	End Class
End Namespace
