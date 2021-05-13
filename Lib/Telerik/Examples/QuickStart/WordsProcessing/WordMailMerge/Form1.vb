Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Forms
Imports System.Windows.Media
Imports Telerik.Windows.Documents.Common.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders.Pdf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Docx
Imports Telerik.Windows.Documents.Flow.FormatProviders.Html
Imports Telerik.Windows.Documents.Flow.FormatProviders.Rtf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Txt
Imports Telerik.Windows.Documents.Flow.Model
Imports Telerik.Windows.Documents.Flow.Model.Editing
Imports Telerik.Windows.Documents.Flow.Model.Styles
Imports Telerik.Windows.Documents.Spreadsheet.Model
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.WordsProcessing.WordMailMerge
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private Shared ReadOnly greenColor As ThemableColor = New ThemableColor(System.Windows.Media.Color.FromArgb(255, 92, 230, 0))
        Private m_exportFormats As IEnumerable(Of String)

        Public Sub New()
            InitializeComponent()
            pictureBox1.Image = Image.FromFile("..\WordsProcessing\WordMailMerge\Images\MailMergeThumbnail.png")
            radDropDownList1.DataSource = ExportFormats
            radDropDownList1.SelectedIndex = 1
            AddHandler radDropDownList1.SelectedIndexChanged, AddressOf RadDropDownList1_SelectedIndexChanged
            Me.SelectedExportFormat = radDropDownList1.SelectedItem.Text
        End Sub

        Public Property SelectedExportFormat As String

        Public ReadOnly Property ExportFormats() As IEnumerable(Of String)
            Get
                If Me.m_exportFormats Is Nothing Then
                    m_exportFormats = New String() {"Docx", "Rtf", "Txt"}
                End If

                Return Me.m_exportFormats
            End Get
        End Property

        Private Sub RadDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.SelectedExportFormat = radDropDownList1.SelectedItem.Text
        End Sub

        Private Sub MailMerge()
            Dim document As RadFlowDocument = Me.CreateDocument()
            Dim mailMergeDocument As RadFlowDocument = document.MailMerge(Person.Persons)
            mailMergeDocument.DocumentVariables.Add("sender", "Telerik Team")
            mailMergeDocument.UpdateFields()
            Dim selectedFromat As String = Me.SelectedExportFormat
            SaveDocument(mailMergeDocument, selectedFromat)
        End Sub

        Public Shared Function SaveDocument(ByVal document As RadFlowDocument, ByVal selectedFormat As String) As Boolean
            Dim formatProvider As IFormatProvider(Of RadFlowDocument) = Nothing

            Select Case selectedFormat
                Case "Docx"
                    formatProvider = New DocxFormatProvider()
                Case "Rtf"
                    formatProvider = New RtfFormatProvider()
                Case "Html"
                    formatProvider = New HtmlFormatProvider()
                Case "Txt"
                    formatProvider = New TxtFormatProvider()
                Case "Pdf"
                    formatProvider = New PdfFormatProvider()
            End Select

            If formatProvider Is Nothing Then
                Return False
            End If

            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.FileName = "Result"
            dialog.Filter = String.Format("{0} files|*{1}|All files (*.*)|*.*", selectedFormat, formatProvider.SupportedExtensions.First())
            dialog.FilterIndex = 1

            If dialog.ShowDialog() = DialogResult.OK Then

                Using stream As Stream = dialog.OpenFile()
                    formatProvider.Export(document, stream)
                End Using

                Return True
            Else
                Return False
            End If
        End Function

        Private Function CreateDocument() As RadFlowDocument
            Dim document As RadFlowDocument = New RadFlowDocument()
            Dim editor As RadFlowDocumentEditor = New RadFlowDocumentEditor(document)
            editor.ParagraphFormatting.TextAlignment.LocalValue = Alignment.Justified
            Dim paragraphWithText As Paragraph = editor.InsertParagraph()
            editor.MoveToParagraphStart(paragraphWithText)
            editor.InsertText("Dear ")
            editor.InsertField("MERGEFIELD FirstName", "")
            editor.InsertText(" ")
            editor.InsertField("MERGEFIELD LastName", "")
            editor.InsertLine(",")
            editor.InsertLine("We're happy to introduce the new Telerik RadWordsProcessing component for WPF. High performance library that enables you to read, write and manipulate documents in DOCX, RTF, HTML and plain text format.")
            editor.InsertText("The current beta version comes with full rich-text capabilities including ")
            editor.InsertText("bold, ").FontWeight = FontWeights.Bold
            editor.InsertText("italic, ").FontStyle = FontStyles.Italic
            Dim underlined As Run = editor.InsertText("underline,")
            underlined.Underline.Pattern = UnderlinePattern.Dotted
            underlined.Underline.Color = New ThemableColor(Colors.Black)
            editor.InsertText(" font sizes and ").FontSize = 20
            editor.InsertText("colors ").ForegroundColor = greenColor
            editor.InsertLine("as well as text alignment and indentation. Other options include tables, lists, hyperlinks, bookmarks and comments, inline and floating images. Even more sweetness is added by the built-in styles and themes.")
            editor.InsertLine("We hope you'll enjoy RadWordsProcessing as much as we do. Happy coding!")
            editor.InsertParagraph().Spacing.SpacingAfter = 0
            editor.InsertLine("Regards,")
            editor.InsertField("DOCVARIABLE sender", "")
            editor.InsertParagraph()
            File.SetAttributes("..\WordsProcessing\WordMailMerge\Images\TelerikLogoSmall.png", FileAttributes.Normal)

            Using stream As Stream = New FileStream("..\WordsProcessing\WordMailMerge\Images\TelerikLogoSmall.png", FileMode.Open)
                editor.InsertImageInline(stream, "png", New System.Windows.Size(93, 42))
            End Using

            Return document
        End Function

        Private Sub mailMergeButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.MailMerge()
        End Sub
    End Class
End Namespace
