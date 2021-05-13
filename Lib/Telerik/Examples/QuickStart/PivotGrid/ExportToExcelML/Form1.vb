Imports System.IO

Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.Aggregates
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.PivotGrid.ExportToExcelML
	Partial Public Class Form1
		Inherits ExamplesForm
		Private radPivotGrid1 As RadPivotGrid
		Private radPrintDocument1 As RadPrintDocument

		Private orders As New List(Of Order2)()
		Private provider As LocalDataSourceProvider
		Private exporter As Telerik.WinControls.UI.Export.PivotExportToExcelML

		Public Sub New()
			Me.radPivotGrid1 = New RadPivotGrid()
			Me.radPivotGrid1.ColumnWidth = 110
			Me.radPivotGrid1.Dock = DockStyle.Fill

			Me.radPrintDocument1 = New RadPrintDocument()
			Me.radPrintDocument1.AssociatedObject = Me.radPivotGrid1

			Me.Controls.Add(Me.radPivotGrid1)
			InitializeComponent()


		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Me.LoadData()

			Me.provider = New LocalDataSourceProvider() With {.ItemsSource = orders}

			provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Product"})
			provider.ColumnGroupDescriptions.Add(New PropertyGroupDescription() With {.PropertyName = "Promotion"})

			provider.RowGroupDescriptions.Add(New DateTimeGroupDescription() With {.PropertyName = "Date", .Step = DateTimeStep.Day})

			provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Quantity", .AggregateFunction = AggregateFunctions.Sum})
			provider.AggregateDescriptions.Add(New PropertyAggregateDescription() With {.PropertyName = "Net", .AggregateFunction = AggregateFunctions.Sum})

			provider.AggregatesPosition = PivotAxis.Rows
			provider.AggregatesLevel = 21

			Me.radPivotGrid1.ColumnGrandTotalsPosition = TotalsPos.Last
			Me.radPivotGrid1.ColumnsSubTotalsPosition = TotalsPos.Last

			Me.radPivotGrid1.RowGrandTotalsPosition = TotalsPos.Last
			Me.radPivotGrid1.RowsSubTotalsPosition = TotalsPos.None

			Me.radPivotGrid1.PivotGridElement.DataProvider = provider
			Me.radPivotGrid1.PivotGridElement.BestFitHelper.BestFitColumns()

			Me.exporter = New Telerik.WinControls.UI.Export.PivotExportToExcelML(Me.radPivotGrid1)
			AddHandler exporter.PivotExcelCellFormatting, AddressOf exporter_PivotExcelCellFormatting
		End Sub

		Private Sub LoadData()
            Dim stream As Stream = System.Reflection.Assembly.GetAssembly(Me.GetType()).GetManifestResourceStream("PivotData.txt")

            Using streamReader As New StreamReader(stream)
				Do While streamReader.Peek() <> -1
					Dim items() As String = streamReader.ReadLine().Split(ControlChars.Tab)
					Dim o As New Order2() With {.Date = Date.Parse(items(0), System.Globalization.CultureInfo.InvariantCulture), .Product = items(1), .Quantity = Integer.Parse(items(2), System.Globalization.CultureInfo.InvariantCulture), .Net = Double.Parse(items(3), System.Globalization.CultureInfo.InvariantCulture), .Promotion = items(4), .Advertisement = items(5)}
					orders.Add(o)
				Loop
			End Using
		End Sub

		Private Sub buttonPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radPivotGrid1.Print(True, Me.radPrintDocument1)
		End Sub

		Private Sub buttonPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.radPivotGrid1.PrintPreview(Me.radPrintDocument1)
		End Sub

		Private Sub buttonPrintSettings_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As New PivotGridPrintSettingsDialog(Me.radPrintDocument1)
			dialog.ThemeName = Me.radPivotGrid1.ThemeName
			If dialog.ShowDialog() = DialogResult.OK Then
				Me.radPivotGrid1.PrintPreview(Me.radPrintDocument1)
			End If
		End Sub

		Protected Overrides Sub WireEvents()

		End Sub

		Private Sub exporter_PivotExcelCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Export.ExcelPivotCellExportingEventArgs)
			Me.radProgressBarExport.Maximum = e.RowsCount+1
			If Me.radProgressBarExport.Value1 < Me.radProgressBarExport.Maximum Then
				Me.radProgressBarExport.Value1 += 1
			End If
			Dim value As Decimal = 0
			If Decimal.TryParse(e.Cell.Text, value) Then
				If value>1000 Then
					e.Cell.BackColor = Color.Red
				End If
				If value < 100 Then
					e.Cell.BackColor = Color.Green
				End If
			End If
		End Sub

		Private Sub buttonExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonExport.Click
			Dim saveFileDialog1 As New SaveFileDialog()
			saveFileDialog1.Filter = "Excel ML|*.xls"
			saveFileDialog1.Title = "Export to File"
			saveFileDialog1.ShowDialog()
			If saveFileDialog1.FileName <> "" Then
				Me.exporter.RunExport(saveFileDialog1.FileName)
				MessageBox.Show("Successfully exported to " & saveFileDialog1.FileName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Me.radProgressBarExport.Value1 = 0
				Try
					Process.Start(saveFileDialog1.FileName)
				Finally
				End Try
			End If
		End Sub

		Private Sub radCheckBoxFlatData_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBoxFlatData.ToggleStateChanged
            If Me.exporter IsNot Nothing Then Me.exporter.ExportFlatData = Me.radCheckBoxFlatData.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        End Sub
	End Class
End Namespace
