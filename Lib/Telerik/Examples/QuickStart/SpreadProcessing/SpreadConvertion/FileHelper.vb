Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv
Imports Telerik.Windows.Documents.Spreadsheet.Model

Namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadConvertion
    Public NotInheritable Class FileHelper
        Private Sub New()
        End Sub
        Shared Sub New()
            WorkbookFormatProvidersManager.RegisterFormatProvider(New XlsxFormatProvider())
        End Sub

        Public Shared Sub SaveDocument(workbook As Workbook, selectedFormat As String)
            If workbook Is Nothing Then
                Return
            End If

            Dim formatProvider As IWorkbookFormatProvider = GetFormatProvider(selectedFormat)
            If formatProvider Is Nothing Then
                Return
            End If

            Dim dialog As New SaveFileDialog()
            dialog.Filter = [String].Format("{0} files|*{1}|All files (*.*)|*.*", selectedFormat, formatProvider.SupportedExtensions.First())
            dialog.FileName = "SpreadDocumentsConvertion"

            If dialog.ShowDialog() = DialogResult.OK Then
                Try
                    Using stream As Stream = dialog.OpenFile()
                        formatProvider.Export(workbook, stream)
                    End Using
                Catch ex As IOException
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End Sub

        Private Shared Function GetFormatProvider(extension As String) As IWorkbookFormatProvider
            Dim formatProvider As IWorkbookFormatProvider
            Select Case extension
                Case "Xlsx"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider")
                    Exit Select
                Case "Csv"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("CsvFormatProvider")
                    TryCast(formatProvider, CsvFormatProvider).Settings.HasHeaderRow = True
                    Exit Select
                Case "Txt"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider")
                    Exit Select
                Case Else
                    formatProvider = Nothing
                    Exit Select
            End Select

            Return formatProvider
        End Function

        Public Shared Function GetSampleResourceStream(resource As String) As Stream
            Dim assembly__1 As Assembly = Assembly.GetExecutingAssembly()
            Dim stream As Stream = assembly__1.GetManifestResourceStream(resource)
            If stream IsNot Nothing Then
                Return stream
            End If

            Return Nothing
        End Function
    End Class
End Namespace