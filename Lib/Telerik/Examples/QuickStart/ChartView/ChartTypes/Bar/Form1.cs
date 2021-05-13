using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Bar
{
    /// <summary>
    /// RadTreeView example
    /// </summary>
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
		public Form1()
		{
			InitializeComponent();

			this.SelectedControl = this.radChartView1;

            string themeName = string.IsNullOrEmpty(this.CurrentThemeName) ? "Fluent" : this.CurrentThemeName;
            Theme theme = Theme.ReadCSSText(@"
                                            theme
                                            {
                                               name: " + themeName + @";
                                               elementType: Telerik.WinControls.UI.RadChartElement; 
                                               controlType: Telerik.WinControls.UI.RadChartView; 
                                            }

                                            Bar
                                            {    
                                                HeightAspectRatio
                                                {
                                                    Value: 0.9;
                                                    EndValue: 1;
                                                    MaxValue: 1;
                                                    Frames: 30;
                                                    Interval: 20;
                                                    EasingType: InOutCubic;
                                                    RandomDelay: 200;
                                                    RemoveAfterApply: true; 
                                                }
                                            }
                                            ");

            ThemeRepository.Add(theme, false);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
         
            CartesianArea area = this.radChartView1.GetArea<CartesianArea>();
            area.ShowGrid = true;
           
            this.radDropDownList1.SelectedIndex = 0;

            LinearAxis verticalAcix = new LinearAxis();
            verticalAcix.AxisType = AxisType.Second;
            CategoricalAxis horizontalAxis = new CategoricalAxis();
            PerformanceModel model = new PerformanceModel();

            for (int i = 0; i < 4; i++)
            {
                BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
                barSeries.Name = "Q" + (i + 1);
                barSeries.HorizontalAxis = horizontalAxis;
                barSeries.VerticalAxis = verticalAcix;
                barSeries.DataSource = model.GetData(i);
                this.radChartView1.Series.Add(barSeries);
                foreach (DataPointElement pointElement in barSeries.Children)
                {
                    pointElement.BorderWidth = 0;
                }
            }
        }

        private void showLabelsCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            for (int i = 0; i < this.radChartView1.Series.Count; i++)
            {
                BarSeries barSeries = this.radChartView1.GetSeries<BarSeries>(i);
                barSeries.ShowLabels = !barSeries.ShowLabels;
            }
        }

        private void orientationCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            CartesianGrid grid = this.radChartView1.GetArea<CartesianArea>().GetGrid<CartesianGrid>();

            if (this.orientationCheckBox.IsChecked)
            {
                this.radChartView1.GetArea<CartesianArea>().Orientation = Orientation.Horizontal;
                grid.DrawVerticalStripes = true;
                grid.DrawHorizontalStripes = false;
            }
            else
            {
                this.radChartView1.GetArea<CartesianArea>().Orientation = Orientation.Vertical;
                grid.DrawVerticalStripes = false;
                grid.DrawHorizontalStripes = true;
            }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.radChartView1.Series.Count == 0)
            {
                return;
            }

            ChartSeriesCombineMode combineMode = ChartSeriesCombineMode.None;
            if (radDropDownList1.SelectedIndex == 0)
            {
                combineMode = ChartSeriesCombineMode.Cluster;
            }
            else if (radDropDownList1.SelectedIndex == 1)
            {
                combineMode = ChartSeriesCombineMode.Stack;
            }
            else if (radDropDownList1.SelectedIndex == 2)
            {
                combineMode = ChartSeriesCombineMode.Stack100;
            }

            for (int i = 0; i < this.radChartView1.Series.Count; i++)
            {
                this.radChartView1.GetSeries<BarSeries>(i).CombineMode = combineMode;
            }
        }

        protected override void WireEvents()
        {
            this.showLabelsCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.showLabelsCheckBox_ToggleStateChanged);
            this.orientationCheckBox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.orientationCheckBox_ToggleStateChanged);
            this.radDropDownList1.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList1_SelectedIndexChanged);
        }
	}
}

