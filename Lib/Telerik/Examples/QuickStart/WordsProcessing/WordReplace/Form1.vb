Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Windows.Documents.Common.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders.Pdf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Docx
Imports Telerik.Windows.Documents.Flow.FormatProviders.Html
Imports Telerik.Windows.Documents.Flow.FormatProviders.Rtf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Txt
Imports Telerik.Windows.Documents.Flow.Model
Imports Telerik.Windows.Documents.Flow.Model.Editing
Imports System.Text.RegularExpressions
Imports System.Windows.Media
Imports Telerik.QuickStart.WinControls

Namespace Telerik.Examples.WinControls.WordsProcessing.WordReplace
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private ReadOnly providers As Dictionary(Of IFormatProvider(Of RadFlowDocument), String)
        Private ReadOnly replaceOptions As List(Of ReplaceOption)
        Private document As RadFlowDocument
        Private fileName As String
        Private sampleDocumentFile As String = "..\WordsProcessing\WordReplace\SampleData\SampleDocument.docx"
        Private selectedFormat As String = "Docx"
        Private isDocumentLoaded As Boolean = False
        Private selectedReplaceOption As ReplaceOption

        Public Sub New()
            InitializeComponent()
            Me.pictureBox1.Image = Image.FromFile("..\WordsProcessing\WordReplace\Images\SampleDocumentLargeThumbnail.png")
            Me.providers = New Dictionary(Of IFormatProvider(Of RadFlowDocument), String)() From {
                {New DocxFormatProvider(), "Docx"},
                {New RtfFormatProvider(), "Rtf"},
                {New HtmlFormatProvider(), "Html"},
                {New TxtFormatProvider(), "Txt"},
                {New PdfFormatProvider(), "Pdf"}
            }
            Me.replaceOptions = New List(Of ReplaceOption)()

            For Each replaceOption As ReplaceOption In [Enum].GetValues(GetType(ReplaceOption))
                replaceOptions.Add(replaceOption)
            Next

            selectOption.DataSource = replaceOptions
            UpdateSaveAndReplaceButton()
            docName.Text = ""
        End Sub

        Private Sub LoadCustomDoc_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "Docx files|*.docx|Rtf files|*.rtf|Html files|*.html|Text files|*.txt|All files (*.*)|*.*"
            dialog.FilterIndex = 1

            If dialog.ShowDialog() = DialogResult.OK Then
                findWhat.Text = ""
                replaceWith.Text = ""
                Dim extension As String = Path.GetExtension(dialog.FileName)
                Dim provider As IFormatProvider(Of RadFlowDocument) = Me.providers.Keys.FirstOrDefault(Function(p) p.SupportedExtensions.Any(Function(ex) String.Equals(extension, ex, StringComparison.InvariantCultureIgnoreCase)))

                If provider Is Nothing Then
                    MessageBox.Show("Not supported file type.")
                    Return
                End If

                Me.selectedFormat = Me.providers(provider)

                Using stream As Stream = dialog.OpenFile()

                    Try
                        Me.document = provider.Import(stream)
                        Me.fileName = Path.GetFileName(dialog.FileName)
                        Me.docName.Text = fileName
                        Me.isDocumentLoaded = True
                        Me.UpdateSaveAndReplaceButton()
                    Catch __unusedException1__ As Exception
                        MessageBox.Show("Could not open file.")
                        Me.document = Nothing
                        Me.fileName = Nothing
                        Me.docName.Text = ""
                    End Try
                End Using
            End If
        End Sub

        Private Sub LoadSampleDoc_Click(ByVal sender As Object, ByVal e As EventArgs)
            File.SetAttributes(sampleDocumentFile, FileAttributes.Normal)

            Using stream As Stream = New FileStream(sampleDocumentFile, FileMode.Open)
                Me.document = New DocxFormatProvider().Import(stream)
                Me.fileName = Path.GetFileName(Me.sampleDocumentFile)
                Me.docName.Text = fileName
                Me.isDocumentLoaded = True
                Me.UpdateSaveAndReplaceButton()
                Me.selectedFormat = "Docx"
            End Using
        End Sub

        Private Sub ReplaceAndSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Replace()
            Dim selectedFromat As String = Me.selectedFormat
            Dim result As Boolean = Me.SaveDocument(Me.document, selectedFromat)

            If result Then
                Me.CleanDocument()
            End If
        End Sub

        Private Sub Replace()
            Select Case Me.selectedReplaceOption
                Case ReplaceOption.ReplaceText
                    Me.ReplaceText()
                Case ReplaceOption.ReplaceStyling
                    Me.ReplaceStyling()
            End Select
        End Sub

        Public Function SaveDocument(ByVal document As RadFlowDocument, ByVal selectedFormat As String) As Boolean
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

        Private Sub ReplaceText()
            If String.IsNullOrEmpty(Me.findWhat.Text) Then
                Return
            End If

            Dim editor As RadFlowDocumentEditor = New RadFlowDocumentEditor(Me.document)

            If Me.useRegex.Checked Then
                Dim oldTextRegex As Regex = New Regex(Me.findWhat.Text)
                editor.ReplaceText(oldTextRegex, Me.replaceWith.Text)
            Else
                editor.ReplaceText(Me.findWhat.Text, Me.replaceWith.Text, Me.matchCase.Checked, Me.matchWholeWord.Checked)
            End If
        End Sub

        Private Sub ReplaceStyling()
            If String.IsNullOrEmpty(Me.findWhat.Text) Then
                Return
            End If

            Dim editor As RadFlowDocumentEditor = New RadFlowDocumentEditor(Me.document)

            If Me.useRegex.Checked Then
                Dim searchedTextRegex As Regex = New Regex(Me.findWhat.Text)
                editor.ReplaceStyling(searchedTextRegex, Function(properties) CSharpImpl.__Assign(properties.HighlightColor.LocalValue, Colors.Yellow))
            Else
                editor.ReplaceStyling(Me.findWhat.Text, Me.matchCase.Checked, Me.matchWholeWord.Checked, Function(properties) CSharpImpl.__Assign(properties.HighlightColor.LocalValue, Colors.Yellow))
            End If
        End Sub

        Private Sub CleanDocument()
            Me.document = Nothing
            Me.fileName = Nothing
            Me.isDocumentLoaded = False
            Me.UpdateSaveAndReplaceButton()
        End Sub

        Private Sub SelectOption_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If e.Position = 0 Then
                radLabel6.Visible = True
                replaceWith.Visible = True
                Me.selectedReplaceOption = ReplaceOption.ReplaceText
            Else
                radLabel6.Visible = False
                replaceWith.Visible = False
                Me.selectedReplaceOption = ReplaceOption.ReplaceStyling
            End If
        End Sub

        Private Sub UpdateSaveAndReplaceButton()
            replaceAndSave.Enabled = Me.isDocumentLoaded AndAlso Me.selectOption.SelectedItem IsNot Nothing
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
