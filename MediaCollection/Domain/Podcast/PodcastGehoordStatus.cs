using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Podcast
{
    public class PodcastGehoordStatus
    {
        public int PodcastId { get; set; }
        public string UserId { get; set; }
        public int GehoordStatus { get; set; }
    }
}
