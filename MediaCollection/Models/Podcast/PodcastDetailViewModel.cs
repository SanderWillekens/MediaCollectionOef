using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Models.Podcast
{
    public class PodcastDetailViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Host { get; set; }
        public List<PodcastAfleveringListViewModel> Afleveringen { get; set; }
    }
}
