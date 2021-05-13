Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv
Imports Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Txt
Imports Telerik.Windows.Documents.Spreadsheet.Model

Namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadConvertion
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private Shared ReadOnly SampleDocumentFile As String = "SampleDocument.xlsx"
        Private providers As List(Of IWorkbookFormatProvider)

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.fileExtensionsDropDownList.SelectedIndex = 1
            Me.providers = New List(Of IWorkbookFormatProvider)() From {
                New XlsxFormatProvider(),
                New CsvFormatProvider(),
                New TxtFormatProvider()
            }
        End Sub

        Private Sub loadCustomDocumentButton_Click(ByVal sender As Object, ByVal args As EventArgs)
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "Xlsx files|*.xlsx|Csv files|*.Csv|Text files|*.txt|All files (*.*)|*.*"
            dialog.FilterIndex = 1

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim extension As String = Path.GetExtension(dialog.FileName)
                Dim provider As IWorkbookFormatProvider = Me.providers.FirstOrDefault(Function(p) p.SupportedExtensions.Any(Function(e) String.Compare(extension, e, StringComparison.InvariantCultureIgnoreCase) = 0))

                If provider IsNot Nothing Then

                    Try

                        Using stream As Stream = dialog.OpenFile()
                            Me.Workbook = provider.Import(stream)
                            Me.FileName = Path.GetFileName(dialog.FileName)
                            Me.saveButton.Enabled = True
                        End Using

                    Catch __unusedException1__ As Exception
                        MessageBox.Show("Could not open file.")
                        Me.Workbook = Nothing
                        Me.FileName = Nothing
                    End Try
                Else
                    MessageBox.Show("Could not open file.")
                End If
            End If
        End Sub

        Private m_workbook As Workbook
        Public Property Workbook() As Workbook
            Get
                Return Me.m_workbook
            End Get
            Set(value As Workbook)
                If Me.m_workbook IsNot value Then
                    Me.m_workbook = value
                    Me.IsDocumentLoaded = value IsNot Nothing
                End If
            End Set
        End Property

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
                    m_exportFormats = New String() {"Xlsx", "Csv", "Txt"}
                End If

                Return m_exportFormats
            End Get
        End Property

        Private Sub loadSampleDocumentButton_Click(sender As Object, e As EventArgs)
            Using stream As Stream = FileHelper.GetSampleResourceStream(SampleDocumentFile)
                Me.Workbook = New XlsxFormatProvider().Import(stream)
                Me.FileName = Path.GetFileName(SampleDocumentFile)
                Me.saveButton.Enabled = True
            End Using
        End Sub

        Private Sub saveButton_Click(sender As Object, e As EventArgs)
            Dim selectedFromat As String = Me.fileExtensionsDropDownList.Text
            FileHelper.SaveDocument(Me.Workbook, selectedFromat)
        End Sub

        Private Shared Function GetFormatProvider(extension As String) As IWorkbookFormatProvider
            Dim formatProvider As IWorkbookFormatProvider
            Select Case extension
                Case "Xlsx"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider")
                    Exit Select
                Case "Csv"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("CsvFormatProvider")
                    TryCast(formatProvider, CsvFormatProvider).Settings.HasHeaderRow = True
                    Exit Select
                Case "Txt"
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider")
                    Exit Select
                Case Else
                    formatProvider = Nothing
                    Exit Select
            End Select

            Return formatProvider
        End Function
    End Class
End Namespace
