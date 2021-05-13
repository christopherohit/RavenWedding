using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI.Map;

namespace Telerik.Examples.WinControls.Map.Layers
{
    public class SportTeamInfo
    {
        private PointG location;
        private string city;
        private string name;
        private string arena;

        public SportTeamInfo(PointG location, string city, string name, string arena)
        {
            this.location = location;
            this.city = city;
            this.name = name;
            this.arena = arena;
        }

        public PointG Location
        {
            get { return location; }
            set { location = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Arena
        {
            get { return arena; }
            set { arena = value; }
        }
    }
}
