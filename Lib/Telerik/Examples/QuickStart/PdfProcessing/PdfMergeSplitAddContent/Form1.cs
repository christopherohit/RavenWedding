using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Telerik.Examples.WinControls.Properties;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.Commands;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Fixed.Exceptions;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Streaming;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Documents.Fixed.Model.Editing;


namespace Telerik.Examples.WinControls.PdfProcessing.PdfMergeSplitAddContent
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        public static string ResultFolder = System.IO.Path.GetTempPath() +  "\\Results";
        public Form1()
        {
            InitializeComponent();
            doubleBufferedFlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            SizeF dpi = this.mergePagesButton.RootElement.DpiScaleFactor;
            Size buttonSize = Telerik.WinControls.TelerikDpiHelper.ScaleSize(new Size(500, 125), dpi);
            mergePagesButton.Size = buttonSize;
            splitPagesButton.Size = buttonSize;
            appendContentButton.Size = buttonSize;
            prependContentButton.Size = buttonSize;

            mergePagesButton.Text = "<html> <span style=\"font-size:22\">Merge Pages</span> <span style=\"font-size:9\">\nSelect several PDF files and their pages will be merged\ninto a single PDF Document</span>";
            splitPagesButton.Text = "<html> <span style=\"font-size:22\">Split Pages</span> <span style=\"font-size:9\">\nSelect a PDF files and its pages will be split and exported to\nseparate single-paged documents</span>";
            appendContentButton.Text = "<html> <span style=\"font-size:22\">Append Content to Pages</span> <span style=\"font-size:9\">\nSelect a PDF file and on each page, you will append\na 'STAMP' text content above the existing page content</span>";
            prependContentButton.Text = "<html> <span style=\"font-size:22\">Prepend Content to Pages</span> <span style=\"font-size:9\">\nSelect a PDF file and on each page, you will prepend\nthe \"Progress\" logo below the existing page content</span>";

            mergePagesButton.Image = Resources.merge;
            splitPagesButton.Image = Resources.split;
            appendContentButton.Image = Resources.append;
            prependContentButton.Image = Resources.prepend;

            mergePagesButton.TextAlignment = ContentAlignment.MiddleLeft;
            splitPagesButton.TextAlignment = ContentAlignment.MiddleLeft;
            appendContentButton.TextAlignment = ContentAlignment.MiddleLeft;
            prependContentButton.TextAlignment = ContentAlignment.MiddleLeft;

            mergePagesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            splitPagesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            appendContentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            prependContentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void MergePagesButton_Click(object sender, EventArgs e)
        {
            this.MergePages();
        }

        private void SplitPagesButton_Click(object sender, EventArgs e)
        {
            this.SplitPages();
        }

        private void AppendContentButton_Click(object sender, EventArgs e)
        {
            this.AppendContentToPages();
        }

        private void PrependContentButton_Click(object sender, EventArgs e)
        {
            this.PrependContentToPages();
        }
        private bool MergePages()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select PDF files to merge";
            ofd.Filter = "PDF files (*.pdf)|*.pdf";
            ofd.Multiselect = true;
            ofd.InitialDirectory = GetSamplePdfsDir();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = GetResultFolderName(ManipulatePagesOption.MergePages);
                string mergeFileName = Path.Combine(path, "MergeResult.pdf");

                if (!Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                using (PdfStreamWriter fileWriter = new PdfStreamWriter(File.OpenWrite(mergeFileName)))
                {
                    foreach (string inputFileName in ofd.FileNames)
                    {
                        using (PdfFileSource fileSource = new PdfFileSource(File.OpenRead(inputFileName)))
                        {
                            foreach (PdfPageSource pageSource in fileSource.Pages)
                            {
                                fileWriter.WritePage(pageSource);
                            }
                        }
                    }
                }
                Process.Start(mergeFileName);
                return true;
            }

            return false;
        }

        private bool SplitPages()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select PDF file to split";
            ofd.Filter = "PDF files|*.pdf";
            ofd.InitialDirectory = GetSamplePdfsDir();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = GetResultFolderName(ManipulatePagesOption.SplitPages);
                string splitNameTemplate = Path.Combine(path, "SplitPage-{0}.pdf");

                if (!Directory.Exists(splitNameTemplate))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                using (PdfFileSource fileSource = new PdfFileSource(ofd.OpenFile()))
                {
                    for (int i = 0; i < fileSource.Pages.Length; i++)
                    {

                        using (PdfStreamWriter fileWriter = new PdfStreamWriter(File.OpenWrite(string.Format(splitNameTemplate, i + 1))))
                        {
                            PdfPageSource pageSource = fileSource.Pages[i];
                            fileWriter.WritePage(pageSource);
                        }
                    }
                }

                Process.Start(GetResultFolderName(ManipulatePagesOption.SplitPages));
                return true;
            }

            return false;
        }

        private bool AppendContentToPages()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select PDF file to append page content";
            ofd.Filter = "PDF files|*.pdf";
            ofd.InitialDirectory = GetSamplePdfsDir();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = GetResultFolderName(ManipulatePagesOption.AppendContentToPages);
                string mergeFileName = Path.Combine(path, "AppendedContentResult.pdf");

                if (!Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                RadFixedPage foregroundContentOwner = GenerateForegroundTextContent("STAMP");

                using (PdfStreamWriter fileWriter = new PdfStreamWriter(File.OpenWrite(mergeFileName)))
                {
                    using (PdfFileSource fileSource = new PdfFileSource(ofd.OpenFile()))
                    {
                        foreach (PdfPageSource pageSource in fileSource.Pages)
                        {
                            using (PdfPageStreamWriter pageWriter = fileWriter.BeginPage(pageSource.Size, pageSource.Rotation))
                            {
                                pageWriter.WriteContent(pageSource);

                                using (pageWriter.SaveContentPosition())
                                {
                                    double xCenteringTranslation = (pageSource.Size.Width - foregroundContentOwner.Size.Width) / 2;
                                    double yCenteringTranslation = (pageSource.Size.Height - foregroundContentOwner.Size.Height) / 2;
                                    pageWriter.ContentPosition.Translate(xCenteringTranslation, yCenteringTranslation);
                                    pageWriter.WriteContent(foregroundContentOwner);
                                }
                            }
                        }
                    }
                }
                Process.Start(mergeFileName);
                return true;
            }

            return false;
        }

        private bool PrependContentToPages()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select PDF file to prepend page content";
            ofd.Filter = "PDF files|*.pdf";
            ofd.InitialDirectory = GetSamplePdfsDir();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = GetResultFolderName(ManipulatePagesOption.PrependContentToPages);
                string mergeFileName = Path.Combine(path, "PrependedContentResult.pdf");

                if (!Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                using (PdfStreamWriter fileWriter = new PdfStreamWriter(File.OpenWrite(mergeFileName)))
                {
                    using (PdfFileSource fileSource = new PdfFileSource(ofd.OpenFile()))
                    {
                        using (PdfFileSource templateSource = new PdfFileSource(GetResourceFile(@"..\PdfProcessing\PdfMergeSplitAddContent\SampleData\template.pdf")))
                        {
                            PdfPageSource backgroundTemplate = templateSource.Pages[0];

                            foreach (PdfPageSource pageSource in fileSource.Pages)
                            {
                                using (PdfPageStreamWriter pageWriter = fileWriter.BeginPage(pageSource.Size, pageSource.Rotation))
                                {
                                    using (pageWriter.SaveContentPosition())
                                    {
                                        double scaleX = pageSource.Size.Width / backgroundTemplate.Size.Width;
                                        double scaleY = pageSource.Size.Height / backgroundTemplate.Size.Height;
                                        double scale = Math.Min(scaleX, scaleY);
                                        double xCenteringTranslation = (pageSource.Size.Width - scale * backgroundTemplate.Size.Width) / 2;
                                        double yCenteringTranslation = (pageSource.Size.Height - scale * backgroundTemplate.Size.Height) / 2;
                                        pageWriter.ContentPosition.Translate(xCenteringTranslation, yCenteringTranslation);
                                        pageWriter.ContentPosition.Scale(scale, scale);
                                        pageWriter.WriteContent(backgroundTemplate);
                                    }

                                    pageWriter.WriteContent(pageSource);
                                }
                            }
                        }
                    }
                }
                Process.Start(mergeFileName);
                return true;
            }

            return false;
        }

        private Stream GetResourceFile(string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);
            FileStream fs = new FileStream(path, FileMode.Open);
            return fs;
        }

        private static string GetSamplePdfsDir()
        {
            return Path.GetFullPath("..\\Examples\\PdfViewer\\SampleData");
        }

        private static string GetResultFolderName(ManipulatePagesOption option)
        {
            string subFolderName = option.ToString();
            string folderName = Path.Combine(ResultFolder, subFolderName);

            return folderName;
        }

        private RadFixedPage GenerateForegroundTextContent(string text)
        {
            Block block = new Block();
            block.BackgroundColor = new RgbColor(50, 0, 0, 0);
            block.GraphicProperties.FillColor = new RgbColor(255, 0, 0);
            block.TextProperties.FontSize = 120;
            block.InsertText(text);
            var horizontalTextSize = block.Measure();
            double rotatedTextSquareSize = (horizontalTextSize.Width + horizontalTextSize.Height) / Math.Sqrt(2);

            RadFixedPage foregroundContentOwner = new RadFixedPage();
            foregroundContentOwner.Size = new System.Windows.Size(rotatedTextSquareSize, rotatedTextSquareSize);
            var foregroundEditor = new FixedContentEditor(foregroundContentOwner);
            foregroundEditor.Position.Translate(horizontalTextSize.Height / Math.Sqrt(2), 0);
            foregroundEditor.Position.Rotate(45);
            foregroundEditor.DrawBlock(block);

            return foregroundContentOwner;
        }

    }

    public enum ManipulatePagesOption
    {
        MergePages,
        SplitPages,
        AppendContentToPages,
        PrependContentToPages
    }
}