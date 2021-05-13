using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using Telerik.QuickStart.WinControls;

namespace Telerik.Examples.WinControls.PdfViewer.FirstLook
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
            this.radPDFCommandBar1.MinimumSize = new Size(0, 60);
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Telerik.Examples.WinControls.PdfViewer.FirstLook.Sample.pdf");
            this.radPdfViewer1.LoadDocument(stream);
            this.radPdfViewer1.ShowThumbnails();
        }
    }
}