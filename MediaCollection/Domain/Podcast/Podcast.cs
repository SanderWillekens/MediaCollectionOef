using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Podcast
{
    public class Podcast
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Host { get; set; }
        public ICollection<PodcastAuteur> PodcastAuteurs { get; set; }
        public ICollection<PodcastAflevering> PodcastAfleveringen { get; set; }
        public ICollection<PodcastAfspeellijst> PodcastAfspeellijsten { get; set; }
        public ICollection<PodcastFavorite> PodcastFavorites { get; set; }
        public ICollection<PodcastGehoordStatus> PodcastGehoordStatuses { get; set; }
        public ICollection<PodcastReview> Reviews { get; set; }
    }
}
