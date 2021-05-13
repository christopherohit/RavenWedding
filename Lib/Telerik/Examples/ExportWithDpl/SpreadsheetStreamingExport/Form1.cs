using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ExportWithDpl.SpreadsheetStreamingExport
{
    public partial class Form1 : RadForm
    {
        private ExampleViewModel viewModel = new ExampleViewModel();

        public Form1()
        {
            InitializeComponent();
            this.WireEvents();

            if (Program.themeName != "") //set the example theme to the same theme QSF uses
            {
                this.ThemeName = Program.themeName;
            }
            else
            {
                this.ThemeName = "TelerikMetro"; //set default theme
            }

            ApplyThemeRecursively(this.Controls);

            AddBindings();
        }

        private void ApplyThemeRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                RadControl radControl = control as RadControl;

                if (radControl != null)
                {
                    radControl.ThemeName = this.ThemeName;
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }

        private void WireEvents()
        {
            this.radButtonExport.Click += RadButtonExport_Click;
        }

        private void RadButtonExport_Click(object sender, EventArgs e)
        {
            this.viewModel.Export();
        }

        private void AddBindings()
        {
            this.radSpinEditorRowsCount.DataBindings.Add("Value", this.viewModel, "RowsCount", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDropDownListExtension.DataSource = this.viewModel.ExportFormats;
            this.radDropDownListExtension.DataBindings.Add("SelectedValue", this.viewModel, "SelectedDocumentFormat", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radLabelNumberOfExportedCells.DataBindings.Add("Text", this.viewModel, "ExportedCellsCount", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radLabelExportTimeElapsed.DataBindings.Add("Text", this.viewModel, "ExportTime", true, DataSourceUpdateMode.OnPropertyChanged, 0d, "F2");

            this.radLabelMemory.DataBindings.Add("Text", this.viewModel, "Memory", true, DataSourceUpdateMode.OnPropertyChanged, 0d, "F2");

            this.radButtonExport.DataBindings.Add("Enabled", this.viewModel, "CanExport", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radProgressBarExportProgress.DataBindings.Add("Maximum", this.viewModel, "TotalCellsCount", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radProgressBarExportProgress.DataBindings.Add("Value1", this.viewModel, "ExportedCellsCount", false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
