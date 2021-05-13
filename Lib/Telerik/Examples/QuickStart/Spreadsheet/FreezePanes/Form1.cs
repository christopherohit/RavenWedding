using System;
using System.IO;
using Telerik.QuickStart.WinControls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;

namespace Telerik.Examples.WinControls.Spreadsheet.FreezePanes
{
    public partial class Form1 : ExamplesForm
    {
        private const string SampleDocumentPath = @"..\Spreadsheet\SampleData\FreezePanes.xlsx";

        public Form1()
        {
            this.StartWaiting();
            InitializeComponent();
            this.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items[3].Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = this.radSpreadsheetRibbonBar1.RibbonBarElement.TabStripElement.Items[5];
            this.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.SystemButtons.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.ShouldHandleMouseInput = false;
            this.radSpreadsheetRibbonBar1.RibbonBarElement.RibbonCaption.CanManageOwnerForm = false;

            byte[] bytes = File.ReadAllBytes(SampleDocumentPath);
            this.radSpreadsheet1.SpreadsheetElement.Workbook = (WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider") as XlsxFormatProvider).Import(bytes);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.StopWaiting();
            this.radSpreadsheet1.SpreadsheetElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
        }
    }
}
