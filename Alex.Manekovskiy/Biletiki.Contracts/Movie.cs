using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Biletiki.Contracts
{
    [DataContract]
    public class Movie
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public float? IMDBRating { get; set; }
        [DataMember]
        public int DurationInMinutes { get; set; }
        [DataMember]
        public ReadOnlyCollection<string> Directors { get; set; }
        [DataMember]
        public ReadOnlyCollection<string> Writers { get; set; }
        [DataMember]
        public ReadOnlyCollection<string> Stars { get; set; }
        [DataMember]
        public ReadOnlyCollection<string> Genres { get; set; }
        [DataMember]
        public DateTime ShowingFrom { get; set; }
        [DataMember]
        public DateTime ShowingTo { get; set; }
    }
}
