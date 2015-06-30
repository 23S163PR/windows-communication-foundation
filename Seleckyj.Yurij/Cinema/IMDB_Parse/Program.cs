using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            ListMovie list = new ListMovie();
            var a = list.GetThisWeekMovies();
            Console.WriteLine(a[0].Scenery);
            Console.ReadLine();
        }
    }
}


