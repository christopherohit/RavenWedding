using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Telerik.Examples.WinControls.ChartView.LiveData
{
    class ChartBusinessObject
    {
        private double value;
        private DateTime category;

        public double Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;     
            }
        }

        public DateTime Category
        {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;  
            }
        }
    }
}
