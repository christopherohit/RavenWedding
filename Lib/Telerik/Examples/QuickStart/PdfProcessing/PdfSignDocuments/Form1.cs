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
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf;
using Telerik.Windows.Documents.Fixed.Model;
using Telerik.Windows.Documents.Fixed.Model.Annotations;
using Telerik.Windows.Documents.Fixed.Model.DigitalSignatures;
using Telerik.Windows.Documents.Fixed.Model.Editing;
using Telerik.Windows.Documents.Fixed.Model.InteractiveForms;
using Telerik.Windows.Documents.Fixed.Model.Resources;

namespace Telerik.Examples.WinControls.PdfProcessing.PdfSignDocuments
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        public string unsignedDocFile = @"..\PdfProcessing\PdfSignDocuments\SampleData\Unsigned.pdf";
        public string signatureFile = @"..\PdfProcessing\PdfSignDocuments\SampleData\JohnDoe";

        public Form1()
        {
            InitializeComponent();
            radPdfViewer1.EnableThumbnails = false;
            radPdfViewer1.LoadDocument(unsignedDocFile);

            radPdfViewerNavigator1.AssociatedViewer = radPdfViewer1;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            radPdfViewer1.UnloadDocument();
            RadFixedDocument document;
            PdfFormatProvider provider = new PdfFormatProvider();
            using (Stream stream = new FileStream(unsignedDocFile, FileMode.Open, FileAccess.Read))
            {
                document = provider.Import(stream);

                byte[] fileAllBytes;
                using (Stream certificateStream = new FileStream(signatureFile, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        certificateStream.CopyTo(ms);
                        fileAllBytes = ms.ToArray();
                    }
                }

                if (fileAllBytes.Length == 0)
                    return;

                AddSignature(document, fileAllBytes);

                ReloadSignedFile(document);
            }
        }

        private static void AddSignature(RadFixedDocument document, byte[] certificateFileBytes)
        {
            FormSource formSource = new Telerik.Windows.Documents.Fixed.Model.Resources.FormSource();
            formSource.Size = new System.Windows.Size(420, 150);

            var certificate = new X509Certificate2(certificateFileBytes, "johndoe");
            SignatureField signatureField = document.AcroForm.FormFields.Where(f => f.FieldType == FormFieldType.Signature).FirstOrDefault() as SignatureField;
            signatureField.Signature = new Signature(certificate);

            SignatureWidget widget = signatureField.Widgets.FirstOrDefault();
            if (widget != null)
            {
                formSource = widget.Content.NormalContentSource;

                FixedContentEditor ed = new FixedContentEditor(formSource);
                ed.TextProperties.FontSize = 80;
                ed.Position.Translate(30, 0);
                ed.DrawText("John Doe");
                ed.Position.Translate(0, 90);
                ed.TextProperties.FontSize = 25;
                ed.DrawText("Digitally signed on: " + DateTime.Now.ToString());
                ed.Position.Translate(40, 120);
                ed.TextProperties.FontSize = 20;
                ed.DrawText("(Click here to view the signature info)");
            }

            document.Pages[0].Annotations.Add(widget);
        }


        private void ReloadSignedFile(RadFixedDocument document)
        {
            MemoryStream outputStream = new MemoryStream();

            PdfFormatProvider provider = new PdfFormatProvider();
            provider.Export(document, outputStream);

            this.radPdfViewer1.LoadDocument(outputStream);
        }
    }
}
