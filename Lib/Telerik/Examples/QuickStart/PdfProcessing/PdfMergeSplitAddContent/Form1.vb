Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Resources
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.Commands
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Fixed.Exceptions
Imports Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Streaming
Imports Telerik.Windows.Documents.Fixed.Model
Imports Telerik.Windows.Documents.Fixed.Model.ColorSpaces
Imports Telerik.Windows.Documents.Fixed.Model.Editing

Namespace Telerik.Examples.WinControls.PdfProcessing.PdfMergeSplitAddContent
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Public Shared ResultFolder As String = System.IO.Path.GetTempPath() & "\Results"

        Public Sub New()
            InitializeComponent()
            doubleBufferedFlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
            Dim dpi As SizeF = Me.mergePagesButton.RootElement.DpiScaleFactor
            Dim buttonSize As Size = Telerik.WinControls.TelerikDpiHelper.ScaleSize(New Size(500, 125), dpi)
            mergePagesButton.Size = buttonSize
            splitPagesButton.Size = buttonSize
            appendContentButton.Size = buttonSize
            prependContentButton.Size = buttonSize
            mergePagesButton.Text = "<html> <span style=""font-size:22"">Merge Pages</span> <span style=""font-size:9"">" & vbLf & "Select several PDF files and their pages will be merged" & vbLf & "into a single PDF Document</span>"
            splitPagesButton.Text = "<html> <span style=""font-size:22"">Split Pages</span> <span style=""font-size:9"">" & vbLf & "Select a PDF files and its pages will be split and exported to" & vbLf & "separate single-paged documents</span>"
            appendContentButton.Text = "<html> <span style=""font-size:22"">Append Content to Pages</span> <span style=""font-size:9"">" & vbLf & "Select a PDF file and on each page, you will append" & vbLf & "a 'STAMP' text content above the existing page content</span>"
            prependContentButton.Text = "<html> <span style=""font-size:22"">Prepend Content to Pages</span> <span style=""font-size:9"">" & vbLf & "Select a PDF file and on each page, you will prepend" & vbLf & "the ""Progress"" logo below the existing page content</span>"
            mergePagesButton.Image = My.Resources.merge1
            splitPagesButton.Image = My.Resources.split1
            appendContentButton.Image = My.Resources.append1
            prependContentButton.Image = My.Resources.prepend1
            mergePagesButton.TextAlignment = ContentAlignment.MiddleLeft
            splitPagesButton.TextAlignment = ContentAlignment.MiddleLeft
            appendContentButton.TextAlignment = ContentAlignment.MiddleLeft
            prependContentButton.TextAlignment = ContentAlignment.MiddleLeft
            mergePagesButton.TextImageRelation = TextImageRelation.ImageBeforeText
            splitPagesButton.TextImageRelation = TextImageRelation.ImageBeforeText
            appendContentButton.TextImageRelation = TextImageRelation.ImageBeforeText
            prependContentButton.TextImageRelation = TextImageRelation.ImageBeforeText
        End Sub

        Private Sub MergePagesButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.MergePages()
        End Sub

        Private Sub SplitPagesButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.SplitPages()
        End Sub

        Private Sub AppendContentButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.AppendContentToPages()
        End Sub

        Private Sub PrependContentButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.PrependContentToPages()
        End Sub

        Private Function MergePages() As Boolean
            Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Title = "Select PDF files to merge"
            ofd.Filter = "PDF files (*.pdf)|*.pdf"
            ofd.Multiselect = True
            ofd.InitialDirectory = GetSamplePdfsDir()

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim path As String = GetResultFolderName(ManipulatePagesOption.MergePages)
                Dim mergeFileName As String = System.IO.Path.Combine(path, "MergeResult.pdf")

                If Not Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(path)
                End If

                Using fileWriter As PdfStreamWriter = New PdfStreamWriter(File.OpenWrite(mergeFileName))

                    For Each inputFileName As String In ofd.FileNames

                        Using fileSource As PdfFileSource = New PdfFileSource(File.OpenRead(inputFileName))

                            For Each pageSource As PdfPageSource In fileSource.Pages
                                fileWriter.WritePage(pageSource)
                            Next
                        End Using
                    Next
                End Using

                Process.Start(mergeFileName)
                Return True
            End If

            Return False
        End Function

        Private Function SplitPages() As Boolean
            Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Title = "Select PDF file to split"
            ofd.Filter = "PDF files|*.pdf"
            ofd.InitialDirectory = GetSamplePdfsDir()

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim path As String = GetResultFolderName(ManipulatePagesOption.SplitPages)
                Dim splitNameTemplate As String = System.IO.Path.Combine(path, "SplitPage-{0}.pdf")

                If Not Directory.Exists(splitNameTemplate) Then
                    System.IO.Directory.CreateDirectory(path)
                End If

                Using fileSource As PdfFileSource = New PdfFileSource(ofd.OpenFile())

                    For i As Integer = 0 To fileSource.Pages.Length - 1

                        Using fileWriter As PdfStreamWriter = New PdfStreamWriter(File.OpenWrite(String.Format(splitNameTemplate, i + 1)))
                            Dim pageSource As PdfPageSource = fileSource.Pages(i)
                            fileWriter.WritePage(pageSource)
                        End Using
                    Next
                End Using

                Process.Start(GetResultFolderName(ManipulatePagesOption.SplitPages))
                Return True
            End If

            Return False
        End Function

        Private Function AppendContentToPages() As Boolean
            Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Title = "Select PDF file to append page content"
            ofd.Filter = "PDF files|*.pdf"
            ofd.InitialDirectory = GetSamplePdfsDir()

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim path As String = GetResultFolderName(ManipulatePagesOption.AppendContentToPages)
                Dim mergeFileName As String = System.IO.Path.Combine(path, "AppendedContentResult.pdf")

                If Not Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(path)
                End If

                Dim foregroundContentOwner As RadFixedPage = GenerateForegroundTextContent("STAMP")

                Using fileWriter As PdfStreamWriter = New PdfStreamWriter(File.OpenWrite(mergeFileName))

                    Using fileSource As PdfFileSource = New PdfFileSource(ofd.OpenFile())

                        For Each pageSource As PdfPageSource In fileSource.Pages

                            Using pageWriter As PdfPageStreamWriter = fileWriter.BeginPage(pageSource.Size, pageSource.Rotation)
                                pageWriter.WriteContent(pageSource)

                                Using pageWriter.SaveContentPosition()
                                    Dim xCenteringTranslation As Double = (pageSource.Size.Width - foregroundContentOwner.Size.Width) / 2
                                    Dim yCenteringTranslation As Double = (pageSource.Size.Height - foregroundContentOwner.Size.Height) / 2
                                    pageWriter.ContentPosition.Translate(xCenteringTranslation, yCenteringTranslation)
                                    pageWriter.WriteContent(foregroundContentOwner)
                                End Using
                            End Using
                        Next
                    End Using
                End Using

                Process.Start(mergeFileName)
                Return True
            End If

            Return False
        End Function

        Private Function PrependContentToPages() As Boolean
            Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Title = "Select PDF file to prepend page content"
            ofd.Filter = "PDF files|*.pdf"
            ofd.InitialDirectory = GetSamplePdfsDir()

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim path As String = GetResultFolderName(ManipulatePagesOption.PrependContentToPages)
                Dim mergeFileName As String = System.IO.Path.Combine(path, "PrependedContentResult.pdf")

                If Not Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(path)
                End If

                Using fileWriter As PdfStreamWriter = New PdfStreamWriter(File.OpenWrite(mergeFileName))

                    Using fileSource As PdfFileSource = New PdfFileSource(ofd.OpenFile())

                        Using templateSource As PdfFileSource = New PdfFileSource(GetResourceFile("..\PdfProcessing\PdfMergeSplitAddContent\SampleData\template.pdf"))
                            Dim backgroundTemplate As PdfPageSource = templateSource.Pages(0)

                            For Each pageSource As PdfPageSource In fileSource.Pages

                                Using pageWriter As PdfPageStreamWriter = fileWriter.BeginPage(pageSource.Size, pageSource.Rotation)

                                    Using pageWriter.SaveContentPosition()
                                        Dim scaleX As Double = pageSource.Size.Width / backgroundTemplate.Size.Width
                                        Dim scaleY As Double = pageSource.Size.Height / backgroundTemplate.Size.Height
                                        Dim scale As Double = Math.Min(scaleX, scaleY)
                                        Dim xCenteringTranslation As Double = (pageSource.Size.Width - scale * backgroundTemplate.Size.Width) / 2
                                        Dim yCenteringTranslation As Double = (pageSource.Size.Height - scale * backgroundTemplate.Size.Height) / 2
                                        pageWriter.ContentPosition.Translate(xCenteringTranslation, yCenteringTranslation)
                                        pageWriter.ContentPosition.Scale(scale, scale)
                                        pageWriter.WriteContent(backgroundTemplate)
                                    End Using

                                    pageWriter.WriteContent(pageSource)
                                End Using
                            Next
                        End Using
                    End Using
                End Using

                Process.Start(mergeFileName)
                Return True
            End If

            Return False
        End Function

        Private Function GetResourceFile(ByVal path As String) As Stream
            File.SetAttributes(path, FileAttributes.Normal)
            Dim fs As FileStream = New FileStream(path, FileMode.Open)
            Return fs
        End Function

        Private Shared Function GetSamplePdfsDir() As String
            Return Path.GetFullPath("..\Examples\PdfViewer\SampleData")
        End Function

        Private Shared Function GetResultFolderName(ByVal [option] As ManipulatePagesOption) As String
            Dim subFolderName As String = [option].ToString()
            Dim folderName As String = Path.Combine(ResultFolder, subFolderName)
            Return folderName
        End Function

        Private Function GenerateForegroundTextContent(ByVal text As String) As RadFixedPage
            Dim block As Block = New Block()
            block.BackgroundColor = New RgbColor(50, 0, 0, 0)
            block.GraphicProperties.FillColor = New RgbColor(255, 0, 0)
            block.TextProperties.FontSize = 120
            block.InsertText(text)
            Dim horizontalTextSize As System.Windows.Size = block.Measure()
            Dim rotatedTextSquareSize As Double = (horizontalTextSize.Width + horizontalTextSize.Height) / Math.Sqrt(2)
            Dim foregroundContentOwner As RadFixedPage = New RadFixedPage()
            foregroundContentOwner.Size = New System.Windows.Size(rotatedTextSquareSize, rotatedTextSquareSize)
            Dim foregroundEditor As FixedContentEditor = New FixedContentEditor(foregroundContentOwner)
            foregroundEditor.Position.Translate(horizontalTextSize.Height / Math.Sqrt(2), 0)
            foregroundEditor.Position.Rotate(45)
            foregroundEditor.DrawBlock(block)
            Return foregroundContentOwner
        End Function
    End Class

    Public Enum ManipulatePagesOption
        MergePages
        SplitPages
        AppendContentToPages
        PrependContentToPages
    End Enum
End Namespace
