using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI.Barcode.Symbology;

namespace Telerik.Examples.WinControls.Barcode.FirstLook
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            this.ScrollableArea.BackColor = System.Drawing.Color.Transparent;

            this.BackgroundImage = Properties.Resources.bcard_export;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;

            QRCode qRCode = new QRCode(CodeMode.Byte, 9, ErrorCorrectionLevel.L, ECIMode.UTF8, FNC1Mode.None, null);
            qRCode.Module = 2;
            this.radBarcode1.Symbology = qRCode;
            this.radBarcode1.Value = @"BEGIN:VCARD
VERSION:2.1
N:Steven Buchannan
TEL;WORK;VOICE:+44.71.555.48.48
ADR;WORK:;;14 Garrett Hill, SW 1 8JR, London, UK
EMAIL;PREF;INTERNET:buchannan@company.com
END:VCARD";
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (this.radBarcode1 != null)
            {
                this.CenterControl(this.radBarcode1);
                this.radBarcode1.Left -= 130;
                this.radBarcode1.Top += 60;
            }
        }
    }
}
