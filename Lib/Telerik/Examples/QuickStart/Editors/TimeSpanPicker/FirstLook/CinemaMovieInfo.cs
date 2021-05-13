using System;
using System.Drawing;

namespace Telerik.Examples.WinControls.Editors.TimeSpanPicker.FirstLook
{
    public class CinemaMovieInfo
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime StartFilmingDate { get; set; }

        public Bitmap GenreIcon { get; set; } 

        public TimeSpan FilmingDuration
        {
            get
            {
                return this.ReleaseDate.Subtract(this.StartFilmingDate);
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return this.EndTime.Subtract(this.StartTime);
            }
        }       
    }
}