using System.ServiceModel;

namespace tickets.contracts
{
    [ServiceContract(Namespace = "http://TicketService/v1")]
    public interface ITicketService
    {
        [OperationContract]
        IPoster GetPoster(IPosterRequestParameters requestParameters);
    }
}
