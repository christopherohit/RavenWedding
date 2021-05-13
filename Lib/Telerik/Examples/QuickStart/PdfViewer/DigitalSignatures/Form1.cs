using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.PdfViewer.DigitalSignatures
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

            this.LoadDocumentWithStream("Telerik.Examples.WinControls.PdfViewer.DigitalSignatures.Unknown.pdf");
            this.radPdfViewerNavigator1.MinimumSize = new Size(0, 60);
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.invalidSignatureRadioButton.ToggleStateChanged += OnRadioButtonToggleStateChanged;
            this.unknownSignatureRadioButton.ToggleStateChanged += OnRadioButtonToggleStateChanged;
            this.openDocumentButton.Click += OnOpenDocumentButtonClick;
        }

        private void OnRadioButtonToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off)
            {
                return;
            }

            if (this.invalidSignatureRadioButton.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.LoadDocumentWithStream("Telerik.Examples.WinControls.PdfViewer.DigitalSignatures.Invalid.pdf");
            }
            else
            {
                this.LoadDocumentWithStream("Telerik.Examples.WinControls.PdfViewer.DigitalSignatures.Unknown.pdf");
            }
        }

        private void OnOpenDocumentButtonClick(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            dialog.Title = "Select a PDF file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                this.radPdfViewer1.LoadDocument(path);

                this.invalidSignatureRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
                this.unknownSignatureRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off;
            }
        }
        
        private void LoadDocumentWithStream(string name)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            this.radPdfViewer1.LoadDocument(stream);
        }
    }
}
