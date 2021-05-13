using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.Pivot.Core;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PivotGrid.UnderlyingData
{
    public partial class Form1 : ExamplesForm
    {
        private LocalDataSourceProvider provider;
        private UnderlyingDataForm underlyingDataForm = new UnderlyingDataForm();
        private List<Order2> orders = new List<Order2>();

        public Form1()
        {
            InitializeComponent();

            this.radPivotGrid1.MouseDoubleClick += radPivotGrid1_MouseDoubleClick;
        }

        private void radPivotGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RadPivotGrid pivotGrid = (RadPivotGrid)sender;
                PivotCellElement cell = pivotGrid.ElementTree.GetElementAtPoint(e.Location) as PivotCellElement;
                if (cell != null)
                {
                    IGroup row = cell.Row.Group;
                    IGroup column = cell.Column.Group;
                    LocalDataSourceProvider localProvider = pivotGrid.DataProvider as LocalDataSourceProvider;
                    localProvider.GetUnderlyingData(row, column);
                }
            }
        }

        private void provider_GetUnderlyingDataCompleted(object sender, Telerik.Pivot.Core.DrillDown.DrillDownCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (e.InnerExceptions.Count == 0)
                {
                    ThemeResolutionService.ApplyThemeToControlTree(this.underlyingDataForm as Form, this.CurrentThemeName);
                    this.underlyingDataForm.DisplayUnderlyingData(e.Result, this);
                }
                else if (e.InnerExceptions.Count == 1 && e.InnerExceptions[0].GetType() == typeof(InvalidOperationException))
                {
                    RadMessageBox.ThemeName = this.CurrentThemeName;
                    RadMessageBox.Show("Please Refresh the Data Provider.");
                }
            });
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadData();
            this.SetupPivot();

            this.radPivotGrid1.DataProvider = provider;
            this.radPivotGrid1.RowsSubTotalsPosition = Telerik.WinControls.UI.TotalsPos.Last;
        }

        private void SetupPivot()
        {
            this.provider = new LocalDataSourceProvider()
            {
                ItemsSource = orders
            };

            this.provider.GetUnderlyingDataCompleted += provider_GetUnderlyingDataCompleted;

            this.provider.RowGroupDescriptions.Add(new PropertyGroupDescription()
            {
                PropertyName = "Product"
            });

            this.provider.RowGroupDescriptions.Add(new PropertyGroupDescription()
            {
                PropertyName = "Advertisement"
            });

            this.provider.ColumnGroupDescriptions.Add(new PropertyGroupDescription()
            {
                PropertyName = "Promotion"
            });

            this.provider.AggregateDescriptions.Add(new PropertyAggregateDescription()
            {
                PropertyName = "Quantity"
            });

            this.provider.AggregateDescriptions.Add(new PropertyAggregateDescription()
            {
                PropertyName = "Net"
            });
        }

        private void LoadData()
        {
            Stream stream = System.Reflection.Assembly.GetCallingAssembly().GetManifestResourceStream("Telerik.Examples.WinControls.PivotGrid.Settings.PivotData.txt");

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
                        Advertisement = items[5],
                    };

                    orders.Add(o);
                }
            }
        }
    }
}