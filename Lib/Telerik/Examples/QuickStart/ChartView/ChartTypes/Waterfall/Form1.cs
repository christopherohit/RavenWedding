using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Waterfall
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

            WaterfallSeries series = new WaterfallSeries("Value", "Summary", "Total", "Category");
            series.ShowLabels = true;
            series.DataSource = DataModel.GetData();

            this.radChartView1.Series.Add(series);
        }
	}
}

