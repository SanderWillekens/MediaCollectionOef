using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Domain.Muziek
{
    public class Nummer
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Speeltijd { get; set; }
        public ICollection<NummerAfspeellijst> NummerAfspeellijsten { get; set; }
        public ICollection<NummerAlbum> NummerAlbums { get; set; }
        public ICollection<NummerArtiest> NummerArtiests { get; set; }
        public ICollection<NummerGenre> NummerGenres { get; set; }
        public ICollection<NummerFavorite> NummerFavorites { get; set; }
        public ICollection<NummerGeluisterdStatus> NummerGeluisterdStatuses { get; set; }
        public ICollection<NummerReview> NummerReviews { get; set; }
        
    }
}
