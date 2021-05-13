using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.IO;
using System.Reflection;

namespace Telerik.Examples.WinControls.PdfViewer.DigitallySignDocument
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadDocumentWithStream("Telerik.Examples.WinControls.PdfViewer.DigitallySignDocument.Unsigned.pdf");
            this.radPdfViewerNavigator1.MinimumSize = new Size(0, 60);
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.openDocumentButton.Click += OnOpenDocumentButtonClick;
            this.downloadCertificateButton.Click += OnDownloadCertificateButtonClick;
        }

        private void OnOpenDocumentButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";
            openFileDialog.Title = "Select a PDF File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.radPdfViewer1.LoadDocument(openFileDialog.FileName);
                this.radPdfViewerNavigator1.UpdatePageCount();
            }
        }

        private void OnDownloadCertificateButtonClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PFX file (*.pfx)|*.pfx";
            saveFileDialog.FileName = "JohnDoe";
            saveFileDialog.DefaultExt = ".pfx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream outputStream = saveFileDialog.OpenFile())
                {
                    using (Stream inputStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Telerik.Examples.WinControls.PdfViewer.DigitallySignDocument.JohnDoe"))
                    {
                        inputStream.CopyTo(outputStream);
                    }
                }
            }
        }

        private void LoadDocumentWithStream(string name)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            this.radPdfViewer1.LoadDocument(stream);
        }
    }
}
