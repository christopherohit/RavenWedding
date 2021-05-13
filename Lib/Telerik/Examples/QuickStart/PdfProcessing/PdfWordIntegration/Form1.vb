Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Windows.Documents.Common.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders.Pdf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Docx
Imports Telerik.Windows.Documents.Flow.FormatProviders.Html
Imports Telerik.Windows.Documents.Flow.FormatProviders.Rtf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Txt
Imports Telerik.Windows.Documents.Flow.Model
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PdfProcessing.PdfWordIntegration
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private document As RadFlowDocument
        Private ReadOnly providers As List(Of IFormatProvider(Of RadFlowDocument))

        Public Sub New()
            InitializeComponent()
            pictureBox1.Image = Image.FromFile("..\PdfProcessing\PdfWordIntegration\SampleData\CustomDocumentImage.png")
            pictureBox2.Image = Image.FromFile("..\PdfProcessing\PdfWordIntegration\SampleData\JohnGrishamThumbnail.png")
            pictureBox1.BorderStyle = BorderStyle.FixedSingle
            pictureBox2.BorderStyle = BorderStyle.FixedSingle
            Me.providers = New List(Of IFormatProvider(Of RadFlowDocument))() From {
                New DocxFormatProvider(),
                New RtfFormatProvider(),
                New HtmlFormatProvider(),
                New TxtFormatProvider(),
                New PdfFormatProvider()
            }
            radDropDownList1.SelectedIndex = 0
        End Sub

        Private Sub loadCustomDocButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "Docx files|*.docx|Rtf files|*.rtf|Html files|*.html|Text files|*.txt|All files (*.*)|*.*"
            dialog.FilterIndex = 1

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim extension As String = Path.GetExtension(dialog.FileName)
                Dim provider As IFormatProvider(Of RadFlowDocument) = Me.providers.FirstOrDefault(Function(p) p.SupportedExtensions.Any(Function(x) String.Equals(extension, x, StringComparison.InvariantCultureIgnoreCase)))

                If provider Is Nothing Then
                    MessageBox.Show("Not supported file type.")
                    Return
                End If

                Using stream As Stream = dialog.OpenFile()

                    Try
                        Me.document = provider.Import(stream)
                        Me.documentPathLabel.Text = Path.GetFileName(dialog.FileName)
                    Catch __unusedException1__ As Exception
                        MessageBox.Show("Could not open file.")
                        Me.document = Nothing
                        Me.documentPathLabel.Text = ""
                    End Try
                End Using
            End If
        End Sub

        Private Sub loadSampleDocButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim path As String = "..\PdfProcessing\PdfWordIntegration\SampleData\JohnGrisham.docx"
            File.SetAttributes(path, FileAttributes.Normal)

            Using stream As Stream = New FileStream(path, FileMode.Open)
                Me.document = New DocxFormatProvider().Import(stream)
                Me.documentPathLabel.Text = System.IO.Path.GetFileName(path)
            End Using
        End Sub

        Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim formatProvider As IFormatProvider(Of RadFlowDocument) = New PdfFormatProvider()
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = String.Format("Pdf files|*{0}|All files (*.*)|*.*", formatProvider.SupportedExtensions.First())
            dialog.FileName = "Result"
            dialog.FilterIndex = 1

            If dialog.ShowDialog() = DialogResult.OK Then

                Using stream As Stream = dialog.OpenFile()
                    formatProvider.Export(document, stream)
                End Using
            End If
        End Sub
    End Class
End Namespace
