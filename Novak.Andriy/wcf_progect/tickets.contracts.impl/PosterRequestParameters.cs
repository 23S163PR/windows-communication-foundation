using System.Runtime.Serialization;

namespace tickets.contracts.impl
{
    [DataContract(Namespace = "http://TicketService/v1")]
    public class PosterRequestParameters : IPosterRequestParameters
    {
    }
}
