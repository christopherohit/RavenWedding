using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.Charting;

namespace Telerik.Examples.WinControls.ChartView.LabelFormatting
{
    public class TwoLabelOhlcSeries : OhlcSeries
    {
        protected override DataPointElement CreatePointElement(DataPoint point)
        {
            return new TwoLabelOhlcPointElement(point);
        }
    }

    public class TwoLabelOhlcPointElement : OhlcPointElement
    {
        LabelElement secondLabel;

        public TwoLabelOhlcPointElement(DataPoint point)
            : base(point)
        {
            secondLabel = CreateLabelElement(this);
            this.Children.Add(secondLabel);
        }

        public LabelElement SecondLabel
        {
            get { return this.secondLabel; }
        }

        public override Type GetThemeEffectiveType()
        {
            return typeof(OhlcPointElement);     
        }   
    }
}
