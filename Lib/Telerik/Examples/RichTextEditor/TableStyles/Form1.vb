Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Linq
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Xaml
Imports Telerik.WinForms.Documents.Model

Namespace RichTextEditor.TableStyles
	Public Partial Class Form1
		Inherits RadRibbonForm
		Private Const SampleDocumentPath As String = "TableStylesGalleryDemo.xaml"

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

                Dim headerFooters As Collections.Generic.List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As Telerik.WinControls.RichTextEditor.UI.HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(SampleDocumentPath)
                Me.radRichTextEditor1.Document = New XamlFormatProvider().Import(stream)
            End Using

            Dim table As Table = Me.radRichTextEditor1.Document.EnumerateChildrenOfType(Of Table)().FirstOrDefault()

            If Not table Is Nothing Then
                Me.radRichTextEditor1.Document.CaretPosition.MoveToStartOfDocumentElement(table)
            End If
        End Sub
	End Class
End Namespace
