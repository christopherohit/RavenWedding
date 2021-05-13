using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Telerik.Examples.WinControls.ChartView.CartesianAnnotations
{
    public class CompanyEvent
    {
        private string eventDescription;
        private DateTime timeOfEvent;
        private SizeF offset;

        public CompanyEvent(DateTime timeOfEvent, string eventDescription, SizeF offset)
        {
            this.timeOfEvent = timeOfEvent;
            this.eventDescription = eventDescription;
            this.offset = offset;
        }

        public string EventDescription
        {
            get { return eventDescription; }
            set { eventDescription = value; }
        }

        public DateTime TimeOfEvent
        {
            get { return timeOfEvent; }
            set { timeOfEvent = value; }
        }

        public SizeF Offset
        {
            get { return offset; }
            set { offset = value; }
        }
    }
}
