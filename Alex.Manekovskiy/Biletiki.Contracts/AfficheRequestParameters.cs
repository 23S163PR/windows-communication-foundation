using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.Contracts
{
    [DataContract(Namespace = "http://itstep.org/BiletikiService/V1")]
    public class AfficheRequestParameters
    {
        [DataMember]
        public PagingInfo PagingInfo { get; set; }
    }
}
