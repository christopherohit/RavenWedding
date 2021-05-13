using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.Aggregates;
using Telerik.WinControls.UI;
using Telerik.WinControls.Export;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls;

namespace ExportWithDpl.PivotGrid
{
    public partial class Form1 : RadForm
    {
        private List<Order2> orders = new List<Order2>();
        private LocalDataSourceProvider provider;

        private PivotGridSpreadExport spreadExporter;
        private PivotGridPdfExport pdfExporter;
        
        public Form1()
        {
            InitializeComponent();

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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadData();

            this.provider = new LocalDataSourceProvider() { ItemsSource = orders };

            provider.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Product" });
            provider.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Promotion" });

            provider.RowGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "Date", Step = DateTimeStep.Day });

            provider.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Quantity", AggregateFunction = AggregateFunctions.Sum });
            provider.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Net", AggregateFunction = AggregateFunctions.Sum });

            provider.AggregatesPosition = PivotAxis.Rows;
            provider.AggregatesLevel = 21;

            this.radPivotGrid1.ColumnGrandTotalsPosition = TotalsPos.Last;
            this.radPivotGrid1.ColumnsSubTotalsPosition = TotalsPos.Last;

            this.radPivotGrid1.RowGrandTotalsPosition = TotalsPos.Last;
            this.radPivotGrid1.RowsSubTotalsPosition = TotalsPos.None;

            this.radPivotGrid1.PivotGridElement.DataProvider = provider;
            this.radPivotGrid1.PivotGridElement.BestFitHelper.BestFitColumns();

            this.spreadExporter = new PivotGridSpreadExport(this.radPivotGrid1);
            this.spreadExporter.CellFormatting += spreadExporter_CellFormatting;

            this.pdfExporter = new PivotGridPdfExport(this.radPivotGrid1);
            this.pdfExporter.PageMargins = new Padding(15);
            this.pdfExporter.CellFormatting += pdfExporter_CellFormatting;

            this.SetupInitialSettings();
        }

        private void LoadData()
        {
            Stream stream = System.Reflection.Assembly.GetAssembly(this.GetType()).GetManifestResourceStream("ExportWithDpl.PivotGrid.PivotData.txt");

            using (StreamReader streamReader = new StreamReader(stream))
            {
                while (streamReader.Peek() != -1)
                {
                    string[] items = streamReader.ReadLine().Split('\t');
                    Order2 o = new Order2()
                    {
                        Date = DateTime.Parse(items[0], System.Globalization.CultureInfo.InvariantCulture),
                        Product = items[1],
                        Quantity = int.Parse(items[2], System.Globalization.CultureInfo.InvariantCulture),
                        Net = double.Parse(items[3], System.Globalization.CultureInfo.InvariantCulture),
                        Promotion = items[4],
                        Advertisement = items[5]
                    };
                    orders.Add(o);
                }
            }
        }

        private void SetupInitialSettings()
        {
            this.exportVisualSettingsCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.xlsxRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;

            this.radCheckBoxExportVisualSettingsPdfExport.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
        }

        #region Events

        void spreadExporter_CellFormatting(object sender, PivotGridSpreadExportCellFormattingEventArgs e)
        {
            if (this.customizeVisualSettingsCheckBox.ToggleState != ToggleState.On)
            {
                return;
            }

            decimal value;
            if (decimal.TryParse(e.Cell.Text, out value))
            {
                if (value > 1000)
                {
                    e.Cell.BackColor = System.Drawing.Color.Red;
                    e.Cell.ForeColor = Color.White;
                }
                if (value < 100)
                {
                    e.Cell.BackColor = System.Drawing.Color.Green;
                    e.Cell.ForeColor = Color.White;
                }
            }
        }

        void pdfExporter_CellFormatting(object sender, PivotGridPdfExportCellFormattingEventArgs e)
        {
            if (this.radCheckBoxCustomizeVisualSettingsPdfExport.ToggleState != ToggleState.On)
            {
                return;
            }

            decimal value;
            if (decimal.TryParse(e.Cell.Text, out value))
            {
                if (value > 1000)
                {
                    e.Cell.BackColor = System.Drawing.Color.Red;
                    e.Cell.ForeColor = Color.White;
                }
                if (value < 100)
                {
                    e.Cell.BackColor = System.Drawing.Color.Green;
                    e.Cell.ForeColor = Color.White;
                }
            }
        }

        private void exportFlatDataCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.ExportFlatData = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxExportFlatDataPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.pdfExporter.ExportFlatData = args.ToggleState == ToggleState.On;
        }

        private void exportVisualSettingsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.spreadExporter.ExportVisualSettings = args.ToggleState == ToggleState.On;
        }

        private void radCheckBoxExportVisualSettingsPdfExport_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.pdfExporter.ExportVisualSettings = args.ToggleState == ToggleState.On;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "exportedFile";
            if (this.xlsxRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Xlsx;
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            }
            else if (this.csvRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Csv;
                dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            }
            else if (this.pdfRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Pdf;
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            }
            else if (this.txtRadioButton.ToggleState == ToggleState.On)
            {
                this.spreadExporter.ExportFormat = SpreadExportFormat.Txt;
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.spreadExporter.RunExport(dialog.FileName, new SpreadExportRenderer());
            }
        }

        private void radButtonPdfExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "exportedFile";
            dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pdfExporter.FitToPageWidth = this.radCheckBoxFitToPageWidth.ToggleState == ToggleState.On;
                this.pdfExporter.RunExport(dialog.FileName, new PdfExportRenderer());
            }
        }

        #endregion

        private void radCheckBoxShowHeaderAndFooter_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.pdfExporter.ShowHeaderAndFooter = true;
                this.pdfExporter.LeftHeader = "Date: " + PivotGridPdfExport.DatePrintedString;
                this.pdfExporter.MiddleHeader = "Time: " + PivotGridPdfExport.TimePrintedString;
                this.pdfExporter.RightHeader = "User: " + PivotGridPdfExport.UserNamePrintedString;
                this.pdfExporter.FooterHeight = 20;
                this.pdfExporter.MiddleFooter = string.Format("Page {0} of {1}", PivotGridPdfExport.PageNumberString, PivotGridPdfExport.TotalPagesString);
            }
            else
            {
                this.pdfExporter.ShowHeaderAndFooter = false;
            }
        }
    }

    public class Order2
    {
        private double net;

        public Order2()
        {
        }

        public DateTime Date { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }

        public double Net
        {
            get
            {
                if (this.net == 1025.64)
                {
                    // throw new Exception("Example for error value");
                }
                return this.net;
            }
            set
            {
                this.net = value;
            }
        }

        public string Promotion { get; set; }
        public string Advertisement { get; set; }

        public override string ToString()
        {
            return this.Product + this.Promotion + this.Quantity;
        }
    }
}
