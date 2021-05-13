using System;
using System.Data;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bubble
{
    /// <summary>
    /// RadChartView example
    /// </summary>
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
   
		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radChartView1;        
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BubbleSeries europe = new BubbleSeries();
            BubbleSeries northAmeruca = new BubbleSeries();
            BubbleSeries middleEast = new BubbleSeries();

            europe.XValueMember = "LifeExpectancy";
            europe.YValueMember = "FertilityRate";
            europe.ValueMember = "Population";
            europe.DataMember = "Europe";
            europe.AutoScaleMaxWidth = 150;
            europe.LegendTitle = "Europe";

            northAmeruca.XValueMember = "LifeExpectancy";
            northAmeruca.YValueMember = "FertilityRate";
            northAmeruca.ValueMember = "Population";
            northAmeruca.DataMember = "NorthAmerica";
            northAmeruca.AutoScaleMaxWidth = 150;
            northAmeruca.LegendTitle = "North America";

            middleEast.XValueMember = "LifeExpectancy";
            middleEast.YValueMember = "FertilityRate";
            middleEast.ValueMember = "Population";
            middleEast.DataMember = "MiddleEast";
            middleEast.AutoScaleMaxWidth = 150;
            middleEast.LegendTitle = "Middle East";

            this.radChartView1.Series.Add(europe);
            this.radChartView1.Series.Add(northAmeruca);
            this.radChartView1.Series.Add(middleEast);

            this.radChartView1.ShowLegend = true;
            this.radChartView1.DataSource = DataModel.GetData();

            ChartTooltipController tooltip = new ChartTooltipController();
            tooltip.DataPointTooltipTextNeeded += tooltip_DataPointTooltipTextNeeded;
            this.radChartView1.Controllers.Add(tooltip);
        }

        private void tooltip_DataPointTooltipTextNeeded(object sender, DataPointTooltipTextNeededEventArgs e)
        {
            BubbleDataPoint point = e.DataPoint as BubbleDataPoint;
            DataRowView row = point.DataItem as DataRowView;
            e.Text = string.Format("Country: {0}\nLife Expectancy: {1:F2}\nFertility Rate: {2:F2}\nRegion: {3}\nPopulation: {4}", row["Country"], point.XValue, point.YValue, row.Row.Table.TableName, point.Value);
        }
	}
}

