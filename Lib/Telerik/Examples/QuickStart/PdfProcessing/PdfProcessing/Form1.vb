Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.Windows.Documents.Fixed.FormatProviders.Pdf
Imports Telerik.Windows.Documents.Fixed.Model
Imports Telerik.Windows.Documents.Fixed.Model.ColorSpaces
Imports Telerik.Windows.Documents.Fixed.Model.Editing
Imports Telerik.Windows.Documents.Fixed.Model.Fonts
Imports Telerik.Windows.Documents.Fixed.Model.Graphics

Namespace Telerik.Examples.WinControls.PdfProcessing.PdfProcessing
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm

        Private Shared ReadOnly defaultLeftIndent As Double = 50
        Private Shared ReadOnly defaultLineHeight As Double = 20

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Export()
            Dim formatProvider As PdfFormatProvider = New PdfFormatProvider()
            formatProvider.ExportSettings.ImageQuality = Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export.ImageQuality.High
            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Filter = String.Format("{0} files|*.{1}", "Pdf", "pdf")
            dialog.FileName = "PdfDocumentProcessing"

            If dialog.ShowDialog() = DialogResult.OK Then

                Try

                    Using stream As Stream = dialog.OpenFile()
                        Dim document As RadFixedDocument = Me.CreateDocument()
                        formatProvider.Export(document, stream)
                    End Using

                Catch ex As IOException
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End Sub

        Private Function CreateDocument() As RadFixedDocument
            Dim document As RadFixedDocument = New RadFixedDocument()
            Dim page As RadFixedPage = document.Pages.AddPage()
            page.Size = New System.Windows.Size(600, 800)
            Dim editor As FixedContentEditor = New FixedContentEditor(page)
            editor.Position.Translate(defaultLeftIndent, 50)

            Using stream As Stream = GetSampleResourceStream("..\PdfProcessing\PdfProcessing\pdfProcessing.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                editor.DrawImage(stream)
            End Using

            Dim currentTopOffset As Double = 110
            editor.Position.Translate(defaultLeftIndent, currentTopOffset)
            Dim maxWidth As Double = page.Size.Width - defaultLeftIndent * 2
            Me.DrawDescription(editor, maxWidth)
            currentTopOffset += defaultLineHeight * 2
            editor.Position.Translate(defaultLeftIndent, currentTopOffset)

            Using editor.SaveGraphicProperties()

                Using editor.SaveTextProperties()
                    Me.DrawFunnelFigure(editor)
                End Using
            End Using

            Me.DrawText(editor, maxWidth)
            Me.DrawLogo(page, editor)
            Return document
        End Function

        Private Sub DrawLogo(ByVal page As RadFixedPage, ByVal editor As FixedContentEditor)
            Dim imageBlock As Block = New Block()

            Using stream As Stream = GetSampleResourceStream("..\PdfProcessing\PdfProcessing\progress.png", System.Drawing.Imaging.ImageFormat.Png)
                imageBlock.InsertImage(stream)
            End Using

            Dim imageSize As System.Windows.Size = imageBlock.Measure()
            Dim imageIndent As Double = (page.Size.Width - imageSize.Width) / 2.0
            editor.Position.Translate(imageIndent, page.Size.Height - imageSize.Height - defaultLeftIndent)
            editor.DrawBlock(imageBlock)
        End Sub

        Private Sub DrawDescription(ByVal editor As FixedContentEditor, ByVal maxWidth As Double)
            Dim block As Block = New Block()
            block.GraphicProperties.FillColor = RgbColors.Black
            block.TextProperties.FontSize = 11
            block.TextProperties.Font = FontsRepository.CourierBoldOblique
            block.InsertText("RadPdfProcessing")
            block.TextProperties.TrySetFont(New System.Windows.Media.FontFamily("Calibri"))
            block.InsertText(" is a document processing library that enables your application to import and export files to and from PDF format. " & "The document model is entirely independent from UI and allows you to generate sleek documents with differently formatted text, images, shapes and more.")
            editor.DrawBlock(block, New System.Windows.Size(maxWidth, Double.PositiveInfinity))
        End Sub

        Private Sub DrawText(ByVal editor As FixedContentEditor, ByVal maxWidth As Double)
            Dim currentTopOffset As Double = 470
            currentTopOffset += defaultLineHeight * 2
            editor.Position.Translate(defaultLeftIndent, currentTopOffset)
            editor.TextProperties.FontSize = 11
            Dim block As Block = New Block()
            block.TextProperties.FontSize = 11
            block.TextProperties.Font = FontsRepository.Courier
            block.InsertText("A wizard's job is to vex ")

            Using block.GraphicProperties.Save()
                block.GraphicProperties.FillColor = New RgbColor(146, 208, 80)
                block.InsertText("chumps")
            End Using

            block.InsertText(" quickly in fog.")
            editor.DrawBlock(block, New System.Windows.Size(maxWidth, Double.PositiveInfinity))
            currentTopOffset += defaultLineHeight
            editor.Position.Translate(defaultLeftIndent, currentTopOffset)
            block = New Block()
            block.TextProperties.FontSize = 14
            block.InsertText("A wizard's job is to vex chumps ")

            Using block.TextProperties.Save()
                block.TextProperties.UnderlinePattern = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.UnderlinePattern.Single
                block.TextProperties.UnderlineColor = editor.GraphicProperties.FillColor
                block.InsertText("quickly")
            End Using

            block.InsertText(" in fog.")
            editor.DrawBlock(block, New System.Windows.Size(maxWidth, Double.PositiveInfinity))
            currentTopOffset += defaultLineHeight
            editor.Position.Translate(defaultLeftIndent, currentTopOffset)
            block = New Block()
            block.TextProperties.FontSize = 16
            block.InsertText("A ")

            Using block.TextProperties.Save()
                block.TextProperties.UnderlinePattern = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.UnderlinePattern.Single
                block.TextProperties.UnderlineColor = editor.GraphicProperties.FillColor
                block.InsertText("wizard's")
            End Using

            block.InsertText(" job is to vex chumps quickly in fog.")
            editor.DrawBlock(block, New System.Windows.Size(maxWidth, Double.PositiveInfinity))
            currentTopOffset += defaultLineHeight + 2
            editor.Position.Translate(defaultLeftIndent, currentTopOffset)
            block = New Block()
            block.TextProperties.FontSize = 18
            block.InsertText("A wizard's job is to vex chumps ")

            Using block.TextProperties.Save()
                block.InsertText("quickly")
            End Using

            block.InsertText(" in fog.")
            editor.DrawBlock(block, New System.Windows.Size(maxWidth, Double.PositiveInfinity))
            currentTopOffset += defaultLineHeight
            editor.Position.Translate(defaultLeftIndent, currentTopOffset)
        End Sub

        Private Sub DrawFunnelFigure(ByVal editor As FixedContentEditor)
            editor.GraphicProperties.IsStroked = False
            editor.GraphicProperties.FillColor = New RgbColor(231, 238, 247)
            editor.DrawEllipse(New System.Windows.Point(250, 70), 136, 48)
            editor.GraphicProperties.IsStroked = True
            editor.GraphicProperties.StrokeColor = RgbColors.White
            editor.GraphicProperties.StrokeThickness = 1
            editor.GraphicProperties.FillColor = New RgbColor(91, 155, 223)
            editor.DrawEllipse(New System.Windows.Point(289, 77), 48, 48)
            editor.TextProperties.Font = FontsRepository.Helvetica
            editor.Position.Translate(0, 0)

            Using editor.SaveGraphicProperties()
                editor.Position.Translate(323, 219)
                editor.GraphicProperties.FillColor = RgbColors.White
                editor.DrawText("Fonts")
            End Using

            editor.Position.Translate(0, 0)
            editor.DrawEllipse(New System.Windows.Point(238, 249), 48, 48)

            Using editor.SaveGraphicProperties()
                editor.Position.Translate(215, 240)
                editor.GraphicProperties.FillColor = RgbColors.White
                editor.DrawText("Images")
            End Using

            editor.Position.Translate(0, 0)
            editor.DrawEllipse(New System.Windows.Point(307, 322), 48, 48)

            Using editor.SaveGraphicProperties()
                editor.Position.Translate(284, 313)
                editor.GraphicProperties.FillColor = RgbColors.White
                editor.DrawText("Shapes")
            End Using

            editor.Position.Translate(0, 0)
            Dim arrow As PathGeometry = New PathGeometry()
            Dim figure As PathFigure = arrow.Figures.AddPathFigure()
            figure.StartPoint = New System.Windows.Point(287, 397)
            figure.IsClosed = True
            figure.Segments.AddLineSegment(New System.Windows.Point(287, 413))
            figure.Segments.AddLineSegment(New System.Windows.Point(278, 413))
            figure.Segments.AddLineSegment(New System.Windows.Point(300, 429))
            figure.Segments.AddLineSegment(New System.Windows.Point(322, 413))
            figure.Segments.AddLineSegment(New System.Windows.Point(313, 413))
            figure.Segments.AddLineSegment(New System.Windows.Point(313, 397))
            editor.DrawPath(arrow)
            editor.GraphicProperties.FillColor = New RgbColor(80, 255, 255, 255)
            editor.GraphicProperties.IsStroked = True
            editor.GraphicProperties.StrokeThickness = 1
            editor.GraphicProperties.StrokeColor = New RgbColor(91, 155, 223)
            Dim funnel As PathGeometry = New PathGeometry()
            funnel.FillRule = FillRule.EvenOdd
            figure = funnel.Figures.AddPathFigure()
            figure.IsClosed = True
            figure.StartPoint = New System.Windows.Point(164, 220)
            figure.Segments.AddArcSegment(New System.Windows.Point(436, 220), 136, 48)
            figure.Segments.AddArcSegment(New System.Windows.Point(164, 220), 136, 48)
            figure = funnel.Figures.AddPathFigure()
            figure.IsClosed = True
            figure.StartPoint = New System.Windows.Point(151, 220)
            figure.Segments.AddArcSegment(New System.Windows.Point(449, 220), 149, 61)
            figure.Segments.AddLineSegment(New System.Windows.Point(332, 390))
            figure.Segments.AddArcSegment(New System.Windows.Point(268, 390), 16, 4)
            editor.DrawPath(funnel)

            Using editor.SaveGraphicProperties()

                Using editor.SaveTextProperties()
                    editor.Position.Translate(282, 430)
                    editor.TextProperties.FontSize = 18
                    editor.GraphicProperties.FillColor = RgbColors.Black
                    Dim block1 As Block = New Block()
                    block1.TextProperties.CopyFrom(editor.TextProperties)
                    block1.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Center
                    block1.VerticalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.VerticalAlignment.Top
                    block1.InsertText("PDF")
                    editor.DrawBlock(block1)
                End Using
            End Using
        End Sub

        Private Sub buttonSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Export()
        End Sub

        Public Shared Function GetSampleResourceStream(ByVal resource As String, ByVal imageFormat As System.Drawing.Imaging.ImageFormat) As Stream
            Dim image As Image = Image.FromFile(resource)
            Dim stream As Stream = New MemoryStream()
            image.Save(stream, imageFormat)
            Return stream
        End Function
    End Class
End Namespace
