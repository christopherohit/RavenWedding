using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;
using Telerik.Charting;

namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
{
    public partial class Form1 : ExamplesForm, ICustomThemeExamplesForm
    {
        string currentCompany = "Google Inc.";
        private DataModel model;
        private AreaSeries series;

        private List<CartesianGridLineAnnotation> googleEvents;
        private List<CartesianGridLineAnnotation> microsoftEvents;
        private List<CartesianGridLineAnnotation> appleEvents;
        private List<CartesianGridLineAnnotation> adobeEvents;

        private CartesianGridLineAnnotation googleAverage;
        private CartesianGridLineAnnotation microsoftAverage;
        private CartesianGridLineAnnotation appleAverage;
        private CartesianGridLineAnnotation adobeAverage;

        private CartesianPlotBandAnnotation googleRange;
        private CartesianPlotBandAnnotation microsoftRange;
        private CartesianPlotBandAnnotation appleRange;
        private CartesianPlotBandAnnotation adobeRange;

        public Form1()
        {
            InitializeComponent();

            this.model = new DataModel();

            DateTimeContinuousAxis axis = new DateTimeContinuousAxis();
            axis.MajorStepUnit = Charting.TimeInterval.Month;
            axis.MajorStep = 3;
            axis.LabelFormatProvider = new DateTimeFormatProvider();

            this.series = new AreaSeries();
            this.series.HorizontalAxis = axis;
            this.series.ValueMember = "Value";
            this.series.CategoryMember = "Date";
            series.BorderColor = Color.FromArgb(27, 157, 222);
            series.BackColor = Color.FromArgb(80, 27, 157, 222);
            this.radChartView1.Series.Add(series);
            this.radChartView1.ShowGrid = true;

            this.googleEvents = new List<CartesianGridLineAnnotation>();
            this.microsoftEvents = new List<CartesianGridLineAnnotation>();
            this.appleEvents = new List<CartesianGridLineAnnotation>();
            this.adobeEvents = new List<CartesianGridLineAnnotation>();

            foreach (CompanyEvent ev in this.model.GetGoogleEventData())
            {
                CartesianGridLineAnnotation ann = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[0], ev.TimeOfEvent);
                ann.Label = ev.EventDescription;
                ann.PositonOffset = ev.Offset;
                this.googleEvents.Add(ann);
            }

            foreach (CompanyEvent ev in this.model.GetMicrosoftEventData())
            {
                CartesianGridLineAnnotation ann = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[0], ev.TimeOfEvent);
                ann.Label = ev.EventDescription;
                ann.PositonOffset = ev.Offset;
                this.microsoftEvents.Add(ann);
            }

            foreach (CompanyEvent ev in this.model.GetAppleEventData())
            {
                CartesianGridLineAnnotation ann = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[0], ev.TimeOfEvent);
                ann.Label = ev.EventDescription;
                ann.PositonOffset = ev.Offset;
                this.appleEvents.Add(ann);
            }

            foreach (CompanyEvent ev in this.model.GetAdobeEventData())
            {
                CartesianGridLineAnnotation ann = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[0], ev.TimeOfEvent);
                ann.Label = ev.EventDescription;
                ann.PositonOffset = ev.Offset;
                this.adobeEvents.Add(ann);
            }

            this.googleAverage = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[1], 515.25d);
            this.googleAverage.BorderColor = Color.LimeGreen;
            this.googleAverage.BorderWidth = 2;
            this.googleAverage.Label = "515.25 AVG value";
            this.googleAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            this.microsoftAverage = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[1], 26.85d);
            this.microsoftAverage.BorderColor = Color.LimeGreen;
            this.microsoftAverage.BorderWidth = 2;
            this.microsoftAverage.Label = "26.85 AVG value";
            this.microsoftAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            this.appleAverage = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[1], 225.74d);
            this.appleAverage.BorderColor = Color.LimeGreen;
            this.appleAverage.BorderWidth = 2;
            this.appleAverage.Label = "225.74 AVG value";
            this.appleAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            this.adobeAverage = new CartesianGridLineAnnotation((CartesianAxis)this.radChartView1.Axes[1], 33.35d);
            this.adobeAverage.BorderColor = Color.LimeGreen;
            this.adobeAverage.BorderWidth = 2;
            this.adobeAverage.Label = "33.35 AVG value";
            this.adobeAverage.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            this.googleRange = new CartesianPlotBandAnnotation((CartesianAxis)this.radChartView1.Axes[1], 257.44, 741.79);
            this.microsoftRange = new CartesianPlotBandAnnotation((CartesianAxis)this.radChartView1.Axes[1], 15.15, 37.06);
            this.appleRange = new CartesianPlotBandAnnotation((CartesianAxis)this.radChartView1.Axes[1], 636.23, 78.2);
            this.adobeRange = new CartesianPlotBandAnnotation((CartesianAxis)this.radChartView1.Axes[1], 15.98, 48);

            this.SelectedCompanyChnaged();
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.radRadioButton1.ToggleStateChanged += radRadioButton_ToggleStateChanged;
            this.radRadioButton2.ToggleStateChanged += radRadioButton_ToggleStateChanged;
            this.radRadioButton3.ToggleStateChanged += radRadioButton_ToggleStateChanged;
            this.radRadioButton4.ToggleStateChanged += radRadioButton_ToggleStateChanged;

            this.radCheckBoxCompanyEvents.ToggleStateChanged += radCheckBoxCompanyEvents_ToggleStateChanged;
            this.radCheckBoxAveragePrice.ToggleStateChanged += radCheckBoxAveragePrice_ToggleStateChanged;
            this.radCheckBoxPriceRange.ToggleStateChanged += radCheckBoxPriceRange_ToggleStateChanged;
        }

        private void radCheckBoxPriceRange_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            switch (currentCompany)
            {
                case "Google Inc.":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.googleRange);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.googleRange);
                    }
                    break;
                case "Microsoft Corporation":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.microsoftRange);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.microsoftRange);
                    }
                    break;
                case "Apple Inc.":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.appleRange);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.appleRange);
                    }
                    break;
                case "Adobe Systems Inc.":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.adobeRange);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.adobeRange);
                    }
                    break;
            }
        }

        private void radCheckBoxAveragePrice_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            switch (currentCompany)
            {
                case "Google Inc.":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.googleAverage);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.googleAverage);
                    }
                    break;
                case "Microsoft Corporation":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.microsoftAverage);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.microsoftAverage);
                    }
                    break;
                case "Apple Inc.":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.appleAverage);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.appleAverage);
                    }
                    break;
                case "Adobe Systems Inc.":
                    if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                    {
                        this.radChartView1.Area.Annotations.Add(this.adobeAverage);
                    }
                    else
                    {
                        this.radChartView1.Area.Annotations.Remove(this.adobeAverage);
                    }
                    break;
            }
        }

        private void radCheckBoxCompanyEvents_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            switch (currentCompany)
            {
                case "Google Inc.":
                    foreach (CartesianGridLineAnnotation ev in this.googleEvents)
                    {
                        if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                        else
                        {
                            this.radChartView1.Area.Annotations.Remove(ev);
                        }
                    }
                    break;
                case "Microsoft Corporation":
                    foreach (CartesianGridLineAnnotation ev in this.microsoftEvents)
                    {
                        if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                        else
                        {
                            this.radChartView1.Area.Annotations.Remove(ev);
                        }
                    }
                    break;
                case "Apple Inc.":
                    foreach (CartesianGridLineAnnotation ev in this.appleEvents)
                    {
                        if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                        else
                        {
                            this.radChartView1.Area.Annotations.Remove(ev);
                        }
                    }
                    break;
                case "Adobe Systems Inc.":
                    foreach (CartesianGridLineAnnotation ev in this.adobeEvents)
                    {
                        if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                        else
                        {
                            this.radChartView1.Area.Annotations.Remove(ev);
                        }
                    }
                    break;
            }
        }

        private void SelectedCompanyChnaged()
        {
            this.radChartView1.Area.Annotations.Clear();
            this.series.DataSource = this.model.GetData().Tables[currentCompany];

            switch (currentCompany)
            {
                case "Google Inc.":
                    if (this.radCheckBoxCompanyEvents.IsChecked)
                    {
                        foreach (CartesianGridLineAnnotation ev in this.googleEvents)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                    }

                    if (this.radCheckBoxAveragePrice.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.googleAverage);
                    }

                    if (this.radCheckBoxPriceRange.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.googleRange);
                    }
                    break;
                case "Microsoft Corporation":
                    if (this.radCheckBoxCompanyEvents.IsChecked)
                    {
                        foreach (CartesianGridLineAnnotation ev in this.microsoftEvents)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                    }

                    if (this.radCheckBoxAveragePrice.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.microsoftAverage);
                    }

                    if (this.radCheckBoxPriceRange.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.microsoftRange);
                    }
                    break;
                case "Apple Inc.":
                    if (this.radCheckBoxCompanyEvents.IsChecked)
                    {
                        foreach (CartesianGridLineAnnotation ev in this.appleEvents)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                    }

                    if (this.radCheckBoxAveragePrice.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.appleAverage);
                    }

                    if (this.radCheckBoxPriceRange.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.appleRange);
                    }
                    break;
                case "Adobe Systems Inc.":
                    if (this.radCheckBoxCompanyEvents.IsChecked)
                    {
                        foreach (CartesianGridLineAnnotation ev in this.adobeEvents)
                        {
                            this.radChartView1.Area.Annotations.Add(ev);
                        }
                    }

                    if (this.radCheckBoxAveragePrice.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.adobeAverage);
                    }

                    if (this.radCheckBoxPriceRange.IsChecked)
                    {
                        this.radChartView1.Area.Annotations.Add(this.adobeRange);
                    }
                    break;
            }
        }

        private void radRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                currentCompany = ((RadRadioButton)sender).Text;
                this.SelectedCompanyChnaged();
            }
        }
    }
}