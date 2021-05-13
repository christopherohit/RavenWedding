Imports System.IO
Imports Telerik.Pivot.Core
Imports Telerik.Pivot.Core.ViewModels

Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Pivot.Core.Aggregates

Namespace Telerik.Examples.WinControls.PivotGrid.Printing
	Partial Public Class Form1
		Inherits ExamplesForm
		Private radPivotGrid1 As RadPivotGrid
		Private radPrintDocument1 As RadPrintDocument

		Private orders As New List(Of Order2)()
		Private provider As LocalDataSourceProvider

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
			AddHandler buttonPrint.Click, AddressOf buttonPrint_Click
			AddHandler buttonPrintPreview.Click, AddressOf buttonPrintPreview_Click
			AddHandler buttonPrintSettings.Click, AddressOf buttonPrintSettings_Click
		End Sub

		Private Sub buttonExport_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim m As New Telerik.WinControls.UI.Export.PivotExportToExcelML(Me.radPivotGrid1.PivotGridElement)
			Dim saveFileDialog1 As New SaveFileDialog()
			saveFileDialog1.Filter = "Excel ML|*.xls"
			saveFileDialog1.Title = "Export to File"
			saveFileDialog1.ShowDialog()
			If saveFileDialog1.FileName <> "" Then
				m.RunExport(saveFileDialog1.FileName)
				MessageBox.Show("Successfully exported to " & saveFileDialog1.FileName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End Sub
	End Class
End Namespace
