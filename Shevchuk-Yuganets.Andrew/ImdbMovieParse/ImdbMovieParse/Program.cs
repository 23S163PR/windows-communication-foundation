using System;
using System.Net;
using HtmlAgilityPack;

namespace ImdbMovieParse
{
	class Program
	{
		private const string MovieListURL = "http://www.imdb.com/movies-in-theaters/?ref_=nv_mv_inth_1";

		private const string xPathForMovieName = "//*[@id='main']/div/div[2]/div/table/tbody/tr/td/h4/a";
		private const string xPathForMovieDuration = "//*[@id='main']/div/div[2]/div/table/tbody/tr/td/p/time";
		private const string xPathForMovieGenre = "//*[@id='main']/div/div[2]/div/table/tbody/tr/td/p/span";
		private const string xPathForMovieDescription = "//*[@id='main']/div/div[2]/div/table/tbody/tr/td/div[@class='outline']";
		private const string xPathForMovieDirector = "//*[@id='main']/div/div[2]/div/table/tbody/tr/td/div/span/span/a";
		private const string xPathForMovieActors = "//*[@id='main']/div/div[2]/div/table/tbody/tr/td/div[@class='txt-block']/span/span/a"; 

		static void Main(string[] args)
		{
			var request = (HttpWebRequest)WebRequest.Create(MovieListURL);
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
			request.Method = "GET";
			request.Accept = "text/html";

			var responseStream = request
				.GetResponse()
				.GetResponseStream();

			var document = new HtmlDocument();
			document.Load(responseStream);

			var colection = document.DocumentNode.SelectNodes(xPathForMovieName);

			foreach (var info in colection)
			{
				Console.WriteLine(info.InnerHtml);
			}

		}
	}
}
