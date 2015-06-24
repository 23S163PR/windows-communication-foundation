using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.Contracts
{
    [ServiceContract(Namespace = "http://itstep.org/BiletikiService/V1")]
    public interface IBiletikiService
    {
        [OperationContract]
        IAffiche GetAffiche(IAfficheRequestParameters parameters);
    }
}
