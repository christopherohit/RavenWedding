using System;
using System.Collections.Generic;
using System.Text;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.IndicateErrors
{
    class EmployeePositions
    {
        private string display;
        private EmployeePosition position;

        public EmployeePositions()
        {
        }

        public EmployeePositions(string display, EmployeePosition position)
        {
            this.display = display;
            this.position = position;
        }

        public string Display
        {
            get
            {
                return display;
            }
            set
            {
                display = value;
            }
        }

        public EmployeePosition Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
    }
}
