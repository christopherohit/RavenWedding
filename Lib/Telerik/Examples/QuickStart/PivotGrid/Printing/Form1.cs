using System;
using System.Collections.Generic;
using System.IO; 
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.Pivot.Core.ViewModels;

using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Pivot.Core.Aggregates;

namespace Telerik.Examples.WinControls.PivotGrid.Printing
{
    public partial class Form1 : ExamplesForm
    {
        private RadPivotGrid radPivotGrid1;
        private RadPrintDocument radPrintDocument1;
         
        List<Order2> orders = new List<Order2>();
        LocalDataSourceProvider provider;

        public Form1()
        {
            this.radPivotGrid1 = new RadPivotGrid();
            this.radPivotGrid1.ColumnWidth = 110;
            this.radPivotGrid1.Dock = DockStyle.Fill;

            this.radPrintDocument1 = new RadPrintDocument();
            this.radPrintDocument1.AssociatedObject = this.radPivotGrid1;

            this.Controls.Add(this.radPivotGrid1);
            InitializeComponent();
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
        }

        private void LoadData()
        {
            Stream stream = System.Reflection.Assembly.GetAssembly(this.GetType()).GetManifestResourceStream("Telerik.Examples.WinControls.PivotGrid.Settings.PivotData.txt");

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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            this.radPivotGrid1.Print(true, this.radPrintDocument1);           
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            this.radPivotGrid1.PrintPreview(this.radPrintDocument1);
        }

        private void buttonPrintSettings_Click(object sender, EventArgs e)
        {
            PivotGridPrintSettingsDialog dialog = new PivotGridPrintSettingsDialog(this.radPrintDocument1);
            dialog.ThemeName = this.radPivotGrid1.ThemeName;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.radPivotGrid1.PrintPreview(this.radPrintDocument1);
            }
        }

        protected override void WireEvents()
        {
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            this.buttonPrintSettings.Click += new System.EventHandler(this.buttonPrintSettings_Click);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.Export.PivotExportToExcelML m = new Telerik.WinControls.UI.Export.PivotExportToExcelML(this.radPivotGrid1.PivotGridElement);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel ML|*.xls";
            saveFileDialog1.Title = "Export to File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                m.RunExport(saveFileDialog1.FileName);
                MessageBox.Show("Successfully exported to " + saveFileDialog1.FileName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
