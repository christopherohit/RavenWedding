using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.ColorSpaces;
using Telerik.Windows.Documents.Fixed.Model.Editing;

namespace Telerik.Examples.WinControls.PdfProcessing.PdfChartIntegration
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private static readonly double chartWidth = 600;
        private static readonly double chartHeight = 360;
        private static readonly double markerAreaWidth = 60;
        private static readonly double marginTop = 200;
        private static readonly double valuesMargin = 10;
        private static readonly double rectSize = 5;
        private static readonly double barMargin = 2;
        private static readonly int markersCount = 7;

        private Product[] products;
        private Dictionary<int, bool> quartersToExport;

        private bool q1;
        private bool q2;
        private bool q3;
        private bool q4;
        private int exportedProductsCount = 6;
        private double stepValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.products = Product.GetProducts();
            this.quartersToExport = new Dictionary<int, bool>();
            this.InitializeData();
            this.InitializeControls();
        }

        private void InitializeControls()
        {
            this.checkBoxQ1.CheckStateChanged += checkBoxQ1_CheckStateChanged;
            this.checkBoxQ2.CheckStateChanged += checkBoxQ2_CheckStateChanged;
            this.checkBoxQ3.CheckStateChanged += checkBoxQ3_CheckStateChanged;
            this.checkBoxQ4.CheckStateChanged += checkBoxQ4_CheckStateChanged;
            this.checkBoxQ1.Checked = true;
            this.checkBoxQ2.Checked = true;
            this.checkBoxQ3.Checked = true;
            this.checkBoxQ4.Checked = true;
            this.dropDownListNumberOfProducts.SelectedIndexChanged += dropDownListNumberOfProducts_SelectedIndexChanged;
            this.dropDownListNumberOfProducts.SelectedIndex = 5;
            this.chartValueStepEditor.ValueChanged += chartValueStepEditor_ValueChanged;
            this.pictureBox1.Image = Image.FromFile(@"..\PdfProcessing\PdfChartIntegration\barChart.PNG");
        }

        void chartValueStepEditor_ValueChanged(object sender, EventArgs e)
        {
            stepValue = (double)this.chartValueStepEditor.Value;
        }

        void dropDownListNumberOfProducts_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.exportedProductsCount = int.Parse(this.dropDownListNumberOfProducts.Text);
        }

        void checkBoxQ4_CheckStateChanged(object sender, EventArgs e)
        {
            Q4 = this.checkBoxQ4.Checked;
        }

        void checkBoxQ3_CheckStateChanged(object sender, EventArgs e)
        {
            Q3 = this.checkBoxQ3.Checked;
        }

        void checkBoxQ2_CheckStateChanged(object sender, EventArgs e)
        {
            Q2 = this.checkBoxQ2.Checked;
        }

        void checkBoxQ1_CheckStateChanged(object sender, EventArgs e)
        {
            Q1 = this.checkBoxQ1.Checked;
        }

        private void InitializeData()
        {
            this.quartersToExport.Add(0, false);
            this.quartersToExport.Add(1, false);
            this.quartersToExport.Add(2, false);
            this.quartersToExport.Add(3, false);

            this.Q1 = true;
            this.Q2 = true;
            this.Q3 = true;
            this.Q4 = true;
            this.ExportedProductsCount = this.products.Length;
            this.StepValue = 5000;
        }

        public int ExportedProductsCount
        {
            get { return this.exportedProductsCount; }
            set
            {
                if (this.exportedProductsCount != value)
                {
                    this.exportedProductsCount = value;
                }
            }
        }

        public double StepValue
        {
            get { return this.stepValue; }
            set
            {
                if (this.stepValue != value)
                {
                    this.stepValue = value;
                }
            }
        }

        public bool Q1
        {
            get { return this.q1; }
            set
            {
                if (this.q1 != value)
                {
                    this.q1 = value;
                    this.quartersToExport[0] = this.q1;
                    this.buttonSave.Enabled = this.quartersToExport.Values.Contains(true);
                }
            }
        }

        public bool Q2
        {
            get { return this.q2; }
            set
            {
                if (this.q2 != value)
                {
                    this.q2 = value;
                    this.quartersToExport[1] = this.q2;
                    this.buttonSave.Enabled = this.quartersToExport.Values.Contains(true);
                }
            }
        }

        public bool Q3
        {
            get { return this.q3; }
            set
            {
                if (this.q3 != value)
                {
                    this.q3 = value;
                    this.quartersToExport[2] = this.q3;
                    this.buttonSave.Enabled = this.quartersToExport.Values.Contains(true);
                }
            }
        }

        public bool Q4
        {
            get { return this.q4; }
            set
            {
                if (this.q4 != value)
                {
                    this.q4 = value;
                    this.quartersToExport[3] = this.q4;
                    this.buttonSave.Enabled = this.quartersToExport.Values.Contains(true);
                }
            }
        }

        private void Export()
        {
            Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider formatProvider = new Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.PdfFormatProvider();
            formatProvider.ExportSettings.ImageQuality = Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Export.ImageQuality.High;

            if (!this.quartersToExport.Values.Contains(true))
            {
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = String.Format("{0} files|*.{1}", "Pdf", "pdf");
            dialog.FileName = "PdfBarChartGeneration";

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
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private RadFixedDocument CreateDocument()
        {
            RadFixedDocument document = new RadFixedDocument();
            RadFixedPage page = document.Pages.AddPage();
            page.Size = new System.Windows.Size(792, 1128);
            FixedContentEditor editor = new FixedContentEditor(page);
            editor.GraphicProperties.IsFilled = false;
            this.DrawCompanyLogo(editor);

            double leftMargin = (page.Size.Width - chartWidth) / 2;
            double offsetX;
            double offsetY;

            this.DrawChartFrame(leftMargin, editor, out offsetX, out offsetY);

            double offset = 20;
            double textWidth = 0;
            double rectMargin = 2;

            List<Block> blocks = new List<Block>();
            for (int i = 0; i < this.ExportedProductsCount; i++)
            {
                Block block = new Block();
                block.TextProperties.CopyFrom(editor.TextProperties);
                block.InsertText(this.products[i].Name);
                block.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Left;
                blocks.Add(block);

                textWidth += rectSize + rectMargin + offset;
                textWidth += block.Measure().Width;
            }

            RgbColor[] colors = { new RgbColor(49, 204, 118), 
                                  new RgbColor(154, 92, 179), 
                                  new RgbColor(56, 152, 216), 
                                  new RgbColor(243, 200, 41), 
                                  new RgbColor(230, 130, 44), 
                                  new RgbColor(230, 80, 65) };

            RgbColor[] secondaryColors = { 
                                  new RgbColor(197, 243, 217), 
                                  new RgbColor(210, 179, 223),
                                  new RgbColor(163, 209, 240), 
                                  new RgbColor(249, 230, 148), 
                                  new RgbColor(246, 204, 167),
                                  new RgbColor(244, 167, 160) };

            offsetX = leftMargin + ((chartWidth - textWidth) / 2);
            offsetY += 20;
            for (int i = 0; i < this.ExportedProductsCount; i++)
            {
                editor.Position.Translate(offsetX, offsetY + 2);
                Tiling tiling = CreateTiling(offsetX, offsetY, rectSize, colors[i], secondaryColors[i]);
                editor.GraphicProperties.FillColor = tiling;
                editor.DrawRectangle(new Rect(0, 0, rectSize, rectSize));

                offsetX += rectSize + rectMargin;
                editor.Position.Translate(offsetX, offsetY - 2);
                editor.GraphicProperties.FillColor = RgbColors.Black;
                editor.DrawBlock(blocks[i]);
                offsetX += blocks[i].Measure().Width + offset;
            }

            offsetX = leftMargin;

            offsetY += 30;
            double markerHeight = (chartHeight - (offsetY - marginTop)) / markersCount;
            editor.Position.Translate(offsetX, offsetY);

            for (int i = markersCount - 1; i >= 0; i--)
            {
                Block labelBlock = new Block();
                labelBlock.TextProperties.CopyFrom(editor.TextProperties);
                labelBlock.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Right;
                labelBlock.InsertText(string.Format("{0:C}", i * this.StepValue));
                System.Windows.Size labelSize = labelBlock.Measure();
                labelSize.Width = markerAreaWidth;
                editor.DrawBlock(labelBlock, labelSize);

                if (i > 0)
                {
                    offsetY += markerHeight;
                    editor.Position.Translate(offsetX, offsetY);
                }
            }

            offsetX = leftMargin + markerAreaWidth + valuesMargin;

            Block blockX = new Block();
            blockX.TextProperties.CopyFrom(editor.TextProperties);
            blockX.InsertText("X");

            double center = blockX.Measure().Height / 2;
            offsetY += center;
            double valueHeight = markerHeight / this.StepValue;
            double dataAreaWidth = chartWidth - markerAreaWidth - 2 * valuesMargin;

            double sectionWidth = dataAreaWidth / this.GetQuartersToExportCount();
            double barWidth = (sectionWidth - 2 * valuesMargin - 2 * this.ExportedProductsCount * barMargin) / this.ExportedProductsCount;

            for (int j = 0; j < this.quartersToExport.Keys.Count; j++)
            {
                if (!this.quartersToExport[j])
                {
                    continue;
                }

                editor.Position.Translate(offsetX, offsetY + 5);
                editor.GraphicProperties.FillColor = RgbColors.Black;

                Block qBlock = new Block();
                qBlock.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Center;
                qBlock.TextProperties.CopyFrom(editor.TextProperties);
                qBlock.InsertText(string.Format("Q{0}", j + 1));
                System.Windows.Size qBlockSize = qBlock.Measure();
                qBlockSize.Width = sectionWidth;
                editor.DrawBlock(qBlock, qBlockSize);

                editor.Position.Translate(0, 0);
                offsetX += valuesMargin;
                for (int i = 0; i < this.ExportedProductsCount; i++)
                {
                    Product product = this.products[i];
                    double h = product.Q[j] * valueHeight;
                    offsetX += barMargin;
                    Tiling tiling = CreateTiling(offsetX, offsetY - h, barWidth, colors[i], secondaryColors[i]);
                    editor.GraphicProperties.FillColor = tiling;
                    editor.DrawRectangle(new Rect(offsetX, offsetY - h, barWidth, h));
                    offsetX += barWidth + barMargin;
                }

                offsetX += valuesMargin;
            }

            offsetX = leftMargin + markerAreaWidth + valuesMargin;
            DrawBarLine(editor, offsetX, offsetY, dataAreaWidth);

            return document;
        }

        private void DrawCompanyLogo(FixedContentEditor editor)
        {
            editor.Position.Translate(230, 80);
            Image image = Image.FromFile(@"..\PdfProcessing\PdfChartIntegration\abCompany.jpg");
            using (Stream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                editor.DrawImage(stream);
            }
            editor.Position.Translate(0, 0);
        }

        private void DrawChartFrame(double leftMargin, FixedContentEditor editor, out double offsetX, out double offsetY)
        {
            offsetX = leftMargin;
            offsetY = marginTop;
            editor.DrawRectangle(new Rect(offsetX, offsetY, chartWidth, chartHeight));
            offsetY += 10;
            editor.Position.Translate(offsetX, offsetY);

            Block headerText = new Block();
            headerText.HorizontalAlignment = Telerik.Windows.Documents.Fixed.Model.Editing.Flow.HorizontalAlignment.Center;
            headerText.TextProperties.FontSize = 18;
            headerText.TextProperties.TrySetFont(new System.Windows.Media.FontFamily("Calibri"), FontStyles.Normal, FontWeights.Bold);
            headerText.InsertText("2013");
            System.Windows.Size blockSize = headerText.Measure();
            blockSize.Width = chartWidth;
            editor.DrawBlock(headerText, blockSize);

            offsetY += 30;
            editor.Position.Translate(offsetX, offsetY);

            editor.TextProperties.TrySetFont(new System.Windows.Media.FontFamily("Calibri"));
            editor.TextProperties.FontSize = 10;
            editor.GraphicProperties.IsFilled = true;
            editor.GraphicProperties.IsStroked = false;
        }

        private static Tiling CreateTiling(double offsetX, double offsetY, double width, SimpleColor color, SimpleColor secondaryColor)
        {
            Tiling tiling = new Tiling(new Rect(0, 0, width, 2));
            tiling.Position.Translate(offsetX, offsetY);
            var tilingEditor = new FixedContentEditor(tiling);
            tilingEditor.GraphicProperties.IsStroked = false;
            tilingEditor.GraphicProperties.FillColor = color;
            tilingEditor.DrawRectangle(new Rect(0, 0, width, 1));
            LinearGradient gradient = new LinearGradient(new System.Windows.Point(0, 0), new System.Windows.Point(width, 0));
            gradient.GradientStops.Add(new GradientStop(color, 0));
            gradient.GradientStops.Add(new GradientStop(secondaryColor, 0.6));
            gradient.GradientStops.Add(new GradientStop(color, 1));
            tilingEditor.GraphicProperties.FillColor = gradient;
            tilingEditor.DrawRectangle(new Rect(0, 1, width, 1));

            return tiling;
        }

        private static void DrawBarLine(FixedContentEditor editor, double offsetX, double offsetY, double width)
        {
            editor.GraphicProperties.FillColor = RgbColors.Black;
            editor.GraphicProperties.StrokeThickness = 1;
            editor.GraphicProperties.IsFilled = false;
            editor.GraphicProperties.IsStroked = true;
            editor.DrawLine(new System.Windows.Point(offsetX, offsetY), new System.Windows.Point(offsetX + width, offsetY));
        }

        private double GetQuartersToExportCount()
        {
            int counter = 0;
            foreach (bool shouldExportQ in this.quartersToExport.Values)
            {
                if (shouldExportQ)
                {
                    counter++;
                }
            }

            return counter;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Export();
        }
    }
}
