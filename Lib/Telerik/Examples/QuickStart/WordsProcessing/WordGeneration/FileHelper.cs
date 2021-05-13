using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using Telerik.Windows.Documents.Common.FormatProviders;
using Telerik.Windows.Documents.Flow.FormatProviders.Docx;
using Telerik.Windows.Documents.Flow.FormatProviders.Rtf;
using Telerik.Windows.Documents.Flow.FormatProviders.Txt;
using Telerik.Windows.Documents.Flow.Model;
using System.Windows.Forms;

namespace Telerik.Examples.WinControls.WordsProcessing.WordGeneration
{
    public static class FileHelper
    {
        public static void SaveDocument(RadFlowDocument document, string selectedFromat)
        {
            IFormatProvider<RadFlowDocument> formatProvider = null;
            switch (selectedFromat)
            {
                case "Docx":
                    formatProvider = new DocxFormatProvider();
                    break;
                case "Rtf":
                    formatProvider = new RtfFormatProvider();
                    break;
                case "Txt":
                    formatProvider = new TxtFormatProvider();
                    break;
            }
            if (formatProvider == null)
            {
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = String.Format("{0} files|*{1}|All files (*.*)|*.*",
                selectedFromat,
                formatProvider.SupportedExtensions.First());
            dialog.FilterIndex = 1;
            dialog.FileName = "WordDocumentGeneration";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = dialog.OpenFile())
                    {
                        formatProvider.Export(document, stream);
                    }
                }
                catch (IOException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        public static Stream GetSampleResourceStream(string resource)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(resource);
            if (stream != null)
            {
                return stream;
            }

            return null;
        }        

        private static Uri GetResourceUri(string resource)
        {
            AssemblyName assemblyName = new AssemblyName(typeof(FileHelper).Assembly.FullName);
            string resourcePath = "/" + assemblyName.Name + ";component/" + resource;
            Uri resourceUri = new Uri(resourcePath, UriKind.Relative);

            return resourceUri;
        }
    }
}
