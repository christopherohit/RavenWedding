Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PdfViewer.DigitalSignatures
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

            Me.LoadDocumentWithStream("Unknown.pdf")
            Me.radPdfViewerNavigator1.MinimumSize = New Size(0, 60)
		End Sub

		Protected Overrides Sub WireEvents()
			MyBase.WireEvents()

			AddHandler Me.invalidSignatureRadioButton.ToggleStateChanged, AddressOf OnRadioButtonToggleStateChanged
			AddHandler Me.unknownSignatureRadioButton.ToggleStateChanged, AddressOf OnRadioButtonToggleStateChanged
			AddHandler Me.openDocumentButton.Click, AddressOf OnOpenDocumentButtonClick
		End Sub

		Private Sub OnRadioButtonToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
			If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
				Return
			End If

			If Me.invalidSignatureRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.LoadDocumentWithStream("Invalid.pdf")
            Else
                Me.LoadDocumentWithStream("Unknown.pdf")
            End If
		End Sub

		Private Sub OnOpenDocumentButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim path As String = ""
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
			dialog.Title = "Select a PDF file"
			If dialog.ShowDialog() = DialogResult.OK Then
				path = dialog.FileName
				Me.radPdfViewer1.LoadDocument(path)

				Me.invalidSignatureRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
				Me.unknownSignatureRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			End If
		End Sub

		Private Sub LoadDocumentWithStream(ByVal name As String)
			Dim stream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
			Me.radPdfViewer1.LoadDocument(stream)
		End Sub
	End Class
End Namespace
