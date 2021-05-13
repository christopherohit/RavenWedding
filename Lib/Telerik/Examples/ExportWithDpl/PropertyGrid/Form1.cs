using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace ExportWithDpl.PropertyGrid
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
            this.WireEvents();
            this.SetupInitialSettings();

            if (Program.themeName != "") //set the example theme to the same theme QSF uses
            {
                this.ThemeName = Program.themeName;
            }
            else
            {
                this.ThemeName = "TelerikMetro"; //set default theme
            }

            ApplyThemeRecursively(this.Controls);
        }

        void ApplyThemeRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                RadControl radControl = control as RadControl;
                if (radControl != null )
                {                    
                    radControl.ThemeName = this.ThemeName;                    
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }

        private void WireEvents()
        {
            this.exportButton.Click += exportButton_Click;
        }

        private void SetupInitialSettings()
        {
            this.exportVisualSettingsCheckBox.ToggleState = ToggleState.On;
            this.groupChildItemsCheckBox.ToggleState = ToggleState.On;
            this.exportFormatXlsxRadioButton.ToggleState = ToggleState.On;
            this.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            PropertyGridSpreadExport exporter = new PropertyGridSpreadExport(this.radPropertyGrid1);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "exportedFile";
            if (this.exportFormatXlsxRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Xlsx;
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            }
            else if (this.exportFormatPdfRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Pdf;
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            }
            else if (this.exportFormatCsvRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Csv;
                dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            }
            else if (this.exportFormatTxtRadioButton.ToggleState == ToggleState.On)
            {
                exporter.ExportFormat = SpreadExportFormat.Txt;
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (this.customizeVisualSettingsCheckBox.ToggleState == ToggleState.On)
                {
                    exporter.CellFormatting += exporter_CellFormatting;
                }

                exporter.ExportVisualSettings = this.exportVisualSettingsCheckBox.ToggleState == ToggleState.On;
                exporter.ExportChildItemsGrouped = this.groupChildItemsCheckBox.ToggleState == ToggleState.On;

                if (this.collapsedOptionExportAlwaysRadioButton.ToggleState == ToggleState.On)
                {
                    exporter.CollapsedItemOption = HiddenOption.ExportAlways;
                }
                else if (this.collapsedOptionDoNotExportRadioButton.ToggleState == ToggleState.On)
                {
                    exporter.CollapsedItemOption = HiddenOption.DoNotExport;
                }
                else if (this.collapsedOptionExportAsHiddenRadioButton.ToggleState == ToggleState.On)
                {
                    exporter.CollapsedItemOption = HiddenOption.ExportAsHidden;
                }

                SpreadExportRenderer renderer = new SpreadExportRenderer();
                if (this.exportDescriptionsCheckBox.ToggleState == ToggleState.On)
                {
                    exporter.ExportDescriptions = true;
                    renderer.WorkbookCreated += renderer_WorkbookCreated;
                }
                exporter.RunExport(dialog.FileName, renderer);
            }
        }

        private void renderer_WorkbookCreated(object sender, WorkbookCreatedEventArgs e)
        {
            Worksheet worksheet = e.Workbook.ActiveWorksheet;
            worksheet.Columns[worksheet.UsedCellRange.GetLastColumn()].AutoFitWidth();
        }

        private void exporter_CellFormatting(object sender, PropertyGridSpreadExportCellFormattingEventArgs e)
        {
            if (e.Item is PropertyGridGroupItem)
            {
                e.ExportCell.BackColor = Color.Cornsilk;
                e.ExportCell.ForeColor = Color.YellowGreen;
            }
            else if (e.Item.GridItems.Count > 0)
            {
                e.ExportCell.BackColor = Color.LightSteelBlue;
            }
        }
    }
}
