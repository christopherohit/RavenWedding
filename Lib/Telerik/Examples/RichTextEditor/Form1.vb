
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx
Imports Telerik.WinForms.Documents.FormatProviders.Txt

Namespace RichTextEditor
	Public Partial Class Form1
		Inherits RadRibbonForm
		Public Sub New()
			InitializeComponent()
			New Office2013LightTheme()
			ThemeResolutionService.ApplicationThemeName = "Office2013Light"
			Me.LoadFile(New FileInfo(Application.StartupPath & "\overview.docx"))
		End Sub

		Private Sub LoadFile(fileToLoad As FileInfo)
			Dim provider As DocumentFormatProviderBase = Nothing

			If fileToLoad.Extension = ".docx" Then
				provider = New DocxFormatProvider()
			ElseIf fileToLoad.Extension = ".txt" Then
				provider = New TxtFormatProvider()
			End If

			Dim stream As FileStream = File.Open(fileToLoad.Name, FileMode.Open)
			Me.radRichTextEditor1.RichTextBoxElement.Document = provider.Import(stream)
			stream.Close()
		End Sub
	End Class
End Namespace