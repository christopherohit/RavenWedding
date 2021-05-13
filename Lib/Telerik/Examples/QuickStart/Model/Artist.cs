using System;
using System.Collections.Generic;

namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
{
    [Serializable]
    public class Artist
    {
        private int id;
        private string name;
        private List<Album> albums = new List<Album>();

        public Artist()
        {

        }

        public Artist(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Album> Albums
        {
            get { return albums; }
        }
    }
}
