using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Xml;
using HtmlAgilityPack;

namespace IMDB_Parse
{
    public class ListMovie 
    {
        private const string UrlThisWeekAndNow = "http://www.imdb.com/movies-in-theaters/";
        private const string UrlComingSoon = "http://www.imdb.com/movies-coming-soon/?ref_=inth_cs";

        private const string ParrentThisWeek = "//div[@class='list detail sub-list'][1]//div[@itemtype='http://schema.org/Movie']";
        private const string ParrentNow = "//div[@class='list detail sub-list'][2]//div[@itemtype='http://schema.org/Movie']";
        private const string ParrentComingSoon = "/div[@class='list detail']//div[@itemtype='http://schema.org/Movie']";


        private const string Title = "//h4[@itemprop='name']//a[@itemprop='url']/@title";
        private const string AboutMovie = "//div[@itemprop='description']";
        private const string Genre = "//span[@itemprop='genre']";
        private const string Actors = "//span[@itemprop='actors']//a";
        private const string Director = "//span[@itemprop='director']//a";
        private const string DurationInMinute = "//time[@itemprop='duration']";
        private const string Poster = "//img[@itemprop='image']";
        private const string Scenery = "//div[@itemprop='creator']//span[@itemprop='name']";

        private List<MovieDescription> GetMovies (HtmlNodeCollection colection)
        {
            var movies = new List<MovieDescription>();
            foreach (var node in colection)
            {
                var actorsNode = node.SelectNodes(node.XPath + Actors);
                movies.Add(new MovieDescription()
                {
                    Title = node.SelectSingleNode(node.XPath + Title).InnerHtml,
                    AboutMovie = node.SelectSingleNode(node.XPath + AboutMovie).InnerHtml,
                    Actors = string.Join(", ", actorsNode == null ?
                        new[] { "" } : actorsNode.Select(x => x.InnerHtml)),
                    DurationInMinute = node.SelectSingleNode(node.XPath + DurationInMinute).InnerHtml,
                    Genre = node.SelectSingleNode(node.XPath + Genre).InnerHtml,
                    Director = node.SelectSingleNode(node.XPath + Director).InnerHtml,
                    Scenery = GetScenery("http://www.imdb.com"+node.SelectSingleNode(node.XPath + Title).Attributes["href"].Value),
                    Poster = new Bitmap(WebRequest.Create(node.SelectSingleNode(node.XPath + Poster).Attributes["src"].Value).GetResponse().GetResponseStream())
                });
            }
            return movies;
        }

        private string GetScenery(string uri)
        {
            var nodesScenery = MoviePage.GetParrentNodeMovie(uri, Scenery);
            return string.Join(", ", nodesScenery == null ?
                new[] { "" } : nodesScenery.Select(x => x.InnerHtml));
        }

        public List<MovieDescription> GetThisWeekMovies()
        {
            var parrentNodes = MoviePage.GetParrentNodeMovie(UrlThisWeekAndNow, ParrentThisWeek);
            var movies = GetMovies(parrentNodes);
            return movies;
        }
        public List<MovieDescription> GetNowMovies()
        {
            var parrentNodes = MoviePage.GetParrentNodeMovie(UrlThisWeekAndNow, ParrentNow);
            var movies = GetMovies(parrentNodes);
            return movies;
        }
        public List<MovieDescription> GetComingSoonMovies()
        {
            var parrentNodes = MoviePage.GetParrentNodeMovie(UrlComingSoon, ParrentComingSoon);
            var movies = GetMovies(parrentNodes);
            return movies;
        }

    }
}