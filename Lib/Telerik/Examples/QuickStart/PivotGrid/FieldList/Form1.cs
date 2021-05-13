using System;
using System.Collections.Generic;
using System.IO;

using Telerik.Pivot.Core;
using Telerik.Pivot.Core.Aggregates;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.PivotGrid.FieldList
{
    public partial class Form1 : RadForm, ISupportThemeName
    {
        List<Order2> orders = new List<Order2>();
        LocalDataSourceProvider provider;

        public Form1()
        {
            InitializeComponent();
            this.LoadData();

            this.provider = new LocalDataSourceProvider() { ItemsSource = orders };

            provider.ColumnGroupDescriptions.Add(new DateTimeGroupDescription() { PropertyName = "Date", Step = DateTimeStep.Year });
            provider.ColumnGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Promotion", GroupComparer = new GroupNameComparer() });

            provider.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Product", GroupComparer = new GroupNameComparer(), SortOrder = Telerik.Pivot.Core.SortOrder.Descending });
            provider.RowGroupDescriptions.Add(new PropertyGroupDescription() { PropertyName = "Advertisement", GroupComparer = new GroupNameComparer() });

            provider.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Quantity", AggregateFunction = AggregateFunctions.Sum });
            provider.AggregateDescriptions.Add(new PropertyAggregateDescription() { PropertyName = "Net", AggregateFunction = AggregateFunctions.Sum });

            provider.AggregatesPosition = PivotAxis.Columns;
            provider.AggregatesLevel = 2; 

            this.radPivotGrid1.PivotGridElement.DataProvider = provider;
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

        public void ApplyTheme(string themeName)
        {
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }
    }
}
