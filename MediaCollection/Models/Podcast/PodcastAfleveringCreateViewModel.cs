using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Podcast
{
    public class PodcastAfleveringCreateViewModel
    {
        public int PodcastId { get; set; }
        public string Guests { get; set; }
        public string Titel { get; set; }
    }
}
