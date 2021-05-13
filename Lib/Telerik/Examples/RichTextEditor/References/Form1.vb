Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Xaml
Imports Telerik.WinControls.RichTextEditor.UI

Namespace RichTextEditor.References
    Partial Public Class Form1
        Inherits RadRibbonForm
        Private Const FootnoteDocumentPath As String = "ReferencesFootnote.xaml"
        Private Const EndnoteDocumentPath As String = "ReferencesEndnote.xaml"
        Private Const BibliographyDocumentPath As String = "ReferencesBibliography.xaml"

        Public Sub New()
            InitializeComponent()

            Dim referencesTab As RibbonTab = CType(Me.richTextEditorRibbonBar1.CommandTabs(3), RibbonTab)

            Dim group As RadRibbonBarButtonGroup = New RadRibbonBarButtonGroup()
            group.Orientation = Orientation.Vertical
            group.ShowBackColor = False
            group.ShowBorder = False

            group.Items.Add(Me.CreateButton("Footnotes", AddressOf LoadFootnotes))
            group.Items.Add(Me.CreateButton("EndNotes", AddressOf LoadEndnotes))
            group.Items.Add(Me.CreateButton("Citations && Bibliography", AddressOf LoadBibliography))

            referencesTab.Items.Add(group)

            Dim ribbonGroup As RadRibbonBarGroup = New RadRibbonBarGroup()
            ribbonGroup.Margin = New System.Windows.Forms.Padding(-1, -1, 0, -1)
            ribbonGroup.Orientation = System.Windows.Forms.Orientation.Vertical
            ribbonGroup.Text = "Load document"
            ribbonGroup.Items.Add(group)

            referencesTab.Items.Insert(0, ribbonGroup)

            ThemeResolutionService.ApplicationThemeName = Program.ThemeName
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            LoadDocument(FootnoteDocumentPath)
        End Sub

        Private Function CreateButton(ByVal text As String, ByVal OnClick As EventHandler) As RadButtonElement
            Dim button As RadButtonElement = New RadButtonElement()
            button.DisplayStyle = DisplayStyle.Text
            button.MinSize = New System.Drawing.Size(20, 20)
            button.Text = text
            button.ShowBorder = False
            AddHandler button.Click, OnClick

            Return button
        End Function

        Private Sub LoadFootnotes(ByVal sender As Object, ByVal e As EventArgs)
            LoadDocument(FootnoteDocumentPath)
        End Sub

        Private Sub LoadEndnotes(ByVal sender As Object, ByVal e As EventArgs)
            LoadDocument(EndnoteDocumentPath)
        End Sub

        Private Sub LoadBibliography(ByVal sender As Object, ByVal e As EventArgs)
            LoadDocument(BibliographyDocumentPath)
        End Sub

        Private Sub LoadDocument(ByVal path As String)
            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(path)
                Me.radRichTextEditor1.Document = New XamlFormatProvider().Import(stream)
            End Using

            Me.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = Me.richTextEditorRibbonBar1.RibbonBarElement.TabStripElement.Items(3)

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
    End Class
End Namespace
