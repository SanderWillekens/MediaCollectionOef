using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Podcast
{
    public class PodcastAfspeellijst
    {
        public int PodcastId { get; set; }
        public string UserId { get; set; }
        public int AfspeellijstId { get; set; }
    }
}
