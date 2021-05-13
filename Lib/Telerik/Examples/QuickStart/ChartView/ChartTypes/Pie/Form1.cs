using System;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Charting;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ChartView.ChartTypes.Pie
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        PieSeries pieSeries;

        public Form1()
        {
            InitializeComponent();
            this.SelectedControl = this.radChartView1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radLabel4.Visible = false;
            this.radSpinDonutRadius.Visible = false;

            this.radChartView1.Controllers.Add(new ChartSelectionController());
            this.radChartView1.SelectedPointChanged += new ChartViewSelectedChangedEventHandler(selectionController_SelectedPointChanged);

            BindSelectionModeCombo();
            this.radDropDownList1.SelectedValueChanged += new EventHandler(radDropDownList1_SelectedValueChanged);
            this.radDropDownList1.SelectedValue = ChartSelectionMode.SingleDataPoint;

            this.pieSeries = new PieSeries();
            this.PopulatePieSeries();
            this.radChartView1.Series.Clear();
            this.radChartView1.Series.Add(this.pieSeries);

            string themeName = string.IsNullOrEmpty(this.CurrentThemeName) ? "Fluent" : this.CurrentThemeName;
            Theme theme = Theme.ReadCSSText(@"
                                        theme
                                        {
                                           name: " + themeName + @";
                                           elementType: Telerik.WinControls.UI.RadChartElement; 
                                           controlType: Telerik.WinControls.UI.RadChartView; 
                                        }

                                        PieSegment
                                        {    
                                            RadiusAspectRatio
                                            {
                                                Value: 0.5;
                                                EndValue: 1;
                                                MaxValue: 1;
                                                Frames: 20;
                                                Interval: 10;
                                                EasingType: OutCircular;
                                                RandomDelay: 100;
                                                RemoveAfterApply: true; 
                                            }
                                        }
                                        ");

            ThemeRepository.Add(theme, false);
        }

        private void radDropDownList1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.radChartView1.SelectionMode = (ChartSelectionMode)this.radDropDownList1.SelectedValue;
        }

        private void selectionController_SelectedPointChanged(object sender, ChartViewSelectedPointChangedEventArgs args)
        {
            this.UpdadateOffsetFromCenter(args.OldSelectedPoint as PieDataPoint);
            this.UpdadateOffsetFromCenter(args.NewSelectedPoint as PieDataPoint);
        }

        private void UpdadateOffsetFromCenter(PieDataPoint point)
        {
            if (point != null)
            {
                point.OffsetFromCenter = point.IsSelected ? 0.1 : 0;
            }
        }

        private void radSpinEditor1_ValueChanged(object sender, EventArgs e)
        {
            AngleRange range = this.pieSeries.Range;
            range.StartAngle = Decimal.ToDouble(this.radSpinEditor1.Value);
            this.pieSeries.Range = range;
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            AngleRange range = this.pieSeries.Range;
            range.SweepAngle = Decimal.ToDouble(this.radSpinEditor2.Value);
            this.pieSeries.Range = range;
        }

        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.pieSeries.ShowLabels = args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On ? true : false;
        }

        private void PopulatePieSeries()
        {
            this.pieSeries.ShowLabels = true;
            this.pieSeries.LabelFormat = "{0:P2}";
            this.pieSeries.RadiusFactor = 0.9f;
            this.pieSeries.Range = new AngleRange(270, 360);
            
            this.pieSeries.DataPoints.Add(new PieDataPoint(40, "Apple"));
            this.pieSeries.DataPoints.Add(new PieDataPoint(45, "Microsoft"));
            this.pieSeries.DataPoints.Add(new PieDataPoint(40, "Google"));
            this.pieSeries.DataPoints.Add(new PieDataPoint(25, "Android"));
            this.pieSeries.DataPoints.Add(new PieDataPoint(15, "HTC"));
            this.pieSeries.DataPoints.Add(new PieDataPoint(15, "Samsung"));
            this.pieSeries.DataPoints.Add(new PieDataPoint(15, "Bada"));
            this.pieSeries.DataPoints.Add(new PieDataPoint(30, "Others"));

        }

        private void BindSelectionModeCombo()
        {
            BindingSource selectionModeBindingSource = new BindingSource();
            selectionModeBindingSource.Add(ChartSelectionMode.None);
            selectionModeBindingSource.Add(ChartSelectionMode.SingleDataPoint);
            selectionModeBindingSource.Add(ChartSelectionMode.MultipleDataPoints);

            this.radDropDownList1.DataSource = selectionModeBindingSource;
        }

        private void radRadioButton1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Series.Clear();
                this.pieSeries = new PieSeries();
                this.PopulatePieSeries();
                this.radChartView1.Series.Add(pieSeries);
                this.radLabel4.Visible = false;
                this.radSpinDonutRadius.Visible = false;
                this.pieSeries.ShowLabels = this.radCheckBox1.Checked;
            }
        }

        private void radRadioButton2_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radChartView1.Series.Clear();
                this.pieSeries = new DonutSeries();
                this.PopulatePieSeries();
                this.radChartView1.Series.Add(pieSeries);
                this.radLabel4.Visible = true;
                this.radSpinDonutRadius.Value = (int)(((DonutSeries)pieSeries).InnerRadiusFactor * 100);
                this.radSpinDonutRadius.Visible = true;
                this.pieSeries.ShowLabels = this.radCheckBox1.Checked;
            }
        }

        private void radSpinDonutRadius_ValueChanged(object sender, EventArgs e)
        {
            ((DonutSeries)this.pieSeries).InnerRadiusFactor = (float)this.radSpinDonutRadius.Value / 100;
        }

        protected override void WireEvents()
        {
            this.radSpinEditor1.ValueChanged += new System.EventHandler(this.radSpinEditor1_ValueChanged);
            this.radSpinEditor2.ValueChanged += new System.EventHandler(this.radSpinEditor2_ValueChanged);
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            this.radRadioButton2.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            this.radRadioButton1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            this.radSpinDonutRadius.ValueChanged += new System.EventHandler(this.radSpinDonutRadius_ValueChanged);
        }
    }
}
