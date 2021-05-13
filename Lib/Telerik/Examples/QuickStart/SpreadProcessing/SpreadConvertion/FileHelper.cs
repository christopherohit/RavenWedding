using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.Xls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Csv;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace Telerik.Examples.WinControls.SpreadProcessing.SpreadConvertion
{
    public static class FileHelper
    {
        static FileHelper()
        {
            WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsxFormatProvider());
            WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsFormatProvider());
        }

        public static void SaveDocument(Workbook workbook, string selectedFormat)
        {
            if (workbook == null)
            {
                return;
            }

            IWorkbookFormatProvider formatProvider = GetFormatProvider(selectedFormat);
            if (formatProvider == null)
            {
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = string.Format("{0} files|*{1}|All files (*.*)|*.*", selectedFormat,
                formatProvider.SupportedExtensions.First());
            dialog.FileName = "SpreadDocumentsConvertion";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var stream = dialog.OpenFile())
                    {
                        formatProvider.Export(workbook, stream);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private static IWorkbookFormatProvider GetFormatProvider(string extension)
        {
            IWorkbookFormatProvider formatProvider;
            switch (extension)
            {
                case "Xls":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("XlsFormatProvider");
                    break;
                case "Xlsx":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider");
                    break;
                case "Csv":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("CsvFormatProvider");
                    (formatProvider as CsvFormatProvider).Settings.HasHeaderRow = true;
                    break;
                case "Txt":
                    formatProvider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider");
                    break;
                default:
                    formatProvider = null;
                    break;
            }

            return formatProvider;
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
    }
}
