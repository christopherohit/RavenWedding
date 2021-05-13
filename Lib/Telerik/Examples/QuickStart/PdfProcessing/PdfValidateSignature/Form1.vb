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
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Fixed.FormatProviders.Pdf
Imports Telerik.Windows.Documents.Fixed.Model
Imports Telerik.Windows.Documents.Fixed.Model.DigitalSignatures
Imports Telerik.Windows.Documents.Fixed.Model.InteractiveForms

Namespace Telerik.Examples.WinControls.PdfProcessing.PdfValidateSignature
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private Enum ValidationStatus
            None
            Valid
            Unknown
            Invalid
        End Enum

        Public Sub New()
            InitializeComponent()
            Me.Validate(0)
            Me.signatureTypeListBox.SelectedIndex = 0
            AddHandler Me.signatureTypeListBox.SelectedIndexChanged, AddressOf SignatureTypeListBox_SelectedIndexChanged
            statusImage.Text = ""
            signatureTypeListBox.AutoSizeItems = True
            signatureTypeListBox.Items(0).Image = Image.FromFile("..\PdfProcessing\PdfValidateSignature\Images\24\ValidSignature.png")
            signatureTypeListBox.Items(1).Image = Image.FromFile("..\PdfProcessing\PdfValidateSignature\Images\24\InvalidSignature.png")
            signatureTypeListBox.Items(2).Image = Image.FromFile("..\PdfProcessing\PdfValidateSignature\Images\24\UnknownSignature.png")
            Me.tableLayoutPanel1.BackColor = Color.Transparent
        End Sub

        Private Sub SignatureTypeListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Dim listbox As RadListElement = TryCast(sender, RadListElement)
            If listbox Is Nothing OrElse listbox.SelectedIndex = -1 Then
                Return
            End If

            Me.Validate(listbox.SelectedIndex)
        End Sub

        Private Overloads Sub Validate(ByVal documentIndex As Integer)
            Dim fileName As String = If(documentIndex = 1, "Invalid.pdf", "Unknown.pdf")
            fileName = "..\PdfProcessing\PdfValidateSignature\SampleData\" & fileName

            Using stream As Stream = New FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read)
                Dim verificationFlags As X509VerificationFlags

                If documentIndex = 0 Then
                    ' We set the following flag for demonstration purposes only.
                    ' This flag ignores a warning regarding certificate authority which is missing in the Windows trusted root certificates.
                    ' The result of this setting is a valid general validation status.
                    ' In real scenario this flag should most probably not be used. The validation process should be based only on Windows trusted root certificates.
                    verificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority
                Else
                    verificationFlags = X509VerificationFlags.NoFlag
                End If

                Me.Validate(stream, verificationFlags)
            End Using
        End Sub

        Private Overloads Sub Validate(ByVal stream As Stream, ByVal verificationFlags As X509VerificationFlags)
            Dim document As RadFixedDocument = (New PdfFormatProvider()).Import(stream)

            Dim validationStatus As ValidationStatus

            ' For simplicity, the example handles only the first signature.
            Dim firstSignatureField As SignatureField = TryCast(document.AcroForm.FormFields.FirstOrDefault(Function(field) field.FieldType = FormFieldType.Signature), SignatureField)
            If firstSignatureField IsNot Nothing AndAlso firstSignatureField.Signature IsNot Nothing Then
                Dim properties As New SignatureValidationProperties()
                properties.Chain.ChainPolicy.VerificationFlags = verificationFlags

                Dim validationResult As SignatureValidationResult = Nothing
                If firstSignatureField.Signature.TryValidate(properties, validationResult) Then
                    If Not validationResult.IsDocumentModified Then
                        If validationResult.IsCertificateValid Then
                            validationStatus = validationStatus.Valid
                        Else
                            validationStatus = validationStatus.Unknown
                        End If
                    Else
                        validationStatus = validationStatus.Invalid
                    End If

                    Me.textBlockIsDocumentModified.Text = validationResult.IsDocumentModified.ToString()
                    Me.textBlockIsCertificateValid.Text = validationResult.IsCertificateValid.ToString()
                    Me.textBlockSignerInformation.Text = validationResult.SignerInformation
                    Me.textBlockHashAlgorithm.Text = validationResult.HashAlgorithm.FriendlyName
                Else
                    validationStatus = validationStatus.Invalid

                    Me.textBlockIsDocumentModified.Text = String.Empty
                    Me.textBlockIsCertificateValid.Text = ""
                    Me.textBlockSignerInformation.Text = "Corrupted signature."
                    Me.textBlockHashAlgorithm.Text = String.Empty
                End If
            Else
                validationStatus = validationStatus.None

                Me.textBlockIsDocumentModified.Text = String.Empty
                Me.textBlockIsCertificateValid.Text = ""
                Me.textBlockSignerInformation.Text = "No signature."
                Me.textBlockHashAlgorithm.Text = String.Empty
            End If

            Me.statusImage.Image = GetValidationStatusImage(validationStatus)
        End Sub

        Private Shared Function GetValidationStatusImage(ByVal validationStatus As ValidationStatus) As Image
            Dim name As String

            Select Case validationStatus
                Case ValidationStatus.None
                    Return Nothing
                Case ValidationStatus.Valid
                    name = "ValidSignature"
                Case ValidationStatus.Unknown
                    name = "UnknownSignature"
                Case ValidationStatus.Invalid
                    name = "InvalidSignature"
                Case Else
                    Return Nothing
            End Select

            Dim statusImagePath As String = String.Format("..\PdfProcessing\PdfValidateSignature\Images\24\{0}.png", name)
            Return Image.FromFile(statusImagePath)
        End Function

        Private Sub openYourDocument_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With {
                .Filter = "PDF files (*.pdf)|*.pdf"
            }

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Me.signatureTypeListBox.SelectedIndex = -1

                Using stream As Stream = openFileDialog.OpenFile()
                    Me.Validate(stream, X509VerificationFlags.NoFlag)
                End Using
            End If
        End Sub
    End Class
End Namespace
