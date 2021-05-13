Imports System.IO
Imports System.Reflection
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.PdfViewer.FirstLook
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radPDFCommandBar1.MinimumSize = New Size(0, 60)
            Dim stream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Sample.pdf")
            Me.radPdfViewer1.LoadDocument(stream)
            Me.radPdfViewer1.ShowThumbnails()
        End Sub
	End Class
End Namespace