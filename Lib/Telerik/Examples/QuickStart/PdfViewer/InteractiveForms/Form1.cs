using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using System.Reflection;
using System.IO;

namespace Telerik.Examples.WinControls.PdfViewer.InteractiveForms
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

            this.LoadDocumentWithStream("Telerik.Examples.WinControls.PdfViewer.InteractiveForms.InteractiveForms.pdf");
            this.radPdfViewerNavigator1.MinimumSize = new Size(0, 60);
        }

        private void LoadDocumentWithStream(string name)
        {
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            this.radPdfViewer1.LoadDocument(stream);
        }
    }
}
