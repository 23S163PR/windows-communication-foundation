using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.Contracts
{
    [DataContract(Namespace = "http://itstep.org/BiletikiService/V1")]
    public class Affiche
    {
        [DataMember]
        public ReadOnlyCollection<Movie> Movies { get; set; }
        [DataMember]
        public int PagesCount { get; set; }
    }
}
