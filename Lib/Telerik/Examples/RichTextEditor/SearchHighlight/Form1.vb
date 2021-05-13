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
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.Model
Imports System

Namespace RichTextEditor.SearchHighlight
    Partial Public Class Form1
        Inherits RadForm
        Private Const SampleDocumentPath As String = "RadRichTextBoxCustomizePresentation.xaml"

        Private radDocument As RadDocument
        Private customLayersBuilder As CustomLayersBuilder

        Public Sub New()
            InitializeComponent()

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName

            Me.LoadRadDocument()
            Me.customLayersBuilder = New CustomLayersBuilder() With { _
                 .HighlightCurrentWord = True, _
                 .HighlightSearchResult = True _
            }
            Me.radRichTextEditor1.RichTextBoxElement.UILayersBuilder = Me.customLayersBuilder

            AddHandler toggleButtonSearchResults.ToggleStateChanged, AddressOf toggleButtonSearchResults_ToggleStateChanged
            AddHandler toggleButtonCurrentWord.ToggleStateChanged, AddressOf toggleButtonCurrentWord_ToggleStateChanged
            AddHandler toggleButtonCurrentLine.ToggleStateChanged, AddressOf toggleButtonCurrentLine_ToggleStateChanged

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

        Private Sub LoadRadDocument()
            Me.radDocument = Me.ImportRadDocument(SampleDocumentPath)
            Me.SetupNewDocument(Me.radDocument)
            Me.radRichTextEditor1.Document = Me.radDocument
        End Sub

        Private Function ImportRadDocument(radDocumentPath As String) As RadDocument
            Dim currentRadDocument As RadDocument
            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(radDocumentPath)
                Dim xamlProvider As IDocumentFormatProvider = DocumentFormatProvidersManager.GetProviderByExtension(".xaml")
                currentRadDocument = xamlProvider.Import(stream)
            End Using

            Return currentRadDocument
        End Function

        Private Sub RecreateUI()
            If Me.radRichTextEditor1.RichTextBoxElement.ActiveEditorPresenter IsNot Nothing Then
                Me.radRichTextEditor1.RichTextBoxElement.ActiveEditorPresenter.RecreateUI()
                Me.radRichTextEditor1.UpdateEditorLayout()
            End If
        End Sub

        Private Sub SetupNewDocument(document As RadDocument)
            document.LayoutMode = DocumentLayoutMode.Paged
            document.ParagraphDefaultSpacingAfter = 10
            document.SectionDefaultPageMargin = New Telerik.WinForms.Documents.Layout.Padding(40)
        End Sub

        Private Sub textToSearch_TextChanged(sender As Object, e As EventArgs) Handles commandBarTextBox1.TextChanged
            If Me.customLayersBuilder.HighlightSearchResult Then
                HighlightSearchedWordLayer.Word = Me.commandBarTextBox1.Text
                Me.radRichTextEditor1.UpdateEditorLayout()
            End If
        End Sub

        Private Sub toggleButtonSearchResults_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.customLayersBuilder.HighlightSearchResult = Me.toggleButtonSearchResults.CheckState = CheckState.Checked
            Me.RecreateUI()
        End Sub

        Private Sub toggleButtonCurrentWord_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.customLayersBuilder.HighlightCurrentWord = Me.toggleButtonCurrentWord.CheckState = CheckState.Checked
            Me.RecreateUI()
        End Sub

        Private Sub toggleButtonCurrentLine_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            Me.customLayersBuilder.HighlightCurrentLine = Me.toggleButtonCurrentLine.CheckState = CheckState.Checked
            Me.RecreateUI()
        End Sub
    End Class
End Namespace