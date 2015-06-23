using System;
using System.Collections.Generic;
using System.Linq;
using cinema_data_model;

namespace wcf_cinema_service
{
    public class CinemaService : ICinemaService
    {
        public List<List<Shows>> ViewAviableTickkets(int ticketCountInPage)
        {
            return Paging(ticketCountInPage, new List<Shows>());
        }

        private List<List<T>> Paging<T>(int fieldsInPage, IReadOnlyCollection<T> aviableShowses)
        {
            var pages = (aviableShowses.Count % fieldsInPage == 0 ? 0 : 1) + (aviableShowses.Count / fieldsInPage);
            var pageList = new List<List<T>>();
            var page = 1;
            var take = aviableShowses.Take(fieldsInPage);
            while (page++ <= pages)
            {
                var fieldsPage = new List<T>();
                fieldsPage.AddRange(take);
                pageList.Add(fieldsPage);
                take = aviableShowses.Skip(fieldsInPage * (page - 1)).Take(fieldsInPage);
            }
            return pageList;
        }
    }
}
