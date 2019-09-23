using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Podcast
{
    public class PodcastReview
    {
        public int PodcastAfleveringId { get; set; }
        public string UserId { get; set; }
        public string Titel { get; set; }
        public int Score { get; set; }
        public string Review { get; set; }
    }
}
