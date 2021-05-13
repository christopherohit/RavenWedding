using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.Fonts;
using Telerik.Windows.Documents.Fixed.Model.Graphics;

namespace Telerik.Examples.WinControls.PdfProcessing.PdfProcessing
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private static readonly double defaultLeftIndent = 50;
        private static readonly double defaultLineHeight = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Export()
        {
            PdfFormatProvider formatProvider = new PdfFormatProvider();
            formatProvider.ExportSettings.ImageQuality = Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export.ImageQuality.High;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = String.Format("{0} files|*.{1}", "Pdf", "pdf");
            dialog.FileName = "PdfDocumentProcessing";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = dialog.OpenFile())
                    {
                        RadFixedDocument document = this.CreateDocument();
                        formatProvider.Export(document, stream);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private RadFixedDocument CreateDocument()
        {
            RadFixedDocument document = new RadFixedDocument();
            RadFixedPage page = document.Pages.AddPage();
            page.Size = new System.Windows.Size(600, 800);
            FixedContentEditor editor = new FixedContentEditor(page);
            editor.Position.Translate(defaultLeftIndent, 50);
            using (Stream stream = GetSampleResourceStream(@"..\PdfProcessing\PdfProcessing\pdfProcessing.jpg", System.Drawing.Imaging.ImageFormat.Jpeg))
            {
                editor.DrawImage(stream);
            }

            double currentTopOffset = 110;
            editor.Position.Translate(defaultLeftIndent, currentTopOffset);
            double maxWidth = page.Size.Width - defaultLeftIndent * 2;

            this.DrawDescription(editor, maxWidth);

            currentTopOffset += defaultLineHeight * 2;
            editor.Position.Translate(defaultLeftIndent, currentTopOffset);

            using (editor.SaveGraphicProperties())
            {
                using (editor.SaveTextProperties())
                {
                    this.DrawFunnelFigure(editor);
                }
            }

            this.DrawText(editor, maxWidth);
            this.DrawLogo(page, editor);

            return document;
        }
 
        private void DrawLogo(RadFixedPage page, FixedContentEditor editor)
        {
            Block imageBlock = new Block();
            using (Stream stream = GetSampleResourceStream(@"..\PdfProcessing\PdfProcessing\progress.png", System.Drawing.Imaging.ImageFormat.Png))
            {
                imageBlock.InsertImage(stream);
            }

            System.Windows.Size imageSize = imageBlock.Measure();
            double imageIndent = (page.Size.Width - imageSize.Width) / 2.0;

            editor.Position.Translate(imageIndent, page.Size.Height - imageSize.Height - defaultLeftIndent);
            editor.DrawBlock(imageBlock);
        }

        private void DrawDescription(FixedContentEditor editor, double maxWidth)
        {
            Block block = new Block();
            block.GraphicProperties.FillColor = RgbColors.Black;
            block.TextProperties.FontSize = 11;
            block.TextProperties.Font = FontsRepository.CourierBoldOblique;

            block.InsertText("RadPdfProcessing");
            block.TextProperties.TrySetFont(new System.Windows.Media.FontFamily("Calibri"));
            block.InsertText(" is a document processing library that enables your application to import and export files to and from PDF format. " +
                "The document model is entirely independent from UI and allows you to generate sleek documents with differently formatted text, images, shapes and more.");

            editor.DrawBlock(block, new System.Windows.Size(maxWidth, double.PositiveInfinity));
        }

        private void DrawText(FixedContentEditor editor, double maxWidth)
        {
            double currentTopOffset = 470;
            currentTopOffset += defaultLineHeight * 2;
            editor.Position.Translate(defaultLeftIndent, currentTopOffset);
            editor.TextProperties.FontSize = 11;

            Block block = new Block();
            block.TextProperties.FontSize = 11;
            block.TextProperties.Font = FontsRepository.Courier;
            block.InsertText("A wizard's job is to vex ");
            using (block.GraphicProperties.Save())
            {
                block.GraphicProperties.FillColor = new RgbColor(146, 208, 80);
                block.InsertText("chumps");
            }

            block.InsertText(" quickly in fog.");
            editor.DrawBlock(block, new System.Windows.Size(maxWidth, double.PositiveInfinity));

            currentTopOffset += defaultLineHeight;
            editor.Position.Translate(defaultLeftIndent, currentTopOffset);

            block = new Block();
            block.TextProperties.FontSize = 14;

            block.InsertText("A wizard's job is to vex chumps ");
            using (block.TextProperties.Save())
            {
                block.TextProperties.UnderlinePattern = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.UnderlinePattern.Single;
                block.TextProperties.UnderlineColor = editor.GraphicProperties.FillColor;
                block.InsertText("quickly");
            }

            block.InsertText(" in fog.");
            editor.DrawBlock(block, new System.Windows.Size(maxWidth, double.PositiveInfinity));

            currentTopOffset += defaultLineHeight;
            editor.Position.Translate(defaultLeftIndent, currentTopOffset);
            block = new Block();
            block.TextProperties.FontSize = 16;

            block.InsertText("A ");
            using (block.TextProperties.Save())
            {
                block.TextProperties.UnderlinePattern = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.UnderlinePattern.Single;
                block.TextProperties.UnderlineColor = editor.GraphicProperties.FillColor;
                block.InsertText("wizard's");
            }

            block.InsertText(" job is to vex chumps quickly in fog.");
            editor.DrawBlock(block, new System.Windows.Size(maxWidth, double.PositiveInfinity));

            currentTopOffset += defaultLineHeight + 2;
            editor.Position.Translate(defaultLeftIndent, currentTopOffset);
            block = new Block();
            block.TextProperties.FontSize = 18;

            block.InsertText("A wizard's job is to vex chumps ");
            using (block.TextProperties.Save())
            {

                block.InsertText("quickly");
            }

            block.InsertText(" in fog.");
            editor.DrawBlock(block, new System.Windows.Size(maxWidth, double.PositiveInfinity));

            currentTopOffset += defaultLineHeight;
            editor.Position.Translate(defaultLeftIndent, currentTopOffset);
        }

        private void DrawFunnelFigure(FixedContentEditor editor)
        {
            editor.GraphicProperties.IsStroked = false;
            editor.GraphicProperties.FillColor = new RgbColor(231, 238, 247);
            editor.DrawEllipse(new System.Windows.Point(250, 70), 136, 48);

            editor.GraphicProperties.IsStroked = true;
            editor.GraphicProperties.StrokeColor = RgbColors.White;
            editor.GraphicProperties.StrokeThickness = 1;
            editor.GraphicProperties.FillColor = new RgbColor(91, 155, 223);
            editor.DrawEllipse(new System.Windows.Point(289, 77), 48, 48);
            editor.TextProperties.Font = FontsRepository.Helvetica;

            editor.Position.Translate(0, 0);
            using (editor.SaveGraphicProperties())
            {
                editor.Position.Translate(323, 219);
                editor.GraphicProperties.FillColor = RgbColors.White;
                editor.DrawText("Fonts");
            }

            editor.Position.Translate(0, 0);
            editor.DrawEllipse(new System.Windows.Point(238, 249), 48, 48);
            using (editor.SaveGraphicProperties())
            {
                editor.Position.Translate(215, 240);
                editor.GraphicProperties.FillColor = RgbColors.White;
                editor.DrawText("Images");
            }

            editor.Position.Translate(0, 0);
            editor.DrawEllipse(new System.Windows.Point(307, 322), 48, 48);
            using (editor.SaveGraphicProperties())
            {
                editor.Position.Translate(284, 313);
                editor.GraphicProperties.FillColor = RgbColors.White;
                editor.DrawText("Shapes");
            }

            editor.Position.Translate(0, 0);
            PathGeometry arrow = new PathGeometry();
            PathFigure figure = arrow.Figures.AddPathFigure();
            figure.StartPoint = new System.Windows.Point(287, 397);
            figure.IsClosed = true;
            figure.Segments.AddLineSegment(new System.Windows.Point(287, 413));
            figure.Segments.AddLineSegment(new System.Windows.Point(278, 413));
            figure.Segments.AddLineSegment(new System.Windows.Point(300, 429));
            figure.Segments.AddLineSegment(new System.Windows.Point(322, 413));
            figure.Segments.AddLineSegment(new System.Windows.Point(313, 413));
            figure.Segments.AddLineSegment(new System.Windows.Point(313, 397));

            editor.DrawPath(arrow);

            editor.GraphicProperties.FillColor = new RgbColor(80, 255, 255, 255);
            editor.GraphicProperties.IsStroked = true;
            editor.GraphicProperties.StrokeThickness = 1;
            editor.GraphicProperties.StrokeColor = new RgbColor(91, 155, 223);

            PathGeometry funnel = new PathGeometry();
            funnel.FillRule = FillRule.EvenOdd;
            figure = funnel.Figures.AddPathFigure();
            figure.IsClosed = true;
            figure.StartPoint = new System.Windows.Point(164, 220);
            figure.Segments.AddArcSegment(new System.Windows.Point(436, 220), 136, 48);
            figure.Segments.AddArcSegment(new System.Windows.Point(164, 220), 136, 48);

            figure = funnel.Figures.AddPathFigure();
            figure.IsClosed = true;
            figure.StartPoint = new System.Windows.Point(151, 220);
            figure.Segments.AddArcSegment(new System.Windows.Point(449, 220), 149, 61);
            figure.Segments.AddLineSegment(new System.Windows.Point(332, 390));
            figure.Segments.AddArcSegment(new System.Windows.Point(268, 390), 16, 4);

            editor.DrawPath(funnel);

            using (editor.SaveGraphicProperties())
            {
                using (editor.SaveTextProperties())
                {
                    editor.Position.Translate(282, 430);
                    editor.TextProperties.FontSize = 18;
                    editor.GraphicProperties.FillColor = RgbColors.Black;
                    Block block1 = new Block();
                    block1.TextProperties.CopyFrom(editor.TextProperties);
                    block1.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Center;
                    block1.VerticalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.VerticalAlignment.Top;
                    block1.InsertText("PDF");

                    editor.DrawBlock(block1);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Export();
        }

        public static Stream GetSampleResourceStream(string resource, System.Drawing.Imaging.ImageFormat imageFormat)
        {            
            Image image = Image.FromFile(resource);
            Stream stream = new MemoryStream();
            image.Save(stream, imageFormat);
            return stream;
        }
    }
}
