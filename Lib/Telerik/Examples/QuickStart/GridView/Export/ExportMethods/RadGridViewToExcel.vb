Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports Telerik.Data
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Export


Namespace Telerik.Examples.WinControls.GridView.Export.ExportMethods
    Partial Public Class Form1
        Inherits ExamplesForm
        ' Fields
        Private exportVisualSettings As Boolean

        Public Sub New()
            InitializeComponent()

            Me.radGridView1.EnableHotTracking = True
            Me.radGridView1.EnableAlternatingRowColor = True
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.radGridView1.TableElement.BeginUpdate()
            Me.customersTableAdapter.Fill(Me.nwindRadGridView.Customers)
            Me.radGridView1.MasterTemplate.EnableFiltering = True
            Me.radGridView1.MasterTemplate.AutoExpandGroups = True
            Me.radGridView1.MasterTemplate.AllowAddNewRow = False

            Me.AddSummaries()
            Me.radGridView1.TableElement.EndUpdate()

            SetConditions()

            Me.radListBox1.SelectedIndex = 0
            Me.radComboBoxSummaries.SelectedIndex = 0

            Me.radGridView1.Columns(0).Width = 300
        End Sub

        'Update the progress bar with the export progress
        Private Sub exportProgress(sender As Object, e As ProgressEventArgs)
            ' Call InvokeRequired to check if thread needs marshalling, to access properly the UI thread.
            If Me.InvokeRequired Then

                Me.Invoke(New EventHandler(Sub()
                                               If e.ProgressValue <= 100 Then
                                                   radProgressBar1.Value1 = e.ProgressValue
                                               Else
                                                   radProgressBar1.Value1 = 100
                                               End If
                                           End Sub))
            Else
                If e.ProgressValue <= 100 Then
                    radProgressBar1.Value1 = e.ProgressValue
                Else
                    radProgressBar1.Value1 = 100

                End If
            End If
		End Sub

        ' when the worker finishes the export, we can do some post processing
        Private Sub bg_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
            Me.radButtonExport.Enabled = True
            Me.radProgressBar1.Value1 = 0

            RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
            RadMessageBox.Show("The data in the grid was exported successfully.", "Export to Excel")
        End Sub

        Private Sub radListBox1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            saveFileDialog.Filter = "Excel (*.xls)|*.xls"

            Select Case Me.radListBox1.SelectedIndex
                Case 0
                    'export to excelML
                    Me.radCheckBoxExportVisual.Enabled = True
                    Me.radRadioButton1.Enabled = True
                    Me.radRadioButton2.Enabled = True
                    Me.radTextBoxSheet.Enabled = True
                    Me.radComboBoxSummaries.Enabled = True
                    Me.radLabel1.Visible = True
                    Me.radLabel1.Text = "Sheet:"
                    Me.radTextBoxSheet.Text = [String].Empty
                    Me.radTextBoxSheet.Visible = True

                    Me.radProgressBar1.Visible = False
                    Me.radLblProgress.Visible = False
                    Exit Select
                Case 1
                    'export to CSV
                    saveFileDialog.Filter = "CSV File (*.csv)|*.csv"
                    Me.radCheckBoxExportVisual.Enabled = False
                    Me.radRadioButton1.Enabled = False
                    Me.radRadioButton2.Enabled = False
                    Me.radTextBoxSheet.Enabled = False
                    Me.radComboBoxSummaries.Enabled = True
                    Me.radLabel1.Visible = False
                    Me.radTextBoxSheet.Visible = False

                    Me.radProgressBar1.Visible = False
                    Me.radLblProgress.Visible = False
                    Exit Select
                Case 2
                    'export to HTML
                    saveFileDialog.Filter = "Html File (*.htm)|*.htm"
                    Me.radCheckBoxExportVisual.Enabled = True
                    Me.radRadioButton1.Enabled = False
                    Me.radRadioButton2.Enabled = False
                    Me.radTextBoxSheet.Enabled = True
                    Me.radComboBoxSummaries.Enabled = True
                    Me.radLabel1.Visible = True
                    Me.radLabel1.Text = "HtmlTable Caption:"
                    Me.radTextBoxSheet.Text = [String].Empty
                    Me.radTextBoxSheet.Visible = True

                    Me.radProgressBar1.Visible = False
                    Me.radLblProgress.Visible = False
                    Exit Select
                Case 3
                    'export to PDF
                    saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf"
                    Me.radCheckBoxExportVisual.Enabled = True
                    Me.radRadioButton1.Enabled = False
                    Me.radRadioButton2.Enabled = False
                    Me.radTextBoxSheet.Enabled = True
                    Me.radComboBoxSummaries.Enabled = True
                    Me.radLabel1.Visible = True
                    Me.radLabel1.Text = "PdfTable Caption:"
                    Me.radTextBoxSheet.Text = [String].Empty
                    Me.radTextBoxSheet.Visible = True

                    Me.radProgressBar1.Visible = False
                    Me.radLblProgress.Visible = False
                    Exit Select
            End Select
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

            If Me.radCheckBoxExportVisual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                Me.exportVisualSettings = True
            Else
                Me.exportVisualSettings = False
            End If

            Select Case Me.radListBox1.SelectedIndex
                Case 0
                    'export to excelML
                    RunExportToExcelML(fileName, openExportFile)
                    Exit Select

                Case 1
                    'export to CSV
                    RunExportToCSV(fileName, openExportFile)
                    Exit Select

                Case 2
                    'export to HTML
                    RunExportToHTML(fileName, openExportFile)
                    Exit Select

                Case 3
                    'export to PDF
                    RunExportToPDF(fileName, openExportFile)
                    Exit Select
            End Select

            If openExportFile Then
                Try
                    System.Diagnostics.Process.Start(fileName)
                Catch ex As Exception
                    Dim message As String = [String].Format("The file cannot be opened on your system." & vbLf & "Error message: {0}", ex.Message)
                    RadMessageBox.Show(message, "Open File", MessageBoxButtons.OK, RadMessageIcon.[Error])
                End Try
            End If
        End Sub

        Private Sub SetConditions()
            'add a couple of sample formatting objects
            Dim c1 As New ConditionalFormattingObject("Red", ConditionTypes.Equal, "London", "", True)
            c1.RowBackColor = Color.FromArgb(255, 153, 0)
            c1.RowForeColor = Color.Black
            radGridView1.Columns("City").ConditionalFormattingObjectList.Add(c1)

            Dim c2 As New ConditionalFormattingObject("Green", ConditionTypes.Equal, "Berlin", "", True)
            c2.RowBackColor = Color.FromArgb(165, 244, 36)
            c2.RowForeColor = Color.Black
            radGridView1.Columns("City").ConditionalFormattingObjectList.Add(c2)
        End Sub

        Private Sub AddSummaries()
            Dim item1 As New GridViewSummaryRowItem()
            Dim item2 As New GridViewSummaryRowItem()

            item1.Add(New GridViewSummaryItem("CompanyName", "Count: {0}", GridAggregateFunction.Count))
            item2.Add(New GridViewSummaryItem("ContactName", "Count: {0}", GridAggregateFunction.Count))

            Me.radGridView1.MasterTemplate.SummaryRowsTop.Add(item1)
            Me.radGridView1.MasterTemplate.SummaryRowsBottom.Add(item2)
        End Sub

        Private Sub RunExportToExcelML(fileName As String, ByRef openExportFile As Boolean)
            Dim excelExporter As New ExportToExcelML(Me.radGridView1)

            If Me.radTextBoxSheet.Text <> [String].Empty Then

                excelExporter.SheetName = Me.radTextBoxSheet.Text
            End If

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

            'set max sheet rows
            If Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                excelExporter.SheetMaxRows = ExcelMaxRows._1048576
            ElseIf Me.radRadioButton2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On] Then
                excelExporter.SheetMaxRows = ExcelMaxRows._65536
            End If

            'set exporting visual settings
            excelExporter.ExportVisualSettings = Me.exportVisualSettings

            Try
                excelExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to Excel", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True
                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            End Try
        End Sub

        Private Sub RunExportToCSV(fileName As String, ByRef openExportFile As Boolean)
            Dim csvExporter As New ExportToCSV(Me.radGridView1)
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
            Try
                csvExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to CSV", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True
                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            End Try
        End Sub

        Private Sub RunExportToHTML(fileName As String, ByRef openExportFile As Boolean)
            Dim htmlExporter As New ExportToHTML(Me.radGridView1)

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

            'set exporting visual settings
            htmlExporter.ExportVisualSettings = Me.exportVisualSettings
            htmlExporter.TableCaption = Me.radTextBoxSheet.Text

            Try
                htmlExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to HTML", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True
                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            End Try
        End Sub

        Private Sub RunExportToPDF(fileName As String, ByRef openExportFile As Boolean)
            Dim pdfExporter As New ExportToPDF(Me.radGridView1)
            pdfExporter.PdfExportSettings.Title = "My PDF Title"
            pdfExporter.PdfExportSettings.PageWidth = 297
            pdfExporter.PdfExportSettings.PageHeight = 210
            pdfExporter.PageTitle = Me.radTextBoxSheet.Text
            pdfExporter.FitToPageWidth = True

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

            'set exporting visual settings
            pdfExporter.ExportVisualSettings = Me.exportVisualSettings

            Try
                pdfExporter.RunExport(fileName)

                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                Dim dr As DialogResult = RadMessageBox.Show("The data in the grid was exported successfully. Do you want to open the file?", "Export to PDF", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If dr = DialogResult.Yes Then
                    openExportFile = True

                End If
            Catch ex As IOException
                RadMessageBox.SetThemeName(Me.radGridView1.ThemeName)
                RadMessageBox.Show(Me, ex.Message, "I/O Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
            End Try
        End Sub

        Protected Overrides Sub WireEvents()
            AddHandler Me.radButtonExport.Click, AddressOf Me.radButtonExport_Click
            AddHandler Me.radListBox1.SelectedIndexChanged, AddressOf Me.radListBox1_SelectedIndexChanged
        End Sub
    End Class
End Namespace