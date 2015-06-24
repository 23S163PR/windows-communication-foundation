using System.Runtime.Serialization;

namespace tickets.contracts.impl
{
    [KnownType(typeof(Poster))]
    [KnownType(typeof(PosterRequestParameters))]
    public class TicketService : ITicketService
    {
        public IPoster GetPoster(IPosterRequestParameters requestParameters)
        {
            return new Poster();
        }
    }
}
