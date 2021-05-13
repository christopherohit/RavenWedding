using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.FirstLook
{
    public class TripCity
    {
        private PointG location;
        private string name;
        private int tripStop;
        private bool isFlight;

        public TripCity(string name, PointG location, int tripStop, bool isFlight)
        {
            this.name = name;
            this.location = location;
            this.tripStop = tripStop;
            this.isFlight = isFlight;
        }

        public PointG Location
        {
            get { return location; }
            set { this.location = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int TripStop
        {
            get { return tripStop; }
            set { this.tripStop = value; }
        }

        public bool IsFlight
        {
            get { return isFlight; }
            set { this.isFlight = value; }
        }
    }
}
