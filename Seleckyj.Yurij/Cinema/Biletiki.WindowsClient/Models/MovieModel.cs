using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.WindowsClient.Models
{
    public class MovieModel
    {
        public string Name { get; set; }
        public string ShowingDates { get; set; }
        public int DurationInMinutes { get; set; }
        public string VerticalBarDelimitedGenres { get; set; }
        public string IMDBRating { get; set; }
        public string Description { get; set; }
        public string CommaDelimitedDirectors { get; set; }
        public string CommaDelimitedStars { get; set; }
        public string CommaDelimitedWriters { get; set; }
    }
}
