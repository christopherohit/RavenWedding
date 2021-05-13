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
Imports Telerik.WinControls.Themes
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx
Imports Telerik.WinForms.Documents.FormatProviders.Txt
Imports Telerik.WinControls.RichTextEditor.UI

Namespace RichTextEditor.FirstLook
    Partial Public Class Form1
        Inherits RadRibbonForm
        Public Sub New()
            InitializeComponent()
            Me.LoadFile("overview.docx")
        End Sub

        Private Sub LoadFile(ByVal file As String)
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName
            Dim provider As DocumentFormatProviderBase = New DocxFormatProvider()

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                Me.radRichTextEditor1.Document = provider.Import(stream)
            End Using

            AddHandler Me.radRichTextEditor1.ProviderUILayerInitialized, AddressOf radRichTextEditor1_ProviderUILayerInitialized
        End Sub

        Private Sub radRichTextEditor1_ProviderUILayerInitialized(sender As Object, e As ProviderUILayerInitilizedEventArgs)
            If e.Layer.Name = "PagesLayer" Then
                For Each element As Telerik.WinControls.RichTextEditor.UI.UIElement In e.Container.Children
                    element.BackColor = Colors.White
                Next

                Dim headerFooters As List(Of RadElement) = Me.radRichTextEditor1.RichTextBoxElement.GetDescendants(Function(x As RadElement) TypeOf x Is HeaderFooterContainer, TreeTraversalMode.BreadthFirst)
                For Each container As HeaderFooterContainer In headerFooters
                    container.OverlayColor = System.Drawing.Color.FromArgb(128, 255, 255, 255)
                Next
            End If
        End Sub

    End Class
End Namespace
