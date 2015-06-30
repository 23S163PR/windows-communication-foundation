using System.Net;
using System.Text;
using HtmlAgilityPack;

namespace IMDB_Parse
{
    public static class MoviePage
    {
        public static HtmlNodeCollection GetParrentNodeMovie(string urlPageMovie, string predicateMovieNode)
        {
            var request = (HttpWebRequest)WebRequest.Create(urlPageMovie);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
            request.Method = "GET";
            request.Accept = "text/html";

            var responseStream = request
                .GetResponse()
                .GetResponseStream();

            var document = new HtmlDocument();
            document.Load(responseStream, Encoding.UTF8);
            return document.DocumentNode.SelectNodes(predicateMovieNode);
        }
    }
}
