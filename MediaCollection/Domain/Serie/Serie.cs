using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Serie
{
    public class Serie
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public byte[] Foto { get; set; }
        public ICollection<SerieGenre> SerieGenres { get; set; }
        public ICollection<SerieAflevering> SerieAfleveringen { get; set; }
        public ICollection<SerieBekekenStatus> SerieBekekenStatuses { get; set; }
        public ICollection<SerieFavorite> SerieFavorites { get; set; }
        public ICollection<SerieRegisseur> SerieRegisseurs { get; set; }
        public ICollection<SerieReview> SerieReviews { get; set; }
    }
}
