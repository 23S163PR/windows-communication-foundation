using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.Contracts.Impl
{
    public class BiletikiService : IBiletikiService
    {
        public Affiche GetAffiche(AfficheRequestParameters parameters)
        {
            return new Affiche
            {
                Movies = new ReadOnlyCollection<Movie>(new List<Movie> 
                {
                    // http://www.imdb.com/title/tt1340138/
                    new Movie
                    {
                        Name = "Terminator Genisys",
                        Description = "John Connor sends Kyle Reese back in time to protect Sarah Connor, but when he arrives in 1984, nothing is as he expected it to be.",
                        Directors = new ReadOnlyCollection<string>(new List<string> { "Alan Taylor" }),
                        Writers = new ReadOnlyCollection<string>(new List<string> { "Laeta Kalogridis", "Patrick Lussier" }),
                        Stars = new ReadOnlyCollection<string>(new List<string> { "Arnold Schwarzenegger", "Emilia Clarke", "Jai Courtney" }),
                        Genres = new ReadOnlyCollection<string>(new List<string> { "Action", "Adventure", "Sci-Fi" }),
                        IMDBRating = 8.0f,
                        DurationInMinutes = 126,
                        ShowingFrom = new DateTime(2015, 07, 02),
                        ShowingTo = new DateTime(2015, 08, 02)
                    },
                    // http://www.imdb.com/title/tt2268016/
                    new Movie
                    {
                        Name = "Magic Mike XXL",
                        Description = "Three years after Mike bowed out of the stripper life at the top of his game, he and the remaining Kings of Tampa hit the road to Myrtle Beach to put on one last blow-out performance.",
                        Directors = new ReadOnlyCollection<string>(new List<string> { "Gregory Jacobs" }),
                        Writers = new ReadOnlyCollection<string>(new List<string> { "Reid Carolin", "Reid Carolin" }),
                        Stars = new ReadOnlyCollection<string>(new List<string> { " Channing Tatum", "Joe Manganiello", "Matt Bomer" }),
                        Genres = new ReadOnlyCollection<string>(new List<string> { "Comedy", "Drama", "Music" }),
                        IMDBRating = null,
                        DurationInMinutes = 115,
                        ShowingFrom = new DateTime(2015, 07, 02),
                        ShowingTo = new DateTime(2015, 09, 02)
                    }
                })
            };
        }
    }
}
