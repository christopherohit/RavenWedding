using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.Printing
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private RadChartView radChartView1;
        private RadPrintDocument radPrintDocument1;

        public Form1()
        {
            this.radChartView1 = new RadChartView();
            this.radChartView1.Dock = DockStyle.Fill;
            
            this.radPrintDocument1 = new RadPrintDocument();
            this.radPrintDocument1.Landscape = true;
            this.radPrintDocument1.AssociatedObject = this.radChartView1;

            this.Controls.Add(this.radChartView1);

            InitializeComponent();

          
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadData();

            this.radChartView1.ShowLegend = true;
            this.radChartView1.ChartElement.LegendElement.LegendTitle = "Expenses";
            this.radChartView1.ShowTitle = true;
            this.radChartView1.Title = "Personal monthly expenses";

            List<ImageFormat> formats = new List<ImageFormat>()
            {
                ImageFormat.Bmp,
                ImageFormat.Gif,
                ImageFormat.Jpeg,
                ImageFormat.Png,
                ImageFormat.Tiff,
            };

            this.radDropDownList1.DataSource = formats;
            this.radDropDownList1.SelectedValue = ImageFormat.Png;

            this.radSpinEditorWidth.Value = this.radChartView1.Size.Width;
            this.radSpinEditorHeight.Value = this.radChartView1.Size.Height;
        }

        private void LoadData()
        {
            LineSeries lineSeries;
            LineSeriesDataModel model = new LineSeriesDataModel();

            for (int i = 0; i < 11; i++)
            {
                lineSeries = new LineSeries();
                lineSeries.CategoryMember = "Month";
                lineSeries.ValueMember = "Expense";
                lineSeries.LegendTitle = model.GetLegendText(i);
                lineSeries.DataSource = model.GetData(i);
                lineSeries.PointSize = new SizeF(3f, 3f);

                this.radChartView1.Series.Add(lineSeries);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.radChartView1.Print(true, this.radPrintDocument1);
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            this.radChartView1.PrintPreview(this.radPrintDocument1);
        }

        private void buttonPrintSettings_Click(object sender, EventArgs e)
        {
            Form dialog = this.radChartView1.GetSettingsDialog(this.radPrintDocument1);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radChartView1.PrintPreview(this.radPrintDocument1);
            }
        }

        private void radButtonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = string.Format("Image (*.{0};)|*.{0}", this.radDropDownList1.Text.ToLower());

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radChartView1.ExportToImage(dialog.FileName, new Size((int)this.radSpinEditorWidth.Value, (int)this.radSpinEditorHeight.Value), this.radDropDownList1.SelectedValue as ImageFormat);

                RadMessageBox.Instance.ThemeName = this.CurrentThemeName;

                if (RadMessageBox.Show("Export complete. Would you like to open the file?", "Export complete", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Process.Start(dialog.FileName);
                }
            }
        }

        protected override void WireEvents()
        {
            this.buttonPrint.Click += this.buttonPrint_Click;
            this.buttonPrintPreview.Click += this.buttonPrintPreview_Click;
            this.buttonPrintSettings.Click += this.buttonPrintSettings_Click;
            this.radButtonExport.Click += radButtonExport_Click;
        }
    }
}
