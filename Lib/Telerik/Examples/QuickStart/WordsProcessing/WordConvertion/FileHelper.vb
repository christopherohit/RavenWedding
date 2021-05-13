Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Windows
Imports Telerik.Windows.Documents.Common.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders.Docx
Imports Telerik.Windows.Documents.Flow.FormatProviders.Rtf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Txt
Imports Telerik.Windows.Documents.Flow.Model
Imports System.Windows.Forms

Namespace Telerik.Examples.WinControls.WordsProcessing.WordConvertion
    Public NotInheritable Class FileHelper
        Private Sub New()
        End Sub
        Public Shared Sub SaveDocument(document As RadFlowDocument, selectedFromat As String)
            If document Is Nothing Then
                Return
            End If

            Dim formatProvider As IFormatProvider(Of RadFlowDocument) = Nothing
            Select Case selectedFromat
                Case "Docx"
                    formatProvider = New DocxFormatProvider()
                    Exit Select
                Case "Html"
                    formatProvider = New Telerik.Windows.Documents.Flow.FormatProviders.Html.HtmlFormatProvider()
                Case "Rtf"
                    formatProvider = New RtfFormatProvider()
                    Exit Select
                Case "Txt"
                    formatProvider = New TxtFormatProvider()
                    Exit Select
            End Select
            If formatProvider Is Nothing Then
                Return
            End If

            Dim dialog As New SaveFileDialog()
            dialog.Filter = [String].Format("{0} files|*{1}|All files (*.*)|*.*", selectedFromat, formatProvider.SupportedExtensions.First())
            dialog.FilterIndex = 1
            dialog.FileName = "WordDocumentsConvertion"

            If dialog.ShowDialog() = DialogResult.OK Then
                Try
                    Using stream As Stream = dialog.OpenFile()
                        formatProvider.Export(document, stream)
                    End Using
                Catch ex As IOException
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End Sub

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