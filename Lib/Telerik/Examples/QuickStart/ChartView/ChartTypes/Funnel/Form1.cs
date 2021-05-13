using System;
using Telerik.Charting;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Funnel
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    
    {
        FunnelSeries funnelSeries;

        public Form1()
        {
            InitializeComponent();

            this.SelectedControl = this.radChartView1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.funnelSeries = new FunnelSeries();

            this.PopulateFunnelSeries();

            this.radChartView1.Series.Clear();
            this.radChartView1.Series.Add(this.funnelSeries);
            this.radChartView1.ShowLegend = true;
            this.radChartView1.View.Palette = KnownPalette.Metro;
        }

        private void PopulateFunnelSeries()
        {
            this.funnelSeries.ShowLabels = true;

            this.funnelSeries.DataPoints.Add(new FunnelDataPoint(5442, "Visited the website"));
            this.funnelSeries.DataPoints.Add(new FunnelDataPoint(1519, "Watched the demos"));
            this.funnelSeries.DataPoints.Add(new FunnelDataPoint(1131, "Downloaded a trial"));
            this.funnelSeries.DataPoints.Add(new FunnelDataPoint(811, "Purchased a license"));
            this.funnelSeries.DataPoints.Add(new FunnelDataPoint(704, "Renewed a license"));

        }

        protected override void WireEvents()
        {
            this.radSpinEditorNeckRatio.ValueChanged += radSpinEditorNeckRatio_ValueChanged;
            this.radSpinEditorSegmentSpacing.ValueChanged += radSpinEditorSegmentSpacing_ValueChanged;
            this.radCheckBoxDynamicSlope.ToggleStateChanged += radCheckBoxDynamicSlope_ToggleStateChanged;
            this.radCheckBoxDynamicHeight.ToggleStateChanged += radCheckBoxDynamicHeight_ToggleStateChanged;
        }

        private void radCheckBoxDynamicHeight_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.funnelSeries.DynamicHeight = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
            this.radSpinEditorNeckRatio.Enabled = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.Off;
        }

        private void radCheckBoxDynamicSlope_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.funnelSeries.DynamicSlope = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On;
        }

        private void radSpinEditorSegmentSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.funnelSeries.SegmentSpacing = (int)this.radSpinEditorSegmentSpacing.Value;
        }

        private void radSpinEditorNeckRatio_ValueChanged(object sender, EventArgs e)
        {
            this.funnelSeries.NeckRatio = (float)this.radSpinEditorNeckRatio.Value;
        }
    }
}
