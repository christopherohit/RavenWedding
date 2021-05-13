Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Flow.Model
Imports Telerik.Windows.Documents.Flow.Model.Editing
Imports Telerik.Windows.Documents.Flow.Model.Styles
Imports Telerik.Windows.Documents.Spreadsheet.Model

Namespace Telerik.Examples.WinControls.WordsProcessing.WordGeneration
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private m_exportFormats As IEnumerable(Of String)
        Private Shared ReadOnly GreenColor As ThemableColor = ThemableColor.FromArgb(255, 92, 230, 0)
        Public Property IncludeHeader As Boolean
        Public Property IncludeFooter As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.exportFormatDropDownList.DataSource = ExportFormats
            Me.exportFormatDropDownList.SelectedIndex = 0
            Me.IncludeHeader = True
            Me.IncludeFooter = True
        End Sub

        Public ReadOnly Property ExportFormats() As IEnumerable(Of String)
            Get
                If Me.m_exportFormats Is Nothing Then
                    m_exportFormats = New String() {"Docx", "Rtf", "Txt"}
                End If

                Return Me.m_exportFormats
            End Get
        End Property

        Private Sub exportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim document As RadFlowDocument = Me.CreateDocument()
            Dim selectedFromat As String = Me.exportFormatDropDownList.Text
            FileHelper.SaveDocument(document, selectedFromat)
        End Sub

        Private Sub Generate(ByVal obj As Object)
            Dim document As RadFlowDocument = Me.CreateDocument()
            Dim selectedFromat As String = Me.exportFormatDropDownList.Text
            FileHelper.SaveDocument(document, selectedFromat)
        End Sub

        Private Function CreateDocument() As RadFlowDocument
            Dim document As RadFlowDocument = New RadFlowDocument()
            Dim editor As RadFlowDocumentEditor = New RadFlowDocumentEditor(document)
            editor.ParagraphFormatting.TextAlignment.LocalValue = Alignment.Justified
            editor.InsertLine("Dear Telerik User,")
            editor.InsertText("We’re happy to introduce the new Telerik RadWordsProcessing component for WPF. High performance library that enables you to read, write and manipulate documents in DOCX, RTF and plain text format. The document model is independent from UI and ")
            Dim run As Run = editor.InsertText("does not require")
            run.Underline.Pattern = UnderlinePattern.Single
            editor.InsertLine(" Microsoft Office.")
            editor.InsertText("The current community preview version comes with full rich-text capabilities including ")
            editor.InsertText("bold, ").FontWeight = FontWeights.Bold
            editor.InsertText("italic, ").FontStyle = FontStyles.Italic
            editor.InsertText("underline,").Underline.Pattern = UnderlinePattern.Single
            editor.InsertText(" font sizes and ").FontSize = 20
            editor.InsertText("colors ").ForegroundColor = GreenColor
            editor.InsertLine("as well as text alignment and indentation. Other options include tables, hyperlinks, inline and floating images. Even more sweetness is added by the built-in styles and themes.")
            editor.InsertText("Here at Telerik we strive to provide the best services possible and fulfill all needs you as a customer may have. We would appreciate any feedback you send our way through the ")
            editor.InsertHyperlink("public forums", "http://www.telerik.com/forums", False, "Telerik Forums")
            editor.InsertLine(" or support ticketing system.")
            editor.InsertLine("We hope you’ll enjoy RadWordsProcessing as much as we do. Happy coding!")
            editor.InsertParagraph()
            editor.InsertText("Kind regards,")
            Me.CreateSignature(editor)
            Me.CreateHeader(editor)
            Me.CreateFooter(editor)
            Return document
        End Function

        Private Sub CreateSignature(ByVal editor As RadFlowDocumentEditor)
            Dim signatureTable As Table = editor.InsertTable(1, 2)
            signatureTable.Rows(0).Cells(0).Borders = New TableCellBorders(New Border(Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.None), New Border(Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.None), New Border(4, Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.Single, GreenColor), New Border(Telerik.Windows.Documents.Flow.Model.Styles.BorderStyle.None))
            signatureTable.Rows(0).Cells(0).PreferredWidth = New TableWidthUnit(140)
            Dim paragraphWithImage As Paragraph = signatureTable.Rows(0).Cells(0).Blocks.AddParagraph()
            paragraphWithImage.Spacing.SpacingAfter = 0
            editor.MoveToParagraphStart(paragraphWithImage)

            Using stream As Stream = FileHelper.GetSampleResourceStream("progress-logo.png")
                editor.InsertImageInline(stream, "png", New System.Windows.Size(120, 29))
            End Using

            signatureTable.Rows(0).Cells(1).PreferredWidth = New TableWidthUnit(100)
            signatureTable.Rows(0).Cells(1).Padding = New Telerik.Windows.Documents.Primitives.Padding(12, 0, 0, 0)
            Dim cellParagraph As Paragraph = signatureTable.Rows(0).Cells(1).Blocks.AddParagraph()
            cellParagraph.Spacing.SpacingAfter = 0
            editor.MoveToParagraphStart(cellParagraph)
            editor.CharacterFormatting.FontSize.LocalValue = 12
            editor.InsertText("Jane Doe").FontWeight = FontWeights.Bold
            editor.InsertParagraph().Spacing.SpacingAfter = 0
            editor.InsertText("Support Officer")
        End Sub

        Private Sub CreateFooter(ByVal editor As RadFlowDocumentEditor)
            If Me.IncludeFooter Then
                Dim footer As Footer = editor.Document.Sections.First().Footers.Add()
                Dim paragraph As Paragraph = footer.Blocks.AddParagraph()
                paragraph.TextAlignment = Alignment.Right
                editor.MoveToParagraphStart(paragraph)
                editor.InsertHyperlink("telerik.com", "http://www.telerik.com", False, "Telerik Site")
            End If
        End Sub

        Private Sub CreateHeader(ByVal editor As RadFlowDocumentEditor)
            If Me.IncludeHeader Then
                Dim header As Header = editor.Document.Sections.First().Headers.Add()
                editor.MoveToParagraphStart(header.Blocks.AddParagraph())

                Using stream As Stream = FileHelper.GetSampleResourceStream("progress-big-logo.png")
                    editor.InsertImageInline(stream, "png", New System.Windows.Size(660, 222))
                End Using
            End If
        End Sub

        Private Sub radCheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.IncludeHeader = Me.radCheckBox1.Checked
        End Sub

        Private Sub radCheckBox2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.IncludeFooter = Me.radCheckBox1.Checked
        End Sub
    End Class
End Namespace
