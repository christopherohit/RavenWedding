Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Fixed.FormatProviders.Pdf
Imports Telerik.Windows.Documents.Fixed.Model
Imports Telerik.Windows.Documents.Fixed.Model.Annotations
Imports Telerik.Windows.Documents.Fixed.Model.DigitalSignatures
Imports Telerik.Windows.Documents.Fixed.Model.Editing
Imports Telerik.Windows.Documents.Fixed.Model.InteractiveForms
Imports Telerik.Windows.Documents.Fixed.Model.Resources

Namespace Telerik.Examples.WinControls.PdfProcessing.PdfSignDocuments
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Public unsignedDocFile As String = "..\PdfProcessing\PdfSignDocuments\SampleData\Unsigned.pdf"
        Public signatureFile As String = "..\PdfProcessing\PdfSignDocuments\SampleData\JohnDoe"

        Public Sub New()
            InitializeComponent()
            radPdfViewer1.EnableThumbnails = False
            radPdfViewer1.LoadDocument(unsignedDocFile)
            radPdfViewerNavigator1.AssociatedViewer = radPdfViewer1
        End Sub

        Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            radPdfViewer1.UnloadDocument()
            Dim document As RadFixedDocument
            Dim provider As PdfFormatProvider = New PdfFormatProvider()

            Using stream As Stream = New FileStream(unsignedDocFile, FileMode.Open, FileAccess.Read)
                document = provider.Import(stream)
                Dim fileAllBytes As Byte()

                Using certificateStream As Stream = New FileStream(signatureFile, FileMode.Open, FileAccess.Read)

                    Using ms As MemoryStream = New MemoryStream()
                        certificateStream.CopyTo(ms)
                        fileAllBytes = ms.ToArray()
                    End Using
                End Using

                If fileAllBytes.Length = 0 Then Return
                AddSignature(document, fileAllBytes)
                ReloadSignedFile(document)
            End Using
        End Sub

        Private Shared Sub AddSignature(ByVal document As RadFixedDocument, ByVal certificateFileBytes As Byte())
            Dim formSource As FormSource = New Telerik.Windows.Documents.Fixed.Model.Resources.FormSource()
            formSource.Size = New System.Windows.Size(420, 150)
            Dim certificate As X509Certificate2 = New X509Certificate2(certificateFileBytes, "johndoe")
            Dim signatureField As SignatureField = TryCast(document.AcroForm.FormFields.Where(Function(f) f.FieldType = FormFieldType.Signature).FirstOrDefault(), SignatureField)
            signatureField.Signature = New Signature(certificate)
            Dim widget As SignatureWidget = signatureField.Widgets.FirstOrDefault()

            If widget IsNot Nothing Then
                formSource = widget.Content.NormalContentSource
                Dim ed As FixedContentEditor = New FixedContentEditor(formSource)
                ed.TextProperties.FontSize = 80
                ed.Position.Translate(30, 0)
                ed.DrawText("John Doe")
                ed.Position.Translate(0, 90)
                ed.TextProperties.FontSize = 25
                ed.DrawText("Digitally signed on: " & DateTime.Now.ToString())
                ed.Position.Translate(40, 120)
                ed.TextProperties.FontSize = 20
                ed.DrawText("(Click here to view the signature info)")
            End If

            document.Pages(0).Annotations.Add(widget)
        End Sub

        Private Sub ReloadSignedFile(ByVal document As RadFixedDocument)
            Dim outputStream As MemoryStream = New MemoryStream()
            Dim provider As PdfFormatProvider = New PdfFormatProvider()
            provider.Export(document, outputStream)
            Me.radPdfViewer1.LoadDocument(outputStream)
        End Sub
    End Class
End Namespace
