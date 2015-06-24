using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biletiki.Contracts.Impl
{
    [KnownType(typeof(Affiche))]
    [KnownType(typeof(AfficheRequestParameters))]
    public class BiletikiService : IBiletikiService
    {
        public IAffiche GetAffiche(IAfficheRequestParameters parameters)
        {
            return new Affiche();
        }
    }
}
