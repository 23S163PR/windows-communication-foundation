using System.Drawing;

namespace IMDB_Parse
{
    public class MovieDescription
    {
        public string Title { get; set; }
        public string AboutMovie { get; set; }
        public string Genre { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string DurationInMinute { get; set; }
        public string Scenery { get; set; }
        public Bitmap Poster { get; set; }
    }
}
