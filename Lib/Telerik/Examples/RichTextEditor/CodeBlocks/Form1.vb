Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.RichTextEditor.UI
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders
Imports Telerik.WinForms.Documents.FormatProviders.Xaml
Imports Telerik.WinForms.Documents.Model
Imports Telerik.WinForms.Documents.Model.Code
Imports Telerik.WinForms.Documents.Model.Styles

Namespace RichTextEditor.CodeBlocks
    Partial Public Class Form1
        Inherits RadRibbonForm
        Public Sub New()
            InitializeComponent()

            Me.LoadFile("CodeBlocks.xaml")

            Me.AdjustRibbon()

            Me.AddTagger(Me.radRichTextEditor1.Document)
        End Sub

        Private Sub AdjustRibbon()
            Dim codeButton As RadItem = (CType((CType(Me.richTextEditorRibbonBar1.CommandTabs(1), RibbonTab)).Items(6), RadRibbonBarGroup)).Items(2)
            codeButton.Text = "Code"

            Dim newGroup As RadRibbonBarGroup = New RadRibbonBarGroup()
            newGroup.Margin = New System.Windows.Forms.Padding(-1, -1, 0, -1)

            newGroup.Text = "Insert"
            Dim homeTab As RibbonTab = (CType(Me.richTextEditorRibbonBar1.CommandTabs(0), RibbonTab))
            homeTab.Items.RemoveAt(homeTab.Items.Count - 1)
            homeTab.Items.RemoveAt(homeTab.Items.Count - 1)
            homeTab.Items.Add(newGroup)
            newGroup.Items.Add(codeButton)

        End Sub

        Private Sub LoadFile(ByVal file As String)
            ThemeResolutionService.ApplicationThemeName = Program.ThemeName

            Dim provider As DocumentFormatProviderBase = New XamlFormatProvider()

            Using stream As Stream = GetType(Form1).Assembly.GetManifestResourceStream(file)
                Me.radRichTextEditor1.RichTextBoxElement.Document = provider.Import(stream)
                Me.radRichTextEditor1.RichTextBoxElement.Document.CaretPosition.MoveToLastPositionInDocument()
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

        Private Sub AddTagger(ByVal document As RadDocument)
            Dim vbCodeLanguage As CodeLanguage = New CodeLanguage("VB")

            Dim vbRegexTagger As RegexTagger = GetVbTagger()

            document.CodeFormatter.RegisterCodeLanguage(vbCodeLanguage, vbRegexTagger)

            Dim vbKeywordStyle As StyleDefinition = New StyleDefinition("vbKeywordStyle", StyleType.Character)
            vbKeywordStyle.SpanProperties.ForeColor = Colors.Orange

            document.CodeFormatter.RegisterClassificationType(ClassificationTypes.Keyword, vbCodeLanguage, vbKeywordStyle)
        End Sub

        Private Shared Function GetVbTagger() As RegexTagger
            Dim keywordRegex As Regex = RegexTagger.GetKeywordsRegex(Keywords.Vb)
            Dim preprocessorRegex As Regex = New Regex("^\s*#.*$", RegexOptions.Multiline)
            Dim stringRegex As Regex = New Regex(DefaultRegexPatterns.StringPattern, RegexOptions.Multiline)
            Dim singleCommentRegex As Regex = New Regex(DefaultRegexPatterns.SingleLineCommentPattern, RegexOptions.Multiline)
            Dim multiLineCommentRegex As Regex = New Regex(DefaultRegexPatterns.MultilineCommentPattern, RegexOptions.Multiline)

            Dim collection As Dictionary(Of Regex, ClassificationType) = New Dictionary(Of Regex, ClassificationType)()
            collection.Add(keywordRegex, ClassificationTypes.Keyword)
            collection.Add(preprocessorRegex, ClassificationTypes.PreprocessorKeyword)
            collection.Add(stringRegex, ClassificationTypes.StringLiteral)
            collection.Add(singleCommentRegex, ClassificationTypes.Comment)
            collection.Add(multiLineCommentRegex, ClassificationTypes.Comment)

            Dim regexVbTagger As RegexTagger = New RegexTagger(collection)

            Return regexVbTagger
        End Function
    End Class
End Namespace
