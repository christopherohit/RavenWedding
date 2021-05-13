using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.QuickStart.WinControls;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.RangeSelector.FirstLook
{
    public partial class Form1 : ExamplesForm
    {
        public Form1()
        {
            InitializeComponent();

            (this.radRangeSlider1.RangeSelectorElement.AssociatedElement as RangeSelectorViewElement).ScalesPosition = ViewPosition.BottomRight;

            this.radChartView1.View.Margin = new Padding(0);
            this.radChartView1.BackColor = Color.White;
        }
    }
}
