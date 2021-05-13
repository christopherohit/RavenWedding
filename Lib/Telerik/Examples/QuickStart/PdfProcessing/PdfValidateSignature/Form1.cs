using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.DigitalSignatures;
using Telerik.Windows.Documents.Fixed.Model.InteractiveForms;

namespace Telerik.Examples.WinControls.PdfProcessing.PdfValidateSignature
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        private enum ValidationStatus { None, Valid, Unknown, Invalid }
        public Form1()
        {
            InitializeComponent();
            this.Validate(0);
            this.signatureTypeListBox.SelectedIndex = 0;
            this.signatureTypeListBox.SelectedIndexChanged += SignatureTypeListBox_SelectedIndexChanged;
            statusImage.Text = "";
            signatureTypeListBox.AutoSizeItems = true;
            signatureTypeListBox.Items[0].Image = Image.FromFile(@"..\PdfProcessing\PdfValidateSignature\Images\24\ValidSignature.png");
            signatureTypeListBox.Items[1].Image = Image.FromFile(@"..\PdfProcessing\PdfValidateSignature\Images\24\InvalidSignature.png");
            signatureTypeListBox.Items[2].Image = Image.FromFile(@"..\PdfProcessing\PdfValidateSignature\Images\24\UnknownSignature.png");
            this.tableLayoutPanel1.BackColor = Color.Transparent;
      
        }

        private void SignatureTypeListBox_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            var listbox = sender as RadListElement;
            if (listbox == null || listbox.SelectedIndex == -1)
                return;

            this.Validate(listbox.SelectedIndex);
        }

        private void Validate(int documentIndex)
        {
            string fileName = documentIndex == 1 ? "Invalid.pdf" : "Unknown.pdf";
            fileName = @"..\PdfProcessing\PdfValidateSignature\SampleData\" + fileName;

            using (Stream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                X509VerificationFlags verificationFlags;
                if (documentIndex == 0)
                {
                    // We set the following flag for demonstration purposes only.
                    // This flag ignores a warning regarding certificate authority which is missing in the Windows trusted root certificates.
                    // The result of this setting is a valid general validation status.
                    // In real scenario this flag should most probably not be used. The validation process should be based only on Windows trusted root certificates.
                    verificationFlags = X509VerificationFlags.AllowUnknownCertificateAuthority;
                }
                else
                {
                    verificationFlags = X509VerificationFlags.NoFlag;
                }

                this.Validate(stream, verificationFlags);
            }
        }

        private void Validate(Stream stream, X509VerificationFlags verificationFlags)
        {
            RadFixedDocument document = new PdfFormatProvider().Import(stream);

            ValidationStatus validationStatus;

            // For simplicity, the example handles only the first signature.
            var firstSignatureField = document.AcroForm.FormFields.FirstOrDefault(field => field.FieldType == FormFieldType.Signature) as SignatureField;
            if (firstSignatureField != null && firstSignatureField.Signature != null)
            {
                SignatureValidationProperties properties = new SignatureValidationProperties();
                properties.Chain.ChainPolicy.VerificationFlags = verificationFlags;

                SignatureValidationResult validationResult;
                if (firstSignatureField.Signature.TryValidate(properties, out validationResult))
                {
                    if (!validationResult.IsDocumentModified)
                    {
                        if (validationResult.IsCertificateValid)
                        {
                            validationStatus = ValidationStatus.Valid;
                        }
                        else
                        {
                            validationStatus = ValidationStatus.Unknown;
                        }
                    }
                    else
                    {
                        validationStatus = ValidationStatus.Invalid;
                    }

                    this.textBlockIsDocumentModified.Text = validationResult.IsDocumentModified.ToString();
                    this.textBlockIsCertificateValid.Text = validationResult.IsCertificateValid.ToString();
                    this.textBlockSignerInformation.Text = validationResult.SignerInformation;
                    this.textBlockHashAlgorithm.Text = validationResult.HashAlgorithm.FriendlyName;
                }
                else
                {
                    validationStatus = ValidationStatus.Invalid;

                    this.textBlockIsDocumentModified.Text = string.Empty;
                    this.textBlockIsCertificateValid.Text = "";
                    this.textBlockSignerInformation.Text = "Corrupted signature.";
                    this.textBlockHashAlgorithm.Text = string.Empty;
                }
            }
            else
            {
                validationStatus = ValidationStatus.None;

                this.textBlockIsDocumentModified.Text = string.Empty;
                this.textBlockIsCertificateValid.Text = "";
                this.textBlockSignerInformation.Text = "No signature.";
                this.textBlockHashAlgorithm.Text = string.Empty;
            }

            this.statusImage.Image = GetValidationStatusImage(validationStatus);
        }

        private static Image GetValidationStatusImage(ValidationStatus validationStatus)
        {
            string name;
            switch (validationStatus)
            {
                case ValidationStatus.None:
                    return null;
                case ValidationStatus.Valid:
                    name = "ValidSignature";
                    break;
                case ValidationStatus.Unknown:
                    name = "UnknownSignature";
                    break;
                case ValidationStatus.Invalid:
                    name = "InvalidSignature";
                    break;
                default:
                    return null;
            }

            string statusImagePath = string.Format(@"..\PdfProcessing\PdfValidateSignature\Images\24\{0}.png", name);
            return Image.FromFile(statusImagePath);
        }



        private void openYourDocument_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "PDF files (*.pdf)|*.pdf"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.signatureTypeListBox.SelectedIndex = -1;

                using (var stream = openFileDialog.OpenFile())
                {
                    this.Validate(stream, X509VerificationFlags.NoFlag);
                }
            }
        }
    }

}
