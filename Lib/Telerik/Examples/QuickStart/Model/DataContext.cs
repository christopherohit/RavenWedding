using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Telerik.Examples.WinControls.Properties;

namespace Telerik.Examples.WinControls.TreeView.Populating.ObjectRelational
{
    public class DataContext
    {
        private static List<Artist> artistsField = null;
        private static List<Artist> topArtistsField = null;

        protected DataContext()
        {
            
        }

        public static List<Artist> Artists
        {
            get 
            {
                if (artistsField == null)
                {
                    using (MemoryStream stream = new MemoryStream(Resources.ChinookModel))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        artistsField = (List<Artist>)formatter.Deserialize(stream);
                    }
                }

                return artistsField; 
            }
        }

        public static List<Artist> TopArtists
        {
            get
            {
                if (topArtistsField == null)
                {
                    using (MemoryStream stream = new MemoryStream(Resources.ChinookModel))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        topArtistsField = (List<Artist>)formatter.Deserialize(stream);

                        while (topArtistsField.Count > 50)
                        {
                            topArtistsField.RemoveAt(topArtistsField.Count - 1);
                        }
                    }
                }

                return topArtistsField;
            }
        }
    }
}
