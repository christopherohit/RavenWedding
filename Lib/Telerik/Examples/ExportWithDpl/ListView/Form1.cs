using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace ExportWithDpl.ListView
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
            this.listViewShowGroupsCheckBox.ToggleStateChanged += listViewShowGroupsCheckBox_ToggleStateChanged;
            this.exportButton.Click += exportButton_Click;
            this.listViewTypeDropDownList.SelectedIndexChanged += listViewTypeDropDownList_SelectedIndexChanged;
        }

        private void SetupInitialSettings()
        {
            this.listViewShowGroupsCheckBox.ToggleState = ToggleState.On;
            this.exportVisualSettingsCheckBox.ToggleState = ToggleState.On;
            this.exportImagesCheckBox.ToggleState = ToggleState.On;
            this.groupChildItemsCheckBox.ToggleState = ToggleState.On;
            this.exportFormatXlsxRadioButton.ToggleState = ToggleState.On;
            this.collapsedOptionExportAlwaysRadioButton.ToggleState = ToggleState.On;
        }

        private void listViewShowGroupsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radListView1.ShowGroups = args.ToggleState == ToggleState.On;
        }

        private void listViewTypeDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.listViewTypeDropDownList.Text)
            {
                case "List View":
                    this.radListView1.ViewType = ListViewType.ListView;
                    this.radListView1.ItemSize = new Size(200, 32);
                    break;
                case "Icon View":
                    this.radListView1.ViewType = ListViewType.IconsView;
                    this.radListView1.ItemSize = new Size(155, 46);
                    break;
                case "Detail View":
                    this.radListView1.ViewType = ListViewType.DetailsView;
                    this.radListView1.ItemSize = new Size(200, 32);
                    break;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ListViewSpreadExport exporter = new ListViewSpreadExport(this.radListView1);

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
                exporter.ExportImages = this.exportImagesCheckBox.ToggleState == ToggleState.On;
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
                renderer.WorkbookCreated += renderer_WorkbookCreated;
                exporter.RunExport(dialog.FileName, renderer);
            }
        }

        void renderer_WorkbookCreated(object sender, WorkbookCreatedEventArgs e)
        {
            Telerik.Windows.Documents.Spreadsheet.Model.Worksheet worksheet = e.Workbook.ActiveWorksheet;
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
        }

        private void exporter_CellFormatting(object sender, ListViewSpreadExportCellFormattingEventArgs e)
        {
            if (e.DataItem is ListViewDataItemGroup)
            {
                e.ExportCell.BackColor = Color.AliceBlue;
                e.ExportCell.ForeColor = Color.DarkGreen;
                e.ExportCell.Font = new Font("SegoeUI", 12, FontStyle.Italic);
            }
            else if (e.RowIndex % 2 == 0)
            {
                e.ExportCell.BackColor = Color.LightGray;
            }
        }
    }
}
