using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.RadarColumn
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        public Form1()
        {
            InitializeComponent();
            List<string> categories = new List<string> {
                        "Df", "Pr", "A", "C", "D", "E",
                        "Th", "Ri", "Ni", "B", "F", 
                        "Se", "Mn", "Cu", "Zn", "K", "P",
                        "Fe", "Ca", "Na", "Ch", "Sf" };

            List<int> values = new List<int>() {
                        5, 1, 1, 5, 0, 1,
                        1, 2, 1, 2, 1, 0,
                        0, 2, 1, 0, 3, 1,
                        1, 1, 0, 0, };

            RadarColumnSeries series = new RadarColumnSeries();


            for (int i = 0; i < categories.Count; i++)
            {
                series.DataPoints.Add(new CategoricalDataPoint(values[i], categories[i]));
            }
            radChartView1.AreaType = ChartAreaType.Polar;
            radChartView1.Series.Add(series);

            for (int i = 0; i < series.Children.Count; i++)
            {
                if (i % 2 == 0)
                {
                    series.Children[i].BackColor = Color.FromArgb(61, 153, 231);
                }
                else
                {
                    series.Children[i].BackColor = Color.FromArgb(249, 196, 0);
                }
            }

        }
    }
}
