Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports Telerik.Examples.WinControls.Editors
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Controls.SyntaxEditor.Palettes
Imports Telerik.WinForms.Controls.SyntaxEditor.Taggers
Imports Telerik.WinForms.SyntaxEditor.Core.Tagging
Imports Telerik.WinForms.SyntaxEditor.Core.Text

Namespace Telerik.Examples.WinControls.SyntaxEditor.FirstLook
    Partial Public Class Form1
        Inherits EditorExampleBaseForm

        Private foldingTagger As FoldingTaggerBase
        Private selectionWordTagger As TextSearchHighlightTagger
        Private currentLanguageTagger As TaggerBase(Of ClassificationTag)
        Private openFolderDialog As RadOpenFolderDialog
        Private supportedFileExtensions As List(Of String) = New List(Of String)() From {
            ".cs",
            ".vb",
            ".js",
            ".xaml",
            ".xml",
            "html",
            ".sql",
            ".csproj",
            ".user",
            ".cpp",
            ".txt",
            ".config",
            ".resx",
            ".settings",
            ".sln",
            ".licx"
        }
        Private usingFileSystem As Boolean = False

        Public Sub New()
            Me.InitializeComponent()
            Me.CenterPanel = True
            Me.radButton1.ButtonElement.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.documentWindow1.AllowedDockState = Telerik.WinControls.UI.Docking.AllowedDockState.TabbedDocument
            Me.openFolderDialog = New RadOpenFolderDialog()
            Me.openFolderDialog.ShowNetworkLocations = False
            openFolderDialog.OpenFolderDialogForm.Text = "Open Directory"
            ExampleHelper.PopulateTreeView(Me.treeView)
            Me.foldingTagger = New CSharpFoldingTagger(Me.syntaxEditor.SyntaxEditorElement)
            Me.selectionWordTagger = New TextSearchHighlightTagger(Me.syntaxEditor.SyntaxEditorElement, TextSearchHighlightTagger.SearchFormatDefinition)
            Me.syntaxEditor.TaggersRegistry.RegisterTagger(foldingTagger)
            Me.syntaxEditor.TaggersRegistry.RegisterTagger(Me.selectionWordTagger)
            AddHandler Me.syntaxEditor.SyntaxEditorElement.Selection.SelectionChanged, AddressOf Selection_SelectionChanged
            AddHandler Me.treeView.SelectedNodeChanged, AddressOf Me.TreeView_SelectionChanged
        End Sub

        Public Overrides Sub OnThemeChanged()
            MyBase.OnThemeChanged()

            If TelerikHelper.IsDarkTheme(Me.CurrentThemeName) Then
                Me.syntaxEditor.Palette = SyntaxPalettes.NeutralDark
            Else
                Me.syntaxEditor.Palette = SyntaxPalettes.Light
            End If

            If Not Me.usingFileSystem Then
                Me.treeView.ExpandAll()
            End If

            If Me.openFolderDialog IsNot Nothing Then
                Me.openFolderDialog.OpenFolderDialogForm.ThemeName = Me.CurrentThemeName
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Me.treeView.ExpandAll()
            Me.treeView.SelectedNode = Me.treeView.Nodes(0).Nodes(0)
            Me.openFolderDialog.OpenFolderDialogForm.ThemeName = Me.CurrentThemeName
        End Sub

        Private Sub RegisterTagger(ByVal fileName As String)
            Me.UnregisterTaggers()
            Dim extension As String = Path.GetExtension(fileName)

            Select Case extension
                Case ".cs"
                    Me.currentLanguageTagger = New CSharpTagger(Me.syntaxEditor.SyntaxEditorElement)
                    Me.ClearXmlFormatDefinitions()
                    Me.foldingTagger = New CSharpFoldingTagger(Me.syntaxEditor.SyntaxEditorElement)
                Case ".cpp"
                    Me.currentLanguageTagger = New CSharpTagger(Me.syntaxEditor.SyntaxEditorElement)
                    Me.ClearXmlFormatDefinitions()
                    Me.foldingTagger = New BracketFoldingTagger(Me.syntaxEditor.SyntaxEditorElement)
                Case ".vb"
                    Me.currentLanguageTagger = New VisualBasicTagger(Me.syntaxEditor.SyntaxEditorElement)
                    Me.ClearXmlFormatDefinitions()
                    Me.foldingTagger = New VisualBasicFoldingTagger(Me.syntaxEditor.SyntaxEditorElement)
                Case ".js"
                    Me.currentLanguageTagger = New JavaScriptTagger(Me.syntaxEditor.SyntaxEditorElement)
                    Me.ClearXmlFormatDefinitions()
                    Me.foldingTagger = New JavaScriptFoldingTagger(Me.syntaxEditor.SyntaxEditorElement)
                Case ".sql"
                    Me.currentLanguageTagger = New SqlTagger(Me.syntaxEditor.SyntaxEditorElement)
                    Me.ClearXmlFormatDefinitions()

                    If Me.syntaxEditor.TaggersRegistry.IsTaggerRegistered(Me.foldingTagger) Then
                        Me.syntaxEditor.TaggersRegistry.UnregisterTagger(Me.foldingTagger)
                    End If

                Case ".xaml", ".xml", ".licx", ".html", ".csproj", ".vbproj", ".user", ".config", ".resx", ".settings", ".sln"
                    Me.currentLanguageTagger = New XmlTagger(Me.syntaxEditor.SyntaxEditorElement)
                    Me.AddXmlFormatDefinitions()
                    Me.foldingTagger = New XmlFoldingTagger(Me.syntaxEditor.SyntaxEditorElement)
                Case Else
                    Me.ClearXmlFormatDefinitions()
                    Me.currentLanguageTagger = Nothing

                    If Me.syntaxEditor.TaggersRegistry.IsTaggerRegistered(Me.foldingTagger) Then
                        Me.syntaxEditor.TaggersRegistry.UnregisterTagger(Me.foldingTagger)
                    End If
            End Select

            If Me.currentLanguageTagger IsNot Nothing Then
                Me.syntaxEditor.TaggersRegistry.RegisterTagger(Me.currentLanguageTagger)
            End If

            If Me.foldingTagger IsNot Nothing Then
                Me.syntaxEditor.TaggersRegistry.RegisterTagger(Me.foldingTagger)
            End If
        End Sub

        Private Sub UnregisterTaggers()
            If Me.currentLanguageTagger IsNot Nothing AndAlso Me.syntaxEditor.TaggersRegistry.IsTaggerRegistered(Me.currentLanguageTagger) Then
                Me.syntaxEditor.TaggersRegistry.UnregisterTagger(Me.currentLanguageTagger)
            End If

            If Me.foldingTagger IsNot Nothing AndAlso Me.syntaxEditor.TaggersRegistry.IsTaggerRegistered(Me.foldingTagger) Then
                Me.syntaxEditor.TaggersRegistry.UnregisterTagger(Me.foldingTagger)
                Me.foldingTagger = Nothing
            End If
        End Sub

        Private Sub AddXmlFormatDefinitions()
            Me.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlAttribute, XmlSyntaxHighlightingHelper.XmlAttributeFormatDefinition)
            Me.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlElement, XmlSyntaxHighlightingHelper.XmlElementFormatDefinition)
            Me.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlComment, XmlSyntaxHighlightingHelper.XmlCommentFormatDefinition)
            Me.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlContent, XmlSyntaxHighlightingHelper.XmlContentFormatDefinition)
            Me.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlString, XmlSyntaxHighlightingHelper.XmlStringFormatDefinition)
            Me.syntaxEditor.TextFormatDefinitions.AddLast(XmlSyntaxHighlightingHelper.XmlTag, XmlSyntaxHighlightingHelper.XmlTagFormatDefinition)
        End Sub

        Private Sub ClearXmlFormatDefinitions()
            Me.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlAttribute)
            Me.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlElement)
            Me.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlComment)
            Me.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlContent)
            Me.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlString)
            Me.syntaxEditor.TextFormatDefinitions.Remove(XmlSyntaxHighlightingHelper.XmlTag)
        End Sub

        Private treeItems As ObservableCollection(Of FileInfo)

        Private Sub LoadDirectory(ByVal directoryPath As String)
            Me.treeView.Nodes.Clear()
            Me.treeView.DataSource = Nothing
            Me.usingFileSystem = True
            Me.treeView.LazyMode = False
            Dim directory As DirectoryInfo = New DirectoryInfo(directoryPath, Path.GetDirectoryName(directoryPath))
            directory.LoadChildren()
            Me.treeItems = directory.Children
            RemoveHandler Me.treeView.NodesNeeded, AddressOf Me.TreeView_NodesNeeded
            AddHandler Me.treeView.NodesNeeded, AddressOf Me.TreeView_NodesNeeded
        End Sub

        Private Sub TreeView_NodesNeeded(ByVal sender As Object, ByVal e As NodesNeededEventArgs)
            If e.Parent Is Nothing Then

                For Each item As FileInfo In Me.treeItems
                    Dim mcNode As RadTreeNode = New RadTreeNode(item.Name) With {
                        .Tag = item
                    }
                    e.Nodes.Add(mcNode)
                Next

                Return
            End If

            If e.Parent IsNot Nothing Then
                Dim parent As DirectoryInfo = TryCast(e.Parent.Tag, DirectoryInfo)

                If parent IsNot Nothing Then
                    parent.LoadChildren()

                    For Each item As FileInfo In parent.Children
                        Dim mcNode As RadTreeNode = New RadTreeNode(item.Name) With {
                            .Tag = item
                        }
                        e.Nodes.Add(mcNode)
                    Next
                End If
            End If
        End Sub

        Private Sub LoadFile(ByVal fileName As String)
            If usingFileSystem Then

                Try

                    Using stream As FileStream = New FileStream(fileName, FileMode.Open)
                        Dim reader As StreamReader = New StreamReader(stream, Encoding.UTF8)
                        Me.syntaxEditor.Document = New TextDocument(reader)
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else

                Using stream As Stream = GetResourceStream(fileName)
                    Dim reader As StreamReader = New StreamReader(stream, Encoding.UTF8)
                    Me.syntaxEditor.Document = New TextDocument(reader)
                End Using
            End If

            Me.RegisterTagger(fileName)
        End Sub

        Protected Shared Function GetResourceStream(ByVal resourcePath As String) As Stream
            Dim assembly As Assembly = Assembly.GetExecutingAssembly()
            Dim resourceNames As List(Of String) = New List(Of String)(assembly.GetManifestResourceNames())
            resourcePath = resourceNames.FirstOrDefault(Function(r) r.EndsWith(resourcePath))

            If resourcePath Is Nothing Then
                Throw New FileNotFoundException("Resource not found")
            End If

            Return assembly.GetManifestResourceStream(resourcePath)
        End Function

        Private Sub TreeView_SelectionChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
            If e.Node Is Nothing Then
                Return
            End If

            Dim file As FileInfo = Nothing

            If Not Me.usingFileSystem Then
                file = TryCast(e.Node.DataBoundItem, FileInfo)
            Else
                file = TryCast(e.Node.Tag, FileInfo)
            End If

            If file Is Nothing Then
                Return
            End If

            Dim d As DirectoryInfo = TryCast(file, DirectoryInfo)

            If d IsNot Nothing AndAlso d.Children.Count > 0 Then
                Return
            End If

            If Me.supportedFileExtensions.Contains(Path.GetExtension(file.FullPath)) Then
                Me.LoadFile(file.FullPath)
                Me.documentWindow1.Text = file.Name
                Me.syntaxEditor.Visible = True
                Me.infoLabel.Visible = False
            Else
                Me.syntaxEditor.Visible = False
                Me.infoLabel.Visible = True
            End If
        End Sub

        Private Sub RadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
            If Me.openFolderDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim selectedFolder As String = Me.openFolderDialog.FileName

                If Not String.IsNullOrEmpty(selectedFolder) Then

                    If Me.syntaxEditor IsNot Nothing Then
                        Me.documentWindow1.Text = Me.openFolderDialog.SafeFileNames.FirstOrDefault()
                        Me.syntaxEditor.Document = New TextDocument()
                    End If

                    Me.UnregisterTaggers()
                    Me.LoadDirectory(selectedFolder)
                End If
            End If
        End Sub

        Private Sub Selection_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.syntaxEditor.SyntaxEditorElement.Selection.IsEmpty Then
                Dim searchedWord As String = Me.syntaxEditor.SyntaxEditorElement.Selection.GetSelectedText()

                If Not String.IsNullOrWhiteSpace(searchedWord) Then
                    Me.selectionWordTagger.UpdateSearchWord(searchedWord)
                End If
            Else
                Me.selectionWordTagger.UpdateSearchWord(String.Empty)
            End If
        End Sub
    End Class
End Namespace
