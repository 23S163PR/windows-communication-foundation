using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
     public class Show
    {
         public string Title { get; set; }

         public string CinemaHall { get; set; }

         public List<PerfomanceDays> PerfomanceDayses { get; set; }

         public ShowDescription Description { get; set; }
    }
}
