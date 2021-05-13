using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.Barcode.PDF417
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.radGroupBox1;

            Random rnd = new Random();
            this.radTextBoxOrderNumber.Text = rnd.Next(1000000, 10000000).ToString();
            this.radDropDownListCountry.DataSource = Countries.CountryNames;
            this.radBarcode1.Symbology = new Telerik.WinControls.UI.Barcode.Symbology.PDF417(11, 6, 1);

            this.radButtonGenerate.Click += this.RadButtonGenerate_Click;
            this.radButtonExport.Click += this.RadButtonExport_Click;
        }

        private void SetBarcodeValue()
        {
            string barcodeValue =
                   this.radTextBoxOrderNumber.Text + " " +
                   this.radDropDownListCountry.SelectedItem.Text + " " +
                   this.radTextBoxCity.Text + " " +
                   this.radTextBoxAddress.Text + " " +
                   this.radDateTimePickerDate.Value.ToShortDateString() + " " +
                   this.radTextBoxFullName.Text + " " +
                   this.radTextBoxPhoneNumber.Text;

            this.radBarcode1.Value = barcodeValue;
        }

        private void RadButtonGenerate_Click(object sender, EventArgs e)
        {
            this.SetBarcodeValue();
        }

        private void RadButtonExport_Click(object sender, EventArgs e)
        {
            this.SetBarcodeValue();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Png (*.png)|*.png";
                saveFileDialog.FileName = "PDF417Code";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = this.radBarcode1.ExportToImage();
                    img.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
            }
        }
    }
}
