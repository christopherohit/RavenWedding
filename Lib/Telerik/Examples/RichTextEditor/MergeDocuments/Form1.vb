Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx
Imports Telerik.WinForms.Documents.Model

Namespace RichTextEditor.MergeDocuments
	Public Partial Class Form1
		Inherits RadForm
		Private isFirst As Boolean = True

		Public Sub New()
			InitializeComponent()
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName

            AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized
        End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As Telerik.WinControls.RichTextEditor.UI.UIElement In e.Container.Children
                    element.BackColor = Telerik.WinControls.RichTextEditor.UI.Colors.White
                Next

                Dim headerFooters As List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub

		Private Function LoadDocumentToInsert() As RadDocument
			Dim document As RadDocument = Nothing

			Dim ofd As OpenFileDialog = New OpenFileDialog()
			ofd.Filter = "Word Documents (*.docx)|*.docx|All Files (*.*)|*.*"

			If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim extension As String

				extension = Path.GetExtension(ofd.SafeFileName).ToLower()
				Dim provider As IDocumentFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension(extension)

				Using stream As Stream = ofd.OpenFile()
					document = provider.Import(stream)
				End Using
			End If

			Return document
		End Function

		Private Function LoadFile(ByVal file As String) As RadDocument
			Dim provider As DocumentFormatProviderBase = New DocxFormatProvider()
			Dim document As RadDocument = Nothing

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                document = provider.Import(stream)
            End Using

			Return document
		End Function

		Private Sub InsertFragmentFromDocument(ByVal document As RadDocument)
			If Not document Is Nothing Then
				If isFirst Then
					isFirst = False
				Else
					Me.radRichTextEditor1.InsertSectionBreak(SectionBreakType.NextPage)
				End If

				document.Selection.SelectAll()
				Dim frag As DocumentFragment = New DocumentFragment(document.Selection)
				radRichTextEditor1.InsertFragment(frag)

				CopySectionProperties(document, radRichTextEditor1.Document)
			End If
		End Sub

		Private Shared Sub CopySectionProperties(ByVal fromDocument As RadDocument, ByVal toDocument As RadDocument)
			CopyHeaderAndFooter(fromDocument, toDocument)

			Dim documentEditor As RadDocumentEditor = New RadDocumentEditor(toDocument)
			documentEditor.Document.CaretPosition.MoveToLastPositionInDocument()

			documentEditor.ChangeSectionPageOrientation(fromDocument.Sections.Last.PageOrientation)
			documentEditor.ChangeSectionPageSize(fromDocument.Sections.Last.PageSize)
			documentEditor.ChangeSectionPageMargin(fromDocument.Sections.Last.PageMargin)
			documentEditor.ChangeSectionFooterBottomMargin(fromDocument.Sections.Last.FooterBottomMargin)
			documentEditor.ChangeSectionHeaderTopMargin(fromDocument.Sections.Last.HeaderTopMargin)
		End Sub

		Private Shared Sub CopyHeaderAndFooter(ByVal fromDocument As RadDocument, ByVal toDocument As RadDocument)
			Dim documentEditor As RadDocumentEditor = New RadDocumentEditor(toDocument)

			documentEditor.ChangeSectionHeaderLinkToPrevious(documentEditor.Document.Sections.Last, HeaderFooterType.Default, False)
			If (Not fromDocument.Sections.First.Headers.Default.IsEmpty) Then
				documentEditor.ChangeSectionHeader(documentEditor.Document.Sections.Last, HeaderFooterType.Default, fromDocument.Sections.Last.Headers.Default)
			End If

			documentEditor.ChangeSectionFooterLinkToPrevious(documentEditor.Document.Sections.Last, HeaderFooterType.Default, False)
			If (Not fromDocument.Sections.First.Footers.Default.IsEmpty) Then
				documentEditor.ChangeSectionFooter(documentEditor.Document.Sections.Last, HeaderFooterType.Default, fromDocument.Sections.Last.Footers.Default)
			End If
		End Sub

		Private Sub browseMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseMenuItem.Click
			InsertFragmentFromDocument(LoadDocumentToInsert())
		End Sub

		Private Sub loadDocument2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadDocument2.Click
			InsertFragmentFromDocument(LoadFile("sampleDoc.docx"))
		End Sub

		Private Sub loadDocument1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadDocument1.Click
			InsertFragmentFromDocument(LoadFile("overview.docx"))
		End Sub

		Private Sub clearDocument_Click(ByVal sender As Object, ByVal e As EventArgs) Handles commandBarButtonClear.Click
			isFirst = True
            Me.radRichTextEditor1.Document = New RadDocument()
		End Sub
	End Class
End Namespace
