using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Telerik.WinForms.Controls.Spreadsheet.Worksheets;

namespace Telerik.Examples.WinControls.Spreadsheet.Protection
{
    public partial class Form1 : ExamplesForm
    {
        private const string SampleDocumentPath = @"..\Spreadsheet\SampleData\BalanceSheet.xlsx";
        private RadWorksheetEditor worksheetEditor;

        public Form1()
        {
            this.StartWaiting();
            InitializeComponent();

            byte[] bytes = File.ReadAllBytes(SampleDocumentPath);
            this.radSpreadsheet1.SpreadsheetElement.Workbook = (WorkbookFormatProvidersManager.GetProviderByName("XlsxFormatProvider") as XlsxFormatProvider).Import(bytes);
            this.radSpreadsheet1.SpreadsheetElement.ActiveSheetEditorChanged += this.RadSpreadsheet_ActiveSheetEditorChanged;

            this.RadSpreadsheet_ActiveSheetEditorChanged(null, EventArgs.Empty);
            this.radSpreadsheet1.SpreadsheetElement.ThemesManager.CurrentFontScheme = this.radSpreadsheet1.SpreadsheetElement.ThemesManager.BuiltInFontSchemes.First((scheme) => { return scheme.Name == "Angels"; });
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.UpdateProtectButtonContent();
            this.StopWaiting();
            this.radSpreadsheet1.SpreadsheetElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
        }

        private void RadSpreadsheet_ActiveSheetEditorChanged(object sender, EventArgs e)
        {
            if (this.worksheetEditor != null)
            {
                this.worksheetEditor.Selection.ActiveCellModeChanged -= this.Selection_ActiveCellModeChanged;
                if (this.worksheetEditor.Worksheet != null)
                {
                    this.worksheetEditor.Worksheet.IsProtectedChanged -= this.Worksheet_IsProtectedChanged;
                }
            }

            this.worksheetEditor = this.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor;

            if (this.worksheetEditor != null)
            {
                this.worksheetEditor.Selection.ActiveCellModeChanged += this.Selection_ActiveCellModeChanged;
                if (this.worksheetEditor.Worksheet != null)
                {
                    this.worksheetEditor.Worksheet.IsProtectedChanged += this.Worksheet_IsProtectedChanged;
                }
            }
        }

        private void Worksheet_IsProtectedChanged(object sender, EventArgs e)
        {
            this.UpdateProtectButtonContent();
        }

        private void Selection_ActiveCellModeChanged(object sender, EventArgs e)
        {
            this.UpdateProtectionOptionsIsEnabled();
        }

        private void protectSheetButton_Click(object sender, EventArgs e)
        {
            if (this.radSpreadsheet1.SpreadsheetElement.Workbook.ActiveWorksheet.IsProtected)
            {
                bool requriesNoPassword = this.radSpreadsheet1.SpreadsheetElement.Workbook.ActiveWorksheet.Unprotect(string.Empty);
                if (!requriesNoPassword)
                {
                    this.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.Commands.ShowUnprotectSheetDialog.Execute(null);
                }
            }
            else
            {
                this.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.Commands.ShowProtectSheetDialog.Execute(null);
            }
        }

        private void UpdateProtectionOptionsIsEnabled()
        {
            if (this.worksheetEditor != null)
            {
                bool enabled = this.radSpreadsheet1.SpreadsheetElement.ActiveWorksheetEditor.Selection.ActiveCellMode == ActiveCellMode.Display;
                this.protectSheetButton.Enabled = enabled;
                this.saveSheetButton.Enabled = enabled;
            }
        }

        private void UpdateProtectButtonContent()
        {
            string content = "Protect Sheet";
            if (this.radSpreadsheet1.SpreadsheetElement.Workbook.ActiveWorksheet.IsProtected)
            {
                content = "Unprotect Sheet";
            }

            this.protectSheetButton.Text = content;
        }

        private void saveSheetButton_Click(object sender, EventArgs e)
        {
            if (this.worksheetEditor != null)
            {
                this.worksheetEditor.Commands.SaveFile.Execute(null);
            }
        }
    }
}