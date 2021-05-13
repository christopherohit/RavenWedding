Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.Fixed.Model
Imports Telerik.Windows.Documents.Fixed.Model.ColorSpaces
Imports Telerik.Windows.Documents.Fixed.Model.Editing
Imports System.Runtime.InteropServices

Namespace Telerik.Examples.WinControls.PdfProcessing.PdfChartIntegration
    Partial Public Class Form1
        Inherits ExamplesForm
        Implements ICustomThemeExamplesForm
        Private Shared ReadOnly chartWidth As Double = 600
        Private Shared ReadOnly chartHeight As Double = 360
        Private Shared ReadOnly markerAreaWidth As Double = 60
        Private Shared ReadOnly marginTop As Double = 200
        Private Shared ReadOnly valuesMargin As Double = 10
        Private Shared ReadOnly rectSize As Double = 5
        Private Shared ReadOnly barMargin As Double = 2
        Private Shared ReadOnly markersCount As Integer = 7

        Private products As Product()
        Private quartersToExport As Dictionary(Of Integer, Boolean)

        Private m_q1 As Boolean
        Private m_q2 As Boolean
        Private m_q3 As Boolean
        Private m_q4 As Boolean
        Private m_exportedProductsCount As Integer = 6
        Private m_stepValue As Double

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)
            Me.products = Product.GetProducts()
            Me.quartersToExport = New Dictionary(Of Integer, Boolean)()
            Me.InitializeData()
            Me.InitializeControls()
        End Sub

        Private Sub InitializeControls()
            AddHandler Me.checkBoxQ1.CheckStateChanged, AddressOf checkBoxQ1_CheckStateChanged
            AddHandler Me.checkBoxQ2.CheckStateChanged, AddressOf checkBoxQ2_CheckStateChanged
            AddHandler Me.checkBoxQ3.CheckStateChanged, AddressOf checkBoxQ3_CheckStateChanged
            AddHandler Me.checkBoxQ4.CheckStateChanged, AddressOf checkBoxQ4_CheckStateChanged
            Me.checkBoxQ1.Checked = True
            Me.checkBoxQ2.Checked = True
            Me.checkBoxQ3.Checked = True
            Me.checkBoxQ4.Checked = True
            AddHandler Me.dropDownListNumberOfProducts.SelectedIndexChanged, AddressOf dropDownListNumberOfProducts_SelectedIndexChanged
            Me.dropDownListNumberOfProducts.SelectedIndex = 5
            AddHandler Me.chartValueStepEditor.ValueChanged, AddressOf chartValueStepEditor_ValueChanged
            Me.pictureBox1.Image = Image.FromStream(GetSampleResourceStream("barChart.PNG"))
        End Sub

        Private Sub chartValueStepEditor_ValueChanged(sender As Object, e As EventArgs)
            m_stepValue = CDbl(Me.chartValueStepEditor.Value)
        End Sub

        Private Sub dropDownListNumberOfProducts_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            Me.m_exportedProductsCount = Integer.Parse(Me.dropDownListNumberOfProducts.Text)
        End Sub

        Private Sub checkBoxQ4_CheckStateChanged(sender As Object, e As EventArgs)
            Q4 = Me.checkBoxQ4.Checked
        End Sub

        Private Sub checkBoxQ3_CheckStateChanged(sender As Object, e As EventArgs)
            Q3 = Me.checkBoxQ3.Checked
        End Sub

        Private Sub checkBoxQ2_CheckStateChanged(sender As Object, e As EventArgs)
            Q2 = Me.checkBoxQ2.Checked
        End Sub

        Private Sub checkBoxQ1_CheckStateChanged(sender As Object, e As EventArgs)
            Q1 = Me.checkBoxQ1.Checked
        End Sub

        Private Sub InitializeData()
            Me.quartersToExport.Add(0, False)
            Me.quartersToExport.Add(1, False)
            Me.quartersToExport.Add(2, False)
            Me.quartersToExport.Add(3, False)

            Me.Q1 = True
            Me.Q2 = True
            Me.Q3 = True
            Me.Q4 = True
            Me.ExportedProductsCount = Me.products.Length
            Me.StepValue = 5000
        End Sub

        Public Property ExportedProductsCount() As Integer
            Get
                Return Me.m_exportedProductsCount
            End Get
            Set(value As Integer)
                If Me.m_exportedProductsCount <> value Then
                    Me.m_exportedProductsCount = value
                End If
            End Set
        End Property

        Public Property StepValue() As Double
            Get
                Return Me.m_stepValue
            End Get
            Set(value As Double)
                If Me.m_stepValue <> value Then
                    Me.m_stepValue = value
                End If
            End Set
        End Property

        Public Property Q1() As Boolean
            Get
                Return Me.m_q1
            End Get
            Set(value As Boolean)
                If Me.m_q1 <> value Then
                    Me.m_q1 = value
                    Me.quartersToExport(0) = Me.m_q1
                    Me.buttonSave.Enabled = Me.quartersToExport.Values.Contains(True)
                End If
            End Set
        End Property

        Public Property Q2() As Boolean
            Get
                Return Me.m_q2
            End Get
            Set(value As Boolean)
                If Me.m_q2 <> value Then
                    Me.m_q2 = value
                    Me.quartersToExport(1) = Me.m_q2
                    Me.buttonSave.Enabled = Me.quartersToExport.Values.Contains(True)
                End If
            End Set
        End Property

        Public Property Q3() As Boolean
            Get
                Return Me.m_q3
            End Get
            Set(value As Boolean)
                If Me.m_q3 <> value Then
                    Me.m_q3 = value
                    Me.quartersToExport(2) = Me.m_q3
                    Me.buttonSave.Enabled = Me.quartersToExport.Values.Contains(True)
                End If
            End Set
        End Property

        Public Property Q4() As Boolean
            Get
                Return Me.m_q4
            End Get
            Set(value As Boolean)
                If Me.m_q4 <> value Then
                    Me.m_q4 = value
                    Me.quartersToExport(3) = Me.m_q4
                    Me.buttonSave.Enabled = Me.quartersToExport.Values.Contains(True)
                End If
            End Set
        End Property

        Private Sub Export()
            Dim formatProvider As New Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider()
            formatProvider.ExportSettings.ImageQuality = Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export.ImageQuality.High

            If Not Me.quartersToExport.Values.Contains(True) Then
                Return
            End If

            Dim dialog As New SaveFileDialog()
            dialog.Filter = [String].Format("{0} files|*.{1}", "Pdf", "pdf")
            dialog.FileName = "PdfBarChartGeneration"

            If dialog.ShowDialog() = DialogResult.OK Then
                Try
                    Using stream As Stream = dialog.OpenFile()
                        Dim document As RadFixedDocument = Me.CreateDocument()
                        formatProvider.Export(document, stream)
                    End Using
                Catch ex As IOException
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End Sub

        Private Function CreateDocument() As RadFixedDocument
            Dim document As New RadFixedDocument()
            Dim page As RadFixedPage = document.Pages.AddPage()
            page.Size = New System.Windows.Size(792, 1128)
            Dim editor As New FixedContentEditor(page)
            editor.GraphicProperties.IsFilled = False
            Me.DrawCompanyLogo(editor)

            Dim leftMargin As Double = (page.Size.Width - chartWidth) / 2
            Dim offsetX As Double
            Dim offsetY As Double

            Me.DrawChartFrame(leftMargin, editor, offsetX, offsetY)

            Dim offset As Double = 20
            Dim textWidth As Double = 0
            Dim rectMargin As Double = 2

            Dim blocks As New List(Of Block)()
            For i As Integer = 0 To Me.ExportedProductsCount - 1
                Dim block As New Block()
                block.TextProperties.CopyFrom(editor.TextProperties)
                block.InsertText(Me.products(i).Name)
                block.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Left
                blocks.Add(block)

                textWidth += rectSize + rectMargin + offset
                textWidth += block.Measure().Width
            Next

            Dim colors As RgbColor() = {New RgbColor(49, 204, 118), New RgbColor(154, 92, 179), New RgbColor(56, 152, 216), New RgbColor(243, 200, 41), New RgbColor(230, 130, 44), New RgbColor(230, 80, 65)}

            Dim secondaryColors As RgbColor() = {New RgbColor(197, 243, 217), New RgbColor(210, 179, 223), New RgbColor(163, 209, 240), New RgbColor(249, 230, 148), New RgbColor(246, 204, 167), New RgbColor(244, 167, 160)}

            offsetX = leftMargin + ((chartWidth - textWidth) / 2)
            offsetY += 20
            For i As Integer = 0 To Me.ExportedProductsCount - 1
                editor.Position.Translate(offsetX, offsetY + 2)
                Dim tiling As Tiling = CreateTiling(offsetX, offsetY, rectSize, colors(i), secondaryColors(i))
                editor.GraphicProperties.FillColor = tiling
                editor.DrawRectangle(New Rect(0, 0, rectSize, rectSize))

                offsetX += rectSize + rectMargin
                editor.Position.Translate(offsetX, offsetY - 2)
                editor.GraphicProperties.FillColor = RgbColors.Black
                editor.DrawBlock(blocks(i))
                offsetX += blocks(i).Measure().Width + offset
            Next

            offsetX = leftMargin

            offsetY += 30
            Dim markerHeight As Double = (chartHeight - (offsetY - marginTop)) / markersCount
            editor.Position.Translate(offsetX, offsetY)

            For i As Integer = markersCount - 1 To 0 Step -1
                Dim labelBlock As New Block()
                labelBlock.TextProperties.CopyFrom(editor.TextProperties)
                labelBlock.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Right
                labelBlock.InsertText(String.Format("{0:C}", i * Me.StepValue))
                Dim labelSize As System.Windows.Size = labelBlock.Measure()
                labelSize.Width = markerAreaWidth
                editor.DrawBlock(labelBlock, labelSize)

                If i > 0 Then
                    offsetY += markerHeight
                    editor.Position.Translate(offsetX, offsetY)
                End If
            Next

            offsetX = leftMargin + markerAreaWidth + valuesMargin

            Dim blockX As New Block()
            blockX.TextProperties.CopyFrom(editor.TextProperties)
            blockX.InsertText("X")

            Dim center As Double = blockX.Measure().Height / 2
            offsetY += center
            Dim valueHeight As Double = markerHeight / Me.StepValue
            Dim dataAreaWidth As Double = chartWidth - markerAreaWidth - 2 * valuesMargin

            Dim sectionWidth As Double = dataAreaWidth / Me.GetQuartersToExportCount()
            Dim barWidth As Double = (sectionWidth - 2 * valuesMargin - 2 * Me.ExportedProductsCount * barMargin) / Me.ExportedProductsCount

            For j As Integer = 0 To Me.quartersToExport.Keys.Count - 1
                If Not Me.quartersToExport(j) Then
                    Continue For
                End If

                editor.Position.Translate(offsetX, offsetY + 5)
                editor.GraphicProperties.FillColor = RgbColors.Black

                Dim qBlock As New Block()
                qBlock.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Center
                qBlock.TextProperties.CopyFrom(editor.TextProperties)
                qBlock.InsertText(String.Format("Q{0}", j + 1))
                Dim qBlockSize As System.Windows.Size = qBlock.Measure()
                qBlockSize.Width = sectionWidth
                editor.DrawBlock(qBlock, qBlockSize)

                editor.Position.Translate(0, 0)
                offsetX += valuesMargin
                For i As Integer = 0 To Me.ExportedProductsCount - 1
                    Dim product As Product = Me.products(i)
                    Dim h As Double = product.Q(j) * valueHeight
                    offsetX += barMargin
                    Dim tiling As Tiling = CreateTiling(offsetX, offsetY - h, barWidth, colors(i), secondaryColors(i))
                    editor.GraphicProperties.FillColor = tiling
                    editor.DrawRectangle(New Rect(offsetX, offsetY - h, barWidth, h))
                    offsetX += barWidth + barMargin
                Next

                offsetX += valuesMargin
            Next

            offsetX = leftMargin + markerAreaWidth + valuesMargin
            DrawBarLine(editor, offsetX, offsetY, dataAreaWidth)

            Return document
        End Function

        Private Sub DrawCompanyLogo(editor As FixedContentEditor)
            editor.Position.Translate(230, 80)
            Using stream As Stream = GetSampleResourceStream("abCompany.jpg")
                editor.DrawImage(stream)
            End Using
            editor.Position.Translate(0, 0)
        End Sub

        Private Sub DrawChartFrame(leftMargin As Double, editor As FixedContentEditor, ByRef offsetX As Double, ByRef offsetY As Double)
            offsetX = leftMargin
            offsetY = marginTop
            editor.DrawRectangle(New Rect(offsetX, offsetY, chartWidth, chartHeight))
            offsetY += 10
            editor.Position.Translate(offsetX, offsetY)

            Dim headerText As New Block()
            headerText.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Center
            headerText.TextProperties.FontSize = 18
            headerText.TextProperties.TrySetFont(New System.Windows.Media.FontFamily("Calibri"), FontStyles.Normal, FontWeights.Bold)
            headerText.InsertText("2013")
            Dim blockSize As System.Windows.Size = headerText.Measure()
            blockSize.Width = chartWidth
            editor.DrawBlock(headerText, blockSize)

            offsetY += 30
            editor.Position.Translate(offsetX, offsetY)

            editor.TextProperties.TrySetFont(New System.Windows.Media.FontFamily("Calibri"))
            editor.TextProperties.FontSize = 10
            editor.GraphicProperties.IsFilled = True
            editor.GraphicProperties.IsStroked = False
        End Sub

        Private Shared Function CreateTiling(offsetX As Double, offsetY As Double, width As Double, color As SimpleColor, secondaryColor As SimpleColor) As Tiling
            Dim tiling As New Tiling(New Rect(0, 0, width, 2))
            tiling.Position.Translate(offsetX, offsetY)
            Dim tilingEditor As FixedContentEditor = New FixedContentEditor(tiling)
            tilingEditor.GraphicProperties.IsStroked = False
            tilingEditor.GraphicProperties.FillColor = color
            tilingEditor.DrawRectangle(New Rect(0, 0, width, 1))
            Dim gradient As New LinearGradient(New System.Windows.Point(0, 0), New System.Windows.Point(width, 0))
            gradient.GradientStops.Add(New GradientStop(color, 0))
            gradient.GradientStops.Add(New GradientStop(secondaryColor, 0.6))
            gradient.GradientStops.Add(New GradientStop(color, 1))
            tilingEditor.GraphicProperties.FillColor = gradient
            tilingEditor.DrawRectangle(New Rect(0, 1, width, 1))

            Return tiling
        End Function

        Private Shared Sub DrawBarLine(editor As FixedContentEditor, offsetX As Double, offsetY As Double, width As Double)
            editor.GraphicProperties.FillColor = RgbColors.Black
            editor.GraphicProperties.StrokeThickness = 1
            editor.GraphicProperties.IsFilled = False
            editor.GraphicProperties.IsStroked = True
            editor.DrawLine(New System.Windows.Point(offsetX, offsetY), New System.Windows.Point(offsetX + width, offsetY))
        End Sub

        Private Function GetQuartersToExportCount() As Double
            Dim counter As Integer = 0
            For Each shouldExportQ As Boolean In Me.quartersToExport.Values
                If shouldExportQ Then
                    counter += 1
                End If
            Next

            Return counter
        End Function

        Public Shared Function GetSampleResourceStream(resource As String) As Stream
            Dim assembly__1 As Assembly = Assembly.GetExecutingAssembly()
            Dim stream As Stream = assembly__1.GetManifestResourceStream(resource)
            If stream IsNot Nothing Then
                Return stream
            End If

            Return Nothing
        End Function

        Private Sub buttonSave_Click(sender As Object, e As EventArgs)
            Me.Export()
        End Sub
    End Class
End Namespace