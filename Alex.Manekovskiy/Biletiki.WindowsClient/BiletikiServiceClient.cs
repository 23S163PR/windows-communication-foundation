using Biletiki.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.WindowsClient
{
    [ServiceContract(Namespace = "http://itstep.org/BiletikiService/V1", Name = "IBiletikiService")]
    public interface IBiletikiServiceProxy
    {
        [OperationContract]
        Affiche GetAffiche(AfficheRequestParameters parameters);

        [OperationContract]
        Task<Affiche> GetAfficheAsync(AfficheRequestParameters parameters);
    }

    public class BiletikiServiceClient : ClientBase<IBiletikiServiceProxy>, IBiletikiServiceProxy
    {
        public BiletikiServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public Affiche GetAffiche(AfficheRequestParameters parameters)
        {
            return this.Channel.GetAffiche(parameters);
        }

        public Task<Affiche> GetAfficheAsync(AfficheRequestParameters parameters)
        {
            return this.Channel.GetAfficheAsync(parameters);
        }
    }
}
