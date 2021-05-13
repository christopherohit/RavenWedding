Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Common.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders
Imports Telerik.Windows.Documents.Flow.FormatProviders.Docx
Imports Telerik.Windows.Documents.Flow.FormatProviders.Html
Imports Telerik.Windows.Documents.Flow.FormatProviders.Rtf
Imports Telerik.Windows.Documents.Flow.FormatProviders.Txt
Imports Telerik.Windows.Documents.Flow.Model

Namespace Telerik.Examples.WinControls.WordsProcessing.WordConvertion
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private Shared ReadOnly SampleDocumentFile As String = "SampleDocument.docx"
        Private providers As List(Of IFormatProvider(Of RadFlowDocument))
        Public Property Document As RadFlowDocument

        Public Sub New()
            InitializeComponent()
            Me.fileExtensionsDropDownList.DataSource = Me.ExportFormats
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.fileExtensionsDropDownList.SelectedIndex = 1
            Me.providers = New List(Of IFormatProvider(Of RadFlowDocument))() From {
                New DocxFormatProvider(),
                New RtfFormatProvider(),
                New HtmlFormatProvider(),
                New TxtFormatProvider()
            }
        End Sub

        Private Sub loadCustomDocumentButton_Click(ByVal sender As Object, ByVal args As EventArgs)
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "Docx files|*.docx|Rtf files|*.rtf|Html files|*.html|Text files|*.txt|All files (*.*)|*.*"
            dialog.FilterIndex = 1

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim extension As String = Path.GetExtension(dialog.FileName)
                Dim provider As IFormatProvider(Of RadFlowDocument) = Me.providers.FirstOrDefault(Function(p) p.SupportedExtensions.Any(Function(e) String.Compare(extension, e, StringComparison.InvariantCultureIgnoreCase) = 0))

                If provider IsNot Nothing Then

                    Try

                        Using stream As Stream = dialog.OpenFile()
                            Me.Document = provider.Import(stream)
                            Me.FileName = Path.GetFileName(dialog.FileName)
                            Me.saveButton.Enabled = True
                        End Using

                    Catch __unusedException1__ As Exception
                        MessageBox.Show("Could not open file.")
                        Me.Document = Nothing
                        Me.FileName = Nothing
                    End Try
                Else
                    MessageBox.Show("Could not open file.")
                End If
            End If
        End Sub

        Private m_isDocumentLoaded As Boolean
        Public Property IsDocumentLoaded() As Boolean
            Get
                Return Me.m_isDocumentLoaded
            End Get
            Set(value As Boolean)
                If Me.m_isDocumentLoaded <> value Then
                    Me.m_isDocumentLoaded = value
                End If
            End Set
        End Property

        Private m_fileName As String
        Public Property FileName() As String
            Get
                Return Me.m_fileName
            End Get
            Set(value As String)
                If Me.m_fileName <> value Then
                    Me.m_fileName = value
                    Me.fileNameLabel.Text = value
                End If
            End Set
        End Property

        Private m_exportFormats As IEnumerable(Of String)
        Public ReadOnly Property ExportFormats() As IEnumerable(Of String)
            Get
                If m_exportFormats Is Nothing Then
                    m_exportFormats = New String() {"Docx", "Rtf", "Txt", "Html"}
                End If

                Return m_exportFormats
            End Get
        End Property

        Private Sub loadSampleDocumentButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Using stream As Stream = FileHelper.GetSampleResourceStream(SampleDocumentFile)
                Me.Document = New DocxFormatProvider().Import(stream)
                Me.FileName = Path.GetFileName(SampleDocumentFile)
                Me.saveButton.Enabled = True
            End Using
        End Sub

        Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectedFromat As String = Me.fileExtensionsDropDownList.Text
            FileHelper.SaveDocument(Me.Document, selectedFromat)
        End Sub
    End Class
End Namespace
