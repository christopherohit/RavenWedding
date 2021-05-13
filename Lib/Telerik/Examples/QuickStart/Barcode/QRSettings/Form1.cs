using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Barcode.Symbology;

namespace Telerik.Examples.WinControls.Barcode.QrSettings
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenteredControl = this.radGroupBox1;   

            this.PopulateData();

            this.UpdateLinkBarcodeValue();
            this.UpdateTextBarcodeValue();
            this.UpdateContactBarcodeValue();
            this.UpdateLocationBarcodeValue();
        }

        private void PopulateData()
        {
            Dictionary<ErrorCorrectionLevel, string> ecls = new Dictionary<ErrorCorrectionLevel, string>() { { ErrorCorrectionLevel.H, "H" }, { ErrorCorrectionLevel.L, "L" }, { ErrorCorrectionLevel.M, "M" }, { ErrorCorrectionLevel.Q, "Q" } };
            Dictionary<CodeMode, string> encodings = new Dictionary<CodeMode, string>() { { CodeMode.Alphanumeric, "Alphanumeric" }, { CodeMode.Byte, "Byte" }, { CodeMode.Kanji, "Kanji" }, { CodeMode.Numeric, "Numeric" } };
            Dictionary<FNC1Mode, string> fnc1Modes = new Dictionary<FNC1Mode, string>() { { FNC1Mode.None, "None" }, { FNC1Mode.FirstPosition, "First position" }, { FNC1Mode.SecondPosition, "Second position" } };
            Dictionary<ECIMode, string> eciNumbers = new Dictionary<ECIMode, string>()
            {
                { ECIMode.None, "None" }, { ECIMode.ISO8859_1, "ISO8859_7" }, { ECIMode.ISO8859_1En, "ISO8859_1En" }, { ECIMode.ISO8859_2, "ISO8859_2" }, { ECIMode.ISO8859_3, "ISO8859_3" }, { ECIMode.ISO8859_4, "ISO8859_4" },
                { ECIMode.ISO8859_5, "ISO8859_5" }, { ECIMode.ISO8859_6, "ISO8859_6" }, { ECIMode.ISO8859_7, "ISO8859_7" }, { ECIMode.ISO8859_8, "ISO8859_8" }, { ECIMode.ISO8859_9, "ISO8859_9" }, { ECIMode.ISO8859_11, "ISO8859_11" },
                { ECIMode.ISO8859_13, "ISO8859_13" }, { ECIMode.ISO8859_15, "ISO8859_15" }, { ECIMode.CP437, "CP437" }, { ECIMode.ISO646US, "ISO646US" }, { ECIMode.UTF8, "UTF8" }, { ECIMode.Windows1250, "Windows1250" },
                { ECIMode.Windows1251, "Windows1251" }, { ECIMode.Windows1252, "Windows1252" }, { ECIMode.Windows1256, "Windows1256" }
            };
            Dictionary<int, string> versions = new Dictionary<int, string>()
            {
                { 0, "Auto" }, { 1, "1" }, { 2, "2" }, { 3, "3" }, { 4, "4" }, { 5, "6" }, { 7, "7" }, { 8, "8" }, { 9, "9" }, { 10, "10" },
                { 11, "11" }, { 12, "12" }, { 13, "13" }, { 14, "14" }, { 15, "15" }, { 16, "16" }, { 17, "17" }, { 18, "18" }, { 19, "19" }, { 20, "20" },
                { 21, "21" }, { 22, "22" }, { 23, "23" }, { 24, "24" }, { 25, "25" }, { 26, "26" }, { 27, "27" }, { 28, "28" }, { 29, "29" }, { 30, "30" },
                { 31, "31" }, { 32, "32" }, { 33, "33" }, { 34, "34" }, { 35, "35" }, { 36, "36" }, { 37, "37" }, { 38, "38" }, { 39, "39" }, { 40, "40" }
            };

            this.radDropDownListLinkECL.ValueMember = "Key";
            this.radDropDownListLinkECL.DisplayMember = "Value";
            this.radDropDownListLinkECL.DataSource = ecls;

            this.radDropDownListLinkEncoding.ValueMember = "Key";
            this.radDropDownListLinkEncoding.DisplayMember = "Value";
            this.radDropDownListLinkEncoding.DataSource = encodings;

            this.radDropDownListLinkVersion.ValueMember = "Key";
            this.radDropDownListLinkVersion.DisplayMember = "Value";
            this.radDropDownListLinkVersion.DataSource = versions;

            this.radDropDownListTextECL.ValueMember = "Key";
            this.radDropDownListTextECL.DisplayMember = "Value";
            this.radDropDownListTextECL.DataSource = ecls;

            this.radDropDownListTextVersion.ValueMember = "Key";
            this.radDropDownListTextVersion.DisplayMember = "Value";
            this.radDropDownListTextVersion.DataSource = versions;

            this.radDropDownListTextFnc1Mode.ValueMember = "Key";
            this.radDropDownListTextFnc1Mode.DisplayMember = "Value";
            this.radDropDownListTextFnc1Mode.DataSource = fnc1Modes;

            this.radDropDownListTextEncoding.ValueMember = "Key";
            this.radDropDownListTextEncoding.DisplayMember = "Value";
            this.radDropDownListTextEncoding.DataSource = encodings;

            this.radDropDownListTextEciNumber.ValueMember = "Key";
            this.radDropDownListTextEciNumber.DisplayMember = "Value";
            this.radDropDownListTextEciNumber.DataSource = eciNumbers;

            this.radDropDownListContactECL.ValueMember = "Key";
            this.radDropDownListContactECL.DisplayMember = "Value";
            this.radDropDownListContactECL.DataSource = ecls;

            this.radDropDownListContactVersion.ValueMember = "Key";
            this.radDropDownListContactVersion.DisplayMember = "Value";
            this.radDropDownListContactVersion.DataSource = versions;

            this.radDropDownListLocationECL.ValueMember = "Key";
            this.radDropDownListLocationECL.DisplayMember = "Value";
            this.radDropDownListLocationECL.DataSource = ecls;

            this.radDropDownListLocationVersion.ValueMember = "Key";
            this.radDropDownListLocationVersion.DisplayMember = "Value";
            this.radDropDownListLocationVersion.DataSource = versions;
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radDropDownListTextFnc1Mode.SelectedIndexChanged += delegate { this.radTextBoxAppIndicator.Enabled = this.radDropDownListTextFnc1Mode.SelectedIndex != 0; };

            this.radButtonLinkGenerate.Click += this.RadButtonLinkGenerate_Click;
            this.radButtonLinkExport.Click += this.RadButtonLinkExport_Click;

            this.radButtonTextGenerate.Click += this.RadButtonTextGenerate_Click;
            this.radButtonTextExport.Click += this.RadButtonTextExport_Click;

            this.radButtonContactGenerate.Click += this.RadButtonContactGenerate_Click;
            this.radButtonContactExport.Click += this.RadButtonContactExport_Click;

            this.radButtonLocationGenerate.Click += this.RadButtonLocationGenerate_Click;
            this.radButtonLocationExport.Click += this.RadButtonLocationExport_Click;
        }

        private void RadButtonLinkGenerate_Click(object sender, EventArgs e)
        {
            this.UpdateLinkBarcodeValue();
        }

        private void RadButtonLinkExport_Click(object sender, EventArgs e)
        {
            this.UpdateLinkBarcodeValue();
            this.ExportBarcode(this.radBarcodeLink);
        }

        private void RadButtonTextGenerate_Click(object sender, EventArgs e)
        {
            this.UpdateTextBarcodeValue();
        }

        private void RadButtonTextExport_Click(object sender, EventArgs e)
        {
            this.UpdateTextBarcodeValue();
            this.ExportBarcode(this.radBarcodeText);
        }

        private void RadButtonContactGenerate_Click(object sender, EventArgs e)
        {
            this.UpdateContactBarcodeValue();
        }

        private void RadButtonContactExport_Click(object sender, EventArgs e)
        {
            this.UpdateContactBarcodeValue();
            this.ExportBarcode(this.radBarcodeContact);
        }

        private void RadButtonLocationGenerate_Click(object sender, EventArgs e)
        {
            this.UpdateLocationBarcodeValue();
        }

        private void RadButtonLocationExport_Click(object sender, EventArgs e)
        {
            this.UpdateLocationBarcodeValue();
            this.ExportBarcode(this.radBarcodeLocation);
        }

        private void UpdateLinkBarcodeValue()
        {
            try
            {
                QRCode qrLink = new QRCode(
                    (CodeMode)this.radDropDownListLinkEncoding.SelectedValue,
                    (int)this.radDropDownListLinkVersion.SelectedValue,
                    (ErrorCorrectionLevel)this.radDropDownListLinkECL.SelectedValue,
                    ECIMode.UTF8, FNC1Mode.None, null);
                this.radBarcodeLink.Symbology = qrLink;
                this.radBarcodeLink.Value = this.radTextBoxLink.Text;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }
        }

        private void UpdateTextBarcodeValue()
        {
            try
            {
                QRCode qrText = new QRCode(
                    (CodeMode)this.radDropDownListTextEncoding.SelectedValue,
                    (int)this.radDropDownListTextVersion.SelectedValue,
                    (ErrorCorrectionLevel)this.radDropDownListTextECL.SelectedValue,
                    (ECIMode)this.radDropDownListTextEciNumber.SelectedValue,
                    (FNC1Mode)this.radDropDownListTextFnc1Mode.SelectedValue,
                    this.radTextBoxAppIndicator.Enabled ? this.radTextBoxAppIndicator.Text : null);
                this.radBarcodeText.Symbology = qrText;
                this.radBarcodeText.Value = this.radTextBoxText.Text;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }
        }

        private void UpdateContactBarcodeValue()
        {
            try
            {
                string vCardText = "BEGIN:VCARD\r\nVERSION:2.1\r\nN:";
                vCardText += this.radTextBoxContactName.Text + " " + this.radTextBoxContactFamily.Text + "\r\n";
                vCardText += "TEL;WORK;VOICE:" + this.radTextBoxContactPhone.Text + "\r\n";
                vCardText += "EMAIL;PREF;INTERNET:" + this.radTextBoxContactEmail.Text + "\r\n";
                vCardText += "END:VCARD";

                QRCode qrContact = new QRCode(CodeMode.Byte, (int)this.radDropDownListContactVersion.SelectedValue, (ErrorCorrectionLevel)this.radDropDownListContactECL.SelectedValue, ECIMode.None, FNC1Mode.None, null);
                this.radBarcodeContact.Symbology = qrContact;
                this.radBarcodeContact.Value = vCardText;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }
        }

        private void UpdateLocationBarcodeValue()
        {
            try
            {
                double latDegrees;
                double longDegrees;
                double latMinutes;
                double longMinutes;
                double latSeconds;
                double longSeconds;
                double latitude, longitude;

                double.TryParse(this.radTextBoxLocationLatDegrees.Text, out latDegrees);
                double.TryParse(this.radTextBoxLocationLatMinutes.Text, out latMinutes);
                double.TryParse(this.radTextBoxLocationLatSeconds.Text, out latSeconds);
                double.TryParse(this.radTextBoxLocationLongDegrees.Text, out longDegrees);
                double.TryParse(this.radTextBoxLocationLongMinutes.Text, out longMinutes);
                double.TryParse(this.radTextBoxLocationLongSeconds.Text, out longSeconds);

                if (latDegrees < -90 || latDegrees > 90)
                {
                    latDegrees = 1;
                }

                if (longDegrees < -90 || longDegrees > 90)
                {
                    latDegrees = 1;
                }

                if (latMinutes < 0 || latMinutes > 59)
                {
                    latMinutes = 1;
                }

                if (longMinutes < 0 || longMinutes > 59)
                {
                    longMinutes = 1;
                }

                if (latSeconds < 0 || latSeconds > 59.99)
                {
                    latSeconds = 1;
                }

                if (longSeconds < 0 || longSeconds > 59.99)
                {
                    longSeconds = 1;
                }

                if (latDegrees < 0)
                {
                    latitude = latDegrees - (latMinutes / 60) - (latSeconds / 3600);
                }
                else
                {
                    latitude = latDegrees + (latMinutes / 60) + (latSeconds / 3600);
                }

                if (longDegrees < 0)
                {
                    longitude = longDegrees - (longMinutes / 60) - (longSeconds / 3600);
                }
                else
                {
                    longitude = longDegrees + (longMinutes / 60) - (longSeconds / 3600);
                }

                Math.Round(latitude, 10);
                Math.Round(longitude, 10);

                string url = "http://maps.google.com/maps?q=" + latitude.ToString() + "," + longitude.ToString() + "&num=1&t=m&z=12";

                QRCode qrLocation = new QRCode(CodeMode.Byte, (int)this.radDropDownListLinkVersion.SelectedValue, (ErrorCorrectionLevel)this.radDropDownListLocationECL.SelectedValue, ECIMode.None, FNC1Mode.None, null);
                this.radBarcodeLocation.Symbology = qrLocation;
                this.radBarcodeLocation.Value = url;
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }
        }

        private void ExportBarcode(RadBarcode barcode)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Png (*.png)|*.png";
                saveFileDialog.FileName = "QRCode";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = barcode.ExportToImage();
                    img.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
            }
        }
    }
}
