Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Namespace ExportWithDpl.TreeView
	Public Partial Class Form1
		Inherits RadForm
		Public Sub New()
			InitializeComponent()
			Me.LoadTreeData()
			Me.WireEvents()
			Me.SetupInitialSettings()

			If Program.themeName <> "" Then 'set the example theme to the same theme QSF uses
				ThemeResolutionService.ApplicationThemeName = Program.themeName
			Else
				ThemeResolutionService.ApplicationThemeName = "TelerikMetro" 'set default theme
			End If
		End Sub

		Private Sub LoadTreeData()
			Me.radTreeView1.Nodes.Add(New RadTreeNode("Personal Folders", Image.FromFile("..\TreeView\Images\Root.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Deleted Items", Image.FromFile("..\TreeView\Images\RecycleBin.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Drafts", Image.FromFile("..\TreeView\Images\DraftFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Inbox", Image.FromFile("..\TreeView\Images\InboxFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Junk E-mails", Image.FromFile("..\TreeView\Images\JunkFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Outbox", Image.FromFile("..\TreeView\Images\OutboxFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Sent Items", Image.FromFile("..\TreeView\Images\SentFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("Search Folder", Image.FromFile("..\TreeView\Images\SearchFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes.Add(New RadTreeNode("New Item", Image.FromFile("..\TreeView\Images\SentFolder.png")))

			Me.radTreeView1.Nodes(0).Nodes(2).Nodes.Add(New RadTreeNode("Folders", Image.FromFile("..\TreeView\Images\Folder1.png")))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("From Follow up", Image.FromFile("..\TreeView\Images\SearchFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Large Mail", Image.FromFile("..\TreeView\Images\SearchFolder.png")))
			Me.radTreeView1.Nodes(0).Nodes(6).Nodes.Add(New RadTreeNode("Unread Mail", Image.FromFile("..\TreeView\Images\SearchFolder.png")))

			Me.radTreeView1.TreeViewElement.AutoSizeItems = False
			Me.radTreeView1.ItemHeight = 25
			Me.radTreeView1.ExpandAll()
		End Sub

		Private Sub WireEvents()
			AddHandler Me.exportButton.Click, AddressOf exportButton_Click
			AddHandler Me.allowAlternatingRowColorCheckBox.ToggleStateChanged, AddressOf allowAlternatingRowColorCheckBox_ToggleStateChanged
		End Sub

		Private Sub SetupInitialSettings()
			Me.exportVisualSettingsCheckBox.ToggleState = ToggleState.On
			Me.exportImagesCheckBox.ToggleState = ToggleState.On
			Me.groupChildNodesCheckBox.ToggleState = ToggleState.On
			Me.exportFormatXlsxRadioButton.ToggleState = ToggleState.On
			Me.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On
		End Sub

		Private Sub allowAlternatingRowColorCheckBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
			Me.radTreeView1.TreeViewElement.AllowAlternatingRowColor = args.ToggleState = ToggleState.On
		End Sub

		Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim exporter As TreeViewSpreadExport = New TreeViewSpreadExport(Me.radTreeView1)

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
				exporter.ExportChildNodesGrouped = Me.groupChildNodesCheckBox.ToggleState = ToggleState.On

				If Me.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On Then
					exporter.CollapsedNodeOption = HiddenOption.ExportAlways
				ElseIf Me.collapsedOptionDoNotExportRadioButton.ToggleState = ToggleState.On Then
					exporter.CollapsedNodeOption = HiddenOption.DoNotExport
				ElseIf Me.collapsedOptionExportAsHiddenRadioButton.ToggleState = ToggleState.On Then
					exporter.CollapsedNodeOption = HiddenOption.ExportAsHidden
				End If

				Dim renderer As SpreadExportRenderer = New SpreadExportRenderer()
				exporter.RunExport(dialog.FileName, renderer)
			End If
		End Sub

		Private Sub exporter_CellFormatting(ByVal sender As Object, ByVal e As TreeViewSpreadExportCellFormattingEventArgs)
			If e.TreeNode.Nodes.Count > 0 Then
				e.ExportCell.BackColor = Color.LightBlue
				e.ExportCell.ForeColor = Color.DarkMagenta
				e.ExportCell.Font = New Font("SegoeUI", 12, FontStyle.Underline)
			Else
				e.ExportCell.BackColor = Color.LightYellow
			End If
		End Sub
	End Class
End Namespace
