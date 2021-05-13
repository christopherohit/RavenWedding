Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv
Imports Telerik.Windows.Documents.Spreadsheet.Model

Namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadGridIntegration
    Public Class FileHelper

        Private Sub New()
        End Sub
        Shared Sub New()
            WorkbookFormatProvidersManager.RegisterFormatProvider(New XlsxFormatProvider())
        End Sub

        Public Shared Sub SaveDocument(ByVal workbook As Workbook, ByVal selectedFormat As String)
            Dim formatProvider As IWorkbookFormatProvider = GetFormatProvider(selectedFormat)

            If formatProvider Is Nothing Then
                Return
            End If

            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = String.Format("{0} files|*{1}|All files (*.*)|*.*", selectedFormat, formatProvider.SupportedExtensions.First())
            dialog.FileName = "SpreadGridIntegration"

            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    Using stream As Stream = dialog.OpenFile()
                        formatProvider.Export(workbook, stream)
                    End Using
                Catch ex As IOException
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End Sub

        Private Shared Function GetFormatProvider(ByVal extension As String) As IWorkbookFormatProvider
            Dim formatProvider As IWorkbookFormatProvider
            Select Case extension
                Case "Xlsx"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider")
                Case "Csv"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("CsvFormatProvider")
                    TryCast(formatProvider, CsvFormatProvider).Settings.HasHeaderRow = True
                Case "Txt"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider")
                Case Else
                    formatProvider = Nothing
            End Select

            Return formatProvider
        End Function


    End Class
End Namespace
