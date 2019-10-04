using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Podcast
{
    public class PodcastAflevering
    {
        public int Id { get; set; }
        public int PodcastId { get; set; }
        public string Guests { get; set; }
        public string Titel { get; set; }
        
    }
}
