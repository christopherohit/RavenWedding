Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports Telerik.QuickStart.WinControls
Imports System.Reflection
Imports System.IO

Namespace Telerik.Examples.WinControls.PdfViewer.InteractiveForms
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

            Me.LoadDocumentWithStream("InteractiveForms.pdf")
            Me.radPdfViewerNavigator1.MinimumSize = New Size(0, 60)
		End Sub

		Private Sub LoadDocumentWithStream(ByVal name As String)
			Dim stream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(name)
			Me.radPdfViewer1.LoadDocument(stream)
		End Sub
	End Class
End Namespace
