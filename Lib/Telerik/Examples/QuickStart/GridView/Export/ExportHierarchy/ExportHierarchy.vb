Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports Telerik.Data
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Export


Namespace Telerik.Examples.WinControls.GridView.Export.ExportHierarchy
    Partial Public Class Form1
        Inherits ExamplesForm
        Public Sub New()
            InitializeComponent()

            saveFileDialog.Filter = "Excel (*.xls)|*.xls"

            Me.radGridView1.EnableHotTracking = True
            Me.radGridView1.[ReadOnly] = True
            Me.radGridView1.AutoGenerateHierarchy = True
            Me.radGridView1.EnableFiltering = True
            Me.radGridView1.ShowFilteringRow = False
            Me.radGridView1.ShowHeaderCellButtons = True
            Me.radGridView1.AutoExpandGroups = True
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radGridView1.TableElement.BeginUpdate()
            'TODO
            'this.ordersTableAdapter.FillByTOP20(this.nwindDataSet.Orders);
            Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)
            Me.order_detailsTableAdapter.Fill(Me.nwindDataSet.Order_Details)

            Me.radGridView1.Columns("ShipName").IsVisible = False
            Me.radGridView1.Columns("ShipAddress").IsVisible = False
            Me.radGridView1.Columns("ShipPostalCode").IsVisible = False
            Me.radGridView1.Columns("RequiredDate").IsVisible = False
            Me.radGridView1.Columns("ShippedDate").IsVisible = False

            Me.radGridView1.Columns("OrderDate").FormatString = "{0:d}"
            Me.radGridView1.Columns("OrderDate").ExcelExportType = DisplayFormatType.ShortDate

            Me.radGridView1.MasterTemplate.Templates(0).Columns("UnitPrice").FormatString = "{0:c}"

            Me.AddSummaries()
            Me.radGridView1.TableElement.EndUpdate()

            Me.radRadioButtonExcel.IsChecked = True
            Me.radComboBoxSummaries.SelectedIndex = 0
        End Sub

        Private Sub radRadioButtonExport_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            If Me.radRadioButtonCsv.IsChecked Then
                Me.radCheckBoxExportVisual.Enabled = False
                saveFileDialog.Filter = "CSV File (*.csv)|*.csv"
            Else
                Me.radCheckBoxExportVisual.Enabled = True

                If Me.radRadioButtonExcel.IsChecked Then
                    saveFileDialog.Filter = "Excel (*.xls)|*.xls"
                ElseIf Me.radRadioButtonHtml.IsChecked Then
                    saveFileDialog.Filter = "Html File (*.htm)|*.htm"
                ElseIf Me.radRadioButtonPdf.IsChecked Then
                    saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf"
                End If
            End If
        End Sub

        Private Sub radButtonExport_Click(sender As Object, e As EventArgs)
            If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                Return
            End If

            If saveFileDialog.FileName.Equals([String].Empty) Then
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show("Please enter a file name.")
                Return
            End If

            Dim fileName As String = Me.saveFileDialog.FileName
            Dim openExportFile As Boolean = False

            If Me.radRadioButtonExcel.IsChecked Then
                RunExportToExcelML(fileName, openExportFile)
            ElseIf Me.radRadioButtonCsv.IsChecked Then
                RunExportToCSV(fileName, openExportFile)
            ElseIf Me.radRadioButtonHtml.IsChecked Then
                RunExportToHTML(fileName, openExportFile)
            ElseIf Me.radRadioButtonPdf.IsChecked Then
                RunExportToPDF(fileName, openExportFile)
            End If

            If openExportFile Then
                Try
                    System.Diagnostics.Process.Start(fileName)
                Catch ex As Exception
                    Dim message As String = [String].Format("The file cannot be opened on your system." & vbLf & "Error message: {0}", ex.Message)
                    RadMessageBox.Show(message, "Open File", MessageBoxButtons.OK, RadMessageIcon.[Error])
                End Try
            End If
        End Sub

        Private Sub AddSummaries()
            'master template
            Dim item1 As New GridViewSummaryRowItem()
            Dim item2 As New GridViewSummaryRowItem()

            item1.Add(New GridViewSummaryItem("OrderID", "Count: {0}", GridAggregateFunction.Count))
            item2.Add(New GridViewSummaryItem("Freight", "Max: {0}", GridAggregateFunction.Max))

            Me.radGridView1.MasterTemplate.SummaryRowsTop.Add(item1)
            Me.radGridView1.MasterTemplate.SummaryRowsBottom.Add(item2)

            'child template
            Dim item3 As New GridViewSummaryRowItem()
            Dim item4 As New GridViewSummaryRowItem()

            item3.Add(New GridViewSummaryItem("UnitPrice", "Avg: {0:c}", GridAggregateFunction.Avg))
            item4.Add(New GridViewSummaryItem("Quantity", "Sum: {0}", GridAggregateFunction.Sum))

            Me.radGridView1.MasterTemplate.Templates(0).SummaryRowsTop.Add(item3)
            Me.radGridView1.MasterTemplate.Templates(0).SummaryRowsBottom.Add(item4)
        End Sub

        Private Sub radComboBoxSummaries_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.radButtonExport.Focus()
        End Sub

        Private Sub RunExportToExcelML(fileName As String, ByRef openExportFile As Boolean)
            Dim excelExporter As New ExportToExcelML(Me.radGridView1)

            Select Case Me.radComboBoxSummaries.SelectedIndex
                Case 0
                    excelExporter.SummariesExportOption = SummariesOption.ExportAll
                    Exit Select
                Case 1
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyTop
                    Exit Select
                Case 2
                    excelExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom
                    Exit Select
                Case 3
                    excelExporter.SummariesExportOption = SummariesOption.DoNotExport
                    Exit Select
            End Select

            'set export settings
            excelExporter.ExportVisualSettings = Me.radCheckBoxExportVisual.IsChecked
            excelExporter.ExportHierarchy = Me.radCheckBoxExportHierarchy.IsChecked
            excelExporter.HiddenColumnOption = HiddenOption.DoNotExport

            Try
                Me.Cursor = Cursors.WaitCursor

                excelExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to Excel", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True
                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            Finally
                Me.Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub RunExportToCSV(fileName As String, ByRef openExportFile As Boolean)
            Dim csvExporter As New ExportToCSV(Me.radGridView1)
            AddHandler csvExporter.CSVCellFormatting, AddressOf csvExporter_CSVCellFormatting

            Select Case Me.radComboBoxSummaries.SelectedIndex
                Case 0
                    csvExporter.SummariesExportOption = SummariesOption.ExportAll
                    Exit Select
                Case 1
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyTop
                    Exit Select
                Case 2
                    csvExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom
                    Exit Select
                Case 3
                    csvExporter.SummariesExportOption = SummariesOption.DoNotExport
                    Exit Select
            End Select

            'set export settings
            csvExporter.ExportHierarchy = Me.radCheckBoxExportHierarchy.IsChecked
            csvExporter.HiddenColumnOption = HiddenOption.DoNotExport

            Try
                Me.Cursor = Cursors.WaitCursor

                csvExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to CSV", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True
                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            Finally
                Me.Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub csvExporter_CSVCellFormatting(sender As Object, e As Telerik.WinControls.UI.Export.CSV.CSVCellFormattingEventArgs)
            If TypeOf e.GridCellInfo.ColumnInfo Is GridViewDateTimeColumn Then
                e.CSVCellElement.Value = Me.FormatDate(e.CSVCellElement.Value)
            End If
        End Sub

        Private Sub RunExportToHTML(fileName As String, ByRef openExportFile As Boolean)
            Dim htmlExporter As New ExportToHTML(Me.radGridView1)
            AddHandler htmlExporter.HTMLCellFormatting, AddressOf htmlExporter_HTMLCellFormatting

            Select Case Me.radComboBoxSummaries.SelectedIndex
                Case 0
                    htmlExporter.SummariesExportOption = SummariesOption.ExportAll
                    Exit Select
                Case 1
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyTop
                    Exit Select
                Case 2
                    htmlExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom
                    Exit Select
                Case 3
                    htmlExporter.SummariesExportOption = SummariesOption.DoNotExport
                    Exit Select
            End Select

            'set export settings
            htmlExporter.ExportVisualSettings = Me.radCheckBoxExportVisual.IsChecked
            htmlExporter.ExportHierarchy = Me.radCheckBoxExportHierarchy.IsChecked
            htmlExporter.HiddenColumnOption = HiddenOption.DoNotExport

            Try
                Me.Cursor = Cursors.WaitCursor

                htmlExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to HTML", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True
                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            Finally
                Me.Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub htmlExporter_HTMLCellFormatting(sender As Object, e As Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventArgs)
            If TypeOf e.GridCellInfo.ColumnInfo Is GridViewDateTimeColumn Then
                e.HTMLCellElement.Value = Me.FormatDate(e.HTMLCellElement.Value)
            End If
        End Sub

        Private Sub RunExportToPDF(fileName As String, ByRef openExportFile As Boolean)
            Dim pdfExporter As New ExportToPDF(Me.radGridView1)
            pdfExporter.PdfExportSettings.Title = "My PDF Title"
            pdfExporter.PdfExportSettings.PageWidth = 297
            pdfExporter.PdfExportSettings.PageHeight = 210
            pdfExporter.FitToPageWidth = True
            AddHandler pdfExporter.HTMLCellFormatting, AddressOf pdfExporter_HTMLCellFormatting

            Select Case Me.radComboBoxSummaries.SelectedIndex
                Case 0
                    pdfExporter.SummariesExportOption = SummariesOption.ExportAll
                    Exit Select
                Case 1
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyTop
                    Exit Select
                Case 2
                    pdfExporter.SummariesExportOption = SummariesOption.ExportOnlyBottom
                    Exit Select
                Case 3
                    pdfExporter.SummariesExportOption = SummariesOption.DoNotExport
                    Exit Select
            End Select

            'set export settings
            pdfExporter.ExportVisualSettings = Me.radCheckBoxExportVisual.IsChecked
            pdfExporter.ExportHierarchy = Me.radCheckBoxExportHierarchy.IsChecked
            pdfExporter.HiddenColumnOption = HiddenOption.DoNotExport

            Try
                Me.Cursor = Cursors.WaitCursor

                pdfExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to PDF", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True

                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            Finally
                Me.Cursor = Cursors.[Default]
            End Try
        End Sub

        Private Sub pdfExporter_HTMLCellFormatting(sender As Object, e As Telerik.WinControls.UI.Export.HTML.HTMLCellFormattingEventArgs)
            If TypeOf e.GridCellInfo.ColumnInfo Is GridViewDateTimeColumn Then
                e.HTMLCellElement.Value = Me.FormatDate(e.HTMLCellElement.Value)
            End If
        End Sub

        Private Function FormatDate(value As Object) As String
            Dim [date] As DateTime
            If DateTime.TryParse(value.ToString(), [date]) Then
                Return [date].ToString("d MMM yyyy")
            End If

            Return value.ToString()
        End Function

        Protected Overrides Sub WireEvents()
            AddHandler radComboBoxSummaries.SelectedIndexChanged, AddressOf radComboBoxSummaries_SelectedIndexChanged
            AddHandler radRadioButtonExcel.ToggleStateChanged, AddressOf radRadioButtonExport_ToggleStateChanged
            AddHandler radRadioButtonCsv.ToggleStateChanged, AddressOf radRadioButtonExport_ToggleStateChanged
            AddHandler radRadioButtonHtml.ToggleStateChanged, AddressOf radRadioButtonExport_ToggleStateChanged
            AddHandler radRadioButtonPdf.ToggleStateChanged, AddressOf radRadioButtonExport_ToggleStateChanged
            AddHandler radButtonExport.Click, AddressOf radButtonExport_Click
        End Sub
    End Class
End Namespace