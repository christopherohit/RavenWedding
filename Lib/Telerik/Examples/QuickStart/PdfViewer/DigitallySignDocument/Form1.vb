Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports System.IO
Imports System.Reflection

Namespace Telerik.Examples.WinControls.PdfViewer.DigitallySignDocument
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

            Me.LoadDocumentWithStream("Unsigned.pdf")
            Me.radPdfViewerNavigator1.MinimumSize = New Size(0, 60)
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.openDocumentButton.Click, AddressOf OnOpenDocumentButtonClick
			AddHandler Me.downloadCertificateButton.Click, AddressOf OnDownloadCertificateButtonClick
		End Sub

		Private Sub OnOpenDocumentButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.Filter = "PDF Files|*.pdf"
			openFileDialog.Title = "Select a PDF File"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Me.radPdfViewer1.LoadDocument(openFileDialog.FileName)
				Me.radPdfViewerNavigator1.UpdatePageCount()
			End If
		End Sub

		Private Sub OnDownloadCertificateButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.Filter = "PFX file (*.pfx)|*.pfx"
			saveFileDialog.FileName = "JohnDoe"
			saveFileDialog.DefaultExt = ".pfx"
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				Using outputStream As Stream = saveFileDialog.OpenFile()
					Using inputStream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Telerik.Examples.WinControls.PdfViewer.DigitallySignDocument.JohnDoe")
						inputStream.CopyTo(outputStream)
					End Using
				End Using
			End If
		End Sub

		Private Sub LoadDocumentWithStream(ByVal name As String)
			Dim stream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
			Me.radPdfViewer1.LoadDocument(stream)
		End Sub
	End Class
End Namespace
